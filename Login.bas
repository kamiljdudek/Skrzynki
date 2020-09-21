Attribute VB_Name = "modLogin"
Type Results
    OsiagnietyEtap As Integer
    Ruchy As Long
    Pchniecia As Long
End Type

Type Player
    Numer As Integer
    Imie As String
    Haslo As String
    Zestaw As Byte
    Klasyczne As Results
    SuperTrudneXS As Results
End Type
    
Global LiczbaGraczy As Integer
Global DaneGracza As Player
Public Sub SprawdzLiczbeGraczy()
    RegWartosc = RegSciezka & "\Players\Number of Players"
    LiczbaGraczy = Val(RegObj.Get(RegWartosc))
End Sub
Public Sub Loguj(ByVal NumerGracza As Integer, ByVal Haslo As String)
    DaneGracza.Numer = NumerGracza
    
    RegWartosc = RegSciezka & "\Players\" & str(NumerGracza) & "\Name"
    DaneGracza.Imie = RegObj.Get(RegWartosc)
    
    DaneGracza.Haslo = Haslo
    
    OdczytajStatystyki
End Sub
Public Sub StworzNowyProfil(ByVal ImieGracza As String, ByVal Haslo As String)
    Dim HasloREG As String
    Dim i As Integer
    
    RegWartosc = RegSciezka & "\Players\" & str(LiczbaGraczy + 1) & "\Name"
    RegObj.Set RegWartosc, ImieGracza, RegFlush
    
    HasloREG = Zaszyfruj(Haslo)
    RegWartosc = RegSciezka & "\Players\" & str(LiczbaGraczy + 1) & "\Password"
    RegObj.Set RegWartosc, HasloREG, RegFlush
    
    RegWartosc = RegSciezka & "\Players\" & str(LiczbaGraczy + 1) & "\Level Set"
    RegObj.Set RegWartosc, 1, RegFlush
    
    LiczbaGraczy = LiczbaGraczy + 1
    
    RegWartosc = RegSciezka & "\Players\Number of Players"
    RegObj.Set RegWartosc, LiczbaGraczy, RegFlush
End Sub
Public Sub ZapiszStatystyki()
    RegWartosc = RegSciezka & "\Players\" & str(DaneGracza.Numer) & "\Level Set"
    RegDaneInt = DaneGracza.Zestaw
    RegObj.Set RegWartosc, RegDaneInt, RegFlush
    
    ' Zestaw Klasyczne
    '-----------------
    RegWartosc = RegSciezka & "\Players\" & str(DaneGracza.Numer) & "\Klasyczne\Arrived Level"
    RegDaneInt = DaneGracza.Klasyczne.OsiagnietyEtap
    RegObj.Set RegWartosc, RegDaneInt, RegFlush
    
    RegWartosc = RegSciezka & "\Players\" & str(DaneGracza.Numer) & "\Klasyczne\Moves"
    RegDaneInt = DaneGracza.Klasyczne.Ruchy
    RegObj.Set RegWartosc, RegDaneInt, RegFlush
    
    RegWartosc = RegSciezka & "\Players\" & str(DaneGracza.Numer) & "\Klasyczne\Pushes"
    RegDaneInt = DaneGracza.Klasyczne.Pchniecia
    RegObj.Set RegWartosc, RegDaneInt, RegFlush
        
    ' Zestaw Super Trudne XS
    '-----------------------
    RegWartosc = RegSciezka & "\Players\" & str(DaneGracza.Numer) & "\Super Trudne XS\Arrived Level"
    RegDaneInt = DaneGracza.SuperTrudneXS.OsiagnietyEtap
    RegObj.Set RegWartosc, RegDaneInt, RegFlush
    
    RegWartosc = RegSciezka & "\Players\" & str(DaneGracza.Numer) & "\Super Trudne XS\Moves"
    RegDaneInt = DaneGracza.SuperTrudneXS.Ruchy
    RegObj.Set RegWartosc, RegDaneInt, RegFlush
    
    RegWartosc = RegSciezka & "\Players\" & str(DaneGracza.Numer) & "\Super Trudne XS\Pushes"
    RegDaneInt = DaneGracza.SuperTrudneXS.Pchniecia
    RegObj.Set RegWartosc, RegDaneInt, RegFlush
End Sub
Public Sub OdczytajStatystyki()
    RegWartosc = RegSciezka & "\Players\" & str(DaneGracza.Numer) & "\Level Set"
    DaneGracza.Zestaw = CByte(RegObj.Get(RegWartosc))
    ZestawEtapow = DaneGracza.Zestaw
    
    ' Zestaw Klasyczne
    '-----------------
    RegWartosc = RegSciezka & "\Players\" & str(DaneGracza.Numer) & "\Klasyczne\Arrived Level"
    DaneGracza.Klasyczne.OsiagnietyEtap = Val(RegObj.Get(RegWartosc))
    
    RegWartosc = RegSciezka & "\Players\" & str(DaneGracza.Numer) & "\Klasyczne\Moves"
    DaneGracza.Klasyczne.Ruchy = Val(RegObj.Get(RegWartosc))
    
    RegWartosc = RegSciezka & "\Players\" & str(DaneGracza.Numer) & "\Klasyczne\Pushes"
    DaneGracza.Klasyczne.Pchniecia = Val(RegObj.Get(RegWartosc))
    
    
    ' Zestaw Super Trudne XS
    '-----------------------
    RegWartosc = RegSciezka & "\Players\" & str(DaneGracza.Numer) & "\Super Trudne XS\Arrived Level"
    DaneGracza.SuperTrudneXS.OsiagnietyEtap = Val(RegObj.Get(RegWartosc))
    
    RegWartosc = RegSciezka & "\Players\" & str(DaneGracza.Numer) & "\Super Trudne XS\Moves"
    DaneGracza.SuperTrudneXS.Ruchy = Val(RegObj.Get(RegWartosc))
    
    RegWartosc = RegSciezka & "\Players\" & str(DaneGracza.Numer) & "\Super Trudne XS\Pushes"
    DaneGracza.SuperTrudneXS.Pchniecia = Val(RegObj.Get(RegWartosc))
End Sub
Public Function PodajNumerGracza(ByVal Imie As String) As Integer
    If LiczbaGraczy = 0 Then SprawdzLiczbeGraczy
    If LiczbaGraczy = 0 Then
        PodajNumerGracza = 0
        Exit Function
    End If
    
    For Licznik = 1 To LiczbaGraczy
        RegWartosc = RegSciezka & "\Players\" & str(Licznik) & "\Name"
        If CStr(RegObj.Get(RegWartosc)) = Imie Then
            PodajNumerGracza = Licznik
            Exit Function
        End If
    Next Licznik
    
    PodajNumerGracza = 0
End Function
Public Sub UsunGracza(ByVal NumerGracza As Long)
    RegObj.DeleteKey RegSciezka & "\Players\" & str(NumerGracza), RegFlush
        
    For Licznik = NumerGracza + 1 To LiczbaGraczy
        RegObj.CopyKey RegSciezka & "\Players\" & str(Licznik), _
        RegSciezka & "\Players\" & str(Licznik - 1), RegFlush
        RegObj.DeleteKey RegSciezka & "\Players\" & str(Licznik), RegFlush
    Next Licznik
    
    LiczbaGraczy = LiczbaGraczy - 1
    RegWartosc = RegSciezka & "\Players\Number of Players"
    RegDaneInt = LiczbaGraczy
    RegObj.Set RegWartosc, RegDaneInt, RegFlush
End Sub
Public Function Odszyfruj(ByVal strHaslo As String) As String
    Dim temp As String
    For Licznik = 1 To Len(strHaslo)
           temp = temp & Chr(Asc(Mid$(strHaslo, Licznik, 1)) - 4)
    Next Licznik
    
    Odszyfruj = temp
End Function
Public Function Zaszyfruj(ByVal strHaslo As String) As String
    Dim temp As String
    For Licznik = 1 To Len(strHaslo)
        temp = temp & Chr(Asc(Mid$(strHaslo, Licznik, 1)) + 4)
    Next Licznik
    
    Zaszyfruj = temp
End Function
