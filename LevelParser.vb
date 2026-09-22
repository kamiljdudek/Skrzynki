Module LevelParser
    ''' <remarks>
    ''' Key under which a levelset opened from a file is registered in Levelsets. It is separate
    ''' from the two built-in sets so that loading a file never disturbs their saved progress.
    ''' </remarks>
    Public Const CustomLevelsetName As String = "Custom"

    ' The character the SOK map is padded with: BoardItem.BlankOuter (7) written as text. The
    ' digits used here have to stay in step with the BoardItem enum.
    Private Const BlankOuterCharacter As Char = "7"c

    Public Function PullAllLevels(ByVal inputStream As String, ByVal FileMode As Boolean) As ArrayList
        Dim LevelsRead As New ArrayList
        Dim ItemToAdd As String = Nothing

        Dim ReadContent As String = Nothing
        Dim Content() As String

        ' If this is a file, convert it to string
        If FileMode = True Then
            Dim BufferedReader As System.IO.StreamReader =
                My.Computer.FileSystem.OpenTextFileReader(inputStream, System.Text.Encoding.ASCII)
            With BufferedReader
                ReadContent = .ReadToEnd
            End With
            Content = Split(ReadContent, Environment.NewLine)
        Else
            Content = Split(inputStream, Environment.NewLine)
        End If

        ' A blank (or single character) line closes the current level. Blocks holding no rows at
        ' all are dropped: without that, the trailing newlines at the end of a level file produce
        ' a phantom empty level, which is what made the XS set report 61 levels instead of 60.
        For Each SingleLine As String In Content
            If IsNothing(SingleLine) OrElse SingleLine.Length <= 1 Then
                If Not String.IsNullOrEmpty(ItemToAdd) Then
                    LevelsRead.Add(ItemToAdd)
                End If
                ItemToAdd = Nothing
            Else
                ItemToAdd += SingleLine & vbCrLf
            End If
        Next

        ' A file whose final level is not followed by a blank line still yields that level.
        If Not String.IsNullOrEmpty(ItemToAdd) Then
            LevelsRead.Add(ItemToAdd)
        End If

        Return LevelsRead
    End Function

    ''' <remarks>
    ''' Turns one level of SOK text into exactly BoardHeight rows of BoardWidth characters,
    ''' centred on the board and padded with BlankOuterCharacter. Returns Nothing when the level
    ''' cannot be represented on a BoardWidth x BoardHeight grid.
    ''' </remarks>
    Public Function GetMapStringFromLevel(ByRef lv As String) As String()
        Dim Content() As String = Split(lv, Environment.NewLine)
        Dim OutputLevelMap(BoardHeight - 1) As String
        Dim OuterRow As String = New String(BlankOuterCharacter, BoardWidth)

        ' The row count has to ignore the trailing empty entries left by the newline terminating
        ' the last row. Counting those made every level sit up to half a row too high.
        Dim RowCount As Integer = Content.Length
        While RowCount > 0 AndAlso String.IsNullOrEmpty(Content(RowCount - 1))
            RowCount -= 1
        End While

        Dim WidestRow As Integer = 0
        For j = 0 To RowCount - 1
            If Content(j).Length > WidestRow Then
                WidestRow = Content(j).Length
            End If
        Next

        ' Guard the whole layout rather than only its horizontal half: a level taller than the
        ' board used to run off the end of OutputLevelMap or start a loop at a negative index.
        If RowCount < 1 OrElse RowCount > BoardHeight OrElse WidestRow > BoardWidth Then
            Return Nothing
        End If

        Dim MoveLeft As Integer = CInt(Math.Round((BoardWidth - CDbl(WidestRow)) / 2))
        For j = 0 To RowCount - 1
            Dim LeadingSpaces As Integer =
                System.Text.RegularExpressions.Regex.Match(Content(j), "^ *").Value.Length
            Content(j) = New String(BlankOuterCharacter, MoveLeft + LeadingSpaces) &
                Content(j).Substring(LeadingSpaces)
            Content(j) = Content(j) & New String(BlankOuterCharacter, BoardWidth - Content(j).Length)
        Next

        Dim MoveDown As Integer = CInt(Math.Round((BoardHeight - CDbl(RowCount)) / 2))
        For j = 0 To MoveDown - 1
            OutputLevelMap(j) = OuterRow
        Next
        For j = MoveDown To MoveDown + RowCount - 1
            OutputLevelMap(j) = Content(j - MoveDown)
        Next
        For j = MoveDown + RowCount To BoardHeight - 1
            OutputLevelMap(j) = OuterRow
        Next

        For j = 0 To BoardHeight - 1
            OutputLevelMap(j) = OutputLevelMap(j).Replace(" ", "0")
            OutputLevelMap(j) = OutputLevelMap(j).Replace("#", "1")
            OutputLevelMap(j) = OutputLevelMap(j).Replace("$", "2")
            OutputLevelMap(j) = OutputLevelMap(j).Replace(".", "3")
            OutputLevelMap(j) = OutputLevelMap(j).Replace("*", "4")
            OutputLevelMap(j) = OutputLevelMap(j).Replace("@", "5")
            OutputLevelMap(j) = OutputLevelMap(j).Replace("+", "6")
        Next

        Return OutputLevelMap
    End Function

    Public Function GetBoardStateIntegerFromMapString(ByRef ms As String()) As Integer()
        If IsNothing(ms) Then
            Return Nothing
        End If

        ' See the board indexing convention in 倉庫番.vb: cells live at BoardFirstIndex through
        ' BoardCellCount, so filling has to start at BoardFirstIndex rather than at 0.
        Dim LegacyLevelArrayCounter As Integer = BoardFirstIndex
        Dim OutputStringLegacyFormat(BoardCellCount) As Integer
        For j = 0 To BoardHeight - 1
            Dim charArray() As Char = ms(j).ToCharArray
            For Each character As Char In charArray
                OutputStringLegacyFormat(LegacyLevelArrayCounter) = Val(character)
                LegacyLevelArrayCounter += 1
            Next
        Next

        Return OutputStringLegacyFormat
    End Function

    Public Levelsets As New System.Collections.Hashtable

    Public Function GetLevelset(ByVal SetName As String) As Levelset
        Return CType(LevelParser.Levelsets.Item(SetName), Levelset)
    End Function

    Public Sub LoadAllLevelsets()
        If Levelsets.Count > 0 Then
            Exit Sub
        End If

        Dim Classic As New Levelset(SokobanLevelSet.Classic.ToString())
        Dim XS As New Levelset(SokobanLevelSet.XS.ToString())

        Classic.AddAllLevels(PullAllLevels(My.Resources.LevelsetResource.Classic_SOK, False))
        XS.AddAllLevels(PullAllLevels(My.Resources.LevelsetResource.XS_SOK, False))

        'TODO: load stats @ constructor
        ' Todo: further work on generalizing the levelset support
        Classic.AchievedLevel = My.Settings.ArrivedLevelKlasyczne
        Classic.Moves = My.Settings.MovesKlasyczne
        Classic.Pushes = My.Settings.PushesKlasyczne

        XS.AchievedLevel = My.Settings.ArrivedLevelSupertrudne
        XS.Moves = My.Settings.MovesSupertrudne
        XS.Pushes = My.Settings.PushesSupertrudne

        Levelsets.Add("Classic", Classic)
        Levelsets.Add("XS", XS)
    End Sub

    Public Enum SokobanLevelSet
        Classic
        XS
        SasquatchOne
        SasquatchTwo
        CustomFromFile
    End Enum

End Module
