Option Strict Off
Option Explicit On
Module modPlayMIDI
	Public Declare Function mciSendString Lib "winmm.dll"  Alias "mciSendStringA"(ByVal lpstrCommand As String, ByVal lpstrReturnString As String, ByVal uReturnLength As Short, ByVal hWndCallback As Short) As Integer
	Dim ReturnString As New VB6.FixedLengthString(128)
	Dim CommandString As String
	
	Public PlikiMIDI As New Collection
	Public DlugoscPlikuMidi As String
	Public Function OtworzMidi(ByVal NazwaPlikuMidi As String) As Object
		ReturnString.Value = Space(128)
		CommandString = "open " & NazwaPlikuMidi & " type sequencer alias midi "
		OtworzMidi = mciSendString(CommandString, ReturnString.Value, Len(ReturnString.Value), 0)
	End Function
	Public Function GrajMidi() As Object
		ReturnString.Value = Space(128)
		CommandString = "play midi"
		GrajMidi = mciSendString(CommandString, ReturnString.Value, Len(ReturnString.Value), 0)
	End Function
	Public Function ZatrzymajMidi() As Object
		ReturnString.Value = Space(128)
		CommandString = "stop midi"
		ZatrzymajMidi = mciSendString(CommandString, ReturnString.Value, Len(ReturnString.Value), 0)
	End Function
	Public Function ZamknijMidi() As Object
		ReturnString.Value = Space(128)
		CommandString = "close midi"
		ZamknijMidi = mciSendString(CommandString, ReturnString.Value, Len(ReturnString.Value), 0)
	End Function
	Public Function DlugoscMidi() As String
		ReturnString.Value = Space(128)
		CommandString = "set midi time format smpte 30"
		mciSendString(CommandString, ReturnString.Value, Len(ReturnString.Value), 0)
		CommandString = "status midi length"
		mciSendString(CommandString, ReturnString.Value, Len(ReturnString.Value), 0)
		DlugoscMidi = Mid(ReturnString.Value, 4, 5)
	End Function
	Public Function PozycjaMidi() As String
		ReturnString.Value = Space(128)
		CommandString = "set midi time format smpte 30"
		mciSendString(CommandString, ReturnString.Value, Len(ReturnString.Value), 0)
		CommandString = "status midi position"
		mciSendString(CommandString, ReturnString.Value, Len(ReturnString.Value), 0)
		PozycjaMidi = Mid(ReturnString.Value, 4, 5)
	End Function
	Public Sub WczytajListeMIDI()
		Dim temp As Object
		FileOpen(10, VB6.GetPath & "\INI\MIDI.INI", OpenMode.Input)
		Do Until EOF(10)
			temp = LineInput(10)
			'UPGRADE_WARNING: Couldn't resolve default property of object temp. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
			If temp <> "" Then PlikiMIDI.Add(temp)
		Loop 
		FileClose(10)
	End Sub
	Public Function WybierzLosowyUtwor() As String
		Randomize()
		'UPGRADE_WARNING: Couldn't resolve default property of object PlikiMIDI(). Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
		WybierzLosowyUtwor = PlikiMIDI.Item(Int((PlikiMIDI.Count() * Rnd()) + 1))
	End Function
End Module