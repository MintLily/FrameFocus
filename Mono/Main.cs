using MelonLoader;
using FrameFocus.Utilities;

namespace FrameFocus;

public static class BuildInfo {
    public const string Name = "FrameFocus";
    public const string Author = "Lily";
    public const string Company = "Minty Labs";
    public const string Version = "1.5.0";
    public const string DownloadLink = "https://github.com/MintLily/FrameFocus";
    public const string Description = "FrameFocus is a computer performance enhancement game utility. This will allow you to gain a slight bit of performance while you are tabbed out of the game. When you are tabbed out, your frame rate will drop (this is to unfocusing the game, thus causing extra performance through out your computer). Once you tab back in, your frame rate will go back to normal. This mod also doubles as a frame rate unlocker of sorts. You can set a max target frame rate you would like the game to try and run at.";
}

public class Main : MelonMod {
    private static MelonPreferences_Category _melon;
    public static MelonPreferences_Entry<int> FrameLimit;
    public static MelonPreferences_Entry<int> FrameLimitUnfocused; // suggested by ljoonal
    public static MelonPreferences_Entry<bool> AllowFrameLimit;
    // public static MelonPreferences_Entry<bool> override_emmVRC;

    public override void OnApplicationStart() {
        _melon = MelonPreferences.CreateCategory(BuildInfo.Name, BuildInfo.Name);
        AllowFrameLimit = _melon.CreateEntry("allowFrameLimit", false, "Toggle Frame Focus");
        FrameLimit = _melon.CreateEntry("FrameLimit", 120, "Max Focused Frame Limit");
        FrameLimitUnfocused = _melon.CreateEntry("FrameLimitUnfocused", 5, "Unfocused Frame Limit"); // suggested by ljoonal
        // override_emmVRC = melon.CreateEntry("override_emmVRC", false, "Make FrameFocus ignore emmVRC integration (only works if emmVRC is detected)");

        // MelonCoroutines.Start(ModCompatibility.RunCompatibilityCheck());
        MelonCoroutines.Start(StartLateUtil.Init());
        MelonLogger.Msg("Initialized!");
    }

    public override void OnUpdate() => StartLateUtil.RunOnUpdate();
}