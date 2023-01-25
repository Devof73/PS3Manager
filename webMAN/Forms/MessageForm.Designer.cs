namespace PSS3.Forms
{
    partial class MessageForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MessageForm));
            this.PB_Icon = new System.Windows.Forms.PictureBox();
            this.LBL_MSG = new System.Windows.Forms.Label();
            this.Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.Button2 = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Icon)).BeginInit();
            this.SuspendLayout();
            // 
            // PB_Icon
            // 
            this.PB_Icon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PB_Icon.Location = new System.Drawing.Point(13, 13);
            this.PB_Icon.Name = "PB_Icon";
            this.PB_Icon.Size = new System.Drawing.Size(44, 44);
            this.PB_Icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PB_Icon.TabIndex = 0;
            this.PB_Icon.TabStop = false;
            // 
            // LBL_MSG
            // 
            this.LBL_MSG.AutoEllipsis = true;
            this.LBL_MSG.Location = new System.Drawing.Point(63, 13);
            this.LBL_MSG.Name = "LBL_MSG";
            this.LBL_MSG.Size = new System.Drawing.Size(313, 88);
            this.LBL_MSG.TabIndex = 1;
            this.LBL_MSG.Text = "........";
            // 
            // Button1
            // 
            this.Button1.Animated = true;
            this.Button1.BorderRadius = 2;
            this.Button1.FillColor = System.Drawing.Color.Black;
            this.Button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Button1.ForeColor = System.Drawing.Color.White;
            this.Button1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(52)))), ((int)(((byte)(166)))));
            this.Button1.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(82)))), ((int)(((byte)(196)))));
            this.Button1.Location = new System.Drawing.Point(176, 112);
            this.Button1.Name = "Button1";
            this.Button1.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(82)))), ((int)(((byte)(196)))));
            this.Button1.Size = new System.Drawing.Size(97, 23);
            this.Button1.TabIndex = 4;
            this.Button1.Text = "null";
            // 
            // Button2
            // 
            this.Button2.Animated = true;
            this.Button2.BorderRadius = 2;
            this.Button2.FillColor = System.Drawing.Color.Black;
            this.Button2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Button2.ForeColor = System.Drawing.Color.White;
            this.Button2.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(52)))), ((int)(((byte)(166)))));
            this.Button2.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(82)))), ((int)(((byte)(196)))));
            this.Button2.Location = new System.Drawing.Point(279, 112);
            this.Button2.Name = "Button2";
            this.Button2.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(82)))), ((int)(((byte)(196)))));
            this.Button2.Size = new System.Drawing.Size(97, 23);
            this.Button2.TabIndex = 5;
            this.Button2.Text = "Ok";
            // 
            // MessageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(396, 147);
            this.Controls.Add(this.Button2);
            this.Controls.Add(this.Button1);
            this.Controls.Add(this.PB_Icon);
            this.Controls.Add(this.LBL_MSG);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(449, 283);
            this.MinimizeBox = false;
            this.Name = "MessageForm";
            this.Opacity = 0.01D;
            this.ShowInTaskbar = false;
            this.Text = "...";
            ((System.ComponentModel.ISupportInitialize)(this.PB_Icon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox PB_Icon;
        private System.Windows.Forms.Label LBL_MSG;
        private Guna.UI2.WinForms.Guna2Button Button1;
        private Guna.UI2.WinForms.Guna2Button Button2;
    }
}