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

    Public Function GetNumberOfUnplacedBoxesOnBoard(ByRef Board() As Integer) As Integer
        Dim NumberOfBoxes As Integer = 0
        Dim subset As Integer()
        subset = Array.FindAll(Board, Function(value As Integer) value = 2)
        NumberOfBoxes += subset.Length

        Return NumberOfBoxes
    End Function

    Public Function GetTotalNumberOfBoxesOnBoard(ByRef Board() As Integer) As Integer
        Return GetNumberOfPlacedBoxesOnBoard(Board) + GetNumberOfUnplacedBoxesOnBoard(Board)
    End Function
End Module
