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
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 392);
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
            this.ResumeLayout(false);

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
    }
}

