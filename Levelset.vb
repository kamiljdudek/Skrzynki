Public Class Levelset
    Public Property Name As String
    Private ReadOnly AllLevelsInSet As System.Collections.Generic.List(Of String())
    Public Property AchievedLevel As Integer
    Public Property Moves As Integer
    Public Property Pushes As Integer

    Sub New(ByVal levelsetNameTranslated As String)
        Name = levelsetNameTranslated
        AllLevelsInSet = New System.Collections.Generic.List(Of String())
        ' Load stats from settings
    End Sub

    Sub AddLevel(ByVal boardMap() As String)
        Dim stream() As String = boardMap
        AllLevelsInSet.Add(stream)
    End Sub

    Public Function GetLevel(ByVal levelId As Integer) As Integer()
        Dim ImgGameFieldDescription = LevelParser.GetBoardStateIntegerFromMapString(AllLevelsInSet(levelId - 1))
        Return ImgGameFieldDescription
    End Function

    Public Function GetLevelInitialProperties(ByVal levelId As Integer) As LevelProperties
        Dim ImgGameFieldDescription() = LevelParser.GetBoardStateIntegerFromMapString(AllLevelsInSet(levelId - 1))
        Dim LP As LevelProperties = New LevelProperties
        Dim subset As Integer()
        subset = Array.FindAll(ImgGameFieldDescription, Function(value As Integer) value = 3)
        LP.NumberOfPlaces = subset.Length
        subset = Array.FindAll(ImgGameFieldDescription, Function(value As Integer) value = 2)
        LP.NumberOfBoxes = subset.Length
        subset = Array.FindAll(ImgGameFieldDescription, Function(value As Integer) value = 4)
        LP.BoxesOnPlaces = subset.Length
        subset = Array.FindAll(ImgGameFieldDescription, Function(value As Integer) value = 5)
        LP.PlayerLocation = subset.Length
        subset = Array.FindAll(ImgGameFieldDescription, Function(value As Integer) value = 6)
        LP.PlayerLocation += subset.Length
        Return LP
    End Function
    Public ReadOnly Property NumberOfLevels As Integer
        Get
            Return AllLevelsInSet.Count
        End Get
    End Property

    Sub UpdateStats(ByVal upstreamMaxLevel As Integer, ByVal upstreamMoves As Integer, ByVal upstreamPushes As Integer)
        AchievedLevel = upstreamMaxLevel
        Moves = upstreamMoves
        Pushes = upstreamPushes
    End Sub

    Sub Reset()
        AchievedLevel = 0
        Moves = 0
        Pushes = 0
    End Sub
End Class
