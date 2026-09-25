Imports System.Globalization

' Choosing what to play: a level by number, a levelset opened from a file, or one of the
' built-in levelsets.
Partial Public Class GameBoardForm

    ''' <remarks>
    ''' Picks a level of the selected built-in set - also while a file is being played, since
    ''' NewGame always returns to that set.
    ''' </remarks>
    Private Sub MenuitemSelectLevel_Click(sender As Object, e As EventArgs) Handles MenuitemSelectLevel.Click
        Dim BuiltInLevelset As String = CurrentGame.BuiltInLevelsetName
        Dim FurthestPlayableLevel As Integer = CurrentGame.FurthestPlayableLevel(BuiltInLevelset)

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
           RequestedLevel <= CurrentGame.Levelsets.NumberOfLevelsIn(BuiltInLevelset) Then
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
    ''' The game switches over to the file only once it is known to hold a playable level, so an
    ''' unusable file leaves the game in progress untouched.
    ''' </remarks>
    Private Sub MenuitemOpenLevelFile_Click(sender As Object, e As EventArgs) Handles MenuitemOpenLevelFile.Click
        If OpenLevelFileDialog.ShowDialog() <> DialogResult.OK Then
            Exit Sub
        End If

        If Not CurrentGame.OpenLevelsetFromFile(OpenLevelFileDialog.FileName) Then
            ShowMessage(Localizer.GetString("AlertLevelEmptyOrBad"), MsgBoxStyle.Exclamation)
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
            ShowMessage(Localizer.GetString("AlertLevelsetLoadFailure"), MsgBoxStyle.Critical)
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
