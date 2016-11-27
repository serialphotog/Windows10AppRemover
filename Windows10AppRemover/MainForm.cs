/**
 * Copyright © 2016 Adam Thompson <adam@serialphotog.com>
 * This work is free. You can redistribute it and/or modify it under the
 * terms of the Do What The Fuck You Want To Public License, Version 2,
 * as published by Sam Hocevar. See the COPYING file for more details.
 */

using System;
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

        // App identifier strings
        private const String GettingStarted = @"Microsoft.Getstarted";
        private const String FeedbackHub = @"Microsoft.WindowsFeedbackHub";
        private const String Maps = @"Microsoft.WindowsMaps";
        private const String People = @"Microsoft.People";
        private const String StickyNotes = @"Microsoft.MicrosoftStickyNotes";
        private const String Builder3D = @"Microsoft.3DBuilder";
        private const String Alarms = @"Microsoft.WindowsAlarms";
        private const String Calculator = @"Microsoft.WindowsCalculator";
        private const String Camera = @"Microsoft.WindowsCamera";
        private const String ContactSupport = @"Windows.ContactSupport";
        private const String Messaging = @"Microsoft.Messaging";
        private const String News = @"Microsoft.BingNews";
        private const String OneNote = @"Microsoft.Office.OneNote";
        private const String Skype = @"Microsoft.SkypeApp";
        private const String VoiceRecorder = @"Microsoft.WindowsSoundRecorder";
        private const String Weather = @"Microsoft.BingWeather";
        private const String Xbox = @"Microsoft.XboxApp";
        private const String MailCal = @"microsoft.windowscommunicationsapps";
        private const String Zune = @"zune";

        // Installed app flags
        private bool hasGetStarted = false;
        private bool hasFeedbackHub = false;
        private bool hasMaps = false;
        private bool hasPeople = false;
        private bool hasStickyNotes = false;
        private bool has3dBuilder = false;
        private bool hasAlarms = false;
        private bool hasCalculator = false;
        private bool hasCamera = false;
        private bool hasContactSupport = false;
        private bool hasMessaging = false;
        private bool hasNews = false;
        private bool hasOneNote = false;
        private bool hasSkype = false;
        private bool hasVoiceRecorder = false;
        private bool hasWeather = false;
        private bool hasXbox = false;
        private bool hasMailCal = false;
        private bool hasZune = false;

        public MainForm()
        {
            InitializeComponent();
            SetupUI();
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

            // Determine which buttons to activate
            if (hasGetStarted)
                this.btnDeleteGettingStarted.Enabled = true;
            if (hasFeedbackHub)
                this.btnDeleteFeedbackHub.Enabled = true;
            if (hasMaps)
                this.btnDeleteMaps.Enabled = true;
            if (hasPeople)
                this.btnDeletePeople.Enabled = true;
            if (hasStickyNotes)
                this.btnDeleteStickyNotes.Enabled = true;
            if (has3dBuilder)
                this.btnDelete3DBuilder.Enabled = true;
            if (hasAlarms)
                this.btnDeleteAlarms.Enabled = true;
            if (hasCalculator)
                this.btnDeleteCalculator.Enabled = true;
            if (hasCamera)
                this.btnDeleteCamera.Enabled = true;
            if (hasContactSupport)
                this.btnDeleteContactSupport.Enabled = true;
            if (hasMessaging)
                this.btnDeleteMessaging.Enabled = true;
            if (hasNews)
                this.btnDeleteNews.Enabled = true;
            if (hasOneNote)
                this.btnDeleteOneNote.Enabled = true;
            if (hasSkype)
                this.btnDeleteSkype.Enabled = true;
            if (hasVoiceRecorder)
                this.btnDeleteVoiceRecorder.Enabled = true;
            if (hasWeather)
                this.btnDeleteWeather.Enabled = true;
            if (hasXbox)
                this.btnDeleteXbox.Enabled = true;
            if (hasMailCal)
                this.btnDeleteMailCalendar.Enabled = true;
            if (hasZune)
                this.btnDeleteZune.Enabled = true;

            this.lblCurrentOperation.Text = "";
        }

        /// <summary>
        /// Determines which apps are installed
        /// </summary>
        private void GetInstalledApps()
        {
            // Test for Getting Started app
            if (appHandler.GetIsAppInstalled(GettingStarted))
            {
                Debug.WriteLine("Detected " + GettingStarted + " is installed");
                this.hasGetStarted = true;
            }
            // Test for Feedback Hub app
            if (appHandler.GetIsAppInstalled(FeedbackHub))
            {
                Debug.WriteLine("Detected " + FeedbackHub + " is installed");
                this.hasFeedbackHub = true;
            }
            // Test for Maps app
            if (appHandler.GetIsAppInstalled(Maps))
            {
                Debug.WriteLine("Detected " + Maps + " is installed");
                this.hasMaps = true;
            }
            // Test for People app
            if (appHandler.GetIsAppInstalled(People))
            {
                Debug.WriteLine("Detected " + People + " is installed");
                this.hasPeople = true;
            }
            // Test for Sticky Notes app
            if (appHandler.GetIsAppInstalled(StickyNotes))
            {
                Debug.WriteLine("Detected " + StickyNotes + " is installed");
                this.hasStickyNotes = true;
            }
            // Test for 3d Builder app
            if (appHandler.GetIsAppInstalled(Builder3D))
            {
                Debug.WriteLine("Detected " + Builder3D + " is installed");
                this.has3dBuilder = true;
            }
            // Test for Alarms and Clock app
            if (appHandler.GetIsAppInstalled(Alarms))
            {
                Debug.WriteLine("Detected " + Alarms + " is installed");
                this.hasAlarms = true;
            }
            // Test for calculator App
            if (appHandler.GetIsAppInstalled(Calculator))
            {
                Debug.WriteLine("Detected " + Calculator + " is installed");
                this.hasCalculator = true;
            }
            // Test for camera app
            if (appHandler.GetIsAppInstalled(Camera))
            {
                Debug.WriteLine("Detected " + Camera + " is installed");
                this.hasCamera = true;
            }
            // Test for Contact Support app
            if (appHandler.GetIsAppInstalled(ContactSupport))
            {
                Debug.WriteLine("Detected " + ContactSupport + " is installed");
                this.hasContactSupport = true;
            }
            // Test for Messaging app
            if (appHandler.GetIsAppInstalled(Messaging))
            {
                Debug.WriteLine("Detected " + Messaging + " is installed");
                this.hasMessaging = true;
            }
            // Test for News app
            if (appHandler.GetIsAppInstalled(News))
            {
                Debug.WriteLine("Detected " + News + " is installed");
                this.hasNews = true;
            }
            // Test for OneNote app
            if (appHandler.GetIsAppInstalled(OneNote))
            {
                Debug.WriteLine("Detected " + OneNote + " is installed");
                this.hasOneNote = true;
            }
            // Test for Skype app
            if (appHandler.GetIsAppInstalled(Skype))
            {
                Debug.WriteLine("Detected " + Skype + " is installed");
                this.hasSkype = true;
            }
            // Test for Voice Recorder app
            if (appHandler.GetIsAppInstalled(VoiceRecorder))
            {
                Debug.WriteLine("Detected " + VoiceRecorder + " is installed");
                this.hasVoiceRecorder = true;
            }
            // Test for Weather app
            if (appHandler.GetIsAppInstalled(Weather))
            {
                Debug.WriteLine("Detected " + Weather + " is installed");
                this.hasWeather = true;
            }
            // Test for Xbox app
            if (appHandler.GetIsAppInstalled(Xbox))
            {
                Debug.WriteLine("Detected " + Xbox + " is installed");
                this.hasXbox = true;
            }
            // Test for mail and calendar app
            if (appHandler.GetIsAppInstalled(MailCal))
            {
                Debug.WriteLine("Detected " + MailCal + " is installed");
                this.hasMailCal = true;
            }
            // Test for zune app
            if (appHandler.GetIsAppInstalled(Zune))
            {
                Debug.WriteLine("Detected " + Zune + " is installed");
                this.hasZune = true;
            }
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

        // Delete the Getting started app
        private void btnDeleteGettingStarted_Click(object sender, EventArgs e)
        {
            DoDeleteApp(GettingStarted, sender);
        }

        // Delete the Feedback hub app
        private void btnDeleteFeedbackHub_Click(object sender, EventArgs e)
        {
            DoDeleteApp(FeedbackHub, sender);
        }
           
        // Delete the Maps app
        private void btnDeleteMaps_Click(object sender, EventArgs e)
        {
            DoDeleteApp(Maps, sender);
        }

        // Delete the People app
        private void btnDeletePeople_Click(object sender, EventArgs e)
        {
            DoDeleteApp(People, sender);
        }

        // Delete the Sticky notes app
        private void btnDeleteStickyNotes_Click(object sender, EventArgs e)
        {
            DoDeleteApp(StickyNotes, sender);
        }

        // Delete the 3D Builder app
        private void btnDelete3DBuilder_Click(object sender, EventArgs e)
        {
            DoDeleteApp(Builder3D, sender);
        }

        // Delete the Alarms app
        private void btnDeleteAlarms_Click(object sender, EventArgs e)
        {
            DoDeleteApp(Alarms, sender);
        }

        // Delete the Calculator app
        private void btnDeleteCalculator_Click(object sender, EventArgs e)
        {
            DoDeleteApp(Calculator, sender);
        }

        // Deletes the camera app
        private void btnDeleteCamera_Click(object sender, EventArgs e)
        {
            DoDeleteApp(Camera, sender);
        }

        // Delete Contact Support app
        private void btnDeleteContactSupport_Click(object sender, EventArgs e)
        {
            DoDeleteApp(ContactSupport, sender);
        }

        // Delete Messaging app
        private void btnDeleteMessaging_Click(object sender, EventArgs e)
        {
            DoDeleteApp(Messaging, sender);
        }

        // Delete news app
        private void btnDeleteNews_Click(object sender, EventArgs e)
        {
            DoDeleteApp(News, sender);
        }

        // Delete OneNote app
        private void btnDeleteOneNote_Click(object sender, EventArgs e)
        {
            DoDeleteApp(OneNote, sender);
        }

        // Delete Skype app
        private void btnDeleteSkype_Click(object sender, EventArgs e)
        {
            DoDeleteApp(Skype, sender);
        }

        // Delete Voice Recorder app
        private void btnDeleteVoiceRecorder_Click(object sender, EventArgs e)
        {
            DoDeleteApp(VoiceRecorder, sender);
        }

        // Delete Weather app
        private void btnDeleteWeather_Click(object sender, EventArgs e)
        {
            DoDeleteApp(Weather, sender);
        }

        // Delete Xbox app
        private void btnDeleteXbox_Click(object sender, EventArgs e)
        {
            DoDeleteApp(Xbox, sender);
        }

        // Delete mail and calendar apps
        private void btnDeleteMailCalendar_Click(object sender, EventArgs e)
        {
            DoDeleteApp(MailCal, sender);
        }

        // Deletes the zune app
        private void btnDeleteZune_Click(object sender, EventArgs e)
        {
            DoDeleteApp(Zune, sender);
        }
    }
}
