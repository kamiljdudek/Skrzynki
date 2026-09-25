''' <remarks>
''' The translated strings the user interface is built from come from My.Resources.LocalizableStrings,
''' whose properties are generated from i11n\LocalizableStrings.resx - so a misspelt string name is a
''' compile error rather than a blank label. Each property resolves against the current UI culture
''' when it is read, so the language follows the machine rather than being fixed at startup.
''' </remarks>
Module Localization
    ''' <remarks>
    ''' The translated name of a built-in levelset, as shown to the player. Falls back to the
    ''' internal key when a set has no translation of its own.
    ''' </remarks>
    Public Function LocalizedLevelsetName(levelsetName As String) As String
        Dim Translated As String = Nothing

        Select Case levelsetName
            Case LevelsetLibrary.ClassicLevelsetName
                Translated = My.Resources.LocalizableStrings.LevelSetClassic
            Case LevelsetLibrary.ExtraDifficultLevelsetName
                Translated = My.Resources.LocalizableStrings.LevelSetXS
        End Select

        If String.IsNullOrEmpty(Translated) Then
            Return levelsetName
        End If

        Return Translated
    End Function
End Module
