# KalOnline Quest Tracker

A modern, dark-themed quest tracker application for KalOnline with comprehensive quest management and character progress tracking.

## Features

### 🎯 Quest Management
- **Complete Quest Database**: Loads all quests from QuestsData.json
- **Smart Filtering**: Filter by quest type (QUEST/EVENT) and completion status
- **Level-based Organization**: Quests sorted by level, type, and ID
- **Visual Completion Status**: Completed quests shown in green with checkmarks

### 🎨 Modern Dark UI
- **Dark Theme**: Professional dark color scheme throughout
- **Colored Text Parsing**: Automatic color coding for different elements:
  - 🔵 **NPCs and Characters** (in quotes) - Light Blue
  - 🟠 **Items** (quest items, drops) - Orange  
  - 🔴 **Monsters** (after "by") - Red
  - 🔵 **Locations** (cities, areas) - Cyan
  - 🟣 **Special Characters** (in brackets) - Magenta

### 👤 Character Profiles
- **Character Management**: Save/load character profiles with quest progress
- **Auto-save**: Automatically saves progress when closing the application
- **Profile Persistence**: JSON-based profile storage in Profiles folder
- **Multiple Characters**: Support for multiple character profiles

### ✅ Quest Completion Tracking
- **Completion Checkbox**: Use the "✓ Completed" checkbox in quest details to mark quests as done
- **Double-click Alternative**: Double-click any quest in the list to toggle completion
- **Visual Feedback**: Completed quests highlighted in green with checkmarks
- **Progress Persistence**: Quest completion status saved with character profile
- **Easy Toggle**: Check/uncheck the completion checkbox or double-click to toggle

## How to Use

### Getting Started
1. **Launch the Application**: Run the KalOnline Quest Tracker
2. **Enter Character Name**: Type your character name in the top field
3. **Browse Quests**: Use the quest list on the left to browse available quests
4. **View Details**: Click on any quest to see detailed steps and rewards

### Managing Quest Progress
1. **Mark as Complete**:
   - Use the "✓ Completed" checkbox in the quest details panel, OR
   - Double-click on any quest in the list to toggle completion
2. **View Completed**: Completed quests appear in green with a ✓ checkmark
3. **Filter Options**: Use "Show Completed" checkbox to hide/show completed quests
4. **Quest Types**: Filter by "All Types", "QUEST", or "EVENT"

### Character Profiles
1. **Auto-save**: Progress is automatically saved when you close the application
2. **Manual Save**: Click "Save Profile" to manually save your progress
3. **Load Profile**: Click "Load Profile" to load a previously saved character
4. **Multiple Characters**: Create different profiles for different characters

### Quest Information Display
- **Steps**: Detailed quest steps with color-coded elements
- **Rewards**: List of quest rewards (experience, items, etc.)
- **Level Requirements**: Quest level requirements clearly displayed
- **Quest Types**: Visual distinction between regular quests and events

## File Structure
```
Kal Quests Tracker/
├── QuestsData.json          # Quest database (included)
├── Profiles/                # Character profiles (auto-created)
│   └── [CharacterName].json # Individual character progress files
├── Models/                  # Data models
├── Utils/                   # JSON parsing utilities
└── bin/Debug/              # Compiled application
```

## Technical Features
- **Custom JSON Parser**: No external dependencies required
- **Regex-based Text Parsing**: Intelligent color coding of quest text
- **Owner-drawn ListBox**: Custom rendering for quest completion status
- **Automatic Sorting**: Quests organized by level and type
- **Error Handling**: Robust error handling for file operations

## Tips
- Double-click quests to quickly mark them as complete/incomplete
- Use the quest type filter to focus on specific quest types
- Character profiles are automatically saved when you close the application
- The quest details panel shows color-coded information for easy reading
- Completed quests can be hidden using the "Show Completed" checkbox


### Building the Application

1. **Install Newtonsoft.Json Package**:
   - Open the solution in Visual Studio
   - Right-click on the project in Solution Explorer
   - Select "Manage NuGet Packages"
   - Search for "Newtonsoft.Json" and install version 13.0.3

2. **Build the Project**:
   - Press `Ctrl+Shift+B` to build the solution
   - Or go to Build → Build Solution

3. **Run the Application**:
   - Press `F5` to run with debugging
   - Or press `Ctrl+F5` to run without debugging
   - Or use the "Run Quest Tracker.bat" file after building

## Requirements
- Windows with .NET Framework 4.8
- Visual Studio 2019+ (for building)
- Newtonsoft.Json 13.0.3 package
- QuestsData.json file in the application directory

Enjoy tracking your KalOnline quest progress! 🎮

---
