using System;
using System.Windows.Forms;

namespace frmidmactive
{
    public partial class DonateForm : Form
    {
        public DonateForm()
        {
            InitializeComponent();
        }

        private void DonateForm_Load(object sender, EventArgs e)
        {
            // Form loads with all information displayed
        }

        private void btnCopyAccount_Click(object sender, EventArgs e)
        {
            try
            {
                Clipboard.SetText("19034076619118");
                MessageBox.Show(
                    "Account number copied to clipboard!",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error: " + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
