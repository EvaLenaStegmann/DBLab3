namespace MyGarden
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItemFile = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemExit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemAdmin = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemPlants = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemPlantTypes = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemLocations = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemActionTypes = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemOverView = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemPlantTypesPerLocation = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemPlantsPerLocation = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemViewHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(691, 503);
            this.panel1.TabIndex = 0;
            this.panel1.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.panel1_ControlAdded);
            // 
            // menuStrip2
            // 
            this.menuStrip2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemFile,
            this.toolStripMenuItemAdmin,
            this.toolStripMenuItemOverView,
            this.toolStripMenuItemHelp});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(691, 24);
            this.menuStrip2.TabIndex = 1;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // toolStripMenuItemFile
            // 
            this.toolStripMenuItemFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemExit});
            this.toolStripMenuItemFile.Name = "toolStripMenuItemFile";
            this.toolStripMenuItemFile.Size = new System.Drawing.Size(37, 20);
            this.toolStripMenuItemFile.Text = "File";
            // 
            // toolStripMenuItemExit
            // 
            this.toolStripMenuItemExit.Name = "toolStripMenuItemExit";
            this.toolStripMenuItemExit.Size = new System.Drawing.Size(93, 22);
            this.toolStripMenuItemExit.Text = "Exit";
            this.toolStripMenuItemExit.Click += new System.EventHandler(this.toolStripMenuItemExit_Click);
            // 
            // toolStripMenuItemAdmin
            // 
            this.toolStripMenuItemAdmin.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemPlants,
            this.toolStripMenuItemPlantTypes,
            this.toolStripMenuItemLocations,
            this.toolStripMenuItemActionTypes});
            this.toolStripMenuItemAdmin.Name = "toolStripMenuItemAdmin";
            this.toolStripMenuItemAdmin.Size = new System.Drawing.Size(55, 20);
            this.toolStripMenuItemAdmin.Text = "Admin";
            // 
            // toolStripMenuItemPlants
            // 
            this.toolStripMenuItemPlants.Name = "toolStripMenuItemPlants";
            this.toolStripMenuItemPlants.Size = new System.Drawing.Size(141, 22);
            this.toolStripMenuItemPlants.Text = "Plants";
            this.toolStripMenuItemPlants.Click += new System.EventHandler(this.toolStripMenuItemPlants_Click);
            // 
            // toolStripMenuItemPlantTypes
            // 
            this.toolStripMenuItemPlantTypes.Name = "toolStripMenuItemPlantTypes";
            this.toolStripMenuItemPlantTypes.Size = new System.Drawing.Size(141, 22);
            this.toolStripMenuItemPlantTypes.Text = "Plant Types";
            this.toolStripMenuItemPlantTypes.Click += new System.EventHandler(this.toolStripMenuItemPlantTypes_Click);
            // 
            // toolStripMenuItemLocations
            // 
            this.toolStripMenuItemLocations.Name = "toolStripMenuItemLocations";
            this.toolStripMenuItemLocations.Size = new System.Drawing.Size(141, 22);
            this.toolStripMenuItemLocations.Text = "Locations";
            this.toolStripMenuItemLocations.Click += new System.EventHandler(this.toolStripMenuItemLocations_Click);
            // 
            // toolStripMenuItemActionTypes
            // 
            this.toolStripMenuItemActionTypes.Name = "toolStripMenuItemActionTypes";
            this.toolStripMenuItemActionTypes.Size = new System.Drawing.Size(141, 22);
            this.toolStripMenuItemActionTypes.Text = "Action Types";
            this.toolStripMenuItemActionTypes.Click += new System.EventHandler(this.toolStripMenuItemActionTypes_Click);
            // 
            // toolStripMenuItemOverView
            // 
            this.toolStripMenuItemOverView.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemPlantTypesPerLocation,
            this.toolStripMenuItemPlantsPerLocation});
            this.toolStripMenuItemOverView.Name = "toolStripMenuItemOverView";
            this.toolStripMenuItemOverView.Size = new System.Drawing.Size(68, 20);
            this.toolStripMenuItemOverView.Text = "Overview";
            // 
            // toolStripMenuItemPlantTypesPerLocation
            // 
            this.toolStripMenuItemPlantTypesPerLocation.Name = "toolStripMenuItemPlantTypesPerLocation";
            this.toolStripMenuItemPlantTypesPerLocation.Size = new System.Drawing.Size(199, 22);
            this.toolStripMenuItemPlantTypesPerLocation.Text = "PlantTypes per Location";
            this.toolStripMenuItemPlantTypesPerLocation.Click += new System.EventHandler(this.toolStripMenuItemPlantTypesPerLocation_Click);
            // 
            // toolStripMenuItemPlantsPerLocation
            // 
            this.toolStripMenuItemPlantsPerLocation.Name = "toolStripMenuItemPlantsPerLocation";
            this.toolStripMenuItemPlantsPerLocation.Size = new System.Drawing.Size(199, 22);
            this.toolStripMenuItemPlantsPerLocation.Text = "Plants per Location";
            this.toolStripMenuItemPlantsPerLocation.Click += new System.EventHandler(this.toolStripMenuItemPlantsPerLocation_Click);
            // 
            // toolStripMenuItemHelp
            // 
            this.toolStripMenuItemHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemViewHelp,
            this.toolStripMenuItemAbout});
            this.toolStripMenuItemHelp.Name = "toolStripMenuItemHelp";
            this.toolStripMenuItemHelp.Size = new System.Drawing.Size(44, 20);
            this.toolStripMenuItemHelp.Text = "Help";
            // 
            // toolStripMenuItemViewHelp
            // 
            this.toolStripMenuItemViewHelp.Name = "toolStripMenuItemViewHelp";
            this.toolStripMenuItemViewHelp.Size = new System.Drawing.Size(165, 22);
            this.toolStripMenuItemViewHelp.Text = "View help";
            this.toolStripMenuItemViewHelp.Click += new System.EventHandler(this.toolStripMenuItemViewHelp_Click);
            // 
            // toolStripMenuItemAbout
            // 
            this.toolStripMenuItemAbout.Name = "toolStripMenuItemAbout";
            this.toolStripMenuItemAbout.Size = new System.Drawing.Size(165, 22);
            this.toolStripMenuItemAbout.Text = "About MyGarden";
            this.toolStripMenuItemAbout.Click += new System.EventHandler(this.toolStripMenuItemAbout_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(691, 527);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip2);
            this.Name = "FormMain";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "My Garden";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemAdmin;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemPlants;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemPlantTypes;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemLocations;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemOverView;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemPlantTypesPerLocation;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemPlantsPerLocation;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemActionTypes;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemFile;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemExit;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemHelp;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemViewHelp;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemAbout;
    }
}

