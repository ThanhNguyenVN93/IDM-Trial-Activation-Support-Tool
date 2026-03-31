using System;
using System.IO;
using Microsoft.Win32;

namespace frmidmactive
{
    /// <summary>
    /// Handles IDM detection and validation
    /// </summary>
    public static class IDMChecker
    {
        public static bool IsIDMInstalled()
        {
            try
            {
                // Check both x86 and x64 paths
                if (File.Exists(AppConstants.IDM_PATH_X86) || File.Exists(AppConstants.IDM_PATH_X64))
                {
                    return true;
                }

                // Check registry as backup
                return IsIDMRegistered();
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(string.Format("Error checking IDM installation: {0}", ex.Message));
                return false;
            }
        }

        private static bool IsIDMRegistered()
        {
            try
            {
                using (RegistryKey key = Registry.LocalMachine.OpenSubKey(AppConstants.IDM_REGISTRY_PATH))
                {
                    return key != null;
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(string.Format("Error checking IDM registry: {0}", ex.Message));
                return false;
            }
        }
    }
}
