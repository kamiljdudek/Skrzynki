' Choosing what to play: a level by number, a levelset opened from a file, or one of the
' built-in levelsets.
Partial Public Class GameBoardForm

    ''' <remarks>
    ''' Picks a level of the set being played: any level of a file, or one already reached in a
    ''' built-in set. The dialog starts on the furthest level reached, or on the current level of
    ''' a file, where every level is open.
    ''' </remarks>
    Private Sub MenuitemSelectLevel_Click(sender As Object, e As EventArgs) Handles MenuitemSelectLevel.Click
        Dim SuggestedLevel As Integer = CurrentGame.HighestOpenLevel
        If CurrentGame.IsPlayingCustomLevelset Then
            SuggestedLevel = CurrentGame.CurrentLevelNumber
        End If

        Dim RequestedLevel As Integer
        Using Picker As New SelectLevelForm(CurrentGame.HighestOpenLevel, SuggestedLevel)
            If Picker.ShowDialog(Me) <> DialogResult.OK Then
                Exit Sub
            End If
            RequestedLevel = Picker.SelectedLevel
        End Using

        ' PlayLevel clears the undo history and the move counters along with loading the board.
        ' The picker keeps the number in range, so this fails only when no set is loaded at all.
        If Not CurrentGame.PlayLevel(RequestedLevel) Then
            ShowMessage(My.Resources.LocalizableStrings.AlertLevelDoesNotExist, MsgBoxStyle.Critical)
            Exit Sub
        End If

        RefreshBoard()
        RefreshStatusBar()
        CompleteLevelWhileSolved()
    End Sub

    ''' <remarks>
    ''' The game switches over to the file only once it is known to hold a playable level, so an
    ''' unusable file leaves the game in progress untouched.
    ''' </remarks>
    Private Sub MenuitemOpenLevelFile_Click(sender As Object, e As EventArgs) Handles MenuitemOpenLevelFile.Click
        If OpenLevelFileDialog.ShowDialog() <> DialogResult.OK Then
            Exit Sub
        End If

        If Not CurrentGame.OpenLevelsetFromFile(OpenLevelFileDialog.FileName) Then
            ShowMessage(My.Resources.LocalizableStrings.AlertLevelEmptyOrBad, MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        RefreshBoard()
        RefreshStatusBar()
        CompleteLevelWhileSolved()
    End Sub

    Private Sub MenuitemLevelset_DropDownOpening(sender As Object, e As EventArgs) Handles MenuitemLevelset.DropDownOpening
        Dim PlayingBuiltIn As Boolean = Not CurrentGame.IsPlayingCustomLevelset
        Dim BuiltInLevelset As String = CurrentGame.BuiltInLevelsetName

        MenuitemOpenLevelFile.Checked = Not PlayingBuiltIn
        MenuitemLevelsetClassic.Checked =
            PlayingBuiltIn AndAlso BuiltInLevelset = LevelsetLibrary.ClassicLevelsetName
        MenuitemLevelsetXS.Checked =
            PlayingBuiltIn AndAlso BuiltInLevelset = LevelsetLibrary.ExtraDifficultLevelsetName
    End Sub

    ''' <remarks>
    ''' Starts a built-in levelset - at the furthest level reached when BeginFromArrivedLevel is
    ''' set - and remembers it as the one to come back to next time the game starts.
    ''' </remarks>
    Private Function StartBuiltInLevelset(levelsetName As String) As Boolean
        If Not CurrentGame.SelectBuiltInLevelset(levelsetName, My.Settings.BeginFromArrivedLevel) Then
            Return False
        End If

        My.Settings.LevelSet = levelsetName
        Return True
    End Function

    ''' <remarks>A set that cannot be loaded leaves the game in progress untouched.</remarks>
    Private Sub SwitchToBuiltInLevelset(levelsetName As String)
        If Not StartBuiltInLevelset(levelsetName) Then
            ShowMessage(My.Resources.LocalizableStrings.AlertLevelsetLoadFailure, MsgBoxStyle.Critical)
            Exit Sub
        End If

        RefreshBoard()
        RefreshStatusBar()
        CompleteLevelWhileSolved()
    End Sub

    Private Sub MenuitemLevelsetClassic_Click(sender As Object, e As EventArgs) Handles MenuitemLevelsetClassic.Click
        SwitchToBuiltInLevelset(LevelsetLibrary.ClassicLevelsetName)
    End Sub

    Private Sub MenuitemLevelsetXS_Click(sender As Object, e As EventArgs) Handles MenuitemLevelsetXS.Click
        SwitchToBuiltInLevelset(LevelsetLibrary.ExtraDifficultLevelsetName)
    End Sub
End Class
