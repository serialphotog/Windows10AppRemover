using System;
using System.Diagnostics;
using System.IO;
using System.Text;

namespace Windows10AppRemover.Core.Util
{
    class Utils
    {

        /// <summary>
        /// Starts process with args
        /// </summary>
        /// <param name="name">Name of process to start</param>
        /// <param name="args">Args to run process with</param>
        /// <returns>String containing output</returns>
        public static String StartProcess(String name, String args)
        {
            try
            {
                Process process = new Process
                {
                    StartInfo = new ProcessStartInfo
                    {
                        FileName = name,
                        Arguments = args,
                        UseShellExecute = false,
                        RedirectStandardOutput = true,
                        CreateNoWindow = true,
                        StandardOutputEncoding = Encoding.GetEncoding(866)
                    }
                };

                process.Start();

                // Handle output
                String line = null;
                while (!process.StandardOutput.EndOfStream)
                {
                    line += Environment.NewLine + process.StandardOutput.ReadLine();
                }
                process.WaitForExit();
                //Debug.WriteLine("Process: " + name + " with " + args + "\n Output: " + line);
                return line;
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Error starting process: " + name + " with " + args);
                Debug.WriteLine(ex.Message);
                return null;
            }
        }

    }
}
