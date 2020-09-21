VERSION 5.00
Begin VB.Form frmMain 
   BorderStyle     =   1  'Fixed Single
   Caption         =   "Skrzynki"
   ClientHeight    =   7905
   ClientLeft      =   1305
   ClientTop       =   2100
   ClientWidth     =   7665
   Icon            =   "Main.frx":0000
   KeyPreview      =   -1  'True
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   ScaleHeight     =   527
   ScaleMode       =   3  'Pixel
   ScaleWidth      =   511
   Begin VB.PictureBox picStatusBar 
      Align           =   2  'Align Bottom
      BorderStyle     =   0  'None
      Height          =   255
      Left            =   0
      ScaleHeight     =   255
      ScaleWidth      =   7665
      TabIndex        =   1
      Top             =   7650
      Width           =   7665
      Begin VB.Image imgStatusImage 
         Height          =   240
         Left            =   0
         Picture         =   "Main.frx":0A02
         Top             =   0
         Width           =   240
      End
      Begin VB.Label lblPlayerName 
         Alignment       =   2  'Center
         BorderStyle     =   1  'Fixed Single
         Height          =   255
         Left            =   5580
         TabIndex        =   6
         Top             =   0
         Width           =   2055
      End
      Begin VB.Label lblLevelNumber 
         Alignment       =   2  'Center
         BorderStyle     =   1  'Fixed Single
         Height          =   255
         Left            =   4080
         TabIndex        =   5
         Top             =   0
         Width           =   1515
      End
      Begin VB.Label lblBoxes 
         Alignment       =   2  'Center
         BorderStyle     =   1  'Fixed Single
         Caption         =   "Skrzynki: ##/##"
         Height          =   255
         Left            =   2640
         TabIndex        =   4
         Top             =   0
         Width           =   1455
      End
      Begin VB.Label lblPushes 
         Alignment       =   2  'Center
         BorderStyle     =   1  'Fixed Single
         Caption         =   "Pchniêcia: ###"
         Height          =   255
         Left            =   1320
         TabIndex        =   3
         Top             =   0
         Width           =   1335
      End
      Begin VB.Label lblMoves 
         Alignment       =   2  'Center
         BorderStyle     =   1  'Fixed Single
         Caption         =   "Ruchy: ###"
         Height          =   255
         Left            =   240
         TabIndex        =   2
         Top             =   0
         Width           =   1095
      End
   End
   Begin VB.Timer tmrMIDITimer 
      Enabled         =   0   'False
      Interval        =   250
      Left            =   3840
      Top             =   3420
   End
   Begin VB.PictureBox picTrayObject 
      Height          =   495
      Left            =   3360
      ScaleHeight     =   435
      ScaleWidth      =   435
      TabIndex        =   0
      Top             =   2880
      Visible         =   0   'False
      Width           =   495
   End
   Begin VB.Image imgGameField 
      Height          =   480
      Index           =   256
      Left            =   7200
      Top             =   7200
      Width           =   480
   End
   Begin VB.Image imgGameField 
      Height          =   480
      Index           =   255
      Left            =   6720
      Top             =   7200
      Width           =   480
   End
   Begin VB.Image imgGameField 
      Height          =   480
      Index           =   254
      Left            =   6240
      Top             =   7200
      Width           =   480
   End
   Begin VB.Image imgGameField 
      Height          =   480
      Index           =   253
      Left            =   5760
      Top             =   7200
      Width           =   480
   End
   Begin VB.Image imgGameField 
      Height          =   480
      Index           =   251
      Left            =   4800
      Top             =   7200
      Width           =   480
   End
   Begin VB.Image imgGameField 
      Height          =   480
      Index           =   250
      Left            =   4320
      Top             =   7200
      Width           =   480
   End
   Begin VB.Image imgGameField 
      Height          =   480
      Index           =   249
      Left            =   3840
      Top             =   7200
      Width           =   480
   End
   Begin VB.Image imgGameField 
      Height          =   480
      Index           =   248
      Left            =   3360
      Top             =   7200
      Width           =   480
   End
   Begin VB.Image imgGameField 
      Height          =   480
      Index           =   247
      Left            =   2880
      Top             =   7200
      Width           =   480
   End
   Begin VB.Image imgGameField 
      Height          =   480
      Index           =   246
      Left            =   2400
      Top             =   7200
      Width           =   480
   End
   Begin VB.Image imgGameField 
      Height          =   480
      Index           =   245
      Left            =   1920
      Top             =   7200
      Width           =   480
   End
   Begin VB.Image imgGameField 
      Height          =   480
      Index           =   244
      Left            =   1440
      Top             =   7200
      Width           =   480
   End
   Begin VB.Image imgGameField 
      Height          =   480
      Index           =   243
      Left            =   960
      Top             =   7200
      Width           =   480
   End
   Begin VB.Image imgGameField 
      Height          =   480
      Index           =   242
      Left            =   480
      Top             =   7200
      Width           =   480
   End
   Begin VB.Image imgGameField 
      Height          =   480
      Index           =   241
      Left            =   0
      Top             =   7200
      Width           =   480
   End
   Begin VB.Image imgGameField 
      Height          =   480
      Index           =   240
      Left            =   7200
      Top             =   6720
      Width           =   480
   End
   Begin VB.Image imgGameField 
      Height          =   480
      Index           =   239
      Left            =   6720
      Top             =   6720
      Width           =   480
   End
   Begin VB.Image imgGameField 
      Height          =   480
      Index           =   238
      Left            =   6240
      Top             =   6720
      Width           =   480
   End
   Begin VB.Image imgGameField 
      Height          =   480
      Index           =   237
      Left            =   5760
      Top             =   6720
      Width           =   480
   End
   Begin VB.Image imgGameField 
      Height          =   480
      Index           =   236
      Left            =   5280
      Top             =   6720
      Width           =   480
   End
   Begin VB.Image imgGameField 
      Height          =   480
      Index           =   235
      Left            =   4800
      Top             =   6720
      Width           =   480
   End
   Begin VB.Image imgGameField 
      Height          =   480
      Index           =   252
      Left            =   5280
      Top             =   7200
      Width           =   480
   End
   Begin VB.Image imgGameField 
      Height          =   480
      Index           =   233
      Left            =   3840
      Top             =   6720
      Width           =   480
   End
   Begin VB.Image imgGameField 
      Height          =   480
      Index           =   232
      Left            =   3360
      Top             =   6720
      Width           =   480
   End
   Begin VB.Image imgGameField 
      Height          =   480
      Index           =   231
      Left            =   2880
      Top             =   6720
      Width           =   480
   End
   Begin VB.Image imgGameField 
      Height          =   480
      Index           =   230
      Left            =   2400
      Top             =   6720
      Width           =   480
   End
   Begin VB.Image imgGameField 
      Height          =   480
      Index           =   229
      Left            =   1920
      Top             =   6720
      Width           =   480
   End
   Begin VB.Image imgGameField 
      Height          =   480
      Index           =   228
      Left            =   1440
      Top             =   6720
      Width           =   480
   End
   Begin VB.Image imgGameField 
      Height          =   480
      Index           =   227
      Left            =   960
      Top             =   6720
      Width           =   480
   End
   Begin VB.Image imgGameField 
      Height          =   480
      Index           =   226
      Left            =   480
      Top             =   6720
      Width           =   480
   End
   Begin VB.Image imgGameField 
      Height          =   480
      Index           =   225
      Left            =   0
      Top             =   6720
      Width           =   480
   End
   Begin VB.Image imgGameField 
      Height          =   480
      Index           =   224
      Left            =   7200
      Top             =   6240
      Width           =   480
   End
   Begin VB.Image imgGameField 
      Height          =   480
      Index           =   223
      Left            =   6720
      Top             =   6240
      Width           =   480
   End
   Begin VB.Image imgGameField 
      Height          =   480
      Index           =   222
      Left            =   6240
      Top             =   6240
      Width           =   480
   End
   Begin VB.Image imgGameField 
      Height          =   480
      Index           =   221
      Left            =   5760
      Top             =   6240
      Width           =   480
   End
   Begin VB.Image imgGameField 
      Height          =   480
      Index           =   220
      Left            =   5280
      Top             =   6240
      Width           =   480
   End
   Begin VB.Image imgGameField 
      Height          =   480
      Index           =   219
      Left            =   4800
      Top             =   6240
      Width           =   480
   End
   Begin VB.Image imgGameField 
      Height          =   480
      Index           =   218
      Left            =   4320
      Top             =   6240
      Width           =   480
   End
   Begin VB.Image imgGameField 
      Height          =   480
      Index           =   217
      Left            =   3840
      Top             =   6240
      Width           =   480
   End
   Begin VB.Image imgGameField 
      Height          =   480
      Index           =   234
      Left            =   4320
      Top             =   6720
      Width           =   480
   End
   Begin VB.Image imgGameField 
      Height          =   480
      Index           =   215
      Left            =   2880
      Top             =   6240
      Width           =   480
   End
   Begin VB.Image imgGameField 
      Height          =   480
      Index           =   214
      Left            =   2400
      Top             =   6240
      Width           =   480
   End
   Begin VB.Image imgGameField 
      Height          =   480
      Index           =   213
      Left            =   1920
      Top             =   6240
      Width           =   480
   End
   Begin VB.Image imgGameField 
      Height          =   480
      Index           =   212
      Left            =   1440
      Top             =   6240
      Width           =   480
   End
   Begin VB.Image imgGameField 
      Height          =   480
      Index           =   211
      Left            =   960
      Top             =   6240
      Width           =   480
   End
   Begin VB.Image imgGameField 
      Height          =   480
      Index           =   210
      Left            =   480
      Top             =   6240
      Width           =   480
   End
   Begin VB.Image imgGameField 
      Height          =   480
      Index           =   209
      Left            =   0
      Top             =   6240
      Width           =   480
   End
   Begin VB.Image imgGameField 
      Height          =   480
      Index           =   208
      Left            =   7200
      Top             =   5760
      Width           =   480
   End
   Begin VB.Image imgGameField 
      Height          =   480
      Index           =   207
      Left            =   6720
      Top             =   5760
      Width           =   480
   End
   Begin VB.Image imgGameField 
      Height          =   480
      Index           =   206
      Left            =   6240
      Top             =   5760
      Width           =   480
   End
   Begin VB.Image imgGameField 
      Height          =   480
      Index           =   205
      Left            =   5760
      Top             =   5760
      Width           =   480
   End
   Begin VB.Image imgGameField 
      Height          =   480
      Index           =   204
      Left            =   5280
      Top             =   5760
      Width           =   480
   End
   Begin VB.Image imgGameField 
      Height          =   480
      Index           =   203
      Left            =   4800
      Top             =   5760
      Width           =   480
   End
   Begin VB.Image imgGameField 
      Height          =   480
      Index           =   202
      Left            =   4320
      Top             =   5760
      Width           =   480
   End
   Begin VB.Image imgGameField 
      Height          =   480
      Index           =   201
      Left            =   3840
      Top             =   5760
      Width           =   480
   End
   Begin VB.Image imgGameField 
      Height          =   480
      Index           =   200
      Left            =   3360
      Top             =   5760
      Width           =   480
   End
   Begin VB.Image imgGameField 
      Height          =   480
      Index           =   199
      Left            =   2880
      Top             =   5760
      Width           =   480
   End
   Begin VB.Image imgGameField 
      Height          =   480
      Index           =   216
      Left            =   3360
      Top             =   6240
      Width           =   480
   End
   Begin VB.Image imgGameField 
      Height          =   480
      Index           =   197
      Left            =   1920
      Top             =   5760
      Width           =   480
   End
   Begin VB.Image imgGameField 
      Height          =   480
      Index           =   196
      Left            =   1440
      Top             =   5760
      Width           =   480
   End
   Begin VB.Image imgGameField 
      Height          =   480
      Index           =   195
      Left            =   960
      Top             =   5760
      Width           =   480
   End
   Begin VB.Image imgGameField 
      Height          =   480
      Index           =   194
      Left            =   480
      Top             =   5760
      Width           =   480
   End
   Begin VB.Image imgGameField 
      Height          =   480
      Index           =   193
      Left            =   0
      Top             =   5760
      Width           =   480
   End
   Begin VB.Image imgGameField 
      Height          =   480
      Index           =   192
      Left            =   7200
      Top             =   5280
      Width           =   480
   End
   Begin VB.Image imgGameField 
      Height          =   480
      Index           =   191
      Left            =   6720
      Top             =   5280
      Width           =   480
   End
   Begin VB.Image imgGameField 
      Height          =   480
      Index           =   190
      Left            =   6240
      Top             =   5280
      Width           =   480
   End
   Begin VB.Image imgGameField 
      Height          =   480
      Index           =   189
      Left            =   5760
      Top             =   5280
      Width           =   480
   End
   Begin VB.Image imgGameField 
      Height          =   480
      Index           =   188
      Left            =   5280
      Top             =   5280
      Width           =   480
   End
   Begin VB.Image imgGameField 
      Height          =   480
      Index           =   187
      Left            =   4800
      Top             =   5280
      Width           =   480
   End
   Begin VB.Image imgGameField 
      Height          =   480
      Index           =   186
      Left            =   4320
      Top             =   5280
      Width           =   480
   End
   Begin VB.Image imgGameField 
      Height          =   480
      Index           =   185
      Left            =   3840
      Top             =   5280
      Width           =   480
   End
   Begin VB.Image imgGameField 
      Height          =   480
      Index           =   184
      Left            =   3360
      Top             =   5280
      Width           =   480
   End
   Begin VB.Image imgGameField 
      Height          =   480
      Index           =   183
      Left            =   2880
      Top             =   5280
      Width           =   480
   End
   Begin VB.Image imgGameField 
      Height          =   480
      Index           =   182
      Left            =   2400
      Top             =   5280
      Width           =   480
   End
   Begin VB.Image imgGameField 
      Height          =   480
      Index           =   181
      Left            =   1920
      Top             =   5280
      Width           =   480
   End
   Begin VB.Image imgGameField 
      Height          =   480
      Index           =   198
      Left            =   2400
      Top             =   5760
      Width           =   480
   End
   Begin VB.Image imgGameField 
      Height          =   480
      Index           =   179
      Left            =   960
      Top             =   5280
      Width           =   480
   End
   Begin VB.Image imgGameField 
      Height          =   480
      Index           =   178
      Left            =   480
      Top             =   5280
      Width           =   480
   End
   Begin VB.Image imgGameField 
      Height          =   480
      Index           =   177
      Left            =   0
      Top             =   5280
      Width           =   480
   End
   Begin VB.Image imgGameField 
      Height          =   480
      Index           =   176
      Left            =   7200
      Top             =   4800
      Width           =   480
   End
   Begin VB.Image imgGameField 
      Height          =   480
      Index           =   175
      Left            =   6720
      Top             =   4800
      Width           =   480
   End
   Begin VB.Image imgGameField 
      Height          =   480
      Index           =   174
      Left            =   6240
      Top             =   4800
      Width           =   480
   End
   Begin VB.Image imgGameField 
      Height          =   480
      Index           =   173
      Left            =   5760
      Top             =   4800
      Width           =   480
   End
   Begin VB.Image imgGameField 
      Height          =   480
      Index           =   172
      Left            =   5280
      Top             =   4800
      Width           =   480
   End
   Begin VB.Image imgGameField 
      Height          =   480
      Index           =   171
      Left            =   4800
      Top             =   4800
      Width           =   480
   End
   Begin VB.Image imgGameField 
      Height          =   480
      Index           =   170
      Left            =   4320
      Top             =   4800
      Width           =   480
   End
   Begin VB.Image imgGameField 
      Height          =   480
      Index           =   169
      Left            =   3840
      Top             =   4800
      Width           =   480
   End
   Begin VB.Image imgGameField 
      Height          =   480
      Index           =   168
      Left            =   3360
      Top             =   4800
      Width           =   480
   End
   Begin VB.Image imgGameField 
      Height          =   480
      Index           =   167
      Left            =   2880
      Top             =   4800
      Width           =   480
   End
   Begin VB.Image imgGameField 
      Height          =   480
      Index           =   166
      Left            =   2400
      Top             =   4800
      Width           =   480
   End
   Begin VB.Image imgGameField 
      Height          =   480
      Index           =   165
      Left            =   1920
      Top             =   4800
      Width           =   480
   End
   Begin VB.Image imgGameField 
      Height          =   480
      Index           =   164
      Left            =   1440
      Top             =   4800
      Width           =   480
   End
   Begin VB.Image imgGameField 
      Height          =   480
      Index           =   163
      Left            =   960
      Top             =   4800
      Width           =   480
   End
   Begin VB.Image imgGameField 
      Height          =   480
      Index           =   162
      Left            =   480
      Top             =   4800
      Width           =   480
   End
   Begin VB.Image imgGameField 
      Height          =   480
      Index           =   161
      Left            =   0
      Top             =   4800
      Width           =   480
   End
   Begin VB.Image imgGameField 
      Height          =   480
      Index           =   180
      Left            =   1440
      Top             =   5280
      Width           =   480
   End
   Begin VB.Image imgGameField 
      Height          =   480
      Index           =   159
      Left            =   6720
      Top             =   4320
      Width           =   480
   End
   Begin VB.Image imgGameField 
      Height          =   480
      Index           =   158
      Left            =   6240
      Top             =   4320
      Width           =   480
   End
   Begin VB.Image imgGameField 
      Height          =   480
      Index           =   157
      Left            =   5760
      Top             =   4320
      Width           =   480
   End
   Begin VB.Image imgGameField 
      Height          =   480
      Index           =   156
      Left            =   5280
      Top             =   4320
      Width           =   480
   End
   Begin VB.Image imgGameField 
      Height          =   480
      Index           =   155
      Left            =   4800
      Top             =   4320
      Width           =   480
   End
   Begin VB.Image imgGameField 
      Height          =   480
      Index           =   154
      Left            =   4320
      Top             =   4320
      Width           =   480
   End
   Begin VB.Image imgGameField 
      Height          =   480
      Index           =   153
      Left            =   3840
      Top             =   4320
      Width           =   480
   End
   Begin VB.Image imgGameField 
      Height          =   480
      Index           =   152
      Left            =   3360
      Top             =   4320
      Width           =   480
   End
   Begin VB.Image imgGameField 
      Height          =   480
      Index           =   151
      Left            =   2880
      Top             =   4320
      Width           =   480
   End
   Begin VB.Image imgGameField 
      Height          =   480
      Index           =   150
      Left            =   2400
      Top             =   4320
      Width           =   480
   End
   Begin VB.Image imgGameField 
      Height          =   480
      Index           =   149
      Left            =   1920
      Top             =   4320
      Width           =   480
   End
   Begin VB.Image imgGameField 
      Height          =   480
      Index           =   148
      Left            =   1440
      Top             =   4320
      Width           =   480
   End
   Begin VB.Image imgGameField 
      Height          =   480
      Index           =   147
      Left            =   960
      Top             =   4320
      Width           =   480
   End
   Begin VB.Image imgGameField 
      Height          =   480
      Index           =   146
      Left            =   480
      Top             =   4320
      Width           =   480
   End
   Begin VB.Image imgGameField 
      Height          =   480
      Index           =   145
      Left            =   0
      Top             =   4320
      Width           =   480
   End
   Begin VB.Image imgGameField 
      Height          =   480
      Index           =   144
      Left            =   7200
      Top             =   3840
      Width           =   480
   End
   Begin VB.Image imgGameField 
      Height          =   480
      Index           =   143
      Left            =   6720
      Top             =   3840
      Width           =   480
   End
   Begin VB.Image imgGameField 
      Height          =   480
      Index           =   142
      Left            =   6240
      Top             =   3840
      Width           =   480
   End
   Begin VB.Image imgGameField 
      Height          =   480
      Index           =   141
      Left            =   5760
      Top             =   3840
      Width           =   480
   End
   Begin VB.Image imgGameField 
      Height          =   480
      Index           =   160
      Left            =   7200
      Top             =   4320
      Width           =   480
   End
   Begin VB.Image imgGameField 
      Height          =   480
      Index           =   140
      Left            =   5280
      Top             =   3840
      Width           =   480
   End
   Begin VB.Image imgGameField 
      Height          =   480
      Index           =   139
      Left            =   4800
      Top             =   3840
      Width           =   480
   End
   Begin VB.Image imgGameField 
      Height          =   480
      Index           =   138
      Left            =   4320
      Top             =   3840
      Width           =   480
   End
   Begin VB.Image imgGameField 
      Height          =   480
      Index           =   137
      Left            =   3840
      Top             =   3840
      Width           =   480
   End
   Begin VB.Image imgGameField 
      Height          =   480
      Index           =   136
      Left            =   3360
      Top             =   3840
      Width           =   480
   End
   Begin VB.Image imgGameField 
      Height          =   480
      Index           =   135
      Left            =   2880
      Top             =   3840
      Width           =   480
   End
   Begin VB.Image imgGameField 
      Height          =   480
      Index           =   134
      Left            =   2400
      Top             =   3840
      Width           =   480
   End
   Begin VB.Image imgGameField 
      Height          =   480
      Index           =   133
      Left            =   1920
      Top             =   3840
      Width           =   480
   End
   Begin VB.Image imgGameField 
      Height          =   480
      Index           =   132
      Left            =   1440
      Top             =   3840
      Width           =   480
   End
   Begin VB.Image imgGameField 
      Height          =   480
      Index           =   131
      Left            =   960
      Top             =   3840
      Width           =   480
   End
   Begin VB.Image imgGameField 
      Height          =   480
      Index           =   130
      Left            =   480
      Top             =   3840
      Width           =   480
   End
   Begin VB.Image imgGameField 
      Height          =   480
      Index           =   129
      Left            =   0
      Top             =   3840
      Width           =   480
   End
   Begin VB.Image imgGameField 
      Height          =   480
      Index           =   128
      Left            =   7200
      Top             =   3360
      Width           =   480
   End
   Begin VB.Image imgGameField 
      Height          =   480
      Index           =   127
      Left            =   6720
      Top             =   3360
      Width           =   480
   End
   Begin VB.Image imgGameField 
      Height          =   480
      Index           =   126
      Left            =   6240
      Top             =   3360
      Width           =   480
   End
   Begin VB.Image imgGameField 
      Height          =   480
      Index           =   125
      Left            =   5760
      Top             =   3360
      Width           =   480
   End
   Begin VB.Image imgGameField 
      Height          =   480
      Index           =   124
      Left            =   5280
      Top             =   3360
      Width           =   480
   End
   Begin VB.Image imgGameField 
      Height          =   480
      Index           =   123
      Left            =   4800
      Top             =   3360
      Width           =   480
   End
   Begin VB.Image imgGameField 
      Height          =   480
      Index           =   122
      Left            =   4320
      Top             =   3360
      Width           =   480
   End
   Begin VB.Image imgGameField 
      Height          =   480
      Index           =   121
      Left            =   3840
      Top             =   3360
      Width           =   480
   End
   Begin VB.Image imgGameField 
      Height          =   480
      Index           =   120
      Left            =   3360
      Top             =   3360
      Width           =   480
   End
   Begin VB.Image imgGameField 
      Height          =   480
      Index           =   119
      Left            =   2880
      Top             =   3360
      Width           =   480
   End
   Begin VB.Image imgGameField 
      Height          =   480
      Index           =   118
      Left            =   2400
      Top             =   3360
      Width           =   480
   End
   Begin VB.Image imgGameField 
      Height          =   480
      Index           =   117
      Left            =   1920
      Top             =   3360
      Width           =   480
   End
   Begin VB.Image imgGameField 
      Height          =   480
      Index           =   116
      Left            =   1440
      Top             =   3360
      Width           =   480
   End
   Begin VB.Image imgGameField 
      Height          =   480
      Index           =   115
      Left            =   960
      Top             =   3360
      Width           =   480
   End
   Begin VB.Image imgGameField 
      Height          =   480
      Index           =   114
      Left            =   480
      Top             =   3360
      Width           =   480
   End
   Begin VB.Image imgGameField 
      Height          =   480
      Index           =   113
      Left            =   0
      Top             =   3360
      Width           =   480
   End
   Begin VB.Image imgGameField 
      Height          =   480
      Index           =   112
      Left            =   7200
      Top             =   2880
      Width           =   480
   End
   Begin VB.Image imgGameField 
      Height          =   480
      Index           =   111
      Left            =   6720
      Top             =   2880
      Width           =   480
   End
   Begin VB.Image imgGameField 
      Height          =   480
      Index           =   110
      Left            =   6240
      Top             =   2880
      Width           =   480
   End
   Begin VB.Image imgGameField 
      Height          =   480
      Index           =   109
      Left            =   5760
      Top             =   2880
      Width           =   480
   End
   Begin VB.Image imgGameField 
      Height          =   480
      Index           =   108
      Left            =   5280
      Top             =   2880
      Width           =   480
   End
   Begin VB.Image imgGameField 
      Height          =   480
      Index           =   107
      Left            =   4800
      Top             =   2880
      Width           =   480
   End
   Begin VB.Image imgGameField 
      Height          =   480
      Index           =   106
      Left            =   4320
      Top             =   2880
      Width           =   480
   End
   Begin VB.Image imgGameField 
      Height          =   480
      Index           =   105
      Left            =   3840
      Top             =   2880
      Width           =   480
   End
   Begin VB.Image imgGameField 
      Height          =   480
      Index           =   104
      Left            =   3360
      Top             =   2880
      Width           =   480
   End
   Begin VB.Image imgGameField 
      Height          =   480
      Index           =   103
      Left            =   2880
      Top             =   2880
      Width           =   480
   End
   Begin VB.Image imgGameField 
      Height          =   480
      Index           =   102
      Left            =   2400
      Top             =   2880
      Width           =   480
   End
   Begin VB.Image imgGameField 
      Height          =   480
      Index           =   101
      Left            =   1920
      Top             =   2880
      Width           =   480
   End
   Begin VB.Image imgGameField 
      Height          =   480
      Index           =   2
      Left            =   480
      Top             =   0
      Width           =   480
   End
   Begin VB.Image imgGameField 
      Height          =   480
      Index           =   1
      Left            =   0
      Top             =   0
      Width           =   480
   End
   Begin VB.Image imgGameField 
      Height          =   480
      Index           =   3
      Left            =   960
      Top             =   0
      Width           =   480
   End
   Begin VB.Image imgGameField 
      Height          =   480
      Index           =   4
      Left            =   1440
      Top             =   0
      Width           =   480
   End
   Begin VB.Image imgGameField 
      Height          =   480
      Index           =   5
      Left            =   1920
      Top             =   0
      Width           =   480
   End
   Begin VB.Image imgGameField 
      Height          =   480
      Index           =   6
      Left            =   2400
      Top             =   0
      Width           =   480
   End
   Begin VB.Image imgGameField 
      Height          =   480
      Index           =   7
      Left            =   2880
      Top             =   0
      Width           =   480
   End
   Begin VB.Image imgGameField 
      Height          =   480
      Index           =   8
      Left            =   3360
      Top             =   0
      Width           =   480
   End
   Begin VB.Image imgGameField 
      Height          =   480
      Index           =   9
      Left            =   3840
      Top             =   0
      Width           =   480
   End
   Begin VB.Image imgGameField 
      Height          =   480
      Index           =   10
      Left            =   4320
      Top             =   0
      Width           =   480
   End
   Begin VB.Image imgGameField 
      Height          =   480
      Index           =   12
      Left            =   5280
      Top             =   0
      Width           =   480
   End
   Begin VB.Image imgGameField 
      Height          =   480
      Index           =   11
      Left            =   4800
      Top             =   0
      Width           =   480
   End
   Begin VB.Image imgGameField 
      Height          =   480
      Index           =   13
      Left            =   5760
      Top             =   0
      Width           =   480
   End
   Begin VB.Image imgGameField 
      Height          =   480
      Index           =   14
      Left            =   6240
      Top             =   0
      Width           =   480
   End
   Begin VB.Image imgGameField 
      Height          =   480
      Index           =   15
      Left            =   6720
      Top             =   0
      Width           =   480
   End
   Begin VB.Image imgGameField 
      Height          =   480
      Index           =   16
      Left            =   7200
      Top             =   0
      Width           =   480
   End
   Begin VB.Image imgGameField 
      Height          =   480
      Index           =   17
      Left            =   0
      Top             =   480
      Width           =   480
   End
   Begin VB.Image imgGameField 
      Height          =   480
      Index           =   18
      Left            =   480
      Top             =   480
      Width           =   480
   End
   Begin VB.Image imgGameField 
      Height          =   480
      Index           =   19
      Left            =   960
      Top             =   480
      Width           =   480
   End
   Begin VB.Image imgGameField 
      Height          =   480
      Index           =   20
      Left            =   1440
      Top             =   480
      Width           =   480
   End
   Begin VB.Image imgGameField 
      Height          =   480
      Index           =   22
      Left            =   2400
      Top             =   480
      Width           =   480
   End
   Begin VB.Image imgGameField 
      Height          =   480
      Index           =   21
      Left            =   1920
      Top             =   480
      Width           =   480
   End
   Begin VB.Image imgGameField 
      Height          =   480
      Index           =   23
      Left            =   2880
      Top             =   480
      Width           =   480
   End
   Begin VB.Image imgGameField 
      Height          =   480
      Index           =   24
      Left            =   3360
      Top             =   480
      Width           =   480
   End
   Begin VB.Image imgGameField 
      Height          =   480
      Index           =   25
      Left            =   3840
      Top             =   480
      Width           =   480
   End
   Begin VB.Image imgGameField 
      Height          =   480
      Index           =   26
      Left            =   4320
      Top             =   480
      Width           =   480
   End
   Begin VB.Image imgGameField 
      Height          =   480
      Index           =   27
      Left            =   4800
      Top             =   480
      Width           =   480
   End
   Begin VB.Image imgGameField 
      Height          =   480
      Index           =   28
      Left            =   5280
      Top             =   480
      Width           =   480
   End
   Begin VB.Image imgGameField 
      Height          =   480
      Index           =   29
      Left            =   5760
      Top             =   480
      Width           =   480
   End
   Begin VB.Image imgGameField 
      Height          =   480
      Index           =   30
      Left            =   6240
      Top             =   480
      Width           =   480
   End
   Begin VB.Image imgGameField 
      Height          =   480
      Index           =   32
      Left            =   7200
      Top             =   480
      Width           =   480
   End
   Begin VB.Image imgGameField 
      Height          =   480
      Index           =   31
      Left            =   6720
      Top             =   480
      Width           =   480
   End
   Begin VB.Image imgGameField 
      Height          =   480
      Index           =   33
      Left            =   0
      Top             =   960
      Width           =   480
   End
   Begin VB.Image imgGameField 
      Height          =   480
      Index           =   34
      Left            =   480
      Top             =   960
      Width           =   480
   End
   Begin VB.Image imgGameField 
      Height          =   480
      Index           =   35
      Left            =   960
      Top             =   960
      Width           =   480
   End
   Begin VB.Image imgGameField 
      Height          =   480
      Index           =   36
      Left            =   1440
      Top             =   960
      Width           =   480
   End
   Begin VB.Image imgGameField 
      Height          =   480
      Index           =   37
      Left            =   1920
      Top             =   960
      Width           =   480
   End
   Begin VB.Image imgGameField 
      Height          =   480
      Index           =   38
      Left            =   2400
      Top             =   960
      Width           =   480
   End
   Begin VB.Image imgGameField 
      Height          =   480
      Index           =   39
      Left            =   2880
      Top             =   960
      Width           =   480
   End
   Begin VB.Image imgGameField 
      Height          =   480
      Index           =   40
      Left            =   3360
      Top             =   960
      Width           =   480
   End
   Begin VB.Image imgGameField 
      Height          =   480
      Index           =   50
      Left            =   480
      Top             =   1440
      Width           =   480
   End
   Begin VB.Image imgGameField 
      Height          =   480
      Index           =   49
      Left            =   0
      Top             =   1440
      Width           =   480
   End
   Begin VB.Image imgGameField 
      Height          =   480
      Index           =   48
      Left            =   7200
      Top             =   960
      Width           =   480
   End
   Begin VB.Image imgGameField 
      Height          =   480
      Index           =   47
      Left            =   6720
      Top             =   960
      Width           =   480
   End
   Begin VB.Image imgGameField 
      Height          =   480
      Index           =   46
      Left            =   6240
      Top             =   960
      Width           =   480
   End
   Begin VB.Image imgGameField 
      Height          =   480
      Index           =   45
      Left            =   5760
      Top             =   960
      Width           =   480
   End
   Begin VB.Image imgGameField 
      Height          =   480
      Index           =   44
      Left            =   5280
      Top             =   960
      Width           =   480
   End
   Begin VB.Image imgGameField 
      Height          =   480
      Index           =   43
      Left            =   4800
      Top             =   960
      Width           =   480
   End
   Begin VB.Image imgGameField 
      Height          =   480
      Index           =   41
      Left            =   3840
      Top             =   960
      Width           =   480
   End
   Begin VB.Image imgGameField 
      Height          =   480
      Index           =   42
      Left            =   4320
      Top             =   960
      Width           =   480
   End
   Begin VB.Image imgGameField 
      Height          =   480
      Index           =   90
      Left            =   4320
      Top             =   2400
      Width           =   480
   End
   Begin VB.Image imgGameField 
      Height          =   480
      Index           =   89
      Left            =   3840
      Top             =   2400
      Width           =   480
   End
   Begin VB.Image imgGameField 
      Height          =   480
      Index           =   88
      Left            =   3360
      Top             =   2400
      Width           =   480
   End
   Begin VB.Image imgGameField 
      Height          =   480
      Index           =   87
      Left            =   2880
      Top             =   2400
      Width           =   480
   End
   Begin VB.Image imgGameField 
      Height          =   480
      Index           =   86
      Left            =   2400
      Top             =   2400
      Width           =   480
   End
   Begin VB.Image imgGameField 
      Height          =   480
      Index           =   85
      Left            =   1920
      Top             =   2400
      Width           =   480
   End
   Begin VB.Image imgGameField 
      Height          =   480
      Index           =   84
      Left            =   1440
      Top             =   2400
      Width           =   480
   End
   Begin VB.Image imgGameField 
      Height          =   480
      Index           =   83
      Left            =   960
      Top             =   2400
      Width           =   480
   End
   Begin VB.Image imgGameField 
      Height          =   480
      Index           =   81
      Left            =   0
      Top             =   2400
      Width           =   480
   End
   Begin VB.Image imgGameField 
      Height          =   480
      Index           =   82
      Left            =   480
      Top             =   2400
      Width           =   480
   End
   Begin VB.Image imgGameField 
      Height          =   480
      Index           =   80
      Left            =   7200
      Top             =   1920
      Width           =   480
   End
   Begin VB.Image imgGameField 
      Height          =   480
      Index           =   79
      Left            =   6720
      Top             =   1920
      Width           =   480
   End
   Begin VB.Image imgGameField 
      Height          =   480
      Index           =   78
      Left            =   6240
      Top             =   1920
      Width           =   480
   End
   Begin VB.Image imgGameField 
      Height          =   480
      Index           =   77
      Left            =   5760
      Top             =   1920
      Width           =   480
   End
   Begin VB.Image imgGameField 
      Height          =   480
      Index           =   76
      Left            =   5280
      Top             =   1920
      Width           =   480
   End
   Begin VB.Image imgGameField 
      Height          =   480
      Index           =   75
      Left            =   4800
      Top             =   1920
      Width           =   480
   End
   Begin VB.Image imgGameField 
      Height          =   480
      Index           =   74
      Left            =   4320
      Top             =   1920
      Width           =   480
   End
   Begin VB.Image imgGameField 
      Height          =   480
      Index           =   73
      Left            =   3840
      Top             =   1920
      Width           =   480
   End
   Begin VB.Image imgGameField 
      Height          =   480
      Index           =   71
      Left            =   2880
      Top             =   1920
      Width           =   480
   End
   Begin VB.Image imgGameField 
      Height          =   480
      Index           =   72
      Left            =   3360
      Top             =   1920
      Width           =   480
   End
   Begin VB.Image imgGameField 
      Height          =   480
      Index           =   70
      Left            =   2400
      Top             =   1920
      Width           =   480
   End
   Begin VB.Image imgGameField 
      Height          =   480
      Index           =   69
      Left            =   1920
      Top             =   1920
      Width           =   480
   End
   Begin VB.Image imgGameField 
      Height          =   480
      Index           =   68
      Left            =   1440
      Top             =   1920
      Width           =   480
   End
   Begin VB.Image imgGameField 
      Height          =   480
      Index           =   67
      Left            =   960
      Top             =   1920
      Width           =   480
   End
   Begin VB.Image imgGameField 
      Height          =   480
      Index           =   66
      Left            =   480
      Top             =   1920
      Width           =   480
   End
   Begin VB.Image imgGameField 
      Height          =   480
      Index           =   65
      Left            =   0
      Top             =   1920
      Width           =   480
   End
   Begin VB.Image imgGameField 
      Height          =   480
      Index           =   64
      Left            =   7200
      Top             =   1440
      Width           =   480
   End
   Begin VB.Image imgGameField 
      Height          =   480
      Index           =   63
      Left            =   6720
      Top             =   1440
      Width           =   480
   End
   Begin VB.Image imgGameField 
      Height          =   480
      Index           =   61
      Left            =   5760
      Top             =   1440
      Width           =   480
   End
   Begin VB.Image imgGameField 
      Height          =   480
      Index           =   62
      Left            =   6240
      Top             =   1440
      Width           =   480
   End
   Begin VB.Image imgGameField 
      Height          =   480
      Index           =   60
      Left            =   5280
      Top             =   1440
      Width           =   480
   End
   Begin VB.Image imgGameField 
      Height          =   480
      Index           =   59
      Left            =   4800
      Top             =   1440
      Width           =   480
   End
   Begin VB.Image imgGameField 
      Height          =   480
      Index           =   58
      Left            =   4320
      Top             =   1440
      Width           =   480
   End
   Begin VB.Image imgGameField 
      Height          =   480
      Index           =   57
      Left            =   3840
      Top             =   1440
      Width           =   480
   End
   Begin VB.Image imgGameField 
      Height          =   480
      Index           =   56
      Left            =   3360
      Top             =   1440
      Width           =   480
   End
   Begin VB.Image imgGameField 
      Height          =   480
      Index           =   55
      Left            =   2880
      Top             =   1440
      Width           =   480
   End
   Begin VB.Image imgGameField 
      Height          =   480
      Index           =   54
      Left            =   2400
      Top             =   1440
      Width           =   480
   End
   Begin VB.Image imgGameField 
      Height          =   480
      Index           =   53
      Left            =   1920
      Top             =   1440
      Width           =   480
   End
   Begin VB.Image imgGameField 
      Height          =   480
      Index           =   51
      Left            =   960
      Top             =   1440
      Width           =   480
   End
   Begin VB.Image imgGameField 
      Height          =   480
      Index           =   52
      Left            =   1440
      Top             =   1440
      Width           =   480
   End
   Begin VB.Image imgGameField 
      Height          =   480
      Index           =   100
      Left            =   1440
      Top             =   2880
      Width           =   480
   End
   Begin VB.Image imgGameField 
      Height          =   480
      Index           =   99
      Left            =   960
      Top             =   2880
      Width           =   480
   End
   Begin VB.Image imgGameField 
      Height          =   480
      Index           =   98
      Left            =   480
      Top             =   2880
      Width           =   480
   End
   Begin VB.Image imgGameField 
      Height          =   480
      Index           =   97
      Left            =   0
      Top             =   2880
      Width           =   480
   End
   Begin VB.Image imgGameField 
      Height          =   480
      Index           =   96
      Left            =   7200
      Top             =   2400
      Width           =   480
   End
   Begin VB.Image imgGameField 
      Height          =   480
      Index           =   95
      Left            =   6720
      Top             =   2400
      Width           =   480
   End
   Begin VB.Image imgGameField 
      Height          =   480
      Index           =   94
      Left            =   6240
      Top             =   2400
      Width           =   480
   End
   Begin VB.Image imgGameField 
      Height          =   480
      Index           =   93
      Left            =   5760
      Top             =   2400
      Width           =   480
   End
   Begin VB.Image imgGameField 
      Height          =   480
      Index           =   91
      Left            =   4800
      Top             =   2400
      Width           =   480
   End
   Begin VB.Image imgGameField 
      Height          =   480
      Index           =   92
      Left            =   5280
      Top             =   2400
      Width           =   480
   End
   Begin VB.Menu mnuGame 
      Caption         =   "&Gra"
      Begin VB.Menu mnuGameNew 
         Caption         =   "&Nowa gra..."
      End
      Begin VB.Menu mnuGameWarp 
         Caption         =   "Wybierz &etap..."
         Shortcut        =   {F3}
      End
      Begin VB.Menu mnuGameSet 
         Caption         =   "Wybierz &zestaw etapów"
         Begin VB.Menu mnuGameSetKlasyczne 
            Caption         =   "&Klasyczne"
         End
         Begin VB.Menu mnuGameSetSuperTrudneXS 
            Caption         =   "&Super Trudne XS"
         End
      End
      Begin VB.Menu mnuGameOpen 
         Caption         =   "&Otwórz plik etapu..."
         Shortcut        =   ^O
      End
      Begin VB.Menu mnuGameBar0 
         Caption         =   "-"
      End
      Begin VB.Menu mnuGameExit 
         Caption         =   "&Koniec"
         Shortcut        =   ^Q
      End
   End
   Begin VB.Menu mnuView 
      Caption         =   "&Widok"
      Begin VB.Menu mnuViewStatusbar 
         Caption         =   "Pasek &stanu"
         Checked         =   -1  'True
      End
      Begin VB.Menu mnuViewBar0 
         Caption         =   "-"
      End
      Begin VB.Menu mnuViewRefresh 
         Caption         =   "O&dœwie¿"
         Shortcut        =   {F9}
      End
   End
   Begin VB.Menu mnuTools 
      Caption         =   "&Narzêdzia"
      Begin VB.Menu mnuToolsUndo 
         Caption         =   "&Cofnij"
         Enabled         =   0   'False
         Shortcut        =   {DEL}
      End
      Begin VB.Menu mnuToolsRestart 
         Caption         =   "&Restartuj etap"
         Shortcut        =   ^R
      End
      Begin VB.Menu mnuToolsBar0 
         Caption         =   "-"
      End
      Begin VB.Menu mnuToolsOptions 
         Caption         =   "&Opcje..."
      End
   End
   Begin VB.Menu mnuHelp 
      Caption         =   "Pomo&c"
      Begin VB.Menu mnuHelpContents 
         Caption         =   "&Tematy Pomocy..."
         Shortcut        =   {F1}
      End
      Begin VB.Menu mnuHelpTips 
         Caption         =   "&Porada dnia..."
      End
      Begin VB.Menu mnuHelpWeb 
         Caption         =   "Skrzynki w &sieci..."
      End
      Begin VB.Menu mnuHelpBar0 
         Caption         =   "-"
      End
      Begin VB.Menu mnuHelpAbout 
         Caption         =   "Skrzynki - &informacje..."
      End
   End
End
Attribute VB_Name = "frmMain"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Dim TrayControlVar As Boolean
Private Sub Form_KeyDown(KeyCode As Integer, Shift As Integer)
    If KeyCode = Lewo Or KeyCode = Prawo Or KeyCode = Gora Or KeyCode = Dol Then
        If PrzesunGracza(KeyCode) Then
            OdswiezPoleGryWokolGracza
            Ruchy = Ruchy + 1
            
            PokazNaPaskuStanu 1, ZwrocCiag("StatusBar#0") & Ruchy
            PokazNaPaskuStanu 2, ZwrocCiag("StatusBar#1") & Pchniecia
            PokazNaPaskuStanu 3, ZwrocCiag("StatusBar#2") & Etap.SkrzynkiNaMiejscach & "/" & Etap.LiczbaSkrzynek
                        
            If WykonanoRuch = False Then
                WykonanoRuch = True
                frmMain.mnuToolsUndo.Enabled = True
            End If
            
            If Etap.SkrzynkiNaMiejscach = Etap.LiczbaSkrzynek Then NastepnyEtap
        Else
            NieMozna
        End If
    End If
End Sub
Private Sub Form_Load()
    RegWartosc = RegSciezka & "\Options\Background Color"
    frmMain.BackColor = Val(RegObj.Get(RegWartosc))
    
    RegWartosc = RegSciezka & "\Options\Show Status Bar"
    If Val(RegObj.Get(RegWartosc)) = 1 Then
        frmMain.picStatusBar.Visible = True
    Else
        frmMain.picStatusBar.Visible = False
    End If
    
    If EtapSpozaZestawu = False Then
        RegWartosc = RegSciezka & "\Options\Begin From Arrived Level"
        If Val(RegObj.Get(RegWartosc)) = 1 Then
            NowaGra (NajdalszyEtap())
        Else
            NowaGra (1)
        End If
    End If
    
    RegWartosc = RegSciezka & "\Options\Play Music"
    If Val(RegObj.Get(RegWartosc)) = 1 Then
        WczytajListeMIDI
        OtworzMidi WybierzLosowyUtwor
        DlugoscPlikuMidi = DlugoscMidi
        tmrMIDITimer.Enabled = True
        GrajMidi
    End If
    
    TrayControlVar = True
    Me.Move (Screen.Width - Me.Width) / 2, (Screen.Height - Me.Height) / 2
End Sub
Private Sub Form_Resize()
    RegWartosc = RegSciezka & "\Options\Show in Tray"
    If frmMain.WindowState = vbMinimized And _
    (Val(RegObj.Get(RegWartosc)) = 1 Or _
    Val(RegObj.Get(RegWartosc)) = 2) And _
    TrayControlVar = True Then
        frmMain.Visible = False
        TrayControlVar = False
        TIcon.Show
    End If
End Sub
Private Sub Form_Unload(Cancel As Integer)
    RegWartosc = RegSciezka & "\Options\Want Closing Authorization"
    If Val(RegObj.Get(RegWartosc)) = 1 Then
        Cancel = 1
        
        Temp3 = MsgBox(ZwrocCiag("General#2"), vbYesNo + vbQuestion + vbApplicationModal + vbDefaultButton2, App.Title)
        If Temp3 = vbYes Then
            Cancel = 0
            ZakonczGre
        End If
    Else: End
    End If
End Sub
Private Sub mnuGame_Click()
    If EtapSpozaZestawu Then
        mnuGameOpen.Enabled = False
    Else
        mnuGameOpen.Enabled = True
    End If
End Sub
Private Sub mnuGameExit_Click()
    Unload frmMain
End Sub
Private Sub mnuGameNew_Click()
    NowaGra (1)
End Sub
Private Sub mnuGameOpen_Click()
    With CDialog
        .VBGetOpenFileName NazwaPliku, , , , , True, ZwrocCiag("General#9"), 1, App.Path, ZwrocCiag("General#10"), , Me.hwnd
        
        If WczytajEtap(NazwaPliku, FreeFile()) Then
            OdswiezPoleGry
            frmMain.Caption = "Skrzynki - " & Left(Dir(NazwaPliku), Len(Dir(NazwaPliku)) - 4)
            PokazNaPaskuStanu 3, "Skrzynki: " & Etap.SkrzynkiNaMiejscach & "/" & Etap.LiczbaSkrzynek
            PokazNaPaskuStanu 4, Left(Dir(NazwaPliku), Len(Dir(NazwaPliku)) - 4)
            EtapSpozaZestawu = True
            
            RegWartosc = RegSciezka & "\Options\Show Level Load Confirmation"
            If Val(RegObj.Get(RegWartosc)) = 1 Then
                Temp3 = MsgBox(Replace(ZwrocCiag("General#6"), "<filename>", NazwaPliku), vbOKOnly + vbInformation + vbApplicationModal, App.Title)
            End If
        End If
    End With
End Sub
Private Sub mnuGameSet_Click()
    If DaneGracza.Zestaw = 1 Then
        mnuGameSetKlasyczne.Checked = True
        mnuGameSetSuperTrudneXS.Checked = False
    Else
        mnuGameSetKlasyczne.Checked = False
        mnuGameSetSuperTrudneXS.Checked = True
    End If
End Sub

Private Sub mnuGameSetKlasyczne_Click()
    NowaGra 1, 1
    DaneGracza.Zestaw = 1
    ZestawEtapow = 1
End Sub

Private Sub mnuGameSetSuperTrudneXS_Click()
    NowaGra 1, 2
    DaneGracza.Zestaw = 2
    ZestawEtapow = 2
End Sub

Private Sub mnuGameWarp_Click()
    Temp1 = InputBox(ZwrocCiag("General#12"), App.Title, NajdalszyEtap)
    
    If Temp1 = "" Then Exit Sub
    
    If IsNumeric(Temp1) = False Then
        Temp3 = MsgBox(ZwrocCiag("General#13"), vbOKOnly + vbCritical + vbApplicationModal, App.Title)
        Exit Sub
    End If
    
    If (Val(Temp1) > Val(NajdalszyEtap)) And (Temp1 <= Val(UBound(Etapy, 1))) Then
        Temp3 = MsgBox(ZwrocCiag("General#14"), vbOKOnly + vbCritical + vbApplicationModal, App.Title)
        Exit Sub
    Else
        If (Val(Temp1) > Val(UBound(Etapy, 1))) Or Val(Temp1) <= 0 Then
            Temp3 = MsgBox(ZwrocCiag("General#15"), vbOKOnly + vbCritical + vbApplicationModal, App.Title)
            Exit Sub
        End If
        
        NumerEtapu = Val(Temp1)
        For Licznik = 1 To 256
            PoleGry(Licznik) = Etapy(NumerEtapu, Licznik)
            Etap = DaneEtapow(NumerEtapu)
            PozycjaGracza = PozycjeGracza(NumerEtapu)
        Next Licznik
        
        PokazNaPaskuStanu 1, ZwrocCiag("StatusBar#0") & Ruchy
        PokazNaPaskuStanu 2, ZwrocCiag("StatusBar#1") & Pchniecia
        PokazNaPaskuStanu 3, ZwrocCiag("StatusBar#2") & Etap.SkrzynkiNaMiejscach & "/" & Etap.LiczbaSkrzynek
        PokazNaPaskuStanu 4, "#" & NumerEtapu
        frmMain.Caption = App.Title & " - #" & NumerEtapu
        OdswiezPoleGry
        EtapSpozaZestawu = False
    End If
End Sub

Private Sub mnuHelpAbout_Click()
    PokazForme frmAbout, vbModal, frmMain
End Sub

Private Sub mnuHelpContents_Click()
    On Error GoTo BladPomocy
    
    HH$ = KatalogWindows + "\hh.exe" + Chr(0)
    Plik$ = App.HelpFile + Chr(0)
    
    Temp5 = ShellExecute(frmMain.hwnd, "open", HH$, Plik$, "", 3)
    Exit Sub
    
BladPomocy:
    Temp3 = MsgBox("B³¹d nr " & Err.Number & ":" & Chr(10) & Err.Description, vbOKOnly + vbCritical + vbApplicationModal, App.Title)
End Sub
Private Sub mnuHelpTips_Click()
    RegWartosc = RegSciezka & "\Options\Show Tips at Startup"
    RegDaneInt = 1
    RegObj.Set RegWartosc, RegDaneInt, RegFlush
    
    PokazForme frmTip
End Sub
Private Sub mnuHelpWeb_Click()
    url$ = "http://www.avc-soft.prv.pl/" & Chr$(0)
    ShellExecute Me.hwnd, "open" & Chr$(0), url$, "", "", 3
End Sub
Private Sub mnuTools_Click()
    If WykonanoRuch Then mnuToolsUndo.Enabled = True Else mnuToolsUndo.Enabled = False
    If EtapSpozaZestawu = False Then mnuToolsRestart.Enabled = True Else mnuToolsRestart.Enabled = False
End Sub
Private Sub mnuToolsOptions_Click()
    PokazForme frmOptions, vbModal, frmMain
End Sub
Private Sub mnuViewRefresh_Click()
    OdswiezPoleGry
End Sub
Private Sub mnuToolsRestart_Click()
    RegWartosc = RegSciezka & "\Options\Want Level Restarting Authorization"
    If Val(RegObj.Get(RegWartosc)) = 1 Then
        Temp3 = MsgBox(ZwrocCiag("General#1"), vbYesNo + vbQuestion + vbApplicationModal, App.Title)
        If Temp3 = vbYes Then
            RestartujEtap
        End If
    Else
        RestartujEtap
    End If
End Sub
Private Sub mnuToolsUndo_Click()
    Cofnij
End Sub
Private Sub mnuView_Click()
    RegWartosc = RegSciezka & "\Options\Show Status Bar"
    If Val(RegObj.Get(RegWartosc)) = 1 Then
        mnuViewStatusbar.Checked = True
    Else
        mnuViewStatusbar.Checked = False
    End If
End Sub
Private Sub mnuViewStatusbar_Click()
    If mnuViewStatusbar.Checked Then
        mnuViewStatusbar.Checked = False
        picStatusBar.Visible = False
        
        RegWartosc = RegSciezka & "\Options\Show Status Bar"
        RegDaneInt = 0
        RegObj.Set RegWartosc, RegDaneInt, RegFlush
    Else
        mnuViewStatusbar.Checked = True
        picStatusBar.Visible = True
        
        RegWartosc = RegSciezka & "\Options\Show Status Bar"
        RegDaneInt = 1
        RegObj.Set RegWartosc, RegDaneInt, RegFlush
    End If
End Sub
Private Sub picTrayObject_MouseMove(Button As Integer, Shift As Integer, x As Single, y As Single)
    Dim Msg As Long
    Msg = x / Screen.TwipsPerPixelX
    
    Select Case Msg
    Case WM_LBUTTONDOWN
        If frmMain.Visible = False Then
            frmMain.Visible = True
            TrayControlVar = True
            frmMain.WindowState = vbNormal
            
            RegWartosc = RegSciezka & "\Options\Show in Tray"
            If Val(RegObj.Get(RegWartosc)) <> 2 Then TIcon.Hide
        End If
    End Select
End Sub
Private Sub tmrMIDITimer_Timer()
    RegWartosc = RegSciezka & "\Options\Play Music"
    If Val(RegObj.Get(RegWartosc)) = 0 Then
        tmrMIDITimer.Enabled = False
        ZatrzymajMidi
        Exit Sub
    End If
    
    If PozycjaMidi = DlugoscPlikuMidi Then
        ZatrzymajMidi
        ZamknijMidi
        OtworzMidi WybierzLosowyUtwor
        DlugoscPlikuMidi = DlugoscMidi
        GrajMidi
    End If
End Sub
