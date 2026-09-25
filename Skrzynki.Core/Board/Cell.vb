''' <remarks>
''' One square, as a row and a column counted from the top-left corner. Naming squares this way
''' means stepping off the left edge lands outside the board, where a position in a flat array
''' minus one would land on the previous row's last column. Whether a square is on a particular
''' board is the board's to say.
''' </remarks>
Public Structure Cell
    Implements IEquatable(Of Cell)

    Private ReadOnly CellRow As Integer
    Private ReadOnly CellColumn As Integer

    Public Sub New(row As Integer, column As Integer)
        CellRow = row
        CellColumn = column
    End Sub

    Public ReadOnly Property Row As Integer
        Get
            Return CellRow
        End Get
    End Property

    Public ReadOnly Property Column As Integer
        Get
            Return CellColumn
        End Get
    End Property

    ''' <remarks>The adjacent square in the given direction, which may be off the board.</remarks>
    Public Function Neighbour(direction As MoveDirection) As Cell
        Return New Cell(CellRow + direction.RowStep(), CellColumn + direction.ColumnStep())
    End Function

    Public Overrides Function Equals(obj As Object) As Boolean
        If TypeOf obj Is Cell Then
            Return Equals(CType(obj, Cell))
        End If

        Return False
    End Function

    Public Overloads Function Equals(other As Cell) As Boolean Implements IEquatable(Of Cell).Equals
        Return CellRow = other.CellRow AndAlso CellColumn = other.CellColumn
    End Function

    Public Overrides Function GetHashCode() As Integer
        Return (CellRow * 397) Xor CellColumn
    End Function

    Public Shared Operator =(left As Cell, right As Cell) As Boolean
        Return left.Equals(right)
    End Operator

    Public Shared Operator <>(left As Cell, right As Cell) As Boolean
        Return Not left.Equals(right)
    End Operator
End Structure
