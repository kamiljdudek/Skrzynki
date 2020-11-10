Option Strict Off
Option Explicit On
Friend Class FrmOptions
    Inherits System.Windows.Forms.Form
#Region "Windows Form Designer generated code "
    Public Sub New()
        MyBase.New()
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
    Private ReadOnly components As System.ComponentModel.IContainer
    Public WithEvents ChkWantLevelRestartingAuthorization As System.Windows.Forms.CheckBox
    Public WithEvents ChkShowLevelLoadConfirmation As System.Windows.Forms.CheckBox
    Public WithEvents Frame1 As System.Windows.Forms.GroupBox
    Public WithEvents CmdPrevSet As System.Windows.Forms.Button
    Public WithEvents CmdNextSet As System.Windows.Forms.Button
    Public WithEvents LblPushes As System.Windows.Forms.Label
    Public WithEvents LblMoves As System.Windows.Forms.Label
    Public WithEvents LblArrivedLevel As System.Windows.Forms.Label
    Public WithEvents Label8 As System.Windows.Forms.Label
    Public WithEvents Label7 As System.Windows.Forms.Label
    Public WithEvents Label6 As System.Windows.Forms.Label
    Public WithEvents LblLevelSet As System.Windows.Forms.Label
    Public WithEvents Frame8 As System.Windows.Forms.GroupBox
    Public WithEvents FraSample4 As System.Windows.Forms.GroupBox
    Public WithEvents PicOptions_3 As System.Windows.Forms.Panel
    Public WithEvents FraSample3 As System.Windows.Forms.GroupBox
    Public WithEvents PicOptions_2 As System.Windows.Forms.Panel
    Public WithEvents FraSample2 As System.Windows.Forms.GroupBox
    Public WithEvents PicOptions_1 As System.Windows.Forms.Panel
    Public WithEvents CmdOK As System.Windows.Forms.Button
    'Public WithEvents picOptions As Microsoft.VisualBasic.Compatibility.VB6.PanelArray
    'Public WithEvents picPreview As Microsoft.VisualBasic.Compatibility.VB6.PictureBoxArray
    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Frame1 = New System.Windows.Forms.GroupBox()
        Me.ChkWantLevelRestartingAuthorization = New System.Windows.Forms.CheckBox()
        Me.ChkShowLevelLoadConfirmation = New System.Windows.Forms.CheckBox()
        Me.Frame8 = New System.Windows.Forms.GroupBox()
        Me.CmdPrevSet = New System.Windows.Forms.Button()
        Me.CmdNextSet = New System.Windows.Forms.Button()
        Me.LblPushes = New System.Windows.Forms.Label()
        Me.LblMoves = New System.Windows.Forms.Label()
        Me.LblArrivedLevel = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.LblLevelSet = New System.Windows.Forms.Label()
        Me.PicOptions_3 = New System.Windows.Forms.Panel()
        Me.FraSample4 = New System.Windows.Forms.GroupBox()
        Me.PicOptions_2 = New System.Windows.Forms.Panel()
        Me.FraSample3 = New System.Windows.Forms.GroupBox()
        Me.PicOptions_1 = New System.Windows.Forms.Panel()
        Me.FraSample2 = New System.Windows.Forms.GroupBox()
        Me.CmdOK = New System.Windows.Forms.Button()
        Me.Frame1.SuspendLayout()
        Me.Frame8.SuspendLayout()
        Me.PicOptions_3.SuspendLayout()
        Me.PicOptions_2.SuspendLayout()
        Me.PicOptions_1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Frame1
        '
        Me.Frame1.BackColor = System.Drawing.SystemColors.Control
        Me.Frame1.Controls.Add(Me.ChkWantLevelRestartingAuthorization)
        Me.Frame1.Controls.Add(Me.ChkShowLevelLoadConfirmation)
        Me.Frame1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frame1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame1.Location = New System.Drawing.Point(12, 22)
        Me.Frame1.Name = "Frame1"
        Me.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame1.Size = New System.Drawing.Size(340, 96)
        Me.Frame1.TabIndex = 12
        Me.Frame1.TabStop = False
        Me.Frame1.Tag = "OptionsDialog#8"
        Me.Frame1.Text = "Potwierdzenia"
        '
        'ChkWantLevelRestartingAuthorization
        '
        Me.ChkWantLevelRestartingAuthorization.BackColor = System.Drawing.SystemColors.Control
        Me.ChkWantLevelRestartingAuthorization.Cursor = System.Windows.Forms.Cursors.Default
        Me.ChkWantLevelRestartingAuthorization.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkWantLevelRestartingAuthorization.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ChkWantLevelRestartingAuthorization.Location = New System.Drawing.Point(8, 43)
        Me.ChkWantLevelRestartingAuthorization.Name = "ChkWantLevelRestartingAuthorization"
        Me.ChkWantLevelRestartingAuthorization.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ChkWantLevelRestartingAuthorization.Size = New System.Drawing.Size(303, 18)
        Me.ChkWantLevelRestartingAuthorization.TabIndex = 14
        Me.ChkWantLevelRestartingAuthorization.Tag = "OptionsDialog#10#Want Level Restarting Authorization"
        Me.ChkWantLevelRestartingAuthorization.Text = "Pytaj o potwierdzenie &restartowania aktualnego etapu"
        Me.ChkWantLevelRestartingAuthorization.UseVisualStyleBackColor = False
        '
        'ChkShowLevelLoadConfirmation
        '
        Me.ChkShowLevelLoadConfirmation.BackColor = System.Drawing.SystemColors.Control
        Me.ChkShowLevelLoadConfirmation.Cursor = System.Windows.Forms.Cursors.Default
        Me.ChkShowLevelLoadConfirmation.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkShowLevelLoadConfirmation.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ChkShowLevelLoadConfirmation.Location = New System.Drawing.Point(8, 68)
        Me.ChkShowLevelLoadConfirmation.Name = "ChkShowLevelLoadConfirmation"
        Me.ChkShowLevelLoadConfirmation.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ChkShowLevelLoadConfirmation.Size = New System.Drawing.Size(314, 18)
        Me.ChkShowLevelLoadConfirmation.TabIndex = 13
        Me.ChkShowLevelLoadConfirmation.Tag = "OptionsDialog#11#Show Level Load Confirmation"
        Me.ChkShowLevelLoadConfirmation.Text = "Wyœwietlaj potwierdzenie &wczytania etapu"
        Me.ChkShowLevelLoadConfirmation.UseVisualStyleBackColor = False
        '
        'Frame8
        '
        Me.Frame8.BackColor = System.Drawing.SystemColors.Control
        Me.Frame8.Controls.Add(Me.CmdPrevSet)
        Me.Frame8.Controls.Add(Me.CmdNextSet)
        Me.Frame8.Controls.Add(Me.LblPushes)
        Me.Frame8.Controls.Add(Me.LblMoves)
        Me.Frame8.Controls.Add(Me.LblArrivedLevel)
        Me.Frame8.Controls.Add(Me.Label8)
        Me.Frame8.Controls.Add(Me.Label7)
        Me.Frame8.Controls.Add(Me.Label6)
        Me.Frame8.Controls.Add(Me.LblLevelSet)
        Me.Frame8.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frame8.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame8.Location = New System.Drawing.Point(12, 151)
        Me.Frame8.Name = "Frame8"
        Me.Frame8.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame8.Size = New System.Drawing.Size(340, 137)
        Me.Frame8.TabIndex = 42
        Me.Frame8.TabStop = False
        Me.Frame8.Tag = "OptionsDialog#24"
        Me.Frame8.Text = "Statystyki"
        '
        'CmdPrevSet
        '
        Me.CmdPrevSet.BackColor = System.Drawing.SystemColors.Control
        Me.CmdPrevSet.Cursor = System.Windows.Forms.Cursors.Default
        Me.CmdPrevSet.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdPrevSet.ForeColor = System.Drawing.SystemColors.ControlText
        Me.CmdPrevSet.Location = New System.Drawing.Point(4, 108)
        Me.CmdPrevSet.Name = "CmdPrevSet"
        Me.CmdPrevSet.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CmdPrevSet.Size = New System.Drawing.Size(25, 21)
        Me.CmdPrevSet.TabIndex = 48
        Me.CmdPrevSet.Text = "<-"
        Me.CmdPrevSet.UseVisualStyleBackColor = False
        '
        'CmdNextSet
        '
        Me.CmdNextSet.BackColor = System.Drawing.SystemColors.Control
        Me.CmdNextSet.Cursor = System.Windows.Forms.Cursors.Default
        Me.CmdNextSet.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdNextSet.ForeColor = System.Drawing.SystemColors.ControlText
        Me.CmdNextSet.Location = New System.Drawing.Point(220, 108)
        Me.CmdNextSet.Name = "CmdNextSet"
        Me.CmdNextSet.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CmdNextSet.Size = New System.Drawing.Size(25, 21)
        Me.CmdNextSet.TabIndex = 47
        Me.CmdNextSet.Text = "->"
        Me.CmdNextSet.UseVisualStyleBackColor = False
        '
        'LblPushes
        '
        Me.LblPushes.BackColor = System.Drawing.SystemColors.Control
        Me.LblPushes.Cursor = System.Windows.Forms.Cursors.Default
        Me.LblPushes.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPushes.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LblPushes.Location = New System.Drawing.Point(132, 84)
        Me.LblPushes.Name = "LblPushes"
        Me.LblPushes.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.LblPushes.Size = New System.Drawing.Size(109, 13)
        Me.LblPushes.TabIndex = 51
        Me.LblPushes.Text = "#Pchniêcia#"
        Me.LblPushes.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'LblMoves
        '
        Me.LblMoves.BackColor = System.Drawing.SystemColors.Control
        Me.LblMoves.Cursor = System.Windows.Forms.Cursors.Default
        Me.LblMoves.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblMoves.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LblMoves.Location = New System.Drawing.Point(128, 64)
        Me.LblMoves.Name = "LblMoves"
        Me.LblMoves.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.LblMoves.Size = New System.Drawing.Size(113, 13)
        Me.LblMoves.TabIndex = 50
        Me.LblMoves.Text = "#Ruchy#"
        Me.LblMoves.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'LblArrivedLevel
        '
        Me.LblArrivedLevel.BackColor = System.Drawing.SystemColors.Control
        Me.LblArrivedLevel.Cursor = System.Windows.Forms.Cursors.Default
        Me.LblArrivedLevel.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblArrivedLevel.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LblArrivedLevel.Location = New System.Drawing.Point(128, 44)
        Me.LblArrivedLevel.Name = "LblArrivedLevel"
        Me.LblArrivedLevel.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.LblArrivedLevel.Size = New System.Drawing.Size(113, 13)
        Me.LblArrivedLevel.TabIndex = 49
        Me.LblArrivedLevel.Text = "#Osi¹gniêty Etap#"
        Me.LblArrivedLevel.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.SystemColors.Control
        Me.Label8.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label8.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label8.Location = New System.Drawing.Point(40, 84)
        Me.Label8.Name = "Label8"
        Me.Label8.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label8.Size = New System.Drawing.Size(73, 13)
        Me.Label8.TabIndex = 46
        Me.Label8.Tag = "OptionsDialog#28"
        Me.Label8.Text = "Pchniêcia:"
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.SystemColors.Control
        Me.Label7.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label7.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label7.Location = New System.Drawing.Point(40, 64)
        Me.Label7.Name = "Label7"
        Me.Label7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label7.Size = New System.Drawing.Size(73, 13)
        Me.Label7.TabIndex = 45
        Me.Label7.Tag = "OptionsDialog#27"
        Me.Label7.Text = "Ruchy:"
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.SystemColors.Control
        Me.Label6.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label6.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label6.Location = New System.Drawing.Point(40, 44)
        Me.Label6.Name = "Label6"
        Me.Label6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label6.Size = New System.Drawing.Size(77, 17)
        Me.Label6.TabIndex = 44
        Me.Label6.Tag = "OptionsDialog#26"
        Me.Label6.Text = "Osi¹gniêty etap:"
        '
        'LblLevelSet
        '
        Me.LblLevelSet.BackColor = System.Drawing.SystemColors.Control
        Me.LblLevelSet.Cursor = System.Windows.Forms.Cursors.Default
        Me.LblLevelSet.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.LblLevelSet.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LblLevelSet.Location = New System.Drawing.Point(8, 24)
        Me.LblLevelSet.Name = "LblLevelSet"
        Me.LblLevelSet.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.LblLevelSet.Size = New System.Drawing.Size(221, 17)
        Me.LblLevelSet.TabIndex = 43
        Me.LblLevelSet.Text = "#Zestaw Etapów#"
        '
        'PicOptions_3
        '
        Me.PicOptions_3.BackColor = System.Drawing.SystemColors.Control
        Me.PicOptions_3.Controls.Add(Me.FraSample4)
        Me.PicOptions_3.Cursor = System.Windows.Forms.Cursors.Default
        Me.PicOptions_3.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PicOptions_3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.PicOptions_3.Location = New System.Drawing.Point(-1333, 32)
        Me.PicOptions_3.Name = "PicOptions_3"
        Me.PicOptions_3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.PicOptions_3.Size = New System.Drawing.Size(381, 252)
        Me.PicOptions_3.TabIndex = 4
        '
        'FraSample4
        '
        Me.FraSample4.BackColor = System.Drawing.SystemColors.Control
        Me.FraSample4.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FraSample4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.FraSample4.Location = New System.Drawing.Point(140, 56)
        Me.FraSample4.Name = "FraSample4"
        Me.FraSample4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.FraSample4.Size = New System.Drawing.Size(137, 119)
        Me.FraSample4.TabIndex = 7
        Me.FraSample4.TabStop = False
        Me.FraSample4.Text = "Sample 4"
        '
        'PicOptions_2
        '
        Me.PicOptions_2.BackColor = System.Drawing.SystemColors.Control
        Me.PicOptions_2.Controls.Add(Me.FraSample3)
        Me.PicOptions_2.Cursor = System.Windows.Forms.Cursors.Default
        Me.PicOptions_2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PicOptions_2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.PicOptions_2.Location = New System.Drawing.Point(-1333, 32)
        Me.PicOptions_2.Name = "PicOptions_2"
        Me.PicOptions_2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.PicOptions_2.Size = New System.Drawing.Size(381, 252)
        Me.PicOptions_2.TabIndex = 3
        '
        'FraSample3
        '
        Me.FraSample3.BackColor = System.Drawing.SystemColors.Control
        Me.FraSample3.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FraSample3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.FraSample3.Location = New System.Drawing.Point(103, 45)
        Me.FraSample3.Name = "FraSample3"
        Me.FraSample3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.FraSample3.Size = New System.Drawing.Size(137, 119)
        Me.FraSample3.TabIndex = 6
        Me.FraSample3.TabStop = False
        Me.FraSample3.Text = "Sample 3"
        '
        'PicOptions_1
        '
        Me.PicOptions_1.BackColor = System.Drawing.SystemColors.Control
        Me.PicOptions_1.Controls.Add(Me.FraSample2)
        Me.PicOptions_1.Cursor = System.Windows.Forms.Cursors.Default
        Me.PicOptions_1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PicOptions_1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.PicOptions_1.Location = New System.Drawing.Point(-1333, 32)
        Me.PicOptions_1.Name = "PicOptions_1"
        Me.PicOptions_1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.PicOptions_1.Size = New System.Drawing.Size(381, 252)
        Me.PicOptions_1.TabIndex = 2
        '
        'FraSample2
        '
        Me.FraSample2.BackColor = System.Drawing.SystemColors.Control
        Me.FraSample2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FraSample2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.FraSample2.Location = New System.Drawing.Point(43, 20)
        Me.FraSample2.Name = "FraSample2"
        Me.FraSample2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.FraSample2.Size = New System.Drawing.Size(137, 119)
        Me.FraSample2.TabIndex = 5
        Me.FraSample2.TabStop = False
        Me.FraSample2.Text = "Sample 2"
        '
        'CmdOK
        '
        Me.CmdOK.BackColor = System.Drawing.SystemColors.Control
        Me.CmdOK.Cursor = System.Windows.Forms.Cursors.Default
        Me.CmdOK.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdOK.ForeColor = System.Drawing.SystemColors.ControlText
        Me.CmdOK.Location = New System.Drawing.Point(82, 358)
        Me.CmdOK.Name = "CmdOK"
        Me.CmdOK.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CmdOK.Size = New System.Drawing.Size(73, 25)
        Me.CmdOK.TabIndex = 0
        Me.CmdOK.Tag = "Buttons#0"
        Me.CmdOK.Text = "&OK"
        Me.CmdOK.UseVisualStyleBackColor = False
        '
        'FrmOptions
        '
        Me.AcceptButton = Me.CmdOK
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(445, 417)
        Me.ControlBox = False
        Me.Controls.Add(Me.Frame1)
        Me.Controls.Add(Me.Frame8)
        Me.Controls.Add(Me.PicOptions_3)
        Me.Controls.Add(Me.PicOptions_2)
        Me.Controls.Add(Me.PicOptions_1)
        Me.Controls.Add(Me.CmdOK)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.KeyPreview = True
        Me.Location = New System.Drawing.Point(102, 170)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmOptions"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Tag = "OptionsDialog#42"
        Me.Text = "Opcje"
        Me.Frame1.ResumeLayout(False)
        Me.Frame8.ResumeLayout(False)
        Me.PicOptions_3.ResumeLayout(False)
        Me.PicOptions_2.ResumeLayout(False)
        Me.PicOptions_1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
#End Region
    Private Sub CmdNextSet_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles CmdNextSet.Click
        CmdNextSet.Enabled = False
        CmdPrevSet.Enabled = True
        WyswietlStatystyki(2)
    End Sub

    Private Sub CmdOK_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles CmdOK.Click
        Me.Close()
    End Sub

    Private Sub CmdPrevSet_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles CmdPrevSet.Click
        CmdPrevSet.Enabled = False
        CmdNextSet.Enabled = True
        WyswietlStatystyki(1)
    End Sub

    Private Sub FrmOptions_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
        GameBoardForm.Localizer.GetString("o")
        CmdPrevSet.Enabled = False
        CmdNextSet.Enabled = True
        WyswietlStatystyki(1)
        LblLevelSet.Text = My.Settings.LevelSet


    End Sub

    'UPGRADE_WARNING: Event lstPlayers.SelectedIndexChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup2075"'
    Private Sub LstPlayers_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs)
        CmdPrevSet.Enabled = False
        CmdNextSet.Enabled = True
        WyswietlStatystyki(1)
    End Sub

    Public Sub WyswietlStatystyki(ByVal NrZestawu As Byte)
        Select Case NrZestawu
            Case 1
                LblLevelSet.Text = GameBoardForm.Localizer.GetString("LevelSetCaption") & UCase(GameBoardForm.Localizer.GetString("ClassicLevelsetName"))

                LblArrivedLevel.Text = My.Settings.ArrivedLevelKlasyczne
                LblMoves.Text = My.Settings.MovesKlasyczne
                LblPushes.Text = My.Settings.PushesKlasyczne

            Case 2
                LblLevelSet.Text = GameBoardForm.Localizer.GetString("LevelSetCaption") & UCase(GameBoardForm.Localizer.GetString("ExtraHardLevelsetName"))

                LblArrivedLevel.Text = My.Settings.ArrivedLevelSupertrudne
                LblMoves.Text = My.Settings.MovesSupertrudne
                LblPushes.Text = My.Settings.PushesSupertrudne

        End Select
    End Sub
End Class