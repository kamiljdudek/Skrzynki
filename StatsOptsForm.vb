Public Class StatsOptsForm

    Private Sub RefreshStatistics()
        LabelLevelSet.Text = Localizer.GetString("LabelLevelSet")

        ' Value comparison, not reference comparison: the combo holds a copy of the localized
        ' string, so "Is" only matched while the ResourceManager happened to hand back the very
        ' same instance it had handed the combo box.
        Dim IsClassic As Boolean =
            String.Equals(CStr(LevelsetComboBox.SelectedItem),
                          Localizer.GetString("LevelSetClassic"),
                          StringComparison.Ordinal)

        Dim LevelsetName As String =
            If(IsClassic, ProgressStore.ClassicLevelsetName, ProgressStore.ExtraDifficultLevelsetName)

        Dim Moves As Integer = ProgressStore.GetMoves(LevelsetName)
        Dim Pushes As Integer = ProgressStore.GetPushes(LevelsetName)
        Dim ProgressMarker As Integer = ProgressStore.GetLevelMarker(LevelsetName)

        ' The stored marker names the next level to play and runs one past the end of a completed
        ' set, so it is clamped to a level that exists before being shown.
        Dim ReachedLevel As Integer = ClampToLevelset(ProgressMarker, LevelsetName)

        LabelMoves.Text = Localizer.GetString("LabelMoves") & Moves
        LabelPushes.Text = Localizer.GetString("LabelPushes") & Pushes
        LabelReachedLevel.Text = Localizer.GetString("LabelAchievedLevel") & ReachedLevel

        ' Taken from the levelset itself rather than assumed to be 60.
        Dim NumberOfLevels As Integer = NumberOfLevelsIn(LevelsetName)

        LevelSetProgressBar.Maximum = Math.Max(1, NumberOfLevels)
        LevelSetProgressBar.Value =
            Math.Max(LevelSetProgressBar.Minimum, Math.Min(ReachedLevel, LevelSetProgressBar.Maximum))
    End Sub
    Private Sub StatsOptsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = Localizer.GetString("LabelStats")
        LevelsetComboBox.Items.Add(Localizer.GetString("LevelSetClassic"))
        LevelsetComboBox.Items.Add(Localizer.GetString("LevelSetXS"))

        If My.Settings.LevelSet = "Classic" Then
            LevelsetComboBox.SelectedItem = Localizer.GetString("LevelSetClassic")
        Else
            LevelsetComboBox.SelectedItem = Localizer.GetString("LevelSetXS")
        End If

        RefreshStatistics()
    End Sub

    Private Sub LevelsetComboBox_SelectedValueChanged() Handles LevelsetComboBox.SelectedValueChanged
        RefreshStatistics()
    End Sub
End Class