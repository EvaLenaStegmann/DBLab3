namespace MyGarden
{
    partial class UserControlActionTypeAdmin
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
            this.labelActionTypes = new System.Windows.Forms.Label();
            this.listBoxActionTypes = new System.Windows.Forms.ListBox();
            this.labelActionTypeName = new System.Windows.Forms.Label();
            this.textBoxActionTypeName = new System.Windows.Forms.TextBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelActionTypes
            // 
            this.labelActionTypes.AllowDrop = true;
            this.labelActionTypes.AutoSize = true;
            this.labelActionTypes.Location = new System.Drawing.Point(16, 17);
            this.labelActionTypes.Name = "labelActionTypes";
            this.labelActionTypes.Size = new System.Drawing.Size(77, 15);
            this.labelActionTypes.TabIndex = 1;
            this.labelActionTypes.Text = "Action Types:";
            // 
            // listBoxActionTypes
            // 
            this.listBoxActionTypes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listBoxActionTypes.FormattingEnabled = true;
            this.listBoxActionTypes.ItemHeight = 15;
            this.listBoxActionTypes.Location = new System.Drawing.Point(16, 35);
            this.listBoxActionTypes.Name = "listBoxActionTypes";
            this.listBoxActionTypes.Size = new System.Drawing.Size(159, 409);
            this.listBoxActionTypes.TabIndex = 0;
            this.listBoxActionTypes.SelectedIndexChanged += new System.EventHandler(this.listBoxActionTypes_SelectedIndexChanged);
            // 
            // labelActionTypeName
            // 
            this.labelActionTypeName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelActionTypeName.AutoSize = true;
            this.labelActionTypeName.Location = new System.Drawing.Point(203, 17);
            this.labelActionTypeName.Name = "labelActionTypeName";
            this.labelActionTypeName.Size = new System.Drawing.Size(39, 15);
            this.labelActionTypeName.TabIndex = 2;
            this.labelActionTypeName.Text = "Name";
            // 
            // textBoxActionTypeName
            // 
            this.textBoxActionTypeName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxActionTypeName.Location = new System.Drawing.Point(203, 35);
            this.textBoxActionTypeName.Name = "textBoxActionTypeName";
            this.textBoxActionTypeName.Size = new System.Drawing.Size(303, 23);
            this.textBoxActionTypeName.TabIndex = 1;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(203, 78);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 9;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(284, 78);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonDelete.TabIndex = 8;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSave.Location = new System.Drawing.Point(431, 78);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 7;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
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
            // 
            // toolStripLabel
            // 
            this.toolStripLabel.Name = "toolStripLabel";
            this.toolStripLabel.Size = new System.Drawing.Size(0, 22);
            // 
            // UserControlActionTypeAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.textBoxActionTypeName);
            this.Controls.Add(this.labelActionTypeName);
            this.Controls.Add(this.listBoxActionTypes);
            this.Controls.Add(this.labelActionTypes);
            this.Name = "UserControlActionTypeAdmin";
            this.Size = new System.Drawing.Size(529, 488);
            this.Load += new System.EventHandler(this.UserControlActionTypeAdmin_Load);
            this.Leave += new System.EventHandler(this.UserControlActionTypeAdmin_Leave);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelActionTypes;
        private System.Windows.Forms.ListBox listBoxActionTypes;
        private System.Windows.Forms.Label labelActionTypeName;
        private System.Windows.Forms.TextBox textBoxActionTypeName;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel;
    }
}
