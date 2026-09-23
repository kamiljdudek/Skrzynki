' A levelset holds level data only. Progress and statistics live in My.Settings, keyed per set,
' and are read and written there directly.
Public Class Levelset
    Public Property Name As String

    Private ReadOnly LevelMaps As New List(Of String())

    ''' <remarks>
    ''' Constructing a set does not switch the game over to it; that happens in
    ''' OpenLevelsetFromFile, once the set is known to be usable.
    ''' </remarks>
    Public Sub New(levelsetName As String)
        Name = levelsetName
    End Sub

    Public Sub AddLevel(levelMap() As String)
        LevelMaps.Add(levelMap)
    End Sub

    Public Sub AddAllLevels(levelTexts As IEnumerable(Of String))
        If levelTexts Is Nothing Then
            Exit Sub
        End If

        For Each SokobanText As String In levelTexts
            Dim LevelMap() As String = BuildLevelMap(SokobanText)
            ' Levels that do not fit the board are skipped rather than stored as Nothing, so that
            ' NumberOfLevels only ever counts levels that can actually be played.
            If LevelMap IsNot Nothing Then
                AddLevel(LevelMap)
            End If
        Next
    End Sub

    Public ReadOnly Property ContainsLevel(levelNumber As Integer) As Boolean
        Get
            Return levelNumber >= 1 AndAlso levelNumber <= LevelMaps.Count
        End Get
    End Property

    ''' <remarks>Returns Nothing for a level number outside the set, rather than throwing.</remarks>
    Public Function GetLevel(levelNumber As Integer) As Integer()
        If Not ContainsLevel(levelNumber) Then
            Return Nothing
        End If

        Return BuildBoardState(LevelMaps(levelNumber - 1))
    End Function

    Public ReadOnly Property NumberOfLevels As Integer
        Get
            Return LevelMaps.Count
        End Get
    End Property
End Class
