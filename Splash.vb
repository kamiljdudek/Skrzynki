Option Strict Off
Option Explicit On
Friend Class frmSplash
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
	Public WithEvents tmrTimer As System.Windows.Forms.Timer
	Public WithEvents imgTitle As System.Windows.Forms.PictureBox
	Public WithEvents lblPlatform As System.Windows.Forms.Label
	Public WithEvents lblVersion As System.Windows.Forms.Label
	Public WithEvents lblCopyright As System.Windows.Forms.Label
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmSplash))
		Me.components = New System.ComponentModel.Container()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(components)
		Me.ToolTip1.Active = True
		Me.tmrTimer = New System.Windows.Forms.Timer(components)
		Me.imgTitle = New System.Windows.Forms.PictureBox
		Me.lblPlatform = New System.Windows.Forms.Label
		Me.lblVersion = New System.Windows.Forms.Label
		Me.lblCopyright = New System.Windows.Forms.Label
		Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
		Me.ControlBox = False
		Me.BackColor = System.Drawing.SystemColors.ActiveBorder
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
		Me.ClientSize = New System.Drawing.Size(401, 248)
		Me.Location = New System.Drawing.Point(162, 227)
		Me.KeyPreview = True
		Me.MaximizeBox = False
		Me.MinimizeBox = False
		Me.ShowInTaskbar = False
		Me.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
		Me.Enabled = True
		Me.Cursor = System.Windows.Forms.Cursors.Default
		Me.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.HelpButton = False
		Me.WindowState = System.Windows.Forms.FormWindowState.Normal
		Me.Name = "frmSplash"
		Me.tmrTimer.Interval = 2000
		Me.tmrTimer.Enabled = True
		Me.imgTitle.Size = New System.Drawing.Size(288, 61)
		Me.imgTitle.Location = New System.Drawing.Point(96, 40)
		Me.imgTitle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
		Me.imgTitle.Enabled = True
		Me.imgTitle.Cursor = System.Windows.Forms.Cursors.Default
		Me.imgTitle.Visible = True
		Me.imgTitle.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.imgTitle.Name = "imgTitle"
		Me.lblPlatform.TextAlign = System.Drawing.ContentAlignment.TopRight
		Me.lblPlatform.Text = "dla Windows 95/98/NT/2000/ME"
		Me.lblPlatform.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblPlatform.Size = New System.Drawing.Size(312, 24)
		Me.lblPlatform.Location = New System.Drawing.Point(82, 137)
		Me.lblPlatform.TabIndex = 2
		Me.lblPlatform.Tag = "SplashScreen#0"
		Me.lblPlatform.BackColor = System.Drawing.Color.Transparent
		Me.lblPlatform.Enabled = True
		Me.lblPlatform.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblPlatform.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblPlatform.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblPlatform.UseMnemonic = True
		Me.lblPlatform.Visible = True
		Me.lblPlatform.AutoSize = True
		Me.lblPlatform.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblPlatform.Name = "lblPlatform"
		Me.lblVersion.TextAlign = System.Drawing.ContentAlignment.TopRight
		Me.lblVersion.Text = "Wersja"
		Me.lblVersion.Font = New System.Drawing.Font("Arial", 12!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblVersion.Size = New System.Drawing.Size(52, 19)
		Me.lblVersion.Location = New System.Drawing.Point(342, 163)
		Me.lblVersion.TabIndex = 1
		Me.lblVersion.BackColor = System.Drawing.Color.Transparent
		Me.lblVersion.Enabled = True
		Me.lblVersion.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblVersion.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblVersion.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblVersion.UseMnemonic = True
		Me.lblVersion.Visible = True
		Me.lblVersion.AutoSize = True
		Me.lblVersion.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblVersion.Name = "lblVersion"
		Me.lblCopyright.Text = "Copyright (c) 2000 - 2001, Karol Kuczmarski"
		Me.lblCopyright.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblCopyright.Size = New System.Drawing.Size(215, 17)
		Me.lblCopyright.Location = New System.Drawing.Point(180, 205)
		Me.lblCopyright.TabIndex = 0
		Me.lblCopyright.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblCopyright.BackColor = System.Drawing.Color.Transparent
		Me.lblCopyright.Enabled = True
		Me.lblCopyright.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblCopyright.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblCopyright.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblCopyright.UseMnemonic = True
		Me.lblCopyright.Visible = True
		Me.lblCopyright.AutoSize = False
		Me.lblCopyright.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblCopyright.Name = "lblCopyright"
		Me.Controls.Add(imgTitle)
		Me.Controls.Add(lblPlatform)
		Me.Controls.Add(lblVersion)
		Me.Controls.Add(lblCopyright)
	End Sub
#End Region 
#Region "Upgrade Support "
	Private Shared m_vb6FormDefInstance As frmSplash
	Private Shared m_InitializingDefInstance As Boolean
	Public Shared Property DefInstance() As frmSplash
		Get
			If m_vb6FormDefInstance Is Nothing OrElse m_vb6FormDefInstance.IsDisposed Then
				m_InitializingDefInstance = True
				m_vb6FormDefInstance = New frmSplash()
				m_InitializingDefInstance = False
			End If
			DefInstance = m_vb6FormDefInstance
		End Get
		Set
			m_vb6FormDefInstance = Value
		End Set
	End Property
#End Region 
	Private Sub frmSplash_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles MyBase.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		Me.Close()
		If KeyAscii = 0 Then
			eventArgs.Handled = True
		End If
	End Sub
	Private Sub frmSplash_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
		Me.SetBounds(VB6.TwipsToPixelsX((VB6.PixelsToTwipsX(System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width) - VB6.PixelsToTwipsX(Me.Width)) / 2), VB6.TwipsToPixelsY((VB6.PixelsToTwipsY(System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height) - VB6.PixelsToTwipsY(Me.Height)) / 2), 0, 0, Windows.Forms.BoundsSpecified.X Or Windows.Forms.BoundsSpecified.Y)
		'UPGRADE_ISSUE: App property App.Revision was not upgraded. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup2069"'
		lblVersion.Text = ZwrocCiag("SplashScreen#1") & System.Diagnostics.FileVersionInfo.GetVersionInfo(System.Reflection.Assembly.GetExecutingAssembly.Location).FileMajorPart & "." & System.Diagnostics.FileVersionInfo.GetVersionInfo(System.Reflection.Assembly.GetExecutingAssembly.Location).FileMinorPart & "." & App.Revision
		
		'UPGRADE_WARNING: Form property frmSplash.Picture has a new behavior. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup2065"'
		Me.BackgroundImage = VB6.LoadResPicture(101, VB6.LoadResConstants.ResBitmap)
		imgTitle.Image = VB6.LoadResPicture(102, VB6.LoadResConstants.ResBitmap)
		SetWindowPos(Me.Handle.ToInt32, HWND_TOPMOST, 0, 0, 0, 0, SWP_NOMOVE Or SWP_NOSIZE Or SWP_SHOWWINDOW)
	End Sub
	Private Sub frmSplash_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Click
		Me.Close()
	End Sub
	
	Private Sub imgTitle_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles imgTitle.Click
		Me.Close()
	End Sub
	
	Private Sub tmrTimer_Tick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles tmrTimer.Tick
		Me.Close()
	End Sub
End Class