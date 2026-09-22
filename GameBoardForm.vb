Imports System.Globalization

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
    ''' Builds the grid of cells and sizes the form around it. The grid starts below the menu
    ''' strip and ends above the status strip: laying it out from the top of the client area
    ''' hid its first row behind the menu, which clipped the top wall of every level tall enough
    ''' to reach row 0 (Classic 54 to 60).
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

    <CodeAnalysis.SuppressMessage("Microsoft.Globalization", "CA1303:Do not pass literals as localized parameters", MessageId:="System.Windows.Forms.Form.set_Text(System.String)")>
    Private Sub RefreshStatusBar()
        MovesLabel.Text = Localizer.GetString("LabelMoves") & MovesPerformedOnCurrentLevel
        PushesLabel.Text = Localizer.GetString("LabelPushes") & PushesPerformedOnCurrentLevel
        If ExternalCustomLevel Then
            Dim FnCore As String() = 倉庫番.FileName.Split(CType("\", Char))
            Text = Localizer.GetString("GameName") &
                " (" & FnCore(FnCore.Length - 1) & "): #" &
                CurrentlyPlayedLevelId.ToString(CultureInfo.InvariantCulture)

        Else
            Text = Localizer.GetString("GameName") &
                " (" & My.Settings.LevelSet & "): #" &
                CurrentlyPlayedLevelId.ToString(CultureInfo.InvariantCulture)
        End If

        SetProgress(Me.LevelProgressBar,
                    GameBoardDetails.GetNumberOfPlacedBoxesOnBoard(GameBoard),
                    GameBoardDetails.GetTotalNumberOfBoxesOnBoard(GameBoard))

        ' The levelset size is whatever was actually parsed, not a fixed 60: XS parsed to 61 for
        ' years, and a levelset opened from a file can be any size at all.
        SetProgress(Me.LevelsetProgressBar, CurrentlyPlayedLevelId, SizeOfCurrentLevelset)
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

        If GameBoard(cellIndex) < CInt(BoardItem.BlankOuter) Then
            Me.imgGameField(cellIndex).Image = Skrzynki.Skin.GetIcon(GameBoard(cellIndex))
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
        RefreshCell(PlayerLocation - BoardWidth)
        RefreshCell(PlayerLocation - 1)
        RefreshCell(PlayerLocation)
        RefreshCell(PlayerLocation + 1)
        RefreshCell(PlayerLocation + BoardWidth)
    End Sub


    Private Sub FrmMain_KeyDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        Dim KeyCode As Windows.Forms.Keys = eventArgs.KeyCode
        If KeyCode = System.Windows.Forms.Keys.Left Or
            KeyCode = System.Windows.Forms.Keys.Right Or
            KeyCode = System.Windows.Forms.Keys.Up Or
            KeyCode = System.Windows.Forms.Keys.Down Then
            If PrzesunGracza(KeyCode) Then
                Call RefreshBoardNearItemsOnly()
                Call RefreshStatusBar()

                If MoveHasJustBeenPerformed = True Then
                    Me.MenuitemUndo.Enabled = True
                End If

                If GameBoardDetails.GetNumberOfPlacedBoxesOnBoard(GameBoard) =
                    GameBoardDetails.GetTotalNumberOfBoxesOnBoard(GameBoard) Then
                    MsgBox(Localizer.GetString("AlertLevelSolved"),
                           MsgBoxStyle.OkOnly Or
                           MsgBoxStyle.Information Or
                           MsgBoxStyle.ApplicationModal,
                           System.Reflection.Assembly.GetExecutingAssembly.GetName.Name)
                    LevelCleared = True
                    ClearUndoHistory()
                    CurrentlyPlayedLevelId += 1

                    If CurrentlyPlayedLevelId > SizeOfCurrentLevelset OrElse Not LoadNextLevel() Then
                        MsgBox(Localizer.GetString("AlertAllLevelsSolved"),
                               MsgBoxStyle.OkOnly Or
                               MsgBoxStyle.Information Or
                               MsgBoxStyle.ApplicationModal,
                               System.Reflection.Assembly.GetExecutingAssembly.GetName.Name)
                        ' Todo: select Klasyczne jeżeli to był custom
                        NewGame(1)
                    End If

                    Me.MenuitemUndo.Enabled = False
                    Call RefreshBoard()
                    Call RefreshStatusBar()
                End If
            Else
                Interaction.Beep()
            End If
        End If
    End Sub


    ''' <remarks>
    ''' The single Load handler. GenerateGameField used to be a second one, and everything below
    ''' it depends on the cells it builds - VB does not define the order two handlers of the same
    ''' event run in, so that only ever worked by luck.
    ''' </remarks>
    Private Sub GameBoardForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call ApplyLocalizationResources()
        Call GenerateGameField()

        Me.Icon = My.Resources.ico101
        Me.Text = Localizer.GetString("GameName") & Localizer.GetString("LabelShortPauseAndNumberID") & CurrentlyPlayedLevelId

        LevelParser.LoadAllLevelsets()

        CurrentlyPlayedLevelId = 1
        MoveHasJustBeenPerformed = False
        LevelCleared = False

        Me.BackColor = Color.Black

        Dim SuccessfulNewGame As Boolean
        If My.Settings.BeginFromArrivedLevel = True Then
            SuccessfulNewGame = NewGame(GetArrivedLevel())
        Else
            SuccessfulNewGame = NewGame(1)
        End If

        ' Falling back to the first level keeps the game playable when the saved progress points
        ' past the end of the set.
        If Not SuccessfulNewGame Then
            SuccessfulNewGame = NewGame(1)
        End If

        If Not SuccessfulNewGame Then
            MsgBox(Localizer.GetString("AlertLevelsetLoadFailure"),
                   MsgBoxStyle.OkOnly Or
                   MsgBoxStyle.Critical Or
                   MsgBoxStyle.ApplicationModal,
                   System.Reflection.Assembly.GetExecutingAssembly.GetName.Name)
        End If

        RefreshBoard()
        Me.MenuitemUndo.Enabled = False
        RefreshStatusBar()
        Me.Visible = True
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

        Dim Levelset As Levelset = LevelParser.GetLevelset(My.Settings.LevelSet)
        If Levelset Is Nothing Then
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

        If (Val(IB) > Val(CStr(GetArrivedLevel()))) And (Val(IB) <= Levelset.NumberOfLevels) Then
            MsgBox(Localizer.GetString("AlertLevelNotReachedYet"),
                   MsgBoxStyle.OkOnly Or
                   MsgBoxStyle.Critical Or
                   MsgBoxStyle.ApplicationModal,
                   System.Reflection.Assembly.GetExecutingAssembly.GetName.Name)
            Exit Sub
        Else
            If Val(IB) > Levelset.NumberOfLevels Or Val(IB) <= 0 Then
                MsgBox(Localizer.GetString("AlertNotANumber"),
                       MsgBoxStyle.OkOnly Or
                       MsgBoxStyle.Critical Or
                       MsgBoxStyle.ApplicationModal,
                       System.Reflection.Assembly.GetExecutingAssembly.GetName.Name)
                Exit Sub
            End If

            ' Going through NewGame rather than assigning the board directly is what clears the
            ' undo history and the move counters. Without that, Ctrl+Z after switching levels
            ' restored the board of the level you came from.
            If Not NewGame(CInt(Val(IB))) Then
                MsgBox(Localizer.GetString("AlertLevelDoesNotExist"),
                       MsgBoxStyle.OkOnly Or
                       MsgBoxStyle.Critical Or
                       MsgBoxStyle.ApplicationModal,
                       System.Reflection.Assembly.GetExecutingAssembly.GetName.Name)
                Exit Sub
            End If

            Me.MenuitemUndo.Enabled = False
            Call RefreshStatusBar()
            Me.Text = Localizer.GetString("GameName") & Localizer.GetString("LabelShortPauseAndNumberID") & CurrentlyPlayedLevelId
            RefreshBoard()
        End If
    End Sub

    Private Sub MenuitemTools_Click(sender As Object, e As EventArgs) Handles MenuitemTools.Click
        If MoveHasJustBeenPerformed Then MenuitemUndo.Enabled = True Else MenuitemUndo.Enabled = False
        If ExternalCustomLevel = False Then MenuitemRestart.Enabled = True Else MenuitemRestart.Enabled = False
    End Sub

    ''' <remarks>
    ''' The custom set is only registered, and the game only switched over to it, once it is known
    ''' to hold a playable level. Nothing about the game in progress changes before that point, so
    ''' a bad file leaves the current level alone instead of half-loading over it.
    ''' </remarks>
    Private Sub MenuitemOpenLevel_Click(sender As Object, e As EventArgs) Handles ZPlikuToolStripMenuItem.Click
        If OpenFileDialog1.ShowDialog() <> DialogResult.OK Then
            Exit Sub
        End If

        Dim SelectedFileName As String = OpenFileDialog1.FileName
        Dim LevelsetCustomInput As ArrayList

        Try
            LevelsetCustomInput = LevelParser.PullAllLevels(SelectedFileName, True)
        Catch ex As System.IO.IOException
            ShowLevelFileError()
            Exit Sub
        Catch ex As UnauthorizedAccessException
            ShowLevelFileError()
            Exit Sub
        End Try

        Dim LevelsetCustom As New Levelset(LevelParser.CustomLevelsetName, True)
        LevelsetCustom.AddAllLevels(LevelsetCustomInput)

        If LevelsetCustom.NumberOfLevels < 1 Then
            ShowLevelFileError()
            Exit Sub
        End If

        If Levelsets.ContainsKey(LevelParser.CustomLevelsetName) Then
            Levelsets.Remove(LevelParser.CustomLevelsetName)
        End If
        Levelsets.Add(LevelParser.CustomLevelsetName, LevelsetCustom)

        ' Starts at level 1 of the new set. Carrying the previous level number over meant opening
        ' a short file while deep into a long one asked for a level that does not exist.
        If Not StartCustomLevelset() Then
            Levelsets.Remove(LevelParser.CustomLevelsetName)
            ShowLevelFileError()
            Exit Sub
        End If

        FileName = SelectedFileName

        MenuitemLevelsetClassic.Checked = False
        MenuitemLevelsetXS.Checked = False
        ZPlikuToolStripMenuItem.Checked = True
        Me.MenuitemUndo.Enabled = False

        If My.Settings.LevelLoadConfirmation = True Then
            MsgBox((Localizer.GetString("AlertLevelFromFileLoadSuccess") & FileName),
                   MsgBoxStyle.OkOnly Or
                   MsgBoxStyle.Information Or
                   MsgBoxStyle.ApplicationModal,
                   System.Reflection.Assembly.GetExecutingAssembly.GetName.Name)
        End If

        RefreshBoard()
        Call RefreshStatusBar()
    End Sub

    Private Shared Sub ShowLevelFileError()
        MsgBox(Localizer.GetString("AlertLevelEmptyOrBad"),
               MsgBoxStyle.Exclamation Or MsgBoxStyle.ApplicationModal,
               System.Reflection.Assembly.GetExecutingAssembly.GetName.Name)
    End Sub

    Private Sub MenuitemLevelset_Click(sender As Object, e As EventArgs) Handles MenuitemLevelset.Click
        If My.Settings.LevelSet = "Classic" Then
            MenuitemLevelsetClassic.Checked = True
            MenuitemLevelsetXS.Checked = False
        Else
            MenuitemLevelsetClassic.Checked = False
            MenuitemLevelsetXS.Checked = True
        End If
    End Sub

    Private Sub MenuitemLevelset_Hover(sender As Object, e As EventArgs) Handles MenuitemLevelset.MouseHover
        If ExternalCustomLevel Then
            MenuitemLevelsetClassic.Checked = False
            MenuitemLevelsetXS.Checked = False
            ZPlikuToolStripMenuItem.Checked = True
        Else
            ZPlikuToolStripMenuItem.Checked = False
            If My.Settings.LevelSet = "Classic" Then
                MenuitemLevelsetClassic.Checked = True
                MenuitemLevelsetXS.Checked = False
            Else
                MenuitemLevelsetClassic.Checked = False
                MenuitemLevelsetXS.Checked = True
            End If
        End If
    End Sub

    Private Sub MenuitemLevelsetClassic_Click(sender As Object, e As EventArgs) Handles MenuitemLevelsetClassic.Click
        My.Settings.LevelSet = "Classic"
        MenuitemLevelsetClassic.Checked = True
        MenuitemLevelsetXS.Checked = False
        ' Todo najdalszy
        NewGame(1)

        RefreshBoard()
        Me.MenuitemUndo.Enabled = False
        Call RefreshStatusBar()
        Me.Text = System.Reflection.Assembly.GetExecutingAssembly.GetName.Name & Localizer.GetString("LabelShortPauseAndNumberID") & CurrentlyPlayedLevelId
    End Sub

    Private Sub MenuitemLevelsetXS_Click(sender As Object, e As EventArgs) Handles MenuitemLevelsetXS.Click
        My.Settings.LevelSet = "XS"
        MenuitemLevelsetClassic.Checked = False
        MenuitemLevelsetXS.Checked = True
        ' Todo najdalszy
        NewGame(1)

        RefreshBoard()
        Me.MenuitemUndo.Enabled = False
        Call RefreshStatusBar()
    End Sub

    Private Sub MenuitemGame_Click(sender As Object, e As EventArgs) Handles MenuitemGame.Click
        If ExternalCustomLevel Then
            'MenuitemOpenLevel.Enabled = False
        Else
            'MenuitemOpenLevel.Enabled = True
        End If
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