''' <remarks>
''' A named collection of levels. A levelset holds level data only; progress and statistics are
''' kept by the game's IProgressStore.
''' </remarks>
Public NotInheritable Class Levelset
    Public ReadOnly Property Name As String

    ''' <remarks>The file the set was read from; Nothing for a set built into the game.</remarks>
    Public ReadOnly Property SourceFileName As String

    ''' <remarks>
    ''' The side of the square board every level of this set is played on: at least
    ''' Board.MinimumSize, and large enough for the set's largest level. Worked out as the set is
    ''' read; nothing about it is stored in the file.
    ''' </remarks>
    Public ReadOnly Property BoardSize As Integer

    Private ReadOnly Levels As New List(Of Board)

    Private Sub New(levelsetName As String, sourceFileName As String, levelsetText As String)
        Name = levelsetName
        Me.SourceFileName = sourceFileName

        Dim LevelTexts As List(Of String)
        If LevelParser.IsBoxFormat(levelsetText) Then
            LevelTexts = LevelParser.SplitBoxLevelTexts(levelsetText)
        Else
            LevelTexts = LevelParser.SplitIntoLevelTexts(levelsetText)
        End If

        ' Read in two passes, because the board every level is laid out on depends on them all.
        Dim PlayableLevels As New List(Of List(Of String))
        Dim Size As Integer = Board.MinimumSize

        For Each LevelText As String In LevelTexts
            Dim Rows As List(Of String) = LevelParser.ReadLevelRows(LevelText)

            ' Levels that cannot be played, or that are too large to show, are skipped rather than
            ' stored as Nothing, so that NumberOfLevels only ever counts levels that can be played.
            If Rows Is Nothing OrElse LevelParser.LevelExtent(Rows) > Board.MaximumSize Then
                Continue For
            End If

            PlayableLevels.Add(Rows)
            Size = Math.Max(Size, LevelParser.LevelExtent(Rows))
        Next

        BoardSize = Size
        For Each Rows As List(Of String) In PlayableLevels
            Levels.Add(LevelParser.LayOutLevel(Rows, Size))
        Next
    End Sub

    ''' <remarks>A set built from level text held in memory, such as an embedded resource.</remarks>
    Public Shared Function FromText(levelsetName As String, levelsetText As String) As Levelset
        Return New Levelset(levelsetName, Nothing, If(levelsetText, String.Empty))
    End Function

    ''' <remarks>
    ''' A set read from a SOK or .box file and named after it. Throws IOException or
    ''' UnauthorizedAccessException when the file cannot be read.
    ''' </remarks>
    Public Shared Function FromFile(fileName As String) As Levelset
        Dim LevelsetText As String = System.IO.File.ReadAllText(fileName, System.Text.Encoding.ASCII)
        Return New Levelset(System.IO.Path.GetFileName(fileName), fileName, LevelsetText)
    End Function

    Public Function ContainsLevel(levelNumber As Integer) As Boolean
        Return levelNumber >= 1 AndAlso levelNumber <= Levels.Count
    End Function

    ''' <remarks>
    ''' A copy of the level's starting board, which the caller is free to play on. Returns Nothing
    ''' for a level number outside the set, rather than throwing.
    ''' </remarks>
    Public Function GetLevel(levelNumber As Integer) As Board
        If Not ContainsLevel(levelNumber) Then
            Return Nothing
        End If

        Return Levels(levelNumber - 1).Clone()
    End Function

    Public ReadOnly Property NumberOfLevels As Integer
        Get
            Return Levels.Count
        End Get
    End Property
End Class
