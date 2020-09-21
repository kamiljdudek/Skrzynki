VERSION 5.00
Object = "{BDC217C8-ED16-11CD-956C-0000C04E4C0A}#1.1#0"; "TABCTL32.OCX"
Begin VB.Form frmOptions 
   BorderStyle     =   3  'Fixed Dialog
   Caption         =   "Opcje"
   ClientHeight    =   5130
   ClientLeft      =   1530
   ClientTop       =   2550
   ClientWidth     =   6675
   ControlBox      =   0   'False
   KeyPreview      =   -1  'True
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   ScaleHeight     =   5130
   ScaleWidth      =   6675
   ShowInTaskbar   =   0   'False
   Tag             =   "OptionsDialog#42"
   Begin VB.CommandButton cmdApply 
      Caption         =   "&Zastosuj"
      Height          =   375
      Left            =   4005
      TabIndex        =   28
      Tag             =   "Buttons#2"
      Top             =   4680
      Width           =   1095
   End
   Begin TabDlg.SSTab tabOptions 
      Height          =   4515
      Left            =   120
      TabIndex        =   8
      Top             =   60
      Width           =   6405
      _ExtentX        =   11298
      _ExtentY        =   7964
      _Version        =   393216
      Style           =   1
      Tabs            =   5
      TabsPerRow      =   5
      TabHeight       =   520
      TabCaption(0)   =   "&Ogólne"
      TabPicture(0)   =   "Options.frx":0000
      Tab(0).ControlEnabled=   -1  'True
      Tab(0).Control(0)=   "Label3"
      Tab(0).Control(0).Enabled=   0   'False
      Tab(0).Control(1)=   "Frame2"
      Tab(0).Control(1).Enabled=   0   'False
      Tab(0).Control(2)=   "Frame1"
      Tab(0).Control(2).Enabled=   0   'False
      Tab(0).Control(3)=   "chkBeginFromArrivedLevel"
      Tab(0).Control(3).Enabled=   0   'False
      Tab(0).Control(4)=   "cmbShowInTray"
      Tab(0).Control(4).Enabled=   0   'False
      Tab(0).ControlCount=   5
      TabCaption(1)   =   "&Wygl¹d"
      TabPicture(1)   =   "Options.frx":001C
      Tab(1).ControlEnabled=   0   'False
      Tab(1).Control(0)=   "Frame3"
      Tab(1).Control(0).Enabled=   0   'False
      Tab(1).Control(1)=   "Frame5"
      Tab(1).Control(1).Enabled=   0   'False
      Tab(1).ControlCount=   2
      TabCaption(2)   =   "&Gracze"
      TabPicture(2)   =   "Options.frx":0038
      Tab(2).ControlEnabled=   0   'False
      Tab(2).Control(0)=   "Frame7"
      Tab(2).Control(1)=   "Frame8"
      Tab(2).Control(2)=   "Frame9"
      Tab(2).Control(3)=   "chkFirstPlayerAutoLogon"
      Tab(2).ControlCount=   4
      TabCaption(3)   =   "&Muzyka"
      TabPicture(3)   =   "Options.frx":0054
      Tab(3).ControlEnabled=   0   'False
      Tab(3).Control(0)=   "Frame6"
      Tab(3).Control(1)=   "chkPlayMusic"
      Tab(3).ControlCount=   2
      TabCaption(4)   =   "&Jêzyk"
      TabPicture(4)   =   "Options.frx":0070
      Tab(4).ControlEnabled=   0   'False
      Tab(4).Control(0)=   "Frame10"
      Tab(4).Control(0).Enabled=   0   'False
      Tab(4).ControlCount=   1
      Begin VB.Frame Frame10 
         Height          =   3750
         Left            =   -74865
         TabIndex        =   60
         Top             =   450
         Width           =   6135
         Begin VB.ListBox lstLanguages 
            Height          =   3375
            Left            =   1845
            Sorted          =   -1  'True
            TabIndex        =   61
            Top             =   225
            Width           =   2490
         End
      End
      Begin VB.CheckBox chkFirstPlayerAutoLogon 
         Caption         =   "&Automatycznie loguj pierwszego gracza, je¿eli jest on jedynym"
         Height          =   255
         Left            =   -74820
         TabIndex        =   59
         Tag             =   "OptionsDialog#35#First Player Auto Logon"
         Top             =   4110
         Width           =   5955
      End
      Begin VB.Frame Frame9 
         Caption         =   "Ustawienia"
         Height          =   1335
         Left            =   -72600
         TabIndex        =   52
         Tag             =   "OptionsDialog#29"
         Top             =   2700
         Width           =   3735
         Begin VB.CommandButton cmdChangePassword 
            Caption         =   "Zmieñ &has³o..."
            Height          =   435
            Left            =   2040
            TabIndex        =   56
            Tag             =   "OptionsDialog#34"
            Top             =   780
            Width           =   1575
         End
         Begin VB.TextBox txtPassword 
            Height          =   315
            IMEMode         =   3  'DISABLE
            Left            =   1440
            PasswordChar    =   "*"
            TabIndex        =   55
            Top             =   300
            Width           =   2175
         End
         Begin VB.CommandButton cmdChangePlayerID 
            Caption         =   "Zmieñ &imiê..."
            Height          =   435
            Left            =   180
            TabIndex        =   53
            Tag             =   "OptionsDialog#31"
            Top             =   780
            Width           =   1515
         End
         Begin VB.Label Label9 
            Caption         =   "Wpisz has³o:"
            Height          =   255
            Left            =   180
            TabIndex        =   54
            Tag             =   "OptionsDialog#30"
            Top             =   360
            Width           =   1155
         End
      End
      Begin VB.Frame Frame8 
         Caption         =   "Statystyki"
         Height          =   2055
         Left            =   -72600
         TabIndex        =   42
         Tag             =   "OptionsDialog#24"
         Top             =   510
         Width           =   3735
         Begin VB.CommandButton cmdPrevSet 
            Caption         =   "<-"
            Height          =   315
            Left            =   60
            TabIndex        =   48
            Top             =   1620
            Width           =   375
         End
         Begin VB.CommandButton cmdNextSet 
            Caption         =   "->"
            Height          =   315
            Left            =   3300
            TabIndex        =   47
            Top             =   1620
            Width           =   375
         End
         Begin VB.Label lblPushes 
            Alignment       =   1  'Right Justify
            Caption         =   "#Pchniêcia#"
            Height          =   195
            Left            =   1980
            TabIndex        =   51
            Top             =   1260
            Width           =   1635
         End
         Begin VB.Label lblMoves 
            Alignment       =   1  'Right Justify
            Caption         =   "#Ruchy#"
            Height          =   195
            Left            =   1920
            TabIndex        =   50
            Top             =   960
            Width           =   1695
         End
         Begin VB.Label lblArrivedLevel 
            Alignment       =   1  'Right Justify
            Caption         =   "#Osi¹gniêty Etap#"
            Height          =   195
            Left            =   1920
            TabIndex        =   49
            Top             =   660
            Width           =   1695
         End
         Begin VB.Label Label8 
            Caption         =   "Pchniêcia:"
            Height          =   195
            Left            =   600
            TabIndex        =   46
            Tag             =   "OptionsDialog#28"
            Top             =   1260
            Width           =   1095
         End
         Begin VB.Label Label7 
            Caption         =   "Ruchy:"
            Height          =   195
            Left            =   600
            TabIndex        =   45
            Tag             =   "OptionsDialog#27"
            Top             =   960
            Width           =   1095
         End
         Begin VB.Label Label6 
            Caption         =   "Osi¹gniêty etap:"
            Height          =   255
            Left            =   600
            TabIndex        =   44
            Tag             =   "OptionsDialog#26"
            Top             =   660
            Width           =   1155
         End
         Begin VB.Label lblLevelSet 
            Caption         =   "#Zestaw Etapów#"
            BeginProperty Font 
               Name            =   "MS Sans Serif"
               Size            =   8.25
               Charset         =   238
               Weight          =   700
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            Height          =   255
            Left            =   120
            TabIndex        =   43
            Top             =   360
            Width           =   3315
         End
      End
      Begin VB.Frame Frame7 
         Caption         =   "Lista graczy"
         Height          =   3495
         Left            =   -74820
         TabIndex        =   40
         Tag             =   "OptionsDialog#21"
         Top             =   510
         Width           =   2055
         Begin VB.CommandButton cmdDeletePlayer 
            Caption         =   "&Usuñ"
            Height          =   435
            Left            =   1080
            TabIndex        =   58
            Tag             =   "OptionsDialog#23"
            Top             =   3000
            Width           =   795
         End
         Begin VB.CommandButton cmdNewPlayer 
            Caption         =   "&Nowy..."
            Height          =   435
            Left            =   120
            TabIndex        =   57
            Tag             =   "OptionsDialog#22"
            Top             =   3000
            Width           =   795
         End
         Begin VB.ListBox lstPlayers 
            Height          =   2595
            Left            =   120
            TabIndex        =   41
            Top             =   360
            Width           =   1755
         End
      End
      Begin VB.Frame Frame6 
         Caption         =   "Lista plików muzycznych"
         Height          =   3255
         Left            =   -74760
         TabIndex        =   35
         Tag             =   "OptionsDialog#37"
         Top             =   945
         Width           =   5715
         Begin VB.CommandButton cmdUseOnlyOwnMIDI 
            Caption         =   "&Zresetuj listê plików"
            Height          =   435
            Left            =   180
            TabIndex        =   39
            Tag             =   "OptionsDialog#41"
            Top             =   2580
            Width           =   5115
         End
         Begin VB.CommandButton cmdFindMIDIAgain 
            Caption         =   "&Szukaj ponownie plików MIDI..."
            Height          =   435
            Left            =   180
            TabIndex        =   37
            Tag             =   "OptionsDialog#39"
            Top             =   840
            Width           =   5115
         End
         Begin VB.Label Label5 
            Caption         =   "Je¿eli chcesz, by odtwarzane by³y tylko pliki do³¹czone do gry, kliknij ten przycisk:"
            Height          =   435
            Left            =   180
            TabIndex        =   38
            Tag             =   "OptionsDialog#40"
            Top             =   1980
            Width           =   5115
         End
         Begin VB.Label Label4 
            Caption         =   "Mo¿esz ponownie przeprowadziæ wyszukiwanie plików MIDI klikaj¹c na ten przycisk:"
            Height          =   375
            Left            =   180
            TabIndex        =   36
            Tag             =   "OptionsDialog#38"
            Top             =   360
            Width           =   5295
         End
      End
      Begin VB.CheckBox chkPlayMusic 
         Caption         =   "&Odtwarzaj muzykê w czasie gry"
         Height          =   255
         Left            =   -74760
         TabIndex        =   34
         Tag             =   "OptionsDialog#36#Play Music"
         Top             =   525
         Width           =   5475
      End
      Begin VB.ComboBox cmbShowInTray 
         Height          =   315
         ItemData        =   "Options.frx":008C
         Left            =   2970
         List            =   "Options.frx":008E
         Style           =   2  'Dropdown List
         TabIndex        =   33
         Top             =   3885
         Width           =   2355
      End
      Begin VB.Frame Frame5 
         Caption         =   "T³o"
         Height          =   735
         Left            =   -74820
         TabIndex        =   29
         Tag             =   "OptionsDialog#17"
         Top             =   525
         Width           =   6015
         Begin VB.CommandButton cmdBackgroundColor 
            Height          =   255
            Left            =   2760
            Style           =   1  'Graphical
            TabIndex        =   30
            Top             =   300
            Width           =   1230
         End
         Begin VB.Label Label1 
            Caption         =   "Kolor t³a:"
            Height          =   255
            Left            =   1560
            TabIndex        =   31
            Tag             =   "OptionsDialog#18"
            Top             =   300
            Width           =   1035
         End
      End
      Begin VB.Frame Frame3 
         Caption         =   "Skiny"
         Height          =   2655
         Left            =   -74820
         TabIndex        =   17
         Tag             =   "OptionsDialog#19"
         Top             =   1545
         Width           =   6075
         Begin VB.Frame Frame4 
            Caption         =   "Podgl¹d"
            Height          =   1335
            Left            =   1980
            TabIndex        =   19
            Tag             =   "OptionsDialog#20"
            Top             =   660
            Width           =   3975
            Begin VB.PictureBox picPreview 
               BorderStyle     =   0  'None
               Height          =   495
               Index           =   6
               Left            =   3360
               ScaleHeight     =   33
               ScaleMode       =   3  'Pixel
               ScaleWidth      =   34
               TabIndex        =   26
               Top             =   300
               Width           =   510
            End
            Begin VB.PictureBox picPreview 
               BorderStyle     =   0  'None
               Height          =   495
               Index           =   5
               Left            =   2820
               ScaleHeight     =   33
               ScaleMode       =   3  'Pixel
               ScaleWidth      =   34
               TabIndex        =   25
               Top             =   300
               Width           =   510
            End
            Begin VB.PictureBox picPreview 
               BorderStyle     =   0  'None
               Height          =   495
               Index           =   4
               Left            =   2280
               ScaleHeight     =   33
               ScaleMode       =   3  'Pixel
               ScaleWidth      =   34
               TabIndex        =   24
               Top             =   300
               Width           =   510
            End
            Begin VB.PictureBox picPreview 
               BorderStyle     =   0  'None
               Height          =   495
               Index           =   3
               Left            =   1740
               ScaleHeight     =   33
               ScaleMode       =   3  'Pixel
               ScaleWidth      =   34
               TabIndex        =   23
               Top             =   300
               Width           =   510
            End
            Begin VB.PictureBox picPreview 
               BorderStyle     =   0  'None
               Height          =   495
               Index           =   2
               Left            =   1200
               ScaleHeight     =   33
               ScaleMode       =   3  'Pixel
               ScaleWidth      =   34
               TabIndex        =   22
               Top             =   300
               Width           =   510
            End
            Begin VB.PictureBox picPreview 
               BorderStyle     =   0  'None
               Height          =   495
               Index           =   0
               Left            =   120
               ScaleHeight     =   33
               ScaleMode       =   3  'Pixel
               ScaleWidth      =   34
               TabIndex        =   21
               Top             =   300
               Width           =   510
            End
            Begin VB.PictureBox picPreview 
               BorderStyle     =   0  'None
               Height          =   495
               Index           =   1
               Left            =   660
               ScaleHeight     =   33
               ScaleMode       =   3  'Pixel
               ScaleWidth      =   34
               TabIndex        =   20
               Top             =   300
               Width           =   510
            End
            Begin VB.Label Label2 
               Caption         =   "0          1          2          3           4         5           6"
               Height          =   255
               Left            =   300
               TabIndex        =   27
               Top             =   900
               Width           =   3375
            End
         End
         Begin VB.ListBox lstSkins 
            Height          =   2010
            Left            =   180
            Sorted          =   -1  'True
            TabIndex        =   18
            Top             =   360
            Width           =   1695
         End
      End
      Begin VB.CheckBox chkBeginFromArrivedLevel 
         Caption         =   "Przy uruchomieniu programu wyœwietlaj najdalszy dostêpny &etap"
         Height          =   285
         Left            =   210
         TabIndex        =   16
         Tag             =   "OptionsDialog#12#Begin From Arrived Level"
         Top             =   3405
         Width           =   4890
      End
      Begin VB.Frame Frame1 
         Caption         =   "Potwierdzenia"
         Height          =   1440
         Left            =   225
         TabIndex        =   12
         Tag             =   "OptionsDialog#8"
         Top             =   1845
         Width           =   5100
         Begin VB.CheckBox chkWantClosingAuthorization 
            Caption         =   "Pytaj o potwierdzenie z&akoñczenia dzia³ania programu"
            Height          =   270
            Left            =   120
            TabIndex        =   15
            Tag             =   "OptionsDialog#9#Want Closing Authorization"
            Top             =   270
            Width           =   4245
         End
         Begin VB.CheckBox chkWantLevelRestartingAuthorization 
            Caption         =   "Pytaj o potwierdzenie &restartowania aktualnego etapu"
            Height          =   270
            Left            =   120
            TabIndex        =   14
            Tag             =   "OptionsDialog#10#Want Level Restarting Authorization"
            Top             =   645
            Width           =   4155
         End
         Begin VB.CheckBox chkShowLevelLoadConfirmation 
            Caption         =   "Wyœwietlaj potwierdzenie &wczytania etapu"
            Height          =   270
            Left            =   120
            TabIndex        =   13
            Tag             =   "OptionsDialog#11#Show Level Load Confirmation"
            Top             =   1020
            Width           =   4710
         End
      End
      Begin VB.Frame Frame2 
         Caption         =   "Porady dnia i ekran tytu³owy"
         Height          =   1125
         Left            =   210
         TabIndex        =   9
         Tag             =   "OptionsDialog#5"
         Top             =   585
         Width           =   5100
         Begin VB.CheckBox chkShowTipsAtStartup 
            Caption         =   "Pokazuj &porady dnia"
            Height          =   240
            Left            =   135
            TabIndex        =   11
            Tag             =   "OptionsDialog#6#Show Tips at Startup"
            Top             =   345
            Width           =   4800
         End
         Begin VB.CheckBox chkShowSplashAtStartup 
            Caption         =   "Pokazuj ekran &tytu³owy"
            Height          =   225
            Left            =   135
            TabIndex        =   10
            Tag             =   "OptionsDialog#7#Show Splash at Startup"
            Top             =   735
            Width           =   4785
         End
      End
      Begin VB.Label Label3 
         Caption         =   "Pokazuj ikonê na pasku systemowym:"
         Height          =   255
         Left            =   210
         TabIndex        =   32
         Tag             =   "OptionsDialog#13"
         Top             =   3945
         Width           =   2715
      End
   End
   Begin VB.PictureBox picOptions 
      BorderStyle     =   0  'None
      Height          =   3780
      Index           =   3
      Left            =   -20000
      ScaleHeight     =   3780
      ScaleWidth      =   5685
      TabIndex        =   4
      TabStop         =   0   'False
      Top             =   480
      Width           =   5685
      Begin VB.Frame fraSample4 
         Caption         =   "Sample 4"
         Height          =   1785
         Left            =   2100
         TabIndex        =   7
         Top             =   840
         Width           =   2055
      End
   End
   Begin VB.PictureBox picOptions 
      BorderStyle     =   0  'None
      Height          =   3780
      Index           =   2
      Left            =   -20000
      ScaleHeight     =   3780
      ScaleWidth      =   5685
      TabIndex        =   3
      TabStop         =   0   'False
      Top             =   480
      Width           =   5685
      Begin VB.Frame fraSample3 
         Caption         =   "Sample 3"
         Height          =   1785
         Left            =   1545
         TabIndex        =   6
         Top             =   675
         Width           =   2055
      End
   End
   Begin VB.PictureBox picOptions 
      BorderStyle     =   0  'None
      Height          =   3780
      Index           =   1
      Left            =   -20000
      ScaleHeight     =   3780
      ScaleWidth      =   5685
      TabIndex        =   2
      TabStop         =   0   'False
      Top             =   480
      Width           =   5685
      Begin VB.Frame fraSample2 
         Caption         =   "Sample 2"
         Height          =   1785
         Left            =   645
         TabIndex        =   5
         Top             =   300
         Width           =   2055
      End
   End
   Begin VB.CommandButton cmdCancel 
      Cancel          =   -1  'True
      Caption         =   "&Anuluj"
      Height          =   375
      Left            =   2640
      TabIndex        =   1
      Tag             =   "Buttons#1"
      Top             =   4680
      Width           =   1095
   End
   Begin VB.CommandButton cmdOK 
      Caption         =   "&OK"
      Default         =   -1  'True
      Height          =   375
      Left            =   1260
      TabIndex        =   0
      Tag             =   "Buttons#0"
      Top             =   4680
      Width           =   1095
   End
End
Attribute VB_Name = "frmOptions"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Explicit
Dim Temp

Private Sub cmdApply_Click()
    ZapiszOpcje
    
    PrzetlumaczForme frmOptions
    PrzetlumaczForme frmMain
End Sub

Private Sub cmdBackgroundColor_Click()
    Dim Color As Long
    
    Color = cmdBackgroundColor.BackColor
    CDialog.VBChooseColor Color, , , , Me.hwnd
    If Color >= 0 Then cmdBackgroundColor.BackColor = Color
End Sub
Private Sub cmdCancel_Click()
    Unload Me
End Sub
Sub ZapiszOpcje()
    Dim ctrl As Control
    Dim Temp As Variant
    
    For Each ctrl In Me.Controls
        If TypeName(ctrl) = "CheckBox" Then
            Temp = Split(ctrl.Tag, "#")
            
            RegWartosc = RegSciezka & "\Options\" & Temp(2)
            RegDaneInt = ctrl.Value
            RegObj.Set RegWartosc, RegDaneInt, RegFlush
        End If
    Next ctrl
    WczytajListeMIDI
    GrajMidi
    
    RegWartosc = RegSciezka & "\Options\Show in Tray"
    RegDaneInt = cmbShowInTray.ListIndex
    RegObj.Set RegWartosc, RegDaneInt, RegFlush
    Select Case RegDaneInt
    Case 0: TIcon.Hide
    Case 2: If TIcon.Visible = False Then TIcon.Show
    End Select
    
    ' Wygl¹d
    '-------
    RegWartosc = RegSciezka & "\Options\Background Color"
    RegDaneInt = Val(cmdBackgroundColor.BackColor)
    RegObj.Set RegWartosc, RegDaneInt, RegFlush
    
    RegWartosc = RegSciezka & "\Options\Skin"
    RegDaneStr = lstSkins.Text
    RegObj.Set RegWartosc, RegDaneStr, RegFlush
    
    ' Jêzyk
    '------
    RegWartosc = RegSciezka & "\Options\Language"
    RegDaneStr = lstLanguages.Text
    RegObj.Set RegWartosc, RegDaneStr, RegFlush
    
    frmMain.BackColor = cmdBackgroundColor.BackColor
    OdswiezPoleGry
End Sub
Sub WczytajOpcje()
    Dim ctrl As Control
    Dim Temp As Variant
    
    cmbShowInTray.AddItem ZwrocCiag("OptionsDialog#14"), 0
    cmbShowInTray.AddItem ZwrocCiag("OptionsDialog#15"), 1
    cmbShowInTray.AddItem ZwrocCiag("OptionsDialog#16"), 2
    
    For Each ctrl In Me.Controls
        If TypeName(ctrl) = "CheckBox" Then
            Temp = Split(ctrl.Tag, "#")
            
            RegWartosc = RegSciezka & "\Options\" & Temp(2)
            If Val(RegObj.Get(RegWartosc)) = 1 Then
                ctrl.Value = vbChecked
            Else
                ctrl.Value = vbUnchecked
            End If
        End If
    Next ctrl
    
    RegWartosc = RegSciezka & "\Options\Show in Tray"
    cmbShowInTray.ListIndex = Val(RegObj.Get(RegWartosc))
                
    ' Wygl¹d
    '-------
    RegWartosc = RegSciezka & "\Options\Background Color"
    cmdBackgroundColor.BackColor = Val(RegObj.Get(RegWartosc))
    
    lstSkins.AddItem "(Oryginalny)"
    Open App.Path & "\Ini\Skiny.ini" For Input As #1
        Do Until EOF(1)
            Line Input #1, Temp
            lstSkins.AddItem Temp
        Loop
    Close #1
    RegWartosc = RegSciezka & "\Options\Skin"
    lstSkins.Text = RegObj.Get(RegWartosc)
    
    ' Jêzyk
    '------
    Open App.Path & "\Ini\Jezyki.ini" For Input As #1
        Do Until EOF(1)
            Line Input #1, Temp
            lstLanguages.AddItem Temp
        Loop
    Close #1
    RegWartosc = RegSciezka & "\Options\Language"
    lstLanguages.Text = RegObj.Get(RegWartosc)
End Sub

Private Sub cmdChangePassword_Click()
    RegWartosc = RegSciezka & "\Players\" & str(PodajNumerGracza(lstPlayers.Text)) & "\Password"
    If Odszyfruj(CStr(RegObj.Get(RegWartosc))) <> txtPassword.Text Then
        MsgBox "Stare has³o jest nieprawid³owe!", vbOKOnly + vbCritical + vbApplicationModal, "B³ad w haœle"
        Exit Sub
    End If

    NewPlayerFormAction = "Password"
    PokazForme frmNewPlayer, vbModal, frmOptions
End Sub

Private Sub cmdChangePlayerID_Click()
    RegWartosc = RegSciezka & "\Players\" & str(PodajNumerGracza(lstPlayers.Text)) & "\Password"
    If Odszyfruj(RegObj.Get(RegWartosc)) <> txtPassword.Text Then
        MsgBox ZwrocCiag("LoginDialog#4"), vbOKOnly + vbCritical + vbApplicationModal, App.Title
        Exit Sub
    End If
    
    Temp = InputBox(ZwrocCiag("OptionsDialog#33"), ZwrocCiag("OptionsDialog#32"), DaneGracza.Imie)
    If Temp <> "" Then
        DaneGracza.Imie = Temp
        RegWartosc = RegSciezka & "\Players\" & str(DaneGracza.Numer) & "\Name"
        RegObj.Set RegWartosc, DaneGracza.Imie, RegFlush
    End If
    
    WczytajListeGraczy
End Sub
Private Sub cmdDeletePlayer_Click()
    If lstPlayers.Text <> DaneGracza.Imie Then
        If MsgBox(Replace(ZwrocCiag("OptionsDialog#43"), "<player>", lstPlayers.Text), vbYesNo + vbExclamation + vbApplicationModal, App.Title) = vbYes Then
            UsunGracza PodajNumerGracza(lstPlayers.Text)
        End If
    Else
        If MsgBox(Replace(ZwrocCiag("OptionsDialog#44"), "<player>", lstPlayers.Text), vbYesNo + vbExclamation + vbApplicationModal, App.Title) = vbYes Then
            UsunGracza PodajNumerGracza(lstPlayers.Text)
            ZatrzymajMidi
            ZamknijMidi
            TIcon.Hide
            End
        End If
    End If
    
    SprawdzLiczbeGraczy
    WczytajListeGraczy
End Sub
Private Sub cmdFindMIDIAgain_Click()
    If MsgBox(ZwrocCiag("OptionsDialog#45"), vbYesNo + vbQuestion + vbApplicationModal, "Wyszukiwanie") = vbYes Then
        PokazForme frmFindMIDI, vbModal, frmOptions
    End If
End Sub

Private Sub cmdNewPlayer_Click()
    NewPlayerFormAction = "New Player"
    PokazForme frmNewPlayer, vbModal, frmOptions
    WczytajListeGraczy
End Sub

Private Sub cmdNextSet_Click()
    cmdNextSet.Enabled = False
    cmdPrevSet.Enabled = True
    WyswietlStatystyki 2
End Sub

Private Sub cmdOK_Click()
    ZapiszOpcje
    PrzetlumaczForme frmOptions
    PrzetlumaczForme frmMain
    
    Unload Me
End Sub

Private Sub cmdPrevSet_Click()
    cmdPrevSet.Enabled = False
    cmdNextSet.Enabled = True
    WyswietlStatystyki 1
End Sub

Private Sub cmdUseOnlyOwnMIDI_Click()
    If MsgBox(ZwrocCiag("OptionsDialog#46"), vbYesNo + vbExclamation + vbApplicationModal, "Reesetowanie listy plików") = vbYes Then
        PrzywrocOryginalnyINI
    End If
End Sub

Private Sub Form_Load()
    tabOptions.Tab = 0
    
    WczytajOpcje
    WyswietlPodgladSkinu
    
    SprawdzLiczbeGraczy
    WczytajListeGraczy
    
    cmdPrevSet.Enabled = False
    cmdNextSet.Enabled = True
    WyswietlStatystyki 1
    
    'center the form
    Me.Move (Screen.Width - Me.Width) / 2, (Screen.Height - Me.Height) / 2
End Sub
Sub WyswietlPodgladSkinu()
    Dim i As Integer
    
    For i = 0 To 6
        picPreview(i).Picture = LoadPicture(App.Path & "\Skiny\" & lstSkins.Text & "\" & i & ".ico")
    Next i
End Sub

Private Sub lstPlayers_Click()
    cmdPrevSet.Enabled = False
    cmdNextSet.Enabled = True
    WyswietlStatystyki 1
End Sub

Private Sub lstSkins_Click()
    WyswietlPodgladSkinu
End Sub
Public Sub WczytajListeGraczy()
    If LiczbaGraczy = 0 Then Exit Sub
    
    lstPlayers.Clear
    lstPlayers.AddItem "", 0
    For Licznik = 1 To LiczbaGraczy
        RegWartosc = RegSciezka & "\Players\" & str(Licznik) & "\Name"
        lstPlayers.AddItem CStr(RegObj.Get(RegWartosc)) 'Licznik
    Next Licznik
    lstPlayers.RemoveItem 0
    lstPlayers.Selected(0) = True
End Sub
Public Sub WyswietlStatystyki(ByVal NrZestawu As Byte)
    Select Case NrZestawu
    Case 1
        lblLevelSet.Caption = ZwrocCiag("OptionsDialog#25") & " " & UCase$(ZwrocCiag("Sets#0"))
        
        RegWartosc = RegSciezka & "\Players\" & str(PodajNumerGracza(lstPlayers.Text)) & "\Klasyczne\Arrived Level"
        lblArrivedLevel.Caption = RegObj.Get(RegWartosc)
        
        RegWartosc = RegSciezka & "\Players\" & str(PodajNumerGracza(lstPlayers.Text)) & "\Klasyczne\Moves"
        lblMoves.Caption = RegObj.Get(RegWartosc)

        RegWartosc = RegSciezka & "\Players\" & str(PodajNumerGracza(lstPlayers.Text)) & "\Klasyczne\Pushes"
        lblPushes.Caption = RegObj.Get(RegWartosc)
    Case 2
        lblLevelSet.Caption = ZwrocCiag("OptionsDialog#25") & " " & UCase$(ZwrocCiag("Sets#1"))
        
        RegWartosc = RegSciezka & "\Players\" & str(PodajNumerGracza(lstPlayers.Text)) & "\Super Trudne XS\Arrived Level"
        lblArrivedLevel.Caption = RegObj.Get(RegWartosc)
        
        RegWartosc = RegSciezka & "\Players\" & str(PodajNumerGracza(lstPlayers.Text)) & "\Super Trudne XS\Moves"
        lblMoves.Caption = RegObj.Get(RegWartosc)

        RegWartosc = RegSciezka & "\Players\" & str(PodajNumerGracza(lstPlayers.Text)) & "\Super Trudne XS\Pushes"
        lblPushes.Caption = RegObj.Get(RegWartosc)
    End Select
End Sub
