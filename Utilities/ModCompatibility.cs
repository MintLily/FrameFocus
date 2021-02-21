using MelonLoader;

namespace FrameFocus.Utilities
{
    class ModCompatibility
    {
        public static bool emmVRC;

        public static void RunCompatibilityCheck()
        {
            if ((MelonHandler.Mods.FindIndex((MelonMod i) => i.Info.Name == "emmVRCLoader") != -1) || 
                MelonHandler.Mods.FindIndex((MelonMod i) => i.Info.Name == "emmVRC") != -1)
            {
                emmVRC = true;
                if (FrameFocus.isDebug)
                    MelonLogger.Msg("[Debug] Detected emmVRC, I will be using emmVRC's config for values.");
                GETemmVRCconfig.LoadConfig();
            }
        }
    }
}
