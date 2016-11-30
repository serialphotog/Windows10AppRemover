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
        private const String Solitaire = @"Microsoft.MicrosoftSolitaireCollection";

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
        private bool hasSolitaire = false;

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
            if (hasSolitaire)
                this.btnDeleteSolitaire.Enabled = true;

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
            // Test for solitaire app
            if (appHandler.GetIsAppInstalled(Solitaire))
            {
                Debug.WriteLine("Detected " + Solitaire + " is installed");
                this.hasSolitaire = true;
            }
        }

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

        private void DeleteButton_Click(object sender, EventArgs args)
        {
            Button btn = (Button)sender;
            switch ((String)btn.Tag) {
                case "GettingStarted":
                    DoDeleteApp(GettingStarted, sender);
                    break;
                case "FeedbackHub":
                    DoDeleteApp(FeedbackHub, sender);
                    break;
                case "Maps":
                    DoDeleteApp(Maps, sender);
                    break;
                case "People":
                    DoDeleteApp(People, sender);
                    break;
                case "StickyNotes":
                    DoDeleteApp(StickyNotes, sender);
                    break;
                case "3DBuilder":
                    DoDeleteApp(Builder3D, sender);
                    break;
                case "AlarmsAndClock":
                    DoDeleteApp(Alarms, sender);
                    break;
                case "Calculator":
                    DoDeleteApp(Calculator, sender);
                    break;
                case "Camera":
                    DoDeleteApp(Camera, sender);
                    break;
                case "ContactSupport":
                    DoDeleteApp(ContactSupport, sender);
                    break;
                case "Messaging":
                    DoDeleteApp(Messaging, sender);
                    break;
                case "News":
                    DoDeleteApp(News, sender);
                    break;
                case "OneNote":
                    DoDeleteApp(OneNote, sender);
                    break;
                case "Skype":
                    DoDeleteApp(Skype, sender);
                    break;
                case "VoiceRecorder":
                    DoDeleteApp(VoiceRecorder, sender);
                    break;
                case "Weather":
                    DoDeleteApp(Weather, sender);
                    break;
                case "Xbox":
                    DoDeleteApp(Xbox, sender);
                    break;
                case "MailAndCalendar":
                    DoDeleteApp(MailCal, sender);
                    break;
                case "Zune":
                    DoDeleteApp(Zune, sender);
                    break;
                case "Solitaire":
                    DoDeleteApp(Solitaire, sender);
                    break;
            }
        }
    }
}
