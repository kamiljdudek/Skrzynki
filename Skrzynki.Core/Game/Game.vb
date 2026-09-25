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
''' progress goes to - so it reads no settings of its own. It announces every change to the board
''' through LevelLoaded and PlayerMoved, so whoever shows it never has to guess when to redraw.
''' The movement rules are in MovementRules.vb.
''' </remarks>
Partial Public Class Game
    Private ReadOnly Library As LevelsetLibrary
    Private ReadOnly Progress As IProgressStore

    ''' <remarks>
    ''' The current arrangement of everything on the playing field. (Qualified, because inside
    ''' this class the name Board means the property below.)
    ''' </remarks>
    Private CurrentBoard As New Board(Skrzynki.Board.MinimumSize)

    Private PlayerCell As Cell

    ''' <remarks>
    ''' The attempt on the level being played: every move in order, which is what Undo reverses
    ''' and what a solution is written from.
    ''' </remarks>
    Private ReadOnly RecordedMoves As New MoveHistory

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

    ''' <remarks>
    ''' Raised whenever a level is put on the board: another level, the same one restarted, or the
    ''' first level of another set - whose board may be of another size.
    ''' </remarks>
    Public Event LevelLoaded As EventHandler

    ''' <remarks>Raised whenever the player has moved, or a move has been taken back.</remarks>
    Public Event PlayerMoved As EventHandler

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
    ''' The board being played on, for looking at. A new board object is put in place each time a
    ''' level loads, so anything holding on to it should pick it up again on LevelLoaded.
    ''' </remarks>
    Public ReadOnly Property Board() As IReadOnlyBoard
        Get
            Return CurrentBoard
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

    ''' <remarks>
    ''' The name of the set being played: a built-in set's internal name, or the file name of a
    ''' set opened from disk. Nothing until a level has loaded.
    ''' </remarks>
    Public ReadOnly Property CurrentLevelsetName() As String
        Get
            Return CurrentLevelset?.Name
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
            Return CurrentLevelset?.SourceFileName IsNot Nothing
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
            Return CurrentBoard.IsSolved()
        End Get
    End Property

    Public ReadOnly Property NumberOfGoalsOnCurrentLevel() As Integer
        Get
            Return CurrentBoard.CountGoals()
        End Get
    End Property

    Public ReadOnly Property NumberOfCoveredGoalsOnCurrentLevel() As Integer
        Get
            Return CurrentBoard.CountCoveredGoals()
        End Get
    End Property

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

    ' --- Choosing what to play -------------------------------------------------------------

    ''' <remarks>
    ''' Loads a level onto the board and starts a fresh attempt at it. Returns False without
    ''' touching any state when there is no such level, so callers can report the failure rather
    ''' than crash on a bad index later on.
    ''' </remarks>
    Private Function LoadLevel(levelset As Levelset, levelId As Integer) As Boolean
        Dim StartingBoard As Board = levelset?.GetLevel(levelId)
        If StartingBoard Is Nothing Then
            Return False
        End If

        Dim Player As Cell? = StartingBoard.FindPlayer()
        If Not Player.HasValue Then
            Return False
        End If

        ' GetLevel hands over a copy of its own, so it can be played on directly.
        CurrentBoard = StartingBoard
        PlayerCell = Player.Value
        CurrentLevelset = levelset
        LevelNumber = levelId

        MoveCount = 0
        PushCount = 0
        RecordedMoves.Clear()

        RaiseEvent LevelLoaded(Me, EventArgs.Empty)
        Return True
    End Function

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
        If Selected Is Nothing Then
            Return False
        End If

        ' Recorded first, so that anyone reacting to LevelLoaded already sees the new set.
        Dim PreviousSelection As String = SelectedBuiltInLevelset
        SelectedBuiltInLevelset = levelsetName

        Dim StartingLevel As Integer = 1
        If startAtFurthestLevel Then
            StartingLevel = Library.FurthestPlayableLevel(levelsetName, Progress)
        End If

        ' Saved progress can point past the end of the set; the first level always exists.
        If Not LoadLevel(Selected, StartingLevel) AndAlso Not LoadLevel(Selected, 1) Then
            SelectedBuiltInLevelset = PreviousSelection
            Return False
        End If

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
        Dim CameFrom As Cell = PlayerCell.Neighbour(LastMove.Direction.Opposite())

        If LastMove.PushedBox Then
            ' The box is one square further along than the player, and gets pulled back with them.
            Dim BoxCell As Cell = PlayerCell.Neighbour(LastMove.Direction)
            CurrentBoard(BoxCell) = CurrentBoard(BoxCell).WithNothing()
            CurrentBoard(PlayerCell) = CurrentBoard(PlayerCell).WithBox()
            PushCount -= 1
        Else
            CurrentBoard(PlayerCell) = CurrentBoard(PlayerCell).WithNothing()
        End If

        CurrentBoard(CameFrom) = CurrentBoard(CameFrom).WithPlayer()
        PlayerCell = CameFrom
        MoveCount -= 1

        RaiseEvent PlayerMoved(Me, EventArgs.Empty)
    End Sub
End Class
