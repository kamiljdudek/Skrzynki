VERSION 5.00
Begin VB.Form frmLogin 
   BorderStyle     =   3  'Fixed Dialog
   Caption         =   "Skrzynki - logowanie"
   ClientHeight    =   2685
   ClientLeft      =   3660
   ClientTop       =   2460
   ClientWidth     =   3765
   ControlBox      =   0   'False
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   ScaleHeight     =   1586.388
   ScaleMode       =   0  'User
   ScaleWidth      =   3535.131
   ShowInTaskbar   =   0   'False
   Begin VB.TextBox txtPlayerName 
      Height          =   345
      Left            =   1320
      TabIndex        =   1
      Top             =   1275
      Width           =   2325
   End
   Begin VB.CommandButton cmdOK 
      Caption         =   "&OK"
      Default         =   -1  'True
      Height          =   390
      Left            =   480
      TabIndex        =   4
      Tag             =   "Buttons#0"
      Top             =   2160
      Width           =   1140
   End
   Begin VB.CommandButton cmdCancel 
      Cancel          =   -1  'True
      Caption         =   "&Anuluj"
      Height          =   390
      Left            =   2160
      TabIndex        =   5
      Tag             =   "Buttons#1"
      Top             =   2160
      Width           =   1140
   End
   Begin VB.TextBox txtPassword 
      Height          =   345
      IMEMode         =   3  'DISABLE
      Left            =   1320
      PasswordChar    =   "*"
      TabIndex        =   3
      Top             =   1665
      Width           =   2325
   End
   Begin VB.Label lblLabels 
      Alignment       =   2  'Center
      Caption         =   "Gra zachowuje statystyki oddzielnie dla ka¿dego gracza, którego rozpoznaje na podstawie identyfikatora."
      Height          =   615
      Index           =   4
      Left            =   120
      TabIndex        =   7
      Top             =   60
      Width           =   3495
   End
   Begin VB.Label lblLabels 
      Alignment       =   2  'Center
      Caption         =   "WprowadŸ swój identyfikator i has³o (wielkoœæ liter jest wa¿na):"
      Height          =   375
      Index           =   2
      Left            =   120
      TabIndex        =   6
      Top             =   780
      Width           =   3495
   End
   Begin VB.Label lblLabels 
      Caption         =   "Gracz:"
      Height          =   270
      Index           =   0
      Left            =   120
      TabIndex        =   0
      Top             =   1290
      Width           =   1080
   End
   Begin VB.Label lblLabels 
      Caption         =   "Has³o:"
      Height          =   270
      Index           =   1
      Left            =   120
      TabIndex        =   2
      Top             =   1680
      Width           =   1080
   End
End
Attribute VB_Name = "frmLogin"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Explicit
Private Sub cmdCancel_Click()
    End
End Sub
Private Sub cmdOK_Click()
    Dim Login As String
    Dim Password As String
    Dim PasswordChk As String
    Dim temp As String
    Dim Response As Integer
    Dim i As Integer
    Dim j As Integer
    
    For i = 0 To LiczbaGraczy
        RegWartosc = RegSciezka & "\Players\" & str(i) & "\Name"
        Login = RegObj.Get(RegWartosc)
        If txtPlayerName.Text = Login Then
            RegWartosc = RegSciezka & "\Players\" & str(i) & "\Password"
            PasswordChk = RegObj.Get(RegWartosc)
            Password = Odszyfruj(PasswordChk)
            If txtPassword.Text = Password Then
                Loguj i, Password
                Unload frmLogin
                Exit Sub
            Else
                MsgBox ZwrocCiag("LoginDialog#4"), vbOKOnly + vbCritical + vbApplicationModal, App.Title
                txtPassword.SetFocus
                SendKeys "{Home}+{End}"
                Exit Sub
            End If
        End If
    Next i
    
    Response = MsgBox(ZwrocCiag("LoginDialog#5"), vbYesNoCancel + vbExclamation + vbApplicationModal, App.Title)
    If Response = vbYes Then
        StworzNowyProfil txtPlayerName.Text, txtPassword.Text
        SprawdzLiczbeGraczy
        Loguj LiczbaGraczy, txtPassword.Text
        Unload frmLogin
    ElseIf Response = vbNo Then End
    Else: Exit Sub
    End If
End Sub
Private Sub Form_Load()
    Me.Move (Screen.Width - Me.Width) / 2, (Screen.Height - Me.Height) / 2
    SprawdzLiczbeGraczy
End Sub
