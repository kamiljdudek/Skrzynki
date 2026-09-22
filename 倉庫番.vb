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
    ' anything that fills a board array must start writing at BoardFirstIndex. Filling from 0
    ' instead is what used to leave cell 256 - the bottom right one - permanently unset.
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

    Public Function LoadNextLevel() As Boolean
        ' Progress is only recorded for the two built-in sets; a levelset opened from a file has
        ' no persisted statistics of its own.
        If Not ExternalCustomLevel AndAlso CurrentlyPlayedLevelId > GetArrivedLevel() Then
            Select Case My.Settings.LevelSet
                Case "Classic"
                    My.Settings.ArrivedLevelKlasyczne = CurrentlyPlayedLevelId
                    My.Settings.PushesKlasyczne += PushesPerformedOnCurrentLevel
                    My.Settings.MovesKlasyczne += MovesPerformedOnCurrentLevel
                Case "XS"
                    My.Settings.ArrivedLevelSupertrudne = CurrentlyPlayedLevelId
                    My.Settings.PushesSupertrudne += PushesPerformedOnCurrentLevel
                    My.Settings.MovesSupertrudne += MovesPerformedOnCurrentLevel
            End Select
        End If

        Return LoadLevelIntoGameState(CurrentLevelsetName, CurrentlyPlayedLevelId)
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
                            GameBoard(targetBoxLocation) = BoardItem.Player
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
    ''' Switches play over to the levelset most recently opened from a file, starting at its first
    ''' level. Returns False and leaves the current game alone if that set is unusable.
    ''' </remarks>
    Public Function StartCustomLevelset() As Boolean
        If Not LoadLevelIntoGameState(LevelParser.CustomLevelsetName, 1) Then
            Return False
        End If

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