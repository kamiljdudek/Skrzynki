Attribute VB_Name = "modFindMIDI"
Global LiczbaPlikow As Long

Public Const INVALID_HANDLE_VALUE = -1
Public Const MAX_PATH = 260
Public Const FILE_ATTRIBUTE_DIRECTORY = &H10

Public Type FILETIME
    dwLowDateTime As Long
    dwHighDateTime As Long
End Type

Public Type WIN32_FIND_DATA
    dwFileAttributes As Long
    ftCreationTime As FILETIME
    ftLastAccessTime As FILETIME
    ftLastWriteTime As FILETIME
    nFileSizeHigh As Long
    nFileSizeLow As Long
    dwReserved0 As Long
    dwReserved1 As Long
    cFileName As String * MAX_PATH
    cAlternate As String * 14
End Type

Public Declare Function FindFirstFile Lib "kernel32" Alias "FindFirstFileA" _
(ByVal lpFileName As String, lpFindFileData As WIN32_FIND_DATA) As Long
Public Declare Function FindNextFile Lib "kernel32" Alias "FindNextFileA" _
(ByVal hFindFile As Long, lpFindFileData As WIN32_FIND_DATA) As Long
Public Declare Function FindClose Lib "kernel32" (ByVal hFindFile As Long) As Long

Public Const DRIVE_REMOVABLE = 2
Public Const DRIVE_FIXED = 3
Public Const DRIVE_REMOTE = 4
Public Const DRIVE_CDROM = 5
Public Const DRIVE_RAMDISK = 6
Public Declare Function GetDriveType Lib "kernel32" Alias "GetDriveTypeA" _
(ByVal nDrive As String) As Long

Public Sub PrzetwarzajFolder(ByVal strPath As String)
    Dim lHandle As Long, lRet As Long, strTPath As String
    Dim fdFile As WIN32_FIND_DATA
    Dim strFile As String
    
    frmFindMIDI.lblFolder.Caption = strPath
    
    If Right$(strPath, 1) <> "\" Then strPath = strPath & "\"
    strTPath = strPath & "*.*"
    
    fdFile.dwFileAttributes = 1
    lRet = 1
    lHandle = FindFirstFile(strTPath, fdFile)
    Do While lHandle <> INVALID_HANDLE_VALUE And lRet <> 0
        DoEvents
        
        strFile = strip(fdFile.cFileName)
        If strFile = "." Or strFile = ".." Then
        'Omijamy
        ElseIf (fdFile.dwFileAttributes And FILE_ATTRIBUTE_DIRECTORY) = _
        FILE_ATTRIBUTE_DIRECTORY Then
        'Katalog
            PrzetwarzajFolder strPath & strFile
        Else
            If UCase$(Right$(strFile, 3)) = "MID" Then
                Print #iniMidi, strPath & strFile
                LiczbaPlikow = LiczbaPlikow + 1
            End If
        End If
        lRet = FindNextFile(lHandle, fdFile)
        
        DoEvents
    Loop
    FindClose lHandle
End Sub

Public Function strip(ByVal str As String) As String
Dim i As Long

i = InStr(str, Chr$(0))
If i > 0 Then
strip = Left$(str, i - 1)
Else
strip = str
End If
End Function
Public Function ShowDriveType(ByVal strDrive As String) As String
    Dim lRet As Long
    
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
    Screen.MousePointer = vbHourglass
    
    iniMidi = FreeFile()
    Open App.Path & "\INI\MIDI.INI" For Output As #iniMidi
        PrzetwarzajFolder ("C:\")
        If ShowDriveType("D:") <> "CD-ROM" Then PrzetwarzajFolder ("D:\")
        If ShowDriveType("E:") <> "CD-ROM" Then PrzetwarzajFolder ("E:\")
    Close #iniMidi
    
    Screen.MousePointer = vbDefault
    
    MsgBox ZwrocCiag("FindMIDIDialog#3") & LiczbaPlikow, vbOKOnly + vbInformation + vbApplicationModal, App.Title
End Sub

Public Sub PrzywrocOryginalnyINI()
    iniMidi = FreeFile()
    Open App.Path & "\INI\MIDI.INI" For Output As #iniMidi
        LiczbaPlikow = 0
        DoEvents
        PrzetwarzajFolder App.Path & "\MIDI\"
    Close #iniMidi
End Sub
