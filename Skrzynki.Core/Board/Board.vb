''' <remarks>A board that can be looked at but not changed: what a game shows to the outside.</remarks>
Public Interface IReadOnlyBoard
    ''' <remarks>The number of squares on each side; boards are always square.</remarks>
    ReadOnly Property Size As Integer

    ''' <remarks>The contents of a square. Squares off the board read as BlankOuter.</remarks>
    <Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1043:UseIntegralOrStringArgumentForIndexers",
        Justification:="A square is named by its row and column; indexing by Cell is the point of the type.")>
    Default ReadOnly Property Item(cell As Cell) As BoardItem
End Interface

''' <remarks>
''' The playing field: a square grid of BoardItems. Every level of a levelset is laid out on a
''' board of the same size - at least MinimumSize on a side, and large enough for the set's largest
''' level - worked out when the set is read and never stored anywhere.
'''
''' A square off the board reads as BlankOuter, the same as the space around a level, so the
''' movement rules need no separate edge check: the edge stops the player like any other outside.
''' </remarks>
Public NotInheritable Class Board
    Implements IReadOnlyBoard

    Public Const MinimumSize As Integer = 16

    ''' <remarks>
    ''' The largest board a set can use, which keeps a malformed file from asking for millions of
    ''' squares. Levels larger than this are skipped.
    ''' </remarks>
    Public Const MaximumSize As Integer = 50

    Private ReadOnly SideLength As Integer
    Private ReadOnly Items() As BoardItem

    ''' <remarks>A board of the given size with nothing on it: every square outside any level.</remarks>
    Public Sub New(size As Integer)
        If size < 1 Then
            Throw New ArgumentOutOfRangeException(NameOf(size))
        End If

        SideLength = size
        ReDim Items(size * size - 1)
        For Index As Integer = 0 To Items.Length - 1
            Items(Index) = BoardItem.BlankOuter
        Next
    End Sub

    Private Sub New(source As Board)
        SideLength = source.SideLength
        Items = CType(source.Items.Clone(), BoardItem())
    End Sub

    Public ReadOnly Property Size As Integer Implements IReadOnlyBoard.Size
        Get
            Return SideLength
        End Get
    End Property

    Public Function Contains(cell As Cell) As Boolean
        Return cell.Row >= 0 AndAlso cell.Row < SideLength AndAlso
               cell.Column >= 0 AndAlso cell.Column < SideLength
    End Function

    ''' <remarks>
    ''' Reading a square off the board gives BlankOuter; writing one is a mistake in the caller and
    ''' throws.
    ''' </remarks>
    <Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1043:UseIntegralOrStringArgumentForIndexers",
        Justification:="A square is named by its row and column; indexing by Cell is the point of the type.")>
    Default Public Property Item(cell As Cell) As BoardItem Implements IReadOnlyBoard.Item
        Get
            If Not Contains(cell) Then
                Return BoardItem.BlankOuter
            End If
            Return Items(cell.Row * SideLength + cell.Column)
        End Get
        Set(value As BoardItem)
            If Not Contains(cell) Then
                Throw New ArgumentOutOfRangeException(NameOf(cell))
            End If
            Items(cell.Row * SideLength + cell.Column) = value
        End Set
    End Property

    ''' <remarks>Every square of the board, row by row from the top-left corner.</remarks>
    Public Iterator Function AllCells() As IEnumerable(Of Cell)
        For Row As Integer = 0 To SideLength - 1
            For Column As Integer = 0 To SideLength - 1
                Yield New Cell(Row, Column)
            Next
        Next
    End Function

    ''' <remarks>Where the player is standing, or Nothing on a board without one.</remarks>
    Public Function FindPlayer() As Cell?
        For Each Position As Cell In AllCells()
            If Me(Position).HoldsPlayer() Then
                Return Position
            End If
        Next

        Return Nothing
    End Function

    ''' <remarks>
    ''' Every square that has to end up under a box: empty goals, goals already covered, and the
    ''' goal the player happens to be standing on.
    ''' </remarks>
    Public Function CountGoals() As Integer
        Dim Goals As Integer = 0
        For Each Item As BoardItem In Items
            If Item.StandsOnGoal() Then
                Goals += 1
            End If
        Next
        Return Goals
    End Function

    Public Function CountCoveredGoals() As Integer
        Dim Covered As Integer = 0
        For Each Item As BoardItem In Items
            If Item = BoardItem.BoxOnPlace Then
                Covered += 1
            End If
        Next
        Return Covered
    End Function

    ''' <remarks>
    ''' A level is solved once every goal square carries a box - not once every box sits on a
    ''' goal. The two differ when a level holds more boxes than goals, where the spare boxes are
    ''' decoys; XS 27 is such a level. A level with no goals at all is never solved, so malformed
    ''' data cannot win by default.
    ''' </remarks>
    Public Function IsSolved() As Boolean
        Dim Goals As Integer = CountGoals()
        Return Goals > 0 AndAlso CountCoveredGoals() = Goals
    End Function

    Public Function Clone() As Board
        Return New Board(Me)
    End Function
End Class
