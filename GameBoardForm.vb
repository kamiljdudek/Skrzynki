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
        Me.MenuitemNewGame.Text = Localizer.GetString("MenuitemNewGame")
        Me.MenuitemOpenLevel.Text = Localizer.GetString("MenuitemOpenLevelFile")
        Me.MenuitemOptions.Text = Localizer.GetString("MenuitemOptions")
        Me.MenuitemQuit.Text = Localizer.GetString("MenuitemQuit")
        Me.MenuitemRefresh.Text = Localizer.GetString("MenuitemRefresh")
        Me.MenuitemRestart.Text = Localizer.GetString("MenuitemRestart")
        Me.MenuitemSelectLevel.Text = Localizer.GetString("MenuitemSelectLevel")
        Me.MenuitemOpenLevel.Text = Localizer.GetString("MenuitemOpenLevelFile")
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
        Text = Localizer.GetString("GameName") & " (" & My.Settings.LevelSet & "): #" & CurrentlyPlayedLevelId.ToString(CultureInfo.InvariantCulture)

        Me.LevelProgressBar.Maximum = CurrentLevelStats.NumberOfBoxes
        Me.LevelProgressBar.Value = CurrentLevelStats.BoxesOnPlaces

        Me.LevelsetProgressBar.Maximum = 60
        Me.LevelsetProgressBar.Value = CurrentlyPlayedLevelId
    End Sub

    Public Sub RefreshBoard()
        For Counter = 1 To 256 Step 1
            If GameBoard(Counter) < 7 Then
                Me.imgGameField(Counter).Image = Skrzynki.Skin.GetIcon(GameBoard(Counter))
            Else
                Me.imgGameField(Counter).Image = Nothing
                Me.imgGameField(Counter).BackColor = My.Settings.BackgroundColor
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
                MovesPerformedOnCurrentLevel += 1

                If MoveHasBeenPerformed = False Then
                    MoveHasBeenPerformed = True
                    Me.MenuitemUndo.Enabled = True
                End If

                If CurrentLevelStats.BoxesOnPlaces = CurrentLevelStats.NumberOfBoxes Then
                    MsgBox(Localizer.GetString("AlertLevelSolved"),
                           MsgBoxStyle.OkOnly Or
                           MsgBoxStyle.Information Or
                           MsgBoxStyle.ApplicationModal,
                           System.Reflection.Assembly.GetExecutingAssembly.GetName.Name)
                    LevelCleared = True
                    CurrentlyPlayedLevelId += 1
                    Dim Levelset As Levelset = CType(LevelParser.Levelsets.Item("Classic"), Levelset)

                    If CurrentlyPlayedLevelId > Levelset.NumberOfLevels Then
                        MsgBox(Localizer.GetString("AlertAllLevelsSolved"),
                               MsgBoxStyle.OkOnly Or
                               MsgBoxStyle.Information Or
                               MsgBoxStyle.ApplicationModal,
                               System.Reflection.Assembly.GetExecutingAssembly.GetName.Name)
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
        AllGameBoardStates = New System.Collections.Generic.List(Of Integer())

        CurrentlyPlayedLevelId = 1
        MoveHasBeenPerformed = False
        LevelCleared = False

        Stats.OdczytajStatystyki()

        Me.BackColor = Color.Black

        Dim SuccessfulNewGame As Boolean = False
        If ExternalCustomLevel = False Then
            If My.Settings.BeginFromArrivedLevel = True Then
                SuccessfulNewGame = NewGame((SetArrivedLevel()))
            Else
                SuccessfulNewGame = NewGame((1))
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
        Stats.ZapiszStatystyki()
        End
    End Sub

    Private Sub MenuitemQuit_Click(sender As Object, e As EventArgs) Handles MenuitemQuit.Click
        Call Stats.ZapiszStatystyki()
        End
    End Sub

    Private Sub MenuitemNewGame_Click(sender As Object, e As EventArgs) Handles MenuitemNewGame.Click
        NewGame((1))
        RefreshBoard()
        Me.MenuitemUndo.Enabled = False
        Call RefreshStatusBar()
    End Sub

    Private Sub MenuitemAbout_Click(sender As Object, e As EventArgs) Handles MenuitemAbout.Click
        SplashScreen.Show()
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
        ColorDialog1.ShowDialog()
        My.Settings.BackgroundColor = ColorDialog1.Color
        RefreshBoard()
    End Sub

    Private Sub MenuitemUndo_Click(sender As Object, e As EventArgs) Handles MenuitemUndo.Click
        Undo()
        RefreshBoard()
        RefreshStatusBar()
        Me.MenuitemUndo.Enabled = False
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
                                    CStr(SetArrivedLevel()))
        If IB = "" Then
            Exit Sub
        End If

        Dim ZE As String = Nothing
        If My.Settings.LevelSet = "Klasyczne" Then
            ZE = "Classic"
        ElseIf My.Settings.LevelSet = "SuperTrudneXS" Then
            ZE = "XS"
        End If

        Dim Levelset As Levelset = CType(LevelParser.Levelsets.Item(ZE), Levelset)

        If IsNumeric(IB) = False Then
            MsgBox(Localizer.GetString("AlertNotANumber"),
                   MsgBoxStyle.OkOnly Or
                   MsgBoxStyle.Critical Or
                   MsgBoxStyle.ApplicationModal,
                   System.Reflection.Assembly.GetExecutingAssembly.GetName.Name)
            Exit Sub
        End If

        If (Val(IB) > Val(CStr(SetArrivedLevel()))) And (Val(IB) <= Levelset.NumberOfLevels) Then
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
            Dim BoardState() As Integer = Levelset.GetLevel(CurrentlyPlayedLevelId)
            For Counter = 1 To 256 Step 1
                GameBoard(Counter) = BoardState(Counter)
            Next Counter

            CurrentLevelStats = Levelset.GetLevelInitialProperties(CurrentlyPlayedLevelId)
            PlayerLocation = CurrentLevelStats.PlayerLocation

            Call RefreshStatusBar()
            Me.Text = Localizer.GetString("GameName") & Localizer.GetString("LabelShortPauseAndNumberID") & CurrentlyPlayedLevelId
            RefreshBoard()
            ExternalCustomLevel = False
        End If
    End Sub

    Private Sub MenuitemTools_Click(sender As Object, e As EventArgs) Handles MenuitemTools.Click
        If MoveHasBeenPerformed Then MenuitemUndo.Enabled = True Else MenuitemUndo.Enabled = False
        If ExternalCustomLevel = False Then MenuitemRestart.Enabled = True Else MenuitemRestart.Enabled = False
    End Sub

    Private Sub MenuitemOpenLevel_Click(sender As Object, e As EventArgs) Handles MenuitemOpenLevel.Click
        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            FileName = OpenFileDialog1.FileName
        End If

        Dim LevelsetCustomInput = LevelParser.PullAllLevels(FileName, True)
        Dim LevelsetCustom As Levelset = New Levelset("NazwaPliku")

        If LevelsetCustomInput.Count > 0 Then
            If My.Settings.LevelLoadConfirmation = True Then
                MsgBox((Localizer.GetString("AlertLevelFromFileLoadSuccess") & FileName),
                       MsgBoxStyle.OkOnly Or
                       MsgBoxStyle.Information Or
                       MsgBoxStyle.ApplicationModal,
                       System.Reflection.Assembly.GetExecutingAssembly.GetName.Name)
            End If

            ' TODO fail and fall back if it didn't 

            For Each SokobanCompliantLevel As String In LevelsetCustomInput
                Dim SkrzynkiCompliantLevel = GetMapStringFromLevel(SokobanCompliantLevel)
                LevelsetCustom.AddLevel(SkrzynkiCompliantLevel)
            Next

            LevelsetCustom.AchievedLevel = 0
            LevelsetCustom.Moves = 0
            LevelsetCustom.Pushes = 0

            Levelsets.Add("Custom", LevelsetCustom)
        End If

        Dim Levelset As Levelset = CType(LevelParser.Levelsets.Item("Custom"), Levelset)
        RefreshBoard()
        ExternalCustomLevel = True

        Dim BoardState() As Integer = Levelset.GetLevel(CurrentlyPlayedLevelId)
        For Counter = 1 To 256 Step 1
            GameBoard(Counter) = BoardState(Counter)
        Next Counter

        CurrentLevelStats = Levelset.GetLevelInitialProperties(CurrentlyPlayedLevelId)

    End Sub

    Private Sub MenuitemLevelset_Click(sender As Object, e As EventArgs) Handles MenuitemLevelset.Click
        If My.Settings.LevelSet = "Klasyczne" Then
            MenuitemLevelsetClassic.Checked = True
            MenuitemLevelsetXS.Checked = False
        Else
            MenuitemLevelsetClassic.Checked = False
            MenuitemLevelsetXS.Checked = True
        End If
    End Sub

    Private Sub MenuitemLevelset_Hover(sender As Object, e As EventArgs) Handles MenuitemLevelset.MouseHover
        If My.Settings.LevelSet = "Klasyczne" Then
            MenuitemLevelsetClassic.Checked = True
            MenuitemLevelsetXS.Checked = False
        Else
            MenuitemLevelsetClassic.Checked = False
            MenuitemLevelsetXS.Checked = True
        End If
    End Sub

    Private Sub MenuitemLevelsetClassic_Click(sender As Object, e As EventArgs) Handles MenuitemLevelsetClassic.Click
        My.Settings.LevelSet = "Klasyczne"
        MenuitemLevelsetClassic.Checked = True
        MenuitemLevelsetXS.Checked = False
        NewGame(1)

        RefreshBoard()
        Me.MenuitemUndo.Enabled = False
        Call RefreshStatusBar()
        Me.Text = System.Reflection.Assembly.GetExecutingAssembly.GetName.Name & Localizer.GetString("LabelShortPauseAndNumberID") & CurrentlyPlayedLevelId
    End Sub

    Private Sub MenuitemLevelsetXS_Click(sender As Object, e As EventArgs) Handles MenuitemLevelsetXS.Click
        My.Settings.LevelSet = "SuperTrudneXS"
        MenuitemLevelsetClassic.Checked = False
        MenuitemLevelsetXS.Checked = True
        NewGame(1)

        RefreshBoard()
        Me.MenuitemUndo.Enabled = False
        Call RefreshStatusBar()
    End Sub

    Private Sub MenuitemGame_Click(sender As Object, e As EventArgs) Handles MenuitemGame.Click
        If ExternalCustomLevel Then
            MenuitemOpenLevel.Enabled = False
        Else
            MenuitemOpenLevel.Enabled = True
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
            MenuitemSkinCheese.Checked = False
            MenuitemSkinExport.Checked = True
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