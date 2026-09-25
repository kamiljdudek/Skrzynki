''' <remarks>
''' The built-in levelsets, keyed by name. A set opened from a file is never registered here: the
''' Game playing it holds it directly, so loading a file cannot disturb the built-in sets or their
''' progress.
''' </remarks>
Public NotInheritable Class LevelsetLibrary
    Public Const ClassicLevelsetName As String = "Classic"
    Public Const ExtraDifficultLevelsetName As String = "XS"

    Private ReadOnly Levelsets As New Dictionary(Of String, Levelset)(StringComparer.Ordinal)
    Private ReadOnly Names As New List(Of String)

    ''' <remarks>The two sets that ship with the game, parsed from the embedded resources.</remarks>
    Public Shared Function LoadBuiltIn() As LevelsetLibrary
        Dim Library As New LevelsetLibrary()
        Library.Add(Levelset.FromText(ClassicLevelsetName, My.Resources.LevelsetResource.Classic_SOK))
        Library.Add(Levelset.FromText(ExtraDifficultLevelsetName, My.Resources.LevelsetResource.XS_SOK))
        Return Library
    End Function

    Public Sub Add(levelset As Levelset)
        If levelset Is Nothing Then
            Throw New ArgumentNullException(NameOf(levelset))
        End If

        Levelsets.Add(levelset.Name, levelset)
        Names.Add(levelset.Name)
    End Sub

    ''' <remarks>The names of the sets held here, in the order they were added.</remarks>
    Public ReadOnly Property LevelsetNames As IReadOnlyList(Of String)
        Get
            Return Names.AsReadOnly()
        End Get
    End Property

    Public Function GetLevelset(levelsetName As String) As Levelset
        Dim Found As Levelset = Nothing
        If levelsetName IsNot Nothing AndAlso Levelsets.TryGetValue(levelsetName, Found) Then
            Return Found
        End If

        Return Nothing
    End Function

    ''' <remarks>Size of a set held here, or 0 when there is no such set.</remarks>
    Public Function NumberOfLevelsIn(levelsetName As String) As Integer
        Dim Levelset As Levelset = GetLevelset(levelsetName)
        If Levelset Is Nothing Then
            Return 0
        End If

        Return Levelset.NumberOfLevels
    End Function

    ''' <remarks>
    ''' The highest level the player may open in the named set: the progress marker, which runs
    ''' one past the end of a finished set, clamped to a level that exists.
    ''' </remarks>
    Public Function FurthestPlayableLevel(levelsetName As String, progress As IProgressStore) As Integer
        If progress Is Nothing Then
            Throw New ArgumentNullException(NameOf(progress))
        End If

        Return ClampToLevelset(progress.GetLevelMarker(levelsetName), levelsetName)
    End Function

    ''' <remarks>Clamps a level number to one that exists in the named set.</remarks>
    Public Function ClampToLevelset(levelNumber As Integer, levelsetName As String) As Integer
        Dim LevelCount As Integer = NumberOfLevelsIn(levelsetName)
        If LevelCount < 1 Then
            Return 1
        End If

        Return Math.Max(1, Math.Min(levelNumber, LevelCount))
    End Function
End Class
