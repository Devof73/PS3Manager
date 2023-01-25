namespace PSS3.Forms
{
    partial class DebugNodesForm
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
            this.debug1 = new System.Windows.Forms.ListBox();
            this.debug2 = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.LABEL1 = new System.Windows.Forms.Label();
            this.LABEL2 = new System.Windows.Forms.Label();
            this.LABEL3 = new System.Windows.Forms.Label();
            this.TEXTREG = new System.Windows.Forms.TextBox();
            this.buttonGet = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // debug1
            // 
            this.debug1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.debug1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            this.debug1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.debug1.ForeColor = System.Drawing.Color.White;
            this.debug1.FormattingEnabled = true;
            this.debug1.Location = new System.Drawing.Point(329, 184);
            this.debug1.Name = "debug1";
            this.debug1.Size = new System.Drawing.Size(311, 182);
            this.debug1.TabIndex = 0;
            // 
            // debug2
            // 
            this.debug2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.debug2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            this.debug2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.debug2.ForeColor = System.Drawing.Color.White;
            this.debug2.Location = new System.Drawing.Point(12, 184);
            this.debug2.Name = "debug2";
            this.debug2.Size = new System.Drawing.Size(311, 182);
            this.debug2.TabIndex = 1;
            this.debug2.Text = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Data Initialize ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(134, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(116, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "GetFriends";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(256, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(116, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = "TestScreen";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // LABEL1
            // 
            this.LABEL1.AutoSize = true;
            this.LABEL1.Font = new System.Drawing.Font("SSTW20-Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LABEL1.ForeColor = System.Drawing.Color.Black;
            this.LABEL1.Location = new System.Drawing.Point(12, 84);
            this.LABEL1.Name = "LABEL1";
            this.LABEL1.Size = new System.Drawing.Size(66, 19);
            this.LABEL1.TabIndex = 5;
            this.LABEL1.Text = "PSNID:";
            // 
            // LABEL2
            // 
            this.LABEL2.AutoSize = true;
            this.LABEL2.Font = new System.Drawing.Font("SSTW20-Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LABEL2.ForeColor = System.Drawing.Color.Black;
            this.LABEL2.Location = new System.Drawing.Point(12, 108);
            this.LABEL2.Name = "LABEL2";
            this.LABEL2.Size = new System.Drawing.Size(76, 19);
            this.LABEL2.TabIndex = 6;
            this.LABEL2.Text = "USERID:";
            // 
            // LABEL3
            // 
            this.LABEL3.AutoSize = true;
            this.LABEL3.Font = new System.Drawing.Font("SSTW20-Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LABEL3.ForeColor = System.Drawing.Color.Black;
            this.LABEL3.Location = new System.Drawing.Point(12, 131);
            this.LABEL3.Name = "LABEL3";
            this.LABEL3.Size = new System.Drawing.Size(170, 19);
            this.LABEL3.TabIndex = 7;
            this.LABEL3.Text = "LOCAL USERNAME: ";
            // 
            // TEXTREG
            // 
            this.TEXTREG.Location = new System.Drawing.Point(378, 14);
            this.TEXTREG.Name = "TEXTREG";
            this.TEXTREG.Size = new System.Drawing.Size(100, 20);
            this.TEXTREG.TabIndex = 8;
            // 
            // buttonGet
            // 
            this.buttonGet.Location = new System.Drawing.Point(483, 13);
            this.buttonGet.Name = "buttonGet";
            this.buttonGet.Size = new System.Drawing.Size(75, 23);
            this.buttonGet.TabIndex = 9;
            this.buttonGet.Text = "Get";
            this.buttonGet.UseVisualStyleBackColor = true;
            this.buttonGet.Click += new System.EventHandler(this.buttonGet_Click);
            // 
            // DebugNodesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.ClientSize = new System.Drawing.Size(673, 384);
            this.Controls.Add(this.buttonGet);
            this.Controls.Add(this.TEXTREG);
            this.Controls.Add(this.LABEL3);
            this.Controls.Add(this.LABEL2);
            this.Controls.Add(this.LABEL1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.debug2);
            this.Controls.Add(this.debug1);
            this.DoubleBuffered = true;
            this.Name = "DebugNodesForm";
            this.Text = " ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox debug1;
        private System.Windows.Forms.RichTextBox debug2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label LABEL1;
        private System.Windows.Forms.Label LABEL2;
        private System.Windows.Forms.Label LABEL3;
        private System.Windows.Forms.TextBox TEXTREG;
        private System.Windows.Forms.Button buttonGet;
    }
}