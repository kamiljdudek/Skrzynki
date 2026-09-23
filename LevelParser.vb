Module LevelParser
    ' The character the SOK map is padded with: BoardItem.BlankOuter (7) written as text. The
    ' digits used here have to stay in step with the BoardItem enum.
    Private Const BlankOuterCharacter As Char = "7"c

    ''' <remarks>
    ''' Splits level text into lines on any line ending - CRLF, LF or CR alone - so that level
    ''' files written on Windows, Unix-like systems or classic Mac all load.
    ''' </remarks>
    Private Function SplitIntoLines(text As String) As String()
        Return text.Split(New String() {vbCrLf, vbLf, vbCr}, StringSplitOptions.None)
    End Function

    ''' <remarks>
    ''' Splits a levelset - either the text itself or the contents of a file - into one block of
    ''' SOK text per level.
    ''' </remarks>
    Public Function SplitIntoLevelTexts(levelsetSource As String, sourceIsFilePath As Boolean) As List(Of String)
        Dim LevelTexts As New List(Of String)
        Dim CurrentLevel As String = Nothing
        Dim Lines() As String

        If sourceIsFilePath Then
            Lines = SplitIntoLines(System.IO.File.ReadAllText(levelsetSource, System.Text.Encoding.ASCII))
        Else
            Lines = SplitIntoLines(levelsetSource)
        End If

        ' A blank (or single character) line closes the current level. Blocks holding no rows are
        ' dropped, so trailing newlines at the end of a file cannot yield an empty level.
        For Each Line As String In Lines
            If Line Is Nothing OrElse Line.Length <= 1 Then
                If Not String.IsNullOrEmpty(CurrentLevel) Then
                    LevelTexts.Add(CurrentLevel)
                End If
                CurrentLevel = Nothing
            Else
                CurrentLevel += Line & vbCrLf
            End If
        Next

        ' A file whose final level is not followed by a blank line still yields that level.
        If Not String.IsNullOrEmpty(CurrentLevel) Then
            LevelTexts.Add(CurrentLevel)
        End If

        Return LevelTexts
    End Function

    ''' <remarks>
    ''' Turns one level of SOK text into exactly BoardHeight rows of BoardWidth characters,
    ''' centred on the board and padded with BlankOuterCharacter. Returns Nothing when the level
    ''' cannot be represented on a BoardWidth x BoardHeight grid.
    ''' </remarks>
    Public Function BuildLevelMap(levelText As String) As String()
        Dim Rows() As String = SplitIntoLines(levelText)
        Dim LevelMap(BoardHeight - 1) As String
        Dim OuterRow As String = New String(BlankOuterCharacter, BoardWidth)

        ' The row count ignores the trailing empty entries left by the newline that terminates the
        ' last row, so that the level is centred on its actual height.
        Dim RowCount As Integer = Rows.Length
        While RowCount > 0 AndAlso String.IsNullOrEmpty(Rows(RowCount - 1))
            RowCount -= 1
        End While

        Dim WidestRow As Integer = 0
        For Row As Integer = 0 To RowCount - 1
            If Rows(Row).Length > WidestRow Then
                WidestRow = Rows(Row).Length
            End If
        Next

        ' Both dimensions are checked: a level larger than the board in either direction cannot be
        ' laid out and is rejected here.
        If RowCount < 1 OrElse RowCount > BoardHeight OrElse WidestRow > BoardWidth Then
            Return Nothing
        End If

        Dim ShiftRight As Integer = CInt(Math.Round((BoardWidth - CDbl(WidestRow)) / 2))
        For Row As Integer = 0 To RowCount - 1
            Dim LeadingSpaces As Integer =
                System.Text.RegularExpressions.Regex.Match(Rows(Row), "^ *").Value.Length
            Rows(Row) = New String(BlankOuterCharacter, ShiftRight + LeadingSpaces) &
                Rows(Row).Substring(LeadingSpaces)
            Rows(Row) = Rows(Row) & New String(BlankOuterCharacter, BoardWidth - Rows(Row).Length)
        Next

        Dim ShiftDown As Integer = CInt(Math.Round((BoardHeight - CDbl(RowCount)) / 2))
        For Row As Integer = 0 To ShiftDown - 1
            LevelMap(Row) = OuterRow
        Next
        For Row As Integer = ShiftDown To ShiftDown + RowCount - 1
            LevelMap(Row) = Rows(Row - ShiftDown)
        Next
        For Row As Integer = ShiftDown + RowCount To BoardHeight - 1
            LevelMap(Row) = OuterRow
        Next

        For Row As Integer = 0 To BoardHeight - 1
            LevelMap(Row) = LevelMap(Row).Replace(" ", "0")
            LevelMap(Row) = LevelMap(Row).Replace("#", "1")
            LevelMap(Row) = LevelMap(Row).Replace("$", "2")
            LevelMap(Row) = LevelMap(Row).Replace(".", "3")
            LevelMap(Row) = LevelMap(Row).Replace("*", "4")
            LevelMap(Row) = LevelMap(Row).Replace("@", "5")
            LevelMap(Row) = LevelMap(Row).Replace("+", "6")
        Next

        Return LevelMap
    End Function

    ''' <remarks>Turns the rows of a level map into the flat board array the game plays on.</remarks>
    Public Function BuildBoardState(levelMap As String()) As Integer()
        If levelMap Is Nothing Then
            Return Nothing
        End If

        ' See the board indexing convention in 倉庫番.vb: cells live at BoardFirstIndex through
        ' BoardCellCount, so filling starts at BoardFirstIndex.
        Dim CellIndex As Integer = BoardFirstIndex
        Dim BoardState(BoardCellCount) As Integer

        For Row As Integer = 0 To BoardHeight - 1
            For Each MapCharacter As Char In levelMap(Row)
                ' Each map character is a single digit naming a BoardItem.
                BoardState(CellIndex) = CInt(Char.GetNumericValue(MapCharacter))
                CellIndex += 1
            Next
        Next

        Return BoardState
    End Function

End Module
