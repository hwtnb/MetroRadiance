using System.Reflection;
using System.Runtime.InteropServices;
using System.Windows;

#if NET5_0_OR_GREATER
using System.Runtime.Versioning;
#endif

[assembly: AssemblyTitle("MetroRadiance.Core")]
[assembly: AssemblyCompany("grabacr.net")]
[assembly: AssemblyProduct("MetroRadiance")]
[assembly: AssemblyDescription("Modern WPF Themes (core)")]
[assembly: AssemblyCopyright("Copyright © 2014 Manato KAMEYA")]

[assembly: ComVisible(false)]
[assembly: Guid("F3EACB40-2C04-418F-8297-AD00858824A9")]

[assembly: ThemeInfo(
	ResourceDictionaryLocation.None,
	ResourceDictionaryLocation.SourceAssembly)]

[assembly: AssemblyVersion("2.4.1")]
[assembly: AssemblyInformationalVersion("2.4.1")]

#if NET5_0_OR_GREATER
[assembly: TargetPlatform("windows7.0")]
[assembly: SupportedOSPlatform("windows7.0")]
#endif
