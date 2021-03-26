# FrameFocus
FrameFocus is a computer performance enhancement game utility. This will allow you to gain a slight bit of performance while you are tabbed out of the game. When you are tabbed out, your frame rate will drop (this is to unfocusing the game, thus causing extra performance through out your computer). Once you tab back in, your frame rate will go back to normal. This mod also doubles as a frame rate unlocker of sorts. You can set a max target frame rate you would like the game to try and run at.

### MelonLoader
Need to install MelonLoader?<br>
Click [this link](https://melonwiki.xyz/) to get started!

### Prerequisites
MelonLoader: v0.3.0 (Alpha)<br>
Game: VRChat (2021.1.2(p1) [build 1046 - 1048])<br>

### Optional Prerequisites
[UIExpansionKit](https://github.com/knah/VRCMods)<br>
[emmVRC](https://discord.gg/emmvrc)

### MelonPreferences (Default Values)
```
[FrameFocus]
allowFrameLimit = false
FrameLimit = 90
FrameLimitUnfocused = 5
allowVRUse = false
override_emmVRC = false
```
<br>
allowFrameLimit - (Main Toggle) Toggle the framerate when the application is focused or not<br>
FrameLimit - sets game's Frame Rate<br>
FrameLimitUnfocused - sets game's Frame Rate when unfocused<br>
allowVRUse - Allows the function to be used with VR Mode<br>
override_emmVRC - Make FrameFocus ignore emmVRC integration (only works if emmVRC is detected)

### Preview
![Preview GIF](https://kortyboi.com/img/upload/QQscYMB2ho.gif)<br>
*White Top Bar = unfocused (5 FPS)*<br>
*Black Top Bar = focused (user set 145 FPS)*

# Change Log
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



## Stay Updated
Stay update to date with all my mods by joining my [discord server](https://discord.gg/qkycuAMUGS) today.
