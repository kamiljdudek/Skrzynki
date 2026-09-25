' -------------------------------------------------------------------------------------------
' |                                         SKRZYNKI                                        |
' |                                 autor: Karol Kuczmarski                                 |
' -------------------------------------------------------------------------------------------
'
' A Sokoban puzzle. The boxes have to be arranged onto the marked places; only one box moves at
' a time, and only by being pushed away from the player.
' -------------------------------------------------------------------------------------------

''' <remarks>
''' One game in progress: the board, the attempt on the current level, and which levelset it comes
''' from. Everything it depends on is handed to it - the levelsets it can play and the store its
''' progress goes to - so it reads no settings of its own. The movement rules are in
''' MovementRules.vb; BoardItem, the board dimensions and the cell-encoding helpers are in Board.vb.
''' </remarks>
Partial Public Class Game
    Private ReadOnly Library As LevelsetLibrary
    Private ReadOnly Progress As IProgressStore

    ''' <remarks>The current arrangement of everything on the playing field.</remarks>
    Private Cells() As BoardItem = EmptyBoard(MinimumBoardSize)

    ''' <remarks>The side of the board being played on; see the indexing convention in Board.vb.</remarks>
    Private SideLength As Integer = MinimumBoardSize

    ''' <remarks>
    ''' The attempt on the level being played: every move in order, which is what Undo reverses
    ''' and what a solution is written from.
    ''' </remarks>
    Private ReadOnly RecordedMoves As New MoveHistory

    ''' <remarks>Where the player is standing, as an index into Cells.</remarks>
    Private PlayerLocation As Integer

    ''' <remarks>
    ''' The levelset being played: one of the built-in sets, or one opened from a file. Nothing
    ''' until a level has loaded.
    ''' </remarks>
    Private CurrentLevelset As Levelset

    ''' <remarks>
    ''' The built-in set last selected. Play returns to it when a set opened from a file is
    ''' finished, and it is the set whose progress is recorded. Nothing until one is selected.
    ''' </remarks>
    Private SelectedBuiltInLevelset As String

    Private LevelNumber As Integer
    Private MoveCount As Integer
    Private PushCount As Integer

    Public Sub New(levelsets As LevelsetLibrary, progress As IProgressStore)
        If levelsets Is Nothing Then
            Throw New ArgumentNullException(NameOf(levelsets))
        End If
        If progress Is Nothing Then
            Throw New ArgumentNullException(NameOf(progress))
        End If

        Library = levelsets
        Me.Progress = progress
    End Sub

    ' --- The state of play -----------------------------------------------------------------

    ''' <remarks>
    ''' The side of the square board being played on. It changes only when play moves to another
    ''' levelset, since every level of a set shares one board size.
    ''' </remarks>
    Public ReadOnly Property BoardSize() As Integer
        Get
            Return SideLength
        End Get
    End Property

    ''' <remarks>Contents of one board cell. Out-of-range indices read as BlankOuter.</remarks>
    Public ReadOnly Property BoardCell(cellIndex As Integer) As BoardItem
        Get
            If cellIndex < BoardFirstIndex OrElse cellIndex > Cells.Length - 1 Then
                Return BoardItem.BlankOuter
            End If
            Return Cells(cellIndex)
        End Get
    End Property

    Public ReadOnly Property CurrentPlayerLocation() As Integer
        Get
            Return PlayerLocation
        End Get
    End Property

    Public ReadOnly Property CurrentLevelNumber() As Integer
        Get
            Return LevelNumber
        End Get
    End Property

    Public ReadOnly Property NumberOfLevelsInCurrentLevelset() As Integer
        Get
            If CurrentLevelset Is Nothing Then
                Return 0
            End If
            Return CurrentLevelset.NumberOfLevels
        End Get
    End Property

    Public ReadOnly Property MovesPerformed() As Integer
        Get
            Return MoveCount
        End Get
    End Property

    Public ReadOnly Property PushesPerformed() As Integer
        Get
            Return PushCount
        End Get
    End Property

    ''' <remarks>The built-in set last selected; see SelectedBuiltInLevelset.</remarks>
    Public ReadOnly Property BuiltInLevelsetName() As String
        Get
            Return SelectedBuiltInLevelset
        End Get
    End Property

    Public ReadOnly Property IsPlayingCustomLevelset() As Boolean
        Get
            Return CustomLevelsetFileName IsNot Nothing
        End Get
    End Property

    ''' <remarks>Path of the levelset file currently open, if the game is playing one.</remarks>
    Public ReadOnly Property CustomLevelsetFileName() As String
        Get
            If CurrentLevelset Is Nothing Then
                Return Nothing
            End If
            Return CurrentLevelset.SourceFileName
        End Get
    End Property

    Public ReadOnly Property CanUndo() As Boolean
        Get
            Return Not RecordedMoves.IsEmpty
        End Get
    End Property

    ''' <remarks>
    ''' The attempt on the current level in LURD notation - the notation Sokoban solutions are
    ''' normally exchanged in, so this is what an exported solution consists of. Once the level is
    ''' solved, this string is a solution to it.
    ''' </remarks>
    Public ReadOnly Property CurrentAttemptLurd() As String
        Get
            Return RecordedMoves.Lurd
        End Get
    End Property

    Public ReadOnly Property IsCurrentLevelSolved() As Boolean
        Get
            Return IsBoardSolved(Cells)
        End Get
    End Property

    Public ReadOnly Property NumberOfGoalsOnCurrentLevel() As Integer
        Get
            Return GetTotalNumberOfGoalsOnBoard(Cells)
        End Get
    End Property

    Public ReadOnly Property NumberOfCoveredGoalsOnCurrentLevel() As Integer
        Get
            Return GetNumberOfPlacedBoxesOnBoard(Cells)
        End Get
    End Property

    ' --- Choosing what to play -------------------------------------------------------------

    ''' <remarks>
    ''' Loads a level onto the board and starts a fresh attempt at it. Returns False without
    ''' touching any state when there is no such level, so callers can report the failure rather
    ''' than crash on a bad index later on.
    ''' </remarks>
    Private Function LoadLevel(levelset As Levelset, levelId As Integer) As Boolean
        If levelset Is Nothing Then
            Return False
        End If

        Dim StartingBoard() As BoardItem = levelset.GetLevel(levelId)
        If StartingBoard Is Nothing Then
            Return False
        End If

        ' GetLevel hands over a copy of its own, so it can be played on directly.
        Cells = StartingBoard
        SideLength = levelset.BoardSize
        PlayerLocation = GetIndexOfPlayerOnBoard(Cells)
        CurrentLevelset = levelset
        LevelNumber = levelId

        MoveCount = 0
        PushCount = 0
        RecordedMoves.Clear()

        Return True
    End Function

    ''' <remarks>
    ''' The highest level of the set being played that the player may pick: any level of a set
    ''' opened from a file, which keeps no progress, and up to the furthest level reached in a
    ''' built-in one.
    ''' </remarks>
    Public ReadOnly Property HighestOpenLevel() As Integer
        Get
            If IsPlayingCustomLevelset Then
                Return NumberOfLevelsInCurrentLevelset
            End If
            Return Library.FurthestPlayableLevel(SelectedBuiltInLevelset, Progress)
        End Get
    End Property

    ''' <remarks>Starts the given level of the set being played, whichever that is.</remarks>
    Public Function PlayLevel(levelNumber As Integer) As Boolean
        Return LoadLevel(CurrentLevelset, levelNumber)
    End Function

    ''' <remarks>
    ''' Starts the given level of the selected built-in levelset, leaving a set opened from a file
    ''' if one is being played.
    ''' </remarks>
    Public Function PlayBuiltInLevel(levelNumber As Integer) As Boolean
        Return LoadLevel(Library.GetLevelset(SelectedBuiltInLevelset), levelNumber)
    End Function

    ''' <remarks>
    ''' Switches to one of the built-in levelsets, starting at its first level or, when asked to,
    ''' at the furthest level the player has reached. Nothing changes if the set cannot be loaded.
    ''' </remarks>
    Public Function SelectBuiltInLevelset(levelsetName As String,
                                          startAtFurthestLevel As Boolean) As Boolean
        Dim Selected As Levelset = Library.GetLevelset(levelsetName)

        Dim StartingLevel As Integer = 1
        If startAtFurthestLevel Then
            StartingLevel = Library.FurthestPlayableLevel(levelsetName, Progress)
        End If

        ' Saved progress can point past the end of the set; the first level always exists.
        If Not LoadLevel(Selected, StartingLevel) AndAlso Not LoadLevel(Selected, 1) Then
            Return False
        End If

        SelectedBuiltInLevelset = levelsetName
        Return True
    End Function

    ''' <remarks>
    ''' Reads a level file and switches play over to its first level. Nothing about the game in
    ''' progress changes unless that succeeds, so a bad file leaves the current level untouched.
    ''' </remarks>
    Public Function OpenLevelsetFromFile(levelFileName As String) As Boolean
        Dim FromFile As Levelset

        Try
            FromFile = Levelset.FromFile(levelFileName)
        Catch ex As System.IO.IOException
            Return False
        Catch ex As UnauthorizedAccessException
            Return False
        End Try

        ' Always starts at level 1 of the new set, whatever level the previous set was on.
        Return LoadLevel(FromFile, 1)
    End Function

    ''' <remarks>
    ''' Moves on to the level after the one just solved. Returns False when the set is finished or
    ''' the next level cannot be loaded, leaving it to the caller to decide what happens next.
    ''' </remarks>
    Public Function AdvanceToNextLevel() As Boolean
        Return PlayLevel(LevelNumber + 1)
    End Function

    Public Function RestartLevel() As Boolean
        Return PlayLevel(LevelNumber)
    End Function

    ''' <remarks>
    ''' Banks the moves and pushes spent on the level just completed and advances the furthest
    ''' reached marker. Call once per solved level, including the last one of a set.
    '''
    ''' The marker names the next level to play, so completing level N sets it to N + 1 and
    ''' completing the last level of a set takes it one past the end - which is what distinguishes
    ''' a finished set from merely standing on its final level. LevelsetLibrary.FurthestPlayableLevel
    ''' clamps it back to a level number for anything that has to play or display one.
    '''
    ''' Progress is only kept for the built-in sets; a levelset opened from a file has no
    ''' persisted statistics of its own.
    ''' </remarks>
    Public Sub RecordProgressForSolvedLevel()
        If IsPlayingCustomLevelset Then
            Exit Sub
        End If

        Progress.RecordSolvedLevel(SelectedBuiltInLevelset, LevelNumber + 1, MoveCount, PushCount)
    End Sub

    ' --- Taking a move back ----------------------------------------------------------------

    ''' <remarks>
    ''' Takes back the last move by reversing it, rather than by restoring a copy of the board:
    ''' the player steps back the way they came, and a box that was pushed is pulled back with
    ''' them. Each square is re-encoded from the floor it already reports, so goals survive.
    ''' </remarks>
    Public Sub Undo()
        If RecordedMoves.IsEmpty Then
            Exit Sub
        End If

        Dim LastMove As MoveRecord = RecordedMoves.TakeLast()
        Dim Player As Cell = Cell.FromIndex(PlayerLocation, SideLength)
        Dim CameFrom As Cell = Player.Neighbour(Opposite(LastMove.Direction))

        If LastMove.PushedBox Then
            ' The box is one square further along than the player, and gets pulled back with them.
            Dim BoxCell As Cell = Player.Neighbour(LastMove.Direction)
            Cells(BoxCell.Index) = WithNothing(Cells(BoxCell.Index))
            Cells(Player.Index) = WithBox(Cells(Player.Index))
            PushCount -= 1
        Else
            Cells(Player.Index) = WithNothing(Cells(Player.Index))
        End If

        Cells(CameFrom.Index) = WithPlayer(Cells(CameFrom.Index))
        PlayerLocation = CameFrom.Index
        MoveCount -= 1
    End Sub
End Class
