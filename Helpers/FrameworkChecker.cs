using System;
using Microsoft.Win32;

namespace frmidmactive
{
    /// <summary>
    /// Handles .NET Framework checks
    /// </summary>
    public static class FrameworkChecker
    {
        public static bool IsNet35Enabled()
        {
            try
            {
                using (RegistryKey key = Registry.LocalMachine.OpenSubKey(AppConstants.NET35_REGISTRY_PATH))
                {
                    if (key != null)
                    {
                        object install = key.GetValue("Install");
                        return install != null && install.ToString() == "1";
                    }
                    return false;
                }
            }
            catch
            {
                return false;
            }
        }
    }
}
