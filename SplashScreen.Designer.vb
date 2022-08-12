<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SplashScreen
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer
    Public WithEvents LabelPlatform As System.Windows.Forms.Label
    Public WithEvents LabelVersion As System.Windows.Forms.Label
    Friend WithEvents PictureBoxLogo As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Public WithEvents LabelCopyright As System.Windows.Forms.Label

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.LabelPlatform = New System.Windows.Forms.Label()
        Me.LabelVersion = New System.Windows.Forms.Label()
        Me.LabelCopyright = New System.Windows.Forms.Label()
        Me.PictureBoxLogo = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.LabelDescr = New System.Windows.Forms.Label()
        CType(Me.PictureBoxLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'LabelPlatform
        '
        Me.LabelPlatform.AutoSize = True
        Me.LabelPlatform.BackColor = System.Drawing.Color.Transparent
        Me.LabelPlatform.Cursor = System.Windows.Forms.Cursors.Default
        Me.LabelPlatform.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.LabelPlatform.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LabelPlatform.Location = New System.Drawing.Point(256, 136)
        Me.LabelPlatform.Name = "LabelPlatform"
        Me.LabelPlatform.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.LabelPlatform.Size = New System.Drawing.Size(0, 30)
        Me.LabelPlatform.TabIndex = 2
        Me.LabelPlatform.Tag = "SplashScreen#0"
        Me.LabelPlatform.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'LabelVersion
        '
        Me.LabelVersion.AutoSize = True
        Me.LabelVersion.BackColor = System.Drawing.Color.Transparent
        Me.LabelVersion.Cursor = System.Windows.Forms.Cursors.Default
        Me.LabelVersion.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.LabelVersion.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LabelVersion.Location = New System.Drawing.Point(261, 163)
        Me.LabelVersion.Name = "LabelVersion"
        Me.LabelVersion.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.LabelVersion.Size = New System.Drawing.Size(0, 21)
        Me.LabelVersion.TabIndex = 1
        Me.LabelVersion.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'LabelCopyright
        '
        Me.LabelCopyright.BackColor = System.Drawing.Color.Transparent
        Me.LabelCopyright.Cursor = System.Windows.Forms.Cursors.Default
        Me.LabelCopyright.Font = New System.Drawing.Font("Segoe UI", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.LabelCopyright.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LabelCopyright.Location = New System.Drawing.Point(112, 205)
        Me.LabelCopyright.Name = "LabelCopyright"
        Me.LabelCopyright.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.LabelCopyright.Size = New System.Drawing.Size(280, 19)
        Me.LabelCopyright.TabIndex = 0
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
        Me.Label1.Size = New System.Drawing.Size(0, 57)
        Me.Label1.TabIndex = 5
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
        'LabelDescr
        '
        Me.LabelDescr.AutoSize = True
        Me.LabelDescr.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.LabelDescr.Location = New System.Drawing.Point(109, 94)
        Me.LabelDescr.Name = "LabelDescr"
        Me.LabelDescr.Size = New System.Drawing.Size(0, 17)
        Me.LabelDescr.TabIndex = 7
        '
        'SplashScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(401, 248)
        Me.ControlBox = False
        Me.Controls.Add(Me.LabelDescr)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LabelPlatform)
        Me.Controls.Add(Me.LabelVersion)
        Me.Controls.Add(Me.LabelCopyright)
        Me.Controls.Add(Me.Panel1)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.Location = New System.Drawing.Point(162, 227)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "SplashScreen"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.PictureBoxLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LabelDescr As Label
End Class
