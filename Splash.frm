VERSION 5.00
Begin VB.Form frmSplash 
   BackColor       =   &H8000000A&
   BorderStyle     =   0  'None
   ClientHeight    =   3720
   ClientLeft      =   2430
   ClientTop       =   3405
   ClientWidth     =   6015
   ClipControls    =   0   'False
   ControlBox      =   0   'False
   Icon            =   "Splash.frx":0000
   KeyPreview      =   -1  'True
   LinkTopic       =   "Form2"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   ScaleHeight     =   3720
   ScaleWidth      =   6015
   ShowInTaskbar   =   0   'False
   Begin VB.Timer tmrTimer 
      Interval        =   2000
      Left            =   600
      Top             =   705
   End
   Begin VB.Image imgTitle 
      Height          =   915
      Left            =   1440
      Stretch         =   -1  'True
      Top             =   600
      Width           =   4320
   End
   Begin VB.Label lblPlatform 
      Alignment       =   1  'Right Justify
      AutoSize        =   -1  'True
      BackStyle       =   0  'Transparent
      Caption         =   "dla Windows 95/98/NT/2000/ME"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   15.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   360
      Left            =   1230
      TabIndex        =   2
      Tag             =   "SplashScreen#0"
      Top             =   2055
      Width           =   4680
   End
   Begin VB.Label lblVersion 
      Alignment       =   1  'Right Justify
      AutoSize        =   -1  'True
      BackStyle       =   0  'Transparent
      Caption         =   "Wersja"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   12
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   285
      Left            =   5130
      TabIndex        =   1
      Top             =   2445
      Width           =   780
   End
   Begin VB.Label lblCopyright 
      BackStyle       =   0  'Transparent
      Caption         =   "Copyright (c) 2000 - 2001, Karol Kuczmarski"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   255
      Left            =   2700
      TabIndex        =   0
      Top             =   3075
      Width           =   3225
   End
End
Attribute VB_Name = "frmSplash"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Explicit
Private Sub Form_KeyPress(KeyAscii As Integer)
    Unload Me
End Sub
Private Sub Form_Load()
    Me.Move (Screen.Width - Me.Width) / 2, (Screen.Height - Me.Height) / 2
    lblVersion.Caption = ZwrocCiag("SplashScreen#1") & App.Major & "." & App.Minor & "." & App.Revision

    Me.Picture = LoadResPicture(101, vbResBitmap)
    imgTitle.Picture = LoadResPicture(102, vbResBitmap)
    SetWindowPos Me.hwnd, HWND_TOPMOST, 0&, 0&, 0&, 0&, SWP_NOMOVE Or SWP_NOSIZE Or SWP_SHOWWINDOW
End Sub
Private Sub Form_Click()
    Unload Me
End Sub

Private Sub imgTitle_Click()
    Unload Me
End Sub

Private Sub tmrTimer_Timer()
    Unload Me
End Sub
