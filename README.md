# Dungeon Game WPF

A roguelike dungeon crawler built from scratch using **C#** and **WPF** (Windows Presentation Foundation), following clean code principles and the **MVVM architecture pattern**.

## About This Project

This project is a personal learning exercise to deepen my understanding of:

- **C# and .NET development**
- **WPF framework** and XAML
- **MVVM (Model-View-ViewModel)** architectural pattern
- **Clean Code** principles and software design patterns
- **Procedural generation** algorithms
- **Game development** fundamentals

> **Note:** This entire project is built from scratch without tutorials or copy-pasting solutions. The goal is to learn by doing.

## Features

### Core Gameplay
- [ ] Procedurally generated dungeon levels
- [ ] Turn-based movement and combat
- [ ] Player progression (leveling, stats)
- [ ] Inventory and equipment system
- [ ] Various enemy types with different AI behaviors
- [ ] Item drops and loot system
- [ ] Fog of War exploration

### Technical Features
- [ ] MVVM architecture with clean separation of concerns
- [ ] Custom dungeon generation algorithm
- [ ] Save/Load game state (JSON serialization)
- [ ] Responsive UI with data binding
- [ ] Custom WPF controls and styles

## Architecture

This project follows the **MVVM pattern** for clean separation between UI and business logic:

```
DungeonGame/
├── Models/           # Data classes and game logic
│   ├── Entities/     # Player, Enemy, base Entity
│   ├── Items/        # Weapons, Armor, Consumables
│   ├── Dungeon/      # Tiles, Rooms, Floor/Map
│   └── Combat/       # Combat calculations
│
├── ViewModels/       # Presentation logic, commands
│   ├── BaseViewModel.cs
│   ├── GameViewModel.cs
│   └── ...
│
├── Views/            # XAML UI definitions
│   ├── Controls/     # Reusable UI components
│   └── Pages/        # Main game screens
│
├── Services/         # Game services (interfaces + implementations)
│   ├── DungeonGenerator
│   ├── CombatService
│   └── SaveService
│
├── Commands/         # ICommand implementations
├── Converters/       # WPF value converters
└── Resources/        # Images, sounds, styles
```

## Tech Stack

| Technology | Purpose |
|------------|---------|
| C# | Primary programming language |
| .NET 8 | Runtime framework |
| WPF | UI framework |
| XAML | UI markup language |
| System.Text.Json | Save/Load serialization |

## Getting Started

### Prerequisites

- Windows 10/11
- [.NET 8 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)
- Visual Studio 2022 (recommended) or VS Code with C# extension

### Installation

1. Clone the repository:
   ```bash
   git clone https://github.com/MrNovex/Dungeon-Game-WPF.git
   ```

2. Open the solution in Visual Studio:
   ```bash
   cd Dungeon-Game-WPF
   start DungeonGame.sln
   ```

3. Build and run (F5)

## Development Progress

### Phase 1: Project Setup & Foundation
- [ ] Create WPF project with folder structure
- [ ] Implement BaseViewModel (INotifyPropertyChanged)
- [ ] Implement RelayCommand (ICommand)
- [ ] Set up navigation system

### Phase 2: Data Models
- [ ] Entity system (Player, Enemy)
- [ ] Item system (Weapons, Armor, Consumables)
- [ ] Dungeon structure (Tiles, Rooms, Floor)

### Phase 3: Dungeon Generation
- [ ] Room placement algorithm
- [ ] Corridor connection
- [ ] Content population (enemies, items, traps)

### Phase 4: Player Movement & Interaction
- [ ] Keyboard input handling
- [ ] Collision detection
- [ ] Tile interactions (doors, chests, stairs)

### Phase 5: Combat System
- [ ] Damage calculation
- [ ] Enemy AI
- [ ] Turn-based combat flow
- [ ] Experience and leveling

### Phase 6: UI & Visualization
- [ ] Dungeon map rendering
- [ ] HUD (health, XP, level)
- [ ] Inventory UI
- [ ] Combat UI

### Phase 7: Save System
- [ ] Game state serialization
- [ ] Save/Load functionality

### Phase 8-10: Polish
- [ ] Audio system
- [ ] Game balancing
- [ ] Testing and bug fixes

## Screenshots

*Screenshots will be added as development progresses.*

## What I Learned

This section will be updated throughout development with key learnings:

- **MVVM Pattern:** *Coming soon...*
- **WPF Data Binding:** *Coming soon...*
- **Procedural Generation:** *Coming soon...*
- **Game Architecture:** *Coming soon...*

## License

This project is open source and available under the [MIT License](LICENSE).

## Contact

**Tim** - [@MrNovex](https://github.com/MrNovex)

Project Link: [https://github.com/MrNovex/Dungeon-Game-WPF](https://github.com/MrNovex/Dungeon-Game-WPF)

---

<p align="center">
  <i>Built with dedication to learning, one commit at a time.</i>
</p>
