Public Class StatsOptsForm

    Private Sub UpdateStatsUI()
        LabelLevelSet.Text = 倉庫番.Localizer.GetString("LabelLevelSet")

        ' Value comparison, not reference comparison: the combo holds a copy of the localized
        ' string, so "Is" only matched while the ResourceManager happened to hand back the very
        ' same instance it had handed the combo box.
        Dim IsClassic As Boolean =
            String.Equals(CStr(LevelsetComboBox.SelectedItem),
                          倉庫番.Localizer.GetString("LevelSetClassic"),
                          StringComparison.Ordinal)

        Dim LevelsetName As String = If(IsClassic, "Classic", "XS")
        Dim Moves As Integer
        Dim Pushes As Integer
        Dim ProgressMarker As Integer

        If IsClassic Then
            Moves = My.Settings.MovesKlasyczne
            Pushes = My.Settings.PushesKlasyczne
            ProgressMarker = My.Settings.ArrivedLevelKlasyczne
        Else
            Moves = My.Settings.MovesSupertrudne
            Pushes = My.Settings.PushesSupertrudne
            ProgressMarker = My.Settings.ArrivedLevelSupertrudne
        End If

        ' The stored marker names the next level to play and runs one past the end of a completed
        ' set, so it is clamped to a level that exists before being shown.
        Dim ReachedLevel As Integer = 倉庫番.ClampToLevelset(ProgressMarker, LevelsetName)

        LabelMoves.Text = 倉庫番.Localizer.GetString("LabelMoves") & Moves
        LabelPushes.Text = 倉庫番.Localizer.GetString("LabelPushes") & Pushes
        LabelReachedLevel.Text = 倉庫番.Localizer.GetString("LabelAchievedLevel") & ReachedLevel

        ' Taken from the levelset itself rather than assumed to be 60.
        Dim NumberOfLevels As Integer = 倉庫番.NumberOfLevelsIn(LevelsetName)

        LevelSetProgressBar.Maximum = Math.Max(1, NumberOfLevels)
        LevelSetProgressBar.Value =
            Math.Max(LevelSetProgressBar.Minimum, Math.Min(ReachedLevel, LevelSetProgressBar.Maximum))
    End Sub
    Private Sub StatsOptsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = 倉庫番.Localizer.GetString("LabelStats")
        LevelsetComboBox.Items.Add(倉庫番.Localizer.GetString("LevelSetClassic"))
        LevelsetComboBox.Items.Add(倉庫番.Localizer.GetString("LevelSetXS"))

        If My.Settings.LevelSet = "Classic" Then
            LevelsetComboBox.SelectedItem = 倉庫番.Localizer.GetString("LevelSetClassic")
        Else
            LevelsetComboBox.SelectedItem = 倉庫番.Localizer.GetString("LevelSetXS")
        End If

        UpdateStatsUI()
    End Sub

    Private Sub ChangeStatsCombo() Handles LevelsetComboBox.SelectedValueChanged
        Call UpdateStatsUI()
    End Sub
End Class