namespace frmidmactive
{
    partial class Form2
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.progressIDM = new System.Windows.Forms.ProgressBar();
            this.btnDownloadIDM = new System.Windows.Forms.Button();
            this.txtIDMStatus = new System.Windows.Forms.TextBox();
            this.lblIDMStatus = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.progressExecution = new System.Windows.Forms.ProgressBar();
            this.btnExecute = new System.Windows.Forms.Button();
            this.txtCommand = new System.Windows.Forms.TextBox();
            this.lblCommandTitle = new System.Windows.Forms.Label();
            this.chkBasic = new System.Windows.Forms.CheckBox();
            this.chkAdvanced = new System.Windows.Forms.CheckBox();
            this.lblSelectVersion = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblInfoTitle = new System.Windows.Forms.Label();
            this.lblInfo = new System.Windows.Forms.Label();
            this.btnDonate = new System.Windows.Forms.Button();
            this.pnlHeader.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(25, 118, 210);
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(600, 70);
            this.pnlHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(600, 70);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "IDM TRIAL ACTIVATION SUPPORT";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlContent
            // 
            this.pnlContent.AutoScroll = true;
            this.pnlContent.BackColor = System.Drawing.Color.FromArgb(245, 245, 245);
            this.pnlContent.Controls.Add(this.groupBox1);
            this.pnlContent.Controls.Add(this.groupBox2);
            this.pnlContent.Controls.Add(this.groupBox3);
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(0, 70);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Padding = new System.Windows.Forms.Padding(20);
            this.pnlContent.Size = new System.Drawing.Size(600, 500);
            this.pnlContent.TabIndex = 1;
            // 
            // groupBox1 - Check IDM Installation
            // 
            this.groupBox1.Controls.Add(this.progressIDM);
            this.groupBox1.Controls.Add(this.btnDownloadIDM);
            this.groupBox1.Controls.Add(this.txtIDMStatus);
            this.groupBox1.Controls.Add(this.lblIDMStatus);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(25, 118, 210);
            this.groupBox1.Location = new System.Drawing.Point(20, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(560, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = " Check IDM Installation ";
            // 
            // lblIDMStatus
            // 
            this.lblIDMStatus.AutoSize = true;
            this.lblIDMStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblIDMStatus.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
            this.lblIDMStatus.Location = new System.Drawing.Point(15, 26);
            this.lblIDMStatus.Name = "lblIDMStatus";
            this.lblIDMStatus.Size = new System.Drawing.Size(70, 15);
            this.lblIDMStatus.TabIndex = 0;
            this.lblIDMStatus.Text = "IDM Status:";
            // 
            // txtIDMStatus
            // 
            this.txtIDMStatus.BackColor = System.Drawing.Color.White;
            this.txtIDMStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIDMStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtIDMStatus.Location = new System.Drawing.Point(15, 46);
            this.txtIDMStatus.Name = "txtIDMStatus";
            this.txtIDMStatus.ReadOnly = false;
            this.txtIDMStatus.Size = new System.Drawing.Size(405, 21);
            this.txtIDMStatus.TabIndex = 1;
            this.txtIDMStatus.Text = "Checking IDM...";
            // 
            // btnDownloadIDM
            // 
            this.btnDownloadIDM.BackColor = System.Drawing.Color.FromArgb(251, 140, 0);
            this.btnDownloadIDM.Enabled = false;
            this.btnDownloadIDM.FlatAppearance.BorderSize = 0;
            this.btnDownloadIDM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDownloadIDM.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnDownloadIDM.ForeColor = System.Drawing.Color.White;
            this.btnDownloadIDM.Location = new System.Drawing.Point(430, 44);
            this.btnDownloadIDM.Name = "btnDownloadIDM";
            this.btnDownloadIDM.Size = new System.Drawing.Size(115, 26);
            this.btnDownloadIDM.TabIndex = 2;
            this.btnDownloadIDM.Text = "Download IDM";
            this.btnDownloadIDM.UseVisualStyleBackColor = false;
            this.btnDownloadIDM.Click += new System.EventHandler(this.btnDownloadIDM_Click);
            // 
            // progressIDM
            // 
            this.progressIDM.Location = new System.Drawing.Point(15, 75);
            this.progressIDM.Name = "progressIDM";
            this.progressIDM.Size = new System.Drawing.Size(530, 16);
            this.progressIDM.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressIDM.TabIndex = 3;
            this.progressIDM.Visible = false;
            // 
            // groupBox2 - Select Activation Method
            // 
            this.groupBox2.Controls.Add(this.btnExecute);
            this.groupBox2.Controls.Add(this.progressExecution);
            this.groupBox2.Controls.Add(this.txtCommand);
            this.groupBox2.Controls.Add(this.lblCommandTitle);
            this.groupBox2.Controls.Add(this.chkBasic);
            this.groupBox2.Controls.Add(this.chkAdvanced);
            this.groupBox2.Controls.Add(this.lblSelectVersion);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(25, 118, 210);
            this.groupBox2.Location = new System.Drawing.Point(20, 125);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(560, 240);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = " Select Activation Method ";
            // 
            // lblSelectVersion
            // 
            this.lblSelectVersion.AutoSize = true;
            this.lblSelectVersion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblSelectVersion.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
            this.lblSelectVersion.Location = new System.Drawing.Point(15, 26);
            this.lblSelectVersion.Name = "lblSelectVersion";
            this.lblSelectVersion.Size = new System.Drawing.Size(96, 15);
            this.lblSelectVersion.TabIndex = 0;
            this.lblSelectVersion.Text = "Choose version:";
            // 
            // chkAdvanced
            // 
            this.chkAdvanced.AutoSize = true;
            this.chkAdvanced.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.chkAdvanced.ForeColor = System.Drawing.Color.FromArgb(51, 51, 51);
            this.chkAdvanced.Location = new System.Drawing.Point(32, 50);
            this.chkAdvanced.Name = "chkAdvanced";
            this.chkAdvanced.Size = new System.Drawing.Size(178, 19);
            this.chkAdvanced.TabIndex = 1;
            this.chkAdvanced.Text = "🔧 Advanced (nâng cao)";
            this.chkAdvanced.UseVisualStyleBackColor = true;
            this.chkAdvanced.CheckedChanged += new System.EventHandler(this.chkAdvanced_CheckedChanged);
            // 
            // chkBasic
            // 
            this.chkBasic.AutoSize = true;
            this.chkBasic.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.chkBasic.ForeColor = System.Drawing.Color.FromArgb(51, 51, 51);
            this.chkBasic.Location = new System.Drawing.Point(32, 76);
            this.chkBasic.Name = "chkBasic";
            this.chkBasic.Size = new System.Drawing.Size(150, 19);
            this.chkBasic.TabIndex = 2;
            this.chkBasic.Text = "⚡ Basic (cơ bản)";
            this.chkBasic.UseVisualStyleBackColor = true;
            this.chkBasic.CheckedChanged += new System.EventHandler(this.chkBasic_CheckedChanged);
            // 
            // lblCommandTitle
            // 
            this.lblCommandTitle.AutoSize = true;
            this.lblCommandTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblCommandTitle.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
            this.lblCommandTitle.Location = new System.Drawing.Point(15, 108);
            this.lblCommandTitle.Name = "lblCommandTitle";
            this.lblCommandTitle.Size = new System.Drawing.Size(122, 15);
            this.lblCommandTitle.TabIndex = 3;
            this.lblCommandTitle.Text = "Execution command:";
            // 
            // txtCommand
            // 
            this.txtCommand.BackColor = System.Drawing.Color.White;
            this.txtCommand.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCommand.Font = new System.Drawing.Font("Courier New", 8.25F);
            this.txtCommand.Location = new System.Drawing.Point(15, 128);
            this.txtCommand.Multiline = true;
            this.txtCommand.Name = "txtCommand";
            this.txtCommand.ReadOnly = true;
            this.txtCommand.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtCommand.Size = new System.Drawing.Size(530, 55);
            this.txtCommand.TabIndex = 4;
            // 
            // progressExecution
            // 
            this.progressExecution.Location = new System.Drawing.Point(15, 190);
            this.progressExecution.Name = "progressExecution";
            this.progressExecution.Size = new System.Drawing.Size(530, 16);
            this.progressExecution.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.progressExecution.TabIndex = 5;
            this.progressExecution.Visible = false;
            // 
            // btnExecute
            // 
            this.btnExecute.BackColor = System.Drawing.Color.FromArgb(25, 118, 210);
            this.btnExecute.Enabled = false;
            this.btnExecute.FlatAppearance.BorderSize = 0;
            this.btnExecute.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExecute.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.btnExecute.ForeColor = System.Drawing.Color.White;
            this.btnExecute.Location = new System.Drawing.Point(460, 208);
            this.btnExecute.Name = "btnExecute";
            this.btnExecute.Size = new System.Drawing.Size(85, 28);
            this.btnExecute.TabIndex = 6;
            this.btnExecute.Text = "Execute";
            this.btnExecute.UseVisualStyleBackColor = false;
            this.btnExecute.Click += new System.EventHandler(this.btnExecute_Click);
            // 
            // groupBox3 - System Information
            // 
            this.groupBox3.Controls.Add(this.btnDonate);
            this.groupBox3.Controls.Add(this.lblInfo);
            this.groupBox3.Controls.Add(this.lblInfoTitle);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.groupBox3.ForeColor = System.Drawing.Color.FromArgb(25, 118, 210);
            this.groupBox3.Location = new System.Drawing.Point(20, 375);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(560, 110);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = " System Information ";
            // 
            // lblInfoTitle
            // 
            this.lblInfoTitle.AutoSize = true;
            this.lblInfoTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblInfoTitle.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
            this.lblInfoTitle.Location = new System.Drawing.Point(15, 26);
            this.lblInfoTitle.Name = "lblInfoTitle";
            this.lblInfoTitle.Size = new System.Drawing.Size(130, 15);
            this.lblInfoTitle.TabIndex = 0;
            this.lblInfoTitle.Text = "Windows Information:";
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblInfo.ForeColor = System.Drawing.Color.FromArgb(100, 100, 100);
            this.lblInfo.Location = new System.Drawing.Point(32, 48);
            this.lblInfo.MaximumSize = new System.Drawing.Size(400, 50);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(233, 30);
            this.lblInfo.TabIndex = 1;
            this.lblInfo.Text = "OS: Windows\r\nFramework: .NET 3.5";
            // 
            // btnDonate
            // 
            this.btnDonate.BackColor = System.Drawing.Color.FromArgb(76, 175, 80);
            this.btnDonate.FlatAppearance.BorderSize = 0;
            this.btnDonate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDonate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.btnDonate.ForeColor = System.Drawing.Color.White;
            this.btnDonate.Location = new System.Drawing.Point(460, 74);
            this.btnDonate.Name = "btnDonate";
            this.btnDonate.Size = new System.Drawing.Size(85, 28);
            this.btnDonate.TabIndex = 2;
            this.btnDonate.Text = "❤ Donate";
            this.btnDonate.UseVisualStyleBackColor = false;
            this.btnDonate.Click += new System.EventHandler(this.btnDonate_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(245, 245, 245);
            this.ClientSize = new System.Drawing.Size(600, 570);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IDM Trial Activation Support Tool";
            this.Icon = IconGenerator.GenerateAppIcon();
            this.Load += new System.EventHandler(this.Form2_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlContent.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ProgressBar progressIDM;
        private System.Windows.Forms.Button btnDownloadIDM;
        private System.Windows.Forms.TextBox txtIDMStatus;
        private System.Windows.Forms.Label lblIDMStatus;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ProgressBar progressExecution;
        private System.Windows.Forms.Button btnExecute;
        private System.Windows.Forms.TextBox txtCommand;
        private System.Windows.Forms.Label lblCommandTitle;
        private System.Windows.Forms.CheckBox chkBasic;
        private System.Windows.Forms.CheckBox chkAdvanced;
        private System.Windows.Forms.Label lblSelectVersion;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblInfoTitle;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Button btnDonate;
    }
}
