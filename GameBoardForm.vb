Imports System.Globalization

Public Class GameBoardForm
    ReadOnly imgGameField(256) As System.Windows.Forms.PictureBox
    Friend WithEvents SkrzynkiTrayIcon As NotifyIcon
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
        Me.SkrzynkiTrayIcon1.Text = Localizer.GetString("GameName")
        Me.MenuitemConfirmRestarts.Text = Localizer.GetString("MenuitemConfirmRestarts")
        OpenFileDialog1.Filter = Localizer.GetString("DialogFileFilter")
        OpenFileDialog1.Title = Localizer.GetString("DialogOpenLevelFile")
    End Sub

    Private Sub GenerateGameField() Handles Me.Load
        Dim FirstDimension As Integer = 0
        Dim SecondDimension As Integer = 0
        For pic As Integer = 1 To 256
            imgGameField(pic) = New PictureBox
            With imgGameField(pic)
                .Size = New Size(32, 32)
                .Image = My.Resources.ico104.ToBitmap()
                .Location = New Point(FirstDimension, SecondDimension)
                .BackColor = My.Settings.BackgroundColor
            End With
            If pic Mod 16 = 0 Then
                SecondDimension += 32
            End If
            FirstDimension += 32
            If FirstDimension >= 16 * 32 Then
                FirstDimension = 0
            End If
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

        Me.LevelProgressBar.Maximum = GameBoardDetails.GetTotalNumberOfBoxesOnBoard(GameBoard)
        Me.LevelProgressBar.Value = GameBoardDetails.GetNumberOfPlacedBoxesOnBoard(GameBoard)

        Me.LevelsetProgressBar.Maximum = 60
        Me.LevelsetProgressBar.Value = CurrentlyPlayedLevelId
    End Sub

    Public Sub RefreshBoard()
        For Counter As Integer = 1 To 256 Step 1
            Me.imgGameField(Counter).BackColor = My.Settings.BackgroundColor
            If GameBoard(Counter) < 7 Then
                Me.imgGameField(Counter).Image = Skrzynki.Skin.GetIcon(GameBoard(Counter))
            Else
                Me.imgGameField(Counter).Image = Nothing
            End If
        Next Counter
    End Sub

    Public Sub RefreshBoardNearItemsOnly()
        If GameBoard(PlayerLocation - 16) < 7 Then
            Me.imgGameField(PlayerLocation - 16).Image =
                    Skrzynki.Skin.GetIcon(GameBoard(PlayerLocation - 16))
        Else
            Me.imgGameField(PlayerLocation - 16).Image = Nothing
        End If

        If GameBoard(PlayerLocation - 1) < 7 Then
            Me.imgGameField(PlayerLocation - 1).Image =
                    Skrzynki.Skin.GetIcon(GameBoard(PlayerLocation - 1))
        Else
            Me.imgGameField(PlayerLocation - 1).Image = Nothing
        End If

        If GameBoard(PlayerLocation) < 7 Then
            Me.imgGameField(PlayerLocation).Image =
                    Skrzynki.Skin.GetIcon(GameBoard(PlayerLocation))
        Else
            Me.imgGameField(PlayerLocation).Image = Nothing
        End If

        If GameBoard(PlayerLocation + 1) < 7 Then
            Me.imgGameField(PlayerLocation + 1).Image =
                    Skrzynki.Skin.GetIcon(GameBoard(PlayerLocation + 1))
        Else
            Me.imgGameField(PlayerLocation + 1).Image = Nothing
        End If

        If GameBoard(PlayerLocation + 16) < 7 Then
            Me.imgGameField(PlayerLocation + 16).Image =
                    Skrzynki.Skin.GetIcon(GameBoard(PlayerLocation + 16))
        Else
            Me.imgGameField(PlayerLocation + 16).Image = Nothing
        End If

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
                    AllGameBoardStates.Clear()
                    CurrentlyPlayedLevelId += 1

                    If CurrentlyPlayedLevelId > SizeOfCurrentLevelset Then
                        MsgBox(Localizer.GetString("AlertAllLevelsSolved"),
                               MsgBoxStyle.OkOnly Or
                               MsgBoxStyle.Information Or
                               MsgBoxStyle.ApplicationModal,
                               System.Reflection.Assembly.GetExecutingAssembly.GetName.Name)
                        ' Todo: select Klasyczne jeżeli to był custom
                        NewGame(1)
                    Else
                        LoadNextLevel()
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


    Private Sub GameBoardForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call ApplyLocalizationResources()

        Me.Icon = My.Resources.ico101
        Me.Text = Localizer.GetString("GameName") & Localizer.GetString("LabelShortPauseAndNumberID") & CurrentlyPlayedLevelId

        LevelParser.LoadAllLevelsets()
        'AllGameBoardStates = New System.Collections.Generic.List(Of Integer())
        AllGameBoardStates = New System.Collections.ObjectModel.Collection(Of Integer())
        AllPushStates = New System.Collections.ObjectModel.Collection(Of Boolean)

        CurrentlyPlayedLevelId = 1
        MoveHasJustBeenPerformed = False
        LevelCleared = False

        Me.BackColor = Color.Black

        Dim SuccessfulNewGame As Boolean = False
        If ExternalCustomLevel = False Then
            If My.Settings.BeginFromArrivedLevel = True Then
                SuccessfulNewGame = NewGame(GetArrivedLevel())
            Else
                SuccessfulNewGame = NewGame(1)
            End If

            If Not SuccessfulNewGame Then
                MsgBox(Localizer.GetString("LevelsetLoadFailure"),
                       MsgBoxStyle.OkOnly Or
                       MsgBoxStyle.Critical Or
                       MsgBoxStyle.ApplicationModal,
                       System.Reflection.Assembly.GetExecutingAssembly.GetName.Name)
            End If

            RefreshBoard()
            Me.MenuitemUndo.Enabled = False
            RefreshStatusBar()
            Me.Visible = True
        End If
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

        Dim Levelset As Levelset = CType(LevelParser.Levelsets.Item(My.Settings.LevelSet), Levelset)

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

            CurrentlyPlayedLevelId = CInt(Val(IB))
            GameBoard = Levelset.GetLevel(CurrentlyPlayedLevelId)
            Dim Details As LevelProperties = Levelset.GetLevelInitialProperties(CurrentlyPlayedLevelId)
            PlayerLocation = Details.PlayerLocation

            Call RefreshStatusBar()
            Me.Text = Localizer.GetString("GameName") & Localizer.GetString("LabelShortPauseAndNumberID") & CurrentlyPlayedLevelId
            RefreshBoard()
            ExternalCustomLevel = False
        End If
    End Sub

    Private Sub MenuitemTools_Click(sender As Object, e As EventArgs) Handles MenuitemTools.Click
        If MoveHasJustBeenPerformed Then MenuitemUndo.Enabled = True Else MenuitemUndo.Enabled = False
        If ExternalCustomLevel = False Then MenuitemRestart.Enabled = True Else MenuitemRestart.Enabled = False
    End Sub

    Private Sub MenuitemOpenLevel_Click(sender As Object, e As EventArgs) Handles ZPlikuToolStripMenuItem.Click
        If OpenFileDialog1.ShowDialog() <> DialogResult.OK Then
            Exit Sub
        End If

        FileName = OpenFileDialog1.FileName

        If ExternalCustomLevel Then
            ExternalCustomLevel = False
            NewGame(1)
        End If

        MenuitemLevelsetClassic.Checked = False
        MenuitemLevelsetXS.Checked = False
        ZPlikuToolStripMenuItem.Checked = True

        Dim LevelsetCustomInput = LevelParser.PullAllLevels(FileName, True)
        Dim LevelsetCustom As New Levelset(SokobanLevelSet.CustomFromFile.ToString(), True)

        If LevelsetCustomInput.Count > 0 Then
            If My.Settings.LevelLoadConfirmation = True Then
                MsgBox((Localizer.GetString("AlertLevelFromFileLoadSuccess") & FileName),
                       MsgBoxStyle.OkOnly Or
                       MsgBoxStyle.Information Or
                       MsgBoxStyle.ApplicationModal,
                       System.Reflection.Assembly.GetExecutingAssembly.GetName.Name)
            End If

            LevelsetCustom.AddAllLevels(LevelsetCustomInput)

            If Levelsets.ContainsKey("Custom") Then
                Levelsets.Remove("Custom")
            End If
            Levelsets.Add("Custom", LevelsetCustom)
        Else
            MsgBox(Localizer.GetString("AlertLevelEmptyOrBad"), MsgBoxStyle.Exclamation Or MsgBoxStyle.ApplicationModal,
                       System.Reflection.Assembly.GetExecutingAssembly.GetName.Name)
            Exit Sub
        End If

        Call RefreshStatusBar()
        Me.Text = Localizer.GetString("GameName") & Localizer.GetString("LabelShortPauseAndNumberID") & CurrentlyPlayedLevelId

        ' TODO: Somehow merge with LoadNextLevel()
        Dim Levelset As Levelset = LevelParser.GetLevelset("Custom")
        SizeOfCurrentLevelset = Levelset.NumberOfLevels
        RefreshBoard()

        Dim BoardState() As Integer = Levelset.GetLevel(CurrentlyPlayedLevelId)
        If IsNothing(BoardState) Then
            MsgBox(Localizer.GetString("AlertLevelEmptyOrBad"), MsgBoxStyle.Exclamation Or MsgBoxStyle.ApplicationModal,
                       System.Reflection.Assembly.GetExecutingAssembly.GetName.Name)
            NewGame(1)
        Else
            Array.Copy(BoardState, GameBoard, GameBoard.Length)
            PlayerLocation = GameBoardDetails.GetIndexOfPlayerOnBoard(BoardState)
            RefreshBoard()
        End If

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
        SkrzynkiTrayIcon1.Visible = True
        SkrzynkiTrayIcon1.Text = Localizer.GetString("LabelTrayDescription")
        SkrzynkiTrayIcon1.BalloonTipText = Localizer.GetString("LabelTrayDescription")
        Me.Visible = False
    End Sub

    Private Sub NotifyIcon1_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles SkrzynkiTrayIcon1.MouseDoubleClick
        SkrzynkiTrayIcon1.Visible = False
        Me.Visible = True
    End Sub

    Private Sub NotifyIcon1_MouseClick(sender As Object, e As MouseEventArgs) Handles SkrzynkiTrayIcon1.MouseClick
        SkrzynkiTrayIcon1.Visible = False
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