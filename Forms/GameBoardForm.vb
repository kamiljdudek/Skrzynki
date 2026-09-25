' The menu handlers for choosing levels and levelsets are in GameBoardForm.LevelSelection.vb, and
' those of the View menu in GameBoardForm.ViewMenu.vb.
Partial Public Class GameBoardForm
    ' Initialized in this order: the game is built from the two before it.
    Private ReadOnly Levelsets As LevelsetLibrary = BuiltInLevelsets.Load()
    Private ReadOnly Progress As New ProgressStore()

    ''' <remarks>
    ''' The game being played. The window never redraws on its own initiative: it follows the
    ''' game's LevelLoaded and PlayerMoved events, so every menu command and key press only has to
    ''' tell the game what to do.
    ''' </remarks>
    Private WithEvents CurrentGame As New Game(Levelsets, Progress)

    ''' <remarks>The board, drawn below the menu strip.</remarks>
    Private ReadOnly BoardDisplay As New BoardView()

    ' The board size the window is laid out for; 0 until the first layout.
    Private LaidOutBoardSize As Integer

    ' Cells are drawn at the icons' own size - scaled for the screen's DPI - while the board fits
    ' the screen at that size, and shrunk when it does not, down to a size that still reads.
    Private Const SmallestCellSize As Integer = 8

    ''' <remarks>
    ''' The statistics window, while it is open. It is modeless and there is only ever one of it;
    ''' closing it disposes it, and the reference is dropped when that happens.
    ''' </remarks>
    Private WithEvents StatisticsWindow As StatsOptsForm

    ' Set while CompleteLevelWhileSolved runs. It loads levels itself, which raises LevelLoaded,
    ' which would call it again; its own loop already checks the level it loads.
    Private CompletingLevels As Boolean

    Private Sub ApplyLocalizationResources()
        Me.MenuitemAbout.Text = My.Resources.LocalizableStrings.MenuitemAbout
        Me.MenuitemAppWebsite.Text = My.Resources.LocalizableStrings.MenuitemWebsite
        Me.MenuitemGame.Text = My.Resources.LocalizableStrings.MenuitemGame
        Me.MenuitemHelp.Text = My.Resources.LocalizableStrings.MenuitemHelp
        Me.MenuitemHelpTopics.Text = My.Resources.LocalizableStrings.MenuitemHelpTopics
        Me.MenuitemLevelset.Text = My.Resources.LocalizableStrings.MenuitemSelectLevelSet
        Me.MenuitemLevelsetClassic.Text = My.Resources.LocalizableStrings.LevelSetClassic
        Me.MenuitemLevelsetXS.Text = My.Resources.LocalizableStrings.LevelSetXS
        Me.MenuitemOptions.Text = My.Resources.LocalizableStrings.MenuitemOptions
        Me.MenuitemQuit.Text = My.Resources.LocalizableStrings.MenuitemQuit
        Me.MenuitemRefresh.Text = My.Resources.LocalizableStrings.MenuitemRefresh
        Me.MenuitemRestart.Text = My.Resources.LocalizableStrings.MenuitemRestart
        Me.MenuitemSelectLevel.Text = My.Resources.LocalizableStrings.MenuitemSelectLevel
        Me.MenuitemOpenLevelFile.Text = My.Resources.LocalizableStrings.MenuitemOpenLevelFile
        Me.MenuitemTools.Text = My.Resources.LocalizableStrings.MenuitemTools
        Me.MenuitemUndo.Text = My.Resources.LocalizableStrings.MenuitemUndo
        Me.MenuitemView.Text = My.Resources.LocalizableStrings.MenuitemView
        Me.MenuitemSkinOrig.Text = My.Resources.LocalizableStrings.LabelSkinOriginal
        Me.MenuitemSkinExport.Text = My.Resources.LocalizableStrings.LabelSkinExport
        Me.MenuitemSkinCheese.Text = My.Resources.LocalizableStrings.LabelSkinCheese
        Me.MenuitemSkins.Text = My.Resources.LocalizableStrings.LabelSkin
        Me.MenuitemColor.Text = My.Resources.LocalizableStrings.MenuitemColor
        Me.MenuitemHide.Text = My.Resources.LocalizableStrings.MenuitemHide
        Me.SkrzynkiTrayIcon.Text = My.Resources.LocalizableStrings.GameName
        Me.MenuitemConfirmRestarts.Text = My.Resources.LocalizableStrings.MenuitemConfirmRestarts
        OpenLevelFileDialog.Filter = My.Resources.LocalizableStrings.DialogFileFilter
        OpenLevelFileDialog.Title = My.Resources.LocalizableStrings.DialogOpenLevelFile
    End Sub

    ' --- Layout --------------------------------------------------------------------------------

    ''' <remarks>
    ''' Sizes the board and the window around it for the board being played, on the screen the
    ''' window is on: the board fills the client area between the menu strip and the status strip.
    ''' </remarks>
    Private Sub LayOutBoard()
        Dim BoardSize As Integer = CurrentGame.Board.Size
        Dim CellSize As Integer = FitCellSize(BoardSize)
        Dim BoardTop As Integer = GameMenuStrip.Height
        Dim Side As Integer = BoardSize * CellSize

        BoardDisplay.CellSize = CellSize
        BoardDisplay.Bounds = New Rectangle(0, BoardTop, Side, Side)
        Me.ClientSize = New Size(Side, BoardTop + Side + GameStatusStrip.Height)

        LaidOutBoardSize = BoardSize
        KeepOnScreen()
    End Sub

    ''' <remarks>
    ''' The largest cell, up to the icons' own size at the screen's DPI, at which the whole board
    ''' and the window around it fit on the screen the window is on.
    ''' </remarks>
    Private Function FitCellSize(boardSize As Integer) As Integer
        Dim Scale As Double = Me.DeviceDpi / 96.0
        Dim Largest As Integer = CInt(Math.Round(SkinIcons.IconSize * Scale))
        Dim Smallest As Integer = CInt(Math.Round(SmallestCellSize * Scale))

        Dim WorkingArea As Rectangle = Screen.FromControl(Me).WorkingArea

        ' Everything around the board: the window frame, the title bar, and both strips.
        Dim ChromeWidth As Integer = Me.Width - Me.ClientSize.Width
        Dim ChromeHeight As Integer = Me.Height - Me.ClientSize.Height +
                                      GameMenuStrip.Height + GameStatusStrip.Height

        Dim Fitting As Integer = Math.Min((WorkingArea.Width - ChromeWidth) \ boardSize,
                                          (WorkingArea.Height - ChromeHeight) \ boardSize)

        Return Math.Max(Smallest, Math.Min(Largest, Fitting))
    End Function

    ''' <remarks>A window that has just grown is moved back inside the screen it is on.</remarks>
    Private Sub KeepOnScreen()
        Dim WorkingArea As Rectangle = Screen.FromControl(Me).WorkingArea
        Me.Left = Math.Max(WorkingArea.Left, Math.Min(Me.Left, WorkingArea.Right - Me.Width))
        Me.Top = Math.Max(WorkingArea.Top, Math.Min(Me.Top, WorkingArea.Bottom - Me.Height))
    End Sub

    ''' <remarks>
    ''' Moving to a screen with another DPI rescales the menus and strips; the board is then laid
    ''' out again to match them.
    ''' </remarks>
    Protected Overrides Sub OnDpiChanged(e As DpiChangedEventArgs)
        MyBase.OnDpiChanged(e)
        If e IsNot Nothing AndAlso Not e.Cancel Then
            LayOutBoard()
        End If
    End Sub

    ' --- Following the game --------------------------------------------------------------------

    Private Sub CurrentGame_LevelLoaded(sender As Object, e As EventArgs) Handles CurrentGame.LevelLoaded
        If CurrentGame.Board.Size <> LaidOutBoardSize Then
            LayOutBoard()
        End If

        ' Each level comes on a board of its own, which the view has to be given.
        BoardDisplay.Board = CurrentGame.Board
        RefreshStatusBar()

        ' A level that arrives already solved has to be noticed too, not only after a move.
        CompleteLevelWhileSolved()
    End Sub

    Private Sub CurrentGame_PlayerMoved(sender As Object, e As EventArgs) Handles CurrentGame.PlayerMoved
        BoardDisplay.Invalidate()
        RefreshStatusBar()
        CompleteLevelWhileSolved()
    End Sub

    ''' <remarks>
    ''' Brings every piece of chrome back in line with the game state: labels, window title, both
    ''' progress bars and the menu items whose availability depends on that state.
    ''' </remarks>
    Private Sub RefreshStatusBar()
        MovesLabel.Text = UiText.Format($"{My.Resources.LocalizableStrings.LabelMoves}{CurrentGame.MovesPerformed}")
        PushesLabel.Text = UiText.Format($"{My.Resources.LocalizableStrings.LabelPushes}{CurrentGame.PushesPerformed}")

        Me.Text = String.Format(Globalization.CultureInfo.CurrentCulture,
                                My.Resources.LocalizableStrings.GameTitleFormat,
                                My.Resources.LocalizableStrings.GameName,
                                LevelsetDisplayName(),
                                CurrentGame.CurrentLevelNumber)

        ' Progress towards the goal squares, matching the rule that decides the level is solved.
        SetProgress(Me.LevelProgressBar,
                    CurrentGame.NumberOfCoveredGoalsOnCurrentLevel,
                    CurrentGame.NumberOfGoalsOnCurrentLevel)

        ' Scaled to the size of the set actually loaded, which a set opened from a file may set
        ' to anything.
        SetProgress(Me.LevelsetProgressBar,
                    CurrentGame.CurrentLevelNumber,
                    CurrentGame.NumberOfLevelsInCurrentLevelset)

        RefreshMenuState()
    End Sub

    ''' <remarks>
    ''' How the levelset being played is named to the player: the file name for a set opened from
    ''' disk, the translated set name otherwise.
    ''' </remarks>
    Private Function LevelsetDisplayName() As String
        If CurrentGame.IsPlayingCustomLevelset Then
            Return CurrentGame.CurrentLevelsetName
        End If

        Return BuiltInLevelsets.DisplayName(CurrentGame.BuiltInLevelsetName)
    End Function

    ''' <remarks>
    ''' Menu availability follows the game state, so that the shortcut keys behave the same way
    ''' whether or not the menu holding them has been opened.
    ''' </remarks>
    Private Sub RefreshMenuState()
        Me.MenuitemUndo.Enabled = CurrentGame.CanUndo
        Me.MenuitemRestart.Enabled = CurrentGame.NumberOfLevelsInCurrentLevelset > 0
    End Sub

    ''' <remarks>
    ''' Sets a progress bar without letting a stale or oversized value throw: ProgressBar rejects
    ''' a Value above its Maximum, and Maximum must stay at least 1 for the bar to be meaningful.
    ''' </remarks>
    Private Shared Sub SetProgress(bar As ToolStripProgressBar,
                                   value As Integer,
                                   maximum As Integer)
        bar.Maximum = Math.Max(1, maximum)
        bar.Value = Math.Max(bar.Minimum, Math.Min(value, bar.Maximum))
    End Sub

    ' --- Playing -------------------------------------------------------------------------------

    ''' <remarks>
    ''' Which cursor key means which direction is a property of the input device, so the mapping
    ''' lives here rather than in the game itself.
    ''' </remarks>
    Private Shared Function TryGetMoveDirection(pressedKey As Keys,
                                                ByRef direction As MoveDirection) As Boolean
        Select Case pressedKey
            Case Keys.Up
                direction = MoveDirection.Up
            Case Keys.Down
                direction = MoveDirection.Down
            Case Keys.Left
                direction = MoveDirection.Left
            Case Keys.Right
                direction = MoveDirection.Right
            Case Else
                Return False
        End Select

        Return True
    End Function

    Private Sub GameBoardForm_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        Dim Direction As MoveDirection

        If TryGetMoveDirection(e.KeyCode, Direction) AndAlso
           Not CurrentGame.TryMovePlayer(Direction) Then
            System.Media.SystemSounds.Beep.Play()
        End If
    End Sub

    ''' <remarks>
    ''' Handles a solved level: banks the progress, announces it, and moves on. It loops because
    ''' the level it moves on to can itself arrive already solved, which a hand-made level file
    ''' can produce. The counter bounds a file made entirely of solved levels.
    ''' </remarks>
    Private Sub CompleteLevelWhileSolved()
        If CompletingLevels Then
            Exit Sub
        End If

        CompletingLevels = True
        Try
            Dim LevelsCompleted As Integer = 0

            While CurrentGame.IsCurrentLevelSolved AndAlso
                  LevelsCompleted <= CurrentGame.NumberOfLevelsInCurrentLevelset
                LevelsCompleted += 1

                ' Banked before advancing, for every solved level including the last one of a set.
                CurrentGame.RecordProgressForSolvedLevel()
                StatisticsWindow?.RefreshStatistics()

                ' Read before the level changes: advancing and restarting both clear the history
                ' the solution is written from.
                Dim Choice As LevelSolvedChoice = AskWhatToDoNext()

                If Choice = LevelSolvedChoice.RepeatLevel Then
                    CurrentGame.RestartLevel()
                ElseIf Not CurrentGame.AdvanceToNextLevel() Then
                    Dialogs.ShowMessage(Me, My.Resources.LocalizableStrings.AlertAllLevelsSolved,
                                        MessageBoxButtons.OK, MessageBoxIcon.Information)

                    ' Finishing a set opened from a file drops back to the selected built-in one,
                    ' the same way as choosing it from the menu. Finishing a built-in set starts it
                    ' over.
                    Dim Continued As Boolean
                    If CurrentGame.IsPlayingCustomLevelset Then
                        Continued = StartBuiltInLevelset(CurrentGame.BuiltInLevelsetName)
                    Else
                        Continued = CurrentGame.PlayBuiltInLevel(1)
                    End If

                    If Not Continued Then
                        Exit While
                    End If
                End If
            End While
        Finally
            CompletingLevels = False
        End Try
    End Sub

    ''' <remarks>
    ''' Shows the solved-level dialog and returns what the player picked. The dialog is created
    ''' fresh each time so that it carries the solution for the level just finished.
    ''' </remarks>
    Private Function AskWhatToDoNext() As LevelSolvedChoice
        Using Solved As New LevelSolvedForm()
            Solved.PresentSolvedLevel(CurrentGame.CurrentAttemptLurd,
                                      CurrentGame.MovesPerformed,
                                      CurrentGame.PushesPerformed,
                                      LevelsetDisplayName(),
                                      CurrentGame.CurrentLevelNumber)
            Solved.ShowDialog(Me)

            Return Solved.Choice
        End Using
    End Function

    ' --- The window and its commands -----------------------------------------------------------

    ''' <remarks>
    ''' The only Load handler. The board is laid out before the first level loads, so that a game
    ''' that fails to start still shows an empty board of the usual size.
    ''' </remarks>
    Private Sub GameBoardForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ApplyLocalizationResources()

        Me.Icon = My.Resources.ico101
        Me.BackColor = Color.Black

        BoardDisplay.BackColor = My.Settings.BackgroundColor
        BoardDisplay.Skin = SkinIcons.FromSetting(My.Settings.Skin)
        Me.Controls.Add(BoardDisplay)
        LayOutBoard()
        BoardDisplay.Board = CurrentGame.Board

        ' Resumes in the set the player was last in, or in the first built-in set when the saved
        ' name is not one the game knows.
        If Not StartBuiltInLevelset(My.Settings.LevelSet) AndAlso
           Not StartBuiltInLevelset(Levelsets.LevelsetNames(0)) Then
            Dialogs.ShowMessage(Me, My.Resources.LocalizableStrings.AlertLevelsetLoadFailure,
                                MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

        RefreshStatusBar()
    End Sub

    ''' <remarks>
    ''' Closing the main form ends the application, and the application framework saves the
    ''' settings on the way out (SaveMySettingsOnExit in Application.myapp).
    ''' </remarks>
    Private Sub MenuitemQuit_Click(sender As Object, e As EventArgs) Handles MenuitemQuit.Click
        Me.Close()
    End Sub

    Private Sub MenuitemAbout_Click(sender As Object, e As EventArgs) Handles MenuitemAbout.Click
        Using About As New SplashScreen()
            About.ShowDialog(Me)
        End Using
    End Sub

    Private Sub MenuitemOptions_Click(sender As Object, e As EventArgs) Handles MenuitemOptions.Click
        If StatisticsWindow Is Nothing Then
            StatisticsWindow = New StatsOptsForm(Levelsets, Progress, CurrentGame.BuiltInLevelsetName)
        End If

        StatisticsWindow.Show(Me)
        StatisticsWindow.BringToFront()
    End Sub

    Private Sub StatisticsWindow_FormClosed(sender As Object, e As FormClosedEventArgs) Handles StatisticsWindow.FormClosed
        StatisticsWindow = Nothing
    End Sub

    Private Sub MenuitemRestart_Click(sender As Object, e As EventArgs) Handles MenuitemRestart.Click
        If My.Settings.LevelRestartingAuthorization AndAlso
           Dialogs.ShowMessage(Me, My.Resources.LocalizableStrings.QueryRestartLevel,
                               MessageBoxButtons.YesNo, MessageBoxIcon.Question) <> DialogResult.Yes Then
            Exit Sub
        End If

        CurrentGame.RestartLevel()
    End Sub

    Private Sub MenuitemUndo_Click(sender As Object, e As EventArgs) Handles MenuitemUndo.Click
        CurrentGame.Undo()
    End Sub
End Class
