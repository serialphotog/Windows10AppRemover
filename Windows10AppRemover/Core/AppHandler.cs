using System;

using Windows10AppRemover.Core.Util;

namespace Windows10AppRemover.Core
{
    class AppHandler
    {

        /// <summary>
        /// Checks if an app is installed
        /// </summary>
        /// <param name="app">App to check if is installed</param>
        /// <returns>True if installed, else returns false</returns>
        public bool GetIsAppInstalled(String app)
        {
            // Query for app
            String cmdOutput = Utils.StartProcess("powershell", $"-command \"Get-AppxPackage *{app}*");
            if (cmdOutput != null && cmdOutput.Contains("Name") && cmdOutput.Contains("Architecture"))
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// Deletes a Windows 10 app, if it exists on system
        /// </summary>
        /// <param name="app"></param>
        public void DeleteW10App(String app)
        {
            if (GetIsAppInstalled(app))
            {
                Utils.StartProcess("powershell", $"-command \"Get-AppxPackage *{app}* | Remove-AppxPackage\"");
            }
        }

    }
}
