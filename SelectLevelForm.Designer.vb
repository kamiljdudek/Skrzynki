<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SelectLevelForm
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

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.LabelPrompt = New System.Windows.Forms.Label()
        Me.LevelNumber = New System.Windows.Forms.NumericUpDown()
        Me.ButtonOK = New System.Windows.Forms.Button()
        Me.ButtonCancel = New System.Windows.Forms.Button()
        CType(Me.LevelNumber, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelPrompt
        '
        Me.LabelPrompt.AutoSize = True
        Me.LabelPrompt.Location = New System.Drawing.Point(12, 15)
        Me.LabelPrompt.MaximumSize = New System.Drawing.Size(236, 0)
        Me.LabelPrompt.Name = "LabelPrompt"
        Me.LabelPrompt.Size = New System.Drawing.Size(0, 13)
        Me.LabelPrompt.TabIndex = 0
        '
        'LevelNumber
        '
        Me.LevelNumber.Location = New System.Drawing.Point(12, 38)
        Me.LevelNumber.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.LevelNumber.Name = "LevelNumber"
        Me.LevelNumber.Size = New System.Drawing.Size(236, 20)
        Me.LevelNumber.TabIndex = 1
        Me.LevelNumber.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'ButtonOK
        '
        Me.ButtonOK.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.ButtonOK.Location = New System.Drawing.Point(92, 70)
        Me.ButtonOK.Name = "ButtonOK"
        Me.ButtonOK.Size = New System.Drawing.Size(75, 23)
        Me.ButtonOK.TabIndex = 2
        Me.ButtonOK.UseVisualStyleBackColor = True
        '
        'ButtonCancel
        '
        Me.ButtonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.ButtonCancel.Location = New System.Drawing.Point(173, 70)
        Me.ButtonCancel.Name = "ButtonCancel"
        Me.ButtonCancel.Size = New System.Drawing.Size(75, 23)
        Me.ButtonCancel.TabIndex = 3
        Me.ButtonCancel.UseVisualStyleBackColor = True
        '
        'SelectLevelForm
        '
        Me.AcceptButton = Me.ButtonOK
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.ButtonCancel
        Me.ClientSize = New System.Drawing.Size(260, 105)
        Me.Controls.Add(Me.ButtonCancel)
        Me.Controls.Add(Me.ButtonOK)
        Me.Controls.Add(Me.LevelNumber)
        Me.Controls.Add(Me.LabelPrompt)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "SelectLevelForm"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        CType(Me.LevelNumber, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LabelPrompt As Label
    Friend WithEvents LevelNumber As NumericUpDown
    Friend WithEvents ButtonOK As Button
    Friend WithEvents ButtonCancel As Button
End Class
