Option Strict Off
Option Explicit On
Module modFindMIDI
	Public LiczbaPlikow As Integer
	
	Public Const INVALID_HANDLE_VALUE As Short = -1
	Public Const MAX_PATH As Short = 260
	Public Const FILE_ATTRIBUTE_DIRECTORY As Short = &H10s
	
	Public Structure FILETIME
		Dim dwLowDateTime As Integer
		Dim dwHighDateTime As Integer
	End Structure
	
	Public Structure WIN32_FIND_DATA
		Dim dwFileAttributes As Integer
		Dim ftCreationTime As FILETIME
		Dim ftLastAccessTime As FILETIME
		Dim ftLastWriteTime As FILETIME
		Dim nFileSizeHigh As Integer
		Dim nFileSizeLow As Integer
		Dim dwReserved0 As Integer
		Dim dwReserved1 As Integer
		<VBFixedString(MAX_PATH),System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.ByValTStr,SizeConst:=MAX_PATH)> Public cFileName As String
		<VBFixedString(14),System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.ByValTStr,SizeConst:=14)> Public cAlternate As String
	End Structure
	
	'UPGRADE_WARNING: Structure WIN32_FIND_DATA may require marshalling attributes to be passed as an argument in this Declare statement. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1050"'
	Public Declare Function FindFirstFile Lib "kernel32"  Alias "FindFirstFileA"(ByVal lpFileName As String, ByRef lpFindFileData As WIN32_FIND_DATA) As Integer
	'UPGRADE_WARNING: Structure WIN32_FIND_DATA may require marshalling attributes to be passed as an argument in this Declare statement. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1050"'
	Public Declare Function FindNextFile Lib "kernel32"  Alias "FindNextFileA"(ByVal hFindFile As Integer, ByRef lpFindFileData As WIN32_FIND_DATA) As Integer
	Public Declare Function FindClose Lib "kernel32" (ByVal hFindFile As Integer) As Integer
	
	Public Const DRIVE_REMOVABLE As Short = 2
	Public Const DRIVE_FIXED As Short = 3
	Public Const DRIVE_REMOTE As Short = 4
	Public Const DRIVE_CDROM As Short = 5
	Public Const DRIVE_RAMDISK As Short = 6
	Public Declare Function GetDriveType Lib "kernel32"  Alias "GetDriveTypeA"(ByVal nDrive As String) As Integer
	
	Public Sub PrzetwarzajFolder(ByVal strPath As String)
		Dim lHandle, lRet As Integer
		Dim strTPath As String
		Dim fdFile As WIN32_FIND_DATA
		Dim strFile As String
		
		frmFindMIDI.DefInstance.lblFolder.Text = strPath
		
		If Right(strPath, 1) <> "\" Then strPath = strPath & "\"
		strTPath = strPath & "*.*"
		
		fdFile.dwFileAttributes = 1
		lRet = 1
		lHandle = FindFirstFile(strTPath, fdFile)
		Do While lHandle <> INVALID_HANDLE_VALUE And lRet <> 0
			System.Windows.Forms.Application.DoEvents()
			
			strFile = strip(fdFile.cFileName)
			If strFile = "." Or strFile = ".." Then
				'Omijamy
			ElseIf (fdFile.dwFileAttributes And FILE_ATTRIBUTE_DIRECTORY) = FILE_ATTRIBUTE_DIRECTORY Then 
				'Katalog
				PrzetwarzajFolder(strPath & strFile)
			Else
				If UCase(Right(strFile, 3)) = "MID" Then
					PrintLine(iniMidi, strPath & strFile)
					LiczbaPlikow = LiczbaPlikow + 1
				End If
			End If
			lRet = FindNextFile(lHandle, fdFile)
			
			System.Windows.Forms.Application.DoEvents()
		Loop 
		FindClose(lHandle)
	End Sub
	
	'UPGRADE_NOTE: str was upgraded to str_Renamed. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1061"'
	Public Function strip(ByVal str_Renamed As String) As String
		Dim i As Integer
		
		i = InStr(str_Renamed, Chr(0))
		If i > 0 Then
			strip = Left(str_Renamed, i - 1)
		Else
			strip = str_Renamed
		End If
	End Function
	Public Function ShowDriveType(ByVal strDrive As String) As String
		Dim lRet As Integer
		
		lRet = GetDriveType(strDrive)
		
		Select Case lRet
			Case 0
				ShowDriveType = "Unknown"
			Case 1
				ShowDriveType = "N/A"
			Case DRIVE_REMOVABLE
				ShowDriveType = "Removable"
			Case DRIVE_FIXED
				ShowDriveType = "Fixed"
			Case DRIVE_REMOTE
				ShowDriveType = "Remote"
			Case DRIVE_CDROM
				ShowDriveType = "CD-ROM"
			Case DRIVE_RAMDISK
				ShowDriveType = "RAM Disk"
		End Select
	End Function
	
	Public Sub PrzetwarzajDyski()
		'UPGRADE_WARNING: Screen property Screen.MousePointer has a new behavior. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup2065"'
		System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
		
		iniMidi = FreeFile
		FileOpen(iniMidi, VB6.GetPath & "\INI\MIDI.INI", OpenMode.Output)
		PrzetwarzajFolder(("C:\"))
		If ShowDriveType("D:") <> "CD-ROM" Then PrzetwarzajFolder(("D:\"))
		If ShowDriveType("E:") <> "CD-ROM" Then PrzetwarzajFolder(("E:\"))
		FileClose(iniMidi)
		
		'UPGRADE_WARNING: Screen property Screen.MousePointer has a new behavior. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup2065"'
		System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
		
		MsgBox(ZwrocCiag("FindMIDIDialog#3") & LiczbaPlikow, MsgBoxStyle.OKOnly + MsgBoxStyle.Information + MsgBoxStyle.ApplicationModal, System.Reflection.Assembly.GetExecutingAssembly.GetName.Name)
	End Sub
	
	Public Sub PrzywrocOryginalnyINI()
		iniMidi = FreeFile
		FileOpen(iniMidi, VB6.GetPath & "\INI\MIDI.INI", OpenMode.Output)
		LiczbaPlikow = 0
		System.Windows.Forms.Application.DoEvents()
		PrzetwarzajFolder(VB6.GetPath & "\MIDI\")
		FileClose(iniMidi)
	End Sub
End Module