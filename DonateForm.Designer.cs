namespace frmidmactive
{
    partial class DonateForm
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
            this.lblDescription = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnCopyAccount = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblBankLogo = new System.Windows.Forms.Label();
            this.lblBankName = new System.Windows.Forms.Label();
            this.lblAccountName = new System.Windows.Forms.Label();
            this.lblAccountNumber = new System.Windows.Forms.Label();
            this.lblAccountValue = new System.Windows.Forms.Label();
            this.lblAccountNameValue = new System.Windows.Forms.Label();
            this.pnlHeader.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(25, 118, 210);
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(500, 60);
            this.pnlHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(500, 60);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "❤ Hỗ trợ dự án";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlContent
            // 
            this.pnlContent.BackColor = System.Drawing.Color.FromArgb(245, 245, 245);
            this.pnlContent.Controls.Add(this.groupBox2);
            this.pnlContent.Controls.Add(this.groupBox1);
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(0, 60);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Padding = new System.Windows.Forms.Padding(15);
            this.pnlContent.Size = new System.Drawing.Size(500, 380);
            this.pnlContent.TabIndex = 1;
            // 
            // groupBox1 - Title
            // 
            this.groupBox1.Controls.Add(this.lblDescription);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(25, 118, 210);
            this.groupBox1.Location = new System.Drawing.Point(15, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(470, 80);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = " Cảm ơn bạn ";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblDescription.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
            this.lblDescription.Location = new System.Drawing.Point(15, 25);
            this.lblDescription.MaximumSize = new System.Drawing.Size(440, 100);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(420, 45);
            this.lblDescription.TabIndex = 0;
            this.lblDescription.Text = "Nếu bạn thấy công cụ này hữu ích, hãy ủng hộ chúng tôi để tiếp tục phát triển.\n\nBạn có thể chuyển khoản qua Techcombank bằng thông tin dưới đây.";
            // 
            // groupBox2 - Bank Info
            // 
            this.groupBox2.Controls.Add(this.btnCopyAccount);
            this.groupBox2.Controls.Add(this.btnClose);
            this.groupBox2.Controls.Add(this.lblAccountNameValue);
            this.groupBox2.Controls.Add(this.lblAccountValue);
            this.groupBox2.Controls.Add(this.lblAccountNumber);
            this.groupBox2.Controls.Add(this.lblAccountName);
            this.groupBox2.Controls.Add(this.lblBankName);
            this.groupBox2.Controls.Add(this.lblBankLogo);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(25, 118, 210);
            this.groupBox2.Location = new System.Drawing.Point(15, 95);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(470, 260);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = " Thông tin chuyển khoản ";
            // 
            // lblBankLogo
            // 
            this.lblBankLogo.AutoSize = true;
            this.lblBankLogo.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold);
            this.lblBankLogo.ForeColor = System.Drawing.Color.FromArgb(25, 118, 210);
            this.lblBankLogo.Location = new System.Drawing.Point(15, 28);
            this.lblBankLogo.Name = "lblBankLogo";
            this.lblBankLogo.Size = new System.Drawing.Size(40, 37);
            this.lblBankLogo.TabIndex = 0;
            this.lblBankLogo.Text = "🏦";
            // 
            // lblBankName
            // 
            this.lblBankName.AutoSize = true;
            this.lblBankName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.lblBankName.ForeColor = System.Drawing.Color.FromArgb(25, 118, 210);
            this.lblBankName.Location = new System.Drawing.Point(60, 35);
            this.lblBankName.Name = "lblBankName";
            this.lblBankName.Size = new System.Drawing.Size(150, 18);
            this.lblBankName.TabIndex = 1;
            this.lblBankName.Text = "Ngân hàng Techcombank";
            // 
            // lblAccountName
            // 
            this.lblAccountName.AutoSize = true;
            this.lblAccountName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblAccountName.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
            this.lblAccountName.Location = new System.Drawing.Point(15, 85);
            this.lblAccountName.Name = "lblAccountName";
            this.lblAccountName.Size = new System.Drawing.Size(54, 15);
            this.lblAccountName.TabIndex = 2;
            this.lblAccountName.Text = "Tên chủ:";
            // 
            // lblAccountNameValue
            // 
            this.lblAccountNameValue.AutoSize = true;
            this.lblAccountNameValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lblAccountNameValue.ForeColor = System.Drawing.Color.Black;
            this.lblAccountNameValue.Location = new System.Drawing.Point(150, 85);
            this.lblAccountNameValue.Name = "lblAccountNameValue";
            this.lblAccountNameValue.Size = new System.Drawing.Size(170, 15);
            this.lblAccountNameValue.TabIndex = 3;
            this.lblAccountNameValue.Text = "Nguyễn Minh Thành";
            // 
            // lblAccountNumber
            // 
            this.lblAccountNumber.AutoSize = true;
            this.lblAccountNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblAccountNumber.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
            this.lblAccountNumber.Location = new System.Drawing.Point(15, 115);
            this.lblAccountNumber.Name = "lblAccountNumber";
            this.lblAccountNumber.Size = new System.Drawing.Size(54, 15);
            this.lblAccountNumber.TabIndex = 4;
            this.lblAccountNumber.Text = "Số tài khoản:";
            // 
            // lblAccountValue
            // 
            this.lblAccountValue.AutoSize = true;
            this.lblAccountValue.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.lblAccountValue.ForeColor = System.Drawing.Color.FromArgb(220, 20, 60);
            this.lblAccountValue.Location = new System.Drawing.Point(150, 115);
            this.lblAccountValue.Name = "lblAccountValue";
            this.lblAccountValue.Size = new System.Drawing.Size(168, 17);
            this.lblAccountValue.TabIndex = 5;
            this.lblAccountValue.Text = "19034076619118";
            // 
            // btnCopyAccount
            // 
            this.btnCopyAccount.BackColor = System.Drawing.Color.FromArgb(25, 118, 210);
            this.btnCopyAccount.FlatAppearance.BorderSize = 0;
            this.btnCopyAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCopyAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.btnCopyAccount.ForeColor = System.Drawing.Color.White;
            this.btnCopyAccount.Location = new System.Drawing.Point(15, 155);
            this.btnCopyAccount.Name = "btnCopyAccount";
            this.btnCopyAccount.Size = new System.Drawing.Size(440, 32);
            this.btnCopyAccount.TabIndex = 6;
            this.btnCopyAccount.Text = "📋 Copy số tài khoản";
            this.btnCopyAccount.UseVisualStyleBackColor = false;
            this.btnCopyAccount.Click += new System.EventHandler(this.btnCopyAccount_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(158, 158, 158);
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(15, 200);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(440, 32);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "Đóng";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // DonateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(245, 245, 245);
            this.ClientSize = new System.Drawing.Size(500, 440);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DonateForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Hỗ trợ dự án";
            this.Load += new System.EventHandler(this.DonateForm_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlContent.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblBankLogo;
        private System.Windows.Forms.Label lblBankName;
        private System.Windows.Forms.Label lblAccountName;
        private System.Windows.Forms.Label lblAccountNameValue;
        private System.Windows.Forms.Label lblAccountNumber;
        private System.Windows.Forms.Label lblAccountValue;
        private System.Windows.Forms.Button btnCopyAccount;
        private System.Windows.Forms.Button btnClose;
    }
}
