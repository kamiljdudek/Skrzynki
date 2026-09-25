Imports System.Globalization

' Choosing what to play: a level by number, a levelset opened from a file, or one of the
' built-in levelsets.
Partial Public Class GameBoardForm

    ''' <remarks>
    ''' Picks a level of the built-in set named by the settings - also while a file is being
    ''' played, since NewGame always returns to that set.
    ''' </remarks>
    Private Sub MenuitemSelectLevel_Click(sender As Object, e As EventArgs) Handles MenuitemSelectLevel.Click
        Dim FurthestPlayableLevel As Integer = ProgressStore.FurthestPlayableLevel(My.Settings.LevelSet)

        Dim IB As String = InputBox(Localizer.GetString("QuerySelectLevel"),
                                    MessageTitle,
                                    FurthestPlayableLevel.ToString(CultureInfo.InvariantCulture))
        If String.IsNullOrWhiteSpace(IB) Then
            Exit Sub
        End If

        ' A whole number and nothing else: the level number is not a localized quantity, and
        ' anything with a decimal separator or trailing text is a typo rather than a level.
        Dim RequestedLevel As Integer
        If Not Integer.TryParse(IB.Trim(),
                                NumberStyles.Integer,
                                CultureInfo.InvariantCulture,
                                RequestedLevel) Then
            ShowMessage(Localizer.GetString("AlertNotANumber"), MsgBoxStyle.Critical)
            Exit Sub
        End If

        If RequestedLevel > FurthestPlayableLevel AndAlso
           RequestedLevel <= NumberOfLevelsIn(My.Settings.LevelSet) Then
            ShowMessage(Localizer.GetString("AlertLevelNotReachedYet"), MsgBoxStyle.Critical)
            Exit Sub
        End If

        ' NewGame clears the undo history and the move counters along with loading the board, and
        ' rejects a level number outside the set.
        If Not CurrentGame.NewGame(RequestedLevel) Then
            ShowMessage(Localizer.GetString("AlertLevelDoesNotExist"), MsgBoxStyle.Critical)
            Exit Sub
        End If

        RefreshBoard()
        RefreshStatusBar()
        CompleteLevelWhileSolved()
    End Sub

    ''' <remarks>
    ''' The custom set is registered, and the game switched over to it, only once it is known to
    ''' hold a playable level, so an unusable file leaves the game in progress untouched.
    ''' </remarks>
    Private Sub MenuitemOpenLevelFile_Click(sender As Object, e As EventArgs) Handles MenuitemOpenLevelFile.Click
        If OpenFileDialog1.ShowDialog() <> DialogResult.OK Then
            Exit Sub
        End If

        Dim SelectedFileName As String = OpenFileDialog1.FileName

        If Not CurrentGame.OpenLevelsetFromFile(SelectedFileName) Then
            ShowMessage(Localizer.GetString("AlertLevelEmptyOrBad"), MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        RefreshLevelsetChecks()

        If My.Settings.LevelLoadConfirmation = True Then
            ShowMessage(Localizer.GetString("AlertLevelFromFileLoadSuccess") & SelectedFileName,
                        MsgBoxStyle.Information)
        End If

        RefreshBoard()
        RefreshStatusBar()
        CompleteLevelWhileSolved()
    End Sub

    Private Sub MenuitemLevelset_Click(sender As Object, e As EventArgs) Handles MenuitemLevelset.Click
        RefreshLevelsetChecks()
    End Sub

    Private Sub MenuitemLevelset_Hover(sender As Object, e As EventArgs) Handles MenuitemLevelset.MouseHover
        RefreshLevelsetChecks()
    End Sub

    Private Sub RefreshLevelsetChecks()
        Dim PlayingBuiltIn As Boolean = Not CurrentGame.IsPlayingCustomLevelset

        MenuitemOpenLevelFile.Checked = Not PlayingBuiltIn
        MenuitemLevelsetClassic.Checked =
            PlayingBuiltIn AndAlso My.Settings.LevelSet = ProgressStore.ClassicLevelsetName
        MenuitemLevelsetXS.Checked =
            PlayingBuiltIn AndAlso My.Settings.LevelSet = ProgressStore.ExtraDifficultLevelsetName
    End Sub

    ''' <remarks>
    ''' Switches levelsets. SelectBuiltInLevelset resumes at the furthest level reached when
    ''' BeginFromArrivedLevel is set, and restores the previous set if the requested one cannot
    ''' be loaded.
    ''' </remarks>
    Private Sub SwitchToBuiltInLevelset(levelsetName As String)
        If Not CurrentGame.SelectBuiltInLevelset(levelsetName) Then
            ShowMessage(Localizer.GetString("AlertLevelsetLoadFailure"), MsgBoxStyle.Critical)
            Exit Sub
        End If

        RefreshLevelsetChecks()
        RefreshBoard()
        RefreshStatusBar()
        CompleteLevelWhileSolved()
    End Sub

    Private Sub MenuitemLevelsetClassic_Click(sender As Object, e As EventArgs) Handles MenuitemLevelsetClassic.Click
        SwitchToBuiltInLevelset(ProgressStore.ClassicLevelsetName)
    End Sub

    Private Sub MenuitemLevelsetXS_Click(sender As Object, e As EventArgs) Handles MenuitemLevelsetXS.Click
        SwitchToBuiltInLevelset(ProgressStore.ExtraDifficultLevelsetName)
    End Sub
End Class
