using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPMS
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.pdfFile = pdfFile.Text;
            Properties.Settings.Default.targetDir = targetDir.Text;
            Properties.Settings.Default.Save();
            
            this.Close();
        }

        private void Settings_Shown(object sender, EventArgs e)
        {
            pdfFile.Text = Properties.Settings.Default.pdfFile;
            targetDir.Text = Properties.Settings.Default.targetDir;
        }

        private void pdfFile_Click(object sender, EventArgs e)
        {
            // Create an instance of the open file dialog box.
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            // Set filter options and filter index.
            openFileDialog1.Filter = "PDF Files (.pdf)|*.pdf";
            openFileDialog1.FilterIndex = 1;

            openFileDialog1.Multiselect = false;

            // Call the ShowDialog method to show the dialog box.
            DialogResult userClickedOK = openFileDialog1.ShowDialog();

            // Process input if the user clicked OK.
            if (userClickedOK == DialogResult.OK)
            {
                System.Console.WriteLine(openFileDialog1.FileName);

                pdfFile.Text = openFileDialog1.FileName;
            }
        }

        private void targetDir_Click(object sender, EventArgs e)
        {
            // Create an instance of the open file dialog box.
            FolderBrowserDialog fbd = new FolderBrowserDialog();

            // Call the ShowDialog method to show the dialog box.
            DialogResult userClickedOK = fbd.ShowDialog();

            // Process input if the user clicked OK.
            if (userClickedOK == DialogResult.OK)
            {
                System.Console.WriteLine(fbd.SelectedPath);

                targetDir.Text = fbd.SelectedPath;
            }
        }
    }
}
