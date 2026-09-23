''' <remarks>
''' Where per-levelset progress lives. Each of the two built-in sets has its own settings, and
''' this is the only place that knows which settings belong to which set - so nothing else has to
''' name them.
'''
''' A levelset opened from a file keeps no progress at all, and every member here ignores it.
'''
''' The stored level marker names the *next* level to play, so it reaches one past the end of a
''' set once that set is finished. Callers that need a level number that exists should go through
''' FurthestPlayableLevel rather than reading the marker directly.
''' </remarks>
Module ProgressStore
    Public Const ClassicLevelsetName As String = "Classic"
    Public Const ExtraDifficultLevelsetName As String = "XS"

    ''' <remarks>Whether the named set keeps progress at all.</remarks>
    Public Function TracksProgress(levelsetName As String) As Boolean
        Return levelsetName = ClassicLevelsetName OrElse levelsetName = ExtraDifficultLevelsetName
    End Function

    ' --- Progress stored under earlier setting names ---------------------------------------------
    ' A saved user.config may hold these six settings under the names on the left. The settings
    ' system matches by name and would simply ignore them, leaving the player looking as though
    ' their progress had been reset, so the values are copied across once.

    Private ReadOnly LegacySettingNames As New Dictionary(Of String, String)(StringComparer.Ordinal) From {
        {"ArrivedLevelKlasyczne", NameOf(My.MySettings.ClassicArrivedLevel)},
        {"ArrivedLevelSupertrudne", NameOf(My.MySettings.ExtraDifficultArrivedLevel)},
        {"MovesKlasyczne", NameOf(My.MySettings.ClassicMoves)},
        {"MovesSupertrudne", NameOf(My.MySettings.ExtraDifficultMoves)},
        {"PushesKlasyczne", NameOf(My.MySettings.ClassicPushes)},
        {"PushesSupertrudne", NameOf(My.MySettings.ExtraDifficultPushes)}
    }

    ''' <remarks>
    ''' Copies progress saved under the old setting names into the new ones, once. Any failure to
    ''' read the stored configuration leaves the new settings at their defaults rather than
    ''' stopping the game from starting - losing a statistic is not worth refusing to run over.
    ''' </remarks>
    Public Sub MigrateLegacyProgress()
        If My.Settings.LegacyProgressMigrated Then
            Exit Sub
        End If

        Try
            Dim LegacyValues As Dictionary(Of String, Integer) = ReadLegacyValues()

            For Each Legacy As KeyValuePair(Of String, String) In LegacySettingNames
                Dim Value As Integer
                If LegacyValues.TryGetValue(Legacy.Key, Value) Then
                    My.Settings(Legacy.Value) = Value
                End If
            Next

            My.Settings.LegacyProgressMigrated = True
            My.Settings.Save()
        Catch ex As System.Configuration.ConfigurationErrorsException
            ' A stored configuration that cannot be read has no progress to rescue.
        Catch ex As System.Xml.XmlException
        Catch ex As System.IO.IOException
        End Try
    End Sub

    ''' <remarks>Reads the old, now-unmapped settings straight out of the stored user.config.</remarks>
    Private Function ReadLegacyValues() As Dictionary(Of String, Integer)
        Dim Found As New Dictionary(Of String, Integer)(StringComparer.Ordinal)

        Dim StoredConfiguration As System.Configuration.Configuration =
            System.Configuration.ConfigurationManager.OpenExeConfiguration(
                System.Configuration.ConfigurationUserLevel.PerUserRoamingAndLocal)

        If StoredConfiguration Is Nothing OrElse Not System.IO.File.Exists(StoredConfiguration.FilePath) Then
            Return Found
        End If

        Dim Stored As New System.Xml.XmlDocument With {.XmlResolver = Nothing}
        Stored.Load(StoredConfiguration.FilePath)

        For Each SettingNode As System.Xml.XmlNode In Stored.GetElementsByTagName("setting")
            Dim NameAttribute As System.Xml.XmlNode = SettingNode.Attributes.GetNamedItem("name")
            If NameAttribute Is Nothing OrElse Not LegacySettingNames.ContainsKey(NameAttribute.Value) Then
                Continue For
            End If

            Dim ValueNode As System.Xml.XmlNode = SettingNode.SelectSingleNode("value")
            Dim Value As Integer
            If ValueNode IsNot Nothing AndAlso
               Integer.TryParse(ValueNode.InnerText,
                                Globalization.NumberStyles.Integer,
                                Globalization.CultureInfo.InvariantCulture,
                                Value) Then
                Found(NameAttribute.Value) = Value
            End If
        Next

        Return Found
    End Function

    Public Function GetLevelMarker(levelsetName As String) As Integer
        If levelsetName = ExtraDifficultLevelsetName Then
            Return My.Settings.ExtraDifficultArrivedLevel
        End If

        Return My.Settings.ClassicArrivedLevel
    End Function

    Public Function GetMoves(levelsetName As String) As Integer
        If levelsetName = ExtraDifficultLevelsetName Then
            Return My.Settings.ExtraDifficultMoves
        End If

        Return My.Settings.ClassicMoves
    End Function

    Public Function GetPushes(levelsetName As String) As Integer
        If levelsetName = ExtraDifficultLevelsetName Then
            Return My.Settings.ExtraDifficultPushes
        End If

        Return My.Settings.ClassicPushes
    End Function

    ''' <remarks>
    ''' Records one solved level: advances the marker and adds the effort spent. Does nothing when
    ''' the marker would not move, so replaying a level already beaten cannot inflate the totals.
    ''' Returns True when the progress was recorded.
    ''' </remarks>
    Public Function RecordSolvedLevel(levelsetName As String,
                                      unlockedLevel As Integer,
                                      moves As Integer,
                                      pushes As Integer) As Boolean
        If Not TracksProgress(levelsetName) Then
            Return False
        End If

        If unlockedLevel <= GetLevelMarker(levelsetName) Then
            Return False
        End If

        If levelsetName = ExtraDifficultLevelsetName Then
            My.Settings.ExtraDifficultArrivedLevel = unlockedLevel
            My.Settings.ExtraDifficultMoves += moves
            My.Settings.ExtraDifficultPushes += pushes
        Else
            My.Settings.ClassicArrivedLevel = unlockedLevel
            My.Settings.ClassicMoves += moves
            My.Settings.ClassicPushes += pushes
        End If

        Return True
    End Function
End Module
