Option Strict Off
Option Explicit On
Module modLogin
	Structure Results
		Dim OsiagnietyEtap As Short
		Dim Ruchy As Integer
		Dim Pchniecia As Integer
	End Structure

    Structure Player
        Dim Zestaw As String
        Dim Klasyczne As Results
        Dim SuperTrudneXS As Results
    End Structure

    Public LiczbaGraczy As Short
	Public DaneGracza As Player
	Public Sub SprawdzLiczbeGraczy()
        LiczbaGraczy = 1
	End Sub
    Public Sub Loguj(ByVal NumerGracza As Short)
        OdczytajStatystyki()
    End Sub
    Public Sub ZapiszStatystyki()
        modMain.RegKey = Microsoft.Win32.Registry.CurrentUser.OpenSubKey(RegSciezka & "\\Players\\1", True)
        RegKey.SetValue("Level Set", DaneGracza.Zestaw)

        ' Zestaw Klasyczne
        '-----------------
        modMain.RegKey = Microsoft.Win32.Registry.CurrentUser.OpenSubKey(RegSciezka & "\\Players\\1\\Klasyczne", True)
        RegKey.SetValue("Arrived Level", DaneGracza.Klasyczne.OsiagnietyEtap)
        RegKey.SetValue("Moves", DaneGracza.Klasyczne.Ruchy)
        RegKey.SetValue("Pushes", DaneGracza.Klasyczne.Pchniecia)


        ' Zestaw Super Trudne XS
        '-----------------------
        modMain.RegKey = Microsoft.Win32.Registry.CurrentUser.OpenSubKey(RegSciezka & "\\Players\\1\\Super Trudne XS", True)
        RegKey.SetValue("Arrived Level", DaneGracza.Klasyczne.OsiagnietyEtap)
        RegKey.SetValue("Moves", DaneGracza.Klasyczne.Ruchy)
        RegKey.SetValue("Pushes", DaneGracza.Klasyczne.Pchniecia)

    End Sub
    Public Sub OdczytajStatystyki()
        modMain.RegKey = Microsoft.Win32.Registry.CurrentUser.OpenSubKey(RegSciezka & "\\Players\\1", True)
        DaneGracza.Zestaw = RegKey.GetValue("Level Set", "set")
        ZestawEtapow = DaneGracza.Zestaw

        ' Zestaw Klasyczne
        '-----------------
        modMain.RegKey = Microsoft.Win32.Registry.CurrentUser.OpenSubKey(RegSciezka & "\\Players\\1\\Klasyczne", True)
        modMain.RegValue = RegKey.GetValue("Arrived Level", 0)
        DaneGracza.Klasyczne.OsiagnietyEtap = modMain.RegValue

        modMain.RegValue = RegKey.GetValue("Moves", 0)
        DaneGracza.Klasyczne.Ruchy = modMain.RegValue

        modMain.RegValue = RegKey.GetValue("Pushes", 0)
        DaneGracza.Klasyczne.Pchniecia = modMain.RegValue


        ' Zestaw Super Trudne XS
        '-----------------------
        modMain.RegKey = Microsoft.Win32.Registry.CurrentUser.OpenSubKey(RegSciezka & "\\Players\\1\\Super Trudne XS", True)
        modMain.RegValue = RegKey.GetValue("Arrived Level", 0)
        DaneGracza.SuperTrudneXS.OsiagnietyEtap = modMain.RegValue

        modMain.RegValue = RegKey.GetValue("Moves", 0)
        DaneGracza.SuperTrudneXS.Ruchy = modMain.RegValue

        modMain.RegValue = RegKey.GetValue("Pushes", 0)
        DaneGracza.SuperTrudneXS.Pchniecia = modMain.RegValue

    End Sub

End Module