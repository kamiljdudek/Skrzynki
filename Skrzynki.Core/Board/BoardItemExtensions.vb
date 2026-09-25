Imports System.Runtime.CompilerServices

''' <remarks>
''' How to put an occupant onto a square without disturbing the square itself, and what a square
''' will allow. Undo has to put an occupant back without losing the floor underneath, and the
''' floor is always recoverable, because each of the six occupiable values names it.
''' </remarks>
Friend Module BoardItemExtensions
    <Extension>
    Friend Function StandsOnGoal(item As BoardItem) As Boolean
        Return item = BoardItem.PlaceForBox OrElse
               item = BoardItem.BoxOnPlace OrElse
               item = BoardItem.PlayerOnPlace
    End Function

    <Extension>
    Friend Function WithPlayer(item As BoardItem) As BoardItem
        Return If(item.StandsOnGoal(), BoardItem.PlayerOnPlace, BoardItem.Player)
    End Function

    <Extension>
    Friend Function WithBox(item As BoardItem) As BoardItem
        Return If(item.StandsOnGoal(), BoardItem.BoxOnPlace, BoardItem.Box)
    End Function

    <Extension>
    Friend Function WithNothing(item As BoardItem) As BoardItem
        Return If(item.StandsOnGoal(), BoardItem.PlaceForBox, BoardItem.Blank)
    End Function

    ''' <remarks>Whether anything can stand on this square: a wall and the outside cannot.</remarks>
    <Extension>
    Friend Function IsWalkable(item As BoardItem) As Boolean
        Return item <> BoardItem.Wall AndAlso item <> BoardItem.BlankOuter
    End Function

    ''' <remarks>Whether a box is standing here, on plain floor or on a goal.</remarks>
    <Extension>
    Friend Function HoldsBox(item As BoardItem) As Boolean
        Return item = BoardItem.Box OrElse item = BoardItem.BoxOnPlace
    End Function

    <Extension>
    Friend Function HoldsPlayer(item As BoardItem) As Boolean
        Return item = BoardItem.Player OrElse item = BoardItem.PlayerOnPlace
    End Function
End Module
