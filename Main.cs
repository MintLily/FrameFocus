using MelonLoader;
using UnityEngine;
using System;
using UnityEngine.XR;
using FrameFocus.Utilities;

namespace FrameFocus
{
    public static class BuildInfo
    {
        public const string Name = "FrameFocus";
        public const string Author = "Lily";
        public const string Company = null;
        public const string Version = "1.4.0";
        public const string DownloadLink = "https://github.com/MintLily/FrameFocus";
        public const string Description = "FrameFocus is a computer performance enhancement game utility. This will allow you to gain a slight bit of performance while you are tabbed out of the game. When you are tabbed out, your frame rate will drop (this is to unfocusing the game, thus causing extra performance through out your computer). Once you tab back in, your frame rate will go back to normal. This mod also doubles as a frame rate unlocker of sorts. You can set a max target frame rate you would like the game to try and run at.";
    }

    public class FrameFocus : MelonMod
    {
        public static bool isDebug;
        public static MelonPreferences_Category melon;
        public static MelonPreferences_Entry<int> FrameLimit;
        public static MelonPreferences_Entry<int> FrameLimitUnfocused; // suggested by ljoonal
        public static MelonPreferences_Entry<bool> allowFrameLimit;
        public static MelonPreferences_Entry<bool> override_emmVRC;

        public override void OnApplicationStart() // Runs after Game Initialization.
        {
            if (Environment.CommandLine.Contains("--ff.debug") || MelonDebug.IsEnabled())
            {
                isDebug = true;
                MelonLogger.Msg("Debug mode is active");
            }
            
            melon = MelonPreferences.CreateCategory(BuildInfo.Name, BuildInfo.Name);
            allowFrameLimit = (MelonPreferences_Entry<bool>)melon.CreateEntry("allowFrameLimit", false, "Toggle Frame Focus");
            FrameLimit = (MelonPreferences_Entry<int>)melon.CreateEntry("FrameLimit", 90, "Max Focused Frame Limit");
            FrameLimitUnfocused = (MelonPreferences_Entry<int>)melon.CreateEntry("FrameLimitUnfocused", 5, "Unfocused Frame Limit"); // suggested by ljoonal
            override_emmVRC = (MelonPreferences_Entry<bool>)melon.CreateEntry("override_emmVRC", false, "Make FrameFocus ignore emmVRC integration (only works if emmVRC is detected)");

            //ModCompatibility.RunCompatibilityCheck();
            MelonLogger.Msg("Initialized!");
        }

        public override void VRChat_OnUiManagerInit()
        {
            MelonCoroutines.Start(ModCompatibility.RunCompatibilityCheck());
            MelonCoroutines.Start(StartLate.Init());
        }

        public override void OnUpdate()
        {
            StartLate.OnUpdate();
        }

        public override void OnPreferencesSaved() 
        {
            MelonLogger.Msg("Preferences Saved!");
            if (isDebug)
                MelonLogger.Msg("[Debug] \n" +
                    " ================= Preferences Values: ============== \n" +
                    " ============== int  FrameLimit          = " + FrameLimit.Value.ToString() + "\n" +
                    " ============== int  FrameLimitUnfocused = " + FrameLimitUnfocused.Value.ToString() + "\n" + // suggested by ljoonal
                    " ============== bool allowFrameLimit     = " + allowFrameLimit.Value.ToString() + "\n" +
                    " ============== bool override_emmVRC     = " + override_emmVRC.Value.ToString() + "\n" +
                    " ====================================================");
        }
    }
}