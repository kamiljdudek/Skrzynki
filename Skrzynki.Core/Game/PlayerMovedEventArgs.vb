Imports System.Collections.ObjectModel

''' <remarks>
''' What a move, or the taking back of one, changed on the board: at most three squares. Knowing
''' them lets a view repaint just those rather than the whole board.
''' </remarks>
Public NotInheritable Class PlayerMovedEventArgs
    Inherits EventArgs

    Private ReadOnly Changed As ReadOnlyCollection(Of Cell)

    Public Sub New(changedCells As IList(Of Cell))
        If changedCells Is Nothing Then
            Throw New ArgumentNullException(NameOf(changedCells))
        End If

        Changed = New ReadOnlyCollection(Of Cell)(changedCells)
    End Sub

    ''' <remarks>
    ''' The squares whose contents changed: where the player was, where the player is now, and -
    ''' when a box moved with them - the square the box was pushed onto or pulled from.
    ''' </remarks>
    Public ReadOnly Property ChangedCells As ReadOnlyCollection(Of Cell)
        Get
            Return Changed
        End Get
    End Property
End Class
