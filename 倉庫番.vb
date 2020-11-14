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
    ' miarowego arrayu o nazwie PoleGry.
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

    Public Class LevelProperties ' dane etapu
        Public NumberOfBoxes As Integer
        Public NumberOfPlaces As Integer
        Public BoxesOnPlaces As Integer
        Public PlayerLocation As Integer
    End Class

    Public Localizer As System.Resources.ResourceManager =
        New System.Resources.ResourceManager("Skrzynki.LocalizableStrings", System.Reflection.Assembly.GetExecutingAssembly())

    ' deklaracje stałych, zmiennych i funkcji API
    '--------------------------------------------
    '
    Public Lewo As System.Windows.Forms.Keys = System.Windows.Forms.Keys.Left
    Public Prawo As System.Windows.Forms.Keys = System.Windows.Forms.Keys.Right
    Public Gora As System.Windows.Forms.Keys = System.Windows.Forms.Keys.Up
    Public Dol As System.Windows.Forms.Keys = System.Windows.Forms.Keys.Down
    '
    Public Const BoardItemBlank As Short = 0 ' stałe pola gry
    Public Const BoardItemWall As Short = 1
    Public Const BoardItemBox As Short = 2
    Public Const BoardItemPlaceForBox As Short = 3
    Public Const BoardItemBoxOnPlace As Short = 4
    Public Const BoardItemPlayer As Short = 5
    Public Const BoardItemPlayerOnPlace As Short = 6
    Public Const BoardItemBlankOuter As Short = 7

    ' zmienne
    Public GameBoard(256) As Integer ' przechowuje aktualne ustawienie obiektów w polu gry
    Public AllGameBoardStates As System.Collections.Generic.List(Of Integer())
    Public CurrentLevelStats As LevelProperties ' przechowuje liczbę skrzynek i miejsc
    Public PreviousLevelStats As LevelProperties ' tak jak PoleGrySprzedRuchu
    Public PreviouslyLoadedLevelStats As LevelProperties ' jeśli wczytywanie etapu się nie powiedzie,
    ' ta zmienna zachowuje dane poprzedniego poziomu
    Public PlayerLocation As Integer ' aktualna pozycja gracza
    Public MoveHasBeenPerformed As Boolean ' czy gracz wykonał ruch (i czy ew. można cofnąć)
    Public PushHasJustBeenPerformed As Boolean
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
            CurrentlyPlayedLevelId -= 1
            Exit Sub
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
        MoveHasBeenPerformed = False

        Dim Levelset As Levelset = CType(LevelParser.Levelsets.Item("Classic"), Levelset)
        Dim NextBoardState() As Integer = Levelset.GetLevel(CurrentlyPlayedLevelId)
        For Counter = 1 To 256 Step 1
            GameBoard(Counter) = NextBoardState(Counter)
        Next Counter

        CurrentLevelStats = Levelset.GetLevelInitialProperties(CurrentlyPlayedLevelId)
        PreviousLevelStats = CurrentLevelStats

        PlayerLocation = Array.IndexOf(NextBoardState, 5)
        If PlayerLocation < 0 Then
            PlayerLocation = Array.IndexOf(NextBoardState, 6)
        End If
        LevelCleared = False
    End Sub
    Public Function PrzesunGracza(ByVal moveDirection As System.Windows.Forms.Keys) As Boolean
        If LevelCleared Then
            PrzesunGracza = False
            Exit Function
        End If

        Dim StateBeforeMove(256) As Integer
        Array.Copy(GameBoard, StateBeforeMove, GameBoard.Length)

        Select Case moveDirection
            Case Lewo
                Select Case GameBoard(PlayerLocation - 1)
                    Case BoardItemBlank
                        If GameBoard(PlayerLocation) = BoardItemPlayerOnPlace Then
                            GameBoard(PlayerLocation) = BoardItemPlaceForBox
                        Else
                            GameBoard(PlayerLocation) = BoardItemBlank
                        End If

                        GameBoard(PlayerLocation - 1) = BoardItemPlayer
                        PlayerLocation -= 1
                    Case BoardItemWall
                        PrzesunGracza = False
                        Exit Function
                    Case BoardItemBox
                        If PrzesunSkrzynke(Lewo, PlayerLocation - 1, False) = False Then
                            PrzesunGracza = False
                            Exit Function
                        End If

                        If GameBoard(PlayerLocation) = BoardItemPlayerOnPlace Then
                            GameBoard(PlayerLocation) = BoardItemPlaceForBox
                        Else
                            GameBoard(PlayerLocation) = BoardItemBlank
                        End If

                        GameBoard(PlayerLocation - 1) = BoardItemPlayer
                        PlayerLocation -= 1

                        PushesPerformedOnCurrentLevel += 1
                    Case BoardItemPlaceForBox
                        If GameBoard(PlayerLocation) = BoardItemPlayerOnPlace Then
                            GameBoard(PlayerLocation) = BoardItemPlaceForBox
                        Else
                            GameBoard(PlayerLocation) = BoardItemBlank
                        End If

                        GameBoard(PlayerLocation - 1) = BoardItemPlayerOnPlace
                        PlayerLocation -= 1
                    Case BoardItemBoxOnPlace
                        If PrzesunSkrzynke(Lewo, PlayerLocation - 1, True) = False Then
                            PrzesunGracza = False
                            Exit Function
                        End If

                        If GameBoard(PlayerLocation) = BoardItemPlayerOnPlace Then
                            GameBoard(PlayerLocation) = BoardItemPlaceForBox
                        Else
                            GameBoard(PlayerLocation) = BoardItemBlank
                        End If

                        GameBoard(PlayerLocation - 1) = BoardItemPlayerOnPlace
                        PlayerLocation -= 1

                        PushesPerformedOnCurrentLevel += 1
                End Select
            Case Prawo
                Select Case GameBoard(PlayerLocation + 1)
                    Case BoardItemBlank
                        If GameBoard(PlayerLocation) = BoardItemPlayerOnPlace Then
                            GameBoard(PlayerLocation) = BoardItemPlaceForBox
                        Else
                            GameBoard(PlayerLocation) = BoardItemBlank
                        End If

                        GameBoard(PlayerLocation + 1) = BoardItemPlayer
                        PlayerLocation += 1
                    Case BoardItemWall
                        PrzesunGracza = False
                        Exit Function
                    Case BoardItemBox
                        If PrzesunSkrzynke(Prawo, PlayerLocation + 1, False) = False Then
                            PrzesunGracza = False
                            Exit Function
                        End If

                        If GameBoard(PlayerLocation) = BoardItemPlayerOnPlace Then
                            GameBoard(PlayerLocation) = BoardItemPlaceForBox
                        Else
                            GameBoard(PlayerLocation) = BoardItemBlank
                        End If

                        GameBoard(PlayerLocation + 1) = BoardItemPlayer
                        PlayerLocation += 1

                        PushesPerformedOnCurrentLevel += 1
                    Case BoardItemPlaceForBox
                        If GameBoard(PlayerLocation) = BoardItemPlayerOnPlace Then
                            GameBoard(PlayerLocation) = BoardItemPlaceForBox
                        Else
                            GameBoard(PlayerLocation) = BoardItemBlank
                        End If

                        GameBoard(PlayerLocation + 1) = BoardItemPlayerOnPlace
                        PlayerLocation += 1
                    Case BoardItemBoxOnPlace
                        If PrzesunSkrzynke(Prawo, PlayerLocation + 1, True) = False Then
                            PrzesunGracza = False
                            Exit Function
                        End If

                        If GameBoard(PlayerLocation) = BoardItemPlayerOnPlace Then
                            GameBoard(PlayerLocation) = BoardItemPlaceForBox
                        Else
                            GameBoard(PlayerLocation) = BoardItemBlank
                        End If

                        GameBoard(PlayerLocation + 1) = BoardItemPlayerOnPlace
                        PlayerLocation += 1

                        PushesPerformedOnCurrentLevel += 1
                End Select
            Case Gora
                Select Case GameBoard(PlayerLocation - 16)
                    Case BoardItemBlank
                        If GameBoard(PlayerLocation) = BoardItemPlayerOnPlace Then
                            GameBoard(PlayerLocation) = BoardItemPlaceForBox
                        Else
                            GameBoard(PlayerLocation) = BoardItemBlank
                        End If

                        GameBoard(PlayerLocation - 16) = BoardItemPlayer
                        PlayerLocation -= 16
                    Case BoardItemWall
                        PrzesunGracza = False
                        Exit Function
                    Case BoardItemBox
                        If PrzesunSkrzynke(Gora, PlayerLocation - 16, False) = False Then
                            PrzesunGracza = False
                            Exit Function
                        End If

                        If GameBoard(PlayerLocation) = BoardItemPlayerOnPlace Then
                            GameBoard(PlayerLocation) = BoardItemPlaceForBox
                        Else
                            GameBoard(PlayerLocation) = BoardItemBlank
                        End If

                        GameBoard(PlayerLocation - 16) = BoardItemPlayer
                        PlayerLocation -= 16

                        PushesPerformedOnCurrentLevel += 1
                    Case BoardItemPlaceForBox
                        If GameBoard(PlayerLocation) = BoardItemPlayerOnPlace Then
                            GameBoard(PlayerLocation) = BoardItemPlaceForBox
                        Else
                            GameBoard(PlayerLocation) = BoardItemBlank
                        End If

                        GameBoard(PlayerLocation - 16) = BoardItemPlayerOnPlace
                        PlayerLocation -= 16
                    Case BoardItemBoxOnPlace
                        If PrzesunSkrzynke(Gora, PlayerLocation - 16, True) = False Then
                            PrzesunGracza = False
                            Exit Function
                        End If

                        If GameBoard(PlayerLocation) = BoardItemPlayerOnPlace Then
                            GameBoard(PlayerLocation) = BoardItemPlaceForBox
                        Else
                            GameBoard(PlayerLocation) = BoardItemBlank
                        End If

                        GameBoard(PlayerLocation - 16) = BoardItemPlayerOnPlace
                        PlayerLocation -= 16

                        PushesPerformedOnCurrentLevel += 1
                End Select
            Case Dol
                Select Case GameBoard(PlayerLocation + 16)
                    Case BoardItemBlank
                        If GameBoard(PlayerLocation) = BoardItemPlayerOnPlace Then
                            GameBoard(PlayerLocation) = BoardItemPlaceForBox
                        Else
                            GameBoard(PlayerLocation) = BoardItemBlank
                        End If

                        GameBoard(PlayerLocation + 16) = BoardItemPlayer
                        PlayerLocation += 16
                    Case BoardItemWall
                        PrzesunGracza = False
                        Exit Function
                    Case BoardItemBox
                        If PrzesunSkrzynke(Dol, PlayerLocation + 16, False) = False Then
                            PrzesunGracza = False
                            Exit Function
                        End If

                        If GameBoard(PlayerLocation) = BoardItemPlayerOnPlace Then
                            GameBoard(PlayerLocation) = BoardItemPlaceForBox
                        Else
                            GameBoard(PlayerLocation) = BoardItemBlank
                        End If

                        GameBoard(PlayerLocation + 16) = BoardItemPlayer
                        PlayerLocation += 16

                        PushesPerformedOnCurrentLevel += 1
                    Case BoardItemPlaceForBox
                        If GameBoard(PlayerLocation) = BoardItemPlayerOnPlace Then
                            GameBoard(PlayerLocation) = BoardItemPlaceForBox
                        Else
                            GameBoard(PlayerLocation) = BoardItemBlank
                        End If

                        GameBoard(PlayerLocation + 16) = BoardItemPlayerOnPlace
                        PlayerLocation += 16
                    Case BoardItemBoxOnPlace
                        If PrzesunSkrzynke(Dol, PlayerLocation + 16, True) = False Then
                            PrzesunGracza = False
                            Exit Function
                        End If

                        If GameBoard(PlayerLocation) = BoardItemPlayerOnPlace Then
                            GameBoard(PlayerLocation) = BoardItemPlaceForBox
                        Else
                            GameBoard(PlayerLocation) = BoardItemBlank
                        End If

                        GameBoard(PlayerLocation + 16) = BoardItemPlayerOnPlace
                        PlayerLocation += 16

                        PushesPerformedOnCurrentLevel += 1
                End Select
        End Select

        AllGameBoardStates.Add(StateBeforeMove)
        PrzesunGracza = True
    End Function
    Public Function PrzesunSkrzynke(ByVal moveDirection As System.Windows.Forms.Keys, ByVal targetBoxLocation As Integer, ByVal fromProperlyPlacedLocation As Boolean) As Boolean
        If fromProperlyPlacedLocation = True Then
            Select Case moveDirection
                Case Lewo
                    Select Case GameBoard(targetBoxLocation - 1)
                        Case BoardItemBlank
                            GameBoard(targetBoxLocation - 1) = BoardItemBox

                            CurrentLevelStats.BoxesOnPlaces -= 1
                        Case BoardItemWall
                            PrzesunSkrzynke = False
                            Exit Function
                        Case BoardItemBox
                            PrzesunSkrzynke = False
                            Exit Function
                        Case BoardItemBoxOnPlace
                            PrzesunSkrzynke = False
                            Exit Function
                        Case BoardItemPlaceForBox
                            GameBoard(targetBoxLocation - 1) = BoardItemBoxOnPlace
                    End Select
                Case Prawo
                    Select Case GameBoard(targetBoxLocation + 1)
                        Case BoardItemBlank
                            GameBoard(targetBoxLocation + 1) = BoardItemBox

                            CurrentLevelStats.BoxesOnPlaces -= 1
                        Case BoardItemWall
                            PrzesunSkrzynke = False
                            Exit Function
                        Case BoardItemBox
                            PrzesunSkrzynke = False
                            Exit Function
                        Case BoardItemBoxOnPlace
                            PrzesunSkrzynke = False
                            Exit Function
                        Case BoardItemPlaceForBox
                            GameBoard(targetBoxLocation + 1) = BoardItemBoxOnPlace
                    End Select
                Case Gora
                    Select Case GameBoard(targetBoxLocation - 16)
                        Case BoardItemBlank
                            GameBoard(targetBoxLocation - 16) = BoardItemBox

                            CurrentLevelStats.BoxesOnPlaces -= 1
                        Case BoardItemWall
                            PrzesunSkrzynke = False
                            Exit Function
                        Case BoardItemBox
                            PrzesunSkrzynke = False
                            Exit Function
                        Case BoardItemBoxOnPlace
                            PrzesunSkrzynke = False
                            Exit Function
                        Case BoardItemPlaceForBox
                            GameBoard(targetBoxLocation - 16) = BoardItemBoxOnPlace
                    End Select
                Case Dol
                    Select Case GameBoard(targetBoxLocation + 16)
                        Case BoardItemBlank
                            GameBoard(targetBoxLocation + 16) = BoardItemBox

                            CurrentLevelStats.BoxesOnPlaces -= 1
                        Case BoardItemWall
                            PrzesunSkrzynke = False
                            Exit Function
                        Case BoardItemBox
                            PrzesunSkrzynke = False
                            Exit Function
                        Case BoardItemBoxOnPlace
                            PrzesunSkrzynke = False
                            Exit Function
                        Case BoardItemPlaceForBox
                            GameBoard(targetBoxLocation + 16) = BoardItemBoxOnPlace
                    End Select
            End Select
        Else
            Select Case moveDirection
                Case Lewo
                    Select Case GameBoard(targetBoxLocation - 1)
                        Case BoardItemBlank
                            GameBoard(targetBoxLocation - 1) = BoardItemBox
                            GameBoard(targetBoxLocation) = BoardItemBlank
                        Case BoardItemWall
                            PrzesunSkrzynke = False
                            Exit Function
                        Case BoardItemBox
                            PrzesunSkrzynke = False
                            Exit Function
                        Case BoardItemBoxOnPlace
                            PrzesunSkrzynke = False
                            Exit Function
                        Case BoardItemPlaceForBox
                            GameBoard(targetBoxLocation - 1) = BoardItemBoxOnPlace
                            GameBoard(targetBoxLocation) = BoardItemBlank

                            CurrentLevelStats.BoxesOnPlaces += 1
                    End Select
                Case Prawo
                    Select Case GameBoard(targetBoxLocation + 1)
                        Case BoardItemBlank
                            GameBoard(targetBoxLocation + 1) = BoardItemBox
                            GameBoard(targetBoxLocation) = BoardItemBlank
                        Case BoardItemWall
                            PrzesunSkrzynke = False
                            Exit Function
                        Case BoardItemBox
                            PrzesunSkrzynke = False
                            Exit Function
                        Case BoardItemBoxOnPlace
                            PrzesunSkrzynke = False
                            Exit Function
                        Case BoardItemPlaceForBox
                            GameBoard(targetBoxLocation + 1) = BoardItemBoxOnPlace
                            GameBoard(targetBoxLocation) = BoardItemBlank

                            CurrentLevelStats.BoxesOnPlaces += 1
                    End Select
                Case Gora
                    Select Case GameBoard(targetBoxLocation - 16)
                        Case BoardItemBlank
                            GameBoard(targetBoxLocation - 16) = BoardItemBox
                            GameBoard(targetBoxLocation) = BoardItemBlank
                        Case BoardItemWall
                            PrzesunSkrzynke = False
                            Exit Function
                        Case BoardItemBox
                            PrzesunSkrzynke = False
                            Exit Function
                        Case BoardItemBoxOnPlace
                            PrzesunSkrzynke = False
                            Exit Function
                        Case BoardItemPlaceForBox
                            GameBoard(targetBoxLocation - 16) = BoardItemBoxOnPlace
                            GameBoard(targetBoxLocation) = BoardItemPlayer

                            CurrentLevelStats.BoxesOnPlaces += 1
                    End Select
                Case Dol
                    Select Case GameBoard(targetBoxLocation + 16)
                        Case BoardItemBlank
                            GameBoard(targetBoxLocation + 16) = BoardItemBox
                            GameBoard(targetBoxLocation) = BoardItemBlank
                        Case BoardItemWall
                            PrzesunSkrzynke = False
                            Exit Function
                        Case BoardItemBox
                            PrzesunSkrzynke = False
                            Exit Function
                        Case BoardItemBoxOnPlace
                            PrzesunSkrzynke = False
                            Exit Function
                        Case BoardItemPlaceForBox
                            GameBoard(targetBoxLocation + 16) = BoardItemBoxOnPlace
                            GameBoard(targetBoxLocation) = BoardItemBlank

                            CurrentLevelStats.BoxesOnPlaces += 1
                    End Select
            End Select
        End If


        PrzesunSkrzynke = True
    End Function
    Public Function NewGame(ByVal whichLevel As Integer) As Boolean
        Dim ZE As String = Nothing
        CurrentlyPlayedLevelId = whichLevel
        MovesPerformedOnCurrentLevel = 0
        PushesPerformedOnCurrentLevel = 0
        MoveHasBeenPerformed = False
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
            If GameBoard(Counter) = BoardItemPlayer Or GameBoard(Counter) = BoardItemPlayerOnPlace Then PlayerLocation = Counter
        Next Counter

        CurrentLevelStats = Levelset.GetLevelInitialProperties(CurrentlyPlayedLevelId)
        PreviousLevelStats = CurrentLevelStats

        Return True
    End Function
    Public Sub Undo()
        Array.Copy(AllGameBoardStates(AllGameBoardStates.Count - 1), GameBoard, GameBoard.Length)
        AllGameBoardStates.RemoveRange(AllGameBoardStates.Count - 1, 1)

        PlayerLocation = GameBoardDetails.GetIndexOfPlayerOnBoard(GameBoard)
        CurrentLevelStats.BoxesOnPlaces = GameBoardDetails.GetNumberOfPlacedBoxesOnBoard(GameBoard)
        MovesPerformedOnCurrentLevel -= 1
        MoveHasBeenPerformed = False
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

        CurrentLevelStats = Levelset.GetLevelInitialProperties(CurrentlyPlayedLevelId)
        PlayerLocation = CurrentLevelStats.PlayerLocation

        MovesPerformedOnCurrentLevel = 0
        PushesPerformedOnCurrentLevel = 0
        MoveHasBeenPerformed = False
    End Sub
    Public Function SetArrivedLevel() As Integer
        If My.Settings.LevelSet = "Klasyczne" Then
            SetArrivedLevel = My.Settings.ArrivedLevelKlasyczne
        Else
            SetArrivedLevel = My.Settings.ArrivedLevelSupertrudne
        End If
    End Function

End Module