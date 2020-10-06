Option Strict Off
Option Explicit On
Friend Class frmOptions
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
    Public WithEvents chkWantLevelRestartingAuthorization As System.Windows.Forms.CheckBox
    Public WithEvents chkShowLevelLoadConfirmation As System.Windows.Forms.CheckBox
    Public WithEvents Frame1 As System.Windows.Forms.GroupBox
    Public WithEvents chkBeginFromArrivedLevel As System.Windows.Forms.CheckBox
    Public WithEvents _tabOptions_TabPage0 As System.Windows.Forms.TabPage
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
    Public WithEvents _tabOptions_TabPage2 As System.Windows.Forms.TabPage
    Public WithEvents tabOptions As System.Windows.Forms.TabControl
    Public WithEvents fraSample4 As System.Windows.Forms.GroupBox
    Public WithEvents _picOptions_3 As System.Windows.Forms.Panel
    Public WithEvents fraSample3 As System.Windows.Forms.GroupBox
    Public WithEvents _picOptions_2 As System.Windows.Forms.Panel
    Public WithEvents fraSample2 As System.Windows.Forms.GroupBox
    Public WithEvents _picOptions_1 As System.Windows.Forms.Panel
    Public WithEvents cmdOK As System.Windows.Forms.Button
    'Public WithEvents picOptions As Microsoft.VisualBasic.Compatibility.VB6.PanelArray
    'Public WithEvents picPreview As Microsoft.VisualBasic.Compatibility.VB6.PictureBoxArray
    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.tabOptions = New System.Windows.Forms.TabControl()
        Me._tabOptions_TabPage0 = New System.Windows.Forms.TabPage()
        Me.Frame1 = New System.Windows.Forms.GroupBox()
        Me.chkWantLevelRestartingAuthorization = New System.Windows.Forms.CheckBox()
        Me.chkShowLevelLoadConfirmation = New System.Windows.Forms.CheckBox()
        Me.chkBeginFromArrivedLevel = New System.Windows.Forms.CheckBox()
        Me._tabOptions_TabPage2 = New System.Windows.Forms.TabPage()
        Me.Frame8 = New System.Windows.Forms.GroupBox()
        Me.cmdPrevSet = New System.Windows.Forms.Button()
        Me.cmdNextSet = New System.Windows.Forms.Button()
        Me.lblPushes = New System.Windows.Forms.Label()
        Me.lblMoves = New System.Windows.Forms.Label()
        Me.lblArrivedLevel = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblLevelSet = New System.Windows.Forms.Label()
        Me._picOptions_3 = New System.Windows.Forms.Panel()
        Me.fraSample4 = New System.Windows.Forms.GroupBox()
        Me._picOptions_2 = New System.Windows.Forms.Panel()
        Me.fraSample3 = New System.Windows.Forms.GroupBox()
        Me._picOptions_1 = New System.Windows.Forms.Panel()
        Me.fraSample2 = New System.Windows.Forms.GroupBox()
        Me.cmdOK = New System.Windows.Forms.Button()
        Me.tabOptions.SuspendLayout()
        Me._tabOptions_TabPage0.SuspendLayout()
        Me.Frame1.SuspendLayout()
        Me._tabOptions_TabPage2.SuspendLayout()
        Me.Frame8.SuspendLayout()
        Me._picOptions_3.SuspendLayout()
        Me._picOptions_2.SuspendLayout()
        Me._picOptions_1.SuspendLayout()
        Me.SuspendLayout()
        '
        'tabOptions
        '
        Me.tabOptions.Appearance = System.Windows.Forms.TabAppearance.FlatButtons
        Me.tabOptions.Controls.Add(Me._tabOptions_TabPage0)
        Me.tabOptions.Controls.Add(Me._tabOptions_TabPage2)
        Me.tabOptions.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabOptions.ItemSize = New System.Drawing.Size(42, 18)
        Me.tabOptions.Location = New System.Drawing.Point(8, 4)
        Me.tabOptions.Name = "tabOptions"
        Me.tabOptions.SelectedIndex = 0
        Me.tabOptions.Size = New System.Drawing.Size(425, 339)
        Me.tabOptions.TabIndex = 8
        '
        '_tabOptions_TabPage0
        '
        Me._tabOptions_TabPage0.Controls.Add(Me.Frame1)
        Me._tabOptions_TabPage0.Controls.Add(Me.chkBeginFromArrivedLevel)
        Me._tabOptions_TabPage0.Location = New System.Drawing.Point(4, 22)
        Me._tabOptions_TabPage0.Name = "_tabOptions_TabPage0"
        Me._tabOptions_TabPage0.Size = New System.Drawing.Size(417, 313)
        Me._tabOptions_TabPage0.TabIndex = 0
        Me._tabOptions_TabPage0.Text = "&Ogólne"
        '
        'Frame1
        '
        Me.Frame1.BackColor = System.Drawing.SystemColors.Control
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
        'chkWantLevelRestartingAuthorization
        '
        Me.chkWantLevelRestartingAuthorization.BackColor = System.Drawing.SystemColors.Control
        Me.chkWantLevelRestartingAuthorization.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkWantLevelRestartingAuthorization.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkWantLevelRestartingAuthorization.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkWantLevelRestartingAuthorization.Location = New System.Drawing.Point(8, 43)
        Me.chkWantLevelRestartingAuthorization.Name = "chkWantLevelRestartingAuthorization"
        Me.chkWantLevelRestartingAuthorization.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkWantLevelRestartingAuthorization.Size = New System.Drawing.Size(303, 18)
        Me.chkWantLevelRestartingAuthorization.TabIndex = 14
        Me.chkWantLevelRestartingAuthorization.Tag = "OptionsDialog#10#Want Level Restarting Authorization"
        Me.chkWantLevelRestartingAuthorization.Text = "Pytaj o potwierdzenie &restartowania aktualnego etapu"
        Me.chkWantLevelRestartingAuthorization.UseVisualStyleBackColor = False
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
        Me.chkShowLevelLoadConfirmation.UseVisualStyleBackColor = False
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
        Me.chkBeginFromArrivedLevel.UseVisualStyleBackColor = False
        '
        '_tabOptions_TabPage2
        '
        Me._tabOptions_TabPage2.Controls.Add(Me.Frame8)
        Me._tabOptions_TabPage2.Location = New System.Drawing.Point(4, 22)
        Me._tabOptions_TabPage2.Name = "_tabOptions_TabPage2"
        Me._tabOptions_TabPage2.Size = New System.Drawing.Size(417, 313)
        Me._tabOptions_TabPage2.TabIndex = 2
        Me._tabOptions_TabPage2.Text = "&Gracze"
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
        Me.cmdPrevSet.UseVisualStyleBackColor = False
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
        Me.cmdNextSet.UseVisualStyleBackColor = False
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
        '_picOptions_3
        '
        Me._picOptions_3.BackColor = System.Drawing.SystemColors.Control
        Me._picOptions_3.Controls.Add(Me.fraSample4)
        Me._picOptions_3.Cursor = System.Windows.Forms.Cursors.Default
        Me._picOptions_3.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._picOptions_3.ForeColor = System.Drawing.SystemColors.ControlText
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
        'cmdOK
        '
        Me.cmdOK.BackColor = System.Drawing.SystemColors.Control
        Me.cmdOK.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdOK.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdOK.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdOK.Location = New System.Drawing.Point(82, 358)
        Me.cmdOK.Name = "cmdOK"
        Me.cmdOK.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdOK.Size = New System.Drawing.Size(73, 25)
        Me.cmdOK.TabIndex = 0
        Me.cmdOK.Tag = "Buttons#0"
        Me.cmdOK.Text = "&OK"
        Me.cmdOK.UseVisualStyleBackColor = False
        '
        'frmOptions
        '
        Me.AcceptButton = Me.cmdOK
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(445, 417)
        Me.ControlBox = False
        Me.Controls.Add(Me.tabOptions)
        Me.Controls.Add(Me._picOptions_3)
        Me.Controls.Add(Me._picOptions_2)
        Me.Controls.Add(Me._picOptions_1)
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
        Me.Frame1.ResumeLayout(False)
        Me._tabOptions_TabPage2.ResumeLayout(False)
        Me.Frame8.ResumeLayout(False)
        Me._picOptions_3.ResumeLayout(False)
        Me._picOptions_2.ResumeLayout(False)
        Me._picOptions_1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
#End Region
    Private Sub cmdNextSet_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdNextSet.Click
        cmdNextSet.Enabled = False
        cmdPrevSet.Enabled = True
        WyswietlStatystyki(2)
    End Sub

    Private Sub cmdOK_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdOK.Click
        Me.Close()
    End Sub

    Private Sub cmdPrevSet_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdPrevSet.Click
        cmdPrevSet.Enabled = False
        cmdNextSet.Enabled = True
        WyswietlStatystyki(1)
    End Sub

    Private Sub frmOptions_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
        tabOptions.SelectedIndex = 0

        cmdPrevSet.Enabled = False
        cmdNextSet.Enabled = True
        WyswietlStatystyki(1)

    End Sub

    'UPGRADE_WARNING: Event lstPlayers.SelectedIndexChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup2075"'
    Private Sub lstPlayers_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs)
        cmdPrevSet.Enabled = False
        cmdNextSet.Enabled = True
        WyswietlStatystyki(1)
    End Sub

    Public Sub WyswietlStatystyki(ByVal NrZestawu As Byte)
        Select Case NrZestawu
            Case 1
                lblLevelSet.Text = ZwrocCiag("OptionsDialog#25") & " " & UCase(ZwrocCiag("Sets#0"))

                lblArrivedLevel.Text = My.Settings.ArrivedLevelKlasyczne
                lblMoves.Text = My.Settings.MovesKlasyczne
                lblPushes.Text = My.Settings.PushesKlasyczne

            Case 2
                lblLevelSet.Text = ZwrocCiag("OptionsDialog#25") & " " & UCase(ZwrocCiag("Sets#1"))

                lblArrivedLevel.Text = My.Settings.ArrivedLevelSupertrudne
                lblMoves.Text = My.Settings.MovesSupertrudne
                lblPushes.Text = My.Settings.PushesSupertrudne

        End Select
    End Sub
End Class