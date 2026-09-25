''' <remarks>
''' The player's statistics for each built-in levelset, and the options that go with them. The
''' combo box holds the levelsets' internal names and shows them translated, so what is selected
''' never has to be worked out from the text on screen.
''' </remarks>
Public Class StatsOptsForm
    Private ReadOnly PlayedGame As Game

    Public Sub New(game As Game)
        InitializeComponent()
        PlayedGame = game
    End Sub

    Private Sub RefreshStatistics()
        Dim LevelsetName As String = CStr(LevelsetComboBox.SelectedItem)

        Dim Moves As Integer = PlayedGame.Progress.GetMoves(LevelsetName)
        Dim Pushes As Integer = PlayedGame.Progress.GetPushes(LevelsetName)
        Dim ReachedLevel As Integer = PlayedGame.FurthestPlayableLevel(LevelsetName)

        LabelMoves.Text = Localizer.GetString("LabelMoves") & Moves
        LabelPushes.Text = Localizer.GetString("LabelPushes") & Pushes
        LabelReachedLevel.Text = Localizer.GetString("LabelAchievedLevel") & ReachedLevel

        ' Taken from the levelset itself rather than assumed to be 60.
        Dim NumberOfLevels As Integer = PlayedGame.Levelsets.NumberOfLevelsIn(LevelsetName)

        LevelSetProgressBar.Maximum = Math.Max(1, NumberOfLevels)
        LevelSetProgressBar.Value =
            Math.Max(LevelSetProgressBar.Minimum, Math.Min(ReachedLevel, LevelSetProgressBar.Maximum))
    End Sub

    Private Sub StatsOptsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = Localizer.GetString("LabelStats")
        LabelLevelSet.Text = Localizer.GetString("LabelLevelSet")
        CheckBoxBeginFromArrivedLevel.Text = Localizer.GetString("CheckBoxBeginFromArrivedLevel")
        CheckBoxBeginFromArrivedLevel.Checked = My.Settings.BeginFromArrivedLevel

        For Each LevelsetName As String In PlayedGame.Levelsets.LevelsetNames
            LevelsetComboBox.Items.Add(LevelsetName)
        Next

        ' Opens on the set being played, or the first one when the game has none selected.
        Dim Selected As Integer = LevelsetComboBox.Items.IndexOf(PlayedGame.BuiltInLevelsetName)
        LevelsetComboBox.SelectedIndex = Math.Max(0, Selected)
    End Sub

    Private Sub LevelsetComboBox_Format(sender As Object, e As ListControlConvertEventArgs) Handles LevelsetComboBox.Format
        e.Value = LocalizedLevelsetName(CStr(e.ListItem))
    End Sub

    Private Sub LevelsetComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LevelsetComboBox.SelectedIndexChanged
        RefreshStatistics()
    End Sub

    ''' <remarks>Takes effect the next time a built-in levelset is started.</remarks>
    Private Sub CheckBoxBeginFromArrivedLevel_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxBeginFromArrivedLevel.CheckedChanged
        My.Settings.BeginFromArrivedLevel = CheckBoxBeginFromArrivedLevel.Checked
    End Sub
End Class
