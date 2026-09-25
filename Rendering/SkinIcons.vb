''' <remarks>The looks the board can be drawn in. My.Settings.Skin holds the name of one of these.</remarks>
Public Enum BoardSkin
    Original
    Cheese
    Export
End Enum

''' <remarks>
''' The icons each skin draws the board with. A skin's icons are project resources named with its
''' prefix and numbered by the BoardItem they show: Serowy0 is the Blank square of the cheese skin,
''' Serowy6 its PlayerOnPlace.
''' </remarks>
Friend NotInheritable Class SkinIcons
    ' One bitmap per BoardItem per skin, built on first use and kept for the life of the process:
    ' the board draws every square on every repaint, and converting the icons each time would
    ' allocate a Bitmap - and a GDI handle - per square per repaint.
    Private Shared ReadOnly Cache As New Dictionary(Of BoardSkin, Bitmap())

    ''' <remarks>The icons' own size; the board draws them larger or smaller from this.</remarks>
    Public Const IconSize As Integer = 32

    Private Sub New()
    End Sub

    ''' <remarks>
    ''' The skin a setting names. Before the setting held these names it held the skins' Polish
    ''' names, which are still understood; anything else draws as the original.
    ''' </remarks>
    Public Shared Function FromSetting(value As String) As BoardSkin
        Dim Parsed As BoardSkin
        If [Enum].TryParse(value, Parsed) AndAlso [Enum].IsDefined(GetType(BoardSkin), Parsed) Then
            Return Parsed
        End If

        Select Case value
            Case "Serowy"
                Return BoardSkin.Cheese
            Case "Eksport"
                Return BoardSkin.Export
            Case Else
                Return BoardSkin.Original
        End Select
    End Function

    Private Shared Function ResourcePrefix(skin As BoardSkin) As String
        Select Case skin
            Case BoardSkin.Cheese
                Return "Serowy"
            Case BoardSkin.Export
                Return "Eksport"
            Case Else
                Return "Oryginalny"
        End Select
    End Function

    Private Shared Function LoadSkin(skin As BoardSkin) As Bitmap()
        ' BlankOuter has no icon: nothing is drawn outside the level.
        Dim LastIcon As Integer = CInt(BoardItem.PlayerOnPlace)
        Dim Bitmaps(LastIcon) As Bitmap

        For Item As Integer = 0 To LastIcon
            Dim ResourceName As String =
                ResourcePrefix(skin) & Item.ToString(Globalization.CultureInfo.InvariantCulture)

            Using Icon As Icon = TryCast(
                My.Resources.ResourceManager.GetObject(ResourceName, My.Resources.Culture), Icon)
                ' Every skin has to supply every icon; a gap is a packaging mistake, reported by
                ' name rather than as a null reference somewhere in the drawing code.
                If Icon Is Nothing Then
                    Throw New InvalidOperationException(FormattableString.Invariant(
                        $"The skin resource {ResourceName} is missing or is not an icon."))
                End If

                Bitmaps(Item) = Icon.ToBitmap()
            End Using
        Next

        Return Bitmaps
    End Function

    ''' <remarks>
    ''' The icon for a board item in the given skin, or Nothing for an item that is not drawn. The
    ''' bitmap is shared and owned by this cache - callers must not dispose it.
    ''' </remarks>
    Public Shared Function GetIcon(item As BoardItem, skin As BoardSkin) As Bitmap
        Dim Bitmaps() As Bitmap = Nothing
        If Not Cache.TryGetValue(skin, Bitmaps) Then
            Bitmaps = LoadSkin(skin)
            Cache.Add(skin, Bitmaps)
        End If

        If item < 0 OrElse item > Bitmaps.Length - 1 Then
            Return Nothing
        End If

        Return Bitmaps(item)
    End Function
End Class
