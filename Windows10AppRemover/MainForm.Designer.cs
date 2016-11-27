namespace Windows10AppRemover
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnDeleteGettingStarted = new System.Windows.Forms.Button();
            this.btnDeleteFeedbackHub = new System.Windows.Forms.Button();
            this.btnDeleteMaps = new System.Windows.Forms.Button();
            this.btnDeletePeople = new System.Windows.Forms.Button();
            this.btnDeleteStickyNotes = new System.Windows.Forms.Button();
            this.btnDelete3DBuilder = new System.Windows.Forms.Button();
            this.btnDeleteAlarms = new System.Windows.Forms.Button();
            this.btnDeleteCalculator = new System.Windows.Forms.Button();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.lblCurrentOperation = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnDeleteCamera = new System.Windows.Forms.Button();
            this.btnDeleteContactSupport = new System.Windows.Forms.Button();
            this.btnDeleteMessaging = new System.Windows.Forms.Button();
            this.btnDeleteNews = new System.Windows.Forms.Button();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDeleteGettingStarted
            // 
            this.btnDeleteGettingStarted.Enabled = false;
            this.btnDeleteGettingStarted.Location = new System.Drawing.Point(12, 12);
            this.btnDeleteGettingStarted.Name = "btnDeleteGettingStarted";
            this.btnDeleteGettingStarted.Size = new System.Drawing.Size(160, 60);
            this.btnDeleteGettingStarted.TabIndex = 0;
            this.btnDeleteGettingStarted.Text = "Delete Getting Started";
            this.btnDeleteGettingStarted.UseVisualStyleBackColor = true;
            this.btnDeleteGettingStarted.Click += new System.EventHandler(this.btnDeleteGettingStarted_Click);
            // 
            // btnDeleteFeedbackHub
            // 
            this.btnDeleteFeedbackHub.Enabled = false;
            this.btnDeleteFeedbackHub.Location = new System.Drawing.Point(178, 12);
            this.btnDeleteFeedbackHub.Name = "btnDeleteFeedbackHub";
            this.btnDeleteFeedbackHub.Size = new System.Drawing.Size(160, 60);
            this.btnDeleteFeedbackHub.TabIndex = 1;
            this.btnDeleteFeedbackHub.Text = "Delete Feedback Hub";
            this.btnDeleteFeedbackHub.UseVisualStyleBackColor = true;
            this.btnDeleteFeedbackHub.Click += new System.EventHandler(this.btnDeleteFeedbackHub_Click);
            // 
            // btnDeleteMaps
            // 
            this.btnDeleteMaps.Enabled = false;
            this.btnDeleteMaps.Location = new System.Drawing.Point(344, 12);
            this.btnDeleteMaps.Name = "btnDeleteMaps";
            this.btnDeleteMaps.Size = new System.Drawing.Size(160, 60);
            this.btnDeleteMaps.TabIndex = 2;
            this.btnDeleteMaps.Text = "Delete Maps";
            this.btnDeleteMaps.UseVisualStyleBackColor = true;
            this.btnDeleteMaps.Click += new System.EventHandler(this.btnDeleteMaps_Click);
            // 
            // btnDeletePeople
            // 
            this.btnDeletePeople.Enabled = false;
            this.btnDeletePeople.Location = new System.Drawing.Point(510, 12);
            this.btnDeletePeople.Name = "btnDeletePeople";
            this.btnDeletePeople.Size = new System.Drawing.Size(160, 60);
            this.btnDeletePeople.TabIndex = 3;
            this.btnDeletePeople.Text = "Delete People";
            this.btnDeletePeople.UseVisualStyleBackColor = true;
            this.btnDeletePeople.Click += new System.EventHandler(this.btnDeletePeople_Click);
            // 
            // btnDeleteStickyNotes
            // 
            this.btnDeleteStickyNotes.Enabled = false;
            this.btnDeleteStickyNotes.Location = new System.Drawing.Point(12, 78);
            this.btnDeleteStickyNotes.Name = "btnDeleteStickyNotes";
            this.btnDeleteStickyNotes.Size = new System.Drawing.Size(160, 60);
            this.btnDeleteStickyNotes.TabIndex = 4;
            this.btnDeleteStickyNotes.Text = "Delete Sticky Notes";
            this.btnDeleteStickyNotes.UseVisualStyleBackColor = true;
            this.btnDeleteStickyNotes.Click += new System.EventHandler(this.btnDeleteStickyNotes_Click);
            // 
            // btnDelete3DBuilder
            // 
            this.btnDelete3DBuilder.Enabled = false;
            this.btnDelete3DBuilder.Location = new System.Drawing.Point(178, 78);
            this.btnDelete3DBuilder.Name = "btnDelete3DBuilder";
            this.btnDelete3DBuilder.Size = new System.Drawing.Size(160, 60);
            this.btnDelete3DBuilder.TabIndex = 5;
            this.btnDelete3DBuilder.Text = "Delete 3D Builder";
            this.btnDelete3DBuilder.UseVisualStyleBackColor = true;
            this.btnDelete3DBuilder.Click += new System.EventHandler(this.btnDelete3DBuilder_Click);
            // 
            // btnDeleteAlarms
            // 
            this.btnDeleteAlarms.Enabled = false;
            this.btnDeleteAlarms.Location = new System.Drawing.Point(344, 78);
            this.btnDeleteAlarms.Name = "btnDeleteAlarms";
            this.btnDeleteAlarms.Size = new System.Drawing.Size(160, 60);
            this.btnDeleteAlarms.TabIndex = 6;
            this.btnDeleteAlarms.Text = "Delete Alarms and Clock";
            this.btnDeleteAlarms.UseVisualStyleBackColor = true;
            this.btnDeleteAlarms.Click += new System.EventHandler(this.btnDeleteAlarms_Click);
            // 
            // btnDeleteCalculator
            // 
            this.btnDeleteCalculator.Enabled = false;
            this.btnDeleteCalculator.Location = new System.Drawing.Point(510, 78);
            this.btnDeleteCalculator.Name = "btnDeleteCalculator";
            this.btnDeleteCalculator.Size = new System.Drawing.Size(160, 60);
            this.btnDeleteCalculator.TabIndex = 7;
            this.btnDeleteCalculator.Text = "Delete Calculator";
            this.btnDeleteCalculator.UseVisualStyleBackColor = true;
            this.btnDeleteCalculator.Click += new System.EventHandler(this.btnDeleteCalculator_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblCurrentOperation});
            this.statusStrip.Location = new System.Drawing.Point(0, 370);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(686, 22);
            this.statusStrip.TabIndex = 8;
            this.statusStrip.Text = "statusStrip1";
            // 
            // lblCurrentOperation
            // 
            this.lblCurrentOperation.Name = "lblCurrentOperation";
            this.lblCurrentOperation.Size = new System.Drawing.Size(118, 17);
            this.lblCurrentOperation.Text = "toolStripStatusLabel1";
            // 
            // btnDeleteCamera
            // 
            this.btnDeleteCamera.Enabled = false;
            this.btnDeleteCamera.Location = new System.Drawing.Point(12, 144);
            this.btnDeleteCamera.Name = "btnDeleteCamera";
            this.btnDeleteCamera.Size = new System.Drawing.Size(160, 60);
            this.btnDeleteCamera.TabIndex = 9;
            this.btnDeleteCamera.Text = "Delete Camera";
            this.btnDeleteCamera.UseVisualStyleBackColor = true;
            this.btnDeleteCamera.Click += new System.EventHandler(this.btnDeleteCamera_Click);
            // 
            // btnDeleteContactSupport
            // 
            this.btnDeleteContactSupport.Enabled = false;
            this.btnDeleteContactSupport.Location = new System.Drawing.Point(178, 144);
            this.btnDeleteContactSupport.Name = "btnDeleteContactSupport";
            this.btnDeleteContactSupport.Size = new System.Drawing.Size(160, 60);
            this.btnDeleteContactSupport.TabIndex = 10;
            this.btnDeleteContactSupport.Text = "Delete Contact Support";
            this.btnDeleteContactSupport.UseVisualStyleBackColor = true;
            this.btnDeleteContactSupport.Click += new System.EventHandler(this.btnDeleteContactSupport_Click);
            // 
            // btnDeleteMessaging
            // 
            this.btnDeleteMessaging.Enabled = false;
            this.btnDeleteMessaging.Location = new System.Drawing.Point(344, 144);
            this.btnDeleteMessaging.Name = "btnDeleteMessaging";
            this.btnDeleteMessaging.Size = new System.Drawing.Size(160, 60);
            this.btnDeleteMessaging.TabIndex = 11;
            this.btnDeleteMessaging.Text = "Delete Messaging";
            this.btnDeleteMessaging.UseVisualStyleBackColor = true;
            this.btnDeleteMessaging.Click += new System.EventHandler(this.btnDeleteGrooveMusic_Click);
            // 
            // btnDeleteNews
            // 
            this.btnDeleteNews.DialogResult = System.Windows.Forms.DialogResult.No;
            this.btnDeleteNews.Enabled = false;
            this.btnDeleteNews.Location = new System.Drawing.Point(510, 144);
            this.btnDeleteNews.Name = "btnDeleteNews";
            this.btnDeleteNews.Size = new System.Drawing.Size(160, 60);
            this.btnDeleteNews.TabIndex = 12;
            this.btnDeleteNews.Text = "Delete News";
            this.btnDeleteNews.UseVisualStyleBackColor = true;
            this.btnDeleteNews.Click += new System.EventHandler(this.btnDeleteNews_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 392);
            this.Controls.Add(this.btnDeleteNews);
            this.Controls.Add(this.btnDeleteMessaging);
            this.Controls.Add(this.btnDeleteContactSupport);
            this.Controls.Add(this.btnDeleteCamera);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.btnDeleteCalculator);
            this.Controls.Add(this.btnDeleteAlarms);
            this.Controls.Add(this.btnDelete3DBuilder);
            this.Controls.Add(this.btnDeleteStickyNotes);
            this.Controls.Add(this.btnDeletePeople);
            this.Controls.Add(this.btnDeleteMaps);
            this.Controls.Add(this.btnDeleteFeedbackHub);
            this.Controls.Add(this.btnDeleteGettingStarted);
            this.Name = "MainForm";
            this.Text = "Windows 10 App Remover";
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDeleteGettingStarted;
        private System.Windows.Forms.Button btnDeleteFeedbackHub;
        private System.Windows.Forms.Button btnDeleteMaps;
        private System.Windows.Forms.Button btnDeletePeople;
        private System.Windows.Forms.Button btnDeleteStickyNotes;
        private System.Windows.Forms.Button btnDelete3DBuilder;
        private System.Windows.Forms.Button btnDeleteAlarms;
        private System.Windows.Forms.Button btnDeleteCalculator;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel lblCurrentOperation;
        private System.Windows.Forms.Button btnDeleteCamera;
        private System.Windows.Forms.Button btnDeleteContactSupport;
        private System.Windows.Forms.Button btnDeleteMessaging;
        private System.Windows.Forms.Button btnDeleteNews;
    }
}

