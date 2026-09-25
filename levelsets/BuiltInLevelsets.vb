''' <remarks>
''' The two levelsets that ship with the game: their internal names, which the settings and the
''' progress store key on, the names the player sees, and the levels themselves, read from the
''' embedded resources in this folder.
''' </remarks>
Public NotInheritable Class BuiltInLevelsets
    Public Const ClassicName As String = "Classic"
    Public Const ExtraDifficultName As String = "XS"

    Private Sub New()
    End Sub

    ''' <remarks>A library holding the built-in sets, in the order the menus list them.</remarks>
    Public Shared Function Load() As LevelsetLibrary
        Dim Library As New LevelsetLibrary()
        Library.Add(Levelset.FromText(ClassicName, My.Resources.LevelsetResource.Classic_SOK))
        Library.Add(Levelset.FromText(ExtraDifficultName, My.Resources.LevelsetResource.XS_SOK))
        Return Library
    End Function

    ''' <remarks>
    ''' The translated name of a built-in levelset, as shown to the player. Falls back to the
    ''' internal name when a set has no translation of its own.
    ''' </remarks>
    Public Shared Function DisplayName(levelsetName As String) As String
        Dim Translated As String = Nothing

        Select Case levelsetName
            Case ClassicName
                Translated = My.Resources.LocalizableStrings.LevelSetClassic
            Case ExtraDifficultName
                Translated = My.Resources.LocalizableStrings.LevelSetXS
        End Select

        If String.IsNullOrEmpty(Translated) Then
            Return levelsetName
        End If

        Return Translated
    End Function
End Class
