namespace MyGarden
{
    partial class UserControlPlantAdmin
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
            this.listBoxPlants = new System.Windows.Forms.ListBox();
            this.labelPlants = new System.Windows.Forms.Label();
            this.labelPlantName = new System.Windows.Forms.Label();
            this.labelPlantType = new System.Windows.Forms.Label();
            this.textBoxPlantName = new System.Windows.Forms.TextBox();
            this.comboBoxPlantTypes = new System.Windows.Forms.ComboBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.buttonExit = new System.Windows.Forms.Button();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxPlants
            // 
            this.listBoxPlants.FormattingEnabled = true;
            this.listBoxPlants.ItemHeight = 15;
            this.listBoxPlants.Location = new System.Drawing.Point(16, 35);
            this.listBoxPlants.Name = "listBoxPlants";
            this.listBoxPlants.Size = new System.Drawing.Size(159, 139);
            this.listBoxPlants.TabIndex = 0;
            this.listBoxPlants.SelectedIndexChanged += new System.EventHandler(this.listBoxPlants_SelectedIndexChanged);
            // 
            // labelPlants
            // 
            this.labelPlants.AllowDrop = true;
            this.labelPlants.AutoSize = true;
            this.labelPlants.Location = new System.Drawing.Point(16, 17);
            this.labelPlants.Name = "labelPlants";
            this.labelPlants.Size = new System.Drawing.Size(42, 15);
            this.labelPlants.TabIndex = 1;
            this.labelPlants.Text = "Plants:";
            // 
            // labelPlantName
            // 
            this.labelPlantName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelPlantName.AutoSize = true;
            this.labelPlantName.Location = new System.Drawing.Point(203, 17);
            this.labelPlantName.Name = "labelPlantName";
            this.labelPlantName.Size = new System.Drawing.Size(39, 15);
            this.labelPlantName.TabIndex = 2;
            this.labelPlantName.Text = "Name";
            // 
            // labelPlantType
            // 
            this.labelPlantType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelPlantType.AutoSize = true;
            this.labelPlantType.Location = new System.Drawing.Point(203, 73);
            this.labelPlantType.Name = "labelPlantType";
            this.labelPlantType.Size = new System.Drawing.Size(58, 15);
            this.labelPlantType.TabIndex = 3;
            this.labelPlantType.Text = "PlantType";
            // 
            // textBoxPlantName
            // 
            this.textBoxPlantName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxPlantName.Location = new System.Drawing.Point(203, 35);
            this.textBoxPlantName.Name = "textBoxPlantName";
            this.textBoxPlantName.Size = new System.Drawing.Size(303, 23);
            this.textBoxPlantName.TabIndex = 1;
            // 
            // comboBoxPlantTypes
            // 
            this.comboBoxPlantTypes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxPlantTypes.FormattingEnabled = true;
            this.comboBoxPlantTypes.Location = new System.Drawing.Point(203, 93);
            this.comboBoxPlantTypes.Name = "comboBoxPlantTypes";
            this.comboBoxPlantTypes.Size = new System.Drawing.Size(303, 23);
            this.comboBoxPlantTypes.TabIndex = 2;
            this.comboBoxPlantTypes.Enter += new System.EventHandler(this.comboBoxPlantTypes_Enter);
            // 
            // buttonSave
            // 
            this.buttonSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSave.Location = new System.Drawing.Point(431, 135);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 3;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(203, 135);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 5;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(284, 135);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonDelete.TabIndex = 4;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Location = new System.Drawing.Point(16, 190);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(490, 222);
            this.panel1.TabIndex = 6;
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(0, 22);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel});
            this.toolStrip1.Location = new System.Drawing.Point(0, 463);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(529, 25);
            this.toolStrip1.TabIndex = 14;
            this.toolStrip1.Text = "toolStrip";
            // 
            // toolStripLabel
            // 
            this.toolStripLabel.Name = "toolStripLabel";
            this.toolStripLabel.Size = new System.Drawing.Size(0, 22);
            // 
            // buttonExit
            // 
            this.buttonExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonExit.Location = new System.Drawing.Point(431, 428);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(75, 23);
            this.buttonExit.TabIndex = 7;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // UserControlPlantAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.comboBoxPlantTypes);
            this.Controls.Add(this.textBoxPlantName);
            this.Controls.Add(this.labelPlantType);
            this.Controls.Add(this.labelPlantName);
            this.Controls.Add(this.labelPlants);
            this.Controls.Add(this.listBoxPlants);
            this.Name = "UserControlPlantAdmin";
            this.Size = new System.Drawing.Size(529, 488);
            this.Load += new System.EventHandler(this.PlantListBox_Load);
            this.Leave += new System.EventHandler(this.UserControlPlantAdmin_Leave);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxPlants;
        private System.Windows.Forms.Label labelPlants;
        private System.Windows.Forms.Label labelPlantName;
        private System.Windows.Forms.Label labelPlantType;
        private System.Windows.Forms.TextBox textBoxPlantName;
        private System.Windows.Forms.ComboBox comboBoxPlantTypes;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel;
        private System.Windows.Forms.Button buttonExit;
    }
}
