' The menu handlers for choosing levels and levelsets are in GameBoardForm.LevelSelection.vb, and
' those of the View menu in GameBoardForm.ViewMenu.vb.
Partial Public Class GameBoardForm
    ' Initialized in this order: the game is built from the two before it.
    Private ReadOnly Levelsets As LevelsetLibrary = LevelsetLibrary.LoadBuiltIn()
    Private ReadOnly Progress As New ProgressStore()
    Private ReadOnly CurrentGame As New Game(Levelsets, Progress)

    ' Parallel to the game's board: see the board indexing convention in Board.vb. Index 0 is
    ' unused. Rebuilt whenever play moves to a set with a different board size.
    Private CellPictures() As System.Windows.Forms.PictureBox = {}

    ' Cells are drawn at the icons' own size while the board fits the screen at that size, and
    ' shrunk - icons and all - when it does not, down to a size that still reads.
    Private Const LargestCellSize As Integer = 32
    Private Const SmallestCellSize As Integer = 8

    Private StatisticsWindow As StatsOptsForm

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

    ''' <remarks>
    ''' Makes sure the grid of cells matches the size of the board being played, rebuilding it
    ''' when play has moved to a set with a board of another size.
    ''' </remarks>
    Private Sub EnsureBoardCells()
        Dim BoardSize As Integer = CurrentGame.BoardSize
        If CellPictures.Length <> BoardSize * BoardSize + 1 Then
            BuildBoardCells(BoardSize)
        End If
    End Sub

    ''' <remarks>
    ''' The largest cell, up to the icons' own size, at which the whole board and the window around
    ''' it fit on the screen the window is on.
    ''' </remarks>
    Private Function FitCellSize(boardSize As Integer) As Integer
        Dim WorkingArea As Rectangle = Screen.FromControl(Me).WorkingArea

        ' Everything around the board: the window frame, the title bar, and both strips.
        Dim ChromeWidth As Integer = Me.Width - Me.ClientSize.Width
        Dim ChromeHeight As Integer = Me.Height - Me.ClientSize.Height +
                                      GameMenuStrip.Height + GameStatusStrip.Height

        Dim Fitting As Integer = Math.Min((WorkingArea.Width - ChromeWidth) \ boardSize,
                                          (WorkingArea.Height - ChromeHeight) \ boardSize)

        Return Math.Max(SmallestCellSize, Math.Min(LargestCellSize, Fitting))
    End Function

    ''' <remarks>
    ''' Builds the grid of cells for a board of the given size and sizes the form around it. The
    ''' grid occupies the client area between the menu strip and the status strip. Each picture is
    ''' scaled to its cell, so a board shrunk to fit the screen shrinks its icons with it.
    ''' </remarks>
    Private Sub BuildBoardCells(boardSize As Integer)
        Dim CellSize As Integer = FitCellSize(boardSize)
        Dim BoardTop As Integer = Me.GameMenuStrip.Height

        Me.SuspendLayout()

        For Each OldPicture As PictureBox In CellPictures
            If OldPicture IsNot Nothing Then
                Me.Controls.Remove(OldPicture)
                OldPicture.Dispose()
            End If
        Next

        Me.ClientSize = New Size(
            boardSize * CellSize,
            BoardTop + boardSize * CellSize + Me.GameStatusStrip.Height)

        Dim Pictures(boardSize * boardSize) As PictureBox
        For Index As Integer = BoardFirstIndex To Pictures.Length - 1
            Dim Position As Cell = Cell.FromIndex(Index, boardSize)

            Pictures(Index) = New PictureBox
            With Pictures(Index)
                .Size = New Size(CellSize, CellSize)
                .Location = New Point(Position.Column * CellSize, BoardTop + Position.Row * CellSize)
                .SizeMode = PictureBoxSizeMode.Zoom
                .BackColor = My.Settings.BackgroundColor
            End With
            Me.Controls.Add(Pictures(Index))
        Next
        CellPictures = Pictures

        Me.ResumeLayout()
        KeepOnScreen()
    End Sub

    ''' <remarks>A window that has just grown is moved back inside the screen it is on.</remarks>
    Private Sub KeepOnScreen()
        Dim WorkingArea As Rectangle = Screen.FromControl(Me).WorkingArea
        Me.Left = Math.Max(WorkingArea.Left, Math.Min(Me.Left, WorkingArea.Right - Me.Width))
        Me.Top = Math.Max(WorkingArea.Top, Math.Min(Me.Top, WorkingArea.Bottom - Me.Height))
    End Sub

    ''' <remarks>
    ''' Brings every piece of chrome back in line with the game state: labels, window title, both
    ''' progress bars and the menu items whose availability depends on that state. Called after
    ''' anything that changes the game, so no caller has to remember which parts to update.
    ''' </remarks>
    Private Sub RefreshStatusBar()
        MovesLabel.Text = My.Resources.LocalizableStrings.LabelMoves & CurrentGame.MovesPerformed
        PushesLabel.Text = My.Resources.LocalizableStrings.LabelPushes & CurrentGame.PushesPerformed

        Me.Text = String.Format(System.Globalization.CultureInfo.CurrentCulture,
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
            Return System.IO.Path.GetFileName(CurrentGame.CustomLevelsetFileName)
        End If

        Return LocalizedLevelsetName(CurrentGame.BuiltInLevelsetName)
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

    ''' <remarks>
    ''' Redraws one cell. Indices outside the board are ignored rather than throwing: the
    ''' neighbours of a player standing on the top or bottom row fall off the ends of the array.
    ''' </remarks>
    Private Sub RefreshCell(cellIndex As Integer)
        If cellIndex < BoardFirstIndex OrElse cellIndex > CellPictures.Length - 1 Then
            Exit Sub
        End If

        Dim Item As BoardItem = CurrentGame.BoardCell(cellIndex)
        If Item = BoardItem.BlankOuter Then
            Me.CellPictures(cellIndex).Image = Nothing
        Else
            Me.CellPictures(cellIndex).Image = Skrzynki.Skin.GetIcon(Item)
        End If
    End Sub

    ''' <remarks>
    ''' Redraws the whole board, first rebuilding the grid if play has moved to a board of another
    ''' size - so every path that changes levelset gets the right grid by refreshing as usual.
    ''' </remarks>
    Private Sub RefreshBoard()
        EnsureBoardCells()

        For Counter As Integer = BoardFirstIndex To CellPictures.Length - 1
            RefreshCell(Counter)
        Next Counter
    End Sub

    ''' <remarks>A move never changes the board size, so the grid is already the right one.</remarks>
    Private Sub RefreshCellsAroundPlayer()
        Dim Player As Integer = CurrentGame.CurrentPlayerLocation
        Dim RowLength As Integer = CurrentGame.BoardSize
        RefreshCell(Player - RowLength)
        RefreshCell(Player - 1)
        RefreshCell(Player)
        RefreshCell(Player + 1)
        RefreshCell(Player + RowLength)
    End Sub


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

        If Not TryGetMoveDirection(e.KeyCode, Direction) Then
            Exit Sub
        End If

        If Not CurrentGame.TryMovePlayer(Direction) Then
            System.Media.SystemSounds.Beep.Play()
            Exit Sub
        End If

        RefreshCellsAroundPlayer()
        RefreshStatusBar()
        CompleteLevelWhileSolved()
    End Sub

    ''' <remarks>
    ''' Handles a solved level: banks the progress, announces it, and moves on. It loops because
    ''' the level it moves on to can itself arrive already solved, which a hand-made level file
    ''' can produce. The counter bounds a file made entirely of solved levels.
    ''' </remarks>
    Private Sub CompleteLevelWhileSolved()
        Dim LevelsCompleted As Integer = 0

        While CurrentGame.IsCurrentLevelSolved AndAlso
              LevelsCompleted <= CurrentGame.NumberOfLevelsInCurrentLevelset
            LevelsCompleted += 1

            ' Banked before advancing, for every solved level including the last one of a set.
            CurrentGame.RecordProgressForSolvedLevel()
            If StatisticsWindow IsNot Nothing AndAlso Not StatisticsWindow.IsDisposed Then
                StatisticsWindow.RefreshStatistics()
            End If

            ' Read before the level changes: advancing and restarting both clear the history the
            ' solution is written from.
            Dim Choice As LevelSolvedChoice = AskWhatToDoNext()

            If Choice = LevelSolvedChoice.RepeatLevel Then
                CurrentGame.RestartLevel()
            ElseIf Not CurrentGame.AdvanceToNextLevel() Then
                ShowMessage(My.Resources.LocalizableStrings.AlertAllLevelsSolved, MsgBoxStyle.Information)

                ' Finishing a set opened from a file drops back to the selected built-in one, the
                ' same way as choosing it from the menu. Finishing a built-in set starts it over.
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

            RefreshBoard()
            RefreshStatusBar()
        End While
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


    ''' <remarks>
    ''' The only Load handler. Everything here runs in order: the first RefreshBoard builds the
    ''' grid for the board the starting set uses, and what follows draws on it - VB does not define
    ''' the order two handlers of one event run in, so this sequence must stay in a single handler.
    ''' </remarks>
    Private Sub GameBoardForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ApplyLocalizationResources()

        Me.Icon = My.Resources.ico101
        Me.BackColor = Color.Black

        ' Resumes in the set the player was last in, or in the first built-in set when the saved
        ' name is not one the game knows.
        If Not StartBuiltInLevelset(My.Settings.LevelSet) AndAlso
           Not StartBuiltInLevelset(Levelsets.LevelsetNames(0)) Then
            ShowMessage(My.Resources.LocalizableStrings.AlertLevelsetLoadFailure, MsgBoxStyle.Critical)
        End If

        RefreshBoard()
        RefreshStatusBar()
        Me.Visible = True

        ' A level that arrives already solved has to be noticed here too, not only after a move.
        CompleteLevelWhileSolved()
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

    ''' <remarks>
    ''' The statistics window is modeless and there is only ever one of it. A form shown with
    ''' Show disposes itself when closed, so the reference is replaced once that has happened.
    ''' </remarks>
    Private Sub MenuitemOptions_Click(sender As Object, e As EventArgs) Handles MenuitemOptions.Click
        If StatisticsWindow Is Nothing OrElse StatisticsWindow.IsDisposed Then
            StatisticsWindow = New StatsOptsForm(Levelsets, Progress, CurrentGame.BuiltInLevelsetName)
        End If

        StatisticsWindow.Show(Me)
        StatisticsWindow.BringToFront()
    End Sub

    Private Sub MenuitemRestart_Click(sender As Object, e As EventArgs) Handles MenuitemRestart.Click
        If My.Settings.LevelRestartingAuthorization AndAlso
           ShowMessage(My.Resources.LocalizableStrings.QueryRestartLevel,
                       MsgBoxStyle.YesNo Or MsgBoxStyle.Question) <> MsgBoxResult.Yes Then
            Exit Sub
        End If

        CurrentGame.RestartLevel()
        RefreshBoard()
        RefreshStatusBar()
    End Sub

    Private Sub MenuitemUndo_Click(sender As Object, e As EventArgs) Handles MenuitemUndo.Click
        CurrentGame.Undo()
        RefreshBoard()
        RefreshStatusBar()
    End Sub
End Class
