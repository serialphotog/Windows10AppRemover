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

        // Installed app flags
        private bool hasGetStarted = false;
        private bool hasFeedbackHub = false;
        private bool hasMaps = false;
        private bool hasPeople = false;
        private bool hasStickyNotes = false;
        private bool has3dBuilder = false;
        private bool hasAlarms = false;
        private bool hasCalculator = false;

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
        }

        // Delete the Getting started app
        private void btnDeleteGettingStarted_Click(object sender, EventArgs e)
        {
            this.lblCurrentOperation.Text = "Deleting " + GettingStarted;
            Debug.WriteLine("Deleting " + GettingStarted + "...");
            appHandler.DeleteW10App(GettingStarted);
            this.lblCurrentOperation.Text = "";
        }

        // Delete the Feedback hub app
        private void btnDeleteFeedbackHub_Click(object sender, EventArgs e)
        {
            this.lblCurrentOperation.Text = "Deleting " + FeedbackHub;
            Debug.WriteLine("Deleting " + FeedbackHub + "...");
            appHandler.DeleteW10App(FeedbackHub);
            this.lblCurrentOperation.Text = "";
        }
           
        // Delete the Maps app
        private void btnDeleteMaps_Click(object sender, EventArgs e)
        {
            this.lblCurrentOperation.Text = "Deleting " + Maps;
            Debug.WriteLine("Deleting " + Maps + "...");
            appHandler.DeleteW10App(Maps);
            this.lblCurrentOperation.Text = "";
        }

        // Delete the People app
        private void btnDeletePeople_Click(object sender, EventArgs e)
        {
            this.lblCurrentOperation.Text = "Deleting " + People;
            Debug.WriteLine("Deleting " + People + "...");
            appHandler.DeleteW10App(People);
            this.lblCurrentOperation.Text = "";
        }

        // Delete the Sticky notes app
        private void btnDeleteStickyNotes_Click(object sender, EventArgs e)
        {
            this.lblCurrentOperation.Text = "Deleting " + StickyNotes;
            Debug.WriteLine("Deleting " + StickyNotes + "...");
            appHandler.DeleteW10App(StickyNotes);
            this.lblCurrentOperation.Text = "";
        }

        // Delete the 3D Builder app
        private void btnDelete3DBuilder_Click(object sender, EventArgs e)
        {
            this.lblCurrentOperation.Text = "Deleting " + Builder3D;
            Debug.WriteLine("Deleting " + Builder3D + "...");
            appHandler.DeleteW10App(Builder3D);
            this.lblCurrentOperation.Text = "";
        }

        // Delete the Alarms app
        private void btnDeleteAlarms_Click(object sender, EventArgs e)
        {
            this.lblCurrentOperation.Text = "Deleting " + Alarms;
            Debug.WriteLine("Deleting " + Alarms + "...");
            appHandler.DeleteW10App(Alarms);
            this.lblCurrentOperation.Text = "";
        }

        // Delete the Calculator app
        private void btnDeleteCalculator_Click(object sender, EventArgs e)
        {
            this.lblCurrentOperation.Text = "Deleting " + Calculator;
            Debug.WriteLine("Deleting " + Calculator + "...");
            appHandler.DeleteW10App(Calculator);
        }
    }
}
