namespace PSS3.Forms
{
    partial class debug
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
            this.D1 = new Guna.UI2.WinForms.Guna2Button();
            this.D2 = new Guna.UI2.WinForms.Guna2Button();
            this.D3 = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // D1
            // 
            this.D1.Animated = true;
            this.D1.BorderRadius = 2;
            this.D1.FillColor = System.Drawing.Color.Black;
            this.D1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.D1.ForeColor = System.Drawing.Color.White;
            this.D1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(52)))), ((int)(((byte)(166)))));
            this.D1.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(82)))), ((int)(((byte)(196)))));
            this.D1.Location = new System.Drawing.Point(12, 43);
            this.D1.Name = "D1";
            this.D1.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(82)))), ((int)(((byte)(196)))));
            this.D1.Size = new System.Drawing.Size(392, 23);
            this.D1.TabIndex = 4;
            this.D1.Text = "RPC Impose Init";
            this.D1.Click += new System.EventHandler(this.D1_Click);
            // 
            // D2
            // 
            this.D2.Animated = true;
            this.D2.BorderRadius = 2;
            this.D2.FillColor = System.Drawing.Color.Black;
            this.D2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.D2.ForeColor = System.Drawing.Color.White;
            this.D2.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(52)))), ((int)(((byte)(166)))));
            this.D2.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(82)))), ((int)(((byte)(196)))));
            this.D2.Location = new System.Drawing.Point(12, 72);
            this.D2.Name = "D2";
            this.D2.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(82)))), ((int)(((byte)(196)))));
            this.D2.Size = new System.Drawing.Size(392, 23);
            this.D2.TabIndex = 5;
            this.D2.Text = "RPC Impose Stop";
            this.D2.Click += new System.EventHandler(this.D2_Click);
            // 
            // D3
            // 
            this.D3.Animated = true;
            this.D3.BorderRadius = 2;
            this.D3.FillColor = System.Drawing.Color.Black;
            this.D3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.D3.ForeColor = System.Drawing.Color.White;
            this.D3.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(52)))), ((int)(((byte)(166)))));
            this.D3.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(82)))), ((int)(((byte)(196)))));
            this.D3.Location = new System.Drawing.Point(12, 101);
            this.D3.Name = "D3";
            this.D3.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(82)))), ((int)(((byte)(196)))));
            this.D3.Size = new System.Drawing.Size(392, 23);
            this.D3.TabIndex = 6;
            this.D3.Text = "RPC Impose Clear";
            this.D3.Click += new System.EventHandler(this.D3_Click);
            // 
            // debug
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 325);
            this.Controls.Add(this.D3);
            this.Controls.Add(this.D2);
            this.Controls.Add(this.D1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(432, 364);
            this.MinimumSize = new System.Drawing.Size(432, 364);
            this.Name = "debug";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "debug";
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button D1;
        private Guna.UI2.WinForms.Guna2Button D2;
        private Guna.UI2.WinForms.Guna2Button D3;
    }
}