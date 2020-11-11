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
        MovesLabel.Text = Localizer.GetString("LabelMoves") & Ruchy
        PushesLabel.Text = Localizer.GetString("LabelPushes") & Pchniecia
        Text = Localizer.GetString("GameName") & " (" & My.Settings.LevelSet & "): #" & NumerEtapu.ToString(CultureInfo.InvariantCulture)

        Me.LevelProgressBar.Maximum = Etap.LiczbaSkrzynek
        Me.LevelProgressBar.Value = Etap.SkrzynkiNaMiejscach

        Me.LevelsetProgressBar.Maximum = 60
        Me.LevelsetProgressBar.Value = NumerEtapu
    End Sub

    Public Sub RefreshBoard()
        For Licznik = 1 To 256 Step 1
            If PoleGry(Licznik) < 7 Then
                Me.imgGameField(Licznik).Image = Skrzynki.Skin.GetIcon(PoleGry(Licznik))
            Else
                Me.imgGameField(Licznik).Image = Nothing
                Me.imgGameField(Licznik).BackColor = My.Settings.BackgroundColor
            End If
        Next Licznik
    End Sub

    Public Sub RefreshBoardNearItemsOnly()
        If PoleGry(PozycjaGracza - 16) < 7 Then
            Me.imgGameField(PozycjaGracza - 16).Image =
                    Skrzynki.Skin.GetIcon(PoleGry(PozycjaGracza - 16))
        Else
            Me.imgGameField(PozycjaGracza - 16).Image = Nothing
        End If

        If PoleGry(PozycjaGracza - 1) < 7 Then
            Me.imgGameField(PozycjaGracza - 1).Image =
                    Skrzynki.Skin.GetIcon(PoleGry(PozycjaGracza - 1))
        Else
            Me.imgGameField(PozycjaGracza - 1).Image = Nothing
        End If

        If PoleGry(PozycjaGracza) < 7 Then
            Me.imgGameField(PozycjaGracza).Image =
                    Skrzynki.Skin.GetIcon(PoleGry(PozycjaGracza))
        Else
            Me.imgGameField(PozycjaGracza).Image = Nothing
        End If

        If PoleGry(PozycjaGracza + 1) < 7 Then
            Me.imgGameField(PozycjaGracza + 1).Image =
                    Skrzynki.Skin.GetIcon(PoleGry(PozycjaGracza + 1))
        Else
            Me.imgGameField(PozycjaGracza + 1).Image = Nothing
        End If

        If PoleGry(PozycjaGracza + 16) < 7 Then
            Me.imgGameField(PozycjaGracza + 16).Image =
                    Skrzynki.Skin.GetIcon(PoleGry(PozycjaGracza + 16))
        Else
            Me.imgGameField(PozycjaGracza + 16).Image = Nothing
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
                Ruchy += 1

                If WykonanoRuch = False Then
                    WykonanoRuch = True
                    Me.MenuitemUndo.Enabled = True
                End If

                If Etap.SkrzynkiNaMiejscach = Etap.LiczbaSkrzynek Then
                    MsgBox(Localizer.GetString("AlertLevelSolved"),
                           MsgBoxStyle.OkOnly Or
                           MsgBoxStyle.Information Or
                           MsgBoxStyle.ApplicationModal,
                           System.Reflection.Assembly.GetExecutingAssembly.GetName.Name)
                    EtapZaliczony = True
                    NumerEtapu += 1
                    If NumerEtapu > UBound(Etapy, 1) Then
                        MsgBox(Localizer.GetString("Moves"),
                               MsgBoxStyle.OkOnly Or
                               MsgBoxStyle.Information Or
                               MsgBoxStyle.ApplicationModal,
                               System.Reflection.Assembly.GetExecutingAssembly.GetName.Name)
                    Else
                        NastepnyEtap()
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
        Me.Text = Localizer.GetString("GameName") & Localizer.GetString("LabelShortPauseAndNumberID") & NumerEtapu

        ZestawEtapow = My.Settings.LevelSet
        NumerEtapu = 1
        WykonanoRuch = False
        EtapZaliczony = False

        Stats.OdczytajStatystyki()

        Me.BackColor = Color.Black

        Dim SuccessfulNewGame As Boolean = False
        If EtapSpozaZestawu = False Then
            If My.Settings.BeginFromArrivedLevel = True Then
                SuccessfulNewGame = NowaGra((NajdalszyEtap()))
            Else
                SuccessfulNewGame = NowaGra((1))
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
        NowaGra((1))
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
                RestartujEtap()
                RefreshBoard()
            End If
        Else
            RestartujEtap()
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
        Cofnij()
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
                                    CStr(NajdalszyEtap()))
        If IB = "" Then
            Exit Sub
        End If

        If IsNumeric(IB) = False Then
            MsgBox(Localizer.GetString("NaNAlert"),
                   MsgBoxStyle.OkOnly Or
                   MsgBoxStyle.Critical Or
                   MsgBoxStyle.ApplicationModal,
                   System.Reflection.Assembly.GetExecutingAssembly.GetName.Name)
            Exit Sub
        End If

        If (Val(IB) > Val(CStr(NajdalszyEtap()))) And (Val(IB) <= Val(CStr(UBound(Etapy, 1)))) Then
            MsgBox(Localizer.GetString("AlertLevelNotReachedYet"),
                   MsgBoxStyle.OkOnly Or
                   MsgBoxStyle.Critical Or
                   MsgBoxStyle.ApplicationModal,
                   System.Reflection.Assembly.GetExecutingAssembly.GetName.Name)
            Exit Sub
        Else
            If (Val(IB) > Val(CStr(UBound(Etapy, 1)))) Or Val(IB) <= 0 Then
                MsgBox(Localizer.GetString("AlertNotANumber"),
                       MsgBoxStyle.OkOnly Or
                       MsgBoxStyle.Critical Or
                       MsgBoxStyle.ApplicationModal,
                       System.Reflection.Assembly.GetExecutingAssembly.GetName.Name)
                Exit Sub
            End If

            NumerEtapu = CInt(Val(IB))
            For Licznik = 1 To 256
                PoleGry(Licznik) = Etapy(NumerEtapu, Licznik)
                'UPGRADE_WARNING: Couldn't resolve default property of object Etap. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
                Etap = DaneEtapow(NumerEtapu)
                PozycjaGracza = PozycjeGracza(NumerEtapu)
            Next Licznik

            Call RefreshStatusBar()
            Me.Text = Localizer.GetString("GameName") & Localizer.GetString("LabelShortPauseAndNumberID") & NumerEtapu
            RefreshBoard()
            EtapSpozaZestawu = False
        End If
    End Sub

    Private Sub MenuitemTools_Click(sender As Object, e As EventArgs) Handles MenuitemTools.Click
        If WykonanoRuch Then MenuitemUndo.Enabled = True Else MenuitemUndo.Enabled = False
        If EtapSpozaZestawu = False Then MenuitemRestart.Enabled = True Else MenuitemRestart.Enabled = False
    End Sub

    Private Sub MenuitemOpenLevel_Click(sender As Object, e As EventArgs) Handles MenuitemOpenLevel.Click
        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            NazwaPliku = OpenFileDialog1.FileName
        End If

        If WczytajEtap(NazwaPliku, FreeFile) Then
            RefreshBoard()
            EtapSpozaZestawu = True

            If My.Settings.LevelLoadConfirmation = True Then
                MsgBox((Localizer.GetString("AlertLevelFromFileLoadSuccess") & NazwaPliku),
                       MsgBoxStyle.OkOnly Or
                       MsgBoxStyle.Information Or
                       MsgBoxStyle.ApplicationModal,
                       System.Reflection.Assembly.GetExecutingAssembly.GetName.Name)
            End If
        End If
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
        NowaGra(1, My.Settings.LevelSet)

        RefreshBoard()
        Me.MenuitemUndo.Enabled = False
        Call RefreshStatusBar()
        Me.Text = System.Reflection.Assembly.GetExecutingAssembly.GetName.Name & Localizer.GetString("LabelShortPauseAndNumberID") & NumerEtapu
    End Sub

    Private Sub MenuitemLevelsetXS_Click(sender As Object, e As EventArgs) Handles MenuitemLevelsetXS.Click
        My.Settings.LevelSet = "SuperTrudneXS"
        MenuitemLevelsetClassic.Checked = False
        MenuitemLevelsetXS.Checked = True
        NowaGra(1, My.Settings.LevelSet)

        RefreshBoard()
        Me.MenuitemUndo.Enabled = False
        Call RefreshStatusBar()
    End Sub

    Private Sub MenuitemGame_Click(sender As Object, e As EventArgs) Handles MenuitemGame.Click
        If EtapSpozaZestawu Then
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