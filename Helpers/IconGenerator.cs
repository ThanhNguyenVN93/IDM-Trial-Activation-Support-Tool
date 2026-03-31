using System;
using System.Drawing;
using System.IO;

namespace frmidmactive
{
    /// <summary>
    /// Generates application icon
    /// </summary>
    public static class IconGenerator
    {
        private const string ICON_FILENAME = "app.ico";

        public static Icon GenerateAppIcon()
        {
            // Create 32x32 bitmap
            Bitmap bitmap = new Bitmap(32, 32);
            Graphics g = Graphics.FromImage(bitmap);

            // Fill background with white
            g.Clear(Color.White);

            // Draw blue circle (download manager icon)
            Brush blueBrush = new SolidBrush(Color.FromArgb(25, 118, 210));
            g.FillEllipse(blueBrush, 2, 2, 28, 28);

            // Draw download arrow (white)
            Pen whitePen = new Pen(Color.White, 2);

            // Vertical line (down arrow)
            g.DrawLine(whitePen, 16, 8, 16, 20);

            // Arrow head - left
            g.DrawLine(whitePen, 16, 20, 12, 16);

            // Arrow head - right
            g.DrawLine(whitePen, 16, 20, 20, 16);

            // Draw horizontal line at bottom (storage)
            g.DrawLine(whitePen, 10, 24, 22, 24);

            g.Dispose();

            // Convert bitmap to icon
            IntPtr hicon = bitmap.GetHicon();
            Icon icon = Icon.FromHandle(hicon);

            bitmap.Dispose();
            blueBrush.Dispose();
            whitePen.Dispose();

            return icon;
        }

        public static string GetIconPath()
        {
            string appDir = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
            return Path.Combine(appDir, ICON_FILENAME);
        }

        public static void EnsureIconFileExists()
        {
            try
            {
                string iconPath = GetIconPath();

                // Only create if doesn't exist
                if (!File.Exists(iconPath))
                {
                    SaveAppIcon(iconPath);
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("Error ensuring icon file: " + ex.Message);
            }
        }

        public static void SaveAppIcon(string iconPath)
        {
            try
            {
                // Create directory if not exists
                string directory = Path.GetDirectoryName(iconPath);
                if (!Directory.Exists(directory))
                {
                    Directory.CreateDirectory(directory);
                }

                // Generate icon and save
                Icon icon = GenerateAppIcon();
                using (FileStream fs = new FileStream(iconPath, FileMode.Create))
                {
                    icon.Save(fs);
                }
                icon.Dispose();
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("Error saving icon: " + ex.Message);
            }
        }
    }
}
