Public Module 倉庫番
    ' -------------------------------------------------------------------------------------------
    ' |                                         SKRZYNKI                                        |
    ' |                                 autor: Karol Kuczmarski                                 |
    ' -------------------------------------------------------------------------------------------
    '
    ' Rodzaj: gra logiczna
    ' Typ: sokoban
    '
    ' Należy ułożyć skrzynki na wyznaczony miejscach. Można poruszać tylko jedną skrzynką naraz,
    ' w kierunku "od siebie".
    '
    ' PrzesunGracza (F) - używana, kiedy gracz wciśnie klawisz kursora; zwraca True, jeśli
    '                     przesunięcie jest możliwe (jednocześnie je wykonuje); kierunek jest
    '                     jest określony parametrem Kierunek
    ' PrzesunSkrzynke (F) - czy można przesunąć skrzynkę na drodze gracza? (parametry: Kierunek
    '                       określa kierunek przesunięcia, PozycjaSkrzynki - którą skrzynkę
    '                       należy przesunąć, zaś ZMiejsca - czy skrzynka ta jest lub nie jest
    '                       na miejscu
    '--------------------------------------------------------------------------------------------
    ' Działanie gry opiera się na tablicy 256 Image'ów oraz jej odpowiedniku w postaci jednowy-
    ' miarowego arrayu o nazwie GameBoard.
    '--------------------------------------------------------------------------------------------
    ' Niniejszy program jest wolnym oprogramowaniem; możesz go 
    ' rozprowadzać dalej i/lub modyfikować na warunkach Powszechnej
    ' Licencji Publicznej GNU, wydanej przez Fundację Wolnego
    ' Oprogramowania - według wersji 2-giej tej Licencji lub którejś
    ' z późniejszych wersji.
    '
    ' Niniejszy program rozpowszechniany jest z nadzieją, iż będzie on
    ' użyteczny - jednak BEZ JAKIEJKOLWIEK GWARANCJI, nawet domyślnej
    ' gwarancji PRZYDATNOŚCI HANDLOWEJ albo PRZYDATNOŚCI DO OKREŚLONYCH
    ' ZASTOSOWAŃ. W celu uzyskania bliższych informacji - Powszechna
    ' Licencja Publiczna GNU.
    '
    ' Z pewnością wraz z niniejszym programem otrzymałeś też egzemplarz
    ' Powszechnej Licencji Publicznej GNU (GNU General Public License);
    ' jeśli nie - napisz do Free Software Foundation, Inc., 675 Mass Ave,
    ' Cambridge, MA 02139, USA.
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

    Public Localizer As System.Resources.ResourceManager =
        New System.Resources.ResourceManager("Skrzynki.LocalizableStrings", System.Reflection.Assembly.GetExecutingAssembly())

    ' zmienne
    Public GameBoard(256) As Integer ' przechowuje aktualne ustawienie obiektów w polu gry
    'Public AllGameBoardStates As System.Collections.Generic.List(Of Integer())
    Public AllGameBoardStates As System.Collections.ObjectModel.Collection(Of Integer())
    Public PlayerLocation As Integer ' aktualna pozycja gracza
    Public MoveHasJustBeenPerformed As Boolean ' czy gracz wykonał ruch (i czy ew. można cofnąć)
    Private PushHasJustBeenPerformed As Boolean
    Public ExternalCustomLevel As Boolean ' wybranego przez użytkownika (jeśli tak jest, po jego
    ' przejściu nie powinien być wyświetlony następny)
    Public LevelCleared As Boolean ' czy etap spoza zestawu zaliczony?
    Public CurrentlyPlayedLevelId As Integer ' numer aktualnie rozgrywanego etapu
    Public MovesPerformedOnCurrentLevel As Integer ' ruchy wykonane w etapie
    Public PushesPerformedOnCurrentLevel As Integer ' ruchy skrzynek wykonane w etapie
    Public FileName As String ' nazwa pliku etapu
    Public Counter As Integer ' do pętli For...Next


    Public Sub LoadNextLevel()

        If ExternalCustomLevel Then
            ' TODO Only if single-level
            ' CurrentlyPlayedLevelId -= 1
            ' Exit Sub
        End If

        If CurrentlyPlayedLevelId > SetArrivedLevel() Then
            Select Case My.Settings.LevelSet
                Case "Klasyczne"
                    DaneGracza.Klasyczne.OsiagnietyEtap = CurrentlyPlayedLevelId
                    DaneGracza.Klasyczne.Pchniecia += PushesPerformedOnCurrentLevel
                    DaneGracza.Klasyczne.Ruchy += MovesPerformedOnCurrentLevel
                Case "SuperTrudneXS"
                    DaneGracza.SuperTrudneXS.OsiagnietyEtap = CurrentlyPlayedLevelId
                    DaneGracza.SuperTrudneXS.Pchniecia += PushesPerformedOnCurrentLevel
                    DaneGracza.SuperTrudneXS.Ruchy += MovesPerformedOnCurrentLevel
            End Select
        End If
        MovesPerformedOnCurrentLevel = 0
        PushesPerformedOnCurrentLevel = 0
        MoveHasJustBeenPerformed = False
        PushHasJustBeenPerformed = False

        ' TODO Incorrect way of checking the number of levels
        Dim Levelset As Levelset = CType(LevelParser.Levelsets.Item("Classic"), Levelset)

        Dim NextBoardState() As Integer = Levelset.GetLevel(CurrentlyPlayedLevelId)
        Array.Copy(NextBoardState, GameBoard, GameBoard.Length)
        PlayerLocation = GameBoardDetails.GetIndexOfPlayerOnBoard(NextBoardState)
        LevelCleared = False
    End Sub
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
        Dim ZE As String = Nothing
        CurrentlyPlayedLevelId = whichLevel
        MovesPerformedOnCurrentLevel = 0
        PushesPerformedOnCurrentLevel = 0
        MoveHasJustBeenPerformed = False
        ExternalCustomLevel = False

        If My.Settings.LevelSet = "Klasyczne" Then
            ZE = "Classic"
        ElseIf My.Settings.LevelSet = "SuperTrudneXS" Then
            ZE = "XS"
        End If

        LevelCleared = False

        Dim Levelset As Levelset = CType(LevelParser.Levelsets.Item(ZE), Levelset)
        Dim BoardState() As Integer = Levelset.GetLevel(CurrentlyPlayedLevelId)
        Array.Copy(BoardState, GameBoard, GameBoard.Length)

        ' Todo: .GetPlayerLocation()
        For Counter = 1 To 256 Step 1
            If GameBoard(Counter) = BoardItem.Player Or GameBoard(Counter) = BoardItem.PlayerOnPlace Then PlayerLocation = Counter
        Next Counter

        PlayerLocation = GameBoardDetails.GetIndexOfPlayerOnBoard(GameBoard)

        Return True
    End Function
    Public Sub Undo()
        Array.Copy(AllGameBoardStates(AllGameBoardStates.Count - 1), GameBoard, GameBoard.Length)
        AllGameBoardStates.RemoveAt(AllGameBoardStates.Count - 1)

        PlayerLocation = GameBoardDetails.GetIndexOfPlayerOnBoard(GameBoard)

        MovesPerformedOnCurrentLevel -= 1
        If PushHasJustBeenPerformed Then
            PushesPerformedOnCurrentLevel -= 1
        End If
        MoveHasJustBeenPerformed = False
    End Sub
    Public Sub RestartLevel()
        Dim ZE As String = Nothing
        If My.Settings.LevelSet = "Klasyczne" Then
            ZE = "Classic"
        ElseIf My.Settings.LevelSet = "SuperTrudneXS" Then
            ZE = "XS"
        End If

        Dim Levelset As Levelset = CType(LevelParser.Levelsets.Item(ZE), Levelset)
        Dim BoardState() As Integer = Levelset.GetLevel(CurrentlyPlayedLevelId)
        Array.Copy(BoardState, GameBoard, GameBoard.Length)

        PlayerLocation = Levelset.GetLevelInitialProperties(CurrentlyPlayedLevelId).PlayerLocation

        MovesPerformedOnCurrentLevel = 0
        PushesPerformedOnCurrentLevel = 0
        MoveHasJustBeenPerformed = False
    End Sub
    Public Function SetArrivedLevel() As Integer
        If My.Settings.LevelSet = "Klasyczne" Then
            SetArrivedLevel = My.Settings.ArrivedLevelKlasyczne
        Else
            SetArrivedLevel = My.Settings.ArrivedLevelSupertrudne
        End If
    End Function

End Module