<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GameBoardForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GameBoardForm))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MenuitemGame = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuitemLevelset = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuitemLevelsetClassic = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuitemLevelsetXS = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.MenuitemOpenLevelFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuitemSelectLevel = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.MenuitemQuit = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuitemView = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuitemSkins = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuitemSkinOrig = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuitemSkinExport = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuitemSkinCheese = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuitemColor = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuitemConfirmRestarts = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.MenuitemRefresh = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuitemHide = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuitemTools = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuitemUndo = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuitemRestart = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.MenuitemOptions = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuitemHelp = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuitemHelpTopics = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuitemAppWebsite = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.MenuitemAbout = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.LevelProgressBar = New System.Windows.Forms.ToolStripProgressBar()
        Me.MovesLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.PushesLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.LevelsetProgressBar = New System.Windows.Forms.ToolStripProgressBar()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.SkrzynkiTrayIcon = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.MenuStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuitemGame, Me.MenuitemView, Me.MenuitemTools, Me.MenuitemHelp})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.MenuStrip1.Size = New System.Drawing.Size(510, 24)
        Me.MenuStrip1.TabIndex = 0
        '
        'MenuitemGame
        '
        Me.MenuitemGame.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuitemLevelset, Me.MenuitemSelectLevel, Me.ToolStripSeparator2, Me.MenuitemQuit})
        Me.MenuitemGame.Name = "MenuitemGame"
        Me.MenuitemGame.Size = New System.Drawing.Size(12, 20)
        '
        'MenuitemLevelset
        '
        Me.MenuitemLevelset.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuitemLevelsetClassic, Me.MenuitemLevelsetXS, Me.ToolStripSeparator5, Me.MenuitemOpenLevelFile})
        Me.MenuitemLevelset.Name = "MenuitemLevelset"
        Me.MenuitemLevelset.Size = New System.Drawing.Size(109, 22)
        '
        'MenuitemLevelsetClassic
        '
        Me.MenuitemLevelsetClassic.Name = "MenuitemLevelsetClassic"
        Me.MenuitemLevelsetClassic.Size = New System.Drawing.Size(110, 22)
        '
        'MenuitemLevelsetXS
        '
        Me.MenuitemLevelsetXS.Name = "MenuitemLevelsetXS"
        Me.MenuitemLevelsetXS.Size = New System.Drawing.Size(110, 22)
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(107, 6)
        '
        'MenuitemOpenLevelFile
        '
        Me.MenuitemOpenLevelFile.Name = "MenuitemOpenLevelFile"
        Me.MenuitemOpenLevelFile.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.MenuitemOpenLevelFile.Size = New System.Drawing.Size(110, 22)
        '
        'MenuitemSelectLevel
        '
        Me.MenuitemSelectLevel.Name = "MenuitemSelectLevel"
        Me.MenuitemSelectLevel.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.L), System.Windows.Forms.Keys)
        Me.MenuitemSelectLevel.Size = New System.Drawing.Size(109, 22)
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(106, 6)
        '
        'MenuitemQuit
        '
        Me.MenuitemQuit.Name = "MenuitemQuit"
        Me.MenuitemQuit.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.F4), System.Windows.Forms.Keys)
        Me.MenuitemQuit.Size = New System.Drawing.Size(109, 22)
        '
        'MenuitemView
        '
        Me.MenuitemView.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuitemSkins, Me.MenuitemColor, Me.MenuitemConfirmRestarts, Me.ToolStripSeparator4, Me.MenuitemRefresh, Me.MenuitemHide})
        Me.MenuitemView.Name = "MenuitemView"
        Me.MenuitemView.Size = New System.Drawing.Size(12, 20)
        '
        'MenuitemSkins
        '
        Me.MenuitemSkins.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuitemSkinOrig, Me.MenuitemSkinExport, Me.MenuitemSkinCheese})
        Me.MenuitemSkins.Name = "MenuitemSkins"
        Me.MenuitemSkins.Size = New System.Drawing.Size(110, 22)
        '
        'MenuitemSkinOrig
        '
        Me.MenuitemSkinOrig.Image = Global.Skrzynki.My.Resources.Resources.Oryginalny
        Me.MenuitemSkinOrig.Name = "MenuitemSkinOrig"
        Me.MenuitemSkinOrig.Size = New System.Drawing.Size(67, 22)
        '
        'MenuitemSkinExport
        '
        Me.MenuitemSkinExport.Image = Global.Skrzynki.My.Resources.Resources.Eksport
        Me.MenuitemSkinExport.Name = "MenuitemSkinExport"
        Me.MenuitemSkinExport.Size = New System.Drawing.Size(67, 22)
        '
        'MenuitemSkinCheese
        '
        Me.MenuitemSkinCheese.Image = Global.Skrzynki.My.Resources.Resources.Serowy
        Me.MenuitemSkinCheese.Name = "MenuitemSkinCheese"
        Me.MenuitemSkinCheese.Size = New System.Drawing.Size(67, 22)
        '
        'MenuitemColor
        '
        Me.MenuitemColor.Name = "MenuitemColor"
        Me.MenuitemColor.Size = New System.Drawing.Size(110, 22)
        '
        'MenuitemConfirmRestarts
        '
        Me.MenuitemConfirmRestarts.CheckOnClick = True
        Me.MenuitemConfirmRestarts.Name = "MenuitemConfirmRestarts"
        Me.MenuitemConfirmRestarts.Size = New System.Drawing.Size(110, 22)
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(107, 6)
        '
        'MenuitemRefresh
        '
        Me.MenuitemRefresh.Name = "MenuitemRefresh"
        Me.MenuitemRefresh.ShortcutKeys = System.Windows.Forms.Keys.F5
        Me.MenuitemRefresh.Size = New System.Drawing.Size(110, 22)
        '
        'MenuitemHide
        '
        Me.MenuitemHide.Name = "MenuitemHide"
        Me.MenuitemHide.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.H), System.Windows.Forms.Keys)
        Me.MenuitemHide.Size = New System.Drawing.Size(110, 22)
        '
        'MenuitemTools
        '
        Me.MenuitemTools.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuitemUndo, Me.MenuitemRestart, Me.ToolStripSeparator3, Me.MenuitemOptions})
        Me.MenuitemTools.Name = "MenuitemTools"
        Me.MenuitemTools.Size = New System.Drawing.Size(12, 20)
        '
        'MenuitemUndo
        '
        Me.MenuitemUndo.Name = "MenuitemUndo"
        Me.MenuitemUndo.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Z), System.Windows.Forms.Keys)
        Me.MenuitemUndo.Size = New System.Drawing.Size(108, 22)
        '
        'MenuitemRestart
        '
        Me.MenuitemRestart.Name = "MenuitemRestart"
        Me.MenuitemRestart.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.R), System.Windows.Forms.Keys)
        Me.MenuitemRestart.Size = New System.Drawing.Size(108, 22)
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(105, 6)
        '
        'MenuitemOptions
        '
        Me.MenuitemOptions.Name = "MenuitemOptions"
        Me.MenuitemOptions.ShortcutKeys = System.Windows.Forms.Keys.F9
        Me.MenuitemOptions.Size = New System.Drawing.Size(108, 22)
        '
        'MenuitemHelp
        '
        Me.MenuitemHelp.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuitemHelpTopics, Me.MenuitemAppWebsite, Me.ToolStripSeparator1, Me.MenuitemAbout})
        Me.MenuitemHelp.Name = "MenuitemHelp"
        Me.MenuitemHelp.Size = New System.Drawing.Size(12, 20)
        '
        'MenuitemHelpTopics
        '
        Me.MenuitemHelpTopics.Name = "MenuitemHelpTopics"
        Me.MenuitemHelpTopics.ShortcutKeys = System.Windows.Forms.Keys.F1
        Me.MenuitemHelpTopics.Size = New System.Drawing.Size(118, 22)
        '
        'MenuitemAppWebsite
        '
        Me.MenuitemAppWebsite.Name = "MenuitemAppWebsite"
        Me.MenuitemAppWebsite.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.W), System.Windows.Forms.Keys)
        Me.MenuitemAppWebsite.Size = New System.Drawing.Size(118, 22)
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(115, 6)
        '
        'MenuitemAbout
        '
        Me.MenuitemAbout.Name = "MenuitemAbout"
        Me.MenuitemAbout.ShortcutKeys = CType((System.Windows.Forms.Keys.Shift Or System.Windows.Forms.Keys.F1), System.Windows.Forms.Keys)
        Me.MenuitemAbout.Size = New System.Drawing.Size(118, 22)
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LevelProgressBar, Me.MovesLabel, Me.PushesLabel, Me.LevelsetProgressBar})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 495)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(510, 22)
        Me.StatusStrip1.TabIndex = 1
        '
        'LevelProgressBar
        '
        Me.LevelProgressBar.MarqueeAnimationSpeed = 0
        Me.LevelProgressBar.Name = "LevelProgressBar"
        Me.LevelProgressBar.Size = New System.Drawing.Size(100, 16)
        Me.LevelProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        '
        'MovesLabel
        '
        Me.MovesLabel.BackColor = System.Drawing.SystemColors.Control
        Me.MovesLabel.BorderSides = CType((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.MovesLabel.BorderStyle = System.Windows.Forms.Border3DStyle.Etched
        Me.MovesLabel.Name = "MovesLabel"
        Me.MovesLabel.Size = New System.Drawing.Size(131, 17)
        Me.MovesLabel.Spring = True
        '
        'PushesLabel
        '
        Me.PushesLabel.BackColor = System.Drawing.SystemColors.Control
        Me.PushesLabel.BorderSides = CType((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.PushesLabel.BorderStyle = System.Windows.Forms.Border3DStyle.Etched
        Me.PushesLabel.Name = "PushesLabel"
        Me.PushesLabel.Size = New System.Drawing.Size(131, 17)
        Me.PushesLabel.Spring = True
        '
        'LevelsetProgressBar
        '
        Me.LevelsetProgressBar.Name = "LevelsetProgressBar"
        Me.LevelsetProgressBar.Size = New System.Drawing.Size(128, 16)
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'SkrzynkiTrayIcon
        '
        Me.SkrzynkiTrayIcon.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.SkrzynkiTrayIcon.Icon = CType(resources.GetObject("SkrzynkiTrayIcon.Icon"), System.Drawing.Icon)
        '
        'GameBoardForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(510, 517)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "GameBoardForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents MenuitemGame As ToolStripMenuItem
    Friend WithEvents MenuitemLevelset As ToolStripMenuItem
    Friend WithEvents MenuitemLevelsetClassic As ToolStripMenuItem
    Friend WithEvents MenuitemLevelsetXS As ToolStripMenuItem
    Friend WithEvents MenuitemSelectLevel As ToolStripMenuItem
    Friend WithEvents MenuitemView As ToolStripMenuItem
    Friend WithEvents MenuitemSkins As ToolStripMenuItem
    Friend WithEvents MenuitemSkinOrig As ToolStripMenuItem
    Friend WithEvents MenuitemSkinExport As ToolStripMenuItem
    Friend WithEvents MenuitemSkinCheese As ToolStripMenuItem
    Friend WithEvents MenuitemColor As ToolStripMenuItem
    Friend WithEvents MenuitemRefresh As ToolStripMenuItem
    Friend WithEvents MenuitemHide As ToolStripMenuItem
    Friend WithEvents MenuitemTools As ToolStripMenuItem
    Friend WithEvents MenuitemUndo As ToolStripMenuItem
    Friend WithEvents MenuitemRestart As ToolStripMenuItem
    Friend WithEvents MenuitemOptions As ToolStripMenuItem
    Friend WithEvents MenuitemHelp As ToolStripMenuItem
    Friend WithEvents MenuitemHelpTopics As ToolStripMenuItem
    Friend WithEvents MenuitemAppWebsite As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents MenuitemAbout As ToolStripMenuItem
    Friend WithEvents MenuitemQuit As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents MovesLabel As ToolStripStatusLabel
    Friend WithEvents PushesLabel As ToolStripStatusLabel
    Friend WithEvents LevelProgressBar As ToolStripProgressBar
    Friend WithEvents LevelsetProgressBar As ToolStripProgressBar
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents SkrzynkiTrayIcon As NotifyIcon
    Friend WithEvents ColorDialog1 As ColorDialog
    Friend WithEvents MenuitemConfirmRestarts As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator4 As ToolStripSeparator
    Friend WithEvents MenuitemOpenLevelFile As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator5 As ToolStripSeparator
End Class
