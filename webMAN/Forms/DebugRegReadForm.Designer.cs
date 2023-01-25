namespace PSS3.Forms
{
    partial class DebugRegReadForm
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.ButtonOptions = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox1.Font = new System.Drawing.Font("SST", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 17;
            this.listBox1.Location = new System.Drawing.Point(12, 100);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(270, 191);
            this.listBox1.TabIndex = 0;
            // 
            // ButtonOptions
            // 
            this.ButtonOptions.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonOptions.BackColor = System.Drawing.Color.Transparent;
            this.ButtonOptions.BorderColor = System.Drawing.Color.White;
            this.ButtonOptions.BorderRadius = 5;
            this.ButtonOptions.BorderThickness = 2;
            this.ButtonOptions.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ButtonOptions.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ButtonOptions.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ButtonOptions.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ButtonOptions.FillColor = System.Drawing.Color.Black;
            this.ButtonOptions.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ButtonOptions.ForeColor = System.Drawing.Color.White;
            this.ButtonOptions.ImageSize = new System.Drawing.Size(40, 40);
            this.ButtonOptions.IndicateFocus = true;
            this.ButtonOptions.Location = new System.Drawing.Point(12, 12);
            this.ButtonOptions.Name = "ButtonOptions";
            this.ButtonOptions.Size = new System.Drawing.Size(270, 27);
            this.ButtonOptions.TabIndex = 22;
            this.ButtonOptions.Text = "Get";
            this.ButtonOptions.UseTransparentBackground = true;
            this.ButtonOptions.Click += new System.EventHandler(this.ButtonOptions_Click);
            // 
            // DebugRegReadForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(294, 303);
            this.Controls.Add(this.ButtonOptions);
            this.Controls.Add(this.listBox1);
            this.Name = "DebugRegReadForm";
            this.Opacity = 0D;
            this.Text = "DebugRegReadForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private Guna.UI2.WinForms.Guna2Button ButtonOptions;
    }
}