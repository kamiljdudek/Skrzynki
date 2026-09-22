Public Class Levelset
    Public Property Name As String
    Private ReadOnly AllLevelsInSet As System.Collections.Generic.List(Of String())
    Public Property AchievedLevel As Integer
    Public Property Moves As Integer
    Public Property Pushes As Integer

    ' Suppression made because CA1026 is deprecated in FxCop and Optional var will not be skipped
#Disable Warning IDE0079 ' Remove unnecessary suppression
    <CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1026:DefaultParametersShouldNotBeUsed")>
    Public Sub New(levelsetNameTranslated As String, Optional isFromFile As Boolean = False)

        Name = levelsetNameTranslated
        AllLevelsInSet = New System.Collections.Generic.List(Of String())

        ' A set loaded from a file carries no saved progress. Note that constructing one must not
        ' switch the game over to it - that only happens once the set is known to be usable, via
        ' StartCustomLevelset.
        If isFromFile = True Then
            Me.AchievedLevel = 0
            Me.Moves = 0
            Me.Pushes = 0
        End If
    End Sub
#Enable Warning IDE0079 ' Remove unnecessary suppression

    Sub AddLevel(ByVal boardMap() As String)
        Dim stream() As String = boardMap
        AllLevelsInSet.Add(stream)
    End Sub

    ' Suppression made because the parameter is validated implicitly from resource
#Disable Warning IDE0079 ' Remove unnecessary suppression
    <CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1062:Validate arguments of public methods", MessageId:="0")>
    Sub AddAllLevels(ByVal levelStream As ArrayList)
        If levelStream.Count > 0 Then
            For Each SokobanCompliantLevel As String In levelStream
                Dim SkrzynkiCompliantLevel = GetMapStringFromLevel(SokobanCompliantLevel)
                ' Levels that do not fit the board are skipped rather than stored as Nothing, so
                ' that NumberOfLevels only ever counts levels that can actually be played.
                If SkrzynkiCompliantLevel IsNot Nothing Then
                    Me.AddLevel(SkrzynkiCompliantLevel)
                End If
            Next
        End If
    End Sub
#Enable Warning IDE0079 ' Remove unnecessary suppression

    Public ReadOnly Property ContainsLevel(ByVal levelId As Integer) As Boolean
        Get
            Return levelId >= 1 AndAlso levelId <= AllLevelsInSet.Count
        End Get
    End Property

    ''' <remarks>Returns Nothing for a level number outside the set, rather than throwing.</remarks>
    Public Function GetLevel(ByVal levelId As Integer) As Integer()
        If Not ContainsLevel(levelId) Then
            Return Nothing
        End If

        Dim ImgGameFieldDescription = LevelParser.GetBoardStateIntegerFromMapString(AllLevelsInSet(levelId - 1))
        Return ImgGameFieldDescription
    End Function

    ''' <remarks>Returns Nothing for a level number outside the set, rather than throwing.</remarks>
    Public Function GetLevelInitialProperties(ByVal levelId As Integer) As LevelProperties
        If Not ContainsLevel(levelId) Then
            Return Nothing
        End If

        Dim ImgGameFieldDescription() = LevelParser.GetBoardStateIntegerFromMapString(AllLevelsInSet(levelId - 1))
        Dim LP As New LevelProperties
        Dim subset As Integer()
        subset = Array.FindAll(ImgGameFieldDescription, Function(value As Integer) value = BoardItem.PlaceForBox)
        LP.NumberOfPlaces = subset.Length
        subset = Array.FindAll(ImgGameFieldDescription, Function(value As Integer) value = BoardItem.Box)
        LP.NumberOfBoxes = subset.Length
        subset = Array.FindAll(ImgGameFieldDescription, Function(value As Integer) value = BoardItem.BoxOnPlace)
        LP.NumberOfBoxesOnPlaces = subset.Length

        Dim ix As Integer = Array.IndexOf(ImgGameFieldDescription, CInt(BoardItem.Player))
        If ix < 0 Then
            LP.PlayerLocation = Array.IndexOf(ImgGameFieldDescription, CInt(BoardItem.PlayerOnPlace))
        Else
            LP.PlayerLocation = ix
        End If

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
