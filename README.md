# IDM Trial Activation Support Tool

🎯 **A support tool for Internet Download Manager (IDM) trial activation**

Windows Forms application that helps activate IDM trial through 2 methods: **Advanced Mode** (download activation tool) and **Basic Mode** (run PowerShell script).

## ✨ Features

### 🔍 Check IDM Installation
- Automatically detect if IDM is installed
- Display installation status clearly
- Download IDM if not installed

### 🚀 2 Activation Modes

#### 1️⃣ **Advanced Mode** (🔧 Professional)
- Download IDM Freezer activation tool from GitHub
- Automatically run the tool
- Form closes after tool launches

#### 2️⃣ **Basic Mode** (⚡ Simple)  
- Run PowerShell activation script
- Run silently in background
- Form closes when script completes

### 💰 Donate
- Donation form with Techcombank transfer information
- Copy account number in 1 click
- Support project development

### ℹ️ System Information
- Display OS version
- Display .NET Framework version

## 🛠️ Technology Stack

- **Language**: C# 7.3
- **Framework**: .NET Framework 3.5
- **UI**: Windows Forms
- **Tools**: Visual Studio 2026

## 📋 Requirements

- Windows 7+
- .NET Framework 3.5 or higher
- PowerShell (for Basic Mode)
- Internet connection (for downloads)

## 🚀 Installation & Usage

### Clone Project
```bash
git clone https://github.com/yourusername/frmidmactive.git
cd frmidmactive
```

### Build & Run
1. Open `frmidmactive.sln` in Visual Studio
2. Build solution: `Ctrl + Shift + B`
3. Run: `F5` or `Ctrl + F5`

### Usage
1. **Check IDM**: Application automatically detects if IDM is installed
2. **Download IDM** (if not installed): Click "Download IDM" button
3. **Choose Activation Method**:
   - 🔧 **Advanced**: Check checkbox → Tool downloads & runs → Form closes
   - ⚡ **Basic**: Check checkbox → PowerShell script runs → Form closes
4. **Donate** (optional): Click "❤ Donate" button to see transfer information

## 📁 Project Structure

```
frmidmactive/
├── Form2.cs                 # Main form logic
├── Form2.Designer.cs        # Form UI design
├── DonateForm.cs            # Donate form logic
├── DonateForm.Designer.cs   # Donate form UI
├── Constants.cs             # Application constants
├── Helpers/
│   ├── IconGenerator.cs     # Generate app icon
│   ├── IDMChecker.cs        # IDM detection
│   └── DownloadManager.cs   # File download manager
├── .gitignore              # Git ignore rules
├── README.md               # This file
└── LICENSE                 # MIT License
```

## 🔑 Key Features

### SSL/TLS Fix
- Support TLS 1.2 for .NET 3.5
- Download from GitHub without SSL errors

### Retry Logic
- Retry running tool 3 times if locked
- Exponential backoff delay

### UI/UX
- Material Design colors
- Progress bar feedback
- Auto-close form when done
- Checkbox enable/disable logic

## 🐛 Troubleshooting

### Download SSL error?
- ✅ Fixed: `ServicePointManager.SecurityProtocol = TLS 1.2`

### Tool won't run?
- ✅ Retry logic: Try 3 times with delay
- ✅ Check file exists before running

### PowerShell script error?
- ✅ `CreateNoWindow = true`: Run silently
- ✅ `WaitForExit()`: Wait for script to complete properly

## 📝 License

MIT License - See `LICENSE` file for details

## 👨‍💻 Contributing

Pull requests welcome! Please:
1. Fork the project
2. Create feature branch (`git checkout -b feature/AmazingFeature`)
3. Commit changes (`git commit -m 'Add AmazingFeature'`)
4. Push to branch (`git push origin feature/AmazingFeature`)
5. Open Pull Request

## 📧 Contact

- **Email**: [your-email@example.com]
- **GitHub**: [@yourusername](https://github.com/yourusername)
- **Donate**: Techcombank - 19034076619118 (Nguyễn Minh Thành)

## ⭐ Show your support

Give a ⭐ if this project helped you!

---

**Made with ❤️ by [Your Name]**
