Namespace My
    ' The following events are available for MyApplication:
    ' Startup: Raised when the application starts, before the startup form is created.
    ' Shutdown: Raised after all application forms are closed.  This event is not raised if the application terminates abnormally.
    ' UnhandledException: Raised if the application encounters an unhandled exception.
    ' StartupNextInstance: Raised when launching a single-instance application and the application is already active.
    ' NetworkAvailabilityChanged: Raised when the network connection is connected or disconnected.
    Partial Friend Class MyApplication

        ''' <remarks>
        ''' The game runs as a single instance, so launching it again lands here. The running
        ''' window is brought back, even from the tray, rather than the launch doing nothing.
        ''' </remarks>
        Private Sub MyApplication_StartupNextInstance(sender As Object, e As ApplicationServices.StartupNextInstanceEventArgs) Handles Me.StartupNextInstance
            Dim Board As GameBoardForm = TryCast(Me.MainForm, GameBoardForm)
            If Board IsNot Nothing Then
                Board.RestoreWindow()
            End If
        End Sub
    End Class
End Namespace
