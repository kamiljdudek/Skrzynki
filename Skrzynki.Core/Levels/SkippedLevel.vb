''' <remarks>Why a level in a levelset's text was left out of the set.</remarks>
Public Enum LevelSkipReason
    ''' <remarks>
    ''' Not a level that can be played: it holds a character that is not part of a map, or it does
    ''' not have exactly one player.
    ''' </remarks>
    NotValid

    ''' <remarks>Larger than the largest board, Board.MaximumSize squares on a side.</remarks>
    TooLarge
End Enum

''' <remarks>A level that a levelset left out, and why.</remarks>
Public NotInheritable Class SkippedLevel
    Public Sub New(position As Integer, reason As LevelSkipReason)
        Me.Position = position
        Me.Reason = reason
    End Sub

    ''' <remarks>Where the level stands in the text it was read from, counting from 1.</remarks>
    Public ReadOnly Property Position As Integer

    Public ReadOnly Property Reason As LevelSkipReason
End Class
