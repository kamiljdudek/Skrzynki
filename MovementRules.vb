Partial Public Class Game
    ' -------------------------------------------------------------------------------------------
    ' |                                   MOVEMENT RULES                                        |
    ' -------------------------------------------------------------------------------------------
    '
    ' The rules of Sokoban: the player steps onto the next square, and if a box is standing there
    ' it is pushed one square further. Each rule is stated once rather than once per direction,
    ' because a direction is a row and column step that Cell.Neighbour applies.
    ' -------------------------------------------------------------------------------------------

    ''' <summary>
    ''' Moves the player one square in the given direction, pushing a box out of the way if one is
    ''' standing there, and records the move in the attempt history.
    ''' </summary>
    ''' <param name="direction">The direction the player is trying to walk in.</param>
    ''' <returns>
    ''' True when the player moved. False when a wall, the edge of the level, or a box that cannot
    ''' be pushed blocks the way, in which case nothing on the board changes.
    ''' </returns>
    Public Function TryMovePlayer(direction As MoveDirection) As Boolean
        Dim Player As Cell = Cell.FromIndex(PlayerLocation, SideLength)
        Dim Ahead As Cell = Player.Neighbour(direction)

        ' Walls and the space outside the level both stop the player.
        If Not Ahead.IsOnBoard OrElse Not IsWalkable(Cells(Ahead.Index)) Then
            Return False
        End If

        ' A push that turns out to be blocked returns before anything has been written, so the
        ' board is left exactly as it was.
        Dim PushedBox As Boolean = HoldsBox(Cells(Ahead.Index))
        If PushedBox AndAlso Not TryPushBox(direction, Ahead) Then
            Return False
        End If

        ' Both squares are re-encoded from the floor they already report, so goals survive the
        ' move. The square ahead still reads as a box when one has just been pushed off it, and
        ' its floor is recoverable from that too.
        Cells(Player.Index) = WithNothing(Cells(Player.Index))
        Cells(Ahead.Index) = WithPlayer(Cells(Ahead.Index))
        PlayerLocation = Ahead.Index

        MoveCount += 1
        If PushedBox Then
            PushCount += 1
        End If
        RecordedMoves.Add(New MoveRecord(direction, PushedBox))

        Return True
    End Function

    ''' <summary>
    ''' Pushes the box on the given square one square further in the given direction.
    ''' </summary>
    ''' <param name="direction">The direction the box is being pushed in.</param>
    ''' <param name="boxCell">The square the box is standing on.</param>
    ''' <returns>True when the box moved, False when it has nowhere to go.</returns>
    ''' <remarks>
    ''' Only the square the box moves to is written. The square it came from is left alone,
    ''' because the player steps onto it immediately afterwards and overwrites it.
    ''' </remarks>
    Private Function TryPushBox(direction As MoveDirection, boxCell As Cell) As Boolean
        Dim Beyond As Cell = boxCell.Neighbour(direction)

        ' A box needs somewhere to go: not off the level, not a wall, and not another box.
        If Not Beyond.IsOnBoard Then
            Return False
        End If

        Dim BeyondItem As BoardItem = Cells(Beyond.Index)
        If Not IsWalkable(BeyondItem) OrElse HoldsBox(BeyondItem) Then
            Return False
        End If

        Cells(Beyond.Index) = WithBox(BeyondItem)
        Return True
    End Function
End Class
