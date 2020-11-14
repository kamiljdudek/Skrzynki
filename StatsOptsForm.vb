Public Class StatsOptsForm

    Private Sub UpdateStatsUI()
        LabelLevelSet.Text = 倉庫番.Localizer.GetString("LabelLevelSet")
        LabelReachedLevel.Text = 倉庫番.Localizer.GetString("LabelAchievedLevel") & My.Settings.ArrivedLevelKlasyczne
        LabelMoves.Text = 倉庫番.Localizer.GetString("LabelMoves") & MovesPerformedOnCurrentLevel
        LabelPushes.Text = 倉庫番.Localizer.GetString("LabelPushes") & PushesPerformedOnCurrentLevel

        LevelSetProgressBar.Maximum = 60
        If LevelsetComboBox.SelectedItem Is 倉庫番.Localizer.GetString("LevelSetClassic") Then
            LevelSetProgressBar.Value = My.Settings.ArrivedLevelKlasyczne
        Else
            LevelSetProgressBar.Value = My.Settings.ArrivedLevelSupertrudne
        End If
    End Sub
    Private Sub StatsOptsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = 倉庫番.Localizer.GetString("LabelStats")
        LevelsetComboBox.Items.Add(倉庫番.Localizer.GetString("LevelSetClassic"))
        LevelsetComboBox.Items.Add(倉庫番.Localizer.GetString("LevelSetXS"))

        If My.Settings.LevelSet = "Klasyczne" Then
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