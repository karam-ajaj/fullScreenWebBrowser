# 🖥️ FullScreen Web Browser

**A C# application designed for full-screen web monitoring using the WebBrowser control.**

This project provides a simple and efficient solution for displaying web content in full-screen mode, ideal for kiosks, digital signage, or monitoring dashboards.

---

## 📌 Features

- **Full-Screen Display**: Launches the application in full-screen mode without window borders or controls.
- **Customizable URL**: Easily set the desired URL to be displayed.
- **Auto-Refresh**: Optionally refresh the page at set intervals.
- **Minimal UI**: Clean interface focused solely on displaying web content.

---

## 🛠️ Getting Started

### Prerequisites

- Windows OS
- [.NET Framework](https://dotnet.microsoft.com/en-us/download/dotnet-framework) (version compatible with the project)

### Installation

1. **Clone the repository**:

   ```bash
   git clone https://github.com/karam-ajaj/fullScreenWebBrowser.git
   ```

2. **Open the solution**:

   Open `test_full.sln` in Visual Studio.

3. **Build and run**:

   Build the solution and run the application.

---

## ⚙️ Configuration

To set the URL or adjust settings:

1. Open the main form file (e.g., `MainForm.cs`).
2. Locate the section where the WebBrowser control is initialized.
3. Modify the URL or settings as needed.

---

## 📁 Project Structure

```
fullScreenWebBrowser/
├── test_full.sln           # Visual Studio solution file
├── test_full/              # Main project directory
│   ├── MainForm.cs         # Main form with WebBrowser control
│   ├── Program.cs          # Application entry point
│   └── ...                 # Other project files
├── README.md               # Project documentation
└── ...                     # Additional files and directories
```

---

## 🧩 Customization

Feel free to modify the application to suit your specific needs:

- **Change the default URL**: Set your preferred default web page.
- **Adjust refresh intervals**: Implement timers to refresh the page periodically.
- **Add navigation controls**: Include buttons or menus for navigation if required.

---

## 🤝 Contributing

Contributions are welcome! Please fork the repository and submit a pull request with your enhancements.

---

## 📄 License

This project is licensed under the [MIT License](LICENSE).

---

## 📬 Contact

For questions or support, please open an issue on the [GitHub repository](https://github.com/karam-ajaj/fullScreenWebBrowser/issues).
