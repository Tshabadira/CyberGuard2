# 🛡 CyberGuard — Cybersecurity Awareness Chatbot

A console-based C# chatbot that educates users on cybersecurity topics through interactive conversation, colour-coded UI, ASCII art, and voice greeting.

---

## 📋 About

CyberGuard is a cybersecurity awareness assistant built in C#. It guides users through key online safety topics using a menu-driven and keyword-responsive chat interface. The bot personalises every interaction using the user's name and provides multiple levels of detail on each topic.

---

## 🚀 How to Run

### Requirements
- Windows OS
- [.NET 6.0 SDK](https://dotnet.microsoft.com/download) or later
- Visual Studio 2022 (recommended) or VS Code with C# extension

### Steps
1. Clone the repository:
   ```bash
   git clone https://github.com/Tshabadira/CyberGuard2.git
   ```
2. Open `CyberGuard1.sln` in Visual Studio
3. Build the solution: **Build → Build Solution** (or `Ctrl+Shift+B`)
4. Run the project: Press **F5** or click **Run**
5. *(Optional)* Place a `welcome.wav` file in the output folder (`bin/Debug/`) to enable voice greeting

---

## 💬 Features

| Feature | Description |
|---|---|
| 🔊 Voice Greeting | Plays a welcome audio message on startup |
| 🎨 ASCII Art Banner | Displays a styled CyberGuard logo in the console |
| 👤 Name Validation | Validates user name (letters and spaces only, 2–30 chars) |
| 🛡 7 Cyber Topics | Password safety, phishing, safe browsing, malware, 2FA, social engineering, public Wi-Fi |
| 🔍 Deep Info | Type `more` after any topic for advanced tips |
| 📝 Simple Summary | Type `simple` after any topic for a one-line recap |
| 🎨 Colour-coded UI | Each type of output has its own colour for readability |
| ⌨ Typing Animation | Bot responses appear with a typewriter effect |
| ✅ Input Validation | Handles empty input, unknown commands, and invalid names |

---

## 🗂 Project Structure

```
CyberGuard2/
├── .github/
│   └── workflows/
│       └── dotnet.yml        # GitHub Actions CI workflow
├── CyberGuard1/
│   ├── Program.cs            # Entry point — startup sequence and name validation
│   ├── Chatbot.cs            # Core chatbot logic and response handling
│   ├── VoiceGreeting.cs      # Audio greeting handler
│   └── CyberGuard1.csproj    # Project file
├── CyberGuard1.sln           # Solution file
├── .gitignore
├── .gitattributes
└── README.md
```

---

## 🧠 Topics Covered

1. 🔑 **Password Safety** — Strong passwords, password managers, avoiding reuse
2. 🎣 **Phishing** — Identifying fake emails, links, and urgent scam messages
3. 🌐 **Safe Browsing** — HTTPS, browser updates, avoiding unsafe downloads
4. 🦠 **Malware** — Types of malware, antivirus, and backup strategies
5. 🔐 **Two-Factor Authentication** — Why 2FA matters and which methods are safest
6. 🎭 **Social Engineering** — Manipulation tactics and how to spot them
7. 📶 **Public Wi-Fi** — Risks of public networks and VPN usage

---

## ⚙ CI/CD

This project uses **GitHub Actions** to automatically build the solution on every push to `master`.

Workflow file: `.github/workflows/dotnet.yml`

---

## 👤 Author

**Lazarus Tshabadira Motsalane** — PROG6221 Portfolio of Evidence
