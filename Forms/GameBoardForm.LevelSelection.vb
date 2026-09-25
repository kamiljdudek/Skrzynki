' Choosing what to play: a level by number, a levelset opened from a file, or one of the
' built-in levelsets. Each command only tells the game what to load; the window follows the game's
' LevelLoaded event from there.
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

        ' The picker keeps the number in range, so this fails only when no set is loaded at all.
        If Not CurrentGame.PlayLevel(RequestedLevel) Then
            Dialogs.ShowMessage(Me, My.Resources.LocalizableStrings.AlertLevelDoesNotExist,
                                MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    ''' <remarks>
    ''' The game switches over to the file only once it is known to hold a playable level, so an
    ''' unusable file leaves the game in progress untouched. Either way the player is told what was
    ''' wrong: a file that could not be read, one with no playable level at all, or one that
    ''' opened but had levels left out - and why they were.
    ''' </remarks>
    Private Sub MenuitemOpenLevelFile_Click(sender As Object, e As EventArgs) Handles MenuitemOpenLevelFile.Click
        If OpenLevelFileDialog.ShowDialog(Me) <> DialogResult.OK Then
            Exit Sub
        End If

        Dim Result As LevelsetOpenResult = CurrentGame.OpenLevelsetFromFile(OpenLevelFileDialog.FileName)

        Select Case Result.Outcome
            Case LevelsetOpenOutcome.Unreadable
                Dialogs.ShowMessage(Me, My.Resources.LocalizableStrings.AlertLevelFileUnreadable,
                                    MessageBoxButtons.OK, MessageBoxIcon.Error)

            Case LevelsetOpenOutcome.NoPlayableLevels
                Dim Message As String = My.Resources.LocalizableStrings.AlertNoPlayableLevels
                Dim Skipped As String = DescribeSkippedLevels(Result.Levelset)
                If Skipped.Length > 0 Then
                    Message &= Environment.NewLine & Environment.NewLine & Skipped
                End If
                Dialogs.ShowMessage(Me, Message, MessageBoxButtons.OK, MessageBoxIcon.Warning)

            Case Else
                Dim Skipped As String = DescribeSkippedLevels(Result.Levelset)
                If Skipped.Length > 0 Then
                    Dialogs.ShowMessage(Me, Skipped, MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
        End Select
    End Sub

    ''' <remarks>
    ''' Which levels of a file were left out, counted by reason - one line per reason that applies -
    ''' or an empty string when none were.
    ''' </remarks>
    Private Shared Function DescribeSkippedLevels(levelset As Levelset) As String
        If levelset Is Nothing OrElse levelset.SkippedLevels.Count = 0 Then
            Return String.Empty
        End If

        Dim TooLarge As Integer = 0
        Dim NotValid As Integer = 0
        For Each Skipped As SkippedLevel In levelset.SkippedLevels
            If Skipped.Reason = LevelSkipReason.TooLarge Then
                TooLarge += 1
            Else
                NotValid += 1
            End If
        Next

        Dim Lines As New List(Of String) From {My.Resources.LocalizableStrings.AlertLevelsSkipped}
        If TooLarge > 0 Then
            Lines.Add(UiText.Format(My.Resources.LocalizableStrings.AlertLevelsSkippedTooLargeFormat,
                                    Board.MaximumSize, TooLarge))
        End If
        If NotValid > 0 Then
            Lines.Add(UiText.Format(My.Resources.LocalizableStrings.AlertLevelsSkippedNotValidFormat, NotValid))
        End If

        Return String.Join(Environment.NewLine, Lines)
    End Function

    Private Sub MenuitemLevelset_DropDownOpening(sender As Object, e As EventArgs) Handles MenuitemLevelset.DropDownOpening
        Dim PlayingBuiltIn As Boolean = Not CurrentGame.IsPlayingCustomLevelset
        Dim BuiltInLevelset As String = CurrentGame.BuiltInLevelsetName

        MenuitemOpenLevelFile.Checked = Not PlayingBuiltIn
        MenuitemLevelsetClassic.Checked =
            PlayingBuiltIn AndAlso BuiltInLevelset = BuiltInLevelsets.ClassicName
        MenuitemLevelsetXS.Checked =
            PlayingBuiltIn AndAlso BuiltInLevelset = BuiltInLevelsets.ExtraDifficultName
    End Sub

    ''' <remarks>
    ''' Starts a built-in levelset - at the furthest level reached when BeginFromArrivedLevel is
    ''' set - and remembers it as the one to come back to next time the game starts.
    ''' </remarks>
    Private Function StartBuiltInLevelset(levelsetName As String) As Boolean
        Dim StartAt As StartingLevel =
            If(My.Settings.BeginFromArrivedLevel, StartingLevel.FurthestReached, StartingLevel.First)

        If Not CurrentGame.SelectBuiltInLevelset(levelsetName, StartAt) Then
            Return False
        End If

        My.Settings.LevelSet = levelsetName
        Return True
    End Function

    ''' <remarks>A set that cannot be loaded leaves the game in progress untouched.</remarks>
    Private Sub SwitchToBuiltInLevelset(levelsetName As String)
        If Not StartBuiltInLevelset(levelsetName) Then
            Dialogs.ShowMessage(Me, My.Resources.LocalizableStrings.AlertLevelsetLoadFailure,
                                MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub MenuitemLevelsetClassic_Click(sender As Object, e As EventArgs) Handles MenuitemLevelsetClassic.Click
        SwitchToBuiltInLevelset(BuiltInLevelsets.ClassicName)
    End Sub

    Private Sub MenuitemLevelsetXS_Click(sender As Object, e As EventArgs) Handles MenuitemLevelsetXS.Click
        SwitchToBuiltInLevelset(BuiltInLevelsets.ExtraDifficultName)
    End Sub
End Class
