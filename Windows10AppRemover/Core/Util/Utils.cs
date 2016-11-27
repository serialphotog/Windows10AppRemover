/**
 * Copyright © 2016 Adam Thompson <adam@serialphotog.com>
 * This work is free. You can redistribute it and/or modify it under the
 * terms of the Do What The Fuck You Want To Public License, Version 2,
 * as published by Sam Hocevar. See the COPYING file for more details.
 */

using System;
using System.Diagnostics;
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
                process.WaitForExit();
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
