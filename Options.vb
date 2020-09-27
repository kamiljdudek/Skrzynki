Option Strict Off
Option Explicit On
Friend Class frmOptions
	Inherits System.Windows.Forms.Form
#Region "Windows Form Designer generated code "
	Public Sub New()
		MyBase.New()
		If m_vb6FormDefInstance Is Nothing Then
			If m_InitializingDefInstance Then
				m_vb6FormDefInstance = Me
			Else
				Try 
					'For the start-up form, the first instance created is the default instance.
					If System.Reflection.Assembly.GetExecutingAssembly.EntryPoint.DeclaringType Is Me.GetType Then
						m_vb6FormDefInstance = Me
					End If
				Catch
				End Try
			End If
		End If
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
	Public ToolTip1 As System.Windows.Forms.ToolTip
	Public WithEvents cmdApply As System.Windows.Forms.Button
    Public WithEvents chkShowTipsAtStartup As System.Windows.Forms.CheckBox
	Public WithEvents chkShowSplashAtStartup As System.Windows.Forms.CheckBox
	Public WithEvents Frame2 As System.Windows.Forms.GroupBox
	Public WithEvents chkWantClosingAuthorization As System.Windows.Forms.CheckBox
	Public WithEvents chkWantLevelRestartingAuthorization As System.Windows.Forms.CheckBox
	Public WithEvents chkShowLevelLoadConfirmation As System.Windows.Forms.CheckBox
	Public WithEvents Frame1 As System.Windows.Forms.GroupBox
	Public WithEvents chkBeginFromArrivedLevel As System.Windows.Forms.CheckBox
	Public WithEvents cmbShowInTray As System.Windows.Forms.ComboBox
	Public WithEvents _tabOptions_TabPage0 As System.Windows.Forms.TabPage
	Public WithEvents _picPreview_6 As System.Windows.Forms.PictureBox
	Public WithEvents _picPreview_5 As System.Windows.Forms.PictureBox
	Public WithEvents _picPreview_4 As System.Windows.Forms.PictureBox
	Public WithEvents _picPreview_3 As System.Windows.Forms.PictureBox
	Public WithEvents _picPreview_2 As System.Windows.Forms.PictureBox
	Public WithEvents _picPreview_0 As System.Windows.Forms.PictureBox
	Public WithEvents _picPreview_1 As System.Windows.Forms.PictureBox
	Public WithEvents Label2 As System.Windows.Forms.Label
	Public WithEvents Frame4 As System.Windows.Forms.GroupBox
	Public WithEvents lstSkins As System.Windows.Forms.ListBox
	Public WithEvents Frame3 As System.Windows.Forms.GroupBox
	Public WithEvents cmdBackgroundColor As System.Windows.Forms.Button
	Public WithEvents Label1 As System.Windows.Forms.Label
	Public WithEvents Frame5 As System.Windows.Forms.GroupBox
	Public WithEvents _tabOptions_TabPage1 As System.Windows.Forms.TabPage
	Public WithEvents cmdDeletePlayer As System.Windows.Forms.Button
	Public WithEvents cmdNewPlayer As System.Windows.Forms.Button
	Public WithEvents lstPlayers As System.Windows.Forms.ListBox
	Public WithEvents Frame7 As System.Windows.Forms.GroupBox
	Public WithEvents cmdPrevSet As System.Windows.Forms.Button
	Public WithEvents cmdNextSet As System.Windows.Forms.Button
	Public WithEvents lblPushes As System.Windows.Forms.Label
	Public WithEvents lblMoves As System.Windows.Forms.Label
	Public WithEvents lblArrivedLevel As System.Windows.Forms.Label
	Public WithEvents Label8 As System.Windows.Forms.Label
	Public WithEvents Label7 As System.Windows.Forms.Label
	Public WithEvents Label6 As System.Windows.Forms.Label
	Public WithEvents lblLevelSet As System.Windows.Forms.Label
	Public WithEvents Frame8 As System.Windows.Forms.GroupBox
    Public WithEvents Frame9 As System.Windows.Forms.GroupBox
	Public WithEvents chkFirstPlayerAutoLogon As System.Windows.Forms.CheckBox
	Public WithEvents _tabOptions_TabPage2 As System.Windows.Forms.TabPage
    Public WithEvents tabOptions As System.Windows.Forms.TabControl
	Public WithEvents fraSample4 As System.Windows.Forms.GroupBox
	Public WithEvents _picOptions_3 As System.Windows.Forms.Panel
	Public WithEvents fraSample3 As System.Windows.Forms.GroupBox
	Public WithEvents _picOptions_2 As System.Windows.Forms.Panel
	Public WithEvents fraSample2 As System.Windows.Forms.GroupBox
	Public WithEvents _picOptions_1 As System.Windows.Forms.Panel
	Public WithEvents cmdCancel As System.Windows.Forms.Button
	Public WithEvents cmdOK As System.Windows.Forms.Button
    'Public WithEvents picOptions As Microsoft.VisualBasic.Compatibility.VB6.PanelArray
    'Public WithEvents picPreview As Microsoft.VisualBasic.Compatibility.VB6.PictureBoxArray
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.cmdApply = New System.Windows.Forms.Button
        Me.tabOptions = New System.Windows.Forms.TabControl
        Me._tabOptions_TabPage0 = New System.Windows.Forms.TabPage
        Me.Frame2 = New System.Windows.Forms.GroupBox
        Me.chkShowTipsAtStartup = New System.Windows.Forms.CheckBox
        Me.chkShowSplashAtStartup = New System.Windows.Forms.CheckBox
        Me.Frame1 = New System.Windows.Forms.GroupBox
        Me.chkWantClosingAuthorization = New System.Windows.Forms.CheckBox
        Me.chkWantLevelRestartingAuthorization = New System.Windows.Forms.CheckBox
        Me.chkShowLevelLoadConfirmation = New System.Windows.Forms.CheckBox
        Me.chkBeginFromArrivedLevel = New System.Windows.Forms.CheckBox
        Me.cmbShowInTray = New System.Windows.Forms.ComboBox
        Me._tabOptions_TabPage1 = New System.Windows.Forms.TabPage
        Me.Frame3 = New System.Windows.Forms.GroupBox
        Me.Frame4 = New System.Windows.Forms.GroupBox
        Me._picPreview_6 = New System.Windows.Forms.PictureBox
        Me._picPreview_5 = New System.Windows.Forms.PictureBox
        Me._picPreview_4 = New System.Windows.Forms.PictureBox
        Me._picPreview_3 = New System.Windows.Forms.PictureBox
        Me._picPreview_2 = New System.Windows.Forms.PictureBox
        Me._picPreview_0 = New System.Windows.Forms.PictureBox
        Me._picPreview_1 = New System.Windows.Forms.PictureBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.lstSkins = New System.Windows.Forms.ListBox
        Me.Frame5 = New System.Windows.Forms.GroupBox
        Me.cmdBackgroundColor = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me._tabOptions_TabPage2 = New System.Windows.Forms.TabPage
        Me.Frame7 = New System.Windows.Forms.GroupBox
        Me.cmdDeletePlayer = New System.Windows.Forms.Button
        Me.cmdNewPlayer = New System.Windows.Forms.Button
        Me.lstPlayers = New System.Windows.Forms.ListBox
        Me.Frame8 = New System.Windows.Forms.GroupBox
        Me.cmdPrevSet = New System.Windows.Forms.Button
        Me.cmdNextSet = New System.Windows.Forms.Button
        Me.lblPushes = New System.Windows.Forms.Label
        Me.lblMoves = New System.Windows.Forms.Label
        Me.lblArrivedLevel = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.lblLevelSet = New System.Windows.Forms.Label
        Me.Frame9 = New System.Windows.Forms.GroupBox
        Me.chkFirstPlayerAutoLogon = New System.Windows.Forms.CheckBox
        Me._picOptions_3 = New System.Windows.Forms.Panel
        Me.fraSample4 = New System.Windows.Forms.GroupBox
        Me._picOptions_2 = New System.Windows.Forms.Panel
        Me.fraSample3 = New System.Windows.Forms.GroupBox
        Me._picOptions_1 = New System.Windows.Forms.Panel
        Me.fraSample2 = New System.Windows.Forms.GroupBox
        Me.cmdCancel = New System.Windows.Forms.Button
        Me.cmdOK = New System.Windows.Forms.Button
        'Me.picOptions = New Microsoft.VisualBasic.Compatibility.VB6.PanelArray(Me.components)
        'Me.picPreview = New Microsoft.VisualBasic.Compatibility.VB6.PictureBoxArray(Me.components)
        Me.tabOptions.SuspendLayout()
        Me._tabOptions_TabPage0.SuspendLayout()
        Me.Frame2.SuspendLayout()
        Me.Frame1.SuspendLayout()
        Me._tabOptions_TabPage1.SuspendLayout()
        Me.Frame3.SuspendLayout()
        Me.Frame4.SuspendLayout()
        Me.Frame5.SuspendLayout()
        Me._tabOptions_TabPage2.SuspendLayout()
        Me.Frame7.SuspendLayout()
        Me.Frame8.SuspendLayout()
        Me._picOptions_3.SuspendLayout()
        Me._picOptions_2.SuspendLayout()
        Me._picOptions_1.SuspendLayout()
        'CType(Me.picOptions, System.ComponentModel.ISupportInitialize).BeginInit()
        'CType(Me.picPreview, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdApply
        '
        Me.cmdApply.BackColor = System.Drawing.SystemColors.Control
        Me.cmdApply.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdApply.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdApply.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdApply.Location = New System.Drawing.Point(267, 312)
        Me.cmdApply.Name = "cmdApply"
        Me.cmdApply.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdApply.Size = New System.Drawing.Size(73, 25)
        Me.cmdApply.TabIndex = 28
        Me.cmdApply.Tag = "Buttons#2"
        Me.cmdApply.Text = "&Zastosuj"
        '
        'tabOptions
        '
        Me.tabOptions.Appearance = System.Windows.Forms.TabAppearance.FlatButtons
        Me.tabOptions.Controls.Add(Me._tabOptions_TabPage0)
        Me.tabOptions.Controls.Add(Me._tabOptions_TabPage1)
        Me.tabOptions.Controls.Add(Me._tabOptions_TabPage2)
        Me.tabOptions.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabOptions.ItemSize = New System.Drawing.Size(42, 18)
        Me.tabOptions.Location = New System.Drawing.Point(8, 4)
        Me.tabOptions.Name = "tabOptions"
        Me.tabOptions.SelectedIndex = 0
        Me.tabOptions.Size = New System.Drawing.Size(427, 301)
        Me.tabOptions.TabIndex = 8
        '
        '_tabOptions_TabPage0
        '
        Me._tabOptions_TabPage0.Controls.Add(Me.Frame2)
        Me._tabOptions_TabPage0.Controls.Add(Me.Frame1)
        Me._tabOptions_TabPage0.Controls.Add(Me.chkBeginFromArrivedLevel)
        Me._tabOptions_TabPage0.Controls.Add(Me.cmbShowInTray)
        Me._tabOptions_TabPage0.Location = New System.Drawing.Point(4, 22)
        Me._tabOptions_TabPage0.Name = "_tabOptions_TabPage0"
        Me._tabOptions_TabPage0.Size = New System.Drawing.Size(419, 275)
        Me._tabOptions_TabPage0.TabIndex = 0
        Me._tabOptions_TabPage0.Text = "&Ogólne"
        '
        'Frame2
        '
        Me.Frame2.BackColor = System.Drawing.SystemColors.Control
        Me.Frame2.Controls.Add(Me.chkShowTipsAtStartup)
        Me.Frame2.Controls.Add(Me.chkShowSplashAtStartup)
        Me.Frame2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frame2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame2.Location = New System.Drawing.Point(14, 39)
        Me.Frame2.Name = "Frame2"
        Me.Frame2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame2.Size = New System.Drawing.Size(340, 75)
        Me.Frame2.TabIndex = 9
        Me.Frame2.TabStop = False
        Me.Frame2.Tag = "OptionsDialog#5"
        Me.Frame2.Text = "Porady dnia i ekran tytu³owy"
        '
        'chkShowTipsAtStartup
        '
        Me.chkShowTipsAtStartup.BackColor = System.Drawing.SystemColors.Control
        Me.chkShowTipsAtStartup.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkShowTipsAtStartup.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkShowTipsAtStartup.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkShowTipsAtStartup.Location = New System.Drawing.Point(9, 23)
        Me.chkShowTipsAtStartup.Name = "chkShowTipsAtStartup"
        Me.chkShowTipsAtStartup.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkShowTipsAtStartup.Size = New System.Drawing.Size(320, 16)
        Me.chkShowTipsAtStartup.TabIndex = 11
        Me.chkShowTipsAtStartup.Tag = "OptionsDialog#6#Show Tips at Startup"
        Me.chkShowTipsAtStartup.Text = "Pokazuj &porady dnia"
        '
        'chkShowSplashAtStartup
        '
        Me.chkShowSplashAtStartup.BackColor = System.Drawing.SystemColors.Control
        Me.chkShowSplashAtStartup.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkShowSplashAtStartup.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkShowSplashAtStartup.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkShowSplashAtStartup.Location = New System.Drawing.Point(9, 49)
        Me.chkShowSplashAtStartup.Name = "chkShowSplashAtStartup"
        Me.chkShowSplashAtStartup.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkShowSplashAtStartup.Size = New System.Drawing.Size(319, 15)
        Me.chkShowSplashAtStartup.TabIndex = 10
        Me.chkShowSplashAtStartup.Tag = "OptionsDialog#7#Show Splash at Startup"
        Me.chkShowSplashAtStartup.Text = "Pokazuj ekran &tytu³owy"
        '
        'Frame1
        '
        Me.Frame1.BackColor = System.Drawing.SystemColors.Control
        Me.Frame1.Controls.Add(Me.chkWantClosingAuthorization)
        Me.Frame1.Controls.Add(Me.chkWantLevelRestartingAuthorization)
        Me.Frame1.Controls.Add(Me.chkShowLevelLoadConfirmation)
        Me.Frame1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frame1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame1.Location = New System.Drawing.Point(15, 123)
        Me.Frame1.Name = "Frame1"
        Me.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame1.Size = New System.Drawing.Size(340, 96)
        Me.Frame1.TabIndex = 12
        Me.Frame1.TabStop = False
        Me.Frame1.Tag = "OptionsDialog#8"
        Me.Frame1.Text = "Potwierdzenia"
        '
        'chkWantClosingAuthorization
        '
        Me.chkWantClosingAuthorization.BackColor = System.Drawing.SystemColors.Control
        Me.chkWantClosingAuthorization.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkWantClosingAuthorization.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkWantClosingAuthorization.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkWantClosingAuthorization.Location = New System.Drawing.Point(8, 18)
        Me.chkWantClosingAuthorization.Name = "chkWantClosingAuthorization"
        Me.chkWantClosingAuthorization.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkWantClosingAuthorization.Size = New System.Drawing.Size(283, 18)
        Me.chkWantClosingAuthorization.TabIndex = 15
        Me.chkWantClosingAuthorization.Tag = "OptionsDialog#9#Want Closing Authorization"
        Me.chkWantClosingAuthorization.Text = "Pytaj o potwierdzenie z&akoñczenia dzia³ania programu"
        '
        'chkWantLevelRestartingAuthorization
        '
        Me.chkWantLevelRestartingAuthorization.BackColor = System.Drawing.SystemColors.Control
        Me.chkWantLevelRestartingAuthorization.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkWantLevelRestartingAuthorization.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkWantLevelRestartingAuthorization.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkWantLevelRestartingAuthorization.Location = New System.Drawing.Point(8, 43)
        Me.chkWantLevelRestartingAuthorization.Name = "chkWantLevelRestartingAuthorization"
        Me.chkWantLevelRestartingAuthorization.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkWantLevelRestartingAuthorization.Size = New System.Drawing.Size(277, 18)
        Me.chkWantLevelRestartingAuthorization.TabIndex = 14
        Me.chkWantLevelRestartingAuthorization.Tag = "OptionsDialog#10#Want Level Restarting Authorization"
        Me.chkWantLevelRestartingAuthorization.Text = "Pytaj o potwierdzenie &restartowania aktualnego etapu"
        '
        'chkShowLevelLoadConfirmation
        '
        Me.chkShowLevelLoadConfirmation.BackColor = System.Drawing.SystemColors.Control
        Me.chkShowLevelLoadConfirmation.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkShowLevelLoadConfirmation.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkShowLevelLoadConfirmation.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkShowLevelLoadConfirmation.Location = New System.Drawing.Point(8, 68)
        Me.chkShowLevelLoadConfirmation.Name = "chkShowLevelLoadConfirmation"
        Me.chkShowLevelLoadConfirmation.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkShowLevelLoadConfirmation.Size = New System.Drawing.Size(314, 18)
        Me.chkShowLevelLoadConfirmation.TabIndex = 13
        Me.chkShowLevelLoadConfirmation.Tag = "OptionsDialog#11#Show Level Load Confirmation"
        Me.chkShowLevelLoadConfirmation.Text = "Wyœwietlaj potwierdzenie &wczytania etapu"
        '
        'chkBeginFromArrivedLevel
        '
        Me.chkBeginFromArrivedLevel.BackColor = System.Drawing.SystemColors.Control
        Me.chkBeginFromArrivedLevel.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkBeginFromArrivedLevel.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkBeginFromArrivedLevel.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkBeginFromArrivedLevel.Location = New System.Drawing.Point(14, 227)
        Me.chkBeginFromArrivedLevel.Name = "chkBeginFromArrivedLevel"
        Me.chkBeginFromArrivedLevel.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkBeginFromArrivedLevel.Size = New System.Drawing.Size(326, 19)
        Me.chkBeginFromArrivedLevel.TabIndex = 16
        Me.chkBeginFromArrivedLevel.Tag = "OptionsDialog#12#Begin From Arrived Level"
        Me.chkBeginFromArrivedLevel.Text = "Przy uruchomieniu programu wyœwietlaj najdalszy dostêpny &etap"
        '
        'cmbShowInTray
        '
        Me.cmbShowInTray.BackColor = System.Drawing.SystemColors.Window
        Me.cmbShowInTray.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmbShowInTray.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbShowInTray.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbShowInTray.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbShowInTray.Location = New System.Drawing.Point(198, 259)
        Me.cmbShowInTray.Name = "cmbShowInTray"
        Me.cmbShowInTray.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmbShowInTray.Size = New System.Drawing.Size(157, 22)
        Me.cmbShowInTray.TabIndex = 33
        '
        '_tabOptions_TabPage1
        '
        Me._tabOptions_TabPage1.Controls.Add(Me.Frame3)
        Me._tabOptions_TabPage1.Controls.Add(Me.Frame5)
        Me._tabOptions_TabPage1.Location = New System.Drawing.Point(4, 22)
        Me._tabOptions_TabPage1.Name = "_tabOptions_TabPage1"
        Me._tabOptions_TabPage1.Size = New System.Drawing.Size(419, 275)
        Me._tabOptions_TabPage1.TabIndex = 1
        Me._tabOptions_TabPage1.Text = "&Wygl¹d"
        '
        'Frame3
        '
        Me.Frame3.BackColor = System.Drawing.SystemColors.Control
        Me.Frame3.Controls.Add(Me.Frame4)
        Me.Frame3.Controls.Add(Me.lstSkins)
        Me.Frame3.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frame3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame3.Location = New System.Drawing.Point(12, 103)
        Me.Frame3.Name = "Frame3"
        Me.Frame3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame3.Size = New System.Drawing.Size(405, 177)
        Me.Frame3.TabIndex = 17
        Me.Frame3.TabStop = False
        Me.Frame3.Tag = "OptionsDialog#19"
        Me.Frame3.Text = "Skiny"
        '
        'Frame4
        '
        Me.Frame4.BackColor = System.Drawing.SystemColors.Control
        Me.Frame4.Controls.Add(Me._picPreview_6)
        Me.Frame4.Controls.Add(Me._picPreview_5)
        Me.Frame4.Controls.Add(Me._picPreview_4)
        Me.Frame4.Controls.Add(Me._picPreview_3)
        Me.Frame4.Controls.Add(Me._picPreview_2)
        Me.Frame4.Controls.Add(Me._picPreview_0)
        Me.Frame4.Controls.Add(Me._picPreview_1)
        Me.Frame4.Controls.Add(Me.Label2)
        Me.Frame4.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frame4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame4.Location = New System.Drawing.Point(132, 44)
        Me.Frame4.Name = "Frame4"
        Me.Frame4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame4.Size = New System.Drawing.Size(265, 89)
        Me.Frame4.TabIndex = 19
        Me.Frame4.TabStop = False
        Me.Frame4.Tag = "OptionsDialog#20"
        Me.Frame4.Text = "Podgl¹d"
        '
        '_picPreview_6
        '
        Me._picPreview_6.BackColor = System.Drawing.SystemColors.Control
        Me._picPreview_6.Cursor = System.Windows.Forms.Cursors.Default
        Me._picPreview_6.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._picPreview_6.ForeColor = System.Drawing.SystemColors.ControlText
        'Me.picPreview.SetIndex(Me._picPreview_6, CType(6, Short))
        Me._picPreview_6.Location = New System.Drawing.Point(224, 20)
        Me._picPreview_6.Name = "_picPreview_6"
        Me._picPreview_6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._picPreview_6.Size = New System.Drawing.Size(34, 33)
        Me._picPreview_6.TabIndex = 26
        Me._picPreview_6.TabStop = False
        '
        '_picPreview_5
        '
        Me._picPreview_5.BackColor = System.Drawing.SystemColors.Control
        Me._picPreview_5.Cursor = System.Windows.Forms.Cursors.Default
        Me._picPreview_5.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._picPreview_5.ForeColor = System.Drawing.SystemColors.ControlText
        'Me.picPreview.SetIndex(Me._picPreview_5, CType(5, Short))
        Me._picPreview_5.Location = New System.Drawing.Point(188, 20)
        Me._picPreview_5.Name = "_picPreview_5"
        Me._picPreview_5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._picPreview_5.Size = New System.Drawing.Size(34, 33)
        Me._picPreview_5.TabIndex = 25
        Me._picPreview_5.TabStop = False
        '
        '_picPreview_4
        '
        Me._picPreview_4.BackColor = System.Drawing.SystemColors.Control
        Me._picPreview_4.Cursor = System.Windows.Forms.Cursors.Default
        Me._picPreview_4.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._picPreview_4.ForeColor = System.Drawing.SystemColors.ControlText
        'Me.picPreview.SetIndex(Me._picPreview_4, CType(4, Short))
        Me._picPreview_4.Location = New System.Drawing.Point(152, 20)
        Me._picPreview_4.Name = "_picPreview_4"
        Me._picPreview_4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._picPreview_4.Size = New System.Drawing.Size(34, 33)
        Me._picPreview_4.TabIndex = 24
        Me._picPreview_4.TabStop = False
        '
        '_picPreview_3
        '
        Me._picPreview_3.BackColor = System.Drawing.SystemColors.Control
        Me._picPreview_3.Cursor = System.Windows.Forms.Cursors.Default
        Me._picPreview_3.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._picPreview_3.ForeColor = System.Drawing.SystemColors.ControlText
        'Me.picPreview.SetIndex(Me._picPreview_3, CType(3, Short))
        Me._picPreview_3.Location = New System.Drawing.Point(116, 20)
        Me._picPreview_3.Name = "_picPreview_3"
        Me._picPreview_3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._picPreview_3.Size = New System.Drawing.Size(34, 33)
        Me._picPreview_3.TabIndex = 23
        Me._picPreview_3.TabStop = False
        '
        '_picPreview_2
        '
        Me._picPreview_2.BackColor = System.Drawing.SystemColors.Control
        Me._picPreview_2.Cursor = System.Windows.Forms.Cursors.Default
        Me._picPreview_2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._picPreview_2.ForeColor = System.Drawing.SystemColors.ControlText
        'Me.picPreview.SetIndex(Me._picPreview_2, CType(2, Short))
        Me._picPreview_2.Location = New System.Drawing.Point(80, 20)
        Me._picPreview_2.Name = "_picPreview_2"
        Me._picPreview_2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._picPreview_2.Size = New System.Drawing.Size(34, 33)
        Me._picPreview_2.TabIndex = 22
        Me._picPreview_2.TabStop = False
        '
        '_picPreview_0
        '
        Me._picPreview_0.BackColor = System.Drawing.SystemColors.Control
        Me._picPreview_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._picPreview_0.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._picPreview_0.ForeColor = System.Drawing.SystemColors.ControlText
        'Me.picPreview.SetIndex(Me._picPreview_0, CType(0, Short))
        Me._picPreview_0.Location = New System.Drawing.Point(8, 20)
        Me._picPreview_0.Name = "_picPreview_0"
        Me._picPreview_0.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._picPreview_0.Size = New System.Drawing.Size(34, 33)
        Me._picPreview_0.TabIndex = 21
        Me._picPreview_0.TabStop = False
        '
        '_picPreview_1
        '
        Me._picPreview_1.BackColor = System.Drawing.SystemColors.Control
        Me._picPreview_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._picPreview_1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._picPreview_1.ForeColor = System.Drawing.SystemColors.ControlText
        'Me.picPreview.SetIndex(Me._picPreview_1, CType(1, Short))
        Me._picPreview_1.Location = New System.Drawing.Point(44, 20)
        Me._picPreview_1.Name = "_picPreview_1"
        Me._picPreview_1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._picPreview_1.Size = New System.Drawing.Size(34, 33)
        Me._picPreview_1.TabIndex = 20
        Me._picPreview_1.TabStop = False
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.Control
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(20, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(225, 17)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "0          1          2          3           4         5           6"
        '
        'lstSkins
        '
        Me.lstSkins.BackColor = System.Drawing.SystemColors.Window
        Me.lstSkins.Cursor = System.Windows.Forms.Cursors.Default
        Me.lstSkins.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstSkins.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lstSkins.ItemHeight = 14
        Me.lstSkins.Location = New System.Drawing.Point(12, 24)
        Me.lstSkins.Name = "lstSkins"
        Me.lstSkins.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lstSkins.Size = New System.Drawing.Size(113, 130)
        Me.lstSkins.Sorted = True
        Me.lstSkins.TabIndex = 18
        '
        'Frame5
        '
        Me.Frame5.BackColor = System.Drawing.SystemColors.Control
        Me.Frame5.Controls.Add(Me.cmdBackgroundColor)
        Me.Frame5.Controls.Add(Me.Label1)
        Me.Frame5.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frame5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame5.Location = New System.Drawing.Point(12, 35)
        Me.Frame5.Name = "Frame5"
        Me.Frame5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame5.Size = New System.Drawing.Size(401, 49)
        Me.Frame5.TabIndex = 29
        Me.Frame5.TabStop = False
        Me.Frame5.Tag = "OptionsDialog#17"
        Me.Frame5.Text = "T³o"
        '
        'cmdBackgroundColor
        '
        Me.cmdBackgroundColor.BackColor = System.Drawing.SystemColors.Control
        Me.cmdBackgroundColor.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdBackgroundColor.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdBackgroundColor.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdBackgroundColor.Location = New System.Drawing.Point(184, 20)
        Me.cmdBackgroundColor.Name = "cmdBackgroundColor"
        Me.cmdBackgroundColor.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdBackgroundColor.Size = New System.Drawing.Size(82, 17)
        Me.cmdBackgroundColor.TabIndex = 30
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(104, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(69, 17)
        Me.Label1.TabIndex = 31
        Me.Label1.Tag = "OptionsDialog#18"
        Me.Label1.Text = "Kolor t³a:"
        '
        '_tabOptions_TabPage2
        '
        Me._tabOptions_TabPage2.Controls.Add(Me.Frame7)
        Me._tabOptions_TabPage2.Controls.Add(Me.Frame8)
        Me._tabOptions_TabPage2.Controls.Add(Me.Frame9)
        Me._tabOptions_TabPage2.Controls.Add(Me.chkFirstPlayerAutoLogon)
        Me._tabOptions_TabPage2.Location = New System.Drawing.Point(4, 22)
        Me._tabOptions_TabPage2.Name = "_tabOptions_TabPage2"
        Me._tabOptions_TabPage2.Size = New System.Drawing.Size(419, 275)
        Me._tabOptions_TabPage2.TabIndex = 2
        Me._tabOptions_TabPage2.Text = "&Gracze"
        '
        'Frame7
        '
        Me.Frame7.BackColor = System.Drawing.SystemColors.Control
        Me.Frame7.Controls.Add(Me.cmdDeletePlayer)
        Me.Frame7.Controls.Add(Me.cmdNewPlayer)
        Me.Frame7.Controls.Add(Me.lstPlayers)
        Me.Frame7.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frame7.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame7.Location = New System.Drawing.Point(12, 34)
        Me.Frame7.Name = "Frame7"
        Me.Frame7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame7.Size = New System.Drawing.Size(137, 233)
        Me.Frame7.TabIndex = 40
        Me.Frame7.TabStop = False
        Me.Frame7.Tag = "OptionsDialog#21"
        Me.Frame7.Text = "Lista graczy"
        '
        'cmdDeletePlayer
        '
        Me.cmdDeletePlayer.BackColor = System.Drawing.SystemColors.Control
        Me.cmdDeletePlayer.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdDeletePlayer.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdDeletePlayer.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdDeletePlayer.Location = New System.Drawing.Point(72, 200)
        Me.cmdDeletePlayer.Name = "cmdDeletePlayer"
        Me.cmdDeletePlayer.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdDeletePlayer.Size = New System.Drawing.Size(53, 29)
        Me.cmdDeletePlayer.TabIndex = 58
        Me.cmdDeletePlayer.Tag = "OptionsDialog#23"
        Me.cmdDeletePlayer.Text = "&Usuñ"
        '
        'cmdNewPlayer
        '
        Me.cmdNewPlayer.BackColor = System.Drawing.SystemColors.Control
        Me.cmdNewPlayer.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdNewPlayer.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdNewPlayer.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdNewPlayer.Location = New System.Drawing.Point(8, 200)
        Me.cmdNewPlayer.Name = "cmdNewPlayer"
        Me.cmdNewPlayer.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdNewPlayer.Size = New System.Drawing.Size(53, 29)
        Me.cmdNewPlayer.TabIndex = 57
        Me.cmdNewPlayer.Tag = "OptionsDialog#22"
        Me.cmdNewPlayer.Text = "&Nowy..."
        '
        'lstPlayers
        '
        Me.lstPlayers.BackColor = System.Drawing.SystemColors.Window
        Me.lstPlayers.Cursor = System.Windows.Forms.Cursors.Default
        Me.lstPlayers.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstPlayers.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lstPlayers.ItemHeight = 14
        Me.lstPlayers.Location = New System.Drawing.Point(8, 24)
        Me.lstPlayers.Name = "lstPlayers"
        Me.lstPlayers.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lstPlayers.Size = New System.Drawing.Size(117, 172)
        Me.lstPlayers.TabIndex = 41
        '
        'Frame8
        '
        Me.Frame8.BackColor = System.Drawing.SystemColors.Control
        Me.Frame8.Controls.Add(Me.cmdPrevSet)
        Me.Frame8.Controls.Add(Me.cmdNextSet)
        Me.Frame8.Controls.Add(Me.lblPushes)
        Me.Frame8.Controls.Add(Me.lblMoves)
        Me.Frame8.Controls.Add(Me.lblArrivedLevel)
        Me.Frame8.Controls.Add(Me.Label8)
        Me.Frame8.Controls.Add(Me.Label7)
        Me.Frame8.Controls.Add(Me.Label6)
        Me.Frame8.Controls.Add(Me.lblLevelSet)
        Me.Frame8.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frame8.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame8.Location = New System.Drawing.Point(160, 34)
        Me.Frame8.Name = "Frame8"
        Me.Frame8.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame8.Size = New System.Drawing.Size(249, 137)
        Me.Frame8.TabIndex = 42
        Me.Frame8.TabStop = False
        Me.Frame8.Tag = "OptionsDialog#24"
        Me.Frame8.Text = "Statystyki"
        '
        'cmdPrevSet
        '
        Me.cmdPrevSet.BackColor = System.Drawing.SystemColors.Control
        Me.cmdPrevSet.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdPrevSet.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdPrevSet.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdPrevSet.Location = New System.Drawing.Point(4, 108)
        Me.cmdPrevSet.Name = "cmdPrevSet"
        Me.cmdPrevSet.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdPrevSet.Size = New System.Drawing.Size(25, 21)
        Me.cmdPrevSet.TabIndex = 48
        Me.cmdPrevSet.Text = "<-"
        '
        'cmdNextSet
        '
        Me.cmdNextSet.BackColor = System.Drawing.SystemColors.Control
        Me.cmdNextSet.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdNextSet.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdNextSet.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdNextSet.Location = New System.Drawing.Point(220, 108)
        Me.cmdNextSet.Name = "cmdNextSet"
        Me.cmdNextSet.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdNextSet.Size = New System.Drawing.Size(25, 21)
        Me.cmdNextSet.TabIndex = 47
        Me.cmdNextSet.Text = "->"
        '
        'lblPushes
        '
        Me.lblPushes.BackColor = System.Drawing.SystemColors.Control
        Me.lblPushes.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblPushes.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPushes.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblPushes.Location = New System.Drawing.Point(132, 84)
        Me.lblPushes.Name = "lblPushes"
        Me.lblPushes.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblPushes.Size = New System.Drawing.Size(109, 13)
        Me.lblPushes.TabIndex = 51
        Me.lblPushes.Text = "#Pchniêcia#"
        Me.lblPushes.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblMoves
        '
        Me.lblMoves.BackColor = System.Drawing.SystemColors.Control
        Me.lblMoves.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblMoves.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMoves.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblMoves.Location = New System.Drawing.Point(128, 64)
        Me.lblMoves.Name = "lblMoves"
        Me.lblMoves.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblMoves.Size = New System.Drawing.Size(113, 13)
        Me.lblMoves.TabIndex = 50
        Me.lblMoves.Text = "#Ruchy#"
        Me.lblMoves.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblArrivedLevel
        '
        Me.lblArrivedLevel.BackColor = System.Drawing.SystemColors.Control
        Me.lblArrivedLevel.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblArrivedLevel.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblArrivedLevel.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblArrivedLevel.Location = New System.Drawing.Point(128, 44)
        Me.lblArrivedLevel.Name = "lblArrivedLevel"
        Me.lblArrivedLevel.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblArrivedLevel.Size = New System.Drawing.Size(113, 13)
        Me.lblArrivedLevel.TabIndex = 49
        Me.lblArrivedLevel.Text = "#Osi¹gniêty Etap#"
        Me.lblArrivedLevel.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.SystemColors.Control
        Me.Label8.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label8.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label8.Location = New System.Drawing.Point(40, 84)
        Me.Label8.Name = "Label8"
        Me.Label8.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label8.Size = New System.Drawing.Size(73, 13)
        Me.Label8.TabIndex = 46
        Me.Label8.Tag = "OptionsDialog#28"
        Me.Label8.Text = "Pchniêcia:"
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.SystemColors.Control
        Me.Label7.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label7.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label7.Location = New System.Drawing.Point(40, 64)
        Me.Label7.Name = "Label7"
        Me.Label7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label7.Size = New System.Drawing.Size(73, 13)
        Me.Label7.TabIndex = 45
        Me.Label7.Tag = "OptionsDialog#27"
        Me.Label7.Text = "Ruchy:"
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.SystemColors.Control
        Me.Label6.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label6.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label6.Location = New System.Drawing.Point(40, 44)
        Me.Label6.Name = "Label6"
        Me.Label6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label6.Size = New System.Drawing.Size(77, 17)
        Me.Label6.TabIndex = 44
        Me.Label6.Tag = "OptionsDialog#26"
        Me.Label6.Text = "Osi¹gniêty etap:"
        '
        'lblLevelSet
        '
        Me.lblLevelSet.BackColor = System.Drawing.SystemColors.Control
        Me.lblLevelSet.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblLevelSet.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lblLevelSet.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblLevelSet.Location = New System.Drawing.Point(8, 24)
        Me.lblLevelSet.Name = "lblLevelSet"
        Me.lblLevelSet.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblLevelSet.Size = New System.Drawing.Size(221, 17)
        Me.lblLevelSet.TabIndex = 43
        Me.lblLevelSet.Text = "#Zestaw Etapów#"
        '
        'Frame9
        '
        Me.Frame9.BackColor = System.Drawing.SystemColors.Control
        Me.Frame9.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frame9.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame9.Location = New System.Drawing.Point(160, 180)
        Me.Frame9.Name = "Frame9"
        Me.Frame9.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame9.Size = New System.Drawing.Size(249, 89)
        Me.Frame9.TabIndex = 52
        Me.Frame9.TabStop = False
        Me.Frame9.Tag = "OptionsDialog#29"
        Me.Frame9.Text = "Ustawienia"
        '
        'chkFirstPlayerAutoLogon
        '
        Me.chkFirstPlayerAutoLogon.BackColor = System.Drawing.SystemColors.Control
        Me.chkFirstPlayerAutoLogon.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkFirstPlayerAutoLogon.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkFirstPlayerAutoLogon.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkFirstPlayerAutoLogon.Location = New System.Drawing.Point(12, 274)
        Me.chkFirstPlayerAutoLogon.Name = "chkFirstPlayerAutoLogon"
        Me.chkFirstPlayerAutoLogon.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkFirstPlayerAutoLogon.Size = New System.Drawing.Size(397, 17)
        Me.chkFirstPlayerAutoLogon.TabIndex = 59
        Me.chkFirstPlayerAutoLogon.Tag = "OptionsDialog#35#First Player Auto Logon"
        Me.chkFirstPlayerAutoLogon.Text = "&Automatycznie loguj pierwszego gracza, je¿eli jest on jedynym"
        '
        '_picOptions_3
        '
        Me._picOptions_3.BackColor = System.Drawing.SystemColors.Control
        Me._picOptions_3.Controls.Add(Me.fraSample4)
        Me._picOptions_3.Cursor = System.Windows.Forms.Cursors.Default
        Me._picOptions_3.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._picOptions_3.ForeColor = System.Drawing.SystemColors.ControlText
        'Me.picOptions.SetIndex(Me._picOptions_3, CType(3, Short))
        Me._picOptions_3.Location = New System.Drawing.Point(-1333, 32)
        Me._picOptions_3.Name = "_picOptions_3"
        Me._picOptions_3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._picOptions_3.Size = New System.Drawing.Size(381, 252)
        Me._picOptions_3.TabIndex = 4
        '
        'fraSample4
        '
        Me.fraSample4.BackColor = System.Drawing.SystemColors.Control
        Me.fraSample4.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fraSample4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.fraSample4.Location = New System.Drawing.Point(140, 56)
        Me.fraSample4.Name = "fraSample4"
        Me.fraSample4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.fraSample4.Size = New System.Drawing.Size(137, 119)
        Me.fraSample4.TabIndex = 7
        Me.fraSample4.TabStop = False
        Me.fraSample4.Text = "Sample 4"
        '
        '_picOptions_2
        '
        Me._picOptions_2.BackColor = System.Drawing.SystemColors.Control
        Me._picOptions_2.Controls.Add(Me.fraSample3)
        Me._picOptions_2.Cursor = System.Windows.Forms.Cursors.Default
        Me._picOptions_2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._picOptions_2.ForeColor = System.Drawing.SystemColors.ControlText
        'Me.picOptions.SetIndex(Me._picOptions_2, CType(2, Short))
        Me._picOptions_2.Location = New System.Drawing.Point(-1333, 32)
        Me._picOptions_2.Name = "_picOptions_2"
        Me._picOptions_2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._picOptions_2.Size = New System.Drawing.Size(381, 252)
        Me._picOptions_2.TabIndex = 3
        '
        'fraSample3
        '
        Me.fraSample3.BackColor = System.Drawing.SystemColors.Control
        Me.fraSample3.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fraSample3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.fraSample3.Location = New System.Drawing.Point(103, 45)
        Me.fraSample3.Name = "fraSample3"
        Me.fraSample3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.fraSample3.Size = New System.Drawing.Size(137, 119)
        Me.fraSample3.TabIndex = 6
        Me.fraSample3.TabStop = False
        Me.fraSample3.Text = "Sample 3"
        '
        '_picOptions_1
        '
        Me._picOptions_1.BackColor = System.Drawing.SystemColors.Control
        Me._picOptions_1.Controls.Add(Me.fraSample2)
        Me._picOptions_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._picOptions_1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._picOptions_1.ForeColor = System.Drawing.SystemColors.ControlText
        'Me.picOptions.SetIndex(Me._picOptions_1, CType(1, Short))
        Me._picOptions_1.Location = New System.Drawing.Point(-1333, 32)
        Me._picOptions_1.Name = "_picOptions_1"
        Me._picOptions_1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._picOptions_1.Size = New System.Drawing.Size(381, 252)
        Me._picOptions_1.TabIndex = 2
        '
        'fraSample2
        '
        Me.fraSample2.BackColor = System.Drawing.SystemColors.Control
        Me.fraSample2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fraSample2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.fraSample2.Location = New System.Drawing.Point(43, 20)
        Me.fraSample2.Name = "fraSample2"
        Me.fraSample2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.fraSample2.Size = New System.Drawing.Size(137, 119)
        Me.fraSample2.TabIndex = 5
        Me.fraSample2.TabStop = False
        Me.fraSample2.Text = "Sample 2"
        '
        'cmdCancel
        '
        Me.cmdCancel.BackColor = System.Drawing.SystemColors.Control
        Me.cmdCancel.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdCancel.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCancel.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdCancel.Location = New System.Drawing.Point(176, 312)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdCancel.Size = New System.Drawing.Size(73, 25)
        Me.cmdCancel.TabIndex = 1
        Me.cmdCancel.Tag = "Buttons#1"
        Me.cmdCancel.Text = "&Anuluj"
        '
        'cmdOK
        '
        Me.cmdOK.BackColor = System.Drawing.SystemColors.Control
        Me.cmdOK.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdOK.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdOK.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdOK.Location = New System.Drawing.Point(84, 312)
        Me.cmdOK.Name = "cmdOK"
        Me.cmdOK.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdOK.Size = New System.Drawing.Size(73, 25)
        Me.cmdOK.TabIndex = 0
        Me.cmdOK.Tag = "Buttons#0"
        Me.cmdOK.Text = "&OK"
        '
        'frmOptions
        '
        Me.AcceptButton = Me.cmdOK
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.CancelButton = Me.cmdCancel
        Me.ClientSize = New System.Drawing.Size(445, 342)
        Me.ControlBox = False
        Me.Controls.Add(Me.cmdApply)
        Me.Controls.Add(Me.tabOptions)
        Me.Controls.Add(Me._picOptions_3)
        Me.Controls.Add(Me._picOptions_2)
        Me.Controls.Add(Me._picOptions_1)
        Me.Controls.Add(Me.cmdCancel)
        Me.Controls.Add(Me.cmdOK)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.KeyPreview = True
        Me.Location = New System.Drawing.Point(102, 170)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmOptions"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Tag = "OptionsDialog#42"
        Me.Text = "Opcje"
        Me.tabOptions.ResumeLayout(False)
        Me._tabOptions_TabPage0.ResumeLayout(False)
        Me.Frame2.ResumeLayout(False)
        Me.Frame1.ResumeLayout(False)
        Me._tabOptions_TabPage1.ResumeLayout(False)
        Me.Frame3.ResumeLayout(False)
        Me.Frame4.ResumeLayout(False)
        Me.Frame5.ResumeLayout(False)
        Me._tabOptions_TabPage2.ResumeLayout(False)
        Me.Frame7.ResumeLayout(False)
        Me.Frame8.ResumeLayout(False)
        Me._picOptions_3.ResumeLayout(False)
        Me._picOptions_2.ResumeLayout(False)
        Me._picOptions_1.ResumeLayout(False)
        'CType(Me.picOptions, System.ComponentModel.ISupportInitialize).EndInit()
        'CType(Me.picPreview, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
#End Region 
#Region "Upgrade Support "
	Private Shared m_vb6FormDefInstance As frmOptions
	Private Shared m_InitializingDefInstance As Boolean
	Public Shared Property DefInstance() As frmOptions
		Get
			If m_vb6FormDefInstance Is Nothing OrElse m_vb6FormDefInstance.IsDisposed Then
				m_InitializingDefInstance = True
				m_vb6FormDefInstance = New frmOptions()
				m_InitializingDefInstance = False
			End If
			DefInstance = m_vb6FormDefInstance
		End Get
		Set
			m_vb6FormDefInstance = Value
		End Set
	End Property
#End Region 
	Dim Temp As Object
	
	Private Sub cmdApply_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdApply.Click
		ZapiszOpcje()
	End Sub
	
	Private Sub cmdBackgroundColor_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdBackgroundColor.Click
        Dim MyColor As System.Drawing.Color
		
        'MyColor = System.Drawing.ColorTranslator.ToOle(cmdBackgroundColor.BackColor)
        Dim ColorDialog1 As ColorDialog = New ColorDialog
        With ColorDialog1
            MyColor = ColorDialog1.Color
            cmdBackgroundColor.BackColor = MyColor
        End With
    End Sub
    Private Sub cmdCancel_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdCancel.Click
        Me.Close()
    End Sub
    Sub ZapiszOpcje()
        Dim ctrl As System.Windows.Forms.Control
        Dim Temp As Object
        modMain.RegKey = Microsoft.Win32.Registry.CurrentUser.OpenSubKey(RegSciezka & "\\Options", True)
        For Each ctrl In Me.Controls
            'UPGRADE_WARNING: TypeName has a new behavior. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1041"'
            If TypeName(ctrl) = "CheckBox" Then
                'UPGRADE_WARNING: Couldn't resolve default property of object Temp. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
                Temp = Split(ctrl.Tag, "#")

                'UPGRADE_WARNING: Couldn't resolve default property of object Temp(). Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
                RegKey.SetValue(Temp(2), ctrl.Visible)
            End If
        Next ctrl


        RegKey.SetValue("Background Color", Val(CStr(System.Drawing.ColorTranslator.ToOle(cmdBackgroundColor.BackColor))))
        RegKey.SetValue("Skin", lstSkins.Text)

        frmMain.DefInstance.BackColor = cmdBackgroundColor.BackColor
        OdswiezPoleGry()
    End Sub
    Sub WczytajOpcje()
        Dim ctrl As System.Windows.Forms.Control
        Dim Temp As Object

        cmbShowInTray.Items.Insert(0, ZwrocCiag("OptionsDialog#14"))
        cmbShowInTray.Items.Insert(1, ZwrocCiag("OptionsDialog#15"))
        cmbShowInTray.Items.Insert(2, ZwrocCiag("OptionsDialog#16"))

        modMain.RegKey = Microsoft.Win32.Registry.CurrentUser.OpenSubKey(RegSciezka & "\\Options", True)

        For Each ctrl In Me.Controls
            'UPGRADE_WARNING: TypeName has a new behavior. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1041"'
            If TypeName(ctrl) = "CheckBox" Then
                'UPGRADE_WARNING: Couldn't resolve default property of object Temp. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
                Temp = Split(ctrl.Tag, "#")

                modMain.RegValue = RegKey.GetValue(Temp(2), 0)
                If modMain.RegValue = 1 Then
                    'UPGRADE_WARNING: Couldn't resolve default property of object ctrl.Value. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
                    ctrl.Visible = System.Windows.Forms.CheckState.Checked
                Else
                    'UPGRADE_WARNING: Couldn't resolve default property of object ctrl.Value. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
                    ctrl.Visible = System.Windows.Forms.CheckState.Unchecked
                End If
            End If
        Next ctrl

        modMain.RegValue = RegKey.GetValue("Show in Tray", 0)
        cmbShowInTray.SelectedIndex = modMain.RegValue

        ' Wygl¹d
        '-------
        modMain.RegValue = RegKey.GetValue("Background Color", 0)
        cmdBackgroundColor.BackColor = System.Drawing.ColorTranslator.FromOle(Val(modMain.RegValue))

        lstSkins.Items.Add("(Oryginalny)")
        FileOpen(1, ".\Ini\Skiny.ini", OpenMode.Input)
        Do Until EOF(1)
            Temp = LineInput(1)
            'UPGRADE_WARNING: Couldn't resolve default property of object Temp. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
            lstSkins.Items.Add(Temp)
        Loop
        FileClose(1)
        modMain.RegString = RegKey.GetValue("Skin", "(Oryginalny)")
        lstSkins.Text = modMain.RegString

    End Sub

    Private Sub cmdNextSet_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdNextSet.Click
        cmdNextSet.Enabled = False
        cmdPrevSet.Enabled = True
        WyswietlStatystyki(2)
    End Sub

    Private Sub cmdOK_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdOK.Click
        ZapiszOpcje()
        Me.Close()
    End Sub

    Private Sub cmdPrevSet_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdPrevSet.Click
        cmdPrevSet.Enabled = False
        cmdNextSet.Enabled = True
        WyswietlStatystyki(1)
    End Sub

    Private Sub frmOptions_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
        tabOptions.SelectedIndex = 0

        WczytajOpcje()
        WyswietlPodgladSkinu()

        SprawdzLiczbeGraczy()
        WczytajListeGraczy()

        cmdPrevSet.Enabled = False
        cmdNextSet.Enabled = True
        WyswietlStatystyki(1)

        'center the form
        'Me.SetBounds(VB6.TwipsToPixelsX((VB6.PixelsToTwipsX(System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width) - VB6.PixelsToTwipsX(Me.Width)) / 2), VB6.TwipsToPixelsY((VB6.PixelsToTwipsY(System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height) - VB6.PixelsToTwipsY(Me.Height)) / 2), 0, 0, Windows.Forms.BoundsSpecified.X Or Windows.Forms.BoundsSpecified.Y)
    End Sub
    Sub WyswietlPodgladSkinu()
        Dim i As Short

        For i = 0 To 6
            'picPreview(i).Image = System.Drawing.Image.FromFile(".\Skiny\" & lstSkins.Text & "\" & i & ".ico")
        Next i
    End Sub

    'UPGRADE_WARNING: Event lstPlayers.SelectedIndexChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup2075"'
    Private Sub lstPlayers_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles lstPlayers.SelectedIndexChanged
        cmdPrevSet.Enabled = False
        cmdNextSet.Enabled = True
        WyswietlStatystyki(1)
    End Sub

    'UPGRADE_WARNING: Event lstSkins.SelectedIndexChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup2075"'
    Private Sub lstSkins_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles lstSkins.SelectedIndexChanged
        WyswietlPodgladSkinu()
    End Sub
    Public Sub WczytajListeGraczy()
        If LiczbaGraczy = 0 Then Exit Sub

        lstPlayers.Items.Clear()
        lstPlayers.Items.Insert(0, "")
        For Licznik = 1 To LiczbaGraczy
            modMain.RegKey = Microsoft.Win32.Registry.CurrentUser.OpenSubKey(RegSciezka & "\\Players\\" & Str(Licznik), True)
            modMain.RegString = RegKey.GetValue("Name", "imie")
            lstPlayers.Items.Add(CStr(modMain.RegString))
        Next Licznik
        lstPlayers.Items.RemoveAt(0)
        lstPlayers.SetSelected(0, True)
    End Sub
    Public Sub WyswietlStatystyki(ByVal NrZestawu As Byte)
        Select Case NrZestawu
            Case 1
                lblLevelSet.Text = ZwrocCiag("OptionsDialog#25") & " " & UCase(ZwrocCiag("Sets#0"))
                modMain.RegKey = Microsoft.Win32.Registry.CurrentUser.OpenSubKey(RegSciezka & "\\Players\\1\\Klasyczne", True)

                lblArrivedLevel.Text = RegKey.GetValue("Arrived Level", 0)
                lblMoves.Text = RegKey.GetValue("Moves", 0)
                lblPushes.Text = RegKey.GetValue("Pushes", 0)

            Case 2
                lblLevelSet.Text = ZwrocCiag("OptionsDialog#25") & " " & UCase(ZwrocCiag("Sets#1"))
                modMain.RegKey = Microsoft.Win32.Registry.CurrentUser.OpenSubKey(RegSciezka & "\\Players\\1\\Super Trudne XS", True)

                lblArrivedLevel.Text = RegKey.GetValue("Arrived Level", 0)
                lblMoves.Text = RegKey.GetValue("Moves", 0)
                lblPushes.Text = RegKey.GetValue("Pushes", 0)

        End Select
    End Sub
End Class