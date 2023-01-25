namespace PSS3.Forms
{
    partial class YTForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(YTForm));
            this.PanelHead = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LabelHead = new System.Windows.Forms.Label();
            this.TXTURL = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.NUMINT = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.ButtonEnable = new Guna.UI2.WinForms.Guna2Button();
            this.ButtonCancel = new Guna.UI2.WinForms.Guna2Button();
            this.PanelHead.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUMINT)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelHead
            // 
            this.PanelHead.BackColor = System.Drawing.Color.Black;
            this.PanelHead.Controls.Add(this.pictureBox1);
            this.PanelHead.Controls.Add(this.LabelHead);
            this.PanelHead.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelHead.Location = new System.Drawing.Point(0, 0);
            this.PanelHead.Name = "PanelHead";
            this.PanelHead.Size = new System.Drawing.Size(361, 76);
            this.PanelHead.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PSS3.Properties.Resources.menu_48px1;
            this.pictureBox1.Location = new System.Drawing.Point(10, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 48);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // LabelHead
            // 
            this.LabelHead.AutoSize = true;
            this.LabelHead.Font = new System.Drawing.Font("SSTW20-Medium", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelHead.ForeColor = System.Drawing.Color.White;
            this.LabelHead.Location = new System.Drawing.Point(64, 22);
            this.LabelHead.Name = "LabelHead";
            this.LabelHead.Size = new System.Drawing.Size(143, 33);
            this.LabelHead.TabIndex = 0;
            this.LabelHead.Text = "YT Notify";
            // 
            // TXTURL
            // 
            this.TXTURL.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TXTURL.DefaultText = "";
            this.TXTURL.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TXTURL.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TXTURL.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TXTURL.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TXTURL.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TXTURL.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TXTURL.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TXTURL.Location = new System.Drawing.Point(28, 123);
            this.TXTURL.Name = "TXTURL";
            this.TXTURL.PasswordChar = '\0';
            this.TXTURL.PlaceholderText = "";
            this.TXTURL.SelectedText = "";
            this.TXTURL.Size = new System.Drawing.Size(317, 36);
            this.TXTURL.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("SSTW20-Medium", 12.75F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(28, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 20);
            this.label1.TabIndex = 23;
            this.label1.Text = "Stream URL:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("SSTW20-Medium", 12.75F);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(28, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 20);
            this.label2.TabIndex = 25;
            this.label2.Text = "Ping Every: Minutes";
            // 
            // NUMINT
            // 
            this.NUMINT.BackColor = System.Drawing.Color.Transparent;
            this.NUMINT.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.NUMINT.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.NUMINT.Location = new System.Drawing.Point(28, 186);
            this.NUMINT.Name = "NUMINT";
            this.NUMINT.Size = new System.Drawing.Size(317, 36);
            this.NUMINT.TabIndex = 26;
            // 
            // ButtonEnable
            // 
            this.ButtonEnable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonEnable.Animated = true;
            this.ButtonEnable.BackColor = System.Drawing.Color.Transparent;
            this.ButtonEnable.BorderColor = System.Drawing.Color.White;
            this.ButtonEnable.BorderRadius = 5;
            this.ButtonEnable.BorderThickness = 2;
            this.ButtonEnable.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonEnable.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ButtonEnable.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ButtonEnable.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ButtonEnable.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ButtonEnable.FillColor = System.Drawing.Color.Black;
            this.ButtonEnable.Font = new System.Drawing.Font("SCE-PS3 Rodin LATIN", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonEnable.ForeColor = System.Drawing.Color.White;
            this.ButtonEnable.ImageSize = new System.Drawing.Size(40, 45);
            this.ButtonEnable.Location = new System.Drawing.Point(255, 248);
            this.ButtonEnable.Name = "ButtonEnable";
            this.ButtonEnable.Size = new System.Drawing.Size(94, 27);
            this.ButtonEnable.TabIndex = 27;
            this.ButtonEnable.Text = "Enable";
            this.ButtonEnable.UseTransparentBackground = true;
            this.ButtonEnable.Click += new System.EventHandler(this.ButtonEnable_Click);
            // 
            // ButtonCancel
            // 
            this.ButtonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonCancel.Animated = true;
            this.ButtonCancel.BackColor = System.Drawing.Color.Transparent;
            this.ButtonCancel.BorderColor = System.Drawing.Color.White;
            this.ButtonCancel.BorderRadius = 5;
            this.ButtonCancel.BorderThickness = 2;
            this.ButtonCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonCancel.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ButtonCancel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ButtonCancel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ButtonCancel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ButtonCancel.FillColor = System.Drawing.Color.Black;
            this.ButtonCancel.Font = new System.Drawing.Font("SCE-PS3 Rodin LATIN", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonCancel.ForeColor = System.Drawing.Color.White;
            this.ButtonCancel.ImageSize = new System.Drawing.Size(40, 45);
            this.ButtonCancel.Location = new System.Drawing.Point(155, 248);
            this.ButtonCancel.Name = "ButtonCancel";
            this.ButtonCancel.Size = new System.Drawing.Size(94, 27);
            this.ButtonCancel.TabIndex = 28;
            this.ButtonCancel.Text = "Cancel";
            this.ButtonCancel.UseTransparentBackground = true;
            this.ButtonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
            // 
            // YTForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(361, 287);
            this.Controls.Add(this.ButtonCancel);
            this.Controls.Add(this.ButtonEnable);
            this.Controls.Add(this.NUMINT);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TXTURL);
            this.Controls.Add(this.PanelHead);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "YTForm";
            this.Text = "YTForm";
            this.PanelHead.ResumeLayout(false);
            this.PanelHead.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUMINT)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PanelHead;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label LabelHead;
        private Guna.UI2.WinForms.Guna2TextBox TXTURL;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2NumericUpDown NUMINT;
        private Guna.UI2.WinForms.Guna2Button ButtonEnable;
        private Guna.UI2.WinForms.Guna2Button ButtonCancel;
    }
}