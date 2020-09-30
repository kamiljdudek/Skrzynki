Module Skin
    Public Function GetIcon(ByVal Id As Integer) As System.Drawing.Bitmap

        Dim Oryginalny() As System.Drawing.Icon = {
            My.Resources.Oryginalny0,
            My.Resources.Oryginalny1,
            My.Resources.Oryginalny2,
            My.Resources.Oryginalny3,
            My.Resources.Oryginalny4,
            My.Resources.Oryginalny5,
            My.Resources.Oryginalny6}

        Dim Serowy() As System.Drawing.Icon = {
            My.Resources.Serowy0,
            My.Resources.Serowy1,
            My.Resources.Serowy2,
            My.Resources.Serowy3,
            My.Resources.Serowy4,
            My.Resources.Serowy5,
            My.Resources.Serowy6}

        Dim Eksport() As System.Drawing.Icon = {
            My.Resources.Eksport0,
            My.Resources.Eksport1,
            My.Resources.Eksport2,
            My.Resources.Eksport3,
            My.Resources.Eksport4,
            My.Resources.Eksport5,
            My.Resources.Eksport6}

        If My.Settings.Skin = "(Oryginalny)" Then
            Return Oryginalny(Id).ToBitmap()
        ElseIf My.Settings.Skin = "Serowy" Then
            Return Serowy(Id).ToBitmap()
        ElseIf My.Settings.Skin = "Eksport" Then
            Return Eksport(Id).ToBitmap()
        End If
        Return My.Resources.Oryginalny0.ToBitmap()
    End Function

End Module
