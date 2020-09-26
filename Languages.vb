Option Strict Off
Option Explicit On
Module modLanguages
	Public Declare Function GetINIInt Lib "kernel32"  Alias "GetPrivateProfileIntA"(ByVal lpApplicationName As String, ByVal lpKeyName As String, ByVal nDefault As Integer, ByVal lpFileName As String) As Integer
	'UPGRADE_ISSUE: Declaring a parameter 'As Any' is not supported. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1016"'
	Public Declare Function GetINIString Lib "kernel32"  Alias "GetPrivateProfileStringA"(ByVal lpApplicationName As String, ByVal lpKeyName As Any, ByVal lpDefault As String, ByVal lpReturnedString As String, ByVal nSize As Integer, ByVal lpFileName As String) As Integer
	Public Declare Function GetUserDefaultLCID Lib "kernel32" () As Integer
	Public Sub PrzetlumaczForme(ByRef frm As System.Windows.Forms.Form)
		Dim ctl As System.Windows.Forms.Control
		
		If InStr(1, frm.Tag, "#") > 0 Then frm.Text = ZwrocCiag(frm.Tag)
		
		Select Case frm.Name
			Case "frmOptions"
				'UPGRADE_ISSUE: Control tabOptions could not be resolved because it was within the generic namespace Form. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup2072"'
				frm.tabOptions.Tab = 0
				'UPGRADE_ISSUE: Control tabOptions could not be resolved because it was within the generic namespace Form. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup2072"'
				frm.tabOptions.Caption = ZwrocCiag("OptionsDialog#0")
				'UPGRADE_ISSUE: Control tabOptions could not be resolved because it was within the generic namespace Form. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup2072"'
				frm.tabOptions.Tab = 1
				'UPGRADE_ISSUE: Control tabOptions could not be resolved because it was within the generic namespace Form. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup2072"'
				frm.tabOptions.Caption = ZwrocCiag("OptionsDialog#1")
				'UPGRADE_ISSUE: Control tabOptions could not be resolved because it was within the generic namespace Form. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup2072"'
				frm.tabOptions.Tab = 2
				'UPGRADE_ISSUE: Control tabOptions could not be resolved because it was within the generic namespace Form. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup2072"'
				frm.tabOptions.Caption = ZwrocCiag("OptionsDialog#2")
				'UPGRADE_ISSUE: Control tabOptions could not be resolved because it was within the generic namespace Form. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup2072"'
				frm.tabOptions.Tab = 3
				'UPGRADE_ISSUE: Control tabOptions could not be resolved because it was within the generic namespace Form. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup2072"'
				frm.tabOptions.Caption = ZwrocCiag("OptionsDialog#3")
				'UPGRADE_ISSUE: Control tabOptions could not be resolved because it was within the generic namespace Form. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup2072"'
				frm.tabOptions.Tab = 4
				'UPGRADE_ISSUE: Control tabOptions could not be resolved because it was within the generic namespace Form. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup2072"'
				frm.tabOptions.Caption = ZwrocCiag("OptionsDialog#4")
				'UPGRADE_ISSUE: Control tabOptions could not be resolved because it was within the generic namespace Form. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup2072"'
				frm.tabOptions.Tab = 0
			Case "frmMain"
				'UPGRADE_ISSUE: Control mnuGame could not be resolved because it was within the generic namespace Form. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup2072"'
				frm.mnuGame.Caption = ZwrocCiag("Menu#0")
				'UPGRADE_ISSUE: Control mnuGameNew could not be resolved because it was within the generic namespace Form. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup2072"'
				frm.mnuGameNew.Caption = ZwrocCiag("Menu#1")
				'UPGRADE_ISSUE: Control mnuGameWarp could not be resolved because it was within the generic namespace Form. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup2072"'
				frm.mnuGameWarp.Caption = ZwrocCiag("Menu#2")
				'UPGRADE_ISSUE: Control mnuGameSet could not be resolved because it was within the generic namespace Form. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup2072"'
				frm.mnuGameSet.Caption = ZwrocCiag("Menu#3")
				'UPGRADE_ISSUE: Control mnuGameSetKlasyczne could not be resolved because it was within the generic namespace Form. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup2072"'
				frm.mnuGameSetKlasyczne.Caption = ZwrocCiag("Sets#0")
				'UPGRADE_ISSUE: Control mnuGameSetSuperTrudneXS could not be resolved because it was within the generic namespace Form. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup2072"'
				frm.mnuGameSetSuperTrudneXS.Caption = ZwrocCiag("Sets#1")
				'UPGRADE_ISSUE: Control mnuGameOpen could not be resolved because it was within the generic namespace Form. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup2072"'
				frm.mnuGameOpen.Caption = ZwrocCiag("Menu#4")
				'UPGRADE_ISSUE: Control mnuGameExit could not be resolved because it was within the generic namespace Form. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup2072"'
				frm.mnuGameExit.Caption = ZwrocCiag("Menu#5")
				'UPGRADE_ISSUE: Control mnuView could not be resolved because it was within the generic namespace Form. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup2072"'
				frm.mnuView.Caption = ZwrocCiag("Menu#6")
				'UPGRADE_ISSUE: Control mnuViewStatusbar could not be resolved because it was within the generic namespace Form. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup2072"'
				frm.mnuViewStatusbar.Caption = ZwrocCiag("Menu#7")
				'UPGRADE_ISSUE: Control mnuViewRefresh could not be resolved because it was within the generic namespace Form. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup2072"'
				frm.mnuViewRefresh.Caption = ZwrocCiag("Menu#8")
				'UPGRADE_ISSUE: Control mnuTools could not be resolved because it was within the generic namespace Form. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup2072"'
				frm.mnuTools.Caption = ZwrocCiag("Menu#9")
				'UPGRADE_ISSUE: Control mnuToolsUndo could not be resolved because it was within the generic namespace Form. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup2072"'
				frm.mnuToolsUndo.Caption = ZwrocCiag("Menu#10")
				'UPGRADE_ISSUE: Control mnuToolsRestart could not be resolved because it was within the generic namespace Form. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup2072"'
				frm.mnuToolsRestart.Caption = ZwrocCiag("Menu#11")
				'UPGRADE_ISSUE: Control mnuToolsOptions could not be resolved because it was within the generic namespace Form. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup2072"'
				frm.mnuToolsOptions.Caption = ZwrocCiag("Menu#12")
				'UPGRADE_ISSUE: Control mnuHelp could not be resolved because it was within the generic namespace Form. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup2072"'
				frm.mnuHelp.Caption = ZwrocCiag("Menu#13")
				'UPGRADE_ISSUE: Control mnuHelpContents could not be resolved because it was within the generic namespace Form. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup2072"'
				frm.mnuHelpContents.Caption = ZwrocCiag("Menu#14")
				'UPGRADE_ISSUE: Control mnuHelpTips could not be resolved because it was within the generic namespace Form. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup2072"'
				frm.mnuHelpTips.Caption = ZwrocCiag("Menu#15")
				'UPGRADE_ISSUE: Control mnuHelpWeb could not be resolved because it was within the generic namespace Form. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup2072"'
				frm.mnuHelpWeb.Caption = ZwrocCiag("Menu#16")
				'UPGRADE_ISSUE: Control mnuHelpAbout could not be resolved because it was within the generic namespace Form. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup2072"'
				frm.mnuHelpAbout.Caption = ZwrocCiag("Menu#17")
		End Select
		
		For	Each ctl In frm.Controls
			If InStr(1, ctl.Tag, "#") > 0 Then
				ctl.Text = ZwrocCiag(ctl.Tag)
			End If
		Next ctl
	End Sub
	Public Function ZwrocCiag(ByVal TagKontrolki As String) As String
		Dim Temp As Object
		Dim Section, Key As String
		Dim Returned As New VB6.FixedLengthString(5000)
		
		'UPGRADE_WARNING: Couldn't resolve default property of object Temp. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
		Temp = Split(TagKontrolki, "#")
		RegWartosc = RegSciezka & "\Options\Language"
		'UPGRADE_WARNING: Couldn't resolve default property of object Temp(). Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
		Section = Temp(0)
		'UPGRADE_WARNING: Couldn't resolve default property of object Temp(). Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
		Key = Temp(1)
		
		'UPGRADE_WARNING: Couldn't resolve default property of object RegObj.Get. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
		ZwrocCiag = Left(Returned.Value, GetINIString(Section, Key, "(No string)", Returned.Value, 5000, VB6.GetPath & "\Jezyki\" & RegObj.Get(RegWartosc) & ".bxl"))
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
					RegWartosc = RegSciezka & "\Options\Language"
					'UPGRADE_WARNING: Couldn't resolve default property of object Temp1. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
					RegDaneStr = Temp1
					'UPGRADE_WARNING: Couldn't resolve default property of object RegObj.Set. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
					RegObj.Set(RegWartosc, RegDaneStr, RegFlush)
					
					Exit Sub
				End If
			Next i
		Loop 
		FileClose(Kanal)
		
		RegWartosc = RegSciezka & "\Options\Language"
		RegDaneStr = "English"
		'UPGRADE_WARNING: Couldn't resolve default property of object RegObj.Set. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
		RegObj.Set(RegWartosc, RegDaneStr, RegFlush)
	End Sub
End Module