# PROG_PART1
# 🤖 CyberAwarenessBot

CyberAwarenessBot is a C# console application designed to promote cybersecurity awareness through interactive voice greetings, ASCII art, and random safety tips. The bot also includes input validation and is integrated with GitHub Actions for continuous integration checks.

---

## 📂 Project Structure
CyberAwarenessBot/
├── .github/
│   └── workflows/
│       └── ci.yml              # GitHub Actions CI workflow
├── Assets/
│   ├── greeting.wav            # Voice greeting audio file
│   └── ci-passed.png           # Screenshot of successful CI run
├── bin/                        # Compiled binaries
├── obj/                        # Build object files
├── Program.cs                  # Main application logic
├── CyberAwarenessBot.sln       # Visual Studio solution file
└── README.md                   # Project documentation

## 🔧 Features

- 🎤 **Voice Greeting:** Plays an audio message to welcome users.
- 🖼️ **ASCII Art:** Displays themed ASCII art upon startup.
- 💬 **Random Cybersecurity Tips:** Shows random tips to help users stay safe online.
- 🔐 **Input Validation:** Ensures secure and clean user inputs.
- ⚙️ **GitHub CI:** Integrated with GitHub Actions to run automated checks.

---

## 🚀 How to Run

1. Clone the repository:
   ```bash
   git clone https://github.com/ST10445541/PROG_PART1.git
   cd PROG_PART1
   ____      _            ____        _   
  / ___|__ _| | ___ _   _| __ )  ___ | |_ 
 | |   / _` | |/ __| | | |  _ \ / _ \| __|
 | |__| (_| | | (__| |_| | |_) | (_) | |_ 
  \____\__,_|_|\___|\__, |____/ \___/ \__|
                    |___/                
