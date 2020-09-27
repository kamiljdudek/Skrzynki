Option Strict Off
Option Explicit On
Module modLogin
	Structure Results
		Dim OsiagnietyEtap As Short
		Dim Ruchy As Integer
		Dim Pchniecia As Integer
	End Structure
	
	Structure Player
		Dim Numer As Short
		Dim Imie As String
		Dim Haslo As String
		Dim Zestaw As Byte
		Dim Klasyczne As Results
		Dim SuperTrudneXS As Results
	End Structure
	
	Public LiczbaGraczy As Short
	Public DaneGracza As Player
	Public Sub SprawdzLiczbeGraczy()
        modMain.RegKey = Microsoft.Win32.Registry.CurrentUser.OpenSubKey(RegSciezka & "\\Players", True)
        modMain.RegValue = RegKey.GetValue("Number of Players", 0)
        LiczbaGraczy = modMain.RegValue
	End Sub
	Public Sub Loguj(ByVal NumerGracza As Short, ByVal Haslo As String)
		DaneGracza.Numer = NumerGracza
        modMain.RegKey = Microsoft.Win32.Registry.CurrentUser.OpenSubKey(RegSciezka & "\\Players" & Str(NumerGracza), True)
        modMain.RegString = RegKey.GetValue("Name", 0)
        DaneGracza.Imie = modMain.RegString
		DaneGracza.Haslo = Haslo
		
		OdczytajStatystyki()
	End Sub
	Public Sub StworzNowyProfil(ByVal ImieGracza As String, ByVal Haslo As String)
		Dim HasloREG As String
		Dim i As Short
		
        modMain.RegKey = Microsoft.Win32.Registry.CurrentUser.OpenSubKey(RegSciezka & "\\Players" & Str(LiczbaGraczy + 1), True)
        RegKey.SetValue("Name", ImieGracza)

		HasloREG = Zaszyfruj(Haslo)
        RegKey.SetValue("Password", HasloREG)
		
        RegKey.SetValue("Level Set", 1)
		
        LiczbaGraczy = LiczbaGraczy + 1
        RegKey.SetValue("Number of Players", LiczbaGraczy)
		
	End Sub
    Public Sub ZapiszStatystyki()
        modMain.RegKey = Microsoft.Win32.Registry.CurrentUser.OpenSubKey(RegSciezka & "\\Players" & Str(DaneGracza.Numer), True)
        RegKey.SetValue("Level Set", DaneGracza.Zestaw)

        ' Zestaw Klasyczne
        '-----------------
        modMain.RegKey = Microsoft.Win32.Registry.CurrentUser.OpenSubKey(RegSciezka & "\\Players\\" & Str(DaneGracza.Numer) & "\\Klasyczne", True)
        RegKey.SetValue("Arrived Level", DaneGracza.Klasyczne.OsiagnietyEtap)
        RegKey.SetValue("Moves", DaneGracza.Klasyczne.Ruchy)
        RegKey.SetValue("Pushes", DaneGracza.Klasyczne.Pchniecia)


        ' Zestaw Super Trudne XS
        '-----------------------
        modMain.RegKey = Microsoft.Win32.Registry.CurrentUser.OpenSubKey(RegSciezka & "\\Players\\" & Str(DaneGracza.Numer) & "\\Super Trudne XS", True)
        RegKey.SetValue("Arrived Level", DaneGracza.Klasyczne.OsiagnietyEtap)
        RegKey.SetValue("Moves", DaneGracza.Klasyczne.Ruchy)
        RegKey.SetValue("Pushes", DaneGracza.Klasyczne.Pchniecia)

    End Sub
    Public Sub OdczytajStatystyki()
        modMain.RegKey = Microsoft.Win32.Registry.CurrentUser.OpenSubKey(RegSciezka & "\\Players\\" & Str(DaneGracza.Numer), True)
        DaneGracza.Zestaw = RegKey.GetValue("Level Set", "set")
        ZestawEtapow = DaneGracza.Zestaw

        ' Zestaw Klasyczne
        '-----------------
        modMain.RegKey = Microsoft.Win32.Registry.CurrentUser.OpenSubKey(RegSciezka & "\\Players\\" & Str(DaneGracza.Numer) & "\\Klasyczne", True)
        modMain.RegValue = RegKey.GetValue("Arrived Level", 0)
        DaneGracza.Klasyczne.OsiagnietyEtap = modMain.RegValue

        modMain.RegValue = RegKey.GetValue("Moves", 0)
        DaneGracza.Klasyczne.Ruchy = modMain.RegValue

        modMain.RegValue = RegKey.GetValue("Pushes", 0)
        DaneGracza.Klasyczne.Pchniecia = modMain.RegValue


        ' Zestaw Super Trudne XS
        '-----------------------
        modMain.RegKey = Microsoft.Win32.Registry.CurrentUser.OpenSubKey(RegSciezka & "\\Players\\" & Str(DaneGracza.Numer) & "\\Super Trudne XS", True)
        modMain.RegValue = RegKey.GetValue("Arrived Level", 0)
        DaneGracza.SuperTrudneXS.OsiagnietyEtap = modMain.RegValue

        modMain.RegValue = RegKey.GetValue("Moves", 0)
        DaneGracza.SuperTrudneXS.Ruchy = modMain.RegValue

        modMain.RegValue = RegKey.GetValue("Pushes", 0)
        DaneGracza.SuperTrudneXS.Pchniecia = modMain.RegValue

    End Sub
    Public Function PodajNumerGracza(ByVal Imie As String) As Short
        If LiczbaGraczy = 0 Then SprawdzLiczbeGraczy()
        If LiczbaGraczy = 0 Then
            PodajNumerGracza = 0
            Exit Function
        End If

        For Licznik = 1 To LiczbaGraczy
            RegWartosc = RegSciezka & "\Players\" & Str(Licznik) & "\Name"
            modMain.RegKey = Microsoft.Win32.Registry.CurrentUser.OpenSubKey(RegSciezka & "\\Players\\" & Str(Licznik), True)
            modMain.RegString = RegKey.GetValue("Name", "imie")
            If modMain.RegString = Imie Then
                PodajNumerGracza = Licznik
                Exit Function
            End If
        Next Licznik

        PodajNumerGracza = 0
    End Function
    Public Sub UsunGracza(ByVal NumerGracza As Integer)
        ' Will be removed anyway
        Microsoft.Win32.Registry.CurrentUser.DeleteSubKeyTree(RegSciezka & "\Players\" & Str(NumerGracza))

        'For Licznik = NumerGracza + 1 To LiczbaGraczy
        'UPGRADE_WARNING: Couldn't resolve default property of object RegObj.CopyKey. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
        'RegObj.CopyKey(RegSciezka & "\Players\" & Str(Licznik), RegSciezka & "\Players\" & Str(Licznik - 1), RegFlush)
        'UPGRADE_WARNING: Couldn't resolve default property of object RegObj.DeleteKey. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
        'RegObj.DeleteKey(RegSciezka & "\Players\" & Str(Licznik), RegFlush)
        'Next Licznik

        'LiczbaGraczy = LiczbaGraczy - 1
        'RegWartosc = RegSciezka & "\Players\Number of Players"
        'RegDaneInt = LiczbaGraczy
        'UPGRADE_WARNING: Couldn't resolve default property of object RegObj.Set. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
        'RegObj.Set(RegWartosc, RegDaneInt, RegFlush)
    End Sub
    Public Function Odszyfruj(ByVal strHaslo As String) As String
        Dim temp As String
        For Licznik = 1 To Len(strHaslo)
            temp = temp & Chr(Asc(Mid(strHaslo, Licznik, 1)) - 4)
        Next Licznik

        Odszyfruj = temp
    End Function
    Public Function Zaszyfruj(ByVal strHaslo As String) As String
        Dim temp As String
        For Licznik = 1 To Len(strHaslo)
            temp = temp & Chr(Asc(Mid(strHaslo, Licznik, 1)) + 4)
        Next Licznik

        Zaszyfruj = temp
    End Function
End Module