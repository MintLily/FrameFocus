using System.Resources;
using System.Reflection;
using System.Runtime.InteropServices;
using MelonLoader;

[assembly: AssemblyTitle(FrameFocus.BuildInfo.Name)]
[assembly: AssemblyDescription(FrameFocus.BuildInfo.Description)]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany(FrameFocus.BuildInfo.Company)]
[assembly: AssemblyProduct(FrameFocus.BuildInfo.Name)]
[assembly: AssemblyCopyright("Created by " + FrameFocus.BuildInfo.Author)]
[assembly: AssemblyTrademark(FrameFocus.BuildInfo.Company)]
[assembly: AssemblyCulture("")]
[assembly: ComVisible(false)]
//[assembly: Guid("")]
[assembly: AssemblyVersion(FrameFocus.BuildInfo.Version)]
[assembly: AssemblyFileVersion(FrameFocus.BuildInfo.Version)]
[assembly: NeutralResourcesLanguage("en")]
[assembly: MelonInfo(typeof(FrameFocus.Main),
    FrameFocus.BuildInfo.Name,
    FrameFocus.BuildInfo.Version,
    FrameFocus.BuildInfo.Author,
    FrameFocus.BuildInfo.DownloadLink)]
[assembly: MelonGame]