Public Module 倉庫番
    ' -------------------------------------------------------------------------------------------
    ' |                                         SKRZYNKI                                        |
    ' |                                 autor: Karol Kuczmarski                                 |
    ' -------------------------------------------------------------------------------------------
    '
    ' Gra logiczna
    ' Typ: sokoban
    '
    ' Należy ułożyć skrzynki na wyznaczony miejscach. Można poruszać tylko jedną skrzynką naraz,
    ' w kierunku "od siebie".
    '
    ' Działanie gry opiera się na tablicy 256 Image'ów oraz jej odpowiedniku w postaci jednowy-
    ' miarowego arrayu o nazwie GameBoard.
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

    ' zmienne
    Public GameBoard(256) As Integer ' przechowuje aktualne ustawienie obiektów w polu gry
    Public AllGameBoardStates As System.Collections.ObjectModel.Collection(Of Integer())
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

    Public Sub LoadNextLevel()

        If ExternalCustomLevel Then
            ' TODO Only if single-level
            ' CurrentlyPlayedLevelId -= 1
            ' Exit Sub
        End If

        Dim Levelset As Levelset = LevelParser.GetLevelset("Classic")
        Select Case My.Settings.LevelSet
            Case "Classic"
                If CurrentlyPlayedLevelId > GetArrivedLevel() Then
                    My.Settings.ArrivedLevelKlasyczne = CurrentlyPlayedLevelId
                    My.Settings.PushesKlasyczne += PushesPerformedOnCurrentLevel
                    My.Settings.MovesKlasyczne += MovesPerformedOnCurrentLevel
                End If
            Case "XS"
                If CurrentlyPlayedLevelId > GetArrivedLevel() Then
                    My.Settings.ArrivedLevelSupertrudne = CurrentlyPlayedLevelId
                    My.Settings.PushesSupertrudne += PushesPerformedOnCurrentLevel
                    My.Settings.MovesSupertrudne += MovesPerformedOnCurrentLevel
                End If
                Levelset = LevelParser.GetLevelset("XS")
        End Select

        MovesPerformedOnCurrentLevel = 0
        PushesPerformedOnCurrentLevel = 0
        MoveHasJustBeenPerformed = False
        PushHasJustBeenPerformed = False

        Dim NextBoardState() As Integer = Levelset.GetLevel(CurrentlyPlayedLevelId)
        Array.Copy(NextBoardState, GameBoard, GameBoard.Length)
        PlayerLocation = GameBoardDetails.GetIndexOfPlayerOnBoard(NextBoardState)
        LevelCleared = False
    End Sub

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
        CurrentlyPlayedLevelId = whichLevel
        MovesPerformedOnCurrentLevel = 0
        PushesPerformedOnCurrentLevel = 0
        MoveHasJustBeenPerformed = False
        ExternalCustomLevel = False

        LevelCleared = False

        Dim Levelset As Levelset = CType(LevelParser.Levelsets.Item(My.Settings.LevelSet), Levelset)
        SizeOfCurrentLevelset = Levelset.NumberOfLevels
        Dim BoardState() As Integer = Levelset.GetLevel(CurrentlyPlayedLevelId)
        Array.Copy(BoardState, GameBoard, GameBoard.Length)

        PlayerLocation = GameBoardDetails.GetIndexOfPlayerOnBoard(GameBoard)

        Return True
    End Function
    Public Sub Undo()
        If (AllGameBoardStates.Count - 1) >= 0 Then
            Array.Copy(AllGameBoardStates(AllGameBoardStates.Count - 1), GameBoard, GameBoard.Length)
            AllGameBoardStates.RemoveAt(AllGameBoardStates.Count - 1)

            PlayerLocation = GameBoardDetails.GetIndexOfPlayerOnBoard(GameBoard)

            MovesPerformedOnCurrentLevel -= 1
            If PushHasJustBeenPerformed Then
                PushesPerformedOnCurrentLevel -= 1
            End If
            'MoveHasJustBeenPerformed = False
        End If

    End Sub
    Public Sub RestartLevel()
        Dim Levelset As Levelset = CType(LevelParser.Levelsets.Item(My.Settings.LevelSet), Levelset)
        SizeOfCurrentLevelset = Levelset.NumberOfLevels
        Dim BoardState() As Integer = Levelset.GetLevel(CurrentlyPlayedLevelId)
        Array.Copy(BoardState, GameBoard, GameBoard.Length)

        PlayerLocation = Levelset.GetLevelInitialProperties(CurrentlyPlayedLevelId).PlayerLocation

        MovesPerformedOnCurrentLevel = 0
        PushesPerformedOnCurrentLevel = 0
        MoveHasJustBeenPerformed = False
    End Sub
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