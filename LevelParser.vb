''' <remarks>
''' Reads levels written in SOK notation. A levelset is a sequence of level maps; anything between
''' them that is not a map row - a title, a comment, a level number, a blank line - separates one
''' level from the next and is otherwise ignored.
''' </remarks>
Module LevelParser
    ''' <remarks>
    ''' Splits text into lines on any line ending - CRLF, LF or CR alone - so that level files
    ''' written on Windows, Unix-like systems or classic Mac all load.
    ''' </remarks>
    Private Function SplitIntoLines(text As String) As String()
        Return text.Split(New String() {vbCrLf, vbLf, vbCr}, StringSplitOptions.None)
    End Function

    ''' <remarks>
    ''' Whether a line belongs to a level map: it holds nothing but map characters, and at least one
    ''' wall. The wall requirement is what keeps a blank line, or a line of floor, from counting.
    ''' </remarks>
    Private Function IsMapRow(line As String) As Boolean
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
    Private Function IsMapCharacter(character As Char) As Boolean
        Dim Item As BoardItem
        Return character = "-"c OrElse character = "_"c OrElse TryReadMapCharacter(character, Item)
    End Function

    Private Function TryReadMapCharacter(character As Char, ByRef item As BoardItem) As Boolean
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

    ''' <remarks>Splits the text of a levelset into one block of map rows per level.</remarks>
    Public Function SplitIntoLevelTexts(levelsetText As String) As List(Of String)
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

    ''' <remarks>
    ''' Reads one level's map rows, with the floor written as spaces and trailing spaces dropped.
    ''' Returns Nothing when the level is empty, holds a character that is not part of a map, or
    ''' does not have exactly one player - so that a set never holds a level that cannot be played.
    ''' </remarks>
    Public Function ReadLevelRows(levelText As String) As List(Of String)
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

                If Item = BoardItem.Player OrElse Item = BoardItem.PlayerOnPlace Then
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
    Public Function LevelExtent(rows As IList(Of String)) As Integer
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
    Public Function LayOutLevel(rows As IList(Of String), boardSize As Integer) As BoardItem()
        Dim WidestRow As Integer = 0
        For Each Row As String In rows
            WidestRow = Math.Max(WidestRow, Row.Length)
        Next

        Dim ShiftRight As Integer = CInt(Math.Round((boardSize - CDbl(WidestRow)) / 2))
        Dim ShiftDown As Integer = CInt(Math.Round((boardSize - CDbl(rows.Count)) / 2))

        Dim Cells() As BoardItem = EmptyBoard(boardSize)

        For RowNumber As Integer = 0 To rows.Count - 1
            Dim Row As String = rows(RowNumber)

            ' Spaces before a row's first wall lie outside the level, not on its floor.
            Dim LeadingSpaces As Integer = Row.Length - Row.TrimStart(" "c).Length

            For Column As Integer = LeadingSpaces To Row.Length - 1
                Dim Item As BoardItem
                TryReadMapCharacter(Row(Column), Item)
                Cells(New Cell(ShiftDown + RowNumber, ShiftRight + Column, boardSize).Index) = Item
            Next
        Next

        Return Cells
    End Function
End Module
