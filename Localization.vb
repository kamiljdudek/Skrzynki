''' <remarks>
''' The translated strings the user interface is built from. Everything shown to the player goes
''' through Localizer, which resolves against the current UI culture at the moment it is asked -
''' so the language follows the machine rather than being fixed at startup.
''' </remarks>
Module Localization
    <CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2211:NonConstantFieldsShouldNotBeVisible",
                                  Justification:="Single-threaded UI application")>
    Public Localizer As New System.Resources.ResourceManager(
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

    ''' <remarks>
    ''' How the active levelset is named to the player: the file name for a set opened from disk,
    ''' the translated set name otherwise.
    ''' </remarks>
    Public Function CurrentLevelsetDisplayName() As String
        If IsPlayingCustomLevelset() AndAlso Not String.IsNullOrEmpty(CustomLevelsetFileName) Then
            Return System.IO.Path.GetFileName(CustomLevelsetFileName)
        End If

        Return LocalizedLevelsetName(My.Settings.LevelSet)
    End Function

    ''' <remarks>The window title for the whole game, built in one place.</remarks>
    Public Function CurrentGameTitle() As String
        Return Localizer.GetString("GameName") &
            " (" & CurrentLevelsetDisplayName() & "): #" &
            CurrentLevelNumber.ToString(System.Globalization.CultureInfo.InvariantCulture)
    End Function
End Module
