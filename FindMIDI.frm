VERSION 5.00
Begin VB.Form frmFindMIDI 
   BorderStyle     =   3  'Fixed Dialog
   Caption         =   "Wyszukiwanie..."
   ClientHeight    =   1875
   ClientLeft      =   1875
   ClientTop       =   3480
   ClientWidth     =   6585
   ControlBox      =   0   'False
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   ScaleHeight     =   1875
   ScaleWidth      =   6585
   ShowInTaskbar   =   0   'False
   Tag             =   "FindMIDIDialog#0"
   Begin VB.Timer tmrSecondTimer 
      Interval        =   10
      Left            =   5760
      Top             =   780
   End
   Begin VB.Timer tmrTimer 
      Interval        =   1000
      Left            =   5760
      Top             =   360
   End
   Begin VB.Label lblFilesFound 
      Alignment       =   2  'Center
      Height          =   255
      Left            =   420
      TabIndex        =   2
      Top             =   1500
      Width           =   5775
   End
   Begin VB.Label lblFolder 
      Alignment       =   2  'Center
      Height          =   495
      Left            =   420
      TabIndex        =   1
      Top             =   900
      Width           =   5775
   End
   Begin VB.Label Label1 
      Alignment       =   2  'Center
      Height          =   555
      Left            =   480
      TabIndex        =   0
      Top             =   240
      Width           =   5655
   End
End
Attribute VB_Name = "frmFindMIDI"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Dim i As Integer
Private Sub Form_Load()
    Label1.Caption = ZwrocCiag("FindMIDIDialog#1")
    lblFilesFound.Caption = ZwrocCiag("FindMIDIDialog#2") & "0"
    Me.Move (Screen.Width - Me.Width) / 2, (Screen.Height - Me.Height) / 2
End Sub
Private Sub tmrSecondTimer_Timer()
    lblFilesFound.Caption = ZwrocCiag("FindMIDIDialog#2") & LiczbaPlikow
End Sub
Private Sub tmrTimer_Timer()
    tmrTimer.Enabled = False
    PrzetwarzajDyski
    Unload frmFindMIDI
End Sub
