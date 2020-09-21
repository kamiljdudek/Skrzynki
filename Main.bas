Attribute VB_Name = "modMain"
' -------------------------------------------------------------------------------------------
' |                                      SKRZYNKI 3.6                                       |
' |                                 autor: Karol Kuczmarski                                 |
' -------------------------------------------------------------------------------------------
'
' Rodzaj: gra logiczna
' Typ: sokoban
'
' Nale¿y u³o¿yæ skrzynki na wyznaczony miejscach. Mo¿na poruszaæ tylko jedn¹ skrzynk¹ naraz,
' w kierunku "od siebie".
'
' Znaczenie procedur (P) i funkcji (F):
' Cofnij (P) - pozwala wróciæ do stanu sprzed ruchu (zapisanego w tablicy PoleGrySprzedRuchu
'              i zmiennej PozycjaGraczaSprzedRuchu
' Main (P) - procedura startowa, dba m. in. ¿eby nie by³o uruchomionych dwóch kopii gry
' NastepnyEtap (P) - jest wykonywana, kiedy gracz przejdzie etap
' NieMozna (P) - u¿ywana do generowania sygna³u ze speakera (poprzez funkcjê API MessageBeep)
' NowaGra (P) - startuje grê od wybranego etapu (okreœlonego w parametrze KtoryEtap)
' OdswiezPoleGry (P) - wyœwietla pole gry
' OdswiezPoleGryWokolGracza (P) - wykonywana po ka¿dym ruchu; wyœwietla pole gry wokó³ gracza
' PrzesunGracza (F) - u¿ywana, kiedy gracz wciœnie klawisz kursora; zwraca True, jeœli
'                     przesuniêcie jest mo¿liwe (jednoczeœnie je wykonuje); kierunek jest
'                     jest okreœlony parametrem Kierunek
' PrzesunSkrzynke (F) - czy mo¿na przesun¹æ skrzynkê na drodze gracza? (parametry: Kierunek
'                       okreœla kierunek przesuniêcia, PozycjaSkrzynki - któr¹ skrzynkê
'                       nale¿y przesun¹æ, zaœ ZMiejsca - czy skrzynka ta jest lub nie jest
'                       na miejscu
' RestartujEtap (P) - restartuje bie¿¹cy etap
' WczytajEtap (F) - wczytuje etap z pliku wskazanego w parametrze PlikEtapu; jednoczeœnie
'                   sprawdza jego poprawnoœæ (czy zawiera skrzynki, postaæ gracza itd.);
'                   parametr KanalPliku okreœla numer kana³u plikowego przypisanego do pliku
'                   etapu (zwykle jest to FreeFile())
' WczytajZestawEtapow (F) - wczytuje zestaw etapów
' ZakonczGre (P) - koñczy dzia³anie programu
'--------------------------------------------------------------------------------------------
' Dzia³anie gry opiera siê na tablicy 256 Image'ów oraz jej odpowiedniku w postaci jednowy-
' miarowego arrayu Byte'ów o nazwie PoleGry. Pozycja gracza jest zapisywana w zmiennej o tej
' nazwie. Do czego s³u¿¹ pozosta³e zmienne i sta³e - a jest ich du¿o - przy ich deklaracjach.
'--------------------------------------------------------------------------------------------
' Niniejszy program jest wolnym oprogramowaniem; mo¿esz go 
' rozprowadzaæ dalej i/lub modyfikowaæ na warunkach Powszechnej
' Licencji Publicznej GNU, wydanej przez Fundacjê Wolnego
' Oprogramowania - wed³ug wersji 2-giej tej Licencji lub którejœ
' z póŸniejszych wersji.
'
' Niniejszy program rozpowszechniany jest z nadziej¹, i¿ bêdzie on
' u¿yteczny - jednak BEZ JAKIEJKOLWIEK GWARANCJI, nawet domyœlnej
' gwarancji PRZYDATNOŒCI HANDLOWEJ albo PRZYDATNOŒCI DO OKREŒLONYCH
' ZASTOSOWAÑ. W celu uzyskania bli¿szych informacji - Powszechna
' Licencja Publiczna GNU.
'
' Z pewnoœci¹ wraz z niniejszym programem otrzyma³eœ te¿ egzemplarz
' Powszechnej Licencji Publicznej GNU (GNU General Public License);
' jeœli nie - napisz do Free Software Foundation, Inc., 675 Mass Ave,
' Cambridge, MA 02139, USA.
'--------------------------------------------------------------------------------------------


' dyrektywy
'----------
'
Option Explicit ' wymóg deklaracji zmiennych
Option Base 1 ' indeks bazowy tablic na 1


' struktury
'----------
'
Type Level ' dane etapu
    LiczbaSkrzynek As Long
    LiczbaMiejsc As Long
    SkrzynkiNaMiejscach As Long
    PostacGracza As Boolean
End Type


' deklaracje sta³ych, zmiennych i funkcji API
'--------------------------------------------
'
' sta³e
Global Const Lewo = vbKeyLeft                   ' kierunki
Global Const Prawo = vbKeyRight
Global Const Gora = vbKeyUp
Global Const Dol = vbKeyDown
'
Global Const Pusto = 0                          ' sta³e pola gry
Global Const Murek = 1
Global Const Skrzynka = 2
Global Const Miejsce = 3
Global Const SkrzynkaNaMiejscu = 4
Global Const Gracz = 5
Global Const GraczNaMiejscu = 6
Global Const PustoPozaEtapem = 7
'
Global Const LiczbaEtapow = 60
'
Global Const DyskNieGotowy = 71                 ' b³êdy aplikacji
Global Const DyskPelny = 61
Global Const UrzadzenieNiedostepne = 68
Global Const ZlaNazwaPliku = 52
Global Const ZaDuzoPlikow = 67
Global Const NieZnalezionoKatalogu = 76
Global Const NieZnalezionoPliku = 53
'
Global Const RegSciezka As String = "HKEY_LOCAL_MACHINE\Software\Karol Kuczmarski\Skrzynki"
'
Global Const SWP_NOSIZE = &H1                   ' sta³e API
Global Const SWP_NOMOVE = &H2
Global Const SWP_SHOWWINDOW = &H40
Global Const HWND_NOTOPMOST = -2
Global Const HWND_TOPMOST = -1


' zmienne
Global PoleGry(256) As Byte ' przechowuje aktualne ustawienie obiektów w polu gry
Global PoleGrySprzedRuchu(256) As Byte ' dziêki niemu mo¿liwe jest cofanie ruchów i nie tylko
Global Etapy() As Byte ' wszystkie etapy z danego zestawu
Global DaneEtapow() As Level ' dane wszystkich etapów z zestawu
Global Etap As Level ' przechowuje liczbê skrzynek i miejsc
Global EtapSprzedRuchu As Level ' tak jak PoleGrySprzedRuchu
Global OstatnioEtap As Level ' jeœli wczytywanie etapu siê nie powiedzie,
                             ' ta zmienna zachowuje dane poprzedniego poziomu
Global PozycjaGracza As Integer ' aktualna pozycja gracza
Global PozycjaGraczaSprzedRuchu As Integer ' dziêki temu mo¿liwe jest cofanie ruchów
Global PozycjeGracza() As Integer ' pocz¹tkowe pozycje gracza we wszystkich etapach
Global WykonanoRuch As Boolean ' czy gracz wykona³ ruch (i czy ew. mo¿na cofn¹æ)
                                   ' okreœla, czy aktualny etap jest etapem wczytanym z pliku
Global EtapSpozaZestawu As Boolean ' wybranego przez u¿ytkownika (jeœli tak jest, po jego
                                   ' przejœciu nie powinien byæ wyœwietlony nastêpny)
Global EtapZaliczony As Boolean ' czy etap spoza zestawu zaliczony?
Global NumerEtapu As Long ' numer aktualnie rozgrywanego etapu
Global ZestawEtapow As Byte ' aktualnie rozgrywany zestaw etapów
Global Ruchy As Long ' ruchy wykonane w etapie
Global Pchniecia As Long ' ruchy skrzynek wykonane w etapie
Global NazwaPliku As String ' nazwa pliku etapu
Global Licznik As Long ' do pêtli For...Next
Global Temp1, Temp2 As String ' zmienne do danych tymczasowych lub niepotrzebnych
Global Temp3 As Variant ' j. w.
Global Temp4 As String * 255 ' j. w.
Global Temp5 As Long ' j. w.
Global Msg, Style As Variant ' u¿ywane w komunikatach
Global KatalogWindows As String
Global DlugoscKataloguWindows As Long
Global KatalogTemp As String
Global DlugoscKataloguTemp As Long
'
Global RegObj As RegistryTypeLibrary.CRegObj ' obiekt Rejestr
Global RegWartosc As String, RegWartosc2 As String
Global RegDaneStr As String
Global RegDaneInt As Long
Global RegFlush As Boolean
'
Global TIcon As New CTrayIcon ' ikonka w trayu
Global CDialog As New CCommonDlg ' Common Dialog
'
Global iniMidi As Integer
Global NewPlayerFormAction As String


' funkcje API
Public Declare Function MessageBeep Lib "USER32" (ByVal wType As Long) As Long ' do beepowania
Public Declare Sub Sleep Lib "kernel32" (ByVal dwMilliseconds As Long)
Public Declare Function ShellExecute Lib "shell32.dll" Alias "ShellExecuteA" (ByVal hwnd As Long, ByVal lpOperation As String, ByVal lpFile As String, ByVal lpParameters As String, ByVal lpDirectory As String, ByVal nShowCmd As Long) As Long ' do uruchamiania programów, np. HH.EXE w celu wyœwietlenia Pomocy
Public Declare Function DeleteFile Lib "kernel32" Alias "DeleteFileA" (ByVal lpFileName As String) As Long
Public Declare Function SetWindowPos Lib "USER32" (ByVal hwnd As Long, ByVal hWndInsertAfter As Long, ByVal x As Long, ByVal y As Long, ByVal cx As Long, ByVal cy As Long, ByVal wFlags As Long) As Long
Public Declare Function GetTempPath Lib "kernel32" Alias "GetTempPathA" (ByVal nBufferLength As Long, ByVal lpBuffer As String) As Long
Public Declare Function GetWindowsDirectory Lib "kernel32" Alias "GetWindowsDirectoryA" (ByVal lpBuffer As String, ByVal nSize As Long) As Long

Sub Main()
    Dim TipsShown As Boolean
    Dim SplashShown As Boolean
    Dim Response As Integer
    
    Set RegObj = New RegistryTypeLibrary.CRegObj
    RegFlush = True
    
    RegWartosc = RegSciezka & "\Other\Started"
    If Val(RegObj.Get(RegWartosc)) = 0 Then
        RegDaneInt = 1
        RegObj.Set RegWartosc, RegDaneInt, RegFlush
        
        RegDaneStr = App.Path
        RegWartosc = RegSciezka & "\Other\Path"
        RegObj.Set RegWartosc, RegDaneStr, RegFlush
        
        SkojarzPlikiBOXZProgramem
        RozpoznajJezyk
        
        RegWartosc = RegSciezka & "\Options\Show Splash at Startup"
        RegObj.Set RegWartosc, RegDaneInt, RegFlush
        
        RegWartosc = RegSciezka & "\Options\Show Tips at Startup"
        RegObj.Set RegWartosc, RegDaneInt, RegFlush
        
        RegWartosc = RegSciezka & "\Options\Want Closing Authorization"
        RegObj.Set RegWartosc, RegDaneInt, RegFlush
        
        RegWartosc = RegSciezka & "\Options\Want Level Restarting Authorization"
        RegObj.Set RegWartosc, RegDaneInt, RegFlush
        
        RegWartosc = RegSciezka & "\Options\Show Level Load Confirmation"
        RegObj.Set RegWartosc, RegDaneInt, RegFlush
        
        RegWartosc = RegSciezka & "\Options\Show Status Bar"
        RegObj.Set RegWartosc, RegDaneInt, RegFlush
        
        RegWartosc = RegSciezka & "\Options\Background Color"
        RegDaneInt = &H0&
        RegObj.Set RegWartosc, RegDaneInt, RegFlush
        
        RegWartosc = RegSciezka & "\Options\Skin"
        RegDaneStr = "(Oryginalny)"
        RegObj.Set RegWartosc, RegDaneStr, RegFlush
        
        RegWartosc = RegSciezka & "\Options\Play Music"
        RegDaneInt = 1
        RegObj.Set RegWartosc, RegDaneInt, RegFlush
        
        RegWartosc = RegSciezka & "\Options\First Player Auto Logon"
        RegDaneInt = 1
        RegObj.Set RegWartosc, RegDaneInt, RegFlush
        
        Response = MsgBox(ZwrocCiag("General#11"), vbOKCancel + vbQuestion + vbApplicationModal, App.Title)
        If Response = vbOK Then PokazForme frmFindMIDI, vbModal Else End
    End If
        
    DlugoscKataloguWindows = GetWindowsDirectory(Temp4, 255)
    KatalogWindows = Left$(Temp4, DlugoscKataloguWindows)
    
    DlugoscKataloguTemp = GetTempPath(255, Temp4)
    KatalogTemp = Left$(Temp4, DlugoscKataloguTemp)
    
    Temp3 = AnalizujWierszPolecen
    Select Case Temp3
    Case "Logged"
    Case Else
        SprawdzLiczbeGraczy
        
        RegWartosc = RegSciezka & "\Options\First Player Auto Logon"
        RegWartosc2 = RegSciezka & "\Players\ 1\Password"
        If Val(RegObj.Get(RegWartosc)) = 1 And _
        LiczbaGraczy = 1 And _
        RegObj.Get(RegWartosc2) = Empty Then
            Loguj 1, ""
        Else
            PokazForme frmLogin, vbModal
        End If
    End Select
    
    RegWartosc = RegSciezka & "\Other\Version"
    RegDaneStr = App.Major & "." & App.Minor & "." & App.Revision
    RegObj.Set RegWartosc, RegDaneStr, RegFlush
    
    With TIcon
        .hWndOwner = frmMain.picTrayObject.hwnd
        .Icon = frmMain.Icon
        .Tip = "Skrzynki"
    End With
    
    RegWartosc = RegSciezka & "\Options\Show in Tray"
    If Val(RegObj.Get(RegWartosc)) = 2 Then
        TIcon.Show
    End If
    
    RegWartosc = RegSciezka & "\Options\Show Splash at Startup"
    If Val(RegObj.Get(RegWartosc)) = 1 Then
        PokazForme frmSplash
        frmSplash.SetFocus
        SplashShown = True
    Else: SplashShown = False
    End If
    
    If App.PrevInstance = True Then
        Temp3 = MsgBox(ZwrocCiag("General#16"), vbOKOnly + vbCritical + vbSystemModal, App.Title)
        End
    End If
    
    RegWartosc = RegSciezka & "\Options\Show Tips at Startup"
    If Val(RegObj.Get(RegWartosc)) = 1 Then
        PokazForme frmTip
        frmTip.SetFocus
        TipsShown = True
    Else: TipsShown = False
    End If
    
    If SplashShown Then frmSplash.SetFocus
    
    ZestawEtapow = DaneGracza.Zestaw
    NumerEtapu = 1
    WykonanoRuch = False
    EtapZaliczony = False
    
    PokazForme frmMain
    PokazNaPaskuStanu 5, DaneGracza.Imie
        
    If TipsShown Then frmTip.SetFocus
    If SplashShown Then frmSplash.SetFocus
End Sub
Public Function AnalizujWierszPolecen() As String
    On Error GoTo Blad
    
    Dim Parametry As Variant
    Dim Temp
    
    If Command = "" Or InStr(1, Command, " ") = 0 Then
        AnalizujWierszPolecen = "No command"
        Exit Function
    End If
    
    Parametry = Split(Command, " ")
    Select Case Left(Command, 2)
    Case "/l"
        Temp = PodajNumerGracza(Parametry(1))
        If Temp = 0 Then
            MsgBox ZwrocCiag("General#3"), vbOKOnly + vbCritical + vbApplicationModal, App.Title
            End
        End If
        
        Loguj Val(Temp), Parametry(2)
        AnalizujWierszPolecen = "Logged"
        Exit Function
    Case "/k"
        If KonwertujEtap(Parametry(1), Parametry(2)) = False Then
            MsgBox ZwrocCiag("General#4"), vbOKOnly + vbCritical + vbApplicationModal, App.Title
            End
        Else
            MsgBox ZwrocCiag("General#5"), vbOKOnly + vbInformation + vbApplicationModal, App.Title
            AnalizujWierszPolecen = "Converted"
            Exit Function
        End If
    Case Else
        NazwaPliku = Mid(Command, 2, Len(Command) - 2)
        
        If WczytajEtap(NazwaPliku, FreeFile()) Then
            EtapSpozaZestawu = True
            OdswiezPoleGry
            frmMain.Caption = "Skrzynki - " & Left(Dir(NazwaPliku), Len(Dir(NazwaPliku)) - 4)
            PokazNaPaskuStanu 3, ZwrocCiag("StatusBar#2") & Etap.SkrzynkiNaMiejscach & "/" & Etap.LiczbaSkrzynek
            PokazNaPaskuStanu 4, Left(Dir(NazwaPliku), Len(Dir(NazwaPliku)) - 4)
            
            RegWartosc = RegSciezka & "\Options\Show Level Load Confirmation"
            If Val(RegObj.Get(RegWartosc)) = 1 Then
                Temp3 = MsgBox(Replace(ZwrocCiag("General#6"), "<filename>", NazwaPliku), vbOKOnly + vbInformation + vbApplicationModal, App.Title)
            End If
        End If
    End Select
    
    Exit Function
    
Blad:
End Function
Public Function WczytajEtap(PlikEtapu As String, KanalPliku As Integer) As Boolean
    On Error GoTo BladWczytywaniaEtapu
    
    Const ZaDuzoGraczy = 1
    Const SkrzynkiIMiejsca = 2
    Const BrakSkrzynek = 3
    Const BrakMiejsc = 4
    Const BrakGracza = 5
    
    Dim NumerBleduEtapu As Byte
    Dim Znak As Integer
        
    If PlikEtapu = "" Then Exit Function
    
    With Etap
        OstatnioEtap.LiczbaMiejsc = .LiczbaMiejsc
        .LiczbaMiejsc = 0
        
        OstatnioEtap.LiczbaSkrzynek = .LiczbaSkrzynek
        .LiczbaSkrzynek = 0
        
        OstatnioEtap.PostacGracza = .PostacGracza
        .PostacGracza = False
        
        OstatnioEtap.SkrzynkiNaMiejscach = .SkrzynkiNaMiejscach
        .SkrzynkiNaMiejscach = 0
    End With
    
    For Licznik = 1 To 256 Step 1
        PoleGrySprzedRuchu(Licznik) = PoleGry(Licznik) ' zapisanie aktualnego pola gry
        PoleGry(Licznik) = PustoPozaEtapem
    Next Licznik
    
    Open PlikEtapu For Input Access Read Lock Write As KanalPliku
        If LOF(KanalPliku) < 250 Then
            Close #KanalPliku
            Temp1 = MsgBox("Plik " & PlikEtapu & " ma rozmiar " & LOF(KanalPliku) & "bajtów - jest za ma³y, aby móc przechowywaæ kompletn¹ informacjê o strukturze etapu.", vbOKOnly + vbCritical + vbApplicationModal, App.Title)
            WczytajEtap = False
            Exit Function
        End If
        
        Znak = 1
        For Licznik = 1 To 256 Step 1 'odczytanie etapu - znak po znaku
            If (((Licznik - 1) Mod 16) = 0 Or Licznik = 1) And (Licznik <= 241) Then
                Line Input #KanalPliku, Temp1 'wczytanie linii znaków
            End If
            
            If (Licznik Mod 16) > 0 Then
                Temp2 = Mid(Temp1, Znak, 1) 'pobranie znaku z linii
                Znak = Znak + 1
            Else
                Temp2 = Mid(Temp1, 16, 1)   ' pobranie ostatniego znaku
                Znak = 1
            End If
                
                Select Case Temp2 'sprawdzenie, czym jest odczytany znak
                Case "'"
                    PoleGry(Licznik) = PustoPozaEtapem
                Case Gracz Or GraczNaMiejscu
                    PozycjaGracza = Licznik
                    PoleGry(Licznik) = Val(Temp2)
                Case Else
                    PoleGry(Licznik) = Val(Temp2)
                End Select
                
                With Etap 'zaktualizowanie danych o etapie
                    Select Case Temp2
                    Case Skrzynka
                        .LiczbaSkrzynek = .LiczbaSkrzynek + 1
                    Case Miejsce
                        .LiczbaMiejsc = .LiczbaMiejsc + 1
                    Case Gracz
                        If .PostacGracza Then
                            NumerBleduEtapu = ZaDuzoGraczy
                            GoTo BladPlikuEtapu
                        End If
                        
                        .PostacGracza = True
                    Case SkrzynkaNaMiejscu
                        .LiczbaMiejsc = .LiczbaMiejsc + 1
                        .LiczbaSkrzynek = .LiczbaSkrzynek + 1
                        .SkrzynkiNaMiejscach = .SkrzynkiNaMiejscach + 1
                    Case GraczNaMiejscu
                        If .PostacGracza Then
                            NumerBleduEtapu = ZaDuzoGraczy
                            GoTo BladPlikuEtapu
                        End If
                        
                        .PostacGracza = True
                    End Select
                End With
        Next Licznik
        
        For Licznik = 1 To 256 Step 1
            If PoleGry(Licznik) = Gracz Or PoleGry(Licznik) = GraczNaMiejscu Then PozycjaGracza = Licznik
        Next Licznik
        
' poni¿szy kod powoduje dziwne b³êdy, wiêc go wy³¹czy³em (mia³ on sprawdzaæ poprawnoœæ etapu)
'        With Etap
 '           If .LiczbaMiejsc <> .LiczbaSkrzynek Then
  '               NumerBleduEtapu = SkrzynkiIMiejsca
   '             GoTo BladPlikuEtapu
    '        End If
     '
      '      If .LiczbaMiejsc = 0 Then
       '         NumerBleduEtapu = BrakMiejsc
        '        GoTo BladPlikuEtapu
         '   End If
          '
           ' If .LiczbaSkrzynek = 0 Then
            '    NumerBleduEtapu = BrakSkrzynek
'                GoTo BladPlikuEtapu
 '           End If
  '
   '         If .PostacGracza = False Then
    '            NumerBleduEtapu = BrakGracza
     '           GoTo BladPlikuEtapu
      '      End If
       ' End With
    Close #KanalPliku
    
    WczytajEtap = True
    Exit Function
    
BladPlikuEtapu: 'coœ jest Ÿle w etapie (np. liczba graczy ró¿na od 1)
    Close
    For Licznik = 1 To 256 Step 1
        PoleGry(Licznik) = PoleGrySprzedRuchu(Licznik) 'przywrócenie kopii zapasowej
    Next Licznik
    
    With Etap
        .LiczbaMiejsc = OstatnioEtap.LiczbaMiejsc
        .LiczbaSkrzynek = OstatnioEtap.LiczbaSkrzynek
        .PostacGracza = OstatnioEtap.PostacGracza
        .SkrzynkiNaMiejscach = OstatnioEtap.SkrzynkiNaMiejscach
    End With
    
    WczytajEtap = False
    
    Select Case NumerBleduEtapu
    Case ZaDuzoGraczy Or BrakGracza
        Msg = "W etapie musi byæ dok³adnie jedna postaæ gracza."
    Case SkrzynkiIMiejsca
        Msg = "Liczba skrzynek musi byæ równa liczbie miejsc. Aktualnie jest:" & Chr(10) & "skrzynek: " & Etap.LiczbaSkrzynek & Chr(10) & "miejsc: " & Etap.LiczbaMiejsc & "."
    Case BrakSkrzynek
        Msg = "W etapie musi byæ przynajmniej jedna skrzynka."
    Case BrakMiejsc
        Msg = "W etapie musi byæ przynajmniej jedno miejsce na skrzynkê."
    End Select
    
    Temp3 = MsgBox(Msg, vbOKOnly + vbCritical + vbApplicationModal, App.Title)
    Exit Function
    
BladWczytywaniaEtapu: 'coœ jest z plikiem
    Close
    For Licznik = 1 To 256 Step 1
        PoleGry(Licznik) = PoleGrySprzedRuchu(Licznik) 'przywrócenie kopii
    Next Licznik
    
    With Etap
        .LiczbaMiejsc = OstatnioEtap.LiczbaMiejsc
        .LiczbaSkrzynek = OstatnioEtap.LiczbaSkrzynek
        .PostacGracza = OstatnioEtap.PostacGracza
        .SkrzynkiNaMiejscach = OstatnioEtap.SkrzynkiNaMiejscach
    End With
    
    WczytajEtap = False
    
    Select Case Err.Number
    Case DyskNieGotowy
        Msg = "Dysk nie jest gotowy."
        Style = vbRetryCancel + vbCritical + vbSystemModal
    Case NieZnalezionoPliku
        Msg = "Plik " & PlikEtapu & " nie istnieje."
        Style = vbOKOnly + vbCritical + vbSystemModal
    Case Else
        Msg = "B³¹d nr " & Err.Number & ":" & Chr(10) & Err.Description
        Style = vbOKOnly + vbCritical + vbSystemModal
    End Select
    
    Temp3 = MsgBox(Msg, Style, App.Title)
    
    If Temp3 = vbOK Or Temp3 = vbCancel Then Exit Function Else Resume
End Function
Public Function WczytajZestawEtapow(PlikZestawu As String, KanalPliku As Integer) As Boolean
    Dim LiczbaEtapowWZestawie As Integer
    Dim i As Integer
    Dim j As Integer
    Dim Kanal As Integer
    
    Open PlikZestawu For Input As #KanalPliku
        Input #KanalPliku, Temp1
        LiczbaEtapowWZestawie = Val(Temp1)
        
        ReDim Etapy(LiczbaEtapowWZestawie, 256) As Byte
        ReDim DaneEtapow(LiczbaEtapowWZestawie) As Level
        ReDim PozycjeGracza(LiczbaEtapowWZestawie) As Integer
        
        For i = 1 To LiczbaEtapowWZestawie Step 1
            Input #KanalPliku, Temp1
            
            Kanal = FreeFile()
            Open KatalogTemp & "\#" & str(i) & ".box" For Output As #Kanal
                For j = 1 To 16 Step 1
                    Line Input #KanalPliku, Temp1
                    Print #Kanal, Temp1
                Next j
            Close #Kanal
        Next i
    Close #KanalPliku
    
    For i = 1 To LiczbaEtapowWZestawie Step 1
        If WczytajEtap(KatalogTemp & "\#" & str(i) & ".box", FreeFile) Then
            For j = 1 To 256 Step 1
                Etapy(i, j) = PoleGry(j)
            Next j
            
            DaneEtapow(i) = Etap
            PozycjeGracza(i) = PozycjaGracza
            
            DeleteFile KatalogTemp & "\#" & str(i) & ".box"
        Else: GoTo Blad
        End If
    Next i
    
    For i = 1 To 256 Step 1
        PoleGry(i) = Etapy(1, i)
    Next i
    Etap = DaneEtapow(1)
    
    WczytajZestawEtapow = True
    Exit Function

Blad:
    MsgBox ZwrocCiag("General#8"), vbOKOnly + vbCritical + vbApplicationModal, App.Title
    WczytajZestawEtapow = False
End Function
Public Sub OdswiezPoleGry()
    Dim Skin As String
    
    RegWartosc = RegSciezka & "\Options\Skin"
    Skin = RegObj.Get(RegWartosc)
    
    For Licznik = 1 To 256 Step 1
        If PoleGry(Licznik) < 7 Then
            frmMain.imgGameField(Licznik).Picture = LoadPicture(App.Path & "\Skiny\" & Skin & "\" & PoleGry(Licznik) & ".ico")
        Else
            frmMain.imgGameField(Licznik).Picture = LoadPicture()
        End If
    Next Licznik
End Sub
Public Sub NastepnyEtap()
    Temp3 = MsgBox(ZwrocCiag("General#0"), vbOKOnly + vbInformation + vbApplicationModal, App.Title)
    EtapZaliczony = True
    If EtapSpozaZestawu Then Exit Sub
              
    NumerEtapu = NumerEtapu + 1
    
    If NumerEtapu > NajdalszyEtap Then
        Select Case ZestawEtapow
        Case 1
            DaneGracza.Klasyczne.OsiagnietyEtap = NumerEtapu
            DaneGracza.Klasyczne.Pchniecia = DaneGracza.Klasyczne.Pchniecia + Pchniecia
            DaneGracza.Klasyczne.Ruchy = DaneGracza.Klasyczne.Ruchy + Ruchy
        Case 2
            DaneGracza.SuperTrudneXS.OsiagnietyEtap = NumerEtapu
            DaneGracza.SuperTrudneXS.Pchniecia = DaneGracza.SuperTrudneXS.Pchniecia + Pchniecia
            DaneGracza.SuperTrudneXS.Ruchy = DaneGracza.SuperTrudneXS.Ruchy + Ruchy
        End Select
    End If
    Ruchy = 0
    Pchniecia = 0
    WykonanoRuch = False
    frmMain.mnuToolsUndo.Enabled = False
    
    If NumerEtapu > UBound(Etapy, 1) Then
        Temp3 = MsgBox(ZwrocCiag("General#7"), vbOKOnly + vbInformation + vbApplicationModal, App.Title)
        NowaGra (1)
        Exit Sub
    End If
        
    For Licznik = 1 To 256 Step 1
        PoleGry(Licznik) = Etapy(NumerEtapu, Licznik)
    Next Licznik
    Etap = DaneEtapow(NumerEtapu)
    PozycjaGracza = PozycjeGracza(NumerEtapu)
    
    PokazNaPaskuStanu 1, ZwrocCiag("StatusBar#0") & Ruchy
    PokazNaPaskuStanu 2, ZwrocCiag("StatusBar#1") & Pchniecia
    PokazNaPaskuStanu 3, ZwrocCiag("StatusBar#2") & Etap.SkrzynkiNaMiejscach & "/" & Etap.LiczbaSkrzynek
    PokazNaPaskuStanu 4, "#" & NumerEtapu
    frmMain.Caption = "Skrzynki - #" & NumerEtapu
    EtapZaliczony = False
    OdswiezPoleGry
End Sub
Public Function PrzesunGracza(ByVal Kierunek As Byte) As Boolean
    If EtapZaliczony Then
        PrzesunGracza = False
        Exit Function
    End If
    
    For Licznik = 1 To 256 Step 1
        PoleGrySprzedRuchu(Licznik) = PoleGry(Licznik)
    Next Licznik
    PozycjaGraczaSprzedRuchu = PozycjaGracza
    EtapSprzedRuchu.SkrzynkiNaMiejscach = Etap.SkrzynkiNaMiejscach
    
    Select Case Kierunek
    Case Lewo
        Select Case PoleGry(PozycjaGracza - 1)
        Case Pusto
            If PoleGry(PozycjaGracza) = GraczNaMiejscu Then
                PoleGry(PozycjaGracza) = Miejsce
            Else
                PoleGry(PozycjaGracza) = Pusto
            End If
            
            PoleGry(PozycjaGracza - 1) = Gracz
            PozycjaGracza = PozycjaGracza - 1
        Case Murek
            PrzesunGracza = False
            Exit Function
        Case Skrzynka
            If PrzesunSkrzynke(Lewo, PozycjaGracza - 1, False) = False Then
                PrzesunGracza = False
                Exit Function
            End If
            
            If PoleGry(PozycjaGracza) = GraczNaMiejscu Then
                PoleGry(PozycjaGracza) = Miejsce
            Else
                PoleGry(PozycjaGracza) = Pusto
            End If
            
            PoleGry(PozycjaGracza - 1) = Gracz
            PozycjaGracza = PozycjaGracza - 1
            
            Pchniecia = Pchniecia + 1
        Case Miejsce
            If PoleGry(PozycjaGracza) = GraczNaMiejscu Then
                PoleGry(PozycjaGracza) = Miejsce
            Else
                PoleGry(PozycjaGracza) = Pusto
            End If
            
            PoleGry(PozycjaGracza - 1) = GraczNaMiejscu
            PozycjaGracza = PozycjaGracza - 1
        Case SkrzynkaNaMiejscu
            If PrzesunSkrzynke(Lewo, PozycjaGracza - 1, True) = False Then
                PrzesunGracza = False
                Exit Function
            End If
            
            If PoleGry(PozycjaGracza) = GraczNaMiejscu Then
                PoleGry(PozycjaGracza) = Miejsce
            Else
                PoleGry(PozycjaGracza) = Pusto
            End If
            
            PoleGry(PozycjaGracza - 1) = GraczNaMiejscu
            PozycjaGracza = PozycjaGracza - 1
            
            Pchniecia = Pchniecia + 1
        End Select
    Case Prawo
        Select Case PoleGry(PozycjaGracza + 1)
        Case Pusto
            If PoleGry(PozycjaGracza) = GraczNaMiejscu Then
                PoleGry(PozycjaGracza) = Miejsce
            Else
                PoleGry(PozycjaGracza) = Pusto
            End If
            
            PoleGry(PozycjaGracza + 1) = Gracz
            PozycjaGracza = PozycjaGracza + 1
        Case Murek
            PrzesunGracza = False
            Exit Function
        Case Skrzynka
            If PrzesunSkrzynke(Prawo, PozycjaGracza + 1, False) = False Then
                PrzesunGracza = False
                Exit Function
            End If
            
            If PoleGry(PozycjaGracza) = GraczNaMiejscu Then
                PoleGry(PozycjaGracza) = Miejsce
            Else
                PoleGry(PozycjaGracza) = Pusto
            End If
            
            PoleGry(PozycjaGracza + 1) = Gracz
            PozycjaGracza = PozycjaGracza + 1
            
            Pchniecia = Pchniecia + 1
        Case Miejsce
            If PoleGry(PozycjaGracza) = GraczNaMiejscu Then
                PoleGry(PozycjaGracza) = Miejsce
            Else
                PoleGry(PozycjaGracza) = Pusto
            End If
            
            PoleGry(PozycjaGracza + 1) = GraczNaMiejscu
            PozycjaGracza = PozycjaGracza + 1
        Case SkrzynkaNaMiejscu
            If PrzesunSkrzynke(Prawo, PozycjaGracza + 1, True) = False Then
                PrzesunGracza = False
                Exit Function
            End If
            
            If PoleGry(PozycjaGracza) = GraczNaMiejscu Then
                PoleGry(PozycjaGracza) = Miejsce
            Else
                PoleGry(PozycjaGracza) = Pusto
            End If
            
            PoleGry(PozycjaGracza + 1) = GraczNaMiejscu
            PozycjaGracza = PozycjaGracza + 1
            
            Pchniecia = Pchniecia + 1
        End Select
    Case Gora
        Select Case PoleGry(PozycjaGracza - 16)
        Case Pusto
            If PoleGry(PozycjaGracza) = GraczNaMiejscu Then
                PoleGry(PozycjaGracza) = Miejsce
            Else
                PoleGry(PozycjaGracza) = Pusto
            End If
            
            PoleGry(PozycjaGracza - 16) = Gracz
            PozycjaGracza = PozycjaGracza - 16
        Case Murek
            PrzesunGracza = False
            Exit Function
        Case Skrzynka
            If PrzesunSkrzynke(Gora, PozycjaGracza - 16, False) = False Then
                PrzesunGracza = False
                Exit Function
            End If
            
            If PoleGry(PozycjaGracza) = GraczNaMiejscu Then
                PoleGry(PozycjaGracza) = Miejsce
            Else
                PoleGry(PozycjaGracza) = Pusto
            End If
            
            PoleGry(PozycjaGracza - 16) = Gracz
            PozycjaGracza = PozycjaGracza - 16
            
            Pchniecia = Pchniecia + 1
        Case Miejsce
            If PoleGry(PozycjaGracza) = GraczNaMiejscu Then
                PoleGry(PozycjaGracza) = Miejsce
            Else
                PoleGry(PozycjaGracza) = Pusto
            End If
            
            PoleGry(PozycjaGracza - 16) = GraczNaMiejscu
            PozycjaGracza = PozycjaGracza - 16
        Case SkrzynkaNaMiejscu
            If PrzesunSkrzynke(Gora, PozycjaGracza - 16, True) = False Then
                PrzesunGracza = False
                Exit Function
            End If
            
            If PoleGry(PozycjaGracza) = GraczNaMiejscu Then
                PoleGry(PozycjaGracza) = Miejsce
            Else
                PoleGry(PozycjaGracza) = Pusto
            End If
            
            PoleGry(PozycjaGracza - 16) = GraczNaMiejscu
            PozycjaGracza = PozycjaGracza - 16
            
            Pchniecia = Pchniecia + 1
        End Select
    Case Dol
        Select Case PoleGry(PozycjaGracza + 16)
        Case Pusto
            If PoleGry(PozycjaGracza) = GraczNaMiejscu Then
                PoleGry(PozycjaGracza) = Miejsce
            Else
                PoleGry(PozycjaGracza) = Pusto
            End If
            
            PoleGry(PozycjaGracza + 16) = Gracz
            PozycjaGracza = PozycjaGracza + 16
        Case Murek
            PrzesunGracza = False
            Exit Function
        Case Skrzynka
            If PrzesunSkrzynke(Dol, PozycjaGracza + 16, False) = False Then
                PrzesunGracza = False
                Exit Function
            End If
            
            If PoleGry(PozycjaGracza) = GraczNaMiejscu Then
                PoleGry(PozycjaGracza) = Miejsce
            Else
                PoleGry(PozycjaGracza) = Pusto
            End If
            
            PoleGry(PozycjaGracza + 16) = Gracz
            PozycjaGracza = PozycjaGracza + 16
            
            Pchniecia = Pchniecia + 1
        Case Miejsce
            If PoleGry(PozycjaGracza) = GraczNaMiejscu Then
                PoleGry(PozycjaGracza) = Miejsce
            Else
                PoleGry(PozycjaGracza) = Pusto
            End If
            
            PoleGry(PozycjaGracza + 16) = GraczNaMiejscu
            PozycjaGracza = PozycjaGracza + 16
        Case SkrzynkaNaMiejscu
            If PrzesunSkrzynke(Dol, PozycjaGracza + 16, True) = False Then
                PrzesunGracza = False
                Exit Function
            End If
            
            If PoleGry(PozycjaGracza) = GraczNaMiejscu Then
                PoleGry(PozycjaGracza) = Miejsce
            Else
                PoleGry(PozycjaGracza) = Pusto
            End If
            
            PoleGry(PozycjaGracza + 16) = GraczNaMiejscu
            PozycjaGracza = PozycjaGracza + 16
            
            Pchniecia = Pchniecia + 1
        End Select
    End Select
    
    PrzesunGracza = True
End Function
Public Function PrzesunSkrzynke(ByVal Kierunek As Byte, ByVal PozycjaSkrzynki As Byte, ByVal ZMiejsca As Boolean) As Boolean
    If ZMiejsca = True Then
        Select Case Kierunek
        Case Lewo
            Select Case PoleGry(PozycjaSkrzynki - 1)
            Case Pusto
                PoleGry(PozycjaSkrzynki - 1) = Skrzynka
                                
                Etap.SkrzynkiNaMiejscach = Etap.SkrzynkiNaMiejscach - 1
            Case Murek
                PrzesunSkrzynke = False
                Exit Function
            Case Skrzynka
                PrzesunSkrzynke = False
                Exit Function
            Case SkrzynkaNaMiejscu
                PrzesunSkrzynke = False
                Exit Function
            Case Miejsce
                PoleGry(PozycjaSkrzynki - 1) = SkrzynkaNaMiejscu
            End Select
        Case Prawo
            Select Case PoleGry(PozycjaSkrzynki + 1)
            Case Pusto
                PoleGry(PozycjaSkrzynki + 1) = Skrzynka
                                
                Etap.SkrzynkiNaMiejscach = Etap.SkrzynkiNaMiejscach - 1
            Case Murek
                PrzesunSkrzynke = False
                Exit Function
            Case Skrzynka
                PrzesunSkrzynke = False
                Exit Function
            Case SkrzynkaNaMiejscu
                PrzesunSkrzynke = False
                Exit Function
            Case Miejsce
                PoleGry(PozycjaSkrzynki + 1) = SkrzynkaNaMiejscu
            End Select
        Case Gora
            Select Case PoleGry(PozycjaSkrzynki - 16)
            Case Pusto
                PoleGry(PozycjaSkrzynki - 16) = Skrzynka
                                
                Etap.SkrzynkiNaMiejscach = Etap.SkrzynkiNaMiejscach - 1
            Case Murek
                PrzesunSkrzynke = False
                Exit Function
            Case Skrzynka
                PrzesunSkrzynke = False
                Exit Function
            Case SkrzynkaNaMiejscu
                PrzesunSkrzynke = False
                Exit Function
            Case Miejsce
                PoleGry(PozycjaSkrzynki - 16) = SkrzynkaNaMiejscu
            End Select
        Case Dol
            Select Case PoleGry(PozycjaSkrzynki + 16)
            Case Pusto
                PoleGry(PozycjaSkrzynki + 16) = Skrzynka
                                
                Etap.SkrzynkiNaMiejscach = Etap.SkrzynkiNaMiejscach - 1
            Case Murek
                PrzesunSkrzynke = False
                Exit Function
            Case Skrzynka
                PrzesunSkrzynke = False
                Exit Function
            Case SkrzynkaNaMiejscu
                PrzesunSkrzynke = False
                Exit Function
            Case Miejsce
                PoleGry(PozycjaSkrzynki + 16) = SkrzynkaNaMiejscu
            End Select
        End Select
    Else
        Select Case Kierunek
        Case Lewo
            Select Case PoleGry(PozycjaSkrzynki - 1)
            Case Pusto
                PoleGry(PozycjaSkrzynki - 1) = Skrzynka
                PoleGry(PozycjaSkrzynki) = Pusto
            Case Murek
                PrzesunSkrzynke = False
                Exit Function
            Case Skrzynka
                PrzesunSkrzynke = False
                Exit Function
            Case SkrzynkaNaMiejscu
                PrzesunSkrzynke = False
                Exit Function
            Case Miejsce
                PoleGry(PozycjaSkrzynki - 1) = SkrzynkaNaMiejscu
                PoleGry(PozycjaSkrzynki) = Pusto
                
                Etap.SkrzynkiNaMiejscach = Etap.SkrzynkiNaMiejscach + 1
            End Select
        Case Prawo
            Select Case PoleGry(PozycjaSkrzynki + 1)
            Case Pusto
                PoleGry(PozycjaSkrzynki + 1) = Skrzynka
                PoleGry(PozycjaSkrzynki) = Pusto
            Case Murek
                PrzesunSkrzynke = False
                Exit Function
            Case Skrzynka
                PrzesunSkrzynke = False
                Exit Function
            Case SkrzynkaNaMiejscu
                PrzesunSkrzynke = False
                Exit Function
            Case Miejsce
                PoleGry(PozycjaSkrzynki + 1) = SkrzynkaNaMiejscu
                PoleGry(PozycjaSkrzynki) = Pusto
                
                Etap.SkrzynkiNaMiejscach = Etap.SkrzynkiNaMiejscach + 1
            End Select
        Case Gora
            Select Case PoleGry(PozycjaSkrzynki - 16)
            Case Pusto
                PoleGry(PozycjaSkrzynki - 16) = Skrzynka
                PoleGry(PozycjaSkrzynki) = Pusto
            Case Murek
                PrzesunSkrzynke = False
                Exit Function
            Case Skrzynka
                PrzesunSkrzynke = False
                Exit Function
            Case SkrzynkaNaMiejscu
                PrzesunSkrzynke = False
                Exit Function
            Case Miejsce
                PoleGry(PozycjaSkrzynki - 16) = SkrzynkaNaMiejscu
                PoleGry(PozycjaSkrzynki) = Gracz
                
                Etap.SkrzynkiNaMiejscach = Etap.SkrzynkiNaMiejscach + 1
            End Select
        Case Dol
            Select Case PoleGry(PozycjaSkrzynki + 16)
            Case Pusto
                PoleGry(PozycjaSkrzynki + 16) = Skrzynka
                PoleGry(PozycjaSkrzynki) = Pusto
            Case Murek
                PrzesunSkrzynke = False
                Exit Function
            Case Skrzynka
                PrzesunSkrzynke = False
                Exit Function
            Case SkrzynkaNaMiejscu
                PrzesunSkrzynke = False
                Exit Function
            Case Miejsce
                PoleGry(PozycjaSkrzynki + 16) = SkrzynkaNaMiejscu
                PoleGry(PozycjaSkrzynki) = Pusto
                
                Etap.SkrzynkiNaMiejscach = Etap.SkrzynkiNaMiejscach + 1
            End Select
        End Select
    End If
        
    PrzesunSkrzynke = True
End Function
Public Sub NieMozna()
    Temp3 = MessageBeep(-1)
End Sub
Public Sub NowaGra(ByVal KtoryEtap As Long, Optional ByVal Zestaw As Byte = 0)
    Dim ZE As String
    NumerEtapu = KtoryEtap
    Ruchy = 0
    Pchniecia = 0
    WykonanoRuch = False
    EtapSpozaZestawu = False
    frmMain.mnuToolsUndo.Enabled = False
    
    If Zestaw = 0 Then Zestaw = DaneGracza.Zestaw
    Select Case Zestaw
    Case 1
        ZE = "Klasyczne"
    Case 2
        ZE = "Super Trudne XS"
    End Select
    
    If WczytajZestawEtapow(App.Path & "\Etapy\" & ZE & ".bxp", FreeFile()) Then
        PokazNaPaskuStanu 1, ZwrocCiag("StatusBar#0") & Ruchy
        PokazNaPaskuStanu 2, ZwrocCiag("StatusBar#1") & Pchniecia
        PokazNaPaskuStanu 3, ZwrocCiag("StatusBar#2") & Etap.SkrzynkiNaMiejscach & "/" & Etap.LiczbaSkrzynek
        PokazNaPaskuStanu 4, "#" & NumerEtapu
        PokazNaPaskuStanu 5, DaneGracza.Imie
        frmMain.Caption = App.Title & " - #" & NumerEtapu
        EtapZaliczony = False
    End If
    
    For Licznik = 1 To 256 Step 1
        PoleGry(Licznik) = Etapy(NumerEtapu, Licznik)
    Next Licznik
    
    For Licznik = 1 To 256 Step 1
        If PoleGry(Licznik) = Gracz Or PoleGry(Licznik) = GraczNaMiejscu Then PozycjaGracza = Licznik
    Next Licznik
    
    ZestawEtapow = DaneGracza.Zestaw
    OdswiezPoleGry
End Sub
Public Sub Cofnij()
    For Licznik = 1 To 256 Step 1
        PoleGry(Licznik) = PoleGrySprzedRuchu(Licznik)
    Next Licznik
    PozycjaGracza = PozycjaGraczaSprzedRuchu
    Etap.SkrzynkiNaMiejscach = EtapSprzedRuchu.SkrzynkiNaMiejscach
    PokazNaPaskuStanu 3, ZwrocCiag("StatusBar#2") & Etap.SkrzynkiNaMiejscach & "/" & Etap.LiczbaSkrzynek
    
    WykonanoRuch = False
    frmMain.mnuToolsUndo.Enabled = False
    OdswiezPoleGry
End Sub
Public Sub RestartujEtap()
    For Licznik = 1 To 256
        PoleGry(Licznik) = Etapy(NumerEtapu, Licznik)
        Etap = DaneEtapow(NumerEtapu)
        PozycjaGracza = PozycjeGracza(NumerEtapu)
    Next Licznik
    
    Ruchy = 0
    Pchniecia = 0
    WykonanoRuch = False
    frmMain.mnuToolsUndo.Enabled = False
    
    PokazNaPaskuStanu 1, ZwrocCiag("StatusBar#0") & Ruchy
    PokazNaPaskuStanu 2, ZwrocCiag("StatusBar#1") & Pchniecia
    PokazNaPaskuStanu 3, ZwrocCiag("StatusBar#2") & Etap.SkrzynkiNaMiejscach & "/" & Etap.LiczbaSkrzynek
    PokazNaPaskuStanu 4, "#" & NumerEtapu
    frmMain.Caption = "Skrzynki - #" & NumerEtapu
    OdswiezPoleGry
End Sub
Public Sub OdswiezPoleGryWokolGracza()
    Dim Skin As String
    
    RegWartosc = RegSciezka & "\Options\Skin"
    Skin = RegObj.Get(RegWartosc)
    
    With frmMain
        If PoleGry(PozycjaGracza - 16) < 7 Then
            frmMain.imgGameField(PozycjaGracza - 16).Picture = LoadPicture(App.Path & "\Skiny\" & Skin & "\" & PoleGry(PozycjaGracza - 16) & ".ico")
        Else
            frmMain.imgGameField(PozycjaGracza - 16).Picture = LoadPicture()
        End If
     
        If PoleGry(PozycjaGracza - 1) < 7 Then
            frmMain.imgGameField(PozycjaGracza - 1).Picture = LoadPicture(App.Path & "\Skiny\" & Skin & "\" & PoleGry(PozycjaGracza - 1) & ".ico")
        Else
            frmMain.imgGameField(PozycjaGracza - 1).Picture = LoadPicture()
        End If
        
        If PoleGry(PozycjaGracza) < 7 Then
            frmMain.imgGameField(PozycjaGracza).Picture = LoadPicture(App.Path & "\Skiny\" & Skin & "\" & PoleGry(PozycjaGracza) & ".ico")
        Else
            frmMain.imgGameField(PozycjaGracza).Picture = LoadPicture()
        End If
        
        If PoleGry(PozycjaGracza + 1) < 7 Then
            frmMain.imgGameField(PozycjaGracza + 1).Picture = LoadPicture(App.Path & "\Skiny\" & Skin & "\" & PoleGry(PozycjaGracza + 1) & ".ico")
        Else
            frmMain.imgGameField(PozycjaGracza + 1).Picture = LoadPicture()
        End If
       
        If PoleGry(PozycjaGracza + 16) < 7 Then
            frmMain.imgGameField(PozycjaGracza + 16).Picture = LoadPicture(App.Path & "\Skiny\" & Skin & "\" & PoleGry(PozycjaGracza + 16) & ".ico")
        Else
            frmMain.imgGameField(PozycjaGracza + 16).Picture = LoadPicture()
        End If
    End With
End Sub
Public Sub ZakonczGre()
    ZatrzymajMidi
    ZamknijMidi
    ZapiszStatystyki
    TIcon.Hide
    End
End Sub
Public Function NajdalszyEtap() As Integer
    Select Case ZestawEtapow
    Case 1
        NajdalszyEtap = DaneGracza.Klasyczne.OsiagnietyEtap
    Case 2
        NajdalszyEtap = DaneGracza.SuperTrudneXS.OsiagnietyEtap
    End Select
End Function
Public Function KonwertujEtap(ByVal PlikZrodlowy As String, ByVal PlikDocelowy As String) As Boolean
    On Error GoTo Blad
    Dim Etap(10) As String
    
    Open PlikZrodlowy For Input As #10
        For Licznik = 1 To 10 Step 1
            Line Input #1, Etap(Licznik)
        Next Licznik
    Close #10
    
    Open PlikDocelowy For Output As #20
        For Licznik = 1 To 3 Step 1
            Print #2, "''''''''''''''''"
        Next Licznik
        
        For Licznik = 1 To 10 Step 1
            Print #2, "'''" & Etap(Licznik) & "'''"
        Next Licznik
        
        For Licznik = 1 To 3 Step 1
            Print #2, "''''''''''''''''"
        Next Licznik
    Close #20
    
    KonwertujEtap = True
    Exit Function

Blad:
    KonwertujEtap = False
End Function
Public Sub SkojarzPlikiBOXZProgramem()
    RegWartosc = "HKLM\Software\CLASSES\.box\"
    RegDaneStr = "SkrzynkiLevelFile"
    RegObj.Set RegWartosc, RegDaneStr, RegFlush
    
    RegWartosc = "HKLM\Software\CLASSES\.box\Content Type"
    RegDaneStr = "text/plain"
    RegObj.Set RegWartosc, RegDaneStr, RegFlush
    
    RegWartosc = "HKLM\Software\CLASSES\SkrzynkiLevelFile\"
    RegDaneStr = "Etap gry Skrzynki"
    RegObj.Set RegWartosc, RegDaneStr, RegFlush
    
    RegWartosc = "HKLM\Software\CLASSES\SkrzynkiLevelFile\DefaultIcon\"
    RegDaneStr = Trim$(App.Path & "\" & App.EXEName & ".exe,5")
    RegObj.Set RegWartosc, RegDaneStr, RegFlush
    
    RegWartosc = "HKLM\Software\CLASSES\SkrzynkiLevelFile\Shell\Graj\command\"
    RegDaneStr = Chr$(34) & App.Path & "\" & App.EXEName & ".exe" & Chr(34) & " " & Chr$(34) & "%1" & Chr(34)
    RegObj.Set RegWartosc, RegDaneStr, RegFlush
End Sub
Public Sub PokazNaPaskuStanu(ByVal NumerPanelu As Byte, ByVal Napis As String)
    With frmMain
        Select Case NumerPanelu
        Case 1
            .lblMoves.Caption = Napis
        Case 2
            .lblPushes.Caption = Napis
        Case 3
            .lblBoxes.Caption = Napis
        Case 4
            .lblLevelNumber.Caption = Napis
        Case 5
            .lblPlayerName.Caption = Napis
        End Select
    End With
End Sub
Public Sub PokazForme(frm As Form, Optional Modality, Optional Owner)
    PrzetlumaczForme frm
    frm.Show Modality, Owner
End Sub
