Imports System.Reflection
Imports System.Resources
Imports System.Runtime.InteropServices

' What both assemblies of the game share: who makes it, its version, its copyright. The
' application and Skrzynki.Core each link this one file in, and add only their own title and
' description in their own My Project\AssemblyInfo.vb - so a new version or a new year is
' written once.
'
' Keep this file saved as UTF-8 with a byte order mark: the copyright sign below would otherwise
' be read in the build machine's ANSI code page.

<Assembly: AssemblyCompany("Kamil J. Dudek")>
<Assembly: AssemblyProduct("Boxes: Skrzynki")>
<Assembly: AssemblyCopyright("© 2000-2001 Karol Kuczmarski, 2020-2021 Kamil J. Dudek")>
<Assembly: AssemblyTrademark("")>

<Assembly: AssemblyVersion("4.0")>
<Assembly: AssemblyFileVersion("4.0")>

<Assembly: ComVisible(False)>
<Assembly: CLSCompliant(True)>
<Assembly: NeutralResourcesLanguage("en")>
