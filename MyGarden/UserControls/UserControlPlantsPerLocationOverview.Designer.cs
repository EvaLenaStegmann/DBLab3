namespace MyGarden
{
    partial class UserControlPlantsPerLocationOverview
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Season = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LocationName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewPlantTypesPerLocation = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPlantTypesPerLocation)).BeginInit();
            this.SuspendLayout();
            // 
            // Season
            // 
            this.Season.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Season.Frozen = true;
            this.Season.HeaderText = "Season:";
            this.Season.MinimumWidth = 70;
            this.Season.Name = "Season";
            this.Season.ReadOnly = true;
            this.Season.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Season.Width = 70;
            // 
            // LocationName
            // 
            this.LocationName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.LocationName.HeaderText = "Location:";
            this.LocationName.Name = "LocationName";
            this.LocationName.ReadOnly = true;
            this.LocationName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // dataGridViewPlantTypesPerLocation
            // 
            this.dataGridViewPlantTypesPerLocation.AllowUserToAddRows = false;
            this.dataGridViewPlantTypesPerLocation.AllowUserToDeleteRows = false;
            this.dataGridViewPlantTypesPerLocation.AllowUserToOrderColumns = true;
            this.dataGridViewPlantTypesPerLocation.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewPlantTypesPerLocation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPlantTypesPerLocation.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Season,
            this.LocationName});
            this.dataGridViewPlantTypesPerLocation.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewPlantTypesPerLocation.Name = "dataGridViewPlantTypesPerLocation";
            this.dataGridViewPlantTypesPerLocation.ReadOnly = true;
            this.dataGridViewPlantTypesPerLocation.RowHeadersVisible = false;
            this.dataGridViewPlantTypesPerLocation.Size = new System.Drawing.Size(529, 488);
            this.dataGridViewPlantTypesPerLocation.TabIndex = 0;
            this.dataGridViewPlantTypesPerLocation.Text = "dataGridView1";
            // 
            // UserControlPlantTypesPerLocationOverview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridViewPlantTypesPerLocation);
            this.Name = "UserControlPlantTypesPerLocationOverview";
            this.Size = new System.Drawing.Size(529, 488);
            this.Load += new System.EventHandler(this.UserControlPlantTypesPerLocationOverview_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPlantTypesPerLocation)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridViewPlantTypesPerLocation;
        private System.Windows.Forms.DataGridViewTextBoxColumn Season;
        private System.Windows.Forms.DataGridViewTextBoxColumn LocationName;
    }
}
