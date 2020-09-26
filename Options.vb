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
	Public WithEvents Label3 As System.Windows.Forms.Label
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
	Public WithEvents cmdChangePassword As System.Windows.Forms.Button
	Public WithEvents txtPassword As System.Windows.Forms.TextBox
	Public WithEvents cmdChangePlayerID As System.Windows.Forms.Button
	Public WithEvents Label9 As System.Windows.Forms.Label
	Public WithEvents Frame9 As System.Windows.Forms.GroupBox
	Public WithEvents chkFirstPlayerAutoLogon As System.Windows.Forms.CheckBox
	Public WithEvents _tabOptions_TabPage2 As System.Windows.Forms.TabPage
	Public WithEvents cmdUseOnlyOwnMIDI As System.Windows.Forms.Button
	Public WithEvents cmdFindMIDIAgain As System.Windows.Forms.Button
	Public WithEvents Label5 As System.Windows.Forms.Label
	Public WithEvents Label4 As System.Windows.Forms.Label
	Public WithEvents Frame6 As System.Windows.Forms.GroupBox
	Public WithEvents chkPlayMusic As System.Windows.Forms.CheckBox
	Public WithEvents _tabOptions_TabPage3 As System.Windows.Forms.TabPage
	Public WithEvents lstLanguages As System.Windows.Forms.ListBox
	Public WithEvents Frame10 As System.Windows.Forms.GroupBox
	Public WithEvents _tabOptions_TabPage4 As System.Windows.Forms.TabPage
	Public WithEvents tabOptions As System.Windows.Forms.TabControl
	Public WithEvents fraSample4 As System.Windows.Forms.GroupBox
	Public WithEvents _picOptions_3 As System.Windows.Forms.Panel
	Public WithEvents fraSample3 As System.Windows.Forms.GroupBox
	Public WithEvents _picOptions_2 As System.Windows.Forms.Panel
	Public WithEvents fraSample2 As System.Windows.Forms.GroupBox
	Public WithEvents _picOptions_1 As System.Windows.Forms.Panel
	Public WithEvents cmdCancel As System.Windows.Forms.Button
	Public WithEvents cmdOK As System.Windows.Forms.Button
	Public WithEvents picOptions As Microsoft.VisualBasic.Compatibility.VB6.PanelArray
	Public WithEvents picPreview As Microsoft.VisualBasic.Compatibility.VB6.PictureBoxArray
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmOptions))
		Me.components = New System.ComponentModel.Container()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(components)
		Me.ToolTip1.Active = True
		Me.cmdApply = New System.Windows.Forms.Button
		Me.tabOptions = New System.Windows.Forms.TabControl
		Me._tabOptions_TabPage0 = New System.Windows.Forms.TabPage
		Me.Label3 = New System.Windows.Forms.Label
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
		Me.cmdChangePassword = New System.Windows.Forms.Button
		Me.txtPassword = New System.Windows.Forms.TextBox
		Me.cmdChangePlayerID = New System.Windows.Forms.Button
		Me.Label9 = New System.Windows.Forms.Label
		Me.chkFirstPlayerAutoLogon = New System.Windows.Forms.CheckBox
		Me._tabOptions_TabPage3 = New System.Windows.Forms.TabPage
		Me.Frame6 = New System.Windows.Forms.GroupBox
		Me.cmdUseOnlyOwnMIDI = New System.Windows.Forms.Button
		Me.cmdFindMIDIAgain = New System.Windows.Forms.Button
		Me.Label5 = New System.Windows.Forms.Label
		Me.Label4 = New System.Windows.Forms.Label
		Me.chkPlayMusic = New System.Windows.Forms.CheckBox
		Me._tabOptions_TabPage4 = New System.Windows.Forms.TabPage
		Me.Frame10 = New System.Windows.Forms.GroupBox
		Me.lstLanguages = New System.Windows.Forms.ListBox
		Me._picOptions_3 = New System.Windows.Forms.Panel
		Me.fraSample4 = New System.Windows.Forms.GroupBox
		Me._picOptions_2 = New System.Windows.Forms.Panel
		Me.fraSample3 = New System.Windows.Forms.GroupBox
		Me._picOptions_1 = New System.Windows.Forms.Panel
		Me.fraSample2 = New System.Windows.Forms.GroupBox
		Me.cmdCancel = New System.Windows.Forms.Button
		Me.cmdOK = New System.Windows.Forms.Button
		Me.picOptions = New Microsoft.VisualBasic.Compatibility.VB6.PanelArray(components)
		Me.picPreview = New Microsoft.VisualBasic.Compatibility.VB6.PictureBoxArray(components)
		CType(Me.picOptions, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.picPreview, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
		Me.Text = "Opcje"
		Me.ClientSize = New System.Drawing.Size(445, 342)
		Me.Location = New System.Drawing.Point(102, 170)
		Me.ControlBox = False
		Me.KeyPreview = True
		Me.MaximizeBox = False
		Me.MinimizeBox = False
		Me.ShowInTaskbar = False
		Me.Tag = "OptionsDialog#42"
		Me.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
		Me.BackColor = System.Drawing.SystemColors.Control
		Me.Enabled = True
		Me.Cursor = System.Windows.Forms.Cursors.Default
		Me.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.HelpButton = False
		Me.WindowState = System.Windows.Forms.FormWindowState.Normal
		Me.Name = "frmOptions"
		Me.cmdApply.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cmdApply.Text = "&Zastosuj"
		Me.cmdApply.Size = New System.Drawing.Size(73, 25)
		Me.cmdApply.Location = New System.Drawing.Point(267, 312)
		Me.cmdApply.TabIndex = 28
		Me.cmdApply.Tag = "Buttons#2"
		Me.cmdApply.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdApply.BackColor = System.Drawing.SystemColors.Control
		Me.cmdApply.CausesValidation = True
		Me.cmdApply.Enabled = True
		Me.cmdApply.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdApply.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdApply.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdApply.TabStop = True
		Me.cmdApply.Name = "cmdApply"
		Me.tabOptions.Size = New System.Drawing.Size(427, 301)
		Me.tabOptions.Location = New System.Drawing.Point(8, 4)
		Me.tabOptions.TabIndex = 8
		Me.tabOptions.Appearance = System.Windows.Forms.TabAppearance.FlatButtons
		Me.tabOptions.ItemSize = New System.Drawing.Size(42, 18)
		Me.tabOptions.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.tabOptions.Name = "tabOptions"
		Me._tabOptions_TabPage0.Text = "&Ogólne"
		Me.Label3.Text = "Pokazuj ikonê na pasku systemowym:"
		Me.Label3.Size = New System.Drawing.Size(181, 17)
		Me.Label3.Location = New System.Drawing.Point(14, 263)
		Me.Label3.TabIndex = 32
		Me.Label3.Tag = "OptionsDialog#13"
		Me.Label3.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label3.BackColor = System.Drawing.SystemColors.Control
		Me.Label3.Enabled = True
		Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label3.UseMnemonic = True
		Me.Label3.Visible = True
		Me.Label3.AutoSize = False
		Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label3.Name = "Label3"
		Me.Frame2.Text = "Porady dnia i ekran tytu³owy"
		Me.Frame2.Size = New System.Drawing.Size(340, 75)
		Me.Frame2.Location = New System.Drawing.Point(14, 39)
		Me.Frame2.TabIndex = 9
		Me.Frame2.Tag = "OptionsDialog#5"
		Me.Frame2.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Frame2.BackColor = System.Drawing.SystemColors.Control
		Me.Frame2.Enabled = True
		Me.Frame2.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Frame2.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Frame2.Visible = True
		Me.Frame2.Name = "Frame2"
		Me.chkShowTipsAtStartup.Text = "Pokazuj &porady dnia"
		Me.chkShowTipsAtStartup.Size = New System.Drawing.Size(320, 16)
		Me.chkShowTipsAtStartup.Location = New System.Drawing.Point(9, 23)
		Me.chkShowTipsAtStartup.TabIndex = 11
		Me.chkShowTipsAtStartup.Tag = "OptionsDialog#6#Show Tips at Startup"
		Me.chkShowTipsAtStartup.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.chkShowTipsAtStartup.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.chkShowTipsAtStartup.BackColor = System.Drawing.SystemColors.Control
		Me.chkShowTipsAtStartup.CausesValidation = True
		Me.chkShowTipsAtStartup.Enabled = True
		Me.chkShowTipsAtStartup.ForeColor = System.Drawing.SystemColors.ControlText
		Me.chkShowTipsAtStartup.Cursor = System.Windows.Forms.Cursors.Default
		Me.chkShowTipsAtStartup.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.chkShowTipsAtStartup.Appearance = System.Windows.Forms.Appearance.Normal
		Me.chkShowTipsAtStartup.TabStop = True
		Me.chkShowTipsAtStartup.CheckState = System.Windows.Forms.CheckState.Unchecked
		Me.chkShowTipsAtStartup.Visible = True
		Me.chkShowTipsAtStartup.Name = "chkShowTipsAtStartup"
		Me.chkShowSplashAtStartup.Text = "Pokazuj ekran &tytu³owy"
		Me.chkShowSplashAtStartup.Size = New System.Drawing.Size(319, 15)
		Me.chkShowSplashAtStartup.Location = New System.Drawing.Point(9, 49)
		Me.chkShowSplashAtStartup.TabIndex = 10
		Me.chkShowSplashAtStartup.Tag = "OptionsDialog#7#Show Splash at Startup"
		Me.chkShowSplashAtStartup.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.chkShowSplashAtStartup.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.chkShowSplashAtStartup.BackColor = System.Drawing.SystemColors.Control
		Me.chkShowSplashAtStartup.CausesValidation = True
		Me.chkShowSplashAtStartup.Enabled = True
		Me.chkShowSplashAtStartup.ForeColor = System.Drawing.SystemColors.ControlText
		Me.chkShowSplashAtStartup.Cursor = System.Windows.Forms.Cursors.Default
		Me.chkShowSplashAtStartup.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.chkShowSplashAtStartup.Appearance = System.Windows.Forms.Appearance.Normal
		Me.chkShowSplashAtStartup.TabStop = True
		Me.chkShowSplashAtStartup.CheckState = System.Windows.Forms.CheckState.Unchecked
		Me.chkShowSplashAtStartup.Visible = True
		Me.chkShowSplashAtStartup.Name = "chkShowSplashAtStartup"
		Me.Frame1.Text = "Potwierdzenia"
		Me.Frame1.Size = New System.Drawing.Size(340, 96)
		Me.Frame1.Location = New System.Drawing.Point(15, 123)
		Me.Frame1.TabIndex = 12
		Me.Frame1.Tag = "OptionsDialog#8"
		Me.Frame1.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Frame1.BackColor = System.Drawing.SystemColors.Control
		Me.Frame1.Enabled = True
		Me.Frame1.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Frame1.Visible = True
		Me.Frame1.Name = "Frame1"
		Me.chkWantClosingAuthorization.Text = "Pytaj o potwierdzenie z&akoñczenia dzia³ania programu"
		Me.chkWantClosingAuthorization.Size = New System.Drawing.Size(283, 18)
		Me.chkWantClosingAuthorization.Location = New System.Drawing.Point(8, 18)
		Me.chkWantClosingAuthorization.TabIndex = 15
		Me.chkWantClosingAuthorization.Tag = "OptionsDialog#9#Want Closing Authorization"
		Me.chkWantClosingAuthorization.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.chkWantClosingAuthorization.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.chkWantClosingAuthorization.BackColor = System.Drawing.SystemColors.Control
		Me.chkWantClosingAuthorization.CausesValidation = True
		Me.chkWantClosingAuthorization.Enabled = True
		Me.chkWantClosingAuthorization.ForeColor = System.Drawing.SystemColors.ControlText
		Me.chkWantClosingAuthorization.Cursor = System.Windows.Forms.Cursors.Default
		Me.chkWantClosingAuthorization.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.chkWantClosingAuthorization.Appearance = System.Windows.Forms.Appearance.Normal
		Me.chkWantClosingAuthorization.TabStop = True
		Me.chkWantClosingAuthorization.CheckState = System.Windows.Forms.CheckState.Unchecked
		Me.chkWantClosingAuthorization.Visible = True
		Me.chkWantClosingAuthorization.Name = "chkWantClosingAuthorization"
		Me.chkWantLevelRestartingAuthorization.Text = "Pytaj o potwierdzenie &restartowania aktualnego etapu"
		Me.chkWantLevelRestartingAuthorization.Size = New System.Drawing.Size(277, 18)
		Me.chkWantLevelRestartingAuthorization.Location = New System.Drawing.Point(8, 43)
		Me.chkWantLevelRestartingAuthorization.TabIndex = 14
		Me.chkWantLevelRestartingAuthorization.Tag = "OptionsDialog#10#Want Level Restarting Authorization"
		Me.chkWantLevelRestartingAuthorization.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.chkWantLevelRestartingAuthorization.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.chkWantLevelRestartingAuthorization.BackColor = System.Drawing.SystemColors.Control
		Me.chkWantLevelRestartingAuthorization.CausesValidation = True
		Me.chkWantLevelRestartingAuthorization.Enabled = True
		Me.chkWantLevelRestartingAuthorization.ForeColor = System.Drawing.SystemColors.ControlText
		Me.chkWantLevelRestartingAuthorization.Cursor = System.Windows.Forms.Cursors.Default
		Me.chkWantLevelRestartingAuthorization.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.chkWantLevelRestartingAuthorization.Appearance = System.Windows.Forms.Appearance.Normal
		Me.chkWantLevelRestartingAuthorization.TabStop = True
		Me.chkWantLevelRestartingAuthorization.CheckState = System.Windows.Forms.CheckState.Unchecked
		Me.chkWantLevelRestartingAuthorization.Visible = True
		Me.chkWantLevelRestartingAuthorization.Name = "chkWantLevelRestartingAuthorization"
		Me.chkShowLevelLoadConfirmation.Text = "Wyœwietlaj potwierdzenie &wczytania etapu"
		Me.chkShowLevelLoadConfirmation.Size = New System.Drawing.Size(314, 18)
		Me.chkShowLevelLoadConfirmation.Location = New System.Drawing.Point(8, 68)
		Me.chkShowLevelLoadConfirmation.TabIndex = 13
		Me.chkShowLevelLoadConfirmation.Tag = "OptionsDialog#11#Show Level Load Confirmation"
		Me.chkShowLevelLoadConfirmation.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.chkShowLevelLoadConfirmation.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.chkShowLevelLoadConfirmation.BackColor = System.Drawing.SystemColors.Control
		Me.chkShowLevelLoadConfirmation.CausesValidation = True
		Me.chkShowLevelLoadConfirmation.Enabled = True
		Me.chkShowLevelLoadConfirmation.ForeColor = System.Drawing.SystemColors.ControlText
		Me.chkShowLevelLoadConfirmation.Cursor = System.Windows.Forms.Cursors.Default
		Me.chkShowLevelLoadConfirmation.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.chkShowLevelLoadConfirmation.Appearance = System.Windows.Forms.Appearance.Normal
		Me.chkShowLevelLoadConfirmation.TabStop = True
		Me.chkShowLevelLoadConfirmation.CheckState = System.Windows.Forms.CheckState.Unchecked
		Me.chkShowLevelLoadConfirmation.Visible = True
		Me.chkShowLevelLoadConfirmation.Name = "chkShowLevelLoadConfirmation"
		Me.chkBeginFromArrivedLevel.Text = "Przy uruchomieniu programu wyœwietlaj najdalszy dostêpny &etap"
		Me.chkBeginFromArrivedLevel.Size = New System.Drawing.Size(326, 19)
		Me.chkBeginFromArrivedLevel.Location = New System.Drawing.Point(14, 227)
		Me.chkBeginFromArrivedLevel.TabIndex = 16
		Me.chkBeginFromArrivedLevel.Tag = "OptionsDialog#12#Begin From Arrived Level"
		Me.chkBeginFromArrivedLevel.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.chkBeginFromArrivedLevel.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.chkBeginFromArrivedLevel.BackColor = System.Drawing.SystemColors.Control
		Me.chkBeginFromArrivedLevel.CausesValidation = True
		Me.chkBeginFromArrivedLevel.Enabled = True
		Me.chkBeginFromArrivedLevel.ForeColor = System.Drawing.SystemColors.ControlText
		Me.chkBeginFromArrivedLevel.Cursor = System.Windows.Forms.Cursors.Default
		Me.chkBeginFromArrivedLevel.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.chkBeginFromArrivedLevel.Appearance = System.Windows.Forms.Appearance.Normal
		Me.chkBeginFromArrivedLevel.TabStop = True
		Me.chkBeginFromArrivedLevel.CheckState = System.Windows.Forms.CheckState.Unchecked
		Me.chkBeginFromArrivedLevel.Visible = True
		Me.chkBeginFromArrivedLevel.Name = "chkBeginFromArrivedLevel"
		Me.cmbShowInTray.Size = New System.Drawing.Size(157, 21)
		Me.cmbShowInTray.Location = New System.Drawing.Point(198, 259)
		Me.cmbShowInTray.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cmbShowInTray.TabIndex = 33
		Me.cmbShowInTray.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmbShowInTray.BackColor = System.Drawing.SystemColors.Window
		Me.cmbShowInTray.CausesValidation = True
		Me.cmbShowInTray.Enabled = True
		Me.cmbShowInTray.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cmbShowInTray.IntegralHeight = True
		Me.cmbShowInTray.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmbShowInTray.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmbShowInTray.Sorted = False
		Me.cmbShowInTray.TabStop = True
		Me.cmbShowInTray.Visible = True
		Me.cmbShowInTray.Name = "cmbShowInTray"
		Me._tabOptions_TabPage1.Text = "&Wygl¹d"
		Me.Frame3.Text = "Skiny"
		Me.Frame3.Size = New System.Drawing.Size(405, 177)
		Me.Frame3.Location = New System.Drawing.Point(12, 103)
		Me.Frame3.TabIndex = 17
		Me.Frame3.Tag = "OptionsDialog#19"
		Me.Frame3.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Frame3.BackColor = System.Drawing.SystemColors.Control
		Me.Frame3.Enabled = True
		Me.Frame3.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Frame3.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Frame3.Visible = True
		Me.Frame3.Name = "Frame3"
		Me.Frame4.Text = "Podgl¹d"
		Me.Frame4.Size = New System.Drawing.Size(265, 89)
		Me.Frame4.Location = New System.Drawing.Point(132, 44)
		Me.Frame4.TabIndex = 19
		Me.Frame4.Tag = "OptionsDialog#20"
		Me.Frame4.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Frame4.BackColor = System.Drawing.SystemColors.Control
		Me.Frame4.Enabled = True
		Me.Frame4.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Frame4.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Frame4.Visible = True
		Me.Frame4.Name = "Frame4"
		Me._picPreview_6.Size = New System.Drawing.Size(34, 33)
		Me._picPreview_6.Location = New System.Drawing.Point(224, 20)
		Me._picPreview_6.TabIndex = 26
		Me._picPreview_6.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._picPreview_6.Dock = System.Windows.Forms.DockStyle.None
		Me._picPreview_6.BackColor = System.Drawing.SystemColors.Control
		Me._picPreview_6.CausesValidation = True
		Me._picPreview_6.Enabled = True
		Me._picPreview_6.ForeColor = System.Drawing.SystemColors.ControlText
		Me._picPreview_6.Cursor = System.Windows.Forms.Cursors.Default
		Me._picPreview_6.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._picPreview_6.TabStop = True
		Me._picPreview_6.Visible = True
		Me._picPreview_6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal
		Me._picPreview_6.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._picPreview_6.Name = "_picPreview_6"
		Me._picPreview_5.Size = New System.Drawing.Size(34, 33)
		Me._picPreview_5.Location = New System.Drawing.Point(188, 20)
		Me._picPreview_5.TabIndex = 25
		Me._picPreview_5.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._picPreview_5.Dock = System.Windows.Forms.DockStyle.None
		Me._picPreview_5.BackColor = System.Drawing.SystemColors.Control
		Me._picPreview_5.CausesValidation = True
		Me._picPreview_5.Enabled = True
		Me._picPreview_5.ForeColor = System.Drawing.SystemColors.ControlText
		Me._picPreview_5.Cursor = System.Windows.Forms.Cursors.Default
		Me._picPreview_5.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._picPreview_5.TabStop = True
		Me._picPreview_5.Visible = True
		Me._picPreview_5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal
		Me._picPreview_5.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._picPreview_5.Name = "_picPreview_5"
		Me._picPreview_4.Size = New System.Drawing.Size(34, 33)
		Me._picPreview_4.Location = New System.Drawing.Point(152, 20)
		Me._picPreview_4.TabIndex = 24
		Me._picPreview_4.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._picPreview_4.Dock = System.Windows.Forms.DockStyle.None
		Me._picPreview_4.BackColor = System.Drawing.SystemColors.Control
		Me._picPreview_4.CausesValidation = True
		Me._picPreview_4.Enabled = True
		Me._picPreview_4.ForeColor = System.Drawing.SystemColors.ControlText
		Me._picPreview_4.Cursor = System.Windows.Forms.Cursors.Default
		Me._picPreview_4.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._picPreview_4.TabStop = True
		Me._picPreview_4.Visible = True
		Me._picPreview_4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal
		Me._picPreview_4.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._picPreview_4.Name = "_picPreview_4"
		Me._picPreview_3.Size = New System.Drawing.Size(34, 33)
		Me._picPreview_3.Location = New System.Drawing.Point(116, 20)
		Me._picPreview_3.TabIndex = 23
		Me._picPreview_3.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._picPreview_3.Dock = System.Windows.Forms.DockStyle.None
		Me._picPreview_3.BackColor = System.Drawing.SystemColors.Control
		Me._picPreview_3.CausesValidation = True
		Me._picPreview_3.Enabled = True
		Me._picPreview_3.ForeColor = System.Drawing.SystemColors.ControlText
		Me._picPreview_3.Cursor = System.Windows.Forms.Cursors.Default
		Me._picPreview_3.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._picPreview_3.TabStop = True
		Me._picPreview_3.Visible = True
		Me._picPreview_3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal
		Me._picPreview_3.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._picPreview_3.Name = "_picPreview_3"
		Me._picPreview_2.Size = New System.Drawing.Size(34, 33)
		Me._picPreview_2.Location = New System.Drawing.Point(80, 20)
		Me._picPreview_2.TabIndex = 22
		Me._picPreview_2.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._picPreview_2.Dock = System.Windows.Forms.DockStyle.None
		Me._picPreview_2.BackColor = System.Drawing.SystemColors.Control
		Me._picPreview_2.CausesValidation = True
		Me._picPreview_2.Enabled = True
		Me._picPreview_2.ForeColor = System.Drawing.SystemColors.ControlText
		Me._picPreview_2.Cursor = System.Windows.Forms.Cursors.Default
		Me._picPreview_2.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._picPreview_2.TabStop = True
		Me._picPreview_2.Visible = True
		Me._picPreview_2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal
		Me._picPreview_2.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._picPreview_2.Name = "_picPreview_2"
		Me._picPreview_0.Size = New System.Drawing.Size(34, 33)
		Me._picPreview_0.Location = New System.Drawing.Point(8, 20)
		Me._picPreview_0.TabIndex = 21
		Me._picPreview_0.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._picPreview_0.Dock = System.Windows.Forms.DockStyle.None
		Me._picPreview_0.BackColor = System.Drawing.SystemColors.Control
		Me._picPreview_0.CausesValidation = True
		Me._picPreview_0.Enabled = True
		Me._picPreview_0.ForeColor = System.Drawing.SystemColors.ControlText
		Me._picPreview_0.Cursor = System.Windows.Forms.Cursors.Default
		Me._picPreview_0.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._picPreview_0.TabStop = True
		Me._picPreview_0.Visible = True
		Me._picPreview_0.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal
		Me._picPreview_0.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._picPreview_0.Name = "_picPreview_0"
		Me._picPreview_1.Size = New System.Drawing.Size(34, 33)
		Me._picPreview_1.Location = New System.Drawing.Point(44, 20)
		Me._picPreview_1.TabIndex = 20
		Me._picPreview_1.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._picPreview_1.Dock = System.Windows.Forms.DockStyle.None
		Me._picPreview_1.BackColor = System.Drawing.SystemColors.Control
		Me._picPreview_1.CausesValidation = True
		Me._picPreview_1.Enabled = True
		Me._picPreview_1.ForeColor = System.Drawing.SystemColors.ControlText
		Me._picPreview_1.Cursor = System.Windows.Forms.Cursors.Default
		Me._picPreview_1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._picPreview_1.TabStop = True
		Me._picPreview_1.Visible = True
		Me._picPreview_1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal
		Me._picPreview_1.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._picPreview_1.Name = "_picPreview_1"
		Me.Label2.Text = "0          1          2          3           4         5           6"
		Me.Label2.Size = New System.Drawing.Size(225, 17)
		Me.Label2.Location = New System.Drawing.Point(20, 60)
		Me.Label2.TabIndex = 27
		Me.Label2.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label2.BackColor = System.Drawing.SystemColors.Control
		Me.Label2.Enabled = True
		Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label2.UseMnemonic = True
		Me.Label2.Visible = True
		Me.Label2.AutoSize = False
		Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label2.Name = "Label2"
		Me.lstSkins.Size = New System.Drawing.Size(113, 137)
		Me.lstSkins.Location = New System.Drawing.Point(12, 24)
		Me.lstSkins.Sorted = True
		Me.lstSkins.TabIndex = 18
		Me.lstSkins.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lstSkins.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lstSkins.BackColor = System.Drawing.SystemColors.Window
		Me.lstSkins.CausesValidation = True
		Me.lstSkins.Enabled = True
		Me.lstSkins.ForeColor = System.Drawing.SystemColors.WindowText
		Me.lstSkins.IntegralHeight = True
		Me.lstSkins.Cursor = System.Windows.Forms.Cursors.Default
		Me.lstSkins.SelectionMode = System.Windows.Forms.SelectionMode.One
		Me.lstSkins.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lstSkins.TabStop = True
		Me.lstSkins.Visible = True
		Me.lstSkins.MultiColumn = False
		Me.lstSkins.Name = "lstSkins"
		Me.Frame5.Text = "T³o"
		Me.Frame5.Size = New System.Drawing.Size(401, 49)
		Me.Frame5.Location = New System.Drawing.Point(12, 35)
		Me.Frame5.TabIndex = 29
		Me.Frame5.Tag = "OptionsDialog#17"
		Me.Frame5.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Frame5.BackColor = System.Drawing.SystemColors.Control
		Me.Frame5.Enabled = True
		Me.Frame5.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Frame5.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Frame5.Visible = True
		Me.Frame5.Name = "Frame5"
		Me.cmdBackgroundColor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cmdBackgroundColor.Size = New System.Drawing.Size(82, 17)
		Me.cmdBackgroundColor.Location = New System.Drawing.Point(184, 20)
		Me.cmdBackgroundColor.TabIndex = 30
		Me.cmdBackgroundColor.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdBackgroundColor.BackColor = System.Drawing.SystemColors.Control
		Me.cmdBackgroundColor.CausesValidation = True
		Me.cmdBackgroundColor.Enabled = True
		Me.cmdBackgroundColor.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdBackgroundColor.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdBackgroundColor.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdBackgroundColor.TabStop = True
		Me.cmdBackgroundColor.Name = "cmdBackgroundColor"
		Me.Label1.Text = "Kolor t³a:"
		Me.Label1.Size = New System.Drawing.Size(69, 17)
		Me.Label1.Location = New System.Drawing.Point(104, 20)
		Me.Label1.TabIndex = 31
		Me.Label1.Tag = "OptionsDialog#18"
		Me.Label1.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label1.BackColor = System.Drawing.SystemColors.Control
		Me.Label1.Enabled = True
		Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label1.UseMnemonic = True
		Me.Label1.Visible = True
		Me.Label1.AutoSize = False
		Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label1.Name = "Label1"
		Me._tabOptions_TabPage2.Text = "&Gracze"
		Me.Frame7.Text = "Lista graczy"
		Me.Frame7.Size = New System.Drawing.Size(137, 233)
		Me.Frame7.Location = New System.Drawing.Point(12, 34)
		Me.Frame7.TabIndex = 40
		Me.Frame7.Tag = "OptionsDialog#21"
		Me.Frame7.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Frame7.BackColor = System.Drawing.SystemColors.Control
		Me.Frame7.Enabled = True
		Me.Frame7.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Frame7.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Frame7.Visible = True
		Me.Frame7.Name = "Frame7"
		Me.cmdDeletePlayer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cmdDeletePlayer.Text = "&Usuñ"
		Me.cmdDeletePlayer.Size = New System.Drawing.Size(53, 29)
		Me.cmdDeletePlayer.Location = New System.Drawing.Point(72, 200)
		Me.cmdDeletePlayer.TabIndex = 58
		Me.cmdDeletePlayer.Tag = "OptionsDialog#23"
		Me.cmdDeletePlayer.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdDeletePlayer.BackColor = System.Drawing.SystemColors.Control
		Me.cmdDeletePlayer.CausesValidation = True
		Me.cmdDeletePlayer.Enabled = True
		Me.cmdDeletePlayer.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdDeletePlayer.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdDeletePlayer.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdDeletePlayer.TabStop = True
		Me.cmdDeletePlayer.Name = "cmdDeletePlayer"
		Me.cmdNewPlayer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cmdNewPlayer.Text = "&Nowy..."
		Me.cmdNewPlayer.Size = New System.Drawing.Size(53, 29)
		Me.cmdNewPlayer.Location = New System.Drawing.Point(8, 200)
		Me.cmdNewPlayer.TabIndex = 57
		Me.cmdNewPlayer.Tag = "OptionsDialog#22"
		Me.cmdNewPlayer.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdNewPlayer.BackColor = System.Drawing.SystemColors.Control
		Me.cmdNewPlayer.CausesValidation = True
		Me.cmdNewPlayer.Enabled = True
		Me.cmdNewPlayer.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdNewPlayer.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdNewPlayer.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdNewPlayer.TabStop = True
		Me.cmdNewPlayer.Name = "cmdNewPlayer"
		Me.lstPlayers.Size = New System.Drawing.Size(117, 176)
		Me.lstPlayers.Location = New System.Drawing.Point(8, 24)
		Me.lstPlayers.TabIndex = 41
		Me.lstPlayers.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lstPlayers.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lstPlayers.BackColor = System.Drawing.SystemColors.Window
		Me.lstPlayers.CausesValidation = True
		Me.lstPlayers.Enabled = True
		Me.lstPlayers.ForeColor = System.Drawing.SystemColors.WindowText
		Me.lstPlayers.IntegralHeight = True
		Me.lstPlayers.Cursor = System.Windows.Forms.Cursors.Default
		Me.lstPlayers.SelectionMode = System.Windows.Forms.SelectionMode.One
		Me.lstPlayers.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lstPlayers.Sorted = False
		Me.lstPlayers.TabStop = True
		Me.lstPlayers.Visible = True
		Me.lstPlayers.MultiColumn = False
		Me.lstPlayers.Name = "lstPlayers"
		Me.Frame8.Text = "Statystyki"
		Me.Frame8.Size = New System.Drawing.Size(249, 137)
		Me.Frame8.Location = New System.Drawing.Point(160, 34)
		Me.Frame8.TabIndex = 42
		Me.Frame8.Tag = "OptionsDialog#24"
		Me.Frame8.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Frame8.BackColor = System.Drawing.SystemColors.Control
		Me.Frame8.Enabled = True
		Me.Frame8.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Frame8.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Frame8.Visible = True
		Me.Frame8.Name = "Frame8"
		Me.cmdPrevSet.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cmdPrevSet.Text = "<-"
		Me.cmdPrevSet.Size = New System.Drawing.Size(25, 21)
		Me.cmdPrevSet.Location = New System.Drawing.Point(4, 108)
		Me.cmdPrevSet.TabIndex = 48
		Me.cmdPrevSet.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdPrevSet.BackColor = System.Drawing.SystemColors.Control
		Me.cmdPrevSet.CausesValidation = True
		Me.cmdPrevSet.Enabled = True
		Me.cmdPrevSet.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdPrevSet.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdPrevSet.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdPrevSet.TabStop = True
		Me.cmdPrevSet.Name = "cmdPrevSet"
		Me.cmdNextSet.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cmdNextSet.Text = "->"
		Me.cmdNextSet.Size = New System.Drawing.Size(25, 21)
		Me.cmdNextSet.Location = New System.Drawing.Point(220, 108)
		Me.cmdNextSet.TabIndex = 47
		Me.cmdNextSet.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdNextSet.BackColor = System.Drawing.SystemColors.Control
		Me.cmdNextSet.CausesValidation = True
		Me.cmdNextSet.Enabled = True
		Me.cmdNextSet.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdNextSet.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdNextSet.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdNextSet.TabStop = True
		Me.cmdNextSet.Name = "cmdNextSet"
		Me.lblPushes.TextAlign = System.Drawing.ContentAlignment.TopRight
		Me.lblPushes.Text = "#Pchniêcia#"
		Me.lblPushes.Size = New System.Drawing.Size(109, 13)
		Me.lblPushes.Location = New System.Drawing.Point(132, 84)
		Me.lblPushes.TabIndex = 51
		Me.lblPushes.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblPushes.BackColor = System.Drawing.SystemColors.Control
		Me.lblPushes.Enabled = True
		Me.lblPushes.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblPushes.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblPushes.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblPushes.UseMnemonic = True
		Me.lblPushes.Visible = True
		Me.lblPushes.AutoSize = False
		Me.lblPushes.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblPushes.Name = "lblPushes"
		Me.lblMoves.TextAlign = System.Drawing.ContentAlignment.TopRight
		Me.lblMoves.Text = "#Ruchy#"
		Me.lblMoves.Size = New System.Drawing.Size(113, 13)
		Me.lblMoves.Location = New System.Drawing.Point(128, 64)
		Me.lblMoves.TabIndex = 50
		Me.lblMoves.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblMoves.BackColor = System.Drawing.SystemColors.Control
		Me.lblMoves.Enabled = True
		Me.lblMoves.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblMoves.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblMoves.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblMoves.UseMnemonic = True
		Me.lblMoves.Visible = True
		Me.lblMoves.AutoSize = False
		Me.lblMoves.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblMoves.Name = "lblMoves"
		Me.lblArrivedLevel.TextAlign = System.Drawing.ContentAlignment.TopRight
		Me.lblArrivedLevel.Text = "#Osi¹gniêty Etap#"
		Me.lblArrivedLevel.Size = New System.Drawing.Size(113, 13)
		Me.lblArrivedLevel.Location = New System.Drawing.Point(128, 44)
		Me.lblArrivedLevel.TabIndex = 49
		Me.lblArrivedLevel.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblArrivedLevel.BackColor = System.Drawing.SystemColors.Control
		Me.lblArrivedLevel.Enabled = True
		Me.lblArrivedLevel.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblArrivedLevel.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblArrivedLevel.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblArrivedLevel.UseMnemonic = True
		Me.lblArrivedLevel.Visible = True
		Me.lblArrivedLevel.AutoSize = False
		Me.lblArrivedLevel.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblArrivedLevel.Name = "lblArrivedLevel"
		Me.Label8.Text = "Pchniêcia:"
		Me.Label8.Size = New System.Drawing.Size(73, 13)
		Me.Label8.Location = New System.Drawing.Point(40, 84)
		Me.Label8.TabIndex = 46
		Me.Label8.Tag = "OptionsDialog#28"
		Me.Label8.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label8.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label8.BackColor = System.Drawing.SystemColors.Control
		Me.Label8.Enabled = True
		Me.Label8.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label8.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label8.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label8.UseMnemonic = True
		Me.Label8.Visible = True
		Me.Label8.AutoSize = False
		Me.Label8.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label8.Name = "Label8"
		Me.Label7.Text = "Ruchy:"
		Me.Label7.Size = New System.Drawing.Size(73, 13)
		Me.Label7.Location = New System.Drawing.Point(40, 64)
		Me.Label7.TabIndex = 45
		Me.Label7.Tag = "OptionsDialog#27"
		Me.Label7.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label7.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label7.BackColor = System.Drawing.SystemColors.Control
		Me.Label7.Enabled = True
		Me.Label7.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label7.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label7.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label7.UseMnemonic = True
		Me.Label7.Visible = True
		Me.Label7.AutoSize = False
		Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label7.Name = "Label7"
		Me.Label6.Text = "Osi¹gniêty etap:"
		Me.Label6.Size = New System.Drawing.Size(77, 17)
		Me.Label6.Location = New System.Drawing.Point(40, 44)
		Me.Label6.TabIndex = 44
		Me.Label6.Tag = "OptionsDialog#26"
		Me.Label6.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label6.BackColor = System.Drawing.SystemColors.Control
		Me.Label6.Enabled = True
		Me.Label6.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label6.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label6.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label6.UseMnemonic = True
		Me.Label6.Visible = True
		Me.Label6.AutoSize = False
		Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label6.Name = "Label6"
		Me.lblLevelSet.Text = "#Zestaw Etapów#"
		Me.lblLevelSet.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
		Me.lblLevelSet.Size = New System.Drawing.Size(221, 17)
		Me.lblLevelSet.Location = New System.Drawing.Point(8, 24)
		Me.lblLevelSet.TabIndex = 43
		Me.lblLevelSet.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblLevelSet.BackColor = System.Drawing.SystemColors.Control
		Me.lblLevelSet.Enabled = True
		Me.lblLevelSet.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblLevelSet.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblLevelSet.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblLevelSet.UseMnemonic = True
		Me.lblLevelSet.Visible = True
		Me.lblLevelSet.AutoSize = False
		Me.lblLevelSet.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblLevelSet.Name = "lblLevelSet"
		Me.Frame9.Text = "Ustawienia"
		Me.Frame9.Size = New System.Drawing.Size(249, 89)
		Me.Frame9.Location = New System.Drawing.Point(160, 180)
		Me.Frame9.TabIndex = 52
		Me.Frame9.Tag = "OptionsDialog#29"
		Me.Frame9.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Frame9.BackColor = System.Drawing.SystemColors.Control
		Me.Frame9.Enabled = True
		Me.Frame9.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Frame9.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Frame9.Visible = True
		Me.Frame9.Name = "Frame9"
		Me.cmdChangePassword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cmdChangePassword.Text = "Zmieñ &has³o..."
		Me.cmdChangePassword.Size = New System.Drawing.Size(105, 29)
		Me.cmdChangePassword.Location = New System.Drawing.Point(136, 52)
		Me.cmdChangePassword.TabIndex = 56
		Me.cmdChangePassword.Tag = "OptionsDialog#34"
		Me.cmdChangePassword.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdChangePassword.BackColor = System.Drawing.SystemColors.Control
		Me.cmdChangePassword.CausesValidation = True
		Me.cmdChangePassword.Enabled = True
		Me.cmdChangePassword.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdChangePassword.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdChangePassword.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdChangePassword.TabStop = True
		Me.cmdChangePassword.Name = "cmdChangePassword"
		Me.txtPassword.AutoSize = False
		Me.txtPassword.Size = New System.Drawing.Size(145, 21)
		Me.txtPassword.IMEMode = System.Windows.Forms.ImeMode.Disable
		Me.txtPassword.Location = New System.Drawing.Point(96, 20)
		Me.txtPassword.PasswordChar = ChrW(42)
		Me.txtPassword.TabIndex = 55
		Me.txtPassword.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtPassword.AcceptsReturn = True
		Me.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtPassword.BackColor = System.Drawing.SystemColors.Window
		Me.txtPassword.CausesValidation = True
		Me.txtPassword.Enabled = True
		Me.txtPassword.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtPassword.HideSelection = True
		Me.txtPassword.ReadOnly = False
		Me.txtPassword.Maxlength = 0
		Me.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtPassword.MultiLine = False
		Me.txtPassword.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtPassword.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtPassword.TabStop = True
		Me.txtPassword.Visible = True
		Me.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtPassword.Name = "txtPassword"
		Me.cmdChangePlayerID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cmdChangePlayerID.Text = "Zmieñ &imiê..."
		Me.cmdChangePlayerID.Size = New System.Drawing.Size(101, 29)
		Me.cmdChangePlayerID.Location = New System.Drawing.Point(12, 52)
		Me.cmdChangePlayerID.TabIndex = 53
		Me.cmdChangePlayerID.Tag = "OptionsDialog#31"
		Me.cmdChangePlayerID.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdChangePlayerID.BackColor = System.Drawing.SystemColors.Control
		Me.cmdChangePlayerID.CausesValidation = True
		Me.cmdChangePlayerID.Enabled = True
		Me.cmdChangePlayerID.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdChangePlayerID.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdChangePlayerID.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdChangePlayerID.TabStop = True
		Me.cmdChangePlayerID.Name = "cmdChangePlayerID"
		Me.Label9.Text = "Wpisz has³o:"
		Me.Label9.Size = New System.Drawing.Size(77, 17)
		Me.Label9.Location = New System.Drawing.Point(12, 24)
		Me.Label9.TabIndex = 54
		Me.Label9.Tag = "OptionsDialog#30"
		Me.Label9.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label9.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label9.BackColor = System.Drawing.SystemColors.Control
		Me.Label9.Enabled = True
		Me.Label9.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label9.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label9.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label9.UseMnemonic = True
		Me.Label9.Visible = True
		Me.Label9.AutoSize = False
		Me.Label9.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label9.Name = "Label9"
		Me.chkFirstPlayerAutoLogon.Text = "&Automatycznie loguj pierwszego gracza, je¿eli jest on jedynym"
		Me.chkFirstPlayerAutoLogon.Size = New System.Drawing.Size(397, 17)
		Me.chkFirstPlayerAutoLogon.Location = New System.Drawing.Point(12, 274)
		Me.chkFirstPlayerAutoLogon.TabIndex = 59
		Me.chkFirstPlayerAutoLogon.Tag = "OptionsDialog#35#First Player Auto Logon"
		Me.chkFirstPlayerAutoLogon.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.chkFirstPlayerAutoLogon.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.chkFirstPlayerAutoLogon.BackColor = System.Drawing.SystemColors.Control
		Me.chkFirstPlayerAutoLogon.CausesValidation = True
		Me.chkFirstPlayerAutoLogon.Enabled = True
		Me.chkFirstPlayerAutoLogon.ForeColor = System.Drawing.SystemColors.ControlText
		Me.chkFirstPlayerAutoLogon.Cursor = System.Windows.Forms.Cursors.Default
		Me.chkFirstPlayerAutoLogon.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.chkFirstPlayerAutoLogon.Appearance = System.Windows.Forms.Appearance.Normal
		Me.chkFirstPlayerAutoLogon.TabStop = True
		Me.chkFirstPlayerAutoLogon.CheckState = System.Windows.Forms.CheckState.Unchecked
		Me.chkFirstPlayerAutoLogon.Visible = True
		Me.chkFirstPlayerAutoLogon.Name = "chkFirstPlayerAutoLogon"
		Me._tabOptions_TabPage3.Text = "&Muzyka"
		Me.Frame6.Text = "Lista plików muzycznych"
		Me.Frame6.Size = New System.Drawing.Size(381, 217)
		Me.Frame6.Location = New System.Drawing.Point(16, 63)
		Me.Frame6.TabIndex = 35
		Me.Frame6.Tag = "OptionsDialog#37"
		Me.Frame6.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Frame6.BackColor = System.Drawing.SystemColors.Control
		Me.Frame6.Enabled = True
		Me.Frame6.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Frame6.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Frame6.Visible = True
		Me.Frame6.Name = "Frame6"
		Me.cmdUseOnlyOwnMIDI.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cmdUseOnlyOwnMIDI.Text = "&Zresetuj listê plików"
		Me.cmdUseOnlyOwnMIDI.Size = New System.Drawing.Size(341, 29)
		Me.cmdUseOnlyOwnMIDI.Location = New System.Drawing.Point(12, 172)
		Me.cmdUseOnlyOwnMIDI.TabIndex = 39
		Me.cmdUseOnlyOwnMIDI.Tag = "OptionsDialog#41"
		Me.cmdUseOnlyOwnMIDI.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdUseOnlyOwnMIDI.BackColor = System.Drawing.SystemColors.Control
		Me.cmdUseOnlyOwnMIDI.CausesValidation = True
		Me.cmdUseOnlyOwnMIDI.Enabled = True
		Me.cmdUseOnlyOwnMIDI.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdUseOnlyOwnMIDI.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdUseOnlyOwnMIDI.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdUseOnlyOwnMIDI.TabStop = True
		Me.cmdUseOnlyOwnMIDI.Name = "cmdUseOnlyOwnMIDI"
		Me.cmdFindMIDIAgain.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cmdFindMIDIAgain.Text = "&Szukaj ponownie plików MIDI..."
		Me.cmdFindMIDIAgain.Size = New System.Drawing.Size(341, 29)
		Me.cmdFindMIDIAgain.Location = New System.Drawing.Point(12, 56)
		Me.cmdFindMIDIAgain.TabIndex = 37
		Me.cmdFindMIDIAgain.Tag = "OptionsDialog#39"
		Me.cmdFindMIDIAgain.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdFindMIDIAgain.BackColor = System.Drawing.SystemColors.Control
		Me.cmdFindMIDIAgain.CausesValidation = True
		Me.cmdFindMIDIAgain.Enabled = True
		Me.cmdFindMIDIAgain.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdFindMIDIAgain.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdFindMIDIAgain.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdFindMIDIAgain.TabStop = True
		Me.cmdFindMIDIAgain.Name = "cmdFindMIDIAgain"
		Me.Label5.Text = "Je¿eli chcesz, by odtwarzane by³y tylko pliki do³¹czone do gry, kliknij ten przycisk:"
		Me.Label5.Size = New System.Drawing.Size(341, 29)
		Me.Label5.Location = New System.Drawing.Point(12, 132)
		Me.Label5.TabIndex = 38
		Me.Label5.Tag = "OptionsDialog#40"
		Me.Label5.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label5.BackColor = System.Drawing.SystemColors.Control
		Me.Label5.Enabled = True
		Me.Label5.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label5.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label5.UseMnemonic = True
		Me.Label5.Visible = True
		Me.Label5.AutoSize = False
		Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label5.Name = "Label5"
		Me.Label4.Text = "Mo¿esz ponownie przeprowadziæ wyszukiwanie plików MIDI klikaj¹c na ten przycisk:"
		Me.Label4.Size = New System.Drawing.Size(353, 25)
		Me.Label4.Location = New System.Drawing.Point(12, 24)
		Me.Label4.TabIndex = 36
		Me.Label4.Tag = "OptionsDialog#38"
		Me.Label4.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label4.BackColor = System.Drawing.SystemColors.Control
		Me.Label4.Enabled = True
		Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label4.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label4.UseMnemonic = True
		Me.Label4.Visible = True
		Me.Label4.AutoSize = False
		Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label4.Name = "Label4"
		Me.chkPlayMusic.Text = "&Odtwarzaj muzykê w czasie gry"
		Me.chkPlayMusic.Size = New System.Drawing.Size(365, 17)
		Me.chkPlayMusic.Location = New System.Drawing.Point(16, 35)
		Me.chkPlayMusic.TabIndex = 34
		Me.chkPlayMusic.Tag = "OptionsDialog#36#Play Music"
		Me.chkPlayMusic.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.chkPlayMusic.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.chkPlayMusic.BackColor = System.Drawing.SystemColors.Control
		Me.chkPlayMusic.CausesValidation = True
		Me.chkPlayMusic.Enabled = True
		Me.chkPlayMusic.ForeColor = System.Drawing.SystemColors.ControlText
		Me.chkPlayMusic.Cursor = System.Windows.Forms.Cursors.Default
		Me.chkPlayMusic.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.chkPlayMusic.Appearance = System.Windows.Forms.Appearance.Normal
		Me.chkPlayMusic.TabStop = True
		Me.chkPlayMusic.CheckState = System.Windows.Forms.CheckState.Unchecked
		Me.chkPlayMusic.Visible = True
		Me.chkPlayMusic.Name = "chkPlayMusic"
		Me._tabOptions_TabPage4.Text = "&Jêzyk"
		Me.Frame10.Size = New System.Drawing.Size(409, 250)
		Me.Frame10.Location = New System.Drawing.Point(9, 30)
		Me.Frame10.TabIndex = 60
		Me.Frame10.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Frame10.BackColor = System.Drawing.SystemColors.Control
		Me.Frame10.Enabled = True
		Me.Frame10.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Frame10.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Frame10.Visible = True
		Me.Frame10.Name = "Frame10"
		Me.lstLanguages.Size = New System.Drawing.Size(166, 228)
		Me.lstLanguages.Location = New System.Drawing.Point(123, 15)
		Me.lstLanguages.Sorted = True
		Me.lstLanguages.TabIndex = 61
		Me.lstLanguages.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lstLanguages.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lstLanguages.BackColor = System.Drawing.SystemColors.Window
		Me.lstLanguages.CausesValidation = True
		Me.lstLanguages.Enabled = True
		Me.lstLanguages.ForeColor = System.Drawing.SystemColors.WindowText
		Me.lstLanguages.IntegralHeight = True
		Me.lstLanguages.Cursor = System.Windows.Forms.Cursors.Default
		Me.lstLanguages.SelectionMode = System.Windows.Forms.SelectionMode.One
		Me.lstLanguages.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lstLanguages.TabStop = True
		Me.lstLanguages.Visible = True
		Me.lstLanguages.MultiColumn = False
		Me.lstLanguages.Name = "lstLanguages"
		Me._picOptions_3.Size = New System.Drawing.Size(379, 252)
		Me._picOptions_3.Location = New System.Drawing.Point(-1333, 32)
		Me._picOptions_3.TabIndex = 4
		Me._picOptions_3.TabStop = False
		Me._picOptions_3.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._picOptions_3.Dock = System.Windows.Forms.DockStyle.None
		Me._picOptions_3.BackColor = System.Drawing.SystemColors.Control
		Me._picOptions_3.CausesValidation = True
		Me._picOptions_3.Enabled = True
		Me._picOptions_3.ForeColor = System.Drawing.SystemColors.ControlText
		Me._picOptions_3.Cursor = System.Windows.Forms.Cursors.Default
		Me._picOptions_3.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._picOptions_3.Visible = True
		Me._picOptions_3.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._picOptions_3.Name = "_picOptions_3"
		Me.fraSample4.Text = "Sample 4"
		Me.fraSample4.Size = New System.Drawing.Size(137, 119)
		Me.fraSample4.Location = New System.Drawing.Point(140, 56)
		Me.fraSample4.TabIndex = 7
		Me.fraSample4.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.fraSample4.BackColor = System.Drawing.SystemColors.Control
		Me.fraSample4.Enabled = True
		Me.fraSample4.ForeColor = System.Drawing.SystemColors.ControlText
		Me.fraSample4.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.fraSample4.Visible = True
		Me.fraSample4.Name = "fraSample4"
		Me._picOptions_2.Size = New System.Drawing.Size(379, 252)
		Me._picOptions_2.Location = New System.Drawing.Point(-1333, 32)
		Me._picOptions_2.TabIndex = 3
		Me._picOptions_2.TabStop = False
		Me._picOptions_2.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._picOptions_2.Dock = System.Windows.Forms.DockStyle.None
		Me._picOptions_2.BackColor = System.Drawing.SystemColors.Control
		Me._picOptions_2.CausesValidation = True
		Me._picOptions_2.Enabled = True
		Me._picOptions_2.ForeColor = System.Drawing.SystemColors.ControlText
		Me._picOptions_2.Cursor = System.Windows.Forms.Cursors.Default
		Me._picOptions_2.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._picOptions_2.Visible = True
		Me._picOptions_2.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._picOptions_2.Name = "_picOptions_2"
		Me.fraSample3.Text = "Sample 3"
		Me.fraSample3.Size = New System.Drawing.Size(137, 119)
		Me.fraSample3.Location = New System.Drawing.Point(103, 45)
		Me.fraSample3.TabIndex = 6
		Me.fraSample3.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.fraSample3.BackColor = System.Drawing.SystemColors.Control
		Me.fraSample3.Enabled = True
		Me.fraSample3.ForeColor = System.Drawing.SystemColors.ControlText
		Me.fraSample3.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.fraSample3.Visible = True
		Me.fraSample3.Name = "fraSample3"
		Me._picOptions_1.Size = New System.Drawing.Size(379, 252)
		Me._picOptions_1.Location = New System.Drawing.Point(-1333, 32)
		Me._picOptions_1.TabIndex = 2
		Me._picOptions_1.TabStop = False
		Me._picOptions_1.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._picOptions_1.Dock = System.Windows.Forms.DockStyle.None
		Me._picOptions_1.BackColor = System.Drawing.SystemColors.Control
		Me._picOptions_1.CausesValidation = True
		Me._picOptions_1.Enabled = True
		Me._picOptions_1.ForeColor = System.Drawing.SystemColors.ControlText
		Me._picOptions_1.Cursor = System.Windows.Forms.Cursors.Default
		Me._picOptions_1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._picOptions_1.Visible = True
		Me._picOptions_1.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._picOptions_1.Name = "_picOptions_1"
		Me.fraSample2.Text = "Sample 2"
		Me.fraSample2.Size = New System.Drawing.Size(137, 119)
		Me.fraSample2.Location = New System.Drawing.Point(43, 20)
		Me.fraSample2.TabIndex = 5
		Me.fraSample2.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.fraSample2.BackColor = System.Drawing.SystemColors.Control
		Me.fraSample2.Enabled = True
		Me.fraSample2.ForeColor = System.Drawing.SystemColors.ControlText
		Me.fraSample2.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.fraSample2.Visible = True
		Me.fraSample2.Name = "fraSample2"
		Me.cmdCancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.CancelButton = Me.cmdCancel
		Me.cmdCancel.Text = "&Anuluj"
		Me.cmdCancel.Size = New System.Drawing.Size(73, 25)
		Me.cmdCancel.Location = New System.Drawing.Point(176, 312)
		Me.cmdCancel.TabIndex = 1
		Me.cmdCancel.Tag = "Buttons#1"
		Me.cmdCancel.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdCancel.BackColor = System.Drawing.SystemColors.Control
		Me.cmdCancel.CausesValidation = True
		Me.cmdCancel.Enabled = True
		Me.cmdCancel.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdCancel.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdCancel.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdCancel.TabStop = True
		Me.cmdCancel.Name = "cmdCancel"
		Me.cmdOK.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cmdOK.Text = "&OK"
		Me.AcceptButton = Me.cmdOK
		Me.cmdOK.Size = New System.Drawing.Size(73, 25)
		Me.cmdOK.Location = New System.Drawing.Point(84, 312)
		Me.cmdOK.TabIndex = 0
		Me.cmdOK.Tag = "Buttons#0"
		Me.cmdOK.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdOK.BackColor = System.Drawing.SystemColors.Control
		Me.cmdOK.CausesValidation = True
		Me.cmdOK.Enabled = True
		Me.cmdOK.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdOK.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdOK.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdOK.TabStop = True
		Me.cmdOK.Name = "cmdOK"
		Me.Controls.Add(cmdApply)
		Me.Controls.Add(tabOptions)
		Me.Controls.Add(_picOptions_3)
		Me.Controls.Add(_picOptions_2)
		Me.Controls.Add(_picOptions_1)
		Me.Controls.Add(cmdCancel)
		Me.Controls.Add(cmdOK)
		Me.tabOptions.Controls.Add(_tabOptions_TabPage0)
		Me.tabOptions.Controls.Add(_tabOptions_TabPage1)
		Me.tabOptions.Controls.Add(_tabOptions_TabPage2)
		Me.tabOptions.Controls.Add(_tabOptions_TabPage3)
		Me.tabOptions.Controls.Add(_tabOptions_TabPage4)
		Me._tabOptions_TabPage0.Controls.Add(Label3)
		Me._tabOptions_TabPage0.Controls.Add(Frame2)
		Me._tabOptions_TabPage0.Controls.Add(Frame1)
		Me._tabOptions_TabPage0.Controls.Add(chkBeginFromArrivedLevel)
		Me._tabOptions_TabPage0.Controls.Add(cmbShowInTray)
		Me.Frame2.Controls.Add(chkShowTipsAtStartup)
		Me.Frame2.Controls.Add(chkShowSplashAtStartup)
		Me.Frame1.Controls.Add(chkWantClosingAuthorization)
		Me.Frame1.Controls.Add(chkWantLevelRestartingAuthorization)
		Me.Frame1.Controls.Add(chkShowLevelLoadConfirmation)
		Me._tabOptions_TabPage1.Controls.Add(Frame3)
		Me._tabOptions_TabPage1.Controls.Add(Frame5)
		Me.Frame3.Controls.Add(Frame4)
		Me.Frame3.Controls.Add(lstSkins)
		Me.Frame4.Controls.Add(_picPreview_6)
		Me.Frame4.Controls.Add(_picPreview_5)
		Me.Frame4.Controls.Add(_picPreview_4)
		Me.Frame4.Controls.Add(_picPreview_3)
		Me.Frame4.Controls.Add(_picPreview_2)
		Me.Frame4.Controls.Add(_picPreview_0)
		Me.Frame4.Controls.Add(_picPreview_1)
		Me.Frame4.Controls.Add(Label2)
		Me.Frame5.Controls.Add(cmdBackgroundColor)
		Me.Frame5.Controls.Add(Label1)
		Me._tabOptions_TabPage2.Controls.Add(Frame7)
		Me._tabOptions_TabPage2.Controls.Add(Frame8)
		Me._tabOptions_TabPage2.Controls.Add(Frame9)
		Me._tabOptions_TabPage2.Controls.Add(chkFirstPlayerAutoLogon)
		Me.Frame7.Controls.Add(cmdDeletePlayer)
		Me.Frame7.Controls.Add(cmdNewPlayer)
		Me.Frame7.Controls.Add(lstPlayers)
		Me.Frame8.Controls.Add(cmdPrevSet)
		Me.Frame8.Controls.Add(cmdNextSet)
		Me.Frame8.Controls.Add(lblPushes)
		Me.Frame8.Controls.Add(lblMoves)
		Me.Frame8.Controls.Add(lblArrivedLevel)
		Me.Frame8.Controls.Add(Label8)
		Me.Frame8.Controls.Add(Label7)
		Me.Frame8.Controls.Add(Label6)
		Me.Frame8.Controls.Add(lblLevelSet)
		Me.Frame9.Controls.Add(cmdChangePassword)
		Me.Frame9.Controls.Add(txtPassword)
		Me.Frame9.Controls.Add(cmdChangePlayerID)
		Me.Frame9.Controls.Add(Label9)
		Me._tabOptions_TabPage3.Controls.Add(Frame6)
		Me._tabOptions_TabPage3.Controls.Add(chkPlayMusic)
		Me.Frame6.Controls.Add(cmdUseOnlyOwnMIDI)
		Me.Frame6.Controls.Add(cmdFindMIDIAgain)
		Me.Frame6.Controls.Add(Label5)
		Me.Frame6.Controls.Add(Label4)
		Me._tabOptions_TabPage4.Controls.Add(Frame10)
		Me.Frame10.Controls.Add(lstLanguages)
		Me._picOptions_3.Controls.Add(fraSample4)
		Me._picOptions_2.Controls.Add(fraSample3)
		Me._picOptions_1.Controls.Add(fraSample2)
		Me.picOptions.SetIndex(_picOptions_3, CType(3, Short))
		Me.picOptions.SetIndex(_picOptions_2, CType(2, Short))
		Me.picOptions.SetIndex(_picOptions_1, CType(1, Short))
		Me.picPreview.SetIndex(_picPreview_6, CType(6, Short))
		Me.picPreview.SetIndex(_picPreview_5, CType(5, Short))
		Me.picPreview.SetIndex(_picPreview_4, CType(4, Short))
		Me.picPreview.SetIndex(_picPreview_3, CType(3, Short))
		Me.picPreview.SetIndex(_picPreview_2, CType(2, Short))
		Me.picPreview.SetIndex(_picPreview_0, CType(0, Short))
		Me.picPreview.SetIndex(_picPreview_1, CType(1, Short))
		CType(Me.picPreview, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.picOptions, System.ComponentModel.ISupportInitialize).EndInit()
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
		
		PrzetlumaczForme(frmOptions.DefInstance)
		PrzetlumaczForme(frmMain.DefInstance)
	End Sub
	
	Private Sub cmdBackgroundColor_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdBackgroundColor.Click
		Dim Color As Integer
		
		Color = System.Drawing.ColorTranslator.ToOle(cmdBackgroundColor.BackColor)
		CDialog.VBChooseColor(Color,  ,  ,  , Me.Handle.ToInt32)
		If Color >= 0 Then cmdBackgroundColor.BackColor = System.Drawing.ColorTranslator.FromOle(Color)
	End Sub
	Private Sub cmdCancel_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdCancel.Click
		Me.Close()
	End Sub
	Sub ZapiszOpcje()
		Dim ctrl As System.Windows.Forms.Control
		Dim Temp As Object
		
		For	Each ctrl In Me.Controls
			'UPGRADE_WARNING: TypeName has a new behavior. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1041"'
			If TypeName(ctrl) = "CheckBox" Then
				'UPGRADE_WARNING: Couldn't resolve default property of object Temp. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
				Temp = Split(ctrl.Tag, "#")
				
				'UPGRADE_WARNING: Couldn't resolve default property of object Temp(). Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
				RegWartosc = RegSciezka & "\Options\" & Temp(2)
				'UPGRADE_WARNING: Couldn't resolve default property of object ctrl.Value. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
				RegDaneInt = ctrl.Value
				'UPGRADE_WARNING: Couldn't resolve default property of object RegObj.Set. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
				RegObj.Set(RegWartosc, RegDaneInt, RegFlush)
			End If
		Next ctrl
		WczytajListeMIDI()
		GrajMidi()
		
		RegWartosc = RegSciezka & "\Options\Show in Tray"
		RegDaneInt = cmbShowInTray.SelectedIndex
		'UPGRADE_WARNING: Couldn't resolve default property of object RegObj.Set. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
		RegObj.Set(RegWartosc, RegDaneInt, RegFlush)
		Select Case RegDaneInt
			Case 0 : TIcon.Hide()
			Case 2 : If TIcon.Visible = False Then TIcon.Show()
		End Select
		
		' Wygl¹d
		'-------
		RegWartosc = RegSciezka & "\Options\Background Color"
		RegDaneInt = Val(CStr(System.Drawing.ColorTranslator.ToOle(cmdBackgroundColor.BackColor)))
		'UPGRADE_WARNING: Couldn't resolve default property of object RegObj.Set. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
		RegObj.Set(RegWartosc, RegDaneInt, RegFlush)
		
		RegWartosc = RegSciezka & "\Options\Skin"
		RegDaneStr = lstSkins.Text
		'UPGRADE_WARNING: Couldn't resolve default property of object RegObj.Set. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
		RegObj.Set(RegWartosc, RegDaneStr, RegFlush)
		
		' Jêzyk
		'------
		RegWartosc = RegSciezka & "\Options\Language"
		RegDaneStr = lstLanguages.Text
		'UPGRADE_WARNING: Couldn't resolve default property of object RegObj.Set. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
		RegObj.Set(RegWartosc, RegDaneStr, RegFlush)
		
		frmMain.DefInstance.BackColor = cmdBackgroundColor.BackColor
		OdswiezPoleGry()
	End Sub
	Sub WczytajOpcje()
		Dim ctrl As System.Windows.Forms.Control
		Dim Temp As Object
		
		cmbShowInTray.Items.Insert(0, ZwrocCiag("OptionsDialog#14"))
		cmbShowInTray.Items.Insert(1, ZwrocCiag("OptionsDialog#15"))
		cmbShowInTray.Items.Insert(2, ZwrocCiag("OptionsDialog#16"))
		
		For	Each ctrl In Me.Controls
			'UPGRADE_WARNING: TypeName has a new behavior. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1041"'
			If TypeName(ctrl) = "CheckBox" Then
				'UPGRADE_WARNING: Couldn't resolve default property of object Temp. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
				Temp = Split(ctrl.Tag, "#")
				
				'UPGRADE_WARNING: Couldn't resolve default property of object Temp(). Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
				RegWartosc = RegSciezka & "\Options\" & Temp(2)
				'UPGRADE_WARNING: Couldn't resolve default property of object RegObj.Get. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
				If Val(RegObj.Get(RegWartosc)) = 1 Then
					'UPGRADE_WARNING: Couldn't resolve default property of object ctrl.Value. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
					ctrl.Value = System.Windows.Forms.CheckState.Checked
				Else
					'UPGRADE_WARNING: Couldn't resolve default property of object ctrl.Value. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
					ctrl.Value = System.Windows.Forms.CheckState.Unchecked
				End If
			End If
		Next ctrl
		
		RegWartosc = RegSciezka & "\Options\Show in Tray"
		'UPGRADE_WARNING: Couldn't resolve default property of object RegObj.Get. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
		cmbShowInTray.SelectedIndex = Val(RegObj.Get(RegWartosc))
		
		' Wygl¹d
		'-------
		RegWartosc = RegSciezka & "\Options\Background Color"
		'UPGRADE_WARNING: Couldn't resolve default property of object RegObj.Get. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
		cmdBackgroundColor.BackColor = System.Drawing.ColorTranslator.FromOle(Val(RegObj.Get(RegWartosc)))
		
		lstSkins.Items.Add("(Oryginalny)")
		FileOpen(1, VB6.GetPath & "\Ini\Skiny.ini", OpenMode.Input)
		Do Until EOF(1)
			Temp = LineInput(1)
			'UPGRADE_WARNING: Couldn't resolve default property of object Temp. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
			lstSkins.Items.Add(Temp)
		Loop 
		FileClose(1)
		RegWartosc = RegSciezka & "\Options\Skin"
		'UPGRADE_WARNING: Couldn't resolve default property of object RegObj.Get. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
		lstSkins.Text = RegObj.Get(RegWartosc)
		
		' Jêzyk
		'------
		FileOpen(1, VB6.GetPath & "\Ini\Jezyki.ini", OpenMode.Input)
		Do Until EOF(1)
			Temp = LineInput(1)
			'UPGRADE_WARNING: Couldn't resolve default property of object Temp. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
			lstLanguages.Items.Add(Temp)
		Loop 
		FileClose(1)
		RegWartosc = RegSciezka & "\Options\Language"
		'UPGRADE_WARNING: Couldn't resolve default property of object RegObj.Get. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
		lstLanguages.Text = RegObj.Get(RegWartosc)
	End Sub
	
	Private Sub cmdChangePassword_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdChangePassword.Click
		RegWartosc = RegSciezka & "\Players\" & Str(PodajNumerGracza(lstPlayers.Text)) & "\Password"
		'UPGRADE_WARNING: Couldn't resolve default property of object RegObj.Get. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
		If Odszyfruj(CStr(RegObj.Get(RegWartosc))) <> txtPassword.Text Then
			MsgBox("Stare has³o jest nieprawid³owe!", MsgBoxStyle.OKOnly + MsgBoxStyle.Critical + MsgBoxStyle.ApplicationModal, "B³ad w haœle")
			Exit Sub
		End If
		
		NewPlayerFormAction = "Password"
		PokazForme(frmNewPlayer.DefInstance, VB6.FormShowConstants.Modal, frmOptions.DefInstance)
	End Sub
	
	Private Sub cmdChangePlayerID_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdChangePlayerID.Click
		RegWartosc = RegSciezka & "\Players\" & Str(PodajNumerGracza(lstPlayers.Text)) & "\Password"
		'UPGRADE_WARNING: Couldn't resolve default property of object RegObj.Get. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
		If Odszyfruj(RegObj.Get(RegWartosc)) <> txtPassword.Text Then
			MsgBox(ZwrocCiag("LoginDialog#4"), MsgBoxStyle.OKOnly + MsgBoxStyle.Critical + MsgBoxStyle.ApplicationModal, System.Reflection.Assembly.GetExecutingAssembly.GetName.Name)
			Exit Sub
		End If
		
		'UPGRADE_WARNING: Couldn't resolve default property of object Temp. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
		Temp = InputBox(ZwrocCiag("OptionsDialog#33"), ZwrocCiag("OptionsDialog#32"), DaneGracza.Imie)
		'UPGRADE_WARNING: Couldn't resolve default property of object Temp. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
		If Temp <> "" Then
			'UPGRADE_WARNING: Couldn't resolve default property of object Temp. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
			DaneGracza.Imie = Temp
			RegWartosc = RegSciezka & "\Players\" & Str(DaneGracza.Numer) & "\Name"
			'UPGRADE_WARNING: Couldn't resolve default property of object RegObj.Set. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
			RegObj.Set(RegWartosc, DaneGracza.Imie, RegFlush)
		End If
		
		WczytajListeGraczy()
	End Sub
	Private Sub cmdDeletePlayer_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdDeletePlayer.Click
		If lstPlayers.Text <> DaneGracza.Imie Then
			If MsgBox(Replace(ZwrocCiag("OptionsDialog#43"), "<player>", lstPlayers.Text), MsgBoxStyle.YesNo + MsgBoxStyle.Exclamation + MsgBoxStyle.ApplicationModal, System.Reflection.Assembly.GetExecutingAssembly.GetName.Name) = MsgBoxResult.Yes Then
				UsunGracza(PodajNumerGracza(lstPlayers.Text))
			End If
		Else
			If MsgBox(Replace(ZwrocCiag("OptionsDialog#44"), "<player>", lstPlayers.Text), MsgBoxStyle.YesNo + MsgBoxStyle.Exclamation + MsgBoxStyle.ApplicationModal, System.Reflection.Assembly.GetExecutingAssembly.GetName.Name) = MsgBoxResult.Yes Then
				UsunGracza(PodajNumerGracza(lstPlayers.Text))
				ZatrzymajMidi()
				ZamknijMidi()
				TIcon.Hide()
				End
			End If
		End If
		
		SprawdzLiczbeGraczy()
		WczytajListeGraczy()
	End Sub
	Private Sub cmdFindMIDIAgain_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdFindMIDIAgain.Click
		If MsgBox(ZwrocCiag("OptionsDialog#45"), MsgBoxStyle.YesNo + MsgBoxStyle.Question + MsgBoxStyle.ApplicationModal, "Wyszukiwanie") = MsgBoxResult.Yes Then
			PokazForme(frmFindMIDI.DefInstance, VB6.FormShowConstants.Modal, frmOptions.DefInstance)
		End If
	End Sub
	
	Private Sub cmdNewPlayer_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdNewPlayer.Click
		NewPlayerFormAction = "New Player"
		PokazForme(frmNewPlayer.DefInstance, VB6.FormShowConstants.Modal, frmOptions.DefInstance)
		WczytajListeGraczy()
	End Sub
	
	Private Sub cmdNextSet_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdNextSet.Click
		cmdNextSet.Enabled = False
		cmdPrevSet.Enabled = True
		WyswietlStatystyki(2)
	End Sub
	
	Private Sub cmdOK_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdOK.Click
		ZapiszOpcje()
		PrzetlumaczForme(frmOptions.DefInstance)
		PrzetlumaczForme(frmMain.DefInstance)
		
		Me.Close()
	End Sub
	
	Private Sub cmdPrevSet_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdPrevSet.Click
		cmdPrevSet.Enabled = False
		cmdNextSet.Enabled = True
		WyswietlStatystyki(1)
	End Sub
	
	Private Sub cmdUseOnlyOwnMIDI_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdUseOnlyOwnMIDI.Click
		If MsgBox(ZwrocCiag("OptionsDialog#46"), MsgBoxStyle.YesNo + MsgBoxStyle.Exclamation + MsgBoxStyle.ApplicationModal, "Reesetowanie listy plików") = MsgBoxResult.Yes Then
			PrzywrocOryginalnyINI()
		End If
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
		Me.SetBounds(VB6.TwipsToPixelsX((VB6.PixelsToTwipsX(System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width) - VB6.PixelsToTwipsX(Me.Width)) / 2), VB6.TwipsToPixelsY((VB6.PixelsToTwipsY(System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height) - VB6.PixelsToTwipsY(Me.Height)) / 2), 0, 0, Windows.Forms.BoundsSpecified.X Or Windows.Forms.BoundsSpecified.Y)
	End Sub
	Sub WyswietlPodgladSkinu()
		Dim i As Short
		
		For i = 0 To 6
			picPreview(i).Image = System.Drawing.Image.FromFile(VB6.GetPath & "\Skiny\" & lstSkins.Text & "\" & i & ".ico")
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
			RegWartosc = RegSciezka & "\Players\" & Str(Licznik) & "\Name"
			'UPGRADE_WARNING: Couldn't resolve default property of object RegObj.Get. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
			lstPlayers.Items.Add(CStr(RegObj.Get(RegWartosc))) 'Licznik
		Next Licznik
		lstPlayers.Items.RemoveAt(0)
		lstPlayers.SetSelected(0, True)
	End Sub
	Public Sub WyswietlStatystyki(ByVal NrZestawu As Byte)
		Select Case NrZestawu
			Case 1
				lblLevelSet.Text = ZwrocCiag("OptionsDialog#25") & " " & UCase(ZwrocCiag("Sets#0"))
				
				RegWartosc = RegSciezka & "\Players\" & Str(PodajNumerGracza(lstPlayers.Text)) & "\Klasyczne\Arrived Level"
				'UPGRADE_WARNING: Couldn't resolve default property of object RegObj.Get. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
				lblArrivedLevel.Text = RegObj.Get(RegWartosc)
				
				RegWartosc = RegSciezka & "\Players\" & Str(PodajNumerGracza(lstPlayers.Text)) & "\Klasyczne\Moves"
				'UPGRADE_WARNING: Couldn't resolve default property of object RegObj.Get. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
				lblMoves.Text = RegObj.Get(RegWartosc)
				
				RegWartosc = RegSciezka & "\Players\" & Str(PodajNumerGracza(lstPlayers.Text)) & "\Klasyczne\Pushes"
				'UPGRADE_WARNING: Couldn't resolve default property of object RegObj.Get. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
				lblPushes.Text = RegObj.Get(RegWartosc)
			Case 2
				lblLevelSet.Text = ZwrocCiag("OptionsDialog#25") & " " & UCase(ZwrocCiag("Sets#1"))
				
				RegWartosc = RegSciezka & "\Players\" & Str(PodajNumerGracza(lstPlayers.Text)) & "\Super Trudne XS\Arrived Level"
				'UPGRADE_WARNING: Couldn't resolve default property of object RegObj.Get. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
				lblArrivedLevel.Text = RegObj.Get(RegWartosc)
				
				RegWartosc = RegSciezka & "\Players\" & Str(PodajNumerGracza(lstPlayers.Text)) & "\Super Trudne XS\Moves"
				'UPGRADE_WARNING: Couldn't resolve default property of object RegObj.Get. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
				lblMoves.Text = RegObj.Get(RegWartosc)
				
				RegWartosc = RegSciezka & "\Players\" & Str(PodajNumerGracza(lstPlayers.Text)) & "\Super Trudne XS\Pushes"
				'UPGRADE_WARNING: Couldn't resolve default property of object RegObj.Get. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
				lblPushes.Text = RegObj.Get(RegWartosc)
		End Select
	End Sub
End Class