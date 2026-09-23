''' <remarks>
''' What a single square of the board holds. The value folds two facts into one: what the square
''' itself is, and what is standing on it. The digits match the characters a level map is written
''' with, so BuildBoardState can read a map straight into these.
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
    ' The playing field is a fixed BoardWidth x BoardHeight grid held in a flat array. Cells occupy
    ' indices BoardFirstIndex (1) through BoardCellCount (256); index 0 exists only because VB
    ' declares arrays by upper bound, and is never read, written or drawn.
    '
    ' Row r and column c (both 0-based) live at index r * BoardWidth + c + 1.
    '
    ' 倉庫番.GameBoard and GameBoardForm.CellPictures are index-for-index parallel and share this
    ' convention. Every loop over the board therefore runs BoardFirstIndex To BoardCellCount, and
    ' anything that fills a board array must start writing at BoardFirstIndex.
    Public Const BoardWidth As Integer = 16
    Public Const BoardHeight As Integer = 16
    Public Const BoardCellCount As Integer = BoardWidth * BoardHeight
    Public Const BoardFirstIndex As Integer = 1

    ''' <remarks>Whether the index names a square on the board at all.</remarks>
    Public Function IsOnBoard(cellIndex As Integer) As Boolean
        Return cellIndex >= BoardFirstIndex AndAlso cellIndex <= BoardCellCount
    End Function

    ' --- Reading the floor back out of a cell --------------------------------------------------
    ' Undo has to put an occupant back onto a square without disturbing the square itself, so it
    ' asks these what the cell should read as once a given occupant is placed on it. The floor is
    ' always recoverable, because each of the six occupiable values names it.

    Public Function StandsOnGoal(cellValue As Integer) As Boolean
        Return cellValue = CInt(BoardItem.PlaceForBox) OrElse
               cellValue = CInt(BoardItem.BoxOnPlace) OrElse
               cellValue = CInt(BoardItem.PlayerOnPlace)
    End Function

    Public Function WithPlayer(cellValue As Integer) As Integer
        Return CInt(If(StandsOnGoal(cellValue), BoardItem.PlayerOnPlace, BoardItem.Player))
    End Function

    Public Function WithBox(cellValue As Integer) As Integer
        Return CInt(If(StandsOnGoal(cellValue), BoardItem.BoxOnPlace, BoardItem.Box))
    End Function

    Public Function WithNothing(cellValue As Integer) As Integer
        Return CInt(If(StandsOnGoal(cellValue), BoardItem.PlaceForBox, BoardItem.Blank))
    End Function
End Module
