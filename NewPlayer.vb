Option Strict Off
Option Explicit On
Friend Class frmNewPlayer
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
	Public WithEvents _txtEditBoxes_2 As System.Windows.Forms.TextBox
	Public WithEvents _txtEditBoxes_0 As System.Windows.Forms.TextBox
	Public WithEvents cmdOK As System.Windows.Forms.Button
	Public WithEvents cmdCancel As System.Windows.Forms.Button
	Public WithEvents _txtEditBoxes_1 As System.Windows.Forms.TextBox
	Public WithEvents _lblLabels_2 As System.Windows.Forms.Label
	Public WithEvents _lblLabels_0 As System.Windows.Forms.Label
	Public WithEvents _lblLabels_1 As System.Windows.Forms.Label
	Public WithEvents lblLabels As Microsoft.VisualBasic.Compatibility.VB6.LabelArray
	Public WithEvents txtEditBoxes As Microsoft.VisualBasic.Compatibility.VB6.TextBoxArray
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmNewPlayer))
		Me.components = New System.ComponentModel.Container()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(components)
		Me.ToolTip1.Active = True
		Me._txtEditBoxes_2 = New System.Windows.Forms.TextBox
		Me._txtEditBoxes_0 = New System.Windows.Forms.TextBox
		Me.cmdOK = New System.Windows.Forms.Button
		Me.cmdCancel = New System.Windows.Forms.Button
		Me._txtEditBoxes_1 = New System.Windows.Forms.TextBox
		Me._lblLabels_2 = New System.Windows.Forms.Label
		Me._lblLabels_0 = New System.Windows.Forms.Label
		Me._lblLabels_1 = New System.Windows.Forms.Label
		Me.lblLabels = New Microsoft.VisualBasic.Compatibility.VB6.LabelArray(components)
		Me.txtEditBoxes = New Microsoft.VisualBasic.Compatibility.VB6.TextBoxArray(components)
		CType(Me.lblLabels, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtEditBoxes, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
		Me.Text = "Nowy gracz"
		Me.ClientSize = New System.Drawing.Size(250, 136)
		Me.Location = New System.Drawing.Point(189, 232)
		Me.ControlBox = False
		Me.MaximizeBox = False
		Me.MinimizeBox = False
		Me.ShowInTaskbar = False
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
		Me.BackColor = System.Drawing.SystemColors.Control
		Me.Enabled = True
		Me.KeyPreview = False
		Me.Cursor = System.Windows.Forms.Cursors.Default
		Me.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.HelpButton = False
		Me.WindowState = System.Windows.Forms.FormWindowState.Normal
		Me.Name = "frmNewPlayer"
		Me._txtEditBoxes_2.AutoSize = False
		Me._txtEditBoxes_2.Size = New System.Drawing.Size(155, 23)
		Me._txtEditBoxes_2.IMEMode = System.Windows.Forms.ImeMode.Disable
		Me._txtEditBoxes_2.Location = New System.Drawing.Point(88, 64)
		Me._txtEditBoxes_2.PasswordChar = ChrW(42)
		Me._txtEditBoxes_2.TabIndex = 6
		Me._txtEditBoxes_2.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._txtEditBoxes_2.AcceptsReturn = True
		Me._txtEditBoxes_2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me._txtEditBoxes_2.BackColor = System.Drawing.SystemColors.Window
		Me._txtEditBoxes_2.CausesValidation = True
		Me._txtEditBoxes_2.Enabled = True
		Me._txtEditBoxes_2.ForeColor = System.Drawing.SystemColors.WindowText
		Me._txtEditBoxes_2.HideSelection = True
		Me._txtEditBoxes_2.ReadOnly = False
		Me._txtEditBoxes_2.Maxlength = 0
		Me._txtEditBoxes_2.Cursor = System.Windows.Forms.Cursors.IBeam
		Me._txtEditBoxes_2.MultiLine = False
		Me._txtEditBoxes_2.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._txtEditBoxes_2.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me._txtEditBoxes_2.TabStop = True
		Me._txtEditBoxes_2.Visible = True
		Me._txtEditBoxes_2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me._txtEditBoxes_2.Name = "_txtEditBoxes_2"
		Me._txtEditBoxes_0.AutoSize = False
		Me._txtEditBoxes_0.Size = New System.Drawing.Size(155, 23)
		Me._txtEditBoxes_0.IMEMode = System.Windows.Forms.ImeMode.Disable
		Me._txtEditBoxes_0.Location = New System.Drawing.Point(88, 9)
		Me._txtEditBoxes_0.PasswordChar = ChrW(42)
		Me._txtEditBoxes_0.TabIndex = 1
		Me._txtEditBoxes_0.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._txtEditBoxes_0.AcceptsReturn = True
		Me._txtEditBoxes_0.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me._txtEditBoxes_0.BackColor = System.Drawing.SystemColors.Window
		Me._txtEditBoxes_0.CausesValidation = True
		Me._txtEditBoxes_0.Enabled = True
		Me._txtEditBoxes_0.ForeColor = System.Drawing.SystemColors.WindowText
		Me._txtEditBoxes_0.HideSelection = True
		Me._txtEditBoxes_0.ReadOnly = False
		Me._txtEditBoxes_0.Maxlength = 0
		Me._txtEditBoxes_0.Cursor = System.Windows.Forms.Cursors.IBeam
		Me._txtEditBoxes_0.MultiLine = False
		Me._txtEditBoxes_0.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._txtEditBoxes_0.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me._txtEditBoxes_0.TabStop = True
		Me._txtEditBoxes_0.Visible = True
		Me._txtEditBoxes_0.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me._txtEditBoxes_0.Name = "_txtEditBoxes_0"
		Me.cmdOK.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cmdOK.Text = "&OK"
		Me.AcceptButton = Me.cmdOK
		Me.cmdOK.Size = New System.Drawing.Size(76, 26)
		Me.cmdOK.Location = New System.Drawing.Point(33, 104)
		Me.cmdOK.TabIndex = 4
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
		Me.cmdCancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.CancelButton = Me.cmdCancel
		Me.cmdCancel.Text = "&Anuluj"
		Me.cmdCancel.Size = New System.Drawing.Size(76, 26)
		Me.cmdCancel.Location = New System.Drawing.Point(140, 104)
		Me.cmdCancel.TabIndex = 5
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
		Me._txtEditBoxes_1.AutoSize = False
		Me._txtEditBoxes_1.Size = New System.Drawing.Size(155, 23)
		Me._txtEditBoxes_1.IMEMode = System.Windows.Forms.ImeMode.Disable
		Me._txtEditBoxes_1.Location = New System.Drawing.Point(88, 36)
		Me._txtEditBoxes_1.PasswordChar = ChrW(42)
		Me._txtEditBoxes_1.TabIndex = 3
		Me._txtEditBoxes_1.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._txtEditBoxes_1.AcceptsReturn = True
		Me._txtEditBoxes_1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me._txtEditBoxes_1.BackColor = System.Drawing.SystemColors.Window
		Me._txtEditBoxes_1.CausesValidation = True
		Me._txtEditBoxes_1.Enabled = True
		Me._txtEditBoxes_1.ForeColor = System.Drawing.SystemColors.WindowText
		Me._txtEditBoxes_1.HideSelection = True
		Me._txtEditBoxes_1.ReadOnly = False
		Me._txtEditBoxes_1.Maxlength = 0
		Me._txtEditBoxes_1.Cursor = System.Windows.Forms.Cursors.IBeam
		Me._txtEditBoxes_1.MultiLine = False
		Me._txtEditBoxes_1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._txtEditBoxes_1.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me._txtEditBoxes_1.TabStop = True
		Me._txtEditBoxes_1.Visible = True
		Me._txtEditBoxes_1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me._txtEditBoxes_1.Name = "_txtEditBoxes_1"
		Me._lblLabels_2.Text = "&Powtórz has³o:"
		Me._lblLabels_2.Size = New System.Drawing.Size(72, 18)
		Me._lblLabels_2.Location = New System.Drawing.Point(8, 68)
		Me._lblLabels_2.TabIndex = 7
		Me._lblLabels_2.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._lblLabels_2.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me._lblLabels_2.BackColor = System.Drawing.SystemColors.Control
		Me._lblLabels_2.Enabled = True
		Me._lblLabels_2.ForeColor = System.Drawing.SystemColors.ControlText
		Me._lblLabels_2.Cursor = System.Windows.Forms.Cursors.Default
		Me._lblLabels_2.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._lblLabels_2.UseMnemonic = True
		Me._lblLabels_2.Visible = True
		Me._lblLabels_2.AutoSize = False
		Me._lblLabels_2.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._lblLabels_2.Name = "_lblLabels_2"
		Me._lblLabels_0.Text = "&Gracz:"
		Me._lblLabels_0.Size = New System.Drawing.Size(72, 18)
		Me._lblLabels_0.Location = New System.Drawing.Point(7, 12)
		Me._lblLabels_0.TabIndex = 0
		Me._lblLabels_0.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._lblLabels_0.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me._lblLabels_0.BackColor = System.Drawing.SystemColors.Control
		Me._lblLabels_0.Enabled = True
		Me._lblLabels_0.ForeColor = System.Drawing.SystemColors.ControlText
		Me._lblLabels_0.Cursor = System.Windows.Forms.Cursors.Default
		Me._lblLabels_0.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._lblLabels_0.UseMnemonic = True
		Me._lblLabels_0.Visible = True
		Me._lblLabels_0.AutoSize = False
		Me._lblLabels_0.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._lblLabels_0.Name = "_lblLabels_0"
		Me._lblLabels_1.Text = "&Has³o:"
		Me._lblLabels_1.Size = New System.Drawing.Size(72, 18)
		Me._lblLabels_1.Location = New System.Drawing.Point(7, 40)
		Me._lblLabels_1.TabIndex = 2
		Me._lblLabels_1.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._lblLabels_1.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me._lblLabels_1.BackColor = System.Drawing.SystemColors.Control
		Me._lblLabels_1.Enabled = True
		Me._lblLabels_1.ForeColor = System.Drawing.SystemColors.ControlText
		Me._lblLabels_1.Cursor = System.Windows.Forms.Cursors.Default
		Me._lblLabels_1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._lblLabels_1.UseMnemonic = True
		Me._lblLabels_1.Visible = True
		Me._lblLabels_1.AutoSize = False
		Me._lblLabels_1.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._lblLabels_1.Name = "_lblLabels_1"
		Me.Controls.Add(_txtEditBoxes_2)
		Me.Controls.Add(_txtEditBoxes_0)
		Me.Controls.Add(cmdOK)
		Me.Controls.Add(cmdCancel)
		Me.Controls.Add(_txtEditBoxes_1)
		Me.Controls.Add(_lblLabels_2)
		Me.Controls.Add(_lblLabels_0)
		Me.Controls.Add(_lblLabels_1)
		Me.lblLabels.SetIndex(_lblLabels_2, CType(2, Short))
		Me.lblLabels.SetIndex(_lblLabels_0, CType(0, Short))
		Me.lblLabels.SetIndex(_lblLabels_1, CType(1, Short))
		Me.txtEditBoxes.SetIndex(_txtEditBoxes_2, CType(2, Short))
		Me.txtEditBoxes.SetIndex(_txtEditBoxes_0, CType(0, Short))
		Me.txtEditBoxes.SetIndex(_txtEditBoxes_1, CType(1, Short))
		CType(Me.txtEditBoxes, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.lblLabels, System.ComponentModel.ISupportInitialize).EndInit()
	End Sub
#End Region 
#Region "Upgrade Support "
	Private Shared m_vb6FormDefInstance As frmNewPlayer
	Private Shared m_InitializingDefInstance As Boolean
	Public Shared Property DefInstance() As frmNewPlayer
		Get
			If m_vb6FormDefInstance Is Nothing OrElse m_vb6FormDefInstance.IsDisposed Then
				m_InitializingDefInstance = True
				m_vb6FormDefInstance = New frmNewPlayer()
				m_InitializingDefInstance = False
			End If
			DefInstance = m_vb6FormDefInstance
		End Get
		Set
			m_vb6FormDefInstance = Value
		End Set
	End Property
#End Region 
	
	Private Sub cmdCancel_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdCancel.Click
		Me.Hide()
	End Sub
	
	Private Sub cmdOK_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdOK.Click
		If txtEditBoxes(1).Text <> txtEditBoxes(2).Text Then
			MsgBox("Potwierdzenie nie jest takie same jak pierwsze has³o!", MsgBoxStyle.OKCancel + MsgBoxStyle.Critical + MsgBoxStyle.ApplicationModal, "Has³o")
			Exit Sub
		End If
		
        If NewPlayerFormAction = "Password" Then
            modMain.RegKey = Microsoft.Win32.Registry.CurrentUser.OpenSubKey(RegSciezka & "\\Players\\" & Str(PodajNumerGracza(frmOptions.DefInstance.lstPlayers.Text)), True)
            modMain.RegString = RegKey.GetValue("Password", "password")
            If Odszyfruj(modMain.RegString) = txtEditBoxes(0).Text Then
                RegDaneStr = Zaszyfruj(txtEditBoxes(1).Text)
                RegKey.SetValue("Password", RegDaneStr)
                DaneGracza.Haslo = txtEditBoxes(1).Text
            Else
                MsgBox("Stare has³o nie jest prawid³owe!", MsgBoxStyle.OKCancel + MsgBoxStyle.Critical + MsgBoxStyle.ApplicationModal, "B³ad w haœle")
                Exit Sub
            End If
        Else
            StworzNowyProfil(txtEditBoxes(0).Text, txtEditBoxes(1).Text)
        End If

        Me.Hide()
	End Sub
	Private Sub frmNewPlayer_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
		If NewPlayerFormAction = "Password" Then
			Me.Text = ZwrocCiag("ChangePasswordDialog#0")
			lblLabels(0).Text = ZwrocCiag("ChangePasswordDialog#1")
			lblLabels(1).Text = ZwrocCiag("ChangePasswordDialog#2")
			lblLabels(2).Text = ZwrocCiag("ChangePasswordDialog#3")
			txtEditBoxes(0).Text = frmOptions.DefInstance.txtPassword.Text
		Else
			Me.Text = ZwrocCiag("NewPlayerDialog#0")
			lblLabels(0).Text = ZwrocCiag("NewPlayerDialog#1")
			txtEditBoxes(0).PasswordChar = CChar("")
			lblLabels(1).Text = ZwrocCiag("NewPlayerDialog#2")
			lblLabels(2).Text = ZwrocCiag("NewPlayerDialog#3")
		End If
	End Sub
End Class