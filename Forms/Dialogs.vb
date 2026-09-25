''' <remarks>
''' How the game talks to the player outside its own windows. Every message box belongs to the
''' window it concerns - centred on it and blocking it - and is titled with the game's translated
''' name. Text reads right to left in a language that does.
''' </remarks>
Friend NotInheritable Class Dialogs
    Private Sub New()
    End Sub

    Public Shared ReadOnly Property MessageTitle As String
        Get
            Return My.Resources.LocalizableStrings.GameName
        End Get
    End Property

    Public Shared Function ShowMessage(owner As IWin32Window,
                                       text As String,
                                       buttons As MessageBoxButtons,
                                       icon As MessageBoxIcon) As DialogResult
        Dim Options As MessageBoxOptions = 0
        If Globalization.CultureInfo.CurrentUICulture.TextInfo.IsRightToLeft Then
            Options = MessageBoxOptions.RtlReading Or MessageBoxOptions.RightAlign
        End If

        Return MessageBox.Show(owner, text, MessageTitle, buttons, icon,
                               MessageBoxDefaultButton.Button1, Options)
    End Function
End Class
