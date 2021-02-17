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
[assembly: MelonInfo(typeof(FrameFocus.FrameFocus),
    FrameFocus.BuildInfo.Name,
    FrameFocus.BuildInfo.Version,
    FrameFocus.BuildInfo.Author,
    FrameFocus.BuildInfo.DownloadLink)]

//[assembly: MelonOptionalDependencies("", "", "", "")]
// Create and Setup a MelonModGame to mark a Mod as Universal or Compatible with specific Games.
// If no MelonModGameAttribute is found or any of the Values for any MelonModGame on the Mod is null or empty it will be assumed the Mod is Universal.
// Values for MelonModGame can be found in the Game's app.info file or printed at the top of every log directly beneath the Unity version.
[assembly: MelonGame("VRChat", "VRChat")]