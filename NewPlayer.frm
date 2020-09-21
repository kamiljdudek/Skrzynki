VERSION 5.00
Begin VB.Form frmNewPlayer 
   BorderStyle     =   3  'Fixed Dialog
   Caption         =   "Nowy gracz"
   ClientHeight    =   2040
   ClientLeft      =   2835
   ClientTop       =   3480
   ClientWidth     =   3750
   ControlBox      =   0   'False
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   ScaleHeight     =   1205.299
   ScaleMode       =   0  'User
   ScaleWidth      =   3521.047
   ShowInTaskbar   =   0   'False
   StartUpPosition =   2  'CenterScreen
   Begin VB.TextBox txtEditBoxes 
      Height          =   345
      IMEMode         =   3  'DISABLE
      Index           =   2
      Left            =   1320
      PasswordChar    =   "*"
      TabIndex        =   6
      Top             =   960
      Width           =   2325
   End
   Begin VB.TextBox txtEditBoxes 
      Height          =   345
      IMEMode         =   3  'DISABLE
      Index           =   0
      Left            =   1320
      PasswordChar    =   "*"
      TabIndex        =   1
      Top             =   135
      Width           =   2325
   End
   Begin VB.CommandButton cmdOK 
      Caption         =   "&OK"
      Default         =   -1  'True
      Height          =   390
      Left            =   495
      TabIndex        =   4
      Tag             =   "Buttons#0"
      Top             =   1560
      Width           =   1140
   End
   Begin VB.CommandButton cmdCancel 
      Cancel          =   -1  'True
      Caption         =   "&Anuluj"
      Height          =   390
      Left            =   2100
      TabIndex        =   5
      Tag             =   "Buttons#1"
      Top             =   1560
      Width           =   1140
   End
   Begin VB.TextBox txtEditBoxes 
      Height          =   345
      IMEMode         =   3  'DISABLE
      Index           =   1
      Left            =   1320
      PasswordChar    =   "*"
      TabIndex        =   3
      Top             =   540
      Width           =   2325
   End
   Begin VB.Label lblLabels 
      Caption         =   "&Powtórz has³o:"
      Height          =   270
      Index           =   2
      Left            =   120
      TabIndex        =   7
      Top             =   1020
      Width           =   1080
   End
   Begin VB.Label lblLabels 
      Caption         =   "&Gracz:"
      Height          =   270
      Index           =   0
      Left            =   105
      TabIndex        =   0
      Top             =   180
      Width           =   1080
   End
   Begin VB.Label lblLabels 
      Caption         =   "&Has³o:"
      Height          =   270
      Index           =   1
      Left            =   105
      TabIndex        =   2
      Top             =   600
      Width           =   1080
   End
End
Attribute VB_Name = "frmNewPlayer"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Explicit

Private Sub cmdCancel_Click()
    Me.Hide
End Sub

Private Sub cmdOK_Click()
    If txtEditBoxes(1).Text <> txtEditBoxes(2).Text Then
        MsgBox "Potwierdzenie nie jest takie same jak pierwsze has³o!", vbOKCancel + vbCritical + vbApplicationModal, "Has³o"
        Exit Sub
    End If
    
    If NewPlayerFormAction = "Password" Then
        RegWartosc = RegSciezka & "\Players\" & str(PodajNumerGracza(frmOptions.lstPlayers.Text)) & "\Password"
        If Odszyfruj(RegObj.Get(RegWartosc)) = txtEditBoxes(0) Then
            RegDaneStr = Zaszyfruj(txtEditBoxes(1))
            RegObj.Set RegWartosc, RegDaneStr, RegFlush
            DaneGracza.Haslo = txtEditBoxes(1)
        Else
            MsgBox "Stare has³o nie jest prawid³owe!", vbOKCancel + vbCritical + vbApplicationModal, "B³ad w haœle"
            Exit Sub
        End If
    Else
        StworzNowyProfil txtEditBoxes(0), txtEditBoxes(1)
    End If
    
    Me.Hide
End Sub
Private Sub Form_Load()
    If NewPlayerFormAction = "Password" Then
        Me.Caption = ZwrocCiag("ChangePasswordDialog#0")
        lblLabels(0).Caption = ZwrocCiag("ChangePasswordDialog#1")
        lblLabels(1).Caption = ZwrocCiag("ChangePasswordDialog#2")
        lblLabels(2).Caption = ZwrocCiag("ChangePasswordDialog#3")
        txtEditBoxes(0).Text = frmOptions.txtPassword.Text
    Else
        Me.Caption = ZwrocCiag("NewPlayerDialog#0")
        lblLabels(0).Caption = ZwrocCiag("NewPlayerDialog#1")
        txtEditBoxes(0).PasswordChar = ""
        lblLabels(1).Caption = ZwrocCiag("NewPlayerDialog#2")
        lblLabels(2).Caption = ZwrocCiag("NewPlayerDialog#3")
    End If
End Sub
