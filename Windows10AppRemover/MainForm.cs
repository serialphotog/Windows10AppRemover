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
    }
}
