''' <remarks>
''' Where a Game keeps the player's progress through the built-in levelsets. The interface is what
''' lets a Game be run against something other than the user's settings.
'''
''' The level marker names the *next* level to play, so it reaches one past the end of a set once
''' that set is finished. Callers that need a level number that exists should go through
''' Game.FurthestPlayableLevel rather than reading the marker directly.
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

''' <remarks>
''' Progress kept in My.Settings. Each of the built-in sets has its own settings, and this is the
''' only place that knows which settings belong to which set - so nothing else has to name them.
''' A set this store does not know, such as one opened from a file, keeps no progress at all.
''' </remarks>
Public NotInheritable Class ProgressStore
    Implements IProgressStore

    ' Each tracked set has three settings, named with its prefix followed by one of the suffixes
    ' below - ClassicArrivedLevel, ClassicMoves, ClassicPushes. Tracking a further set takes those
    ' three settings and one entry here.
    Private Shared ReadOnly SettingPrefixes As New Dictionary(Of String, String)(StringComparer.Ordinal) From {
        {LevelsetLibrary.ClassicLevelsetName, "Classic"},
        {LevelsetLibrary.ExtraDifficultLevelsetName, "ExtraDifficult"}
    }

    Private Const LevelMarkerSetting As String = "ArrivedLevel"
    Private Const MovesSetting As String = "Moves"
    Private Const PushesSetting As String = "Pushes"

    ''' <remarks>
    ''' The settings are addressed by name, which the compiler cannot check, so every name is
    ''' checked here instead: a missing one stops the game at startup rather than the first time
    ''' a level is solved.
    ''' </remarks>
    Public Sub New()
        For Each Prefix As String In SettingPrefixes.Values
            For Each Suffix As String In {LevelMarkerSetting, MovesSetting, PushesSetting}
                If My.Settings.Properties(Prefix & Suffix) Is Nothing Then
                    Throw New InvalidOperationException(
                        "ProgressStore expects a setting named " & Prefix & Suffix &
                        ", which My.Settings does not define.")
                End If
            Next
        Next
    End Sub

    ''' <remarks>Whether the named set keeps progress at all.</remarks>
    Private Shared Function TracksProgress(levelsetName As String) As Boolean
        Return levelsetName IsNot Nothing AndAlso SettingPrefixes.ContainsKey(levelsetName)
    End Function

    ''' <remarks>One of a tracked set's settings, or the fallback for a set that keeps none.</remarks>
    Private Shared Function ReadSetting(levelsetName As String,
                                        settingSuffix As String,
                                        fallback As Integer) As Integer
        If Not TracksProgress(levelsetName) Then
            Return fallback
        End If

        Return CInt(My.Settings(SettingPrefixes(levelsetName) & settingSuffix))
    End Function

    Private Shared Sub WriteSetting(levelsetName As String, settingSuffix As String, value As Integer)
        My.Settings(SettingPrefixes(levelsetName) & settingSuffix) = value
    End Sub

    ''' <remarks>The number of the next level to play; 1 for a set that keeps no progress.</remarks>
    Public Function GetLevelMarker(levelsetName As String) As Integer _
        Implements IProgressStore.GetLevelMarker
        Return ReadSetting(levelsetName, LevelMarkerSetting, 1)
    End Function

    Public Function GetMoves(levelsetName As String) As Integer Implements IProgressStore.GetMoves
        Return ReadSetting(levelsetName, MovesSetting, 0)
    End Function

    Public Function GetPushes(levelsetName As String) As Integer Implements IProgressStore.GetPushes
        Return ReadSetting(levelsetName, PushesSetting, 0)
    End Function

    Public Function RecordSolvedLevel(levelsetName As String,
                                      unlockedLevel As Integer,
                                      moves As Integer,
                                      pushes As Integer) As Boolean _
        Implements IProgressStore.RecordSolvedLevel
        If Not TracksProgress(levelsetName) Then
            Return False
        End If

        If unlockedLevel <= GetLevelMarker(levelsetName) Then
            Return False
        End If

        WriteSetting(levelsetName, LevelMarkerSetting, unlockedLevel)
        WriteSetting(levelsetName, MovesSetting, GetMoves(levelsetName) + moves)
        WriteSetting(levelsetName, PushesSetting, GetPushes(levelsetName) + pushes)

        Return True
    End Function
End Class
