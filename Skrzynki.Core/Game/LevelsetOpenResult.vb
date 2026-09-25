''' <remarks>What came of opening a levelset file.</remarks>
Public Enum LevelsetOpenOutcome
    ''' <remarks>The file was read and play has moved to its first level.</remarks>
    Opened

    ''' <remarks>The file could not be read at all; the game in progress is untouched.</remarks>
    Unreadable

    ''' <remarks>
    ''' The file was read, but not one level in it can be played; the game in progress is
    ''' untouched. The levelset's SkippedLevels say why.
    ''' </remarks>
    NoPlayableLevels
End Enum

''' <remarks>
''' The outcome of opening a levelset file, together with the set as read, so that whoever opened it
''' can tell the player not only whether it worked but also which levels were left out and why.
''' </remarks>
Public NotInheritable Class LevelsetOpenResult
    Public Sub New(outcome As LevelsetOpenOutcome, levelset As Levelset)
        Me.Outcome = outcome
        Me.Levelset = levelset
    End Sub

    Public ReadOnly Property Outcome As LevelsetOpenOutcome

    ''' <remarks>The set as read from the file; Nothing when the file could not be read.</remarks>
    Public ReadOnly Property Levelset As Levelset
End Class
