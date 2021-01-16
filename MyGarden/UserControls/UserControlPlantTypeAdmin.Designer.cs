namespace MyGarden
{
    partial class UserControlPlantTypeAdmin
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
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.textBoxPlantTypeName = new System.Windows.Forms.TextBox();
            this.labelPlantTypeName = new System.Windows.Forms.Label();
            this.labelPlantTypes = new System.Windows.Forms.Label();
            this.listBoxPlantTypes = new System.Windows.Forms.ListBox();
            this.textBoxSoil = new System.Windows.Forms.TextBox();
            this.labelSoil = new System.Windows.Forms.Label();
            this.textBoxNutrition = new System.Windows.Forms.TextBox();
            this.labelNutrition = new System.Windows.Forms.Label();
            this.textBoxInfo = new System.Windows.Forms.TextBox();
            this.labelInfo = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.groupBoxPerennial = new System.Windows.Forms.GroupBox();
            this.radioButtonNo = new System.Windows.Forms.RadioButton();
            this.radioButtonYes = new System.Windows.Forms.RadioButton();
            this.buttonExit = new System.Windows.Forms.Button();
            this.toolStrip1.SuspendLayout();
            this.groupBoxPerennial.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonDelete
            // 
            this.buttonDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonDelete.Location = new System.Drawing.Point(284, 387);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonDelete.TabIndex = 8;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonAdd.Location = new System.Drawing.Point(203, 387);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 9;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSave.Location = new System.Drawing.Point(431, 387);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 7;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // textBoxPlantTypeName
            // 
            this.textBoxPlantTypeName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxPlantTypeName.Location = new System.Drawing.Point(203, 35);
            this.textBoxPlantTypeName.Name = "textBoxPlantTypeName";
            this.textBoxPlantTypeName.Size = new System.Drawing.Size(303, 23);
            this.textBoxPlantTypeName.TabIndex = 1;
            // 
            // labelPlantTypeName
            // 
            this.labelPlantTypeName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelPlantTypeName.AutoSize = true;
            this.labelPlantTypeName.Location = new System.Drawing.Point(203, 17);
            this.labelPlantTypeName.Name = "labelPlantTypeName";
            this.labelPlantTypeName.Size = new System.Drawing.Size(39, 15);
            this.labelPlantTypeName.TabIndex = 2;
            this.labelPlantTypeName.Text = "Name";
            // 
            // labelPlantTypes
            // 
            this.labelPlantTypes.AllowDrop = true;
            this.labelPlantTypes.AutoSize = true;
            this.labelPlantTypes.Location = new System.Drawing.Point(16, 17);
            this.labelPlantTypes.Name = "labelPlantTypes";
            this.labelPlantTypes.Size = new System.Drawing.Size(69, 15);
            this.labelPlantTypes.TabIndex = 1;
            this.labelPlantTypes.Text = "Plant Types:";
            // 
            // listBoxPlantTypes
            // 
            this.listBoxPlantTypes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listBoxPlantTypes.FormattingEnabled = true;
            this.listBoxPlantTypes.ItemHeight = 15;
            this.listBoxPlantTypes.Location = new System.Drawing.Point(16, 35);
            this.listBoxPlantTypes.Name = "listBoxPlantTypes";
            this.listBoxPlantTypes.Size = new System.Drawing.Size(159, 409);
            this.listBoxPlantTypes.TabIndex = 0;
            this.listBoxPlantTypes.SelectedIndexChanged += new System.EventHandler(this.listBoxPlantTypes_SelectedIndexChanged);
            // 
            // textBoxSoil
            // 
            this.textBoxSoil.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSoil.Location = new System.Drawing.Point(203, 166);
            this.textBoxSoil.Multiline = true;
            this.textBoxSoil.Name = "textBoxSoil";
            this.textBoxSoil.Size = new System.Drawing.Size(303, 42);
            this.textBoxSoil.TabIndex = 4;
            // 
            // labelSoil
            // 
            this.labelSoil.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelSoil.AutoSize = true;
            this.labelSoil.Location = new System.Drawing.Point(203, 148);
            this.labelSoil.Name = "labelSoil";
            this.labelSoil.Size = new System.Drawing.Size(26, 15);
            this.labelSoil.TabIndex = 2;
            this.labelSoil.Text = "Soil";
            // 
            // textBoxNutrition
            // 
            this.textBoxNutrition.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxNutrition.Location = new System.Drawing.Point(203, 236);
            this.textBoxNutrition.Multiline = true;
            this.textBoxNutrition.Name = "textBoxNutrition";
            this.textBoxNutrition.Size = new System.Drawing.Size(303, 42);
            this.textBoxNutrition.TabIndex = 5;
            // 
            // labelNutrition
            // 
            this.labelNutrition.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelNutrition.AutoSize = true;
            this.labelNutrition.Location = new System.Drawing.Point(203, 218);
            this.labelNutrition.Name = "labelNutrition";
            this.labelNutrition.Size = new System.Drawing.Size(55, 15);
            this.labelNutrition.TabIndex = 2;
            this.labelNutrition.Text = "Nutrition";
            // 
            // textBoxInfo
            // 
            this.textBoxInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxInfo.Location = new System.Drawing.Point(203, 306);
            this.textBoxInfo.Multiline = true;
            this.textBoxInfo.Name = "textBoxInfo";
            this.textBoxInfo.Size = new System.Drawing.Size(303, 70);
            this.textBoxInfo.TabIndex = 6;
            // 
            // labelInfo
            // 
            this.labelInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelInfo.AutoSize = true;
            this.labelInfo.Location = new System.Drawing.Point(203, 288);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(28, 15);
            this.labelInfo.TabIndex = 2;
            this.labelInfo.Text = "Info";
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
            // 
            // toolStripLabel
            // 
            this.toolStripLabel.Name = "toolStripLabel";
            this.toolStripLabel.Size = new System.Drawing.Size(0, 22);
            // 
            // groupBoxPerennial
            // 
            this.groupBoxPerennial.Controls.Add(this.radioButtonNo);
            this.groupBoxPerennial.Controls.Add(this.radioButtonYes);
            this.groupBoxPerennial.Location = new System.Drawing.Point(203, 69);
            this.groupBoxPerennial.Name = "groupBoxPerennial";
            this.groupBoxPerennial.Size = new System.Drawing.Size(82, 72);
            this.groupBoxPerennial.TabIndex = 2;
            this.groupBoxPerennial.TabStop = false;
            this.groupBoxPerennial.Text = "Perennial";
            // 
            // radioButtonNo
            // 
            this.radioButtonNo.AutoSize = true;
            this.radioButtonNo.Location = new System.Drawing.Point(6, 44);
            this.radioButtonNo.Name = "radioButtonNo";
            this.radioButtonNo.Size = new System.Drawing.Size(41, 19);
            this.radioButtonNo.TabIndex = 3;
            this.radioButtonNo.TabStop = true;
            this.radioButtonNo.Text = "No";
            this.radioButtonNo.UseVisualStyleBackColor = true;
            // 
            // radioButtonYes
            // 
            this.radioButtonYes.AutoSize = true;
            this.radioButtonYes.Location = new System.Drawing.Point(6, 19);
            this.radioButtonYes.Name = "radioButtonYes";
            this.radioButtonYes.Size = new System.Drawing.Size(42, 19);
            this.radioButtonYes.TabIndex = 2;
            this.radioButtonYes.TabStop = true;
            this.radioButtonYes.Text = "Yes";
            this.radioButtonYes.UseVisualStyleBackColor = true;
            // 
            // buttonExit
            // 
            this.buttonExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonExit.Location = new System.Drawing.Point(431, 428);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(75, 23);
            this.buttonExit.TabIndex = 10;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // UserControlPlantTypeAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.groupBoxPerennial);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.labelInfo);
            this.Controls.Add(this.textBoxInfo);
            this.Controls.Add(this.labelNutrition);
            this.Controls.Add(this.textBoxNutrition);
            this.Controls.Add(this.labelSoil);
            this.Controls.Add(this.textBoxSoil);
            this.Controls.Add(this.listBoxPlantTypes);
            this.Controls.Add(this.labelPlantTypes);
            this.Controls.Add(this.labelPlantTypeName);
            this.Controls.Add(this.textBoxPlantTypeName);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonDelete);
            this.Name = "UserControlPlantTypeAdmin";
            this.Size = new System.Drawing.Size(529, 488);
            this.Load += new System.EventHandler(this.UserControlPlantTypeAdmin_Load);
            this.Leave += new System.EventHandler(this.UserControlPlantTypeAdmin_Leave);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBoxPerennial.ResumeLayout(false);
            this.groupBoxPerennial.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.TextBox textBoxPlantTypeName;
        private System.Windows.Forms.Label labelPlantTypeName;
        private System.Windows.Forms.Label labelInfo;
        private System.Windows.Forms.ListBox listBoxPlantTypes;
        private System.Windows.Forms.Label labelPlantTypes;
        private System.Windows.Forms.TextBox textBoxSoil;
        private System.Windows.Forms.Label labelSoil;
        private System.Windows.Forms.TextBox textBoxNutrition;
        private System.Windows.Forms.Label labelNutrition;
        private System.Windows.Forms.TextBox textBoxInfo;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel;
        private System.Windows.Forms.GroupBox groupBoxPerennial;
        private System.Windows.Forms.RadioButton radioButtonNo;
        private System.Windows.Forms.RadioButton radioButtonYes;
        private System.Windows.Forms.Button buttonExit;
    }
}
