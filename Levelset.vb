' A levelset holds level data only. Progress and statistics are kept by the game's IProgressStore.
Public Class Levelset
    Public ReadOnly Property Name As String

    ''' <remarks>The file the set was read from; Nothing for a set built into the game.</remarks>
    Public ReadOnly Property SourceFileName As String

    ''' <remarks>
    ''' The side of the square board every level of this set is played on: at least
    ''' MinimumBoardSize, and large enough for the set's largest level. Worked out as the set is
    ''' read; nothing about it is stored in the file.
    ''' </remarks>
    Public ReadOnly Property BoardSize As Integer

    Private ReadOnly Levels As New List(Of BoardItem())

    Private Sub New(levelsetName As String, sourceFileName As String, levelsetText As String)
        Name = levelsetName
        Me.SourceFileName = sourceFileName

        ' Read in two passes, because the board every level is laid out on depends on them all.
        Dim PlayableLevels As New List(Of List(Of String))
        Dim Size As Integer = MinimumBoardSize

        For Each LevelText As String In SplitIntoLevelTexts(levelsetText)
            Dim Rows As List(Of String) = ReadLevelRows(LevelText)

            ' Levels that cannot be played, or that are too large to show, are skipped rather than
            ' stored as Nothing, so that NumberOfLevels only ever counts levels that can be played.
            If Rows Is Nothing OrElse LevelExtent(Rows) > MaximumBoardSize Then
                Continue For
            End If

            PlayableLevels.Add(Rows)
            Size = Math.Max(Size, LevelExtent(Rows))
        Next

        BoardSize = Size
        For Each Rows As List(Of String) In PlayableLevels
            Levels.Add(LayOutLevel(Rows, Size))
        Next
    End Sub

    ''' <remarks>A set built from SOK text held in memory, such as an embedded resource.</remarks>
    Public Shared Function FromText(levelsetName As String, levelsetText As String) As Levelset
        Return New Levelset(levelsetName, Nothing, If(levelsetText, String.Empty))
    End Function

    ''' <remarks>
    ''' A set read from a SOK file and named after it. Throws IOException or
    ''' UnauthorizedAccessException when the file cannot be read.
    ''' </remarks>
    Public Shared Function FromFile(fileName As String) As Levelset
        Dim LevelsetText As String = System.IO.File.ReadAllText(fileName, System.Text.Encoding.ASCII)
        Return New Levelset(System.IO.Path.GetFileName(fileName), fileName, LevelsetText)
    End Function

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
