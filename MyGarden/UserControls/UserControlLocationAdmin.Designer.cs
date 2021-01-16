namespace MyGarden
{
    partial class UserControlLocationAdmin
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
            this.textBoxLocationName = new System.Windows.Forms.TextBox();
            this.labelLocationName = new System.Windows.Forms.Label();
            this.labelLocations = new System.Windows.Forms.Label();
            this.listBoxLocations = new System.Windows.Forms.ListBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonExit = new System.Windows.Forms.Button();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(292, 74);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonDelete.TabIndex = 3;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(203, 74);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 4;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSave.Location = new System.Drawing.Point(431, 74);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 2;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // textBoxLocationName
            // 
            this.textBoxLocationName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxLocationName.Location = new System.Drawing.Point(203, 35);
            this.textBoxLocationName.Name = "textBoxLocationName";
            this.textBoxLocationName.Size = new System.Drawing.Size(303, 23);
            this.textBoxLocationName.TabIndex = 1;
            // 
            // labelLocationName
            // 
            this.labelLocationName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelLocationName.AutoSize = true;
            this.labelLocationName.Location = new System.Drawing.Point(203, 17);
            this.labelLocationName.Name = "labelLocationName";
            this.labelLocationName.Size = new System.Drawing.Size(39, 15);
            this.labelLocationName.TabIndex = 2;
            this.labelLocationName.Text = "Name";
            // 
            // labelLocations
            // 
            this.labelLocations.AllowDrop = true;
            this.labelLocations.AutoSize = true;
            this.labelLocations.Location = new System.Drawing.Point(16, 17);
            this.labelLocations.Name = "labelLocations";
            this.labelLocations.Size = new System.Drawing.Size(61, 15);
            this.labelLocations.TabIndex = 1;
            this.labelLocations.Text = "Locations:";
            // 
            // listBoxLocations
            // 
            this.listBoxLocations.FormattingEnabled = true;
            this.listBoxLocations.ItemHeight = 15;
            this.listBoxLocations.Location = new System.Drawing.Point(16, 35);
            this.listBoxLocations.Name = "listBoxLocations";
            this.listBoxLocations.Size = new System.Drawing.Size(159, 139);
            this.listBoxLocations.TabIndex = 0;
            this.listBoxLocations.SelectedIndexChanged += new System.EventHandler(this.listBoxLocations_SelectedIndexChanged);
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
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Location = new System.Drawing.Point(16, 190);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(490, 222);
            this.panel1.TabIndex = 7;
            // 
            // buttonExit
            // 
            this.buttonExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonExit.Location = new System.Drawing.Point(431, 428);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(75, 23);
            this.buttonExit.TabIndex = 6;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // UserControlLocationAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.listBoxLocations);
            this.Controls.Add(this.labelLocations);
            this.Controls.Add(this.labelLocationName);
            this.Controls.Add(this.textBoxLocationName);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonDelete);
            this.Name = "UserControlLocationAdmin";
            this.Size = new System.Drawing.Size(529, 488);
            this.Load += new System.EventHandler(this.UserControlLocationAdmin_Load);
            this.Leave += new System.EventHandler(this.UserControlLocationAdmin_Leave);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.TextBox textBoxLocationName;
        private System.Windows.Forms.Label labelLocationName;
        private System.Windows.Forms.Label labelLocations;
        private System.Windows.Forms.ListBox listBoxLocations;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonExit;
    }
}
