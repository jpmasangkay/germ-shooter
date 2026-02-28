# 🦠 GERM SHOOTER
[![Ask DeepWiki](https://devin.ai/assets/askdeepwiki.png)](https://deepwiki.com/jpmasangkay/germ-shooter)

### Unity Shooter Game

**Aim. Fire. Eliminate.**

A fast-paced shooter game built in Unity where your mission is to blast waves of germs before they overwhelm you. Armed with custom shaders and tight gameplay mechanics, Germ Shooter delivers satisfying, action-packed combat against microscopic enemies.

[![Unity](https://img.shields.io/badge/Unity-000000?style=for-the-badge&logo=unity&logoColor=white)](https://unity.com)
[![C#](https://img.shields.io/badge/C%23-239120?style=for-the-badge&logo=csharp&logoColor=white)](https://learn.microsoft.com/en-us/dotnet/csharp/)
[![ShaderLab](https://img.shields.io/badge/ShaderLab-HLSL-5C2D91?style=for-the-badge&logo=unity&logoColor=white)](https://docs.unity3d.com/Manual/SL-Reference.html)

---

## ✨ Features

### 🎯 Core Gameplay

- Shoot down waves of **germ enemies** in a high-energy shooter experience
- Responsive **player controls** with smooth aiming and firing mechanics
- Escalating difficulty — enemies grow stronger, faster, and more numerous as you progress
- A **score system** that rewards accuracy and speed

### 👾 Enemies

- Multiple **germ and microbe enemy types**, each with unique movement and attack patterns
- Enemies spawn in waves, keeping constant pressure on the player
- Distinct visual designs powered by **custom Unity shaders** for a stylized biological aesthetic

### 💥 Combat & Weapons

- Responsive shooting with satisfying visual and audio feedback
- Projectile-based combat with collision detection handled by Unity's physics engine
- Enemy hit reactions and destruction effects for impactful gameplay

### 🎨 Visuals & Shaders

- Custom **ShaderLab + HLSL shaders** for stylized enemy and environment rendering
- Visual effects that bring the microscopic world to life
- Polished sprites and animations managed through Unity's Asset pipeline

### 🔊 Audio

- Sound effects for shooting, enemy hits, and destruction
- Background music to reinforce the tense, fast-paced atmosphere

---

## 🛠️ Tech Stack

| Technology | Purpose |
|-----------|---------|
| **Unity** | Game engine — rendering, physics, input, and scene management |
| **C#** | All gameplay logic, enemy AI, player controller, and game systems |
| **ShaderLab** | Unity's shader language for writing custom material shaders |
| **HLSL** | Low-level GPU shader code for custom visual effects |
| **Unity Package Manager** | Dependency management via the `Packages/` manifest |

---

## 🚀 Getting Started

### Prerequisites

- [Unity Hub](https://unity.com/download) with a compatible **Unity Editor** installed
- The exact Unity version used by this project can be found in `ProjectSettings/ProjectVersion.txt`

### Installation

```bash
# Clone the repository
git clone https://github.com/jpmasangkay/germ-shooter.git
cd germ-shooter
```

### Opening the Project

1. Open **Unity Hub**
2. Click **Open** → **Add project from disk**
3. Select the cloned `germ-shooter` folder
4. Unity will import all assets and compile scripts automatically
5. Once loaded, open the main scene from the `Assets/` folder and press **▶ Play**

---

## 📁 Project Structure

```
germ-shooter/
├── Assets/                     # All game content
│   ├── Scripts/                # C# gameplay scripts
│   │   ├── Player/             # Player controller, shooting, health
│   │   ├── Enemies/            # Germ AI, movement, wave spawning
│   │   ├── UI/                 # HUD, score display, game over screen
│   │   └── Managers/           # Game manager, audio manager, scene control
│   ├── Scenes/                 # Unity scene files (.unity)
│   ├── Prefabs/                # Reusable enemy, bullet, and effect prefabs
│   ├── Sprites/                # 2D art assets for player, germs, and environment
│   ├── Audio/                  # Sound effects and background music
│   ├── Shaders/                # Custom ShaderLab / HLSL shader files
│   └── Materials/              # Materials referencing the custom shaders
├── Library/                    # Unity-generated import cache (not committed)
├── Packages/                   # Unity Package Manager manifest & lock file
├── ProjectSettings/            # Unity project configuration
│   └── ProjectVersion.txt      # Unity Editor version used
├── UserSettings/               # Local user-specific Unity preferences
├── .gitattributes
└── .gitignore
```

---

## 🧠 How It Works

Germ Shooter is built on Unity's **component-based architecture**, with each game system cleanly separated into C# MonoBehaviour scripts:

1. **Player Controller** — Handles movement input and translates it into smooth character motion. A dedicated shooting script listens for fire input, instantiates bullet prefabs, and applies directional force via Unity's physics engine.

2. **Enemy AI** — Each germ enemy type has its own script defining speed, movement behaviour (patrol or chase), and attack logic. A central **Wave Spawner** manages spawn timing, enemy counts, and difficulty scaling across rounds.

3. **Collision & Damage System** — Unity's `OnTriggerEnter2D` / `OnCollisionEnter2D` callbacks handle bullet-to-enemy and enemy-to-player interactions, triggering hit reactions, health deduction, and destruction effects.

4. **Custom Shaders** — ShaderLab and HLSL shaders define the visual style of enemies and effects — achieving a stylized biological look that makes germ entities feel distinct and alive without relying solely on static sprites.

5. **Game Manager** — A singleton `GameManager` coordinates global state: tracking score, managing lives, triggering wave progressions, and transitioning between gameplay, pause, and game-over states.

---

## 🎮 How to Play

1. **Launch the game** in the Unity Editor or run a built executable
2. **Move** your character to dodge incoming germs
3. **Aim and shoot** to destroy germ enemies before they reach you
4. **Survive the waves** — each round spawns more and tougher enemies
5. **Beat your high score** — the longer you survive and the more germs you eliminate, the higher your score

---
