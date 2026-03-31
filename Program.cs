using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;

namespace frmidmactive
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Check if running as administrator
            if (!IsRunningAsAdmin())
            {
                // Restart as admin
                RestartAsAdmin();
                return;
            }

            // Generate icon file on startup
            IconGenerator.EnsureIconFileExists();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form2());
        }

        /// <summary>
        /// Check if application is running with administrator privileges
        /// </summary>
        static bool IsRunningAsAdmin()
        {
            try
            {
                var identity = System.Security.Principal.WindowsIdentity.GetCurrent();
                var principal = new System.Security.Principal.WindowsPrincipal(identity);
                return principal.IsInRole(System.Security.Principal.WindowsBuiltInRole.Administrator);
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// Restart application with administrator privileges
        /// </summary>
        static void RestartAsAdmin()
        {
            try
            {
                ProcessStartInfo psi = new ProcessStartInfo();
                psi.UseShellExecute = true;
                psi.FileName = System.Reflection.Assembly.GetExecutingAssembly().Location;
                psi.Verb = "runas"; // Run as administrator

                Process.Start(psi);
                Environment.Exit(0);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "This application requires administrator privileges.\nError: " + ex.Message,
                    "Administrator Required",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                Environment.Exit(1);
            }
        }
    }
}
