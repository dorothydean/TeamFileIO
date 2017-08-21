namespace TeamFileIO
{
    partial class Form1
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
            this.txtImport = new System.Windows.Forms.TextBox();
            this.btnImport = new System.Windows.Forms.Button();
            this.gboxImport = new System.Windows.Forms.GroupBox();
            this.gboxSave = new System.Windows.Forms.GroupBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblFiletext = new System.Windows.Forms.Label();
            this.txtReadFile = new System.Windows.Forms.TextBox();
            this.btnDecrypt = new System.Windows.Forms.Button();
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.gboxImport.SuspendLayout();
            this.gboxSave.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtImport
            // 
            this.txtImport.Location = new System.Drawing.Point(39, 65);
            this.txtImport.Name = "txtImport";
            this.txtImport.Size = new System.Drawing.Size(324, 31);
            this.txtImport.TabIndex = 0;
            // 
            // btnImport
            // 
            this.btnImport.Location = new System.Drawing.Point(416, 65);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(149, 49);
            this.btnImport.TabIndex = 1;
            this.btnImport.Text = "Import";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // gboxImport
            // 
            this.gboxImport.Controls.Add(this.btnImport);
            this.gboxImport.Controls.Add(this.txtImport);
            this.gboxImport.Location = new System.Drawing.Point(35, 28);
            this.gboxImport.Name = "gboxImport";
            this.gboxImport.Size = new System.Drawing.Size(806, 164);
            this.gboxImport.TabIndex = 3;
            this.gboxImport.TabStop = false;
            this.gboxImport.Text = "Import File";
            // 
            // gboxSave
            // 
            this.gboxSave.Controls.Add(this.btnSave);
            this.gboxSave.Location = new System.Drawing.Point(36, 632);
            this.gboxSave.Name = "gboxSave";
            this.gboxSave.Size = new System.Drawing.Size(806, 164);
            this.gboxSave.TabIndex = 4;
            this.gboxSave.TabStop = false;
            this.gboxSave.Text = "Save File";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(175, 59);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(149, 49);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(351, 822);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(207, 99);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(89, 216);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "File Text";
            // 
            // lblFiletext
            // 
            this.lblFiletext.AutoSize = true;
            this.lblFiletext.Location = new System.Drawing.Point(94, 261);
            this.lblFiletext.Name = "lblFiletext";
            this.lblFiletext.Size = new System.Drawing.Size(0, 25);
            this.lblFiletext.TabIndex = 7;
            // 
            // txtReadFile
            // 
            this.txtReadFile.Location = new System.Drawing.Point(94, 270);
            this.txtReadFile.Multiline = true;
            this.txtReadFile.Name = "txtReadFile";
            this.txtReadFile.Size = new System.Drawing.Size(723, 278);
            this.txtReadFile.TabIndex = 8;
            // 
            // btnDecrypt
            // 
            this.btnDecrypt.Location = new System.Drawing.Point(175, 572);
            this.btnDecrypt.Name = "btnDecrypt";
            this.btnDecrypt.Size = new System.Drawing.Size(146, 54);
            this.btnDecrypt.TabIndex = 9;
            this.btnDecrypt.Text = "Decrypt";
            this.btnDecrypt.UseVisualStyleBackColor = true;
            this.btnDecrypt.Click += new System.EventHandler(this.btnDecrypt_Click);
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.Location = new System.Drawing.Point(454, 572);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(146, 54);
            this.btnEncrypt.TabIndex = 10;
            this.btnEncrypt.Text = "Encrypt";
            this.btnEncrypt.UseVisualStyleBackColor = true;
            this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 1058);
            this.Controls.Add(this.btnEncrypt);
            this.Controls.Add(this.btnDecrypt);
            this.Controls.Add(this.txtReadFile);
            this.Controls.Add(this.lblFiletext);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.gboxImport);
            this.Controls.Add(this.gboxSave);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gboxImport.ResumeLayout(false);
            this.gboxImport.PerformLayout();
            this.gboxSave.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtImport;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.GroupBox gboxImport;
        private System.Windows.Forms.GroupBox gboxSave;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblFiletext;
        private System.Windows.Forms.TextBox txtReadFile;
        private System.Windows.Forms.Button btnDecrypt;
        private System.Windows.Forms.Button btnEncrypt;
    }
}

