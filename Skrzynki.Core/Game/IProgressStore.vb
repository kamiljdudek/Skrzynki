''' <remarks>
''' Where a Game keeps the player's progress through its levelsets. The game only talks to this
''' interface, so it can be run against something other than the user's settings.
'''
''' The level marker names the *next* level to play, so it reaches one past the end of a set once
''' that set is finished. Callers that need a level number that exists should go through
''' LevelsetLibrary.FurthestPlayableLevel rather than reading the marker directly.
''' </remarks>
Public Interface IProgressStore
    Function GetLevelMarker(levelsetName As String) As Integer
    Function GetMoves(levelsetName As String) As Integer
    Function GetPushes(levelsetName As String) As Integer

    ''' <remarks>
    ''' Records one solved level: advances the marker and adds the effort spent. Does nothing when
    ''' the marker would not move, so replaying a level already beaten cannot inflate the totals.
    ''' Returns True when the progress was recorded.
    ''' </remarks>
    Function RecordSolvedLevel(levelsetName As String,
                               unlockedLevel As Integer,
                               moves As Integer,
                               pushes As Integer) As Boolean
End Interface
