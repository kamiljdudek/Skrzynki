''' <remarks>
''' How the game talks to the player outside its own windows: every message box and prompt is
''' application-modal and titled with the game's translated name.
''' </remarks>
Module Dialogs
    Public ReadOnly Property MessageTitle As String
        Get
            Return My.Resources.LocalizableStrings.GameName
        End Get
    End Property

    Public Function ShowMessage(text As String, style As MsgBoxStyle) As MsgBoxResult
        Return MsgBox(text, style Or MsgBoxStyle.ApplicationModal, MessageTitle)
    End Function
End Module
