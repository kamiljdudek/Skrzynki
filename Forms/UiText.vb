''' <remarks>
''' Text shown to the player, built with string interpolation. Numbers in it are written the way
''' the player's own culture writes them, which is the point of routing it through here rather
''' than letting each call site pick a culture - or forget to.
''' </remarks>
Friend NotInheritable Class UiText
    Private Sub New()
    End Sub

    ''' <example>LabelMoves.Text = UiText.Format($"{LocalizableStrings.LabelMoves}{moves}")</example>
    Public Shared Function Format(text As FormattableString) As String
        If text Is Nothing Then
            Return String.Empty
        End If

        Return text.ToString(Globalization.CultureInfo.CurrentCulture)
    End Function
End Class
