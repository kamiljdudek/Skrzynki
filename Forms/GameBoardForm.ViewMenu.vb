' The View menu: how the board looks, whether restarts ask first, and hiding to the tray.
' Check marks are brought up to date as a menu opens - by mouse or by keyboard alike.
Partial Public Class GameBoardForm

    Private Sub MenuitemView_DropDownOpening(sender As Object, e As EventArgs) Handles MenuitemView.DropDownOpening
        MenuitemConfirmRestarts.Checked = My.Settings.LevelRestartingAuthorization
    End Sub

    Private Sub MenuitemRefresh_Click(sender As Object, e As EventArgs) Handles MenuitemRefresh.Click
        BoardDisplay.Invalidate()
    End Sub

    Private Sub MenuitemColor_Click(sender As Object, e As EventArgs) Handles MenuitemColor.Click
        BackgroundColorDialog.Color = My.Settings.BackgroundColor
        If BackgroundColorDialog.ShowDialog(Me) = DialogResult.OK Then
            My.Settings.BackgroundColor = BackgroundColorDialog.Color
            BoardDisplay.BackColor = BackgroundColorDialog.Color
        End If
    End Sub

    Private Sub ApplySkin(skin As BoardSkin)
        My.Settings.Skin = skin.ToString()
        BoardDisplay.Skin = skin
    End Sub

    Private Sub MenuitemSkins_DropDownOpening(sender As Object, e As EventArgs) Handles MenuitemSkins.DropDownOpening
        Dim Current As BoardSkin = SkinIcons.FromSetting(My.Settings.Skin)
        MenuitemSkinOrig.Checked = Current = BoardSkin.Original
        MenuitemSkinCheese.Checked = Current = BoardSkin.Cheese
        MenuitemSkinExport.Checked = Current = BoardSkin.Export
    End Sub

    Private Sub MenuitemSkinOrig_Click(sender As Object, e As EventArgs) Handles MenuitemSkinOrig.Click
        ApplySkin(BoardSkin.Original)
    End Sub

    Private Sub MenuitemSkinExport_Click(sender As Object, e As EventArgs) Handles MenuitemSkinExport.Click
        ApplySkin(BoardSkin.Export)
    End Sub

    Private Sub MenuitemSkinCheese_Click(sender As Object, e As EventArgs) Handles MenuitemSkinCheese.Click
        ApplySkin(BoardSkin.Cheese)
    End Sub

    ''' <remarks>CheckOnClick toggles the item; this only carries the new state into the setting.</remarks>
    Private Sub MenuitemConfirmRestarts_CheckedChanged(sender As Object, e As EventArgs) Handles MenuitemConfirmRestarts.CheckedChanged
        My.Settings.LevelRestartingAuthorization = MenuitemConfirmRestarts.Checked
    End Sub

    Private Sub MenuitemHide_Click(sender As Object, e As EventArgs) Handles MenuitemHide.Click
        SkrzynkiTrayIcon.Visible = True
        SkrzynkiTrayIcon.Text = My.Resources.LocalizableStrings.LabelTrayDescription
        SkrzynkiTrayIcon.BalloonTipText = My.Resources.LocalizableStrings.LabelTrayDescription
        Me.Visible = False
    End Sub

    ''' <remarks>Any click brings the window back; a double-click raises MouseClick too.</remarks>
    Private Sub SkrzynkiTrayIcon_MouseClick(sender As Object, e As MouseEventArgs) Handles SkrzynkiTrayIcon.MouseClick
        RestoreWindow()
    End Sub

    ''' <remarks>
    ''' Brings the game window back from wherever it is - hidden in the tray, minimized, or behind
    ''' other windows. Also called when the game is launched a second time.
    ''' </remarks>
    Friend Sub RestoreWindow()
        SkrzynkiTrayIcon.Visible = False
        Me.Visible = True
        If Me.WindowState = FormWindowState.Minimized Then
            Me.WindowState = FormWindowState.Normal
        End If
        Me.Activate()
    End Sub
End Class
