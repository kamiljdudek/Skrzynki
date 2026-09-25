''' <remarks>
''' The translated strings the user interface is built from. Everything shown to the player goes
''' through Localizer, which resolves against the current UI culture at the moment it is asked -
''' so the language follows the machine rather than being fixed at startup.
''' </remarks>
Module Localization
    Public ReadOnly Localizer As New System.Resources.ResourceManager(
        "Skrzynki.LocalizableStrings", System.Reflection.Assembly.GetExecutingAssembly())

    ''' <remarks>
    ''' The translated name of a built-in levelset, as shown to the player. Falls back to the
    ''' internal key when a set has no translation of its own.
    ''' </remarks>
    Public Function LocalizedLevelsetName(levelsetName As String) As String
        Dim Translated As String = Nothing

        Select Case levelsetName
            Case ProgressStore.ClassicLevelsetName
                Translated = Localizer.GetString("LevelSetClassic")
            Case ProgressStore.ExtraDifficultLevelsetName
                Translated = Localizer.GetString("LevelSetXS")
        End Select

        If String.IsNullOrEmpty(Translated) Then
            Return levelsetName
        End If

        Return Translated
    End Function
End Module
