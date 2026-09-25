''' <remarks>
''' How the game talks to the player outside its own windows: every message box and prompt is
''' application-modal and titled with the game's name.
''' </remarks>
Module Dialogs
    Public ReadOnly MessageTitle As String =
        System.Reflection.Assembly.GetExecutingAssembly.GetName.Name

    Public Function ShowMessage(text As String, style As MsgBoxStyle) As MsgBoxResult
        Return MsgBox(text, style Or MsgBoxStyle.ApplicationModal, MessageTitle)
    End Function
End Module
