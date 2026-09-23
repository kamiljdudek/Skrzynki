Public Class GameBoardForm
    ' Parallel to GameBoard: see the board indexing convention in 倉庫番.vb. Cells occupy
    ' BoardFirstIndex through BoardCellCount; index 0 is unused.
    ReadOnly imgGameField(BoardCellCount) As System.Windows.Forms.PictureBox

    Private Const CellSizeInPixels As Integer = 32

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
        Me.ZPlikuToolStripMenuItem.Text = Localizer.GetString("MenuitemOpenLevelFile")
        Me.MenuitemTools.Text = Localizer.GetString("MenuitemTools")
        Me.MenuitemUndo.Text = Localizer.GetString("MenuitemUndo")
        Me.MenuitemView.Text = Localizer.GetString("MenuitemView")
        Me.MenuitemSkinOrig.Text = Localizer.GetString("LabelSkinOriginal")
        Me.MenuitemSkinExport.Text = Localizer.GetString("LabelSkinExport")
        Me.MenuitemSkinCheese.Text = Localizer.GetString("LabelSkinCheese")
        Me.MenuitemOptions.Text = Localizer.GetString("MenuitemOptions")
        Me.MenuitemSelectLevel.Text = Localizer.GetString("MenuitemSelectLevel")
        Me.MenuitemLevelset.Text = Localizer.GetString("MenuitemSelectLevelSet")
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
    Private Sub GenerateGameField()
        Dim BoardTop As Integer = Me.MenuStrip1.Height

        Me.ClientSize = New Size(
            BoardWidth * CellSizeInPixels,
            BoardTop + BoardHeight * CellSizeInPixels + Me.StatusStrip1.Height)

        For pic As Integer = BoardFirstIndex To BoardCellCount
            Dim Row As Integer = (pic - BoardFirstIndex) \ BoardWidth
            Dim Column As Integer = (pic - BoardFirstIndex) Mod BoardWidth

            imgGameField(pic) = New PictureBox
            With imgGameField(pic)
                .Size = New Size(CellSizeInPixels, CellSizeInPixels)
                .Location = New Point(
                    Column * CellSizeInPixels,
                    BoardTop + Row * CellSizeInPixels)
                .BackColor = My.Settings.BackgroundColor
            End With
            Me.Controls.Add(imgGameField(pic))
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

        Call RefreshMenuState()
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
    Private Shared Sub SetProgress(ByVal bar As ToolStripProgressBar,
                                   ByVal value As Integer,
                                   ByVal maximum As Integer)
        bar.Maximum = Math.Max(1, maximum)
        bar.Value = Math.Max(bar.Minimum, Math.Min(value, bar.Maximum))
    End Sub

    ''' <remarks>
    ''' Redraws one cell. Indices outside the board are ignored rather than throwing: the
    ''' neighbours of a player standing on the top or bottom row fall off the ends of the array.
    ''' </remarks>
    Private Sub RefreshCell(ByVal cellIndex As Integer)
        If cellIndex < BoardFirstIndex OrElse cellIndex > BoardCellCount Then
            Exit Sub
        End If

        If BoardCell(cellIndex) < CInt(BoardItem.BlankOuter) Then
            Me.imgGameField(cellIndex).Image = Skrzynki.Skin.GetIcon(BoardCell(cellIndex))
        Else
            Me.imgGameField(cellIndex).Image = Nothing
        End If
    End Sub

    Public Sub RefreshBoard()
        For Counter As Integer = BoardFirstIndex To BoardCellCount
            Me.imgGameField(Counter).BackColor = My.Settings.BackgroundColor
            RefreshCell(Counter)
        Next Counter
    End Sub

    Public Sub RefreshBoardNearItemsOnly()
        RefreshCell(CurrentPlayerLocation - BoardWidth)
        RefreshCell(CurrentPlayerLocation - 1)
        RefreshCell(CurrentPlayerLocation)
        RefreshCell(CurrentPlayerLocation + 1)
        RefreshCell(CurrentPlayerLocation + BoardWidth)
    End Sub


    Private Sub FrmMain_KeyDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        Dim KeyCode As Windows.Forms.Keys = eventArgs.KeyCode
        If KeyCode <> System.Windows.Forms.Keys.Left AndAlso
           KeyCode <> System.Windows.Forms.Keys.Right AndAlso
           KeyCode <> System.Windows.Forms.Keys.Up AndAlso
           KeyCode <> System.Windows.Forms.Keys.Down Then
            Exit Sub
        End If

        If Not TryMovePlayer(KeyCode) Then
            Interaction.Beep()
            Exit Sub
        End If

        Call RefreshBoardNearItemsOnly()
        Call RefreshStatusBar()
        Call CompleteLevelWhileSolved()
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

            MsgBox(Localizer.GetString("AlertLevelSolved"),
                   MsgBoxStyle.OkOnly Or
                   MsgBoxStyle.Information Or
                   MsgBoxStyle.ApplicationModal,
                   System.Reflection.Assembly.GetExecutingAssembly.GetName.Name)

            If Not AdvanceToNextLevel() Then
                MsgBox(Localizer.GetString("AlertAllLevelsSolved"),
                       MsgBoxStyle.OkOnly Or
                       MsgBoxStyle.Information Or
                       MsgBoxStyle.ApplicationModal,
                       System.Reflection.Assembly.GetExecutingAssembly.GetName.Name)

                ' Finishing a set opened from a file drops back to the built-in one named in the
                ' settings.
                If Not NewGame(1) Then
                    Exit While
                End If
            End If

            Call RefreshBoard()
            Call RefreshStatusBar()
        End While
    End Sub


    ''' <remarks>
    ''' The only Load handler. Everything here runs in order, and the steps after GenerateGameField
    ''' depend on the cells it builds - VB does not define the order two handlers of one event run
    ''' in, so this sequence must stay in a single handler.
    ''' </remarks>
    Private Sub GameBoardForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call ApplyLocalizationResources()
        Call GenerateGameField()

        Me.Icon = My.Resources.ico101
        Me.BackColor = Color.Black

        ' SelectBuiltInLevelset applies the BeginFromArrivedLevel setting and falls back to the
        ' first level when saved progress points past the end of the set.
        Dim SuccessfulNewGame As Boolean = StartGame()

        If Not SuccessfulNewGame Then
            MsgBox(Localizer.GetString("AlertLevelsetLoadFailure"),
                   MsgBoxStyle.OkOnly Or
                   MsgBoxStyle.Critical Or
                   MsgBoxStyle.ApplicationModal,
                   System.Reflection.Assembly.GetExecutingAssembly.GetName.Name)
        End If

        RefreshBoard()
        RefreshStatusBar()
        Me.Visible = True

        ' A level that arrives already solved has to be noticed here too, not only after a move.
        Call CompleteLevelWhileSolved()
    End Sub

    Private Sub GameBoardForm_Close(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Closed
        My.Settings.Save()
        Application.Exit()
    End Sub

    Private Sub MenuitemQuit_Click(sender As Object, e As EventArgs) Handles MenuitemQuit.Click
        My.Settings.Save()
        Application.Exit()
    End Sub

    Private Sub MenuitemAbout_Click(sender As Object, e As EventArgs) Handles MenuitemAbout.Click
        SplashScreen.ShowDialog(Me)
    End Sub

    Private Sub MenuitemRefresh_Click(sender As Object, e As EventArgs) Handles MenuitemRefresh.Click
        Call RefreshBoard()
    End Sub

    Private Sub MenuitemOptions_Click(sender As Object, e As EventArgs) Handles MenuitemOptions.Click
        StatsOptsForm.Show()
    End Sub

    Private Sub MenuitemRestart_Click(sender As Object, e As EventArgs) Handles MenuitemRestart.Click
        If My.Settings.LevelRestartingAuthorization = True Then
            Dim TempX As MsgBoxResult =
                MsgBox(Localizer.GetString("QueryRestartLevel"),
                        MsgBoxStyle.YesNo Or
                        MsgBoxStyle.Question Or
                        MsgBoxStyle.ApplicationModal,
                        System.Reflection.Assembly.GetExecutingAssembly.GetName.Name)

            If TempX = MsgBoxResult.Yes Then
                RestartLevel()
                RefreshBoard()
            End If
        Else
            RestartLevel()
            RefreshBoard()
        End If

        Me.MenuitemUndo.Enabled = False
        Call RefreshStatusBar()
    End Sub

    Private Sub MenuitemColor_Click(sender As Object, e As EventArgs) Handles MenuitemColor.Click
        If ColorDialog1.ShowDialog() = DialogResult.OK Then
            My.Settings.BackgroundColor = ColorDialog1.Color
            RefreshBoard()
        End If
    End Sub

    Private Sub MenuitemUndo_Click(sender As Object, e As EventArgs) Handles MenuitemUndo.Click
        Undo()
        RefreshBoard()
        RefreshStatusBar()
        'LOLMe.MenuitemUndo.Enabled = False
    End Sub

    Private Sub MenuitemOriginal_Click(sender As Object, e As EventArgs)
        MenuitemSkinCheese.Checked = False
        MenuitemSkinExport.Checked = False
        MenuitemSkinOrig.Checked = True
        My.Settings.Skin = "(Oryginalny)"
        RefreshBoard()
    End Sub

    Private Sub MenuitemExport_Click(sender As Object, e As EventArgs)
        MenuitemSkinCheese.Checked = False
        MenuitemSkinExport.Checked = True
        MenuitemSkinOrig.Checked = False
        My.Settings.Skin = "Eksport"
        RefreshBoard()
    End Sub

    Private Sub MenuitemCheese_Click(sender As Object, e As EventArgs)
        MenuitemSkinCheese.Checked = True
        MenuitemSkinExport.Checked = False
        MenuitemSkinOrig.Checked = False
        My.Settings.Skin = "Serowy"
        RefreshBoard()
    End Sub

    Private Sub MenuitemSelectLevel_Click(sender As Object, e As EventArgs) Handles MenuitemSelectLevel.Click
        Dim IB As String = InputBox(Localizer.GetString("QuerySelectLevel"),
                                    System.Reflection.Assembly.GetExecutingAssembly.GetName.Name,
                                    CStr(GetArrivedLevel()))
        If IB = "" Then
            Exit Sub
        End If

        If IsNumeric(IB) = False Then
            MsgBox(Localizer.GetString("AlertNotANumber"),
                   MsgBoxStyle.OkOnly Or
                   MsgBoxStyle.Critical Or
                   MsgBoxStyle.ApplicationModal,
                   System.Reflection.Assembly.GetExecutingAssembly.GetName.Name)
            Exit Sub
        End If

        Dim RequestedLevel As Integer = CInt(Val(IB))

        If RequestedLevel > GetArrivedLevel() AndAlso
           RequestedLevel <= NumberOfLevelsInCurrentLevelset Then
            MsgBox(Localizer.GetString("AlertLevelNotReachedYet"),
                   MsgBoxStyle.OkOnly Or
                   MsgBoxStyle.Critical Or
                   MsgBoxStyle.ApplicationModal,
                   System.Reflection.Assembly.GetExecutingAssembly.GetName.Name)
            Exit Sub
        End If

        ' NewGame clears the undo history and the move counters along with loading the board, and
        ' rejects a level number outside the set.
        If Not NewGame(RequestedLevel) Then
            MsgBox(Localizer.GetString("AlertLevelDoesNotExist"),
                   MsgBoxStyle.OkOnly Or
                   MsgBoxStyle.Critical Or
                   MsgBoxStyle.ApplicationModal,
                   System.Reflection.Assembly.GetExecutingAssembly.GetName.Name)
            Exit Sub
        End If

        RefreshBoard()
        Call RefreshStatusBar()
        Call CompleteLevelWhileSolved()
    End Sub

    ''' <remarks>
    ''' The custom set is registered, and the game switched over to it, only once it is known to
    ''' hold a playable level, so an unusable file leaves the game in progress untouched.
    ''' </remarks>
    Private Sub MenuitemOpenLevel_Click(sender As Object, e As EventArgs) Handles ZPlikuToolStripMenuItem.Click
        If OpenFileDialog1.ShowDialog() <> DialogResult.OK Then
            Exit Sub
        End If

        Dim SelectedFileName As String = OpenFileDialog1.FileName

        If Not OpenLevelsetFromFile(SelectedFileName) Then
            ShowLevelFileError()
            Exit Sub
        End If

        MenuitemLevelsetClassic.Checked = False
        MenuitemLevelsetXS.Checked = False
        ZPlikuToolStripMenuItem.Checked = True

        If My.Settings.LevelLoadConfirmation = True Then
            MsgBox((Localizer.GetString("AlertLevelFromFileLoadSuccess") & SelectedFileName),
                   MsgBoxStyle.OkOnly Or
                   MsgBoxStyle.Information Or
                   MsgBoxStyle.ApplicationModal,
                   System.Reflection.Assembly.GetExecutingAssembly.GetName.Name)
        End If

        RefreshBoard()
        Call RefreshStatusBar()
        Call CompleteLevelWhileSolved()
    End Sub

    Private Shared Sub ShowLevelFileError()
        MsgBox(Localizer.GetString("AlertLevelEmptyOrBad"),
               MsgBoxStyle.Exclamation Or MsgBoxStyle.ApplicationModal,
               System.Reflection.Assembly.GetExecutingAssembly.GetName.Name)
    End Sub

    Private Sub MenuitemLevelset_Click(sender As Object, e As EventArgs) Handles MenuitemLevelset.Click
        Call RefreshLevelsetChecks()
    End Sub

    Private Sub MenuitemLevelset_Hover(sender As Object, e As EventArgs) Handles MenuitemLevelset.MouseHover
        Call RefreshLevelsetChecks()
    End Sub

    Private Sub RefreshLevelsetChecks()
        ZPlikuToolStripMenuItem.Checked = IsPlayingCustomLevelset()
        MenuitemLevelsetClassic.Checked =
            Not IsPlayingCustomLevelset() AndAlso My.Settings.LevelSet = "Classic"
        MenuitemLevelsetXS.Checked =
            Not IsPlayingCustomLevelset() AndAlso My.Settings.LevelSet = "XS"
    End Sub

    ''' <remarks>
    ''' Switches levelsets. SelectBuiltInLevelset resumes at the furthest level reached when
    ''' BeginFromArrivedLevel is set, and restores the previous set if the requested one cannot
    ''' be loaded.
    ''' </remarks>
    Private Sub SwitchToBuiltInLevelset(ByVal levelsetName As String)
        If Not SelectBuiltInLevelset(levelsetName) Then
            MsgBox(Localizer.GetString("AlertLevelsetLoadFailure"),
                   MsgBoxStyle.OkOnly Or
                   MsgBoxStyle.Critical Or
                   MsgBoxStyle.ApplicationModal,
                   System.Reflection.Assembly.GetExecutingAssembly.GetName.Name)
            Exit Sub
        End If

        Call RefreshLevelsetChecks()
        RefreshBoard()
        Call RefreshStatusBar()
        Call CompleteLevelWhileSolved()
    End Sub

    Private Sub MenuitemLevelsetClassic_Click(sender As Object, e As EventArgs) Handles MenuitemLevelsetClassic.Click
        Call SwitchToBuiltInLevelset("Classic")
    End Sub

    Private Sub MenuitemLevelsetXS_Click(sender As Object, e As EventArgs) Handles MenuitemLevelsetXS.Click
        Call SwitchToBuiltInLevelset("XS")
    End Sub

    Private Sub MenuitemHide_Click(sender As Object, e As EventArgs) Handles MenuitemHide.Click
        SkrzynkiTrayIcon.Visible = True
        SkrzynkiTrayIcon.Text = Localizer.GetString("LabelTrayDescription")
        SkrzynkiTrayIcon.BalloonTipText = Localizer.GetString("LabelTrayDescription")
        Me.Visible = False
    End Sub

    Private Sub SkrzynkiTrayIcon_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles SkrzynkiTrayIcon.MouseDoubleClick
        SkrzynkiTrayIcon.Visible = False
        Me.Visible = True
    End Sub

    Private Sub SkrzynkiTrayIcon_MouseClick(sender As Object, e As MouseEventArgs) Handles SkrzynkiTrayIcon.MouseClick
        SkrzynkiTrayIcon.Visible = False
        Me.Visible = True
    End Sub

    Private Sub MenuitemSkinOrig_Click(sender As Object, e As EventArgs) Handles MenuitemSkinOrig.Click
        MenuitemSkinOrig.Checked = True
        MenuitemSkinCheese.Checked = False
        MenuitemSkinExport.Checked = False
        My.Settings.Skin = "(Oryginalny)"
        RefreshBoard()
    End Sub

    Private Sub MenuitemSkinExport_Click(sender As Object, e As EventArgs) Handles MenuitemSkinExport.Click
        MenuitemSkinOrig.Checked = False
        MenuitemSkinCheese.Checked = False
        MenuitemSkinExport.Checked = True
        My.Settings.Skin = "Eksport"
        RefreshBoard()
    End Sub

    Private Sub MenuitemSkinCheese_Click(sender As Object, e As EventArgs) Handles MenuitemSkinCheese.Click
        MenuitemSkinOrig.Checked = False
        MenuitemSkinCheese.Checked = True
        MenuitemSkinExport.Checked = False
        My.Settings.Skin = "Serowy"
        RefreshBoard()
    End Sub

    Private Sub MenuitemSkins_Click(sender As Object, e As EventArgs) Handles MenuitemSkins.MouseHover
        If My.Settings.Skin = "(Oryginalny)" Then
            MenuitemSkinOrig.Checked = True
            MenuitemSkinCheese.Checked = False
            MenuitemSkinExport.Checked = False
        ElseIf My.Settings.Skin = "Serowy" Then
            MenuitemSkinOrig.Checked = False
            MenuitemSkinCheese.Checked = True
            MenuitemSkinExport.Checked = False
        Else
            MenuitemSkinOrig.Checked = False
            MenuitemSkinCheese.Checked = False
            MenuitemSkinExport.Checked = True
        End If
    End Sub

    Private Sub MenuitemView_Click(sender As Object, e As EventArgs) Handles MenuitemView.Click
        If My.Settings.LevelRestartingAuthorization = True Then
            MenuitemConfirmRestarts.Checked = True
        Else
            MenuitemConfirmRestarts.Checked = False
        End If
    End Sub


    Private Sub MenuitemConfirmRestarts_CheckStateChanged(sender As Object, e As EventArgs) Handles MenuitemConfirmRestarts.CheckStateChanged
        If MenuitemConfirmRestarts.Checked = True Then
            My.Settings.LevelRestartingAuthorization = True
        Else
            My.Settings.LevelRestartingAuthorization = False
        End If
    End Sub

    Private Sub MenuitemConfirmRestarts_Click(sender As Object, e As EventArgs) Handles MenuitemConfirmRestarts.Click
        If MenuitemConfirmRestarts.Checked = True Then
            MenuitemConfirmRestarts.Checked = False
        Else
            MenuitemConfirmRestarts.Checked = True
        End If
    End Sub
End Class