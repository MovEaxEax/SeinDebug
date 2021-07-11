# SeinDebug
Extented debug modification for Ori and the Blind Forest: Defenitive Edition

Replace the Assembly-CSharp.dll with your one in the "../steam/steamapps/common/Ori DE/oriDE_DataOri/Managed" folder. Make sure to backup you old one, so you can deactivate it again if you want to.

Ingame you open the Debug Menu with NUMPAD_0 or with F10. Navigate with mouseclicks on what you want.

The Mod creates a settings file for keybinding in "../steam/steamapps/common/Ori DE/xNyuDebug/key_settings.txt", where you can set specific functions for your hotkeys with parameter and stuff. List of all available functions are listed in the KeyFunctions.txt.

If you want to create you own Assembly, the source code is available in this repo too, but it's a hell of a mess, so I don't recommend to evolve this code further. Anyway, in the "Ori Mod Activator.txt" is the class where i patched the xnyuDebugMenu class into.

I patched out the requirement for the normal Debug Menu out, so no need for "C:/Temp/MoonDbg.txt".

![Debugger-debugtext](https://user-images.githubusercontent.com/59608685/125210745-087e3400-e2a2-11eb-80b1-484cb93e1c12.jpg)
![Debugger-details](https://user-images.githubusercontent.com/59608685/125210746-0916ca80-e2a2-11eb-9c54-1272c1e787af.jpg)
![Debugger-menu](https://user-images.githubusercontent.com/59608685/125210747-09af6100-e2a2-11eb-95c8-c5bf7f34350f.jpg)
