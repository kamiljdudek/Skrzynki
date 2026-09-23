Partial Public Module 倉庫番
    ' -------------------------------------------------------------------------------------------
    ' |                                         SKRZYNKI                                        |
    ' |                                 autor: Karol Kuczmarski                                 |
    ' -------------------------------------------------------------------------------------------
    '
    ' A Sokoban puzzle. The boxes have to be arranged onto the marked places; only one box moves
    ' at a time, and only by being pushed away from the player.
    '
    ' The game runs on two parallel arrays: GameBoard below holds what stands on each square, and
    ' GameBoardForm.CellPictures holds the picture showing it. BoardItem, the board dimensions and
    ' the cell-encoding helpers live in Board.vb.
    ' -------------------------------------------------------------------------------------------

    ''' <remarks>The current arrangement of everything on the playing field.</remarks>
    Public GameBoard(BoardCellCount) As Integer

    ' The attempt on the level being played: every move in order, which is what Undo reverses and
    ' what a solution is written from. The two collections after it hold one board snapshot per
    ' move, read only by the debug check in DiscardRecordedSnapshot.
    Private ReadOnly RecordedMoves As New MoveHistory
    Private ReadOnly AllGameBoardStates As New System.Collections.ObjectModel.Collection(Of Integer())
    Private ReadOnly AllPushStates As New System.Collections.ObjectModel.Collection(Of Boolean)

    ''' <remarks>Where the player is standing, as an index into GameBoard.</remarks>
    Public PlayerLocation As Integer

    ''' <remarks>Whether the move just made pushed a box; recorded with the move.</remarks>
    Public PushHasJustBeenPerformed As Boolean

    ''' <remarks>Whether the levelset being played was opened from a file.</remarks>
    Public ExternalCustomLevel As Boolean

    Private SizeOfCurrentLevelset As Integer

    ''' <remarks>Number of the level being played.</remarks>
    Public CurrentlyPlayedLevelId As Integer

    ''' <remarks>Moves and pushes spent on the level being played.</remarks>
    Public MovesPerformedOnCurrentLevel As Integer
    Public PushesPerformedOnCurrentLevel As Integer

    ''' <remarks>Path of the levelset file being played, when there is one.</remarks>
    Public FileName As String

    ' --- Game state, as seen from the outside -------------------------------------------------
    ' The fields above are shared with the movement code in this module. Callers outside it -
    ' GameBoardForm in particular - use the members below, and never read or write that state
    ' directly.

    ''' <remarks>
    ''' Name of the levelset currently being played. A levelset opened from a file is registered
    ''' under LevelsetLibrary.CustomLevelsetName rather than under My.Settings.LevelSet, so anything
    ''' that needs to reach for the active set has to ask here instead of reading the setting.
    ''' </remarks>
    Public ReadOnly Property CurrentLevelsetName() As String
        Get
            If ExternalCustomLevel Then
                Return LevelsetLibrary.CustomLevelsetName
            End If
            Return My.Settings.LevelSet
        End Get
    End Property

    ''' <remarks>Contents of one board cell. Out-of-range indices read as BlankOuter.</remarks>
    Public ReadOnly Property BoardCell(cellIndex As Integer) As Integer
        Get
            If Not IsOnBoard(cellIndex) Then
                Return CInt(BoardItem.BlankOuter)
            End If
            Return GameBoard(cellIndex)
        End Get
    End Property

    Public ReadOnly Property CurrentPlayerLocation() As Integer
        Get
            Return PlayerLocation
        End Get
    End Property

    Public ReadOnly Property CurrentLevelNumber() As Integer
        Get
            Return CurrentlyPlayedLevelId
        End Get
    End Property

    Public ReadOnly Property NumberOfLevelsInCurrentLevelset() As Integer
        Get
            Return SizeOfCurrentLevelset
        End Get
    End Property

    ''' <remarks>Size of any known levelset, or 0 when there is no such set.</remarks>
    Public ReadOnly Property NumberOfLevelsIn(levelsetName As String) As Integer
        Get
            Dim Levelset As Levelset = LevelsetLibrary.GetLevelset(levelsetName)
            If Levelset Is Nothing Then
                Return 0
            End If
            Return Levelset.NumberOfLevels
        End Get
    End Property

    Public ReadOnly Property MovesPerformed() As Integer
        Get
            Return MovesPerformedOnCurrentLevel
        End Get
    End Property

    Public ReadOnly Property PushesPerformed() As Integer
        Get
            Return PushesPerformedOnCurrentLevel
        End Get
    End Property

    Public ReadOnly Property IsPlayingCustomLevelset() As Boolean
        Get
            Return ExternalCustomLevel
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

    Public ReadOnly Property CurrentAttemptPushCount() As Integer
        Get
            Return RecordedMoves.PushCount
        End Get
    End Property

    Public ReadOnly Property IsCurrentLevelSolved() As Boolean
        Get
            Return GameBoardDetails.IsBoardSolved(GameBoard)
        End Get
    End Property

    Public ReadOnly Property NumberOfGoalsOnCurrentLevel() As Integer
        Get
            Return GameBoardDetails.GetTotalNumberOfGoalsOnBoard(GameBoard)
        End Get
    End Property

    Public ReadOnly Property NumberOfCoveredGoalsOnCurrentLevel() As Integer
        Get
            Return GameBoardDetails.GetNumberOfPlacedBoxesOnBoard(GameBoard)
        End Get
    End Property

    ''' <remarks>Path of the levelset file currently open, if the game is playing one.</remarks>
    Public ReadOnly Property CustomLevelsetFileName() As String
        Get
            Return FileName
        End Get
    End Property

    Public Sub ClearUndoHistory()
        RecordedMoves.Clear()
        AllGameBoardStates.Clear()
        AllPushStates.Clear()
    End Sub

    ''' <remarks>
    ''' Loads a level into the shared game state and resets the per-level counters. Returns False
    ''' without touching any state when the levelset is missing, the level number is out of range,
    ''' or the level has no player on it - so callers can report the failure rather than crash on
    ''' a bad index later on.
    ''' </remarks>
    Private Function LoadLevelIntoGameState(levelsetName As String, levelId As Integer) As Boolean
        Dim Levelset As Levelset = LevelsetLibrary.GetLevelset(levelsetName)
        If Levelset Is Nothing Then
            Return False
        End If

        Dim BoardState() As Integer = Levelset.GetLevel(levelId)
        If BoardState Is Nothing Then
            Return False
        End If

        Dim StartingLocation As Integer = GameBoardDetails.GetIndexOfPlayerOnBoard(BoardState)
        If StartingLocation < BoardFirstIndex OrElse StartingLocation > BoardCellCount Then
            Return False
        End If

        Array.Copy(BoardState, GameBoard, GameBoard.Length)
        PlayerLocation = StartingLocation
        CurrentlyPlayedLevelId = levelId
        SizeOfCurrentLevelset = Levelset.NumberOfLevels

        MovesPerformedOnCurrentLevel = 0
        PushesPerformedOnCurrentLevel = 0
        PushHasJustBeenPerformed = False
        ClearUndoHistory()

        Return True
    End Function

    ''' <remarks>
    ''' Banks the moves and pushes spent on the level just completed and advances the furthest
    ''' reached marker. Call once per solved level, including the last one of a set.
    '''
    ''' The marker names the next level to play, so completing level N sets it to N + 1 and
    ''' completing the last level of a set takes it one past the end - which is what distinguishes
    ''' a finished set from merely standing on its final level. FurthestPlayableLevel clamps it
    ''' back to a level number for anything that has to play or display one.
    '''
    ''' Effort is banked only when the marker actually advances, so beating a level a second time
    ''' does not add to the totals again.
    '''
    ''' Progress is only kept for the two built-in sets; a levelset opened from a file has no
    ''' persisted statistics of its own.
    ''' </remarks>
    Public Sub RecordProgressForSolvedLevel()
        If ExternalCustomLevel Then
            Exit Sub
        End If

        ProgressStore.RecordSolvedLevel(My.Settings.LevelSet,
                                        CurrentlyPlayedLevelId + 1,
                                        MovesPerformedOnCurrentLevel,
                                        PushesPerformedOnCurrentLevel)
    End Sub

    ''' <remarks>
    ''' Moves on to the level after the one just solved. Returns False when the set is finished or
    ''' the next level cannot be loaded, leaving it to the caller to decide what happens next.
    ''' </remarks>
    Public Function AdvanceToNextLevel() As Boolean
        If CurrentlyPlayedLevelId + 1 > SizeOfCurrentLevelset Then
            Return False
        End If

        Return LoadLevelIntoGameState(CurrentLevelsetName, CurrentlyPlayedLevelId + 1)
    End Function
    Public Function NewGame(whichLevel As Integer) As Boolean
        If Not LoadLevelIntoGameState(My.Settings.LevelSet, whichLevel) Then
            Return False
        End If

        ExternalCustomLevel = False
        Return True
    End Function

    ''' <remarks>
    ''' Prepares the levelsets and starts play in the set named by the settings. The one call a
    ''' host needs to make before showing a board.
    ''' </remarks>
    Public Function StartGame() As Boolean
        ProgressStore.MigrateLegacyProgress()
        LevelsetLibrary.LoadAllLevelsets()
        Return SelectBuiltInLevelset(My.Settings.LevelSet)
    End Function

    ''' <remarks>
    ''' Switches to one of the built-in levelsets, starting either at its first level or at the
    ''' furthest the player has reached, according to the BeginFromArrivedLevel setting.
    ''' </remarks>
    Public Function SelectBuiltInLevelset(levelsetName As String) As Boolean
        Dim PreviousLevelset As String = My.Settings.LevelSet
        My.Settings.LevelSet = levelsetName

        Dim StartingLevel As Integer = 1
        If My.Settings.BeginFromArrivedLevel Then
            StartingLevel = FurthestPlayableLevel
        End If

        If NewGame(StartingLevel) Then
            Return True
        End If

        ' Saved progress can point past the end of the set; the first level always exists.
        If NewGame(1) Then
            Return True
        End If

        My.Settings.LevelSet = PreviousLevelset
        Return False
    End Function

    ''' <remarks>
    ''' Reads a level file, registers it as the custom levelset and switches play over to its
    ''' first level. Nothing about the game in progress changes unless the whole thing succeeds,
    ''' so a bad file leaves the current level untouched.
    ''' </remarks>
    Public Function OpenLevelsetFromFile(levelFileName As String) As Boolean
        Dim LevelsRead As List(Of String)

        Try
            LevelsRead = SplitIntoLevelTexts(levelFileName, True)
        Catch ex As System.IO.IOException
            Return False
        Catch ex As UnauthorizedAccessException
            Return False
        End Try

        Dim LevelsetCustom As New Levelset(LevelsetLibrary.CustomLevelsetName)
        LevelsetCustom.AddAllLevels(LevelsRead)
        If LevelsetCustom.NumberOfLevels < 1 Then
            Return False
        End If

        Dim PreviouslyRegistered As Levelset = LevelsetLibrary.GetLevelset(LevelsetLibrary.CustomLevelsetName)
        If PreviouslyRegistered IsNot Nothing Then
            LevelsetLibrary.Levelsets.Remove(LevelsetLibrary.CustomLevelsetName)
        End If
        LevelsetLibrary.Levelsets.Add(LevelsetLibrary.CustomLevelsetName, LevelsetCustom)

        ' Always starts at level 1 of the new set, whatever level the previous set was on.
        If Not LoadLevelIntoGameState(LevelsetLibrary.CustomLevelsetName, 1) Then
            LevelsetLibrary.Levelsets.Remove(LevelsetLibrary.CustomLevelsetName)
            If PreviouslyRegistered IsNot Nothing Then
                LevelsetLibrary.Levelsets.Add(LevelsetLibrary.CustomLevelsetName, PreviouslyRegistered)
            End If
            Return False
        End If

        FileName = levelFileName
        ExternalCustomLevel = True
        Return True
    End Function

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
        Dim Player As Cell = Cell.FromIndex(PlayerLocation)
        Dim CameFrom As Cell = Player.Neighbour(Opposite(LastMove.Direction))

        If LastMove.PushedBox Then
            ' The box is one square further along than the player, and gets pulled back with them.
            Dim BoxCell As Cell = Player.Neighbour(LastMove.Direction)
            GameBoard(BoxCell.Index) = WithNothing(GameBoard(BoxCell.Index))
            GameBoard(Player.Index) = WithBox(GameBoard(Player.Index))
            PushesPerformedOnCurrentLevel -= 1
        Else
            GameBoard(Player.Index) = WithNothing(GameBoard(Player.Index))
        End If

        GameBoard(CameFrom.Index) = WithPlayer(GameBoard(CameFrom.Index))
        PlayerLocation = CameFrom.Index
        MovesPerformedOnCurrentLevel -= 1

        DiscardRecordedSnapshot()
    End Sub

    ''' <remarks>
    ''' Drops the board snapshot the movement code records alongside each move. In a debug build
    ''' the snapshot is first compared against the board the reversal above produced, so that any
    ''' divergence between the two is caught where it happens.
    ''' </remarks>
    Private Sub DiscardRecordedSnapshot()
        If AllGameBoardStates.Count > 0 Then
#If DEBUG Then
            Dim Expected() As Integer = AllGameBoardStates(AllGameBoardStates.Count - 1)
            For Index As Integer = BoardFirstIndex To BoardCellCount
                System.Diagnostics.Debug.Assert(
                    GameBoard(Index) = Expected(Index),
                    "Reversing the last move produced a different board than the recorded snapshot.")
            Next
#End If
            AllGameBoardStates.RemoveAt(AllGameBoardStates.Count - 1)
        End If

        If AllPushStates.Count > 0 Then
            AllPushStates.RemoveAt(AllPushStates.Count - 1)
        End If
    End Sub

    Public Function RestartLevel() As Boolean
        Return LoadLevelIntoGameState(CurrentLevelsetName, CurrentlyPlayedLevelId)
    End Function
    ''' <remarks>
    ''' The progress marker for the levelset named by the settings: the number of the next level
    ''' to play. It reaches one past the end of a set once that set has been completed, so callers
    ''' that need a level number should use FurthestPlayableLevel instead.
    ''' </remarks>
    Public ReadOnly Property ArrivedLevel() As Integer
        Get
            Return ProgressStore.GetLevelMarker(My.Settings.LevelSet)
        End Get
    End Property

    ''' <remarks>
    ''' The highest level the player may open in the levelset named by the settings: the progress
    ''' marker clamped to a level that exists.
    ''' </remarks>
    Public ReadOnly Property FurthestPlayableLevel() As Integer
        Get
            Return ClampToLevelset(ArrivedLevel(), My.Settings.LevelSet)
        End Get
    End Property

    ''' <remarks>Clamps a progress marker to a level number that exists in the named set.</remarks>
    Public ReadOnly Property ClampToLevelset(levelNumber As Integer,
                                             levelsetName As String) As Integer
        Get
            Dim LevelCount As Integer = NumberOfLevelsIn(levelsetName)
            If LevelCount < 1 Then
                Return 1
            End If

            Return Math.Max(1, Math.Min(levelNumber, LevelCount))
        End Get
    End Property


End Module
