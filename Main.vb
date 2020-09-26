Option Strict Off
Option Explicit On
Imports VB = Microsoft.VisualBasic
Friend Class frmMain
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
	Public WithEvents imgStatusImage As System.Windows.Forms.PictureBox
	Public WithEvents lblPlayerName As System.Windows.Forms.Label
	Public WithEvents lblLevelNumber As System.Windows.Forms.Label
	Public WithEvents lblBoxes As System.Windows.Forms.Label
	Public WithEvents lblPushes As System.Windows.Forms.Label
	Public WithEvents lblMoves As System.Windows.Forms.Label
	Public WithEvents picStatusBar As System.Windows.Forms.Panel
	Public WithEvents tmrMIDITimer As System.Windows.Forms.Timer
	Public WithEvents picTrayObject As System.Windows.Forms.PictureBox
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
	Public WithEvents mnuViewStatusbar As System.Windows.Forms.MenuItem
	Public WithEvents mnuViewBar0 As System.Windows.Forms.MenuItem
	Public WithEvents mnuViewRefresh As System.Windows.Forms.MenuItem
	Public WithEvents mnuView As System.Windows.Forms.MenuItem
	Public WithEvents mnuToolsUndo As System.Windows.Forms.MenuItem
	Public WithEvents mnuToolsRestart As System.Windows.Forms.MenuItem
	Public WithEvents mnuToolsBar0 As System.Windows.Forms.MenuItem
	Public WithEvents mnuToolsOptions As System.Windows.Forms.MenuItem
	Public WithEvents mnuTools As System.Windows.Forms.MenuItem
	Public WithEvents mnuHelpContents As System.Windows.Forms.MenuItem
	Public WithEvents mnuHelpTips As System.Windows.Forms.MenuItem
	Public WithEvents mnuHelpWeb As System.Windows.Forms.MenuItem
	Public WithEvents mnuHelpBar0 As System.Windows.Forms.MenuItem
	Public WithEvents mnuHelpAbout As System.Windows.Forms.MenuItem
	Public WithEvents mnuHelp As System.Windows.Forms.MenuItem
	Public MainMenu1 As System.Windows.Forms.MainMenu
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmMain))
		Me.components = New System.ComponentModel.Container()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(components)
		Me.ToolTip1.Active = True
		Me.picStatusBar = New System.Windows.Forms.Panel
		Me.imgStatusImage = New System.Windows.Forms.PictureBox
		Me.lblPlayerName = New System.Windows.Forms.Label
		Me.lblLevelNumber = New System.Windows.Forms.Label
		Me.lblBoxes = New System.Windows.Forms.Label
		Me.lblPushes = New System.Windows.Forms.Label
		Me.lblMoves = New System.Windows.Forms.Label
		Me.tmrMIDITimer = New System.Windows.Forms.Timer(components)
		Me.picTrayObject = New System.Windows.Forms.PictureBox
		Me._imgGameField_256 = New System.Windows.Forms.PictureBox
		Me._imgGameField_255 = New System.Windows.Forms.PictureBox
		Me._imgGameField_254 = New System.Windows.Forms.PictureBox
		Me._imgGameField_253 = New System.Windows.Forms.PictureBox
		Me._imgGameField_251 = New System.Windows.Forms.PictureBox
		Me._imgGameField_250 = New System.Windows.Forms.PictureBox
		Me._imgGameField_249 = New System.Windows.Forms.PictureBox
		Me._imgGameField_248 = New System.Windows.Forms.PictureBox
		Me._imgGameField_247 = New System.Windows.Forms.PictureBox
		Me._imgGameField_246 = New System.Windows.Forms.PictureBox
		Me._imgGameField_245 = New System.Windows.Forms.PictureBox
		Me._imgGameField_244 = New System.Windows.Forms.PictureBox
		Me._imgGameField_243 = New System.Windows.Forms.PictureBox
		Me._imgGameField_242 = New System.Windows.Forms.PictureBox
		Me._imgGameField_241 = New System.Windows.Forms.PictureBox
		Me._imgGameField_240 = New System.Windows.Forms.PictureBox
		Me._imgGameField_239 = New System.Windows.Forms.PictureBox
		Me._imgGameField_238 = New System.Windows.Forms.PictureBox
		Me._imgGameField_237 = New System.Windows.Forms.PictureBox
		Me._imgGameField_236 = New System.Windows.Forms.PictureBox
		Me._imgGameField_235 = New System.Windows.Forms.PictureBox
		Me._imgGameField_252 = New System.Windows.Forms.PictureBox
		Me._imgGameField_233 = New System.Windows.Forms.PictureBox
		Me._imgGameField_232 = New System.Windows.Forms.PictureBox
		Me._imgGameField_231 = New System.Windows.Forms.PictureBox
		Me._imgGameField_230 = New System.Windows.Forms.PictureBox
		Me._imgGameField_229 = New System.Windows.Forms.PictureBox
		Me._imgGameField_228 = New System.Windows.Forms.PictureBox
		Me._imgGameField_227 = New System.Windows.Forms.PictureBox
		Me._imgGameField_226 = New System.Windows.Forms.PictureBox
		Me._imgGameField_225 = New System.Windows.Forms.PictureBox
		Me._imgGameField_224 = New System.Windows.Forms.PictureBox
		Me._imgGameField_223 = New System.Windows.Forms.PictureBox
		Me._imgGameField_222 = New System.Windows.Forms.PictureBox
		Me._imgGameField_221 = New System.Windows.Forms.PictureBox
		Me._imgGameField_220 = New System.Windows.Forms.PictureBox
		Me._imgGameField_219 = New System.Windows.Forms.PictureBox
		Me._imgGameField_218 = New System.Windows.Forms.PictureBox
		Me._imgGameField_217 = New System.Windows.Forms.PictureBox
		Me._imgGameField_234 = New System.Windows.Forms.PictureBox
		Me._imgGameField_215 = New System.Windows.Forms.PictureBox
		Me._imgGameField_214 = New System.Windows.Forms.PictureBox
		Me._imgGameField_213 = New System.Windows.Forms.PictureBox
		Me._imgGameField_212 = New System.Windows.Forms.PictureBox
		Me._imgGameField_211 = New System.Windows.Forms.PictureBox
		Me._imgGameField_210 = New System.Windows.Forms.PictureBox
		Me._imgGameField_209 = New System.Windows.Forms.PictureBox
		Me._imgGameField_208 = New System.Windows.Forms.PictureBox
		Me._imgGameField_207 = New System.Windows.Forms.PictureBox
		Me._imgGameField_206 = New System.Windows.Forms.PictureBox
		Me._imgGameField_205 = New System.Windows.Forms.PictureBox
		Me._imgGameField_204 = New System.Windows.Forms.PictureBox
		Me._imgGameField_203 = New System.Windows.Forms.PictureBox
		Me._imgGameField_202 = New System.Windows.Forms.PictureBox
		Me._imgGameField_201 = New System.Windows.Forms.PictureBox
		Me._imgGameField_200 = New System.Windows.Forms.PictureBox
		Me._imgGameField_199 = New System.Windows.Forms.PictureBox
		Me._imgGameField_216 = New System.Windows.Forms.PictureBox
		Me._imgGameField_197 = New System.Windows.Forms.PictureBox
		Me._imgGameField_196 = New System.Windows.Forms.PictureBox
		Me._imgGameField_195 = New System.Windows.Forms.PictureBox
		Me._imgGameField_194 = New System.Windows.Forms.PictureBox
		Me._imgGameField_193 = New System.Windows.Forms.PictureBox
		Me._imgGameField_192 = New System.Windows.Forms.PictureBox
		Me._imgGameField_191 = New System.Windows.Forms.PictureBox
		Me._imgGameField_190 = New System.Windows.Forms.PictureBox
		Me._imgGameField_189 = New System.Windows.Forms.PictureBox
		Me._imgGameField_188 = New System.Windows.Forms.PictureBox
		Me._imgGameField_187 = New System.Windows.Forms.PictureBox
		Me._imgGameField_186 = New System.Windows.Forms.PictureBox
		Me._imgGameField_185 = New System.Windows.Forms.PictureBox
		Me._imgGameField_184 = New System.Windows.Forms.PictureBox
		Me._imgGameField_183 = New System.Windows.Forms.PictureBox
		Me._imgGameField_182 = New System.Windows.Forms.PictureBox
		Me._imgGameField_181 = New System.Windows.Forms.PictureBox
		Me._imgGameField_198 = New System.Windows.Forms.PictureBox
		Me._imgGameField_179 = New System.Windows.Forms.PictureBox
		Me._imgGameField_178 = New System.Windows.Forms.PictureBox
		Me._imgGameField_177 = New System.Windows.Forms.PictureBox
		Me._imgGameField_176 = New System.Windows.Forms.PictureBox
		Me._imgGameField_175 = New System.Windows.Forms.PictureBox
		Me._imgGameField_174 = New System.Windows.Forms.PictureBox
		Me._imgGameField_173 = New System.Windows.Forms.PictureBox
		Me._imgGameField_172 = New System.Windows.Forms.PictureBox
		Me._imgGameField_171 = New System.Windows.Forms.PictureBox
		Me._imgGameField_170 = New System.Windows.Forms.PictureBox
		Me._imgGameField_169 = New System.Windows.Forms.PictureBox
		Me._imgGameField_168 = New System.Windows.Forms.PictureBox
		Me._imgGameField_167 = New System.Windows.Forms.PictureBox
		Me._imgGameField_166 = New System.Windows.Forms.PictureBox
		Me._imgGameField_165 = New System.Windows.Forms.PictureBox
		Me._imgGameField_164 = New System.Windows.Forms.PictureBox
		Me._imgGameField_163 = New System.Windows.Forms.PictureBox
		Me._imgGameField_162 = New System.Windows.Forms.PictureBox
		Me._imgGameField_161 = New System.Windows.Forms.PictureBox
		Me._imgGameField_180 = New System.Windows.Forms.PictureBox
		Me._imgGameField_159 = New System.Windows.Forms.PictureBox
		Me._imgGameField_158 = New System.Windows.Forms.PictureBox
		Me._imgGameField_157 = New System.Windows.Forms.PictureBox
		Me._imgGameField_156 = New System.Windows.Forms.PictureBox
		Me._imgGameField_155 = New System.Windows.Forms.PictureBox
		Me._imgGameField_154 = New System.Windows.Forms.PictureBox
		Me._imgGameField_153 = New System.Windows.Forms.PictureBox
		Me._imgGameField_152 = New System.Windows.Forms.PictureBox
		Me._imgGameField_151 = New System.Windows.Forms.PictureBox
		Me._imgGameField_150 = New System.Windows.Forms.PictureBox
		Me._imgGameField_149 = New System.Windows.Forms.PictureBox
		Me._imgGameField_148 = New System.Windows.Forms.PictureBox
		Me._imgGameField_147 = New System.Windows.Forms.PictureBox
		Me._imgGameField_146 = New System.Windows.Forms.PictureBox
		Me._imgGameField_145 = New System.Windows.Forms.PictureBox
		Me._imgGameField_144 = New System.Windows.Forms.PictureBox
		Me._imgGameField_143 = New System.Windows.Forms.PictureBox
		Me._imgGameField_142 = New System.Windows.Forms.PictureBox
		Me._imgGameField_141 = New System.Windows.Forms.PictureBox
		Me._imgGameField_160 = New System.Windows.Forms.PictureBox
		Me._imgGameField_140 = New System.Windows.Forms.PictureBox
		Me._imgGameField_139 = New System.Windows.Forms.PictureBox
		Me._imgGameField_138 = New System.Windows.Forms.PictureBox
		Me._imgGameField_137 = New System.Windows.Forms.PictureBox
		Me._imgGameField_136 = New System.Windows.Forms.PictureBox
		Me._imgGameField_135 = New System.Windows.Forms.PictureBox
		Me._imgGameField_134 = New System.Windows.Forms.PictureBox
		Me._imgGameField_133 = New System.Windows.Forms.PictureBox
		Me._imgGameField_132 = New System.Windows.Forms.PictureBox
		Me._imgGameField_131 = New System.Windows.Forms.PictureBox
		Me._imgGameField_130 = New System.Windows.Forms.PictureBox
		Me._imgGameField_129 = New System.Windows.Forms.PictureBox
		Me._imgGameField_128 = New System.Windows.Forms.PictureBox
		Me._imgGameField_127 = New System.Windows.Forms.PictureBox
		Me._imgGameField_126 = New System.Windows.Forms.PictureBox
		Me._imgGameField_125 = New System.Windows.Forms.PictureBox
		Me._imgGameField_124 = New System.Windows.Forms.PictureBox
		Me._imgGameField_123 = New System.Windows.Forms.PictureBox
		Me._imgGameField_122 = New System.Windows.Forms.PictureBox
		Me._imgGameField_121 = New System.Windows.Forms.PictureBox
		Me._imgGameField_120 = New System.Windows.Forms.PictureBox
		Me._imgGameField_119 = New System.Windows.Forms.PictureBox
		Me._imgGameField_118 = New System.Windows.Forms.PictureBox
		Me._imgGameField_117 = New System.Windows.Forms.PictureBox
		Me._imgGameField_116 = New System.Windows.Forms.PictureBox
		Me._imgGameField_115 = New System.Windows.Forms.PictureBox
		Me._imgGameField_114 = New System.Windows.Forms.PictureBox
		Me._imgGameField_113 = New System.Windows.Forms.PictureBox
		Me._imgGameField_112 = New System.Windows.Forms.PictureBox
		Me._imgGameField_111 = New System.Windows.Forms.PictureBox
		Me._imgGameField_110 = New System.Windows.Forms.PictureBox
		Me._imgGameField_109 = New System.Windows.Forms.PictureBox
		Me._imgGameField_108 = New System.Windows.Forms.PictureBox
		Me._imgGameField_107 = New System.Windows.Forms.PictureBox
		Me._imgGameField_106 = New System.Windows.Forms.PictureBox
		Me._imgGameField_105 = New System.Windows.Forms.PictureBox
		Me._imgGameField_104 = New System.Windows.Forms.PictureBox
		Me._imgGameField_103 = New System.Windows.Forms.PictureBox
		Me._imgGameField_102 = New System.Windows.Forms.PictureBox
		Me._imgGameField_101 = New System.Windows.Forms.PictureBox
		Me._imgGameField_2 = New System.Windows.Forms.PictureBox
		Me._imgGameField_1 = New System.Windows.Forms.PictureBox
		Me._imgGameField_3 = New System.Windows.Forms.PictureBox
		Me._imgGameField_4 = New System.Windows.Forms.PictureBox
		Me._imgGameField_5 = New System.Windows.Forms.PictureBox
		Me._imgGameField_6 = New System.Windows.Forms.PictureBox
		Me._imgGameField_7 = New System.Windows.Forms.PictureBox
		Me._imgGameField_8 = New System.Windows.Forms.PictureBox
		Me._imgGameField_9 = New System.Windows.Forms.PictureBox
		Me._imgGameField_10 = New System.Windows.Forms.PictureBox
		Me._imgGameField_12 = New System.Windows.Forms.PictureBox
		Me._imgGameField_11 = New System.Windows.Forms.PictureBox
		Me._imgGameField_13 = New System.Windows.Forms.PictureBox
		Me._imgGameField_14 = New System.Windows.Forms.PictureBox
		Me._imgGameField_15 = New System.Windows.Forms.PictureBox
		Me._imgGameField_16 = New System.Windows.Forms.PictureBox
		Me._imgGameField_17 = New System.Windows.Forms.PictureBox
		Me._imgGameField_18 = New System.Windows.Forms.PictureBox
		Me._imgGameField_19 = New System.Windows.Forms.PictureBox
		Me._imgGameField_20 = New System.Windows.Forms.PictureBox
		Me._imgGameField_22 = New System.Windows.Forms.PictureBox
		Me._imgGameField_21 = New System.Windows.Forms.PictureBox
		Me._imgGameField_23 = New System.Windows.Forms.PictureBox
		Me._imgGameField_24 = New System.Windows.Forms.PictureBox
		Me._imgGameField_25 = New System.Windows.Forms.PictureBox
		Me._imgGameField_26 = New System.Windows.Forms.PictureBox
		Me._imgGameField_27 = New System.Windows.Forms.PictureBox
		Me._imgGameField_28 = New System.Windows.Forms.PictureBox
		Me._imgGameField_29 = New System.Windows.Forms.PictureBox
		Me._imgGameField_30 = New System.Windows.Forms.PictureBox
		Me._imgGameField_32 = New System.Windows.Forms.PictureBox
		Me._imgGameField_31 = New System.Windows.Forms.PictureBox
		Me._imgGameField_33 = New System.Windows.Forms.PictureBox
		Me._imgGameField_34 = New System.Windows.Forms.PictureBox
		Me._imgGameField_35 = New System.Windows.Forms.PictureBox
		Me._imgGameField_36 = New System.Windows.Forms.PictureBox
		Me._imgGameField_37 = New System.Windows.Forms.PictureBox
		Me._imgGameField_38 = New System.Windows.Forms.PictureBox
		Me._imgGameField_39 = New System.Windows.Forms.PictureBox
		Me._imgGameField_40 = New System.Windows.Forms.PictureBox
		Me._imgGameField_50 = New System.Windows.Forms.PictureBox
		Me._imgGameField_49 = New System.Windows.Forms.PictureBox
		Me._imgGameField_48 = New System.Windows.Forms.PictureBox
		Me._imgGameField_47 = New System.Windows.Forms.PictureBox
		Me._imgGameField_46 = New System.Windows.Forms.PictureBox
		Me._imgGameField_45 = New System.Windows.Forms.PictureBox
		Me._imgGameField_44 = New System.Windows.Forms.PictureBox
		Me._imgGameField_43 = New System.Windows.Forms.PictureBox
		Me._imgGameField_41 = New System.Windows.Forms.PictureBox
		Me._imgGameField_42 = New System.Windows.Forms.PictureBox
		Me._imgGameField_90 = New System.Windows.Forms.PictureBox
		Me._imgGameField_89 = New System.Windows.Forms.PictureBox
		Me._imgGameField_88 = New System.Windows.Forms.PictureBox
		Me._imgGameField_87 = New System.Windows.Forms.PictureBox
		Me._imgGameField_86 = New System.Windows.Forms.PictureBox
		Me._imgGameField_85 = New System.Windows.Forms.PictureBox
		Me._imgGameField_84 = New System.Windows.Forms.PictureBox
		Me._imgGameField_83 = New System.Windows.Forms.PictureBox
		Me._imgGameField_81 = New System.Windows.Forms.PictureBox
		Me._imgGameField_82 = New System.Windows.Forms.PictureBox
		Me._imgGameField_80 = New System.Windows.Forms.PictureBox
		Me._imgGameField_79 = New System.Windows.Forms.PictureBox
		Me._imgGameField_78 = New System.Windows.Forms.PictureBox
		Me._imgGameField_77 = New System.Windows.Forms.PictureBox
		Me._imgGameField_76 = New System.Windows.Forms.PictureBox
		Me._imgGameField_75 = New System.Windows.Forms.PictureBox
		Me._imgGameField_74 = New System.Windows.Forms.PictureBox
		Me._imgGameField_73 = New System.Windows.Forms.PictureBox
		Me._imgGameField_71 = New System.Windows.Forms.PictureBox
		Me._imgGameField_72 = New System.Windows.Forms.PictureBox
		Me._imgGameField_70 = New System.Windows.Forms.PictureBox
		Me._imgGameField_69 = New System.Windows.Forms.PictureBox
		Me._imgGameField_68 = New System.Windows.Forms.PictureBox
		Me._imgGameField_67 = New System.Windows.Forms.PictureBox
		Me._imgGameField_66 = New System.Windows.Forms.PictureBox
		Me._imgGameField_65 = New System.Windows.Forms.PictureBox
		Me._imgGameField_64 = New System.Windows.Forms.PictureBox
		Me._imgGameField_63 = New System.Windows.Forms.PictureBox
		Me._imgGameField_61 = New System.Windows.Forms.PictureBox
		Me._imgGameField_62 = New System.Windows.Forms.PictureBox
		Me._imgGameField_60 = New System.Windows.Forms.PictureBox
		Me._imgGameField_59 = New System.Windows.Forms.PictureBox
		Me._imgGameField_58 = New System.Windows.Forms.PictureBox
		Me._imgGameField_57 = New System.Windows.Forms.PictureBox
		Me._imgGameField_56 = New System.Windows.Forms.PictureBox
		Me._imgGameField_55 = New System.Windows.Forms.PictureBox
		Me._imgGameField_54 = New System.Windows.Forms.PictureBox
		Me._imgGameField_53 = New System.Windows.Forms.PictureBox
		Me._imgGameField_51 = New System.Windows.Forms.PictureBox
		Me._imgGameField_52 = New System.Windows.Forms.PictureBox
		Me._imgGameField_100 = New System.Windows.Forms.PictureBox
		Me._imgGameField_99 = New System.Windows.Forms.PictureBox
		Me._imgGameField_98 = New System.Windows.Forms.PictureBox
		Me._imgGameField_97 = New System.Windows.Forms.PictureBox
		Me._imgGameField_96 = New System.Windows.Forms.PictureBox
		Me._imgGameField_95 = New System.Windows.Forms.PictureBox
		Me._imgGameField_94 = New System.Windows.Forms.PictureBox
		Me._imgGameField_93 = New System.Windows.Forms.PictureBox
		Me._imgGameField_91 = New System.Windows.Forms.PictureBox
		Me._imgGameField_92 = New System.Windows.Forms.PictureBox
		Me.imgGameField = New Microsoft.VisualBasic.Compatibility.VB6.PictureBoxArray(components)
		Me.MainMenu1 = New System.Windows.Forms.MainMenu
		Me.mnuGame = New System.Windows.Forms.MenuItem
		Me.mnuGameNew = New System.Windows.Forms.MenuItem
		Me.mnuGameWarp = New System.Windows.Forms.MenuItem
		Me.mnuGameSet = New System.Windows.Forms.MenuItem
		Me.mnuGameSetKlasyczne = New System.Windows.Forms.MenuItem
		Me.mnuGameSetSuperTrudneXS = New System.Windows.Forms.MenuItem
		Me.mnuGameOpen = New System.Windows.Forms.MenuItem
		Me.mnuGameBar0 = New System.Windows.Forms.MenuItem
		Me.mnuGameExit = New System.Windows.Forms.MenuItem
		Me.mnuView = New System.Windows.Forms.MenuItem
		Me.mnuViewStatusbar = New System.Windows.Forms.MenuItem
		Me.mnuViewBar0 = New System.Windows.Forms.MenuItem
		Me.mnuViewRefresh = New System.Windows.Forms.MenuItem
		Me.mnuTools = New System.Windows.Forms.MenuItem
		Me.mnuToolsUndo = New System.Windows.Forms.MenuItem
		Me.mnuToolsRestart = New System.Windows.Forms.MenuItem
		Me.mnuToolsBar0 = New System.Windows.Forms.MenuItem
		Me.mnuToolsOptions = New System.Windows.Forms.MenuItem
		Me.mnuHelp = New System.Windows.Forms.MenuItem
		Me.mnuHelpContents = New System.Windows.Forms.MenuItem
		Me.mnuHelpTips = New System.Windows.Forms.MenuItem
		Me.mnuHelpWeb = New System.Windows.Forms.MenuItem
		Me.mnuHelpBar0 = New System.Windows.Forms.MenuItem
		Me.mnuHelpAbout = New System.Windows.Forms.MenuItem
		CType(Me.imgGameField, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
		Me.Text = "Skrzynki"
		Me.ClientSize = New System.Drawing.Size(511, 527)
		Me.Location = New System.Drawing.Point(87, 140)
		Me.Icon = CType(resources.GetObject("frmMain.Icon"), System.Drawing.Icon)
		Me.KeyPreview = True
		Me.MaximizeBox = False
		Me.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
		Me.BackColor = System.Drawing.SystemColors.Control
		Me.ControlBox = True
		Me.Enabled = True
		Me.MinimizeBox = True
		Me.Cursor = System.Windows.Forms.Cursors.Default
		Me.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.ShowInTaskbar = True
		Me.HelpButton = False
		Me.WindowState = System.Windows.Forms.FormWindowState.Normal
		Me.Name = "frmMain"
		Me.picStatusBar.Dock = System.Windows.Forms.DockStyle.Bottom
		Me.picStatusBar.Size = New System.Drawing.Size(511, 17)
		Me.picStatusBar.Location = New System.Drawing.Point(0, 510)
		Me.picStatusBar.TabIndex = 1
		Me.picStatusBar.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.picStatusBar.BackColor = System.Drawing.SystemColors.Control
		Me.picStatusBar.CausesValidation = True
		Me.picStatusBar.Enabled = True
		Me.picStatusBar.ForeColor = System.Drawing.SystemColors.ControlText
		Me.picStatusBar.Cursor = System.Windows.Forms.Cursors.Default
		Me.picStatusBar.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.picStatusBar.TabStop = True
		Me.picStatusBar.Visible = True
		Me.picStatusBar.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.picStatusBar.Name = "picStatusBar"
		Me.imgStatusImage.Size = New System.Drawing.Size(16, 16)
		Me.imgStatusImage.Location = New System.Drawing.Point(0, 0)
		Me.imgStatusImage.Image = CType(resources.GetObject("imgStatusImage.Image"), System.Drawing.Image)
		Me.imgStatusImage.Enabled = True
		Me.imgStatusImage.Cursor = System.Windows.Forms.Cursors.Default
		Me.imgStatusImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal
		Me.imgStatusImage.Visible = True
		Me.imgStatusImage.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.imgStatusImage.Name = "imgStatusImage"
		Me.lblPlayerName.TextAlign = System.Drawing.ContentAlignment.TopCenter
		Me.lblPlayerName.Size = New System.Drawing.Size(137, 17)
		Me.lblPlayerName.Location = New System.Drawing.Point(372, 0)
		Me.lblPlayerName.TabIndex = 6
		Me.lblPlayerName.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblPlayerName.BackColor = System.Drawing.SystemColors.Control
		Me.lblPlayerName.Enabled = True
		Me.lblPlayerName.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblPlayerName.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblPlayerName.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblPlayerName.UseMnemonic = True
		Me.lblPlayerName.Visible = True
		Me.lblPlayerName.AutoSize = False
		Me.lblPlayerName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblPlayerName.Name = "lblPlayerName"
		Me.lblLevelNumber.TextAlign = System.Drawing.ContentAlignment.TopCenter
		Me.lblLevelNumber.Size = New System.Drawing.Size(101, 17)
		Me.lblLevelNumber.Location = New System.Drawing.Point(272, 0)
		Me.lblLevelNumber.TabIndex = 5
		Me.lblLevelNumber.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblLevelNumber.BackColor = System.Drawing.SystemColors.Control
		Me.lblLevelNumber.Enabled = True
		Me.lblLevelNumber.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblLevelNumber.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblLevelNumber.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblLevelNumber.UseMnemonic = True
		Me.lblLevelNumber.Visible = True
		Me.lblLevelNumber.AutoSize = False
		Me.lblLevelNumber.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblLevelNumber.Name = "lblLevelNumber"
		Me.lblBoxes.TextAlign = System.Drawing.ContentAlignment.TopCenter
		Me.lblBoxes.Text = "Skrzynki: ##/##"
		Me.lblBoxes.Size = New System.Drawing.Size(97, 17)
		Me.lblBoxes.Location = New System.Drawing.Point(176, 0)
		Me.lblBoxes.TabIndex = 4
		Me.lblBoxes.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblBoxes.BackColor = System.Drawing.SystemColors.Control
		Me.lblBoxes.Enabled = True
		Me.lblBoxes.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblBoxes.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblBoxes.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblBoxes.UseMnemonic = True
		Me.lblBoxes.Visible = True
		Me.lblBoxes.AutoSize = False
		Me.lblBoxes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblBoxes.Name = "lblBoxes"
		Me.lblPushes.TextAlign = System.Drawing.ContentAlignment.TopCenter
		Me.lblPushes.Text = "Pchniêcia: ###"
		Me.lblPushes.Size = New System.Drawing.Size(89, 17)
		Me.lblPushes.Location = New System.Drawing.Point(88, 0)
		Me.lblPushes.TabIndex = 3
		Me.lblPushes.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblPushes.BackColor = System.Drawing.SystemColors.Control
		Me.lblPushes.Enabled = True
		Me.lblPushes.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblPushes.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblPushes.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblPushes.UseMnemonic = True
		Me.lblPushes.Visible = True
		Me.lblPushes.AutoSize = False
		Me.lblPushes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblPushes.Name = "lblPushes"
		Me.lblMoves.TextAlign = System.Drawing.ContentAlignment.TopCenter
		Me.lblMoves.Text = "Ruchy: ###"
		Me.lblMoves.Size = New System.Drawing.Size(73, 17)
		Me.lblMoves.Location = New System.Drawing.Point(16, 0)
		Me.lblMoves.TabIndex = 2
		Me.lblMoves.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblMoves.BackColor = System.Drawing.SystemColors.Control
		Me.lblMoves.Enabled = True
		Me.lblMoves.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblMoves.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblMoves.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblMoves.UseMnemonic = True
		Me.lblMoves.Visible = True
		Me.lblMoves.AutoSize = False
		Me.lblMoves.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblMoves.Name = "lblMoves"
		Me.tmrMIDITimer.Enabled = False
		Me.tmrMIDITimer.Interval = 250
		Me.picTrayObject.Size = New System.Drawing.Size(33, 33)
		Me.picTrayObject.Location = New System.Drawing.Point(224, 192)
		Me.picTrayObject.TabIndex = 0
		Me.picTrayObject.Visible = False
		Me.picTrayObject.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.picTrayObject.Dock = System.Windows.Forms.DockStyle.None
		Me.picTrayObject.BackColor = System.Drawing.SystemColors.Control
		Me.picTrayObject.CausesValidation = True
		Me.picTrayObject.Enabled = True
		Me.picTrayObject.ForeColor = System.Drawing.SystemColors.ControlText
		Me.picTrayObject.Cursor = System.Windows.Forms.Cursors.Default
		Me.picTrayObject.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.picTrayObject.TabStop = True
		Me.picTrayObject.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal
		Me.picTrayObject.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.picTrayObject.Name = "picTrayObject"
		Me._imgGameField_256.Size = New System.Drawing.Size(32, 32)
		Me._imgGameField_256.Location = New System.Drawing.Point(480, 480)
		Me._imgGameField_256.Enabled = True
		Me._imgGameField_256.Cursor = System.Windows.Forms.Cursors.Default
		Me._imgGameField_256.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal
		Me._imgGameField_256.Visible = True
		Me._imgGameField_256.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._imgGameField_256.Name = "_imgGameField_256"
		Me._imgGameField_255.Size = New System.Drawing.Size(32, 32)
		Me._imgGameField_255.Location = New System.Drawing.Point(448, 480)
		Me._imgGameField_255.Enabled = True
		Me._imgGameField_255.Cursor = System.Windows.Forms.Cursors.Default
		Me._imgGameField_255.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal
		Me._imgGameField_255.Visible = True
		Me._imgGameField_255.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._imgGameField_255.Name = "_imgGameField_255"
		Me._imgGameField_254.Size = New System.Drawing.Size(32, 32)
		Me._imgGameField_254.Location = New System.Drawing.Point(416, 480)
		Me._imgGameField_254.Enabled = True
		Me._imgGameField_254.Cursor = System.Windows.Forms.Cursors.Default
		Me._imgGameField_254.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal
		Me._imgGameField_254.Visible = True
		Me._imgGameField_254.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._imgGameField_254.Name = "_imgGameField_254"
		Me._imgGameField_253.Size = New System.Drawing.Size(32, 32)
		Me._imgGameField_253.Location = New System.Drawing.Point(384, 480)
		Me._imgGameField_253.Enabled = True
		Me._imgGameField_253.Cursor = System.Windows.Forms.Cursors.Default
		Me._imgGameField_253.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal
		Me._imgGameField_253.Visible = True
		Me._imgGameField_253.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._imgGameField_253.Name = "_imgGameField_253"
		Me._imgGameField_251.Size = New System.Drawing.Size(32, 32)
		Me._imgGameField_251.Location = New System.Drawing.Point(320, 480)
		Me._imgGameField_251.Enabled = True
		Me._imgGameField_251.Cursor = System.Windows.Forms.Cursors.Default
		Me._imgGameField_251.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal
		Me._imgGameField_251.Visible = True
		Me._imgGameField_251.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._imgGameField_251.Name = "_imgGameField_251"
		Me._imgGameField_250.Size = New System.Drawing.Size(32, 32)
		Me._imgGameField_250.Location = New System.Drawing.Point(288, 480)
		Me._imgGameField_250.Enabled = True
		Me._imgGameField_250.Cursor = System.Windows.Forms.Cursors.Default
		Me._imgGameField_250.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal
		Me._imgGameField_250.Visible = True
		Me._imgGameField_250.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._imgGameField_250.Name = "_imgGameField_250"
		Me._imgGameField_249.Size = New System.Drawing.Size(32, 32)
		Me._imgGameField_249.Location = New System.Drawing.Point(256, 480)
		Me._imgGameField_249.Enabled = True
		Me._imgGameField_249.Cursor = System.Windows.Forms.Cursors.Default
		Me._imgGameField_249.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal
		Me._imgGameField_249.Visible = True
		Me._imgGameField_249.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._imgGameField_249.Name = "_imgGameField_249"
		Me._imgGameField_248.Size = New System.Drawing.Size(32, 32)
		Me._imgGameField_248.Location = New System.Drawing.Point(224, 480)
		Me._imgGameField_248.Enabled = True
		Me._imgGameField_248.Cursor = System.Windows.Forms.Cursors.Default
		Me._imgGameField_248.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal
		Me._imgGameField_248.Visible = True
		Me._imgGameField_248.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._imgGameField_248.Name = "_imgGameField_248"
		Me._imgGameField_247.Size = New System.Drawing.Size(32, 32)
		Me._imgGameField_247.Location = New System.Drawing.Point(192, 480)
		Me._imgGameField_247.Enabled = True
		Me._imgGameField_247.Cursor = System.Windows.Forms.Cursors.Default
		Me._imgGameField_247.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal
		Me._imgGameField_247.Visible = True
		Me._imgGameField_247.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._imgGameField_247.Name = "_imgGameField_247"
		Me._imgGameField_246.Size = New System.Drawing.Size(32, 32)
		Me._imgGameField_246.Location = New System.Drawing.Point(160, 480)
		Me._imgGameField_246.Enabled = True
		Me._imgGameField_246.Cursor = System.Windows.Forms.Cursors.Default
		Me._imgGameField_246.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal
		Me._imgGameField_246.Visible = True
		Me._imgGameField_246.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._imgGameField_246.Name = "_imgGameField_246"
		Me._imgGameField_245.Size = New System.Drawing.Size(32, 32)
		Me._imgGameField_245.Location = New System.Drawing.Point(128, 480)
		Me._imgGameField_245.Enabled = True
		Me._imgGameField_245.Cursor = System.Windows.Forms.Cursors.Default
		Me._imgGameField_245.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal
		Me._imgGameField_245.Visible = True
		Me._imgGameField_245.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._imgGameField_245.Name = "_imgGameField_245"
		Me._imgGameField_244.Size = New System.Drawing.Size(32, 32)
		Me._imgGameField_244.Location = New System.Drawing.Point(96, 480)
		Me._imgGameField_244.Enabled = True
		Me._imgGameField_244.Cursor = System.Windows.Forms.Cursors.Default
		Me._imgGameField_244.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal
		Me._imgGameField_244.Visible = True
		Me._imgGameField_244.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._imgGameField_244.Name = "_imgGameField_244"
		Me._imgGameField_243.Size = New System.Drawing.Size(32, 32)
		Me._imgGameField_243.Location = New System.Drawing.Point(64, 480)
		Me._imgGameField_243.Enabled = True
		Me._imgGameField_243.Cursor = System.Windows.Forms.Cursors.Default
		Me._imgGameField_243.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal
		Me._imgGameField_243.Visible = True
		Me._imgGameField_243.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._imgGameField_243.Name = "_imgGameField_243"
		Me._imgGameField_242.Size = New System.Drawing.Size(32, 32)
		Me._imgGameField_242.Location = New System.Drawing.Point(32, 480)
		Me._imgGameField_242.Enabled = True
		Me._imgGameField_242.Cursor = System.Windows.Forms.Cursors.Default
		Me._imgGameField_242.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal
		Me._imgGameField_242.Visible = True
		Me._imgGameField_242.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._imgGameField_242.Name = "_imgGameField_242"
		Me._imgGameField_241.Size = New System.Drawing.Size(32, 32)
		Me._imgGameField_241.Location = New System.Drawing.Point(0, 480)
		Me._imgGameField_241.Enabled = True
		Me._imgGameField_241.Cursor = System.Windows.Forms.Cursors.Default
		Me._imgGameField_241.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal
		Me._imgGameField_241.Visible = True
		Me._imgGameField_241.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._imgGameField_241.Name = "_imgGameField_241"
		Me._imgGameField_240.Size = New System.Drawing.Size(32, 32)
		Me._imgGameField_240.Location = New System.Drawing.Point(480, 448)
		Me._imgGameField_240.Enabled = True
		Me._imgGameField_240.Cursor = System.Windows.Forms.Cursors.Default
		Me._imgGameField_240.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal
		Me._imgGameField_240.Visible = True
		Me._imgGameField_240.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._imgGameField_240.Name = "_imgGameField_240"
		Me._imgGameField_239.Size = New System.Drawing.Size(32, 32)
		Me._imgGameField_239.Location = New System.Drawing.Point(448, 448)
		Me._imgGameField_239.Enabled = True
		Me._imgGameField_239.Cursor = System.Windows.Forms.Cursors.Default
		Me._imgGameField_239.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal
		Me._imgGameField_239.Visible = True
		Me._imgGameField_239.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._imgGameField_239.Name = "_imgGameField_239"
		Me._imgGameField_238.Size = New System.Drawing.Size(32, 32)
		Me._imgGameField_238.Location = New System.Drawing.Point(416, 448)
		Me._imgGameField_238.Enabled = True
		Me._imgGameField_238.Cursor = System.Windows.Forms.Cursors.Default
		Me._imgGameField_238.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal
		Me._imgGameField_238.Visible = True
		Me._imgGameField_238.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._imgGameField_238.Name = "_imgGameField_238"
		Me._imgGameField_237.Size = New System.Drawing.Size(32, 32)
		Me._imgGameField_237.Location = New System.Drawing.Point(384, 448)
		Me._imgGameField_237.Enabled = True
		Me._imgGameField_237.Cursor = System.Windows.Forms.Cursors.Default
		Me._imgGameField_237.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal
		Me._imgGameField_237.Visible = True
		Me._imgGameField_237.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._imgGameField_237.Name = "_imgGameField_237"
		Me._imgGameField_236.Size = New System.Drawing.Size(32, 32)
		Me._imgGameField_236.Location = New System.Drawing.Point(352, 448)
		Me._imgGameField_236.Enabled = True
		Me._imgGameField_236.Cursor = System.Windows.Forms.Cursors.Default
		Me._imgGameField_236.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal
		Me._imgGameField_236.Visible = True
		Me._imgGameField_236.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._imgGameField_236.Name = "_imgGameField_236"
		Me._imgGameField_235.Size = New System.Drawing.Size(32, 32)
		Me._imgGameField_235.Location = New System.Drawing.Point(320, 448)
		Me._imgGameField_235.Enabled = True
		Me._imgGameField_235.Cursor = System.Windows.Forms.Cursors.Default
		Me._imgGameField_235.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal
		Me._imgGameField_235.Visible = True
		Me._imgGameField_235.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._imgGameField_235.Name = "_imgGameField_235"
		Me._imgGameField_252.Size = New System.Drawing.Size(32, 32)
		Me._imgGameField_252.Location = New System.Drawing.Point(352, 480)
		Me._imgGameField_252.Enabled = True
		Me._imgGameField_252.Cursor = System.Windows.Forms.Cursors.Default
		Me._imgGameField_252.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal
		Me._imgGameField_252.Visible = True
		Me._imgGameField_252.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._imgGameField_252.Name = "_imgGameField_252"
		Me._imgGameField_233.Size = New System.Drawing.Size(32, 32)
		Me._imgGameField_233.Location = New System.Drawing.Point(256, 448)
		Me._imgGameField_233.Enabled = True
		Me._imgGameField_233.Cursor = System.Windows.Forms.Cursors.Default
		Me._imgGameField_233.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal
		Me._imgGameField_233.Visible = True
		Me._imgGameField_233.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._imgGameField_233.Name = "_imgGameField_233"
		Me._imgGameField_232.Size = New System.Drawing.Size(32, 32)
		Me._imgGameField_232.Location = New System.Drawing.Point(224, 448)
		Me._imgGameField_232.Enabled = True
		Me._imgGameField_232.Cursor = System.Windows.Forms.Cursors.Default
		Me._imgGameField_232.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal
		Me._imgGameField_232.Visible = True
		Me._imgGameField_232.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._imgGameField_232.Name = "_imgGameField_232"
		Me._imgGameField_231.Size = New System.Drawing.Size(32, 32)
		Me._imgGameField_231.Location = New System.Drawing.Point(192, 448)
		Me._imgGameField_231.Enabled = True
		Me._imgGameField_231.Cursor = System.Windows.Forms.Cursors.Default
		Me._imgGameField_231.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal
		Me._imgGameField_231.Visible = True
		Me._imgGameField_231.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._imgGameField_231.Name = "_imgGameField_231"
		Me._imgGameField_230.Size = New System.Drawing.Size(32, 32)
		Me._imgGameField_230.Location = New System.Drawing.Point(160, 448)
		Me._imgGameField_230.Enabled = True
		Me._imgGameField_230.Cursor = System.Windows.Forms.Cursors.Default
		Me._imgGameField_230.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal
		Me._imgGameField_230.Visible = True
		Me._imgGameField_230.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._imgGameField_230.Name = "_imgGameField_230"
		Me._imgGameField_229.Size = New System.Drawing.Size(32, 32)
		Me._imgGameField_229.Location = New System.Drawing.Point(128, 448)
		Me._imgGameField_229.Enabled = True
		Me._imgGameField_229.Cursor = System.Windows.Forms.Cursors.Default
		Me._imgGameField_229.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal
		Me._imgGameField_229.Visible = True
		Me._imgGameField_229.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._imgGameField_229.Name = "_imgGameField_229"
		Me._imgGameField_228.Size = New System.Drawing.Size(32, 32)
		Me._imgGameField_228.Location = New System.Drawing.Point(96, 448)
		Me._imgGameField_228.Enabled = True
		Me._imgGameField_228.Cursor = System.Windows.Forms.Cursors.Default
		Me._imgGameField_228.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal
		Me._imgGameField_228.Visible = True
		Me._imgGameField_228.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._imgGameField_228.Name = "_imgGameField_228"
		Me._imgGameField_227.Size = New System.Drawing.Size(32, 32)
		Me._imgGameField_227.Location = New System.Drawing.Point(64, 448)
		Me._imgGameField_227.Enabled = True
		Me._imgGameField_227.Cursor = System.Windows.Forms.Cursors.Default
		Me._imgGameField_227.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal
		Me._imgGameField_227.Visible = True
		Me._imgGameField_227.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._imgGameField_227.Name = "_imgGameField_227"
		Me._imgGameField_226.Size = New System.Drawing.Size(32, 32)
		Me._imgGameField_226.Location = New System.Drawing.Point(32, 448)
		Me._imgGameField_226.Enabled = True
		Me._imgGameField_226.Cursor = System.Windows.Forms.Cursors.Default
		Me._imgGameField_226.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal
		Me._imgGameField_226.Visible = True
		Me._imgGameField_226.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._imgGameField_226.Name = "_imgGameField_226"
		Me._imgGameField_225.Size = New System.Drawing.Size(32, 32)
		Me._imgGameField_225.Location = New System.Drawing.Point(0, 448)
		Me._imgGameField_225.Enabled = True
		Me._imgGameField_225.Cursor = System.Windows.Forms.Cursors.Default
		Me._imgGameField_225.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal
		Me._imgGameField_225.Visible = True
		Me._imgGameField_225.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._imgGameField_225.Name = "_imgGameField_225"
		Me._imgGameField_224.Size = New System.Drawing.Size(32, 32)
		Me._imgGameField_224.Location = New System.Drawing.Point(480, 416)
		Me._imgGameField_224.Enabled = True
		Me._imgGameField_224.Cursor = System.Windows.Forms.Cursors.Default
		Me._imgGameField_224.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal
		Me._imgGameField_224.Visible = True
		Me._imgGameField_224.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._imgGameField_224.Name = "_imgGameField_224"
		Me._imgGameField_223.Size = New System.Drawing.Size(32, 32)
		Me._imgGameField_223.Location = New System.Drawing.Point(448, 416)
		Me._imgGameField_223.Enabled = True
		Me._imgGameField_223.Cursor = System.Windows.Forms.Cursors.Default
		Me._imgGameField_223.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal
		Me._imgGameField_223.Visible = True
		Me._imgGameField_223.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._imgGameField_223.Name = "_imgGameField_223"
		Me._imgGameField_222.Size = New System.Drawing.Size(32, 32)
		Me._imgGameField_222.Location = New System.Drawing.Point(416, 416)
		Me._imgGameField_222.Enabled = True
		Me._imgGameField_222.Cursor = System.Windows.Forms.Cursors.Default
		Me._imgGameField_222.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal
		Me._imgGameField_222.Visible = True
		Me._imgGameField_222.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._imgGameField_222.Name = "_imgGameField_222"
		Me._imgGameField_221.Size = New System.Drawing.Size(32, 32)
		Me._imgGameField_221.Location = New System.Drawing.Point(384, 416)
		Me._imgGameField_221.Enabled = True
		Me._imgGameField_221.Cursor = System.Windows.Forms.Cursors.Default
		Me._imgGameField_221.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal
		Me._imgGameField_221.Visible = True
		Me._imgGameField_221.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._imgGameField_221.Name = "_imgGameField_221"
		Me._imgGameField_220.Size = New System.Drawing.Size(32, 32)
		Me._imgGameField_220.Location = New System.Drawing.Point(352, 416)
		Me._imgGameField_220.Enabled = True
		Me._imgGameField_220.Cursor = System.Windows.Forms.Cursors.Default
		Me._imgGameField_220.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal
		Me._imgGameField_220.Visible = True
		Me._imgGameField_220.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._imgGameField_220.Name = "_imgGameField_220"
		Me._imgGameField_219.Size = New System.Drawing.Size(32, 32)
		Me._imgGameField_219.Location = New System.Drawing.Point(320, 416)
		Me._imgGameField_219.Enabled = True
		Me._imgGameField_219.Cursor = System.Windows.Forms.Cursors.Default
		Me._imgGameField_219.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal
		Me._imgGameField_219.Visible = True
		Me._imgGameField_219.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._imgGameField_219.Name = "_imgGameField_219"
		Me._imgGameField_218.Size = New System.Drawing.Size(32, 32)
		Me._imgGameField_218.Location = New System.Drawing.Point(288, 416)
		Me._imgGameField_218.Enabled = True
		Me._imgGameField_218.Cursor = System.Windows.Forms.Cursors.Default
		Me._imgGameField_218.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal
		Me._imgGameField_218.Visible = True
		Me._imgGameField_218.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._imgGameField_218.Name = "_imgGameField_218"
		Me._imgGameField_217.Size = New System.Drawing.Size(32, 32)
		Me._imgGameField_217.Location = New System.Drawing.Point(256, 416)
		Me._imgGameField_217.Enabled = True
		Me._imgGameField_217.Cursor = System.Windows.Forms.Cursors.Default
		Me._imgGameField_217.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal
		Me._imgGameField_217.Visible = True
		Me._imgGameField_217.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._imgGameField_217.Name = "_imgGameField_217"
		Me._imgGameField_234.Size = New System.Drawing.Size(32, 32)
		Me._imgGameField_234.Location = New System.Drawing.Point(288, 448)
		Me._imgGameField_234.Enabled = True
		Me._imgGameField_234.Cursor = System.Windows.Forms.Cursors.Default
		Me._imgGameField_234.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal
		Me._imgGameField_234.Visible = True
		Me._imgGameField_234.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._imgGameField_234.Name = "_imgGameField_234"
		Me._imgGameField_215.Size = New System.Drawing.Size(32, 32)
		Me._imgGameField_215.Location = New System.Drawing.Point(192, 416)
		Me._imgGameField_215.Enabled = True
		Me._imgGameField_215.Cursor = System.Windows.Forms.Cursors.Default
		Me._imgGameField_215.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal
		Me._imgGameField_215.Visible = True
		Me._imgGameField_215.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._imgGameField_215.Name = "_imgGameField_215"
		Me._imgGameField_214.Size = New System.Drawing.Size(32, 32)
		Me._imgGameField_214.Location = New System.Drawing.Point(160, 416)
		Me._imgGameField_214.Enabled = True
		Me._imgGameField_214.Cursor = System.Windows.Forms.Cursors.Default
		Me._imgGameField_214.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal
		Me._imgGameField_214.Visible = True
		Me._imgGameField_214.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._imgGameField_214.Name = "_imgGameField_214"
		Me._imgGameField_213.Size = New System.Drawing.Size(32, 32)
		Me._imgGameField_213.Location = New System.Drawing.Point(128, 416)
		Me._imgGameField_213.Enabled = True
		Me._imgGameField_213.Cursor = System.Windows.Forms.Cursors.Default
		Me._imgGameField_213.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal
		Me._imgGameField_213.Visible = True
		Me._imgGameField_213.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._imgGameField_213.Name = "_imgGameField_213"
		Me._imgGameField_212.Size = New System.Drawing.Size(32, 32)
		Me._imgGameField_212.Location = New System.Drawing.Point(96, 416)
		Me._imgGameField_212.Enabled = True
		Me._imgGameField_212.Cursor = System.Windows.Forms.Cursors.Default
		Me._imgGameField_212.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal
		Me._imgGameField_212.Visible = True
		Me._imgGameField_212.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._imgGameField_212.Name = "_imgGameField_212"
		Me._imgGameField_211.Size = New System.Drawing.Size(32, 32)
		Me._imgGameField_211.Location = New System.Drawing.Point(64, 416)
		Me._imgGameField_211.Enabled = True
		Me._imgGameField_211.Cursor = System.Windows.Forms.Cursors.Default
		Me._imgGameField_211.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal
		Me._imgGameField_211.Visible = True
		Me._imgGameField_211.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._imgGameField_211.Name = "_imgGameField_211"
		Me._imgGameField_210.Size = New System.Drawing.Size(32, 32)
		Me._imgGameField_210.Location = New System.Drawing.Point(32, 416)
		Me._imgGameField_210.Enabled = True
		Me._imgGameField_210.Cursor = System.Windows.Forms.Cursors.Default
		Me._imgGameField_210.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal
		Me._imgGameField_210.Visible = True
		Me._imgGameField_210.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._imgGameField_210.Name = "_imgGameField_210"
		Me._imgGameField_209.Size = New System.Drawing.Size(32, 32)
		Me._imgGameField_209.Location = New System.Drawing.Point(0, 416)
		Me._imgGameField_209.Enabled = True
		Me._imgGameField_209.Cursor = System.Windows.Forms.Cursors.Default
		Me._imgGameField_209.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal
		Me._imgGameField_209.Visible = True
		Me._imgGameField_209.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._imgGameField_209.Name = "_imgGameField_209"
		Me._imgGameField_208.Size = New System.Drawing.Size(32, 32)
		Me._imgGameField_208.Location = New System.Drawing.Point(480, 384)
		Me._imgGameField_208.Enabled = True
		Me._imgGameField_208.Cursor = System.Windows.Forms.Cursors.Default
		Me._imgGameField_208.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal
		Me._imgGameField_208.Visible = True
		Me._imgGameField_208.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._imgGameField_208.Name = "_imgGameField_208"
		Me._imgGameField_207.Size = New System.Drawing.Size(32, 32)
		Me._imgGameField_207.Location = New System.Drawing.Point(448, 384)
		Me._imgGameField_207.Enabled = True
		Me._imgGameField_207.Cursor = System.Windows.Forms.Cursors.Default
		Me._imgGameField_207.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal
		Me._imgGameField_207.Visible = True
		Me._imgGameField_207.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._imgGameField_207.Name = "_imgGameField_207"
		Me._imgGameField_206.Size = New System.Drawing.Size(32, 32)
		Me._imgGameField_206.Location = New System.Drawing.Point(416, 384)
		Me._imgGameField_206.Enabled = True
		Me._imgGameField_206.Cursor = System.Windows.Forms.Cursors.Default
		Me._imgGameField_206.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal
		Me._imgGameField_206.Visible = True
		Me._imgGameField_206.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._imgGameField_206.Name = "_imgGameField_206"
		Me._imgGameField_205.Size = New System.Drawing.Size(32, 32)
		Me._imgGameField_205.Location = New System.Drawing.Point(384, 384)
		Me._imgGameField_205.Enabled = True
		Me._imgGameField_205.Cursor = System.Windows.Forms.Cursors.Default
		Me._imgGameField_205.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal
		Me._imgGameField_205.Visible = True
		Me._imgGameField_205.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._imgGameField_205.Name = "_imgGameField_205"
		Me._imgGameField_204.Size = New System.Drawing.Size(32, 32)
		Me._imgGameField_204.Location = New System.Drawing.Point(352, 384)
		Me._imgGameField_204.Enabled = True
		Me._imgGameField_204.Cursor = System.Windows.Forms.Cursors.Default
		Me._imgGameField_204.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal
		Me._imgGameField_204.Visible = True
		Me._imgGameField_204.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._imgGameField_204.Name = "_imgGameField_204"
		Me._imgGameField_203.Size = New System.Drawing.Size(32, 32)
		Me._imgGameField_203.Location = New System.Drawing.Point(320, 384)
		Me._imgGameField_203.Enabled = True
		Me._imgGameField_203.Cursor = System.Windows.Forms.Cursors.Default
		Me._imgGameField_203.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal
		Me._imgGameField_203.Visible = True
		Me._imgGameField_203.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._imgGameField_203.Name = "_imgGameField_203"
		Me._imgGameField_202.Size = New System.Drawing.Size(32, 32)
		Me._imgGameField_202.Location = New System.Drawing.Point(288, 384)
		Me._imgGameField_202.Enabled = True
		Me._imgGameField_202.Cursor = System.Windows.Forms.Cursors.Default
		Me._imgGameField_202.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal
		Me._imgGameField_202.Visible = True
		Me._imgGameField_202.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._imgGameField_202.Name = "_imgGameField_202"
		Me._imgGameField_201.Size = New System.Drawing.Size(32, 32)
		Me._imgGameField_201.Location = New System.Drawing.Point(256, 384)
		Me._imgGameField_201.Enabled = True
		Me._imgGameField_201.Cursor = System.Windows.Forms.Cursors.Default
		Me._imgGameField_201.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal
		Me._imgGameField_201.Visible = True
		Me._imgGameField_201.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._imgGameField_201.Name = "_imgGameField_201"
		Me._imgGameField_200.Size = New System.Drawing.Size(32, 32)
		Me._imgGameField_200.Location = New System.Drawing.Point(224, 384)
		Me._imgGameField_200.Enabled = True
		Me._imgGameField_200.Cursor = System.Windows.Forms.Cursors.Default
		Me._imgGameField_200.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal
		Me._imgGameField_200.Visible = True
		Me._imgGameField_200.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._imgGameField_200.Name = "_imgGameField_200"
		Me._imgGameField_199.Size = New System.Drawing.Size(32, 32)
		Me._imgGameField_199.Location = New System.Drawing.Point(192, 384)
		Me._imgGameField_199.Enabled = True
		Me._imgGameField_199.Cursor = System.Windows.Forms.Cursors.Default
		Me._imgGameField_199.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal
		Me._imgGameField_199.Visible = True
		Me._imgGameField_199.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._imgGameField_199.Name = "_imgGameField_199"
		Me._imgGameField_216.Size = New System.Drawing.Size(32, 32)
		Me._imgGameField_216.Location = New System.Drawing.Point(224, 416)
		Me._imgGameField_216.Enabled = True
		Me._imgGameField_216.Cursor = System.Windows.Forms.Cursors.Default
		Me._imgGameField_216.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal
		Me._imgGameField_216.Visible = True
		Me._imgGameField_216.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._imgGameField_216.Name = "_imgGameField_216"
		Me._imgGameField_197.Size = New System.Drawing.Size(32, 32)
		Me._imgGameField_197.Location = New System.Drawing.Point(128, 384)
		Me._imgGameField_197.Enabled = True
		Me._imgGameField_197.Cursor = System.Windows.Forms.Cursors.Default
		Me._imgGameField_197.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal
		Me._imgGameField_197.Visible = True
		Me._imgGameField_197.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._imgGameField_197.Name = "_imgGameField_197"
		Me._imgGameField_196.Size = New System.Drawing.Size(32, 32)
		Me._imgGameField_196.Location = New System.Drawing.Point(96, 384)
		Me._imgGameField_196.Enabled = True
		Me._imgGameField_196.Cursor = System.Windows.Forms.Cursors.Default
		Me._imgGameField_196.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal
		Me._imgGameField_196.Visible = True
		Me._imgGameField_196.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._imgGameField_196.Name = "_imgGameField_196"
		Me._imgGameField_195.Size = New System.Drawing.Size(32, 32)
		Me._imgGameField_195.Location = New System.Drawing.Point(64, 384)
		Me._imgGameField_195.Enabled = True
		Me._imgGameField_195.Cursor = System.Windows.Forms.Cursors.Default
		Me._imgGameField_195.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal
		Me._imgGameField_195.Visible = True
		Me._imgGameField_195.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._imgGameField_195.Name = "_imgGameField_195"
		Me._imgGameField_194.Size = New System.Drawing.Size(32, 32)
		Me._imgGameField_194.Location = New System.Drawing.Point(32, 384)
		Me._imgGameField_194.Enabled = True
		Me._imgGameField_194.Cursor = System.Windows.Forms.Cursors.Default
		Me._imgGameField_194.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal
		Me._imgGameField_194.Visible = True
		Me._imgGameField_194.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._imgGameField_194.Name = "_imgGameField_194"
		Me._imgGameField_193.Size = New System.Drawing.Size(32, 32)
		Me._imgGameField_193.Location = New System.Drawing.Point(0, 384)
		Me._imgGameField_193.Enabled = True
		Me._imgGameField_193.Cursor = System.Windows.Forms.Cursors.Default
		Me._imgGameField_193.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal
		Me._imgGameField_193.Visible = True
		Me._imgGameField_193.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._imgGameField_193.Name = "_imgGameField_193"
		Me._imgGameField_192.Size = New System.Drawing.Size(32, 32)
		Me._imgGameField_192.Location = New System.Drawing.Point(480, 352)
		Me._imgGameField_192.Enabled = True
		Me._imgGameField_192.Cursor = System.Windows.Forms.Cursors.Default
		Me._imgGameField_192.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal
		Me._imgGameField_192.Visible = True
		Me._imgGameField_192.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._imgGameField_192.Name = "_imgGameField_192"
		Me._imgGameField_191.Size = New System.Drawing.Size(32, 32)
		Me._imgGameField_191.Location = New System.Drawing.Point(448, 352)
		Me._imgGameField_191.Enabled = True
		Me._imgGameField_191.Cursor = System.Windows.Forms.Cursors.Default
		Me._imgGameField_191.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal
		Me._imgGameField_191.Visible = True
		Me._imgGameField_191.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._imgGameField_191.Name = "_imgGameField_191"
		Me._imgGameField_190.Size = New System.Drawing.Size(32, 32)
		Me._imgGameField_190.Location = New System.Drawing.Point(416, 352)
		Me._imgGameField_190.Enabled = True
		Me._imgGameField_190.Cursor = System.Windows.Forms.Cursors.Default
		Me._imgGameField_190.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal
		Me._imgGameField_190.Visible = True
		Me._imgGameField_190.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._imgGameField_190.Name = "_imgGameField_190"
		Me._imgGameField_189.Size = New System.Drawing.Size(32, 32)
		Me._imgGameField_189.Location = New System.Drawing.Point(384, 352)
		Me._imgGameField_189.Enabled = True
		Me._imgGameField_189.Cursor = System.Windows.Forms.Cursors.Default
		Me._imgGameField_189.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal
		Me._imgGameField_189.Visible = True
		Me._imgGameField_189.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._imgGameField_189.Name = "_imgGameField_189"
		Me._imgGameField_188.Size = New System.Drawing.Size(32, 32)
		Me._imgGameField_188.Location = New System.Drawing.Point(352, 352)
		Me._imgGameField_188.Enabled = True
		Me._imgGameField_188.Cursor = System.Windows.Forms.Cursors.Default
		Me._imgGameField_188.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal
		Me._imgGameField_188.Visible = True
		Me._imgGameField_188.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._imgGameField_188.Name = "_imgGameField_188"
		Me._imgGameField_187.Size = New System.Drawing.Size(32, 32)
		Me._imgGameField_187.Location = New System.Drawing.Point(320, 352)
		Me._imgGameField_187.Enabled = True
		Me._imgGameField_187.Cursor = System.Windows.Forms.Cursors.Default
		Me._imgGameField_187.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal
		Me._imgGameField_187.Visible = True
		Me._imgGameField_187.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._imgGameField_187.Name = "_imgGameField_187"
		Me._imgGameField_186.Size = New System.Drawing.Size(32, 32)
		Me._imgGameField_186.Location = New System.Drawing.Point(288, 352)
		Me._imgGameField_186.Enabled = True
		Me._imgGameField_186.Cursor = System.Windows.Forms.Cursors.Default
		Me._imgGameField_186.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal
		Me._imgGameField_186.Visible = True
		Me._imgGameField_186.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._imgGameField_186.Name = "_imgGameField_186"
		Me._imgGameField_185.Size = New System.Drawing.Size(32, 32)
		Me._imgGameField_185.Location = New System.Drawing.Point(256, 352)
		Me._imgGameField_185.Enabled = True
		Me._imgGameField_185.Cursor = System.Windows.Forms.Cursors.Default
		Me._imgGameField_185.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal
		Me._imgGameField_185.Visible = True
		Me._imgGameField_185.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._imgGameField_185.Name = "_imgGameField_185"
		Me._imgGameField_184.Size = New System.Drawing.Size(32, 32)
		Me._imgGameField_184.Location = New System.Drawing.Point(224, 352)
		Me._imgGameField_184.Enabled = True
		Me._imgGameField_184.Cursor = System.Windows.Forms.Cursors.Default
		Me._imgGameField_184.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal
		Me._imgGameField_184.Visible = True
		Me._imgGameField_184.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._imgGameField_184.Name = "_imgGameField_184"
		Me._imgGameField_183.Size = New System.Drawing.Size(32, 32)
		Me._imgGameField_183.Location = New System.Drawing.Point(192, 352)
		Me._imgGameField_183.Enabled = True
		Me._imgGameField_183.Cursor = System.Windows.Forms.Cursors.Default
		Me._imgGameField_183.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal
		Me._imgGameField_183.Visible = True
		Me._imgGameField_183.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._imgGameField_183.Name = "_imgGameField_183"
		Me._imgGameField_182.Size = New System.Drawing.Size(32, 32)
		Me._imgGameField_182.Location = New System.Drawing.Point(160, 352)
		Me._imgGameField_182.Enabled = True
		Me._imgGameField_182.Cursor = System.Windows.Forms.Cursors.Default
		Me._imgGameField_182.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal
		Me._imgGameField_182.Visible = True
		Me._imgGameField_182.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._imgGameField_182.Name = "_imgGameField_182"
		Me._imgGameField_181.Size = New System.Drawing.Size(32, 32)
		Me._imgGameField_181.Location = New System.Drawing.Point(128, 352)
		Me._imgGameField_181.Enabled = True
		Me._imgGameField_181.Cursor = System.Windows.Forms.Cursors.Default
		Me._imgGameField_181.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal
		Me._imgGameField_181.Visible = True
		Me._imgGameField_181.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._imgGameField_181.Name = "_imgGameField_181"
		Me._imgGameField_198.Size = New System.Drawing.Size(32, 32)
		Me._imgGameField_198.Location = New System.Drawing.Point(160, 384)
		Me._imgGameField_198.Enabled = True
		Me._imgGameField_198.Cursor = System.Windows.Forms.Cursors.Default
		Me._imgGameField_198.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal
		Me._imgGameField_198.Visible = True
		Me._imgGameField_198.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._imgGameField_198.Name = "_imgGameField_198"
		Me._imgGameField_179.Size = New System.Drawing.Size(32, 32)
		Me._imgGameField_179.Location = New System.Drawing.Point(64, 352)
		Me._imgGameField_179.Enabled = True
		Me._imgGameField_179.Cursor = System.Windows.Forms.Cursors.Default
		Me._imgGameField_179.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal
		Me._imgGameField_179.Visible = True
		Me._imgGameField_179.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._imgGameField_179.Name = "_imgGameField_179"
		Me._imgGameField_178.Size = New System.Drawing.Size(32, 32)
		Me._imgGameField_178.Location = New System.Drawing.Point(32, 352)
		Me._imgGameField_178.Enabled = True
		Me._imgGameField_178.Cursor = System.Windows.Forms.Cursors.Default
		Me._imgGameField_178.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal
		Me._imgGameField_178.Visible = True
		Me._imgGameField_178.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._imgGameField_178.Name = "_imgGameField_178"
		Me._imgGameField_177.Size = New System.Drawing.Size(32, 32)
		Me._imgGameField_177.Location = New System.Drawing.Point(0, 352)
		Me._imgGameField_177.Enabled = True
		Me._imgGameField_177.Cursor = System.Windows.Forms.Cursors.Default
		Me._imgGameField_177.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal
		Me._imgGameField_177.Visible = True
		Me._imgGameField_177.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._imgGameField_177.Name = "_imgGameField_177"
		Me._imgGameField_176.Size = New System.Drawing.Size(32, 32)
		Me._imgGameField_176.Location = New System.Drawing.Point(480, 320)
		Me._imgGameField_176.Enabled = True
		Me._imgGameField_176.Cursor = System.Windows.Forms.Cursors.Default
		Me._imgGameField_176.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal
		Me._imgGameField_176.Visible = True
		Me._imgGameField_176.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._imgGameField_176.Name = "_imgGameField_176"
		Me._imgGameField_175.Size = New System.Drawing.Size(32, 32)
		Me._imgGameField_175.Location = New System.Drawing.Point(448, 320)
		Me._imgGameField_175.Enabled = True
		Me._imgGameField_175.Cursor = System.Windows.Forms.Cursors.Default
		Me._imgGameField_175.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal
		Me._imgGameField_175.Visible = True
		Me._imgGameField_175.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._imgGameField_175.Name = "_imgGameField_175"
		Me._imgGameField_174.Size = New System.Drawing.Size(32, 32)
		Me._imgGameField_174.Location = New System.Drawing.Point(416, 320)
		Me._imgGameField_174.Enabled = True
		Me._imgGameField_174.Cursor = System.Windows.Forms.Cursors.Default
		Me._imgGameField_174.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal
		Me._imgGameField_174.Visible = True
		Me._imgGameField_174.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._imgGameField_174.Name = "_imgGameField_174"
		Me._imgGameField_173.Size = New System.Drawing.Size(32, 32)
		Me._imgGameField_173.Location = New System.Drawing.Point(384, 320)
		Me._imgGameField_173.Enabled = True
		Me._imgGameField_173.Cursor = System.Windows.Forms.Cursors.Default
		Me._imgGameField_173.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal
		Me._imgGameField_173.Visible = True
		Me._imgGameField_173.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._imgGameField_173.Name = "_imgGameField_173"
		Me._imgGameField_172.Size = New System.Drawing.Size(32, 32)
		Me._imgGameField_172.Location = New System.Drawing.Point(352, 320)
		Me._imgGameField_172.Enabled = True
		Me._imgGameField_172.Cursor = System.Windows.Forms.Cursors.Default
		Me._imgGameField_172.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal
		Me._imgGameField_172.Visible = True
		Me._imgGameField_172.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._imgGameField_172.Name = "_imgGameField_172"
		Me._imgGameField_171.Size = New System.Drawing.Size(32, 32)
		Me._imgGameField_171.Location = New System.Drawing.Point(320, 320)
		Me._imgGameField_171.Enabled = True
		Me._imgGameField_171.Cursor = System.Windows.Forms.Cursors.Default
		Me._imgGameField_171.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal
		Me._imgGameField_171.Visible = True
		Me._imgGameField_171.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._imgGameField_171.Name = "_imgGameField_171"
		Me._imgGameField_170.Size = New System.Drawing.Size(32, 32)
		Me._imgGameField_170.Location = New System.Drawing.Point(288, 320)
		Me._imgGameField_170.Enabled = True
		Me._imgGameField_170.Cursor = System.Windows.Forms.Cursors.Default
		Me._imgGameField_170.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal
		Me._imgGameField_170.Visible = True
		Me._imgGameField_170.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._imgGameField_170.Name = "_imgGameField_170"
		Me._imgGameField_169.Size = New System.Drawing.Size(32, 32)
		Me._imgGameField_169.Location = New System.Drawing.Point(256, 320)
		Me._imgGameField_169.Enabled = True
		Me._imgGameField_169.Cursor = System.Windows.Forms.Cursors.Default
		Me._imgGameField_169.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal
		Me._imgGameField_169.Visible = True
		Me._imgGameField_169.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._imgGameField_169.Name = "_imgGameField_169"
		Me._imgGameField_168.Size = New System.Drawing.Size(32, 32)
		Me._imgGameField_168.Location = New System.Drawing.Point(224, 320)
		Me._imgGameField_168.Enabled = True
		Me._imgGameField_168.Cursor = System.Windows.Forms.Cursors.Default
		Me._imgGameField_168.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal
		Me._imgGameField_168.Visible = True
		Me._imgGameField_168.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._imgGameField_168.Name = "_imgGameField_168"
		Me._imgGameField_167.Size = New System.Drawing.Size(32, 32)
		Me._imgGameField_167.Location = New System.Drawing.Point(192, 320)
		Me._imgGameField_167.Enabled = True
		Me._imgGameField_167.Cursor = System.Windows.Forms.Cursors.Default
		Me._imgGameField_167.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal
		Me._imgGameField_167.Visible = True
		Me._imgGameField_167.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._imgGameField_167.Name = "_imgGameField_167"
		Me._imgGameField_166.Size = New System.Drawing.Size(32, 32)
		Me._imgGameField_166.Location = New System.Drawing.Point(160, 320)
		Me._imgGameField_166.Enabled = True
		Me._imgGameField_166.Cursor = System.Windows.Forms.Cursors.Default
		Me._imgGameField_166.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal
		Me._imgGameField_166.Visible = True
		Me._imgGameField_166.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._imgGameField_166.Name = "_imgGameField_166"
		Me._imgGameField_165.Size = New System.Drawing.Size(32, 32)
		Me._imgGameField_165.Location = New System.Drawing.Point(128, 320)
		Me._imgGameField_165.Enabled = True
		Me._imgGameField_165.Cursor = System.Windows.Forms.Cursors.Default
		Me._imgGameField_165.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal
		Me._imgGameField_165.Visible = True
		Me._imgGameField_165.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._imgGameField_165.Name = "_imgGameField_165"
		Me._imgGameField_164.Size = New System.Drawing.Size(32, 32)
		Me._imgGameField_164.Location = New System.Drawing.Point(96, 320)
		Me._imgGameField_164.Enabled = True
		Me._imgGameField_164.Cursor = System.Windows.Forms.Cursors.Default
		Me._imgGameField_164.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal
		Me._imgGameField_164.Visible = True
		Me._imgGameField_164.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._imgGameField_164.Name = "_imgGameField_164"
		Me._imgGameField_163.Size = New System.Drawing.Size(32, 32)
		Me._imgGameField_163.Location = New System.Drawing.Point(64, 320)
		Me._imgGameField_163.Enabled = True
		Me._imgGameField_163.Cursor = System.Windows.Forms.Cursors.Default
		Me._imgGameField_163.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal
		Me._imgGameField_163.Visible = True
		Me._imgGameField_163.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._imgGameField_163.Name = "_imgGameField_163"
		Me._imgGameField_162.Size = New System.Drawing.Size(32, 32)
		Me._imgGameField_162.Location = New System.Drawing.Point(32, 320)
		Me._imgGameField_162.Enabled = True
		Me._imgGameField_162.Cursor = System.Windows.Forms.Cursors.Default
		Me._imgGameField_162.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal
		Me._imgGameField_162.Visible = True
		Me._imgGameField_162.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._imgGameField_162.Name = "_imgGameField_162"
		Me._imgGameField_161.Size = New System.Drawing.Size(32, 32)
		Me._imgGameField_161.Location = New System.Drawing.Point(0, 320)
		Me._imgGameField_161.Enabled = True
		Me._imgGameField_161.Cursor = System.Windows.Forms.Cursors.Default
		Me._imgGameField_161.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal
		Me._imgGameField_161.Visible = True
		Me._imgGameField_161.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._imgGameField_161.Name = "_imgGameField_161"
		Me._imgGameField_180.Size = New System.Drawing.Size(32, 32)
		Me._imgGameField_180.Location = New System.Drawing.Point(96, 352)
		Me._imgGameField_180.Enabled = True
		Me._imgGameField_180.Cursor = System.Windows.Forms.Cursors.Default
		Me._imgGameField_180.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal
		Me._imgGameField_180.Visible = True
		Me._imgGameField_180.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._imgGameField_180.Name = "_imgGameField_180"
		Me._imgGameField_159.Size = New System.Drawing.Size(32, 32)
		Me._imgGameField_159.Location = New System.Drawing.Point(448, 288)
		Me._imgGameField_159.Enabled = True
		Me._imgGameField_159.Cursor = System.Windows.Forms.Cursors.Default
		Me._imgGameField_159.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal
		Me._imgGameField_159.Visible = True
		Me._imgGameField_159.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._imgGameField_159.Name = "_imgGameField_159"
		Me._imgGameField_158.Size = New System.Drawing.Size(32, 32)
		Me._imgGameField_158.Location = New System.Drawing.Point(416, 288)
		Me._imgGameField_158.Enabled = True
		Me._imgGameField_158.Cursor = System.Windows.Forms.Cursors.Default
		Me._imgGameField_158.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal
		Me._imgGameField_158.Visible = True
		Me._imgGameField_158.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._imgGameField_158.Name = "_imgGameField_158"
		Me._imgGameField_157.Size = New System.Drawing.Size(32, 32)
		Me._imgGameField_157.Location = New System.Drawing.Point(384, 288)
		Me._imgGameField_157.Enabled = True
		Me._imgGameField_157.Cursor = System.Windows.Forms.Cursors.Default
		Me._imgGameField_157.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal
		Me._imgGameField_157.Visible = True
		Me._imgGameField_157.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._imgGameField_157.Name = "_imgGameField_157"
		Me._imgGameField_156.Size = New System.Drawing.Size(32, 32)
		Me._imgGameField_156.Location = New System.Drawing.Point(352, 288)
		Me._imgGameField_156.Enabled = True
		Me._imgGameField_156.Cursor = System.Windows.Forms.Cursors.Default
		Me._imgGameField_156.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal
		Me._imgGameField_156.Visible = True
		Me._imgGameField_156.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._imgGameField_156.Name = "_imgGameField_156"
		Me._imgGameField_155.Size = New System.Drawing.Size(32, 32)
		Me._imgGameField_155.Location = New System.Drawing.Point(320, 288)
		Me._imgGameField_155.Enabled = True
		Me._imgGameField_155.Cursor = System.Windows.Forms.Cursors.Default
		Me._imgGameField_155.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal
		Me._imgGameField_155.Visible = True
		Me._imgGameField_155.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._imgGameField_155.Name = "_imgGameField_155"
		Me._imgGameField_154.Size = New System.Drawing.Size(32, 32)
		Me._imgGameField_154.Location = New System.Drawing.Point(288, 288)
		Me._imgGameField_154.Enabled = True
		Me._imgGameField_154.Cursor = System.Windows.Forms.Cursors.Default
		Me._imgGameField_154.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal
		Me._imgGameField_154.Visible = True
		Me._imgGameField_154.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._imgGameField_154.Name = "_imgGameField_154"
		Me._imgGameField_153.Size = New System.Drawing.Size(32, 32)
		Me._imgGameField_153.Location = New System.Drawing.Point(256, 288)
		Me._imgGameField_153.Enabled = True
		Me._imgGameField_153.Cursor = System.Windows.Forms.Cursors.Default
		Me._imgGameField_153.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal
		Me._imgGameField_153.Visible = True
		Me._imgGameField_153.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._imgGameField_153.Name = "_imgGameField_153"
		Me._imgGameField_152.Size = New System.Drawing.Size(32, 32)
		Me._imgGameField_152.Location = New System.Drawing.Point(224, 288)
		Me._imgGameField_152.Enabled = True
		Me._imgGameField_152.Cursor = System.Windows.Forms.Cursors.Default
		Me._imgGameField_152.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal
		Me._imgGameField_152.Visible = True
		Me._imgGameField_152.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._imgGameField_152.Name = "_imgGameField_152"
		Me._imgGameField_151.Size = New System.Drawing.Size(32, 32)
		Me._imgGameField_151.Location = New System.Drawing.Point(192, 288)
		Me._imgGameField_151.Enabled = True
		Me._imgGameField_151.Cursor = System.Windows.Forms.Cursors.Default
		Me._imgGameField_151.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal
		Me._imgGameField_151.Visible = True
		Me._imgGameField_151.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._imgGameField_151.Name = "_imgGameField_151"
		Me._imgGameField_150.Size = New System.Drawing.Size(32, 32)
		Me._imgGameField_150.Location = New System.Drawing.Point(160, 288)
		Me._imgGameField_150.Enabled = True
		Me._imgGameField_150.Cursor = System.Windows.Forms.Cursors.Default
		Me._imgGameField_150.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal
		Me._imgGameField_150.Visible = True
		Me._imgGameField_150.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._imgGameField_150.Name = "_imgGameField_150"
		Me._imgGameField_149.Size = New System.Drawing.Size(32, 32)
		Me._imgGameField_149.Location = New System.Drawing.Point(128, 288)
		Me._imgGameField_149.Enabled = True
		Me._imgGameField_149.Cursor = System.Windows.Forms.Cursors.Default
		Me._imgGameField_149.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal
		Me._imgGameField_149.Visible = True
		Me._imgGameField_149.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._imgGameField_149.Name = "_imgGameField_149"
		Me._imgGameField_148.Size = New System.Drawing.Size(32, 32)
		Me._imgGameField_148.Location = New System.Drawing.Point(96, 288)
		Me._imgGameField_148.Enabled = True
		Me._imgGameField_148.Cursor = System.Windows.Forms.Cursors.Default
		Me._imgGameField_148.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal
		Me._imgGameField_148.Visible = True
		Me._imgGameField_148.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._imgGameField_148.Name = "_imgGameField_148"
		Me._imgGameField_147.Size = New System.Drawing.Size(32, 32)
		Me._imgGameField_147.Location = New System.Drawing.Point(64, 288)
		Me._imgGameField_147.Enabled = True
		Me._imgGameField_147.Cursor = System.Windows.Forms.Cursors.Default
		Me._imgGameField_147.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal
		Me._imgGameField_147.Visible = True
		Me._imgGameField_147.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._imgGameField_147.Name = "_imgGameField_147"
		Me._imgGameField_146.Size = New System.Drawing.Size(32, 32)
		Me._imgGameField_146.Location = New System.Drawing.Point(32, 288)
		Me._imgGameField_146.Enabled = True
		Me._imgGameField_146.Cursor = System.Windows.Forms.Cursors.Default
		Me._imgGameField_146.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal
		Me._imgGameField_146.Visible = True
		Me._imgGameField_146.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._imgGameField_146.Name = "_imgGameField_146"
		Me._imgGameField_145.Size = New System.Drawing.Size(32, 32)
		Me._imgGameField_145.Location = New System.Drawing.Point(0, 288)
		Me._imgGameField_145.Enabled = True
		Me._imgGameField_145.Cursor = System.Windows.Forms.Cursors.Default
		Me._imgGameField_145.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal
		Me._imgGameField_145.Visible = True
		Me._imgGameField_145.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._imgGameField_145.Name = "_imgGameField_145"
		Me._imgGameField_144.Size = New System.Drawing.Size(32, 32)
		Me._imgGameField_144.Location = New System.Drawing.Point(480, 256)
		Me._imgGameField_144.Enabled = True
		Me._imgGameField_144.Cursor = System.Windows.Forms.Cursors.Default
		Me._imgGameField_144.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal
		Me._imgGameField_144.Visible = True
		Me._imgGameField_144.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._imgGameField_144.Name = "_imgGameField_144"
		Me._imgGameField_143.Size = New System.Drawing.Size(32, 32)
		Me._imgGameField_143.Location = New System.Drawing.Point(448, 256)
		Me._imgGameField_143.Enabled = True
		Me._imgGameField_143.Cursor = System.Windows.Forms.Cursors.Default
		Me._imgGameField_143.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal
		Me._imgGameField_143.Visible = True
		Me._imgGameField_143.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._imgGameField_143.Name = "_imgGameField_143"
		Me._imgGameField_142.Size = New System.Drawing.Size(32, 32)
		Me._imgGameField_142.Location = New System.Drawing.Point(416, 256)
		Me._imgGameField_142.Enabled = True
		Me._imgGameField_142.Cursor = System.Windows.Forms.Cursors.Default
		Me._imgGameField_142.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal
		Me._imgGameField_142.Visible = True
		Me._imgGameField_142.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._imgGameField_142.Name = "_imgGameField_142"
		Me._imgGameField_141.Size = New System.Drawing.Size(32, 32)
		Me._imgGameField_141.Location = New System.Drawing.Point(384, 256)
		Me._imgGameField_141.Enabled = True
		Me._imgGameField_141.Cursor = System.Windows.Forms.Cursors.Default
		Me._imgGameField_141.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal
		Me._imgGameField_141.Visible = True
		Me._imgGameField_141.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._imgGameField_141.Name = "_imgGameField_141"
		Me._imgGameField_160.Size = New System.Drawing.Size(32, 32)
		Me._imgGameField_160.Location = New System.Drawing.Point(480, 288)
		Me._imgGameField_160.Enabled = True
		Me._imgGameField_160.Cursor = System.Windows.Forms.Cursors.Default
		Me._imgGameField_160.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal
		Me._imgGameField_160.Visible = True
		Me._imgGameField_160.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._imgGameField_160.Name = "_imgGameField_160"
		Me._imgGameField_140.Size = New System.Drawing.Size(32, 32)
		Me._imgGameField_140.Location = New System.Drawing.Point(352, 256)
		Me._imgGameField_140.Enabled = True
		Me._imgGameField_140.Cursor = System.Windows.Forms.Cursors.Default
		Me._imgGameField_140.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal
		Me._imgGameField_140.Visible = True
		Me._imgGameField_140.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._imgGameField_140.Name = "_imgGameField_140"
		Me._imgGameField_139.Size = New System.Drawing.Size(32, 32)
		Me._imgGameField_139.Location = New System.Drawing.Point(320, 256)
		Me._imgGameField_139.Enabled = True
		Me._imgGameField_139.Cursor = System.Windows.Forms.Cursors.Default
		Me._imgGameField_139.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal
		Me._imgGameField_139.Visible = True
		Me._imgGameField_139.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._imgGameField_139.Name = "_imgGameField_139"
		Me._imgGameField_138.Size = New System.Drawing.Size(32, 32)
		Me._imgGameField_138.Location = New System.Drawing.Point(288, 256)
		Me._imgGameField_138.Enabled = True
		Me._imgGameField_138.Cursor = System.Windows.Forms.Cursors.Default
		Me._imgGameField_138.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal
		Me._imgGameField_138.Visible = True
		Me._imgGameField_138.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._imgGameField_138.Name = "_imgGameField_138"
		Me._imgGameField_137.Size = New System.Drawing.Size(32, 32)
		Me._imgGameField_137.Location = New System.Drawing.Point(256, 256)
		Me._imgGameField_137.Enabled = True
		Me._imgGameField_137.Cursor = System.Windows.Forms.Cursors.Default
		Me._imgGameField_137.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal
		Me._imgGameField_137.Visible = True
		Me._imgGameField_137.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._imgGameField_137.Name = "_imgGameField_137"
		Me._imgGameField_136.Size = New System.Drawing.Size(32, 32)
		Me._imgGameField_136.Location = New System.Drawing.Point(224, 256)
		Me._imgGameField_136.Enabled = True
		Me._imgGameField_136.Cursor = System.Windows.Forms.Cursors.Default
		Me._imgGameField_136.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal
		Me._imgGameField_136.Visible = True
		Me._imgGameField_136.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._imgGameField_136.Name = "_imgGameField_136"
		Me._imgGameField_135.Size = New System.Drawing.Size(32, 32)
		Me._imgGameField_135.Location = New System.Drawing.Point(192, 256)
		Me._imgGameField_135.Enabled = True
		Me._imgGameField_135.Cursor = System.Windows.Forms.Cursors.Default
		Me._imgGameField_135.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal
		Me._imgGameField_135.Visible = True
		Me._imgGameField_135.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._imgGameField_135.Name = "_imgGameField_135"
		Me._imgGameField_134.Size = New System.Drawing.Size(32, 32)
		Me._imgGameField_134.Location = New System.Drawing.Point(160, 256)
		Me._imgGameField_134.Enabled = True
		Me._imgGameField_134.Cursor = System.Windows.Forms.Cursors.Default
		Me._imgGameField_134.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal
		Me._imgGameField_134.Visible = True
		Me._imgGameField_134.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._imgGameField_134.Name = "_imgGameField_134"
		Me._imgGameField_133.Size = New System.Drawing.Size(32, 32)
		Me._imgGameField_133.Location = New System.Drawing.Point(128, 256)
		Me._imgGameField_133.Enabled = True
		Me._imgGameField_133.Cursor = System.Windows.Forms.Cursors.Default
		Me._imgGameField_133.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal
		Me._imgGameField_133.Visible = True
		Me._imgGameField_133.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._imgGameField_133.Name = "_imgGameField_133"
		Me._imgGameField_132.Size = New System.Drawing.Size(32, 32)
		Me._imgGameField_132.Location = New System.Drawing.Point(96, 256)
		Me._imgGameField_132.Enabled = True
		Me._imgGameField_132.Cursor = System.Windows.Forms.Cursors.Default
		Me._imgGameField_132.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal
		Me._imgGameField_132.Visible = True
		Me._imgGameField_132.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._imgGameField_132.Name = "_imgGameField_132"
		Me._imgGameField_131.Size = New System.Drawing.Size(32, 32)
		Me._imgGameField_131.Location = New System.Drawing.Point(64, 256)
		Me._imgGameField_131.Enabled = True
		Me._imgGameField_131.Cursor = System.Windows.Forms.Cursors.Default
		Me._imgGameField_131.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal
		Me._imgGameField_131.Visible = True
		Me._imgGameField_131.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._imgGameField_131.Name = "_imgGameField_131"
		Me._imgGameField_130.Size = New System.Drawing.Size(32, 32)
		Me._imgGameField_130.Location = New System.Drawing.Point(32, 256)
		Me._imgGameField_130.Enabled = True
		Me._imgGameField_130.Cursor = System.Windows.Forms.Cursors.Default
		Me._imgGameField_130.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal
		Me._imgGameField_130.Visible = True
		Me._imgGameField_130.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._imgGameField_130.Name = "_imgGameField_130"
		Me._imgGameField_129.Size = New System.Drawing.Size(32, 32)
		Me._imgGameField_129.Location = New System.Drawing.Point(0, 256)
		Me._imgGameField_129.Enabled = True
		Me._imgGameField_129.Cursor = System.Windows.Forms.Cursors.Default
		Me._imgGameField_129.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal
		Me._imgGameField_129.Visible = True
		Me._imgGameField_129.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._imgGameField_129.Name = "_imgGameField_129"
		Me._imgGameField_128.Size = New System.Drawing.Size(32, 32)
		Me._imgGameField_128.Location = New System.Drawing.Point(480, 224)
		Me._imgGameField_128.Enabled = True
		Me._imgGameField_128.Cursor = System.Windows.Forms.Cursors.Default
		Me._imgGameField_128.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal
		Me._imgGameField_128.Visible = True
		Me._imgGameField_128.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._imgGameField_128.Name = "_imgGameField_128"
		Me._imgGameField_127.Size = New System.Drawing.Size(32, 32)
		Me._imgGameField_127.Location = New System.Drawing.Point(448, 224)
		Me._imgGameField_127.Enabled = True
		Me._imgGameField_127.Cursor = System.Windows.Forms.Cursors.Default
		Me._imgGameField_127.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal
		Me._imgGameField_127.Visible = True
		Me._imgGameField_127.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._imgGameField_127.Name = "_imgGameField_127"
		Me._imgGameField_126.Size = New System.Drawing.Size(32, 32)
		Me._imgGameField_126.Location = New System.Drawing.Point(416, 224)
		Me._imgGameField_126.Enabled = True
		Me._imgGameField_126.Cursor = System.Windows.Forms.Cursors.Default
		Me._imgGameField_126.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal
		Me._imgGameField_126.Visible = True
		Me._imgGameField_126.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._imgGameField_126.Name = "_imgGameField_126"
		Me._imgGameField_125.Size = New System.Drawing.Size(32, 32)
		Me._imgGameField_125.Location = New System.Drawing.Point(384, 224)
		Me._imgGameField_125.Enabled = True
		Me._imgGameField_125.Cursor = System.Windows.Forms.Cursors.Default
		Me._imgGameField_125.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal
		Me._imgGameField_125.Visible = True
		Me._imgGameField_125.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._imgGameField_125.Name = "_imgGameField_125"
		Me._imgGameField_124.Size = New System.Drawing.Size(32, 32)
		Me._imgGameField_124.Location = New System.Drawing.Point(352, 224)
		Me._imgGameField_124.Enabled = True
		Me._imgGameField_124.Cursor = System.Windows.Forms.Cursors.Default
		Me._imgGameField_124.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal
		Me._imgGameField_124.Visible = True
		Me._imgGameField_124.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._imgGameField_124.Name = "_imgGameField_124"
		Me._imgGameField_123.Size = New System.Drawing.Size(32, 32)
		Me._imgGameField_123.Location = New System.Drawing.Point(320, 224)
		Me._imgGameField_123.Enabled = True
		Me._imgGameField_123.Cursor = System.Windows.Forms.Cursors.Default
		Me._imgGameField_123.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal
		Me._imgGameField_123.Visible = True
		Me._imgGameField_123.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._imgGameField_123.Name = "_imgGameField_123"
		Me._imgGameField_122.Size = New System.Drawing.Size(32, 32)
		Me._imgGameField_122.Location = New System.Drawing.Point(288, 224)
		Me._imgGameField_122.Enabled = True
		Me._imgGameField_122.Cursor = System.Windows.Forms.Cursors.Default
		Me._imgGameField_122.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal
		Me._imgGameField_122.Visible = True
		Me._imgGameField_122.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._imgGameField_122.Name = "_imgGameField_122"
		Me._imgGameField_121.Size = New System.Drawing.Size(32, 32)
		Me._imgGameField_121.Location = New System.Drawing.Point(256, 224)
		Me._imgGameField_121.Enabled = True
		Me._imgGameField_121.Cursor = System.Windows.Forms.Cursors.Default
		Me._imgGameField_121.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal
		Me._imgGameField_121.Visible = True
		Me._imgGameField_121.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._imgGameField_121.Name = "_imgGameField_121"
		Me._imgGameField_120.Size = New System.Drawing.Size(32, 32)
		Me._imgGameField_120.Location = New System.Drawing.Point(224, 224)
		Me._imgGameField_120.Enabled = True
		Me._imgGameField_120.Cursor = System.Windows.Forms.Cursors.Default
		Me._imgGameField_120.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal
		Me._imgGameField_120.Visible = True
		Me._imgGameField_120.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._imgGameField_120.Name = "_imgGameField_120"
		Me._imgGameField_119.Size = New System.Drawing.Size(32, 32)
		Me._imgGameField_119.Location = New System.Drawing.Point(192, 224)
		Me._imgGameField_119.Enabled = True
		Me._imgGameField_119.Cursor = System.Windows.Forms.Cursors.Default
		Me._imgGameField_119.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal
		Me._imgGameField_119.Visible = True
		Me._imgGameField_119.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._imgGameField_119.Name = "_imgGameField_119"
		Me._imgGameField_118.Size = New System.Drawing.Size(32, 32)
		Me._imgGameField_118.Location = New System.Drawing.Point(160, 224)
		Me._imgGameField_118.Enabled = True
		Me._imgGameField_118.Cursor = System.Windows.Forms.Cursors.Default
		Me._imgGameField_118.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal
		Me._imgGameField_118.Visible = True
		Me._imgGameField_118.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._imgGameField_118.Name = "_imgGameField_118"
		Me._imgGameField_117.Size = New System.Drawing.Size(32, 32)
		Me._imgGameField_117.Location = New System.Drawing.Point(128, 224)
		Me._imgGameField_117.Enabled = True
		Me._imgGameField_117.Cursor = System.Windows.Forms.Cursors.Default
		Me._imgGameField_117.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal
		Me._imgGameField_117.Visible = True
		Me._imgGameField_117.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._imgGameField_117.Name = "_imgGameField_117"
		Me._imgGameField_116.Size = New System.Drawing.Size(32, 32)
		Me._imgGameField_116.Location = New System.Drawing.Point(96, 224)
		Me._imgGameField_116.Enabled = True
		Me._imgGameField_116.Cursor = System.Windows.Forms.Cursors.Default
		Me._imgGameField_116.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal
		Me._imgGameField_116.Visible = True
		Me._imgGameField_116.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._imgGameField_116.Name = "_imgGameField_116"
		Me._imgGameField_115.Size = New System.Drawing.Size(32, 32)
		Me._imgGameField_115.Location = New System.Drawing.Point(64, 224)
		Me._imgGameField_115.Enabled = True
		Me._imgGameField_115.Cursor = System.Windows.Forms.Cursors.Default
		Me._imgGameField_115.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal
		Me._imgGameField_115.Visible = True
		Me._imgGameField_115.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._imgGameField_115.Name = "_imgGameField_115"
		Me._imgGameField_114.Size = New System.Drawing.Size(32, 32)
		Me._imgGameField_114.Location = New System.Drawing.Point(32, 224)
		Me._imgGameField_114.Enabled = True
		Me._imgGameField_114.Cursor = System.Windows.Forms.Cursors.Default
		Me._imgGameField_114.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal
		Me._imgGameField_114.Visible = True
		Me._imgGameField_114.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._imgGameField_114.Name = "_imgGameField_114"
		Me._imgGameField_113.Size = New System.Drawing.Size(32, 32)
		Me._imgGameField_113.Location = New System.Drawing.Point(0, 224)
		Me._imgGameField_113.Enabled = True
		Me._imgGameField_113.Cursor = System.Windows.Forms.Cursors.Default
		Me._imgGameField_113.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal
		Me._imgGameField_113.Visible = True
		Me._imgGameField_113.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._imgGameField_113.Name = "_imgGameField_113"
		Me._imgGameField_112.Size = New System.Drawing.Size(32, 32)
		Me._imgGameField_112.Location = New System.Drawing.Point(480, 192)
		Me._imgGameField_112.Enabled = True
		Me._imgGameField_112.Cursor = System.Windows.Forms.Cursors.Default
		Me._imgGameField_112.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal
		Me._imgGameField_112.Visible = True
		Me._imgGameField_112.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._imgGameField_112.Name = "_imgGameField_112"
		Me._imgGameField_111.Size = New System.Drawing.Size(32, 32)
		Me._imgGameField_111.Location = New System.Drawing.Point(448, 192)
		Me._imgGameField_111.Enabled = True
		Me._imgGameField_111.Cursor = System.Windows.Forms.Cursors.Default
		Me._imgGameField_111.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal
		Me._imgGameField_111.Visible = True
		Me._imgGameField_111.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._imgGameField_111.Name = "_imgGameField_111"
		Me._imgGameField_110.Size = New System.Drawing.Size(32, 32)
		Me._imgGameField_110.Location = New System.Drawing.Point(416, 192)
		Me._imgGameField_110.Enabled = True
		Me._imgGameField_110.Cursor = System.Windows.Forms.Cursors.Default
		Me._imgGameField_110.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal
		Me._imgGameField_110.Visible = True
		Me._imgGameField_110.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._imgGameField_110.Name = "_imgGameField_110"
		Me._imgGameField_109.Size = New System.Drawing.Size(32, 32)
		Me._imgGameField_109.Location = New System.Drawing.Point(384, 192)
		Me._imgGameField_109.Enabled = True
		Me._imgGameField_109.Cursor = System.Windows.Forms.Cursors.Default
		Me._imgGameField_109.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal
		Me._imgGameField_109.Visible = True
		Me._imgGameField_109.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._imgGameField_109.Name = "_imgGameField_109"
		Me._imgGameField_108.Size = New System.Drawing.Size(32, 32)
		Me._imgGameField_108.Location = New System.Drawing.Point(352, 192)
		Me._imgGameField_108.Enabled = True
		Me._imgGameField_108.Cursor = System.Windows.Forms.Cursors.Default
		Me._imgGameField_108.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal
		Me._imgGameField_108.Visible = True
		Me._imgGameField_108.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._imgGameField_108.Name = "_imgGameField_108"
		Me._imgGameField_107.Size = New System.Drawing.Size(32, 32)
		Me._imgGameField_107.Location = New System.Drawing.Point(320, 192)
		Me._imgGameField_107.Enabled = True
		Me._imgGameField_107.Cursor = System.Windows.Forms.Cursors.Default
		Me._imgGameField_107.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal
		Me._imgGameField_107.Visible = True
		Me._imgGameField_107.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._imgGameField_107.Name = "_imgGameField_107"
		Me._imgGameField_106.Size = New System.Drawing.Size(32, 32)
		Me._imgGameField_106.Location = New System.Drawing.Point(288, 192)
		Me._imgGameField_106.Enabled = True
		Me._imgGameField_106.Cursor = System.Windows.Forms.Cursors.Default
		Me._imgGameField_106.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal
		Me._imgGameField_106.Visible = True
		Me._imgGameField_106.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._imgGameField_106.Name = "_imgGameField_106"
		Me._imgGameField_105.Size = New System.Drawing.Size(32, 32)
		Me._imgGameField_105.Location = New System.Drawing.Point(256, 192)
		Me._imgGameField_105.Enabled = True
		Me._imgGameField_105.Cursor = System.Windows.Forms.Cursors.Default
		Me._imgGameField_105.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal
		Me._imgGameField_105.Visible = True
		Me._imgGameField_105.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._imgGameField_105.Name = "_imgGameField_105"
		Me._imgGameField_104.Size = New System.Drawing.Size(32, 32)
		Me._imgGameField_104.Location = New System.Drawing.Point(224, 192)
		Me._imgGameField_104.Enabled = True
		Me._imgGameField_104.Cursor = System.Windows.Forms.Cursors.Default
		Me._imgGameField_104.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal
		Me._imgGameField_104.Visible = True
		Me._imgGameField_104.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._imgGameField_104.Name = "_imgGameField_104"
		Me._imgGameField_103.Size = New System.Drawing.Size(32, 32)
		Me._imgGameField_103.Location = New System.Drawing.Point(192, 192)
		Me._imgGameField_103.Enabled = True
		Me._imgGameField_103.Cursor = System.Windows.Forms.Cursors.Default
		Me._imgGameField_103.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal
		Me._imgGameField_103.Visible = True
		Me._imgGameField_103.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._imgGameField_103.Name = "_imgGameField_103"
		Me._imgGameField_102.Size = New System.Drawing.Size(32, 32)
		Me._imgGameField_102.Location = New System.Drawing.Point(160, 192)
		Me._imgGameField_102.Enabled = True
		Me._imgGameField_102.Cursor = System.Windows.Forms.Cursors.Default
		Me._imgGameField_102.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal
		Me._imgGameField_102.Visible = True
		Me._imgGameField_102.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._imgGameField_102.Name = "_imgGameField_102"
		Me._imgGameField_101.Size = New System.Drawing.Size(32, 32)
		Me._imgGameField_101.Location = New System.Drawing.Point(128, 192)
		Me._imgGameField_101.Enabled = True
		Me._imgGameField_101.Cursor = System.Windows.Forms.Cursors.Default
		Me._imgGameField_101.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal
		Me._imgGameField_101.Visible = True
		Me._imgGameField_101.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._imgGameField_101.Name = "_imgGameField_101"
		Me._imgGameField_2.Size = New System.Drawing.Size(32, 32)
		Me._imgGameField_2.Location = New System.Drawing.Point(32, 0)
		Me._imgGameField_2.Enabled = True
		Me._imgGameField_2.Cursor = System.Windows.Forms.Cursors.Default
		Me._imgGameField_2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal
		Me._imgGameField_2.Visible = True
		Me._imgGameField_2.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._imgGameField_2.Name = "_imgGameField_2"
		Me._imgGameField_1.Size = New System.Drawing.Size(32, 32)
		Me._imgGameField_1.Location = New System.Drawing.Point(0, 0)
		Me._imgGameField_1.Enabled = True
		Me._imgGameField_1.Cursor = System.Windows.Forms.Cursors.Default
		Me._imgGameField_1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal
		Me._imgGameField_1.Visible = True
		Me._imgGameField_1.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._imgGameField_1.Name = "_imgGameField_1"
		Me._imgGameField_3.Size = New System.Drawing.Size(32, 32)
		Me._imgGameField_3.Location = New System.Drawing.Point(64, 0)
		Me._imgGameField_3.Enabled = True
		Me._imgGameField_3.Cursor = System.Windows.Forms.Cursors.Default
		Me._imgGameField_3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal
		Me._imgGameField_3.Visible = True
		Me._imgGameField_3.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._imgGameField_3.Name = "_imgGameField_3"
		Me._imgGameField_4.Size = New System.Drawing.Size(32, 32)
		Me._imgGameField_4.Location = New System.Drawing.Point(96, 0)
		Me._imgGameField_4.Enabled = True
		Me._imgGameField_4.Cursor = System.Windows.Forms.Cursors.Default
		Me._imgGameField_4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal
		Me._imgGameField_4.Visible = True
		Me._imgGameField_4.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._imgGameField_4.Name = "_imgGameField_4"
		Me._imgGameField_5.Size = New System.Drawing.Size(32, 32)
		Me._imgGameField_5.Location = New System.Drawing.Point(128, 0)
		Me._imgGameField_5.Enabled = True
		Me._imgGameField_5.Cursor = System.Windows.Forms.Cursors.Default
		Me._imgGameField_5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal
		Me._imgGameField_5.Visible = True
		Me._imgGameField_5.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._imgGameField_5.Name = "_imgGameField_5"
		Me._imgGameField_6.Size = New System.Drawing.Size(32, 32)
		Me._imgGameField_6.Location = New System.Drawing.Point(160, 0)
		Me._imgGameField_6.Enabled = True
		Me._imgGameField_6.Cursor = System.Windows.Forms.Cursors.Default
		Me._imgGameField_6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal
		Me._imgGameField_6.Visible = True
		Me._imgGameField_6.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._imgGameField_6.Name = "_imgGameField_6"
		Me._imgGameField_7.Size = New System.Drawing.Size(32, 32)
		Me._imgGameField_7.Location = New System.Drawing.Point(192, 0)
		Me._imgGameField_7.Enabled = True
		Me._imgGameField_7.Cursor = System.Windows.Forms.Cursors.Default
		Me._imgGameField_7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal
		Me._imgGameField_7.Visible = True
		Me._imgGameField_7.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._imgGameField_7.Name = "_imgGameField_7"
		Me._imgGameField_8.Size = New System.Drawing.Size(32, 32)
		Me._imgGameField_8.Location = New System.Drawing.Point(224, 0)
		Me._imgGameField_8.Enabled = True
		Me._imgGameField_8.Cursor = System.Windows.Forms.Cursors.Default
		Me._imgGameField_8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal
		Me._imgGameField_8.Visible = True
		Me._imgGameField_8.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._imgGameField_8.Name = "_imgGameField_8"
		Me._imgGameField_9.Size = New System.Drawing.Size(32, 32)
		Me._imgGameField_9.Location = New System.Drawing.Point(256, 0)
		Me._imgGameField_9.Enabled = True
		Me._imgGameField_9.Cursor = System.Windows.Forms.Cursors.Default
		Me._imgGameField_9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal
		Me._imgGameField_9.Visible = True
		Me._imgGameField_9.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._imgGameField_9.Name = "_imgGameField_9"
		Me._imgGameField_10.Size = New System.Drawing.Size(32, 32)
		Me._imgGameField_10.Location = New System.Drawing.Point(288, 0)
		Me._imgGameField_10.Enabled = True
		Me._imgGameField_10.Cursor = System.Windows.Forms.Cursors.Default
		Me._imgGameField_10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal
		Me._imgGameField_10.Visible = True
		Me._imgGameField_10.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._imgGameField_10.Name = "_imgGameField_10"
		Me._imgGameField_12.Size = New System.Drawing.Size(32, 32)
		Me._imgGameField_12.Location = New System.Drawing.Point(352, 0)
		Me._imgGameField_12.Enabled = True
		Me._imgGameField_12.Cursor = System.Windows.Forms.Cursors.Default
		Me._imgGameField_12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal
		Me._imgGameField_12.Visible = True
		Me._imgGameField_12.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._imgGameField_12.Name = "_imgGameField_12"
		Me._imgGameField_11.Size = New System.Drawing.Size(32, 32)
		Me._imgGameField_11.Location = New System.Drawing.Point(320, 0)
		Me._imgGameField_11.Enabled = True
		Me._imgGameField_11.Cursor = System.Windows.Forms.Cursors.Default
		Me._imgGameField_11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal
		Me._imgGameField_11.Visible = True
		Me._imgGameField_11.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._imgGameField_11.Name = "_imgGameField_11"
		Me._imgGameField_13.Size = New System.Drawing.Size(32, 32)
		Me._imgGameField_13.Location = New System.Drawing.Point(384, 0)
		Me._imgGameField_13.Enabled = True
		Me._imgGameField_13.Cursor = System.Windows.Forms.Cursors.Default
		Me._imgGameField_13.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal
		Me._imgGameField_13.Visible = True
		Me._imgGameField_13.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._imgGameField_13.Name = "_imgGameField_13"
		Me._imgGameField_14.Size = New System.Drawing.Size(32, 32)
		Me._imgGameField_14.Location = New System.Drawing.Point(416, 0)
		Me._imgGameField_14.Enabled = True
		Me._imgGameField_14.Cursor = System.Windows.Forms.Cursors.Default
		Me._imgGameField_14.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal
		Me._imgGameField_14.Visible = True
		Me._imgGameField_14.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._imgGameField_14.Name = "_imgGameField_14"
		Me._imgGameField_15.Size = New System.Drawing.Size(32, 32)
		Me._imgGameField_15.Location = New System.Drawing.Point(448, 0)
		Me._imgGameField_15.Enabled = True
		Me._imgGameField_15.Cursor = System.Windows.Forms.Cursors.Default
		Me._imgGameField_15.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal
		Me._imgGameField_15.Visible = True
		Me._imgGameField_15.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._imgGameField_15.Name = "_imgGameField_15"
		Me._imgGameField_16.Size = New System.Drawing.Size(32, 32)
		Me._imgGameField_16.Location = New System.Drawing.Point(480, 0)
		Me._imgGameField_16.Enabled = True
		Me._imgGameField_16.Cursor = System.Windows.Forms.Cursors.Default
		Me._imgGameField_16.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal
		Me._imgGameField_16.Visible = True
		Me._imgGameField_16.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._imgGameField_16.Name = "_imgGameField_16"
		Me._imgGameField_17.Size = New System.Drawing.Size(32, 32)
		Me._imgGameField_17.Location = New System.Drawing.Point(0, 32)
		Me._imgGameField_17.Enabled = True
		Me._imgGameField_17.Cursor = System.Windows.Forms.Cursors.Default
		Me._imgGameField_17.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal
		Me._imgGameField_17.Visible = True
		Me._imgGameField_17.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._imgGameField_17.Name = "_imgGameField_17"
		Me._imgGameField_18.Size = New System.Drawing.Size(32, 32)
		Me._imgGameField_18.Location = New System.Drawing.Point(32, 32)
		Me._imgGameField_18.Enabled = True
		Me._imgGameField_18.Cursor = System.Windows.Forms.Cursors.Default
		Me._imgGameField_18.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal
		Me._imgGameField_18.Visible = True
		Me._imgGameField_18.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._imgGameField_18.Name = "_imgGameField_18"
		Me._imgGameField_19.Size = New System.Drawing.Size(32, 32)
		Me._imgGameField_19.Location = New System.Drawing.Point(64, 32)
		Me._imgGameField_19.Enabled = True
		Me._imgGameField_19.Cursor = System.Windows.Forms.Cursors.Default
		Me._imgGameField_19.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal
		Me._imgGameField_19.Visible = True
		Me._imgGameField_19.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._imgGameField_19.Name = "_imgGameField_19"
		Me._imgGameField_20.Size = New System.Drawing.Size(32, 32)
		Me._imgGameField_20.Location = New System.Drawing.Point(96, 32)
		Me._imgGameField_20.Enabled = True
		Me._imgGameField_20.Cursor = System.Windows.Forms.Cursors.Default
		Me._imgGameField_20.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal
		Me._imgGameField_20.Visible = True
		Me._imgGameField_20.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._imgGameField_20.Name = "_imgGameField_20"
		Me._imgGameField_22.Size = New System.Drawing.Size(32, 32)
		Me._imgGameField_22.Location = New System.Drawing.Point(160, 32)
		Me._imgGameField_22.Enabled = True
		Me._imgGameField_22.Cursor = System.Windows.Forms.Cursors.Default
		Me._imgGameField_22.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal
		Me._imgGameField_22.Visible = True
		Me._imgGameField_22.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._imgGameField_22.Name = "_imgGameField_22"
		Me._imgGameField_21.Size = New System.Drawing.Size(32, 32)
		Me._imgGameField_21.Location = New System.Drawing.Point(128, 32)
		Me._imgGameField_21.Enabled = True
		Me._imgGameField_21.Cursor = System.Windows.Forms.Cursors.Default
		Me._imgGameField_21.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal
		Me._imgGameField_21.Visible = True
		Me._imgGameField_21.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._imgGameField_21.Name = "_imgGameField_21"
		Me._imgGameField_23.Size = New System.Drawing.Size(32, 32)
		Me._imgGameField_23.Location = New System.Drawing.Point(192, 32)
		Me._imgGameField_23.Enabled = True
		Me._imgGameField_23.Cursor = System.Windows.Forms.Cursors.Default
		Me._imgGameField_23.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal
		Me._imgGameField_23.Visible = True
		Me._imgGameField_23.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._imgGameField_23.Name = "_imgGameField_23"
		Me._imgGameField_24.Size = New System.Drawing.Size(32, 32)
		Me._imgGameField_24.Location = New System.Drawing.Point(224, 32)
		Me._imgGameField_24.Enabled = True
		Me._imgGameField_24.Cursor = System.Windows.Forms.Cursors.Default
		Me._imgGameField_24.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal
		Me._imgGameField_24.Visible = True
		Me._imgGameField_24.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._imgGameField_24.Name = "_imgGameField_24"
		Me._imgGameField_25.Size = New System.Drawing.Size(32, 32)
		Me._imgGameField_25.Location = New System.Drawing.Point(256, 32)
		Me._imgGameField_25.Enabled = True
		Me._imgGameField_25.Cursor = System.Windows.Forms.Cursors.Default
		Me._imgGameField_25.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal
		Me._imgGameField_25.Visible = True
		Me._imgGameField_25.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._imgGameField_25.Name = "_imgGameField_25"
		Me._imgGameField_26.Size = New System.Drawing.Size(32, 32)
		Me._imgGameField_26.Location = New System.Drawing.Point(288, 32)
		Me._imgGameField_26.Enabled = True
		Me._imgGameField_26.Cursor = System.Windows.Forms.Cursors.Default
		Me._imgGameField_26.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal
		Me._imgGameField_26.Visible = True
		Me._imgGameField_26.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._imgGameField_26.Name = "_imgGameField_26"
		Me._imgGameField_27.Size = New System.Drawing.Size(32, 32)
		Me._imgGameField_27.Location = New System.Drawing.Point(320, 32)
		Me._imgGameField_27.Enabled = True
		Me._imgGameField_27.Cursor = System.Windows.Forms.Cursors.Default
		Me._imgGameField_27.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal
		Me._imgGameField_27.Visible = True
		Me._imgGameField_27.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._imgGameField_27.Name = "_imgGameField_27"
		Me._imgGameField_28.Size = New System.Drawing.Size(32, 32)
		Me._imgGameField_28.Location = New System.Drawing.Point(352, 32)
		Me._imgGameField_28.Enabled = True
		Me._imgGameField_28.Cursor = System.Windows.Forms.Cursors.Default
		Me._imgGameField_28.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal
		Me._imgGameField_28.Visible = True
		Me._imgGameField_28.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._imgGameField_28.Name = "_imgGameField_28"
		Me._imgGameField_29.Size = New System.Drawing.Size(32, 32)
		Me._imgGameField_29.Location = New System.Drawing.Point(384, 32)
		Me._imgGameField_29.Enabled = True
		Me._imgGameField_29.Cursor = System.Windows.Forms.Cursors.Default
		Me._imgGameField_29.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal
		Me._imgGameField_29.Visible = True
		Me._imgGameField_29.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._imgGameField_29.Name = "_imgGameField_29"
		Me._imgGameField_30.Size = New System.Drawing.Size(32, 32)
		Me._imgGameField_30.Location = New System.Drawing.Point(416, 32)
		Me._imgGameField_30.Enabled = True
		Me._imgGameField_30.Cursor = System.Windows.Forms.Cursors.Default
		Me._imgGameField_30.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal
		Me._imgGameField_30.Visible = True
		Me._imgGameField_30.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._imgGameField_30.Name = "_imgGameField_30"
		Me._imgGameField_32.Size = New System.Drawing.Size(32, 32)
		Me._imgGameField_32.Location = New System.Drawing.Point(480, 32)
		Me._imgGameField_32.Enabled = True
		Me._imgGameField_32.Cursor = System.Windows.Forms.Cursors.Default
		Me._imgGameField_32.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal
		Me._imgGameField_32.Visible = True
		Me._imgGameField_32.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._imgGameField_32.Name = "_imgGameField_32"
		Me._imgGameField_31.Size = New System.Drawing.Size(32, 32)
		Me._imgGameField_31.Location = New System.Drawing.Point(448, 32)
		Me._imgGameField_31.Enabled = True
		Me._imgGameField_31.Cursor = System.Windows.Forms.Cursors.Default
		Me._imgGameField_31.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal
		Me._imgGameField_31.Visible = True
		Me._imgGameField_31.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._imgGameField_31.Name = "_imgGameField_31"
		Me._imgGameField_33.Size = New System.Drawing.Size(32, 32)
		Me._imgGameField_33.Location = New System.Drawing.Point(0, 64)
		Me._imgGameField_33.Enabled = True
		Me._imgGameField_33.Cursor = System.Windows.Forms.Cursors.Default
		Me._imgGameField_33.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal
		Me._imgGameField_33.Visible = True
		Me._imgGameField_33.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._imgGameField_33.Name = "_imgGameField_33"
		Me._imgGameField_34.Size = New System.Drawing.Size(32, 32)
		Me._imgGameField_34.Location = New System.Drawing.Point(32, 64)
		Me._imgGameField_34.Enabled = True
		Me._imgGameField_34.Cursor = System.Windows.Forms.Cursors.Default
		Me._imgGameField_34.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal
		Me._imgGameField_34.Visible = True
		Me._imgGameField_34.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._imgGameField_34.Name = "_imgGameField_34"
		Me._imgGameField_35.Size = New System.Drawing.Size(32, 32)
		Me._imgGameField_35.Location = New System.Drawing.Point(64, 64)
		Me._imgGameField_35.Enabled = True
		Me._imgGameField_35.Cursor = System.Windows.Forms.Cursors.Default
		Me._imgGameField_35.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal
		Me._imgGameField_35.Visible = True
		Me._imgGameField_35.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._imgGameField_35.Name = "_imgGameField_35"
		Me._imgGameField_36.Size = New System.Drawing.Size(32, 32)
		Me._imgGameField_36.Location = New System.Drawing.Point(96, 64)
		Me._imgGameField_36.Enabled = True
		Me._imgGameField_36.Cursor = System.Windows.Forms.Cursors.Default
		Me._imgGameField_36.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal
		Me._imgGameField_36.Visible = True
		Me._imgGameField_36.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._imgGameField_36.Name = "_imgGameField_36"
		Me._imgGameField_37.Size = New System.Drawing.Size(32, 32)
		Me._imgGameField_37.Location = New System.Drawing.Point(128, 64)
		Me._imgGameField_37.Enabled = True
		Me._imgGameField_37.Cursor = System.Windows.Forms.Cursors.Default
		Me._imgGameField_37.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal
		Me._imgGameField_37.Visible = True
		Me._imgGameField_37.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._imgGameField_37.Name = "_imgGameField_37"
		Me._imgGameField_38.Size = New System.Drawing.Size(32, 32)
		Me._imgGameField_38.Location = New System.Drawing.Point(160, 64)
		Me._imgGameField_38.Enabled = True
		Me._imgGameField_38.Cursor = System.Windows.Forms.Cursors.Default
		Me._imgGameField_38.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal
		Me._imgGameField_38.Visible = True
		Me._imgGameField_38.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._imgGameField_38.Name = "_imgGameField_38"
		Me._imgGameField_39.Size = New System.Drawing.Size(32, 32)
		Me._imgGameField_39.Location = New System.Drawing.Point(192, 64)
		Me._imgGameField_39.Enabled = True
		Me._imgGameField_39.Cursor = System.Windows.Forms.Cursors.Default
		Me._imgGameField_39.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal
		Me._imgGameField_39.Visible = True
		Me._imgGameField_39.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._imgGameField_39.Name = "_imgGameField_39"
		Me._imgGameField_40.Size = New System.Drawing.Size(32, 32)
		Me._imgGameField_40.Location = New System.Drawing.Point(224, 64)
		Me._imgGameField_40.Enabled = True
		Me._imgGameField_40.Cursor = System.Windows.Forms.Cursors.Default
		Me._imgGameField_40.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal
		Me._imgGameField_40.Visible = True
		Me._imgGameField_40.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._imgGameField_40.Name = "_imgGameField_40"
		Me._imgGameField_50.Size = New System.Drawing.Size(32, 32)
		Me._imgGameField_50.Location = New System.Drawing.Point(32, 96)
		Me._imgGameField_50.Enabled = True
		Me._imgGameField_50.Cursor = System.Windows.Forms.Cursors.Default
		Me._imgGameField_50.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal
		Me._imgGameField_50.Visible = True
		Me._imgGameField_50.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._imgGameField_50.Name = "_imgGameField_50"
		Me._imgGameField_49.Size = New System.Drawing.Size(32, 32)
		Me._imgGameField_49.Location = New System.Drawing.Point(0, 96)
		Me._imgGameField_49.Enabled = True
		Me._imgGameField_49.Cursor = System.Windows.Forms.Cursors.Default
		Me._imgGameField_49.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal
		Me._imgGameField_49.Visible = True
		Me._imgGameField_49.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._imgGameField_49.Name = "_imgGameField_49"
		Me._imgGameField_48.Size = New System.Drawing.Size(32, 32)
		Me._imgGameField_48.Location = New System.Drawing.Point(480, 64)
		Me._imgGameField_48.Enabled = True
		Me._imgGameField_48.Cursor = System.Windows.Forms.Cursors.Default
		Me._imgGameField_48.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal
		Me._imgGameField_48.Visible = True
		Me._imgGameField_48.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._imgGameField_48.Name = "_imgGameField_48"
		Me._imgGameField_47.Size = New System.Drawing.Size(32, 32)
		Me._imgGameField_47.Location = New System.Drawing.Point(448, 64)
		Me._imgGameField_47.Enabled = True
		Me._imgGameField_47.Cursor = System.Windows.Forms.Cursors.Default
		Me._imgGameField_47.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal
		Me._imgGameField_47.Visible = True
		Me._imgGameField_47.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._imgGameField_47.Name = "_imgGameField_47"
		Me._imgGameField_46.Size = New System.Drawing.Size(32, 32)
		Me._imgGameField_46.Location = New System.Drawing.Point(416, 64)
		Me._imgGameField_46.Enabled = True
		Me._imgGameField_46.Cursor = System.Windows.Forms.Cursors.Default
		Me._imgGameField_46.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal
		Me._imgGameField_46.Visible = True
		Me._imgGameField_46.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._imgGameField_46.Name = "_imgGameField_46"
		Me._imgGameField_45.Size = New System.Drawing.Size(32, 32)
		Me._imgGameField_45.Location = New System.Drawing.Point(384, 64)
		Me._imgGameField_45.Enabled = True
		Me._imgGameField_45.Cursor = System.Windows.Forms.Cursors.Default
		Me._imgGameField_45.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal
		Me._imgGameField_45.Visible = True
		Me._imgGameField_45.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._imgGameField_45.Name = "_imgGameField_45"
		Me._imgGameField_44.Size = New System.Drawing.Size(32, 32)
		Me._imgGameField_44.Location = New System.Drawing.Point(352, 64)
		Me._imgGameField_44.Enabled = True
		Me._imgGameField_44.Cursor = System.Windows.Forms.Cursors.Default
		Me._imgGameField_44.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal
		Me._imgGameField_44.Visible = True
		Me._imgGameField_44.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._imgGameField_44.Name = "_imgGameField_44"
		Me._imgGameField_43.Size = New System.Drawing.Size(32, 32)
		Me._imgGameField_43.Location = New System.Drawing.Point(320, 64)
		Me._imgGameField_43.Enabled = True
		Me._imgGameField_43.Cursor = System.Windows.Forms.Cursors.Default
		Me._imgGameField_43.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal
		Me._imgGameField_43.Visible = True
		Me._imgGameField_43.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._imgGameField_43.Name = "_imgGameField_43"
		Me._imgGameField_41.Size = New System.Drawing.Size(32, 32)
		Me._imgGameField_41.Location = New System.Drawing.Point(256, 64)
		Me._imgGameField_41.Enabled = True
		Me._imgGameField_41.Cursor = System.Windows.Forms.Cursors.Default
		Me._imgGameField_41.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal
		Me._imgGameField_41.Visible = True
		Me._imgGameField_41.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._imgGameField_41.Name = "_imgGameField_41"
		Me._imgGameField_42.Size = New System.Drawing.Size(32, 32)
		Me._imgGameField_42.Location = New System.Drawing.Point(288, 64)
		Me._imgGameField_42.Enabled = True
		Me._imgGameField_42.Cursor = System.Windows.Forms.Cursors.Default
		Me._imgGameField_42.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal
		Me._imgGameField_42.Visible = True
		Me._imgGameField_42.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._imgGameField_42.Name = "_imgGameField_42"
		Me._imgGameField_90.Size = New System.Drawing.Size(32, 32)
		Me._imgGameField_90.Location = New System.Drawing.Point(288, 160)
		Me._imgGameField_90.Enabled = True
		Me._imgGameField_90.Cursor = System.Windows.Forms.Cursors.Default
		Me._imgGameField_90.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal
		Me._imgGameField_90.Visible = True
		Me._imgGameField_90.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._imgGameField_90.Name = "_imgGameField_90"
		Me._imgGameField_89.Size = New System.Drawing.Size(32, 32)
		Me._imgGameField_89.Location = New System.Drawing.Point(256, 160)
		Me._imgGameField_89.Enabled = True
		Me._imgGameField_89.Cursor = System.Windows.Forms.Cursors.Default
		Me._imgGameField_89.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal
		Me._imgGameField_89.Visible = True
		Me._imgGameField_89.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._imgGameField_89.Name = "_imgGameField_89"
		Me._imgGameField_88.Size = New System.Drawing.Size(32, 32)
		Me._imgGameField_88.Location = New System.Drawing.Point(224, 160)
		Me._imgGameField_88.Enabled = True
		Me._imgGameField_88.Cursor = System.Windows.Forms.Cursors.Default
		Me._imgGameField_88.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal
		Me._imgGameField_88.Visible = True
		Me._imgGameField_88.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._imgGameField_88.Name = "_imgGameField_88"
		Me._imgGameField_87.Size = New System.Drawing.Size(32, 32)
		Me._imgGameField_87.Location = New System.Drawing.Point(192, 160)
		Me._imgGameField_87.Enabled = True
		Me._imgGameField_87.Cursor = System.Windows.Forms.Cursors.Default
		Me._imgGameField_87.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal
		Me._imgGameField_87.Visible = True
		Me._imgGameField_87.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._imgGameField_87.Name = "_imgGameField_87"
		Me._imgGameField_86.Size = New System.Drawing.Size(32, 32)
		Me._imgGameField_86.Location = New System.Drawing.Point(160, 160)
		Me._imgGameField_86.Enabled = True
		Me._imgGameField_86.Cursor = System.Windows.Forms.Cursors.Default
		Me._imgGameField_86.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal
		Me._imgGameField_86.Visible = True
		Me._imgGameField_86.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._imgGameField_86.Name = "_imgGameField_86"
		Me._imgGameField_85.Size = New System.Drawing.Size(32, 32)
		Me._imgGameField_85.Location = New System.Drawing.Point(128, 160)
		Me._imgGameField_85.Enabled = True
		Me._imgGameField_85.Cursor = System.Windows.Forms.Cursors.Default
		Me._imgGameField_85.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal
		Me._imgGameField_85.Visible = True
		Me._imgGameField_85.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._imgGameField_85.Name = "_imgGameField_85"
		Me._imgGameField_84.Size = New System.Drawing.Size(32, 32)
		Me._imgGameField_84.Location = New System.Drawing.Point(96, 160)
		Me._imgGameField_84.Enabled = True
		Me._imgGameField_84.Cursor = System.Windows.Forms.Cursors.Default
		Me._imgGameField_84.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal
		Me._imgGameField_84.Visible = True
		Me._imgGameField_84.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._imgGameField_84.Name = "_imgGameField_84"
		Me._imgGameField_83.Size = New System.Drawing.Size(32, 32)
		Me._imgGameField_83.Location = New System.Drawing.Point(64, 160)
		Me._imgGameField_83.Enabled = True
		Me._imgGameField_83.Cursor = System.Windows.Forms.Cursors.Default
		Me._imgGameField_83.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal
		Me._imgGameField_83.Visible = True
		Me._imgGameField_83.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._imgGameField_83.Name = "_imgGameField_83"
		Me._imgGameField_81.Size = New System.Drawing.Size(32, 32)
		Me._imgGameField_81.Location = New System.Drawing.Point(0, 160)
		Me._imgGameField_81.Enabled = True
		Me._imgGameField_81.Cursor = System.Windows.Forms.Cursors.Default
		Me._imgGameField_81.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal
		Me._imgGameField_81.Visible = True
		Me._imgGameField_81.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._imgGameField_81.Name = "_imgGameField_81"
		Me._imgGameField_82.Size = New System.Drawing.Size(32, 32)
		Me._imgGameField_82.Location = New System.Drawing.Point(32, 160)
		Me._imgGameField_82.Enabled = True
		Me._imgGameField_82.Cursor = System.Windows.Forms.Cursors.Default
		Me._imgGameField_82.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal
		Me._imgGameField_82.Visible = True
		Me._imgGameField_82.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._imgGameField_82.Name = "_imgGameField_82"
		Me._imgGameField_80.Size = New System.Drawing.Size(32, 32)
		Me._imgGameField_80.Location = New System.Drawing.Point(480, 128)
		Me._imgGameField_80.Enabled = True
		Me._imgGameField_80.Cursor = System.Windows.Forms.Cursors.Default
		Me._imgGameField_80.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal
		Me._imgGameField_80.Visible = True
		Me._imgGameField_80.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._imgGameField_80.Name = "_imgGameField_80"
		Me._imgGameField_79.Size = New System.Drawing.Size(32, 32)
		Me._imgGameField_79.Location = New System.Drawing.Point(448, 128)
		Me._imgGameField_79.Enabled = True
		Me._imgGameField_79.Cursor = System.Windows.Forms.Cursors.Default
		Me._imgGameField_79.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal
		Me._imgGameField_79.Visible = True
		Me._imgGameField_79.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._imgGameField_79.Name = "_imgGameField_79"
		Me._imgGameField_78.Size = New System.Drawing.Size(32, 32)
		Me._imgGameField_78.Location = New System.Drawing.Point(416, 128)
		Me._imgGameField_78.Enabled = True
		Me._imgGameField_78.Cursor = System.Windows.Forms.Cursors.Default
		Me._imgGameField_78.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal
		Me._imgGameField_78.Visible = True
		Me._imgGameField_78.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._imgGameField_78.Name = "_imgGameField_78"
		Me._imgGameField_77.Size = New System.Drawing.Size(32, 32)
		Me._imgGameField_77.Location = New System.Drawing.Point(384, 128)
		Me._imgGameField_77.Enabled = True
		Me._imgGameField_77.Cursor = System.Windows.Forms.Cursors.Default
		Me._imgGameField_77.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal
		Me._imgGameField_77.Visible = True
		Me._imgGameField_77.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._imgGameField_77.Name = "_imgGameField_77"
		Me._imgGameField_76.Size = New System.Drawing.Size(32, 32)
		Me._imgGameField_76.Location = New System.Drawing.Point(352, 128)
		Me._imgGameField_76.Enabled = True
		Me._imgGameField_76.Cursor = System.Windows.Forms.Cursors.Default
		Me._imgGameField_76.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal
		Me._imgGameField_76.Visible = True
		Me._imgGameField_76.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._imgGameField_76.Name = "_imgGameField_76"
		Me._imgGameField_75.Size = New System.Drawing.Size(32, 32)
		Me._imgGameField_75.Location = New System.Drawing.Point(320, 128)
		Me._imgGameField_75.Enabled = True
		Me._imgGameField_75.Cursor = System.Windows.Forms.Cursors.Default
		Me._imgGameField_75.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal
		Me._imgGameField_75.Visible = True
		Me._imgGameField_75.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._imgGameField_75.Name = "_imgGameField_75"
		Me._imgGameField_74.Size = New System.Drawing.Size(32, 32)
		Me._imgGameField_74.Location = New System.Drawing.Point(288, 128)
		Me._imgGameField_74.Enabled = True
		Me._imgGameField_74.Cursor = System.Windows.Forms.Cursors.Default
		Me._imgGameField_74.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal
		Me._imgGameField_74.Visible = True
		Me._imgGameField_74.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._imgGameField_74.Name = "_imgGameField_74"
		Me._imgGameField_73.Size = New System.Drawing.Size(32, 32)
		Me._imgGameField_73.Location = New System.Drawing.Point(256, 128)
		Me._imgGameField_73.Enabled = True
		Me._imgGameField_73.Cursor = System.Windows.Forms.Cursors.Default
		Me._imgGameField_73.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal
		Me._imgGameField_73.Visible = True
		Me._imgGameField_73.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._imgGameField_73.Name = "_imgGameField_73"
		Me._imgGameField_71.Size = New System.Drawing.Size(32, 32)
		Me._imgGameField_71.Location = New System.Drawing.Point(192, 128)
		Me._imgGameField_71.Enabled = True
		Me._imgGameField_71.Cursor = System.Windows.Forms.Cursors.Default
		Me._imgGameField_71.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal
		Me._imgGameField_71.Visible = True
		Me._imgGameField_71.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._imgGameField_71.Name = "_imgGameField_71"
		Me._imgGameField_72.Size = New System.Drawing.Size(32, 32)
		Me._imgGameField_72.Location = New System.Drawing.Point(224, 128)
		Me._imgGameField_72.Enabled = True
		Me._imgGameField_72.Cursor = System.Windows.Forms.Cursors.Default
		Me._imgGameField_72.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal
		Me._imgGameField_72.Visible = True
		Me._imgGameField_72.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._imgGameField_72.Name = "_imgGameField_72"
		Me._imgGameField_70.Size = New System.Drawing.Size(32, 32)
		Me._imgGameField_70.Location = New System.Drawing.Point(160, 128)
		Me._imgGameField_70.Enabled = True
		Me._imgGameField_70.Cursor = System.Windows.Forms.Cursors.Default
		Me._imgGameField_70.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal
		Me._imgGameField_70.Visible = True
		Me._imgGameField_70.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._imgGameField_70.Name = "_imgGameField_70"
		Me._imgGameField_69.Size = New System.Drawing.Size(32, 32)
		Me._imgGameField_69.Location = New System.Drawing.Point(128, 128)
		Me._imgGameField_69.Enabled = True
		Me._imgGameField_69.Cursor = System.Windows.Forms.Cursors.Default
		Me._imgGameField_69.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal
		Me._imgGameField_69.Visible = True
		Me._imgGameField_69.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._imgGameField_69.Name = "_imgGameField_69"
		Me._imgGameField_68.Size = New System.Drawing.Size(32, 32)
		Me._imgGameField_68.Location = New System.Drawing.Point(96, 128)
		Me._imgGameField_68.Enabled = True
		Me._imgGameField_68.Cursor = System.Windows.Forms.Cursors.Default
		Me._imgGameField_68.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal
		Me._imgGameField_68.Visible = True
		Me._imgGameField_68.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._imgGameField_68.Name = "_imgGameField_68"
		Me._imgGameField_67.Size = New System.Drawing.Size(32, 32)
		Me._imgGameField_67.Location = New System.Drawing.Point(64, 128)
		Me._imgGameField_67.Enabled = True
		Me._imgGameField_67.Cursor = System.Windows.Forms.Cursors.Default
		Me._imgGameField_67.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal
		Me._imgGameField_67.Visible = True
		Me._imgGameField_67.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._imgGameField_67.Name = "_imgGameField_67"
		Me._imgGameField_66.Size = New System.Drawing.Size(32, 32)
		Me._imgGameField_66.Location = New System.Drawing.Point(32, 128)
		Me._imgGameField_66.Enabled = True
		Me._imgGameField_66.Cursor = System.Windows.Forms.Cursors.Default
		Me._imgGameField_66.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal
		Me._imgGameField_66.Visible = True
		Me._imgGameField_66.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._imgGameField_66.Name = "_imgGameField_66"
		Me._imgGameField_65.Size = New System.Drawing.Size(32, 32)
		Me._imgGameField_65.Location = New System.Drawing.Point(0, 128)
		Me._imgGameField_65.Enabled = True
		Me._imgGameField_65.Cursor = System.Windows.Forms.Cursors.Default
		Me._imgGameField_65.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal
		Me._imgGameField_65.Visible = True
		Me._imgGameField_65.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._imgGameField_65.Name = "_imgGameField_65"
		Me._imgGameField_64.Size = New System.Drawing.Size(32, 32)
		Me._imgGameField_64.Location = New System.Drawing.Point(480, 96)
		Me._imgGameField_64.Enabled = True
		Me._imgGameField_64.Cursor = System.Windows.Forms.Cursors.Default
		Me._imgGameField_64.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal
		Me._imgGameField_64.Visible = True
		Me._imgGameField_64.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._imgGameField_64.Name = "_imgGameField_64"
		Me._imgGameField_63.Size = New System.Drawing.Size(32, 32)
		Me._imgGameField_63.Location = New System.Drawing.Point(448, 96)
		Me._imgGameField_63.Enabled = True
		Me._imgGameField_63.Cursor = System.Windows.Forms.Cursors.Default
		Me._imgGameField_63.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal
		Me._imgGameField_63.Visible = True
		Me._imgGameField_63.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._imgGameField_63.Name = "_imgGameField_63"
		Me._imgGameField_61.Size = New System.Drawing.Size(32, 32)
		Me._imgGameField_61.Location = New System.Drawing.Point(384, 96)
		Me._imgGameField_61.Enabled = True
		Me._imgGameField_61.Cursor = System.Windows.Forms.Cursors.Default
		Me._imgGameField_61.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal
		Me._imgGameField_61.Visible = True
		Me._imgGameField_61.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._imgGameField_61.Name = "_imgGameField_61"
		Me._imgGameField_62.Size = New System.Drawing.Size(32, 32)
		Me._imgGameField_62.Location = New System.Drawing.Point(416, 96)
		Me._imgGameField_62.Enabled = True
		Me._imgGameField_62.Cursor = System.Windows.Forms.Cursors.Default
		Me._imgGameField_62.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal
		Me._imgGameField_62.Visible = True
		Me._imgGameField_62.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._imgGameField_62.Name = "_imgGameField_62"
		Me._imgGameField_60.Size = New System.Drawing.Size(32, 32)
		Me._imgGameField_60.Location = New System.Drawing.Point(352, 96)
		Me._imgGameField_60.Enabled = True
		Me._imgGameField_60.Cursor = System.Windows.Forms.Cursors.Default
		Me._imgGameField_60.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal
		Me._imgGameField_60.Visible = True
		Me._imgGameField_60.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._imgGameField_60.Name = "_imgGameField_60"
		Me._imgGameField_59.Size = New System.Drawing.Size(32, 32)
		Me._imgGameField_59.Location = New System.Drawing.Point(320, 96)
		Me._imgGameField_59.Enabled = True
		Me._imgGameField_59.Cursor = System.Windows.Forms.Cursors.Default
		Me._imgGameField_59.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal
		Me._imgGameField_59.Visible = True
		Me._imgGameField_59.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._imgGameField_59.Name = "_imgGameField_59"
		Me._imgGameField_58.Size = New System.Drawing.Size(32, 32)
		Me._imgGameField_58.Location = New System.Drawing.Point(288, 96)
		Me._imgGameField_58.Enabled = True
		Me._imgGameField_58.Cursor = System.Windows.Forms.Cursors.Default
		Me._imgGameField_58.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal
		Me._imgGameField_58.Visible = True
		Me._imgGameField_58.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._imgGameField_58.Name = "_imgGameField_58"
		Me._imgGameField_57.Size = New System.Drawing.Size(32, 32)
		Me._imgGameField_57.Location = New System.Drawing.Point(256, 96)
		Me._imgGameField_57.Enabled = True
		Me._imgGameField_57.Cursor = System.Windows.Forms.Cursors.Default
		Me._imgGameField_57.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal
		Me._imgGameField_57.Visible = True
		Me._imgGameField_57.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._imgGameField_57.Name = "_imgGameField_57"
		Me._imgGameField_56.Size = New System.Drawing.Size(32, 32)
		Me._imgGameField_56.Location = New System.Drawing.Point(224, 96)
		Me._imgGameField_56.Enabled = True
		Me._imgGameField_56.Cursor = System.Windows.Forms.Cursors.Default
		Me._imgGameField_56.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal
		Me._imgGameField_56.Visible = True
		Me._imgGameField_56.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._imgGameField_56.Name = "_imgGameField_56"
		Me._imgGameField_55.Size = New System.Drawing.Size(32, 32)
		Me._imgGameField_55.Location = New System.Drawing.Point(192, 96)
		Me._imgGameField_55.Enabled = True
		Me._imgGameField_55.Cursor = System.Windows.Forms.Cursors.Default
		Me._imgGameField_55.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal
		Me._imgGameField_55.Visible = True
		Me._imgGameField_55.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._imgGameField_55.Name = "_imgGameField_55"
		Me._imgGameField_54.Size = New System.Drawing.Size(32, 32)
		Me._imgGameField_54.Location = New System.Drawing.Point(160, 96)
		Me._imgGameField_54.Enabled = True
		Me._imgGameField_54.Cursor = System.Windows.Forms.Cursors.Default
		Me._imgGameField_54.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal
		Me._imgGameField_54.Visible = True
		Me._imgGameField_54.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._imgGameField_54.Name = "_imgGameField_54"
		Me._imgGameField_53.Size = New System.Drawing.Size(32, 32)
		Me._imgGameField_53.Location = New System.Drawing.Point(128, 96)
		Me._imgGameField_53.Enabled = True
		Me._imgGameField_53.Cursor = System.Windows.Forms.Cursors.Default
		Me._imgGameField_53.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal
		Me._imgGameField_53.Visible = True
		Me._imgGameField_53.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._imgGameField_53.Name = "_imgGameField_53"
		Me._imgGameField_51.Size = New System.Drawing.Size(32, 32)
		Me._imgGameField_51.Location = New System.Drawing.Point(64, 96)
		Me._imgGameField_51.Enabled = True
		Me._imgGameField_51.Cursor = System.Windows.Forms.Cursors.Default
		Me._imgGameField_51.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal
		Me._imgGameField_51.Visible = True
		Me._imgGameField_51.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._imgGameField_51.Name = "_imgGameField_51"
		Me._imgGameField_52.Size = New System.Drawing.Size(32, 32)
		Me._imgGameField_52.Location = New System.Drawing.Point(96, 96)
		Me._imgGameField_52.Enabled = True
		Me._imgGameField_52.Cursor = System.Windows.Forms.Cursors.Default
		Me._imgGameField_52.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal
		Me._imgGameField_52.Visible = True
		Me._imgGameField_52.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._imgGameField_52.Name = "_imgGameField_52"
		Me._imgGameField_100.Size = New System.Drawing.Size(32, 32)
		Me._imgGameField_100.Location = New System.Drawing.Point(96, 192)
		Me._imgGameField_100.Enabled = True
		Me._imgGameField_100.Cursor = System.Windows.Forms.Cursors.Default
		Me._imgGameField_100.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal
		Me._imgGameField_100.Visible = True
		Me._imgGameField_100.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._imgGameField_100.Name = "_imgGameField_100"
		Me._imgGameField_99.Size = New System.Drawing.Size(32, 32)
		Me._imgGameField_99.Location = New System.Drawing.Point(64, 192)
		Me._imgGameField_99.Enabled = True
		Me._imgGameField_99.Cursor = System.Windows.Forms.Cursors.Default
		Me._imgGameField_99.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal
		Me._imgGameField_99.Visible = True
		Me._imgGameField_99.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._imgGameField_99.Name = "_imgGameField_99"
		Me._imgGameField_98.Size = New System.Drawing.Size(32, 32)
		Me._imgGameField_98.Location = New System.Drawing.Point(32, 192)
		Me._imgGameField_98.Enabled = True
		Me._imgGameField_98.Cursor = System.Windows.Forms.Cursors.Default
		Me._imgGameField_98.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal
		Me._imgGameField_98.Visible = True
		Me._imgGameField_98.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._imgGameField_98.Name = "_imgGameField_98"
		Me._imgGameField_97.Size = New System.Drawing.Size(32, 32)
		Me._imgGameField_97.Location = New System.Drawing.Point(0, 192)
		Me._imgGameField_97.Enabled = True
		Me._imgGameField_97.Cursor = System.Windows.Forms.Cursors.Default
		Me._imgGameField_97.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal
		Me._imgGameField_97.Visible = True
		Me._imgGameField_97.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._imgGameField_97.Name = "_imgGameField_97"
		Me._imgGameField_96.Size = New System.Drawing.Size(32, 32)
		Me._imgGameField_96.Location = New System.Drawing.Point(480, 160)
		Me._imgGameField_96.Enabled = True
		Me._imgGameField_96.Cursor = System.Windows.Forms.Cursors.Default
		Me._imgGameField_96.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal
		Me._imgGameField_96.Visible = True
		Me._imgGameField_96.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._imgGameField_96.Name = "_imgGameField_96"
		Me._imgGameField_95.Size = New System.Drawing.Size(32, 32)
		Me._imgGameField_95.Location = New System.Drawing.Point(448, 160)
		Me._imgGameField_95.Enabled = True
		Me._imgGameField_95.Cursor = System.Windows.Forms.Cursors.Default
		Me._imgGameField_95.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal
		Me._imgGameField_95.Visible = True
		Me._imgGameField_95.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._imgGameField_95.Name = "_imgGameField_95"
		Me._imgGameField_94.Size = New System.Drawing.Size(32, 32)
		Me._imgGameField_94.Location = New System.Drawing.Point(416, 160)
		Me._imgGameField_94.Enabled = True
		Me._imgGameField_94.Cursor = System.Windows.Forms.Cursors.Default
		Me._imgGameField_94.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal
		Me._imgGameField_94.Visible = True
		Me._imgGameField_94.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._imgGameField_94.Name = "_imgGameField_94"
		Me._imgGameField_93.Size = New System.Drawing.Size(32, 32)
		Me._imgGameField_93.Location = New System.Drawing.Point(384, 160)
		Me._imgGameField_93.Enabled = True
		Me._imgGameField_93.Cursor = System.Windows.Forms.Cursors.Default
		Me._imgGameField_93.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal
		Me._imgGameField_93.Visible = True
		Me._imgGameField_93.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._imgGameField_93.Name = "_imgGameField_93"
		Me._imgGameField_91.Size = New System.Drawing.Size(32, 32)
		Me._imgGameField_91.Location = New System.Drawing.Point(320, 160)
		Me._imgGameField_91.Enabled = True
		Me._imgGameField_91.Cursor = System.Windows.Forms.Cursors.Default
		Me._imgGameField_91.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal
		Me._imgGameField_91.Visible = True
		Me._imgGameField_91.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._imgGameField_91.Name = "_imgGameField_91"
		Me._imgGameField_92.Size = New System.Drawing.Size(32, 32)
		Me._imgGameField_92.Location = New System.Drawing.Point(352, 160)
		Me._imgGameField_92.Enabled = True
		Me._imgGameField_92.Cursor = System.Windows.Forms.Cursors.Default
		Me._imgGameField_92.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal
		Me._imgGameField_92.Visible = True
		Me._imgGameField_92.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._imgGameField_92.Name = "_imgGameField_92"
		Me.mnuGame.Text = "&Gra"
		Me.mnuGame.Checked = False
		Me.mnuGame.Enabled = True
		Me.mnuGame.Visible = True
		Me.mnuGame.MDIList = False
		Me.mnuGameNew.Text = "&Nowa gra..."
		Me.mnuGameNew.Checked = False
		Me.mnuGameNew.Enabled = True
		Me.mnuGameNew.Visible = True
		Me.mnuGameNew.MDIList = False
		Me.mnuGameWarp.Text = "Wybierz &etap..."
		Me.mnuGameWarp.Shortcut = System.Windows.Forms.Shortcut.F3
		Me.mnuGameWarp.Checked = False
		Me.mnuGameWarp.Enabled = True
		Me.mnuGameWarp.Visible = True
		Me.mnuGameWarp.MDIList = False
		Me.mnuGameSet.Text = "Wybierz &zestaw etapów"
		Me.mnuGameSet.Checked = False
		Me.mnuGameSet.Enabled = True
		Me.mnuGameSet.Visible = True
		Me.mnuGameSet.MDIList = False
		Me.mnuGameSetKlasyczne.Text = "&Klasyczne"
		Me.mnuGameSetKlasyczne.Checked = False
		Me.mnuGameSetKlasyczne.Enabled = True
		Me.mnuGameSetKlasyczne.Visible = True
		Me.mnuGameSetKlasyczne.MDIList = False
		Me.mnuGameSetSuperTrudneXS.Text = "&Super Trudne XS"
		Me.mnuGameSetSuperTrudneXS.Checked = False
		Me.mnuGameSetSuperTrudneXS.Enabled = True
		Me.mnuGameSetSuperTrudneXS.Visible = True
		Me.mnuGameSetSuperTrudneXS.MDIList = False
		Me.mnuGameOpen.Text = "&Otwórz plik etapu..."
		Me.mnuGameOpen.Shortcut = System.Windows.Forms.Shortcut.CtrlO
		Me.mnuGameOpen.Checked = False
		Me.mnuGameOpen.Enabled = True
		Me.mnuGameOpen.Visible = True
		Me.mnuGameOpen.MDIList = False
		Me.mnuGameBar0.Text = "-"
		Me.mnuGameBar0.Checked = False
		Me.mnuGameBar0.Enabled = True
		Me.mnuGameBar0.Visible = True
		Me.mnuGameBar0.MDIList = False
		Me.mnuGameExit.Text = "&Koniec"
		Me.mnuGameExit.Shortcut = System.Windows.Forms.Shortcut.CtrlQ
		Me.mnuGameExit.Checked = False
		Me.mnuGameExit.Enabled = True
		Me.mnuGameExit.Visible = True
		Me.mnuGameExit.MDIList = False
		Me.mnuView.Text = "&Widok"
		Me.mnuView.Checked = False
		Me.mnuView.Enabled = True
		Me.mnuView.Visible = True
		Me.mnuView.MDIList = False
		Me.mnuViewStatusbar.Text = "Pasek &stanu"
		Me.mnuViewStatusbar.Checked = True
		Me.mnuViewStatusbar.Enabled = True
		Me.mnuViewStatusbar.Visible = True
		Me.mnuViewStatusbar.MDIList = False
		Me.mnuViewBar0.Text = "-"
		Me.mnuViewBar0.Checked = False
		Me.mnuViewBar0.Enabled = True
		Me.mnuViewBar0.Visible = True
		Me.mnuViewBar0.MDIList = False
		Me.mnuViewRefresh.Text = "O&dœwie¿"
		Me.mnuViewRefresh.Shortcut = System.Windows.Forms.Shortcut.F9
		Me.mnuViewRefresh.Checked = False
		Me.mnuViewRefresh.Enabled = True
		Me.mnuViewRefresh.Visible = True
		Me.mnuViewRefresh.MDIList = False
		Me.mnuTools.Text = "&Narzêdzia"
		Me.mnuTools.Checked = False
		Me.mnuTools.Enabled = True
		Me.mnuTools.Visible = True
		Me.mnuTools.MDIList = False
		Me.mnuToolsUndo.Text = "&Cofnij"
		Me.mnuToolsUndo.Enabled = False
		Me.mnuToolsUndo.Shortcut = System.Windows.Forms.Shortcut.Del
		Me.mnuToolsUndo.Checked = False
		Me.mnuToolsUndo.Visible = True
		Me.mnuToolsUndo.MDIList = False
		Me.mnuToolsRestart.Text = "&Restartuj etap"
		Me.mnuToolsRestart.Shortcut = System.Windows.Forms.Shortcut.CtrlR
		Me.mnuToolsRestart.Checked = False
		Me.mnuToolsRestart.Enabled = True
		Me.mnuToolsRestart.Visible = True
		Me.mnuToolsRestart.MDIList = False
		Me.mnuToolsBar0.Text = "-"
		Me.mnuToolsBar0.Checked = False
		Me.mnuToolsBar0.Enabled = True
		Me.mnuToolsBar0.Visible = True
		Me.mnuToolsBar0.MDIList = False
		Me.mnuToolsOptions.Text = "&Opcje..."
		Me.mnuToolsOptions.Checked = False
		Me.mnuToolsOptions.Enabled = True
		Me.mnuToolsOptions.Visible = True
		Me.mnuToolsOptions.MDIList = False
		Me.mnuHelp.Text = "Pomo&c"
		Me.mnuHelp.Checked = False
		Me.mnuHelp.Enabled = True
		Me.mnuHelp.Visible = True
		Me.mnuHelp.MDIList = False
		Me.mnuHelpContents.Text = "&Tematy Pomocy..."
		Me.mnuHelpContents.Shortcut = System.Windows.Forms.Shortcut.F1
		Me.mnuHelpContents.Checked = False
		Me.mnuHelpContents.Enabled = True
		Me.mnuHelpContents.Visible = True
		Me.mnuHelpContents.MDIList = False
		Me.mnuHelpTips.Text = "&Porada dnia..."
		Me.mnuHelpTips.Checked = False
		Me.mnuHelpTips.Enabled = True
		Me.mnuHelpTips.Visible = True
		Me.mnuHelpTips.MDIList = False
		Me.mnuHelpWeb.Text = "Skrzynki w &sieci..."
		Me.mnuHelpWeb.Checked = False
		Me.mnuHelpWeb.Enabled = True
		Me.mnuHelpWeb.Visible = True
		Me.mnuHelpWeb.MDIList = False
		Me.mnuHelpBar0.Text = "-"
		Me.mnuHelpBar0.Checked = False
		Me.mnuHelpBar0.Enabled = True
		Me.mnuHelpBar0.Visible = True
		Me.mnuHelpBar0.MDIList = False
		Me.mnuHelpAbout.Text = "Skrzynki - &informacje..."
		Me.mnuHelpAbout.Checked = False
		Me.mnuHelpAbout.Enabled = True
		Me.mnuHelpAbout.Visible = True
		Me.mnuHelpAbout.MDIList = False
		Me.Controls.Add(picStatusBar)
		Me.Controls.Add(picTrayObject)
		Me.Controls.Add(_imgGameField_256)
		Me.Controls.Add(_imgGameField_255)
		Me.Controls.Add(_imgGameField_254)
		Me.Controls.Add(_imgGameField_253)
		Me.Controls.Add(_imgGameField_251)
		Me.Controls.Add(_imgGameField_250)
		Me.Controls.Add(_imgGameField_249)
		Me.Controls.Add(_imgGameField_248)
		Me.Controls.Add(_imgGameField_247)
		Me.Controls.Add(_imgGameField_246)
		Me.Controls.Add(_imgGameField_245)
		Me.Controls.Add(_imgGameField_244)
		Me.Controls.Add(_imgGameField_243)
		Me.Controls.Add(_imgGameField_242)
		Me.Controls.Add(_imgGameField_241)
		Me.Controls.Add(_imgGameField_240)
		Me.Controls.Add(_imgGameField_239)
		Me.Controls.Add(_imgGameField_238)
		Me.Controls.Add(_imgGameField_237)
		Me.Controls.Add(_imgGameField_236)
		Me.Controls.Add(_imgGameField_235)
		Me.Controls.Add(_imgGameField_252)
		Me.Controls.Add(_imgGameField_233)
		Me.Controls.Add(_imgGameField_232)
		Me.Controls.Add(_imgGameField_231)
		Me.Controls.Add(_imgGameField_230)
		Me.Controls.Add(_imgGameField_229)
		Me.Controls.Add(_imgGameField_228)
		Me.Controls.Add(_imgGameField_227)
		Me.Controls.Add(_imgGameField_226)
		Me.Controls.Add(_imgGameField_225)
		Me.Controls.Add(_imgGameField_224)
		Me.Controls.Add(_imgGameField_223)
		Me.Controls.Add(_imgGameField_222)
		Me.Controls.Add(_imgGameField_221)
		Me.Controls.Add(_imgGameField_220)
		Me.Controls.Add(_imgGameField_219)
		Me.Controls.Add(_imgGameField_218)
		Me.Controls.Add(_imgGameField_217)
		Me.Controls.Add(_imgGameField_234)
		Me.Controls.Add(_imgGameField_215)
		Me.Controls.Add(_imgGameField_214)
		Me.Controls.Add(_imgGameField_213)
		Me.Controls.Add(_imgGameField_212)
		Me.Controls.Add(_imgGameField_211)
		Me.Controls.Add(_imgGameField_210)
		Me.Controls.Add(_imgGameField_209)
		Me.Controls.Add(_imgGameField_208)
		Me.Controls.Add(_imgGameField_207)
		Me.Controls.Add(_imgGameField_206)
		Me.Controls.Add(_imgGameField_205)
		Me.Controls.Add(_imgGameField_204)
		Me.Controls.Add(_imgGameField_203)
		Me.Controls.Add(_imgGameField_202)
		Me.Controls.Add(_imgGameField_201)
		Me.Controls.Add(_imgGameField_200)
		Me.Controls.Add(_imgGameField_199)
		Me.Controls.Add(_imgGameField_216)
		Me.Controls.Add(_imgGameField_197)
		Me.Controls.Add(_imgGameField_196)
		Me.Controls.Add(_imgGameField_195)
		Me.Controls.Add(_imgGameField_194)
		Me.Controls.Add(_imgGameField_193)
		Me.Controls.Add(_imgGameField_192)
		Me.Controls.Add(_imgGameField_191)
		Me.Controls.Add(_imgGameField_190)
		Me.Controls.Add(_imgGameField_189)
		Me.Controls.Add(_imgGameField_188)
		Me.Controls.Add(_imgGameField_187)
		Me.Controls.Add(_imgGameField_186)
		Me.Controls.Add(_imgGameField_185)
		Me.Controls.Add(_imgGameField_184)
		Me.Controls.Add(_imgGameField_183)
		Me.Controls.Add(_imgGameField_182)
		Me.Controls.Add(_imgGameField_181)
		Me.Controls.Add(_imgGameField_198)
		Me.Controls.Add(_imgGameField_179)
		Me.Controls.Add(_imgGameField_178)
		Me.Controls.Add(_imgGameField_177)
		Me.Controls.Add(_imgGameField_176)
		Me.Controls.Add(_imgGameField_175)
		Me.Controls.Add(_imgGameField_174)
		Me.Controls.Add(_imgGameField_173)
		Me.Controls.Add(_imgGameField_172)
		Me.Controls.Add(_imgGameField_171)
		Me.Controls.Add(_imgGameField_170)
		Me.Controls.Add(_imgGameField_169)
		Me.Controls.Add(_imgGameField_168)
		Me.Controls.Add(_imgGameField_167)
		Me.Controls.Add(_imgGameField_166)
		Me.Controls.Add(_imgGameField_165)
		Me.Controls.Add(_imgGameField_164)
		Me.Controls.Add(_imgGameField_163)
		Me.Controls.Add(_imgGameField_162)
		Me.Controls.Add(_imgGameField_161)
		Me.Controls.Add(_imgGameField_180)
		Me.Controls.Add(_imgGameField_159)
		Me.Controls.Add(_imgGameField_158)
		Me.Controls.Add(_imgGameField_157)
		Me.Controls.Add(_imgGameField_156)
		Me.Controls.Add(_imgGameField_155)
		Me.Controls.Add(_imgGameField_154)
		Me.Controls.Add(_imgGameField_153)
		Me.Controls.Add(_imgGameField_152)
		Me.Controls.Add(_imgGameField_151)
		Me.Controls.Add(_imgGameField_150)
		Me.Controls.Add(_imgGameField_149)
		Me.Controls.Add(_imgGameField_148)
		Me.Controls.Add(_imgGameField_147)
		Me.Controls.Add(_imgGameField_146)
		Me.Controls.Add(_imgGameField_145)
		Me.Controls.Add(_imgGameField_144)
		Me.Controls.Add(_imgGameField_143)
		Me.Controls.Add(_imgGameField_142)
		Me.Controls.Add(_imgGameField_141)
		Me.Controls.Add(_imgGameField_160)
		Me.Controls.Add(_imgGameField_140)
		Me.Controls.Add(_imgGameField_139)
		Me.Controls.Add(_imgGameField_138)
		Me.Controls.Add(_imgGameField_137)
		Me.Controls.Add(_imgGameField_136)
		Me.Controls.Add(_imgGameField_135)
		Me.Controls.Add(_imgGameField_134)
		Me.Controls.Add(_imgGameField_133)
		Me.Controls.Add(_imgGameField_132)
		Me.Controls.Add(_imgGameField_131)
		Me.Controls.Add(_imgGameField_130)
		Me.Controls.Add(_imgGameField_129)
		Me.Controls.Add(_imgGameField_128)
		Me.Controls.Add(_imgGameField_127)
		Me.Controls.Add(_imgGameField_126)
		Me.Controls.Add(_imgGameField_125)
		Me.Controls.Add(_imgGameField_124)
		Me.Controls.Add(_imgGameField_123)
		Me.Controls.Add(_imgGameField_122)
		Me.Controls.Add(_imgGameField_121)
		Me.Controls.Add(_imgGameField_120)
		Me.Controls.Add(_imgGameField_119)
		Me.Controls.Add(_imgGameField_118)
		Me.Controls.Add(_imgGameField_117)
		Me.Controls.Add(_imgGameField_116)
		Me.Controls.Add(_imgGameField_115)
		Me.Controls.Add(_imgGameField_114)
		Me.Controls.Add(_imgGameField_113)
		Me.Controls.Add(_imgGameField_112)
		Me.Controls.Add(_imgGameField_111)
		Me.Controls.Add(_imgGameField_110)
		Me.Controls.Add(_imgGameField_109)
		Me.Controls.Add(_imgGameField_108)
		Me.Controls.Add(_imgGameField_107)
		Me.Controls.Add(_imgGameField_106)
		Me.Controls.Add(_imgGameField_105)
		Me.Controls.Add(_imgGameField_104)
		Me.Controls.Add(_imgGameField_103)
		Me.Controls.Add(_imgGameField_102)
		Me.Controls.Add(_imgGameField_101)
		Me.Controls.Add(_imgGameField_2)
		Me.Controls.Add(_imgGameField_1)
		Me.Controls.Add(_imgGameField_3)
		Me.Controls.Add(_imgGameField_4)
		Me.Controls.Add(_imgGameField_5)
		Me.Controls.Add(_imgGameField_6)
		Me.Controls.Add(_imgGameField_7)
		Me.Controls.Add(_imgGameField_8)
		Me.Controls.Add(_imgGameField_9)
		Me.Controls.Add(_imgGameField_10)
		Me.Controls.Add(_imgGameField_12)
		Me.Controls.Add(_imgGameField_11)
		Me.Controls.Add(_imgGameField_13)
		Me.Controls.Add(_imgGameField_14)
		Me.Controls.Add(_imgGameField_15)
		Me.Controls.Add(_imgGameField_16)
		Me.Controls.Add(_imgGameField_17)
		Me.Controls.Add(_imgGameField_18)
		Me.Controls.Add(_imgGameField_19)
		Me.Controls.Add(_imgGameField_20)
		Me.Controls.Add(_imgGameField_22)
		Me.Controls.Add(_imgGameField_21)
		Me.Controls.Add(_imgGameField_23)
		Me.Controls.Add(_imgGameField_24)
		Me.Controls.Add(_imgGameField_25)
		Me.Controls.Add(_imgGameField_26)
		Me.Controls.Add(_imgGameField_27)
		Me.Controls.Add(_imgGameField_28)
		Me.Controls.Add(_imgGameField_29)
		Me.Controls.Add(_imgGameField_30)
		Me.Controls.Add(_imgGameField_32)
		Me.Controls.Add(_imgGameField_31)
		Me.Controls.Add(_imgGameField_33)
		Me.Controls.Add(_imgGameField_34)
		Me.Controls.Add(_imgGameField_35)
		Me.Controls.Add(_imgGameField_36)
		Me.Controls.Add(_imgGameField_37)
		Me.Controls.Add(_imgGameField_38)
		Me.Controls.Add(_imgGameField_39)
		Me.Controls.Add(_imgGameField_40)
		Me.Controls.Add(_imgGameField_50)
		Me.Controls.Add(_imgGameField_49)
		Me.Controls.Add(_imgGameField_48)
		Me.Controls.Add(_imgGameField_47)
		Me.Controls.Add(_imgGameField_46)
		Me.Controls.Add(_imgGameField_45)
		Me.Controls.Add(_imgGameField_44)
		Me.Controls.Add(_imgGameField_43)
		Me.Controls.Add(_imgGameField_41)
		Me.Controls.Add(_imgGameField_42)
		Me.Controls.Add(_imgGameField_90)
		Me.Controls.Add(_imgGameField_89)
		Me.Controls.Add(_imgGameField_88)
		Me.Controls.Add(_imgGameField_87)
		Me.Controls.Add(_imgGameField_86)
		Me.Controls.Add(_imgGameField_85)
		Me.Controls.Add(_imgGameField_84)
		Me.Controls.Add(_imgGameField_83)
		Me.Controls.Add(_imgGameField_81)
		Me.Controls.Add(_imgGameField_82)
		Me.Controls.Add(_imgGameField_80)
		Me.Controls.Add(_imgGameField_79)
		Me.Controls.Add(_imgGameField_78)
		Me.Controls.Add(_imgGameField_77)
		Me.Controls.Add(_imgGameField_76)
		Me.Controls.Add(_imgGameField_75)
		Me.Controls.Add(_imgGameField_74)
		Me.Controls.Add(_imgGameField_73)
		Me.Controls.Add(_imgGameField_71)
		Me.Controls.Add(_imgGameField_72)
		Me.Controls.Add(_imgGameField_70)
		Me.Controls.Add(_imgGameField_69)
		Me.Controls.Add(_imgGameField_68)
		Me.Controls.Add(_imgGameField_67)
		Me.Controls.Add(_imgGameField_66)
		Me.Controls.Add(_imgGameField_65)
		Me.Controls.Add(_imgGameField_64)
		Me.Controls.Add(_imgGameField_63)
		Me.Controls.Add(_imgGameField_61)
		Me.Controls.Add(_imgGameField_62)
		Me.Controls.Add(_imgGameField_60)
		Me.Controls.Add(_imgGameField_59)
		Me.Controls.Add(_imgGameField_58)
		Me.Controls.Add(_imgGameField_57)
		Me.Controls.Add(_imgGameField_56)
		Me.Controls.Add(_imgGameField_55)
		Me.Controls.Add(_imgGameField_54)
		Me.Controls.Add(_imgGameField_53)
		Me.Controls.Add(_imgGameField_51)
		Me.Controls.Add(_imgGameField_52)
		Me.Controls.Add(_imgGameField_100)
		Me.Controls.Add(_imgGameField_99)
		Me.Controls.Add(_imgGameField_98)
		Me.Controls.Add(_imgGameField_97)
		Me.Controls.Add(_imgGameField_96)
		Me.Controls.Add(_imgGameField_95)
		Me.Controls.Add(_imgGameField_94)
		Me.Controls.Add(_imgGameField_93)
		Me.Controls.Add(_imgGameField_91)
		Me.Controls.Add(_imgGameField_92)
		Me.picStatusBar.Controls.Add(imgStatusImage)
		Me.picStatusBar.Controls.Add(lblPlayerName)
		Me.picStatusBar.Controls.Add(lblLevelNumber)
		Me.picStatusBar.Controls.Add(lblBoxes)
		Me.picStatusBar.Controls.Add(lblPushes)
		Me.picStatusBar.Controls.Add(lblMoves)
		Me.imgGameField.SetIndex(_imgGameField_256, CType(256, Short))
		Me.imgGameField.SetIndex(_imgGameField_255, CType(255, Short))
		Me.imgGameField.SetIndex(_imgGameField_254, CType(254, Short))
		Me.imgGameField.SetIndex(_imgGameField_253, CType(253, Short))
		Me.imgGameField.SetIndex(_imgGameField_251, CType(251, Short))
		Me.imgGameField.SetIndex(_imgGameField_250, CType(250, Short))
		Me.imgGameField.SetIndex(_imgGameField_249, CType(249, Short))
		Me.imgGameField.SetIndex(_imgGameField_248, CType(248, Short))
		Me.imgGameField.SetIndex(_imgGameField_247, CType(247, Short))
		Me.imgGameField.SetIndex(_imgGameField_246, CType(246, Short))
		Me.imgGameField.SetIndex(_imgGameField_245, CType(245, Short))
		Me.imgGameField.SetIndex(_imgGameField_244, CType(244, Short))
		Me.imgGameField.SetIndex(_imgGameField_243, CType(243, Short))
		Me.imgGameField.SetIndex(_imgGameField_242, CType(242, Short))
		Me.imgGameField.SetIndex(_imgGameField_241, CType(241, Short))
		Me.imgGameField.SetIndex(_imgGameField_240, CType(240, Short))
		Me.imgGameField.SetIndex(_imgGameField_239, CType(239, Short))
		Me.imgGameField.SetIndex(_imgGameField_238, CType(238, Short))
		Me.imgGameField.SetIndex(_imgGameField_237, CType(237, Short))
		Me.imgGameField.SetIndex(_imgGameField_236, CType(236, Short))
		Me.imgGameField.SetIndex(_imgGameField_235, CType(235, Short))
		Me.imgGameField.SetIndex(_imgGameField_252, CType(252, Short))
		Me.imgGameField.SetIndex(_imgGameField_233, CType(233, Short))
		Me.imgGameField.SetIndex(_imgGameField_232, CType(232, Short))
		Me.imgGameField.SetIndex(_imgGameField_231, CType(231, Short))
		Me.imgGameField.SetIndex(_imgGameField_230, CType(230, Short))
		Me.imgGameField.SetIndex(_imgGameField_229, CType(229, Short))
		Me.imgGameField.SetIndex(_imgGameField_228, CType(228, Short))
		Me.imgGameField.SetIndex(_imgGameField_227, CType(227, Short))
		Me.imgGameField.SetIndex(_imgGameField_226, CType(226, Short))
		Me.imgGameField.SetIndex(_imgGameField_225, CType(225, Short))
		Me.imgGameField.SetIndex(_imgGameField_224, CType(224, Short))
		Me.imgGameField.SetIndex(_imgGameField_223, CType(223, Short))
		Me.imgGameField.SetIndex(_imgGameField_222, CType(222, Short))
		Me.imgGameField.SetIndex(_imgGameField_221, CType(221, Short))
		Me.imgGameField.SetIndex(_imgGameField_220, CType(220, Short))
		Me.imgGameField.SetIndex(_imgGameField_219, CType(219, Short))
		Me.imgGameField.SetIndex(_imgGameField_218, CType(218, Short))
		Me.imgGameField.SetIndex(_imgGameField_217, CType(217, Short))
		Me.imgGameField.SetIndex(_imgGameField_234, CType(234, Short))
		Me.imgGameField.SetIndex(_imgGameField_215, CType(215, Short))
		Me.imgGameField.SetIndex(_imgGameField_214, CType(214, Short))
		Me.imgGameField.SetIndex(_imgGameField_213, CType(213, Short))
		Me.imgGameField.SetIndex(_imgGameField_212, CType(212, Short))
		Me.imgGameField.SetIndex(_imgGameField_211, CType(211, Short))
		Me.imgGameField.SetIndex(_imgGameField_210, CType(210, Short))
		Me.imgGameField.SetIndex(_imgGameField_209, CType(209, Short))
		Me.imgGameField.SetIndex(_imgGameField_208, CType(208, Short))
		Me.imgGameField.SetIndex(_imgGameField_207, CType(207, Short))
		Me.imgGameField.SetIndex(_imgGameField_206, CType(206, Short))
		Me.imgGameField.SetIndex(_imgGameField_205, CType(205, Short))
		Me.imgGameField.SetIndex(_imgGameField_204, CType(204, Short))
		Me.imgGameField.SetIndex(_imgGameField_203, CType(203, Short))
		Me.imgGameField.SetIndex(_imgGameField_202, CType(202, Short))
		Me.imgGameField.SetIndex(_imgGameField_201, CType(201, Short))
		Me.imgGameField.SetIndex(_imgGameField_200, CType(200, Short))
		Me.imgGameField.SetIndex(_imgGameField_199, CType(199, Short))
		Me.imgGameField.SetIndex(_imgGameField_216, CType(216, Short))
		Me.imgGameField.SetIndex(_imgGameField_197, CType(197, Short))
		Me.imgGameField.SetIndex(_imgGameField_196, CType(196, Short))
		Me.imgGameField.SetIndex(_imgGameField_195, CType(195, Short))
		Me.imgGameField.SetIndex(_imgGameField_194, CType(194, Short))
		Me.imgGameField.SetIndex(_imgGameField_193, CType(193, Short))
		Me.imgGameField.SetIndex(_imgGameField_192, CType(192, Short))
		Me.imgGameField.SetIndex(_imgGameField_191, CType(191, Short))
		Me.imgGameField.SetIndex(_imgGameField_190, CType(190, Short))
		Me.imgGameField.SetIndex(_imgGameField_189, CType(189, Short))
		Me.imgGameField.SetIndex(_imgGameField_188, CType(188, Short))
		Me.imgGameField.SetIndex(_imgGameField_187, CType(187, Short))
		Me.imgGameField.SetIndex(_imgGameField_186, CType(186, Short))
		Me.imgGameField.SetIndex(_imgGameField_185, CType(185, Short))
		Me.imgGameField.SetIndex(_imgGameField_184, CType(184, Short))
		Me.imgGameField.SetIndex(_imgGameField_183, CType(183, Short))
		Me.imgGameField.SetIndex(_imgGameField_182, CType(182, Short))
		Me.imgGameField.SetIndex(_imgGameField_181, CType(181, Short))
		Me.imgGameField.SetIndex(_imgGameField_198, CType(198, Short))
		Me.imgGameField.SetIndex(_imgGameField_179, CType(179, Short))
		Me.imgGameField.SetIndex(_imgGameField_178, CType(178, Short))
		Me.imgGameField.SetIndex(_imgGameField_177, CType(177, Short))
		Me.imgGameField.SetIndex(_imgGameField_176, CType(176, Short))
		Me.imgGameField.SetIndex(_imgGameField_175, CType(175, Short))
		Me.imgGameField.SetIndex(_imgGameField_174, CType(174, Short))
		Me.imgGameField.SetIndex(_imgGameField_173, CType(173, Short))
		Me.imgGameField.SetIndex(_imgGameField_172, CType(172, Short))
		Me.imgGameField.SetIndex(_imgGameField_171, CType(171, Short))
		Me.imgGameField.SetIndex(_imgGameField_170, CType(170, Short))
		Me.imgGameField.SetIndex(_imgGameField_169, CType(169, Short))
		Me.imgGameField.SetIndex(_imgGameField_168, CType(168, Short))
		Me.imgGameField.SetIndex(_imgGameField_167, CType(167, Short))
		Me.imgGameField.SetIndex(_imgGameField_166, CType(166, Short))
		Me.imgGameField.SetIndex(_imgGameField_165, CType(165, Short))
		Me.imgGameField.SetIndex(_imgGameField_164, CType(164, Short))
		Me.imgGameField.SetIndex(_imgGameField_163, CType(163, Short))
		Me.imgGameField.SetIndex(_imgGameField_162, CType(162, Short))
		Me.imgGameField.SetIndex(_imgGameField_161, CType(161, Short))
		Me.imgGameField.SetIndex(_imgGameField_180, CType(180, Short))
		Me.imgGameField.SetIndex(_imgGameField_159, CType(159, Short))
		Me.imgGameField.SetIndex(_imgGameField_158, CType(158, Short))
		Me.imgGameField.SetIndex(_imgGameField_157, CType(157, Short))
		Me.imgGameField.SetIndex(_imgGameField_156, CType(156, Short))
		Me.imgGameField.SetIndex(_imgGameField_155, CType(155, Short))
		Me.imgGameField.SetIndex(_imgGameField_154, CType(154, Short))
		Me.imgGameField.SetIndex(_imgGameField_153, CType(153, Short))
		Me.imgGameField.SetIndex(_imgGameField_152, CType(152, Short))
		Me.imgGameField.SetIndex(_imgGameField_151, CType(151, Short))
		Me.imgGameField.SetIndex(_imgGameField_150, CType(150, Short))
		Me.imgGameField.SetIndex(_imgGameField_149, CType(149, Short))
		Me.imgGameField.SetIndex(_imgGameField_148, CType(148, Short))
		Me.imgGameField.SetIndex(_imgGameField_147, CType(147, Short))
		Me.imgGameField.SetIndex(_imgGameField_146, CType(146, Short))
		Me.imgGameField.SetIndex(_imgGameField_145, CType(145, Short))
		Me.imgGameField.SetIndex(_imgGameField_144, CType(144, Short))
		Me.imgGameField.SetIndex(_imgGameField_143, CType(143, Short))
		Me.imgGameField.SetIndex(_imgGameField_142, CType(142, Short))
		Me.imgGameField.SetIndex(_imgGameField_141, CType(141, Short))
		Me.imgGameField.SetIndex(_imgGameField_160, CType(160, Short))
		Me.imgGameField.SetIndex(_imgGameField_140, CType(140, Short))
		Me.imgGameField.SetIndex(_imgGameField_139, CType(139, Short))
		Me.imgGameField.SetIndex(_imgGameField_138, CType(138, Short))
		Me.imgGameField.SetIndex(_imgGameField_137, CType(137, Short))
		Me.imgGameField.SetIndex(_imgGameField_136, CType(136, Short))
		Me.imgGameField.SetIndex(_imgGameField_135, CType(135, Short))
		Me.imgGameField.SetIndex(_imgGameField_134, CType(134, Short))
		Me.imgGameField.SetIndex(_imgGameField_133, CType(133, Short))
		Me.imgGameField.SetIndex(_imgGameField_132, CType(132, Short))
		Me.imgGameField.SetIndex(_imgGameField_131, CType(131, Short))
		Me.imgGameField.SetIndex(_imgGameField_130, CType(130, Short))
		Me.imgGameField.SetIndex(_imgGameField_129, CType(129, Short))
		Me.imgGameField.SetIndex(_imgGameField_128, CType(128, Short))
		Me.imgGameField.SetIndex(_imgGameField_127, CType(127, Short))
		Me.imgGameField.SetIndex(_imgGameField_126, CType(126, Short))
		Me.imgGameField.SetIndex(_imgGameField_125, CType(125, Short))
		Me.imgGameField.SetIndex(_imgGameField_124, CType(124, Short))
		Me.imgGameField.SetIndex(_imgGameField_123, CType(123, Short))
		Me.imgGameField.SetIndex(_imgGameField_122, CType(122, Short))
		Me.imgGameField.SetIndex(_imgGameField_121, CType(121, Short))
		Me.imgGameField.SetIndex(_imgGameField_120, CType(120, Short))
		Me.imgGameField.SetIndex(_imgGameField_119, CType(119, Short))
		Me.imgGameField.SetIndex(_imgGameField_118, CType(118, Short))
		Me.imgGameField.SetIndex(_imgGameField_117, CType(117, Short))
		Me.imgGameField.SetIndex(_imgGameField_116, CType(116, Short))
		Me.imgGameField.SetIndex(_imgGameField_115, CType(115, Short))
		Me.imgGameField.SetIndex(_imgGameField_114, CType(114, Short))
		Me.imgGameField.SetIndex(_imgGameField_113, CType(113, Short))
		Me.imgGameField.SetIndex(_imgGameField_112, CType(112, Short))
		Me.imgGameField.SetIndex(_imgGameField_111, CType(111, Short))
		Me.imgGameField.SetIndex(_imgGameField_110, CType(110, Short))
		Me.imgGameField.SetIndex(_imgGameField_109, CType(109, Short))
		Me.imgGameField.SetIndex(_imgGameField_108, CType(108, Short))
		Me.imgGameField.SetIndex(_imgGameField_107, CType(107, Short))
		Me.imgGameField.SetIndex(_imgGameField_106, CType(106, Short))
		Me.imgGameField.SetIndex(_imgGameField_105, CType(105, Short))
		Me.imgGameField.SetIndex(_imgGameField_104, CType(104, Short))
		Me.imgGameField.SetIndex(_imgGameField_103, CType(103, Short))
		Me.imgGameField.SetIndex(_imgGameField_102, CType(102, Short))
		Me.imgGameField.SetIndex(_imgGameField_101, CType(101, Short))
		Me.imgGameField.SetIndex(_imgGameField_2, CType(2, Short))
		Me.imgGameField.SetIndex(_imgGameField_1, CType(1, Short))
		Me.imgGameField.SetIndex(_imgGameField_3, CType(3, Short))
		Me.imgGameField.SetIndex(_imgGameField_4, CType(4, Short))
		Me.imgGameField.SetIndex(_imgGameField_5, CType(5, Short))
		Me.imgGameField.SetIndex(_imgGameField_6, CType(6, Short))
		Me.imgGameField.SetIndex(_imgGameField_7, CType(7, Short))
		Me.imgGameField.SetIndex(_imgGameField_8, CType(8, Short))
		Me.imgGameField.SetIndex(_imgGameField_9, CType(9, Short))
		Me.imgGameField.SetIndex(_imgGameField_10, CType(10, Short))
		Me.imgGameField.SetIndex(_imgGameField_12, CType(12, Short))
		Me.imgGameField.SetIndex(_imgGameField_11, CType(11, Short))
		Me.imgGameField.SetIndex(_imgGameField_13, CType(13, Short))
		Me.imgGameField.SetIndex(_imgGameField_14, CType(14, Short))
		Me.imgGameField.SetIndex(_imgGameField_15, CType(15, Short))
		Me.imgGameField.SetIndex(_imgGameField_16, CType(16, Short))
		Me.imgGameField.SetIndex(_imgGameField_17, CType(17, Short))
		Me.imgGameField.SetIndex(_imgGameField_18, CType(18, Short))
		Me.imgGameField.SetIndex(_imgGameField_19, CType(19, Short))
		Me.imgGameField.SetIndex(_imgGameField_20, CType(20, Short))
		Me.imgGameField.SetIndex(_imgGameField_22, CType(22, Short))
		Me.imgGameField.SetIndex(_imgGameField_21, CType(21, Short))
		Me.imgGameField.SetIndex(_imgGameField_23, CType(23, Short))
		Me.imgGameField.SetIndex(_imgGameField_24, CType(24, Short))
		Me.imgGameField.SetIndex(_imgGameField_25, CType(25, Short))
		Me.imgGameField.SetIndex(_imgGameField_26, CType(26, Short))
		Me.imgGameField.SetIndex(_imgGameField_27, CType(27, Short))
		Me.imgGameField.SetIndex(_imgGameField_28, CType(28, Short))
		Me.imgGameField.SetIndex(_imgGameField_29, CType(29, Short))
		Me.imgGameField.SetIndex(_imgGameField_30, CType(30, Short))
		Me.imgGameField.SetIndex(_imgGameField_32, CType(32, Short))
		Me.imgGameField.SetIndex(_imgGameField_31, CType(31, Short))
		Me.imgGameField.SetIndex(_imgGameField_33, CType(33, Short))
		Me.imgGameField.SetIndex(_imgGameField_34, CType(34, Short))
		Me.imgGameField.SetIndex(_imgGameField_35, CType(35, Short))
		Me.imgGameField.SetIndex(_imgGameField_36, CType(36, Short))
		Me.imgGameField.SetIndex(_imgGameField_37, CType(37, Short))
		Me.imgGameField.SetIndex(_imgGameField_38, CType(38, Short))
		Me.imgGameField.SetIndex(_imgGameField_39, CType(39, Short))
		Me.imgGameField.SetIndex(_imgGameField_40, CType(40, Short))
		Me.imgGameField.SetIndex(_imgGameField_50, CType(50, Short))
		Me.imgGameField.SetIndex(_imgGameField_49, CType(49, Short))
		Me.imgGameField.SetIndex(_imgGameField_48, CType(48, Short))
		Me.imgGameField.SetIndex(_imgGameField_47, CType(47, Short))
		Me.imgGameField.SetIndex(_imgGameField_46, CType(46, Short))
		Me.imgGameField.SetIndex(_imgGameField_45, CType(45, Short))
		Me.imgGameField.SetIndex(_imgGameField_44, CType(44, Short))
		Me.imgGameField.SetIndex(_imgGameField_43, CType(43, Short))
		Me.imgGameField.SetIndex(_imgGameField_41, CType(41, Short))
		Me.imgGameField.SetIndex(_imgGameField_42, CType(42, Short))
		Me.imgGameField.SetIndex(_imgGameField_90, CType(90, Short))
		Me.imgGameField.SetIndex(_imgGameField_89, CType(89, Short))
		Me.imgGameField.SetIndex(_imgGameField_88, CType(88, Short))
		Me.imgGameField.SetIndex(_imgGameField_87, CType(87, Short))
		Me.imgGameField.SetIndex(_imgGameField_86, CType(86, Short))
		Me.imgGameField.SetIndex(_imgGameField_85, CType(85, Short))
		Me.imgGameField.SetIndex(_imgGameField_84, CType(84, Short))
		Me.imgGameField.SetIndex(_imgGameField_83, CType(83, Short))
		Me.imgGameField.SetIndex(_imgGameField_81, CType(81, Short))
		Me.imgGameField.SetIndex(_imgGameField_82, CType(82, Short))
		Me.imgGameField.SetIndex(_imgGameField_80, CType(80, Short))
		Me.imgGameField.SetIndex(_imgGameField_79, CType(79, Short))
		Me.imgGameField.SetIndex(_imgGameField_78, CType(78, Short))
		Me.imgGameField.SetIndex(_imgGameField_77, CType(77, Short))
		Me.imgGameField.SetIndex(_imgGameField_76, CType(76, Short))
		Me.imgGameField.SetIndex(_imgGameField_75, CType(75, Short))
		Me.imgGameField.SetIndex(_imgGameField_74, CType(74, Short))
		Me.imgGameField.SetIndex(_imgGameField_73, CType(73, Short))
		Me.imgGameField.SetIndex(_imgGameField_71, CType(71, Short))
		Me.imgGameField.SetIndex(_imgGameField_72, CType(72, Short))
		Me.imgGameField.SetIndex(_imgGameField_70, CType(70, Short))
		Me.imgGameField.SetIndex(_imgGameField_69, CType(69, Short))
		Me.imgGameField.SetIndex(_imgGameField_68, CType(68, Short))
		Me.imgGameField.SetIndex(_imgGameField_67, CType(67, Short))
		Me.imgGameField.SetIndex(_imgGameField_66, CType(66, Short))
		Me.imgGameField.SetIndex(_imgGameField_65, CType(65, Short))
		Me.imgGameField.SetIndex(_imgGameField_64, CType(64, Short))
		Me.imgGameField.SetIndex(_imgGameField_63, CType(63, Short))
		Me.imgGameField.SetIndex(_imgGameField_61, CType(61, Short))
		Me.imgGameField.SetIndex(_imgGameField_62, CType(62, Short))
		Me.imgGameField.SetIndex(_imgGameField_60, CType(60, Short))
		Me.imgGameField.SetIndex(_imgGameField_59, CType(59, Short))
		Me.imgGameField.SetIndex(_imgGameField_58, CType(58, Short))
		Me.imgGameField.SetIndex(_imgGameField_57, CType(57, Short))
		Me.imgGameField.SetIndex(_imgGameField_56, CType(56, Short))
		Me.imgGameField.SetIndex(_imgGameField_55, CType(55, Short))
		Me.imgGameField.SetIndex(_imgGameField_54, CType(54, Short))
		Me.imgGameField.SetIndex(_imgGameField_53, CType(53, Short))
		Me.imgGameField.SetIndex(_imgGameField_51, CType(51, Short))
		Me.imgGameField.SetIndex(_imgGameField_52, CType(52, Short))
		Me.imgGameField.SetIndex(_imgGameField_100, CType(100, Short))
		Me.imgGameField.SetIndex(_imgGameField_99, CType(99, Short))
		Me.imgGameField.SetIndex(_imgGameField_98, CType(98, Short))
		Me.imgGameField.SetIndex(_imgGameField_97, CType(97, Short))
		Me.imgGameField.SetIndex(_imgGameField_96, CType(96, Short))
		Me.imgGameField.SetIndex(_imgGameField_95, CType(95, Short))
		Me.imgGameField.SetIndex(_imgGameField_94, CType(94, Short))
		Me.imgGameField.SetIndex(_imgGameField_93, CType(93, Short))
		Me.imgGameField.SetIndex(_imgGameField_91, CType(91, Short))
		Me.imgGameField.SetIndex(_imgGameField_92, CType(92, Short))
		CType(Me.imgGameField, System.ComponentModel.ISupportInitialize).EndInit()
		Me.mnuGame.Index = 0
		Me.mnuView.Index = 1
		Me.mnuTools.Index = 2
		Me.mnuHelp.Index = 3
		MainMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem(){Me.mnuGame, Me.mnuView, Me.mnuTools, Me.mnuHelp})
		Me.mnuGameNew.Index = 0
		Me.mnuGameWarp.Index = 1
		Me.mnuGameSet.Index = 2
		Me.mnuGameOpen.Index = 3
		Me.mnuGameBar0.Index = 4
		Me.mnuGameExit.Index = 5
		mnuGame.MenuItems.AddRange(New System.Windows.Forms.MenuItem(){Me.mnuGameNew, Me.mnuGameWarp, Me.mnuGameSet, Me.mnuGameOpen, Me.mnuGameBar0, Me.mnuGameExit})
		Me.mnuGameSetKlasyczne.Index = 0
		Me.mnuGameSetSuperTrudneXS.Index = 1
		mnuGameSet.MenuItems.AddRange(New System.Windows.Forms.MenuItem(){Me.mnuGameSetKlasyczne, Me.mnuGameSetSuperTrudneXS})
		Me.mnuViewStatusbar.Index = 0
		Me.mnuViewBar0.Index = 1
		Me.mnuViewRefresh.Index = 2
		mnuView.MenuItems.AddRange(New System.Windows.Forms.MenuItem(){Me.mnuViewStatusbar, Me.mnuViewBar0, Me.mnuViewRefresh})
		Me.mnuToolsUndo.Index = 0
		Me.mnuToolsRestart.Index = 1
		Me.mnuToolsBar0.Index = 2
		Me.mnuToolsOptions.Index = 3
		mnuTools.MenuItems.AddRange(New System.Windows.Forms.MenuItem(){Me.mnuToolsUndo, Me.mnuToolsRestart, Me.mnuToolsBar0, Me.mnuToolsOptions})
		Me.mnuHelpContents.Index = 0
		Me.mnuHelpTips.Index = 1
		Me.mnuHelpWeb.Index = 2
		Me.mnuHelpBar0.Index = 3
		Me.mnuHelpAbout.Index = 4
		mnuHelp.MenuItems.AddRange(New System.Windows.Forms.MenuItem(){Me.mnuHelpContents, Me.mnuHelpTips, Me.mnuHelpWeb, Me.mnuHelpBar0, Me.mnuHelpAbout})
		Me.Menu = MainMenu1
	End Sub
#End Region 
#Region "Upgrade Support "
	Private Shared m_vb6FormDefInstance As frmMain
	Private Shared m_InitializingDefInstance As Boolean
	Public Shared Property DefInstance() As frmMain
		Get
			If m_vb6FormDefInstance Is Nothing OrElse m_vb6FormDefInstance.IsDisposed Then
				m_InitializingDefInstance = True
				m_vb6FormDefInstance = New frmMain()
				m_InitializingDefInstance = False
			End If
			DefInstance = m_vb6FormDefInstance
		End Get
		Set
			m_vb6FormDefInstance = Value
		End Set
	End Property
#End Region 
	Dim TrayControlVar As Boolean
	Private Sub frmMain_KeyDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
		Dim KeyCode As Short = eventArgs.KeyCode
		Dim Shift As Short = eventArgs.KeyData \ &H10000
		If KeyCode = modMain.Lewo Or KeyCode = modMain.Prawo Or KeyCode = modMain.Gora Or KeyCode = modMain.Dol Then
			If PrzesunGracza(KeyCode) Then
				OdswiezPoleGryWokolGracza()
				Ruchy = Ruchy + 1
				
				PokazNaPaskuStanu(1, ZwrocCiag("StatusBar#0") & Ruchy)
				PokazNaPaskuStanu(2, ZwrocCiag("StatusBar#1") & Pchniecia)
				PokazNaPaskuStanu(3, ZwrocCiag("StatusBar#2") & Etap.SkrzynkiNaMiejscach & "/" & Etap.LiczbaSkrzynek)
				
				If WykonanoRuch = False Then
					WykonanoRuch = True
					frmMain.DefInstance.mnuToolsUndo.Enabled = True
				End If
				
				If Etap.SkrzynkiNaMiejscach = Etap.LiczbaSkrzynek Then NastepnyEtap()
			Else
				NieMozna()
			End If
		End If
	End Sub
	Private Sub frmMain_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
		RegWartosc = RegSciezka & "\Options\Background Color"
		'UPGRADE_WARNING: Couldn't resolve default property of object RegObj.Get. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
		frmMain.DefInstance.BackColor = System.Drawing.ColorTranslator.FromOle(Val(RegObj.Get(RegWartosc)))
		
		RegWartosc = RegSciezka & "\Options\Show Status Bar"
		'UPGRADE_WARNING: Couldn't resolve default property of object RegObj.Get. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
		If Val(RegObj.Get(RegWartosc)) = 1 Then
			frmMain.DefInstance.picStatusBar.Visible = True
		Else
			frmMain.DefInstance.picStatusBar.Visible = False
		End If
		
		If EtapSpozaZestawu = False Then
			RegWartosc = RegSciezka & "\Options\Begin From Arrived Level"
			'UPGRADE_WARNING: Couldn't resolve default property of object RegObj.Get. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
			If Val(RegObj.Get(RegWartosc)) = 1 Then
				NowaGra((NajdalszyEtap()))
			Else
				NowaGra((1))
			End If
		End If
		
		RegWartosc = RegSciezka & "\Options\Play Music"
		'UPGRADE_WARNING: Couldn't resolve default property of object RegObj.Get. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
		If Val(RegObj.Get(RegWartosc)) = 1 Then
			WczytajListeMIDI()
			OtworzMidi(WybierzLosowyUtwor)
			DlugoscPlikuMidi = DlugoscMidi
			tmrMIDITimer.Enabled = True
			GrajMidi()
		End If
		
		TrayControlVar = True
		Me.SetBounds(VB6.TwipsToPixelsX((VB6.PixelsToTwipsX(System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width) - VB6.PixelsToTwipsX(Me.Width)) / 2), VB6.TwipsToPixelsY((VB6.PixelsToTwipsY(System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height) - VB6.PixelsToTwipsY(Me.Height)) / 2), 0, 0, Windows.Forms.BoundsSpecified.X Or Windows.Forms.BoundsSpecified.Y)
	End Sub
	'UPGRADE_WARNING: Event frmMain.Resize may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup2075"'
	Private Sub frmMain_Resize(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Resize
		RegWartosc = RegSciezka & "\Options\Show in Tray"
		'UPGRADE_WARNING: Couldn't resolve default property of object RegObj.Get. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
		If frmMain.DefInstance.WindowState = System.Windows.Forms.FormWindowState.Minimized And (Val(RegObj.Get(RegWartosc)) = 1 Or Val(RegObj.Get(RegWartosc)) = 2) And TrayControlVar = True Then
			frmMain.DefInstance.Visible = False
			TrayControlVar = False
			TIcon.Show()
		End If
	End Sub
	'UPGRADE_WARNING: Form event frmMain.Unload has a new behavior. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup2065"'
	Private Sub frmMain_Closed(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Closed
		RegWartosc = RegSciezka & "\Options\Want Closing Authorization"
		'UPGRADE_WARNING: Couldn't resolve default property of object RegObj.Get. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
		If Val(RegObj.Get(RegWartosc)) = 1 Then
			'UPGRADE_ISSUE: Event parameter Cancel was not upgraded. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1057"'
			Cancel = 1
			
			'UPGRADE_WARNING: Couldn't resolve default property of object Temp3. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
			Temp3 = MsgBox(ZwrocCiag("General#2"), MsgBoxStyle.YesNo + MsgBoxStyle.Question + MsgBoxStyle.ApplicationModal + MsgBoxStyle.DefaultButton2, System.Reflection.Assembly.GetExecutingAssembly.GetName.Name)
			If Temp3 = MsgBoxResult.Yes Then
				'UPGRADE_ISSUE: Event parameter Cancel was not upgraded. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1057"'
				Cancel = 0
				ZakonczGre()
			End If
		Else : End
		End If
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
		frmMain.DefInstance.Close()
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
		With CDialog
			.VBGetOpenFileName(NazwaPliku,  ,  ,  ,  , True, ZwrocCiag("General#9"), 1, VB6.GetPath, ZwrocCiag("General#10"),  , Me.Handle.ToInt32)
			
			If WczytajEtap(NazwaPliku, FreeFile) Then
				OdswiezPoleGry()
				'UPGRADE_WARNING: Dir has a new behavior. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1041"'
				frmMain.DefInstance.Text = "Skrzynki - " & VB.Left(Dir(NazwaPliku), Len(Dir(NazwaPliku)) - 4)
				PokazNaPaskuStanu(3, "Skrzynki: " & Etap.SkrzynkiNaMiejscach & "/" & Etap.LiczbaSkrzynek)
				'UPGRADE_WARNING: Dir has a new behavior. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1041"'
				PokazNaPaskuStanu(4, VB.Left(Dir(NazwaPliku), Len(Dir(NazwaPliku)) - 4))
				EtapSpozaZestawu = True
				
				RegWartosc = RegSciezka & "\Options\Show Level Load Confirmation"
				'UPGRADE_WARNING: Couldn't resolve default property of object RegObj.Get. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
				If Val(RegObj.Get(RegWartosc)) = 1 Then
					'UPGRADE_WARNING: Couldn't resolve default property of object Temp3. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
					Temp3 = MsgBox(Replace(ZwrocCiag("General#6"), "<filename>", NazwaPliku), MsgBoxStyle.OKOnly + MsgBoxStyle.Information + MsgBoxStyle.ApplicationModal, System.Reflection.Assembly.GetExecutingAssembly.GetName.Name)
				End If
			End If
		End With
	End Sub
	Public Sub mnuGameSet_Popup(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuGameSet.Popup
		mnuGameSet_Click(eventSender, eventArgs)
	End Sub
	Public Sub mnuGameSet_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuGameSet.Click
		If DaneGracza.Zestaw = 1 Then
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
		'UPGRADE_WARNING: Couldn't resolve default property of object Temp1. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
		Temp1 = InputBox(ZwrocCiag("General#12"), System.Reflection.Assembly.GetExecutingAssembly.GetName.Name, CStr(NajdalszyEtap))
		
		'UPGRADE_WARNING: Couldn't resolve default property of object Temp1. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
		If Temp1 = "" Then Exit Sub
		
		If IsNumeric(Temp1) = False Then
			'UPGRADE_WARNING: Couldn't resolve default property of object Temp3. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
			Temp3 = MsgBox(ZwrocCiag("General#13"), MsgBoxStyle.OKOnly + MsgBoxStyle.Critical + MsgBoxStyle.ApplicationModal, System.Reflection.Assembly.GetExecutingAssembly.GetName.Name)
			Exit Sub
		End If
		
		'UPGRADE_WARNING: Couldn't resolve default property of object Temp1. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
		If (Val(Temp1) > Val(CStr(NajdalszyEtap))) And (Temp1 <= Val(CStr(UBound(Etapy, 1)))) Then
			'UPGRADE_WARNING: Couldn't resolve default property of object Temp3. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
			Temp3 = MsgBox(ZwrocCiag("General#14"), MsgBoxStyle.OKOnly + MsgBoxStyle.Critical + MsgBoxStyle.ApplicationModal, System.Reflection.Assembly.GetExecutingAssembly.GetName.Name)
			Exit Sub
		Else
			'UPGRADE_WARNING: Couldn't resolve default property of object Temp1. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
			If (Val(Temp1) > Val(CStr(UBound(Etapy, 1)))) Or Val(Temp1) <= 0 Then
				'UPGRADE_WARNING: Couldn't resolve default property of object Temp3. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
				Temp3 = MsgBox(ZwrocCiag("General#15"), MsgBoxStyle.OKOnly + MsgBoxStyle.Critical + MsgBoxStyle.ApplicationModal, System.Reflection.Assembly.GetExecutingAssembly.GetName.Name)
				Exit Sub
			End If
			
			'UPGRADE_WARNING: Couldn't resolve default property of object Temp1. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
			NumerEtapu = Val(Temp1)
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
			frmMain.DefInstance.Text = System.Reflection.Assembly.GetExecutingAssembly.GetName.Name & " - #" & NumerEtapu
			OdswiezPoleGry()
			EtapSpozaZestawu = False
		End If
	End Sub
	
	Public Sub mnuHelpAbout_Popup(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuHelpAbout.Popup
		mnuHelpAbout_Click(eventSender, eventArgs)
	End Sub
	Public Sub mnuHelpAbout_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuHelpAbout.Click
		PokazForme(frmAbout.DefInstance, VB6.FormShowConstants.Modal, frmMain.DefInstance)
	End Sub
	
	Public Sub mnuHelpContents_Popup(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuHelpContents.Popup
		mnuHelpContents_Click(eventSender, eventArgs)
	End Sub
	Public Sub mnuHelpContents_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuHelpContents.Click
		Dim Plik As String
		Dim HH As String
		On Error GoTo BladPomocy
		
		HH = KatalogWindows & "\hh.exe" & Chr(0)
		'UPGRADE_ISSUE: App property App.HelpFile was not upgraded. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup2069"'
		Plik = App.HelpFile & Chr(0)
		
		Temp5 = ShellExecute(frmMain.DefInstance.Handle.ToInt32, "open", HH, Plik, "", 3)
		Exit Sub
		
BladPomocy: 
		'UPGRADE_WARNING: Couldn't resolve default property of object Temp3. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
		Temp3 = MsgBox("B³¹d nr " & Err.Number & ":" & Chr(10) & Err.Description, MsgBoxStyle.OKOnly + MsgBoxStyle.Critical + MsgBoxStyle.ApplicationModal, System.Reflection.Assembly.GetExecutingAssembly.GetName.Name)
	End Sub
	Public Sub mnuHelpTips_Popup(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuHelpTips.Popup
		mnuHelpTips_Click(eventSender, eventArgs)
	End Sub
	Public Sub mnuHelpTips_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuHelpTips.Click
		RegWartosc = RegSciezka & "\Options\Show Tips at Startup"
		RegDaneInt = 1
		'UPGRADE_WARNING: Couldn't resolve default property of object RegObj.Set. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
		RegObj.Set(RegWartosc, RegDaneInt, RegFlush)
		
		PokazForme(frmTip.DefInstance)
	End Sub
	Public Sub mnuHelpWeb_Popup(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuHelpWeb.Popup
		mnuHelpWeb_Click(eventSender, eventArgs)
	End Sub
	Public Sub mnuHelpWeb_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuHelpWeb.Click
		Dim url As String
		url = "http://www.avc-soft.prv.pl/" & Chr(0)
		ShellExecute(Me.Handle.ToInt32, "open" & Chr(0), url, "", "", 3)
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
		PokazForme(frmOptions.DefInstance, VB6.FormShowConstants.Modal, frmMain.DefInstance)
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
		RegWartosc = RegSciezka & "\Options\Want Level Restarting Authorization"
		'UPGRADE_WARNING: Couldn't resolve default property of object RegObj.Get. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
		If Val(RegObj.Get(RegWartosc)) = 1 Then
			'UPGRADE_WARNING: Couldn't resolve default property of object Temp3. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
			Temp3 = MsgBox(ZwrocCiag("General#1"), MsgBoxStyle.YesNo + MsgBoxStyle.Question + MsgBoxStyle.ApplicationModal, System.Reflection.Assembly.GetExecutingAssembly.GetName.Name)
			If Temp3 = MsgBoxResult.Yes Then
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
		mnuView_Click(eventSender, eventArgs)
	End Sub
	Public Sub mnuView_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuView.Click
		RegWartosc = RegSciezka & "\Options\Show Status Bar"
		'UPGRADE_WARNING: Couldn't resolve default property of object RegObj.Get. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
		If Val(RegObj.Get(RegWartosc)) = 1 Then
			mnuViewStatusbar.Checked = True
		Else
			mnuViewStatusbar.Checked = False
		End If
	End Sub
	Public Sub mnuViewStatusbar_Popup(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuViewStatusbar.Popup
		mnuViewStatusbar_Click(eventSender, eventArgs)
	End Sub
	Public Sub mnuViewStatusbar_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuViewStatusbar.Click
		If mnuViewStatusbar.Checked Then
			mnuViewStatusbar.Checked = False
			picStatusBar.Visible = False
			
			RegWartosc = RegSciezka & "\Options\Show Status Bar"
			RegDaneInt = 0
			'UPGRADE_WARNING: Couldn't resolve default property of object RegObj.Set. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
			RegObj.Set(RegWartosc, RegDaneInt, RegFlush)
		Else
			mnuViewStatusbar.Checked = True
			picStatusBar.Visible = True
			
			RegWartosc = RegSciezka & "\Options\Show Status Bar"
			RegDaneInt = 1
			'UPGRADE_WARNING: Couldn't resolve default property of object RegObj.Set. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
			RegObj.Set(RegWartosc, RegDaneInt, RegFlush)
		End If
	End Sub
	Private Sub picTrayObject_MouseMove(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.MouseEventArgs) Handles picTrayObject.MouseMove
		Dim Button As Short = eventArgs.Button \ &H100000
		Dim Shift As Short = System.Windows.Forms.Control.ModifierKeys \ &H10000
		Dim x As Single = VB6.PixelsToTwipsX(eventArgs.X)
		Dim y As Single = VB6.PixelsToTwipsY(eventArgs.Y)
		Dim Msg As Integer
		Msg = x / VB6.TwipsPerPixelX
		
		Select Case Msg
			Case CTrayIcon.TI_EVENT.WM_LBUTTONDOWN
				If frmMain.DefInstance.Visible = False Then
					frmMain.DefInstance.Visible = True
					TrayControlVar = True
					frmMain.DefInstance.WindowState = System.Windows.Forms.FormWindowState.Normal
					
					RegWartosc = RegSciezka & "\Options\Show in Tray"
					'UPGRADE_WARNING: Couldn't resolve default property of object RegObj.Get. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
					If Val(RegObj.Get(RegWartosc)) <> 2 Then TIcon.Hide()
				End If
		End Select
	End Sub
	Private Sub tmrMIDITimer_Tick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles tmrMIDITimer.Tick
		RegWartosc = RegSciezka & "\Options\Play Music"
		'UPGRADE_WARNING: Couldn't resolve default property of object RegObj.Get. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
		If Val(RegObj.Get(RegWartosc)) = 0 Then
			tmrMIDITimer.Enabled = False
			ZatrzymajMidi()
			Exit Sub
		End If
		
		If PozycjaMidi = DlugoscPlikuMidi Then
			ZatrzymajMidi()
			ZamknijMidi()
			OtworzMidi(WybierzLosowyUtwor)
			DlugoscPlikuMidi = DlugoscMidi
			GrajMidi()
		End If
	End Sub
End Class