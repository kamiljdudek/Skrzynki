Imports System.Drawing.Drawing2D

''' <remarks>
''' Draws a board: a single control that paints every square itself, instead of one control per
''' square. The squares are CellSize pixels on a side; whoever owns the view chooses that to suit
''' the screen and sizes the view to match. Everything outside the level shows the BackColor.
'''
''' Pixel art is scaled with the nearest neighbour when the cell is a whole multiple of the icons'
''' size, which keeps every pixel sharp, and smoothly otherwise, where the nearest neighbour would
''' leave some pixels wider than others.
''' </remarks>
Public NotInheritable Class BoardView
    Inherits Control

    Private ShownBoard As IReadOnlyBoard
    Private ShownSkin As BoardSkin
    Private SideOfCell As Integer = SkinIcons.IconSize

    Public Sub New()
        SetStyle(ControlStyles.AllPaintingInWmPaint Or
                 ControlStyles.OptimizedDoubleBuffer Or
                 ControlStyles.UserPaint Or
                 ControlStyles.ResizeRedraw, True)
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
            ShownSkin = value
            Invalidate()
        End Set
    End Property

    Public Property CellSize As Integer
        Get
            Return SideOfCell
        End Get
        Set(value As Integer)
            SideOfCell = Math.Max(1, value)
            Invalidate()
        End Set
    End Property

    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        If e Is Nothing Then
            Throw New ArgumentNullException(NameOf(e))
        End If

        MyBase.OnPaint(e)

        If ShownBoard Is Nothing Then
            Exit Sub
        End If

        Dim Canvas As Graphics = e.Graphics
        If SideOfCell Mod SkinIcons.IconSize = 0 Then
            Canvas.InterpolationMode = InterpolationMode.NearestNeighbor
            Canvas.PixelOffsetMode = PixelOffsetMode.Half
        Else
            Canvas.InterpolationMode = InterpolationMode.HighQualityBicubic
            Canvas.PixelOffsetMode = PixelOffsetMode.HighQuality
        End If

        For Row As Integer = 0 To ShownBoard.Size - 1
            For Column As Integer = 0 To ShownBoard.Size - 1
                Dim Square As New Rectangle(Column * SideOfCell, Row * SideOfCell, SideOfCell, SideOfCell)

                ' Only what the repaint actually covers is drawn.
                If Not e.ClipRectangle.IntersectsWith(Square) Then
                    Continue For
                End If

                Dim Item As BoardItem = ShownBoard(New Cell(Row, Column))
                If Item <> BoardItem.BlankOuter Then
                    Canvas.DrawImage(SkinIcons.GetIcon(Item, ShownSkin), Square)
                End If
            Next
        Next
    End Sub
End Class
