using MelonLoader;
using UnityEngine;
using UIExpansionKit.API;
using System.Collections;
using System;
using UnityEngine.XR;

namespace FrameFocus
{
    public static class BuildInfo
    {
        public const string Name = "FrameFocus"; // Name of the Mod.  (MUST BE SET)
        public const string Author = "KortyBoi"; // Author of the Mod.  (Set as null if none)
        public const string Company = null; // Company that made the Mod.  (Set as null if none)
        public const string Version = "1.0.0"; // Version of the Mod.  (MUST BE SET)
        public const string DownloadLink = "https://github.com/KortyBoi/FrameFocus"; // Download Link for the Mod.  (Set as null if none)
        public const string Description = "Allows your framerate to be limited while you are not focused on your game. Also doubles as a frame rate unlocker if you set your preferred max frame rate high enough.";
    }

    public class FrameFocus : MelonMod
    {
        private static MelonPreferences_Category melon;
        private static MelonPreferences_Entry<int> FrameLimit;
        private static MelonPreferences_Entry<bool> allowFrameLimit;
        private static MelonPreferences_Entry<bool> allowVRUse;

        public override void OnApplicationStart() // Runs after Game Initialization.
        {
            melon = MelonPreferences.CreateCategory(BuildInfo.Name, BuildInfo.Name);
            allowFrameLimit = (MelonPreferences_Entry<bool>)melon.CreateEntry("allowFrameLimit", false, "Toggle Frame Focus");
            FrameLimit = (MelonPreferences_Entry<int>)melon.CreateEntry("FrameLimit", 90, "Max Frame Limit");
            allowVRUse = (MelonPreferences_Entry<bool>)melon.CreateEntry("allowVRUse", false, "Allow VR to Limit FrameRate");
            MelonLogger.Msg("Initialized!");
        }

        public override void OnUpdate()
        {
            if (!allowFrameLimit.Value) // false
                return; // ends method
            else // true
            {
                if (XRDevice.isPresent && !allowVRUse.Value)
                    return;
                if (Application.isFocused) // isFocused = If you are controlling the game a.k.a. if your mouse has been pressed onto the game
                    Application.targetFrameRate = (int)FrameLimit.Value; // Sets game's FrameRate to Given Target FPS
                else
                    Application.targetFrameRate = (int)5; // Sets game's FrameRate to 5 FPS
            }
        }

        public override void OnPreferencesSaved() { MelonLogger.Msg("Preferences Saved!"); }
    }
}