VERSION 5.00
Begin VB.Form frmTip 
   BorderStyle     =   3  'Fixed Dialog
   Caption         =   "Porada dnia"
   ClientHeight    =   3285
   ClientLeft      =   1200
   ClientTop       =   2640
   ClientWidth     =   8085
   Icon            =   "Tip.frx":0000
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   ScaleHeight     =   219
   ScaleMode       =   3  'Pixel
   ScaleWidth      =   539
   ShowInTaskbar   =   0   'False
   Tag             =   "TipsDialog#2"
   WhatsThisButton =   -1  'True
   WhatsThisHelp   =   -1  'True
   Begin VB.CheckBox chkLoadTipsAtStartup 
      Caption         =   "&Pokazuj porady przy starcie programu Skrzynki"
      Height          =   315
      Left            =   120
      TabIndex        =   3
      Tag             =   "TipsDialog#1"
      Top             =   2910
      Value           =   1  'Checked
      Width           =   3810
   End
   Begin VB.CommandButton cmdNextTip 
      Caption         =   "&Nastêpna"
      Height          =   375
      Left            =   6810
      TabIndex        =   2
      Tag             =   "TipsDialog#0"
      Top             =   600
      Width           =   1215
   End
   Begin VB.PictureBox Picture1 
      BackColor       =   &H00FFFFFF&
      Height          =   2715
      Left            =   120
      Picture         =   "Tip.frx":0442
      ScaleHeight     =   2655
      ScaleWidth      =   6495
      TabIndex        =   1
      Top             =   120
      Width           =   6555
      Begin VB.Label lblTipText 
         BackColor       =   &H00FFFFFF&
         Height          =   2310
         Left            =   450
         TabIndex        =   4
         Top             =   165
         Width           =   5790
      End
   End
   Begin VB.CommandButton cmdOK 
      Cancel          =   -1  'True
      Caption         =   "OK"
      Default         =   -1  'True
      Height          =   375
      Left            =   6810
      TabIndex        =   0
      Tag             =   "Buttons#0"
      Top             =   120
      Width           =   1215
   End
End
Attribute VB_Name = "frmTip"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Explicit

' The in-memory database of tips.
Dim Tips As New Collection

' Name of tips file
Const TIP_FILE = "INI\PORADY.INI"

' Index in collection of tip currently being displayed.
Dim CurrentTip As Long
Private Sub DoNextTip()

    ' Select a tip at random.
    CurrentTip = Int((Tips.Count * Rnd) + 1)
    
    ' Or, you could cycle through the Tips in order

    CurrentTip = CurrentTip + 1
    If Tips.Count < CurrentTip Then
        CurrentTip = 1
    End If
    
    ' Show it.
    frmTip.DisplayCurrentTip
    
End Sub
Function LoadTips(sFile As String) As Boolean
    Dim NextTip As String   ' Each tip read in from file.
    Dim InFile As Integer   ' Descriptor for file.
    
    ' Obtain the next free file descriptor.
    InFile = FreeFile
    
    ' Make sure a file is specified.
    If sFile = "" Then
        LoadTips = False
        Exit Function
    End If
    
    ' Make sure the file exists before trying to open it.
    If Dir(sFile) = "" Then
        LoadTips = False
        Exit Function
    End If
    
    ' Read the collection from a text file.
    Open sFile For Input As InFile
    While Not EOF(InFile)
        Line Input #InFile, NextTip
        Tips.Add NextTip
    Wend
    Close InFile

    ' Display a tip at random.
    DoNextTip
    
    LoadTips = True
    
End Function

Private Sub chkLoadTipsAtStartup_Click()
    ' save whether or not this form should be displayed at startup
    RegWartosc = RegSciezka & "\Options\Show Tips at Startup"
    RegDaneInt = chkLoadTipsAtStartup.Value
    RegObj.Set RegWartosc, RegDaneInt, RegFlush
End Sub
Private Sub cmdNextTip_Click()
    DoNextTip
End Sub
Private Sub cmdOK_Click()
    Me.Hide
End Sub
Private Sub Form_Load()
    Me.Move (Screen.Width - Me.Width) / 2, (Screen.Height - Me.Height) / 2
    
    Dim ShowAtStartup As Long
    
    ' See if we should be shown at startup
    RegWartosc = RegSciezka & "\Options\Show Tips at Startup"
    ShowAtStartup = Val(RegObj.Get(RegWartosc))
    If ShowAtStartup = 0 Then
        Me.Hide
        Exit Sub
    End If
        
    ' Set the checkbox, this will force the value to be written back out to the registry
    Me.chkLoadTipsAtStartup.Value = vbChecked
    
    ' Seed Rnd
    Randomize
    
    ' Read in the tips file and display a tip at random.
    If LoadTips(App.Path & "\" & TIP_FILE) = False Then
        lblTipText.Caption = "Plik " & TIP_FILE & " nie zosta³ znaleziony. " & vbCrLf & vbCrLf & _
           "Zainstaluj ponownie program Skrzynki."
    End If

    
End Sub

Public Sub DisplayCurrentTip()
    If Tips.Count > 0 Then
        lblTipText.Caption = Tips.Item(CurrentTip)
    End If
End Sub

