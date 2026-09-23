Module GameBoardDetails
    Public Function GetIndexOfPlayerOnBoard(ByRef Board() As Integer) As Integer
        Dim PlayerLocation As Integer = Array.IndexOf(Board, 5)
        If PlayerLocation < 0 Then
            PlayerLocation = Array.IndexOf(Board, 6)
        End If
        Return PlayerLocation
    End Function

    Public Function GetNumberOfPlacedBoxesOnBoard(ByRef Board() As Integer) As Integer
        Dim NumberOfBoxes As Integer = 0
        Dim subset As Integer()
        subset = Array.FindAll(Board, Function(value As Integer) value = 4)
        NumberOfBoxes += subset.Length

        Return NumberOfBoxes
    End Function

    ''' <remarks>
    ''' Every square that has to end up under a box: empty goals, goals already covered, and the
    ''' goal the player happens to be standing on.
    ''' </remarks>
    Public Function GetTotalNumberOfGoalsOnBoard(ByRef Board() As Integer) As Integer
        Dim NumberOfGoals As Integer = 0
        NumberOfGoals += Array.FindAll(Board, Function(value As Integer) value = BoardItem.PlaceForBox).Length
        NumberOfGoals += Array.FindAll(Board, Function(value As Integer) value = BoardItem.BoxOnPlace).Length
        NumberOfGoals += Array.FindAll(Board, Function(value As Integer) value = BoardItem.PlayerOnPlace).Length

        Return NumberOfGoals
    End Function

    ''' <remarks>
    ''' A level is solved once every goal square carries a box - not once every box sits on a
    ''' goal. The two differ when a level holds more boxes than goals, where the spare boxes are
    ''' decoys; XS 27 is such a level. A level with no goals at all is never solved, so malformed
    ''' data cannot win by default.
    ''' </remarks>
    Public Function IsBoardSolved(ByRef Board() As Integer) As Boolean
        Dim NumberOfGoals As Integer = GetTotalNumberOfGoalsOnBoard(Board)
        If NumberOfGoals < 1 Then
            Return False
        End If

        Return GetNumberOfPlacedBoxesOnBoard(Board) = NumberOfGoals
    End Function
End Module
