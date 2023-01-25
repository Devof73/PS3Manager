namespace PSS3.Forms.Options
{
    partial class GeneralOptions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GeneralOptions));
            this.PanelHead = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LabelHead = new System.Windows.Forms.Label();
            this.ButtonDisop = new Guna.UI2.WinForms.Guna2Button();
            this.TS1 = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TS2 = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.label3 = new System.Windows.Forms.Label();
            this.TS4 = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.label4 = new System.Windows.Forms.Label();
            this.TS3 = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.ButtonOk = new Guna.UI2.WinForms.Guna2Button();
            this.ButtonCancel = new Guna.UI2.WinForms.Guna2Button();
            this.PanelHead.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.PanelHead.Size = new System.Drawing.Size(351, 76);
            this.PanelHead.TabIndex = 0;
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
            this.LabelHead.Size = new System.Drawing.Size(259, 33);
            this.LabelHead.TabIndex = 0;
            this.LabelHead.Text = "Manager Options";
            // 
            // ButtonDisop
            // 
            this.ButtonDisop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonDisop.BackColor = System.Drawing.Color.Transparent;
            this.ButtonDisop.BorderColor = System.Drawing.Color.White;
            this.ButtonDisop.BorderRadius = 5;
            this.ButtonDisop.BorderThickness = 2;
            this.ButtonDisop.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ButtonDisop.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ButtonDisop.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ButtonDisop.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ButtonDisop.FillColor = System.Drawing.Color.Black;
            this.ButtonDisop.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ButtonDisop.ForeColor = System.Drawing.Color.White;
            this.ButtonDisop.Image = ((System.Drawing.Image)(resources.GetObject("ButtonDisop.Image")));
            this.ButtonDisop.ImageSize = new System.Drawing.Size(40, 40);
            this.ButtonDisop.IndicateFocus = true;
            this.ButtonDisop.Location = new System.Drawing.Point(23, 219);
            this.ButtonDisop.Name = "ButtonDisop";
            this.ButtonDisop.Size = new System.Drawing.Size(316, 44);
            this.ButtonDisop.TabIndex = 21;
            this.ButtonDisop.Text = "Discord Options";
            this.ButtonDisop.UseTransparentBackground = true;
            this.ButtonDisop.Click += new System.EventHandler(this.ButtonDisop_Click);
            // 
            // TS1
            // 
            this.TS1.Animated = true;
            this.TS1.AutoRoundedCorners = true;
            this.TS1.BackColor = System.Drawing.Color.Transparent;
            this.TS1.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.TS1.CheckedState.FillColor = System.Drawing.Color.Blue;
            this.TS1.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.TS1.CheckedState.InnerColor = System.Drawing.Color.White;
            this.TS1.Location = new System.Drawing.Point(23, 104);
            this.TS1.Name = "TS1";
            this.TS1.Size = new System.Drawing.Size(35, 20);
            this.TS1.TabIndex = 23;
            this.TS1.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.TS1.UncheckedState.FillColor = System.Drawing.Color.Black;
            this.TS1.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.TS1.UncheckedState.InnerColor = System.Drawing.Color.White;
            this.TS1.UseTransparentBackground = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("SCE-PS3 Rodin LATIN", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(65, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 16);
            this.label1.TabIndex = 24;
            this.label1.Text = "Hide User Comment";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("SCE-PS3 Rodin LATIN", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(65, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 16);
            this.label2.TabIndex = 26;
            this.label2.Text = "Disable PSMAPI";
            // 
            // TS2
            // 
            this.TS2.Animated = true;
            this.TS2.AutoRoundedCorners = true;
            this.TS2.BackColor = System.Drawing.Color.Transparent;
            this.TS2.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.TS2.CheckedState.FillColor = System.Drawing.Color.Blue;
            this.TS2.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.TS2.CheckedState.InnerColor = System.Drawing.Color.White;
            this.TS2.Location = new System.Drawing.Point(23, 129);
            this.TS2.Name = "TS2";
            this.TS2.Size = new System.Drawing.Size(35, 20);
            this.TS2.TabIndex = 25;
            this.TS2.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.TS2.UncheckedState.FillColor = System.Drawing.Color.Black;
            this.TS2.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.TS2.UncheckedState.InnerColor = System.Drawing.Color.White;
            this.TS2.UseTransparentBackground = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("SCE-PS3 Rodin LATIN", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(65, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(223, 16);
            this.label3.TabIndex = 30;
            this.label3.Text = "Use LocalUsername Instead Of ID";
            // 
            // TS4
            // 
            this.TS4.Animated = true;
            this.TS4.AutoRoundedCorners = true;
            this.TS4.BackColor = System.Drawing.Color.Transparent;
            this.TS4.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.TS4.CheckedState.FillColor = System.Drawing.Color.Blue;
            this.TS4.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.TS4.CheckedState.InnerColor = System.Drawing.Color.White;
            this.TS4.Location = new System.Drawing.Point(23, 180);
            this.TS4.Name = "TS4";
            this.TS4.Size = new System.Drawing.Size(35, 20);
            this.TS4.TabIndex = 29;
            this.TS4.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.TS4.UncheckedState.FillColor = System.Drawing.Color.Black;
            this.TS4.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.TS4.UncheckedState.InnerColor = System.Drawing.Color.White;
            this.TS4.UseTransparentBackground = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("SCE-PS3 Rodin LATIN", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(65, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 16);
            this.label4.TabIndex = 28;
            this.label4.Text = "Hide Power Menu";
            // 
            // TS3
            // 
            this.TS3.Animated = true;
            this.TS3.AutoRoundedCorners = true;
            this.TS3.BackColor = System.Drawing.Color.Transparent;
            this.TS3.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.TS3.CheckedState.FillColor = System.Drawing.Color.Blue;
            this.TS3.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.TS3.CheckedState.InnerColor = System.Drawing.Color.White;
            this.TS3.Location = new System.Drawing.Point(23, 155);
            this.TS3.Name = "TS3";
            this.TS3.Size = new System.Drawing.Size(35, 20);
            this.TS3.TabIndex = 27;
            this.TS3.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.TS3.UncheckedState.FillColor = System.Drawing.Color.Black;
            this.TS3.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.TS3.UncheckedState.InnerColor = System.Drawing.Color.White;
            this.TS3.UseTransparentBackground = true;
            // 
            // ButtonOk
            // 
            this.ButtonOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonOk.BackColor = System.Drawing.Color.Transparent;
            this.ButtonOk.BorderColor = System.Drawing.Color.White;
            this.ButtonOk.BorderRadius = 5;
            this.ButtonOk.BorderThickness = 2;
            this.ButtonOk.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ButtonOk.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ButtonOk.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ButtonOk.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ButtonOk.FillColor = System.Drawing.Color.Black;
            this.ButtonOk.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ButtonOk.ForeColor = System.Drawing.Color.White;
            this.ButtonOk.ImageSize = new System.Drawing.Size(40, 40);
            this.ButtonOk.IndicateFocus = true;
            this.ButtonOk.Location = new System.Drawing.Point(216, 335);
            this.ButtonOk.Name = "ButtonOk";
            this.ButtonOk.Size = new System.Drawing.Size(123, 26);
            this.ButtonOk.TabIndex = 31;
            this.ButtonOk.Text = "Ok";
            this.ButtonOk.UseTransparentBackground = true;
            this.ButtonOk.Click += new System.EventHandler(this.ButtonOk_Click);
            // 
            // ButtonCancel
            // 
            this.ButtonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonCancel.BackColor = System.Drawing.Color.Transparent;
            this.ButtonCancel.BorderColor = System.Drawing.Color.White;
            this.ButtonCancel.BorderRadius = 5;
            this.ButtonCancel.BorderThickness = 2;
            this.ButtonCancel.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ButtonCancel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ButtonCancel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ButtonCancel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ButtonCancel.FillColor = System.Drawing.Color.Black;
            this.ButtonCancel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ButtonCancel.ForeColor = System.Drawing.Color.White;
            this.ButtonCancel.ImageSize = new System.Drawing.Size(40, 40);
            this.ButtonCancel.IndicateFocus = true;
            this.ButtonCancel.Location = new System.Drawing.Point(87, 335);
            this.ButtonCancel.Name = "ButtonCancel";
            this.ButtonCancel.Size = new System.Drawing.Size(123, 26);
            this.ButtonCancel.TabIndex = 32;
            this.ButtonCancel.Text = "Cancel";
            this.ButtonCancel.UseTransparentBackground = true;
            this.ButtonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
            // 
            // GeneralOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(351, 373);
            this.Controls.Add(this.ButtonCancel);
            this.Controls.Add(this.ButtonOk);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TS4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TS3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TS2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TS1);
            this.Controls.Add(this.ButtonDisop);
            this.Controls.Add(this.PanelHead);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(607, 533);
            this.MinimumSize = new System.Drawing.Size(337, 412);
            this.Name = "GeneralOptions";
            this.Opacity = 0D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "GeneralOptions";
            this.PanelHead.ResumeLayout(false);
            this.PanelHead.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PanelHead;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label LabelHead;
        private Guna.UI2.WinForms.Guna2Button ButtonDisop;
        private Guna.UI2.WinForms.Guna2ToggleSwitch TS1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2ToggleSwitch TS2;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2ToggleSwitch TS4;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2ToggleSwitch TS3;
        private Guna.UI2.WinForms.Guna2Button ButtonOk;
        private Guna.UI2.WinForms.Guna2Button ButtonCancel;
    }
}