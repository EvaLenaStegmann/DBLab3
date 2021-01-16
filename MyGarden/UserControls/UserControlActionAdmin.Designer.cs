namespace MyGarden
{
    partial class UserControlActionAdmin
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
            this.dataGridViewComboBoxColumn1 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewComboBoxColumn2 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.Location = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Plant = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.ActionType = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.ActionDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HarvestSeason = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewActions = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewActions)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewComboBoxColumn1
            // 
            this.dataGridViewComboBoxColumn1.HeaderText = "Location";
            this.dataGridViewComboBoxColumn1.Name = "dataGridViewComboBoxColumn1";
            this.dataGridViewComboBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // dataGridViewComboBoxColumn2
            // 
            this.dataGridViewComboBoxColumn2.HeaderText = "Action Type";
            this.dataGridViewComboBoxColumn2.Name = "dataGridViewComboBoxColumn2";
            this.dataGridViewComboBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Action Date";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, -2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 15);
            this.label1.TabIndex = 10;
            this.label1.Text = "Actions:";
            // 
            // Location
            // 
            this.Location.HeaderText = "Location:";
            this.Location.Name = "Location";
            this.Location.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Plant
            // 
            this.Plant.HeaderText = "Plant:";
            this.Plant.Name = "Plant";
            this.Plant.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // ActionType
            // 
            this.ActionType.HeaderText = "Action Type:";
            this.ActionType.Name = "ActionType";
            this.ActionType.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // ActionDate
            // 
            this.ActionDate.HeaderText = "Action Date:";
            this.ActionDate.Name = "ActionDate";
            this.ActionDate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // HarvestSeason
            // 
            this.HarvestSeason.HeaderText = "Harvest Season:";
            this.HarvestSeason.Name = "HarvestSeason";
            // 
            // dataGridViewActions
            // 
            this.dataGridViewActions.AllowUserToResizeRows = false;
            this.dataGridViewActions.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewActions.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewActions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewActions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Location,
            this.Plant,
            this.ActionType,
            this.ActionDate,
            this.HarvestSeason});
            this.dataGridViewActions.Location = new System.Drawing.Point(0, 18);
            this.dataGridViewActions.MultiSelect = false;
            this.dataGridViewActions.Name = "dataGridViewActions";
            this.dataGridViewActions.Size = new System.Drawing.Size(529, 227);
            this.dataGridViewActions.TabIndex = 9;
            this.dataGridViewActions.Text = "dataGridView1";
            this.dataGridViewActions.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dataGridViewActions_CellValidating);
            this.dataGridViewActions.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewActions_CellValueChanged);
            this.dataGridViewActions.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewActions_RowEnter);
            this.dataGridViewActions.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dataGridViewActions_UserDeletingRow);
            // 
            // UserControlActionAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridViewActions);
            this.Controls.Add(this.label1);
            this.Name = "UserControlActionAdmin";
            this.Size = new System.Drawing.Size(529, 245);
            this.Load += new System.EventHandler(this.UserControlActionAdmin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewActions)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewComboBoxColumn1;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewComboBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewActions;
        private System.Windows.Forms.DataGridViewComboBoxColumn Location;
        private System.Windows.Forms.DataGridViewComboBoxColumn Plant;
        private System.Windows.Forms.DataGridViewComboBoxColumn ActionType;
        private System.Windows.Forms.DataGridViewTextBoxColumn ActionDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn HarvestSeason;
    }
}
