Option Strict Off
Option Explicit On
Friend Class CTrayIcon
	'struktura przechowuj¹ca dane o w³aœciwoœciach ikonki
	'pojawiaj¹cej siê w prawym dolnym rogu paska Windows
	Private Structure NOTIFYICONDATA
		Dim cbSize As Integer 'rozmiar
		Dim hwnd As Integer 'uchwyt
		Dim uId As Integer 'numer identyfikacyjny
		Dim uFlags As Integer 'flagi
		Dim ucallbackMessage As Integer 'zwracany komunikat
		Dim hIcon As Integer 'ikonka
		<VBFixedString(64),System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.ByValTStr,SizeConst:=64)> Public szTip As String 'tekst podpowiedzi = 64 znaki
	End Structure
	
	'sta³e
	Private Const NIM_ADD As Short = &H0s 'dodawanie ikonki
	Private Const NIM_MODIFY As Short = &H1s 'modyfikowanie
	Private Const NIM_DELETE As Short = &H2s 'usuwanie
	Private Const WM_MOUSEMOVE As Short = &H200s 'poruszanie myszk¹ nad obiektem
	Private Const NIF_MESSAGE As Short = &H1s 'wiadomoœæ
	Private Const NIF_ICON As Short = &H2s 'ikonka
	Private Const NIF_TIP As Short = &H4s 'tekst podpowiedzi
	
	'sta³e opisuj¹ce mo¿liwe zdarzenia
	Enum TI_EVENT
		WM_LBUTTONDBLCLK = &H203s 'podwójne klikniêcie lewym przyciskiem myszy
		WM_LBUTTONDOWN = &H201s 'lewy przycisk wciskamy i trzymamy wciœniêty
		WM_LBUTTONUP = &H202s '"wyciskamy" wciœniêty lewy przycisk myszki
		WM_RBUTTONDBLCLK = &H206s 'podwójne klikniêcie prawym przyciskiem myszy
		WM_RBUTTONDOWN = &H204s 'prawy przycisk wciskamy i trzymamy wciœniêty
		WM_RBUTTONUP = &H205s '"wyciskamy" wciœniêty prawy przycisk myszki
	End Enum
	'funkcja pozwalaj¹ca umieœciæ program tam gdzie ikonki
	'do ustawiania obrazu i dŸwiêku czyli w prawym dolnym
	'rogu paska Windows
	'UPGRADE_WARNING: Structure NOTIFYICONDATA may require marshalling attributes to be passed as an argument in this Declare statement. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1050"'
	Private Declare Function Shell_NotifyIcon Lib "shell32"  Alias "Shell_NotifyIconA"(ByVal dwMessage As Integer, ByRef pnid As NOTIFYICONDATA) As Boolean
	Private TrayIcon As NOTIFYICONDATA
	Private prpVisible As Boolean
	
	'UPGRADE_NOTE: Class_Initialize was upgraded to Class_Initialize_Renamed. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1061"'
	Private Sub Class_Initialize_Renamed()
		Randomize()
		
		With TrayIcon
			.cbSize = Len(TrayIcon)
			.ucallbackMessage = WM_MOUSEMOVE
			.uFlags = NIF_ICON Or NIF_TIP Or NIF_MESSAGE
			.uId = CShort(4096 * Rnd() + 1)
		End With
		
		prpVisible = False
	End Sub
	Public Sub New()
		MyBase.New()
		Class_Initialize_Renamed()
	End Sub
	'UPGRADE_NOTE: Class_Terminate was upgraded to Class_Terminate_Renamed. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1061"'
	Private Sub Class_Terminate_Renamed()
		Hide()
	End Sub
	Protected Overrides Sub Finalize()
		Class_Terminate_Renamed()
		MyBase.Finalize()
	End Sub
	
	
	Public Property hWndOwner() As Integer
		Get
			hWndOwner = TrayIcon.hwnd
		End Get
		Set(ByVal Value As Integer)
			TrayIcon.hwnd = Value
		End Set
	End Property
	
	Public WriteOnly Property Icon() As System.Drawing.Image
		Set(ByVal Value As System.Drawing.Image)
			'UPGRADE_WARNING: Couldn't resolve default property of object vData. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
			TrayIcon.hIcon = CInt(Value)
		End Set
	End Property
	
	Public Property Tip() As String
		Get
			Tip = Left(TrayIcon.szTip, Len(TrayIcon.szTip) - 1)
		End Get
		Set(ByVal Value As String)
			TrayIcon.szTip = Value & Chr(0)
		End Set
	End Property
	
	Public Property Visible() As Boolean
		Get
			Return prpVisible
		End Get
		Set(ByVal Value As Boolean)
			If Value = True Then
				Show()
			Else
				Hide()
			End If
			
			prpVisible = Value
		End Set
	End Property
	
	Public Sub Show()
		Shell_NotifyIcon(NIM_ADD, TrayIcon)
		prpVisible = True
	End Sub
	Public Sub Hide()
		Shell_NotifyIcon(NIM_DELETE, TrayIcon)
		prpVisible = False
	End Sub
	Public Sub Refresh()
		Shell_NotifyIcon(NIM_MODIFY, TrayIcon)
	End Sub
End Class