using System.Reflection;
using System.Runtime.InteropServices;
using System.Windows;

#if NET5_0_OR_GREATER
using System.Runtime.Versioning;
#endif

[assembly: AssemblyTitle("MetroRadiance.Chrome.Externals")]
[assembly: AssemblyCompany("grabacr.net")]
[assembly: AssemblyProduct("MetroRadiance")]
[assembly: AssemblyDescription("Modern WPF Themes (chrome for external window)")]
[assembly: AssemblyCopyright("Copyright © 2015 Manato KAMEYA")]

[assembly: ComVisible(false)]
[assembly: Guid("BDDDEB9F-1DEA-4B17-A175-010D8AE36B13")]

[assembly: ThemeInfo(
	ResourceDictionaryLocation.None,
	ResourceDictionaryLocation.SourceAssembly)]

[assembly: AssemblyVersion("2.1.0")]
[assembly: AssemblyInformationalVersion("2.1.0")]

#if NET5_0_OR_GREATER
[assembly: TargetPlatform("windows7.0")]
[assembly: SupportedOSPlatform("windows7.0")]
#endif
