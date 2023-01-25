namespace xRegistryEditor
{
    partial class SettingDialog
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
            this.cbSettings = new System.Windows.Forms.ComboBox();
            this.lblSetting = new System.Windows.Forms.Label();
            this.cmdOK = new System.Windows.Forms.Button();
            this.lblType = new System.Windows.Forms.Label();
            this.rad0 = new System.Windows.Forms.RadioButton();
            this.rad1 = new System.Windows.Forms.RadioButton();
            this.rad2 = new System.Windows.Forms.RadioButton();
            this.txtLength = new System.Windows.Forms.NumericUpDown();
            this.lblLength = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.txtLength)).BeginInit();
            this.SuspendLayout();
            // 
            // cbSettings
            // 
            this.cbSettings.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSettings.FormattingEnabled = true;
            this.cbSettings.Location = new System.Drawing.Point(39, 24);
            this.cbSettings.Name = "cbSettings";
            this.cbSettings.Size = new System.Drawing.Size(343, 21);
            this.cbSettings.TabIndex = 0;
            // 
            // lblSetting
            // 
            this.lblSetting.AutoSize = true;
            this.lblSetting.Location = new System.Drawing.Point(110, 9);
            this.lblSetting.Name = "lblSetting";
            this.lblSetting.Size = new System.Drawing.Size(207, 13);
            this.lblSetting.TabIndex = 1;
            this.lblSetting.Text = "Setting (only ones with no data are shown)";
            // 
            // cmdOK
            // 
            this.cmdOK.Location = new System.Drawing.Point(185, 104);
            this.cmdOK.Name = "cmdOK";
            this.cmdOK.Size = new System.Drawing.Size(44, 25);
            this.cmdOK.TabIndex = 2;
            this.cmdOK.Text = "OK";
            this.cmdOK.UseVisualStyleBackColor = true;
            this.cmdOK.Click += new System.EventHandler(this.cmdOK_Click);
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(73, 53);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(31, 13);
            this.lblType.TabIndex = 3;
            this.lblType.Text = "Type";
            // 
            // rad0
            // 
            this.rad0.AutoSize = true;
            this.rad0.Location = new System.Drawing.Point(110, 51);
            this.rad0.Name = "rad0";
            this.rad0.Size = new System.Drawing.Size(69, 17);
            this.rad0.TabIndex = 4;
            this.rad0.TabStop = true;
            this.rad0.Text = "0 (Binary)";
            this.rad0.UseVisualStyleBackColor = true;
            // 
            // rad1
            // 
            this.rad1.AutoSize = true;
            this.rad1.Location = new System.Drawing.Point(185, 51);
            this.rad1.Name = "rad1";
            this.rad1.Size = new System.Drawing.Size(73, 17);
            this.rad1.TabIndex = 5;
            this.rad1.TabStop = true;
            this.rad1.Text = "1 (Integer)";
            this.rad1.UseVisualStyleBackColor = true;
            // 
            // rad2
            // 
            this.rad2.AutoSize = true;
            this.rad2.Location = new System.Drawing.Point(263, 51);
            this.rad2.Name = "rad2";
            this.rad2.Size = new System.Drawing.Size(101, 17);
            this.rad2.TabIndex = 6;
            this.rad2.TabStop = true;
            this.rad2.Text = "2 (String/Binary)";
            this.rad2.UseVisualStyleBackColor = true;
            // 
            // txtLength
            // 
            this.txtLength.Location = new System.Drawing.Point(185, 80);
            this.txtLength.Name = "txtLength";
            this.txtLength.Size = new System.Drawing.Size(63, 20);
            this.txtLength.TabIndex = 7;
            // 
            // lblLength
            // 
            this.lblLength.AutoSize = true;
            this.lblLength.Location = new System.Drawing.Point(135, 82);
            this.lblLength.Name = "lblLength";
            this.lblLength.Size = new System.Drawing.Size(40, 13);
            this.lblLength.TabIndex = 8;
            this.lblLength.Text = "Length";
            // 
            // SettingDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 132);
            this.Controls.Add(this.lblLength);
            this.Controls.Add(this.txtLength);
            this.Controls.Add(this.rad2);
            this.Controls.Add(this.rad1);
            this.Controls.Add(this.rad0);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.cmdOK);
            this.Controls.Add(this.lblSetting);
            this.Controls.Add(this.cbSettings);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingDialog";
            this.Text = "Add Setting";
            ((System.ComponentModel.ISupportInitialize)(this.txtLength)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbSettings;
        private System.Windows.Forms.Label lblSetting;
        private System.Windows.Forms.Button cmdOK;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.RadioButton rad0;
        private System.Windows.Forms.RadioButton rad1;
        private System.Windows.Forms.RadioButton rad2;
        private System.Windows.Forms.NumericUpDown txtLength;
        private System.Windows.Forms.Label lblLength;
    }
}