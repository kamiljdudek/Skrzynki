Module Skin
    ' One bitmap per BoardItem per skin, built once on first use and reused from then on. GetIcon
    ' runs for every cell of the board on every full refresh, so converting the icons each
    ' time would allocate a Bitmap - and leak a GDI handle - per cell per refresh. The cache is
    ' keyed by resource prefix and lives for the life of the process.
    Private ReadOnly SkinCache As New System.Collections.Generic.Dictionary(Of String, System.Drawing.Bitmap())

    ' The values stored in My.Settings.Skin.
    Public Const SkinOriginal As String = "(Oryginalny)"
    Public Const SkinCheese As String = "Serowy"
    Public Const SkinExport As String = "Eksport"

    ''' <remarks>
    ''' A skin's icons are project resources named with this prefix and numbered by the BoardItem
    ''' they show: Serowy0 is the Blank square of the cheese skin, Serowy6 its PlayerOnPlace.
    ''' Anything that is not a known skin draws as the original.
    ''' </remarks>
    Private Function ResourcePrefix(skinName As String) As String
        Select Case skinName
            Case SkinCheese
                Return "Serowy"
            Case SkinExport
                Return "Eksport"
            Case Else
                Return "Oryginalny"
        End Select
    End Function

    Private Function LoadSkin(prefix As String) As System.Drawing.Bitmap()
        ' BlankOuter has no icon: nothing is drawn outside the level.
        Dim LastIcon As Integer = CInt(BoardItem.PlayerOnPlace)
        Dim Bitmaps(LastIcon) As System.Drawing.Bitmap

        For Item As Integer = 0 To LastIcon
            Dim ResourceName As String =
                prefix & Item.ToString(System.Globalization.CultureInfo.InvariantCulture)

            Using Icon As System.Drawing.Icon = TryCast(
                My.Resources.ResourceManager.GetObject(ResourceName, My.Resources.Culture),
                System.Drawing.Icon)
                ' Every skin has to supply every icon; a gap is a packaging mistake, reported by
                ' name rather than as a null reference somewhere in the drawing code.
                If Icon Is Nothing Then
                    Throw New InvalidOperationException(
                        "The skin resource " & ResourceName & " is missing or is not an icon.")
                End If

                Bitmaps(Item) = Icon.ToBitmap()
            End Using
        Next

        Return Bitmaps
    End Function

    ''' <remarks>
    ''' Bitmap for a board item under the currently selected skin. The returned bitmap is shared
    ''' and owned by this cache - callers must not dispose it.
    ''' </remarks>
    Public Function GetIcon(item As BoardItem) As System.Drawing.Bitmap
        Dim Prefix As String = ResourcePrefix(My.Settings.Skin)

        Dim Bitmaps() As System.Drawing.Bitmap = Nothing
        If Not SkinCache.TryGetValue(Prefix, Bitmaps) Then
            Bitmaps = LoadSkin(Prefix)
            SkinCache.Add(Prefix, Bitmaps)
        End If

        If item < 0 OrElse item > Bitmaps.Length - 1 Then
            Return Bitmaps(BoardItem.Blank)
        End If

        Return Bitmaps(item)
    End Function

End Module
