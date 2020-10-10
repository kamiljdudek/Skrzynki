Option Strict Off
Option Explicit On
Friend Class FrmOptions
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
    Public WithEvents ChkWantLevelRestartingAuthorization As System.Windows.Forms.CheckBox
    Public WithEvents ChkShowLevelLoadConfirmation As System.Windows.Forms.CheckBox
    Public WithEvents Frame1 As System.Windows.Forms.GroupBox
    Public WithEvents ChkBeginFromArrivedLevel As System.Windows.Forms.CheckBox
    Public WithEvents _tabOptions_TabPage0 As System.Windows.Forms.TabPage
    Public WithEvents CmdPrevSet As System.Windows.Forms.Button
    Public WithEvents CmdNextSet As System.Windows.Forms.Button
    Public WithEvents LblPushes As System.Windows.Forms.Label
    Public WithEvents LblMoves As System.Windows.Forms.Label
    Public WithEvents LblArrivedLevel As System.Windows.Forms.Label
    Public WithEvents Label8 As System.Windows.Forms.Label
    Public WithEvents Label7 As System.Windows.Forms.Label
    Public WithEvents Label6 As System.Windows.Forms.Label
    Public WithEvents LblLevelSet As System.Windows.Forms.Label
    Public WithEvents Frame8 As System.Windows.Forms.GroupBox
    Public WithEvents _tabOptions_TabPage2 As System.Windows.Forms.TabPage
    Public WithEvents TabOptions As System.Windows.Forms.TabControl
    Public WithEvents FraSample4 As System.Windows.Forms.GroupBox
    Public WithEvents _picOptions_3 As System.Windows.Forms.Panel
    Public WithEvents FraSample3 As System.Windows.Forms.GroupBox
    Public WithEvents _picOptions_2 As System.Windows.Forms.Panel
    Public WithEvents FraSample2 As System.Windows.Forms.GroupBox
    Public WithEvents _picOptions_1 As System.Windows.Forms.Panel
    Public WithEvents CmdOK As System.Windows.Forms.Button
    'Public WithEvents picOptions As Microsoft.VisualBasic.Compatibility.VB6.PanelArray
    'Public WithEvents picPreview As Microsoft.VisualBasic.Compatibility.VB6.PictureBoxArray
    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.TabOptions = New System.Windows.Forms.TabControl()
        Me._tabOptions_TabPage0 = New System.Windows.Forms.TabPage()
        Me.Frame1 = New System.Windows.Forms.GroupBox()
        Me.ChkWantLevelRestartingAuthorization = New System.Windows.Forms.CheckBox()
        Me.ChkShowLevelLoadConfirmation = New System.Windows.Forms.CheckBox()
        Me.ChkBeginFromArrivedLevel = New System.Windows.Forms.CheckBox()
        Me._tabOptions_TabPage2 = New System.Windows.Forms.TabPage()
        Me.Frame8 = New System.Windows.Forms.GroupBox()
        Me.CmdPrevSet = New System.Windows.Forms.Button()
        Me.CmdNextSet = New System.Windows.Forms.Button()
        Me.LblPushes = New System.Windows.Forms.Label()
        Me.LblMoves = New System.Windows.Forms.Label()
        Me.LblArrivedLevel = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.LblLevelSet = New System.Windows.Forms.Label()
        Me._picOptions_3 = New System.Windows.Forms.Panel()
        Me.FraSample4 = New System.Windows.Forms.GroupBox()
        Me._picOptions_2 = New System.Windows.Forms.Panel()
        Me.FraSample3 = New System.Windows.Forms.GroupBox()
        Me._picOptions_1 = New System.Windows.Forms.Panel()
        Me.FraSample2 = New System.Windows.Forms.GroupBox()
        Me.CmdOK = New System.Windows.Forms.Button()
        Me.TabOptions.SuspendLayout()
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
        Me.TabOptions.Appearance = System.Windows.Forms.TabAppearance.FlatButtons
        Me.TabOptions.Controls.Add(Me._tabOptions_TabPage0)
        Me.TabOptions.Controls.Add(Me._tabOptions_TabPage2)
        Me.TabOptions.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabOptions.ItemSize = New System.Drawing.Size(42, 18)
        Me.TabOptions.Location = New System.Drawing.Point(8, 4)
        Me.TabOptions.Name = "tabOptions"
        Me.TabOptions.SelectedIndex = 0
        Me.TabOptions.Size = New System.Drawing.Size(425, 339)
        Me.TabOptions.TabIndex = 8
        '
        '_tabOptions_TabPage0
        '
        Me._tabOptions_TabPage0.Controls.Add(Me.Frame1)
        Me._tabOptions_TabPage0.Controls.Add(Me.ChkBeginFromArrivedLevel)
        Me._tabOptions_TabPage0.Location = New System.Drawing.Point(4, 22)
        Me._tabOptions_TabPage0.Name = "_tabOptions_TabPage0"
        Me._tabOptions_TabPage0.Size = New System.Drawing.Size(417, 313)
        Me._tabOptions_TabPage0.TabIndex = 0
        Me._tabOptions_TabPage0.Text = "&Ogólne"
        '
        'Frame1
        '
        Me.Frame1.BackColor = System.Drawing.SystemColors.Control
        Me.Frame1.Controls.Add(Me.ChkWantLevelRestartingAuthorization)
        Me.Frame1.Controls.Add(Me.ChkShowLevelLoadConfirmation)
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
        Me.ChkWantLevelRestartingAuthorization.BackColor = System.Drawing.SystemColors.Control
        Me.ChkWantLevelRestartingAuthorization.Cursor = System.Windows.Forms.Cursors.Default
        Me.ChkWantLevelRestartingAuthorization.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkWantLevelRestartingAuthorization.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ChkWantLevelRestartingAuthorization.Location = New System.Drawing.Point(8, 43)
        Me.ChkWantLevelRestartingAuthorization.Name = "chkWantLevelRestartingAuthorization"
        Me.ChkWantLevelRestartingAuthorization.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ChkWantLevelRestartingAuthorization.Size = New System.Drawing.Size(303, 18)
        Me.ChkWantLevelRestartingAuthorization.TabIndex = 14
        Me.ChkWantLevelRestartingAuthorization.Tag = "OptionsDialog#10#Want Level Restarting Authorization"
        Me.ChkWantLevelRestartingAuthorization.Text = "Pytaj o potwierdzenie &restartowania aktualnego etapu"
        Me.ChkWantLevelRestartingAuthorization.UseVisualStyleBackColor = False
        '
        'chkShowLevelLoadConfirmation
        '
        Me.ChkShowLevelLoadConfirmation.BackColor = System.Drawing.SystemColors.Control
        Me.ChkShowLevelLoadConfirmation.Cursor = System.Windows.Forms.Cursors.Default
        Me.ChkShowLevelLoadConfirmation.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkShowLevelLoadConfirmation.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ChkShowLevelLoadConfirmation.Location = New System.Drawing.Point(8, 68)
        Me.ChkShowLevelLoadConfirmation.Name = "chkShowLevelLoadConfirmation"
        Me.ChkShowLevelLoadConfirmation.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ChkShowLevelLoadConfirmation.Size = New System.Drawing.Size(314, 18)
        Me.ChkShowLevelLoadConfirmation.TabIndex = 13
        Me.ChkShowLevelLoadConfirmation.Tag = "OptionsDialog#11#Show Level Load Confirmation"
        Me.ChkShowLevelLoadConfirmation.Text = "Wyœwietlaj potwierdzenie &wczytania etapu"
        Me.ChkShowLevelLoadConfirmation.UseVisualStyleBackColor = False
        '
        'chkBeginFromArrivedLevel
        '
        Me.ChkBeginFromArrivedLevel.BackColor = System.Drawing.SystemColors.Control
        Me.ChkBeginFromArrivedLevel.Cursor = System.Windows.Forms.Cursors.Default
        Me.ChkBeginFromArrivedLevel.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkBeginFromArrivedLevel.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ChkBeginFromArrivedLevel.Location = New System.Drawing.Point(14, 227)
        Me.ChkBeginFromArrivedLevel.Name = "chkBeginFromArrivedLevel"
        Me.ChkBeginFromArrivedLevel.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ChkBeginFromArrivedLevel.Size = New System.Drawing.Size(326, 19)
        Me.ChkBeginFromArrivedLevel.TabIndex = 16
        Me.ChkBeginFromArrivedLevel.Tag = "OptionsDialog#12#Begin From Arrived Level"
        Me.ChkBeginFromArrivedLevel.Text = "Przy uruchomieniu programu wyœwietlaj najdalszy dostêpny &etap"
        Me.ChkBeginFromArrivedLevel.UseVisualStyleBackColor = False
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
        Me.Frame8.Controls.Add(Me.CmdPrevSet)
        Me.Frame8.Controls.Add(Me.CmdNextSet)
        Me.Frame8.Controls.Add(Me.LblPushes)
        Me.Frame8.Controls.Add(Me.LblMoves)
        Me.Frame8.Controls.Add(Me.LblArrivedLevel)
        Me.Frame8.Controls.Add(Me.Label8)
        Me.Frame8.Controls.Add(Me.Label7)
        Me.Frame8.Controls.Add(Me.Label6)
        Me.Frame8.Controls.Add(Me.LblLevelSet)
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
        Me.CmdPrevSet.BackColor = System.Drawing.SystemColors.Control
        Me.CmdPrevSet.Cursor = System.Windows.Forms.Cursors.Default
        Me.CmdPrevSet.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdPrevSet.ForeColor = System.Drawing.SystemColors.ControlText
        Me.CmdPrevSet.Location = New System.Drawing.Point(4, 108)
        Me.CmdPrevSet.Name = "cmdPrevSet"
        Me.CmdPrevSet.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CmdPrevSet.Size = New System.Drawing.Size(25, 21)
        Me.CmdPrevSet.TabIndex = 48
        Me.CmdPrevSet.Text = "<-"
        Me.CmdPrevSet.UseVisualStyleBackColor = False
        '
        'cmdNextSet
        '
        Me.CmdNextSet.BackColor = System.Drawing.SystemColors.Control
        Me.CmdNextSet.Cursor = System.Windows.Forms.Cursors.Default
        Me.CmdNextSet.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdNextSet.ForeColor = System.Drawing.SystemColors.ControlText
        Me.CmdNextSet.Location = New System.Drawing.Point(220, 108)
        Me.CmdNextSet.Name = "cmdNextSet"
        Me.CmdNextSet.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CmdNextSet.Size = New System.Drawing.Size(25, 21)
        Me.CmdNextSet.TabIndex = 47
        Me.CmdNextSet.Text = "->"
        Me.CmdNextSet.UseVisualStyleBackColor = False
        '
        'lblPushes
        '
        Me.LblPushes.BackColor = System.Drawing.SystemColors.Control
        Me.LblPushes.Cursor = System.Windows.Forms.Cursors.Default
        Me.LblPushes.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPushes.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LblPushes.Location = New System.Drawing.Point(132, 84)
        Me.LblPushes.Name = "lblPushes"
        Me.LblPushes.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.LblPushes.Size = New System.Drawing.Size(109, 13)
        Me.LblPushes.TabIndex = 51
        Me.LblPushes.Text = "#Pchniêcia#"
        Me.LblPushes.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblMoves
        '
        Me.LblMoves.BackColor = System.Drawing.SystemColors.Control
        Me.LblMoves.Cursor = System.Windows.Forms.Cursors.Default
        Me.LblMoves.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblMoves.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LblMoves.Location = New System.Drawing.Point(128, 64)
        Me.LblMoves.Name = "lblMoves"
        Me.LblMoves.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.LblMoves.Size = New System.Drawing.Size(113, 13)
        Me.LblMoves.TabIndex = 50
        Me.LblMoves.Text = "#Ruchy#"
        Me.LblMoves.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblArrivedLevel
        '
        Me.LblArrivedLevel.BackColor = System.Drawing.SystemColors.Control
        Me.LblArrivedLevel.Cursor = System.Windows.Forms.Cursors.Default
        Me.LblArrivedLevel.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblArrivedLevel.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LblArrivedLevel.Location = New System.Drawing.Point(128, 44)
        Me.LblArrivedLevel.Name = "lblArrivedLevel"
        Me.LblArrivedLevel.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.LblArrivedLevel.Size = New System.Drawing.Size(113, 13)
        Me.LblArrivedLevel.TabIndex = 49
        Me.LblArrivedLevel.Text = "#Osi¹gniêty Etap#"
        Me.LblArrivedLevel.TextAlign = System.Drawing.ContentAlignment.TopRight
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
        Me.LblLevelSet.BackColor = System.Drawing.SystemColors.Control
        Me.LblLevelSet.Cursor = System.Windows.Forms.Cursors.Default
        Me.LblLevelSet.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.LblLevelSet.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LblLevelSet.Location = New System.Drawing.Point(8, 24)
        Me.LblLevelSet.Name = "lblLevelSet"
        Me.LblLevelSet.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.LblLevelSet.Size = New System.Drawing.Size(221, 17)
        Me.LblLevelSet.TabIndex = 43
        Me.LblLevelSet.Text = "#Zestaw Etapów#"
        '
        '_picOptions_3
        '
        Me._picOptions_3.BackColor = System.Drawing.SystemColors.Control
        Me._picOptions_3.Controls.Add(Me.FraSample4)
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
        Me.FraSample4.BackColor = System.Drawing.SystemColors.Control
        Me.FraSample4.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FraSample4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.FraSample4.Location = New System.Drawing.Point(140, 56)
        Me.FraSample4.Name = "fraSample4"
        Me.FraSample4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.FraSample4.Size = New System.Drawing.Size(137, 119)
        Me.FraSample4.TabIndex = 7
        Me.FraSample4.TabStop = False
        Me.FraSample4.Text = "Sample 4"
        '
        '_picOptions_2
        '
        Me._picOptions_2.BackColor = System.Drawing.SystemColors.Control
        Me._picOptions_2.Controls.Add(Me.FraSample3)
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
        Me.FraSample3.BackColor = System.Drawing.SystemColors.Control
        Me.FraSample3.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FraSample3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.FraSample3.Location = New System.Drawing.Point(103, 45)
        Me.FraSample3.Name = "fraSample3"
        Me.FraSample3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.FraSample3.Size = New System.Drawing.Size(137, 119)
        Me.FraSample3.TabIndex = 6
        Me.FraSample3.TabStop = False
        Me.FraSample3.Text = "Sample 3"
        '
        '_picOptions_1
        '
        Me._picOptions_1.BackColor = System.Drawing.SystemColors.Control
        Me._picOptions_1.Controls.Add(Me.FraSample2)
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
        Me.FraSample2.BackColor = System.Drawing.SystemColors.Control
        Me.FraSample2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FraSample2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.FraSample2.Location = New System.Drawing.Point(43, 20)
        Me.FraSample2.Name = "fraSample2"
        Me.FraSample2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.FraSample2.Size = New System.Drawing.Size(137, 119)
        Me.FraSample2.TabIndex = 5
        Me.FraSample2.TabStop = False
        Me.FraSample2.Text = "Sample 2"
        '
        'cmdOK
        '
        Me.CmdOK.BackColor = System.Drawing.SystemColors.Control
        Me.CmdOK.Cursor = System.Windows.Forms.Cursors.Default
        Me.CmdOK.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdOK.ForeColor = System.Drawing.SystemColors.ControlText
        Me.CmdOK.Location = New System.Drawing.Point(82, 358)
        Me.CmdOK.Name = "cmdOK"
        Me.CmdOK.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CmdOK.Size = New System.Drawing.Size(73, 25)
        Me.CmdOK.TabIndex = 0
        Me.CmdOK.Tag = "Buttons#0"
        Me.CmdOK.Text = "&OK"
        Me.CmdOK.UseVisualStyleBackColor = False
        '
        'frmOptions
        '
        Me.AcceptButton = Me.CmdOK
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(445, 417)
        Me.ControlBox = False
        Me.Controls.Add(Me.TabOptions)
        Me.Controls.Add(Me._picOptions_3)
        Me.Controls.Add(Me._picOptions_2)
        Me.Controls.Add(Me._picOptions_1)
        Me.Controls.Add(Me.CmdOK)
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
        Me.TabOptions.ResumeLayout(False)
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
    Private Sub CmdNextSet_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles CmdNextSet.Click
        CmdNextSet.Enabled = False
        CmdPrevSet.Enabled = True
        WyswietlStatystyki(2)
    End Sub

    Private Sub CmdOK_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles CmdOK.Click
        Me.Close()
    End Sub

    Private Sub CmdPrevSet_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles CmdPrevSet.Click
        CmdPrevSet.Enabled = False
        CmdNextSet.Enabled = True
        WyswietlStatystyki(1)
    End Sub

    Private Sub FrmOptions_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
        TabOptions.SelectedIndex = 0

        CmdPrevSet.Enabled = False
        CmdNextSet.Enabled = True
        WyswietlStatystyki(1)

    End Sub

    'UPGRADE_WARNING: Event lstPlayers.SelectedIndexChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup2075"'
    Private Sub LstPlayers_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs)
        CmdPrevSet.Enabled = False
        CmdNextSet.Enabled = True
        WyswietlStatystyki(1)
    End Sub

    Public Sub WyswietlStatystyki(ByVal NrZestawu As Byte)
        Select Case NrZestawu
            Case 1
                LblLevelSet.Text = ZwrocCiag("OptionsDialog#25") & " " & UCase(ZwrocCiag("Sets#0"))

                LblArrivedLevel.Text = My.Settings.ArrivedLevelKlasyczne
                LblMoves.Text = My.Settings.MovesKlasyczne
                LblPushes.Text = My.Settings.PushesKlasyczne

            Case 2
                LblLevelSet.Text = ZwrocCiag("OptionsDialog#25") & " " & UCase(ZwrocCiag("Sets#1"))

                LblArrivedLevel.Text = My.Settings.ArrivedLevelSupertrudne
                LblMoves.Text = My.Settings.MovesSupertrudne
                LblPushes.Text = My.Settings.PushesSupertrudne

        End Select
    End Sub
End Class