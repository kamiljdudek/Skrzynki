Imports System.Reflection
Public Class SplashScreen
    Private Sub SplashScreen_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MyBase.KeyPress
        e.Handled = True
        Me.Close()
    End Sub
    Private Sub SplashScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Text = Assembly.GetExecutingAssembly.GetName.Name
        Me.LabelCopyright.Text = My.Application.Info.Copyright '& My.Application.Info.CompanyName
        Me.Label1.Text = My.Application.Info.AssemblyName
        Me.LabelDescr.Text = My.Application.Info.Description
        Me.LabelPlatform.Text = Localizer.GetString("LabelSplashOS")
        Me.LabelVersion.Text = Localizer.GetString("LabelSplashVersionName") &
            System.Diagnostics.FileVersionInfo.GetVersionInfo(System.Reflection.Assembly.GetExecutingAssembly.Location).FileVersion
        Me.PictureBoxLogo.Image = My.Resources.ico101.ToBitmap()
    End Sub
    Private Sub SplashScreen_Click(sender As Object, e As EventArgs) Handles MyBase.Click
        Me.Close()
    End Sub

    Private Sub SplashScreen_MouseDown(sender As Object, e As EventArgs) Handles Me.MouseDown
        Me.Close()
    End Sub
End Class