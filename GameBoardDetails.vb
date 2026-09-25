''' <remarks>Questions asked of a whole board: where the player is, and how near it is to solved.</remarks>
Module GameBoardDetails
    ''' <remarks>Index of the player on the board, or -1 when there is no player.</remarks>
    Public Function GetIndexOfPlayerOnBoard(board() As BoardItem) As Integer
        For Index As Integer = BoardFirstIndex To BoardCellCount
            If board(Index) = BoardItem.Player OrElse board(Index) = BoardItem.PlayerOnPlace Then
                Return Index
            End If
        Next

        Return -1
    End Function

    Public Function GetNumberOfPlacedBoxesOnBoard(board() As BoardItem) As Integer
        Dim PlacedBoxes As Integer = 0

        For Index As Integer = BoardFirstIndex To BoardCellCount
            If board(Index) = BoardItem.BoxOnPlace Then
                PlacedBoxes += 1
            End If
        Next

        Return PlacedBoxes
    End Function

    ''' <remarks>
    ''' Every square that has to end up under a box: empty goals, goals already covered, and the
    ''' goal the player happens to be standing on.
    ''' </remarks>
    Public Function GetTotalNumberOfGoalsOnBoard(board() As BoardItem) As Integer
        Dim Goals As Integer = 0

        For Index As Integer = BoardFirstIndex To BoardCellCount
            If StandsOnGoal(board(Index)) Then
                Goals += 1
            End If
        Next

        Return Goals
    End Function

    ''' <remarks>
    ''' A level is solved once every goal square carries a box - not once every box sits on a
    ''' goal. The two differ when a level holds more boxes than goals, where the spare boxes are
    ''' decoys; XS 27 is such a level. A level with no goals at all is never solved, so malformed
    ''' data cannot win by default.
    ''' </remarks>
    Public Function IsBoardSolved(board() As BoardItem) As Boolean
        Dim NumberOfGoals As Integer = GetTotalNumberOfGoalsOnBoard(board)
        If NumberOfGoals < 1 Then
            Return False
        End If

        Return GetNumberOfPlacedBoxesOnBoard(board) = NumberOfGoals
    End Function
End Module
