namespace TPMS
{
    partial class Settings
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
            this.settingsClose = new System.Windows.Forms.Button();
            this.pdfFile = new System.Windows.Forms.TextBox();
            this.targetDir = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // settingsClose
            // 
            this.settingsClose.Location = new System.Drawing.Point(191, 102);
            this.settingsClose.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.settingsClose.Name = "settingsClose";
            this.settingsClose.Size = new System.Drawing.Size(167, 40);
            this.settingsClose.TabIndex = 0;
            this.settingsClose.Text = "Save";
            this.settingsClose.UseVisualStyleBackColor = true;
            this.settingsClose.Click += new System.EventHandler(this.button1_Click);
            // 
            // pdfFile
            // 
            this.pdfFile.Location = new System.Drawing.Point(11, 16);
            this.pdfFile.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.pdfFile.Name = "pdfFile";
            this.pdfFile.Size = new System.Drawing.Size(527, 35);
            this.pdfFile.TabIndex = 1;
            this.pdfFile.Click += new System.EventHandler(this.pdfFile_Click);
            // 
            // targetDir
            // 
            this.targetDir.Location = new System.Drawing.Point(11, 59);
            this.targetDir.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.targetDir.Name = "targetDir";
            this.targetDir.Size = new System.Drawing.Size(525, 35);
            this.targetDir.TabIndex = 2;
            this.targetDir.Click += new System.EventHandler(this.targetDir_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 162);
            this.Controls.Add(this.targetDir);
            this.Controls.Add(this.pdfFile);
            this.Controls.Add(this.settingsClose);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Settings";
            this.Text = "Settings";
            this.Shown += new System.EventHandler(this.Settings_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button settingsClose;
        private System.Windows.Forms.TextBox pdfFile;
        private System.Windows.Forms.TextBox targetDir;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}