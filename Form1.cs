using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows.Forms;

namespace frmidmactive
{
    public partial class Form1 : Form
    {
        private BackgroundWorker _bgWorker;
        private Timer _delayTimer;

        public Form1()
        {
            InitializeComponent();
            InitializeBackgroundWorker();
        }

        private void InitializeBackgroundWorker()
        {
            _bgWorker = new BackgroundWorker();
            _bgWorker.DoWork += BgWorker_DoWork;
            _bgWorker.RunWorkerCompleted += BgWorker_RunWorkerCompleted;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            _bgWorker.RunWorkerAsync();
        }

        private void BgWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            e.Result = FrameworkChecker.IsNet35Enabled();
        }

        private void BgWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Error != null)
            {
                lblStatus.Text = "Error checking .NET 3.5";
                return;
            }

            bool isNet35Enabled = (bool)e.Result;

            if (isNet35Enabled)
            {
                lblStatus.Text = AppConstants.NET35_ENABLED_MESSAGE;
                // Delay before opening Form2 to show success message
                ScheduleForm2Opening(AppConstants.INITIAL_DELAY_MS);
            }
            else
            {
                HandleNet35NotEnabled();
            }
        }

        private void ScheduleForm2Opening(int delayMs)
        {
            _delayTimer = new Timer();
            _delayTimer.Interval = delayMs;
            _delayTimer.Tick += (s, e) =>
            {
                _delayTimer.Stop();
                _delayTimer.Dispose();
                OpenForm2();
            };
            _delayTimer.Start();
        }

        private void OpenForm2()
        {
            try
            {
                Form2 form2 = new Form2();

                // Khi Form2 đóng, đóng toàn bộ ứng dụng
                form2.FormClosed += (s, e) => 
                {
                    this.Close();
                };

                // Ẩn Form1 rồi hiển thị Form2
                this.Hide();
                form2.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error opening Form2: " + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void HandleNet35NotEnabled()
        {
            lblStatus.Text = AppConstants.NET35_DISABLED_MESSAGE;
            progressBar1.Style = ProgressBarStyle.Continuous;
            progressBar1.Value = 0;

            DialogResult result = MessageBox.Show(
                AppConstants.NET35_ENABLE_PROMPT,
                AppConstants.NET35_NOT_ENABLED_TITLE,
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                EnableNet35();
            }
            else
            {
                this.Close();
            }
        }

        private void EnableNet35()
        {
            try
            {
                lblStatus.Text = AppConstants.NET35_OPENING_SETTINGS;
                Process.Start("appwiz.cpl");

                MessageBox.Show(
                    AppConstants.NET35_ENABLE_INSTRUCTION,
                    "Enable NET 3.5",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                lblStatus.Text = AppConstants.NET35_CHECKING_AGAIN;
                progressBar1.Style = ProgressBarStyle.Marquee;
                _bgWorker.RunWorkerAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error: " + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                this.Close();
            }
        }
    }
}
