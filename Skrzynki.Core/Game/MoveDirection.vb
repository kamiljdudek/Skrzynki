Imports System.Runtime.CompilerServices

''' <remarks>
''' A direction of travel on the board, independent of whatever input device asked for it.
''' </remarks>
Public Enum MoveDirection
    Up
    Down
    Left
    Right
End Enum

''' <remarks>
''' A direction as data: a row and a column step. Holding it this way rather than as one branch per
''' direction is what lets the movement rules be written once instead of four times.
''' </remarks>
Friend Module MoveDirectionExtensions
    <Extension>
    Friend Function RowStep(direction As MoveDirection) As Integer
        Select Case direction
            Case MoveDirection.Up
                Return -1
            Case MoveDirection.Down
                Return 1
            Case Else
                Return 0
        End Select
    End Function

    <Extension>
    Friend Function ColumnStep(direction As MoveDirection) As Integer
        Select Case direction
            Case MoveDirection.Left
                Return -1
            Case MoveDirection.Right
                Return 1
            Case Else
                Return 0
        End Select
    End Function

    ''' <remarks>The direction that walks back the way this one came.</remarks>
    <Extension>
    Friend Function Opposite(direction As MoveDirection) As MoveDirection
        Select Case direction
            Case MoveDirection.Up
                Return MoveDirection.Down
            Case MoveDirection.Down
                Return MoveDirection.Up
            Case MoveDirection.Left
                Return MoveDirection.Right
            Case Else
                Return MoveDirection.Left
        End Select
    End Function
End Module
