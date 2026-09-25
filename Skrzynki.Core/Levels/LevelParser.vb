''' <remarks>
''' Reads levelsets in the two formats the game opens:
'''
''' SOK notation, the common Sokoban format: a sequence of level maps, where anything between them
''' that is not a map row - a title, a comment, a level number, a blank line - separates one level
''' from the next and is otherwise ignored.
'''
''' The game's own *.box format: the number of levels on the first line, then each level as a line
''' holding a single * followed by its rows, one character per square - ' for outside the level
''' and the digit of the BoardItem for everything else. Each .box level is turned into SOK rows, so
''' both formats go through the same checks and the same layout.
''' </remarks>
Friend NotInheritable Class LevelParser
    Private Sub New()
    End Sub

    ''' <remarks>
    ''' Splits text into lines on any line ending - CRLF, LF or CR alone - so that level files
    ''' written on Windows, Unix-like systems or classic Mac all load.
    ''' </remarks>
    Private Shared Function SplitIntoLines(text As String) As String()
        Return text.Split(New String() {vbCrLf, vbLf, vbCr}, StringSplitOptions.None)
    End Function

    ' --- SOK -----------------------------------------------------------------------------------

    ''' <remarks>
    ''' Whether a line belongs to a level map: it holds nothing but map characters, and at least one
    ''' wall. The wall requirement is what keeps a blank line, or a line of floor, from counting.
    ''' </remarks>
    Private Shared Function IsMapRow(line As String) As Boolean
        If line.IndexOf("#"c) < 0 Then
            Return False
        End If

        For Each Character As Char In line
            If Not IsMapCharacter(Character) Then
                Return False
            End If
        Next

        Return True
    End Function

    ''' <remarks>
    ''' The SOK map characters. Some files write the floor as - or _ instead of a space, so that it
    ''' survives being pasted into mail and forums; those are read as a space.
    ''' </remarks>
    Private Shared Function IsMapCharacter(character As Char) As Boolean
        Dim Item As BoardItem
        Return character = "-"c OrElse character = "_"c OrElse TryReadMapCharacter(character, Item)
    End Function

    Private Shared Function TryReadMapCharacter(character As Char, ByRef item As BoardItem) As Boolean
        Select Case character
            Case " "c
                item = BoardItem.Blank
            Case "#"c
                item = BoardItem.Wall
            Case "$"c
                item = BoardItem.Box
            Case "."c
                item = BoardItem.PlaceForBox
            Case "*"c
                item = BoardItem.BoxOnPlace
            Case "@"c
                item = BoardItem.Player
            Case "+"c
                item = BoardItem.PlayerOnPlace
            Case Else
                Return False
        End Select

        Return True
    End Function

    ''' <remarks>Splits the text of a SOK levelset into one block of map rows per level.</remarks>
    Public Shared Function SplitIntoLevelTexts(levelsetText As String) As List(Of String)
        Dim LevelTexts As New List(Of String)
        Dim CurrentLevel As New System.Text.StringBuilder()

        For Each Line As String In SplitIntoLines(levelsetText)
            If IsMapRow(Line) Then
                CurrentLevel.AppendLine(Line)
            ElseIf CurrentLevel.Length > 0 Then
                LevelTexts.Add(CurrentLevel.ToString())
                CurrentLevel.Clear()
            End If
        Next

        ' A file whose final level is not followed by anything else still yields that level.
        If CurrentLevel.Length > 0 Then
            LevelTexts.Add(CurrentLevel.ToString())
        End If

        Return LevelTexts
    End Function

    ' --- .box ----------------------------------------------------------------------------------

    ''' <remarks>
    ''' Whether text is in the .box format: a level count alone on the first line, and at least one
    ''' line holding nothing but the * that opens a level. SOK text never starts with a number.
    ''' </remarks>
    Public Shared Function IsBoxFormat(levelsetText As String) As Boolean
        Dim Lines() As String = SplitIntoLines(levelsetText)
        Dim Count As Integer

        Return Lines.Length > 1 AndAlso
               Integer.TryParse(Lines(0).Trim(),
                                Globalization.NumberStyles.None,
                                Globalization.CultureInfo.InvariantCulture,
                                Count) AndAlso
               Array.Exists(Lines, Function(line) line.Trim() = "*")
    End Function

    ''' <remarks>
    ''' Splits a .box levelset into one block of SOK rows per level. The level count on the first
    ''' line is not relied on: the levels are whatever follows each * line.
    ''' </remarks>
    Public Shared Function SplitBoxLevelTexts(levelsetText As String) As List(Of String)
        Dim LevelTexts As New List(Of String)
        Dim CurrentLevel As List(Of String) = Nothing
        Dim Lines() As String = SplitIntoLines(levelsetText)

        For LineNumber As Integer = 1 To Lines.Length - 1
            Dim Line As String = Lines(LineNumber)

            If Line.Trim() = "*" Then
                If CurrentLevel IsNot Nothing Then
                    LevelTexts.Add(JoinWithoutMargin(CurrentLevel))
                End If
                CurrentLevel = New List(Of String)
            ElseIf CurrentLevel IsNot Nothing Then
                CurrentLevel.Add(BoxRowToSok(Line).TrimEnd())
            End If
        Next

        If CurrentLevel IsNot Nothing Then
            LevelTexts.Add(JoinWithoutMargin(CurrentLevel))
        End If

        Return LevelTexts
    End Function

    ''' <remarks>
    ''' A .box level is stored already placed on its grid, so every row carries the margin to the
    ''' left of the level. That margin is taken off - the columns of outside squares that all rows
    ''' share - so the rows arrive as a SOK level would, and are centred the same way.
    ''' </remarks>
    Private Shared Function JoinWithoutMargin(rows As List(Of String)) As String
        Dim Margin As Integer = Integer.MaxValue
        For Each Row As String In rows
            If Row.Length > 0 Then
                Margin = Math.Min(Margin, Row.Length - Row.TrimStart(" "c).Length)
            End If
        Next

        Dim Joined As New System.Text.StringBuilder()
        For Each Row As String In rows
            If Row.Length > 0 Then
                Joined.AppendLine(Row.Substring(Margin))
            End If
        Next

        Return Joined.ToString()
    End Function

    ''' <remarks>
    ''' One .box row as a SOK row. Outside squares become spaces, which the layout treats as outside
    ''' when they lead a row and drops when they trail it. Anything unrecognised is kept as it is,
    ''' so that ReadLevelRows rejects the level.
    ''' </remarks>
    Private Shared Function BoxRowToSok(row As String) As String
        Const SokCharacters As String = " #$.*@+ "
        Dim Converted As New System.Text.StringBuilder(row.Length)

        For Each Character As Char In row
            Dim Digit As Integer = AscW(Character) - AscW("0"c)
            If Character = "'"c Then
                Converted.Append(" "c)
            ElseIf Digit >= 0 AndAlso Digit < SokCharacters.Length Then
                Converted.Append(SokCharacters(Digit))
            Else
                Converted.Append(Character)
            End If
        Next

        Return Converted.ToString()
    End Function

    ' --- From rows to a board ------------------------------------------------------------------

    ''' <remarks>
    ''' Reads one level's map rows, with the floor written as spaces and trailing spaces dropped.
    ''' Returns Nothing when the level is empty, holds a character that is not part of a map, or
    ''' does not have exactly one player - so that a set never holds a level that cannot be played.
    ''' </remarks>
    Public Shared Function ReadLevelRows(levelText As String) As List(Of String)
        Dim Rows As New List(Of String)
        Dim Players As Integer = 0

        For Each Line As String In SplitIntoLines(levelText)
            Dim Row As String = Line.Replace("-"c, " "c).Replace("_"c, " "c).TrimEnd()
            If Row.Length = 0 Then
                Continue For
            End If

            For Each Character As Char In Row
                Dim Item As BoardItem
                If Not TryReadMapCharacter(Character, Item) Then
                    Return Nothing
                End If

                If Item.HoldsPlayer() Then
                    Players += 1
                End If
            Next

            Rows.Add(Row)
        Next

        If Rows.Count = 0 OrElse Players <> 1 Then
            Return Nothing
        End If

        Return Rows
    End Function

    ''' <remarks>The side of the smallest square board the level fits on.</remarks>
    Public Shared Function LevelExtent(rows As IList(Of String)) As Integer
        Dim Extent As Integer = rows.Count
        For Each Row As String In rows
            Extent = Math.Max(Extent, Row.Length)
        Next
        Return Extent
    End Function

    ''' <remarks>
    ''' Lays out a level's rows, as read by ReadLevelRows, on a board of the given size: centred,
    ''' and surrounded by BlankOuter. The board must be at least LevelExtent on a side.
    ''' </remarks>
    Public Shared Function LayOutLevel(rows As IList(Of String), boardSize As Integer) As Board
        Dim WidestRow As Integer = 0
        For Each Row As String In rows
            WidestRow = Math.Max(WidestRow, Row.Length)
        Next

        Dim ShiftRight As Integer = CInt(Math.Round((boardSize - CDbl(WidestRow)) / 2))
        Dim ShiftDown As Integer = CInt(Math.Round((boardSize - CDbl(rows.Count)) / 2))

        Dim Laid As New Board(boardSize)

        For RowNumber As Integer = 0 To rows.Count - 1
            Dim Row As String = rows(RowNumber)

            ' Spaces before a row's first wall lie outside the level, not on its floor.
            Dim LeadingSpaces As Integer = Row.Length - Row.TrimStart(" "c).Length

            For Column As Integer = LeadingSpaces To Row.Length - 1
                Dim Item As BoardItem
                TryReadMapCharacter(Row(Column), Item)
                Laid(New Cell(ShiftDown + RowNumber, ShiftRight + Column)) = Item
            Next
        Next

        Return Laid
    End Function
End Class
