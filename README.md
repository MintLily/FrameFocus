# FrameFocus
FrameFocus is a computer performance enhancement game utility. This will allow you to gain a slight bit of performance while you are tabbed out of the game. When you are tabbed out, your frame rate will drop (this is to unfocusing the game, thus causing extra performance through out your computer). Once you tab back in, your frame rate will go back to normal. This mod also doubles as a frame rate unlocker of sorts. You can set a max target frame rate you would like the game to try and run at.
<br>
<b>Note:</b><br>
V-Sync <u>must</u> be turned off for this mod to properly work.<br>
<br>
Works on both Mono and IL2CPP games.

### MelonLoader
Need to install MelonLoader?<br>
Click [this link](https://melonwiki.xyz/) to get started!

### Prerequisites
MelonLoader: v0.5.4 or above

### Tested Games
- BONEWORKS
- VRChat (EAC Prevention)
- Risk of Rain 2
- NeosVR
- Arizona Sunshine
- VTOL VR
- SynthRiders
- Audica
- The Long Dark
- Job Simlulator & Vacation Simulator
- BTD 6
- ChilloutVR

### Unknown / Not Tested
- Phasmophobia
- Blade & Sorcery
- The Forest
- Eden Rising
- Ultimate Epic Battle Simulator
- Totally Accurate Battle Simulator
- SCP Unity
- H3VR
- Pistol Whip

### MelonPreferences (Default Values)
```ini
[FrameFocus]
allowFrameLimit = false
FrameLimit = 120
FrameLimitUnfocused = 5
```
<br>
allowFrameLimit - (Main Toggle) Toggle the framerate when the application is focused or not<br>
FrameLimit - sets game's Frame Rate<br>
FrameLimitUnfocused - sets game's Frame Rate when unfocused

### Preview
![Preview GIF](https://kortyboi.com/img/upload/QQscYMB2ho.gif)<br>
*White Top Bar = unfocused (5 FPS)*<br>
*Black Top Bar = focused (user set 145 FPS)*

# Change Log
### v1.5.1
* Added detection for V-Sync options

### v1.5.0
* Added both Mono and IL2CPP builds
* Updated for MelonLoader v0.5.4
* Removed (VRChat mod) emmVRC mod compatibility

### v1.4.1
* v1.4.0 was still only hooking into VRChat, this update fixes that. Now works in all game running with ML v0.3.0+

### v1.4.0
* Mod is not a universal mod for ML v0.3.0+

### v1.3.0
* Removed VR Usage

### v1.2.0
* Added `FrameLimitUnfocused` to set your unfocused framerate - suggested by [ljoonal](https://github.com/KortyBoi/FrameFocus/pull/1)

### v1.1.1
* Changed order of methods loading to fix an error caused by a lack of emmVRC config file
* ModCompatibility will load after 5 seconds on VRChat_OnUiManagerInit to give enough time for emmVRC to create a config file if you're running emmVRC for the first time
* OnUpdate will not start until 6 seconds after VRChat_OnUiManagerInit

### v1.1.0
* Added emmVRC integration.
* Made New Description of mod

### v1.0.0
* Initial Release
