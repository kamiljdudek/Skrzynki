' The menu handlers for choosing levels and levelsets are in GameBoardForm.LevelSelection.vb, and
' those of the View menu in GameBoardForm.ViewMenu.vb.
Partial Public Class GameBoardForm
    ' Parallel to GameBoard: see the board indexing convention in 倉庫番.vb. Cells occupy
    ' BoardFirstIndex through BoardCellCount; index 0 is unused.
    ReadOnly CellPictures(BoardCellCount) As System.Windows.Forms.PictureBox

    Private Const CellSizeInPixels As Integer = 32

    Private StatisticsWindow As StatsOptsForm

    Private Shared ReadOnly MessageTitle As String =
        System.Reflection.Assembly.GetExecutingAssembly.GetName.Name

    ''' <remarks>Every message box the game shows: application-modal and titled with its name.</remarks>
    Private Shared Function ShowMessage(text As String, style As MsgBoxStyle) As MsgBoxResult
        Return MsgBox(text, style Or MsgBoxStyle.ApplicationModal, MessageTitle)
    End Function

    Private Sub ApplyLocalizationResources()
        Me.MenuitemAbout.Text = Localizer.GetString("MenuitemAbout")
        Me.MenuitemAppWebsite.Text = Localizer.GetString("MenuitemWebsite")
        Me.MenuitemGame.Text = Localizer.GetString("MenuitemGame")
        Me.MenuitemHelp.Text = Localizer.GetString("MenuitemHelp")
        Me.MenuitemHelpTopics.Text = Localizer.GetString("MenuitemHelpTopics")
        Me.MenuitemLevelset.Text = Localizer.GetString("MenuitemSelectLevelSet")
        Me.MenuitemLevelsetClassic.Text = Localizer.GetString("LevelSetClassic")
        Me.MenuitemLevelsetXS.Text = Localizer.GetString("LevelSetXS")
        Me.MenuitemOptions.Text = Localizer.GetString("MenuitemOptions")
        Me.MenuitemQuit.Text = Localizer.GetString("MenuitemQuit")
        Me.MenuitemRefresh.Text = Localizer.GetString("MenuitemRefresh")
        Me.MenuitemRestart.Text = Localizer.GetString("MenuitemRestart")
        Me.MenuitemSelectLevel.Text = Localizer.GetString("MenuitemSelectLevel")
        Me.MenuitemOpenLevelFile.Text = Localizer.GetString("MenuitemOpenLevelFile")
        Me.MenuitemTools.Text = Localizer.GetString("MenuitemTools")
        Me.MenuitemUndo.Text = Localizer.GetString("MenuitemUndo")
        Me.MenuitemView.Text = Localizer.GetString("MenuitemView")
        Me.MenuitemSkinOrig.Text = Localizer.GetString("LabelSkinOriginal")
        Me.MenuitemSkinExport.Text = Localizer.GetString("LabelSkinExport")
        Me.MenuitemSkinCheese.Text = Localizer.GetString("LabelSkinCheese")
        Me.MenuitemSkins.Text = Localizer.GetString("LabelSkin")
        Me.MenuitemColor.Text = Localizer.GetString("MenuitemColor")
        Me.MenuitemHide.Text = Localizer.GetString("MenuitemHide")
        Me.SkrzynkiTrayIcon.Text = Localizer.GetString("GameName")
        Me.MenuitemConfirmRestarts.Text = Localizer.GetString("MenuitemConfirmRestarts")
        OpenFileDialog1.Filter = Localizer.GetString("DialogFileFilter")
        OpenFileDialog1.Title = Localizer.GetString("DialogOpenLevelFile")
    End Sub

    ''' <remarks>
    ''' Builds the grid of cells and sizes the form around it. The grid occupies the client area
    ''' between the menu strip and the status strip, so that all BoardHeight rows are visible.
    ''' </remarks>
    Private Sub BuildBoardCells()
        Dim BoardTop As Integer = Me.MenuStrip1.Height

        Me.ClientSize = New Size(
            BoardWidth * CellSizeInPixels,
            BoardTop + BoardHeight * CellSizeInPixels + Me.StatusStrip1.Height)

        For pic As Integer = BoardFirstIndex To BoardCellCount
            Dim Row As Integer = (pic - BoardFirstIndex) \ BoardWidth
            Dim Column As Integer = (pic - BoardFirstIndex) Mod BoardWidth

            CellPictures(pic) = New PictureBox
            With CellPictures(pic)
                .Size = New Size(CellSizeInPixels, CellSizeInPixels)
                .Location = New Point(
                    Column * CellSizeInPixels,
                    BoardTop + Row * CellSizeInPixels)
                .BackColor = My.Settings.BackgroundColor
            End With
            Me.Controls.Add(CellPictures(pic))
        Next
    End Sub

    ''' <remarks>
    ''' Brings every piece of chrome back in line with the game state: labels, window title, both
    ''' progress bars and the menu items whose availability depends on that state. Called after
    ''' anything that changes the game, so no caller has to remember which parts to update.
    ''' </remarks>
    Private Sub RefreshStatusBar()
        MovesLabel.Text = Localizer.GetString("LabelMoves") & MovesPerformed
        PushesLabel.Text = Localizer.GetString("LabelPushes") & PushesPerformed

        Me.Text = CurrentGameTitle

        ' Progress towards the goal squares, matching the rule that decides the level is solved.
        SetProgress(Me.LevelProgressBar,
                    NumberOfCoveredGoalsOnCurrentLevel,
                    NumberOfGoalsOnCurrentLevel)

        ' Scaled to the size of the set actually loaded, which a set opened from a file may set
        ' to anything.
        SetProgress(Me.LevelsetProgressBar, CurrentLevelNumber, NumberOfLevelsInCurrentLevelset)

        RefreshMenuState()
    End Sub

    ''' <remarks>
    ''' Menu availability follows the game state, so that the shortcut keys behave the same way
    ''' whether or not the menu holding them has been opened.
    ''' </remarks>
    Private Sub RefreshMenuState()
        Me.MenuitemUndo.Enabled = CanUndo()
        Me.MenuitemRestart.Enabled = NumberOfLevelsInCurrentLevelset > 0
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
        If Not IsOnBoard(cellIndex) Then
            Exit Sub
        End If

        If BoardCell(cellIndex) < CInt(BoardItem.BlankOuter) Then
            Me.CellPictures(cellIndex).Image = Skrzynki.Skin.GetIcon(BoardCell(cellIndex))
        Else
            Me.CellPictures(cellIndex).Image = Nothing
        End If
    End Sub

    Public Sub RefreshBoard()
        For Counter As Integer = BoardFirstIndex To BoardCellCount
            RefreshCell(Counter)
        Next Counter
    End Sub

    Public Sub RefreshCellsAroundPlayer()
        RefreshCell(CurrentPlayerLocation - BoardWidth)
        RefreshCell(CurrentPlayerLocation - 1)
        RefreshCell(CurrentPlayerLocation)
        RefreshCell(CurrentPlayerLocation + 1)
        RefreshCell(CurrentPlayerLocation + BoardWidth)
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

        If Not TryMovePlayer(Direction) Then
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

        While IsCurrentLevelSolved() AndAlso LevelsCompleted <= NumberOfLevelsInCurrentLevelset
            LevelsCompleted += 1

            ' Banked before advancing, for every solved level including the last one of a set.
            RecordProgressForSolvedLevel()

            ' Read before the level changes: advancing and restarting both clear the history the
            ' solution is written from.
            Dim Choice As LevelSolvedChoice = AskWhatToDoNext()

            If Choice = LevelSolvedChoice.RepeatLevel Then
                RestartLevel()
            ElseIf Not AdvanceToNextLevel() Then
                ShowMessage(Localizer.GetString("AlertAllLevelsSolved"), MsgBoxStyle.Information)

                ' Finishing a set opened from a file drops back to the built-in one named in the
                ' settings.
                If Not NewGame(1) Then
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
            Solved.PresentSolvedLevel(CurrentAttemptLurd,
                                      MovesPerformed,
                                      PushesPerformed,
                                      CurrentLevelsetDisplayName,
                                      CurrentLevelNumber)
            Solved.ShowDialog(Me)

            Return Solved.Choice
        End Using
    End Function


    ''' <remarks>
    ''' The only Load handler. Everything here runs in order, and the steps after BuildBoardCells
    ''' depend on the cells it builds - VB does not define the order two handlers of one event run
    ''' in, so this sequence must stay in a single handler.
    ''' </remarks>
    Private Sub GameBoardForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ApplyLocalizationResources()
        BuildBoardCells()

        Me.Icon = My.Resources.ico101
        Me.BackColor = Color.Black

        ' SelectBuiltInLevelset applies the BeginFromArrivedLevel setting and falls back to the
        ' first level when saved progress points past the end of the set.
        Dim SuccessfulNewGame As Boolean = StartGame()

        If Not SuccessfulNewGame Then
            ShowMessage(Localizer.GetString("AlertLevelsetLoadFailure"), MsgBoxStyle.Critical)
        End If

        RefreshBoard()
        RefreshStatusBar()
        Me.Visible = True

        ' A level that arrives already solved has to be noticed here too, not only after a move.
        CompleteLevelWhileSolved()
    End Sub

    Private Sub GameBoardForm_Close(sender As Object, e As EventArgs) Handles MyBase.Closed
        My.Settings.Save()
        Application.Exit()
    End Sub

    Private Sub MenuitemQuit_Click(sender As Object, e As EventArgs) Handles MenuitemQuit.Click
        My.Settings.Save()
        Application.Exit()
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
            StatisticsWindow = New StatsOptsForm()
        End If

        StatisticsWindow.Show(Me)
        StatisticsWindow.BringToFront()
    End Sub

    Private Sub MenuitemRestart_Click(sender As Object, e As EventArgs) Handles MenuitemRestart.Click
        If My.Settings.LevelRestartingAuthorization AndAlso
           ShowMessage(Localizer.GetString("QueryRestartLevel"),
                       MsgBoxStyle.YesNo Or MsgBoxStyle.Question) <> MsgBoxResult.Yes Then
            Exit Sub
        End If

        RestartLevel()
        RefreshBoard()
        RefreshStatusBar()
    End Sub

    Private Sub MenuitemUndo_Click(sender As Object, e As EventArgs) Handles MenuitemUndo.Click
        Undo()
        RefreshBoard()
        RefreshStatusBar()
    End Sub
End Class
