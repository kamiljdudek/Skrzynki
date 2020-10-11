Module 倉庫番
    ' -------------------------------------------------------------------------------------------
    ' |                                         SKRZYNKI                                        |
    ' |                                 autor: Karol Kuczmarski                                 |
    ' -------------------------------------------------------------------------------------------
    '
    ' Rodzaj: gra logiczna
    ' Typ: sokoban
    '
    ' Należy ułożyć skrzynki na wyznaczony miejscach. Można poruszać tylko jedną skrzynką naraz,
    ' w kierunku "od siebie".
    '
    ' Znaczenie procedur (P) i funkcji (F):
    ' Cofnij (P) - pozwala wrócić do stanu sprzed ruchu (zapisanego w tablicy PoleGrySprzedRuchu
    '              i zmiennej PozycjaGraczaSprzedRuchu
    ' NastepnyEtap (P) - jest wykonywana, kiedy gracz przejdzie etap
    ' NowaGra (P) - startuje grę od wybranego etapu (określonego w parametrze KtoryEtap)
    ' PrzesunGracza (F) - używana, kiedy gracz wciśnie klawisz kursora; zwraca True, jeśli
    '                     przesunięcie jest możliwe (jednocześnie je wykonuje); kierunek jest
    '                     jest określony parametrem Kierunek
    ' PrzesunSkrzynke (F) - czy można przesunąć skrzynkę na drodze gracza? (parametry: Kierunek
    '                       określa kierunek przesunięcia, PozycjaSkrzynki - którą skrzynkę
    '                       należy przesunąć, zaś ZMiejsca - czy skrzynka ta jest lub nie jest
    '                       na miejscu
    ' RestartujEtap (P) - restartuje bieżący etap
    ' WczytajEtap (F) - wczytuje etap z pliku wskazanego w parametrze PlikEtapu; jednocześnie
    '                   sprawdza jego poprawność (czy zawiera skrzynki, postać gracza itd.);
    '                   parametr KanalPliku określa numer kanału plikowego przypisanego do pliku
    '                   etapu (zwykle jest to FreeFile())
    ' WczytajZestawEtapow (F) - wczytuje zestaw etapów
    '--------------------------------------------------------------------------------------------
    ' Działanie gry opiera się na tablicy 256 Image'ów oraz jej odpowiedniku w postaci jednowy-
    ' miarowego arrayu Byte'ów o nazwie PoleGry. Pozycja gracza jest zapisywana w zmiennej o tej
    ' nazwie. Do czego służą pozostałe zmienne i stałe - a jest ich dużo - przy ich deklaracjach.
    '--------------------------------------------------------------------------------------------
    ' Niniejszy program jest wolnym oprogramowaniem; możesz go 
    ' rozprowadzać dalej i/lub modyfikować na warunkach Powszechnej
    ' Licencji Publicznej GNU, wydanej przez Fundację Wolnego
    ' Oprogramowania - według wersji 2-giej tej Licencji lub którejś
    ' z późniejszych wersji.
    '
    ' Niniejszy program rozpowszechniany jest z nadzieją, iż będzie on
    ' użyteczny - jednak BEZ JAKIEJKOLWIEK GWARANCJI, nawet domyślnej
    ' gwarancji PRZYDATNOŚCI HANDLOWEJ albo PRZYDATNOŚCI DO OKREŚLONYCH
    ' ZASTOSOWAŃ. W celu uzyskania bliższych informacji - Powszechna
    ' Licencja Publiczna GNU.
    '
    ' Z pewnością wraz z niniejszym programem otrzymałeś też egzemplarz
    ' Powszechnej Licencji Publicznej GNU (GNU General Public License);
    ' jeśli nie - napisz do Free Software Foundation, Inc., 675 Mass Ave,
    ' Cambridge, MA 02139, USA.
    '--------------------------------------------------------------------------------------------

    Structure Level ' dane etapu
        Dim LiczbaSkrzynek As Integer
        Dim LiczbaMiejsc As Integer
        Dim SkrzynkiNaMiejscach As Integer
        Dim PostacGracza As Boolean
    End Structure


    ' deklaracje stałych, zmiennych i funkcji API
    '--------------------------------------------
    '
    Public Lewo As System.Windows.Forms.Keys = System.Windows.Forms.Keys.Left
    Public Prawo As System.Windows.Forms.Keys = System.Windows.Forms.Keys.Right
    Public Gora As System.Windows.Forms.Keys = System.Windows.Forms.Keys.Up
    Public Dol As System.Windows.Forms.Keys = System.Windows.Forms.Keys.Down
    '
    Public Const Pusto As Short = 0 ' stałe pola gry
    Public Const Murek As Short = 1
    Public Const Skrzynka As Short = 2
    Public Const Miejsce As Short = 3
    Public Const SkrzynkaNaMiejscu As Short = 4
    Public Const Gracz As Short = 5
    Public Const GraczNaMiejscu As Short = 6
    Public Const PustoPozaEtapem As Short = 7
    '
    Public Const LiczbaEtapow As Short = 60
    '
    Public Const DyskNieGotowy As Short = 71 ' błędy aplikacji
    Public Const DyskPelny As Short = 61
    Public Const UrzadzenieNiedostepne As Short = 68
    Public Const ZlaNazwaPliku As Short = 52
    Public Const ZaDuzoPlikow As Short = 67
    Public Const NieZnalezionoKatalogu As Short = 76
    Public Const NieZnalezionoPliku As Short = 53
    '

    ' zmienne
    Public PoleGry(256) As Integer ' przechowuje aktualne ustawienie obiektów w polu gry
    Public PoleGrySprzedRuchu(256) As Integer ' dzięki niemu możliwe jest cofanie ruchów i nie tylko
    Public Etapy(1, 128) As Integer ' wszystkie etapy z danego zestawu
    Public DaneEtapow() As Level ' dane wszystkich etapów z zestawu
    Public Etap As Level ' przechowuje liczbę skrzynek i miejsc
    Public EtapSprzedRuchu As Level ' tak jak PoleGrySprzedRuchu
    Public OstatnioEtap As Level ' jeśli wczytywanie etapu się nie powiedzie,
    ' ta zmienna zachowuje dane poprzedniego poziomu
    Public PozycjaGracza As Integer ' aktualna pozycja gracza
    Public PozycjaGraczaSprzedRuchu As Integer ' dzięki temu możliwe jest cofanie ruchów
    Public PozycjeGracza() As Integer ' początkowe pozycje gracza we wszystkich etapach
    Public WykonanoRuch As Boolean ' czy gracz wykonał ruch (i czy ew. można cofnąć)
    ' określa, czy aktualny etap jest etapem wczytanym z pliku
    Public EtapSpozaZestawu As Boolean ' wybranego przez użytkownika (jeśli tak jest, po jego
    ' przejściu nie powinien być wyświetlony następny)
    Public EtapZaliczony As Boolean ' czy etap spoza zestawu zaliczony?
    Public NumerEtapu As Integer ' numer aktualnie rozgrywanego etapu
    Public ZestawEtapow As String ' aktualnie rozgrywany zestaw etapów
    Public Ruchy As Integer ' ruchy wykonane w etapie
    Public Pchniecia As Integer ' ruchy skrzynek wykonane w etapie
    Public NazwaPliku As String ' nazwa pliku etapu
    Public Licznik As Integer ' do pętli For...Next
    Public Temp1 As String
    Public Temp2 As String ' zmienne do danych tymczasowych lub niepotrzebnych
    Public Msg As String

    Public Function WczytajEtap(ByRef PlikEtapu As String, ByRef KanalPliku As Integer) As Boolean
        On Error GoTo BladWczytywaniaEtapu

        Const ZaDuzoGraczy As Short = 1
        Const SkrzynkiIMiejsca As Short = 2
        Const BrakSkrzynek As Short = 3
        Const BrakMiejsc As Short = 4
        Const BrakGracza As Short = 5

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

        FileOpen(KanalPliku, PlikEtapu, OpenMode.Input, OpenAccess.Read, OpenShare.LockWrite)
        If LOF(KanalPliku) < 250 Then
            FileClose(KanalPliku)
            MsgBox("Plik " & PlikEtapu & " ma rozmiar " & LOF(KanalPliku) & "bajtów - jest za mały, aby móc przechowywać kompletną informację o strukturze etapu.", MsgBoxStyle.OkOnly Or MsgBoxStyle.Critical Or MsgBoxStyle.ApplicationModal, System.Reflection.Assembly.GetExecutingAssembly.GetName.Name)
            WczytajEtap = False
            Exit Function
        End If

        Znak = 1
        For Licznik = 1 To 256 Step 1 'odczytanie etapu - znak po znaku
            If (((Licznik - 1) Mod 16) = 0 Or Licznik = 1) And (Licznik <= 241) Then
                Temp1 = LineInput(KanalPliku) 'wczytanie linii znaków
            End If

            If (Licznik Mod 16) > 0 Then
                'UPGRADE_WARNING: Couldn't resolve default property of object Temp1. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
                Temp2 = Mid(Temp1, Znak, 1) 'pobranie znaku z linii
                Znak += 1
            Else
                'UPGRADE_WARNING: Couldn't resolve default property of object Temp1. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
                Temp2 = Mid(Temp1, 16, 1) ' pobranie ostatniego znaku
                Znak = 1
            End If

            Select Case Temp2 'sprawdzenie, czym jest odczytany znak
                Case "'"
                    PoleGry(Licznik) = PustoPozaEtapem
                Case CStr(Gracz Or GraczNaMiejscu)
                    PozycjaGracza = Licznik
                    PoleGry(Licznik) = CInt(Val(Temp2))
                Case Else
                    PoleGry(Licznik) = CInt(Val(Temp2))
            End Select

            With Etap 'zaktualizowanie danych o etapie
                Select Case Temp2
                    Case CStr(Skrzynka)
                        .LiczbaSkrzynek = .LiczbaSkrzynek + 1
                    Case CStr(Miejsce)
                        .LiczbaMiejsc = .LiczbaMiejsc + 1
                    Case CStr(Gracz)
                        If .PostacGracza Then
                            NumerBleduEtapu = ZaDuzoGraczy
                            GoTo BladPlikuEtapu
                        End If

                        .PostacGracza = True
                    Case CStr(SkrzynkaNaMiejscu)
                        .LiczbaMiejsc = .LiczbaMiejsc + 1
                        .LiczbaSkrzynek = .LiczbaSkrzynek + 1
                        .SkrzynkiNaMiejscach = .SkrzynkiNaMiejscach + 1
                    Case CStr(GraczNaMiejscu)
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

        FileClose(KanalPliku)

        WczytajEtap = True
        Exit Function

BladPlikuEtapu: 'coś jest źle w etapie (np. liczba graczy różna od 1)
        FileClose()
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
                'UPGRADE_WARNING: Couldn't resolve default property of object Msg. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
                Msg = "W etapie musi być dokładnie jedna postać gracza."
            Case SkrzynkiIMiejsca
                'UPGRADE_WARNING: Couldn't resolve default property of object Msg. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
                Msg = "Liczba skrzynek musi być równa liczbie miejsc. Aktualnie jest:" & Chr(10) & "skrzynek: " & Etap.LiczbaSkrzynek & Chr(10) & "miejsc: " & Etap.LiczbaMiejsc & "."
            Case BrakSkrzynek
                'UPGRADE_WARNING: Couldn't resolve default property of object Msg. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
                Msg = "W etapie musi być przynajmniej jedna skrzynka."
            Case BrakMiejsc
                'UPGRADE_WARNING: Couldn't resolve default property of object Msg. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
                Msg = "W etapie musi być przynajmniej jedno miejsce na skrzynkę."
        End Select

        MsgBox(Msg, MsgBoxStyle.OkOnly Or MsgBoxStyle.Critical Or MsgBoxStyle.ApplicationModal, System.Reflection.Assembly.GetExecutingAssembly.GetName.Name)
        Exit Function

BladWczytywaniaEtapu: 'coś jest z plikiem
        FileClose()
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
        Dim Stl As MsgBoxStyle = MsgBoxStyle.OkOnly

        Select Case Err.Number
            Case DyskNieGotowy
                Msg = "Dysk nie jest gotowy."
                Stl = MsgBoxStyle.RetryCancel Or MsgBoxStyle.Critical Or MsgBoxStyle.SystemModal
            Case NieZnalezionoPliku
                Msg = "Plik " & PlikEtapu & " nie istnieje."
                Stl = MsgBoxStyle.OkOnly Or MsgBoxStyle.Critical Or MsgBoxStyle.SystemModal
            Case Else
                Msg = "Błąd nr " & Err.Number & ":" & Chr(10) & Err.Description
                Stl = MsgBoxStyle.OkOnly Or MsgBoxStyle.Critical Or MsgBoxStyle.SystemModal
        End Select

        Dim TempX As MsgBoxResult = MsgBox(Msg, Stl, System.Reflection.Assembly.GetExecutingAssembly.GetName.Name)
        If TempX = MsgBoxResult.Ok Or TempX = MsgBoxResult.Cancel Then Exit Function Else Resume
    End Function
    Public Function WczytajZestawEtapow(ByRef PlikZestawu As String, ByRef KanalPliku As Integer) As Boolean
        Dim KatalogTemp As String = System.IO.Path.GetTempPath()
        Dim LiczbaEtapowWZestawie As Integer
        Dim i As Integer
        Dim j As Integer
        Dim Kanal As Integer

        FileOpen(KanalPliku, PlikZestawu, OpenMode.Input)
        Input(KanalPliku, Temp1)
        'UPGRADE_WARNING: Couldn't resolve default property of object Temp1. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
        LiczbaEtapowWZestawie = CInt(Val(Temp1))

        'UPGRADE_WARNING: Lower bound of array Etapy was changed from 1,1 to 0,0. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1033"'
        ReDim Etapy(LiczbaEtapowWZestawie, 256)
        'UPGRADE_WARNING: Lower bound of array DaneEtapow was changed from 1 to 0. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1033"'
        ReDim DaneEtapow(LiczbaEtapowWZestawie)
        'UPGRADE_WARNING: Lower bound of array PozycjeGracza was changed from 1 to 0. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1033"'
        ReDim PozycjeGracza(LiczbaEtapowWZestawie)

        For i = 1 To LiczbaEtapowWZestawie Step 1
            Input(KanalPliku, Temp1)

            Kanal = FreeFile()
            FileOpen(Kanal, KatalogTemp & "\#" & Str(i) & ".box", OpenMode.Output)
            For j = 1 To 16 Step 1
                Temp1 = LineInput(KanalPliku)
                PrintLine(Kanal, Temp1)
            Next j
            FileClose(Kanal)
        Next i
        FileClose(KanalPliku)

        For i = 1 To LiczbaEtapowWZestawie Step 1
            If WczytajEtap(KatalogTemp & "\#" & Str(i) & ".box", FreeFile) Then
                For j = 1 To 256 Step 1
                    Etapy(i, j) = PoleGry(j)
                Next j

                'UPGRADE_WARNING: Couldn't resolve default property of object DaneEtapow(i). Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
                DaneEtapow(i) = Etap
                PozycjeGracza(i) = PozycjaGracza

                System.IO.File.Delete(KatalogTemp & "\#" & Str(i) & ".box")
            Else : GoTo Blad
            End If
        Next i

        For i = 1 To 256 Step 1
            PoleGry(i) = Etapy(1, i)
        Next i
        'UPGRADE_WARNING: Couldn't resolve default property of object Etap. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
        Etap = DaneEtapow(1)

        WczytajZestawEtapow = True
        Exit Function

Blad:
        MsgBox(ZwrocCiag("General#8"), MsgBoxStyle.OkOnly Or MsgBoxStyle.Critical Or MsgBoxStyle.ApplicationModal, System.Reflection.Assembly.GetExecutingAssembly.GetName.Name)
        WczytajZestawEtapow = False
    End Function
    Public Sub NastepnyEtap()
        MsgBox(ZwrocCiag("General#0"), MsgBoxStyle.OkOnly Or MsgBoxStyle.Information Or MsgBoxStyle.ApplicationModal, System.Reflection.Assembly.GetExecutingAssembly.GetName.Name)
        EtapZaliczony = True
        If EtapSpozaZestawu Then Exit Sub

        NumerEtapu += 1

        If NumerEtapu > NajdalszyEtap() Then
            Select Case ZestawEtapow
                Case "Klasyczne"
                    DaneGracza.Klasyczne.OsiagnietyEtap = NumerEtapu
                    DaneGracza.Klasyczne.Pchniecia += Pchniecia
                    DaneGracza.Klasyczne.Ruchy += Ruchy
                Case "SuperTrudneXS"
                    DaneGracza.SuperTrudneXS.OsiagnietyEtap = NumerEtapu
                    DaneGracza.SuperTrudneXS.Pchniecia += Pchniecia
                    DaneGracza.SuperTrudneXS.Ruchy += Ruchy
            End Select
        End If
        Ruchy = 0
        Pchniecia = 0
        WykonanoRuch = False

        If NumerEtapu > UBound(Etapy, 1) Then
            MsgBox(ZwrocCiag("General#7"), MsgBoxStyle.OkOnly Or MsgBoxStyle.Information Or MsgBoxStyle.ApplicationModal, System.Reflection.Assembly.GetExecutingAssembly.GetName.Name)
            Exit Sub
        End If

        For Licznik = 1 To 256 Step 1
            PoleGry(Licznik) = Etapy(NumerEtapu, Licznik)
        Next Licznik
        'UPGRADE_WARNING: Couldn't resolve default property of object Etap. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
        Etap = DaneEtapow(NumerEtapu)
        PozycjaGracza = PozycjeGracza(NumerEtapu)
        EtapZaliczony = False
    End Sub
    Public Function PrzesunGracza(ByVal Kierunek As System.Windows.Forms.Keys) As Boolean
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
                        PozycjaGracza -= 1
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
                        PozycjaGracza -= 1

                        Pchniecia += 1
                    Case Miejsce
                        If PoleGry(PozycjaGracza) = GraczNaMiejscu Then
                            PoleGry(PozycjaGracza) = Miejsce
                        Else
                            PoleGry(PozycjaGracza) = Pusto
                        End If

                        PoleGry(PozycjaGracza - 1) = GraczNaMiejscu
                        PozycjaGracza -= 1
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
                        PozycjaGracza -= 1

                        Pchniecia += 1
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
                        PozycjaGracza += 1
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
                        PozycjaGracza += 1

                        Pchniecia += 1
                    Case Miejsce
                        If PoleGry(PozycjaGracza) = GraczNaMiejscu Then
                            PoleGry(PozycjaGracza) = Miejsce
                        Else
                            PoleGry(PozycjaGracza) = Pusto
                        End If

                        PoleGry(PozycjaGracza + 1) = GraczNaMiejscu
                        PozycjaGracza += 1
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
                        PozycjaGracza += 1

                        Pchniecia += 1
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
                        PozycjaGracza -= 16
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
                        PozycjaGracza -= 16

                        Pchniecia += 1
                    Case Miejsce
                        If PoleGry(PozycjaGracza) = GraczNaMiejscu Then
                            PoleGry(PozycjaGracza) = Miejsce
                        Else
                            PoleGry(PozycjaGracza) = Pusto
                        End If

                        PoleGry(PozycjaGracza - 16) = GraczNaMiejscu
                        PozycjaGracza -= 16
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
                        PozycjaGracza -= 16

                        Pchniecia += 1
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
                        PozycjaGracza += 16
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
                        PozycjaGracza += 16

                        Pchniecia += 1
                    Case Miejsce
                        If PoleGry(PozycjaGracza) = GraczNaMiejscu Then
                            PoleGry(PozycjaGracza) = Miejsce
                        Else
                            PoleGry(PozycjaGracza) = Pusto
                        End If

                        PoleGry(PozycjaGracza + 16) = GraczNaMiejscu
                        PozycjaGracza += 16
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
                        PozycjaGracza += 16

                        Pchniecia += 1
                End Select
        End Select

        PrzesunGracza = True
    End Function
    Public Function PrzesunSkrzynke(ByVal Kierunek As System.Windows.Forms.Keys, ByVal PozycjaSkrzynki As Integer, ByVal ZMiejsca As Boolean) As Boolean
        If ZMiejsca = True Then
            Select Case Kierunek
                Case Lewo
                    Select Case PoleGry(PozycjaSkrzynki - 1)
                        Case Pusto
                            PoleGry(PozycjaSkrzynki - 1) = Skrzynka

                            Etap.SkrzynkiNaMiejscach -= 1
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

                            Etap.SkrzynkiNaMiejscach -= 1
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

                            Etap.SkrzynkiNaMiejscach -= 1
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

                            Etap.SkrzynkiNaMiejscach -= 1
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

                            Etap.SkrzynkiNaMiejscach += 1
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

                            Etap.SkrzynkiNaMiejscach += 1
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

                            Etap.SkrzynkiNaMiejscach += 1
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

                            Etap.SkrzynkiNaMiejscach += 1
                    End Select
            End Select
        End If

        PrzesunSkrzynke = True
    End Function
    Public Sub NowaGra(ByVal KtoryEtap As Integer, Optional ByVal Zestaw As String = "Klasyczne")
        Dim ZE As String
        NumerEtapu = KtoryEtap
        Ruchy = 0
        Pchniecia = 0
        WykonanoRuch = False
        EtapSpozaZestawu = False

        ZE = My.Settings.LevelSet

        If WczytajZestawEtapow(".\Etapy\" & ZE & ".bxp", FreeFile) Then

            EtapZaliczony = False
        End If

        For Licznik = 1 To 256 Step 1
            PoleGry(Licznik) = Etapy(NumerEtapu, Licznik)
        Next Licznik

        For Licznik = 1 To 256 Step 1
            If PoleGry(Licznik) = Gracz Or PoleGry(Licznik) = GraczNaMiejscu Then PozycjaGracza = Licznik
        Next Licznik

        ZestawEtapow = My.Settings.LevelSet
    End Sub
    Public Sub Cofnij()
        For Licznik = 1 To 256 Step 1
            PoleGry(Licznik) = PoleGrySprzedRuchu(Licznik)
        Next Licznik
        PozycjaGracza = PozycjaGraczaSprzedRuchu
        Etap.SkrzynkiNaMiejscach = EtapSprzedRuchu.SkrzynkiNaMiejscach

        WykonanoRuch = False
    End Sub
    Public Sub RestartujEtap()
        For Licznik = 1 To 256
            PoleGry(Licznik) = Etapy(NumerEtapu, Licznik)
            'UPGRADE_WARNING: Couldn't resolve default property of object Etap. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
            Etap = DaneEtapow(NumerEtapu)
            PozycjaGracza = PozycjeGracza(NumerEtapu)
        Next Licznik

        Ruchy = 0
        Pchniecia = 0
        WykonanoRuch = False
    End Sub
    Public Function NajdalszyEtap() As Integer
        If My.Settings.LevelSet = "Klasyczne" Then
            NajdalszyEtap = My.Settings.ArrivedLevelKlasyczne
        Else
            NajdalszyEtap = My.Settings.ArrivedLevelSupertrudne
        End If
    End Function

End Module