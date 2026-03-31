using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace frmidmactive
{
    public partial class Form2 : Form
    {
        private BackgroundWorker _bgCheckIDM;
        private DownloadManager _downloadManager;
        private bool _isDownloading = false;
        private bool _preventCheckedChanged = false;

        public Form2()
        {
            InitializeComponent();
            InitializeBackgroundWorkers();
        }

        private void InitializeBackgroundWorkers()
        {
            _bgCheckIDM = new BackgroundWorker();
            _bgCheckIDM.DoWork += BgCheckIDM_DoWork;
            _bgCheckIDM.RunWorkerCompleted += BgCheckIDM_RunWorkerCompleted;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // Create physical icon file if doesn't exist
            IconGenerator.EnsureIconFileExists();

            ResetActivationUI();
            UpdateSystemInfo();
            _bgCheckIDM.RunWorkerAsync();
        }

        private void BgCheckIDM_DoWork(object sender, DoWorkEventArgs e)
        {
            e.Result = IDMChecker.IsIDMInstalled();
        }

        private void BgCheckIDM_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Error != null)
            {
                txtIDMStatus.Text = "Error checking IDM";
                txtIDMStatus.ForeColor = System.Drawing.Color.Red;
                return;
            }

            bool isInstalled = (bool)e.Result;
            if (isInstalled)
            {
                txtIDMStatus.Text = AppConstants.IDM_INSTALLED;
                txtIDMStatus.ForeColor = System.Drawing.Color.Green;
                btnDownloadIDM.Enabled = false;
            }
            else
            {
                txtIDMStatus.Text = AppConstants.IDM_NOT_INSTALLED;
                txtIDMStatus.ForeColor = System.Drawing.Color.Red;
                btnDownloadIDM.Enabled = true;
            }
        }

        private void ResetActivationUI()
        {
            chkAdvanced.Checked = false;
            chkBasic.Checked = false;
            txtCommand.Text = "";
            btnExecute.Enabled = false;
        }

        private void UpdateSystemInfo()
        {
            try
            {
                string osVersion = Environment.OSVersion.VersionString;
                lblInfo.Text = "OS: " + osVersion + "\nFramework: .NET 3.5";
            }
            catch
            {
                lblInfo.Text = "OS: Windows\nFramework: .NET 3.5";
            }
        }

        private void chkAdvanced_CheckedChanged(object sender, EventArgs e)
        {
            if (_preventCheckedChanged) return;

            if (chkAdvanced.Checked || chkBasic.Checked)
            {
                // Nếu Advanced HOẶC Basic được chọn → disable cả 2
                chkAdvanced.Enabled = false;
                chkBasic.Enabled = false;

                if (chkAdvanced.Checked)
                {
                    txtCommand.Text = AppConstants.ADVANCED_ACTIVATION_URL;
                    btnExecute.Enabled = false;
                    progressExecution.Visible = true;
                    ExecuteAdvanced();  // Gọi trực tiếp, không dùng PerformClick()
                }
            }
            else
            {
                // Nếu cả 2 đều unchecked → enable cả 2
                chkAdvanced.Enabled = true;
                chkBasic.Enabled = true;
                txtCommand.Text = "";
                btnExecute.Enabled = false;
            }
        }

        private void chkBasic_CheckedChanged(object sender, EventArgs e)
        {
            if (_preventCheckedChanged) return;

            if (chkAdvanced.Checked || chkBasic.Checked)
            {
                // Nếu Advanced HOẶC Basic được chọn → disable cả 2
                chkAdvanced.Enabled = false;
                chkBasic.Enabled = false;

                if (chkBasic.Checked)
                {
                    txtCommand.Text = AppConstants.BASIC_ACTIVATION_CMD;
                    btnExecute.Enabled = false;
                    progressExecution.Visible = true;
                    ExecuteBasic();  // Gọi trực tiếp, không dùng PerformClick()
                }
            }
            else
            {
                // Nếu cả 2 đều unchecked → enable cả 2
                chkAdvanced.Enabled = true;
                chkBasic.Enabled = true;
                txtCommand.Text = "";
                btnExecute.Enabled = false;
            }
        }

        private void btnExecute_Click(object sender, EventArgs e)
        {
            try
            {
                btnExecute.Enabled = false;
                progressExecution.Visible = true;

                if (chkAdvanced.Checked)
                {
                    ExecuteAdvanced();
                    btnExecute.Enabled = true;
                    progressExecution.Visible = false;
                }
                else if (chkBasic.Checked)
                {
                    ExecuteBasic();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error: " + ex.Message,
                    AppConstants.EXECUTION_ERROR,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                btnExecute.Enabled = true;
                progressExecution.Visible = false;
            }
        }

        private void ExecuteAdvanced()
        {
            // Download Advanced tool
            StartDownloadAdvancedTool(AppConstants.ADVANCED_ACTIVATION_URL);
        }

        private void ExecuteBasic()
        {
            try
            {
                progressExecution.Style = ProgressBarStyle.Marquee;

                ProcessStartInfo psi = new ProcessStartInfo();
                psi.FileName = "powershell.exe";
                psi.Arguments = "-NoProfile -ExecutionPolicy Bypass -Command \"" + AppConstants.BASIC_ACTIVATION_CMD + "\"";
                psi.UseShellExecute = false;
                psi.CreateNoWindow = true;  // Script chạy im lặng ở background

                Process process = Process.Start(psi);

                // Chạy WaitForExit trong background thread để không block UI
                BackgroundWorker bgWaitProcess = new BackgroundWorker();
                bgWaitProcess.DoWork += (s, e) =>
                {
                    process.WaitForExit();  // Đợi script kết thúc
                };
                bgWaitProcess.RunWorkerCompleted += (s, e) =>
                {
                    // Script kết thúc, đóng Form2
                    this.BeginInvoke((MethodInvoker)delegate
                    {
                        progressExecution.Visible = false;
                        this.Close();
                    });
                };
                bgWaitProcess.RunWorkerAsync();
            }
            catch (Exception ex)
            {
                progressExecution.Visible = false;
                btnExecute.Enabled = true;

                // Re-enable checkboxes khi có lỗi
                chkAdvanced.Enabled = true;
                chkBasic.Enabled = true;
                chkBasic.Checked = false;

                MessageBox.Show(
                    string.Format(AppConstants.FAILED_TO_EXECUTE, ex.Message),
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void StartDownloadAdvancedTool(string downloadUrl)
        {
            try
            {
                // Fix SSL/TLS issue for .NET 3.5
                System.Net.ServicePointManager.SecurityProtocol = 
                    (System.Net.SecurityProtocolType)3072 | // TLS 1.2
                    (System.Net.SecurityProtocolType)768;   // TLS 1.1

                string fileName = Path.GetFileName(new Uri(downloadUrl).LocalPath);
                if (string.IsNullOrEmpty(fileName))
                {
                    fileName = "IDM-Freezer-Activation-Tool.exe";
                }
                string downloadPath = Path.Combine(Path.GetTempPath(), fileName);

                DownloadManager downloadMgr = new DownloadManager();
                downloadMgr.ProgressChanged += (s, e) =>
                {
                    progressExecution.Value = e.ProgressPercentage;
                };
                downloadMgr.DownloadCompleted += (s, e) =>
                {
                    progressExecution.Visible = false;

                    // Kiểm tra file tồn tại (dù download báo lỗi, file vẫn có thể tồn tại từ lần trước)
                    if (!File.Exists(downloadPath))
                    {
                        btnExecute.Enabled = true;
                        chkAdvanced.Enabled = true;
                        chkBasic.Enabled = true;
                        chkAdvanced.Checked = false;

                        // Chỉ báo lỗi khi file thực sự không tồn tại
                        string errorMsg = e.Error != null ? e.Error.Message : "Download failed";
                        MessageBox.Show(
                            errorMsg + "\n\nPlease download manually from:\n" + downloadUrl,
                            "Download Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                        return;
                    }

                    // File tồn tại → chạy nó (dù download báo lỗi hay không)
                    // Retry logic vì file có thể bị lock bởi antivirus/process khác
                    int retryCount = 0;
                    int maxRetries = 3;
                    bool toolStarted = false;
                    Exception lastException = null;

                    while (retryCount < maxRetries && !toolStarted)
                    {
                        try
                        {
                            Process.Start(downloadPath);
                            toolStarted = true;
                            System.Threading.Thread.Sleep(1500); // Đợi tool mở
                        }
                        catch (Exception ex)
                        {
                            lastException = ex;
                            retryCount++;
                            if (retryCount < maxRetries)
                            {
                                System.Threading.Thread.Sleep(500 * retryCount); // Exponential backoff
                            }
                        }
                    }

                    if (toolStarted)
                    {
                        // Tool chạy thành công, đóng Form2
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show(
                            "Failed to run tool after " + maxRetries + " attempts:\n" + lastException.Message,
                            "Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }

                    // Re-enable checkboxes để user có thể chọn cái khác
                    btnExecute.Enabled = true;
                    chkAdvanced.Enabled = true;
                    chkBasic.Enabled = true;
                    chkAdvanced.Checked = false;
                    downloadMgr.Dispose();
                };

                downloadMgr.DownloadFileAsync(downloadUrl, downloadPath);
            }
            catch (Exception ex)
            {
                progressExecution.Visible = false;
                btnExecute.Enabled = true;
                chkAdvanced.Enabled = true;
                chkBasic.Enabled = true;
                chkAdvanced.Checked = false;
                MessageBox.Show(
                    "Error: " + ex.Message,
                    "Download Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnDownloadIDM_Click(object sender, EventArgs e)
        {
            if (!_isDownloading)
            {
                StartDownloadIDM();
            }
        }

        private void StartDownloadIDM()
        {
            txtIDMStatus.Text = AppConstants.IDM_DOWNLOADING;
            txtIDMStatus.ForeColor = System.Drawing.Color.Blue;
            progressIDM.Visible = true;
            progressIDM.Value = 0;
            btnDownloadIDM.Enabled = false;
            StartFileDownload(AppConstants.IDM_DOWNLOAD_URL);
        }

        private void StartFileDownload(string downloadUrl)
        {
            try
            {
                // Fix SSL/TLS issue for .NET 3.5
                System.Net.ServicePointManager.SecurityProtocol = 
                    (System.Net.SecurityProtocolType)3072 | // TLS 1.2
                    (System.Net.SecurityProtocolType)768;   // TLS 1.1

                string fileName = Path.GetFileName(new Uri(downloadUrl).LocalPath);
                string downloadPath = Path.Combine(Path.GetTempPath(), fileName);

                _downloadManager = new DownloadManager();
                _downloadManager.ProgressChanged += DownloadManager_ProgressChanged;
                _downloadManager.DownloadCompleted += DownloadManager_DownloadCompleted;

                _isDownloading = true;
                _downloadManager.DownloadFileAsync(downloadUrl, downloadPath);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error: " + ex.Message,
                    "Download Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                progressIDM.Visible = false;
                btnDownloadIDM.Enabled = true;
            }
        }

        private void DownloadManager_ProgressChanged(object sender, System.Net.DownloadProgressChangedEventArgs e)
        {
            progressIDM.Value = e.ProgressPercentage;
            txtIDMStatus.Text = string.Format(AppConstants.DOWNLOAD_PROGRESS, e.ProgressPercentage);
        }

        private void DownloadManager_DownloadCompleted(object sender, AsyncCompletedEventArgs e)
        {
            _isDownloading = false;

            if (e.Error != null)
            {
                txtIDMStatus.Text = string.Format(AppConstants.DOWNLOAD_FAILED, e.Error.Message);
                txtIDMStatus.ForeColor = System.Drawing.Color.Red;
                progressIDM.Visible = false;
                btnDownloadIDM.Enabled = true;
                return;
            }

            if (e.Cancelled)
            {
                progressIDM.Visible = false;
                btnDownloadIDM.Enabled = true;
                return;
            }

            progressIDM.Value = 100;
            txtIDMStatus.Text = AppConstants.DOWNLOAD_COMPLETED;
            txtIDMStatus.ForeColor = System.Drawing.Color.Green;

            RunInstallerAsync();
        }

        private void RunInstallerAsync()
        {
            string fileName = Path.GetFileName(new Uri(AppConstants.IDM_DOWNLOAD_URL).LocalPath);
            string downloadPath = Path.Combine(Path.GetTempPath(), fileName);

            if (File.Exists(downloadPath))
            {
                try
                {
                    Process.Start(downloadPath);
                    MessageBox.Show(
                        AppConstants.INSTALLATION_STARTED_MESSAGE,
                        AppConstants.INSTALLATION_STARTED,
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(
                        string.Format(AppConstants.ERROR_RUNNING_INSTALLER, ex.Message),
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }

            btnDownloadIDM.Enabled = true;
            if (_downloadManager != null)
            {
                _downloadManager.Dispose();
            }
        }

        private void btnDonate_Click(object sender, EventArgs e)
        {
            DonateForm donateForm = new DonateForm();
            donateForm.ShowDialog(this);
        }
    }
}
