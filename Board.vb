''' <remarks>
''' What a single square of the board holds. The value folds two facts into one: what the square
''' itself is, and what is standing on it. LevelParser maps the characters of a SOK level onto
''' these, and the skins number their icons by them.
''' </remarks>
Public Enum BoardItem
    Blank = 0
    Wall = 1
    Box = 2
    PlaceForBox = 3
    BoxOnPlace = 4
    Player = 5
    PlayerOnPlace = 6
    BlankOuter = 7
End Enum

''' <remarks>
''' The vocabulary every other part of the game speaks about the playing field: its dimensions,
''' how the flat array is indexed, and how to put an occupant onto a square without disturbing the
''' square itself.
''' </remarks>
Module Board
    ' --- Board indexing convention -------------------------------------------------------------
    ' The playing field is a square grid, some board size N cells on a side, held in a flat array.
    ' Cells occupy indices BoardFirstIndex (1) through N * N; index 0 exists only because VB
    ' declares arrays by upper bound, and is never read, written or drawn.
    '
    ' Row r and column c (both 0-based) live at index r * N + c + 1.
    '
    ' N belongs to a levelset, not to the program: every level of a set is laid out on the same
    ' board, at least MinimumBoardSize on a side and large enough for the set's largest level. It
    ' is worked out when the set is read and never stored anywhere.
    '
    ' Game.Cells and GameBoardForm.CellPictures are index-for-index parallel and share this
    ' convention. Every loop over a board therefore runs BoardFirstIndex to the array's upper
    ' bound, and anything that fills a board array must start writing at BoardFirstIndex.
    Public Const MinimumBoardSize As Integer = 16

    ''' <remarks>
    ''' The largest board a set can use. Each cell is drawn by a control of its own, so this keeps
    ''' a malformed file from asking for millions of them; levels larger than this are skipped.
    ''' </remarks>
    Public Const MaximumBoardSize As Integer = 50

    Public Const BoardFirstIndex As Integer = 1

    ''' <remarks>A board of the given size with nothing on it: every square outside any level.</remarks>
    Public Function EmptyBoard(boardSize As Integer) As BoardItem()
        Dim Cells(boardSize * boardSize) As BoardItem
        For Index As Integer = BoardFirstIndex To Cells.Length - 1
            Cells(Index) = BoardItem.BlankOuter
        Next
        Return Cells
    End Function

    ' --- Reading the floor back out of a cell --------------------------------------------------
    ' Undo has to put an occupant back onto a square without disturbing the square itself, so it
    ' asks these what the cell should read as once a given occupant is placed on it. The floor is
    ' always recoverable, because each of the six occupiable values names it.

    Public Function StandsOnGoal(cell As BoardItem) As Boolean
        Return cell = BoardItem.PlaceForBox OrElse
               cell = BoardItem.BoxOnPlace OrElse
               cell = BoardItem.PlayerOnPlace
    End Function

    Public Function WithPlayer(cell As BoardItem) As BoardItem
        Return If(StandsOnGoal(cell), BoardItem.PlayerOnPlace, BoardItem.Player)
    End Function

    Public Function WithBox(cell As BoardItem) As BoardItem
        Return If(StandsOnGoal(cell), BoardItem.BoxOnPlace, BoardItem.Box)
    End Function

    Public Function WithNothing(cell As BoardItem) As BoardItem
        Return If(StandsOnGoal(cell), BoardItem.PlaceForBox, BoardItem.Blank)
    End Function

    ' --- Asking what a square will allow -------------------------------------------------------

    ''' <remarks>Whether anything can stand on this square: a wall and the outside cannot.</remarks>
    Public Function IsWalkable(cell As BoardItem) As Boolean
        Return cell <> BoardItem.Wall AndAlso cell <> BoardItem.BlankOuter
    End Function

    ''' <remarks>Whether a box is standing here, on plain floor or on a goal.</remarks>
    Public Function HoldsBox(cell As BoardItem) As Boolean
        Return cell = BoardItem.Box OrElse cell = BoardItem.BoxOnPlace
    End Function

    ' --- Directions as data ---------------------------------------------------------------------
    ' A direction is a row and column step. Holding it as data rather than as one branch per
    ' direction is what lets the movement rules be written once instead of four times.

    Public Function RowStep(direction As MoveDirection) As Integer
        Select Case direction
            Case MoveDirection.Up
                Return -1
            Case MoveDirection.Down
                Return 1
            Case Else
                Return 0
        End Select
    End Function

    Public Function ColumnStep(direction As MoveDirection) As Integer
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
    Public Function Opposite(direction As MoveDirection) As MoveDirection
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

''' <remarks>
''' One square of a board, as a row and a column rather than a position in the flat array, which
''' Index converts back to. Naming squares this way means stepping off the left edge lands outside
''' the board, where a bare index minus one would land on the previous row's last column. A cell
''' carries the size of the board it belongs to, and so do its neighbours.
''' </remarks>
Public Structure Cell
    Implements IEquatable(Of Cell)

    Private ReadOnly CellRow As Integer
    Private ReadOnly CellColumn As Integer
    Private ReadOnly SideLength As Integer

    Public Sub New(row As Integer, column As Integer, boardSize As Integer)
        CellRow = row
        CellColumn = column
        SideLength = boardSize
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

    Public ReadOnly Property BoardSize As Integer
        Get
            Return SideLength
        End Get
    End Property

    Public ReadOnly Property IsOnBoard As Boolean
        Get
            Return CellRow >= 0 AndAlso CellRow < SideLength AndAlso
                   CellColumn >= 0 AndAlso CellColumn < SideLength
        End Get
    End Property

    ''' <remarks>
    ''' Where this square sits in the flat board array. Only meaningful for a square that is on
    ''' the board; callers check IsOnBoard first.
    ''' </remarks>
    Public ReadOnly Property Index As Integer
        Get
            Return CellRow * SideLength + CellColumn + BoardFirstIndex
        End Get
    End Property

    Public Shared Function FromIndex(cellIndex As Integer, boardSize As Integer) As Cell
        Dim Offset As Integer = cellIndex - BoardFirstIndex
        Return New Cell(Offset \ boardSize, Offset Mod boardSize, boardSize)
    End Function

    ''' <remarks>The adjacent square in the given direction, which may be off the board.</remarks>
    Public Function Neighbour(direction As MoveDirection) As Cell
        Return New Cell(CellRow + RowStep(direction), CellColumn + ColumnStep(direction), SideLength)
    End Function

    Public Overrides Function Equals(obj As Object) As Boolean
        If TypeOf obj Is Cell Then
            Return Equals(CType(obj, Cell))
        End If

        Return False
    End Function

    Public Overloads Function Equals(other As Cell) As Boolean Implements IEquatable(Of Cell).Equals
        Return CellRow = other.CellRow AndAlso CellColumn = other.CellColumn AndAlso
               SideLength = other.SideLength
    End Function

    Public Overrides Function GetHashCode() As Integer
        Return (CellRow * MaximumBoardSize + CellColumn) * MaximumBoardSize + SideLength
    End Function

    Public Shared Operator =(left As Cell, right As Cell) As Boolean
        Return left.Equals(right)
    End Operator

    Public Shared Operator <>(left As Cell, right As Cell) As Boolean
        Return Not left.Equals(right)
    End Operator
End Structure
