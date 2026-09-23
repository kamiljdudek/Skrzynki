' A levelset holds level data only. Progress and statistics live in My.Settings, keyed per set,
' and are read and written there directly.
Public Class Levelset
    Public Property Name As String
    Private ReadOnly AllLevelsInSet As System.Collections.Generic.List(Of String())

    ''' <remarks>
    ''' Constructing a set does not switch the game over to it; that happens in
    ''' OpenLevelsetFromFile, once the set is known to be usable.
    ''' </remarks>
    Public Sub New(levelsetNameTranslated As String)
        Name = levelsetNameTranslated
        AllLevelsInSet = New System.Collections.Generic.List(Of String())
    End Sub

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

End Class
