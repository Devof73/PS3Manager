namespace PSS3.Forms
{
    partial class WaitingForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WaitingForm));
            this.StateLabel = new System.Windows.Forms.Label();
            this.Spiner = new MetroFramework.Controls.MetroProgressSpinner();
            this.SuspendLayout();
            // 
            // StateLabel
            // 
            this.StateLabel.AutoSize = true;
            this.StateLabel.Font = new System.Drawing.Font("SST", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StateLabel.Location = new System.Drawing.Point(58, 32);
            this.StateLabel.Name = "StateLabel";
            this.StateLabel.Size = new System.Drawing.Size(105, 19);
            this.StateLabel.TabIndex = 1;
            this.StateLabel.Text = "Working on...";
            this.StateLabel.UseWaitCursor = true;
            // 
            // Spiner
            // 
            this.Spiner.CustomBackground = false;
            this.Spiner.Location = new System.Drawing.Point(12, 21);
            this.Spiner.Maximum = 100;
            this.Spiner.Name = "Spiner";
            this.Spiner.Size = new System.Drawing.Size(40, 37);
            this.Spiner.Style = MetroFramework.MetroColorStyle.Black;
            this.Spiner.StyleManager = null;
            this.Spiner.TabIndex = 5;
            this.Spiner.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Spiner.UseWaitCursor = true;
            this.Spiner.Value = 1;
            // 
            // WaitingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(346, 84);
            this.ControlBox = false;
            this.Controls.Add(this.Spiner);
            this.Controls.Add(this.StateLabel);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "WaitingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Loading...";
            this.UseWaitCursor = true;
            this.Load += new System.EventHandler(this.WaitingForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label StateLabel;
        private MetroFramework.Controls.MetroProgressSpinner Spiner;
    }
}