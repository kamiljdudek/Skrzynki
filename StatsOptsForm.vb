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

        Dim Moves As Integer
        Dim Pushes As Integer
        Dim ReachedLevel As Integer

        If IsClassic Then
            Moves = My.Settings.MovesKlasyczne
            Pushes = My.Settings.PushesKlasyczne
            ReachedLevel = My.Settings.ArrivedLevelKlasyczne
        Else
            Moves = My.Settings.MovesSupertrudne
            Pushes = My.Settings.PushesSupertrudne
            ReachedLevel = My.Settings.ArrivedLevelSupertrudne
        End If

        LabelMoves.Text = 倉庫番.Localizer.GetString("LabelMoves") & Moves
        LabelPushes.Text = 倉庫番.Localizer.GetString("LabelPushes") & Pushes
        LabelReachedLevel.Text = 倉庫番.Localizer.GetString("LabelAchievedLevel") & ReachedLevel

        ' Taken from the levelset itself rather than assumed to be 60.
        Dim Levelset As Levelset = LevelParser.GetLevelset(If(IsClassic, "Classic", "XS"))
        Dim NumberOfLevels As Integer = If(Levelset Is Nothing, 1, Levelset.NumberOfLevels)

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