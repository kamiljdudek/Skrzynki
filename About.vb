Option Strict Off
Option Explicit On
Imports VB = Microsoft.VisualBasic
Friend Class frmAbout
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
	Public WithEvents picIcon As System.Windows.Forms.PictureBox
	Public WithEvents cmdOK As System.Windows.Forms.Button
	Public WithEvents cmdSysInfo As System.Windows.Forms.Button
	Public WithEvents lblTitle As System.Windows.Forms.Label
	Public WithEvents _Line1_1 As System.Windows.Forms.Label
	Public WithEvents lblDescription As System.Windows.Forms.Label
	Public WithEvents _Line1_0 As System.Windows.Forms.Label
	Public WithEvents lblVersion As System.Windows.Forms.Label
	Public WithEvents Line1 As Microsoft.VisualBasic.Compatibility.VB6.LabelArray
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmAbout))
		Me.components = New System.ComponentModel.Container()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(components)
		Me.ToolTip1.Active = True
		Me.picIcon = New System.Windows.Forms.PictureBox
		Me.cmdOK = New System.Windows.Forms.Button
		Me.cmdSysInfo = New System.Windows.Forms.Button
		Me.lblTitle = New System.Windows.Forms.Label
		Me._Line1_1 = New System.Windows.Forms.Label
		Me.lblDescription = New System.Windows.Forms.Label
		Me._Line1_0 = New System.Windows.Forms.Label
		Me.lblVersion = New System.Windows.Forms.Label
		Me.Line1 = New Microsoft.VisualBasic.Compatibility.VB6.LabelArray(components)
		CType(Me.Line1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
		Me.Text = "Skrzynki - informacje"
		Me.ClientSize = New System.Drawing.Size(403, 237)
		Me.Location = New System.Drawing.Point(156, 129)
		Me.ControlBox = False
		Me.MaximizeBox = False
		Me.MinimizeBox = False
		Me.ShowInTaskbar = False
		Me.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
		Me.BackColor = System.Drawing.SystemColors.Control
		Me.Enabled = True
		Me.KeyPreview = False
		Me.Cursor = System.Windows.Forms.Cursors.Default
		Me.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.HelpButton = False
		Me.WindowState = System.Windows.Forms.FormWindowState.Normal
		Me.Name = "frmAbout"
		Me.picIcon.Size = New System.Drawing.Size(104, 104)
		Me.picIcon.Location = New System.Drawing.Point(11, 16)
		Me.picIcon.TabIndex = 1
		Me.picIcon.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.picIcon.Dock = System.Windows.Forms.DockStyle.None
		Me.picIcon.BackColor = System.Drawing.SystemColors.Control
		Me.picIcon.CausesValidation = True
		Me.picIcon.Enabled = True
		Me.picIcon.ForeColor = System.Drawing.SystemColors.ControlText
		Me.picIcon.Cursor = System.Windows.Forms.Cursors.Default
		Me.picIcon.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.picIcon.TabStop = True
		Me.picIcon.Visible = True
		Me.picIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
		Me.picIcon.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.picIcon.Name = "picIcon"
		Me.cmdOK.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.CancelButton = Me.cmdOK
		Me.cmdOK.Text = "&OK"
		Me.AcceptButton = Me.cmdOK
		Me.cmdOK.Size = New System.Drawing.Size(350, 23)
		Me.cmdOK.Location = New System.Drawing.Point(25, 175)
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
		Me.cmdSysInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cmdSysInfo.Text = "&Informacje o systemie..."
		Me.cmdSysInfo.Size = New System.Drawing.Size(351, 23)
		Me.cmdSysInfo.Location = New System.Drawing.Point(25, 205)
		Me.cmdSysInfo.TabIndex = 2
		Me.cmdSysInfo.Tag = "AboutDialog#3"
		Me.cmdSysInfo.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdSysInfo.BackColor = System.Drawing.SystemColors.Control
		Me.cmdSysInfo.CausesValidation = True
		Me.cmdSysInfo.Enabled = True
		Me.cmdSysInfo.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdSysInfo.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdSysInfo.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdSysInfo.TabStop = True
		Me.cmdSysInfo.Name = "cmdSysInfo"
		Me.lblTitle.Text = "Skrzynki"
		Me.lblTitle.Font = New System.Drawing.Font("Arial", 24!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
		Me.lblTitle.ForeColor = System.Drawing.SystemColors.Highlight
		Me.lblTitle.Size = New System.Drawing.Size(261, 37)
		Me.lblTitle.Location = New System.Drawing.Point(116, 16)
		Me.lblTitle.TabIndex = 5
		Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblTitle.BackColor = System.Drawing.SystemColors.Control
		Me.lblTitle.Enabled = True
		Me.lblTitle.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblTitle.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblTitle.UseMnemonic = True
		Me.lblTitle.Visible = True
		Me.lblTitle.AutoSize = False
		Me.lblTitle.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblTitle.Name = "lblTitle"
		Me._Line1_1.BackColor = System.Drawing.Color.FromARGB(128, 128, 128)
		Me._Line1_1.Visible = True
		Me._Line1_1.Location = New System.Drawing.Point(11, 147)
		Me._Line1_1.Width = 288
		Me._Line1_1.Height = 1
		Me._Line1_1.Name = "_Line1_1"
		Me.lblDescription.Text = "App Description"
		Me.lblDescription.ForeColor = System.Drawing.Color.Black
		Me.lblDescription.Size = New System.Drawing.Size(259, 78)
		Me.lblDescription.Location = New System.Drawing.Point(118, 82)
		Me.lblDescription.TabIndex = 3
		Me.lblDescription.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblDescription.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblDescription.BackColor = System.Drawing.SystemColors.Control
		Me.lblDescription.Enabled = True
		Me.lblDescription.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblDescription.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblDescription.UseMnemonic = True
		Me.lblDescription.Visible = True
		Me.lblDescription.AutoSize = False
		Me.lblDescription.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblDescription.Name = "lblDescription"
		Me._Line1_0.BackColor = System.Drawing.Color.White
		Me._Line1_0.Visible = True
		Me._Line1_0.Location = New System.Drawing.Point(12, 148)
		Me._Line1_0.Width = 287
		Me._Line1_0.Height = 1
		Me._Line1_0.Name = "_Line1_0"
		Me.lblVersion.Text = "Wersja"
		Me.lblVersion.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
		Me.lblVersion.Size = New System.Drawing.Size(259, 15)
		Me.lblVersion.Location = New System.Drawing.Point(119, 59)
		Me.lblVersion.TabIndex = 4
		Me.lblVersion.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblVersion.BackColor = System.Drawing.SystemColors.Control
		Me.lblVersion.Enabled = True
		Me.lblVersion.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblVersion.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblVersion.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblVersion.UseMnemonic = True
		Me.lblVersion.Visible = True
		Me.lblVersion.AutoSize = False
		Me.lblVersion.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblVersion.Name = "lblVersion"
		Me.Controls.Add(picIcon)
		Me.Controls.Add(cmdOK)
		Me.Controls.Add(cmdSysInfo)
		Me.Controls.Add(lblTitle)
		Me.Controls.Add(_Line1_1)
		Me.Controls.Add(lblDescription)
		Me.Controls.Add(_Line1_0)
		Me.Controls.Add(lblVersion)
		Me.Line1.SetIndex(_Line1_1, CType(1, Short))
		Me.Line1.SetIndex(_Line1_0, CType(0, Short))
		CType(Me.Line1, System.ComponentModel.ISupportInitialize).EndInit()
	End Sub
#End Region 
#Region "Upgrade Support "
	Private Shared m_vb6FormDefInstance As frmAbout
	Private Shared m_InitializingDefInstance As Boolean
	Public Shared Property DefInstance() As frmAbout
		Get
			If m_vb6FormDefInstance Is Nothing OrElse m_vb6FormDefInstance.IsDisposed Then
				m_InitializingDefInstance = True
				m_vb6FormDefInstance = New frmAbout()
				m_InitializingDefInstance = False
			End If
			DefInstance = m_vb6FormDefInstance
		End Get
		Set
			m_vb6FormDefInstance = Value
		End Set
	End Property
#End Region 
	
	' Reg Key Security Options...
	Const READ_CONTROL As Integer = &H20000
	Const KEY_QUERY_VALUE As Short = &H1s
	Const KEY_SET_VALUE As Short = &H2s
	Const KEY_CREATE_SUB_KEY As Short = &H4s
	Const KEY_ENUMERATE_SUB_KEYS As Short = &H8s
	Const KEY_NOTIFY As Short = &H10s
	Const KEY_CREATE_LINK As Short = &H20s
	Const KEY_ALL_ACCESS As Double = KEY_QUERY_VALUE + KEY_SET_VALUE + KEY_CREATE_SUB_KEY + KEY_ENUMERATE_SUB_KEYS + KEY_NOTIFY + KEY_CREATE_LINK + READ_CONTROL
	
	' Reg Key ROOT Types...
	Const HKEY_LOCAL_MACHINE As Integer = &H80000002
	Const ERROR_SUCCESS As Short = 0
	Const REG_SZ As Short = 1 ' Unicode nul terminated string
	Const REG_DWORD As Short = 4 ' 32-bit number
	
	Const gREGKEYSYSINFOLOC As String = "SOFTWARE\Microsoft\Shared Tools Location"
	Const gREGVALSYSINFOLOC As String = "MSINFO"
	Const gREGKEYSYSINFO As String = "SOFTWARE\Microsoft\Shared Tools\MSINFO"
	Const gREGVALSYSINFO As String = "PATH"
	
	Private Declare Function RegOpenKeyEx Lib "advapi32"  Alias "RegOpenKeyExA"(ByVal hKey As Integer, ByVal lpSubKey As String, ByVal ulOptions As Integer, ByVal samDesired As Integer, ByRef phkResult As Integer) As Integer
	Private Declare Function RegQueryValueEx Lib "advapi32"  Alias "RegQueryValueExA"(ByVal hKey As Integer, ByVal lpValueName As String, ByVal lpReserved As Integer, ByRef lpType As Integer, ByVal lpData As String, ByRef lpcbData As Integer) As Integer
	Private Declare Function RegCloseKey Lib "advapi32" (ByVal hKey As Integer) As Integer
	Private Sub cmdSysInfo_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdSysInfo.Click
		Call StartSysInfo()
	End Sub
	Private Sub cmdOK_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdOK.Click
		Me.Close()
	End Sub
	Private Sub frmAbout_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
		Me.SetBounds(VB6.TwipsToPixelsX((VB6.PixelsToTwipsX(System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width) - VB6.PixelsToTwipsX(Me.Width)) / 2), VB6.TwipsToPixelsY((VB6.PixelsToTwipsY(System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height) - VB6.PixelsToTwipsY(Me.Height)) / 2), 0, 0, Windows.Forms.BoundsSpecified.X Or Windows.Forms.BoundsSpecified.Y)
		Me.Text = System.Reflection.Assembly.GetExecutingAssembly.GetName.Name & ZwrocCiag("AboutDialog#0")
		lblTitle.Text = System.Reflection.Assembly.GetExecutingAssembly.GetName.Name
		'UPGRADE_ISSUE: App property App.Revision was not upgraded. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup2069"'
        lblVersion.Text = ZwrocCiag("AboutDialog#1") & System.Diagnostics.FileVersionInfo.GetVersionInfo(System.Reflection.Assembly.GetExecutingAssembly.Location).FileMajorPart & "." & System.Diagnostics.FileVersionInfo.GetVersionInfo(System.Reflection.Assembly.GetExecutingAssembly.Location).FileMinorPart & "."
		lblDescription.Text = "(c) 2001 - 2002, Karol Kuczmarski" & Chr(10) & ZwrocCiag("AboutDialog#4") & Chr(10) & ZwrocCiag("AboutDialog#2")
		picIcon.Image = VB6.LoadResPicture(201, VB6.LoadResConstants.ResBitmap)
	End Sub
	Public Sub StartSysInfo()
		On Error GoTo SysInfoErr
		
		Dim rc As Integer
		Dim SysInfoPath As String
		
		' Try To Get System Info Program Path\Name From Registry...
		If GetKeyValue(HKEY_LOCAL_MACHINE, gREGKEYSYSINFO, gREGVALSYSINFO, SysInfoPath) Then
			' Try To Get System Info Program Path Only From Registry...
		ElseIf GetKeyValue(HKEY_LOCAL_MACHINE, gREGKEYSYSINFOLOC, gREGVALSYSINFOLOC, SysInfoPath) Then 
			' Validate Existance Of Known 32 Bit File Version
			'UPGRADE_WARNING: Dir has a new behavior. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1041"'
			If (Dir(SysInfoPath & "\MSINFO32.EXE") <> "") Then
				SysInfoPath = SysInfoPath & "\MSINFO32.EXE"
				
				' Error - File Can Not Be Found...
			Else
				GoTo SysInfoErr
			End If
			' Error - Registry Entry Can Not Be Found...
		Else
			GoTo SysInfoErr
		End If
		
		Call Shell(SysInfoPath, AppWinStyle.NormalFocus)
		
		Exit Sub
SysInfoErr: 
		MsgBox("Informacje o systemie nie s¹ dostêpne.", MsgBoxStyle.OKOnly + MsgBoxStyle.Critical + MsgBoxStyle.ApplicationModal)
	End Sub
	
	Public Function GetKeyValue(ByRef KeyRoot As Integer, ByRef KeyName As String, ByRef SubKeyRef As String, ByRef KeyVal As String) As Boolean
		Dim i As Integer ' Loop Counter
		Dim rc As Integer ' Return Code
		Dim hKey As Integer ' Handle To An Open Registry Key
		Dim hDepth As Integer '
		Dim KeyValType As Integer ' Data Type Of A Registry Key
		Dim tmpVal As String ' Tempory Storage For A Registry Key Value
		Dim KeyValSize As Integer ' Size Of Registry Key Variable
		'------------------------------------------------------------
		' Open RegKey Under KeyRoot {HKEY_LOCAL_MACHINE...}
		'------------------------------------------------------------
		rc = RegOpenKeyEx(KeyRoot, KeyName, 0, KEY_ALL_ACCESS, hKey) ' Open Registry Key
		
		If (rc <> ERROR_SUCCESS) Then GoTo GetKeyError ' Handle Error...
		
		tmpVal = New String(Chr(0), 1024) ' Allocate Variable Space
		KeyValSize = 1024 ' Mark Variable Size
		
		'------------------------------------------------------------
		' Retrieve Registry Key Value...
		'------------------------------------------------------------
		rc = RegQueryValueEx(hKey, SubKeyRef, 0, KeyValType, tmpVal, KeyValSize) ' Get/Create Key Value
		
		If (rc <> ERROR_SUCCESS) Then GoTo GetKeyError ' Handle Errors
		
		If (Asc(Mid(tmpVal, KeyValSize, 1)) = 0) Then ' Win95 Adds Null Terminated String...
			tmpVal = VB.Left(tmpVal, KeyValSize - 1) ' Null Found, Extract From String
		Else ' WinNT Does NOT Null Terminate String...
			tmpVal = VB.Left(tmpVal, KeyValSize) ' Null Not Found, Extract String Only
		End If
		'------------------------------------------------------------
		' Determine Key Value Type For Conversion...
		'------------------------------------------------------------
		Select Case KeyValType ' Search Data Types...
			Case REG_SZ ' String Registry Key Data Type
				KeyVal = tmpVal ' Copy String Value
			Case REG_DWORD ' Double Word Registry Key Data Type
				For i = Len(tmpVal) To 1 Step -1 ' Convert Each Bit
					KeyVal = KeyVal & Hex(Asc(Mid(tmpVal, i, 1))) ' Build Value Char. By Char.
				Next 
				KeyVal = VB6.Format("&h" & KeyVal) ' Convert Double Word To String
		End Select
		
		GetKeyValue = True ' Return Success
		rc = RegCloseKey(hKey) ' Close Registry Key
		Exit Function ' Exit
		
GetKeyError: ' Cleanup After An Error Has Occured...
		KeyVal = "" ' Set Return Val To Empty String
		GetKeyValue = False ' Return Failure
		rc = RegCloseKey(hKey) ' Close Registry Key
	End Function
End Class