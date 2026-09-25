''' <remarks>
''' The player's statistics for each built-in levelset, and the options that go with them. The
''' combo box holds the levelsets' internal names and shows them translated, so what is selected
''' never has to be worked out from the text on screen.
''' </remarks>
Public Class StatsOptsForm
    Private ReadOnly Levelsets As LevelsetLibrary
    Private ReadOnly Progress As IProgressStore
    Private ReadOnly InitialLevelset As String

    ''' <param name="initialLevelset">The set to show first; the first set when it is not one of them.</param>
    Public Sub New(levelsets As LevelsetLibrary, progress As IProgressStore, initialLevelset As String)
        InitializeComponent()
        Me.Levelsets = levelsets
        Me.Progress = progress
        Me.InitialLevelset = initialLevelset
    End Sub

    ''' <remarks>
    ''' Brings the figures up to date. The window is modeless and can stay open during play, so the
    ''' game window calls this whenever progress is recorded.
    ''' </remarks>
    Public Sub RefreshStatistics()
        Dim LevelsetName As String = CStr(LevelsetComboBox.SelectedItem)
        If LevelsetName Is Nothing Then
            Exit Sub
        End If

        Dim Moves As Integer = Progress.GetMoves(LevelsetName)
        Dim Pushes As Integer = Progress.GetPushes(LevelsetName)
        Dim ReachedLevel As Integer = Levelsets.FurthestPlayableLevel(LevelsetName, Progress)

        LabelMoves.Text = UiText.Format($"{My.Resources.LocalizableStrings.LabelMoves}{Moves}")
        LabelPushes.Text = UiText.Format($"{My.Resources.LocalizableStrings.LabelPushes}{Pushes}")
        LabelReachedLevel.Text = UiText.Format($"{My.Resources.LocalizableStrings.LabelAchievedLevel}{ReachedLevel}")

        ' Taken from the levelset itself rather than assumed to be 60.
        Dim NumberOfLevels As Integer = Levelsets.NumberOfLevelsIn(LevelsetName)

        LevelSetProgressBar.Maximum = Math.Max(1, NumberOfLevels)
        LevelSetProgressBar.Value =
            Math.Max(LevelSetProgressBar.Minimum, Math.Min(ReachedLevel, LevelSetProgressBar.Maximum))
    End Sub

    Private Sub StatsOptsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = My.Resources.LocalizableStrings.LabelStats
        LabelLevelSet.Text = My.Resources.LocalizableStrings.LabelLevelSet
        CheckBoxBeginFromArrivedLevel.Text = My.Resources.LocalizableStrings.CheckBoxBeginFromArrivedLevel
        CheckBoxBeginFromArrivedLevel.Checked = My.Settings.BeginFromArrivedLevel

        For Each LevelsetName As String In Levelsets.LevelsetNames
            LevelsetComboBox.Items.Add(LevelsetName)
        Next

        LevelsetComboBox.SelectedIndex = Math.Max(0, LevelsetComboBox.Items.IndexOf(InitialLevelset))
    End Sub

    Private Sub LevelsetComboBox_Format(sender As Object, e As ListControlConvertEventArgs) Handles LevelsetComboBox.Format
        e.Value = BuiltInLevelsets.DisplayName(CStr(e.ListItem))
    End Sub

    Private Sub LevelsetComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LevelsetComboBox.SelectedIndexChanged
        RefreshStatistics()
    End Sub

    ''' <remarks>Takes effect the next time a built-in levelset is started.</remarks>
    Private Sub CheckBoxBeginFromArrivedLevel_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxBeginFromArrivedLevel.CheckedChanged
        My.Settings.BeginFromArrivedLevel = CheckBoxBeginFromArrivedLevel.Checked
    End Sub
End Class
