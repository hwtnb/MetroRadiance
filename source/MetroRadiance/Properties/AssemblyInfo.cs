﻿using System.Reflection;
using System.Runtime.InteropServices;
using System.Windows;
using System.Windows.Markup;

#if NET5_0_OR_GREATER
using System.Runtime.Versioning;
#endif

[assembly: AssemblyTitle("MetroRadiance")]
[assembly: AssemblyCompany("grabacr.net")]
[assembly: AssemblyProduct("MetroRadiance")]
[assembly: AssemblyDescription("Modern WPF Themes")]
[assembly: AssemblyCopyright("Copyright © 2014 Manato KAMEYA")]

[assembly: ComVisible(false)]
[assembly: Guid("9A055744-2C4E-465D-A8F2-AD26B43C5F50")]

[assembly: ThemeInfo(
	ResourceDictionaryLocation.None,
	ResourceDictionaryLocation.SourceAssembly)]

[assembly: XmlnsDefinition("http://schemes.grabacr.net/winfx/2014/controls", "MetroRadiance.UI.Controls")]
[assembly: XmlnsDefinition("http://schemes.grabacr.net/winfx/2014/converters", "MetroRadiance.UI.Converters")]
[assembly: XmlnsDefinition("http://schemes.grabacr.net/winfx/2014/interactivity", "MetroRadiance.UI.Interactivity")]

[assembly: AssemblyVersion("2.4.1")]
[assembly: AssemblyInformationalVersion("2.4.1")]

#if NET5_0_OR_GREATER
[assembly: TargetPlatform("windows7.0")]
[assembly: SupportedOSPlatform("windows7.0")]
#endif
