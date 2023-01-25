namespace PSS3
{
    partial class Main
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.TextBoxAddress = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ButtonStart = new Guna.UI2.WinForms.Guna2Button();
            this.MainContainer = new Guna.UI2.WinForms.Guna2Panel();
            this.TXT_PWD = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TXT_USNM = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ButtonIp = new Guna.UI2.WinForms.Guna2Button();
            this.label2 = new System.Windows.Forms.Label();
            this.TextBoxPort = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.SubtitleLabel = new System.Windows.Forms.Label();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.MainContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // TextBoxAddress
            // 
            this.TextBoxAddress.Animated = true;
            this.TextBoxAddress.BorderRadius = 2;
            this.TextBoxAddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxAddress.DefaultText = "";
            this.TextBoxAddress.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBoxAddress.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBoxAddress.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBoxAddress.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBoxAddress.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBoxAddress.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBoxAddress.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBoxAddress.Location = new System.Drawing.Point(16, 125);
            this.TextBoxAddress.Name = "TextBoxAddress";
            this.TextBoxAddress.PasswordChar = '\0';
            this.TextBoxAddress.PlaceholderText = "";
            this.TextBoxAddress.SelectedText = "";
            this.TextBoxAddress.Size = new System.Drawing.Size(284, 43);
            this.TextBoxAddress.TabIndex = 0;
            this.TextBoxAddress.TextChanged += new System.EventHandler(this.TextBoxAddress_TextChanged);
            this.TextBoxAddress.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxAddress_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("SCE-PS3 Rodin LATIN", 12.9F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(12, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "PS3 System Address";
            // 
            // ButtonStart
            // 
            this.ButtonStart.Animated = true;
            this.ButtonStart.BorderRadius = 2;
            this.ButtonStart.FillColor = System.Drawing.Color.Black;
            this.ButtonStart.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ButtonStart.ForeColor = System.Drawing.Color.White;
            this.ButtonStart.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(52)))), ((int)(((byte)(166)))));
            this.ButtonStart.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(82)))), ((int)(((byte)(196)))));
            this.ButtonStart.Location = new System.Drawing.Point(16, 264);
            this.ButtonStart.Name = "ButtonStart";
            this.ButtonStart.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(82)))), ((int)(((byte)(196)))));
            this.ButtonStart.Size = new System.Drawing.Size(174, 23);
            this.ButtonStart.TabIndex = 3;
            this.ButtonStart.Text = "Login";
            this.ButtonStart.Click += new System.EventHandler(this.ButtonStart_Click);
            // 
            // MainContainer
            // 
            this.MainContainer.Controls.Add(this.TXT_PWD);
            this.MainContainer.Controls.Add(this.label4);
            this.MainContainer.Controls.Add(this.TXT_USNM);
            this.MainContainer.Controls.Add(this.label3);
            this.MainContainer.Controls.Add(this.ButtonIp);
            this.MainContainer.Controls.Add(this.label2);
            this.MainContainer.Controls.Add(this.TextBoxPort);
            this.MainContainer.Controls.Add(this.guna2PictureBox1);
            this.MainContainer.Controls.Add(this.SubtitleLabel);
            this.MainContainer.Controls.Add(this.TitleLabel);
            this.MainContainer.Controls.Add(this.TextBoxAddress);
            this.MainContainer.Controls.Add(this.ButtonStart);
            this.MainContainer.Controls.Add(this.label1);
            this.MainContainer.Location = new System.Drawing.Point(12, 12);
            this.MainContainer.Name = "MainContainer";
            this.MainContainer.Size = new System.Drawing.Size(381, 308);
            this.MainContainer.TabIndex = 4;
            this.MainContainer.Paint += new System.Windows.Forms.PaintEventHandler(this.MainContainer_Paint);
            this.MainContainer.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.MainContainer_PreviewKeyDown);
            // 
            // TXT_PWD
            // 
            this.TXT_PWD.Animated = true;
            this.TXT_PWD.BorderRadius = 2;
            this.TXT_PWD.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TXT_PWD.DefaultText = "";
            this.TXT_PWD.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TXT_PWD.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TXT_PWD.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TXT_PWD.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TXT_PWD.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TXT_PWD.Font = new System.Drawing.Font("SCE-PS3 Rodin LATIN", 8.9F, System.Drawing.FontStyle.Bold);
            this.TXT_PWD.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TXT_PWD.Location = new System.Drawing.Point(16, 235);
            this.TXT_PWD.Name = "TXT_PWD";
            this.TXT_PWD.PasswordChar = '\0';
            this.TXT_PWD.PlaceholderText = "ANONYMOUS";
            this.TXT_PWD.SelectedText = "";
            this.TXT_PWD.Size = new System.Drawing.Size(348, 23);
            this.TXT_PWD.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("SCE-PS3 Rodin LATIN", 8.9F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(13, 218);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 14);
            this.label4.TabIndex = 12;
            this.label4.Text = "Password";
            // 
            // TXT_USNM
            // 
            this.TXT_USNM.Animated = true;
            this.TXT_USNM.BorderRadius = 2;
            this.TXT_USNM.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TXT_USNM.DefaultText = "";
            this.TXT_USNM.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TXT_USNM.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TXT_USNM.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TXT_USNM.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TXT_USNM.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TXT_USNM.Font = new System.Drawing.Font("SCE-PS3 Rodin LATIN", 8.9F, System.Drawing.FontStyle.Bold);
            this.TXT_USNM.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TXT_USNM.Location = new System.Drawing.Point(16, 188);
            this.TXT_USNM.Name = "TXT_USNM";
            this.TXT_USNM.PasswordChar = '\0';
            this.TXT_USNM.PlaceholderText = "ANONYMOUS";
            this.TXT_USNM.SelectedText = "";
            this.TXT_USNM.Size = new System.Drawing.Size(348, 23);
            this.TXT_USNM.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("SCE-PS3 Rodin LATIN", 8.9F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(13, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 14);
            this.label3.TabIndex = 10;
            this.label3.Text = "Username";
            // 
            // ButtonIp
            // 
            this.ButtonIp.Animated = true;
            this.ButtonIp.BorderRadius = 2;
            this.ButtonIp.FillColor = System.Drawing.Color.Black;
            this.ButtonIp.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ButtonIp.ForeColor = System.Drawing.Color.White;
            this.ButtonIp.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(52)))), ((int)(((byte)(166)))));
            this.ButtonIp.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(82)))), ((int)(((byte)(196)))));
            this.ButtonIp.Location = new System.Drawing.Point(196, 264);
            this.ButtonIp.Name = "ButtonIp";
            this.ButtonIp.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(82)))), ((int)(((byte)(196)))));
            this.ButtonIp.Size = new System.Drawing.Size(168, 23);
            this.ButtonIp.TabIndex = 9;
            this.ButtonIp.Text = "Last System Data";
            this.ButtonIp.Click += new System.EventHandler(this.ButtonIp_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("SCE-PS3 Rodin LATIN", 12.9F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(302, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 23);
            this.label2.TabIndex = 8;
            this.label2.Text = "Port";
            // 
            // TextBoxPort
            // 
            this.TextBoxPort.Animated = true;
            this.TextBoxPort.BorderRadius = 2;
            this.TextBoxPort.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxPort.DefaultText = "";
            this.TextBoxPort.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBoxPort.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBoxPort.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBoxPort.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBoxPort.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBoxPort.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBoxPort.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBoxPort.Location = new System.Drawing.Point(306, 125);
            this.TextBoxPort.MaxLength = 4;
            this.TextBoxPort.Name = "TextBoxPort";
            this.TextBoxPort.PasswordChar = '\0';
            this.TextBoxPort.PlaceholderText = "";
            this.TextBoxPort.SelectedText = "";
            this.TextBoxPort.Size = new System.Drawing.Size(58, 43);
            this.TextBoxPort.TabIndex = 7;
            this.TextBoxPort.TextChanged += new System.EventHandler(this.TextBoxPort_TextChanged);
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = global::PSS3.Properties.Resources.PS3;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(34, 10);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(95, 60);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox1.TabIndex = 6;
            this.guna2PictureBox1.TabStop = false;
            // 
            // SubtitleLabel
            // 
            this.SubtitleLabel.AutoSize = true;
            this.SubtitleLabel.Font = new System.Drawing.Font("SST", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubtitleLabel.Location = new System.Drawing.Point(137, 50);
            this.SubtitleLabel.Name = "SubtitleLabel";
            this.SubtitleLabel.Size = new System.Drawing.Size(64, 20);
            this.SubtitleLabel.TabIndex = 5;
            this.SubtitleLabel.Text = "by d.sj.";
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("SST Condensed", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.Location = new System.Drawing.Point(135, 12);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(164, 34);
            this.TitleLabel.TabIndex = 4;
            this.TitleLabel.Text = "PS3 MANAGER";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(405, 336);
            this.Controls.Add(this.MainContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Main";
            this.Opacity = 0D;
            this.Text = "PSS3";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Main_KeyPress);
            this.MainContainer.ResumeLayout(false);
            this.MainContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox TextBoxAddress;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button ButtonStart;
        private Guna.UI2.WinForms.Guna2Panel MainContainer;
        private System.Windows.Forms.Label TitleLabel;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private System.Windows.Forms.Label SubtitleLabel;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox TextBoxPort;
        private Guna.UI2.WinForms.Guna2Button ButtonIp;
        private Guna.UI2.WinForms.Guna2TextBox TXT_PWD;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox TXT_USNM;
        private System.Windows.Forms.Label label3;
    }
}

