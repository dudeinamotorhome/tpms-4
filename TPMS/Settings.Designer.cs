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
            this.pdfs = new System.Windows.Forms.DataGridView();
            this.pdf_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pdf_file_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.target_dir = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pdfs)).BeginInit();
            this.SuspendLayout();
            // 
            // settingsClose
            // 
            this.settingsClose.Location = new System.Drawing.Point(315, 331);
            this.settingsClose.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.settingsClose.Name = "settingsClose";
            this.settingsClose.Size = new System.Drawing.Size(167, 40);
            this.settingsClose.TabIndex = 0;
            this.settingsClose.Text = "Add";
            this.settingsClose.UseVisualStyleBackColor = true;
            this.settingsClose.Click += new System.EventHandler(this.button1_Click);
            // 
            // pdfFile
            // 
            this.pdfFile.Location = new System.Drawing.Point(156, 228);
            this.pdfFile.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.pdfFile.Name = "pdfFile";
            this.pdfFile.Size = new System.Drawing.Size(527, 35);
            this.pdfFile.TabIndex = 1;
            this.pdfFile.Click += new System.EventHandler(this.pdfFile_Click);
            // 
            // targetDir
            // 
            this.targetDir.Location = new System.Drawing.Point(156, 276);
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
            // pdfs
            // 
            this.pdfs.AllowUserToAddRows = false;
            this.pdfs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pdfs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pdf_name,
            this.pdf_file_name,
            this.target_dir});
            this.pdfs.Location = new System.Drawing.Point(13, 12);
            this.pdfs.Name = "pdfs";
            this.pdfs.ReadOnly = true;
            this.pdfs.RowTemplate.Height = 28;
            this.pdfs.Size = new System.Drawing.Size(754, 150);
            this.pdfs.TabIndex = 3;
            // 
            // pdf_name
            // 
            this.pdf_name.HeaderText = "Name";
            this.pdf_name.Name = "pdf_name";
            this.pdf_name.ReadOnly = true;
            // 
            // pdf_file_name
            // 
            this.pdf_file_name.HeaderText = "PDF File Name";
            this.pdf_file_name.MinimumWidth = 50;
            this.pdf_file_name.Name = "pdf_file_name";
            this.pdf_file_name.ReadOnly = true;
            this.pdf_file_name.Width = 300;
            // 
            // target_dir
            // 
            this.target_dir.FillWeight = 200F;
            this.target_dir.HeaderText = "Target Directory";
            this.target_dir.MinimumWidth = 50;
            this.target_dir.Name = "target_dir";
            this.target_dir.ReadOnly = true;
            this.target_dir.Width = 300;
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(156, 179);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(525, 35);
            this.name.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 179);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 29);
            this.label1.TabIndex = 5;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(90, 228);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 29);
            this.label2.TabIndex = 5;
            this.label2.Text = "File:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(60, 276);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 29);
            this.label3.TabIndex = 5;
            this.label3.Text = "Folder:";
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 395);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.name);
            this.Controls.Add(this.pdfs);
            this.Controls.Add(this.targetDir);
            this.Controls.Add(this.pdfFile);
            this.Controls.Add(this.settingsClose);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Settings";
            this.Text = "Settings";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Settings_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pdfs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button settingsClose;
        private System.Windows.Forms.TextBox pdfFile;
        private System.Windows.Forms.TextBox targetDir;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.DataGridView pdfs;
        private System.Windows.Forms.DataGridViewTextBoxColumn pdf_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn pdf_file_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn target_dir;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}