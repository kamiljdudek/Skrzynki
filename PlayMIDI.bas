Attribute VB_Name = "modPlayMIDI"
Public Declare Function mciSendString Lib "winmm.dll" Alias "mciSendStringA" (ByVal lpstrCommand As String, ByVal lpstrReturnString As String, ByVal uReturnLength As Integer, ByVal hWndCallback As Integer) As Long
Dim ReturnString As String * 128
Dim CommandString As String

Global PlikiMIDI As New Collection
Global DlugoscPlikuMidi As String
Public Function OtworzMidi(ByVal NazwaPlikuMidi As String)
    ReturnString = Space(128)
    CommandString = "open " & NazwaPlikuMidi & " type sequencer alias midi "
    OtworzMidi = mciSendString(CommandString, ReturnString, Len(ReturnString), 0)
End Function
Public Function GrajMidi()
    ReturnString = Space(128)
    CommandString = "play midi"
    GrajMidi = mciSendString(CommandString, ReturnString, Len(ReturnString), 0)
End Function
Public Function ZatrzymajMidi()
    ReturnString = Space(128)
    CommandString = "stop midi"
    ZatrzymajMidi = mciSendString(CommandString, ReturnString, Len(ReturnString), 0)
End Function
Public Function ZamknijMidi()
    ReturnString = Space(128)
    CommandString = "close midi"
    ZamknijMidi = mciSendString(CommandString, ReturnString, Len(ReturnString), 0)
End Function
Public Function DlugoscMidi() As String
    ReturnString = Space(128)
    CommandString = "set midi time format smpte 30"
    mciSendString CommandString, ReturnString, Len(ReturnString), 0
    CommandString = "status midi length"
    mciSendString CommandString, ReturnString, Len(ReturnString), 0
    DlugoscMidi = Mid$(ReturnString, 4, 5)
End Function
Public Function PozycjaMidi() As String
    ReturnString = Space(128)
    CommandString = "set midi time format smpte 30"
    mciSendString CommandString, ReturnString, Len(ReturnString), 0
    CommandString = "status midi position"
    mciSendString CommandString, ReturnString, Len(ReturnString), 0
    PozycjaMidi = Mid$(ReturnString, 4, 5)
End Function
Public Sub WczytajListeMIDI()
    Open App.Path & "\INI\MIDI.INI" For Input As #10
        Do Until EOF(10)
            Line Input #10, temp
            If temp <> "" Then PlikiMIDI.Add temp
        Loop
    Close #10
End Sub
Public Function WybierzLosowyUtwor() As String
    Randomize
    WybierzLosowyUtwor = PlikiMIDI(Int((PlikiMIDI.Count * Rnd) + 1))
End Function
