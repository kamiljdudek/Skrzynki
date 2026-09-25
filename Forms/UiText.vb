''' <remarks>
''' Text shown to the player, built from a translated format string such as "Moves: {0}". The
''' translation decides where each value goes and what surrounds it, and numbers are written the
''' way the player's own culture writes them - which is the point of routing it all through here
''' rather than letting each call site pick a culture, or glue text and numbers together itself.
''' </remarks>
Friend NotInheritable Class UiText
    Private Sub New()
    End Sub

    ''' <example>MovesLabel.Text = UiText.Format(LocalizableStrings.LabelMovesFormat, moves)</example>
    Public Shared Function Format(translatedFormat As String, ParamArray values As Object()) As String
        Return String.Format(Globalization.CultureInfo.CurrentCulture, translatedFormat, values)
    End Function
End Class
