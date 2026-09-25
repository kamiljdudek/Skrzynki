' A levelset holds level data only. Progress and statistics live in My.Settings, keyed per set,
' and ProgressStore is the only thing that reads and writes them.
Public Class Levelset
    Public ReadOnly Property Name As String

    Private ReadOnly Levels As New List(Of BoardItem())

    Public Sub New(levelsetName As String)
        Name = levelsetName
    End Sub

    Public Sub AddAllLevels(levelTexts As IEnumerable(Of String))
        If levelTexts Is Nothing Then
            Exit Sub
        End If

        For Each SokobanText As String In levelTexts
            Dim Level() As BoardItem = ParseLevel(SokobanText)
            ' Levels that cannot be played are skipped rather than stored as Nothing, so that
            ' NumberOfLevels only ever counts levels that can actually be played.
            If Level IsNot Nothing Then
                Levels.Add(Level)
            End If
        Next
    End Sub

    Public ReadOnly Property ContainsLevel(levelNumber As Integer) As Boolean
        Get
            Return levelNumber >= 1 AndAlso levelNumber <= Levels.Count
        End Get
    End Property

    ''' <remarks>
    ''' A copy of the level's starting board, which the caller is free to play on. Returns Nothing
    ''' for a level number outside the set, rather than throwing.
    ''' </remarks>
    Public Function GetLevel(levelNumber As Integer) As BoardItem()
        If Not ContainsLevel(levelNumber) Then
            Return Nothing
        End If

        Return CType(Levels(levelNumber - 1).Clone(), BoardItem())
    End Function

    Public ReadOnly Property NumberOfLevels As Integer
        Get
            Return Levels.Count
        End Get
    End Property
End Class
