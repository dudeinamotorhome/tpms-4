namespace TPMS
{
    partial class TPMS
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
            this.contin = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.filename = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // contin
            // 
            this.contin.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.contin.ForeColor = System.Drawing.SystemColors.ControlText;
            this.contin.Location = new System.Drawing.Point(638, 116);
            this.contin.Name = "contin";
            this.contin.Size = new System.Drawing.Size(133, 50);
            this.contin.TabIndex = 0;
            this.contin.Text = "Continue";
            this.contin.UseVisualStyleBackColor = false;
            this.contin.Click += new System.EventHandler(this.contin_Click);
            // 
            // cancel
            // 
            this.cancel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.cancel.Location = new System.Drawing.Point(485, 116);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(133, 50);
            this.cancel.TabIndex = 1;
            this.cancel.Text = "Cancel";
            this.cancel.UseVisualStyleBackColor = false;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // filename
            // 
            this.filename.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filename.ForeColor = System.Drawing.Color.Gray;
            this.filename.Location = new System.Drawing.Point(485, 68);
            this.filename.Name = "filename";
            this.filename.Size = new System.Drawing.Size(285, 39);
            this.filename.TabIndex = 3;
            this.filename.Text = "Type a Name Here ...";
            this.filename.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.filename_ControlAdded);
            this.filename.Enter += new System.EventHandler(this.filename_Enter);
            this.filename.Leave += new System.EventHandler(this.filename_Leave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TPMS.Properties.Resources.turningpoints_header4_475x200;
            this.pictureBox1.InitialImage = global::TPMS.Properties.Resources.turningpoints_header4_475x200;
            this.pictureBox1.Location = new System.Drawing.Point(4, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(461, 183);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.DoubleClick += new System.EventHandler(this.pictureBox1_DoubleClick);
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(485, 17);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(285, 40);
            this.comboBox1.TabIndex = 5;
            // 
            // TPMS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 182);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.filename);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.contin);
            this.Name = "TPMS";
            this.Text = "TPMS";
            this.Activated += new System.EventHandler(this.TPMS_Activated);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button contin;
        private System.Windows.Forms.Button     cancel;
        private System.Windows.Forms.TextBox filename;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

