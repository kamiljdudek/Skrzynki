Partial Public Module 倉庫番
    ' -------------------------------------------------------------------------------------------
    ' |                            THE MIGRATED 2001 MOVEMENT CODE                              |
    ' -------------------------------------------------------------------------------------------

    ''' <remarks>
    ''' Function PrzesunGracza: używana, kiedy gracz wciśnie klawisz kursora; zwraca True, jeśli
    ''' przesunięcie jest możliwe (jednocześnie je wykonuje); kierunek jestokreślony parametrem moveDirection
    ''' </remarks>
    Public Function PrzesunGracza(moveDirection As System.Windows.Forms.Keys) As Boolean
        If LevelCleared Then
            PrzesunGracza = False
            Exit Function
        End If

        PushHasJustBeenPerformed = False
        Dim StateBeforeMove(BoardCellCount) As Integer
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
                Select Case GameBoard(PlayerLocation - BoardWidth)
                    Case BoardItem.Blank
                        If GameBoard(PlayerLocation) = BoardItem.PlayerOnPlace Then
                            GameBoard(PlayerLocation) = BoardItem.PlaceForBox
                        Else
                            GameBoard(PlayerLocation) = BoardItem.Blank
                        End If

                        GameBoard(PlayerLocation - BoardWidth) = BoardItem.Player
                        PlayerLocation -= BoardWidth
                    Case BoardItem.Wall
                        PrzesunGracza = False
                        Exit Function
                    Case BoardItem.Box
                        If PrzesunSkrzynke(System.Windows.Forms.Keys.Up, PlayerLocation - BoardWidth, False) = False Then
                            PrzesunGracza = False
                            Exit Function
                        End If

                        If GameBoard(PlayerLocation) = BoardItem.PlayerOnPlace Then
                            GameBoard(PlayerLocation) = BoardItem.PlaceForBox
                        Else
                            GameBoard(PlayerLocation) = BoardItem.Blank
                        End If

                        GameBoard(PlayerLocation - BoardWidth) = BoardItem.Player
                        PlayerLocation -= BoardWidth

                        PushesPerformedOnCurrentLevel += 1
                    Case BoardItem.PlaceForBox
                        If GameBoard(PlayerLocation) = BoardItem.PlayerOnPlace Then
                            GameBoard(PlayerLocation) = BoardItem.PlaceForBox
                        Else
                            GameBoard(PlayerLocation) = BoardItem.Blank
                        End If

                        GameBoard(PlayerLocation - BoardWidth) = BoardItem.PlayerOnPlace
                        PlayerLocation -= BoardWidth
                    Case BoardItem.BoxOnPlace
                        If PrzesunSkrzynke(System.Windows.Forms.Keys.Up, PlayerLocation - BoardWidth, True) = False Then
                            PrzesunGracza = False
                            Exit Function
                        End If

                        If GameBoard(PlayerLocation) = BoardItem.PlayerOnPlace Then
                            GameBoard(PlayerLocation) = BoardItem.PlaceForBox
                        Else
                            GameBoard(PlayerLocation) = BoardItem.Blank
                        End If

                        GameBoard(PlayerLocation - BoardWidth) = BoardItem.PlayerOnPlace
                        PlayerLocation -= BoardWidth

                        PushesPerformedOnCurrentLevel += 1
                End Select
            Case System.Windows.Forms.Keys.Down
                Select Case GameBoard(PlayerLocation + BoardWidth)
                    Case BoardItem.Blank
                        If GameBoard(PlayerLocation) = BoardItem.PlayerOnPlace Then
                            GameBoard(PlayerLocation) = BoardItem.PlaceForBox
                        Else
                            GameBoard(PlayerLocation) = BoardItem.Blank
                        End If

                        GameBoard(PlayerLocation + BoardWidth) = BoardItem.Player
                        PlayerLocation += BoardWidth
                    Case BoardItem.Wall
                        PrzesunGracza = False
                        Exit Function
                    Case BoardItem.Box
                        If PrzesunSkrzynke(System.Windows.Forms.Keys.Down, PlayerLocation + BoardWidth, False) = False Then
                            PrzesunGracza = False
                            Exit Function
                        End If

                        If GameBoard(PlayerLocation) = BoardItem.PlayerOnPlace Then
                            GameBoard(PlayerLocation) = BoardItem.PlaceForBox
                        Else
                            GameBoard(PlayerLocation) = BoardItem.Blank
                        End If

                        GameBoard(PlayerLocation + BoardWidth) = BoardItem.Player
                        PlayerLocation += BoardWidth

                        PushesPerformedOnCurrentLevel += 1
                    Case BoardItem.PlaceForBox
                        If GameBoard(PlayerLocation) = BoardItem.PlayerOnPlace Then
                            GameBoard(PlayerLocation) = BoardItem.PlaceForBox
                        Else
                            GameBoard(PlayerLocation) = BoardItem.Blank
                        End If

                        GameBoard(PlayerLocation + BoardWidth) = BoardItem.PlayerOnPlace
                        PlayerLocation += BoardWidth
                    Case BoardItem.BoxOnPlace
                        If PrzesunSkrzynke(System.Windows.Forms.Keys.Down, PlayerLocation + BoardWidth, True) = False Then
                            PrzesunGracza = False
                            Exit Function
                        End If

                        If GameBoard(PlayerLocation) = BoardItem.PlayerOnPlace Then
                            GameBoard(PlayerLocation) = BoardItem.PlaceForBox
                        Else
                            GameBoard(PlayerLocation) = BoardItem.Blank
                        End If

                        GameBoard(PlayerLocation + BoardWidth) = BoardItem.PlayerOnPlace
                        PlayerLocation += BoardWidth

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
    Public Function PrzesunSkrzynke(moveDirection As System.Windows.Forms.Keys, targetBoxLocation As Integer, fromProperlyPlacedLocation As Boolean) As Boolean
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
                    Select Case GameBoard(targetBoxLocation - BoardWidth)
                        Case BoardItem.Blank
                            GameBoard(targetBoxLocation - BoardWidth) = BoardItem.Box
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
                            GameBoard(targetBoxLocation - BoardWidth) = BoardItem.BoxOnPlace
                    End Select
                Case System.Windows.Forms.Keys.Down
                    Select Case GameBoard(targetBoxLocation + BoardWidth)
                        Case BoardItem.Blank
                            GameBoard(targetBoxLocation + BoardWidth) = BoardItem.Box
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
                            GameBoard(targetBoxLocation + BoardWidth) = BoardItem.BoxOnPlace
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
                    Select Case GameBoard(targetBoxLocation - BoardWidth)
                        Case BoardItem.Blank
                            GameBoard(targetBoxLocation - BoardWidth) = BoardItem.Box
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
                            GameBoard(targetBoxLocation - BoardWidth) = BoardItem.BoxOnPlace
                            GameBoard(targetBoxLocation) = BoardItem.Blank
                    End Select
                Case System.Windows.Forms.Keys.Down
                    Select Case GameBoard(targetBoxLocation + BoardWidth)
                        Case BoardItem.Blank
                            GameBoard(targetBoxLocation + BoardWidth) = BoardItem.Box
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
                            GameBoard(targetBoxLocation + BoardWidth) = BoardItem.BoxOnPlace
                            GameBoard(targetBoxLocation) = BoardItem.Blank
                    End Select
            End Select
        End If

        PushHasJustBeenPerformed = True
        PrzesunSkrzynke = True
    End Function
End Module

