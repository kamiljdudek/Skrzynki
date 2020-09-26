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
		RegWartosc = RegSciezka & "\Players\Number of Players"
		'UPGRADE_WARNING: Couldn't resolve default property of object RegObj.Get. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
		LiczbaGraczy = Val(RegObj.Get(RegWartosc))
	End Sub
	Public Sub Loguj(ByVal NumerGracza As Short, ByVal Haslo As String)
		DaneGracza.Numer = NumerGracza
		
		RegWartosc = RegSciezka & "\Players\" & Str(NumerGracza) & "\Name"
		'UPGRADE_WARNING: Couldn't resolve default property of object RegObj.Get. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
		DaneGracza.Imie = RegObj.Get(RegWartosc)
		
		DaneGracza.Haslo = Haslo
		
		OdczytajStatystyki()
	End Sub
	Public Sub StworzNowyProfil(ByVal ImieGracza As String, ByVal Haslo As String)
		Dim HasloREG As String
		Dim i As Short
		
		RegWartosc = RegSciezka & "\Players\" & Str(LiczbaGraczy + 1) & "\Name"
		'UPGRADE_WARNING: Couldn't resolve default property of object RegObj.Set. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
		RegObj.Set(RegWartosc, ImieGracza, RegFlush)
		
		HasloREG = Zaszyfruj(Haslo)
		RegWartosc = RegSciezka & "\Players\" & Str(LiczbaGraczy + 1) & "\Password"
		'UPGRADE_WARNING: Couldn't resolve default property of object RegObj.Set. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
		RegObj.Set(RegWartosc, HasloREG, RegFlush)
		
		RegWartosc = RegSciezka & "\Players\" & Str(LiczbaGraczy + 1) & "\Level Set"
		'UPGRADE_WARNING: Couldn't resolve default property of object RegObj.Set. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
		RegObj.Set(RegWartosc, 1, RegFlush)
		
		LiczbaGraczy = LiczbaGraczy + 1
		
		RegWartosc = RegSciezka & "\Players\Number of Players"
		'UPGRADE_WARNING: Couldn't resolve default property of object RegObj.Set. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
		RegObj.Set(RegWartosc, LiczbaGraczy, RegFlush)
	End Sub
	Public Sub ZapiszStatystyki()
		RegWartosc = RegSciezka & "\Players\" & Str(DaneGracza.Numer) & "\Level Set"
		RegDaneInt = DaneGracza.Zestaw
		'UPGRADE_WARNING: Couldn't resolve default property of object RegObj.Set. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
		RegObj.Set(RegWartosc, RegDaneInt, RegFlush)
		
		' Zestaw Klasyczne
		'-----------------
		RegWartosc = RegSciezka & "\Players\" & Str(DaneGracza.Numer) & "\Klasyczne\Arrived Level"
		RegDaneInt = DaneGracza.Klasyczne.OsiagnietyEtap
		'UPGRADE_WARNING: Couldn't resolve default property of object RegObj.Set. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
		RegObj.Set(RegWartosc, RegDaneInt, RegFlush)
		
		RegWartosc = RegSciezka & "\Players\" & Str(DaneGracza.Numer) & "\Klasyczne\Moves"
		RegDaneInt = DaneGracza.Klasyczne.Ruchy
		'UPGRADE_WARNING: Couldn't resolve default property of object RegObj.Set. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
		RegObj.Set(RegWartosc, RegDaneInt, RegFlush)
		
		RegWartosc = RegSciezka & "\Players\" & Str(DaneGracza.Numer) & "\Klasyczne\Pushes"
		RegDaneInt = DaneGracza.Klasyczne.Pchniecia
		'UPGRADE_WARNING: Couldn't resolve default property of object RegObj.Set. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
		RegObj.Set(RegWartosc, RegDaneInt, RegFlush)
		
		' Zestaw Super Trudne XS
		'-----------------------
		RegWartosc = RegSciezka & "\Players\" & Str(DaneGracza.Numer) & "\Super Trudne XS\Arrived Level"
		RegDaneInt = DaneGracza.SuperTrudneXS.OsiagnietyEtap
		'UPGRADE_WARNING: Couldn't resolve default property of object RegObj.Set. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
		RegObj.Set(RegWartosc, RegDaneInt, RegFlush)
		
		RegWartosc = RegSciezka & "\Players\" & Str(DaneGracza.Numer) & "\Super Trudne XS\Moves"
		RegDaneInt = DaneGracza.SuperTrudneXS.Ruchy
		'UPGRADE_WARNING: Couldn't resolve default property of object RegObj.Set. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
		RegObj.Set(RegWartosc, RegDaneInt, RegFlush)
		
		RegWartosc = RegSciezka & "\Players\" & Str(DaneGracza.Numer) & "\Super Trudne XS\Pushes"
		RegDaneInt = DaneGracza.SuperTrudneXS.Pchniecia
		'UPGRADE_WARNING: Couldn't resolve default property of object RegObj.Set. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
		RegObj.Set(RegWartosc, RegDaneInt, RegFlush)
	End Sub
	Public Sub OdczytajStatystyki()
		RegWartosc = RegSciezka & "\Players\" & Str(DaneGracza.Numer) & "\Level Set"
		'UPGRADE_WARNING: Couldn't resolve default property of object RegObj.Get. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
		DaneGracza.Zestaw = CByte(RegObj.Get(RegWartosc))
		ZestawEtapow = DaneGracza.Zestaw
		
		' Zestaw Klasyczne
		'-----------------
		RegWartosc = RegSciezka & "\Players\" & Str(DaneGracza.Numer) & "\Klasyczne\Arrived Level"
		'UPGRADE_WARNING: Couldn't resolve default property of object RegObj.Get. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
		DaneGracza.Klasyczne.OsiagnietyEtap = Val(RegObj.Get(RegWartosc))
		
		RegWartosc = RegSciezka & "\Players\" & Str(DaneGracza.Numer) & "\Klasyczne\Moves"
		'UPGRADE_WARNING: Couldn't resolve default property of object RegObj.Get. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
		DaneGracza.Klasyczne.Ruchy = Val(RegObj.Get(RegWartosc))
		
		RegWartosc = RegSciezka & "\Players\" & Str(DaneGracza.Numer) & "\Klasyczne\Pushes"
		'UPGRADE_WARNING: Couldn't resolve default property of object RegObj.Get. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
		DaneGracza.Klasyczne.Pchniecia = Val(RegObj.Get(RegWartosc))
		
		
		' Zestaw Super Trudne XS
		'-----------------------
		RegWartosc = RegSciezka & "\Players\" & Str(DaneGracza.Numer) & "\Super Trudne XS\Arrived Level"
		'UPGRADE_WARNING: Couldn't resolve default property of object RegObj.Get. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
		DaneGracza.SuperTrudneXS.OsiagnietyEtap = Val(RegObj.Get(RegWartosc))
		
		RegWartosc = RegSciezka & "\Players\" & Str(DaneGracza.Numer) & "\Super Trudne XS\Moves"
		'UPGRADE_WARNING: Couldn't resolve default property of object RegObj.Get. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
		DaneGracza.SuperTrudneXS.Ruchy = Val(RegObj.Get(RegWartosc))
		
		RegWartosc = RegSciezka & "\Players\" & Str(DaneGracza.Numer) & "\Super Trudne XS\Pushes"
		'UPGRADE_WARNING: Couldn't resolve default property of object RegObj.Get. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
		DaneGracza.SuperTrudneXS.Pchniecia = Val(RegObj.Get(RegWartosc))
	End Sub
	Public Function PodajNumerGracza(ByVal Imie As String) As Short
		If LiczbaGraczy = 0 Then SprawdzLiczbeGraczy()
		If LiczbaGraczy = 0 Then
			PodajNumerGracza = 0
			Exit Function
		End If
		
		For Licznik = 1 To LiczbaGraczy
			RegWartosc = RegSciezka & "\Players\" & Str(Licznik) & "\Name"
			'UPGRADE_WARNING: Couldn't resolve default property of object RegObj.Get. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
			If CStr(RegObj.Get(RegWartosc)) = Imie Then
				PodajNumerGracza = Licznik
				Exit Function
			End If
		Next Licznik
		
		PodajNumerGracza = 0
	End Function
	Public Sub UsunGracza(ByVal NumerGracza As Integer)
		'UPGRADE_WARNING: Couldn't resolve default property of object RegObj.DeleteKey. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
		RegObj.DeleteKey(RegSciezka & "\Players\" & Str(NumerGracza), RegFlush)
		
		For Licznik = NumerGracza + 1 To LiczbaGraczy
			'UPGRADE_WARNING: Couldn't resolve default property of object RegObj.CopyKey. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
			RegObj.CopyKey(RegSciezka & "\Players\" & Str(Licznik), RegSciezka & "\Players\" & Str(Licznik - 1), RegFlush)
			'UPGRADE_WARNING: Couldn't resolve default property of object RegObj.DeleteKey. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
			RegObj.DeleteKey(RegSciezka & "\Players\" & Str(Licznik), RegFlush)
		Next Licznik
		
		LiczbaGraczy = LiczbaGraczy - 1
		RegWartosc = RegSciezka & "\Players\Number of Players"
		RegDaneInt = LiczbaGraczy
		'UPGRADE_WARNING: Couldn't resolve default property of object RegObj.Set. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
		RegObj.Set(RegWartosc, RegDaneInt, RegFlush)
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