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
    ''' Turns one level's map rows into a board, centred and surrounded by BlankOuter. Returns
    ''' Nothing when the level does not fit a BoardWidth x BoardHeight grid, holds a character that
    ''' is not part of a map, or does not have exactly one player - so that a set never holds a
    ''' level that cannot be played.
    ''' </remarks>
    Public Function ParseLevel(levelText As String) As BoardItem()
        Dim Rows As New List(Of String)
        For Each Line As String In SplitIntoLines(levelText)
            Dim Row As String = Line.Replace("-"c, " "c).Replace("_"c, " "c).TrimEnd()
            If Row.Length > 0 Then
                Rows.Add(Row)
            End If
        Next

        Dim WidestRow As Integer = 0
        For Each Row As String In Rows
            WidestRow = Math.Max(WidestRow, Row.Length)
        Next

        If Rows.Count < 1 OrElse Rows.Count > BoardHeight OrElse WidestRow > BoardWidth Then
            Return Nothing
        End If

        Dim ShiftRight As Integer = CInt(Math.Round((BoardWidth - CDbl(WidestRow)) / 2))
        Dim ShiftDown As Integer = CInt(Math.Round((BoardHeight - CDbl(Rows.Count)) / 2))

        Dim Cells(BoardCellCount) As BoardItem
        For Index As Integer = BoardFirstIndex To BoardCellCount
            Cells(Index) = BoardItem.BlankOuter
        Next

        Dim Players As Integer = 0
        For RowNumber As Integer = 0 To Rows.Count - 1
            Dim Row As String = Rows(RowNumber)

            ' Spaces before a row's first wall lie outside the level, not on its floor.
            Dim LeadingSpaces As Integer = Row.Length - Row.TrimStart(" "c).Length

            For Column As Integer = LeadingSpaces To Row.Length - 1
                Dim Item As BoardItem
                If Not TryReadMapCharacter(Row(Column), Item) Then
                    Return Nothing
                End If

                If Item = BoardItem.Player OrElse Item = BoardItem.PlayerOnPlace Then
                    Players += 1
                End If

                Cells(New Cell(ShiftDown + RowNumber, ShiftRight + Column).Index) = Item
            Next
        Next

        If Players <> 1 Then
            Return Nothing
        End If

        Return Cells
    End Function
End Module
