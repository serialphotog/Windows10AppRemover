/**
 * Copyright © 2016 Adam Thompson <adam@serialphotog.com>
 * This work is free. You can redistribute it and/or modify it under the
 * terms of the Do What The Fuck You Want To Public License, Version 2,
 * as published by Sam Hocevar. See the COPYING file for more details.
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Windows.Forms;

using Windows10AppRemover.Core;

namespace Windows10AppRemover
{
    public partial class MainForm : Form
    {

        /// <summary>
        /// Instance of our app handler class
        /// </summary>
        private AppHandler appHandler = new AppHandler();

        /// <summary>
        /// Contains all our app IDs
        /// </summary>
        private String[] AppIDs = new String[] 
        {
            @"Microsoft.Getstarted",
            @"Microsoft.WindowsFeedbackHub",
            @"Microsoft.WindowsMaps",
            @"Microsoft.People",
            @"Microsoft.MicrosoftStickyNotes",
            @"Microsoft.3DBuilder",
            @"Microsoft.WindowsAlarms",
            @"Microsoft.WindowsCalculator",
            @"Microsoft.WindowsCamera",
            @"Windows.ContactSupport",
            @"Microsoft.Messaging",
            @"Microsoft.BingNews",
            @"Microsoft.Office.OneNote",
            @"Microsoft.SkypeApp",
            @"Microsoft.WindowsSoundRecorder",
            @"Microsoft.BingWeather",
            @"Microsoft.XboxApp",
            @"microsoft.windowscommunicationsapps",
            @"zune",
            @"Microsoft.MicrosoftSolitaireCollection"
        };

        // app dictionary
        private IDictionary<String, bool> apps = new Dictionary<string, bool>();

        public MainForm()
        {
            InitializeComponent();
            InitializeAppDictionary();
            SetupUI();
        }

        /// <summary>
        /// Initializes our dictionary of apps
        /// </summary>
        private void InitializeAppDictionary()
        {
            for (int i=0; i<AppIDs.Length; i++)
            {
                apps[AppIDs[i]] = false;
            }
        }

        /// <summary>
        /// Performs necessary UI setup
        /// </summary>
        private async void SetupUI()
        {
            // Update status strip
            this.lblCurrentOperation.Text = "Detecting installed Windows 10 apps...";

            // Dertermine which apps are installed
            await Task.Run(() => GetInstalledApps());

            for (int i=0; i<AppIDs.Length; i++)
            {
                String currentApp = AppIDs[i];
                Control currentControl = FindControl(i.ToString());
                if (currentControl != null && apps[currentApp])
                {
                    currentControl.Enabled = true;
                }
            }

            this.lblCurrentOperation.Text = "";
        }

        /// <summary>
        /// Finds a control by its tag
        /// </summary>
        /// <param name="tag">The tag to search for</param>
        /// <returns>Control - The control with the given tag, else returns null</returns>
        private Control FindControl(String tag)
        {
            foreach (Control control in this.Controls)
            {
                if (control.Tag != null)
                {
                    String currentTag = (String)control.Tag;
                    if (currentTag.Equals(tag))
                    {
                        return control;
                    }
                }
            }
            return null;
        }

        /// <summary>
        /// Determines which apps are installed
        /// </summary>
        private void GetInstalledApps()
        {
            for (int i=0; i<AppIDs.Length; i++)
            {
                String currentApp = AppIDs[i];
                if (appHandler.GetIsAppInstalled(currentApp))
                {
                    PrintDetectedApp(currentApp);
                    apps[currentApp] = true;
                }
            }
        }

        /// <summary>
        /// Prints detected app debug string
        /// </summary>
        /// <param name="app">App id that was detected</param>
        private void PrintDetectedApp(String app)
        {
            Debug.WriteLine("Detected " + app + " is installed.");
        }

        /// <summary>
        /// Initiates the deletion of an app
        /// </summary>
        /// <param name="app">The app to delete</param>
        private void DoDeleteApp(String app, object sender)
        {
            this.lblCurrentOperation.Text = "Deleting " + app;
            Debug.WriteLine("Deleting " + app);
            appHandler.DeleteW10App(app);
            Button btn = (Button)sender;
            btn.Enabled = false;
            this.lblCurrentOperation.Text = "";
        }

        /// <summary>
        /// Handles button clicks for the delete app buttons
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="args">args</param>
        private void DeleteButton_Click(object sender, EventArgs args)
        {
            Button btn = (Button)sender;
            int tag = Int32.Parse((String)btn.Tag);
            if (tag >= 0 && tag < AppIDs.Length)
            {
                DoDeleteApp(AppIDs[tag], sender);
            }
        }
    }
}
