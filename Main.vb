Public Class FrmMain
    Inherits System.Windows.Forms.Form
#Region "Windows Form Designer generated code "
    Public Sub New()
        MyBase.New()
        'This call is required by the Windows Form Designer.
        InitializeComponent()
    End Sub
    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal Disposing As Boolean)
        If Disposing Then
            If Not components Is Nothing Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(Disposing)
    End Sub
    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer
    Public WithEvents LblPlayerName As System.Windows.Forms.Label
    Public WithEvents LblLevelNumber As System.Windows.Forms.Label
    Public WithEvents LblBoxes As System.Windows.Forms.Label
    Public WithEvents LblPushes As System.Windows.Forms.Label
    Public WithEvents LblMoves As System.Windows.Forms.Label
    Public WithEvents PicStatusBar As System.Windows.Forms.Panel
    Public WithEvents MnuGameNew As System.Windows.Forms.MenuItem
    Public WithEvents MnuGameWarp As System.Windows.Forms.MenuItem
    Public WithEvents MnuGameSetKlasyczne As System.Windows.Forms.MenuItem
    Public WithEvents MnuGameSetSuperTrudneXS As System.Windows.Forms.MenuItem
    Public WithEvents MnuGameSet As System.Windows.Forms.MenuItem
    Public WithEvents MnuGameOpen As System.Windows.Forms.MenuItem
    Public WithEvents MnuGameBar0 As System.Windows.Forms.MenuItem
    Public WithEvents MnuGameExit As System.Windows.Forms.MenuItem
    Public WithEvents MnuGame As System.Windows.Forms.MenuItem
    Public WithEvents MnuViewBar0 As System.Windows.Forms.MenuItem
    Public WithEvents MnuViewRefresh As System.Windows.Forms.MenuItem
    Public WithEvents MnuView As System.Windows.Forms.MenuItem
    Public WithEvents MnuToolsUndo As System.Windows.Forms.MenuItem
    Public WithEvents MnuToolsRestart As System.Windows.Forms.MenuItem
    Public WithEvents MnuToolsBar0 As System.Windows.Forms.MenuItem
    Public WithEvents MnuToolsOptions As System.Windows.Forms.MenuItem
    Public WithEvents MnuTools As System.Windows.Forms.MenuItem
    Public WithEvents MnuHelpContents As System.Windows.Forms.MenuItem
    Public WithEvents MnuHelpWeb As System.Windows.Forms.MenuItem
    Public WithEvents MnuHelpBar0 As System.Windows.Forms.MenuItem
    Public WithEvents MnuHelpAbout As System.Windows.Forms.MenuItem
    Public WithEvents MnuHelp As System.Windows.Forms.MenuItem
    Public MainMenu1 As System.Windows.Forms.MainMenu
    Friend WithEvents MenuItem1 As MenuItem
    Friend WithEvents MnuSkinOryginalny As MenuItem
    Friend WithEvents MenuItem3 As MenuItem
    Friend WithEvents MnuSkinEksport As MenuItem
    Friend WithEvents MnuSkinSerowy As MenuItem
    Friend WithEvents MnuColor As MenuItem
    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.PicStatusBar = New System.Windows.Forms.Panel()
        Me.LblPlayerName = New System.Windows.Forms.Label()
        Me.LblLevelNumber = New System.Windows.Forms.Label()
        Me.LblBoxes = New System.Windows.Forms.Label()
        Me.LblPushes = New System.Windows.Forms.Label()
        Me.LblMoves = New System.Windows.Forms.Label()
        Me.MainMenu1 = New System.Windows.Forms.MainMenu(Me.components)
        Me.MnuGame = New System.Windows.Forms.MenuItem()
        Me.MnuGameNew = New System.Windows.Forms.MenuItem()
        Me.MnuGameWarp = New System.Windows.Forms.MenuItem()
        Me.MnuGameSet = New System.Windows.Forms.MenuItem()
        Me.MnuGameSetKlasyczne = New System.Windows.Forms.MenuItem()
        Me.MnuGameSetSuperTrudneXS = New System.Windows.Forms.MenuItem()
        Me.MnuGameOpen = New System.Windows.Forms.MenuItem()
        Me.MnuGameBar0 = New System.Windows.Forms.MenuItem()
        Me.MnuGameExit = New System.Windows.Forms.MenuItem()
        Me.MnuView = New System.Windows.Forms.MenuItem()
        Me.MenuItem1 = New System.Windows.Forms.MenuItem()
        Me.MnuSkinOryginalny = New System.Windows.Forms.MenuItem()
        Me.MnuSkinEksport = New System.Windows.Forms.MenuItem()
        Me.MnuSkinSerowy = New System.Windows.Forms.MenuItem()
        Me.MnuColor = New System.Windows.Forms.MenuItem()
        Me.MnuViewBar0 = New System.Windows.Forms.MenuItem()
        Me.MnuViewRefresh = New System.Windows.Forms.MenuItem()
        Me.MenuItem3 = New System.Windows.Forms.MenuItem()
        Me.MnuTools = New System.Windows.Forms.MenuItem()
        Me.MnuToolsUndo = New System.Windows.Forms.MenuItem()
        Me.MnuToolsRestart = New System.Windows.Forms.MenuItem()
        Me.MnuToolsBar0 = New System.Windows.Forms.MenuItem()
        Me.MnuToolsOptions = New System.Windows.Forms.MenuItem()
        Me.MnuHelp = New System.Windows.Forms.MenuItem()
        Me.MnuHelpContents = New System.Windows.Forms.MenuItem()
        Me.MnuHelpWeb = New System.Windows.Forms.MenuItem()
        Me.MnuHelpBar0 = New System.Windows.Forms.MenuItem()
        Me.MnuHelpAbout = New System.Windows.Forms.MenuItem()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.PicStatusBar.SuspendLayout()
        Me.SuspendLayout()
        '
        'PicStatusBar
        '
        Me.PicStatusBar.BackColor = System.Drawing.SystemColors.Control
        Me.PicStatusBar.Controls.Add(Me.LblPlayerName)
        Me.PicStatusBar.Controls.Add(Me.LblLevelNumber)
        Me.PicStatusBar.Controls.Add(Me.LblBoxes)
        Me.PicStatusBar.Controls.Add(Me.LblPushes)
        Me.PicStatusBar.Controls.Add(Me.LblMoves)
        Me.PicStatusBar.Cursor = System.Windows.Forms.Cursors.Default
        Me.PicStatusBar.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PicStatusBar.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PicStatusBar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.PicStatusBar.Location = New System.Drawing.Point(0, 490)
        Me.PicStatusBar.Name = "PicStatusBar"
        Me.PicStatusBar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.PicStatusBar.Size = New System.Drawing.Size(511, 17)
        Me.PicStatusBar.TabIndex = 1
        Me.PicStatusBar.TabStop = True
        '
        'LblPlayerName
        '
        Me.LblPlayerName.BackColor = System.Drawing.SystemColors.Control
        Me.LblPlayerName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblPlayerName.Cursor = System.Windows.Forms.Cursors.Default
        Me.LblPlayerName.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPlayerName.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LblPlayerName.Location = New System.Drawing.Point(372, 0)
        Me.LblPlayerName.Name = "LblPlayerName"
        Me.LblPlayerName.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.LblPlayerName.Size = New System.Drawing.Size(137, 17)
        Me.LblPlayerName.TabIndex = 6
        Me.LblPlayerName.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'LblLevelNumber
        '
        Me.LblLevelNumber.BackColor = System.Drawing.SystemColors.Control
        Me.LblLevelNumber.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblLevelNumber.Cursor = System.Windows.Forms.Cursors.Default
        Me.LblLevelNumber.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblLevelNumber.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LblLevelNumber.Location = New System.Drawing.Point(272, 0)
        Me.LblLevelNumber.Name = "LblLevelNumber"
        Me.LblLevelNumber.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.LblLevelNumber.Size = New System.Drawing.Size(101, 17)
        Me.LblLevelNumber.TabIndex = 5
        Me.LblLevelNumber.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'LblBoxes
        '
        Me.LblBoxes.BackColor = System.Drawing.SystemColors.Control
        Me.LblBoxes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblBoxes.Cursor = System.Windows.Forms.Cursors.Default
        Me.LblBoxes.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblBoxes.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LblBoxes.Location = New System.Drawing.Point(176, 0)
        Me.LblBoxes.Name = "LblBoxes"
        Me.LblBoxes.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.LblBoxes.Size = New System.Drawing.Size(97, 17)
        Me.LblBoxes.TabIndex = 4
        Me.LblBoxes.Text = "Skrzynki: ##/##"
        Me.LblBoxes.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'LblPushes
        '
        Me.LblPushes.BackColor = System.Drawing.SystemColors.Control
        Me.LblPushes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblPushes.Cursor = System.Windows.Forms.Cursors.Default
        Me.LblPushes.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPushes.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LblPushes.Location = New System.Drawing.Point(88, 0)
        Me.LblPushes.Name = "LblPushes"
        Me.LblPushes.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.LblPushes.Size = New System.Drawing.Size(89, 17)
        Me.LblPushes.TabIndex = 3
        Me.LblPushes.Text = "Pchnięcia: ###"
        Me.LblPushes.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'LblMoves
        '
        Me.LblMoves.BackColor = System.Drawing.SystemColors.Control
        Me.LblMoves.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblMoves.Cursor = System.Windows.Forms.Cursors.Default
        Me.LblMoves.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblMoves.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LblMoves.Location = New System.Drawing.Point(16, 0)
        Me.LblMoves.Name = "LblMoves"
        Me.LblMoves.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.LblMoves.Size = New System.Drawing.Size(73, 17)
        Me.LblMoves.TabIndex = 2
        Me.LblMoves.Text = "Ruchy: ###"
        Me.LblMoves.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'MainMenu1
        '
        Me.MainMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MnuGame, Me.MnuView, Me.MnuTools, Me.MnuHelp})
        '
        'MnuGame
        '
        Me.MnuGame.Index = 0
        Me.MnuGame.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MnuGameNew, Me.MnuGameWarp, Me.MnuGameSet, Me.MnuGameOpen, Me.MnuGameBar0, Me.MnuGameExit})
        Me.MnuGame.Text = "&Gra"
        '
        'MnuGameNew
        '
        Me.MnuGameNew.Index = 0
        Me.MnuGameNew.Text = "&Nowa gra..."
        '
        'MnuGameWarp
        '
        Me.MnuGameWarp.Index = 1
        Me.MnuGameWarp.Shortcut = System.Windows.Forms.Shortcut.F3
        Me.MnuGameWarp.Text = "Wybierz &etap..."
        '
        'MnuGameSet
        '
        Me.MnuGameSet.Index = 2
        Me.MnuGameSet.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MnuGameSetKlasyczne, Me.MnuGameSetSuperTrudneXS})
        Me.MnuGameSet.Text = "Wybierz &zestaw etapów"
        '
        'MnuGameSetKlasyczne
        '
        Me.MnuGameSetKlasyczne.Checked = True
        Me.MnuGameSetKlasyczne.Index = 0
        Me.MnuGameSetKlasyczne.Text = "&Klasyczne"
        '
        'MnuGameSetSuperTrudneXS
        '
        Me.MnuGameSetSuperTrudneXS.Index = 1
        Me.MnuGameSetSuperTrudneXS.Text = "&Super Trudne XS"
        '
        'MnuGameOpen
        '
        Me.MnuGameOpen.Index = 3
        Me.MnuGameOpen.Shortcut = System.Windows.Forms.Shortcut.CtrlO
        Me.MnuGameOpen.Text = "&Otwórz plik etapu..."
        '
        'MnuGameBar0
        '
        Me.MnuGameBar0.Index = 4
        Me.MnuGameBar0.Text = "-"
        '
        'MnuGameExit
        '
        Me.MnuGameExit.Index = 5
        Me.MnuGameExit.Shortcut = System.Windows.Forms.Shortcut.CtrlQ
        Me.MnuGameExit.Text = "&Koniec"
        '
        'MnuView
        '
        Me.MnuView.Index = 1
        Me.MnuView.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem1, Me.MnuColor, Me.MnuViewBar0, Me.MnuViewRefresh, Me.MenuItem3})
        Me.MnuView.Text = "&Widok"
        '
        'MenuItem1
        '
        Me.MenuItem1.Index = 0
        Me.MenuItem1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MnuSkinOryginalny, Me.MnuSkinEksport, Me.MnuSkinSerowy})
        Me.MenuItem1.Text = "Skin"
        '
        'MnuSkinOryginalny
        '
        Me.MnuSkinOryginalny.Checked = True
        Me.MnuSkinOryginalny.Index = 0
        Me.MnuSkinOryginalny.Text = "(Oryginalny)"
        '
        'MnuSkinEksport
        '
        Me.MnuSkinEksport.Index = 1
        Me.MnuSkinEksport.Text = "Eksport"
        '
        'MnuSkinSerowy
        '
        Me.MnuSkinSerowy.Index = 2
        Me.MnuSkinSerowy.Text = "Serowy"
        '
        'MnuColor
        '
        Me.MnuColor.Index = 1
        Me.MnuColor.Text = "Kolor tła..."
        '
        'MnuViewBar0
        '
        Me.MnuViewBar0.Index = 2
        Me.MnuViewBar0.Text = "-"
        '
        'MnuViewRefresh
        '
        Me.MnuViewRefresh.Index = 3
        Me.MnuViewRefresh.Shortcut = System.Windows.Forms.Shortcut.F9
        Me.MnuViewRefresh.Text = "O&dśwież"
        '
        'MenuItem3
        '
        Me.MenuItem3.Index = 4
        Me.MenuItem3.Text = "Ukryj"
        '
        'MnuTools
        '
        Me.MnuTools.Index = 2
        Me.MnuTools.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MnuToolsUndo, Me.MnuToolsRestart, Me.MnuToolsBar0, Me.MnuToolsOptions})
        Me.MnuTools.Text = "&Narzędzia"
        '
        'MnuToolsUndo
        '
        Me.MnuToolsUndo.Enabled = False
        Me.MnuToolsUndo.Index = 0
        Me.MnuToolsUndo.Shortcut = System.Windows.Forms.Shortcut.Del
        Me.MnuToolsUndo.Text = "&Cofnij"
        '
        'MnuToolsRestart
        '
        Me.MnuToolsRestart.Index = 1
        Me.MnuToolsRestart.Shortcut = System.Windows.Forms.Shortcut.CtrlR
        Me.MnuToolsRestart.Text = "&Restartuj etap"
        '
        'MnuToolsBar0
        '
        Me.MnuToolsBar0.Index = 2
        Me.MnuToolsBar0.Text = "-"
        '
        'MnuToolsOptions
        '
        Me.MnuToolsOptions.Index = 3
        Me.MnuToolsOptions.Text = "&Opcje..."
        '
        'MnuHelp
        '
        Me.MnuHelp.Index = 3
        Me.MnuHelp.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MnuHelpContents, Me.MnuHelpWeb, Me.MnuHelpBar0, Me.MnuHelpAbout})
        Me.MnuHelp.Text = "Pomo&c"
        '
        'MnuHelpContents
        '
        Me.MnuHelpContents.Index = 0
        Me.MnuHelpContents.Shortcut = System.Windows.Forms.Shortcut.F1
        Me.MnuHelpContents.Text = "&Tematy Pomocy..."
        '
        'MnuHelpWeb
        '
        Me.MnuHelpWeb.Index = 1
        Me.MnuHelpWeb.Text = "Skrzynki w &sieci..."
        '
        'MnuHelpBar0
        '
        Me.MnuHelpBar0.Index = 2
        Me.MnuHelpBar0.Text = "-"
        '
        'MnuHelpAbout
        '
        Me.MnuHelpAbout.Index = 3
        Me.MnuHelpAbout.Text = "Skrzynki - &informacje..."
        '
        'FrmMain
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(511, 507)
        Me.Controls.Add(Me.PicStatusBar)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.Location = New System.Drawing.Point(87, 140)
        Me.MaximizeBox = False
        Me.Menu = Me.MainMenu1
        Me.Name = "FrmMain"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Skrzynki"
        Me.PicStatusBar.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
#End Region

    ReadOnly imgGameField(256) As System.Windows.Forms.PictureBox

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

    Private Sub FrmMain_KeyDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        Dim KeyCode As Windows.Forms.Keys = eventArgs.KeyCode
        If KeyCode = 倉庫番.Lewo Or
            KeyCode = 倉庫番.Prawo Or
            KeyCode = 倉庫番.Gora Or
            KeyCode = 倉庫番.Dol Then
            If PrzesunGracza(KeyCode) Then
                OdswiezPoleGryWokolGracza()
                Ruchy += 1

                PokazNaPaskuStanu(1, ZwrocCiag("StatusBar#0") & Ruchy)
                PokazNaPaskuStanu(2, ZwrocCiag("StatusBar#1") & Pchniecia)
                PokazNaPaskuStanu(3, ZwrocCiag("StatusBar#2") & Etap.SkrzynkiNaMiejscach & "/" & Etap.LiczbaSkrzynek)

                If WykonanoRuch = False Then
                    WykonanoRuch = True
                    Me.MnuToolsUndo.Enabled = True
                End If

                If Etap.SkrzynkiNaMiejscach = Etap.LiczbaSkrzynek Then
                    NastepnyEtap()
                    Me.MnuToolsUndo.Enabled = False
                    OdswiezPoleGry()
                    PokazNaPaskuStanu(1, ZwrocCiag("StatusBar#0") & Ruchy)
                    PokazNaPaskuStanu(2, ZwrocCiag("StatusBar#1") & Pchniecia)
                    PokazNaPaskuStanu(3, ZwrocCiag("StatusBar#2") & DaneEtapow(NumerEtapu).SkrzynkiNaMiejscach & "/" & DaneEtapow(NumerEtapu).LiczbaSkrzynek)
                    PokazNaPaskuStanu(4, "#" & NumerEtapu)
                    Me.Text = "Skrzynki - #" & NumerEtapu
                End If
            Else
                Interaction.Beep()
            End If
        End If
    End Sub
    Private Sub FrmMain_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
        Me.Icon = My.Resources.ico101

        ZestawEtapow = My.Settings.LevelSet
        NumerEtapu = 1
        WykonanoRuch = False
        EtapZaliczony = False

        Stats.OdczytajStatystyki()

        Me.BackColor = Color.Black
        Me.PicStatusBar.Visible = True

        PokazNaPaskuStanu(5, System.Security.Principal.WindowsIdentity.GetCurrent().Name)

        If EtapSpozaZestawu = False Then
            If My.Settings.BeginFromArrivedLevel = True Then
                NowaGra((NajdalszyEtap()))
            Else
                NowaGra((1))
            End If

            OdswiezPoleGry()

            Me.MnuToolsUndo.Enabled = False

            PokazNaPaskuStanu(1, ZwrocCiag("StatusBar#0") & Ruchy)
            PokazNaPaskuStanu(2, ZwrocCiag("StatusBar#1") & Pchniecia)
            PokazNaPaskuStanu(3, ZwrocCiag("StatusBar#2") & Etap.SkrzynkiNaMiejscach & "/" & Etap.LiczbaSkrzynek)
            PokazNaPaskuStanu(4, "#" & NumerEtapu)
            PokazNaPaskuStanu(5, System.Security.Principal.WindowsIdentity.GetCurrent().Name)
            Me.Text = System.Reflection.Assembly.GetExecutingAssembly.GetName.Name & " - #" & NumerEtapu
        End If

    End Sub

    Private Sub FrmMain_Closed(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Closed
        ZapiszStatystyki()
        End
    End Sub

    Public Sub PokazNaPaskuStanu(ByVal NumerPanelu As Byte, ByVal Napis As String)
        Select Case NumerPanelu
            Case 1
                LblMoves.Text = Napis
            Case 2
                LblPushes.Text = Napis
            Case 3
                LblBoxes.Text = Napis
            Case 4
                LblLevelNumber.Text = Napis
            Case 5
                LblPlayerName.Text = Napis
        End Select
    End Sub

    Public Sub OdswiezPoleGry()
        Dim Skin As String = My.Settings.Skin
        For Licznik = 1 To 256 Step 1
            If PoleGry(Licznik) < 7 Then
                Me.imgGameField(Licznik).Image = Skrzynki.Skin.GetIcon(PoleGry(Licznik))
            Else
                Me.imgGameField(Licznik).Image = Nothing
                Me.imgGameField(Licznik).BackColor = My.Settings.BackgroundColor
            End If
        Next Licznik
    End Sub

    Public Sub OdswiezPoleGryWokolGracza()
        Dim Skin As String = My.Settings.Skin

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

    Public Sub MnuGame_Popup(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MnuGame.Popup
        MnuGame_Click(eventSender, eventArgs)
    End Sub
    Public Sub MnuGame_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MnuGame.Click
        If EtapSpozaZestawu Then
            MnuGameOpen.Enabled = False
        Else
            MnuGameOpen.Enabled = True
        End If
    End Sub
    Public Sub MnuGameExit_Popup(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MnuGameExit.Popup
        MnuGameExit_Click(eventSender, eventArgs)
    End Sub
    Public Sub MnuGameExit_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MnuGameExit.Click
        Me.Close()
    End Sub
    Public Sub MnuGameNew_Popup(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MnuGameNew.Popup
        MnuGameNew_Click(eventSender, eventArgs)
    End Sub
    Public Sub MnuGameNew_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MnuGameNew.Click
        NowaGra((1))

        OdswiezPoleGry()

        Me.MnuToolsUndo.Enabled = False

        PokazNaPaskuStanu(1, ZwrocCiag("StatusBar#0") & Ruchy)
        PokazNaPaskuStanu(2, ZwrocCiag("StatusBar#1") & Pchniecia)
        PokazNaPaskuStanu(3, ZwrocCiag("StatusBar#2") & Etap.SkrzynkiNaMiejscach & "/" & Etap.LiczbaSkrzynek)
        PokazNaPaskuStanu(4, "#" & NumerEtapu)
        PokazNaPaskuStanu(5, System.Security.Principal.WindowsIdentity.GetCurrent().Name)
        Me.Text = System.Reflection.Assembly.GetExecutingAssembly.GetName.Name & " - #" & NumerEtapu
    End Sub
    Public Sub MnuGameOpen_Popup(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MnuGameOpen.Popup
        MnuGameOpen_Click(eventSender, eventArgs)
    End Sub
    Public Sub MnuGameOpen_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MnuGameOpen.Click
        Dim openFileDialog1 As OpenFileDialog = New OpenFileDialog
        With openFileDialog1
            If openFileDialog1.ShowDialog() = DialogResult.OK Then
                NazwaPliku = openFileDialog1.FileName
            End If
        End With

        If WczytajEtap(NazwaPliku, FreeFile) Then
            OdswiezPoleGry()
            'UPGRADE_WARNING: Dir has a new behavior. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1041"'
            Me.Text = "Skrzynki - " & Microsoft.VisualBasic.Left(Dir(NazwaPliku), Len(Dir(NazwaPliku)) - 4)
            PokazNaPaskuStanu(3, "Skrzynki: " & Etap.SkrzynkiNaMiejscach & "/" & Etap.LiczbaSkrzynek)
            'UPGRADE_WARNING: Dir has a new behavior. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1041"'
            PokazNaPaskuStanu(4, Microsoft.VisualBasic.Left(Dir(NazwaPliku), Len(Dir(NazwaPliku)) - 4))
            EtapSpozaZestawu = True

            If My.Settings.LevelLoadConfirmation = True Then
                MsgBox(Replace(ZwrocCiag("General#6"), "<filename>", NazwaPliku), MsgBoxStyle.OkOnly Or MsgBoxStyle.Information Or MsgBoxStyle.ApplicationModal, System.Reflection.Assembly.GetExecutingAssembly.GetName.Name)
            End If
        End If

    End Sub
    Public Sub MnuGameSet_Popup(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MnuGameSet.Popup
        MnuGameSet_Click(eventSender, eventArgs)
    End Sub
    Public Sub MnuGameSet_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MnuGameSet.Click
        If My.Settings.LevelSet = "Klasyczne" Then
            MnuGameSetKlasyczne.Checked = True
            MnuGameSetSuperTrudneXS.Checked = False
        Else
            MnuGameSetKlasyczne.Checked = False
            MnuGameSetSuperTrudneXS.Checked = True
        End If
    End Sub

    Public Sub MnuGameSetKlasyczne_Popup(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MnuGameSetKlasyczne.Popup
        MnuGameSetKlasyczne_Click(eventSender, eventArgs)
    End Sub
    Public Sub MnuGameSetKlasyczne_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MnuGameSetKlasyczne.Click
        My.Settings.LevelSet = "Klasyczne"
        MnuGameSetKlasyczne.Checked = True
        MnuGameSetSuperTrudneXS.Checked = False
        NowaGra(1, My.Settings.LevelSet)

        OdswiezPoleGry()

        Me.MnuToolsUndo.Enabled = False

        PokazNaPaskuStanu(1, ZwrocCiag("StatusBar#0") & Ruchy)
        PokazNaPaskuStanu(2, ZwrocCiag("StatusBar#1") & Pchniecia)
        PokazNaPaskuStanu(3, ZwrocCiag("StatusBar#2") & Etap.SkrzynkiNaMiejscach & "/" & Etap.LiczbaSkrzynek)
        PokazNaPaskuStanu(4, "#" & NumerEtapu)
        PokazNaPaskuStanu(5, System.Security.Principal.WindowsIdentity.GetCurrent().Name)
        Me.Text = System.Reflection.Assembly.GetExecutingAssembly.GetName.Name & " - #" & NumerEtapu
    End Sub

    Public Sub MnuGameSetSuperTrudneXS_Popup(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MnuGameSetSuperTrudneXS.Popup
        MnuGameSetSuperTrudneXS_Click(eventSender, eventArgs)
    End Sub
    Public Sub MnuGameSetSuperTrudneXS_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MnuGameSetSuperTrudneXS.Click
        My.Settings.LevelSet = "SuperTrudneXS"
        MnuGameSetKlasyczne.Checked = False
        MnuGameSetSuperTrudneXS.Checked = True
        NowaGra(1, My.Settings.LevelSet)

        OdswiezPoleGry()

        Me.MnuToolsUndo.Enabled = False

        PokazNaPaskuStanu(1, ZwrocCiag("StatusBar#0") & Ruchy)
        PokazNaPaskuStanu(2, ZwrocCiag("StatusBar#1") & Pchniecia)
        PokazNaPaskuStanu(3, ZwrocCiag("StatusBar#2") & Etap.SkrzynkiNaMiejscach & "/" & Etap.LiczbaSkrzynek)
        PokazNaPaskuStanu(4, "#" & NumerEtapu)
        PokazNaPaskuStanu(5, System.Security.Principal.WindowsIdentity.GetCurrent().Name)
        Me.Text = System.Reflection.Assembly.GetExecutingAssembly.GetName.Name & " - #" & NumerEtapu
    End Sub

    Public Sub MnuGameWarp_Popup(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MnuGameWarp.Popup
        MnuGameWarp_Click(eventSender, eventArgs)
    End Sub
    Public Sub MnuGameWarp_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MnuGameWarp.Click
        Dim IB As String = InputBox(ZwrocCiag("General#12"), System.Reflection.Assembly.GetExecutingAssembly.GetName.Name, CStr(NajdalszyEtap()))
        If IB = "" Then
            Exit Sub
        End If

        If IsNumeric(IB) = False Then
            MsgBox(ZwrocCiag("General#13"), MsgBoxStyle.OkOnly Or MsgBoxStyle.Critical Or MsgBoxStyle.ApplicationModal, System.Reflection.Assembly.GetExecutingAssembly.GetName.Name)
            Exit Sub
        End If

        If (Val(IB) > Val(CStr(NajdalszyEtap()))) And (Val(IB) <= Val(CStr(UBound(Etapy, 1)))) Then
            MsgBox(ZwrocCiag("General#14"), MsgBoxStyle.OkOnly Or MsgBoxStyle.Critical Or MsgBoxStyle.ApplicationModal, System.Reflection.Assembly.GetExecutingAssembly.GetName.Name)
            Exit Sub
        Else
            If (Val(IB) > Val(CStr(UBound(Etapy, 1)))) Or Val(IB) <= 0 Then
                MsgBox(ZwrocCiag("General#15"), MsgBoxStyle.OkOnly Or MsgBoxStyle.Critical Or MsgBoxStyle.ApplicationModal, System.Reflection.Assembly.GetExecutingAssembly.GetName.Name)
                Exit Sub
            End If

            NumerEtapu = CInt(Val(IB))
            For Licznik = 1 To 256
                PoleGry(Licznik) = Etapy(NumerEtapu, Licznik)
                'UPGRADE_WARNING: Couldn't resolve default property of object Etap. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
                Etap = DaneEtapow(NumerEtapu)
                PozycjaGracza = PozycjeGracza(NumerEtapu)
            Next Licznik

            PokazNaPaskuStanu(1, ZwrocCiag("StatusBar#0") & Ruchy)
            PokazNaPaskuStanu(2, ZwrocCiag("StatusBar#1") & Pchniecia)
            PokazNaPaskuStanu(3, ZwrocCiag("StatusBar#2") & Etap.SkrzynkiNaMiejscach & "/" & Etap.LiczbaSkrzynek)
            PokazNaPaskuStanu(4, "#" & NumerEtapu)
            Me.Text = System.Reflection.Assembly.GetExecutingAssembly.GetName.Name & " - #" & NumerEtapu
            OdswiezPoleGry()
            EtapSpozaZestawu = False
        End If
    End Sub

    Public Sub MnuHelpAbout_Popup(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MnuHelpAbout.Popup
        MnuHelpAbout_Click(eventSender, eventArgs)
    End Sub
    Public Sub MnuHelpAbout_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MnuHelpAbout.Click
        FrmSplash.Show()
    End Sub

    Public Sub MnuTools_Popup(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MnuTools.Popup
        MnuTools_Click(eventSender, eventArgs)
    End Sub
    Public Sub MnuTools_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MnuTools.Click
        If WykonanoRuch Then MnuToolsUndo.Enabled = True Else MnuToolsUndo.Enabled = False
        If EtapSpozaZestawu = False Then MnuToolsRestart.Enabled = True Else MnuToolsRestart.Enabled = False
    End Sub
    Public Sub MnuToolsOptions_Popup(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MnuToolsOptions.Popup
        MnuToolsOptions_Click(eventSender, eventArgs)
    End Sub
    Public Sub MnuToolsOptions_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MnuToolsOptions.Click
        FrmOptions.Show()
    End Sub
    Public Sub MnuViewRefresh_Popup(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MnuViewRefresh.Popup
        MnuViewRefresh_Click(eventSender, eventArgs)
    End Sub
    Public Sub MnuViewRefresh_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MnuViewRefresh.Click
        OdswiezPoleGry()
    End Sub
    Public Sub MnuToolsRestart_Popup(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MnuToolsRestart.Popup
        MnuToolsRestart_Click(eventSender, eventArgs)
    End Sub
    Public Sub MnuToolsRestart_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MnuToolsRestart.Click
        If My.Settings.LevelRestartingAuthorization = True Then
            Dim TempX As MsgBoxResult = MsgBox(ZwrocCiag("General#1"), MsgBoxStyle.YesNo Or MsgBoxStyle.Question Or MsgBoxStyle.ApplicationModal, System.Reflection.Assembly.GetExecutingAssembly.GetName.Name)
            If TempX = MsgBoxResult.Yes Then
                RestartujEtap()
                OdswiezPoleGry()
            End If
        Else
            RestartujEtap()
            OdswiezPoleGry()
        End If
        Me.MnuToolsUndo.Enabled = False
        PokazNaPaskuStanu(1, ZwrocCiag("StatusBar#0") & Ruchy)
        PokazNaPaskuStanu(2, ZwrocCiag("StatusBar#1") & Pchniecia)
        PokazNaPaskuStanu(3, ZwrocCiag("StatusBar#2") & Etap.SkrzynkiNaMiejscach & "/" & Etap.LiczbaSkrzynek)
        PokazNaPaskuStanu(4, "#" & NumerEtapu)
        Me.Text = "Skrzynki - #" & NumerEtapu
    End Sub
    Public Sub MnuToolsUndo_Popup(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MnuToolsUndo.Popup
        MnuToolsUndo_Click(eventSender, eventArgs)
    End Sub
    Public Sub MnuToolsUndo_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MnuToolsUndo.Click
        Cofnij()
        OdswiezPoleGry()
        PokazNaPaskuStanu(3, ZwrocCiag("StatusBar#2") & Etap.SkrzynkiNaMiejscach & "/" & Etap.LiczbaSkrzynek)
        Me.MnuToolsUndo.Enabled = False
    End Sub

    Private Sub MenuItem4_Click(sender As Object, e As EventArgs) Handles MnuSkinEksport.Click
        MnuSkinSerowy.Checked = False
        MnuSkinOryginalny.Checked = False
        My.Settings.Skin = "Eksport"
        OdswiezPoleGry()
    End Sub

    Private Sub MenuItem2_Click(sender As Object, e As EventArgs) Handles MnuSkinOryginalny.Click
        MnuSkinSerowy.Checked = False
        MnuSkinEksport.Checked = False
        My.Settings.Skin = "(Oryginalny)"
        OdswiezPoleGry()
    End Sub

    Private Sub MnuSkinSerowy_Click(sender As Object, e As EventArgs) Handles MnuSkinSerowy.Click
        MnuSkinSerowy.Checked = False
        MnuSkinEksport.Checked = False
        My.Settings.Skin = "Serowy"
        OdswiezPoleGry()
    End Sub

    Private Sub MnuColor_Click(sender As Object, e As EventArgs) Handles MnuColor.Click
        Dim MyColor As Color
        Dim ColorDialog1 As ColorDialog = New ColorDialog
        ColorDialog1.ShowDialog()

        With ColorDialog1
            MyColor = ColorDialog1.Color
            My.Settings.BackgroundColor = MyColor
            OdswiezPoleGry()
        End With
    End Sub

End Class