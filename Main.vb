Option Strict Off
Option Explicit On
Imports VB = Microsoft.VisualBasic
Friend Class FrmMain
    Inherits System.Windows.Forms.Form
#Region "Windows Form Designer generated code "
    Public Sub New()
        MyBase.New()
        If m_vb6FormDefInstance Is Nothing Then
            If m_InitializingDefInstance Then
                m_vb6FormDefInstance = Me
            Else
                Try
                    'For the start-up form, the first instance created is the default instance.
                    If System.Reflection.Assembly.GetExecutingAssembly.EntryPoint.DeclaringType Is Me.GetType Then
                        m_vb6FormDefInstance = Me
                    End If
                Catch
                End Try
            End If
        End If
        'This call is required by the Windows Form Designer.
        InitializeComponent()
    End Sub
    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal Disposing As Boolean)
        If Disposing Then
            If Not components Is Nothing Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(Disposing)
    End Sub
    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer
    Public ToolTip1 As System.Windows.Forms.ToolTip
    Public WithEvents ImgStatusImage As System.Windows.Forms.PictureBox
    Public WithEvents LblPlayerName As System.Windows.Forms.Label
    Public WithEvents LblLevelNumber As System.Windows.Forms.Label
    Public WithEvents LblBoxes As System.Windows.Forms.Label
    Public WithEvents LblPushes As System.Windows.Forms.Label
    Public WithEvents LblMoves As System.Windows.Forms.Label
    Public WithEvents PicStatusBar As System.Windows.Forms.Panel
    Public WithEvents _imgGameField_256 As System.Windows.Forms.PictureBox
    Public WithEvents _imgGameField_255 As System.Windows.Forms.PictureBox
    Public WithEvents _imgGameField_254 As System.Windows.Forms.PictureBox
    Public WithEvents _imgGameField_253 As System.Windows.Forms.PictureBox
    Public WithEvents _imgGameField_251 As System.Windows.Forms.PictureBox
    Public WithEvents _imgGameField_250 As System.Windows.Forms.PictureBox
    Public WithEvents _imgGameField_249 As System.Windows.Forms.PictureBox
    Public WithEvents _imgGameField_248 As System.Windows.Forms.PictureBox
    Public WithEvents _imgGameField_247 As System.Windows.Forms.PictureBox
    Public WithEvents _imgGameField_246 As System.Windows.Forms.PictureBox
    Public WithEvents _imgGameField_245 As System.Windows.Forms.PictureBox
    Public WithEvents _imgGameField_244 As System.Windows.Forms.PictureBox
    Public WithEvents _imgGameField_243 As System.Windows.Forms.PictureBox
    Public WithEvents _imgGameField_242 As System.Windows.Forms.PictureBox
    Public WithEvents _imgGameField_241 As System.Windows.Forms.PictureBox
    Public WithEvents _imgGameField_240 As System.Windows.Forms.PictureBox
    Public WithEvents _imgGameField_239 As System.Windows.Forms.PictureBox
    Public WithEvents _imgGameField_238 As System.Windows.Forms.PictureBox
    Public WithEvents _imgGameField_237 As System.Windows.Forms.PictureBox
    Public WithEvents _imgGameField_236 As System.Windows.Forms.PictureBox
    Public WithEvents _imgGameField_235 As System.Windows.Forms.PictureBox
    Public WithEvents _imgGameField_252 As System.Windows.Forms.PictureBox
    Public WithEvents _imgGameField_233 As System.Windows.Forms.PictureBox
    Public WithEvents _imgGameField_232 As System.Windows.Forms.PictureBox
    Public WithEvents _imgGameField_231 As System.Windows.Forms.PictureBox
    Public WithEvents _imgGameField_230 As System.Windows.Forms.PictureBox
    Public WithEvents _imgGameField_229 As System.Windows.Forms.PictureBox
    Public WithEvents _imgGameField_228 As System.Windows.Forms.PictureBox
    Public WithEvents _imgGameField_227 As System.Windows.Forms.PictureBox
    Public WithEvents _imgGameField_226 As System.Windows.Forms.PictureBox
    Public WithEvents _imgGameField_225 As System.Windows.Forms.PictureBox
    Public WithEvents _imgGameField_224 As System.Windows.Forms.PictureBox
    Public WithEvents _imgGameField_223 As System.Windows.Forms.PictureBox
    Public WithEvents _imgGameField_222 As System.Windows.Forms.PictureBox
    Public WithEvents _imgGameField_221 As System.Windows.Forms.PictureBox
    Public WithEvents _imgGameField_220 As System.Windows.Forms.PictureBox
    Public WithEvents _imgGameField_219 As System.Windows.Forms.PictureBox
    Public WithEvents _imgGameField_218 As System.Windows.Forms.PictureBox
    Public WithEvents _imgGameField_217 As System.Windows.Forms.PictureBox
    Public WithEvents _imgGameField_234 As System.Windows.Forms.PictureBox
    Public WithEvents _imgGameField_215 As System.Windows.Forms.PictureBox
    Public WithEvents _imgGameField_214 As System.Windows.Forms.PictureBox
    Public WithEvents _imgGameField_213 As System.Windows.Forms.PictureBox
    Public WithEvents _imgGameField_212 As System.Windows.Forms.PictureBox
    Public WithEvents _imgGameField_211 As System.Windows.Forms.PictureBox
    Public WithEvents _imgGameField_210 As System.Windows.Forms.PictureBox
    Public WithEvents _imgGameField_209 As System.Windows.Forms.PictureBox
    Public WithEvents _imgGameField_208 As System.Windows.Forms.PictureBox
    Public WithEvents _imgGameField_207 As System.Windows.Forms.PictureBox
    Public WithEvents _imgGameField_206 As System.Windows.Forms.PictureBox
    Public WithEvents _imgGameField_205 As System.Windows.Forms.PictureBox
    Public WithEvents _imgGameField_204 As System.Windows.Forms.PictureBox
    Public WithEvents _imgGameField_203 As System.Windows.Forms.PictureBox
    Public WithEvents _imgGameField_202 As System.Windows.Forms.PictureBox
    Public WithEvents _imgGameField_201 As System.Windows.Forms.PictureBox
    Public WithEvents _imgGameField_200 As System.Windows.Forms.PictureBox
    Public WithEvents _imgGameField_199 As System.Windows.Forms.PictureBox
    Public WithEvents _imgGameField_216 As System.Windows.Forms.PictureBox
    Public WithEvents _imgGameField_197 As System.Windows.Forms.PictureBox
    Public WithEvents _imgGameField_196 As System.Windows.Forms.PictureBox
    Public WithEvents _imgGameField_195 As System.Windows.Forms.PictureBox
    Public WithEvents _imgGameField_194 As System.Windows.Forms.PictureBox
    Public WithEvents _imgGameField_193 As System.Windows.Forms.PictureBox
    Public WithEvents _imgGameField_192 As System.Windows.Forms.PictureBox
    Public WithEvents _imgGameField_191 As System.Windows.Forms.PictureBox
    Public WithEvents _imgGameField_190 As System.Windows.Forms.PictureBox
    Public WithEvents _imgGameField_189 As System.Windows.Forms.PictureBox
    Public WithEvents _imgGameField_188 As System.Windows.Forms.PictureBox
    Public WithEvents _imgGameField_187 As System.Windows.Forms.PictureBox
    Public WithEvents _imgGameField_186 As System.Windows.Forms.PictureBox
    Public WithEvents _imgGameField_185 As System.Windows.Forms.PictureBox
    Public WithEvents _imgGameField_184 As System.Windows.Forms.PictureBox
    Public WithEvents _imgGameField_183 As System.Windows.Forms.PictureBox
    Public WithEvents _imgGameField_182 As System.Windows.Forms.PictureBox
    Public WithEvents _imgGameField_181 As System.Windows.Forms.PictureBox
    Public WithEvents _imgGameField_198 As System.Windows.Forms.PictureBox
    Public WithEvents _imgGameField_179 As System.Windows.Forms.PictureBox
    Public WithEvents _imgGameField_178 As System.Windows.Forms.PictureBox
    Public WithEvents _imgGameField_177 As System.Windows.Forms.PictureBox
    Public WithEvents _imgGameField_176 As System.Windows.Forms.PictureBox
    Public WithEvents _imgGameField_175 As System.Windows.Forms.PictureBox
    Public WithEvents _imgGameField_174 As System.Windows.Forms.PictureBox
    Public WithEvents _imgGameField_173 As System.Windows.Forms.PictureBox
    Public WithEvents _imgGameField_172 As System.Windows.Forms.PictureBox
    Public WithEvents _imgGameField_171 As System.Windows.Forms.PictureBox
    Public WithEvents _imgGameField_170 As System.Windows.Forms.PictureBox
    Public WithEvents _imgGameField_169 As System.Windows.Forms.PictureBox
    Public WithEvents _imgGameField_168 As System.Windows.Forms.PictureBox
    Public WithEvents _imgGameField_167 As System.Windows.Forms.PictureBox
    Public WithEvents _imgGameField_166 As System.Windows.Forms.PictureBox
    Public WithEvents _imgGameField_165 As System.Windows.Forms.PictureBox
    Public WithEvents _imgGameField_164 As System.Windows.Forms.PictureBox
    Public WithEvents _imgGameField_163 As System.Windows.Forms.PictureBox
    Public WithEvents _imgGameField_162 As System.Windows.Forms.PictureBox
    Public WithEvents _imgGameField_161 As System.Windows.Forms.PictureBox
    Public WithEvents _imgGameField_180 As System.Windows.Forms.PictureBox
    Public WithEvents _imgGameField_159 As System.Windows.Forms.PictureBox
    Public WithEvents _imgGameField_158 As System.Windows.Forms.PictureBox
    Public WithEvents _imgGameField_157 As System.Windows.Forms.PictureBox
    Public WithEvents _imgGameField_156 As System.Windows.Forms.PictureBox
    Public WithEvents _imgGameField_155 As System.Windows.Forms.PictureBox
    Public WithEvents _imgGameField_154 As System.Windows.Forms.PictureBox
    Public WithEvents _imgGameField_153 As System.Windows.Forms.PictureBox
    Public WithEvents _imgGameField_152 As System.Windows.Forms.PictureBox
    Public WithEvents _imgGameField_151 As System.Windows.Forms.PictureBox
    Public WithEvents _imgGameField_150 As System.Windows.Forms.PictureBox
    Public WithEvents _imgGameField_149 As System.Windows.Forms.PictureBox
    Public WithEvents _imgGameField_148 As System.Windows.Forms.PictureBox
    Public WithEvents _imgGameField_147 As System.Windows.Forms.PictureBox
    Public WithEvents _imgGameField_146 As System.Windows.Forms.PictureBox
    Public WithEvents _imgGameField_145 As System.Windows.Forms.PictureBox
    Public WithEvents _imgGameField_144 As System.Windows.Forms.PictureBox
    Public WithEvents _imgGameField_143 As System.Windows.Forms.PictureBox
    Public WithEvents _imgGameField_142 As System.Windows.Forms.PictureBox
    Public WithEvents _imgGameField_141 As System.Windows.Forms.PictureBox
    Public WithEvents _imgGameField_160 As System.Windows.Forms.PictureBox
    Public WithEvents _imgGameField_140 As System.Windows.Forms.PictureBox
    Public WithEvents _imgGameField_139 As System.Windows.Forms.PictureBox
    Public WithEvents _imgGameField_138 As System.Windows.Forms.PictureBox
    Public WithEvents _imgGameField_137 As System.Windows.Forms.PictureBox
    Public WithEvents _imgGameField_136 As System.Windows.Forms.PictureBox
    Public WithEvents _imgGameField_135 As System.Windows.Forms.PictureBox
    Public WithEvents _imgGameField_134 As System.Windows.Forms.PictureBox
    Public WithEvents _imgGameField_133 As System.Windows.Forms.PictureBox
    Public WithEvents _imgGameField_132 As System.Windows.Forms.PictureBox
    Public WithEvents _imgGameField_131 As System.Windows.Forms.PictureBox
    Public WithEvents _imgGameField_130 As System.Windows.Forms.PictureBox
    Public WithEvents _imgGameField_129 As System.Windows.Forms.PictureBox
    Public WithEvents _imgGameField_128 As System.Windows.Forms.PictureBox
    Public WithEvents _imgGameField_127 As System.Windows.Forms.PictureBox
    Public WithEvents _imgGameField_126 As System.Windows.Forms.PictureBox
    Public WithEvents _imgGameField_125 As System.Windows.Forms.PictureBox
    Public WithEvents _imgGameField_124 As System.Windows.Forms.PictureBox
    Public WithEvents _imgGameField_123 As System.Windows.Forms.PictureBox
    Public WithEvents _imgGameField_122 As System.Windows.Forms.PictureBox
    Public WithEvents _imgGameField_121 As System.Windows.Forms.PictureBox
    Public WithEvents _imgGameField_120 As System.Windows.Forms.PictureBox
    Public WithEvents _imgGameField_119 As System.Windows.Forms.PictureBox
    Public WithEvents _imgGameField_118 As System.Windows.Forms.PictureBox
    Public WithEvents _imgGameField_117 As System.Windows.Forms.PictureBox
    Public WithEvents _imgGameField_116 As System.Windows.Forms.PictureBox
    Public WithEvents _imgGameField_115 As System.Windows.Forms.PictureBox
    Public WithEvents _imgGameField_114 As System.Windows.Forms.PictureBox
    Public WithEvents _imgGameField_113 As System.Windows.Forms.PictureBox
    Public WithEvents _imgGameField_112 As System.Windows.Forms.PictureBox
    Public WithEvents _imgGameField_111 As System.Windows.Forms.PictureBox
    Public WithEvents _imgGameField_110 As System.Windows.Forms.PictureBox
    Public WithEvents _imgGameField_109 As System.Windows.Forms.PictureBox
    Public WithEvents _imgGameField_108 As System.Windows.Forms.PictureBox
    Public WithEvents _imgGameField_107 As System.Windows.Forms.PictureBox
    Public WithEvents _imgGameField_106 As System.Windows.Forms.PictureBox
    Public WithEvents _imgGameField_105 As System.Windows.Forms.PictureBox
    Public WithEvents _imgGameField_104 As System.Windows.Forms.PictureBox
    Public WithEvents _imgGameField_103 As System.Windows.Forms.PictureBox
    Public WithEvents _imgGameField_102 As System.Windows.Forms.PictureBox
    Public WithEvents _imgGameField_101 As System.Windows.Forms.PictureBox
    Public WithEvents _imgGameField_2 As System.Windows.Forms.PictureBox
    Public WithEvents _imgGameField_1 As System.Windows.Forms.PictureBox
    Public WithEvents _imgGameField_3 As System.Windows.Forms.PictureBox
    Public WithEvents _imgGameField_4 As System.Windows.Forms.PictureBox
    Public WithEvents _imgGameField_5 As System.Windows.Forms.PictureBox
    Public WithEvents _imgGameField_6 As System.Windows.Forms.PictureBox
    Public WithEvents _imgGameField_7 As System.Windows.Forms.PictureBox
    Public WithEvents _imgGameField_8 As System.Windows.Forms.PictureBox
    Public WithEvents _imgGameField_9 As System.Windows.Forms.PictureBox
    Public WithEvents _imgGameField_10 As System.Windows.Forms.PictureBox
    Public WithEvents _imgGameField_12 As System.Windows.Forms.PictureBox
    Public WithEvents _imgGameField_11 As System.Windows.Forms.PictureBox
    Public WithEvents _imgGameField_13 As System.Windows.Forms.PictureBox
    Public WithEvents _imgGameField_14 As System.Windows.Forms.PictureBox
    Public WithEvents _imgGameField_15 As System.Windows.Forms.PictureBox
    Public WithEvents _imgGameField_16 As System.Windows.Forms.PictureBox
    Public WithEvents _imgGameField_17 As System.Windows.Forms.PictureBox
    Public WithEvents _imgGameField_18 As System.Windows.Forms.PictureBox
    Public WithEvents _imgGameField_19 As System.Windows.Forms.PictureBox
    Public WithEvents _imgGameField_20 As System.Windows.Forms.PictureBox
    Public WithEvents _imgGameField_22 As System.Windows.Forms.PictureBox
    Public WithEvents _imgGameField_21 As System.Windows.Forms.PictureBox
    Public WithEvents _imgGameField_23 As System.Windows.Forms.PictureBox
    Public WithEvents _imgGameField_24 As System.Windows.Forms.PictureBox
    Public WithEvents _imgGameField_25 As System.Windows.Forms.PictureBox
    Public WithEvents _imgGameField_26 As System.Windows.Forms.PictureBox
    Public WithEvents _imgGameField_27 As System.Windows.Forms.PictureBox
    Public WithEvents _imgGameField_28 As System.Windows.Forms.PictureBox
    Public WithEvents _imgGameField_29 As System.Windows.Forms.PictureBox
    Public WithEvents _imgGameField_30 As System.Windows.Forms.PictureBox
    Public WithEvents _imgGameField_32 As System.Windows.Forms.PictureBox
    Public WithEvents _imgGameField_31 As System.Windows.Forms.PictureBox
    Public WithEvents _imgGameField_33 As System.Windows.Forms.PictureBox
    Public WithEvents _imgGameField_34 As System.Windows.Forms.PictureBox
    Public WithEvents _imgGameField_35 As System.Windows.Forms.PictureBox
    Public WithEvents _imgGameField_36 As System.Windows.Forms.PictureBox
    Public WithEvents _imgGameField_37 As System.Windows.Forms.PictureBox
    Public WithEvents _imgGameField_38 As System.Windows.Forms.PictureBox
    Public WithEvents _imgGameField_39 As System.Windows.Forms.PictureBox
    Public WithEvents _imgGameField_40 As System.Windows.Forms.PictureBox
    Public WithEvents _imgGameField_50 As System.Windows.Forms.PictureBox
    Public WithEvents _imgGameField_49 As System.Windows.Forms.PictureBox
    Public WithEvents _imgGameField_48 As System.Windows.Forms.PictureBox
    Public WithEvents _imgGameField_47 As System.Windows.Forms.PictureBox
    Public WithEvents _imgGameField_46 As System.Windows.Forms.PictureBox
    Public WithEvents _imgGameField_45 As System.Windows.Forms.PictureBox
    Public WithEvents _imgGameField_44 As System.Windows.Forms.PictureBox
    Public WithEvents _imgGameField_43 As System.Windows.Forms.PictureBox
    Public WithEvents _imgGameField_41 As System.Windows.Forms.PictureBox
    Public WithEvents _imgGameField_42 As System.Windows.Forms.PictureBox
    Public WithEvents _imgGameField_90 As System.Windows.Forms.PictureBox
    Public WithEvents _imgGameField_89 As System.Windows.Forms.PictureBox
    Public WithEvents _imgGameField_88 As System.Windows.Forms.PictureBox
    Public WithEvents _imgGameField_87 As System.Windows.Forms.PictureBox
    Public WithEvents _imgGameField_86 As System.Windows.Forms.PictureBox
    Public WithEvents _imgGameField_85 As System.Windows.Forms.PictureBox
    Public WithEvents _imgGameField_84 As System.Windows.Forms.PictureBox
    Public WithEvents _imgGameField_83 As System.Windows.Forms.PictureBox
    Public WithEvents _imgGameField_81 As System.Windows.Forms.PictureBox
    Public WithEvents _imgGameField_82 As System.Windows.Forms.PictureBox
    Public WithEvents _imgGameField_80 As System.Windows.Forms.PictureBox
    Public WithEvents _imgGameField_79 As System.Windows.Forms.PictureBox
    Public WithEvents _imgGameField_78 As System.Windows.Forms.PictureBox
    Public WithEvents _imgGameField_77 As System.Windows.Forms.PictureBox
    Public WithEvents _imgGameField_76 As System.Windows.Forms.PictureBox
    Public WithEvents _imgGameField_75 As System.Windows.Forms.PictureBox
    Public WithEvents _imgGameField_74 As System.Windows.Forms.PictureBox
    Public WithEvents _imgGameField_73 As System.Windows.Forms.PictureBox
    Public WithEvents _imgGameField_71 As System.Windows.Forms.PictureBox
    Public WithEvents _imgGameField_72 As System.Windows.Forms.PictureBox
    Public WithEvents _imgGameField_70 As System.Windows.Forms.PictureBox
    Public WithEvents _imgGameField_69 As System.Windows.Forms.PictureBox
    Public WithEvents _imgGameField_68 As System.Windows.Forms.PictureBox
    Public WithEvents _imgGameField_67 As System.Windows.Forms.PictureBox
    Public WithEvents _imgGameField_66 As System.Windows.Forms.PictureBox
    Public WithEvents _imgGameField_65 As System.Windows.Forms.PictureBox
    Public WithEvents _imgGameField_64 As System.Windows.Forms.PictureBox
    Public WithEvents _imgGameField_63 As System.Windows.Forms.PictureBox
    Public WithEvents _imgGameField_61 As System.Windows.Forms.PictureBox
    Public WithEvents _imgGameField_62 As System.Windows.Forms.PictureBox
    Public WithEvents _imgGameField_60 As System.Windows.Forms.PictureBox
    Public WithEvents _imgGameField_59 As System.Windows.Forms.PictureBox
    Public WithEvents _imgGameField_58 As System.Windows.Forms.PictureBox
    Public WithEvents _imgGameField_57 As System.Windows.Forms.PictureBox
    Public WithEvents _imgGameField_56 As System.Windows.Forms.PictureBox
    Public WithEvents _imgGameField_55 As System.Windows.Forms.PictureBox
    Public WithEvents _imgGameField_54 As System.Windows.Forms.PictureBox
    Public WithEvents _imgGameField_53 As System.Windows.Forms.PictureBox
    Public WithEvents _imgGameField_51 As System.Windows.Forms.PictureBox
    Public WithEvents _imgGameField_52 As System.Windows.Forms.PictureBox
    Public WithEvents _imgGameField_100 As System.Windows.Forms.PictureBox
    Public WithEvents _imgGameField_99 As System.Windows.Forms.PictureBox
    Public WithEvents _imgGameField_98 As System.Windows.Forms.PictureBox
    Public WithEvents _imgGameField_97 As System.Windows.Forms.PictureBox
    Public WithEvents _imgGameField_96 As System.Windows.Forms.PictureBox
    Public WithEvents _imgGameField_95 As System.Windows.Forms.PictureBox
    Public WithEvents _imgGameField_94 As System.Windows.Forms.PictureBox
    Public WithEvents _imgGameField_93 As System.Windows.Forms.PictureBox
    Public WithEvents _imgGameField_91 As System.Windows.Forms.PictureBox
    Public WithEvents _imgGameField_92 As System.Windows.Forms.PictureBox
    Public WithEvents imgGameField As Microsoft.VisualBasic.Compatibility.VB6.PictureBoxArray
    Public WithEvents mnuGameNew As System.Windows.Forms.MenuItem
    Public WithEvents mnuGameWarp As System.Windows.Forms.MenuItem
    Public WithEvents mnuGameSetKlasyczne As System.Windows.Forms.MenuItem
    Public WithEvents mnuGameSetSuperTrudneXS As System.Windows.Forms.MenuItem
    Public WithEvents mnuGameSet As System.Windows.Forms.MenuItem
    Public WithEvents mnuGameOpen As System.Windows.Forms.MenuItem
    Public WithEvents mnuGameBar0 As System.Windows.Forms.MenuItem
    Public WithEvents mnuGameExit As System.Windows.Forms.MenuItem
    Public WithEvents mnuGame As System.Windows.Forms.MenuItem
    Public WithEvents mnuViewBar0 As System.Windows.Forms.MenuItem
    Public WithEvents mnuViewRefresh As System.Windows.Forms.MenuItem
    Public WithEvents mnuView As System.Windows.Forms.MenuItem
    Public WithEvents mnuToolsUndo As System.Windows.Forms.MenuItem
    Public WithEvents mnuToolsRestart As System.Windows.Forms.MenuItem
    Public WithEvents mnuToolsBar0 As System.Windows.Forms.MenuItem
    Public WithEvents mnuToolsOptions As System.Windows.Forms.MenuItem
    Public WithEvents mnuTools As System.Windows.Forms.MenuItem
    Public WithEvents mnuHelpContents As System.Windows.Forms.MenuItem
    Public WithEvents mnuHelpWeb As System.Windows.Forms.MenuItem
    Public WithEvents mnuHelpBar0 As System.Windows.Forms.MenuItem
    Public WithEvents mnuHelpAbout As System.Windows.Forms.MenuItem
    Public WithEvents mnuHelp As System.Windows.Forms.MenuItem
    Public MainMenu1 As System.Windows.Forms.MainMenu
    Friend WithEvents MenuItem1 As MenuItem
    Friend WithEvents MenuItem2 As MenuItem
    Friend WithEvents MenuItem3 As MenuItem
    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMain))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.PicStatusBar = New System.Windows.Forms.Panel()
        Me.ImgStatusImage = New System.Windows.Forms.PictureBox()
        Me.LblPlayerName = New System.Windows.Forms.Label()
        Me.LblLevelNumber = New System.Windows.Forms.Label()
        Me.LblBoxes = New System.Windows.Forms.Label()
        Me.LblPushes = New System.Windows.Forms.Label()
        Me.LblMoves = New System.Windows.Forms.Label()
        Me._imgGameField_256 = New System.Windows.Forms.PictureBox()
        Me._imgGameField_255 = New System.Windows.Forms.PictureBox()
        Me._imgGameField_254 = New System.Windows.Forms.PictureBox()
        Me._imgGameField_253 = New System.Windows.Forms.PictureBox()
        Me._imgGameField_251 = New System.Windows.Forms.PictureBox()
        Me._imgGameField_250 = New System.Windows.Forms.PictureBox()
        Me._imgGameField_249 = New System.Windows.Forms.PictureBox()
        Me._imgGameField_248 = New System.Windows.Forms.PictureBox()
        Me._imgGameField_247 = New System.Windows.Forms.PictureBox()
        Me._imgGameField_246 = New System.Windows.Forms.PictureBox()
        Me._imgGameField_245 = New System.Windows.Forms.PictureBox()
        Me._imgGameField_244 = New System.Windows.Forms.PictureBox()
        Me._imgGameField_243 = New System.Windows.Forms.PictureBox()
        Me._imgGameField_242 = New System.Windows.Forms.PictureBox()
        Me._imgGameField_241 = New System.Windows.Forms.PictureBox()
        Me._imgGameField_240 = New System.Windows.Forms.PictureBox()
        Me._imgGameField_239 = New System.Windows.Forms.PictureBox()
        Me._imgGameField_238 = New System.Windows.Forms.PictureBox()
        Me._imgGameField_237 = New System.Windows.Forms.PictureBox()
        Me._imgGameField_236 = New System.Windows.Forms.PictureBox()
        Me._imgGameField_235 = New System.Windows.Forms.PictureBox()
        Me._imgGameField_252 = New System.Windows.Forms.PictureBox()
        Me._imgGameField_233 = New System.Windows.Forms.PictureBox()
        Me._imgGameField_232 = New System.Windows.Forms.PictureBox()
        Me._imgGameField_231 = New System.Windows.Forms.PictureBox()
        Me._imgGameField_230 = New System.Windows.Forms.PictureBox()
        Me._imgGameField_229 = New System.Windows.Forms.PictureBox()
        Me._imgGameField_228 = New System.Windows.Forms.PictureBox()
        Me._imgGameField_227 = New System.Windows.Forms.PictureBox()
        Me._imgGameField_226 = New System.Windows.Forms.PictureBox()
        Me._imgGameField_225 = New System.Windows.Forms.PictureBox()
        Me._imgGameField_224 = New System.Windows.Forms.PictureBox()
        Me._imgGameField_223 = New System.Windows.Forms.PictureBox()
        Me._imgGameField_222 = New System.Windows.Forms.PictureBox()
        Me._imgGameField_221 = New System.Windows.Forms.PictureBox()
        Me._imgGameField_220 = New System.Windows.Forms.PictureBox()
        Me._imgGameField_219 = New System.Windows.Forms.PictureBox()
        Me._imgGameField_218 = New System.Windows.Forms.PictureBox()
        Me._imgGameField_217 = New System.Windows.Forms.PictureBox()
        Me._imgGameField_234 = New System.Windows.Forms.PictureBox()
        Me._imgGameField_215 = New System.Windows.Forms.PictureBox()
        Me._imgGameField_214 = New System.Windows.Forms.PictureBox()
        Me._imgGameField_213 = New System.Windows.Forms.PictureBox()
        Me._imgGameField_212 = New System.Windows.Forms.PictureBox()
        Me._imgGameField_211 = New System.Windows.Forms.PictureBox()
        Me._imgGameField_210 = New System.Windows.Forms.PictureBox()
        Me._imgGameField_209 = New System.Windows.Forms.PictureBox()
        Me._imgGameField_208 = New System.Windows.Forms.PictureBox()
        Me._imgGameField_207 = New System.Windows.Forms.PictureBox()
        Me._imgGameField_206 = New System.Windows.Forms.PictureBox()
        Me._imgGameField_205 = New System.Windows.Forms.PictureBox()
        Me._imgGameField_204 = New System.Windows.Forms.PictureBox()
        Me._imgGameField_203 = New System.Windows.Forms.PictureBox()
        Me._imgGameField_202 = New System.Windows.Forms.PictureBox()
        Me._imgGameField_201 = New System.Windows.Forms.PictureBox()
        Me._imgGameField_200 = New System.Windows.Forms.PictureBox()
        Me._imgGameField_199 = New System.Windows.Forms.PictureBox()
        Me._imgGameField_216 = New System.Windows.Forms.PictureBox()
        Me._imgGameField_197 = New System.Windows.Forms.PictureBox()
        Me._imgGameField_196 = New System.Windows.Forms.PictureBox()
        Me._imgGameField_195 = New System.Windows.Forms.PictureBox()
        Me._imgGameField_194 = New System.Windows.Forms.PictureBox()
        Me._imgGameField_193 = New System.Windows.Forms.PictureBox()
        Me._imgGameField_192 = New System.Windows.Forms.PictureBox()
        Me._imgGameField_191 = New System.Windows.Forms.PictureBox()
        Me._imgGameField_190 = New System.Windows.Forms.PictureBox()
        Me._imgGameField_189 = New System.Windows.Forms.PictureBox()
        Me._imgGameField_188 = New System.Windows.Forms.PictureBox()
        Me._imgGameField_187 = New System.Windows.Forms.PictureBox()
        Me._imgGameField_186 = New System.Windows.Forms.PictureBox()
        Me._imgGameField_185 = New System.Windows.Forms.PictureBox()
        Me._imgGameField_184 = New System.Windows.Forms.PictureBox()
        Me._imgGameField_183 = New System.Windows.Forms.PictureBox()
        Me._imgGameField_182 = New System.Windows.Forms.PictureBox()
        Me._imgGameField_181 = New System.Windows.Forms.PictureBox()
        Me._imgGameField_198 = New System.Windows.Forms.PictureBox()
        Me._imgGameField_179 = New System.Windows.Forms.PictureBox()
        Me._imgGameField_178 = New System.Windows.Forms.PictureBox()
        Me._imgGameField_177 = New System.Windows.Forms.PictureBox()
        Me._imgGameField_176 = New System.Windows.Forms.PictureBox()
        Me._imgGameField_175 = New System.Windows.Forms.PictureBox()
        Me._imgGameField_174 = New System.Windows.Forms.PictureBox()
        Me._imgGameField_173 = New System.Windows.Forms.PictureBox()
        Me._imgGameField_172 = New System.Windows.Forms.PictureBox()
        Me._imgGameField_171 = New System.Windows.Forms.PictureBox()
        Me._imgGameField_170 = New System.Windows.Forms.PictureBox()
        Me._imgGameField_169 = New System.Windows.Forms.PictureBox()
        Me._imgGameField_168 = New System.Windows.Forms.PictureBox()
        Me._imgGameField_167 = New System.Windows.Forms.PictureBox()
        Me._imgGameField_166 = New System.Windows.Forms.PictureBox()
        Me._imgGameField_165 = New System.Windows.Forms.PictureBox()
        Me._imgGameField_164 = New System.Windows.Forms.PictureBox()
        Me._imgGameField_163 = New System.Windows.Forms.PictureBox()
        Me._imgGameField_162 = New System.Windows.Forms.PictureBox()
        Me._imgGameField_161 = New System.Windows.Forms.PictureBox()
        Me._imgGameField_180 = New System.Windows.Forms.PictureBox()
        Me._imgGameField_159 = New System.Windows.Forms.PictureBox()
        Me._imgGameField_158 = New System.Windows.Forms.PictureBox()
        Me._imgGameField_157 = New System.Windows.Forms.PictureBox()
        Me._imgGameField_156 = New System.Windows.Forms.PictureBox()
        Me._imgGameField_155 = New System.Windows.Forms.PictureBox()
        Me._imgGameField_154 = New System.Windows.Forms.PictureBox()
        Me._imgGameField_153 = New System.Windows.Forms.PictureBox()
        Me._imgGameField_152 = New System.Windows.Forms.PictureBox()
        Me._imgGameField_151 = New System.Windows.Forms.PictureBox()
        Me._imgGameField_150 = New System.Windows.Forms.PictureBox()
        Me._imgGameField_149 = New System.Windows.Forms.PictureBox()
        Me._imgGameField_148 = New System.Windows.Forms.PictureBox()
        Me._imgGameField_147 = New System.Windows.Forms.PictureBox()
        Me._imgGameField_146 = New System.Windows.Forms.PictureBox()
        Me._imgGameField_145 = New System.Windows.Forms.PictureBox()
        Me._imgGameField_144 = New System.Windows.Forms.PictureBox()
        Me._imgGameField_143 = New System.Windows.Forms.PictureBox()
        Me._imgGameField_142 = New System.Windows.Forms.PictureBox()
        Me._imgGameField_141 = New System.Windows.Forms.PictureBox()
        Me._imgGameField_160 = New System.Windows.Forms.PictureBox()
        Me._imgGameField_140 = New System.Windows.Forms.PictureBox()
        Me._imgGameField_139 = New System.Windows.Forms.PictureBox()
        Me._imgGameField_138 = New System.Windows.Forms.PictureBox()
        Me._imgGameField_137 = New System.Windows.Forms.PictureBox()
        Me._imgGameField_136 = New System.Windows.Forms.PictureBox()
        Me._imgGameField_135 = New System.Windows.Forms.PictureBox()
        Me._imgGameField_134 = New System.Windows.Forms.PictureBox()
        Me._imgGameField_133 = New System.Windows.Forms.PictureBox()
        Me._imgGameField_132 = New System.Windows.Forms.PictureBox()
        Me._imgGameField_131 = New System.Windows.Forms.PictureBox()
        Me._imgGameField_130 = New System.Windows.Forms.PictureBox()
        Me._imgGameField_129 = New System.Windows.Forms.PictureBox()
        Me._imgGameField_128 = New System.Windows.Forms.PictureBox()
        Me._imgGameField_127 = New System.Windows.Forms.PictureBox()
        Me._imgGameField_126 = New System.Windows.Forms.PictureBox()
        Me._imgGameField_125 = New System.Windows.Forms.PictureBox()
        Me._imgGameField_124 = New System.Windows.Forms.PictureBox()
        Me._imgGameField_123 = New System.Windows.Forms.PictureBox()
        Me._imgGameField_122 = New System.Windows.Forms.PictureBox()
        Me._imgGameField_121 = New System.Windows.Forms.PictureBox()
        Me._imgGameField_120 = New System.Windows.Forms.PictureBox()
        Me._imgGameField_119 = New System.Windows.Forms.PictureBox()
        Me._imgGameField_118 = New System.Windows.Forms.PictureBox()
        Me._imgGameField_117 = New System.Windows.Forms.PictureBox()
        Me._imgGameField_116 = New System.Windows.Forms.PictureBox()
        Me._imgGameField_115 = New System.Windows.Forms.PictureBox()
        Me._imgGameField_114 = New System.Windows.Forms.PictureBox()
        Me._imgGameField_113 = New System.Windows.Forms.PictureBox()
        Me._imgGameField_112 = New System.Windows.Forms.PictureBox()
        Me._imgGameField_111 = New System.Windows.Forms.PictureBox()
        Me._imgGameField_110 = New System.Windows.Forms.PictureBox()
        Me._imgGameField_109 = New System.Windows.Forms.PictureBox()
        Me._imgGameField_108 = New System.Windows.Forms.PictureBox()
        Me._imgGameField_107 = New System.Windows.Forms.PictureBox()
        Me._imgGameField_106 = New System.Windows.Forms.PictureBox()
        Me._imgGameField_105 = New System.Windows.Forms.PictureBox()
        Me._imgGameField_104 = New System.Windows.Forms.PictureBox()
        Me._imgGameField_103 = New System.Windows.Forms.PictureBox()
        Me._imgGameField_102 = New System.Windows.Forms.PictureBox()
        Me._imgGameField_101 = New System.Windows.Forms.PictureBox()
        Me._imgGameField_2 = New System.Windows.Forms.PictureBox()
        Me._imgGameField_1 = New System.Windows.Forms.PictureBox()
        Me._imgGameField_3 = New System.Windows.Forms.PictureBox()
        Me._imgGameField_4 = New System.Windows.Forms.PictureBox()
        Me._imgGameField_5 = New System.Windows.Forms.PictureBox()
        Me._imgGameField_6 = New System.Windows.Forms.PictureBox()
        Me._imgGameField_7 = New System.Windows.Forms.PictureBox()
        Me._imgGameField_8 = New System.Windows.Forms.PictureBox()
        Me._imgGameField_9 = New System.Windows.Forms.PictureBox()
        Me._imgGameField_10 = New System.Windows.Forms.PictureBox()
        Me._imgGameField_12 = New System.Windows.Forms.PictureBox()
        Me._imgGameField_11 = New System.Windows.Forms.PictureBox()
        Me._imgGameField_13 = New System.Windows.Forms.PictureBox()
        Me._imgGameField_14 = New System.Windows.Forms.PictureBox()
        Me._imgGameField_15 = New System.Windows.Forms.PictureBox()
        Me._imgGameField_16 = New System.Windows.Forms.PictureBox()
        Me._imgGameField_17 = New System.Windows.Forms.PictureBox()
        Me._imgGameField_18 = New System.Windows.Forms.PictureBox()
        Me._imgGameField_19 = New System.Windows.Forms.PictureBox()
        Me._imgGameField_20 = New System.Windows.Forms.PictureBox()
        Me._imgGameField_22 = New System.Windows.Forms.PictureBox()
        Me._imgGameField_21 = New System.Windows.Forms.PictureBox()
        Me._imgGameField_23 = New System.Windows.Forms.PictureBox()
        Me._imgGameField_24 = New System.Windows.Forms.PictureBox()
        Me._imgGameField_25 = New System.Windows.Forms.PictureBox()
        Me._imgGameField_26 = New System.Windows.Forms.PictureBox()
        Me._imgGameField_27 = New System.Windows.Forms.PictureBox()
        Me._imgGameField_28 = New System.Windows.Forms.PictureBox()
        Me._imgGameField_29 = New System.Windows.Forms.PictureBox()
        Me._imgGameField_30 = New System.Windows.Forms.PictureBox()
        Me._imgGameField_32 = New System.Windows.Forms.PictureBox()
        Me._imgGameField_31 = New System.Windows.Forms.PictureBox()
        Me._imgGameField_33 = New System.Windows.Forms.PictureBox()
        Me._imgGameField_34 = New System.Windows.Forms.PictureBox()
        Me._imgGameField_35 = New System.Windows.Forms.PictureBox()
        Me._imgGameField_36 = New System.Windows.Forms.PictureBox()
        Me._imgGameField_37 = New System.Windows.Forms.PictureBox()
        Me._imgGameField_38 = New System.Windows.Forms.PictureBox()
        Me._imgGameField_39 = New System.Windows.Forms.PictureBox()
        Me._imgGameField_40 = New System.Windows.Forms.PictureBox()
        Me._imgGameField_50 = New System.Windows.Forms.PictureBox()
        Me._imgGameField_49 = New System.Windows.Forms.PictureBox()
        Me._imgGameField_48 = New System.Windows.Forms.PictureBox()
        Me._imgGameField_47 = New System.Windows.Forms.PictureBox()
        Me._imgGameField_46 = New System.Windows.Forms.PictureBox()
        Me._imgGameField_45 = New System.Windows.Forms.PictureBox()
        Me._imgGameField_44 = New System.Windows.Forms.PictureBox()
        Me._imgGameField_43 = New System.Windows.Forms.PictureBox()
        Me._imgGameField_41 = New System.Windows.Forms.PictureBox()
        Me._imgGameField_42 = New System.Windows.Forms.PictureBox()
        Me._imgGameField_90 = New System.Windows.Forms.PictureBox()
        Me._imgGameField_89 = New System.Windows.Forms.PictureBox()
        Me._imgGameField_88 = New System.Windows.Forms.PictureBox()
        Me._imgGameField_87 = New System.Windows.Forms.PictureBox()
        Me._imgGameField_86 = New System.Windows.Forms.PictureBox()
        Me._imgGameField_85 = New System.Windows.Forms.PictureBox()
        Me._imgGameField_84 = New System.Windows.Forms.PictureBox()
        Me._imgGameField_83 = New System.Windows.Forms.PictureBox()
        Me._imgGameField_81 = New System.Windows.Forms.PictureBox()
        Me._imgGameField_82 = New System.Windows.Forms.PictureBox()
        Me._imgGameField_80 = New System.Windows.Forms.PictureBox()
        Me._imgGameField_79 = New System.Windows.Forms.PictureBox()
        Me._imgGameField_78 = New System.Windows.Forms.PictureBox()
        Me._imgGameField_77 = New System.Windows.Forms.PictureBox()
        Me._imgGameField_76 = New System.Windows.Forms.PictureBox()
        Me._imgGameField_75 = New System.Windows.Forms.PictureBox()
        Me._imgGameField_74 = New System.Windows.Forms.PictureBox()
        Me._imgGameField_73 = New System.Windows.Forms.PictureBox()
        Me._imgGameField_71 = New System.Windows.Forms.PictureBox()
        Me._imgGameField_72 = New System.Windows.Forms.PictureBox()
        Me._imgGameField_70 = New System.Windows.Forms.PictureBox()
        Me._imgGameField_69 = New System.Windows.Forms.PictureBox()
        Me._imgGameField_68 = New System.Windows.Forms.PictureBox()
        Me._imgGameField_67 = New System.Windows.Forms.PictureBox()
        Me._imgGameField_66 = New System.Windows.Forms.PictureBox()
        Me._imgGameField_65 = New System.Windows.Forms.PictureBox()
        Me._imgGameField_64 = New System.Windows.Forms.PictureBox()
        Me._imgGameField_63 = New System.Windows.Forms.PictureBox()
        Me._imgGameField_61 = New System.Windows.Forms.PictureBox()
        Me._imgGameField_62 = New System.Windows.Forms.PictureBox()
        Me._imgGameField_60 = New System.Windows.Forms.PictureBox()
        Me._imgGameField_59 = New System.Windows.Forms.PictureBox()
        Me._imgGameField_58 = New System.Windows.Forms.PictureBox()
        Me._imgGameField_57 = New System.Windows.Forms.PictureBox()
        Me._imgGameField_56 = New System.Windows.Forms.PictureBox()
        Me._imgGameField_55 = New System.Windows.Forms.PictureBox()
        Me._imgGameField_54 = New System.Windows.Forms.PictureBox()
        Me._imgGameField_53 = New System.Windows.Forms.PictureBox()
        Me._imgGameField_51 = New System.Windows.Forms.PictureBox()
        Me._imgGameField_52 = New System.Windows.Forms.PictureBox()
        Me._imgGameField_100 = New System.Windows.Forms.PictureBox()
        Me._imgGameField_99 = New System.Windows.Forms.PictureBox()
        Me._imgGameField_98 = New System.Windows.Forms.PictureBox()
        Me._imgGameField_97 = New System.Windows.Forms.PictureBox()
        Me._imgGameField_96 = New System.Windows.Forms.PictureBox()
        Me._imgGameField_95 = New System.Windows.Forms.PictureBox()
        Me._imgGameField_94 = New System.Windows.Forms.PictureBox()
        Me._imgGameField_93 = New System.Windows.Forms.PictureBox()
        Me._imgGameField_91 = New System.Windows.Forms.PictureBox()
        Me._imgGameField_92 = New System.Windows.Forms.PictureBox()
        Me.imgGameField = New Microsoft.VisualBasic.Compatibility.VB6.PictureBoxArray(Me.components)
        Me.MainMenu1 = New System.Windows.Forms.MainMenu(Me.components)
        Me.mnuGame = New System.Windows.Forms.MenuItem()
        Me.mnuGameNew = New System.Windows.Forms.MenuItem()
        Me.mnuGameWarp = New System.Windows.Forms.MenuItem()
        Me.mnuGameSet = New System.Windows.Forms.MenuItem()
        Me.mnuGameSetKlasyczne = New System.Windows.Forms.MenuItem()
        Me.mnuGameSetSuperTrudneXS = New System.Windows.Forms.MenuItem()
        Me.mnuGameOpen = New System.Windows.Forms.MenuItem()
        Me.mnuGameBar0 = New System.Windows.Forms.MenuItem()
        Me.mnuGameExit = New System.Windows.Forms.MenuItem()
        Me.mnuView = New System.Windows.Forms.MenuItem()
        Me.MenuItem1 = New System.Windows.Forms.MenuItem()
        Me.MenuItem2 = New System.Windows.Forms.MenuItem()
        Me.mnuViewBar0 = New System.Windows.Forms.MenuItem()
        Me.mnuViewRefresh = New System.Windows.Forms.MenuItem()
        Me.MenuItem3 = New System.Windows.Forms.MenuItem()
        Me.mnuTools = New System.Windows.Forms.MenuItem()
        Me.mnuToolsUndo = New System.Windows.Forms.MenuItem()
        Me.mnuToolsRestart = New System.Windows.Forms.MenuItem()
        Me.mnuToolsBar0 = New System.Windows.Forms.MenuItem()
        Me.mnuToolsOptions = New System.Windows.Forms.MenuItem()
        Me.mnuHelp = New System.Windows.Forms.MenuItem()
        Me.mnuHelpContents = New System.Windows.Forms.MenuItem()
        Me.mnuHelpWeb = New System.Windows.Forms.MenuItem()
        Me.mnuHelpBar0 = New System.Windows.Forms.MenuItem()
        Me.mnuHelpAbout = New System.Windows.Forms.MenuItem()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.PicStatusBar.SuspendLayout()
        CType(Me.ImgStatusImage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._imgGameField_256, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._imgGameField_255, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._imgGameField_254, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._imgGameField_253, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._imgGameField_251, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._imgGameField_250, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._imgGameField_249, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._imgGameField_248, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._imgGameField_247, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._imgGameField_246, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._imgGameField_245, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._imgGameField_244, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._imgGameField_243, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._imgGameField_242, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._imgGameField_241, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._imgGameField_240, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._imgGameField_239, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._imgGameField_238, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._imgGameField_237, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._imgGameField_236, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._imgGameField_235, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._imgGameField_252, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._imgGameField_233, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._imgGameField_232, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._imgGameField_231, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._imgGameField_230, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._imgGameField_229, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._imgGameField_228, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._imgGameField_227, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._imgGameField_226, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._imgGameField_225, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._imgGameField_224, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._imgGameField_223, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._imgGameField_222, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._imgGameField_221, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._imgGameField_220, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._imgGameField_219, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._imgGameField_218, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._imgGameField_217, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._imgGameField_234, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._imgGameField_215, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._imgGameField_214, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._imgGameField_213, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._imgGameField_212, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._imgGameField_211, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._imgGameField_210, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._imgGameField_209, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._imgGameField_208, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._imgGameField_207, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._imgGameField_206, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._imgGameField_205, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._imgGameField_204, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._imgGameField_203, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._imgGameField_202, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._imgGameField_201, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._imgGameField_200, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._imgGameField_199, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._imgGameField_216, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._imgGameField_197, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._imgGameField_196, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._imgGameField_195, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._imgGameField_194, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._imgGameField_193, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._imgGameField_192, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._imgGameField_191, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._imgGameField_190, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._imgGameField_189, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._imgGameField_188, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._imgGameField_187, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._imgGameField_186, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._imgGameField_185, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._imgGameField_184, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._imgGameField_183, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._imgGameField_182, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._imgGameField_181, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._imgGameField_198, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._imgGameField_179, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._imgGameField_178, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._imgGameField_177, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._imgGameField_176, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._imgGameField_175, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._imgGameField_174, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._imgGameField_173, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._imgGameField_172, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._imgGameField_171, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._imgGameField_170, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._imgGameField_169, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._imgGameField_168, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._imgGameField_167, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._imgGameField_166, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._imgGameField_165, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._imgGameField_164, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._imgGameField_163, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._imgGameField_162, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._imgGameField_161, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._imgGameField_180, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._imgGameField_159, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._imgGameField_158, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._imgGameField_157, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._imgGameField_156, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._imgGameField_155, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._imgGameField_154, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._imgGameField_153, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._imgGameField_152, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._imgGameField_151, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._imgGameField_150, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._imgGameField_149, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._imgGameField_148, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._imgGameField_147, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._imgGameField_146, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._imgGameField_145, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._imgGameField_144, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._imgGameField_143, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._imgGameField_142, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._imgGameField_141, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._imgGameField_160, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._imgGameField_140, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._imgGameField_139, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._imgGameField_138, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._imgGameField_137, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._imgGameField_136, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._imgGameField_135, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._imgGameField_134, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._imgGameField_133, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._imgGameField_132, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._imgGameField_131, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._imgGameField_130, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._imgGameField_129, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._imgGameField_128, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._imgGameField_127, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._imgGameField_126, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._imgGameField_125, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._imgGameField_124, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._imgGameField_123, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._imgGameField_122, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._imgGameField_121, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._imgGameField_120, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._imgGameField_119, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._imgGameField_118, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._imgGameField_117, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._imgGameField_116, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._imgGameField_115, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._imgGameField_114, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._imgGameField_113, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._imgGameField_112, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._imgGameField_111, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._imgGameField_110, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._imgGameField_109, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._imgGameField_108, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._imgGameField_107, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._imgGameField_106, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._imgGameField_105, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._imgGameField_104, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._imgGameField_103, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._imgGameField_102, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._imgGameField_101, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._imgGameField_2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._imgGameField_1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._imgGameField_3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._imgGameField_4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._imgGameField_5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._imgGameField_6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._imgGameField_7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._imgGameField_8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._imgGameField_9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._imgGameField_10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._imgGameField_12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._imgGameField_11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._imgGameField_13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._imgGameField_14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._imgGameField_15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._imgGameField_16, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._imgGameField_17, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._imgGameField_18, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._imgGameField_19, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._imgGameField_20, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._imgGameField_22, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._imgGameField_21, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._imgGameField_23, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._imgGameField_24, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._imgGameField_25, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._imgGameField_26, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._imgGameField_27, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._imgGameField_28, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._imgGameField_29, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._imgGameField_30, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._imgGameField_32, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._imgGameField_31, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._imgGameField_33, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._imgGameField_34, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._imgGameField_35, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._imgGameField_36, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._imgGameField_37, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._imgGameField_38, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._imgGameField_39, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._imgGameField_40, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._imgGameField_50, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._imgGameField_49, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._imgGameField_48, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._imgGameField_47, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._imgGameField_46, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._imgGameField_45, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._imgGameField_44, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._imgGameField_43, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._imgGameField_41, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._imgGameField_42, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._imgGameField_90, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._imgGameField_89, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._imgGameField_88, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._imgGameField_87, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._imgGameField_86, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._imgGameField_85, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._imgGameField_84, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._imgGameField_83, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._imgGameField_81, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._imgGameField_82, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._imgGameField_80, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._imgGameField_79, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._imgGameField_78, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._imgGameField_77, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._imgGameField_76, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._imgGameField_75, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._imgGameField_74, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._imgGameField_73, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._imgGameField_71, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._imgGameField_72, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._imgGameField_70, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._imgGameField_69, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._imgGameField_68, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._imgGameField_67, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._imgGameField_66, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._imgGameField_65, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._imgGameField_64, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._imgGameField_63, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._imgGameField_61, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._imgGameField_62, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._imgGameField_60, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._imgGameField_59, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._imgGameField_58, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._imgGameField_57, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._imgGameField_56, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._imgGameField_55, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._imgGameField_54, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._imgGameField_53, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._imgGameField_51, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._imgGameField_52, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._imgGameField_100, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._imgGameField_99, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._imgGameField_98, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._imgGameField_97, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._imgGameField_96, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._imgGameField_95, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._imgGameField_94, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._imgGameField_93, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._imgGameField_91, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._imgGameField_92, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgGameField, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picStatusBar
        '
        Me.PicStatusBar.BackColor = System.Drawing.SystemColors.Control
        Me.PicStatusBar.Controls.Add(Me.ImgStatusImage)
        Me.PicStatusBar.Controls.Add(Me.LblPlayerName)
        Me.PicStatusBar.Controls.Add(Me.LblLevelNumber)
        Me.PicStatusBar.Controls.Add(Me.LblBoxes)
        Me.PicStatusBar.Controls.Add(Me.LblPushes)
        Me.PicStatusBar.Controls.Add(Me.LblMoves)
        Me.PicStatusBar.Cursor = System.Windows.Forms.Cursors.Default
        Me.PicStatusBar.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PicStatusBar.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PicStatusBar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.PicStatusBar.Location = New System.Drawing.Point(0, 510)
        Me.PicStatusBar.Name = "picStatusBar"
        Me.PicStatusBar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.PicStatusBar.Size = New System.Drawing.Size(511, 17)
        Me.PicStatusBar.TabIndex = 1
        Me.PicStatusBar.TabStop = True
        '
        'imgStatusImage
        '
        Me.ImgStatusImage.Cursor = System.Windows.Forms.Cursors.Default
        Me.ImgStatusImage.Image = CType(resources.GetObject("imgStatusImage.Image"), System.Drawing.Image)
        Me.ImgStatusImage.Location = New System.Drawing.Point(0, 0)
        Me.ImgStatusImage.Name = "imgStatusImage"
        Me.ImgStatusImage.Size = New System.Drawing.Size(16, 16)
        Me.ImgStatusImage.TabIndex = 0
        Me.ImgStatusImage.TabStop = False
        '
        'lblPlayerName
        '
        Me.LblPlayerName.BackColor = System.Drawing.SystemColors.Control
        Me.LblPlayerName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblPlayerName.Cursor = System.Windows.Forms.Cursors.Default
        Me.LblPlayerName.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPlayerName.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LblPlayerName.Location = New System.Drawing.Point(372, 0)
        Me.LblPlayerName.Name = "lblPlayerName"
        Me.LblPlayerName.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.LblPlayerName.Size = New System.Drawing.Size(137, 17)
        Me.LblPlayerName.TabIndex = 6
        Me.LblPlayerName.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblLevelNumber
        '
        Me.LblLevelNumber.BackColor = System.Drawing.SystemColors.Control
        Me.LblLevelNumber.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblLevelNumber.Cursor = System.Windows.Forms.Cursors.Default
        Me.LblLevelNumber.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblLevelNumber.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LblLevelNumber.Location = New System.Drawing.Point(272, 0)
        Me.LblLevelNumber.Name = "lblLevelNumber"
        Me.LblLevelNumber.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.LblLevelNumber.Size = New System.Drawing.Size(101, 17)
        Me.LblLevelNumber.TabIndex = 5
        Me.LblLevelNumber.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblBoxes
        '
        Me.LblBoxes.BackColor = System.Drawing.SystemColors.Control
        Me.LblBoxes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblBoxes.Cursor = System.Windows.Forms.Cursors.Default
        Me.LblBoxes.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblBoxes.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LblBoxes.Location = New System.Drawing.Point(176, 0)
        Me.LblBoxes.Name = "lblBoxes"
        Me.LblBoxes.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.LblBoxes.Size = New System.Drawing.Size(97, 17)
        Me.LblBoxes.TabIndex = 4
        Me.LblBoxes.Text = "Skrzynki: ##/##"
        Me.LblBoxes.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblPushes
        '
        Me.LblPushes.BackColor = System.Drawing.SystemColors.Control
        Me.LblPushes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblPushes.Cursor = System.Windows.Forms.Cursors.Default
        Me.LblPushes.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPushes.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LblPushes.Location = New System.Drawing.Point(88, 0)
        Me.LblPushes.Name = "lblPushes"
        Me.LblPushes.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.LblPushes.Size = New System.Drawing.Size(89, 17)
        Me.LblPushes.TabIndex = 3
        Me.LblPushes.Text = "Pchniêcia: ###"
        Me.LblPushes.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblMoves
        '
        Me.LblMoves.BackColor = System.Drawing.SystemColors.Control
        Me.LblMoves.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblMoves.Cursor = System.Windows.Forms.Cursors.Default
        Me.LblMoves.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblMoves.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LblMoves.Location = New System.Drawing.Point(16, 0)
        Me.LblMoves.Name = "lblMoves"
        Me.LblMoves.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.LblMoves.Size = New System.Drawing.Size(73, 17)
        Me.LblMoves.TabIndex = 2
        Me.LblMoves.Text = "Ruchy: ###"
        Me.LblMoves.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_imgGameField_256
        '
        Me._imgGameField_256.Cursor = System.Windows.Forms.Cursors.Default
        Me.imgGameField.SetIndex(Me._imgGameField_256, CType(256, Short))
        Me._imgGameField_256.Location = New System.Drawing.Point(480, 480)
        Me._imgGameField_256.Name = "_imgGameField_256"
        Me._imgGameField_256.Size = New System.Drawing.Size(32, 32)
        Me._imgGameField_256.TabIndex = 2
        Me._imgGameField_256.TabStop = False
        '
        '_imgGameField_255
        '
        Me._imgGameField_255.Cursor = System.Windows.Forms.Cursors.Default
        Me.imgGameField.SetIndex(Me._imgGameField_255, CType(255, Short))
        Me._imgGameField_255.Location = New System.Drawing.Point(448, 480)
        Me._imgGameField_255.Name = "_imgGameField_255"
        Me._imgGameField_255.Size = New System.Drawing.Size(32, 32)
        Me._imgGameField_255.TabIndex = 3
        Me._imgGameField_255.TabStop = False
        '
        '_imgGameField_254
        '
        Me._imgGameField_254.Cursor = System.Windows.Forms.Cursors.Default
        Me.imgGameField.SetIndex(Me._imgGameField_254, CType(254, Short))
        Me._imgGameField_254.Location = New System.Drawing.Point(416, 480)
        Me._imgGameField_254.Name = "_imgGameField_254"
        Me._imgGameField_254.Size = New System.Drawing.Size(32, 32)
        Me._imgGameField_254.TabIndex = 4
        Me._imgGameField_254.TabStop = False
        '
        '_imgGameField_253
        '
        Me._imgGameField_253.Cursor = System.Windows.Forms.Cursors.Default
        Me.imgGameField.SetIndex(Me._imgGameField_253, CType(253, Short))
        Me._imgGameField_253.Location = New System.Drawing.Point(384, 480)
        Me._imgGameField_253.Name = "_imgGameField_253"
        Me._imgGameField_253.Size = New System.Drawing.Size(32, 32)
        Me._imgGameField_253.TabIndex = 5
        Me._imgGameField_253.TabStop = False
        '
        '_imgGameField_251
        '
        Me._imgGameField_251.Cursor = System.Windows.Forms.Cursors.Default
        Me.imgGameField.SetIndex(Me._imgGameField_251, CType(251, Short))
        Me._imgGameField_251.Location = New System.Drawing.Point(320, 480)
        Me._imgGameField_251.Name = "_imgGameField_251"
        Me._imgGameField_251.Size = New System.Drawing.Size(32, 32)
        Me._imgGameField_251.TabIndex = 6
        Me._imgGameField_251.TabStop = False
        '
        '_imgGameField_250
        '
        Me._imgGameField_250.Cursor = System.Windows.Forms.Cursors.Default
        Me.imgGameField.SetIndex(Me._imgGameField_250, CType(250, Short))
        Me._imgGameField_250.Location = New System.Drawing.Point(288, 480)
        Me._imgGameField_250.Name = "_imgGameField_250"
        Me._imgGameField_250.Size = New System.Drawing.Size(32, 32)
        Me._imgGameField_250.TabIndex = 7
        Me._imgGameField_250.TabStop = False
        '
        '_imgGameField_249
        '
        Me._imgGameField_249.Cursor = System.Windows.Forms.Cursors.Default
        Me.imgGameField.SetIndex(Me._imgGameField_249, CType(249, Short))
        Me._imgGameField_249.Location = New System.Drawing.Point(256, 480)
        Me._imgGameField_249.Name = "_imgGameField_249"
        Me._imgGameField_249.Size = New System.Drawing.Size(32, 32)
        Me._imgGameField_249.TabIndex = 8
        Me._imgGameField_249.TabStop = False
        '
        '_imgGameField_248
        '
        Me._imgGameField_248.Cursor = System.Windows.Forms.Cursors.Default
        Me.imgGameField.SetIndex(Me._imgGameField_248, CType(248, Short))
        Me._imgGameField_248.Location = New System.Drawing.Point(224, 480)
        Me._imgGameField_248.Name = "_imgGameField_248"
        Me._imgGameField_248.Size = New System.Drawing.Size(32, 32)
        Me._imgGameField_248.TabIndex = 9
        Me._imgGameField_248.TabStop = False
        '
        '_imgGameField_247
        '
        Me._imgGameField_247.Cursor = System.Windows.Forms.Cursors.Default
        Me.imgGameField.SetIndex(Me._imgGameField_247, CType(247, Short))
        Me._imgGameField_247.Location = New System.Drawing.Point(192, 480)
        Me._imgGameField_247.Name = "_imgGameField_247"
        Me._imgGameField_247.Size = New System.Drawing.Size(32, 32)
        Me._imgGameField_247.TabIndex = 10
        Me._imgGameField_247.TabStop = False
        '
        '_imgGameField_246
        '
        Me._imgGameField_246.Cursor = System.Windows.Forms.Cursors.Default
        Me.imgGameField.SetIndex(Me._imgGameField_246, CType(246, Short))
        Me._imgGameField_246.Location = New System.Drawing.Point(160, 480)
        Me._imgGameField_246.Name = "_imgGameField_246"
        Me._imgGameField_246.Size = New System.Drawing.Size(32, 32)
        Me._imgGameField_246.TabIndex = 11
        Me._imgGameField_246.TabStop = False
        '
        '_imgGameField_245
        '
        Me._imgGameField_245.Cursor = System.Windows.Forms.Cursors.Default
        Me.imgGameField.SetIndex(Me._imgGameField_245, CType(245, Short))
        Me._imgGameField_245.Location = New System.Drawing.Point(128, 480)
        Me._imgGameField_245.Name = "_imgGameField_245"
        Me._imgGameField_245.Size = New System.Drawing.Size(32, 32)
        Me._imgGameField_245.TabIndex = 12
        Me._imgGameField_245.TabStop = False
        '
        '_imgGameField_244
        '
        Me._imgGameField_244.Cursor = System.Windows.Forms.Cursors.Default
        Me.imgGameField.SetIndex(Me._imgGameField_244, CType(244, Short))
        Me._imgGameField_244.Location = New System.Drawing.Point(96, 480)
        Me._imgGameField_244.Name = "_imgGameField_244"
        Me._imgGameField_244.Size = New System.Drawing.Size(32, 32)
        Me._imgGameField_244.TabIndex = 13
        Me._imgGameField_244.TabStop = False
        '
        '_imgGameField_243
        '
        Me._imgGameField_243.Cursor = System.Windows.Forms.Cursors.Default
        Me.imgGameField.SetIndex(Me._imgGameField_243, CType(243, Short))
        Me._imgGameField_243.Location = New System.Drawing.Point(64, 480)
        Me._imgGameField_243.Name = "_imgGameField_243"
        Me._imgGameField_243.Size = New System.Drawing.Size(32, 32)
        Me._imgGameField_243.TabIndex = 14
        Me._imgGameField_243.TabStop = False
        '
        '_imgGameField_242
        '
        Me._imgGameField_242.Cursor = System.Windows.Forms.Cursors.Default
        Me.imgGameField.SetIndex(Me._imgGameField_242, CType(242, Short))
        Me._imgGameField_242.Location = New System.Drawing.Point(32, 480)
        Me._imgGameField_242.Name = "_imgGameField_242"
        Me._imgGameField_242.Size = New System.Drawing.Size(32, 32)
        Me._imgGameField_242.TabIndex = 15
        Me._imgGameField_242.TabStop = False
        '
        '_imgGameField_241
        '
        Me._imgGameField_241.Cursor = System.Windows.Forms.Cursors.Default
        Me.imgGameField.SetIndex(Me._imgGameField_241, CType(241, Short))
        Me._imgGameField_241.Location = New System.Drawing.Point(0, 480)
        Me._imgGameField_241.Name = "_imgGameField_241"
        Me._imgGameField_241.Size = New System.Drawing.Size(32, 32)
        Me._imgGameField_241.TabIndex = 16
        Me._imgGameField_241.TabStop = False
        '
        '_imgGameField_240
        '
        Me._imgGameField_240.Cursor = System.Windows.Forms.Cursors.Default
        Me.imgGameField.SetIndex(Me._imgGameField_240, CType(240, Short))
        Me._imgGameField_240.Location = New System.Drawing.Point(480, 448)
        Me._imgGameField_240.Name = "_imgGameField_240"
        Me._imgGameField_240.Size = New System.Drawing.Size(32, 32)
        Me._imgGameField_240.TabIndex = 17
        Me._imgGameField_240.TabStop = False
        '
        '_imgGameField_239
        '
        Me._imgGameField_239.Cursor = System.Windows.Forms.Cursors.Default
        Me.imgGameField.SetIndex(Me._imgGameField_239, CType(239, Short))
        Me._imgGameField_239.Location = New System.Drawing.Point(448, 448)
        Me._imgGameField_239.Name = "_imgGameField_239"
        Me._imgGameField_239.Size = New System.Drawing.Size(32, 32)
        Me._imgGameField_239.TabIndex = 18
        Me._imgGameField_239.TabStop = False
        '
        '_imgGameField_238
        '
        Me._imgGameField_238.Cursor = System.Windows.Forms.Cursors.Default
        Me.imgGameField.SetIndex(Me._imgGameField_238, CType(238, Short))
        Me._imgGameField_238.Location = New System.Drawing.Point(416, 448)
        Me._imgGameField_238.Name = "_imgGameField_238"
        Me._imgGameField_238.Size = New System.Drawing.Size(32, 32)
        Me._imgGameField_238.TabIndex = 19
        Me._imgGameField_238.TabStop = False
        '
        '_imgGameField_237
        '
        Me._imgGameField_237.Cursor = System.Windows.Forms.Cursors.Default
        Me.imgGameField.SetIndex(Me._imgGameField_237, CType(237, Short))
        Me._imgGameField_237.Location = New System.Drawing.Point(384, 448)
        Me._imgGameField_237.Name = "_imgGameField_237"
        Me._imgGameField_237.Size = New System.Drawing.Size(32, 32)
        Me._imgGameField_237.TabIndex = 20
        Me._imgGameField_237.TabStop = False
        '
        '_imgGameField_236
        '
        Me._imgGameField_236.Cursor = System.Windows.Forms.Cursors.Default
        Me.imgGameField.SetIndex(Me._imgGameField_236, CType(236, Short))
        Me._imgGameField_236.Location = New System.Drawing.Point(352, 448)
        Me._imgGameField_236.Name = "_imgGameField_236"
        Me._imgGameField_236.Size = New System.Drawing.Size(32, 32)
        Me._imgGameField_236.TabIndex = 21
        Me._imgGameField_236.TabStop = False
        '
        '_imgGameField_235
        '
        Me._imgGameField_235.Cursor = System.Windows.Forms.Cursors.Default
        Me.imgGameField.SetIndex(Me._imgGameField_235, CType(235, Short))
        Me._imgGameField_235.Location = New System.Drawing.Point(320, 448)
        Me._imgGameField_235.Name = "_imgGameField_235"
        Me._imgGameField_235.Size = New System.Drawing.Size(32, 32)
        Me._imgGameField_235.TabIndex = 22
        Me._imgGameField_235.TabStop = False
        '
        '_imgGameField_252
        '
        Me._imgGameField_252.Cursor = System.Windows.Forms.Cursors.Default
        Me.imgGameField.SetIndex(Me._imgGameField_252, CType(252, Short))
        Me._imgGameField_252.Location = New System.Drawing.Point(352, 480)
        Me._imgGameField_252.Name = "_imgGameField_252"
        Me._imgGameField_252.Size = New System.Drawing.Size(32, 32)
        Me._imgGameField_252.TabIndex = 23
        Me._imgGameField_252.TabStop = False
        '
        '_imgGameField_233
        '
        Me._imgGameField_233.Cursor = System.Windows.Forms.Cursors.Default
        Me.imgGameField.SetIndex(Me._imgGameField_233, CType(233, Short))
        Me._imgGameField_233.Location = New System.Drawing.Point(256, 448)
        Me._imgGameField_233.Name = "_imgGameField_233"
        Me._imgGameField_233.Size = New System.Drawing.Size(32, 32)
        Me._imgGameField_233.TabIndex = 24
        Me._imgGameField_233.TabStop = False
        '
        '_imgGameField_232
        '
        Me._imgGameField_232.Cursor = System.Windows.Forms.Cursors.Default
        Me.imgGameField.SetIndex(Me._imgGameField_232, CType(232, Short))
        Me._imgGameField_232.Location = New System.Drawing.Point(224, 448)
        Me._imgGameField_232.Name = "_imgGameField_232"
        Me._imgGameField_232.Size = New System.Drawing.Size(32, 32)
        Me._imgGameField_232.TabIndex = 25
        Me._imgGameField_232.TabStop = False
        '
        '_imgGameField_231
        '
        Me._imgGameField_231.Cursor = System.Windows.Forms.Cursors.Default
        Me.imgGameField.SetIndex(Me._imgGameField_231, CType(231, Short))
        Me._imgGameField_231.Location = New System.Drawing.Point(192, 448)
        Me._imgGameField_231.Name = "_imgGameField_231"
        Me._imgGameField_231.Size = New System.Drawing.Size(32, 32)
        Me._imgGameField_231.TabIndex = 26
        Me._imgGameField_231.TabStop = False
        '
        '_imgGameField_230
        '
        Me._imgGameField_230.Cursor = System.Windows.Forms.Cursors.Default
        Me.imgGameField.SetIndex(Me._imgGameField_230, CType(230, Short))
        Me._imgGameField_230.Location = New System.Drawing.Point(160, 448)
        Me._imgGameField_230.Name = "_imgGameField_230"
        Me._imgGameField_230.Size = New System.Drawing.Size(32, 32)
        Me._imgGameField_230.TabIndex = 27
        Me._imgGameField_230.TabStop = False
        '
        '_imgGameField_229
        '
        Me._imgGameField_229.Cursor = System.Windows.Forms.Cursors.Default
        Me.imgGameField.SetIndex(Me._imgGameField_229, CType(229, Short))
        Me._imgGameField_229.Location = New System.Drawing.Point(128, 448)
        Me._imgGameField_229.Name = "_imgGameField_229"
        Me._imgGameField_229.Size = New System.Drawing.Size(32, 32)
        Me._imgGameField_229.TabIndex = 28
        Me._imgGameField_229.TabStop = False
        '
        '_imgGameField_228
        '
        Me._imgGameField_228.Cursor = System.Windows.Forms.Cursors.Default
        Me.imgGameField.SetIndex(Me._imgGameField_228, CType(228, Short))
        Me._imgGameField_228.Location = New System.Drawing.Point(96, 448)
        Me._imgGameField_228.Name = "_imgGameField_228"
        Me._imgGameField_228.Size = New System.Drawing.Size(32, 32)
        Me._imgGameField_228.TabIndex = 29
        Me._imgGameField_228.TabStop = False
        '
        '_imgGameField_227
        '
        Me._imgGameField_227.Cursor = System.Windows.Forms.Cursors.Default
        Me.imgGameField.SetIndex(Me._imgGameField_227, CType(227, Short))
        Me._imgGameField_227.Location = New System.Drawing.Point(64, 448)
        Me._imgGameField_227.Name = "_imgGameField_227"
        Me._imgGameField_227.Size = New System.Drawing.Size(32, 32)
        Me._imgGameField_227.TabIndex = 30
        Me._imgGameField_227.TabStop = False
        '
        '_imgGameField_226
        '
        Me._imgGameField_226.Cursor = System.Windows.Forms.Cursors.Default
        Me.imgGameField.SetIndex(Me._imgGameField_226, CType(226, Short))
        Me._imgGameField_226.Location = New System.Drawing.Point(32, 448)
        Me._imgGameField_226.Name = "_imgGameField_226"
        Me._imgGameField_226.Size = New System.Drawing.Size(32, 32)
        Me._imgGameField_226.TabIndex = 31
        Me._imgGameField_226.TabStop = False
        '
        '_imgGameField_225
        '
        Me._imgGameField_225.Cursor = System.Windows.Forms.Cursors.Default
        Me.imgGameField.SetIndex(Me._imgGameField_225, CType(225, Short))
        Me._imgGameField_225.Location = New System.Drawing.Point(0, 448)
        Me._imgGameField_225.Name = "_imgGameField_225"
        Me._imgGameField_225.Size = New System.Drawing.Size(32, 32)
        Me._imgGameField_225.TabIndex = 32
        Me._imgGameField_225.TabStop = False
        '
        '_imgGameField_224
        '
        Me._imgGameField_224.Cursor = System.Windows.Forms.Cursors.Default
        Me.imgGameField.SetIndex(Me._imgGameField_224, CType(224, Short))
        Me._imgGameField_224.Location = New System.Drawing.Point(480, 416)
        Me._imgGameField_224.Name = "_imgGameField_224"
        Me._imgGameField_224.Size = New System.Drawing.Size(32, 32)
        Me._imgGameField_224.TabIndex = 33
        Me._imgGameField_224.TabStop = False
        '
        '_imgGameField_223
        '
        Me._imgGameField_223.Cursor = System.Windows.Forms.Cursors.Default
        Me.imgGameField.SetIndex(Me._imgGameField_223, CType(223, Short))
        Me._imgGameField_223.Location = New System.Drawing.Point(448, 416)
        Me._imgGameField_223.Name = "_imgGameField_223"
        Me._imgGameField_223.Size = New System.Drawing.Size(32, 32)
        Me._imgGameField_223.TabIndex = 34
        Me._imgGameField_223.TabStop = False
        '
        '_imgGameField_222
        '
        Me._imgGameField_222.Cursor = System.Windows.Forms.Cursors.Default
        Me.imgGameField.SetIndex(Me._imgGameField_222, CType(222, Short))
        Me._imgGameField_222.Location = New System.Drawing.Point(416, 416)
        Me._imgGameField_222.Name = "_imgGameField_222"
        Me._imgGameField_222.Size = New System.Drawing.Size(32, 32)
        Me._imgGameField_222.TabIndex = 35
        Me._imgGameField_222.TabStop = False
        '
        '_imgGameField_221
        '
        Me._imgGameField_221.Cursor = System.Windows.Forms.Cursors.Default
        Me.imgGameField.SetIndex(Me._imgGameField_221, CType(221, Short))
        Me._imgGameField_221.Location = New System.Drawing.Point(384, 416)
        Me._imgGameField_221.Name = "_imgGameField_221"
        Me._imgGameField_221.Size = New System.Drawing.Size(32, 32)
        Me._imgGameField_221.TabIndex = 36
        Me._imgGameField_221.TabStop = False
        '
        '_imgGameField_220
        '
        Me._imgGameField_220.Cursor = System.Windows.Forms.Cursors.Default
        Me.imgGameField.SetIndex(Me._imgGameField_220, CType(220, Short))
        Me._imgGameField_220.Location = New System.Drawing.Point(352, 416)
        Me._imgGameField_220.Name = "_imgGameField_220"
        Me._imgGameField_220.Size = New System.Drawing.Size(32, 32)
        Me._imgGameField_220.TabIndex = 37
        Me._imgGameField_220.TabStop = False
        '
        '_imgGameField_219
        '
        Me._imgGameField_219.Cursor = System.Windows.Forms.Cursors.Default
        Me.imgGameField.SetIndex(Me._imgGameField_219, CType(219, Short))
        Me._imgGameField_219.Location = New System.Drawing.Point(320, 416)
        Me._imgGameField_219.Name = "_imgGameField_219"
        Me._imgGameField_219.Size = New System.Drawing.Size(32, 32)
        Me._imgGameField_219.TabIndex = 38
        Me._imgGameField_219.TabStop = False
        '
        '_imgGameField_218
        '
        Me._imgGameField_218.Cursor = System.Windows.Forms.Cursors.Default
        Me.imgGameField.SetIndex(Me._imgGameField_218, CType(218, Short))
        Me._imgGameField_218.Location = New System.Drawing.Point(288, 416)
        Me._imgGameField_218.Name = "_imgGameField_218"
        Me._imgGameField_218.Size = New System.Drawing.Size(32, 32)
        Me._imgGameField_218.TabIndex = 39
        Me._imgGameField_218.TabStop = False
        '
        '_imgGameField_217
        '
        Me._imgGameField_217.Cursor = System.Windows.Forms.Cursors.Default
        Me.imgGameField.SetIndex(Me._imgGameField_217, CType(217, Short))
        Me._imgGameField_217.Location = New System.Drawing.Point(256, 416)
        Me._imgGameField_217.Name = "_imgGameField_217"
        Me._imgGameField_217.Size = New System.Drawing.Size(32, 32)
        Me._imgGameField_217.TabIndex = 40
        Me._imgGameField_217.TabStop = False
        '
        '_imgGameField_234
        '
        Me._imgGameField_234.Cursor = System.Windows.Forms.Cursors.Default
        Me.imgGameField.SetIndex(Me._imgGameField_234, CType(234, Short))
        Me._imgGameField_234.Location = New System.Drawing.Point(288, 448)
        Me._imgGameField_234.Name = "_imgGameField_234"
        Me._imgGameField_234.Size = New System.Drawing.Size(32, 32)
        Me._imgGameField_234.TabIndex = 41
        Me._imgGameField_234.TabStop = False
        '
        '_imgGameField_215
        '
        Me._imgGameField_215.Cursor = System.Windows.Forms.Cursors.Default
        Me.imgGameField.SetIndex(Me._imgGameField_215, CType(215, Short))
        Me._imgGameField_215.Location = New System.Drawing.Point(192, 416)
        Me._imgGameField_215.Name = "_imgGameField_215"
        Me._imgGameField_215.Size = New System.Drawing.Size(32, 32)
        Me._imgGameField_215.TabIndex = 42
        Me._imgGameField_215.TabStop = False
        '
        '_imgGameField_214
        '
        Me._imgGameField_214.Cursor = System.Windows.Forms.Cursors.Default
        Me.imgGameField.SetIndex(Me._imgGameField_214, CType(214, Short))
        Me._imgGameField_214.Location = New System.Drawing.Point(160, 416)
        Me._imgGameField_214.Name = "_imgGameField_214"
        Me._imgGameField_214.Size = New System.Drawing.Size(32, 32)
        Me._imgGameField_214.TabIndex = 43
        Me._imgGameField_214.TabStop = False
        '
        '_imgGameField_213
        '
        Me._imgGameField_213.Cursor = System.Windows.Forms.Cursors.Default
        Me.imgGameField.SetIndex(Me._imgGameField_213, CType(213, Short))
        Me._imgGameField_213.Location = New System.Drawing.Point(128, 416)
        Me._imgGameField_213.Name = "_imgGameField_213"
        Me._imgGameField_213.Size = New System.Drawing.Size(32, 32)
        Me._imgGameField_213.TabIndex = 44
        Me._imgGameField_213.TabStop = False
        '
        '_imgGameField_212
        '
        Me._imgGameField_212.Cursor = System.Windows.Forms.Cursors.Default
        Me.imgGameField.SetIndex(Me._imgGameField_212, CType(212, Short))
        Me._imgGameField_212.Location = New System.Drawing.Point(96, 416)
        Me._imgGameField_212.Name = "_imgGameField_212"
        Me._imgGameField_212.Size = New System.Drawing.Size(32, 32)
        Me._imgGameField_212.TabIndex = 45
        Me._imgGameField_212.TabStop = False
        '
        '_imgGameField_211
        '
        Me._imgGameField_211.Cursor = System.Windows.Forms.Cursors.Default
        Me.imgGameField.SetIndex(Me._imgGameField_211, CType(211, Short))
        Me._imgGameField_211.Location = New System.Drawing.Point(64, 416)
        Me._imgGameField_211.Name = "_imgGameField_211"
        Me._imgGameField_211.Size = New System.Drawing.Size(32, 32)
        Me._imgGameField_211.TabIndex = 46
        Me._imgGameField_211.TabStop = False
        '
        '_imgGameField_210
        '
        Me._imgGameField_210.Cursor = System.Windows.Forms.Cursors.Default
        Me.imgGameField.SetIndex(Me._imgGameField_210, CType(210, Short))
        Me._imgGameField_210.Location = New System.Drawing.Point(32, 416)
        Me._imgGameField_210.Name = "_imgGameField_210"
        Me._imgGameField_210.Size = New System.Drawing.Size(32, 32)
        Me._imgGameField_210.TabIndex = 47
        Me._imgGameField_210.TabStop = False
        '
        '_imgGameField_209
        '
        Me._imgGameField_209.Cursor = System.Windows.Forms.Cursors.Default
        Me.imgGameField.SetIndex(Me._imgGameField_209, CType(209, Short))
        Me._imgGameField_209.Location = New System.Drawing.Point(0, 416)
        Me._imgGameField_209.Name = "_imgGameField_209"
        Me._imgGameField_209.Size = New System.Drawing.Size(32, 32)
        Me._imgGameField_209.TabIndex = 48
        Me._imgGameField_209.TabStop = False
        '
        '_imgGameField_208
        '
        Me._imgGameField_208.Cursor = System.Windows.Forms.Cursors.Default
        Me.imgGameField.SetIndex(Me._imgGameField_208, CType(208, Short))
        Me._imgGameField_208.Location = New System.Drawing.Point(480, 384)
        Me._imgGameField_208.Name = "_imgGameField_208"
        Me._imgGameField_208.Size = New System.Drawing.Size(32, 32)
        Me._imgGameField_208.TabIndex = 49
        Me._imgGameField_208.TabStop = False
        '
        '_imgGameField_207
        '
        Me._imgGameField_207.Cursor = System.Windows.Forms.Cursors.Default
        Me.imgGameField.SetIndex(Me._imgGameField_207, CType(207, Short))
        Me._imgGameField_207.Location = New System.Drawing.Point(448, 384)
        Me._imgGameField_207.Name = "_imgGameField_207"
        Me._imgGameField_207.Size = New System.Drawing.Size(32, 32)
        Me._imgGameField_207.TabIndex = 50
        Me._imgGameField_207.TabStop = False
        '
        '_imgGameField_206
        '
        Me._imgGameField_206.Cursor = System.Windows.Forms.Cursors.Default
        Me.imgGameField.SetIndex(Me._imgGameField_206, CType(206, Short))
        Me._imgGameField_206.Location = New System.Drawing.Point(416, 384)
        Me._imgGameField_206.Name = "_imgGameField_206"
        Me._imgGameField_206.Size = New System.Drawing.Size(32, 32)
        Me._imgGameField_206.TabIndex = 51
        Me._imgGameField_206.TabStop = False
        '
        '_imgGameField_205
        '
        Me._imgGameField_205.Cursor = System.Windows.Forms.Cursors.Default
        Me.imgGameField.SetIndex(Me._imgGameField_205, CType(205, Short))
        Me._imgGameField_205.Location = New System.Drawing.Point(384, 384)
        Me._imgGameField_205.Name = "_imgGameField_205"
        Me._imgGameField_205.Size = New System.Drawing.Size(32, 32)
        Me._imgGameField_205.TabIndex = 52
        Me._imgGameField_205.TabStop = False
        '
        '_imgGameField_204
        '
        Me._imgGameField_204.Cursor = System.Windows.Forms.Cursors.Default
        Me.imgGameField.SetIndex(Me._imgGameField_204, CType(204, Short))
        Me._imgGameField_204.Location = New System.Drawing.Point(352, 384)
        Me._imgGameField_204.Name = "_imgGameField_204"
        Me._imgGameField_204.Size = New System.Drawing.Size(32, 32)
        Me._imgGameField_204.TabIndex = 53
        Me._imgGameField_204.TabStop = False
        '
        '_imgGameField_203
        '
        Me._imgGameField_203.Cursor = System.Windows.Forms.Cursors.Default
        Me.imgGameField.SetIndex(Me._imgGameField_203, CType(203, Short))
        Me._imgGameField_203.Location = New System.Drawing.Point(320, 384)
        Me._imgGameField_203.Name = "_imgGameField_203"
        Me._imgGameField_203.Size = New System.Drawing.Size(32, 32)
        Me._imgGameField_203.TabIndex = 54
        Me._imgGameField_203.TabStop = False
        '
        '_imgGameField_202
        '
        Me._imgGameField_202.Cursor = System.Windows.Forms.Cursors.Default
        Me.imgGameField.SetIndex(Me._imgGameField_202, CType(202, Short))
        Me._imgGameField_202.Location = New System.Drawing.Point(288, 384)
        Me._imgGameField_202.Name = "_imgGameField_202"
        Me._imgGameField_202.Size = New System.Drawing.Size(32, 32)
        Me._imgGameField_202.TabIndex = 55
        Me._imgGameField_202.TabStop = False
        '
        '_imgGameField_201
        '
        Me._imgGameField_201.Cursor = System.Windows.Forms.Cursors.Default
        Me.imgGameField.SetIndex(Me._imgGameField_201, CType(201, Short))
        Me._imgGameField_201.Location = New System.Drawing.Point(256, 384)
        Me._imgGameField_201.Name = "_imgGameField_201"
        Me._imgGameField_201.Size = New System.Drawing.Size(32, 32)
        Me._imgGameField_201.TabIndex = 56
        Me._imgGameField_201.TabStop = False
        '
        '_imgGameField_200
        '
        Me._imgGameField_200.Cursor = System.Windows.Forms.Cursors.Default
        Me.imgGameField.SetIndex(Me._imgGameField_200, CType(200, Short))
        Me._imgGameField_200.Location = New System.Drawing.Point(224, 384)
        Me._imgGameField_200.Name = "_imgGameField_200"
        Me._imgGameField_200.Size = New System.Drawing.Size(32, 32)
        Me._imgGameField_200.TabIndex = 57
        Me._imgGameField_200.TabStop = False
        '
        '_imgGameField_199
        '
        Me._imgGameField_199.Cursor = System.Windows.Forms.Cursors.Default
        Me.imgGameField.SetIndex(Me._imgGameField_199, CType(199, Short))
        Me._imgGameField_199.Location = New System.Drawing.Point(192, 384)
        Me._imgGameField_199.Name = "_imgGameField_199"
        Me._imgGameField_199.Size = New System.Drawing.Size(32, 32)
        Me._imgGameField_199.TabIndex = 58
        Me._imgGameField_199.TabStop = False
        '
        '_imgGameField_216
        '
        Me._imgGameField_216.Cursor = System.Windows.Forms.Cursors.Default
        Me.imgGameField.SetIndex(Me._imgGameField_216, CType(216, Short))
        Me._imgGameField_216.Location = New System.Drawing.Point(224, 416)
        Me._imgGameField_216.Name = "_imgGameField_216"
        Me._imgGameField_216.Size = New System.Drawing.Size(32, 32)
        Me._imgGameField_216.TabIndex = 59
        Me._imgGameField_216.TabStop = False
        '
        '_imgGameField_197
        '
        Me._imgGameField_197.Cursor = System.Windows.Forms.Cursors.Default
        Me.imgGameField.SetIndex(Me._imgGameField_197, CType(197, Short))
        Me._imgGameField_197.Location = New System.Drawing.Point(128, 384)
        Me._imgGameField_197.Name = "_imgGameField_197"
        Me._imgGameField_197.Size = New System.Drawing.Size(32, 32)
        Me._imgGameField_197.TabIndex = 60
        Me._imgGameField_197.TabStop = False
        '
        '_imgGameField_196
        '
        Me._imgGameField_196.Cursor = System.Windows.Forms.Cursors.Default
        Me.imgGameField.SetIndex(Me._imgGameField_196, CType(196, Short))
        Me._imgGameField_196.Location = New System.Drawing.Point(96, 384)
        Me._imgGameField_196.Name = "_imgGameField_196"
        Me._imgGameField_196.Size = New System.Drawing.Size(32, 32)
        Me._imgGameField_196.TabIndex = 61
        Me._imgGameField_196.TabStop = False
        '
        '_imgGameField_195
        '
        Me._imgGameField_195.Cursor = System.Windows.Forms.Cursors.Default
        Me.imgGameField.SetIndex(Me._imgGameField_195, CType(195, Short))
        Me._imgGameField_195.Location = New System.Drawing.Point(64, 384)
        Me._imgGameField_195.Name = "_imgGameField_195"
        Me._imgGameField_195.Size = New System.Drawing.Size(32, 32)
        Me._imgGameField_195.TabIndex = 62
        Me._imgGameField_195.TabStop = False
        '
        '_imgGameField_194
        '
        Me._imgGameField_194.Cursor = System.Windows.Forms.Cursors.Default
        Me.imgGameField.SetIndex(Me._imgGameField_194, CType(194, Short))
        Me._imgGameField_194.Location = New System.Drawing.Point(32, 384)
        Me._imgGameField_194.Name = "_imgGameField_194"
        Me._imgGameField_194.Size = New System.Drawing.Size(32, 32)
        Me._imgGameField_194.TabIndex = 63
        Me._imgGameField_194.TabStop = False
        '
        '_imgGameField_193
        '
        Me._imgGameField_193.Cursor = System.Windows.Forms.Cursors.Default
        Me.imgGameField.SetIndex(Me._imgGameField_193, CType(193, Short))
        Me._imgGameField_193.Location = New System.Drawing.Point(0, 384)
        Me._imgGameField_193.Name = "_imgGameField_193"
        Me._imgGameField_193.Size = New System.Drawing.Size(32, 32)
        Me._imgGameField_193.TabIndex = 64
        Me._imgGameField_193.TabStop = False
        '
        '_imgGameField_192
        '
        Me._imgGameField_192.Cursor = System.Windows.Forms.Cursors.Default
        Me.imgGameField.SetIndex(Me._imgGameField_192, CType(192, Short))
        Me._imgGameField_192.Location = New System.Drawing.Point(480, 352)
        Me._imgGameField_192.Name = "_imgGameField_192"
        Me._imgGameField_192.Size = New System.Drawing.Size(32, 32)
        Me._imgGameField_192.TabIndex = 65
        Me._imgGameField_192.TabStop = False
        '
        '_imgGameField_191
        '
        Me._imgGameField_191.Cursor = System.Windows.Forms.Cursors.Default
        Me.imgGameField.SetIndex(Me._imgGameField_191, CType(191, Short))
        Me._imgGameField_191.Location = New System.Drawing.Point(448, 352)
        Me._imgGameField_191.Name = "_imgGameField_191"
        Me._imgGameField_191.Size = New System.Drawing.Size(32, 32)
        Me._imgGameField_191.TabIndex = 66
        Me._imgGameField_191.TabStop = False
        '
        '_imgGameField_190
        '
        Me._imgGameField_190.Cursor = System.Windows.Forms.Cursors.Default
        Me.imgGameField.SetIndex(Me._imgGameField_190, CType(190, Short))
        Me._imgGameField_190.Location = New System.Drawing.Point(416, 352)
        Me._imgGameField_190.Name = "_imgGameField_190"
        Me._imgGameField_190.Size = New System.Drawing.Size(32, 32)
        Me._imgGameField_190.TabIndex = 67
        Me._imgGameField_190.TabStop = False
        '
        '_imgGameField_189
        '
        Me._imgGameField_189.Cursor = System.Windows.Forms.Cursors.Default
        Me.imgGameField.SetIndex(Me._imgGameField_189, CType(189, Short))
        Me._imgGameField_189.Location = New System.Drawing.Point(384, 352)
        Me._imgGameField_189.Name = "_imgGameField_189"
        Me._imgGameField_189.Size = New System.Drawing.Size(32, 32)
        Me._imgGameField_189.TabIndex = 68
        Me._imgGameField_189.TabStop = False
        '
        '_imgGameField_188
        '
        Me._imgGameField_188.Cursor = System.Windows.Forms.Cursors.Default
        Me.imgGameField.SetIndex(Me._imgGameField_188, CType(188, Short))
        Me._imgGameField_188.Location = New System.Drawing.Point(352, 352)
        Me._imgGameField_188.Name = "_imgGameField_188"
        Me._imgGameField_188.Size = New System.Drawing.Size(32, 32)
        Me._imgGameField_188.TabIndex = 69
        Me._imgGameField_188.TabStop = False
        '
        '_imgGameField_187
        '
        Me._imgGameField_187.Cursor = System.Windows.Forms.Cursors.Default
        Me.imgGameField.SetIndex(Me._imgGameField_187, CType(187, Short))
        Me._imgGameField_187.Location = New System.Drawing.Point(320, 352)
        Me._imgGameField_187.Name = "_imgGameField_187"
        Me._imgGameField_187.Size = New System.Drawing.Size(32, 32)
        Me._imgGameField_187.TabIndex = 70
        Me._imgGameField_187.TabStop = False
        '
        '_imgGameField_186
        '
        Me._imgGameField_186.Cursor = System.Windows.Forms.Cursors.Default
        Me.imgGameField.SetIndex(Me._imgGameField_186, CType(186, Short))
        Me._imgGameField_186.Location = New System.Drawing.Point(288, 352)
        Me._imgGameField_186.Name = "_imgGameField_186"
        Me._imgGameField_186.Size = New System.Drawing.Size(32, 32)
        Me._imgGameField_186.TabIndex = 71
        Me._imgGameField_186.TabStop = False
        '
        '_imgGameField_185
        '
        Me._imgGameField_185.Cursor = System.Windows.Forms.Cursors.Default
        Me.imgGameField.SetIndex(Me._imgGameField_185, CType(185, Short))
        Me._imgGameField_185.Location = New System.Drawing.Point(256, 352)
        Me._imgGameField_185.Name = "_imgGameField_185"
        Me._imgGameField_185.Size = New System.Drawing.Size(32, 32)
        Me._imgGameField_185.TabIndex = 72
        Me._imgGameField_185.TabStop = False
        '
        '_imgGameField_184
        '
        Me._imgGameField_184.Cursor = System.Windows.Forms.Cursors.Default
        Me.imgGameField.SetIndex(Me._imgGameField_184, CType(184, Short))
        Me._imgGameField_184.Location = New System.Drawing.Point(224, 352)
        Me._imgGameField_184.Name = "_imgGameField_184"
        Me._imgGameField_184.Size = New System.Drawing.Size(32, 32)
        Me._imgGameField_184.TabIndex = 73
        Me._imgGameField_184.TabStop = False
        '
        '_imgGameField_183
        '
        Me._imgGameField_183.Cursor = System.Windows.Forms.Cursors.Default
        Me.imgGameField.SetIndex(Me._imgGameField_183, CType(183, Short))
        Me._imgGameField_183.Location = New System.Drawing.Point(192, 352)
        Me._imgGameField_183.Name = "_imgGameField_183"
        Me._imgGameField_183.Size = New System.Drawing.Size(32, 32)
        Me._imgGameField_183.TabIndex = 74
        Me._imgGameField_183.TabStop = False
        '
        '_imgGameField_182
        '
        Me._imgGameField_182.Cursor = System.Windows.Forms.Cursors.Default
        Me.imgGameField.SetIndex(Me._imgGameField_182, CType(182, Short))
        Me._imgGameField_182.Location = New System.Drawing.Point(160, 352)
        Me._imgGameField_182.Name = "_imgGameField_182"
        Me._imgGameField_182.Size = New System.Drawing.Size(32, 32)
        Me._imgGameField_182.TabIndex = 75
        Me._imgGameField_182.TabStop = False
        '
        '_imgGameField_181
        '
        Me._imgGameField_181.Cursor = System.Windows.Forms.Cursors.Default
        Me.imgGameField.SetIndex(Me._imgGameField_181, CType(181, Short))
        Me._imgGameField_181.Location = New System.Drawing.Point(128, 352)
        Me._imgGameField_181.Name = "_imgGameField_181"
        Me._imgGameField_181.Size = New System.Drawing.Size(32, 32)
        Me._imgGameField_181.TabIndex = 76
        Me._imgGameField_181.TabStop = False
        '
        '_imgGameField_198
        '
        Me._imgGameField_198.Cursor = System.Windows.Forms.Cursors.Default
        Me.imgGameField.SetIndex(Me._imgGameField_198, CType(198, Short))
        Me._imgGameField_198.Location = New System.Drawing.Point(160, 384)
        Me._imgGameField_198.Name = "_imgGameField_198"
        Me._imgGameField_198.Size = New System.Drawing.Size(32, 32)
        Me._imgGameField_198.TabIndex = 77
        Me._imgGameField_198.TabStop = False
        '
        '_imgGameField_179
        '
        Me._imgGameField_179.Cursor = System.Windows.Forms.Cursors.Default
        Me.imgGameField.SetIndex(Me._imgGameField_179, CType(179, Short))
        Me._imgGameField_179.Location = New System.Drawing.Point(64, 352)
        Me._imgGameField_179.Name = "_imgGameField_179"
        Me._imgGameField_179.Size = New System.Drawing.Size(32, 32)
        Me._imgGameField_179.TabIndex = 78
        Me._imgGameField_179.TabStop = False
        '
        '_imgGameField_178
        '
        Me._imgGameField_178.Cursor = System.Windows.Forms.Cursors.Default
        Me.imgGameField.SetIndex(Me._imgGameField_178, CType(178, Short))
        Me._imgGameField_178.Location = New System.Drawing.Point(32, 352)
        Me._imgGameField_178.Name = "_imgGameField_178"
        Me._imgGameField_178.Size = New System.Drawing.Size(32, 32)
        Me._imgGameField_178.TabIndex = 79
        Me._imgGameField_178.TabStop = False
        '
        '_imgGameField_177
        '
        Me._imgGameField_177.Cursor = System.Windows.Forms.Cursors.Default
        Me.imgGameField.SetIndex(Me._imgGameField_177, CType(177, Short))
        Me._imgGameField_177.Location = New System.Drawing.Point(0, 352)
        Me._imgGameField_177.Name = "_imgGameField_177"
        Me._imgGameField_177.Size = New System.Drawing.Size(32, 32)
        Me._imgGameField_177.TabIndex = 80
        Me._imgGameField_177.TabStop = False
        '
        '_imgGameField_176
        '
        Me._imgGameField_176.Cursor = System.Windows.Forms.Cursors.Default
        Me.imgGameField.SetIndex(Me._imgGameField_176, CType(176, Short))
        Me._imgGameField_176.Location = New System.Drawing.Point(480, 320)
        Me._imgGameField_176.Name = "_imgGameField_176"
        Me._imgGameField_176.Size = New System.Drawing.Size(32, 32)
        Me._imgGameField_176.TabIndex = 81
        Me._imgGameField_176.TabStop = False
        '
        '_imgGameField_175
        '
        Me._imgGameField_175.Cursor = System.Windows.Forms.Cursors.Default
        Me.imgGameField.SetIndex(Me._imgGameField_175, CType(175, Short))
        Me._imgGameField_175.Location = New System.Drawing.Point(448, 320)
        Me._imgGameField_175.Name = "_imgGameField_175"
        Me._imgGameField_175.Size = New System.Drawing.Size(32, 32)
        Me._imgGameField_175.TabIndex = 82
        Me._imgGameField_175.TabStop = False
        '
        '_imgGameField_174
        '
        Me._imgGameField_174.Cursor = System.Windows.Forms.Cursors.Default
        Me.imgGameField.SetIndex(Me._imgGameField_174, CType(174, Short))
        Me._imgGameField_174.Location = New System.Drawing.Point(416, 320)
        Me._imgGameField_174.Name = "_imgGameField_174"
        Me._imgGameField_174.Size = New System.Drawing.Size(32, 32)
        Me._imgGameField_174.TabIndex = 83
        Me._imgGameField_174.TabStop = False
        '
        '_imgGameField_173
        '
        Me._imgGameField_173.Cursor = System.Windows.Forms.Cursors.Default
        Me.imgGameField.SetIndex(Me._imgGameField_173, CType(173, Short))
        Me._imgGameField_173.Location = New System.Drawing.Point(384, 320)
        Me._imgGameField_173.Name = "_imgGameField_173"
        Me._imgGameField_173.Size = New System.Drawing.Size(32, 32)
        Me._imgGameField_173.TabIndex = 84
        Me._imgGameField_173.TabStop = False
        '
        '_imgGameField_172
        '
        Me._imgGameField_172.Cursor = System.Windows.Forms.Cursors.Default
        Me.imgGameField.SetIndex(Me._imgGameField_172, CType(172, Short))
        Me._imgGameField_172.Location = New System.Drawing.Point(352, 320)
        Me._imgGameField_172.Name = "_imgGameField_172"
        Me._imgGameField_172.Size = New System.Drawing.Size(32, 32)
        Me._imgGameField_172.TabIndex = 85
        Me._imgGameField_172.TabStop = False
        '
        '_imgGameField_171
        '
        Me._imgGameField_171.Cursor = System.Windows.Forms.Cursors.Default
        Me.imgGameField.SetIndex(Me._imgGameField_171, CType(171, Short))
        Me._imgGameField_171.Location = New System.Drawing.Point(320, 320)
        Me._imgGameField_171.Name = "_imgGameField_171"
        Me._imgGameField_171.Size = New System.Drawing.Size(32, 32)
        Me._imgGameField_171.TabIndex = 86
        Me._imgGameField_171.TabStop = False
        '
        '_imgGameField_170
        '
        Me._imgGameField_170.Cursor = System.Windows.Forms.Cursors.Default
        Me.imgGameField.SetIndex(Me._imgGameField_170, CType(170, Short))
        Me._imgGameField_170.Location = New System.Drawing.Point(288, 320)
        Me._imgGameField_170.Name = "_imgGameField_170"
        Me._imgGameField_170.Size = New System.Drawing.Size(32, 32)
        Me._imgGameField_170.TabIndex = 87
        Me._imgGameField_170.TabStop = False
        '
        '_imgGameField_169
        '
        Me._imgGameField_169.Cursor = System.Windows.Forms.Cursors.Default
        Me.imgGameField.SetIndex(Me._imgGameField_169, CType(169, Short))
        Me._imgGameField_169.Location = New System.Drawing.Point(256, 320)
        Me._imgGameField_169.Name = "_imgGameField_169"
        Me._imgGameField_169.Size = New System.Drawing.Size(32, 32)
        Me._imgGameField_169.TabIndex = 88
        Me._imgGameField_169.TabStop = False
        '
        '_imgGameField_168
        '
        Me._imgGameField_168.Cursor = System.Windows.Forms.Cursors.Default
        Me.imgGameField.SetIndex(Me._imgGameField_168, CType(168, Short))
        Me._imgGameField_168.Location = New System.Drawing.Point(224, 320)
        Me._imgGameField_168.Name = "_imgGameField_168"
        Me._imgGameField_168.Size = New System.Drawing.Size(32, 32)
        Me._imgGameField_168.TabIndex = 89
        Me._imgGameField_168.TabStop = False
        '
        '_imgGameField_167
        '
        Me._imgGameField_167.Cursor = System.Windows.Forms.Cursors.Default
        Me.imgGameField.SetIndex(Me._imgGameField_167, CType(167, Short))
        Me._imgGameField_167.Location = New System.Drawing.Point(192, 320)
        Me._imgGameField_167.Name = "_imgGameField_167"
        Me._imgGameField_167.Size = New System.Drawing.Size(32, 32)
        Me._imgGameField_167.TabIndex = 90
        Me._imgGameField_167.TabStop = False
        '
        '_imgGameField_166
        '
        Me._imgGameField_166.Cursor = System.Windows.Forms.Cursors.Default
        Me.imgGameField.SetIndex(Me._imgGameField_166, CType(166, Short))
        Me._imgGameField_166.Location = New System.Drawing.Point(160, 320)
        Me._imgGameField_166.Name = "_imgGameField_166"
        Me._imgGameField_166.Size = New System.Drawing.Size(32, 32)
        Me._imgGameField_166.TabIndex = 91
        Me._imgGameField_166.TabStop = False
        '
        '_imgGameField_165
        '
        Me._imgGameField_165.Cursor = System.Windows.Forms.Cursors.Default
        Me.imgGameField.SetIndex(Me._imgGameField_165, CType(165, Short))
        Me._imgGameField_165.Location = New System.Drawing.Point(128, 320)
        Me._imgGameField_165.Name = "_imgGameField_165"
        Me._imgGameField_165.Size = New System.Drawing.Size(32, 32)
        Me._imgGameField_165.TabIndex = 92
        Me._imgGameField_165.TabStop = False
        '
        '_imgGameField_164
        '
        Me._imgGameField_164.Cursor = System.Windows.Forms.Cursors.Default
        Me.imgGameField.SetIndex(Me._imgGameField_164, CType(164, Short))
        Me._imgGameField_164.Location = New System.Drawing.Point(96, 320)
        Me._imgGameField_164.Name = "_imgGameField_164"
        Me._imgGameField_164.Size = New System.Drawing.Size(32, 32)
        Me._imgGameField_164.TabIndex = 93
        Me._imgGameField_164.TabStop = False
        '
        '_imgGameField_163
        '
        Me._imgGameField_163.Cursor = System.Windows.Forms.Cursors.Default
        Me.imgGameField.SetIndex(Me._imgGameField_163, CType(163, Short))
        Me._imgGameField_163.Location = New System.Drawing.Point(64, 320)
        Me._imgGameField_163.Name = "_imgGameField_163"
        Me._imgGameField_163.Size = New System.Drawing.Size(32, 32)
        Me._imgGameField_163.TabIndex = 94
        Me._imgGameField_163.TabStop = False
        '
        '_imgGameField_162
        '
        Me._imgGameField_162.Cursor = System.Windows.Forms.Cursors.Default
        Me.imgGameField.SetIndex(Me._imgGameField_162, CType(162, Short))
        Me._imgGameField_162.Location = New System.Drawing.Point(32, 320)
        Me._imgGameField_162.Name = "_imgGameField_162"
        Me._imgGameField_162.Size = New System.Drawing.Size(32, 32)
        Me._imgGameField_162.TabIndex = 95
        Me._imgGameField_162.TabStop = False
        '
        '_imgGameField_161
        '
        Me._imgGameField_161.Cursor = System.Windows.Forms.Cursors.Default
        Me.imgGameField.SetIndex(Me._imgGameField_161, CType(161, Short))
        Me._imgGameField_161.Location = New System.Drawing.Point(0, 320)
        Me._imgGameField_161.Name = "_imgGameField_161"
        Me._imgGameField_161.Size = New System.Drawing.Size(32, 32)
        Me._imgGameField_161.TabIndex = 96
        Me._imgGameField_161.TabStop = False
        '
        '_imgGameField_180
        '
        Me._imgGameField_180.Cursor = System.Windows.Forms.Cursors.Default
        Me.imgGameField.SetIndex(Me._imgGameField_180, CType(180, Short))
        Me._imgGameField_180.Location = New System.Drawing.Point(96, 352)
        Me._imgGameField_180.Name = "_imgGameField_180"
        Me._imgGameField_180.Size = New System.Drawing.Size(32, 32)
        Me._imgGameField_180.TabIndex = 97
        Me._imgGameField_180.TabStop = False
        '
        '_imgGameField_159
        '
        Me._imgGameField_159.Cursor = System.Windows.Forms.Cursors.Default
        Me.imgGameField.SetIndex(Me._imgGameField_159, CType(159, Short))
        Me._imgGameField_159.Location = New System.Drawing.Point(448, 288)
        Me._imgGameField_159.Name = "_imgGameField_159"
        Me._imgGameField_159.Size = New System.Drawing.Size(32, 32)
        Me._imgGameField_159.TabIndex = 98
        Me._imgGameField_159.TabStop = False
        '
        '_imgGameField_158
        '
        Me._imgGameField_158.Cursor = System.Windows.Forms.Cursors.Default
        Me.imgGameField.SetIndex(Me._imgGameField_158, CType(158, Short))
        Me._imgGameField_158.Location = New System.Drawing.Point(416, 288)
        Me._imgGameField_158.Name = "_imgGameField_158"
        Me._imgGameField_158.Size = New System.Drawing.Size(32, 32)
        Me._imgGameField_158.TabIndex = 99
        Me._imgGameField_158.TabStop = False
        '
        '_imgGameField_157
        '
        Me._imgGameField_157.Cursor = System.Windows.Forms.Cursors.Default
        Me.imgGameField.SetIndex(Me._imgGameField_157, CType(157, Short))
        Me._imgGameField_157.Location = New System.Drawing.Point(384, 288)
        Me._imgGameField_157.Name = "_imgGameField_157"
        Me._imgGameField_157.Size = New System.Drawing.Size(32, 32)
        Me._imgGameField_157.TabIndex = 100
        Me._imgGameField_157.TabStop = False
        '
        '_imgGameField_156
        '
        Me._imgGameField_156.Cursor = System.Windows.Forms.Cursors.Default
        Me.imgGameField.SetIndex(Me._imgGameField_156, CType(156, Short))
        Me._imgGameField_156.Location = New System.Drawing.Point(352, 288)
        Me._imgGameField_156.Name = "_imgGameField_156"
        Me._imgGameField_156.Size = New System.Drawing.Size(32, 32)
        Me._imgGameField_156.TabIndex = 101
        Me._imgGameField_156.TabStop = False
        '
        '_imgGameField_155
        '
        Me._imgGameField_155.Cursor = System.Windows.Forms.Cursors.Default
        Me.imgGameField.SetIndex(Me._imgGameField_155, CType(155, Short))
        Me._imgGameField_155.Location = New System.Drawing.Point(320, 288)
        Me._imgGameField_155.Name = "_imgGameField_155"
        Me._imgGameField_155.Size = New System.Drawing.Size(32, 32)
        Me._imgGameField_155.TabIndex = 102
        Me._imgGameField_155.TabStop = False
        '
        '_imgGameField_154
        '
        Me._imgGameField_154.Cursor = System.Windows.Forms.Cursors.Default
        Me.imgGameField.SetIndex(Me._imgGameField_154, CType(154, Short))
        Me._imgGameField_154.Location = New System.Drawing.Point(288, 288)
        Me._imgGameField_154.Name = "_imgGameField_154"
        Me._imgGameField_154.Size = New System.Drawing.Size(32, 32)
        Me._imgGameField_154.TabIndex = 103
        Me._imgGameField_154.TabStop = False
        '
        '_imgGameField_153
        '
        Me._imgGameField_153.Cursor = System.Windows.Forms.Cursors.Default
        Me.imgGameField.SetIndex(Me._imgGameField_153, CType(153, Short))
        Me._imgGameField_153.Location = New System.Drawing.Point(256, 288)
        Me._imgGameField_153.Name = "_imgGameField_153"
        Me._imgGameField_153.Size = New System.Drawing.Size(32, 32)
        Me._imgGameField_153.TabIndex = 104
        Me._imgGameField_153.TabStop = False
        '
        '_imgGameField_152
        '
        Me._imgGameField_152.Cursor = System.Windows.Forms.Cursors.Default
        Me.imgGameField.SetIndex(Me._imgGameField_152, CType(152, Short))
        Me._imgGameField_152.Location = New System.Drawing.Point(224, 288)
        Me._imgGameField_152.Name = "_imgGameField_152"
        Me._imgGameField_152.Size = New System.Drawing.Size(32, 32)
        Me._imgGameField_152.TabIndex = 105
        Me._imgGameField_152.TabStop = False
        '
        '_imgGameField_151
        '
        Me._imgGameField_151.Cursor = System.Windows.Forms.Cursors.Default
        Me.imgGameField.SetIndex(Me._imgGameField_151, CType(151, Short))
        Me._imgGameField_151.Location = New System.Drawing.Point(192, 288)
        Me._imgGameField_151.Name = "_imgGameField_151"
        Me._imgGameField_151.Size = New System.Drawing.Size(32, 32)
        Me._imgGameField_151.TabIndex = 106
        Me._imgGameField_151.TabStop = False
        '
        '_imgGameField_150
        '
        Me._imgGameField_150.Cursor = System.Windows.Forms.Cursors.Default
        Me.imgGameField.SetIndex(Me._imgGameField_150, CType(150, Short))
        Me._imgGameField_150.Location = New System.Drawing.Point(160, 288)
        Me._imgGameField_150.Name = "_imgGameField_150"
        Me._imgGameField_150.Size = New System.Drawing.Size(32, 32)
        Me._imgGameField_150.TabIndex = 107
        Me._imgGameField_150.TabStop = False
        '
        '_imgGameField_149
        '
        Me._imgGameField_149.Cursor = System.Windows.Forms.Cursors.Default
        Me.imgGameField.SetIndex(Me._imgGameField_149, CType(149, Short))
        Me._imgGameField_149.Location = New System.Drawing.Point(128, 288)
        Me._imgGameField_149.Name = "_imgGameField_149"
        Me._imgGameField_149.Size = New System.Drawing.Size(32, 32)
        Me._imgGameField_149.TabIndex = 108
        Me._imgGameField_149.TabStop = False
        '
        '_imgGameField_148
        '
        Me._imgGameField_148.Cursor = System.Windows.Forms.Cursors.Default
        Me.imgGameField.SetIndex(Me._imgGameField_148, CType(148, Short))
        Me._imgGameField_148.Location = New System.Drawing.Point(96, 288)
        Me._imgGameField_148.Name = "_imgGameField_148"
        Me._imgGameField_148.Size = New System.Drawing.Size(32, 32)
        Me._imgGameField_148.TabIndex = 109
        Me._imgGameField_148.TabStop = False
        '
        '_imgGameField_147
        '
        Me._imgGameField_147.Cursor = System.Windows.Forms.Cursors.Default
        Me.imgGameField.SetIndex(Me._imgGameField_147, CType(147, Short))
        Me._imgGameField_147.Location = New System.Drawing.Point(64, 288)
        Me._imgGameField_147.Name = "_imgGameField_147"
        Me._imgGameField_147.Size = New System.Drawing.Size(32, 32)
        Me._imgGameField_147.TabIndex = 110
        Me._imgGameField_147.TabStop = False
        '
        '_imgGameField_146
        '
        Me._imgGameField_146.Cursor = System.Windows.Forms.Cursors.Default
        Me.imgGameField.SetIndex(Me._imgGameField_146, CType(146, Short))
        Me._imgGameField_146.Location = New System.Drawing.Point(32, 288)
        Me._imgGameField_146.Name = "_imgGameField_146"
        Me._imgGameField_146.Size = New System.Drawing.Size(32, 32)
        Me._imgGameField_146.TabIndex = 111
        Me._imgGameField_146.TabStop = False
        '
        '_imgGameField_145
        '
        Me._imgGameField_145.Cursor = System.Windows.Forms.Cursors.Default
        Me.imgGameField.SetIndex(Me._imgGameField_145, CType(145, Short))
        Me._imgGameField_145.Location = New System.Drawing.Point(0, 288)
        Me._imgGameField_145.Name = "_imgGameField_145"
        Me._imgGameField_145.Size = New System.Drawing.Size(32, 32)
        Me._imgGameField_145.TabIndex = 112
        Me._imgGameField_145.TabStop = False
        '
        '_imgGameField_144
        '
        Me._imgGameField_144.Cursor = System.Windows.Forms.Cursors.Default
        Me.imgGameField.SetIndex(Me._imgGameField_144, CType(144, Short))
        Me._imgGameField_144.Location = New System.Drawing.Point(480, 256)
        Me._imgGameField_144.Name = "_imgGameField_144"
        Me._imgGameField_144.Size = New System.Drawing.Size(32, 32)
        Me._imgGameField_144.TabIndex = 113
        Me._imgGameField_144.TabStop = False
        '
        '_imgGameField_143
        '
        Me._imgGameField_143.Cursor = System.Windows.Forms.Cursors.Default
        Me.imgGameField.SetIndex(Me._imgGameField_143, CType(143, Short))
        Me._imgGameField_143.Location = New System.Drawing.Point(448, 256)
        Me._imgGameField_143.Name = "_imgGameField_143"
        Me._imgGameField_143.Size = New System.Drawing.Size(32, 32)
        Me._imgGameField_143.TabIndex = 114
        Me._imgGameField_143.TabStop = False
        '
        '_imgGameField_142
        '
        Me._imgGameField_142.Cursor = System.Windows.Forms.Cursors.Default
        Me.imgGameField.SetIndex(Me._imgGameField_142, CType(142, Short))
        Me._imgGameField_142.Location = New System.Drawing.Point(416, 256)
        Me._imgGameField_142.Name = "_imgGameField_142"
        Me._imgGameField_142.Size = New System.Drawing.Size(32, 32)
        Me._imgGameField_142.TabIndex = 115
        Me._imgGameField_142.TabStop = False
        '
        '_imgGameField_141
        '
        Me._imgGameField_141.Cursor = System.Windows.Forms.Cursors.Default
        Me.imgGameField.SetIndex(Me._imgGameField_141, CType(141, Short))
        Me._imgGameField_141.Location = New System.Drawing.Point(384, 256)
        Me._imgGameField_141.Name = "_imgGameField_141"
        Me._imgGameField_141.Size = New System.Drawing.Size(32, 32)
        Me._imgGameField_141.TabIndex = 116
        Me._imgGameField_141.TabStop = False
        '
        '_imgGameField_160
        '
        Me._imgGameField_160.Cursor = System.Windows.Forms.Cursors.Default
        Me.imgGameField.SetIndex(Me._imgGameField_160, CType(160, Short))
        Me._imgGameField_160.Location = New System.Drawing.Point(480, 288)
        Me._imgGameField_160.Name = "_imgGameField_160"
        Me._imgGameField_160.Size = New System.Drawing.Size(32, 32)
        Me._imgGameField_160.TabIndex = 117
        Me._imgGameField_160.TabStop = False
        '
        '_imgGameField_140
        '
        Me._imgGameField_140.Cursor = System.Windows.Forms.Cursors.Default
        Me.imgGameField.SetIndex(Me._imgGameField_140, CType(140, Short))
        Me._imgGameField_140.Location = New System.Drawing.Point(352, 256)
        Me._imgGameField_140.Name = "_imgGameField_140"
        Me._imgGameField_140.Size = New System.Drawing.Size(32, 32)
        Me._imgGameField_140.TabIndex = 118
        Me._imgGameField_140.TabStop = False
        '
        '_imgGameField_139
        '
        Me._imgGameField_139.Cursor = System.Windows.Forms.Cursors.Default
        Me.imgGameField.SetIndex(Me._imgGameField_139, CType(139, Short))
        Me._imgGameField_139.Location = New System.Drawing.Point(320, 256)
        Me._imgGameField_139.Name = "_imgGameField_139"
        Me._imgGameField_139.Size = New System.Drawing.Size(32, 32)
        Me._imgGameField_139.TabIndex = 119
        Me._imgGameField_139.TabStop = False
        '
        '_imgGameField_138
        '
        Me._imgGameField_138.Cursor = System.Windows.Forms.Cursors.Default
        Me.imgGameField.SetIndex(Me._imgGameField_138, CType(138, Short))
        Me._imgGameField_138.Location = New System.Drawing.Point(288, 256)
        Me._imgGameField_138.Name = "_imgGameField_138"
        Me._imgGameField_138.Size = New System.Drawing.Size(32, 32)
        Me._imgGameField_138.TabIndex = 120
        Me._imgGameField_138.TabStop = False
        '
        '_imgGameField_137
        '
        Me._imgGameField_137.Cursor = System.Windows.Forms.Cursors.Default
        Me.imgGameField.SetIndex(Me._imgGameField_137, CType(137, Short))
        Me._imgGameField_137.Location = New System.Drawing.Point(256, 256)
        Me._imgGameField_137.Name = "_imgGameField_137"
        Me._imgGameField_137.Size = New System.Drawing.Size(32, 32)
        Me._imgGameField_137.TabIndex = 121
        Me._imgGameField_137.TabStop = False
        '
        '_imgGameField_136
        '
        Me._imgGameField_136.Cursor = System.Windows.Forms.Cursors.Default
        Me.imgGameField.SetIndex(Me._imgGameField_136, CType(136, Short))
        Me._imgGameField_136.Location = New System.Drawing.Point(224, 256)
        Me._imgGameField_136.Name = "_imgGameField_136"
        Me._imgGameField_136.Size = New System.Drawing.Size(32, 32)
        Me._imgGameField_136.TabIndex = 122
        Me._imgGameField_136.TabStop = False
        '
        '_imgGameField_135
        '
        Me._imgGameField_135.Cursor = System.Windows.Forms.Cursors.Default
        Me.imgGameField.SetIndex(Me._imgGameField_135, CType(135, Short))
        Me._imgGameField_135.Location = New System.Drawing.Point(192, 256)
        Me._imgGameField_135.Name = "_imgGameField_135"
        Me._imgGameField_135.Size = New System.Drawing.Size(32, 32)
        Me._imgGameField_135.TabIndex = 123
        Me._imgGameField_135.TabStop = False
        '
        '_imgGameField_134
        '
        Me._imgGameField_134.Cursor = System.Windows.Forms.Cursors.Default
        Me.imgGameField.SetIndex(Me._imgGameField_134, CType(134, Short))
        Me._imgGameField_134.Location = New System.Drawing.Point(160, 256)
        Me._imgGameField_134.Name = "_imgGameField_134"
        Me._imgGameField_134.Size = New System.Drawing.Size(32, 32)
        Me._imgGameField_134.TabIndex = 124
        Me._imgGameField_134.TabStop = False
        '
        '_imgGameField_133
        '
        Me._imgGameField_133.Cursor = System.Windows.Forms.Cursors.Default
        Me.imgGameField.SetIndex(Me._imgGameField_133, CType(133, Short))
        Me._imgGameField_133.Location = New System.Drawing.Point(128, 256)
        Me._imgGameField_133.Name = "_imgGameField_133"
        Me._imgGameField_133.Size = New System.Drawing.Size(32, 32)
        Me._imgGameField_133.TabIndex = 125
        Me._imgGameField_133.TabStop = False
        '
        '_imgGameField_132
        '
        Me._imgGameField_132.Cursor = System.Windows.Forms.Cursors.Default
        Me.imgGameField.SetIndex(Me._imgGameField_132, CType(132, Short))
        Me._imgGameField_132.Location = New System.Drawing.Point(96, 256)
        Me._imgGameField_132.Name = "_imgGameField_132"
        Me._imgGameField_132.Size = New System.Drawing.Size(32, 32)
        Me._imgGameField_132.TabIndex = 126
        Me._imgGameField_132.TabStop = False
        '
        '_imgGameField_131
        '
        Me._imgGameField_131.Cursor = System.Windows.Forms.Cursors.Default
        Me.imgGameField.SetIndex(Me._imgGameField_131, CType(131, Short))
        Me._imgGameField_131.Location = New System.Drawing.Point(64, 256)
        Me._imgGameField_131.Name = "_imgGameField_131"
        Me._imgGameField_131.Size = New System.Drawing.Size(32, 32)
        Me._imgGameField_131.TabIndex = 127
        Me._imgGameField_131.TabStop = False
        '
        '_imgGameField_130
        '
        Me._imgGameField_130.Cursor = System.Windows.Forms.Cursors.Default
        Me.imgGameField.SetIndex(Me._imgGameField_130, CType(130, Short))
        Me._imgGameField_130.Location = New System.Drawing.Point(32, 256)
        Me._imgGameField_130.Name = "_imgGameField_130"
        Me._imgGameField_130.Size = New System.Drawing.Size(32, 32)
        Me._imgGameField_130.TabIndex = 128
        Me._imgGameField_130.TabStop = False
        '
        '_imgGameField_129
        '
        Me._imgGameField_129.Cursor = System.Windows.Forms.Cursors.Default
        Me.imgGameField.SetIndex(Me._imgGameField_129, CType(129, Short))
        Me._imgGameField_129.Location = New System.Drawing.Point(0, 256)
        Me._imgGameField_129.Name = "_imgGameField_129"
        Me._imgGameField_129.Size = New System.Drawing.Size(32, 32)
        Me._imgGameField_129.TabIndex = 129
        Me._imgGameField_129.TabStop = False
        '
        '_imgGameField_128
        '
        Me._imgGameField_128.Cursor = System.Windows.Forms.Cursors.Default
        Me.imgGameField.SetIndex(Me._imgGameField_128, CType(128, Short))
        Me._imgGameField_128.Location = New System.Drawing.Point(480, 224)
        Me._imgGameField_128.Name = "_imgGameField_128"
        Me._imgGameField_128.Size = New System.Drawing.Size(32, 32)
        Me._imgGameField_128.TabIndex = 130
        Me._imgGameField_128.TabStop = False
        '
        '_imgGameField_127
        '
        Me._imgGameField_127.Cursor = System.Windows.Forms.Cursors.Default
        Me.imgGameField.SetIndex(Me._imgGameField_127, CType(127, Short))
        Me._imgGameField_127.Location = New System.Drawing.Point(448, 224)
        Me._imgGameField_127.Name = "_imgGameField_127"
        Me._imgGameField_127.Size = New System.Drawing.Size(32, 32)
        Me._imgGameField_127.TabIndex = 131
        Me._imgGameField_127.TabStop = False
        '
        '_imgGameField_126
        '
        Me._imgGameField_126.Cursor = System.Windows.Forms.Cursors.Default
        Me.imgGameField.SetIndex(Me._imgGameField_126, CType(126, Short))
        Me._imgGameField_126.Location = New System.Drawing.Point(416, 224)
        Me._imgGameField_126.Name = "_imgGameField_126"
        Me._imgGameField_126.Size = New System.Drawing.Size(32, 32)
        Me._imgGameField_126.TabIndex = 132
        Me._imgGameField_126.TabStop = False
        '
        '_imgGameField_125
        '
        Me._imgGameField_125.Cursor = System.Windows.Forms.Cursors.Default
        Me.imgGameField.SetIndex(Me._imgGameField_125, CType(125, Short))
        Me._imgGameField_125.Location = New System.Drawing.Point(384, 224)
        Me._imgGameField_125.Name = "_imgGameField_125"
        Me._imgGameField_125.Size = New System.Drawing.Size(32, 32)
        Me._imgGameField_125.TabIndex = 133
        Me._imgGameField_125.TabStop = False
        '
        '_imgGameField_124
        '
        Me._imgGameField_124.Cursor = System.Windows.Forms.Cursors.Default
        Me.imgGameField.SetIndex(Me._imgGameField_124, CType(124, Short))
        Me._imgGameField_124.Location = New System.Drawing.Point(352, 224)
        Me._imgGameField_124.Name = "_imgGameField_124"
        Me._imgGameField_124.Size = New System.Drawing.Size(32, 32)
        Me._imgGameField_124.TabIndex = 134
        Me._imgGameField_124.TabStop = False
        '
        '_imgGameField_123
        '
        Me._imgGameField_123.Cursor = System.Windows.Forms.Cursors.Default
        Me.imgGameField.SetIndex(Me._imgGameField_123, CType(123, Short))
        Me._imgGameField_123.Location = New System.Drawing.Point(320, 224)
        Me._imgGameField_123.Name = "_imgGameField_123"
        Me._imgGameField_123.Size = New System.Drawing.Size(32, 32)
        Me._imgGameField_123.TabIndex = 135
        Me._imgGameField_123.TabStop = False
        '
        '_imgGameField_122
        '
        Me._imgGameField_122.Cursor = System.Windows.Forms.Cursors.Default
        Me.imgGameField.SetIndex(Me._imgGameField_122, CType(122, Short))
        Me._imgGameField_122.Location = New System.Drawing.Point(288, 224)
        Me._imgGameField_122.Name = "_imgGameField_122"
        Me._imgGameField_122.Size = New System.Drawing.Size(32, 32)
        Me._imgGameField_122.TabIndex = 136
        Me._imgGameField_122.TabStop = False
        '
        '_imgGameField_121
        '
        Me._imgGameField_121.Cursor = System.Windows.Forms.Cursors.Default
        Me.imgGameField.SetIndex(Me._imgGameField_121, CType(121, Short))
        Me._imgGameField_121.Location = New System.Drawing.Point(256, 224)
        Me._imgGameField_121.Name = "_imgGameField_121"
        Me._imgGameField_121.Size = New System.Drawing.Size(32, 32)
        Me._imgGameField_121.TabIndex = 137
        Me._imgGameField_121.TabStop = False
        '
        '_imgGameField_120
        '
        Me._imgGameField_120.Cursor = System.Windows.Forms.Cursors.Default
        Me.imgGameField.SetIndex(Me._imgGameField_120, CType(120, Short))
        Me._imgGameField_120.Location = New System.Drawing.Point(224, 224)
        Me._imgGameField_120.Name = "_imgGameField_120"
        Me._imgGameField_120.Size = New System.Drawing.Size(32, 32)
        Me._imgGameField_120.TabIndex = 138
        Me._imgGameField_120.TabStop = False
        '
        '_imgGameField_119
        '
        Me._imgGameField_119.Cursor = System.Windows.Forms.Cursors.Default
        Me.imgGameField.SetIndex(Me._imgGameField_119, CType(119, Short))
        Me._imgGameField_119.Location = New System.Drawing.Point(192, 224)
        Me._imgGameField_119.Name = "_imgGameField_119"
        Me._imgGameField_119.Size = New System.Drawing.Size(32, 32)
        Me._imgGameField_119.TabIndex = 139
        Me._imgGameField_119.TabStop = False
        '
        '_imgGameField_118
        '
        Me._imgGameField_118.Cursor = System.Windows.Forms.Cursors.Default
        Me.imgGameField.SetIndex(Me._imgGameField_118, CType(118, Short))
        Me._imgGameField_118.Location = New System.Drawing.Point(160, 224)
        Me._imgGameField_118.Name = "_imgGameField_118"
        Me._imgGameField_118.Size = New System.Drawing.Size(32, 32)
        Me._imgGameField_118.TabIndex = 140
        Me._imgGameField_118.TabStop = False
        '
        '_imgGameField_117
        '
        Me._imgGameField_117.Cursor = System.Windows.Forms.Cursors.Default
        Me.imgGameField.SetIndex(Me._imgGameField_117, CType(117, Short))
        Me._imgGameField_117.Location = New System.Drawing.Point(128, 224)
        Me._imgGameField_117.Name = "_imgGameField_117"
        Me._imgGameField_117.Size = New System.Drawing.Size(32, 32)
        Me._imgGameField_117.TabIndex = 141
        Me._imgGameField_117.TabStop = False
        '
        '_imgGameField_116
        '
        Me._imgGameField_116.Cursor = System.Windows.Forms.Cursors.Default
        Me.imgGameField.SetIndex(Me._imgGameField_116, CType(116, Short))
        Me._imgGameField_116.Location = New System.Drawing.Point(96, 224)
        Me._imgGameField_116.Name = "_imgGameField_116"
        Me._imgGameField_116.Size = New System.Drawing.Size(32, 32)
        Me._imgGameField_116.TabIndex = 142
        Me._imgGameField_116.TabStop = False
        '
        '_imgGameField_115
        '
        Me._imgGameField_115.Cursor = System.Windows.Forms.Cursors.Default
        Me.imgGameField.SetIndex(Me._imgGameField_115, CType(115, Short))
        Me._imgGameField_115.Location = New System.Drawing.Point(64, 224)
        Me._imgGameField_115.Name = "_imgGameField_115"
        Me._imgGameField_115.Size = New System.Drawing.Size(32, 32)
        Me._imgGameField_115.TabIndex = 143
        Me._imgGameField_115.TabStop = False
        '
        '_imgGameField_114
        '
        Me._imgGameField_114.Cursor = System.Windows.Forms.Cursors.Default
        Me.imgGameField.SetIndex(Me._imgGameField_114, CType(114, Short))
        Me._imgGameField_114.Location = New System.Drawing.Point(32, 224)
        Me._imgGameField_114.Name = "_imgGameField_114"
        Me._imgGameField_114.Size = New System.Drawing.Size(32, 32)
        Me._imgGameField_114.TabIndex = 144
        Me._imgGameField_114.TabStop = False
        '
        '_imgGameField_113
        '
        Me._imgGameField_113.Cursor = System.Windows.Forms.Cursors.Default
        Me.imgGameField.SetIndex(Me._imgGameField_113, CType(113, Short))
        Me._imgGameField_113.Location = New System.Drawing.Point(0, 224)
        Me._imgGameField_113.Name = "_imgGameField_113"
        Me._imgGameField_113.Size = New System.Drawing.Size(32, 32)
        Me._imgGameField_113.TabIndex = 145
        Me._imgGameField_113.TabStop = False
        '
        '_imgGameField_112
        '
        Me._imgGameField_112.Cursor = System.Windows.Forms.Cursors.Default
        Me.imgGameField.SetIndex(Me._imgGameField_112, CType(112, Short))
        Me._imgGameField_112.Location = New System.Drawing.Point(480, 192)
        Me._imgGameField_112.Name = "_imgGameField_112"
        Me._imgGameField_112.Size = New System.Drawing.Size(32, 32)
        Me._imgGameField_112.TabIndex = 146
        Me._imgGameField_112.TabStop = False
        '
        '_imgGameField_111
        '
        Me._imgGameField_111.Cursor = System.Windows.Forms.Cursors.Default
        Me.imgGameField.SetIndex(Me._imgGameField_111, CType(111, Short))
        Me._imgGameField_111.Location = New System.Drawing.Point(448, 192)
        Me._imgGameField_111.Name = "_imgGameField_111"
        Me._imgGameField_111.Size = New System.Drawing.Size(32, 32)
        Me._imgGameField_111.TabIndex = 147
        Me._imgGameField_111.TabStop = False
        '
        '_imgGameField_110
        '
        Me._imgGameField_110.Cursor = System.Windows.Forms.Cursors.Default
        Me.imgGameField.SetIndex(Me._imgGameField_110, CType(110, Short))
        Me._imgGameField_110.Location = New System.Drawing.Point(416, 192)
        Me._imgGameField_110.Name = "_imgGameField_110"
        Me._imgGameField_110.Size = New System.Drawing.Size(32, 32)
        Me._imgGameField_110.TabIndex = 148
        Me._imgGameField_110.TabStop = False
        '
        '_imgGameField_109
        '
        Me._imgGameField_109.Cursor = System.Windows.Forms.Cursors.Default
        Me.imgGameField.SetIndex(Me._imgGameField_109, CType(109, Short))
        Me._imgGameField_109.Location = New System.Drawing.Point(384, 192)
        Me._imgGameField_109.Name = "_imgGameField_109"
        Me._imgGameField_109.Size = New System.Drawing.Size(32, 32)
        Me._imgGameField_109.TabIndex = 149
        Me._imgGameField_109.TabStop = False
        '
        '_imgGameField_108
        '
        Me._imgGameField_108.Cursor = System.Windows.Forms.Cursors.Default
        Me.imgGameField.SetIndex(Me._imgGameField_108, CType(108, Short))
        Me._imgGameField_108.Location = New System.Drawing.Point(352, 192)
        Me._imgGameField_108.Name = "_imgGameField_108"
        Me._imgGameField_108.Size = New System.Drawing.Size(32, 32)
        Me._imgGameField_108.TabIndex = 150
        Me._imgGameField_108.TabStop = False
        '
        '_imgGameField_107
        '
        Me._imgGameField_107.Cursor = System.Windows.Forms.Cursors.Default
        Me.imgGameField.SetIndex(Me._imgGameField_107, CType(107, Short))
        Me._imgGameField_107.Location = New System.Drawing.Point(320, 192)
        Me._imgGameField_107.Name = "_imgGameField_107"
        Me._imgGameField_107.Size = New System.Drawing.Size(32, 32)
        Me._imgGameField_107.TabIndex = 151
        Me._imgGameField_107.TabStop = False
        '
        '_imgGameField_106
        '
        Me._imgGameField_106.Cursor = System.Windows.Forms.Cursors.Default
        Me.imgGameField.SetIndex(Me._imgGameField_106, CType(106, Short))
        Me._imgGameField_106.Location = New System.Drawing.Point(288, 192)
        Me._imgGameField_106.Name = "_imgGameField_106"
        Me._imgGameField_106.Size = New System.Drawing.Size(32, 32)
        Me._imgGameField_106.TabIndex = 152
        Me._imgGameField_106.TabStop = False
        '
        '_imgGameField_105
        '
        Me._imgGameField_105.Cursor = System.Windows.Forms.Cursors.Default
        Me.imgGameField.SetIndex(Me._imgGameField_105, CType(105, Short))
        Me._imgGameField_105.Location = New System.Drawing.Point(256, 192)
        Me._imgGameField_105.Name = "_imgGameField_105"
        Me._imgGameField_105.Size = New System.Drawing.Size(32, 32)
        Me._imgGameField_105.TabIndex = 153
        Me._imgGameField_105.TabStop = False
        '
        '_imgGameField_104
        '
        Me._imgGameField_104.Cursor = System.Windows.Forms.Cursors.Default
        Me.imgGameField.SetIndex(Me._imgGameField_104, CType(104, Short))
        Me._imgGameField_104.Location = New System.Drawing.Point(224, 192)
        Me._imgGameField_104.Name = "_imgGameField_104"
        Me._imgGameField_104.Size = New System.Drawing.Size(32, 32)
        Me._imgGameField_104.TabIndex = 154
        Me._imgGameField_104.TabStop = False
        '
        '_imgGameField_103
        '
        Me._imgGameField_103.Cursor = System.Windows.Forms.Cursors.Default
        Me.imgGameField.SetIndex(Me._imgGameField_103, CType(103, Short))
        Me._imgGameField_103.Location = New System.Drawing.Point(192, 192)
        Me._imgGameField_103.Name = "_imgGameField_103"
        Me._imgGameField_103.Size = New System.Drawing.Size(32, 32)
        Me._imgGameField_103.TabIndex = 155
        Me._imgGameField_103.TabStop = False
        '
        '_imgGameField_102
        '
        Me._imgGameField_102.Cursor = System.Windows.Forms.Cursors.Default
        Me.imgGameField.SetIndex(Me._imgGameField_102, CType(102, Short))
        Me._imgGameField_102.Location = New System.Drawing.Point(160, 192)
        Me._imgGameField_102.Name = "_imgGameField_102"
        Me._imgGameField_102.Size = New System.Drawing.Size(32, 32)
        Me._imgGameField_102.TabIndex = 156
        Me._imgGameField_102.TabStop = False
        '
        '_imgGameField_101
        '
        Me._imgGameField_101.Cursor = System.Windows.Forms.Cursors.Default
        Me.imgGameField.SetIndex(Me._imgGameField_101, CType(101, Short))
        Me._imgGameField_101.Location = New System.Drawing.Point(128, 192)
        Me._imgGameField_101.Name = "_imgGameField_101"
        Me._imgGameField_101.Size = New System.Drawing.Size(32, 32)
        Me._imgGameField_101.TabIndex = 157
        Me._imgGameField_101.TabStop = False
        '
        '_imgGameField_2
        '
        Me._imgGameField_2.Cursor = System.Windows.Forms.Cursors.Default
        Me.imgGameField.SetIndex(Me._imgGameField_2, CType(2, Short))
        Me._imgGameField_2.Location = New System.Drawing.Point(32, 0)
        Me._imgGameField_2.Name = "_imgGameField_2"
        Me._imgGameField_2.Size = New System.Drawing.Size(32, 32)
        Me._imgGameField_2.TabIndex = 158
        Me._imgGameField_2.TabStop = False
        '
        '_imgGameField_1
        '
        Me._imgGameField_1.Cursor = System.Windows.Forms.Cursors.Default
        Me.imgGameField.SetIndex(Me._imgGameField_1, CType(1, Short))
        Me._imgGameField_1.Location = New System.Drawing.Point(0, 0)
        Me._imgGameField_1.Name = "_imgGameField_1"
        Me._imgGameField_1.Size = New System.Drawing.Size(32, 32)
        Me._imgGameField_1.TabIndex = 159
        Me._imgGameField_1.TabStop = False
        '
        '_imgGameField_3
        '
        Me._imgGameField_3.Cursor = System.Windows.Forms.Cursors.Default
        Me.imgGameField.SetIndex(Me._imgGameField_3, CType(3, Short))
        Me._imgGameField_3.Location = New System.Drawing.Point(64, 0)
        Me._imgGameField_3.Name = "_imgGameField_3"
        Me._imgGameField_3.Size = New System.Drawing.Size(32, 32)
        Me._imgGameField_3.TabIndex = 160
        Me._imgGameField_3.TabStop = False
        '
        '_imgGameField_4
        '
        Me._imgGameField_4.Cursor = System.Windows.Forms.Cursors.Default
        Me.imgGameField.SetIndex(Me._imgGameField_4, CType(4, Short))
        Me._imgGameField_4.Location = New System.Drawing.Point(96, 0)
        Me._imgGameField_4.Name = "_imgGameField_4"
        Me._imgGameField_4.Size = New System.Drawing.Size(32, 32)
        Me._imgGameField_4.TabIndex = 161
        Me._imgGameField_4.TabStop = False
        '
        '_imgGameField_5
        '
        Me._imgGameField_5.Cursor = System.Windows.Forms.Cursors.Default
        Me.imgGameField.SetIndex(Me._imgGameField_5, CType(5, Short))
        Me._imgGameField_5.Location = New System.Drawing.Point(128, 0)
        Me._imgGameField_5.Name = "_imgGameField_5"
        Me._imgGameField_5.Size = New System.Drawing.Size(32, 32)
        Me._imgGameField_5.TabIndex = 162
        Me._imgGameField_5.TabStop = False
        '
        '_imgGameField_6
        '
        Me._imgGameField_6.Cursor = System.Windows.Forms.Cursors.Default
        Me.imgGameField.SetIndex(Me._imgGameField_6, CType(6, Short))
        Me._imgGameField_6.Location = New System.Drawing.Point(160, 0)
        Me._imgGameField_6.Name = "_imgGameField_6"
        Me._imgGameField_6.Size = New System.Drawing.Size(32, 32)
        Me._imgGameField_6.TabIndex = 163
        Me._imgGameField_6.TabStop = False
        '
        '_imgGameField_7
        '
        Me._imgGameField_7.Cursor = System.Windows.Forms.Cursors.Default
        Me.imgGameField.SetIndex(Me._imgGameField_7, CType(7, Short))
        Me._imgGameField_7.Location = New System.Drawing.Point(192, 0)
        Me._imgGameField_7.Name = "_imgGameField_7"
        Me._imgGameField_7.Size = New System.Drawing.Size(32, 32)
        Me._imgGameField_7.TabIndex = 164
        Me._imgGameField_7.TabStop = False
        '
        '_imgGameField_8
        '
        Me._imgGameField_8.Cursor = System.Windows.Forms.Cursors.Default
        Me.imgGameField.SetIndex(Me._imgGameField_8, CType(8, Short))
        Me._imgGameField_8.Location = New System.Drawing.Point(224, 0)
        Me._imgGameField_8.Name = "_imgGameField_8"
        Me._imgGameField_8.Size = New System.Drawing.Size(32, 32)
        Me._imgGameField_8.TabIndex = 165
        Me._imgGameField_8.TabStop = False
        '
        '_imgGameField_9
        '
        Me._imgGameField_9.Cursor = System.Windows.Forms.Cursors.Default
        Me.imgGameField.SetIndex(Me._imgGameField_9, CType(9, Short))
        Me._imgGameField_9.Location = New System.Drawing.Point(256, 0)
        Me._imgGameField_9.Name = "_imgGameField_9"
        Me._imgGameField_9.Size = New System.Drawing.Size(32, 32)
        Me._imgGameField_9.TabIndex = 166
        Me._imgGameField_9.TabStop = False
        '
        '_imgGameField_10
        '
        Me._imgGameField_10.Cursor = System.Windows.Forms.Cursors.Default
        Me.imgGameField.SetIndex(Me._imgGameField_10, CType(10, Short))
        Me._imgGameField_10.Location = New System.Drawing.Point(288, 0)
        Me._imgGameField_10.Name = "_imgGameField_10"
        Me._imgGameField_10.Size = New System.Drawing.Size(32, 32)
        Me._imgGameField_10.TabIndex = 167
        Me._imgGameField_10.TabStop = False
        '
        '_imgGameField_12
        '
        Me._imgGameField_12.Cursor = System.Windows.Forms.Cursors.Default
        Me.imgGameField.SetIndex(Me._imgGameField_12, CType(12, Short))
        Me._imgGameField_12.Location = New System.Drawing.Point(352, 0)
        Me._imgGameField_12.Name = "_imgGameField_12"
        Me._imgGameField_12.Size = New System.Drawing.Size(32, 32)
        Me._imgGameField_12.TabIndex = 168
        Me._imgGameField_12.TabStop = False
        '
        '_imgGameField_11
        '
        Me._imgGameField_11.Cursor = System.Windows.Forms.Cursors.Default
        Me.imgGameField.SetIndex(Me._imgGameField_11, CType(11, Short))
        Me._imgGameField_11.Location = New System.Drawing.Point(320, 0)
        Me._imgGameField_11.Name = "_imgGameField_11"
        Me._imgGameField_11.Size = New System.Drawing.Size(32, 32)
        Me._imgGameField_11.TabIndex = 169
        Me._imgGameField_11.TabStop = False
        '
        '_imgGameField_13
        '
        Me._imgGameField_13.Cursor = System.Windows.Forms.Cursors.Default
        Me.imgGameField.SetIndex(Me._imgGameField_13, CType(13, Short))
        Me._imgGameField_13.Location = New System.Drawing.Point(384, 0)
        Me._imgGameField_13.Name = "_imgGameField_13"
        Me._imgGameField_13.Size = New System.Drawing.Size(32, 32)
        Me._imgGameField_13.TabIndex = 170
        Me._imgGameField_13.TabStop = False
        '
        '_imgGameField_14
        '
        Me._imgGameField_14.Cursor = System.Windows.Forms.Cursors.Default
        Me.imgGameField.SetIndex(Me._imgGameField_14, CType(14, Short))
        Me._imgGameField_14.Location = New System.Drawing.Point(416, 0)
        Me._imgGameField_14.Name = "_imgGameField_14"
        Me._imgGameField_14.Size = New System.Drawing.Size(32, 32)
        Me._imgGameField_14.TabIndex = 171
        Me._imgGameField_14.TabStop = False
        '
        '_imgGameField_15
        '
        Me._imgGameField_15.Cursor = System.Windows.Forms.Cursors.Default
        Me.imgGameField.SetIndex(Me._imgGameField_15, CType(15, Short))
        Me._imgGameField_15.Location = New System.Drawing.Point(448, 0)
        Me._imgGameField_15.Name = "_imgGameField_15"
        Me._imgGameField_15.Size = New System.Drawing.Size(32, 32)
        Me._imgGameField_15.TabIndex = 172
        Me._imgGameField_15.TabStop = False
        '
        '_imgGameField_16
        '
        Me._imgGameField_16.Cursor = System.Windows.Forms.Cursors.Default
        Me.imgGameField.SetIndex(Me._imgGameField_16, CType(16, Short))
        Me._imgGameField_16.Location = New System.Drawing.Point(480, 0)
        Me._imgGameField_16.Name = "_imgGameField_16"
        Me._imgGameField_16.Size = New System.Drawing.Size(32, 32)
        Me._imgGameField_16.TabIndex = 173
        Me._imgGameField_16.TabStop = False
        '
        '_imgGameField_17
        '
        Me._imgGameField_17.Cursor = System.Windows.Forms.Cursors.Default
        Me.imgGameField.SetIndex(Me._imgGameField_17, CType(17, Short))
        Me._imgGameField_17.Location = New System.Drawing.Point(0, 32)
        Me._imgGameField_17.Name = "_imgGameField_17"
        Me._imgGameField_17.Size = New System.Drawing.Size(32, 32)
        Me._imgGameField_17.TabIndex = 174
        Me._imgGameField_17.TabStop = False
        '
        '_imgGameField_18
        '
        Me._imgGameField_18.Cursor = System.Windows.Forms.Cursors.Default
        Me.imgGameField.SetIndex(Me._imgGameField_18, CType(18, Short))
        Me._imgGameField_18.Location = New System.Drawing.Point(32, 32)
        Me._imgGameField_18.Name = "_imgGameField_18"
        Me._imgGameField_18.Size = New System.Drawing.Size(32, 32)
        Me._imgGameField_18.TabIndex = 175
        Me._imgGameField_18.TabStop = False
        '
        '_imgGameField_19
        '
        Me._imgGameField_19.Cursor = System.Windows.Forms.Cursors.Default
        Me.imgGameField.SetIndex(Me._imgGameField_19, CType(19, Short))
        Me._imgGameField_19.Location = New System.Drawing.Point(64, 32)
        Me._imgGameField_19.Name = "_imgGameField_19"
        Me._imgGameField_19.Size = New System.Drawing.Size(32, 32)
        Me._imgGameField_19.TabIndex = 176
        Me._imgGameField_19.TabStop = False
        '
        '_imgGameField_20
        '
        Me._imgGameField_20.Cursor = System.Windows.Forms.Cursors.Default
        Me.imgGameField.SetIndex(Me._imgGameField_20, CType(20, Short))
        Me._imgGameField_20.Location = New System.Drawing.Point(96, 32)
        Me._imgGameField_20.Name = "_imgGameField_20"
        Me._imgGameField_20.Size = New System.Drawing.Size(32, 32)
        Me._imgGameField_20.TabIndex = 177
        Me._imgGameField_20.TabStop = False
        '
        '_imgGameField_22
        '
        Me._imgGameField_22.Cursor = System.Windows.Forms.Cursors.Default
        Me.imgGameField.SetIndex(Me._imgGameField_22, CType(22, Short))
        Me._imgGameField_22.Location = New System.Drawing.Point(160, 32)
        Me._imgGameField_22.Name = "_imgGameField_22"
        Me._imgGameField_22.Size = New System.Drawing.Size(32, 32)
        Me._imgGameField_22.TabIndex = 178
        Me._imgGameField_22.TabStop = False
        '
        '_imgGameField_21
        '
        Me._imgGameField_21.Cursor = System.Windows.Forms.Cursors.Default
        Me.imgGameField.SetIndex(Me._imgGameField_21, CType(21, Short))
        Me._imgGameField_21.Location = New System.Drawing.Point(128, 32)
        Me._imgGameField_21.Name = "_imgGameField_21"
        Me._imgGameField_21.Size = New System.Drawing.Size(32, 32)
        Me._imgGameField_21.TabIndex = 179
        Me._imgGameField_21.TabStop = False
        '
        '_imgGameField_23
        '
        Me._imgGameField_23.Cursor = System.Windows.Forms.Cursors.Default
        Me.imgGameField.SetIndex(Me._imgGameField_23, CType(23, Short))
        Me._imgGameField_23.Location = New System.Drawing.Point(192, 32)
        Me._imgGameField_23.Name = "_imgGameField_23"
        Me._imgGameField_23.Size = New System.Drawing.Size(32, 32)
        Me._imgGameField_23.TabIndex = 180
        Me._imgGameField_23.TabStop = False
        '
        '_imgGameField_24
        '
        Me._imgGameField_24.Cursor = System.Windows.Forms.Cursors.Default
        Me.imgGameField.SetIndex(Me._imgGameField_24, CType(24, Short))
        Me._imgGameField_24.Location = New System.Drawing.Point(224, 32)
        Me._imgGameField_24.Name = "_imgGameField_24"
        Me._imgGameField_24.Size = New System.Drawing.Size(32, 32)
        Me._imgGameField_24.TabIndex = 181
        Me._imgGameField_24.TabStop = False
        '
        '_imgGameField_25
        '
        Me._imgGameField_25.Cursor = System.Windows.Forms.Cursors.Default
        Me.imgGameField.SetIndex(Me._imgGameField_25, CType(25, Short))
        Me._imgGameField_25.Location = New System.Drawing.Point(256, 32)
        Me._imgGameField_25.Name = "_imgGameField_25"
        Me._imgGameField_25.Size = New System.Drawing.Size(32, 32)
        Me._imgGameField_25.TabIndex = 182
        Me._imgGameField_25.TabStop = False
        '
        '_imgGameField_26
        '
        Me._imgGameField_26.Cursor = System.Windows.Forms.Cursors.Default
        Me.imgGameField.SetIndex(Me._imgGameField_26, CType(26, Short))
        Me._imgGameField_26.Location = New System.Drawing.Point(288, 32)
        Me._imgGameField_26.Name = "_imgGameField_26"
        Me._imgGameField_26.Size = New System.Drawing.Size(32, 32)
        Me._imgGameField_26.TabIndex = 183
        Me._imgGameField_26.TabStop = False
        '
        '_imgGameField_27
        '
        Me._imgGameField_27.Cursor = System.Windows.Forms.Cursors.Default
        Me.imgGameField.SetIndex(Me._imgGameField_27, CType(27, Short))
        Me._imgGameField_27.Location = New System.Drawing.Point(320, 32)
        Me._imgGameField_27.Name = "_imgGameField_27"
        Me._imgGameField_27.Size = New System.Drawing.Size(32, 32)
        Me._imgGameField_27.TabIndex = 184
        Me._imgGameField_27.TabStop = False
        '
        '_imgGameField_28
        '
        Me._imgGameField_28.Cursor = System.Windows.Forms.Cursors.Default
        Me.imgGameField.SetIndex(Me._imgGameField_28, CType(28, Short))
        Me._imgGameField_28.Location = New System.Drawing.Point(352, 32)
        Me._imgGameField_28.Name = "_imgGameField_28"
        Me._imgGameField_28.Size = New System.Drawing.Size(32, 32)
        Me._imgGameField_28.TabIndex = 185
        Me._imgGameField_28.TabStop = False
        '
        '_imgGameField_29
        '
        Me._imgGameField_29.Cursor = System.Windows.Forms.Cursors.Default
        Me.imgGameField.SetIndex(Me._imgGameField_29, CType(29, Short))
        Me._imgGameField_29.Location = New System.Drawing.Point(384, 32)
        Me._imgGameField_29.Name = "_imgGameField_29"
        Me._imgGameField_29.Size = New System.Drawing.Size(32, 32)
        Me._imgGameField_29.TabIndex = 186
        Me._imgGameField_29.TabStop = False
        '
        '_imgGameField_30
        '
        Me._imgGameField_30.Cursor = System.Windows.Forms.Cursors.Default
        Me.imgGameField.SetIndex(Me._imgGameField_30, CType(30, Short))
        Me._imgGameField_30.Location = New System.Drawing.Point(416, 32)
        Me._imgGameField_30.Name = "_imgGameField_30"
        Me._imgGameField_30.Size = New System.Drawing.Size(32, 32)
        Me._imgGameField_30.TabIndex = 187
        Me._imgGameField_30.TabStop = False
        '
        '_imgGameField_32
        '
        Me._imgGameField_32.Cursor = System.Windows.Forms.Cursors.Default
        Me.imgGameField.SetIndex(Me._imgGameField_32, CType(32, Short))
        Me._imgGameField_32.Location = New System.Drawing.Point(480, 32)
        Me._imgGameField_32.Name = "_imgGameField_32"
        Me._imgGameField_32.Size = New System.Drawing.Size(32, 32)
        Me._imgGameField_32.TabIndex = 188
        Me._imgGameField_32.TabStop = False
        '
        '_imgGameField_31
        '
        Me._imgGameField_31.Cursor = System.Windows.Forms.Cursors.Default
        Me.imgGameField.SetIndex(Me._imgGameField_31, CType(31, Short))
        Me._imgGameField_31.Location = New System.Drawing.Point(448, 32)
        Me._imgGameField_31.Name = "_imgGameField_31"
        Me._imgGameField_31.Size = New System.Drawing.Size(32, 32)
        Me._imgGameField_31.TabIndex = 189
        Me._imgGameField_31.TabStop = False
        '
        '_imgGameField_33
        '
        Me._imgGameField_33.Cursor = System.Windows.Forms.Cursors.Default
        Me.imgGameField.SetIndex(Me._imgGameField_33, CType(33, Short))
        Me._imgGameField_33.Location = New System.Drawing.Point(0, 64)
        Me._imgGameField_33.Name = "_imgGameField_33"
        Me._imgGameField_33.Size = New System.Drawing.Size(32, 32)
        Me._imgGameField_33.TabIndex = 190
        Me._imgGameField_33.TabStop = False
        '
        '_imgGameField_34
        '
        Me._imgGameField_34.Cursor = System.Windows.Forms.Cursors.Default
        Me.imgGameField.SetIndex(Me._imgGameField_34, CType(34, Short))
        Me._imgGameField_34.Location = New System.Drawing.Point(32, 64)
        Me._imgGameField_34.Name = "_imgGameField_34"
        Me._imgGameField_34.Size = New System.Drawing.Size(32, 32)
        Me._imgGameField_34.TabIndex = 191
        Me._imgGameField_34.TabStop = False
        '
        '_imgGameField_35
        '
        Me._imgGameField_35.Cursor = System.Windows.Forms.Cursors.Default
        Me.imgGameField.SetIndex(Me._imgGameField_35, CType(35, Short))
        Me._imgGameField_35.Location = New System.Drawing.Point(64, 64)
        Me._imgGameField_35.Name = "_imgGameField_35"
        Me._imgGameField_35.Size = New System.Drawing.Size(32, 32)
        Me._imgGameField_35.TabIndex = 192
        Me._imgGameField_35.TabStop = False
        '
        '_imgGameField_36
        '
        Me._imgGameField_36.Cursor = System.Windows.Forms.Cursors.Default
        Me.imgGameField.SetIndex(Me._imgGameField_36, CType(36, Short))
        Me._imgGameField_36.Location = New System.Drawing.Point(96, 64)
        Me._imgGameField_36.Name = "_imgGameField_36"
        Me._imgGameField_36.Size = New System.Drawing.Size(32, 32)
        Me._imgGameField_36.TabIndex = 193
        Me._imgGameField_36.TabStop = False
        '
        '_imgGameField_37
        '
        Me._imgGameField_37.Cursor = System.Windows.Forms.Cursors.Default
        Me.imgGameField.SetIndex(Me._imgGameField_37, CType(37, Short))
        Me._imgGameField_37.Location = New System.Drawing.Point(128, 64)
        Me._imgGameField_37.Name = "_imgGameField_37"
        Me._imgGameField_37.Size = New System.Drawing.Size(32, 32)
        Me._imgGameField_37.TabIndex = 194
        Me._imgGameField_37.TabStop = False
        '
        '_imgGameField_38
        '
        Me._imgGameField_38.Cursor = System.Windows.Forms.Cursors.Default
        Me.imgGameField.SetIndex(Me._imgGameField_38, CType(38, Short))
        Me._imgGameField_38.Location = New System.Drawing.Point(160, 64)
        Me._imgGameField_38.Name = "_imgGameField_38"
        Me._imgGameField_38.Size = New System.Drawing.Size(32, 32)
        Me._imgGameField_38.TabIndex = 195
        Me._imgGameField_38.TabStop = False
        '
        '_imgGameField_39
        '
        Me._imgGameField_39.Cursor = System.Windows.Forms.Cursors.Default
        Me.imgGameField.SetIndex(Me._imgGameField_39, CType(39, Short))
        Me._imgGameField_39.Location = New System.Drawing.Point(192, 64)
        Me._imgGameField_39.Name = "_imgGameField_39"
        Me._imgGameField_39.Size = New System.Drawing.Size(32, 32)
        Me._imgGameField_39.TabIndex = 196
        Me._imgGameField_39.TabStop = False
        '
        '_imgGameField_40
        '
        Me._imgGameField_40.Cursor = System.Windows.Forms.Cursors.Default
        Me.imgGameField.SetIndex(Me._imgGameField_40, CType(40, Short))
        Me._imgGameField_40.Location = New System.Drawing.Point(224, 64)
        Me._imgGameField_40.Name = "_imgGameField_40"
        Me._imgGameField_40.Size = New System.Drawing.Size(32, 32)
        Me._imgGameField_40.TabIndex = 197
        Me._imgGameField_40.TabStop = False
        '
        '_imgGameField_50
        '
        Me._imgGameField_50.Cursor = System.Windows.Forms.Cursors.Default
        Me.imgGameField.SetIndex(Me._imgGameField_50, CType(50, Short))
        Me._imgGameField_50.Location = New System.Drawing.Point(32, 96)
        Me._imgGameField_50.Name = "_imgGameField_50"
        Me._imgGameField_50.Size = New System.Drawing.Size(32, 32)
        Me._imgGameField_50.TabIndex = 198
        Me._imgGameField_50.TabStop = False
        '
        '_imgGameField_49
        '
        Me._imgGameField_49.Cursor = System.Windows.Forms.Cursors.Default
        Me.imgGameField.SetIndex(Me._imgGameField_49, CType(49, Short))
        Me._imgGameField_49.Location = New System.Drawing.Point(0, 96)
        Me._imgGameField_49.Name = "_imgGameField_49"
        Me._imgGameField_49.Size = New System.Drawing.Size(32, 32)
        Me._imgGameField_49.TabIndex = 199
        Me._imgGameField_49.TabStop = False
        '
        '_imgGameField_48
        '
        Me._imgGameField_48.Cursor = System.Windows.Forms.Cursors.Default
        Me.imgGameField.SetIndex(Me._imgGameField_48, CType(48, Short))
        Me._imgGameField_48.Location = New System.Drawing.Point(480, 64)
        Me._imgGameField_48.Name = "_imgGameField_48"
        Me._imgGameField_48.Size = New System.Drawing.Size(32, 32)
        Me._imgGameField_48.TabIndex = 200
        Me._imgGameField_48.TabStop = False
        '
        '_imgGameField_47
        '
        Me._imgGameField_47.Cursor = System.Windows.Forms.Cursors.Default
        Me.imgGameField.SetIndex(Me._imgGameField_47, CType(47, Short))
        Me._imgGameField_47.Location = New System.Drawing.Point(448, 64)
        Me._imgGameField_47.Name = "_imgGameField_47"
        Me._imgGameField_47.Size = New System.Drawing.Size(32, 32)
        Me._imgGameField_47.TabIndex = 201
        Me._imgGameField_47.TabStop = False
        '
        '_imgGameField_46
        '
        Me._imgGameField_46.Cursor = System.Windows.Forms.Cursors.Default
        Me.imgGameField.SetIndex(Me._imgGameField_46, CType(46, Short))
        Me._imgGameField_46.Location = New System.Drawing.Point(416, 64)
        Me._imgGameField_46.Name = "_imgGameField_46"
        Me._imgGameField_46.Size = New System.Drawing.Size(32, 32)
        Me._imgGameField_46.TabIndex = 202
        Me._imgGameField_46.TabStop = False
        '
        '_imgGameField_45
        '
        Me._imgGameField_45.Cursor = System.Windows.Forms.Cursors.Default
        Me.imgGameField.SetIndex(Me._imgGameField_45, CType(45, Short))
        Me._imgGameField_45.Location = New System.Drawing.Point(384, 64)
        Me._imgGameField_45.Name = "_imgGameField_45"
        Me._imgGameField_45.Size = New System.Drawing.Size(32, 32)
        Me._imgGameField_45.TabIndex = 203
        Me._imgGameField_45.TabStop = False
        '
        '_imgGameField_44
        '
        Me._imgGameField_44.Cursor = System.Windows.Forms.Cursors.Default
        Me.imgGameField.SetIndex(Me._imgGameField_44, CType(44, Short))
        Me._imgGameField_44.Location = New System.Drawing.Point(352, 64)
        Me._imgGameField_44.Name = "_imgGameField_44"
        Me._imgGameField_44.Size = New System.Drawing.Size(32, 32)
        Me._imgGameField_44.TabIndex = 204
        Me._imgGameField_44.TabStop = False
        '
        '_imgGameField_43
        '
        Me._imgGameField_43.Cursor = System.Windows.Forms.Cursors.Default
        Me.imgGameField.SetIndex(Me._imgGameField_43, CType(43, Short))
        Me._imgGameField_43.Location = New System.Drawing.Point(320, 64)
        Me._imgGameField_43.Name = "_imgGameField_43"
        Me._imgGameField_43.Size = New System.Drawing.Size(32, 32)
        Me._imgGameField_43.TabIndex = 205
        Me._imgGameField_43.TabStop = False
        '
        '_imgGameField_41
        '
        Me._imgGameField_41.Cursor = System.Windows.Forms.Cursors.Default
        Me.imgGameField.SetIndex(Me._imgGameField_41, CType(41, Short))
        Me._imgGameField_41.Location = New System.Drawing.Point(256, 64)
        Me._imgGameField_41.Name = "_imgGameField_41"
        Me._imgGameField_41.Size = New System.Drawing.Size(32, 32)
        Me._imgGameField_41.TabIndex = 206
        Me._imgGameField_41.TabStop = False
        '
        '_imgGameField_42
        '
        Me._imgGameField_42.Cursor = System.Windows.Forms.Cursors.Default
        Me.imgGameField.SetIndex(Me._imgGameField_42, CType(42, Short))
        Me._imgGameField_42.Location = New System.Drawing.Point(288, 64)
        Me._imgGameField_42.Name = "_imgGameField_42"
        Me._imgGameField_42.Size = New System.Drawing.Size(32, 32)
        Me._imgGameField_42.TabIndex = 207
        Me._imgGameField_42.TabStop = False
        '
        '_imgGameField_90
        '
        Me._imgGameField_90.Cursor = System.Windows.Forms.Cursors.Default
        Me.imgGameField.SetIndex(Me._imgGameField_90, CType(90, Short))
        Me._imgGameField_90.Location = New System.Drawing.Point(288, 160)
        Me._imgGameField_90.Name = "_imgGameField_90"
        Me._imgGameField_90.Size = New System.Drawing.Size(32, 32)
        Me._imgGameField_90.TabIndex = 208
        Me._imgGameField_90.TabStop = False
        '
        '_imgGameField_89
        '
        Me._imgGameField_89.Cursor = System.Windows.Forms.Cursors.Default
        Me.imgGameField.SetIndex(Me._imgGameField_89, CType(89, Short))
        Me._imgGameField_89.Location = New System.Drawing.Point(256, 160)
        Me._imgGameField_89.Name = "_imgGameField_89"
        Me._imgGameField_89.Size = New System.Drawing.Size(32, 32)
        Me._imgGameField_89.TabIndex = 209
        Me._imgGameField_89.TabStop = False
        '
        '_imgGameField_88
        '
        Me._imgGameField_88.Cursor = System.Windows.Forms.Cursors.Default
        Me.imgGameField.SetIndex(Me._imgGameField_88, CType(88, Short))
        Me._imgGameField_88.Location = New System.Drawing.Point(224, 160)
        Me._imgGameField_88.Name = "_imgGameField_88"
        Me._imgGameField_88.Size = New System.Drawing.Size(32, 32)
        Me._imgGameField_88.TabIndex = 210
        Me._imgGameField_88.TabStop = False
        '
        '_imgGameField_87
        '
        Me._imgGameField_87.Cursor = System.Windows.Forms.Cursors.Default
        Me.imgGameField.SetIndex(Me._imgGameField_87, CType(87, Short))
        Me._imgGameField_87.Location = New System.Drawing.Point(192, 160)
        Me._imgGameField_87.Name = "_imgGameField_87"
        Me._imgGameField_87.Size = New System.Drawing.Size(32, 32)
        Me._imgGameField_87.TabIndex = 211
        Me._imgGameField_87.TabStop = False
        '
        '_imgGameField_86
        '
        Me._imgGameField_86.Cursor = System.Windows.Forms.Cursors.Default
        Me.imgGameField.SetIndex(Me._imgGameField_86, CType(86, Short))
        Me._imgGameField_86.Location = New System.Drawing.Point(160, 160)
        Me._imgGameField_86.Name = "_imgGameField_86"
        Me._imgGameField_86.Size = New System.Drawing.Size(32, 32)
        Me._imgGameField_86.TabIndex = 212
        Me._imgGameField_86.TabStop = False
        '
        '_imgGameField_85
        '
        Me._imgGameField_85.Cursor = System.Windows.Forms.Cursors.Default
        Me.imgGameField.SetIndex(Me._imgGameField_85, CType(85, Short))
        Me._imgGameField_85.Location = New System.Drawing.Point(128, 160)
        Me._imgGameField_85.Name = "_imgGameField_85"
        Me._imgGameField_85.Size = New System.Drawing.Size(32, 32)
        Me._imgGameField_85.TabIndex = 213
        Me._imgGameField_85.TabStop = False
        '
        '_imgGameField_84
        '
        Me._imgGameField_84.Cursor = System.Windows.Forms.Cursors.Default
        Me.imgGameField.SetIndex(Me._imgGameField_84, CType(84, Short))
        Me._imgGameField_84.Location = New System.Drawing.Point(96, 160)
        Me._imgGameField_84.Name = "_imgGameField_84"
        Me._imgGameField_84.Size = New System.Drawing.Size(32, 32)
        Me._imgGameField_84.TabIndex = 214
        Me._imgGameField_84.TabStop = False
        '
        '_imgGameField_83
        '
        Me._imgGameField_83.Cursor = System.Windows.Forms.Cursors.Default
        Me.imgGameField.SetIndex(Me._imgGameField_83, CType(83, Short))
        Me._imgGameField_83.Location = New System.Drawing.Point(64, 160)
        Me._imgGameField_83.Name = "_imgGameField_83"
        Me._imgGameField_83.Size = New System.Drawing.Size(32, 32)
        Me._imgGameField_83.TabIndex = 215
        Me._imgGameField_83.TabStop = False
        '
        '_imgGameField_81
        '
        Me._imgGameField_81.Cursor = System.Windows.Forms.Cursors.Default
        Me.imgGameField.SetIndex(Me._imgGameField_81, CType(81, Short))
        Me._imgGameField_81.Location = New System.Drawing.Point(0, 160)
        Me._imgGameField_81.Name = "_imgGameField_81"
        Me._imgGameField_81.Size = New System.Drawing.Size(32, 32)
        Me._imgGameField_81.TabIndex = 216
        Me._imgGameField_81.TabStop = False
        '
        '_imgGameField_82
        '
        Me._imgGameField_82.Cursor = System.Windows.Forms.Cursors.Default
        Me.imgGameField.SetIndex(Me._imgGameField_82, CType(82, Short))
        Me._imgGameField_82.Location = New System.Drawing.Point(32, 160)
        Me._imgGameField_82.Name = "_imgGameField_82"
        Me._imgGameField_82.Size = New System.Drawing.Size(32, 32)
        Me._imgGameField_82.TabIndex = 217
        Me._imgGameField_82.TabStop = False
        '
        '_imgGameField_80
        '
        Me._imgGameField_80.Cursor = System.Windows.Forms.Cursors.Default
        Me.imgGameField.SetIndex(Me._imgGameField_80, CType(80, Short))
        Me._imgGameField_80.Location = New System.Drawing.Point(480, 128)
        Me._imgGameField_80.Name = "_imgGameField_80"
        Me._imgGameField_80.Size = New System.Drawing.Size(32, 32)
        Me._imgGameField_80.TabIndex = 218
        Me._imgGameField_80.TabStop = False
        '
        '_imgGameField_79
        '
        Me._imgGameField_79.Cursor = System.Windows.Forms.Cursors.Default
        Me.imgGameField.SetIndex(Me._imgGameField_79, CType(79, Short))
        Me._imgGameField_79.Location = New System.Drawing.Point(448, 128)
        Me._imgGameField_79.Name = "_imgGameField_79"
        Me._imgGameField_79.Size = New System.Drawing.Size(32, 32)
        Me._imgGameField_79.TabIndex = 219
        Me._imgGameField_79.TabStop = False
        '
        '_imgGameField_78
        '
        Me._imgGameField_78.Cursor = System.Windows.Forms.Cursors.Default
        Me.imgGameField.SetIndex(Me._imgGameField_78, CType(78, Short))
        Me._imgGameField_78.Location = New System.Drawing.Point(416, 128)
        Me._imgGameField_78.Name = "_imgGameField_78"
        Me._imgGameField_78.Size = New System.Drawing.Size(32, 32)
        Me._imgGameField_78.TabIndex = 220
        Me._imgGameField_78.TabStop = False
        '
        '_imgGameField_77
        '
        Me._imgGameField_77.Cursor = System.Windows.Forms.Cursors.Default
        Me.imgGameField.SetIndex(Me._imgGameField_77, CType(77, Short))
        Me._imgGameField_77.Location = New System.Drawing.Point(384, 128)
        Me._imgGameField_77.Name = "_imgGameField_77"
        Me._imgGameField_77.Size = New System.Drawing.Size(32, 32)
        Me._imgGameField_77.TabIndex = 221
        Me._imgGameField_77.TabStop = False
        '
        '_imgGameField_76
        '
        Me._imgGameField_76.Cursor = System.Windows.Forms.Cursors.Default
        Me.imgGameField.SetIndex(Me._imgGameField_76, CType(76, Short))
        Me._imgGameField_76.Location = New System.Drawing.Point(352, 128)
        Me._imgGameField_76.Name = "_imgGameField_76"
        Me._imgGameField_76.Size = New System.Drawing.Size(32, 32)
        Me._imgGameField_76.TabIndex = 222
        Me._imgGameField_76.TabStop = False
        '
        '_imgGameField_75
        '
        Me._imgGameField_75.Cursor = System.Windows.Forms.Cursors.Default
        Me.imgGameField.SetIndex(Me._imgGameField_75, CType(75, Short))
        Me._imgGameField_75.Location = New System.Drawing.Point(320, 128)
        Me._imgGameField_75.Name = "_imgGameField_75"
        Me._imgGameField_75.Size = New System.Drawing.Size(32, 32)
        Me._imgGameField_75.TabIndex = 223
        Me._imgGameField_75.TabStop = False
        '
        '_imgGameField_74
        '
        Me._imgGameField_74.Cursor = System.Windows.Forms.Cursors.Default
        Me.imgGameField.SetIndex(Me._imgGameField_74, CType(74, Short))
        Me._imgGameField_74.Location = New System.Drawing.Point(288, 128)
        Me._imgGameField_74.Name = "_imgGameField_74"
        Me._imgGameField_74.Size = New System.Drawing.Size(32, 32)
        Me._imgGameField_74.TabIndex = 224
        Me._imgGameField_74.TabStop = False
        '
        '_imgGameField_73
        '
        Me._imgGameField_73.Cursor = System.Windows.Forms.Cursors.Default
        Me.imgGameField.SetIndex(Me._imgGameField_73, CType(73, Short))
        Me._imgGameField_73.Location = New System.Drawing.Point(256, 128)
        Me._imgGameField_73.Name = "_imgGameField_73"
        Me._imgGameField_73.Size = New System.Drawing.Size(32, 32)
        Me._imgGameField_73.TabIndex = 225
        Me._imgGameField_73.TabStop = False
        '
        '_imgGameField_71
        '
        Me._imgGameField_71.Cursor = System.Windows.Forms.Cursors.Default
        Me.imgGameField.SetIndex(Me._imgGameField_71, CType(71, Short))
        Me._imgGameField_71.Location = New System.Drawing.Point(192, 128)
        Me._imgGameField_71.Name = "_imgGameField_71"
        Me._imgGameField_71.Size = New System.Drawing.Size(32, 32)
        Me._imgGameField_71.TabIndex = 226
        Me._imgGameField_71.TabStop = False
        '
        '_imgGameField_72
        '
        Me._imgGameField_72.Cursor = System.Windows.Forms.Cursors.Default
        Me.imgGameField.SetIndex(Me._imgGameField_72, CType(72, Short))
        Me._imgGameField_72.Location = New System.Drawing.Point(224, 128)
        Me._imgGameField_72.Name = "_imgGameField_72"
        Me._imgGameField_72.Size = New System.Drawing.Size(32, 32)
        Me._imgGameField_72.TabIndex = 227
        Me._imgGameField_72.TabStop = False
        '
        '_imgGameField_70
        '
        Me._imgGameField_70.Cursor = System.Windows.Forms.Cursors.Default
        Me.imgGameField.SetIndex(Me._imgGameField_70, CType(70, Short))
        Me._imgGameField_70.Location = New System.Drawing.Point(160, 128)
        Me._imgGameField_70.Name = "_imgGameField_70"
        Me._imgGameField_70.Size = New System.Drawing.Size(32, 32)
        Me._imgGameField_70.TabIndex = 228
        Me._imgGameField_70.TabStop = False
        '
        '_imgGameField_69
        '
        Me._imgGameField_69.Cursor = System.Windows.Forms.Cursors.Default
        Me.imgGameField.SetIndex(Me._imgGameField_69, CType(69, Short))
        Me._imgGameField_69.Location = New System.Drawing.Point(128, 128)
        Me._imgGameField_69.Name = "_imgGameField_69"
        Me._imgGameField_69.Size = New System.Drawing.Size(32, 32)
        Me._imgGameField_69.TabIndex = 229
        Me._imgGameField_69.TabStop = False
        '
        '_imgGameField_68
        '
        Me._imgGameField_68.Cursor = System.Windows.Forms.Cursors.Default
        Me.imgGameField.SetIndex(Me._imgGameField_68, CType(68, Short))
        Me._imgGameField_68.Location = New System.Drawing.Point(96, 128)
        Me._imgGameField_68.Name = "_imgGameField_68"
        Me._imgGameField_68.Size = New System.Drawing.Size(32, 32)
        Me._imgGameField_68.TabIndex = 230
        Me._imgGameField_68.TabStop = False
        '
        '_imgGameField_67
        '
        Me._imgGameField_67.Cursor = System.Windows.Forms.Cursors.Default
        Me.imgGameField.SetIndex(Me._imgGameField_67, CType(67, Short))
        Me._imgGameField_67.Location = New System.Drawing.Point(64, 128)
        Me._imgGameField_67.Name = "_imgGameField_67"
        Me._imgGameField_67.Size = New System.Drawing.Size(32, 32)
        Me._imgGameField_67.TabIndex = 231
        Me._imgGameField_67.TabStop = False
        '
        '_imgGameField_66
        '
        Me._imgGameField_66.Cursor = System.Windows.Forms.Cursors.Default
        Me.imgGameField.SetIndex(Me._imgGameField_66, CType(66, Short))
        Me._imgGameField_66.Location = New System.Drawing.Point(32, 128)
        Me._imgGameField_66.Name = "_imgGameField_66"
        Me._imgGameField_66.Size = New System.Drawing.Size(32, 32)
        Me._imgGameField_66.TabIndex = 232
        Me._imgGameField_66.TabStop = False
        '
        '_imgGameField_65
        '
        Me._imgGameField_65.Cursor = System.Windows.Forms.Cursors.Default
        Me.imgGameField.SetIndex(Me._imgGameField_65, CType(65, Short))
        Me._imgGameField_65.Location = New System.Drawing.Point(0, 128)
        Me._imgGameField_65.Name = "_imgGameField_65"
        Me._imgGameField_65.Size = New System.Drawing.Size(32, 32)
        Me._imgGameField_65.TabIndex = 233
        Me._imgGameField_65.TabStop = False
        '
        '_imgGameField_64
        '
        Me._imgGameField_64.Cursor = System.Windows.Forms.Cursors.Default
        Me.imgGameField.SetIndex(Me._imgGameField_64, CType(64, Short))
        Me._imgGameField_64.Location = New System.Drawing.Point(480, 96)
        Me._imgGameField_64.Name = "_imgGameField_64"
        Me._imgGameField_64.Size = New System.Drawing.Size(32, 32)
        Me._imgGameField_64.TabIndex = 234
        Me._imgGameField_64.TabStop = False
        '
        '_imgGameField_63
        '
        Me._imgGameField_63.Cursor = System.Windows.Forms.Cursors.Default
        Me.imgGameField.SetIndex(Me._imgGameField_63, CType(63, Short))
        Me._imgGameField_63.Location = New System.Drawing.Point(448, 96)
        Me._imgGameField_63.Name = "_imgGameField_63"
        Me._imgGameField_63.Size = New System.Drawing.Size(32, 32)
        Me._imgGameField_63.TabIndex = 235
        Me._imgGameField_63.TabStop = False
        '
        '_imgGameField_61
        '
        Me._imgGameField_61.Cursor = System.Windows.Forms.Cursors.Default
        Me.imgGameField.SetIndex(Me._imgGameField_61, CType(61, Short))
        Me._imgGameField_61.Location = New System.Drawing.Point(384, 96)
        Me._imgGameField_61.Name = "_imgGameField_61"
        Me._imgGameField_61.Size = New System.Drawing.Size(32, 32)
        Me._imgGameField_61.TabIndex = 236
        Me._imgGameField_61.TabStop = False
        '
        '_imgGameField_62
        '
        Me._imgGameField_62.Cursor = System.Windows.Forms.Cursors.Default
        Me.imgGameField.SetIndex(Me._imgGameField_62, CType(62, Short))
        Me._imgGameField_62.Location = New System.Drawing.Point(416, 96)
        Me._imgGameField_62.Name = "_imgGameField_62"
        Me._imgGameField_62.Size = New System.Drawing.Size(32, 32)
        Me._imgGameField_62.TabIndex = 237
        Me._imgGameField_62.TabStop = False
        '
        '_imgGameField_60
        '
        Me._imgGameField_60.Cursor = System.Windows.Forms.Cursors.Default
        Me.imgGameField.SetIndex(Me._imgGameField_60, CType(60, Short))
        Me._imgGameField_60.Location = New System.Drawing.Point(352, 96)
        Me._imgGameField_60.Name = "_imgGameField_60"
        Me._imgGameField_60.Size = New System.Drawing.Size(32, 32)
        Me._imgGameField_60.TabIndex = 238
        Me._imgGameField_60.TabStop = False
        '
        '_imgGameField_59
        '
        Me._imgGameField_59.Cursor = System.Windows.Forms.Cursors.Default
        Me.imgGameField.SetIndex(Me._imgGameField_59, CType(59, Short))
        Me._imgGameField_59.Location = New System.Drawing.Point(320, 96)
        Me._imgGameField_59.Name = "_imgGameField_59"
        Me._imgGameField_59.Size = New System.Drawing.Size(32, 32)
        Me._imgGameField_59.TabIndex = 239
        Me._imgGameField_59.TabStop = False
        '
        '_imgGameField_58
        '
        Me._imgGameField_58.Cursor = System.Windows.Forms.Cursors.Default
        Me.imgGameField.SetIndex(Me._imgGameField_58, CType(58, Short))
        Me._imgGameField_58.Location = New System.Drawing.Point(288, 96)
        Me._imgGameField_58.Name = "_imgGameField_58"
        Me._imgGameField_58.Size = New System.Drawing.Size(32, 32)
        Me._imgGameField_58.TabIndex = 240
        Me._imgGameField_58.TabStop = False
        '
        '_imgGameField_57
        '
        Me._imgGameField_57.Cursor = System.Windows.Forms.Cursors.Default
        Me.imgGameField.SetIndex(Me._imgGameField_57, CType(57, Short))
        Me._imgGameField_57.Location = New System.Drawing.Point(256, 96)
        Me._imgGameField_57.Name = "_imgGameField_57"
        Me._imgGameField_57.Size = New System.Drawing.Size(32, 32)
        Me._imgGameField_57.TabIndex = 241
        Me._imgGameField_57.TabStop = False
        '
        '_imgGameField_56
        '
        Me._imgGameField_56.Cursor = System.Windows.Forms.Cursors.Default
        Me.imgGameField.SetIndex(Me._imgGameField_56, CType(56, Short))
        Me._imgGameField_56.Location = New System.Drawing.Point(224, 96)
        Me._imgGameField_56.Name = "_imgGameField_56"
        Me._imgGameField_56.Size = New System.Drawing.Size(32, 32)
        Me._imgGameField_56.TabIndex = 242
        Me._imgGameField_56.TabStop = False
        '
        '_imgGameField_55
        '
        Me._imgGameField_55.Cursor = System.Windows.Forms.Cursors.Default
        Me.imgGameField.SetIndex(Me._imgGameField_55, CType(55, Short))
        Me._imgGameField_55.Location = New System.Drawing.Point(192, 96)
        Me._imgGameField_55.Name = "_imgGameField_55"
        Me._imgGameField_55.Size = New System.Drawing.Size(32, 32)
        Me._imgGameField_55.TabIndex = 243
        Me._imgGameField_55.TabStop = False
        '
        '_imgGameField_54
        '
        Me._imgGameField_54.Cursor = System.Windows.Forms.Cursors.Default
        Me.imgGameField.SetIndex(Me._imgGameField_54, CType(54, Short))
        Me._imgGameField_54.Location = New System.Drawing.Point(160, 96)
        Me._imgGameField_54.Name = "_imgGameField_54"
        Me._imgGameField_54.Size = New System.Drawing.Size(32, 32)
        Me._imgGameField_54.TabIndex = 244
        Me._imgGameField_54.TabStop = False
        '
        '_imgGameField_53
        '
        Me._imgGameField_53.Cursor = System.Windows.Forms.Cursors.Default
        Me.imgGameField.SetIndex(Me._imgGameField_53, CType(53, Short))
        Me._imgGameField_53.Location = New System.Drawing.Point(128, 96)
        Me._imgGameField_53.Name = "_imgGameField_53"
        Me._imgGameField_53.Size = New System.Drawing.Size(32, 32)
        Me._imgGameField_53.TabIndex = 245
        Me._imgGameField_53.TabStop = False
        '
        '_imgGameField_51
        '
        Me._imgGameField_51.Cursor = System.Windows.Forms.Cursors.Default
        Me.imgGameField.SetIndex(Me._imgGameField_51, CType(51, Short))
        Me._imgGameField_51.Location = New System.Drawing.Point(64, 96)
        Me._imgGameField_51.Name = "_imgGameField_51"
        Me._imgGameField_51.Size = New System.Drawing.Size(32, 32)
        Me._imgGameField_51.TabIndex = 246
        Me._imgGameField_51.TabStop = False
        '
        '_imgGameField_52
        '
        Me._imgGameField_52.Cursor = System.Windows.Forms.Cursors.Default
        Me.imgGameField.SetIndex(Me._imgGameField_52, CType(52, Short))
        Me._imgGameField_52.Location = New System.Drawing.Point(96, 96)
        Me._imgGameField_52.Name = "_imgGameField_52"
        Me._imgGameField_52.Size = New System.Drawing.Size(32, 32)
        Me._imgGameField_52.TabIndex = 247
        Me._imgGameField_52.TabStop = False
        '
        '_imgGameField_100
        '
        Me._imgGameField_100.Cursor = System.Windows.Forms.Cursors.Default
        Me.imgGameField.SetIndex(Me._imgGameField_100, CType(100, Short))
        Me._imgGameField_100.Location = New System.Drawing.Point(96, 192)
        Me._imgGameField_100.Name = "_imgGameField_100"
        Me._imgGameField_100.Size = New System.Drawing.Size(32, 32)
        Me._imgGameField_100.TabIndex = 248
        Me._imgGameField_100.TabStop = False
        '
        '_imgGameField_99
        '
        Me._imgGameField_99.Cursor = System.Windows.Forms.Cursors.Default
        Me.imgGameField.SetIndex(Me._imgGameField_99, CType(99, Short))
        Me._imgGameField_99.Location = New System.Drawing.Point(64, 192)
        Me._imgGameField_99.Name = "_imgGameField_99"
        Me._imgGameField_99.Size = New System.Drawing.Size(32, 32)
        Me._imgGameField_99.TabIndex = 249
        Me._imgGameField_99.TabStop = False
        '
        '_imgGameField_98
        '
        Me._imgGameField_98.Cursor = System.Windows.Forms.Cursors.Default
        Me.imgGameField.SetIndex(Me._imgGameField_98, CType(98, Short))
        Me._imgGameField_98.Location = New System.Drawing.Point(32, 192)
        Me._imgGameField_98.Name = "_imgGameField_98"
        Me._imgGameField_98.Size = New System.Drawing.Size(32, 32)
        Me._imgGameField_98.TabIndex = 250
        Me._imgGameField_98.TabStop = False
        '
        '_imgGameField_97
        '
        Me._imgGameField_97.Cursor = System.Windows.Forms.Cursors.Default
        Me.imgGameField.SetIndex(Me._imgGameField_97, CType(97, Short))
        Me._imgGameField_97.Location = New System.Drawing.Point(0, 192)
        Me._imgGameField_97.Name = "_imgGameField_97"
        Me._imgGameField_97.Size = New System.Drawing.Size(32, 32)
        Me._imgGameField_97.TabIndex = 251
        Me._imgGameField_97.TabStop = False
        '
        '_imgGameField_96
        '
        Me._imgGameField_96.Cursor = System.Windows.Forms.Cursors.Default
        Me.imgGameField.SetIndex(Me._imgGameField_96, CType(96, Short))
        Me._imgGameField_96.Location = New System.Drawing.Point(480, 160)
        Me._imgGameField_96.Name = "_imgGameField_96"
        Me._imgGameField_96.Size = New System.Drawing.Size(32, 32)
        Me._imgGameField_96.TabIndex = 252
        Me._imgGameField_96.TabStop = False
        '
        '_imgGameField_95
        '
        Me._imgGameField_95.Cursor = System.Windows.Forms.Cursors.Default
        Me.imgGameField.SetIndex(Me._imgGameField_95, CType(95, Short))
        Me._imgGameField_95.Location = New System.Drawing.Point(448, 160)
        Me._imgGameField_95.Name = "_imgGameField_95"
        Me._imgGameField_95.Size = New System.Drawing.Size(32, 32)
        Me._imgGameField_95.TabIndex = 253
        Me._imgGameField_95.TabStop = False
        '
        '_imgGameField_94
        '
        Me._imgGameField_94.Cursor = System.Windows.Forms.Cursors.Default
        Me.imgGameField.SetIndex(Me._imgGameField_94, CType(94, Short))
        Me._imgGameField_94.Location = New System.Drawing.Point(416, 160)
        Me._imgGameField_94.Name = "_imgGameField_94"
        Me._imgGameField_94.Size = New System.Drawing.Size(32, 32)
        Me._imgGameField_94.TabIndex = 254
        Me._imgGameField_94.TabStop = False
        '
        '_imgGameField_93
        '
        Me._imgGameField_93.Cursor = System.Windows.Forms.Cursors.Default
        Me.imgGameField.SetIndex(Me._imgGameField_93, CType(93, Short))
        Me._imgGameField_93.Location = New System.Drawing.Point(384, 160)
        Me._imgGameField_93.Name = "_imgGameField_93"
        Me._imgGameField_93.Size = New System.Drawing.Size(32, 32)
        Me._imgGameField_93.TabIndex = 255
        Me._imgGameField_93.TabStop = False
        '
        '_imgGameField_91
        '
        Me._imgGameField_91.Cursor = System.Windows.Forms.Cursors.Default
        Me.imgGameField.SetIndex(Me._imgGameField_91, CType(91, Short))
        Me._imgGameField_91.Location = New System.Drawing.Point(320, 160)
        Me._imgGameField_91.Name = "_imgGameField_91"
        Me._imgGameField_91.Size = New System.Drawing.Size(32, 32)
        Me._imgGameField_91.TabIndex = 256
        Me._imgGameField_91.TabStop = False
        '
        '_imgGameField_92
        '
        Me._imgGameField_92.Cursor = System.Windows.Forms.Cursors.Default
        Me.imgGameField.SetIndex(Me._imgGameField_92, CType(92, Short))
        Me._imgGameField_92.Location = New System.Drawing.Point(352, 160)
        Me._imgGameField_92.Name = "_imgGameField_92"
        Me._imgGameField_92.Size = New System.Drawing.Size(32, 32)
        Me._imgGameField_92.TabIndex = 257
        Me._imgGameField_92.TabStop = False
        '
        'MainMenu1
        '
        Me.MainMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuGame, Me.mnuView, Me.mnuTools, Me.mnuHelp})
        '
        'mnuGame
        '
        Me.mnuGame.Index = 0
        Me.mnuGame.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuGameNew, Me.mnuGameWarp, Me.mnuGameSet, Me.mnuGameOpen, Me.mnuGameBar0, Me.mnuGameExit})
        Me.mnuGame.Text = "&Gra"
        '
        'mnuGameNew
        '
        Me.mnuGameNew.Index = 0
        Me.mnuGameNew.Text = "&Nowa gra..."
        '
        'mnuGameWarp
        '
        Me.mnuGameWarp.Index = 1
        Me.mnuGameWarp.Shortcut = System.Windows.Forms.Shortcut.F3
        Me.mnuGameWarp.Text = "Wybierz &etap..."
        '
        'mnuGameSet
        '
        Me.mnuGameSet.Index = 2
        Me.mnuGameSet.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuGameSetKlasyczne, Me.mnuGameSetSuperTrudneXS})
        Me.mnuGameSet.Text = "Wybierz &zestaw etapów"
        '
        'mnuGameSetKlasyczne
        '
        Me.mnuGameSetKlasyczne.Index = 0
        Me.mnuGameSetKlasyczne.Text = "&Klasyczne"
        '
        'mnuGameSetSuperTrudneXS
        '
        Me.mnuGameSetSuperTrudneXS.Index = 1
        Me.mnuGameSetSuperTrudneXS.Text = "&Super Trudne XS"
        '
        'mnuGameOpen
        '
        Me.mnuGameOpen.Index = 3
        Me.mnuGameOpen.Shortcut = System.Windows.Forms.Shortcut.CtrlO
        Me.mnuGameOpen.Text = "&Otwórz plik etapu..."
        '
        'mnuGameBar0
        '
        Me.mnuGameBar0.Index = 4
        Me.mnuGameBar0.Text = "-"
        '
        'mnuGameExit
        '
        Me.mnuGameExit.Index = 5
        Me.mnuGameExit.Shortcut = System.Windows.Forms.Shortcut.CtrlQ
        Me.mnuGameExit.Text = "&Koniec"
        '
        'mnuView
        '
        Me.mnuView.Index = 1
        Me.mnuView.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem1, Me.mnuViewBar0, Me.mnuViewRefresh, Me.MenuItem3})
        Me.mnuView.Text = "&Widok"
        '
        'MenuItem1
        '
        Me.MenuItem1.Index = 0
        Me.MenuItem1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem2})
        Me.MenuItem1.Text = "Skin"
        '
        'MenuItem2
        '
        Me.MenuItem2.Index = 0
        Me.MenuItem2.Text = "(Oryginalny)"
        '
        'mnuViewBar0
        '
        Me.mnuViewBar0.Index = 1
        Me.mnuViewBar0.Text = "-"
        '
        'mnuViewRefresh
        '
        Me.mnuViewRefresh.Index = 2
        Me.mnuViewRefresh.Shortcut = System.Windows.Forms.Shortcut.F9
        Me.mnuViewRefresh.Text = "O&dœwie¿"
        '
        'MenuItem3
        '
        Me.MenuItem3.Index = 3
        Me.MenuItem3.Text = "Ukryj"
        '
        'mnuTools
        '
        Me.mnuTools.Index = 2
        Me.mnuTools.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuToolsUndo, Me.mnuToolsRestart, Me.mnuToolsBar0, Me.mnuToolsOptions})
        Me.mnuTools.Text = "&Narzêdzia"
        '
        'mnuToolsUndo
        '
        Me.mnuToolsUndo.Enabled = False
        Me.mnuToolsUndo.Index = 0
        Me.mnuToolsUndo.Shortcut = System.Windows.Forms.Shortcut.Del
        Me.mnuToolsUndo.Text = "&Cofnij"
        '
        'mnuToolsRestart
        '
        Me.mnuToolsRestart.Index = 1
        Me.mnuToolsRestart.Shortcut = System.Windows.Forms.Shortcut.CtrlR
        Me.mnuToolsRestart.Text = "&Restartuj etap"
        '
        'mnuToolsBar0
        '
        Me.mnuToolsBar0.Index = 2
        Me.mnuToolsBar0.Text = "-"
        '
        'mnuToolsOptions
        '
        Me.mnuToolsOptions.Index = 3
        Me.mnuToolsOptions.Text = "&Opcje..."
        '
        'mnuHelp
        '
        Me.mnuHelp.Index = 3
        Me.mnuHelp.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuHelpContents, Me.mnuHelpWeb, Me.mnuHelpBar0, Me.mnuHelpAbout})
        Me.mnuHelp.Text = "Pomo&c"
        '
        'mnuHelpContents
        '
        Me.mnuHelpContents.Index = 0
        Me.mnuHelpContents.Shortcut = System.Windows.Forms.Shortcut.F1
        Me.mnuHelpContents.Text = "&Tematy Pomocy..."
        '
        'mnuHelpWeb
        '
        Me.mnuHelpWeb.Index = 1
        Me.mnuHelpWeb.Text = "Skrzynki w &sieci..."
        '
        'mnuHelpBar0
        '
        Me.mnuHelpBar0.Index = 2
        Me.mnuHelpBar0.Text = "-"
        '
        'mnuHelpAbout
        '
        Me.mnuHelpAbout.Index = 3
        Me.mnuHelpAbout.Text = "Skrzynki - &informacje..."
        '
        'frmMain
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(511, 527)
        Me.Controls.Add(Me.PicStatusBar)
        Me.Controls.Add(Me._imgGameField_256)
        Me.Controls.Add(Me._imgGameField_255)
        Me.Controls.Add(Me._imgGameField_254)
        Me.Controls.Add(Me._imgGameField_253)
        Me.Controls.Add(Me._imgGameField_251)
        Me.Controls.Add(Me._imgGameField_250)
        Me.Controls.Add(Me._imgGameField_249)
        Me.Controls.Add(Me._imgGameField_248)
        Me.Controls.Add(Me._imgGameField_247)
        Me.Controls.Add(Me._imgGameField_246)
        Me.Controls.Add(Me._imgGameField_245)
        Me.Controls.Add(Me._imgGameField_244)
        Me.Controls.Add(Me._imgGameField_243)
        Me.Controls.Add(Me._imgGameField_242)
        Me.Controls.Add(Me._imgGameField_241)
        Me.Controls.Add(Me._imgGameField_240)
        Me.Controls.Add(Me._imgGameField_239)
        Me.Controls.Add(Me._imgGameField_238)
        Me.Controls.Add(Me._imgGameField_237)
        Me.Controls.Add(Me._imgGameField_236)
        Me.Controls.Add(Me._imgGameField_235)
        Me.Controls.Add(Me._imgGameField_252)
        Me.Controls.Add(Me._imgGameField_233)
        Me.Controls.Add(Me._imgGameField_232)
        Me.Controls.Add(Me._imgGameField_231)
        Me.Controls.Add(Me._imgGameField_230)
        Me.Controls.Add(Me._imgGameField_229)
        Me.Controls.Add(Me._imgGameField_228)
        Me.Controls.Add(Me._imgGameField_227)
        Me.Controls.Add(Me._imgGameField_226)
        Me.Controls.Add(Me._imgGameField_225)
        Me.Controls.Add(Me._imgGameField_224)
        Me.Controls.Add(Me._imgGameField_223)
        Me.Controls.Add(Me._imgGameField_222)
        Me.Controls.Add(Me._imgGameField_221)
        Me.Controls.Add(Me._imgGameField_220)
        Me.Controls.Add(Me._imgGameField_219)
        Me.Controls.Add(Me._imgGameField_218)
        Me.Controls.Add(Me._imgGameField_217)
        Me.Controls.Add(Me._imgGameField_234)
        Me.Controls.Add(Me._imgGameField_215)
        Me.Controls.Add(Me._imgGameField_214)
        Me.Controls.Add(Me._imgGameField_213)
        Me.Controls.Add(Me._imgGameField_212)
        Me.Controls.Add(Me._imgGameField_211)
        Me.Controls.Add(Me._imgGameField_210)
        Me.Controls.Add(Me._imgGameField_209)
        Me.Controls.Add(Me._imgGameField_208)
        Me.Controls.Add(Me._imgGameField_207)
        Me.Controls.Add(Me._imgGameField_206)
        Me.Controls.Add(Me._imgGameField_205)
        Me.Controls.Add(Me._imgGameField_204)
        Me.Controls.Add(Me._imgGameField_203)
        Me.Controls.Add(Me._imgGameField_202)
        Me.Controls.Add(Me._imgGameField_201)
        Me.Controls.Add(Me._imgGameField_200)
        Me.Controls.Add(Me._imgGameField_199)
        Me.Controls.Add(Me._imgGameField_216)
        Me.Controls.Add(Me._imgGameField_197)
        Me.Controls.Add(Me._imgGameField_196)
        Me.Controls.Add(Me._imgGameField_195)
        Me.Controls.Add(Me._imgGameField_194)
        Me.Controls.Add(Me._imgGameField_193)
        Me.Controls.Add(Me._imgGameField_192)
        Me.Controls.Add(Me._imgGameField_191)
        Me.Controls.Add(Me._imgGameField_190)
        Me.Controls.Add(Me._imgGameField_189)
        Me.Controls.Add(Me._imgGameField_188)
        Me.Controls.Add(Me._imgGameField_187)
        Me.Controls.Add(Me._imgGameField_186)
        Me.Controls.Add(Me._imgGameField_185)
        Me.Controls.Add(Me._imgGameField_184)
        Me.Controls.Add(Me._imgGameField_183)
        Me.Controls.Add(Me._imgGameField_182)
        Me.Controls.Add(Me._imgGameField_181)
        Me.Controls.Add(Me._imgGameField_198)
        Me.Controls.Add(Me._imgGameField_179)
        Me.Controls.Add(Me._imgGameField_178)
        Me.Controls.Add(Me._imgGameField_177)
        Me.Controls.Add(Me._imgGameField_176)
        Me.Controls.Add(Me._imgGameField_175)
        Me.Controls.Add(Me._imgGameField_174)
        Me.Controls.Add(Me._imgGameField_173)
        Me.Controls.Add(Me._imgGameField_172)
        Me.Controls.Add(Me._imgGameField_171)
        Me.Controls.Add(Me._imgGameField_170)
        Me.Controls.Add(Me._imgGameField_169)
        Me.Controls.Add(Me._imgGameField_168)
        Me.Controls.Add(Me._imgGameField_167)
        Me.Controls.Add(Me._imgGameField_166)
        Me.Controls.Add(Me._imgGameField_165)
        Me.Controls.Add(Me._imgGameField_164)
        Me.Controls.Add(Me._imgGameField_163)
        Me.Controls.Add(Me._imgGameField_162)
        Me.Controls.Add(Me._imgGameField_161)
        Me.Controls.Add(Me._imgGameField_180)
        Me.Controls.Add(Me._imgGameField_159)
        Me.Controls.Add(Me._imgGameField_158)
        Me.Controls.Add(Me._imgGameField_157)
        Me.Controls.Add(Me._imgGameField_156)
        Me.Controls.Add(Me._imgGameField_155)
        Me.Controls.Add(Me._imgGameField_154)
        Me.Controls.Add(Me._imgGameField_153)
        Me.Controls.Add(Me._imgGameField_152)
        Me.Controls.Add(Me._imgGameField_151)
        Me.Controls.Add(Me._imgGameField_150)
        Me.Controls.Add(Me._imgGameField_149)
        Me.Controls.Add(Me._imgGameField_148)
        Me.Controls.Add(Me._imgGameField_147)
        Me.Controls.Add(Me._imgGameField_146)
        Me.Controls.Add(Me._imgGameField_145)
        Me.Controls.Add(Me._imgGameField_144)
        Me.Controls.Add(Me._imgGameField_143)
        Me.Controls.Add(Me._imgGameField_142)
        Me.Controls.Add(Me._imgGameField_141)
        Me.Controls.Add(Me._imgGameField_160)
        Me.Controls.Add(Me._imgGameField_140)
        Me.Controls.Add(Me._imgGameField_139)
        Me.Controls.Add(Me._imgGameField_138)
        Me.Controls.Add(Me._imgGameField_137)
        Me.Controls.Add(Me._imgGameField_136)
        Me.Controls.Add(Me._imgGameField_135)
        Me.Controls.Add(Me._imgGameField_134)
        Me.Controls.Add(Me._imgGameField_133)
        Me.Controls.Add(Me._imgGameField_132)
        Me.Controls.Add(Me._imgGameField_131)
        Me.Controls.Add(Me._imgGameField_130)
        Me.Controls.Add(Me._imgGameField_129)
        Me.Controls.Add(Me._imgGameField_128)
        Me.Controls.Add(Me._imgGameField_127)
        Me.Controls.Add(Me._imgGameField_126)
        Me.Controls.Add(Me._imgGameField_125)
        Me.Controls.Add(Me._imgGameField_124)
        Me.Controls.Add(Me._imgGameField_123)
        Me.Controls.Add(Me._imgGameField_122)
        Me.Controls.Add(Me._imgGameField_121)
        Me.Controls.Add(Me._imgGameField_120)
        Me.Controls.Add(Me._imgGameField_119)
        Me.Controls.Add(Me._imgGameField_118)
        Me.Controls.Add(Me._imgGameField_117)
        Me.Controls.Add(Me._imgGameField_116)
        Me.Controls.Add(Me._imgGameField_115)
        Me.Controls.Add(Me._imgGameField_114)
        Me.Controls.Add(Me._imgGameField_113)
        Me.Controls.Add(Me._imgGameField_112)
        Me.Controls.Add(Me._imgGameField_111)
        Me.Controls.Add(Me._imgGameField_110)
        Me.Controls.Add(Me._imgGameField_109)
        Me.Controls.Add(Me._imgGameField_108)
        Me.Controls.Add(Me._imgGameField_107)
        Me.Controls.Add(Me._imgGameField_106)
        Me.Controls.Add(Me._imgGameField_105)
        Me.Controls.Add(Me._imgGameField_104)
        Me.Controls.Add(Me._imgGameField_103)
        Me.Controls.Add(Me._imgGameField_102)
        Me.Controls.Add(Me._imgGameField_101)
        Me.Controls.Add(Me._imgGameField_2)
        Me.Controls.Add(Me._imgGameField_1)
        Me.Controls.Add(Me._imgGameField_3)
        Me.Controls.Add(Me._imgGameField_4)
        Me.Controls.Add(Me._imgGameField_5)
        Me.Controls.Add(Me._imgGameField_6)
        Me.Controls.Add(Me._imgGameField_7)
        Me.Controls.Add(Me._imgGameField_8)
        Me.Controls.Add(Me._imgGameField_9)
        Me.Controls.Add(Me._imgGameField_10)
        Me.Controls.Add(Me._imgGameField_12)
        Me.Controls.Add(Me._imgGameField_11)
        Me.Controls.Add(Me._imgGameField_13)
        Me.Controls.Add(Me._imgGameField_14)
        Me.Controls.Add(Me._imgGameField_15)
        Me.Controls.Add(Me._imgGameField_16)
        Me.Controls.Add(Me._imgGameField_17)
        Me.Controls.Add(Me._imgGameField_18)
        Me.Controls.Add(Me._imgGameField_19)
        Me.Controls.Add(Me._imgGameField_20)
        Me.Controls.Add(Me._imgGameField_22)
        Me.Controls.Add(Me._imgGameField_21)
        Me.Controls.Add(Me._imgGameField_23)
        Me.Controls.Add(Me._imgGameField_24)
        Me.Controls.Add(Me._imgGameField_25)
        Me.Controls.Add(Me._imgGameField_26)
        Me.Controls.Add(Me._imgGameField_27)
        Me.Controls.Add(Me._imgGameField_28)
        Me.Controls.Add(Me._imgGameField_29)
        Me.Controls.Add(Me._imgGameField_30)
        Me.Controls.Add(Me._imgGameField_32)
        Me.Controls.Add(Me._imgGameField_31)
        Me.Controls.Add(Me._imgGameField_33)
        Me.Controls.Add(Me._imgGameField_34)
        Me.Controls.Add(Me._imgGameField_35)
        Me.Controls.Add(Me._imgGameField_36)
        Me.Controls.Add(Me._imgGameField_37)
        Me.Controls.Add(Me._imgGameField_38)
        Me.Controls.Add(Me._imgGameField_39)
        Me.Controls.Add(Me._imgGameField_40)
        Me.Controls.Add(Me._imgGameField_50)
        Me.Controls.Add(Me._imgGameField_49)
        Me.Controls.Add(Me._imgGameField_48)
        Me.Controls.Add(Me._imgGameField_47)
        Me.Controls.Add(Me._imgGameField_46)
        Me.Controls.Add(Me._imgGameField_45)
        Me.Controls.Add(Me._imgGameField_44)
        Me.Controls.Add(Me._imgGameField_43)
        Me.Controls.Add(Me._imgGameField_41)
        Me.Controls.Add(Me._imgGameField_42)
        Me.Controls.Add(Me._imgGameField_90)
        Me.Controls.Add(Me._imgGameField_89)
        Me.Controls.Add(Me._imgGameField_88)
        Me.Controls.Add(Me._imgGameField_87)
        Me.Controls.Add(Me._imgGameField_86)
        Me.Controls.Add(Me._imgGameField_85)
        Me.Controls.Add(Me._imgGameField_84)
        Me.Controls.Add(Me._imgGameField_83)
        Me.Controls.Add(Me._imgGameField_81)
        Me.Controls.Add(Me._imgGameField_82)
        Me.Controls.Add(Me._imgGameField_80)
        Me.Controls.Add(Me._imgGameField_79)
        Me.Controls.Add(Me._imgGameField_78)
        Me.Controls.Add(Me._imgGameField_77)
        Me.Controls.Add(Me._imgGameField_76)
        Me.Controls.Add(Me._imgGameField_75)
        Me.Controls.Add(Me._imgGameField_74)
        Me.Controls.Add(Me._imgGameField_73)
        Me.Controls.Add(Me._imgGameField_71)
        Me.Controls.Add(Me._imgGameField_72)
        Me.Controls.Add(Me._imgGameField_70)
        Me.Controls.Add(Me._imgGameField_69)
        Me.Controls.Add(Me._imgGameField_68)
        Me.Controls.Add(Me._imgGameField_67)
        Me.Controls.Add(Me._imgGameField_66)
        Me.Controls.Add(Me._imgGameField_65)
        Me.Controls.Add(Me._imgGameField_64)
        Me.Controls.Add(Me._imgGameField_63)
        Me.Controls.Add(Me._imgGameField_61)
        Me.Controls.Add(Me._imgGameField_62)
        Me.Controls.Add(Me._imgGameField_60)
        Me.Controls.Add(Me._imgGameField_59)
        Me.Controls.Add(Me._imgGameField_58)
        Me.Controls.Add(Me._imgGameField_57)
        Me.Controls.Add(Me._imgGameField_56)
        Me.Controls.Add(Me._imgGameField_55)
        Me.Controls.Add(Me._imgGameField_54)
        Me.Controls.Add(Me._imgGameField_53)
        Me.Controls.Add(Me._imgGameField_51)
        Me.Controls.Add(Me._imgGameField_52)
        Me.Controls.Add(Me._imgGameField_100)
        Me.Controls.Add(Me._imgGameField_99)
        Me.Controls.Add(Me._imgGameField_98)
        Me.Controls.Add(Me._imgGameField_97)
        Me.Controls.Add(Me._imgGameField_96)
        Me.Controls.Add(Me._imgGameField_95)
        Me.Controls.Add(Me._imgGameField_94)
        Me.Controls.Add(Me._imgGameField_93)
        Me.Controls.Add(Me._imgGameField_91)
        Me.Controls.Add(Me._imgGameField_92)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Location = New System.Drawing.Point(87, 140)
        Me.MaximizeBox = False
        Me.Menu = Me.MainMenu1
        Me.Name = "frmMain"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Skrzynki"
        Me.PicStatusBar.ResumeLayout(False)
        CType(Me.ImgStatusImage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._imgGameField_256, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._imgGameField_255, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._imgGameField_254, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._imgGameField_253, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._imgGameField_251, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._imgGameField_250, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._imgGameField_249, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._imgGameField_248, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._imgGameField_247, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._imgGameField_246, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._imgGameField_245, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._imgGameField_244, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._imgGameField_243, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._imgGameField_242, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._imgGameField_241, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._imgGameField_240, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._imgGameField_239, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._imgGameField_238, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._imgGameField_237, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._imgGameField_236, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._imgGameField_235, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._imgGameField_252, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._imgGameField_233, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._imgGameField_232, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._imgGameField_231, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._imgGameField_230, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._imgGameField_229, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._imgGameField_228, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._imgGameField_227, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._imgGameField_226, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._imgGameField_225, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._imgGameField_224, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._imgGameField_223, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._imgGameField_222, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._imgGameField_221, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._imgGameField_220, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._imgGameField_219, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._imgGameField_218, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._imgGameField_217, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._imgGameField_234, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._imgGameField_215, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._imgGameField_214, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._imgGameField_213, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._imgGameField_212, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._imgGameField_211, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._imgGameField_210, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._imgGameField_209, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._imgGameField_208, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._imgGameField_207, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._imgGameField_206, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._imgGameField_205, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._imgGameField_204, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._imgGameField_203, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._imgGameField_202, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._imgGameField_201, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._imgGameField_200, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._imgGameField_199, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._imgGameField_216, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._imgGameField_197, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._imgGameField_196, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._imgGameField_195, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._imgGameField_194, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._imgGameField_193, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._imgGameField_192, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._imgGameField_191, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._imgGameField_190, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._imgGameField_189, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._imgGameField_188, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._imgGameField_187, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._imgGameField_186, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._imgGameField_185, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._imgGameField_184, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._imgGameField_183, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._imgGameField_182, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._imgGameField_181, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._imgGameField_198, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._imgGameField_179, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._imgGameField_178, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._imgGameField_177, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._imgGameField_176, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._imgGameField_175, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._imgGameField_174, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._imgGameField_173, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._imgGameField_172, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._imgGameField_171, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._imgGameField_170, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._imgGameField_169, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._imgGameField_168, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._imgGameField_167, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._imgGameField_166, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._imgGameField_165, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._imgGameField_164, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._imgGameField_163, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._imgGameField_162, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._imgGameField_161, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._imgGameField_180, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._imgGameField_159, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._imgGameField_158, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._imgGameField_157, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._imgGameField_156, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._imgGameField_155, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._imgGameField_154, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._imgGameField_153, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._imgGameField_152, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._imgGameField_151, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._imgGameField_150, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._imgGameField_149, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._imgGameField_148, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._imgGameField_147, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._imgGameField_146, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._imgGameField_145, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._imgGameField_144, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._imgGameField_143, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._imgGameField_142, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._imgGameField_141, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._imgGameField_160, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._imgGameField_140, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._imgGameField_139, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._imgGameField_138, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._imgGameField_137, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._imgGameField_136, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._imgGameField_135, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._imgGameField_134, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._imgGameField_133, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._imgGameField_132, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._imgGameField_131, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._imgGameField_130, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._imgGameField_129, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._imgGameField_128, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._imgGameField_127, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._imgGameField_126, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._imgGameField_125, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._imgGameField_124, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._imgGameField_123, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._imgGameField_122, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._imgGameField_121, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._imgGameField_120, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._imgGameField_119, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._imgGameField_118, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._imgGameField_117, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._imgGameField_116, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._imgGameField_115, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._imgGameField_114, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._imgGameField_113, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._imgGameField_112, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._imgGameField_111, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._imgGameField_110, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._imgGameField_109, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._imgGameField_108, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._imgGameField_107, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._imgGameField_106, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._imgGameField_105, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._imgGameField_104, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._imgGameField_103, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._imgGameField_102, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._imgGameField_101, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._imgGameField_2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._imgGameField_1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._imgGameField_3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._imgGameField_4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._imgGameField_5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._imgGameField_6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._imgGameField_7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._imgGameField_8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._imgGameField_9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._imgGameField_10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._imgGameField_12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._imgGameField_11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._imgGameField_13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._imgGameField_14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._imgGameField_15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._imgGameField_16, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._imgGameField_17, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._imgGameField_18, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._imgGameField_19, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._imgGameField_20, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._imgGameField_22, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._imgGameField_21, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._imgGameField_23, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._imgGameField_24, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._imgGameField_25, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._imgGameField_26, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._imgGameField_27, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._imgGameField_28, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._imgGameField_29, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._imgGameField_30, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._imgGameField_32, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._imgGameField_31, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._imgGameField_33, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._imgGameField_34, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._imgGameField_35, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._imgGameField_36, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._imgGameField_37, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._imgGameField_38, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._imgGameField_39, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._imgGameField_40, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._imgGameField_50, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._imgGameField_49, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._imgGameField_48, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._imgGameField_47, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._imgGameField_46, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._imgGameField_45, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._imgGameField_44, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._imgGameField_43, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._imgGameField_41, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._imgGameField_42, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._imgGameField_90, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._imgGameField_89, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._imgGameField_88, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._imgGameField_87, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._imgGameField_86, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._imgGameField_85, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._imgGameField_84, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._imgGameField_83, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._imgGameField_81, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._imgGameField_82, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._imgGameField_80, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._imgGameField_79, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._imgGameField_78, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._imgGameField_77, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._imgGameField_76, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._imgGameField_75, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._imgGameField_74, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._imgGameField_73, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._imgGameField_71, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._imgGameField_72, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._imgGameField_70, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._imgGameField_69, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._imgGameField_68, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._imgGameField_67, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._imgGameField_66, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._imgGameField_65, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._imgGameField_64, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._imgGameField_63, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._imgGameField_61, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._imgGameField_62, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._imgGameField_60, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._imgGameField_59, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._imgGameField_58, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._imgGameField_57, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._imgGameField_56, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._imgGameField_55, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._imgGameField_54, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._imgGameField_53, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._imgGameField_51, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._imgGameField_52, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._imgGameField_100, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._imgGameField_99, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._imgGameField_98, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._imgGameField_97, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._imgGameField_96, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._imgGameField_95, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._imgGameField_94, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._imgGameField_93, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._imgGameField_91, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._imgGameField_92, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgGameField, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
#End Region
#Region "Upgrade Support "
    Private Shared m_vb6FormDefInstance As FrmMain
    Private Shared m_InitializingDefInstance As Boolean
    Public Shared Property DefInstance() As FrmMain
        Get
            If m_vb6FormDefInstance Is Nothing OrElse m_vb6FormDefInstance.IsDisposed Then
                m_InitializingDefInstance = True
                m_vb6FormDefInstance = New FrmMain
                m_InitializingDefInstance = False
            End If
            DefInstance = m_vb6FormDefInstance
        End Get
        Set(ByVal Value As FrmMain)
            m_vb6FormDefInstance = Value
        End Set
    End Property
#End Region

    Private Sub frmMain_KeyDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        Dim KeyCode As Short = eventArgs.KeyCode
        Dim Shift As Short = eventArgs.KeyData \ &H10000
        If KeyCode = modMain.Lewo Or KeyCode = modMain.Prawo Or KeyCode = modMain.Gora Or KeyCode = modMain.Dol Then
            If PrzesunGracza(KeyCode) Then
                OdswiezPoleGryWokolGracza()
                Ruchy += 1

                PokazNaPaskuStanu(1, ZwrocCiag("StatusBar#0") & Ruchy)
                PokazNaPaskuStanu(2, ZwrocCiag("StatusBar#1") & Pchniecia)
                PokazNaPaskuStanu(3, ZwrocCiag("StatusBar#2") & Etap.SkrzynkiNaMiejscach & "/" & Etap.LiczbaSkrzynek)

                If WykonanoRuch = False Then
                    WykonanoRuch = True
                    FrmMain.DefInstance.mnuToolsUndo.Enabled = True
                End If

                If Etap.SkrzynkiNaMiejscach = Etap.LiczbaSkrzynek Then NastepnyEtap()
            Else
                NieMozna()
            End If
        End If
    End Sub
    Private Sub frmMain_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
        modMain.Main()
        modLogin.OdczytajStatystyki()

        FrmMain.DefInstance.BackColor = Color.Black
        FrmMain.DefInstance.PicStatusBar.Visible = True

        If EtapSpozaZestawu = False Then
            If My.Settings.BeginFromArrivedLevel = True Then
                NowaGra((NajdalszyEtap()))
            Else
                NowaGra((1))
            End If
        End If

    End Sub

    'UPGRADE_WARNING: Form event frmMain.Unload has a new behavior. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup2065"'
    Private Sub frmMain_Closed(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Closed
        ZapiszStatystyki()
        End
    End Sub
    Public Sub mnuGame_Popup(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuGame.Popup
        mnuGame_Click(eventSender, eventArgs)
    End Sub
    Public Sub mnuGame_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuGame.Click
        If EtapSpozaZestawu Then
            mnuGameOpen.Enabled = False
        Else
            mnuGameOpen.Enabled = True
        End If
    End Sub
    Public Sub mnuGameExit_Popup(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuGameExit.Popup
        mnuGameExit_Click(eventSender, eventArgs)
    End Sub
    Public Sub mnuGameExit_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuGameExit.Click
        FrmMain.DefInstance.Close()
    End Sub
    Public Sub mnuGameNew_Popup(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuGameNew.Popup
        mnuGameNew_Click(eventSender, eventArgs)
    End Sub
    Public Sub mnuGameNew_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuGameNew.Click
        NowaGra((1))
    End Sub
    Public Sub mnuGameOpen_Popup(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuGameOpen.Popup
        mnuGameOpen_Click(eventSender, eventArgs)
    End Sub
    Public Sub mnuGameOpen_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuGameOpen.Click
        Dim openFileDialog1 As OpenFileDialog = New OpenFileDialog
        With openFileDialog1
            If openFileDialog1.ShowDialog() = DialogResult.OK Then
                NazwaPliku = openFileDialog1.FileName
            End If
        End With

        If WczytajEtap(NazwaPliku, FreeFile) Then
            OdswiezPoleGry()
            'UPGRADE_WARNING: Dir has a new behavior. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1041"'
            FrmMain.DefInstance.Text = "Skrzynki - " & VB.Left(Dir(NazwaPliku), Len(Dir(NazwaPliku)) - 4)
            PokazNaPaskuStanu(3, "Skrzynki: " & Etap.SkrzynkiNaMiejscach & "/" & Etap.LiczbaSkrzynek)
            'UPGRADE_WARNING: Dir has a new behavior. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1041"'
            PokazNaPaskuStanu(4, VB.Left(Dir(NazwaPliku), Len(Dir(NazwaPliku)) - 4))
            EtapSpozaZestawu = True

            If My.Settings.LevelLoadConfirmation = True Then
                MsgBox(Replace(ZwrocCiag("General#6"), "<filename>", NazwaPliku), MsgBoxStyle.OkOnly + MsgBoxStyle.Information + MsgBoxStyle.ApplicationModal, System.Reflection.Assembly.GetExecutingAssembly.GetName.Name)
            End If
        End If

    End Sub
    Public Sub mnuGameSet_Popup(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuGameSet.Popup
        mnuGameSet_Click(eventSender, eventArgs)
    End Sub
    Public Sub mnuGameSet_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuGameSet.Click
        If DaneGracza.Zestaw = "Klasyczne" Then
            mnuGameSetKlasyczne.Checked = True
            mnuGameSetSuperTrudneXS.Checked = False
        Else
            mnuGameSetKlasyczne.Checked = False
            mnuGameSetSuperTrudneXS.Checked = True
        End If
    End Sub

    Public Sub mnuGameSetKlasyczne_Popup(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuGameSetKlasyczne.Popup
        mnuGameSetKlasyczne_Click(eventSender, eventArgs)
    End Sub
    Public Sub mnuGameSetKlasyczne_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuGameSetKlasyczne.Click
        NowaGra(1, 1)
        DaneGracza.Zestaw = 1
        ZestawEtapow = 1
    End Sub

    Public Sub mnuGameSetSuperTrudneXS_Popup(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuGameSetSuperTrudneXS.Popup
        mnuGameSetSuperTrudneXS_Click(eventSender, eventArgs)
    End Sub
    Public Sub mnuGameSetSuperTrudneXS_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuGameSetSuperTrudneXS.Click
        NowaGra(1, 2)
        DaneGracza.Zestaw = 2
        ZestawEtapow = 2
    End Sub

    Public Sub mnuGameWarp_Popup(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuGameWarp.Popup
        mnuGameWarp_Click(eventSender, eventArgs)
    End Sub
    Public Sub mnuGameWarp_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuGameWarp.Click
        Dim IB As String = InputBox(ZwrocCiag("General#12"), System.Reflection.Assembly.GetExecutingAssembly.GetName.Name, CStr(NajdalszyEtap()))
        If IB = "" Then
            Exit Sub
        End If

        If IsNumeric(IB) = False Then
            MsgBox(ZwrocCiag("General#13"), MsgBoxStyle.OkOnly + MsgBoxStyle.Critical + MsgBoxStyle.ApplicationModal, System.Reflection.Assembly.GetExecutingAssembly.GetName.Name)
            Exit Sub
        End If

        If (Val(IB) > Val(CStr(NajdalszyEtap()))) And (IB <= Val(CStr(UBound(Etapy, 1)))) Then
            MsgBox(ZwrocCiag("General#14"), MsgBoxStyle.OkOnly + MsgBoxStyle.Critical + MsgBoxStyle.ApplicationModal, System.Reflection.Assembly.GetExecutingAssembly.GetName.Name)
            Exit Sub
        Else
            If (Val(IB) > Val(CStr(UBound(Etapy, 1)))) Or Val(IB) <= 0 Then
                MsgBox(ZwrocCiag("General#15"), MsgBoxStyle.OkOnly + MsgBoxStyle.Critical + MsgBoxStyle.ApplicationModal, System.Reflection.Assembly.GetExecutingAssembly.GetName.Name)
                Exit Sub
            End If

            NumerEtapu = Val(IB)
            For Licznik = 1 To 256
                PoleGry(Licznik) = Etapy(NumerEtapu, Licznik)
                'UPGRADE_WARNING: Couldn't resolve default property of object Etap. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
                Etap = DaneEtapow(NumerEtapu)
                PozycjaGracza = PozycjeGracza(NumerEtapu)
            Next Licznik

            PokazNaPaskuStanu(1, ZwrocCiag("StatusBar#0") & Ruchy)
            PokazNaPaskuStanu(2, ZwrocCiag("StatusBar#1") & Pchniecia)
            PokazNaPaskuStanu(3, ZwrocCiag("StatusBar#2") & Etap.SkrzynkiNaMiejscach & "/" & Etap.LiczbaSkrzynek)
            PokazNaPaskuStanu(4, "#" & NumerEtapu)
            FrmMain.DefInstance.Text = System.Reflection.Assembly.GetExecutingAssembly.GetName.Name & " - #" & NumerEtapu
            OdswiezPoleGry()
            EtapSpozaZestawu = False
        End If
    End Sub

    Public Sub mnuHelpAbout_Popup(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuHelpAbout.Popup
        mnuHelpAbout_Click(eventSender, eventArgs)
    End Sub
    Public Sub mnuHelpAbout_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuHelpAbout.Click
        frmSplash.Show()
    End Sub

    Public Sub mnuHelpContents_Popup(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuHelpContents.Popup
        mnuHelpContents_Click(eventSender, eventArgs)
    End Sub
    Public Sub mnuHelpContents_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuHelpContents.Click
    End Sub
    Public Sub mnuHelpTips_Popup(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs)
        mnuHelpTips_Click(eventSender, eventArgs)
    End Sub
    Public Sub mnuHelpTips_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs)

    End Sub
    Public Sub mnuHelpWeb_Popup(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuHelpWeb.Popup
        mnuHelpWeb_Click(eventSender, eventArgs)
    End Sub
    Public Sub mnuHelpWeb_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuHelpWeb.Click

    End Sub
    Public Sub mnuTools_Popup(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuTools.Popup
        mnuTools_Click(eventSender, eventArgs)
    End Sub
    Public Sub mnuTools_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuTools.Click
        If WykonanoRuch Then mnuToolsUndo.Enabled = True Else mnuToolsUndo.Enabled = False
        If EtapSpozaZestawu = False Then mnuToolsRestart.Enabled = True Else mnuToolsRestart.Enabled = False
    End Sub
    Public Sub mnuToolsOptions_Popup(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuToolsOptions.Popup
        mnuToolsOptions_Click(eventSender, eventArgs)
    End Sub
    Public Sub mnuToolsOptions_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuToolsOptions.Click
        frmOptions.Show()
    End Sub
    Public Sub mnuViewRefresh_Popup(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuViewRefresh.Popup
        mnuViewRefresh_Click(eventSender, eventArgs)
    End Sub
    Public Sub mnuViewRefresh_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuViewRefresh.Click
        OdswiezPoleGry()
    End Sub
    Public Sub mnuToolsRestart_Popup(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuToolsRestart.Popup
        mnuToolsRestart_Click(eventSender, eventArgs)
    End Sub
    Public Sub mnuToolsRestart_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuToolsRestart.Click
        If My.Settings.LevelRestartingAuthorization = True Then
            Dim TempX As MsgBoxResult = MsgBox(ZwrocCiag("General#1"), MsgBoxStyle.YesNo + MsgBoxStyle.Question + MsgBoxStyle.ApplicationModal, System.Reflection.Assembly.GetExecutingAssembly.GetName.Name)
            If TempX = MsgBoxResult.Yes Then
                RestartujEtap()
            End If
        Else
            RestartujEtap()
        End If
    End Sub
    Public Sub mnuToolsUndo_Popup(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuToolsUndo.Popup
        mnuToolsUndo_Click(eventSender, eventArgs)
    End Sub
    Public Sub mnuToolsUndo_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuToolsUndo.Click
        Cofnij()
    End Sub
    Public Sub mnuView_Popup(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuView.Popup
        ' mnuView_Click(eventSender, eventArgs)
    End Sub
    Public Sub mnuViewStatusbar_Popup(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs)
        mnuViewStatusbar_Click(eventSender, eventArgs)
    End Sub
    Public Sub mnuViewStatusbar_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs)

        PicStatusBar.Visible = True

    End Sub

End Class