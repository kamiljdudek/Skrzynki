Option Strict Off
Option Explicit On
Friend Class frmFindMIDI
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
	Public WithEvents tmrSecondTimer As System.Windows.Forms.Timer
	Public WithEvents tmrTimer As System.Windows.Forms.Timer
	Public WithEvents lblFilesFound As System.Windows.Forms.Label
	Public WithEvents lblFolder As System.Windows.Forms.Label
	Public WithEvents Label1 As System.Windows.Forms.Label
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmFindMIDI))
		Me.components = New System.ComponentModel.Container()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(components)
		Me.ToolTip1.Active = True
		Me.tmrSecondTimer = New System.Windows.Forms.Timer(components)
		Me.tmrTimer = New System.Windows.Forms.Timer(components)
		Me.lblFilesFound = New System.Windows.Forms.Label
		Me.lblFolder = New System.Windows.Forms.Label
		Me.Label1 = New System.Windows.Forms.Label
		Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
		Me.Text = "Wyszukiwanie..."
		Me.ClientSize = New System.Drawing.Size(439, 125)
		Me.Location = New System.Drawing.Point(125, 232)
		Me.ControlBox = False
		Me.MaximizeBox = False
		Me.MinimizeBox = False
		Me.ShowInTaskbar = False
		Me.Tag = "FindMIDIDialog#0"
		Me.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
		Me.BackColor = System.Drawing.SystemColors.Control
		Me.Enabled = True
		Me.KeyPreview = False
		Me.Cursor = System.Windows.Forms.Cursors.Default
		Me.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.HelpButton = False
		Me.WindowState = System.Windows.Forms.FormWindowState.Normal
		Me.Name = "frmFindMIDI"
		Me.tmrSecondTimer.Interval = 10
		Me.tmrSecondTimer.Enabled = True
		Me.tmrTimer.Interval = 1000
		Me.tmrTimer.Enabled = True
		Me.lblFilesFound.TextAlign = System.Drawing.ContentAlignment.TopCenter
		Me.lblFilesFound.Size = New System.Drawing.Size(385, 17)
		Me.lblFilesFound.Location = New System.Drawing.Point(28, 100)
		Me.lblFilesFound.TabIndex = 2
		Me.lblFilesFound.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblFilesFound.BackColor = System.Drawing.SystemColors.Control
		Me.lblFilesFound.Enabled = True
		Me.lblFilesFound.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblFilesFound.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblFilesFound.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblFilesFound.UseMnemonic = True
		Me.lblFilesFound.Visible = True
		Me.lblFilesFound.AutoSize = False
		Me.lblFilesFound.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblFilesFound.Name = "lblFilesFound"
		Me.lblFolder.TextAlign = System.Drawing.ContentAlignment.TopCenter
		Me.lblFolder.Size = New System.Drawing.Size(385, 33)
		Me.lblFolder.Location = New System.Drawing.Point(28, 60)
		Me.lblFolder.TabIndex = 1
		Me.lblFolder.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblFolder.BackColor = System.Drawing.SystemColors.Control
		Me.lblFolder.Enabled = True
		Me.lblFolder.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblFolder.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblFolder.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblFolder.UseMnemonic = True
		Me.lblFolder.Visible = True
		Me.lblFolder.AutoSize = False
		Me.lblFolder.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblFolder.Name = "lblFolder"
		Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
		Me.Label1.Size = New System.Drawing.Size(377, 37)
		Me.Label1.Location = New System.Drawing.Point(32, 16)
		Me.Label1.TabIndex = 0
		Me.Label1.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
		Me.Controls.Add(lblFilesFound)
		Me.Controls.Add(lblFolder)
		Me.Controls.Add(Label1)
	End Sub
#End Region 
#Region "Upgrade Support "
	Private Shared m_vb6FormDefInstance As frmFindMIDI
	Private Shared m_InitializingDefInstance As Boolean
	Public Shared Property DefInstance() As frmFindMIDI
		Get
			If m_vb6FormDefInstance Is Nothing OrElse m_vb6FormDefInstance.IsDisposed Then
				m_InitializingDefInstance = True
				m_vb6FormDefInstance = New frmFindMIDI()
				m_InitializingDefInstance = False
			End If
			DefInstance = m_vb6FormDefInstance
		End Get
		Set
			m_vb6FormDefInstance = Value
		End Set
	End Property
#End Region 
	Dim i As Short
	Private Sub frmFindMIDI_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
		Label1.Text = ZwrocCiag("FindMIDIDialog#1")
		lblFilesFound.Text = ZwrocCiag("FindMIDIDialog#2") & "0"
		Me.SetBounds(VB6.TwipsToPixelsX((VB6.PixelsToTwipsX(System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width) - VB6.PixelsToTwipsX(Me.Width)) / 2), VB6.TwipsToPixelsY((VB6.PixelsToTwipsY(System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height) - VB6.PixelsToTwipsY(Me.Height)) / 2), 0, 0, Windows.Forms.BoundsSpecified.X Or Windows.Forms.BoundsSpecified.Y)
	End Sub
	Private Sub tmrSecondTimer_Tick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles tmrSecondTimer.Tick
		lblFilesFound.Text = ZwrocCiag("FindMIDIDialog#2") & LiczbaPlikow
	End Sub
	Private Sub tmrTimer_Tick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles tmrTimer.Tick
		tmrTimer.Enabled = False
		PrzetwarzajDyski()
		frmFindMIDI.DefInstance.Close()
	End Sub
End Class