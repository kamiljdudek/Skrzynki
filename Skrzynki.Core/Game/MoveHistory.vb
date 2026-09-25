''' <remarks>
''' One move made by the player: the direction taken, and whether a box was pushed along with it.
''' Those two facts are enough to undo the move and to write it out in LURD notation, the format
''' Sokoban solutions are normally exchanged in.
''' </remarks>
Friend Structure MoveRecord
    Private ReadOnly RecordedDirection As MoveDirection
    Private ReadOnly RecordedPush As Boolean

    Public Sub New(direction As MoveDirection, pushedBox As Boolean)
        RecordedDirection = direction
        RecordedPush = pushedBox
    End Sub

    Public ReadOnly Property Direction As MoveDirection
        Get
            Return RecordedDirection
        End Get
    End Property

    Public ReadOnly Property PushedBox As Boolean
        Get
            Return RecordedPush
        End Get
    End Property

    ''' <remarks>
    ''' The move in LURD notation: l, u, r or d for a plain step, upper case when the step pushed
    ''' a box.
    ''' </remarks>
    Public ReadOnly Property LurdCharacter As Char
        Get
            Dim Letter As Char

            Select Case RecordedDirection
                Case MoveDirection.Up
                    Letter = "u"c
                Case MoveDirection.Down
                    Letter = "d"c
                Case MoveDirection.Left
                    Letter = "l"c
                Case Else
                    Letter = "r"c
            End Select

            If RecordedPush Then
                Return Char.ToUpperInvariant(Letter)
            End If

            Return Letter
        End Get
    End Property
End Structure

''' <remarks>
''' The moves made on the level currently being played, in order. This is what Undo walks back and
''' what a solution is written from, so it is the record of the attempt rather than a by-product
''' of one.
''' </remarks>
Friend NotInheritable Class MoveHistory
    Private ReadOnly RecordedMoves As New List(Of MoveRecord)

    Public ReadOnly Property IsEmpty As Boolean
        Get
            Return RecordedMoves.Count = 0
        End Get
    End Property

    ''' <remarks>The whole attempt so far in LURD notation.</remarks>
    Public ReadOnly Property Lurd As String
        Get
            Dim Written As New System.Text.StringBuilder(RecordedMoves.Count)

            For Each RecordedMove As MoveRecord In RecordedMoves
                Written.Append(RecordedMove.LurdCharacter)
            Next

            Return Written.ToString()
        End Get
    End Property

    Public Sub Add(recordedMove As MoveRecord)
        RecordedMoves.Add(recordedMove)
    End Sub

    ''' <remarks>Removes the most recent move and returns it. The caller checks IsEmpty first.</remarks>
    Public Function TakeLast() As MoveRecord
        If RecordedMoves.Count = 0 Then
            Throw New InvalidOperationException("There is no move to take back.")
        End If

        Dim LastMove As MoveRecord = RecordedMoves(RecordedMoves.Count - 1)
        RecordedMoves.RemoveAt(RecordedMoves.Count - 1)

        Return LastMove
    End Function

    Public Sub Clear()
        RecordedMoves.Clear()
    End Sub
End Class
