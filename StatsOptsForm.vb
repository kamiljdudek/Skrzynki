Public Class StatsOptsForm

    Private Sub UpdateStatsUI()
        LabelLevelSet.Text = 倉庫番.Localizer.GetString("LabelLevelSet")

        LevelSetProgressBar.Maximum = 60
        If LevelsetComboBox.SelectedItem Is 倉庫番.Localizer.GetString("LevelSetClassic") Then
            LabelMoves.Text = 倉庫番.Localizer.GetString("LabelMoves") & My.Settings.MovesKlasyczne
            LabelPushes.Text = 倉庫番.Localizer.GetString("LabelPushes") & My.Settings.PushesKlasyczne
            LabelReachedLevel.Text = 倉庫番.Localizer.GetString("LabelAchievedLevel") & My.Settings.ArrivedLevelKlasyczne
            LevelSetProgressBar.Value = My.Settings.ArrivedLevelKlasyczne
        Else
            LabelMoves.Text = 倉庫番.Localizer.GetString("LabelMoves") & My.Settings.MovesSupertrudne
            LabelPushes.Text = 倉庫番.Localizer.GetString("LabelPushes") & My.Settings.MovesSupertrudne
            LabelReachedLevel.Text = 倉庫番.Localizer.GetString("LabelAchievedLevel") & My.Settings.ArrivedLevelSupertrudne
            LevelSetProgressBar.Value = My.Settings.ArrivedLevelSupertrudne
        End If
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