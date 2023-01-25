namespace xRegistryEditor
{
    partial class Main
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addSettingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToWikitextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToTextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.halpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.lvEntries = new System.Windows.Forms.ListView();
            this.chChecksum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chSetting = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chValue = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chHeaderValue = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chFlags = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtSetting = new System.Windows.Forms.TextBox();
            this.lblFlags = new System.Windows.Forms.Label();
            this.txtFlags = new System.Windows.Forms.TextBox();
            this.cmdSave = new System.Windows.Forms.Button();
            this.lblValue = new System.Windows.Forms.Label();
            this.txtValue = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.aboutToolStripMenuItem,
            this.halpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(830, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.closeToolStripMenuItem,
            this.toolStripMenuItem1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(149, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addSettingToolStripMenuItem,
            this.exportToWikitextToolStripMenuItem,
            this.exportToTextToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // addSettingToolStripMenuItem
            // 
            this.addSettingToolStripMenuItem.Name = "addSettingToolStripMenuItem";
            this.addSettingToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.addSettingToolStripMenuItem.Text = "Add Setting";
            this.addSettingToolStripMenuItem.Click += new System.EventHandler(this.addSettingToolStripMenuItem_Click);
            // 
            // exportToWikitextToolStripMenuItem
            // 
            this.exportToWikitextToolStripMenuItem.Name = "exportToWikitextToolStripMenuItem";
            this.exportToWikitextToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.exportToWikitextToolStripMenuItem.Text = "Export to Wikitext";
            this.exportToWikitextToolStripMenuItem.Click += new System.EventHandler(this.exportToWikitextToolStripMenuItem_Click);
            // 
            // exportToTextToolStripMenuItem
            // 
            this.exportToTextToolStripMenuItem.Name = "exportToTextToolStripMenuItem";
            this.exportToTextToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.exportToTextToolStripMenuItem.Text = "Export to text";
            this.exportToTextToolStripMenuItem.Click += new System.EventHandler(this.exportToTextToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // halpToolStripMenuItem
            // 
            this.halpToolStripMenuItem.Name = "halpToolStripMenuItem";
            this.halpToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.halpToolStripMenuItem.Text = "Halp!";
            this.halpToolStripMenuItem.Click += new System.EventHandler(this.halpToolStripMenuItem_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 24);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.lvEntries);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.txtSetting);
            this.splitContainer1.Panel2.Controls.Add(this.lblFlags);
            this.splitContainer1.Panel2.Controls.Add(this.txtFlags);
            this.splitContainer1.Panel2.Controls.Add(this.cmdSave);
            this.splitContainer1.Panel2.Controls.Add(this.lblValue);
            this.splitContainer1.Panel2.Controls.Add(this.txtValue);
            this.splitContainer1.Panel2.Controls.Add(this.txtID);
            this.splitContainer1.Panel2.Controls.Add(this.lblID);
            this.splitContainer1.Size = new System.Drawing.Size(830, 362);
            this.splitContainer1.SplitterDistance = 564;
            this.splitContainer1.TabIndex = 1;
            // 
            // lvEntries
            // 
            this.lvEntries.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chChecksum,
            this.chSetting,
            this.chValue,
            this.chHeaderValue,
            this.chFlags});
            this.lvEntries.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvEntries.FullRowSelect = true;
            this.lvEntries.Location = new System.Drawing.Point(0, 0);
            this.lvEntries.Name = "lvEntries";
            this.lvEntries.Size = new System.Drawing.Size(564, 362);
            this.lvEntries.TabIndex = 0;
            this.lvEntries.UseCompatibleStateImageBehavior = false;
            this.lvEntries.View = System.Windows.Forms.View.Details;
            this.lvEntries.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.lvEntries_ColumnClick);
            this.lvEntries.SelectedIndexChanged += new System.EventHandler(this.lvEntries_SelectedIndexChanged);
            // 
            // chChecksum
            // 
            this.chChecksum.Text = "Checksum";
            this.chChecksum.Width = 64;
            // 
            // chSetting
            // 
            this.chSetting.Text = "Setting";
            this.chSetting.Width = 181;
            // 
            // chValue
            // 
            this.chValue.Text = "Value";
            this.chValue.Width = 145;
            // 
            // chHeaderValue
            // 
            this.chHeaderValue.Text = "Header Value";
            this.chHeaderValue.Width = 81;
            // 
            // chFlags
            // 
            this.chFlags.Text = "Flags";
            this.chFlags.Width = 56;
            // 
            // txtSetting
            // 
            this.txtSetting.Location = new System.Drawing.Point(17, 19);
            this.txtSetting.Name = "txtSetting";
            this.txtSetting.ReadOnly = true;
            this.txtSetting.Size = new System.Drawing.Size(233, 20);
            this.txtSetting.TabIndex = 9;
            // 
            // lblFlags
            // 
            this.lblFlags.AutoSize = true;
            this.lblFlags.Location = new System.Drawing.Point(26, 176);
            this.lblFlags.Name = "lblFlags";
            this.lblFlags.Size = new System.Drawing.Size(32, 13);
            this.lblFlags.TabIndex = 8;
            this.lblFlags.Text = "Flags";
            // 
            // txtFlags
            // 
            this.txtFlags.Location = new System.Drawing.Point(40, 195);
            this.txtFlags.Name = "txtFlags";
            this.txtFlags.Size = new System.Drawing.Size(197, 20);
            this.txtFlags.TabIndex = 7;
            // 
            // cmdSave
            // 
            this.cmdSave.Location = new System.Drawing.Point(59, 266);
            this.cmdSave.Name = "cmdSave";
            this.cmdSave.Size = new System.Drawing.Size(143, 31);
            this.cmdSave.TabIndex = 6;
            this.cmdSave.Text = "Save";
            this.cmdSave.UseVisualStyleBackColor = true;
            this.cmdSave.Click += new System.EventHandler(this.cmdSave_Click);
            // 
            // lblValue
            // 
            this.lblValue.AutoSize = true;
            this.lblValue.Location = new System.Drawing.Point(26, 124);
            this.lblValue.Name = "lblValue";
            this.lblValue.Size = new System.Drawing.Size(34, 13);
            this.lblValue.TabIndex = 4;
            this.lblValue.Text = "Value";
            // 
            // txtValue
            // 
            this.txtValue.Location = new System.Drawing.Point(40, 143);
            this.txtValue.Name = "txtValue";
            this.txtValue.Size = new System.Drawing.Size(197, 20);
            this.txtValue.TabIndex = 3;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(40, 90);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(197, 20);
            this.txtID.TabIndex = 1;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(26, 74);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(57, 13);
            this.lblID.TabIndex = 0;
            this.lblID.Text = "Checksum";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 386);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.Text = "xRegistry.sys Editor - v0.75 - by stoker25";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ListView lvEntries;
        private System.Windows.Forms.ColumnHeader chChecksum;
        private System.Windows.Forms.ColumnHeader chSetting;
        private System.Windows.Forms.ColumnHeader chValue;
        private System.Windows.Forms.Label lblValue;
        private System.Windows.Forms.TextBox txtValue;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Button cmdSave;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ColumnHeader chHeaderValue;
        private System.Windows.Forms.ColumnHeader chFlags;
        private System.Windows.Forms.Label lblFlags;
        private System.Windows.Forms.TextBox txtFlags;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addSettingToolStripMenuItem;
        private System.Windows.Forms.TextBox txtSetting;
        private System.Windows.Forms.ToolStripMenuItem exportToWikitextToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportToTextToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem halpToolStripMenuItem;
    }
}

