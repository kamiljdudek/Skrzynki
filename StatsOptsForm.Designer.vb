<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StatsOptsForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(StatsOptsForm))
        Me.LevelsetComboBox = New System.Windows.Forms.ComboBox()
        Me.LabelLevelSet = New System.Windows.Forms.Label()
        Me.LabelReachedLevel = New System.Windows.Forms.Label()
        Me.LabelMoves = New System.Windows.Forms.Label()
        Me.LabelPushes = New System.Windows.Forms.Label()
        Me.LevelSetProgressBar = New System.Windows.Forms.ProgressBar()
        Me.SuspendLayout()
        '
        'LevelsetComboBox
        '
        Me.LevelsetComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.LevelsetComboBox.FormattingEnabled = True
        resources.ApplyResources(Me.LevelsetComboBox, "LevelsetComboBox")
        Me.LevelsetComboBox.Name = "LevelsetComboBox"
        '
        'LabelLevelSet
        '
        resources.ApplyResources(Me.LabelLevelSet, "LabelLevelSet")
        Me.LabelLevelSet.Name = "LabelLevelSet"
        '
        'LabelReachedLevel
        '
        resources.ApplyResources(Me.LabelReachedLevel, "LabelReachedLevel")
        Me.LabelReachedLevel.Name = "LabelReachedLevel"
        '
        'LabelMoves
        '
        resources.ApplyResources(Me.LabelMoves, "LabelMoves")
        Me.LabelMoves.Name = "LabelMoves"
        '
        'LabelPushes
        '
        resources.ApplyResources(Me.LabelPushes, "LabelPushes")
        Me.LabelPushes.Name = "LabelPushes"
        '
        'LevelSetProgressBar
        '
        resources.ApplyResources(Me.LevelSetProgressBar, "LevelSetProgressBar")
        Me.LevelSetProgressBar.Name = "LevelSetProgressBar"
        '
        'StatsOptsForm
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.LevelSetProgressBar)
        Me.Controls.Add(Me.LabelPushes)
        Me.Controls.Add(Me.LabelMoves)
        Me.Controls.Add(Me.LabelReachedLevel)
        Me.Controls.Add(Me.LabelLevelSet)
        Me.Controls.Add(Me.LevelsetComboBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "StatsOptsForm"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LevelsetComboBox As ComboBox
    Friend WithEvents LabelLevelSet As Label
    Friend WithEvents LabelReachedLevel As Label
    Friend WithEvents LabelMoves As Label
    Friend WithEvents LabelPushes As Label
    Friend WithEvents LevelSetProgressBar As ProgressBar
End Class
