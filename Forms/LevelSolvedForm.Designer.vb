<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LevelSolvedForm
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
        Me.components = New System.ComponentModel.Container()
        Me.LabelCongratulation = New System.Windows.Forms.Label()
        Me.LabelMoves = New System.Windows.Forms.Label()
        Me.LabelPushes = New System.Windows.Forms.Label()
        Me.LabelUndos = New System.Windows.Forms.Label()
        Me.ButtonNextLevel = New System.Windows.Forms.Button()
        Me.ButtonRepeatLevel = New System.Windows.Forms.Button()
        Me.ButtonSaveSolution = New System.Windows.Forms.Button()
        Me.SaveSolutionDialog = New System.Windows.Forms.SaveFileDialog()
        Me.SuspendLayout()
        '
        'LabelCongratulation
        '
        Me.LabelCongratulation.AutoSize = False
        Me.LabelCongratulation.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold)
        Me.LabelCongratulation.Location = New System.Drawing.Point(16, 16)
        Me.LabelCongratulation.Name = "LabelCongratulation"
        Me.LabelCongratulation.Size = New System.Drawing.Size(388, 28)
        Me.LabelCongratulation.TabIndex = 0
        '
        'LabelMoves
        '
        Me.LabelMoves.AutoSize = False
        Me.LabelMoves.Location = New System.Drawing.Point(16, 52)
        Me.LabelMoves.Name = "LabelMoves"
        Me.LabelMoves.Size = New System.Drawing.Size(188, 19)
        Me.LabelMoves.TabIndex = 1
        '
        'LabelPushes
        '
        Me.LabelPushes.AutoSize = False
        Me.LabelPushes.Location = New System.Drawing.Point(216, 52)
        Me.LabelPushes.Name = "LabelPushes"
        Me.LabelPushes.Size = New System.Drawing.Size(188, 19)
        Me.LabelPushes.TabIndex = 2
        '
        'LabelUndos
        '
        Me.LabelUndos.AutoSize = False
        Me.LabelUndos.Location = New System.Drawing.Point(16, 75)
        Me.LabelUndos.Name = "LabelUndos"
        Me.LabelUndos.Size = New System.Drawing.Size(388, 19)
        Me.LabelUndos.TabIndex = 3
        '
        'ButtonNextLevel
        '
        Me.ButtonNextLevel.Location = New System.Drawing.Point(16, 106)
        Me.ButtonNextLevel.Name = "ButtonNextLevel"
        Me.ButtonNextLevel.Size = New System.Drawing.Size(96, 30)
        Me.ButtonNextLevel.TabIndex = 4
        Me.ButtonNextLevel.UseVisualStyleBackColor = True
        '
        'ButtonRepeatLevel
        '
        Me.ButtonRepeatLevel.Location = New System.Drawing.Point(120, 106)
        Me.ButtonRepeatLevel.Name = "ButtonRepeatLevel"
        Me.ButtonRepeatLevel.Size = New System.Drawing.Size(96, 30)
        Me.ButtonRepeatLevel.TabIndex = 5
        Me.ButtonRepeatLevel.UseVisualStyleBackColor = True
        '
        'ButtonSaveSolution
        '
        Me.ButtonSaveSolution.Location = New System.Drawing.Point(224, 106)
        Me.ButtonSaveSolution.Name = "ButtonSaveSolution"
        Me.ButtonSaveSolution.Size = New System.Drawing.Size(180, 30)
        Me.ButtonSaveSolution.TabIndex = 6
        Me.ButtonSaveSolution.UseVisualStyleBackColor = True
        '
        'SaveSolutionDialog
        '
        Me.SaveSolutionDialog.DefaultExt = "lurd"
        Me.SaveSolutionDialog.OverwritePrompt = True
        '
        'LevelSolvedForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(420, 152)
        Me.Controls.Add(Me.ButtonSaveSolution)
        Me.Controls.Add(Me.ButtonRepeatLevel)
        Me.Controls.Add(Me.ButtonNextLevel)
        Me.Controls.Add(Me.LabelUndos)
        Me.Controls.Add(Me.LabelPushes)
        Me.Controls.Add(Me.LabelMoves)
        Me.Controls.Add(Me.LabelCongratulation)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "LevelSolvedForm"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LabelCongratulation As Label
    Friend WithEvents LabelMoves As Label
    Friend WithEvents LabelPushes As Label
    Friend WithEvents LabelUndos As Label
    Friend WithEvents ButtonNextLevel As Button
    Friend WithEvents ButtonRepeatLevel As Button
    Friend WithEvents ButtonSaveSolution As Button
    Friend WithEvents SaveSolutionDialog As SaveFileDialog
End Class
