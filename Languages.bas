Attribute VB_Name = "modLanguages"
Public Declare Function GetINIInt Lib "kernel32" Alias "GetPrivateProfileIntA" (ByVal lpApplicationName As String, ByVal lpKeyName As String, ByVal nDefault As Long, ByVal lpFileName As String) As Long
Public Declare Function GetINIString Lib "kernel32" Alias "GetPrivateProfileStringA" (ByVal lpApplicationName As String, ByVal lpKeyName As Any, ByVal lpDefault As String, ByVal lpReturnedString As String, ByVal nSize As Long, ByVal lpFileName As String) As Long
Public Declare Function GetUserDefaultLCID Lib "kernel32" () As Long
Public Sub PrzetlumaczForme(frm As Form)
    Dim ctl As Control
    
    If InStr(1, frm.Tag, "#") > 0 Then frm.Caption = ZwrocCiag(frm.Tag)
    
    Select Case frm.Name
    Case "frmOptions"
        frm.tabOptions.Tab = 0
        frm.tabOptions.Caption = ZwrocCiag("OptionsDialog#0")
        frm.tabOptions.Tab = 1
        frm.tabOptions.Caption = ZwrocCiag("OptionsDialog#1")
        frm.tabOptions.Tab = 2
        frm.tabOptions.Caption = ZwrocCiag("OptionsDialog#2")
        frm.tabOptions.Tab = 3
        frm.tabOptions.Caption = ZwrocCiag("OptionsDialog#3")
        frm.tabOptions.Tab = 4
        frm.tabOptions.Caption = ZwrocCiag("OptionsDialog#4")
        frm.tabOptions.Tab = 0
    Case "frmMain"
        frm.mnuGame.Caption = ZwrocCiag("Menu#0")
        frm.mnuGameNew.Caption = ZwrocCiag("Menu#1")
        frm.mnuGameWarp.Caption = ZwrocCiag("Menu#2")
        frm.mnuGameSet.Caption = ZwrocCiag("Menu#3")
        frm.mnuGameSetKlasyczne.Caption = ZwrocCiag("Sets#0")
        frm.mnuGameSetSuperTrudneXS.Caption = ZwrocCiag("Sets#1")
        frm.mnuGameOpen.Caption = ZwrocCiag("Menu#4")
        frm.mnuGameExit.Caption = ZwrocCiag("Menu#5")
        frm.mnuView.Caption = ZwrocCiag("Menu#6")
        frm.mnuViewStatusbar.Caption = ZwrocCiag("Menu#7")
        frm.mnuViewRefresh.Caption = ZwrocCiag("Menu#8")
        frm.mnuTools.Caption = ZwrocCiag("Menu#9")
        frm.mnuToolsUndo.Caption = ZwrocCiag("Menu#10")
        frm.mnuToolsRestart.Caption = ZwrocCiag("Menu#11")
        frm.mnuToolsOptions.Caption = ZwrocCiag("Menu#12")
        frm.mnuHelp.Caption = ZwrocCiag("Menu#13")
        frm.mnuHelpContents.Caption = ZwrocCiag("Menu#14")
        frm.mnuHelpTips.Caption = ZwrocCiag("Menu#15")
        frm.mnuHelpWeb.Caption = ZwrocCiag("Menu#16")
        frm.mnuHelpAbout.Caption = ZwrocCiag("Menu#17")
    End Select
    
    For Each ctl In frm.Controls
        If InStr(1, ctl.Tag, "#") > 0 Then
            ctl.Caption = ZwrocCiag(ctl.Tag)
        End If
    Next ctl
End Sub
Public Function ZwrocCiag(ByVal TagKontrolki As String) As String
    Dim Temp As Variant
    Dim Section As String, Key As String
    Dim Returned As String * 5000
    
    Temp = Split(TagKontrolki, "#")
    RegWartosc = RegSciezka & "\Options\Language"
    Section = Temp(0)
    Key = Temp(1)
    
    ZwrocCiag = Left$(Returned, GetINIString(Section, Key, "(No string)", Returned, 5000, App.Path & "\Jezyki\" & RegObj.Get(RegWartosc) & ".bxl"))
    ZwrocCiag = Replace(ZwrocCiag, "<crlf>", Chr$(10))
End Function
Public Sub RozpoznajJezyk()
    Dim Kanal As Long, i As Long, LCID As Long
    Dim Temp1 As Variant, Temp2 As Variant, Temp3 As Variant
    Dim Returned As String * 255
    
    Kanal = FreeFile()
    LCID = GetUserDefaultLCID()
    
    Open App.Path & "\Ini\Jezyki.ini" For Input As #Kanal
        Do Until EOF(Kanal)
            Line Input #Kanal, Temp1
            Temp2 = Left$(Returned, GetINIString("Info" & Chr$(0), "Countries" & Chr$(0), "1033", Returned, 255, App.Path & "\Jezyki\" & Temp1 & ".bxl" & Chr$(0)))
            Temp3 = Split(Temp2, ",")
            
            For i = LBound(Temp3) To UBound(Temp3)
                If Val(Temp3(i)) = LCID Then
                    RegWartosc = RegSciezka & "\Options\Language"
                    RegDaneStr = Temp1
                    RegObj.Set RegWartosc, RegDaneStr, RegFlush
                    
                    Exit Sub
                End If
            Next i
        Loop
    Close #Kanal
    
    RegWartosc = RegSciezka & "\Options\Language"
    RegDaneStr = "English"
    RegObj.Set RegWartosc, RegDaneStr, RegFlush
End Sub
