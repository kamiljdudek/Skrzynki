''' <remarks>
''' The built-in levelsets, keyed by name and parsed from embedded resources on first use. A set
''' opened from a file is never registered here: the Game playing it holds it directly, so loading
''' a file cannot disturb the built-in sets or their progress.
''' </remarks>
Module LevelsetLibrary
    Private ReadOnly Levelsets As New Dictionary(Of String, Levelset)(StringComparer.Ordinal)

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

        AddBuiltIn(ProgressStore.ClassicLevelsetName, My.Resources.LevelsetResource.Classic_SOK)
        AddBuiltIn(ProgressStore.ExtraDifficultLevelsetName, My.Resources.LevelsetResource.XS_SOK)
    End Sub

    Private Sub AddBuiltIn(levelsetName As String, levelsetText As String)
        Dim BuiltIn As New Levelset(levelsetName)
        BuiltIn.AddAllLevels(SplitIntoLevelTexts(levelsetText))
        Levelsets.Add(levelsetName, BuiltIn)
    End Sub

    ''' <remarks>Size of a built-in levelset, or 0 when there is no such set.</remarks>
    Public Function NumberOfLevelsIn(levelsetName As String) As Integer
        Dim Levelset As Levelset = GetLevelset(levelsetName)
        If Levelset Is Nothing Then
            Return 0
        End If

        Return Levelset.NumberOfLevels
    End Function

    ''' <remarks>Clamps a progress marker to a level number that exists in the named set.</remarks>
    Public Function ClampToLevelset(levelNumber As Integer, levelsetName As String) As Integer
        Dim LevelCount As Integer = NumberOfLevelsIn(levelsetName)
        If LevelCount < 1 Then
            Return 1
        End If

        Return Math.Max(1, Math.Min(levelNumber, LevelCount))
    End Function
End Module
