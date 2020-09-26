Option Strict Off
Option Explicit On
Friend Class CCommonDlg
	
	Public Enum EErrorCommonDialog
		eeBaseCommonDialog = 13450 ' CommonDialog
	End Enum
	
	Private Declare Function lstrlen Lib "kernel32"  Alias "lstrlenA"(ByVal lpString As String) As Integer
	Private Declare Function GlobalAlloc Lib "kernel32" (ByVal wFlags As Integer, ByVal dwBytes As Integer) As Integer
	Private Declare Function GlobalCompact Lib "kernel32" (ByVal dwMinFree As Integer) As Integer
	Private Declare Function GlobalFree Lib "kernel32" (ByVal hMem As Integer) As Integer
	Private Declare Function GlobalLock Lib "kernel32" (ByVal hMem As Integer) As Integer
	Private Declare Function GlobalReAlloc Lib "kernel32" (ByVal hMem As Integer, ByVal dwBytes As Integer, ByVal wFlags As Integer) As Integer
	Private Declare Function GlobalSize Lib "kernel32" (ByVal hMem As Integer) As Integer
	Private Declare Function GlobalUnlock Lib "kernel32" (ByVal hMem As Integer) As Integer
	'UPGRADE_ISSUE: Declaring a parameter 'As Any' is not supported. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1016"'
	'UPGRADE_ISSUE: Declaring a parameter 'As Any' is not supported. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1016"'
	Private Declare Sub CopyMemory Lib "kernel32"  Alias "RtlMoveMemory"(ByRef lpvDest As Any, ByRef lpvSource As Any, ByVal cbCopy As Integer)
	'UPGRADE_ISSUE: Declaring a parameter 'As Any' is not supported. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1016"'
	Private Declare Sub CopyMemoryStr Lib "kernel32"  Alias "RtlMoveMemory"(ByRef lpvDest As Any, ByVal lpvSource As String, ByVal cbCopy As Integer)
	
	Private Const MAX_PATH As Short = 260
	Private Const MAX_FILE As Short = 260
	
	Private Structure OPENFILENAME
		Dim lStructSize As Integer ' Filled with UDT size
		Dim hWndOwner As Integer ' Tied to Owner
		Dim hInstance As Integer ' Ignored (used only by templates)
		Dim lpstrFilter As String ' Tied to Filter
		Dim lpstrCustomFilter As String ' Ignored (exercise for reader)
		Dim nMaxCustFilter As Integer ' Ignored (exercise for reader)
		Dim nFilterIndex As Integer ' Tied to FilterIndex
		Dim lpstrFile As String ' Tied to FileName
		Dim nMaxFile As Integer ' Handled internally
		Dim lpstrFileTitle As String ' Tied to FileTitle
		Dim nMaxFileTitle As Integer ' Handled internally
		Dim lpstrInitialDir As String ' Tied to InitDir
		Dim lpstrTitle As String ' Tied to DlgTitle
		Dim flags As Integer ' Tied to Flags
		Dim nFileOffset As Short ' Ignored (exercise for reader)
		Dim nFileExtension As Short ' Ignored (exercise for reader)
		Dim lpstrDefExt As String ' Tied to DefaultExt
		Dim lCustData As Integer ' Ignored (needed for hooks)
		Dim lpfnHook As Integer ' Ignored (good luck with hooks)
		Dim lpTemplateName As Integer ' Ignored (good luck with templates)
	End Structure
	
	'UPGRADE_WARNING: Structure OPENFILENAME may require marshalling attributes to be passed as an argument in this Declare statement. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1050"'
	Private Declare Function GetOpenFileName Lib "COMDLG32"  Alias "GetOpenFileNameA"(ByRef file As OPENFILENAME) As Integer
	'UPGRADE_WARNING: Structure OPENFILENAME may require marshalling attributes to be passed as an argument in this Declare statement. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1050"'
	Private Declare Function GetSaveFileName Lib "COMDLG32"  Alias "GetSaveFileNameA"(ByRef file As OPENFILENAME) As Integer
	Private Declare Function GetFileTitle Lib "COMDLG32"  Alias "GetFileTitleA"(ByVal szFile As String, ByVal szTitle As String, ByVal cbBuf As Integer) As Integer
	
	Public Enum EOpenFile
		OFN_READONLY = &H1s
		OFN_OVERWRITEPROMPT = &H2s
		OFN_HIDEREADONLY = &H4s
		OFN_NOCHANGEDIR = &H8s
		OFN_SHOWHELP = &H10s
		OFN_ENABLEHOOK = &H20s
		OFN_ENABLETEMPLATE = &H40s
		OFN_ENABLETEMPLATEHANDLE = &H80s
		OFN_NOVALIDATE = &H100s
		OFN_ALLOWMULTISELECT = &H200s
		OFN_EXTENSIONDIFFERENT = &H400s
		OFN_PATHMUSTEXIST = &H800s
		OFN_FILEMUSTEXIST = &H1000s
		OFN_CREATEPROMPT = &H2000s
		OFN_SHAREAWARE = &H4000s
		OFN_NOREADONLYRETURN = &H8000
		OFN_NOTESTFILECREATE = &H10000
		OFN_NONETWORKBUTTON = &H20000
		OFN_NOLONGNAMES = &H40000
		OFN_EXPLORER = &H80000
		OFN_NODEREFERENCELINKS = &H100000
		OFN_LONGNAMES = &H200000
	End Enum
	
	Private Structure TCHOOSECOLOR
		Dim lStructSize As Integer
		Dim hWndOwner As Integer
		Dim hInstance As Integer
		Dim rgbResult As Integer
		Dim lpCustColors As Integer
		Dim flags As Integer
		Dim lCustData As Integer
		Dim lpfnHook As Integer
		Dim lpTemplateName As Integer
	End Structure
	
	'UPGRADE_WARNING: Structure TCHOOSECOLOR may require marshalling attributes to be passed as an argument in this Declare statement. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1050"'
	Private Declare Function ChooseColor Lib "COMDLG32.DLL"  Alias "ChooseColorA"(ByRef Color As TCHOOSECOLOR) As Integer
	
	Public Enum EChooseColor
		CC_RGBInit = &H1s
		CC_FullOpen = &H2s
		CC_PreventFullOpen = &H4s
		CC_ColorShowHelp = &H8s
		' Win95 only
		CC_SolidColor = &H80s
		CC_AnyColor = &H100s
		' End Win95 only
		CC_ENABLEHOOK = &H10s
		CC_ENABLETEMPLATE = &H20s
		CC_EnableTemplateHandle = &H40s
	End Enum
	Private Declare Function GetSysColor Lib "USER32" (ByVal nIndex As Integer) As Integer
	
	Private Structure TCHOOSEFONT
		Dim lStructSize As Integer ' Filled with UDT size
		Dim hWndOwner As Integer ' Caller's window handle
		Dim hdc As Integer ' Printer DC/IC or NULL
		Dim lpLogFont As Integer ' Pointer to LOGFONT
		Dim iPointSize As Integer ' 10 * size in points of font
		Dim flags As Integer ' Type flags
		Dim rgbColors As Integer ' Returned text color
		Dim lCustData As Integer ' Data passed to hook function
		Dim lpfnHook As Integer ' Pointer to hook function
		Dim lpTemplateName As Integer ' Custom template name
		Dim hInstance As Integer ' Instance handle for template
		Dim lpszStyle As String ' Return style field
		Dim nFontType As Short ' Font type bits
		Dim iAlign As Short ' Filler
		Dim nSizeMin As Integer ' Minimum point size allowed
		Dim nSizeMax As Integer ' Maximum point size allowed
	End Structure
	'UPGRADE_WARNING: Structure TCHOOSEFONT may require marshalling attributes to be passed as an argument in this Declare statement. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1050"'
	Private Declare Function ChooseFont Lib "COMDLG32"  Alias "ChooseFontA"(ByRef chfont As TCHOOSEFONT) As Integer
	
	Private Const LF_FACESIZE As Short = 32
	Private Structure LOGFONT
		Dim lfHeight As Integer
		Dim lfWidth As Integer
		Dim lfEscapement As Integer
		Dim lfOrientation As Integer
		Dim lfWeight As Integer
		Dim lfItalic As Byte
		Dim lfUnderline As Byte
		Dim lfStrikeOut As Byte
		Dim lfCharSet As Byte
		Dim lfOutPrecision As Byte
		Dim lfClipPrecision As Byte
		Dim lfQuality As Byte
		Dim lfPitchAndFamily As Byte
		<VBFixedArray(LF_FACESIZE)> Dim lfFaceName() As Byte
		
		'UPGRADE_TODO: "Initialize" must be called to initialize instances of this structure. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1026"'
		Public Sub Initialize()
			ReDim lfFaceName(LF_FACESIZE)
		End Sub
	End Structure
	
	Public Enum EChooseFont
		CF_ScreenFonts = &H1s
		CF_PrinterFonts = &H2s
		CF_BOTH = &H3s
		CF_FontShowHelp = &H4s
		CF_UseStyle = &H80s
		CF_EFFECTS = &H100s
		CF_AnsiOnly = &H400s
		CF_NoVectorFonts = &H800s
		CF_NoOemFonts = EChooseFont.CF_NoVectorFonts
		CF_NoSimulations = &H1000s
		CF_LimitSize = &H2000s
		CF_FixedPitchOnly = &H4000s
		CF_WYSIWYG = &H8000 ' Must also have ScreenFonts And PrinterFonts
		CF_ForceFontExist = &H10000
		CF_ScalableOnly = &H20000
		CF_TTOnly = &H40000
		CF_NoFaceSel = &H80000
		CF_NoStyleSel = &H100000
		CF_NoSizeSel = &H200000
		' Win95 only
		CF_SelectScript = &H400000
		CF_NoScriptSel = &H800000
		CF_NoVertFonts = &H1000000
		CF_InitToLogFontStruct = &H40s
		CF_Apply = &H200s
		CF_EnableHook = &H8s
		CF_EnableTemplate = &H10s
		CF_EnableTemplateHandle = &H20s
		CF_FontNotSupported = &H238s
	End Enum
	
	' These are extra nFontType bits that are added to what is returned to the
	' EnumFonts callback routine
	
	Public Enum EFontType
		Simulated_FontType = &H8000
		Printer_FontType = &H4000s
		Screen_FontType = &H2000s
		Bold_FontType = &H100s
		Italic_FontType = &H200s
		Regular_FontType = &H400s
	End Enum
	
	Private Structure TPRINTDLG
		Dim lStructSize As Integer
		Dim hWndOwner As Integer
		Dim hDevMode As Integer
		Dim hDevNames As Integer
		Dim hdc As Integer
		Dim flags As Integer
		Dim nFromPage As Short
		Dim nToPage As Short
		Dim nMinPage As Short
		Dim nMaxPage As Short
		Dim nCopies As Short
		Dim hInstance As Integer
		Dim lCustData As Integer
		Dim lpfnPrintHook As Integer
		Dim lpfnSetupHook As Integer
		Dim lpPrintTemplateName As Integer
		Dim lpSetupTemplateName As Integer
		Dim hPrintTemplate As Integer
		Dim hSetupTemplate As Integer
	End Structure
	
	'  DEVMODE collation selections
	Private Const DMCOLLATE_FALSE As Short = 0
	Private Const DMCOLLATE_TRUE As Short = 1
	
	'UPGRADE_WARNING: Structure TPRINTDLG may require marshalling attributes to be passed as an argument in this Declare statement. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1050"'
	Private Declare Function PrintDlg Lib "COMDLG32.DLL"  Alias "PrintDlgA"(ByRef prtdlg As TPRINTDLG) As Short
	
	Public Enum EPrintDialog
		PD_ALLPAGES = &H0s
		PD_SELECTION = &H1s
		PD_PAGENUMS = &H2s
		PD_NOSELECTION = &H4s
		PD_NOPAGENUMS = &H8s
		PD_COLLATE = &H10s
		PD_PRINTTOFILE = &H20s
		PD_PRINTSETUP = &H40s
		PD_NOWARNING = &H80s
		PD_RETURNDC = &H100s
		PD_RETURNIC = &H200s
		PD_RETURNDEFAULT = &H400s
		PD_SHOWHELP = &H800s
		PD_ENABLEPRINTHOOK = &H1000s
		PD_ENABLESETUPHOOK = &H2000s
		PD_ENABLEPRINTTEMPLATE = &H4000s
		PD_ENABLESETUPTEMPLATE = &H8000
		PD_ENABLEPRINTTEMPLATEHANDLE = &H10000
		PD_ENABLESETUPTEMPLATEHANDLE = &H20000
		PD_USEDEVMODECOPIES = &H40000
		PD_USEDEVMODECOPIESANDCOLLATE = &H40000
		PD_DISABLEPRINTTOFILE = &H80000
		PD_HIDEPRINTTOFILE = &H100000
		PD_NONETWORKBUTTON = &H200000
	End Enum
	
	Private Structure DEVNAMES
		Dim wDriverOffset As Short
		Dim wDeviceOffset As Short
		Dim wOutputOffset As Short
		Dim wDefault As Short
	End Structure
	
	Private Const CCHDEVICENAME As Short = 32
	Private Const CCHFORMNAME As Short = 32
	Private Structure DevMode
		<VBFixedString(CCHDEVICENAME),System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.ByValTStr,SizeConst:=CCHDEVICENAME)> Public dmDeviceName As String
		Dim dmSpecVersion As Short
		Dim dmDriverVersion As Short
		Dim dmSize As Short
		Dim dmDriverExtra As Short
		Dim dmFields As Integer
		Dim dmOrientation As Short
		Dim dmPaperSize As Short
		Dim dmPaperLength As Short
		Dim dmPaperWidth As Short
		Dim dmScale As Short
		Dim dmCopies As Short
		Dim dmDefaultSource As Short
		Dim dmPrintQuality As Short
		Dim dmColor As Short
		Dim dmDuplex As Short
		Dim dmYResolution As Short
		Dim dmTTOption As Short
		Dim dmCollate As Short
		<VBFixedString(CCHFORMNAME),System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.ByValTStr,SizeConst:=CCHFORMNAME)> Public dmFormName As String
		Dim dmUnusedPadding As Short
		Dim dmBitsPerPel As Short
		Dim dmPelsWidth As Integer
		Dim dmPelsHeight As Integer
		Dim dmDisplayFlags As Integer
		Dim dmDisplayFrequency As Integer
	End Structure
	
	' New Win95 Page Setup dialogs are up to you
	Private Structure POINTL
		Dim x As Integer
		Dim y As Integer
	End Structure
	Private Structure RECT
		'UPGRADE_NOTE: Left was upgraded to Left_Renamed. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1061"'
		Dim Left_Renamed As Integer
		Dim TOp As Integer
		'UPGRADE_NOTE: Right was upgraded to Right_Renamed. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1061"'
		Dim Right_Renamed As Integer
		Dim Bottom As Integer
	End Structure
	
	
	Private Structure TPAGESETUPDLG
		Dim lStructSize As Integer
		Dim hWndOwner As Integer
		Dim hDevMode As Integer
		Dim hDevNames As Integer
		Dim flags As Integer
		Dim ptPaperSize As POINTL
		Dim rtMinMargin As RECT
		Dim rtMargin As RECT
		Dim hInstance As Integer
		Dim lCustData As Integer
		Dim lpfnPageSetupHook As Integer
		Dim lpfnPagePaintHook As Integer
		Dim lpPageSetupTemplateName As Integer
		Dim hPageSetupTemplate As Integer
	End Structure
	
	' EPaperSize constants same as vbPRPS constants
	Public Enum EPaperSize
		epsLetter = 1 ' Letter, 8 1/2 x 11 in.
		epsLetterSmall ' Letter Small, 8 1/2 x 11 in.
		epsTabloid ' Tabloid, 11 x 17 in.
		epsLedger ' Ledger, 17 x 11 in.
		epsLegal ' Legal, 8 1/2 x 14 in.
		epsStatement ' Statement, 5 1/2 x 8 1/2 in.
		epsExecutive ' Executive, 7 1/2 x 10 1/2 in.
		epsA3 ' A3, 297 x 420 mm
		epsA4 ' A4, 210 x 297 mm
		epsA4Small ' A4 Small, 210 x 297 mm
		epsA5 ' A5, 148 x 210 mm
		epsB4 ' B4, 250 x 354 mm
		epsB5 ' B5, 182 x 257 mm
		epsFolio ' Folio, 8 1/2 x 13 in.
		epsQuarto ' Quarto, 215 x 275 mm
		eps10x14 ' 10 x 14 in.
		eps11x17 ' 11 x 17 in.
		epsNote ' Note, 8 1/2 x 11 in.
		epsEnv9 ' Envelope #9, 3 7/8 x 8 7/8 in.
		epsEnv10 ' Envelope #10, 4 1/8 x 9 1/2 in.
		epsEnv11 ' Envelope #11, 4 1/2 x 10 3/8 in.
		epsEnv12 ' Envelope #12, 4 1/2 x 11 in.
		epsEnv14 ' Envelope #14, 5 x 11 1/2 in.
		epsCSheet ' C size sheet
		epsDSheet ' D size sheet
		epsESheet ' E size sheet
		epsEnvDL ' Envelope DL, 110 x 220 mm
		epsEnvC3 ' Envelope C3, 324 x 458 mm
		epsEnvC4 ' Envelope C4, 229 x 324 mm
		epsEnvC5 ' Envelope C5, 162 x 229 mm
		epsEnvC6 ' Envelope C6, 114 x 162 mm
		epsEnvC65 ' Envelope C65, 114 x 229 mm
		epsEnvB4 ' Envelope B4, 250 x 353 mm
		epsEnvB5 ' Envelope B5, 176 x 250 mm
		epsEnvB6 ' Envelope B6, 176 x 125 mm
		epsEnvItaly ' Envelope, 110 x 230 mm
		epsenvmonarch ' Envelope Monarch, 3 7/8 x 7 1/2 in.
		epsEnvPersonal ' Envelope, 3 5/8 x 6 1/2 in.
		epsFanfoldUS ' U.S. Standard Fanfold, 14 7/8 x 11 in.
		epsFanfoldStdGerman ' German Standard Fanfold, 8 1/2 x 12 in.
		epsFanfoldLglGerman ' German Legal Fanfold, 8 1/2 x 13 in.
		epsUser = 256 ' User-defined
	End Enum
	
	' EPrintQuality constants same as vbPRPQ constants
	Public Enum EPrintQuality
		epqDraft = -1
		epqLow = -2
		epqMedium = -3
		epqHigh = -4
	End Enum
	
	Public Enum EOrientation
		eoPortrait = 1
		eoLandscape
	End Enum
	
	'UPGRADE_WARNING: Structure TPAGESETUPDLG may require marshalling attributes to be passed as an argument in this Declare statement. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1050"'
	Private Declare Function PageSetupDlg Lib "COMDLG32"  Alias "PageSetupDlgA"(ByRef lppage As TPAGESETUPDLG) As Boolean
	
	Public Enum EPageSetup
		PSD_Defaultminmargins = &H0s ' Default (printer's)
		PSD_InWinIniIntlMeasure = &H0s
		PSD_MINMARGINS = &H1s
		PSD_MARGINS = &H2s
		PSD_INTHOUSANDTHSOFINCHES = &H4s
		PSD_INHUNDREDTHSOFMILLIMETERS = &H8s
		PSD_DISABLEMARGINS = &H10s
		PSD_DISABLEPRINTER = &H20s
		PSD_NoWarning = &H80s
		PSD_DISABLEORIENTATION = &H100s
		PSD_ReturnDefault = &H400s
		PSD_DISABLEPAPER = &H200s
		PSD_ShowHelp = &H800s
		PSD_EnablePageSetupHook = &H2000s
		PSD_EnablePageSetupTemplate = &H8000
		PSD_EnablePageSetupTemplateHandle = &H20000
		PSD_EnablePagePaintHook = &H40000
		PSD_DisablePagePainting = &H80000
	End Enum
	
	Public Enum EPageSetupUnits
		epsuInches
		epsuMillimeters
	End Enum
	
	' Common dialog errors
	
	Private Declare Function CommDlgExtendedError Lib "COMDLG32" () As Integer
	
	Public Enum EDialogError
		CDERR_DIALOGFAILURE = &HFFFFs
		CDERR_GENERALCODES = &H0s
		CDERR_STRUCTSIZE = &H1s
		CDERR_INITIALIZATION = &H2s
		CDERR_NOTEMPLATE = &H3s
		CDERR_NOHINSTANCE = &H4s
		CDERR_LOADSTRFAILURE = &H5s
		CDERR_FINDRESFAILURE = &H6s
		CDERR_LOADRESFAILURE = &H7s
		CDERR_LOCKRESFAILURE = &H8s
		CDERR_MEMALLOCFAILURE = &H9s
		CDERR_MEMLOCKFAILURE = &HAs
		CDERR_NOHOOK = &HBs
		CDERR_REGISTERMSGFAIL = &HCs
		PDERR_PRINTERCODES = &H1000s
		PDERR_SETUPFAILURE = &H1001s
		PDERR_PARSEFAILURE = &H1002s
		PDERR_RETDEFFAILURE = &H1003s
		PDERR_LOADDRVFAILURE = &H1004s
		PDERR_GETDEVMODEFAIL = &H1005s
		PDERR_INITFAILURE = &H1006s
		PDERR_NODEVICES = &H1007s
		PDERR_NODEFAULTPRN = &H1008s
		PDERR_DNDMMISMATCH = &H1009s
		PDERR_CREATEICFAILURE = &H100As
		PDERR_PRINTERNOTFOUND = &H100Bs
		PDERR_DEFAULTDIFFERENT = &H100Cs
		CFERR_CHOOSEFONTCODES = &H2000s
		CFERR_NOFONTS = &H2001s
		CFERR_MAXLESSTHANMIN = &H2002s
		FNERR_FILENAMECODES = &H3000s
		FNERR_SUBCLASSFAILURE = &H3001s
		FNERR_INVALIDFILENAME = &H3002s
		FNERR_BUFFERTOOSMALL = &H3003s
		CCERR_CHOOSECOLORCODES = &H5000s
	End Enum
	
	' Array of custom colors lasts for life of app
	Private alCustom(15) As Integer
	Private fNotFirst As Boolean
	
	Public Enum EPrintRange
		eprAll
		eprPageNumbers
		eprSelection
	End Enum
	Private m_lApiReturn As Integer
	Private m_lExtendedError As Integer
	Private m_dvmode As DevMode
	
	Public ReadOnly Property APIReturn() As Integer
		Get
			'return object's APIReturn property
			APIReturn = m_lApiReturn
		End Get
	End Property
	Public ReadOnly Property ExtendedError() As Integer
		Get
			'return object's ExtendedError property
			ExtendedError = m_lExtendedError
		End Get
	End Property
	
	' Property to read or modify custom colors (use to save colors in registry)
	
	Public Property CustomColor(ByVal i As Short) As Integer
		Get
			' If first time, initialize to white
			If fNotFirst = False Then InitColors()
			If i >= 0 And i <= 15 Then
				CustomColor = alCustom(i)
			Else
				CustomColor = -1
			End If
		End Get
		Set(ByVal Value As Integer)
			' If first time, initialize to system colors
			If fNotFirst = False Then InitColors()
			If i >= 0 And i <= 15 Then
				alCustom(i) = Value
			End If
		End Set
	End Property
	Private ReadOnly Property DevMode_Renamed() As DevMode
		Get
			'UPGRADE_WARNING: Couldn't resolve default property of object DevMode_Renamed. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
			Return m_dvmode
		End Get
	End Property
	
#If fComponent Then
	'UPGRADE_NOTE: #If #EndIf block was not upgraded because the expression fComponent did not evaluate to True or was not evaluated. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1035"'
	Private Sub Class_Initialize()
	InitColors
	End Sub
#End If
	
	'UPGRADE_NOTE: Filter was upgraded to Filter_Renamed. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1061"'
	'UPGRADE_NOTE: ReadOnly was upgraded to ReadOnly_Renamed. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1061"'
	Function VBGetOpenFileName(ByRef FileName As String, Optional ByRef FileTitle As String = "", Optional ByRef FileMustExist As Boolean = True, Optional ByRef MultiSelect As Boolean = False, Optional ByRef ReadOnly_Renamed As Boolean = False, Optional ByRef HideReadOnly As Boolean = False, Optional ByRef Filter_Renamed As String = "Wszystkie pliki (*.*)| *.*", Optional ByRef FilterIndex As Integer = 1, Optional ByRef InitDir As String = "", Optional ByRef DlgTitle As String = "", Optional ByRef DefaultExt As String = "", Optional ByRef Owner As Integer = -1, Optional ByRef flags As Integer = 0) As Boolean
		
		Dim opfile As OPENFILENAME
		Dim s As String
		Dim afFlags As Integer
		
		m_lApiReturn = 0
		m_lExtendedError = 0
		
		Dim ch As String
		Dim i As Short
		With opfile
			.lStructSize = Len(opfile)
			
			' Add in specific flags and strip out non-VB flags
			
			.flags = (-CShort(FileMustExist) * EOpenFile.OFN_FILEMUSTEXIST) Or (-CShort(MultiSelect) * EOpenFile.OFN_ALLOWMULTISELECT) Or (-CShort(ReadOnly_Renamed) * EOpenFile.OFN_READONLY) Or (-CShort(HideReadOnly) * EOpenFile.OFN_HIDEREADONLY) Or (flags And CInt(Not (EOpenFile.OFN_ENABLEHOOK Or EOpenFile.OFN_ENABLETEMPLATE)))
			' Owner can take handle of owning window
			If Owner <> -1 Then .hWndOwner = Owner
			' InitDir can take initial directory string
			.lpstrInitialDir = InitDir
			' DefaultExt can take default extension
			.lpstrDefExt = DefaultExt
			' DlgTitle can take dialog box title
			.lpstrTitle = DlgTitle
			
			' To make Windows-style filter, replace | and : with nulls
			s = Replace(Filter_Renamed, "|", Chr(0))
			s = Replace(s, ":", Chr(0))
			' Put double null at end
			s = s & Chr(0) & Chr(0)
			.lpstrFilter = s
			.nFilterIndex = FilterIndex
			
			' Pad file and file title buffers to maximum path
			s = FileName & New String(Chr(0), MAX_PATH - Len(FileName))
			.lpstrFile = s
			.nMaxFile = MAX_PATH
			s = FileTitle & New String(Chr(0), MAX_FILE - Len(FileTitle))
			.lpstrFileTitle = s
			.nMaxFileTitle = MAX_FILE
			' All other fields set to zero
			
			m_lApiReturn = GetOpenFileName(opfile)
			Select Case m_lApiReturn
				Case 1
					' Success
					VBGetOpenFileName = True
					FileName = StrZToStr(.lpstrFile)
					FileTitle = StrZToStr(.lpstrFileTitle)
					flags = .flags
					' Return the filter index
					FilterIndex = .nFilterIndex
					' Look up the filter the user selected and return that
					Filter_Renamed = FilterLookup(.lpstrFilter, FilterIndex)
					If (.flags And EOpenFile.OFN_READONLY) Then ReadOnly_Renamed = True
				Case 0
					' Cancelled
					VBGetOpenFileName = False
					FileName = ""
					FileTitle = ""
					flags = 0
					FilterIndex = -1
					Filter_Renamed = ""
				Case Else
					' Extended error
					m_lExtendedError = CommDlgExtendedError()
					VBGetOpenFileName = False
					FileName = ""
					FileTitle = ""
					flags = 0
					FilterIndex = -1
					Filter_Renamed = ""
			End Select
		End With
	End Function
	Private Function StrZToStr(ByRef s As String) As String
		StrZToStr = Left(s, lstrlen(s))
	End Function
	
	'UPGRADE_NOTE: Filter was upgraded to Filter_Renamed. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1061"'
	Function VBGetSaveFileName(ByRef FileName As String, Optional ByRef FileTitle As String = "", Optional ByRef OverWritePrompt As Boolean = True, Optional ByRef Filter_Renamed As String = "Wszystkie pliki (*.*)| *.*", Optional ByRef FilterIndex As Integer = 1, Optional ByRef InitDir As String = "", Optional ByRef DlgTitle As String = "", Optional ByRef DefaultExt As String = "", Optional ByRef Owner As Integer = -1, Optional ByRef flags As Integer = 0) As Boolean
		
		Dim opfile As OPENFILENAME
		Dim s As String
		
		m_lApiReturn = 0
		m_lExtendedError = 0
		
		Dim ch As String
		Dim i As Short
		With opfile
			.lStructSize = Len(opfile)
			
			' Add in specific flags and strip out non-VB flags
			.flags = (-CShort(OverWritePrompt) * EOpenFile.OFN_OVERWRITEPROMPT) Or EOpenFile.OFN_HIDEREADONLY Or (flags And CInt(Not (EOpenFile.OFN_ENABLEHOOK Or EOpenFile.OFN_ENABLETEMPLATE)))
			' Owner can take handle of owning window
			If Owner <> -1 Then .hWndOwner = Owner
			' InitDir can take initial directory string
			.lpstrInitialDir = InitDir
			' DefaultExt can take default extension
			.lpstrDefExt = DefaultExt
			' DlgTitle can take dialog box title
			.lpstrTitle = DlgTitle
			
			' Make new filter with bars (|) replacing nulls and double null at end
			For i = 1 To Len(Filter_Renamed)
				ch = Mid(Filter_Renamed, i, 1)
				If ch = "|" Or ch = ":" Then
					s = s & Chr(0)
				Else
					s = s & ch
				End If
			Next 
			' Put double null at end
			s = s & Chr(0) & Chr(0)
			.lpstrFilter = s
			.nFilterIndex = FilterIndex
			
			' Pad file and file title buffers to maximum path
			s = FileName & New String(Chr(0), MAX_PATH - Len(FileName))
			.lpstrFile = s
			.nMaxFile = MAX_PATH
			s = FileTitle & New String(Chr(0), MAX_FILE - Len(FileTitle))
			.lpstrFileTitle = s
			.nMaxFileTitle = MAX_FILE
			' All other fields zero
			
			m_lApiReturn = GetSaveFileName(opfile)
			Select Case m_lApiReturn
				Case 1
					VBGetSaveFileName = True
					FileName = StrZToStr(.lpstrFile)
					FileTitle = StrZToStr(.lpstrFileTitle)
					flags = .flags
					' Return the filter index
					FilterIndex = .nFilterIndex
					' Look up the filter the user selected and return that
					Filter_Renamed = FilterLookup(.lpstrFilter, FilterIndex)
				Case 0
					' Cancelled:
					VBGetSaveFileName = False
					FileName = ""
					FileTitle = ""
					flags = 0
					FilterIndex = 0
					Filter_Renamed = ""
				Case Else
					' Extended error:
					VBGetSaveFileName = False
					m_lExtendedError = CommDlgExtendedError()
					FileName = ""
					FileTitle = ""
					flags = 0
					FilterIndex = 0
					Filter_Renamed = ""
			End Select
		End With
	End Function
	
	Private Function FilterLookup(ByVal sFilters As String, ByVal iCur As Integer) As String
		Dim iStart, iEnd As Integer
		Dim s As String
		iStart = 1
		If sFilters = "" Then Exit Function
		Do 
			' Cut out both parts marked by null character
			iEnd = InStr(iStart, sFilters, Chr(0))
			If iEnd = 0 Then Exit Function
			iEnd = InStr(iEnd + 1, sFilters, Chr(0))
			If iEnd Then
				s = Mid(sFilters, iStart, iEnd - iStart)
			Else
				s = Mid(sFilters, iStart)
			End If
			iStart = iEnd + 1
			If iCur = 1 Then
				FilterLookup = s
				Exit Function
			End If
			iCur = iCur - 1
		Loop While iCur
	End Function
	
	Function VBGetFileTitle(ByRef sFile As String) As String
		Dim sFileTitle As String
		Dim cFileTitle As Short
		
		cFileTitle = MAX_PATH
		sFileTitle = New String(Chr(0), MAX_PATH)
		cFileTitle = GetFileTitle(sFile, sFileTitle, MAX_PATH)
		If cFileTitle Then
			VBGetFileTitle = ""
		Else
			VBGetFileTitle = Left(sFileTitle, InStr(sFileTitle, Chr(0)) - 1)
		End If
		
	End Function
	
	' ChooseColor wrapper
	Function VBChooseColor(ByRef Color As Integer, Optional ByRef AnyColor As Boolean = True, Optional ByRef FullOpen As Boolean = False, Optional ByRef DisableFullOpen As Boolean = False, Optional ByRef Owner As Integer = -1, Optional ByRef flags As Integer = 0) As Boolean
		
		Dim chclr As TCHOOSECOLOR
		chclr.lStructSize = Len(chclr)
		
		' Color must get reference variable to receive result
		' Flags can get reference variable or constant with bit flags
		' Owner can take handle of owning window
		If Owner <> -1 Then chclr.hWndOwner = Owner
		
		' Assign color (default uninitialized value of zero is good default)
		chclr.rgbResult = Color
		
		' Mask out unwanted bits
		Dim afMask As Integer
		afMask = CInt(Not (EChooseColor.CC_ENABLEHOOK Or EChooseColor.CC_ENABLETEMPLATE))
		' Pass in flags
		chclr.flags = afMask And (EChooseColor.CC_RGBInit Or IIf(AnyColor, EChooseColor.CC_AnyColor, EChooseColor.CC_SolidColor) Or (-CShort(FullOpen) * EChooseColor.CC_FullOpen) Or (-CShort(DisableFullOpen) * EChooseColor.CC_PreventFullOpen))
		
		' If first time, initialize to white
		If fNotFirst = False Then InitColors()
		
		'UPGRADE_ISSUE: VarPtr function is not supported. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1040"'
		chclr.lpCustColors = VarPtr(alCustom(0))
		' All other fields zero
		
		m_lApiReturn = ChooseColor(chclr)
		Select Case m_lApiReturn
			Case 1
				' Success
				VBChooseColor = True
				Color = chclr.rgbResult
			Case 0
				' Cancelled
				VBChooseColor = False
				Color = -1
			Case Else
				' Extended error
				m_lExtendedError = CommDlgExtendedError()
				VBChooseColor = False
				Color = -1
		End Select
		
	End Function
	
	Private Sub InitColors()
		Dim i As Short
		' Initialize with first 16 system interface colors
		For i = 0 To 15
			alCustom(i) = GetSysColor(i)
		Next 
		fNotFirst = True
	End Sub
	
	' ChooseFont wrapper
	Function VBChooseFont(ByRef CurFont As System.Drawing.Font, Optional ByRef PrinterDC As Integer = -1, Optional ByRef Owner As Integer = -1, Optional ByRef Color As Integer = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Black), Optional ByRef MinSize As Integer = 0, Optional ByRef MaxSize As Integer = 0, Optional ByRef flags As Integer = 0) As Boolean
		
		m_lApiReturn = 0
		m_lExtendedError = 0
		
		' Unwanted Flags bits
		Const CF_FontNotSupported As Boolean = EChooseFont.CF_Apply Or EChooseFont.CF_EnableHook Or EChooseFont.CF_EnableTemplate
		
		' Flags can get reference variable or constant with bit flags
		' PrinterDC can take printer DC
		If PrinterDC = -1 Then
			PrinterDC = 0
			'UPGRADE_ISSUE: Printer property Printer.hdc was not upgraded. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup2069"'
			If flags And EChooseFont.CF_PrinterFonts Then PrinterDC = Printer.hDC
		Else
			flags = flags Or EChooseFont.CF_PrinterFonts
		End If
		' Must have some fonts
		If (flags And EChooseFont.CF_PrinterFonts) = 0 Then flags = flags Or EChooseFont.CF_ScreenFonts
		' Color can take initial color, receive chosen color
		If Color <> System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Black) Then flags = flags Or EChooseFont.CF_EFFECTS
		' MinSize can be minimum size accepted
		If MinSize Then flags = flags Or EChooseFont.CF_LimitSize
		' MaxSize can be maximum size accepted
		If MaxSize Then flags = flags Or EChooseFont.CF_LimitSize
		
		' Put in required internal flags and remove unsupported
		flags = (flags Or EChooseFont.CF_InitToLogFontStruct) And Not CF_FontNotSupported
		
		' Initialize LOGFONT variable
		'UPGRADE_WARNING: Arrays in structure fnt may need to be initialized before they can be used. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1063"'
		Dim fnt As LOGFONT
		Const PointsPerTwip As Short = 1440 / 72
		fnt.lfHeight = -(CurFont.SizeInPoints * (PointsPerTwip / VB6.TwipsPerPixelY))
		'UPGRADE_ISSUE: Font property CurFont.Weight was not upgraded. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup2064"'
		fnt.lfWeight = CurFont.Weight
		fnt.lfItalic = CurFont.Italic
		fnt.lfUnderline = CurFont.Underline
		fnt.lfStrikeOut = CurFont.StrikeOut
		' Other fields zero
		StrToBytes(fnt.lfFaceName, (CurFont.Name))
		
		' Initialize TCHOOSEFONT variable
		Dim cf As TCHOOSEFONT
		cf.lStructSize = Len(cf)
		If Owner <> -1 Then cf.hWndOwner = Owner
		cf.hdc = PrinterDC
		'UPGRADE_ISSUE: VarPtr function is not supported. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1040"'
		cf.lpLogFont = VarPtr(fnt)
		cf.iPointSize = CurFont.SizeInPoints * 10
		cf.flags = flags
		cf.rgbColors = Color
		cf.nSizeMin = MinSize
		cf.nSizeMax = MaxSize
		
		' All other fields zero
		m_lApiReturn = ChooseFont(cf)
		Select Case m_lApiReturn
			Case 1
				' Success
				VBChooseFont = True
				flags = cf.flags
				Color = cf.rgbColors
				CurFont = VB6.FontChangeBold(CurFont, cf.nFontType And EFontType.Bold_FontType)
				'CurFont.Italic = cf.nFontType And Italic_FontType
				CurFont = VB6.FontChangeItalic(CurFont, fnt.lfItalic)
				CurFont = VB6.FontChangeStrikeOut(CurFont, fnt.lfStrikeOut)
				CurFont = VB6.FontChangeUnderline(CurFont, fnt.lfUnderline)
				'UPGRADE_ISSUE: Font property CurFont.Weight was not upgraded. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup2064"'
				CurFont.Weight = fnt.lfWeight
				CurFont = VB6.FontChangeSize(CurFont, cf.iPointSize / 10)
				CurFont = VB6.FontChangeName(CurFont, BytesToStr(fnt.lfFaceName))
			Case 0
				' Cancelled
				VBChooseFont = False
			Case Else
				' Extended error
				m_lExtendedError = CommDlgExtendedError()
				VBChooseFont = False
		End Select
		
	End Function
	
	' PrintDlg wrapper
	Function VBPrintDlg(ByRef hdc As Integer, Optional ByRef PrintRange As EPrintRange = EPrintRange.eprAll, Optional ByRef DisablePageNumbers As Boolean = False, Optional ByRef FromPage As Integer = 1, Optional ByRef ToPage As Integer = &HFFFFs, Optional ByRef DisableSelection As Boolean = False, Optional ByRef Copies As Short = 0, Optional ByRef ShowPrintToFile As Boolean = False, Optional ByRef DisablePrintToFile As Boolean = True, Optional ByRef PrintToFile As Boolean = False, Optional ByRef Collate As Boolean = False, Optional ByRef PreventWarning As Boolean = False, Optional ByRef Owner As Integer = 0, Optional ByRef Printer As Object = Nothing, Optional ByRef flags As Integer = 0) As Boolean
		Dim afFlags, afMask As Integer
		
		m_lApiReturn = 0
		m_lExtendedError = 0
		
		' Set PRINTDLG flags
		afFlags = (-CShort(DisablePageNumbers) * EPrintDialog.PD_NOPAGENUMS) Or (-CShort(DisablePrintToFile) * EPrintDialog.PD_DISABLEPRINTTOFILE) Or (-CShort(DisableSelection) * EPrintDialog.PD_NOSELECTION) Or (-CShort(PrintToFile) * EPrintDialog.PD_PRINTTOFILE) Or (-CShort(Not ShowPrintToFile) * EPrintDialog.PD_HIDEPRINTTOFILE) Or (-CShort(PreventWarning) * EPrintDialog.PD_NOWARNING) Or (-CShort(Collate) * EPrintDialog.PD_COLLATE) Or EPrintDialog.PD_USEDEVMODECOPIESANDCOLLATE Or EPrintDialog.PD_RETURNDC
		If PrintRange = EPrintRange.eprPageNumbers Then
			afFlags = afFlags Or EPrintDialog.PD_PAGENUMS
		ElseIf PrintRange = EPrintRange.eprSelection Then 
			afFlags = afFlags Or EPrintDialog.PD_SELECTION
		End If
		' Mask out unwanted bits
		afMask = CInt(Not (EPrintDialog.PD_ENABLEPRINTHOOK Or EPrintDialog.PD_ENABLEPRINTTEMPLATE))
		afMask = afMask And CInt(Not (EPrintDialog.PD_ENABLESETUPHOOK Or EPrintDialog.PD_ENABLESETUPTEMPLATE))
		
		' Fill in PRINTDLG structure
		Dim pd As TPRINTDLG
		pd.lStructSize = Len(pd)
		pd.hWndOwner = Owner
		pd.flags = afFlags And afMask
		pd.nFromPage = FromPage
		pd.nToPage = ToPage
		pd.nMinPage = 1
		pd.nMaxPage = &HFFFFs
		
		' Show Print dialog
		m_lApiReturn = PrintDlg(pd)
		Dim pDevMode As Integer
		Select Case m_lApiReturn
			Case 1
				VBPrintDlg = True
				' Return dialog values in parameters
				hdc = pd.hdc
				If (pd.flags And EPrintDialog.PD_PAGENUMS) Then
					PrintRange = EPrintRange.eprPageNumbers
				ElseIf (pd.flags And EPrintDialog.PD_SELECTION) Then 
					PrintRange = EPrintRange.eprSelection
				Else
					PrintRange = EPrintRange.eprAll
				End If
				FromPage = pd.nFromPage
				ToPage = pd.nToPage
				PrintToFile = (pd.flags And EPrintDialog.PD_PRINTTOFILE)
				' Get DEVMODE structure from PRINTDLG
				pDevMode = GlobalLock(pd.hDevMode)
				'UPGRADE_WARNING: Couldn't resolve default property of object m_dvmode. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
				CopyMemory(m_dvmode, pDevMode, Len(m_dvmode))
				Call GlobalUnlock(pd.hDevMode)
				' Get Copies and Collate settings from DEVMODE structure
				Copies = m_dvmode.dmCopies
				Collate = (m_dvmode.dmCollate = DMCOLLATE_TRUE)
				
				' Set default printer properties
				On Error Resume Next
				If Not (Printer Is Nothing) Then
					'UPGRADE_WARNING: Couldn't resolve default property of object Printer.Copies. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
					Printer.Copies = Copies
					'UPGRADE_WARNING: Couldn't resolve default property of object Printer.Orientation. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
					Printer.Orientation = m_dvmode.dmOrientation
					'UPGRADE_WARNING: Couldn't resolve default property of object Printer.PaperSize. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
					Printer.PaperSize = m_dvmode.dmPaperSize
					'UPGRADE_WARNING: Couldn't resolve default property of object Printer.PrintQuality. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
					Printer.PrintQuality = m_dvmode.dmPrintQuality
				End If
				On Error GoTo 0
			Case 0
				' Cancelled
				VBPrintDlg = False
			Case Else
				' Extended error:
				m_lExtendedError = CommDlgExtendedError()
				VBPrintDlg = False
		End Select
		
	End Function
	
	' PageSetupDlg wrapper
	Function VBPageSetupDlg(Optional ByRef Owner As Integer = 0, Optional ByRef DisableMargins As Boolean = False, Optional ByRef DisableOrientation As Boolean = False, Optional ByRef DisablePaper As Boolean = False, Optional ByRef DisablePrinter As Boolean = False, Optional ByRef LeftMargin As Integer = 0, Optional ByRef MinLeftMargin As Integer = 0, Optional ByRef RightMargin As Integer = 0, Optional ByRef MinRightMargin As Integer = 0, Optional ByRef TopMargin As Integer = 0, Optional ByRef MinTopMargin As Integer = 0, Optional ByRef BottomMargin As Integer = 0, Optional ByRef MinBottomMargin As Integer = 0, Optional ByRef PaperSize As EPaperSize = EPaperSize.epsLetter, Optional ByRef Orientation As EOrientation = EOrientation.eoPortrait, Optional ByRef PrintQuality As EPrintQuality = EPrintQuality.epqDraft, Optional ByRef Units As EPageSetupUnits = EPageSetupUnits.epsuInches, Optional ByRef Printer As Object = Nothing, Optional ByRef flags As Integer = 0) As Boolean
		Dim afFlags, afMask As Integer
		
		m_lApiReturn = 0
		m_lExtendedError = 0
		' Mask out unwanted bits
		afMask = Not (EPageSetup.PSD_EnablePagePaintHook Or EPageSetup.PSD_EnablePageSetupHook Or EPageSetup.PSD_EnablePageSetupTemplate)
		' Set TPAGESETUPDLG flags
		afFlags = (-CShort(DisableMargins) * EPageSetup.PSD_DISABLEMARGINS) Or (-CShort(DisableOrientation) * EPageSetup.PSD_DISABLEORIENTATION) Or (-CShort(DisablePaper) * EPageSetup.PSD_DISABLEPAPER) Or (-CShort(DisablePrinter) * EPageSetup.PSD_DISABLEPRINTER) Or EPageSetup.PSD_MARGINS Or EPageSetup.PSD_MINMARGINS And afMask
		Dim lUnits As Integer
		If Units = EPageSetupUnits.epsuInches Then
			afFlags = afFlags Or EPageSetup.PSD_INTHOUSANDTHSOFINCHES
			lUnits = 1000
		Else
			afFlags = afFlags Or EPageSetup.PSD_INHUNDREDTHSOFMILLIMETERS
			lUnits = 100
		End If
		
		Dim psd As TPAGESETUPDLG
		' Fill in PRINTDLG structure
		psd.lStructSize = Len(psd)
		psd.hWndOwner = Owner
		psd.rtMargin.TOp = TopMargin * lUnits
		psd.rtMargin.Left_Renamed = LeftMargin * lUnits
		psd.rtMargin.Bottom = BottomMargin * lUnits
		psd.rtMargin.Right_Renamed = RightMargin * lUnits
		psd.rtMinMargin.TOp = MinTopMargin * lUnits
		psd.rtMinMargin.Left_Renamed = MinLeftMargin * lUnits
		psd.rtMinMargin.Bottom = MinBottomMargin * lUnits
		psd.rtMinMargin.Right_Renamed = MinRightMargin * lUnits
		psd.flags = afFlags
		
		' Show Print dialog
		Dim dvmode As DevMode
		Dim pDevMode As Integer
		If PageSetupDlg(psd) Then
			VBPageSetupDlg = True
			' Return dialog values in parameters
			TopMargin = psd.rtMargin.TOp / lUnits
			LeftMargin = psd.rtMargin.Left_Renamed / lUnits
			BottomMargin = psd.rtMargin.Bottom / lUnits
			RightMargin = psd.rtMargin.Right_Renamed / lUnits
			MinTopMargin = psd.rtMinMargin.TOp / lUnits
			MinLeftMargin = psd.rtMinMargin.Left_Renamed / lUnits
			MinBottomMargin = psd.rtMinMargin.Bottom / lUnits
			MinRightMargin = psd.rtMinMargin.Right_Renamed / lUnits
			
			' Get DEVMODE structure from PRINTDLG
			pDevMode = GlobalLock(psd.hDevMode)
			'UPGRADE_WARNING: Couldn't resolve default property of object dvmode. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
			CopyMemory(dvmode, pDevMode, Len(dvmode))
			Call GlobalUnlock(psd.hDevMode)
			PaperSize = dvmode.dmPaperSize
			Orientation = dvmode.dmOrientation
			PrintQuality = dvmode.dmPrintQuality
			' Set default printer properties
			On Error Resume Next
			If Not (Printer Is Nothing) Then
				'UPGRADE_WARNING: Couldn't resolve default property of object Printer.Copies. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
				Printer.Copies = dvmode.dmCopies
				'UPGRADE_WARNING: Couldn't resolve default property of object Printer.Orientation. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
				Printer.Orientation = dvmode.dmOrientation
				'UPGRADE_WARNING: Couldn't resolve default property of object Printer.PaperSize. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
				Printer.PaperSize = dvmode.dmPaperSize
				'UPGRADE_WARNING: Couldn't resolve default property of object Printer.PrintQuality. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
				Printer.PrintQuality = dvmode.dmPrintQuality
			End If
			On Error GoTo 0
		End If
		
	End Function
	
#If fComponent = 0 Then
	Private Sub ErrRaise(ByRef e As Integer)
		Dim sText, sSource As String
		If e > 1000 Then
			sSource = VB6.GetExeName() & ".CommonDialog"
			Err.Raise(COMError(e), sSource, sText)
		Else
			' Raise standard Visual Basic error
			sSource = VB6.GetExeName() & ".VBError"
			Err.Raise(e, sSource)
		End If
	End Sub
#End If
	
	
	Private Sub StrToBytes(ByRef ab() As Byte, ByRef s As String)
		Dim cab As Integer
		If IsArrayEmpty(ab) Then
			' Assign to empty array
			'UPGRADE_ISSUE: Constant vbFromUnicode was not upgraded. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup2070"'
			'UPGRADE_TODO: Code was upgraded to use System.Text.UnicodeEncoding.Unicode.GetBytes() which may not have the same behavior. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1059"'
			ab = System.Text.UnicodeEncoding.Unicode.GetBytes(StrConv(s, vbFromUnicode))
		Else
			' Copy to existing array, padding or truncating if necessary
			cab = UBound(ab) - LBound(ab) + 1
			If Len(s) < cab Then s = s & New String(Chr(0), cab - Len(s))
			'If UnicodeTypeLib Then
			'    Dim st As String
			'    st = StrConv(s, vbFromUnicode)
			'    CopyMemoryStr ab(LBound(ab)), st, cab
			'Else
			CopyMemoryStr(ab(LBound(ab)), s, cab)
			'End If
		End If
	End Sub
	
	
	Private Function BytesToStr(ByRef ab() As Byte) As String
		'UPGRADE_ISSUE: Constant vbUnicode was not upgraded. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup2070"'
		BytesToStr = StrConv(System.Text.UnicodeEncoding.Unicode.GetString(ab), vbUnicode)
	End Function
	
	Private Function COMError(ByRef e As Integer) As Integer
		COMError = e Or vbObjectError
	End Function
	'
	Private Function IsArrayEmpty(ByRef va As Object) As Boolean
		Dim v As Object
		On Error Resume Next
		'UPGRADE_WARNING: Couldn't resolve default property of object va(). Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
		'UPGRADE_WARNING: Couldn't resolve default property of object v. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
		v = va(LBound(va))
		IsArrayEmpty = (Err.Number <> 0)
	End Function
End Class