namespace frmidmactive
{
    /// <summary>
    /// Global constants for the application
    /// </summary>
    public static class AppConstants
    {
        // Registry paths
        public const string NET35_REGISTRY_PATH = @"SOFTWARE\Microsoft\NET Framework Setup\NDP\v3.5";
        public const string IDM_REGISTRY_PATH = @"Software\Classes\Applications\IDMan.exe";

        // File paths
        public const string IDM_PATH_X86 = @"C:\Program Files (x86)\Internet Download Manager\IDMan.exe";
        public const string IDM_PATH_X64 = @"C:\Program Files\Internet Download Manager\IDMan.exe";

        // Download URLs
        public const string IDM_DOWNLOAD_URL = "https://download.internetdownloadmanager.com/idman642build63.exe";

        // IDM Messages
        public const string IDM_INSTALLED = "✓ IDM is installed on your computer";
        public const string IDM_NOT_INSTALLED = "✗ IDM is not installed";
        public const string IDM_DOWNLOADING = "Downloading IDM...";
        public const string DOWNLOAD_PROGRESS = "Downloading... {0}%";
        public const string DOWNLOAD_COMPLETED = "✓ Download completed. Installing...";
        public const string DOWNLOAD_FAILED = "✗ Download failed: {0}";
        public const string INSTALLATION_STARTED = "Installation Started";
        public const string INSTALLATION_STARTED_MESSAGE = "The installer has started.\nPlease complete the installation and then restart the application.";
        public const string ERROR_RUNNING_INSTALLER = "Error running installer: {0}";

        // Activation URLs
        public const string ADVANCED_ACTIVATION_URL = "https://github.com/zinzied/IDM-Freezer-Activation-Tool/releases/download/v5.5.0/IDM.Freezer.Activation.Tool.v5.5.0.x64.exe";
        public const string BASIC_ACTIVATION_CMD = "iwr -useb https://raw.githubusercontent.com/hanmaoye/IDM-Activation-Script/main/IAS.ps1 | iex";

        // .NET 3.5 Messages
        public const string NET35_ENABLED_MESSAGE = ".NET 3.5 is enabled!";
        public const string NET35_DISABLED_MESSAGE = ".NET 3.5 is not enabled";
        public const string NET35_NOT_ENABLED_TITLE = "NET 3.5 Not Enabled";
        public const string NET35_ENABLE_PROMPT = ".NET Framework 3.5 is not enabled.\n\nDo you want to enable it?";
        public const string NET35_ENABLE_INSTRUCTION = "Please enable .NET Framework 3.5 from Programs and Features.\n\nClick OK when done.";
        public const string NET35_CHECKING_AGAIN = "Checking again...";
        public const string NET35_OPENING_SETTINGS = "Opening Programs and Features...";

        // Activation Messages
        public const string ADVANCED_MODE_TITLE = "Advanced Mode";
        public const string BASIC_MODE_TITLE = "Basic Mode";
        public const string ADVANCED_MODE_MESSAGE = "File download link opened in your browser.\nPlease download and run the installer.";
        public const string BASIC_MODE_MESSAGE = "PowerShell script is running.\nPlease wait for the process to complete.";
        public const string EXECUTION_ERROR = "Execution Error";
        public const string FAILED_TO_OPEN_LINK = "Failed to open download link: {0}";
        public const string FAILED_TO_EXECUTE = "Failed to execute command: {0}";

        // Donate
        public const string DONATE_MESSAGE = "Thank you for your support! ❤\n\nYour support helps us continue development.";
        public const string DONATE_TITLE = "Donate";

        // UI Defaults
        public const int INITIAL_DELAY_MS = 1000;
        public const int CHECKING_DELAY_MS = 500;
    }
}
