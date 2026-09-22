Option Explicit On
Imports System.Reflection
Public Class SplashScreen
    Private Sub FrmSplash_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles MyBase.KeyPress
        eventArgs.Handled = True
        Me.Close()
    End Sub
    Private Sub FrmSplash_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
        Label1.Text = Assembly.GetExecutingAssembly.GetName.Name
        Me.LabelCopyright.Text = My.Application.Info.Copyright '& My.Application.Info.CompanyName
        Me.Label1.Text = My.Application.Info.AssemblyName
        Me.LabelDescr.Text = My.Application.Info.Description
        Me.LabelPlatform.Text = 倉庫番.Localizer.GetString("LabelSplashOS")
        Me.LabelVersion.Text = 倉庫番.Localizer.GetString("LabelSplashVersionName") &
            System.Diagnostics.FileVersionInfo.GetVersionInfo(System.Reflection.Assembly.GetExecutingAssembly.Location).FileVersion
        Me.PictureBoxLogo.Image = My.Resources.ico101.ToBitmap()
    End Sub
    Private Sub FrmSplash_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Click
        Me.Close()
    End Sub

    Private Sub ImgTitle_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Me.MouseDown
        Me.Close()
    End Sub
End Class