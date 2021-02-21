using Newtonsoft.Json;
using System;
using System.IO;
using MelonLoader;

namespace FrameFocus.Utilities
{
    public class emmVRCConfig
    {
        public bool UnlimitedFPSEnabled { get; set; }
        public int FPSLimit { get; set; }
    }

    public class GETemmVRCconfig
    {
        private static string config = Path.Combine(Environment.CurrentDirectory, "UserData/emmVRC/config.json");

        private static emmVRCConfig _Config { get; set; }

        public static void LoadConfig() 
        { 
            _Config = JsonConvert.DeserializeObject<emmVRCConfig>(File.ReadAllText(config));
            if (FrameFocus.isDebug)
                MelonLogger.Msg("[Debug] Finished loading emmVRC's config for the following values: bool UnlimitedFPSEnabled ; int FPSLimit");
        }

        public static emmVRCConfig ReadConfig() { return _Config; }
    }
}
