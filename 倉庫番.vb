Public Module 倉庫番
    ' -------------------------------------------------------------------------------------------
    ' |                                         SKRZYNKI                                        |
    ' |                                 autor: Karol Kuczmarski                                 |
    ' -------------------------------------------------------------------------------------------
    '
    ' Gra logiczna
    ' Typ: sokoban
    '
    ' Należy ułożyć skrzynki na wyznaczonych miejscach. Można poruszać tylko jedną skrzynką 
    ' naraz, w kierunku "od siebie". Działanie gry opiera się na tablicy 256 Image'ów oraz
    ' jej odpowiedniku w postaci jednowymiarowego arrayu o nazwie GameBoard.
    '
    '--------------------------------------------------------------------------------------------

    Enum BoardItem
        Blank = 0
        Wall = 1
        Box = 2
        PlaceForBox = 3
        BoxOnPlace = 4
        Player = 5
        PlayerOnPlace = 6
        BlankOuter = 7
    End Enum

    ' This is a public localizer created to translate the UI on the fly.
    <CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2211:NonConstantFieldsShouldNotBeVisible")>
    Public Localizer As New System.Resources.ResourceManager("Skrzynki.LocalizableStrings", System.Reflection.Assembly.GetExecutingAssembly())

    ' --- Board indexing convention ----------------------------------------------------------
    ' The playing field is a fixed 16x16 grid held in a flat array. Cells occupy indices
    ' BoardFirstIndex (1) through BoardCellCount (256); index 0 exists only because VB declares
    ' arrays by upper bound, and is never read, written or drawn.
    '
    ' Row r and column c (both 0-based) live at index r * BoardWidth + c + 1.
    '
    ' GameBoard below and GameBoardForm.imgGameField are index-for-index parallel and share this
    ' convention. Every loop over the board therefore runs BoardFirstIndex To BoardCellCount, and
    ' anything that fills a board array must start writing at BoardFirstIndex.
    Public Const BoardWidth As Integer = 16
    Public Const BoardHeight As Integer = 16
    Public Const BoardCellCount As Integer = BoardWidth * BoardHeight
    Public Const BoardFirstIndex As Integer = 1

    ' zmienne
    Public GameBoard(256) As Integer ' przechowuje aktualne ustawienie obiektów w polu gry
    Public AllGameBoardStates As New System.Collections.ObjectModel.Collection(Of Integer())
    Public AllPushStates As New System.Collections.ObjectModel.Collection(Of Boolean)
    Public PlayerLocation As Integer ' aktualna pozycja gracza
    Public MoveHasJustBeenPerformed As Boolean ' czy gracz wykonał ruch (i czy ew. można cofnąć)
    Public PushHasJustBeenPerformed As Boolean
    Public ExternalCustomLevel As Boolean
    Public SizeOfCurrentLevelset As Integer
    Public LevelCleared As Boolean ' czy etap spoza zestawu zaliczony?
    Public CurrentlyPlayedLevelId As Integer ' numer aktualnie rozgrywanego etapu
    Public MovesPerformedOnCurrentLevel As Integer ' ruchy wykonane w etapie
    Public PushesPerformedOnCurrentLevel As Integer ' ruchy skrzynek wykonane w etapie
    Public FileName As String ' nazwa pliku etapu

    ' --- Game state, as seen from the outside -------------------------------------------------
    ' The fields above are shared with the movement code in this module. Callers outside it -
    ' GameBoardForm in particular - use the members below, and never read or write that state
    ' directly.

    ''' <remarks>
    ''' Name of the levelset currently being played. A levelset opened from a file is registered
    ''' under LevelParser.CustomLevelsetName rather than under My.Settings.LevelSet, so anything
    ''' that needs to reach for the active set has to ask here instead of reading the setting.
    ''' </remarks>
    Public ReadOnly Property CurrentLevelsetName() As String
        Get
            If ExternalCustomLevel Then
                Return LevelParser.CustomLevelsetName
            End If
            Return My.Settings.LevelSet
        End Get
    End Property

    ''' <remarks>Contents of one board cell. Out-of-range indices read as BlankOuter.</remarks>
    Public ReadOnly Property BoardCell(ByVal cellIndex As Integer) As Integer
        Get
            If cellIndex < BoardFirstIndex OrElse cellIndex > BoardCellCount Then
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
    Public ReadOnly Property NumberOfLevelsIn(ByVal levelsetName As String) As Integer
        Get
            Dim Levelset As Levelset = LevelParser.GetLevelset(levelsetName)
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
            Return AllGameBoardStates.Count > 0
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

    ''' <remarks>
    ''' The translated name of a built-in levelset, as shown to the player. Falls back to the
    ''' internal key when a set has no translation of its own.
    ''' </remarks>
    Public ReadOnly Property LocalizedLevelsetName(ByVal levelsetName As String) As String
        Get
            Dim Translated As String = Nothing

            Select Case levelsetName
                Case "Classic"
                    Translated = Localizer.GetString("LevelSetClassic")
                Case "XS"
                    Translated = Localizer.GetString("LevelSetXS")
            End Select

            If String.IsNullOrEmpty(Translated) Then
                Return levelsetName
            End If
            Return Translated
        End Get
    End Property

    ''' <remarks>
    ''' How the active levelset is named to the player: the file name for a set opened from disk,
    ''' the translated set name otherwise.
    ''' </remarks>
    Public ReadOnly Property CurrentLevelsetDisplayName() As String
        Get
            If ExternalCustomLevel AndAlso Not String.IsNullOrEmpty(FileName) Then
                Return System.IO.Path.GetFileName(FileName)
            End If
            Return LocalizedLevelsetName(My.Settings.LevelSet)
        End Get
    End Property

    ''' <remarks>The window title for the whole game, built in one place.</remarks>
    Public ReadOnly Property CurrentGameTitle() As String
        Get
            Return Localizer.GetString("GameName") &
                " (" & CurrentLevelsetDisplayName & "): #" &
                CurrentLevelNumber.ToString(System.Globalization.CultureInfo.InvariantCulture)
        End Get
    End Property

    ''' <remarks>
    ''' Attempts a move in the given direction, returning False when it is blocked. The entry
    ''' point callers outside this module use to move the player.
    ''' </remarks>
    Public Function TryMovePlayer(ByVal moveDirection As System.Windows.Forms.Keys) As Boolean
        Return PrzesunGracza(moveDirection)
    End Function

    Public Sub ClearUndoHistory()
        AllGameBoardStates.Clear()
        AllPushStates.Clear()
    End Sub

    ''' <remarks>
    ''' Loads a level into the shared game state and resets the per-level counters. Returns False
    ''' without touching any state when the levelset is missing, the level number is out of range,
    ''' or the level has no player on it - so callers can report the failure rather than crash on
    ''' a bad index later on.
    ''' </remarks>
    Private Function LoadLevelIntoGameState(ByVal levelsetName As String, ByVal levelId As Integer) As Boolean
        Dim Levelset As Levelset = LevelParser.GetLevelset(levelsetName)
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
        MoveHasJustBeenPerformed = False
        PushHasJustBeenPerformed = False
        LevelCleared = False
        ClearUndoHistory()

        Return True
    End Function

    ''' <remarks>
    ''' Banks the moves and pushes spent on the level just completed and advances the furthest
    ''' reached marker. Call once per solved level, including the last one of a set.
    '''
    ''' Progress is only kept for the two built-in sets; a levelset opened from a file has no
    ''' persisted statistics of its own.
    ''' </remarks>
    Public Sub RecordProgressForSolvedLevel()
        If ExternalCustomLevel Then
            Exit Sub
        End If

        ' The marker names the level the player has unlocked, which is the one after the level
        ' just solved - capped at the size of the set, since there is nothing beyond it.
        Dim UnlockedLevel As Integer = Math.Min(CurrentlyPlayedLevelId + 1, SizeOfCurrentLevelset)

        Select Case My.Settings.LevelSet
            Case "Classic"
                My.Settings.ArrivedLevelKlasyczne =
                    Math.Max(My.Settings.ArrivedLevelKlasyczne, UnlockedLevel)
                My.Settings.PushesKlasyczne += PushesPerformedOnCurrentLevel
                My.Settings.MovesKlasyczne += MovesPerformedOnCurrentLevel
            Case "XS"
                My.Settings.ArrivedLevelSupertrudne =
                    Math.Max(My.Settings.ArrivedLevelSupertrudne, UnlockedLevel)
                My.Settings.PushesSupertrudne += PushesPerformedOnCurrentLevel
                My.Settings.MovesSupertrudne += MovesPerformedOnCurrentLevel
        End Select
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

    ''' <remarks>
    ''' Function PrzesunGracza: używana, kiedy gracz wciśnie klawisz kursora; zwraca True, jeśli
    ''' przesunięcie jest możliwe (jednocześnie je wykonuje); kierunek jestokreślony parametrem moveDirection
    ''' </remarks>
    Public Function PrzesunGracza(ByVal moveDirection As System.Windows.Forms.Keys) As Boolean
        If LevelCleared Then
            PrzesunGracza = False
            Exit Function
        End If

        PushHasJustBeenPerformed = False
        Dim StateBeforeMove(256) As Integer
        Array.Copy(GameBoard, StateBeforeMove, GameBoard.Length)

        Select Case moveDirection
            Case System.Windows.Forms.Keys.Left
                Select Case GameBoard(PlayerLocation - 1)
                    Case BoardItem.Blank
                        If GameBoard(PlayerLocation) = BoardItem.PlayerOnPlace Then
                            GameBoard(PlayerLocation) = BoardItem.PlaceForBox
                        Else
                            GameBoard(PlayerLocation) = BoardItem.Blank
                        End If

                        GameBoard(PlayerLocation - 1) = BoardItem.Player
                        PlayerLocation -= 1
                    Case BoardItem.Wall
                        PrzesunGracza = False
                        Exit Function
                    Case BoardItem.Box
                        If PrzesunSkrzynke(System.Windows.Forms.Keys.Left, PlayerLocation - 1, False) = False Then
                            PrzesunGracza = False
                            Exit Function
                        End If

                        If GameBoard(PlayerLocation) = BoardItem.PlayerOnPlace Then
                            GameBoard(PlayerLocation) = BoardItem.PlaceForBox
                        Else
                            GameBoard(PlayerLocation) = BoardItem.Blank
                        End If

                        GameBoard(PlayerLocation - 1) = BoardItem.Player
                        PlayerLocation -= 1

                        PushesPerformedOnCurrentLevel += 1
                    Case BoardItem.PlaceForBox
                        If GameBoard(PlayerLocation) = BoardItem.PlayerOnPlace Then
                            GameBoard(PlayerLocation) = BoardItem.PlaceForBox
                        Else
                            GameBoard(PlayerLocation) = BoardItem.Blank
                        End If

                        GameBoard(PlayerLocation - 1) = BoardItem.PlayerOnPlace
                        PlayerLocation -= 1
                    Case BoardItem.BoxOnPlace
                        If PrzesunSkrzynke(System.Windows.Forms.Keys.Left, PlayerLocation - 1, True) = False Then
                            PrzesunGracza = False
                            Exit Function
                        End If

                        If GameBoard(PlayerLocation) = BoardItem.PlayerOnPlace Then
                            GameBoard(PlayerLocation) = BoardItem.PlaceForBox
                        Else
                            GameBoard(PlayerLocation) = BoardItem.Blank
                        End If

                        GameBoard(PlayerLocation - 1) = BoardItem.PlayerOnPlace
                        PlayerLocation -= 1

                        PushesPerformedOnCurrentLevel += 1
                End Select
            Case System.Windows.Forms.Keys.Right
                Select Case GameBoard(PlayerLocation + 1)
                    Case BoardItem.Blank
                        If GameBoard(PlayerLocation) = BoardItem.PlayerOnPlace Then
                            GameBoard(PlayerLocation) = BoardItem.PlaceForBox
                        Else
                            GameBoard(PlayerLocation) = BoardItem.Blank
                        End If

                        GameBoard(PlayerLocation + 1) = BoardItem.Player
                        PlayerLocation += 1
                    Case BoardItem.Wall
                        PrzesunGracza = False
                        Exit Function
                    Case BoardItem.Box
                        If PrzesunSkrzynke(System.Windows.Forms.Keys.Right, PlayerLocation + 1, False) = False Then
                            PrzesunGracza = False
                            Exit Function
                        End If

                        If GameBoard(PlayerLocation) = BoardItem.PlayerOnPlace Then
                            GameBoard(PlayerLocation) = BoardItem.PlaceForBox
                        Else
                            GameBoard(PlayerLocation) = BoardItem.Blank
                        End If

                        GameBoard(PlayerLocation + 1) = BoardItem.Player
                        PlayerLocation += 1

                        PushesPerformedOnCurrentLevel += 1
                    Case BoardItem.PlaceForBox
                        If GameBoard(PlayerLocation) = BoardItem.PlayerOnPlace Then
                            GameBoard(PlayerLocation) = BoardItem.PlaceForBox
                        Else
                            GameBoard(PlayerLocation) = BoardItem.Blank
                        End If

                        GameBoard(PlayerLocation + 1) = BoardItem.PlayerOnPlace
                        PlayerLocation += 1
                    Case BoardItem.BoxOnPlace
                        If PrzesunSkrzynke(System.Windows.Forms.Keys.Right, PlayerLocation + 1, True) = False Then
                            PrzesunGracza = False
                            Exit Function
                        End If

                        If GameBoard(PlayerLocation) = BoardItem.PlayerOnPlace Then
                            GameBoard(PlayerLocation) = BoardItem.PlaceForBox
                        Else
                            GameBoard(PlayerLocation) = BoardItem.Blank
                        End If

                        GameBoard(PlayerLocation + 1) = BoardItem.PlayerOnPlace
                        PlayerLocation += 1

                        PushesPerformedOnCurrentLevel += 1
                End Select
            Case System.Windows.Forms.Keys.Up
                Select Case GameBoard(PlayerLocation - 16)
                    Case BoardItem.Blank
                        If GameBoard(PlayerLocation) = BoardItem.PlayerOnPlace Then
                            GameBoard(PlayerLocation) = BoardItem.PlaceForBox
                        Else
                            GameBoard(PlayerLocation) = BoardItem.Blank
                        End If

                        GameBoard(PlayerLocation - 16) = BoardItem.Player
                        PlayerLocation -= 16
                    Case BoardItem.Wall
                        PrzesunGracza = False
                        Exit Function
                    Case BoardItem.Box
                        If PrzesunSkrzynke(System.Windows.Forms.Keys.Up, PlayerLocation - 16, False) = False Then
                            PrzesunGracza = False
                            Exit Function
                        End If

                        If GameBoard(PlayerLocation) = BoardItem.PlayerOnPlace Then
                            GameBoard(PlayerLocation) = BoardItem.PlaceForBox
                        Else
                            GameBoard(PlayerLocation) = BoardItem.Blank
                        End If

                        GameBoard(PlayerLocation - 16) = BoardItem.Player
                        PlayerLocation -= 16

                        PushesPerformedOnCurrentLevel += 1
                    Case BoardItem.PlaceForBox
                        If GameBoard(PlayerLocation) = BoardItem.PlayerOnPlace Then
                            GameBoard(PlayerLocation) = BoardItem.PlaceForBox
                        Else
                            GameBoard(PlayerLocation) = BoardItem.Blank
                        End If

                        GameBoard(PlayerLocation - 16) = BoardItem.PlayerOnPlace
                        PlayerLocation -= 16
                    Case BoardItem.BoxOnPlace
                        If PrzesunSkrzynke(System.Windows.Forms.Keys.Up, PlayerLocation - 16, True) = False Then
                            PrzesunGracza = False
                            Exit Function
                        End If

                        If GameBoard(PlayerLocation) = BoardItem.PlayerOnPlace Then
                            GameBoard(PlayerLocation) = BoardItem.PlaceForBox
                        Else
                            GameBoard(PlayerLocation) = BoardItem.Blank
                        End If

                        GameBoard(PlayerLocation - 16) = BoardItem.PlayerOnPlace
                        PlayerLocation -= 16

                        PushesPerformedOnCurrentLevel += 1
                End Select
            Case System.Windows.Forms.Keys.Down
                Select Case GameBoard(PlayerLocation + 16)
                    Case BoardItem.Blank
                        If GameBoard(PlayerLocation) = BoardItem.PlayerOnPlace Then
                            GameBoard(PlayerLocation) = BoardItem.PlaceForBox
                        Else
                            GameBoard(PlayerLocation) = BoardItem.Blank
                        End If

                        GameBoard(PlayerLocation + 16) = BoardItem.Player
                        PlayerLocation += 16
                    Case BoardItem.Wall
                        PrzesunGracza = False
                        Exit Function
                    Case BoardItem.Box
                        If PrzesunSkrzynke(System.Windows.Forms.Keys.Down, PlayerLocation + 16, False) = False Then
                            PrzesunGracza = False
                            Exit Function
                        End If

                        If GameBoard(PlayerLocation) = BoardItem.PlayerOnPlace Then
                            GameBoard(PlayerLocation) = BoardItem.PlaceForBox
                        Else
                            GameBoard(PlayerLocation) = BoardItem.Blank
                        End If

                        GameBoard(PlayerLocation + 16) = BoardItem.Player
                        PlayerLocation += 16

                        PushesPerformedOnCurrentLevel += 1
                    Case BoardItem.PlaceForBox
                        If GameBoard(PlayerLocation) = BoardItem.PlayerOnPlace Then
                            GameBoard(PlayerLocation) = BoardItem.PlaceForBox
                        Else
                            GameBoard(PlayerLocation) = BoardItem.Blank
                        End If

                        GameBoard(PlayerLocation + 16) = BoardItem.PlayerOnPlace
                        PlayerLocation += 16
                    Case BoardItem.BoxOnPlace
                        If PrzesunSkrzynke(System.Windows.Forms.Keys.Down, PlayerLocation + 16, True) = False Then
                            PrzesunGracza = False
                            Exit Function
                        End If

                        If GameBoard(PlayerLocation) = BoardItem.PlayerOnPlace Then
                            GameBoard(PlayerLocation) = BoardItem.PlaceForBox
                        Else
                            GameBoard(PlayerLocation) = BoardItem.Blank
                        End If

                        GameBoard(PlayerLocation + 16) = BoardItem.PlayerOnPlace
                        PlayerLocation += 16

                        PushesPerformedOnCurrentLevel += 1
                End Select
        End Select

        AllGameBoardStates.Add(StateBeforeMove)
        AllPushStates.Add(PushHasJustBeenPerformed)
        MoveHasJustBeenPerformed = True
        MovesPerformedOnCurrentLevel += 1
        PrzesunGracza = True
    End Function

    ''' <remarks>
    ''' Function PrzesunSkrzynke: czy można przesunąć skrzynkę na drodze gracza? (parametry: Kierunek
    ''' określa kierunek przesunięcia, PozycjaSkrzynki - którą skrzynkę należy przesunąć, zaś ZMiejsca
    ''' - czy skrzynka ta jest lub nie jest na miejscu
    ''' </remarks>
    Public Function PrzesunSkrzynke(ByVal moveDirection As System.Windows.Forms.Keys, ByVal targetBoxLocation As Integer, ByVal fromProperlyPlacedLocation As Boolean) As Boolean
        PushHasJustBeenPerformed = False
        If fromProperlyPlacedLocation = True Then
            Select Case moveDirection
                Case System.Windows.Forms.Keys.Left
                    Select Case GameBoard(targetBoxLocation - 1)
                        Case BoardItem.Blank
                            GameBoard(targetBoxLocation - 1) = BoardItem.Box
                        Case BoardItem.Wall
                            PrzesunSkrzynke = False
                            Exit Function
                        Case BoardItem.Box
                            PrzesunSkrzynke = False
                            Exit Function
                        Case BoardItem.BoxOnPlace
                            PrzesunSkrzynke = False
                            Exit Function
                        Case BoardItem.PlaceForBox
                            GameBoard(targetBoxLocation - 1) = BoardItem.BoxOnPlace
                    End Select
                Case System.Windows.Forms.Keys.Right
                    Select Case GameBoard(targetBoxLocation + 1)
                        Case BoardItem.Blank
                            GameBoard(targetBoxLocation + 1) = BoardItem.Box
                        Case BoardItem.Wall
                            PrzesunSkrzynke = False
                            Exit Function
                        Case BoardItem.Box
                            PrzesunSkrzynke = False
                            Exit Function
                        Case BoardItem.BoxOnPlace
                            PrzesunSkrzynke = False
                            Exit Function
                        Case BoardItem.PlaceForBox
                            GameBoard(targetBoxLocation + 1) = BoardItem.BoxOnPlace
                    End Select
                Case System.Windows.Forms.Keys.Up
                    Select Case GameBoard(targetBoxLocation - 16)
                        Case BoardItem.Blank
                            GameBoard(targetBoxLocation - 16) = BoardItem.Box
                        Case BoardItem.Wall
                            PrzesunSkrzynke = False
                            Exit Function
                        Case BoardItem.Box
                            PrzesunSkrzynke = False
                            Exit Function
                        Case BoardItem.BoxOnPlace
                            PrzesunSkrzynke = False
                            Exit Function
                        Case BoardItem.PlaceForBox
                            GameBoard(targetBoxLocation - 16) = BoardItem.BoxOnPlace
                    End Select
                Case System.Windows.Forms.Keys.Down
                    Select Case GameBoard(targetBoxLocation + 16)
                        Case BoardItem.Blank
                            GameBoard(targetBoxLocation + 16) = BoardItem.Box
                        Case BoardItem.Wall
                            PrzesunSkrzynke = False
                            Exit Function
                        Case BoardItem.Box
                            PrzesunSkrzynke = False
                            Exit Function
                        Case BoardItem.BoxOnPlace
                            PrzesunSkrzynke = False
                            Exit Function
                        Case BoardItem.PlaceForBox
                            GameBoard(targetBoxLocation + 16) = BoardItem.BoxOnPlace
                    End Select
            End Select
        Else
            Select Case moveDirection
                Case System.Windows.Forms.Keys.Left
                    Select Case GameBoard(targetBoxLocation - 1)
                        Case BoardItem.Blank
                            GameBoard(targetBoxLocation - 1) = BoardItem.Box
                            GameBoard(targetBoxLocation) = BoardItem.Blank
                        Case BoardItem.Wall
                            PrzesunSkrzynke = False
                            Exit Function
                        Case BoardItem.Box
                            PrzesunSkrzynke = False
                            Exit Function
                        Case BoardItem.BoxOnPlace
                            PrzesunSkrzynke = False
                            Exit Function
                        Case BoardItem.PlaceForBox
                            GameBoard(targetBoxLocation - 1) = BoardItem.BoxOnPlace
                            GameBoard(targetBoxLocation) = BoardItem.Blank
                    End Select
                Case System.Windows.Forms.Keys.Right
                    Select Case GameBoard(targetBoxLocation + 1)
                        Case BoardItem.Blank
                            GameBoard(targetBoxLocation + 1) = BoardItem.Box
                            GameBoard(targetBoxLocation) = BoardItem.Blank
                        Case BoardItem.Wall
                            PrzesunSkrzynke = False
                            Exit Function
                        Case BoardItem.Box
                            PrzesunSkrzynke = False
                            Exit Function
                        Case BoardItem.BoxOnPlace
                            PrzesunSkrzynke = False
                            Exit Function
                        Case BoardItem.PlaceForBox
                            GameBoard(targetBoxLocation + 1) = BoardItem.BoxOnPlace
                            GameBoard(targetBoxLocation) = BoardItem.Blank
                    End Select
                Case System.Windows.Forms.Keys.Up
                    Select Case GameBoard(targetBoxLocation - 16)
                        Case BoardItem.Blank
                            GameBoard(targetBoxLocation - 16) = BoardItem.Box
                            GameBoard(targetBoxLocation) = BoardItem.Blank
                        Case BoardItem.Wall
                            PrzesunSkrzynke = False
                            Exit Function
                        Case BoardItem.Box
                            PrzesunSkrzynke = False
                            Exit Function
                        Case BoardItem.BoxOnPlace
                            PrzesunSkrzynke = False
                            Exit Function
                        Case BoardItem.PlaceForBox
                            GameBoard(targetBoxLocation - 16) = BoardItem.BoxOnPlace
                            GameBoard(targetBoxLocation) = BoardItem.Blank
                    End Select
                Case System.Windows.Forms.Keys.Down
                    Select Case GameBoard(targetBoxLocation + 16)
                        Case BoardItem.Blank
                            GameBoard(targetBoxLocation + 16) = BoardItem.Box
                            GameBoard(targetBoxLocation) = BoardItem.Blank
                        Case BoardItem.Wall
                            PrzesunSkrzynke = False
                            Exit Function
                        Case BoardItem.Box
                            PrzesunSkrzynke = False
                            Exit Function
                        Case BoardItem.BoxOnPlace
                            PrzesunSkrzynke = False
                            Exit Function
                        Case BoardItem.PlaceForBox
                            GameBoard(targetBoxLocation + 16) = BoardItem.BoxOnPlace
                            GameBoard(targetBoxLocation) = BoardItem.Blank
                    End Select
            End Select
        End If

        PushHasJustBeenPerformed = True
        PrzesunSkrzynke = True
    End Function
    Public Function NewGame(ByVal whichLevel As Integer) As Boolean
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
        LevelParser.LoadAllLevelsets()
        Return SelectBuiltInLevelset(My.Settings.LevelSet)
    End Function

    ''' <remarks>
    ''' Switches to one of the built-in levelsets, starting either at its first level or at the
    ''' furthest the player has reached, according to the BeginFromArrivedLevel setting.
    ''' </remarks>
    Public Function SelectBuiltInLevelset(ByVal levelsetName As String) As Boolean
        Dim PreviousLevelset As String = My.Settings.LevelSet
        My.Settings.LevelSet = levelsetName

        Dim StartingLevel As Integer = 1
        If My.Settings.BeginFromArrivedLevel Then
            StartingLevel = Math.Max(1, GetArrivedLevel())
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
    Public Function OpenLevelsetFromFile(ByVal levelFileName As String) As Boolean
        Dim LevelsRead As ArrayList

        Try
            LevelsRead = LevelParser.PullAllLevels(levelFileName, True)
        Catch ex As System.IO.IOException
            Return False
        Catch ex As UnauthorizedAccessException
            Return False
        End Try

        Dim LevelsetCustom As New Levelset(LevelParser.CustomLevelsetName)
        LevelsetCustom.AddAllLevels(LevelsRead)
        If LevelsetCustom.NumberOfLevels < 1 Then
            Return False
        End If

        Dim PreviouslyRegistered As Levelset = LevelParser.GetLevelset(LevelParser.CustomLevelsetName)
        If PreviouslyRegistered IsNot Nothing Then
            LevelParser.Levelsets.Remove(LevelParser.CustomLevelsetName)
        End If
        LevelParser.Levelsets.Add(LevelParser.CustomLevelsetName, LevelsetCustom)

        ' Always starts at level 1 of the new set, whatever level the previous set was on.
        If Not LoadLevelIntoGameState(LevelParser.CustomLevelsetName, 1) Then
            LevelParser.Levelsets.Remove(LevelParser.CustomLevelsetName)
            If PreviouslyRegistered IsNot Nothing Then
                LevelParser.Levelsets.Add(LevelParser.CustomLevelsetName, PreviouslyRegistered)
            End If
            Return False
        End If

        FileName = levelFileName
        ExternalCustomLevel = True
        Return True
    End Function

    Public Sub Undo()
        If (AllGameBoardStates.Count - 1) >= 0 Then
            Array.Copy(AllGameBoardStates(AllGameBoardStates.Count - 1), GameBoard, GameBoard.Length)
            AllGameBoardStates.RemoveAt(AllGameBoardStates.Count - 1)

            PlayerLocation = GameBoardDetails.GetIndexOfPlayerOnBoard(GameBoard)

            MovesPerformedOnCurrentLevel -= 1
            If AllPushStates.Count > 0 Then
                If AllPushStates(AllPushStates.Count - 1) Then
                    PushesPerformedOnCurrentLevel -= 1
                End If
                AllPushStates.RemoveAt(AllPushStates.Count - 1)
            End If
        End If

        ' Once the history is exhausted there is nothing left to undo, and the menu item that
        ' reads this flag has to stop offering it.
        If AllGameBoardStates.Count = 0 Then
            MoveHasJustBeenPerformed = False
        End If
    End Sub

    Public Function RestartLevel() As Boolean
        Return LoadLevelIntoGameState(CurrentLevelsetName, CurrentlyPlayedLevelId)
    End Function
    Public ReadOnly Property GetArrivedLevel() As Integer
        Get
            If My.Settings.LevelSet = "Classic" Then
                GetArrivedLevel = My.Settings.ArrivedLevelKlasyczne
            Else
                GetArrivedLevel = My.Settings.ArrivedLevelSupertrudne
            End If
        End Get
    End Property


End Module