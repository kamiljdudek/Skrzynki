Module LevelParser
    Public Function PullAllLevels(ByVal inputStream As String, ByVal FileMode As Boolean) As ArrayList
        Dim LevelsRead As New ArrayList
        Dim ItemToAdd As String = Nothing

        Dim ReadContent As String = Nothing
        Dim Content() As String

        ' If this is a file, convert it to string
        'string content = new StreamReader(fs, Encoding.Unicode).ReadToEnd();
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

        For Each SingleLine As String In Content
            ItemToAdd += SingleLine.ToString() & vbCrLf
            If Not IsNothing(SingleLine) Then
                If SingleLine.Length <= 1 Then
                    LevelsRead.Add(ItemToAdd)
                    ItemToAdd = Nothing
                End If
            End If
        Next

        Return LevelsRead
    End Function

    Public Function GetMapStringFromLevel(ByRef lv As String) As String()
        Dim Content() As String = Split(lv, Environment.NewLine)
        Dim OutputLevelMap(16) As String

        Dim LongestStringIndex As Integer = 0
        For j = 0 To Content.Length - 1
            If Content(j).Length > Content(LongestStringIndex).Length Then
                LongestStringIndex = j
            End If
        Next

        Dim MoveLeft As Integer = CInt(Math.Round((16 - CDbl(Content(LongestStringIndex).Length)) / 2))

        For j = 0 To Content.Length - 1
            Dim rmatch As System.Text.RegularExpressions.Match = System.Text.RegularExpressions.Regex.Match(Content(j), "^ *")
            Content(j) = System.Text.RegularExpressions.Regex.Replace(Content(j), "^ *", StrDup(rmatch.Value.Length, "7"))
            Content(j) = StrDup(MoveLeft, "7") & Content(j)
            Content(j) = Content(j) & StrDup((16 - Content(j).Length), "7")
        Next

        Dim MoveDown As Integer = CInt(Math.Round((16 - CDbl(Content.Length - 1)) / 2))
        For j = 0 To MoveDown - 1
            OutputLevelMap(j) = StrDup(16, "7")
        Next
        For j = MoveDown To MoveDown + Content.Length - 1 - 1
            OutputLevelMap(j) = Content(j - MoveDown)
        Next
        For j = MoveDown + Content.Length - 1 To 15
            OutputLevelMap(j) = StrDup(16, "7")
        Next

        For j = 0 To 15
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
        Dim LegacyLevelArrayCounter255 As Integer = 0
        Dim OutputStringLegacyFormat(16 * 16) As Integer
        For j = 0 To 15
            Dim charArray() As Char = ms(j).ToCharArray
            For Each character As Char In charArray
                OutputStringLegacyFormat(LegacyLevelArrayCounter255) = Val(character)
                LegacyLevelArrayCounter255 += 1
            Next
        Next

        Return OutputStringLegacyFormat
    End Function

    Public Levelsets As New System.Collections.Hashtable

    Public Sub LoadAllLevelsets()
        Dim Levelset1 = PullAllLevels(My.Resources.LevelsetResource.Classic_SOK, False)
        Dim Levelset2 = PullAllLevels(My.Resources.LevelsetResource.XS_SOK, False)

        Dim Classic As Levelset = New Levelset("Classic")
        Dim XS As Levelset = New Levelset("XS")

        For Each SokobanCompliantLevel As String In Levelset1
            Dim SkrzynkiCompliantLevel = GetMapStringFromLevel(SokobanCompliantLevel)
            Classic.AddLevel(SkrzynkiCompliantLevel)
        Next
        For Each SokobanCompliantLevel As String In Levelset2
            Dim SkrzynkiCompliantLevel = GetMapStringFromLevel(SokobanCompliantLevel)
            XS.AddLevel(SkrzynkiCompliantLevel)
        Next

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
    End Enum

End Module
