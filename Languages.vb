Option Strict Off
Option Explicit On
Module modLanguages
	Public Declare Function GetINIInt Lib "kernel32"  Alias "GetPrivateProfileIntA"(ByVal lpApplicationName As String, ByVal lpKeyName As String, ByVal nDefault As Integer, ByVal lpFileName As String) As Integer
	'UPGRADE_ISSUE: Declaring a parameter 'As Any' is not supported. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1016"'
    Public Declare Function GetINIString Lib "kernel32" Alias "GetPrivateProfileStringA" (ByVal lpApplicationName As String, ByVal lpKeyName As Object, ByVal lpDefault As String, ByVal lpReturnedString As String, ByVal nSize As Integer, ByVal lpFileName As String) As Integer
	Public Declare Function GetUserDefaultLCID Lib "kernel32" () As Integer
	Public Sub PrzetlumaczForme(ByRef frm As System.Windows.Forms.Form)

	End Sub
	Public Function ZwrocCiag(ByVal TagKontrolki As String) As String
		Dim Temp As Object
		Dim Section, Key As String
		Dim Returned As New VB6.FixedLengthString(5000)
		
		'UPGRADE_WARNING: Couldn't resolve default property of object Temp. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
		Temp = Split(TagKontrolki, "#")
		'UPGRADE_WARNING: Couldn't resolve default property of object Temp(). Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
		Section = Temp(0)
		'UPGRADE_WARNING: Couldn't resolve default property of object Temp(). Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
		Key = Temp(1)
		
        'UPGRADE_WARNING: Couldn't resolve default property of object RegObj.Get. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
        modMain.RegKey = Microsoft.Win32.Registry.CurrentUser.OpenSubKey(RegSciezka & "\\Options", True)
        modMain.RegString = RegKey.GetValue("Language", "Polski")
        ZwrocCiag = Left(Returned.Value, GetINIString(Section, Key, "(No string)", Returned.Value, 5000, VB6.GetPath & "\Jezyki\" & modMain.RegString & ".bxl"))
		ZwrocCiag = Replace(ZwrocCiag, "<crlf>", Chr(10))
	End Function
	Public Sub RozpoznajJezyk()
		Dim i, Kanal, LCID As Integer
		Dim Temp2, Temp1, Temp3 As Object
		Dim Returned As New VB6.FixedLengthString(255)
		
		Kanal = FreeFile
		LCID = GetUserDefaultLCID()
		
		FileOpen(Kanal, VB6.GetPath & "\Ini\Jezyki.ini", OpenMode.Input)
		Do Until EOF(Kanal)
			Temp1 = LineInput(Kanal)
			'UPGRADE_WARNING: Couldn't resolve default property of object Temp1. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
			'UPGRADE_WARNING: Couldn't resolve default property of object Temp2. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
			Temp2 = Left(Returned.Value, GetINIString("Info" & Chr(0), "Countries" & Chr(0), "1033", Returned.Value, 255, VB6.GetPath & "\Jezyki\" & Temp1 & ".bxl" & Chr(0)))
			'UPGRADE_WARNING: Couldn't resolve default property of object Temp2. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
			'UPGRADE_WARNING: Couldn't resolve default property of object Temp3. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
			Temp3 = Split(Temp2, ",")
			
			For i = LBound(Temp3) To UBound(Temp3)
				'UPGRADE_WARNING: Couldn't resolve default property of object Temp3(). Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
				If Val(Temp3(i)) = LCID Then
					'UPGRADE_WARNING: Couldn't resolve default property of object Temp1. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
					RegDaneStr = Temp1
                    modMain.RegKey = Microsoft.Win32.Registry.CurrentUser.OpenSubKey(RegSciezka & "\\Options", True)
                    RegKey.SetValue("Language", RegDaneStr)
					
					Exit Sub
				End If
			Next i
		Loop 
		FileClose(Kanal)
		
        modMain.RegKey = Microsoft.Win32.Registry.CurrentUser.OpenSubKey(RegSciezka & "\\Options", True)
        RegKey.SetValue("Language", "English")
	End Sub
End Module