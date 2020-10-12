Public Class GameBoard
    Inherits System.Windows.Forms.Form

    ReadOnly imgGameField(256) As System.Windows.Forms.PictureBox
    Friend WithEvents SkrzynkiTrayIcon As NotifyIcon
    Public Localizer As System.Resources.ResourceManager

#Region "Windows Form Designer generated code "
    Public Sub New()
        MyBase.New()
        Localizer = New System.Resources.ResourceManager("Skrzynki.LocalizableStrings", System.Reflection.Assembly.GetExecutingAssembly())
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
    Public WithEvents PlayerNameLabel As System.Windows.Forms.Label
    Public WithEvents LevelNumberLabel As System.Windows.Forms.Label
    Public WithEvents BoxesLabel As System.Windows.Forms.Label
    Public WithEvents PushesLabel As System.Windows.Forms.Label
    Public WithEvents MovesLabel As System.Windows.Forms.Label
    Public WithEvents PicStatusBar As System.Windows.Forms.Panel
    Public WithEvents StartNewGameMenuItem As System.Windows.Forms.MenuItem
    Public WithEvents GameWarpMenuItem As System.Windows.Forms.MenuItem
    Public WithEvents ClassicLevelsetMenuItem As System.Windows.Forms.MenuItem
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GameBoard))
        Me.PicStatusBar = New System.Windows.Forms.Panel()
        Me.PlayerNameLabel = New System.Windows.Forms.Label()
        Me.LevelNumberLabel = New System.Windows.Forms.Label()
        Me.BoxesLabel = New System.Windows.Forms.Label()
        Me.PushesLabel = New System.Windows.Forms.Label()
        Me.MovesLabel = New System.Windows.Forms.Label()
        Me.MainMenu1 = New System.Windows.Forms.MainMenu(Me.components)
        Me.MnuGame = New System.Windows.Forms.MenuItem()
        Me.StartNewGameMenuItem = New System.Windows.Forms.MenuItem()
        Me.GameWarpMenuItem = New System.Windows.Forms.MenuItem()
        Me.MnuGameSet = New System.Windows.Forms.MenuItem()
        Me.ClassicLevelsetMenuItem = New System.Windows.Forms.MenuItem()
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
        Me.SkrzynkiTrayIcon = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.PicStatusBar.SuspendLayout()
        Me.SuspendLayout()
        '
        'PicStatusBar
        '
        Me.PicStatusBar.BackColor = System.Drawing.SystemColors.Control
        Me.PicStatusBar.Controls.Add(Me.PlayerNameLabel)
        Me.PicStatusBar.Controls.Add(Me.LevelNumberLabel)
        Me.PicStatusBar.Controls.Add(Me.BoxesLabel)
        Me.PicStatusBar.Controls.Add(Me.PushesLabel)
        Me.PicStatusBar.Controls.Add(Me.MovesLabel)
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
        'PlayerNameLabel
        '
        Me.PlayerNameLabel.BackColor = System.Drawing.SystemColors.Control
        Me.PlayerNameLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PlayerNameLabel.Cursor = System.Windows.Forms.Cursors.Default
        Me.PlayerNameLabel.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PlayerNameLabel.ForeColor = System.Drawing.SystemColors.ControlText
        Me.PlayerNameLabel.Location = New System.Drawing.Point(372, 0)
        Me.PlayerNameLabel.Name = "PlayerNameLabel"
        Me.PlayerNameLabel.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.PlayerNameLabel.Size = New System.Drawing.Size(137, 17)
        Me.PlayerNameLabel.TabIndex = 6
        Me.PlayerNameLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'LevelNumberLabel
        '
        Me.LevelNumberLabel.BackColor = System.Drawing.SystemColors.Control
        Me.LevelNumberLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LevelNumberLabel.Cursor = System.Windows.Forms.Cursors.Default
        Me.LevelNumberLabel.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LevelNumberLabel.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LevelNumberLabel.Location = New System.Drawing.Point(272, 0)
        Me.LevelNumberLabel.Name = "LevelNumberLabel"
        Me.LevelNumberLabel.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.LevelNumberLabel.Size = New System.Drawing.Size(101, 17)
        Me.LevelNumberLabel.TabIndex = 5
        Me.LevelNumberLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'BoxesLabel
        '
        Me.BoxesLabel.BackColor = System.Drawing.SystemColors.Control
        Me.BoxesLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.BoxesLabel.Cursor = System.Windows.Forms.Cursors.Default
        Me.BoxesLabel.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BoxesLabel.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BoxesLabel.Location = New System.Drawing.Point(176, 0)
        Me.BoxesLabel.Name = "BoxesLabel"
        Me.BoxesLabel.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BoxesLabel.Size = New System.Drawing.Size(97, 17)
        Me.BoxesLabel.TabIndex = 4
        Me.BoxesLabel.Text = "Skrzynki: ##/##"
        Me.BoxesLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'PushesLabel
        '
        Me.PushesLabel.BackColor = System.Drawing.SystemColors.Control
        Me.PushesLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PushesLabel.Cursor = System.Windows.Forms.Cursors.Default
        Me.PushesLabel.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PushesLabel.ForeColor = System.Drawing.SystemColors.ControlText
        Me.PushesLabel.Location = New System.Drawing.Point(88, 0)
        Me.PushesLabel.Name = "PushesLabel"
        Me.PushesLabel.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.PushesLabel.Size = New System.Drawing.Size(89, 17)
        Me.PushesLabel.TabIndex = 3
        Me.PushesLabel.Text = "Pchnięcia: ###"
        Me.PushesLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'MovesLabel
        '
        Me.MovesLabel.BackColor = System.Drawing.SystemColors.Control
        Me.MovesLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.MovesLabel.Cursor = System.Windows.Forms.Cursors.Default
        Me.MovesLabel.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MovesLabel.ForeColor = System.Drawing.SystemColors.ControlText
        Me.MovesLabel.Location = New System.Drawing.Point(16, 0)
        Me.MovesLabel.Name = "MovesLabel"
        Me.MovesLabel.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.MovesLabel.Size = New System.Drawing.Size(73, 17)
        Me.MovesLabel.TabIndex = 2
        Me.MovesLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'MainMenu1
        '
        Me.MainMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MnuGame, Me.MnuView, Me.MnuTools, Me.MnuHelp})
        '
        'MnuGame
        '
        Me.MnuGame.Index = 0
        Me.MnuGame.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.StartNewGameMenuItem, Me.GameWarpMenuItem, Me.MnuGameSet, Me.MnuGameOpen, Me.MnuGameBar0, Me.MnuGameExit})
        Me.MnuGame.Text = Me.Localizer.GetString("GameMenuItem")
        '
        'StartNewGameMenuItem
        '
        Me.StartNewGameMenuItem.Index = 0
        Me.StartNewGameMenuItem.Text = "&Nowa gra..."
        '
        'GameWarpMenuItem
        '
        Me.GameWarpMenuItem.Index = 1
        Me.GameWarpMenuItem.Shortcut = System.Windows.Forms.Shortcut.F3
        Me.GameWarpMenuItem.Text = "Wybierz &etap..."
        '
        'MnuGameSet
        '
        Me.MnuGameSet.Index = 2
        Me.MnuGameSet.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.ClassicLevelsetMenuItem, Me.MnuGameSetSuperTrudneXS})
        Me.MnuGameSet.Text = "Wybierz &zestaw etapów"
        '
        'ClassicLevelsetMenuItem
        '
        Me.ClassicLevelsetMenuItem.Checked = True
        Me.ClassicLevelsetMenuItem.Index = 0
        Me.ClassicLevelsetMenuItem.Text = ""
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
        Me.MenuItem3.Shortcut = System.Windows.Forms.Shortcut.CtrlH
        Me.MenuItem3.Text = "Ukryj okno"
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
        Me.MnuToolsUndo.Shortcut = System.Windows.Forms.Shortcut.CtrlZ
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
        'SkrzynkiTrayIcon
        '
        Me.SkrzynkiTrayIcon.Icon = CType(resources.GetObject("SkrzynkiTrayIcon.Icon"), System.Drawing.Icon)
        Me.SkrzynkiTrayIcon.Text = "Skrzynki chowają się w kącie..."
        '
        'GameBoard
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
        Me.Name = "GameBoard"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Skrzynki"
        Me.PicStatusBar.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
#End Region

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

                PokazNaPaskuStanu(1, Localizer.GetString("Moves") & Ruchy)
                PokazNaPaskuStanu(2, Localizer.GetString("Pushes") & Pchniecia)
                PokazNaPaskuStanu(3, Localizer.GetString("Boxes") & Etap.SkrzynkiNaMiejscach & "/" & Etap.LiczbaSkrzynek)

                If WykonanoRuch = False Then
                    WykonanoRuch = True
                    Me.MnuToolsUndo.Enabled = True
                End If

                If Etap.SkrzynkiNaMiejscach = Etap.LiczbaSkrzynek Then
                    MsgBox(Localizer.GetString("SolvedAlert"), MsgBoxStyle.OkOnly Or MsgBoxStyle.Information Or MsgBoxStyle.ApplicationModal, System.Reflection.Assembly.GetExecutingAssembly.GetName.Name)
                    EtapZaliczony = True
                    NumerEtapu += 1
                    If NumerEtapu > UBound(Etapy, 1) Then
                        MsgBox(Localizer.GetString("Moves"), MsgBoxStyle.OkOnly Or MsgBoxStyle.Information Or MsgBoxStyle.ApplicationModal, System.Reflection.Assembly.GetExecutingAssembly.GetName.Name)
                    Else
                        NastepnyEtap()
                    End If
                    Me.MnuToolsUndo.Enabled = False
                    OdswiezPoleGry()
                    PokazNaPaskuStanu(1, Localizer.GetString("Moves") & Ruchy)
                    PokazNaPaskuStanu(2, Localizer.GetString("Pushes") & Pchniecia)
                    PokazNaPaskuStanu(3, Localizer.GetString("Boxes") & DaneEtapow(NumerEtapu).SkrzynkiNaMiejscach & "/" & DaneEtapow(NumerEtapu).LiczbaSkrzynek)
                    PokazNaPaskuStanu(4, "#" & NumerEtapu)
                    Me.Text = Localizer.GetString("GameName") & " - #" & NumerEtapu
                End If
            Else
                Interaction.Beep()
            End If
        End If
    End Sub
    Private Sub FrmMain_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
        Me.Icon = My.Resources.ico101
        Localizer = New System.Resources.ResourceManager("Skrzynki.LocalizableStrings", System.Reflection.Assembly.GetExecutingAssembly())

        ZestawEtapow = My.Settings.LevelSet
        NumerEtapu = 1
        WykonanoRuch = False
        EtapZaliczony = False

        Stats.OdczytajStatystyki()

        Me.BackColor = Color.Black
        Me.PicStatusBar.Visible = True

        PokazNaPaskuStanu(5, System.Security.Principal.WindowsIdentity.GetCurrent().Name)

        Dim SuccessfulNewGame As Boolean = False
        If EtapSpozaZestawu = False Then
            If My.Settings.BeginFromArrivedLevel = True Then
                SuccessfulNewGame = NowaGra((NajdalszyEtap()))
            Else
                SuccessfulNewGame = NowaGra((1))
            End If

            If Not SuccessfulNewGame Then
                MsgBox(Localizer.GetString("LevelsetLoadFailure"), MsgBoxStyle.OkOnly Or MsgBoxStyle.Critical Or MsgBoxStyle.ApplicationModal, System.Reflection.Assembly.GetExecutingAssembly.GetName.Name)

            End If

            OdswiezPoleGry()

            Me.MnuToolsUndo.Enabled = False

            PokazNaPaskuStanu(1, Localizer.GetString("Moves") & Ruchy)
            PokazNaPaskuStanu(2, Localizer.GetString("Pushes") & Pchniecia)
            PokazNaPaskuStanu(3, Localizer.GetString("Boxes") & Etap.SkrzynkiNaMiejscach & "/" & Etap.LiczbaSkrzynek)
            PokazNaPaskuStanu(4, "#" & NumerEtapu)
            PokazNaPaskuStanu(5, System.Security.Principal.WindowsIdentity.GetCurrent().Name)
            Me.Text = System.Reflection.Assembly.GetExecutingAssembly.GetName.Name & " - #" & NumerEtapu
        End If

    End Sub

    Private Sub FrmMain_Closed(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Closed
        ZapiszStatystyki()
        End
    End Sub

    Public Sub PokazNaPaskuStanu(ByVal numerPanelu As Byte, ByVal Napis As String)
        Select Case numerPanelu
            Case 1
                MovesLabel.Text = Napis
            Case 2
                PushesLabel.Text = Napis
            Case 3
                BoxesLabel.Text = Napis
            Case 4
                LevelNumberLabel.Text = Napis
            Case 5
                PlayerNameLabel.Text = Napis
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
    Public Sub MnuGameNew_Popup(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles StartNewGameMenuItem.Popup
        MnuGameNew_Click(eventSender, eventArgs)
    End Sub
    Public Sub MnuGameNew_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles StartNewGameMenuItem.Click
        NowaGra((1))

        OdswiezPoleGry()

        Me.MnuToolsUndo.Enabled = False

        PokazNaPaskuStanu(1, Localizer.GetString("Moves") & Ruchy)
        PokazNaPaskuStanu(2, Localizer.GetString("Pushes") & Pchniecia)
        PokazNaPaskuStanu(3, Localizer.GetString("Boxes") & Etap.SkrzynkiNaMiejscach & "/" & Etap.LiczbaSkrzynek)
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
                MsgBox(Replace(Localizer.GetString("LevelFromFileLoadSuccess"), "<filename>", NazwaPliku), MsgBoxStyle.OkOnly Or MsgBoxStyle.Information Or MsgBoxStyle.ApplicationModal, System.Reflection.Assembly.GetExecutingAssembly.GetName.Name)
            End If
        End If

    End Sub
    Public Sub MnuGameSet_Popup(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MnuGameSet.Popup
        MnuGameSet_Click(eventSender, eventArgs)
    End Sub
    Public Sub MnuGameSet_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MnuGameSet.Click
        If My.Settings.LevelSet = "Klasyczne" Then
            ClassicLevelsetMenuItem.Checked = True
            MnuGameSetSuperTrudneXS.Checked = False
        Else
            ClassicLevelsetMenuItem.Checked = False
            MnuGameSetSuperTrudneXS.Checked = True
        End If
    End Sub

    Public Sub MnuGameSetKlasyczne_Popup(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles ClassicLevelsetMenuItem.Popup
        MnuGameSetKlasyczne_Click(eventSender, eventArgs)
    End Sub
    Public Sub MnuGameSetKlasyczne_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles ClassicLevelsetMenuItem.Click
        My.Settings.LevelSet = "Klasyczne"
        ClassicLevelsetMenuItem.Checked = True
        MnuGameSetSuperTrudneXS.Checked = False
        NowaGra(1, My.Settings.LevelSet)

        OdswiezPoleGry()

        Me.MnuToolsUndo.Enabled = False

        PokazNaPaskuStanu(1, Localizer.GetString("Moves") & Ruchy)
        PokazNaPaskuStanu(2, Localizer.GetString("Pushes") & Pchniecia)
        PokazNaPaskuStanu(3, Localizer.GetString("Boxes") & Etap.SkrzynkiNaMiejscach & "/" & Etap.LiczbaSkrzynek)
        PokazNaPaskuStanu(4, "#" & NumerEtapu)
        PokazNaPaskuStanu(5, System.Security.Principal.WindowsIdentity.GetCurrent().Name)
        Me.Text = System.Reflection.Assembly.GetExecutingAssembly.GetName.Name & " - #" & NumerEtapu
    End Sub

    Public Sub MnuGameSetSuperTrudneXS_Popup(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MnuGameSetSuperTrudneXS.Popup
        MnuGameSetSuperTrudneXS_Click(eventSender, eventArgs)
    End Sub
    Public Sub MnuGameSetSuperTrudneXS_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MnuGameSetSuperTrudneXS.Click
        My.Settings.LevelSet = "SuperTrudneXS"
        ClassicLevelsetMenuItem.Checked = False
        MnuGameSetSuperTrudneXS.Checked = True
        NowaGra(1, My.Settings.LevelSet)

        OdswiezPoleGry()

        Me.MnuToolsUndo.Enabled = False

        PokazNaPaskuStanu(1, Localizer.GetString("Moves") & Ruchy)
        PokazNaPaskuStanu(2, Localizer.GetString("Pushes") & Pchniecia)
        PokazNaPaskuStanu(3, Localizer.GetString("Boxes") & Etap.SkrzynkiNaMiejscach & "/" & Etap.LiczbaSkrzynek)
        PokazNaPaskuStanu(4, "#" & NumerEtapu)
        PokazNaPaskuStanu(5, System.Security.Principal.WindowsIdentity.GetCurrent().Name)
        Me.Text = System.Reflection.Assembly.GetExecutingAssembly.GetName.Name & " - #" & NumerEtapu
    End Sub

    Public Sub MnuGameWarp_Popup(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles GameWarpMenuItem.Popup
        MnuGameWarp_Click(eventSender, eventArgs)
    End Sub
    Public Sub MnuGameWarp_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles GameWarpMenuItem.Click
        Dim IB As String = InputBox(Localizer.GetString("SelectLevelQuery"), System.Reflection.Assembly.GetExecutingAssembly.GetName.Name, CStr(NajdalszyEtap()))
        If IB = "" Then
            Exit Sub
        End If

        If IsNumeric(IB) = False Then
            MsgBox(Localizer.GetString("NaNAlert"), MsgBoxStyle.OkOnly Or MsgBoxStyle.Critical Or MsgBoxStyle.ApplicationModal, System.Reflection.Assembly.GetExecutingAssembly.GetName.Name)
            Exit Sub
        End If

        If (Val(IB) > Val(CStr(NajdalszyEtap()))) And (Val(IB) <= Val(CStr(UBound(Etapy, 1)))) Then
            MsgBox(Localizer.GetString("LevelNotReachedYetAlert"), MsgBoxStyle.OkOnly Or MsgBoxStyle.Critical Or MsgBoxStyle.ApplicationModal, System.Reflection.Assembly.GetExecutingAssembly.GetName.Name)
            Exit Sub
        Else
            If (Val(IB) > Val(CStr(UBound(Etapy, 1)))) Or Val(IB) <= 0 Then
                MsgBox(Localizer.GetString("LevelDoesntExistAlert"), MsgBoxStyle.OkOnly Or MsgBoxStyle.Critical Or MsgBoxStyle.ApplicationModal, System.Reflection.Assembly.GetExecutingAssembly.GetName.Name)
                Exit Sub
            End If

            NumerEtapu = CInt(Val(IB))
            For Licznik = 1 To 256
                PoleGry(Licznik) = Etapy(NumerEtapu, Licznik)
                'UPGRADE_WARNING: Couldn't resolve default property of object Etap. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
                Etap = DaneEtapow(NumerEtapu)
                PozycjaGracza = PozycjeGracza(NumerEtapu)
            Next Licznik

            PokazNaPaskuStanu(1, Localizer.GetString("Moves") & Ruchy)
            PokazNaPaskuStanu(2, Localizer.GetString("Pushes") & Pchniecia)
            PokazNaPaskuStanu(3, Localizer.GetString("Boxes") & Etap.SkrzynkiNaMiejscach & "/" & Etap.LiczbaSkrzynek)
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
            Dim TempX As MsgBoxResult = MsgBox(Localizer.GetString("RestartQuery"), MsgBoxStyle.YesNo Or MsgBoxStyle.Question Or MsgBoxStyle.ApplicationModal, System.Reflection.Assembly.GetExecutingAssembly.GetName.Name)
            If TempX = MsgBoxResult.Yes Then
                RestartujEtap()
                OdswiezPoleGry()
            End If
        Else
            RestartujEtap()
            OdswiezPoleGry()
        End If
        Me.MnuToolsUndo.Enabled = False
        PokazNaPaskuStanu(1, Localizer.GetString("Moves") & Ruchy)
        PokazNaPaskuStanu(2, Localizer.GetString("Pushes") & Pchniecia)
        PokazNaPaskuStanu(3, Localizer.GetString("Boxes") & Etap.SkrzynkiNaMiejscach & "/" & Etap.LiczbaSkrzynek)
        PokazNaPaskuStanu(4, "#" & NumerEtapu)
        Me.Text = "Skrzynki - #" & NumerEtapu
    End Sub
    Public Sub MnuToolsUndo_Popup(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MnuToolsUndo.Popup
        MnuToolsUndo_Click(eventSender, eventArgs)
    End Sub
    Public Sub MnuToolsUndo_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MnuToolsUndo.Click
        Cofnij()
        OdswiezPoleGry()
        PokazNaPaskuStanu(3, Localizer.GetString("Boxes") & Etap.SkrzynkiNaMiejscach & "/" & Etap.LiczbaSkrzynek)
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
        ColorDialog1.Dispose()
    End Sub

    Private Sub SkrzynkiTrayIcon_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles SkrzynkiTrayIcon.MouseDoubleClick
        SkrzynkiTrayIcon.Visible = False
        Me.Visible = True
    End Sub

    Private Sub SkrzynkiTrayIcon_MouseClick(sender As Object, e As MouseEventArgs) Handles SkrzynkiTrayIcon.MouseClick
        SkrzynkiTrayIcon.Visible = False
        Me.Visible = True
    End Sub

    Private Sub MenuItem3_Click(sender As Object, e As EventArgs) Handles MenuItem3.Click
        SkrzynkiTrayIcon.Visible = True
        Me.Visible = False
    End Sub
End Class