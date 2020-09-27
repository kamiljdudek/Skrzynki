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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmSplash))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.tmrTimer = New System.Windows.Forms.Timer(Me.components)
        Me.imgTitle = New System.Windows.Forms.PictureBox
        Me.lblPlatform = New System.Windows.Forms.Label
        Me.lblVersion = New System.Windows.Forms.Label
        Me.lblCopyright = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'tmrTimer
        '
        Me.tmrTimer.Enabled = True
        Me.tmrTimer.Interval = 2000
        '
        'imgTitle
        '
        Me.imgTitle.Cursor = System.Windows.Forms.Cursors.Default
        Me.imgTitle.Image = CType(resources.GetObject("imgTitle.Image"), System.Drawing.Image)
        Me.imgTitle.Location = New System.Drawing.Point(96, 40)
        Me.imgTitle.Name = "imgTitle"
        Me.imgTitle.Size = New System.Drawing.Size(288, 61)
        Me.imgTitle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgTitle.TabIndex = 0
        Me.imgTitle.TabStop = False
        '
        'lblPlatform
        '
        Me.lblPlatform.AutoSize = True
        Me.lblPlatform.BackColor = System.Drawing.Color.Transparent
        Me.lblPlatform.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblPlatform.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPlatform.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblPlatform.Location = New System.Drawing.Point(256, 136)
        Me.lblPlatform.Name = "lblPlatform"
        Me.lblPlatform.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblPlatform.Size = New System.Drawing.Size(140, 28)
        Me.lblPlatform.TabIndex = 2
        Me.lblPlatform.Tag = "SplashScreen#0"
        Me.lblPlatform.Text = "dla Windows"
        Me.lblPlatform.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblVersion
        '
        Me.lblVersion.AutoSize = True
        Me.lblVersion.BackColor = System.Drawing.Color.Transparent
        Me.lblVersion.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblVersion.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVersion.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblVersion.Location = New System.Drawing.Point(342, 163)
        Me.lblVersion.Name = "lblVersion"
        Me.lblVersion.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblVersion.Size = New System.Drawing.Size(60, 22)
        Me.lblVersion.TabIndex = 1
        Me.lblVersion.Text = "Wersja"
        Me.lblVersion.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblCopyright
        '
        Me.lblCopyright.BackColor = System.Drawing.Color.Transparent
        Me.lblCopyright.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblCopyright.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCopyright.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblCopyright.Location = New System.Drawing.Point(152, 205)
        Me.lblCopyright.Name = "lblCopyright"
        Me.lblCopyright.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblCopyright.Size = New System.Drawing.Size(240, 17)
        Me.lblCopyright.TabIndex = 0
        Me.lblCopyright.Text = "Copyright (c) 2000 - 2001, Karol Kuczmarski"
        '
        'frmSplash
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(401, 248)
        Me.ControlBox = False
        Me.Controls.Add(Me.imgTitle)
        Me.Controls.Add(Me.lblPlatform)
        Me.Controls.Add(Me.lblVersion)
        Me.Controls.Add(Me.lblCopyright)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.KeyPreview = True
        Me.Location = New System.Drawing.Point(162, 227)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSplash"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.ResumeLayout(False)

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
        lblVersion.Text = ZwrocCiag("SplashScreen#1") & System.Diagnostics.FileVersionInfo.GetVersionInfo(System.Reflection.Assembly.GetExecutingAssembly.Location).FileMajorPart & "." & System.Diagnostics.FileVersionInfo.GetVersionInfo(System.Reflection.Assembly.GetExecutingAssembly.Location).FileMinorPart & "."
		
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