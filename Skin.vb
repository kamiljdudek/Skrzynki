Module Skin
    ' One bitmap per BoardItem per skin, built once on first use and reused from then on. GetIcon
    ' runs for all BoardCellCount cells on every full board refresh, so converting the icons each
    ' time would allocate a Bitmap - and leak a GDI handle - per cell per refresh. The cache is
    ' keyed by skin name and lives for the life of the process.
    Private ReadOnly SkinCache As New System.Collections.Generic.Dictionary(Of String, System.Drawing.Bitmap())

    Private Const SkinOriginal As String = "(Oryginalny)"
    Private Const SkinCheese As String = "Serowy"
    Private Const SkinExport As String = "Eksport"

    Private Function LoadSkin(ByVal skinName As String) As System.Drawing.Bitmap()
        Dim Icons() As System.Drawing.Icon

        Select Case skinName
            Case SkinCheese
                Icons = {
                    My.Resources.Serowy0,
                    My.Resources.Serowy1,
                    My.Resources.Serowy2,
                    My.Resources.Serowy3,
                    My.Resources.Serowy4,
                    My.Resources.Serowy5,
                    My.Resources.Serowy6}
            Case SkinExport
                Icons = {
                    My.Resources.Eksport0,
                    My.Resources.Eksport1,
                    My.Resources.Eksport2,
                    My.Resources.Eksport3,
                    My.Resources.Eksport4,
                    My.Resources.Eksport5,
                    My.Resources.Eksport6}
            Case Else
                Icons = {
                    My.Resources.Oryginalny0,
                    My.Resources.Oryginalny1,
                    My.Resources.Oryginalny2,
                    My.Resources.Oryginalny3,
                    My.Resources.Oryginalny4,
                    My.Resources.Oryginalny5,
                    My.Resources.Oryginalny6}
        End Select

        Dim Bitmaps(Icons.Length - 1) As System.Drawing.Bitmap
        For i As Integer = 0 To Icons.Length - 1
            Bitmaps(i) = Icons(i).ToBitmap()
        Next

        Return Bitmaps
    End Function

    ''' <remarks>
    ''' Bitmap for a board item under the currently selected skin. The returned bitmap is shared
    ''' and owned by this cache - callers must not dispose it.
    ''' </remarks>
    Public Function GetIcon(ByVal Id As Integer) As System.Drawing.Bitmap
        Dim SkinName As String = My.Settings.Skin
        If String.IsNullOrEmpty(SkinName) Then
            SkinName = SkinOriginal
        End If

        Dim Bitmaps() As System.Drawing.Bitmap = Nothing
        If Not SkinCache.TryGetValue(SkinName, Bitmaps) Then
            Bitmaps = LoadSkin(SkinName)
            SkinCache.Add(SkinName, Bitmaps)
        End If

        If Id < 0 OrElse Id > Bitmaps.Length - 1 Then
            Return Bitmaps(CInt(BoardItem.Blank))
        End If

        Return Bitmaps(Id)
    End Function

End Module
