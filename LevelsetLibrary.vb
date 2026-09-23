''' <remarks>
''' The levelsets the game knows about, keyed by name. The two built-in sets are parsed from
''' embedded resources on first use; a set opened from a file is registered under
''' CustomLevelsetName so that loading a file never disturbs the built-in sets or their progress.
''' </remarks>
Module LevelsetLibrary
    Public Const CustomLevelsetName As String = "Custom"

    Public ReadOnly Levelsets As New Dictionary(Of String, Levelset)(StringComparer.Ordinal)

    Public Function GetLevelset(levelsetName As String) As Levelset
        Dim Found As Levelset = Nothing
        If levelsetName IsNot Nothing AndAlso Levelsets.TryGetValue(levelsetName, Found) Then
            Return Found
        End If

        Return Nothing
    End Function

    Public Sub LoadAllLevelsets()
        If Levelsets.Count > 0 Then
            Exit Sub
        End If

        Dim Classic As New Levelset(ProgressStore.ClassicLevelsetName)
        Dim ExtraDifficult As New Levelset(ProgressStore.ExtraDifficultLevelsetName)

        Classic.AddAllLevels(SplitIntoLevelTexts(My.Resources.LevelsetResource.Classic_SOK, False))
        ExtraDifficult.AddAllLevels(SplitIntoLevelTexts(My.Resources.LevelsetResource.XS_SOK, False))

        ' Progress and statistics are not copied onto the Levelset objects: they live in
        ' My.Settings, keyed per set, and ProgressStore is the only thing that touches them.
        Levelsets.Add(ProgressStore.ClassicLevelsetName, Classic)
        Levelsets.Add(ProgressStore.ExtraDifficultLevelsetName, ExtraDifficult)
    End Sub
End Module