Imports System.Drawing.Drawing2D

''' <remarks>
''' Draws a board: a single control that paints every square itself, instead of one control per
''' square. The squares are CellSize pixels on a side; whoever owns the view chooses that to suit
''' the screen and sizes the view to match. Everything outside the level shows the BackColor.
'''
''' Painting is kept cheap, because it happens on every step the player takes: the icons are
''' scaled to the cell size once, whenever the skin or the cell size changes, so a repaint only
''' copies pixels; and after a move only the squares that changed are repainted.
''' </remarks>
Public NotInheritable Class BoardView
    Inherits Control

    Private ShownBoard As IReadOnlyBoard
    Private ShownSkin As BoardSkin
    Private SideOfCell As Integer = SkinIcons.IconSize

    ' The skin's icons at the current cell size, indexed by BoardItem. Made on the first paint
    ' after the skin or the cell size changes, and disposed when either changes again.
    Private ScaledIcons() As Bitmap

    Public Sub New()
        SetStyle(ControlStyles.AllPaintingInWmPaint Or
                 ControlStyles.OptimizedDoubleBuffer Or
                 ControlStyles.UserPaint Or
                 ControlStyles.ResizeRedraw, True)

        ' The view only shows the game; the keyboard belongs to the game window. A control that
        ' can take the focus takes it as soon as the window opens, and Windows Forms then treats
        ' the arrow keys as keys for moving between controls, so they never reach the game.
        SetStyle(ControlStyles.Selectable, False)
        TabStop = False
    End Sub

    ''' <remarks>The board to draw. Nothing draws an empty view.</remarks>
    Public Property Board As IReadOnlyBoard
        Get
            Return ShownBoard
        End Get
        Set(value As IReadOnlyBoard)
            ShownBoard = value
            Invalidate()
        End Set
    End Property

    Public Property Skin As BoardSkin
        Get
            Return ShownSkin
        End Get
        Set(value As BoardSkin)
            If value <> ShownSkin Then
                ShownSkin = value
                DiscardScaledIcons()
                Invalidate()
            End If
        End Set
    End Property

    Public Property CellSize As Integer
        Get
            Return SideOfCell
        End Get
        Set(value As Integer)
            Dim NewSize As Integer = Math.Max(1, value)
            If NewSize <> SideOfCell Then
                SideOfCell = NewSize
                DiscardScaledIcons()
                Invalidate()
            End If
        End Set
    End Property

    ''' <remarks>
    ''' Repaints just the given squares - after a move, the at most three it changed - instead of
    ''' the whole board.
    ''' </remarks>
    Public Sub InvalidateCells(cells As IEnumerable(Of Cell))
        If cells Is Nothing Then
            Invalidate()
            Exit Sub
        End If

        For Each Square As Cell In cells
            Invalidate(New Rectangle(Square.Column * SideOfCell, Square.Row * SideOfCell, SideOfCell, SideOfCell))
        Next
    End Sub

    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        If e Is Nothing Then
            Throw New ArgumentNullException(NameOf(e))
        End If

        MyBase.OnPaint(e)

        If ShownBoard Is Nothing Then
            Exit Sub
        End If

        If ScaledIcons Is Nothing Then
            ScaledIcons = SkinIcons.CreateScaledIcons(ShownSkin, SideOfCell)
        End If

        ' The icons are already the size of a square, so drawing one is a straight copy.
        Dim Canvas As Graphics = e.Graphics
        Canvas.InterpolationMode = InterpolationMode.NearestNeighbor
        Canvas.PixelOffsetMode = PixelOffsetMode.Half

        ' Only the squares the repaint covers are visited, not the whole board.
        Dim Squares As Integer = ShownBoard.Size
        Dim Area As Rectangle = e.ClipRectangle
        Dim FirstRow As Integer = Math.Max(0, Area.Top \ SideOfCell)
        Dim LastRow As Integer = Math.Min(Squares - 1, (Area.Bottom - 1) \ SideOfCell)
        Dim FirstColumn As Integer = Math.Max(0, Area.Left \ SideOfCell)
        Dim LastColumn As Integer = Math.Min(Squares - 1, (Area.Right - 1) \ SideOfCell)

        For Row As Integer = FirstRow To LastRow
            For Column As Integer = FirstColumn To LastColumn
                Dim Item As BoardItem = ShownBoard(New Cell(Row, Column))
                If Item <> BoardItem.BlankOuter Then
                    Canvas.DrawImage(ScaledIcons(Item), Column * SideOfCell, Row * SideOfCell, SideOfCell, SideOfCell)
                End If
            Next
        Next
    End Sub

    Private Sub DiscardScaledIcons()
        If ScaledIcons Is Nothing Then
            Exit Sub
        End If

        For Each Icon As Bitmap In ScaledIcons
            Icon?.Dispose()
        Next
        ScaledIcons = Nothing
    End Sub

    Protected Overrides Sub Dispose(disposing As Boolean)
        If disposing Then
            DiscardScaledIcons()
        End If

        MyBase.Dispose(disposing)
    End Sub
End Class
