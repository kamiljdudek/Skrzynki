Option Strict Off
Option Explicit On
Imports System.Reflection
Imports Microsoft.VisualBasic.ApplicationServices

Friend Class FrmSplash
    Inherits System.Windows.Forms.Form
#Region "Windows Form Designer generated code "
    Public Sub New()
        MyBase.New()
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
    Private ReadOnly components As System.ComponentModel.IContainer
    Public WithEvents LblPlatform As System.Windows.Forms.Label
    Public WithEvents LblVersion As System.Windows.Forms.Label
    Friend WithEvents PictureBoxLogo As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Public WithEvents LblCopyright As System.Windows.Forms.Label
    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.LblPlatform = New System.Windows.Forms.Label()
        Me.LblVersion = New System.Windows.Forms.Label()
        Me.LblCopyright = New System.Windows.Forms.Label()
        Me.PictureBoxLogo = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        CType(Me.PictureBoxLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'LblPlatform
        '
        Me.LblPlatform.AutoSize = True
        Me.LblPlatform.BackColor = System.Drawing.Color.Transparent
        Me.LblPlatform.Cursor = System.Windows.Forms.Cursors.Default
        Me.LblPlatform.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.LblPlatform.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LblPlatform.Location = New System.Drawing.Point(256, 136)
        Me.LblPlatform.Name = "LblPlatform"
        Me.LblPlatform.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.LblPlatform.Size = New System.Drawing.Size(141, 30)
        Me.LblPlatform.TabIndex = 2
        Me.LblPlatform.Tag = "SplashScreen#0"
        Me.LblPlatform.Text = "dla Windows"
        Me.LblPlatform.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'LblVersion
        '
        Me.LblVersion.AutoSize = True
        Me.LblVersion.BackColor = System.Drawing.Color.Transparent
        Me.LblVersion.Cursor = System.Windows.Forms.Cursors.Default
        Me.LblVersion.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.LblVersion.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LblVersion.Location = New System.Drawing.Point(342, 163)
        Me.LblVersion.Name = "LblVersion"
        Me.LblVersion.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.LblVersion.Size = New System.Drawing.Size(62, 21)
        Me.LblVersion.TabIndex = 1
        Me.LblVersion.Text = "Wersja"
        Me.LblVersion.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'LblCopyright
        '
        Me.LblCopyright.BackColor = System.Drawing.Color.Transparent
        Me.LblCopyright.Cursor = System.Windows.Forms.Cursors.Default
        Me.LblCopyright.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.LblCopyright.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LblCopyright.Location = New System.Drawing.Point(152, 205)
        Me.LblCopyright.Name = "LblCopyright"
        Me.LblCopyright.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.LblCopyright.Size = New System.Drawing.Size(240, 17)
        Me.LblCopyright.TabIndex = 0
        Me.LblCopyright.Text = "Copyright (c) 2000 - 2001, Karol Kuczmarski"
        '
        'PictureBoxLogo
        '
        Me.PictureBoxLogo.Location = New System.Drawing.Point(4, 4)
        Me.PictureBoxLogo.Name = "PictureBoxLogo"
        Me.PictureBoxLogo.Size = New System.Drawing.Size(32, 32)
        Me.PictureBoxLogo.TabIndex = 4
        Me.PictureBoxLogo.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe Script", 26.25!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(107, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(191, 57)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Skrzynki"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Location = New System.Drawing.Point(-1, -1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(89, 249)
        Me.Panel1.TabIndex = 6
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.PictureBoxLogo)
        Me.Panel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel2.Location = New System.Drawing.Point(25, 45)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(40, 40)
        Me.Panel2.TabIndex = 7
        '
        'FrmSplash
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(401, 248)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LblPlatform)
        Me.Controls.Add(Me.LblVersion)
        Me.Controls.Add(Me.LblCopyright)
        Me.Controls.Add(Me.Panel1)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.KeyPreview = True
        Me.Location = New System.Drawing.Point(162, 227)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmSplash"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.PictureBoxLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
#End Region
    Private Sub FrmSplash_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles MyBase.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        Me.Close()
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub
    Private Sub FrmSplash_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
        Label1.Text = Assembly.GetExecutingAssembly.GetName.Name
        LblVersion.Text = System.Diagnostics.FileVersionInfo.GetVersionInfo(System.Reflection.Assembly.GetExecutingAssembly.Location).FileVersion
        Me.PictureBoxLogo.Image = My.Resources.ico101.ToBitmap()
    End Sub
    Private Sub FrmSplash_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Click
        Me.Close()
    End Sub

    Private Sub ImgTitle_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs)
        Me.Close()
    End Sub

End Class