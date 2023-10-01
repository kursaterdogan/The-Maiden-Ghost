# The-Maiden-Ghost

# About
The Maiden Ghost is a text-based game prototype based on "The Shepherd and The Maiden Ghost" by Empyrium.

The game utilizes C# and Unity.

# How To Build/Run
1. Clone the repository into local
```bash
$> git clone https://github.com/kursaterdogan/The-Maiden-Ghost.git
```
2. Install Unity Hub from https://unity.com/download
3. In the Projects tab, select Open and navigate to the cloned repository. Select the entire folder and open in Unity.
4. Once prompted, install Unity Version 2020.3.20f1 through the installer
5. Once the correct version of Unity has been installed, open the game in Unity editor and use the keyboard shortcut Ctrl + B to build and open the project. You should now be able to play the game.

# Project Structure
Below is an overview of the project structure with brief summaries for each of the subdirectories to help with understanding where core components of the game are located.

```bash
src/
├── Assets/
│   ├── Fonts (directory for funts)
│   ├── Prefabs (components for Canvas and StateController)
│   ├── Scenes (not utilized)
│   ├── Scripts (scripts for controlling which game state the player is currently on)
│   ├── States (each state represents an individual page of text the player can view)
│   ├── TextMesh Pro (utilized for text)
│   ├── Screenshots (screenshots of each text page)
│   ├── ProjectSettings (unity base settings)
│   └── Packages
```

# Game Screenshots
<img src="https://github.com/kursaterdogan/The-Maiden-Ghost/blob/master/Screenshots/Screenshot%200.png" width="242" height="430">

# Contributors
This game was created by Kürşat Erdoğan.
