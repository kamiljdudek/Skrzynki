VERSION 1.0 CLASS
BEGIN
  MultiUse = -1  'True
  Persistable = 0  'NotPersistable
  DataBindingBehavior = 0  'vbNone
  DataSourceBehavior  = 0  'vbNone
  MTSTransactionMode  = 0  'NotAnMTSObject
END
Attribute VB_Name = "CTrayIcon"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = True
Attribute VB_PredeclaredId = False
Attribute VB_Exposed = False
'struktura przechowuj¹ca dane o w³aœciwoœciach ikonki
'pojawiaj¹cej siê w prawym dolnym rogu paska Windows
Private Type NOTIFYICONDATA
    cbSize As Long              'rozmiar
    hwnd As Long                'uchwyt
    uId As Long                 'numer identyfikacyjny
    uFlags As Long              'flagi
    ucallbackMessage As Long    'zwracany komunikat
    hIcon As Long               'ikonka
    szTip As String * 64        'tekst podpowiedzi = 64 znaki
End Type

'sta³e
Private Const NIM_ADD = &H0         'dodawanie ikonki
Private Const NIM_MODIFY = &H1      'modyfikowanie
Private Const NIM_DELETE = &H2      'usuwanie
Private Const WM_MOUSEMOVE = &H200  'poruszanie myszk¹ nad obiektem
Private Const NIF_MESSAGE = &H1     'wiadomoœæ
Private Const NIF_ICON = &H2        'ikonka
Private Const NIF_TIP = &H4         'tekst podpowiedzi

'sta³e opisuj¹ce mo¿liwe zdarzenia
Enum TI_EVENT
    WM_LBUTTONDBLCLK = &H203  'podwójne klikniêcie lewym przyciskiem myszy
    WM_LBUTTONDOWN = &H201    'lewy przycisk wciskamy i trzymamy wciœniêty
    WM_LBUTTONUP = &H202      '"wyciskamy" wciœniêty lewy przycisk myszki
    WM_RBUTTONDBLCLK = &H206  'podwójne klikniêcie prawym przyciskiem myszy
    WM_RBUTTONDOWN = &H204    'prawy przycisk wciskamy i trzymamy wciœniêty
    WM_RBUTTONUP = &H205      '"wyciskamy" wciœniêty prawy przycisk myszki
End Enum
'funkcja pozwalaj¹ca umieœciæ program tam gdzie ikonki
'do ustawiania obrazu i dŸwiêku czyli w prawym dolnym
'rogu paska Windows
Private Declare Function Shell_NotifyIcon Lib "shell32" Alias "Shell_NotifyIconA" (ByVal dwMessage As Long, pnid As NOTIFYICONDATA) As Boolean
Private TrayIcon As NOTIFYICONDATA
Private prpVisible As Boolean

Private Sub Class_Initialize()
    Randomize
    
    With TrayIcon
        .cbSize = Len(TrayIcon)
        .ucallbackMessage = WM_MOUSEMOVE
        .uFlags = NIF_ICON Or NIF_TIP Or NIF_MESSAGE
        .uId = CInt(4096 * Rnd + 1)
    End With
    
    prpVisible = False
End Sub
Private Sub Class_Terminate()
    Hide
End Sub


Public Property Let hWndOwner(vData As Long)
    TrayIcon.hwnd = vData
End Property
Public Property Get hWndOwner() As Long
    hWndOwner = TrayIcon.hwnd
End Property

Public Property Let Icon(vData As StdPicture)
    TrayIcon.hIcon = CLng(vData)
End Property

Public Property Let Tip(vData As String)
    TrayIcon.szTip = vData & Chr$(0)
End Property
Public Property Get Tip() As String
    Tip = Left$(TrayIcon.szTip, Len(TrayIcon.szTip) - 1)
End Property

Public Property Let Visible(vData As Boolean)
    If vData = True Then
        Show
    Else
        Hide
    End If
    
    prpVisible = vData
End Property
Public Property Get Visible() As Boolean
    Visible = prpVisible
End Property

Public Sub Show()
    Shell_NotifyIcon NIM_ADD, TrayIcon
    prpVisible = True
End Sub
Public Sub Hide()
    Shell_NotifyIcon NIM_DELETE, TrayIcon
    prpVisible = False
End Sub
Public Sub Refresh()
    Shell_NotifyIcon NIM_MODIFY, TrayIcon
End Sub
