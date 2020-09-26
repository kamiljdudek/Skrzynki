Option Strict Off
Option Explicit On
Friend Class frmTip
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
	Public WithEvents chkLoadTipsAtStartup As System.Windows.Forms.CheckBox
	Public WithEvents cmdNextTip As System.Windows.Forms.Button
	Public WithEvents lblTipText As System.Windows.Forms.Label
	Public WithEvents Picture1 As System.Windows.Forms.Panel
	Public WithEvents cmdOK As System.Windows.Forms.Button
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmTip))
		Me.components = New System.ComponentModel.Container()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(components)
		Me.ToolTip1.Active = True
		Me.chkLoadTipsAtStartup = New System.Windows.Forms.CheckBox
		Me.cmdNextTip = New System.Windows.Forms.Button
		Me.Picture1 = New System.Windows.Forms.Panel
		Me.lblTipText = New System.Windows.Forms.Label
		Me.cmdOK = New System.Windows.Forms.Button
		Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
		Me.Text = "Porada dnia"
		Me.ClientSize = New System.Drawing.Size(539, 219)
		Me.Location = New System.Drawing.Point(80, 176)
		Me.Icon = CType(resources.GetObject("frmTip.Icon"), System.Drawing.Icon)
		Me.MaximizeBox = False
		Me.MinimizeBox = False
		Me.ShowInTaskbar = False
		Me.Tag = "TipsDialog#2"
		Me.HelpButton = True
		Me.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
		Me.BackColor = System.Drawing.SystemColors.Control
		Me.ControlBox = True
		Me.Enabled = True
		Me.KeyPreview = False
		Me.Cursor = System.Windows.Forms.Cursors.Default
		Me.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.WindowState = System.Windows.Forms.FormWindowState.Normal
		Me.Name = "frmTip"
		Me.chkLoadTipsAtStartup.Text = "&Pokazuj porady przy starcie programu Skrzynki"
		Me.chkLoadTipsAtStartup.Size = New System.Drawing.Size(254, 21)
		Me.chkLoadTipsAtStartup.Location = New System.Drawing.Point(8, 194)
		Me.chkLoadTipsAtStartup.TabIndex = 3
		Me.chkLoadTipsAtStartup.Tag = "TipsDialog#1"
		Me.chkLoadTipsAtStartup.CheckState = System.Windows.Forms.CheckState.Checked
		Me.chkLoadTipsAtStartup.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.chkLoadTipsAtStartup.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.chkLoadTipsAtStartup.BackColor = System.Drawing.SystemColors.Control
		Me.chkLoadTipsAtStartup.CausesValidation = True
		Me.chkLoadTipsAtStartup.Enabled = True
		Me.chkLoadTipsAtStartup.ForeColor = System.Drawing.SystemColors.ControlText
		Me.chkLoadTipsAtStartup.Cursor = System.Windows.Forms.Cursors.Default
		Me.chkLoadTipsAtStartup.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.chkLoadTipsAtStartup.Appearance = System.Windows.Forms.Appearance.Normal
		Me.chkLoadTipsAtStartup.TabStop = True
		Me.chkLoadTipsAtStartup.Visible = True
		Me.chkLoadTipsAtStartup.Name = "chkLoadTipsAtStartup"
		Me.cmdNextTip.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cmdNextTip.Text = "&Nastêpna"
		Me.cmdNextTip.Size = New System.Drawing.Size(81, 25)
		Me.cmdNextTip.Location = New System.Drawing.Point(454, 40)
		Me.cmdNextTip.TabIndex = 2
		Me.cmdNextTip.Tag = "TipsDialog#0"
		Me.cmdNextTip.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdNextTip.BackColor = System.Drawing.SystemColors.Control
		Me.cmdNextTip.CausesValidation = True
		Me.cmdNextTip.Enabled = True
		Me.cmdNextTip.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdNextTip.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdNextTip.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdNextTip.TabStop = True
		Me.cmdNextTip.Name = "cmdNextTip"
		Me.Picture1.BackColor = System.Drawing.Color.White
		Me.Picture1.Size = New System.Drawing.Size(437, 181)
		Me.Picture1.Location = New System.Drawing.Point(8, 8)
		Me.Picture1.BackgroundImage = CType(resources.GetObject("Picture1.BackgroundImage"), System.Drawing.Image)
		Me.Picture1.TabIndex = 1
		Me.Picture1.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Picture1.Dock = System.Windows.Forms.DockStyle.None
		Me.Picture1.CausesValidation = True
		Me.Picture1.Enabled = True
		Me.Picture1.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Picture1.Cursor = System.Windows.Forms.Cursors.Default
		Me.Picture1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Picture1.TabStop = True
		Me.Picture1.Visible = True
		Me.Picture1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.Picture1.Name = "Picture1"
		Me.lblTipText.BackColor = System.Drawing.Color.White
		Me.lblTipText.Size = New System.Drawing.Size(386, 154)
		Me.lblTipText.Location = New System.Drawing.Point(30, 11)
		Me.lblTipText.TabIndex = 4
		Me.lblTipText.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblTipText.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblTipText.Enabled = True
		Me.lblTipText.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblTipText.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblTipText.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblTipText.UseMnemonic = True
		Me.lblTipText.Visible = True
		Me.lblTipText.AutoSize = False
		Me.lblTipText.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblTipText.Name = "lblTipText"
		Me.cmdOK.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.CancelButton = Me.cmdOK
		Me.cmdOK.Text = "OK"
		Me.AcceptButton = Me.cmdOK
		Me.cmdOK.Size = New System.Drawing.Size(81, 25)
		Me.cmdOK.Location = New System.Drawing.Point(454, 8)
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
		Me.Controls.Add(chkLoadTipsAtStartup)
		Me.Controls.Add(cmdNextTip)
		Me.Controls.Add(Picture1)
		Me.Controls.Add(cmdOK)
		Me.Picture1.Controls.Add(lblTipText)
	End Sub
#End Region 
#Region "Upgrade Support "
	Private Shared m_vb6FormDefInstance As frmTip
	Private Shared m_InitializingDefInstance As Boolean
	Public Shared Property DefInstance() As frmTip
		Get
			If m_vb6FormDefInstance Is Nothing OrElse m_vb6FormDefInstance.IsDisposed Then
				m_InitializingDefInstance = True
				m_vb6FormDefInstance = New frmTip()
				m_InitializingDefInstance = False
			End If
			DefInstance = m_vb6FormDefInstance
		End Get
		Set
			m_vb6FormDefInstance = Value
		End Set
	End Property
#End Region 
	
	' The in-memory database of tips.
	Dim Tips As New Collection
	
	' Name of tips file
	Const TIP_FILE As String = "INI\PORADY.INI"
	
	' Index in collection of tip currently being displayed.
	Dim CurrentTip As Integer
	Private Sub DoNextTip()
		
		' Select a tip at random.
		CurrentTip = Int((Tips.Count() * Rnd()) + 1)
		
		' Or, you could cycle through the Tips in order
		
		CurrentTip = CurrentTip + 1
		If Tips.Count() < CurrentTip Then
			CurrentTip = 1
		End If
		
		' Show it.
		frmTip.DefInstance.DisplayCurrentTip()
		
	End Sub
	Function LoadTips(ByRef sFile As String) As Boolean
		Dim NextTip As String ' Each tip read in from file.
		Dim InFile As Short ' Descriptor for file.
		
		' Obtain the next free file descriptor.
		InFile = FreeFile
		
		' Make sure a file is specified.
		If sFile = "" Then
			LoadTips = False
			Exit Function
		End If
		
		' Make sure the file exists before trying to open it.
		'UPGRADE_WARNING: Dir has a new behavior. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1041"'
		If Dir(sFile) = "" Then
			LoadTips = False
			Exit Function
		End If
		
		' Read the collection from a text file.
		FileOpen(InFile, sFile, OpenMode.Input)
		While Not EOF(InFile)
			NextTip = LineInput(InFile)
			Tips.Add(NextTip)
		End While
		FileClose(InFile)
		
		' Display a tip at random.
		DoNextTip()
		
		LoadTips = True
		
	End Function
	
	'UPGRADE_WARNING: Event chkLoadTipsAtStartup.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup2075"'
	Private Sub chkLoadTipsAtStartup_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles chkLoadTipsAtStartup.CheckStateChanged
		' save whether or not this form should be displayed at startup
		RegWartosc = RegSciezka & "\Options\Show Tips at Startup"
		RegDaneInt = chkLoadTipsAtStartup.CheckState
		'UPGRADE_WARNING: Couldn't resolve default property of object RegObj.Set. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
		RegObj.Set(RegWartosc, RegDaneInt, RegFlush)
	End Sub
	Private Sub cmdNextTip_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdNextTip.Click
		DoNextTip()
	End Sub
	Private Sub cmdOK_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdOK.Click
		Me.Hide()
	End Sub
	Private Sub frmTip_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
		Me.SetBounds(VB6.TwipsToPixelsX((VB6.PixelsToTwipsX(System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width) - VB6.PixelsToTwipsX(Me.Width)) / 2), VB6.TwipsToPixelsY((VB6.PixelsToTwipsY(System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height) - VB6.PixelsToTwipsY(Me.Height)) / 2), 0, 0, Windows.Forms.BoundsSpecified.X Or Windows.Forms.BoundsSpecified.Y)
		
		Dim ShowAtStartup As Integer
		
		' See if we should be shown at startup
		RegWartosc = RegSciezka & "\Options\Show Tips at Startup"
		'UPGRADE_WARNING: Couldn't resolve default property of object RegObj.Get. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
		ShowAtStartup = Val(RegObj.Get(RegWartosc))
		If ShowAtStartup = 0 Then
			Me.Hide()
			Exit Sub
		End If
		
		' Set the checkbox, this will force the value to be written back out to the registry
		Me.chkLoadTipsAtStartup.CheckState = System.Windows.Forms.CheckState.Checked
		
		' Seed Rnd
		Randomize()
		
		' Read in the tips file and display a tip at random.
		If LoadTips(VB6.GetPath & "\" & TIP_FILE) = False Then
			lblTipText.Text = "Plik " & TIP_FILE & " nie zosta³ znaleziony. " & vbCrLf & vbCrLf & "Zainstaluj ponownie program Skrzynki."
		End If
		
		
	End Sub
	
	Public Sub DisplayCurrentTip()
		If Tips.Count() > 0 Then
			'UPGRADE_WARNING: Couldn't resolve default property of object Tips.Item(). Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
			lblTipText.Text = Tips.Item(CurrentTip)
		End If
	End Sub
End Class