namespace PSS3.Forms
{
    partial class PrivateInfoMenu
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
            this.ListBoxPrivate = new MaterialSkin.Controls.MaterialListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LabelHead = new System.Windows.Forms.Label();
            this.LabelWarning = new System.Windows.Forms.Label();
            this.ButtonCopy = new Guna.UI2.WinForms.Guna2Button();
            this.ButtonClose = new Guna.UI2.WinForms.Guna2Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ListBoxPrivate
            // 
            this.ListBoxPrivate.BackColor = System.Drawing.Color.White;
            this.ListBoxPrivate.BorderColor = System.Drawing.Color.LightGray;
            this.ListBoxPrivate.Depth = 0;
            this.ListBoxPrivate.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ListBoxPrivate.Location = new System.Drawing.Point(12, 137);
            this.ListBoxPrivate.MouseState = MaterialSkin.MouseState.HOVER;
            this.ListBoxPrivate.Name = "ListBoxPrivate";
            this.ListBoxPrivate.SelectedIndex = -1;
            this.ListBoxPrivate.SelectedItem = null;
            this.ListBoxPrivate.Size = new System.Drawing.Size(297, 184);
            this.ListBoxPrivate.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.LabelHead);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(321, 77);
            this.panel1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PSS3.Properties.Resources.info;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 48);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // LabelHead
            // 
            this.LabelHead.AutoSize = true;
            this.LabelHead.Font = new System.Drawing.Font("SSTW20-Medium", 18F, System.Drawing.FontStyle.Bold);
            this.LabelHead.ForeColor = System.Drawing.Color.White;
            this.LabelHead.Location = new System.Drawing.Point(66, 24);
            this.LabelHead.Name = "LabelHead";
            this.LabelHead.Size = new System.Drawing.Size(211, 28);
            this.LabelHead.TabIndex = 3;
            this.LabelHead.Text = "PS3 Config State";
            // 
            // LabelWarning
            // 
            this.LabelWarning.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.LabelWarning.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LabelWarning.Font = new System.Drawing.Font("SCE-PS3 Rodin LATIN", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelWarning.Location = new System.Drawing.Point(12, 93);
            this.LabelWarning.Name = "LabelWarning";
            this.LabelWarning.Size = new System.Drawing.Size(297, 41);
            this.LabelWarning.TabIndex = 2;
            this.LabelWarning.Text = "System Config and Private Info!! \r\nDon\'t share this to anybody!";
            // 
            // ButtonCopy
            // 
            this.ButtonCopy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonCopy.BackColor = System.Drawing.Color.Transparent;
            this.ButtonCopy.BorderColor = System.Drawing.Color.White;
            this.ButtonCopy.BorderRadius = 3;
            this.ButtonCopy.BorderThickness = 2;
            this.ButtonCopy.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ButtonCopy.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ButtonCopy.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ButtonCopy.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ButtonCopy.FillColor = System.Drawing.Color.Black;
            this.ButtonCopy.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ButtonCopy.ForeColor = System.Drawing.Color.White;
            this.ButtonCopy.ImageSize = new System.Drawing.Size(40, 40);
            this.ButtonCopy.IndicateFocus = true;
            this.ButtonCopy.Location = new System.Drawing.Point(12, 327);
            this.ButtonCopy.Name = "ButtonCopy";
            this.ButtonCopy.Size = new System.Drawing.Size(141, 25);
            this.ButtonCopy.TabIndex = 22;
            this.ButtonCopy.Text = "Copy Selected Value";
            this.ButtonCopy.UseTransparentBackground = true;
            this.ButtonCopy.Click += new System.EventHandler(this.ButtonCopy_Click);
            // 
            // ButtonClose
            // 
            this.ButtonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonClose.BackColor = System.Drawing.Color.Transparent;
            this.ButtonClose.BorderColor = System.Drawing.Color.White;
            this.ButtonClose.BorderRadius = 3;
            this.ButtonClose.BorderThickness = 2;
            this.ButtonClose.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ButtonClose.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ButtonClose.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ButtonClose.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ButtonClose.FillColor = System.Drawing.Color.Black;
            this.ButtonClose.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ButtonClose.ForeColor = System.Drawing.Color.White;
            this.ButtonClose.ImageSize = new System.Drawing.Size(40, 40);
            this.ButtonClose.IndicateFocus = true;
            this.ButtonClose.Location = new System.Drawing.Point(168, 327);
            this.ButtonClose.Name = "ButtonClose";
            this.ButtonClose.Size = new System.Drawing.Size(141, 25);
            this.ButtonClose.TabIndex = 23;
            this.ButtonClose.Text = "Copy Selected Value";
            this.ButtonClose.UseTransparentBackground = true;
            this.ButtonClose.Click += new System.EventHandler(this.ButtonClose_Click);
            // 
            // PrivateInfoMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 373);
            this.Controls.Add(this.ButtonClose);
            this.Controls.Add(this.ButtonCopy);
            this.Controls.Add(this.LabelWarning);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ListBoxPrivate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "PrivateInfoMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "PrivateInfoMenu";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialListBox ListBoxPrivate;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label LabelHead;
        private System.Windows.Forms.Label LabelWarning;
        private Guna.UI2.WinForms.Guna2Button ButtonCopy;
        private Guna.UI2.WinForms.Guna2Button ButtonClose;
    }
}