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
        public event EventHandler onClose;

        public Settings()
        {
            InitializeComponent();
            string z = Properties.Settings.Default.pdfFile;
            string[] p = z.Split('|');
            for(int i = 0; i < p.Length; i++)
            {
                string[] item = p[i].Split('~');
                if (item.Length == 3 && item[0].Length > 0)
                {
                    int n = pdfs.Rows.Add();
                    pdfs.Rows[n].Cells[0].Value = item[0];
                    pdfs.Rows[n].Cells[1].Value = item[1];
                    pdfs.Rows[n].Cells[2].Value = item[2];
                }
            }
        }

        private List<string> PDFForms = new List<string>();

        private void button1_Click(object sender, EventArgs e)
        {
            if (name.Text.Length > 0 && pdfFile.Text.Length > 0 && targetDir.Text.Length > 0 )
            {
                int n = pdfs.Rows.Add();
                pdfs.Rows[n].Cells[0].Value = name.Text;
                pdfs.Rows[n].Cells[1].Value = pdfFile.Text;
                pdfs.Rows[n].Cells[2].Value = targetDir.Text;
            } else
            {
                MessageBox.Show("Missing Data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

        private void Settings_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Console.Write("closting form");

            string z = "";
            foreach (DataGridViewRow r in pdfs.Rows)
            {
    

                if (r !=null &&  r.Cells[0].Value.ToString().Length > 0)
                    z += r.Cells[0].Value + "~" + r.Cells[1].Value + "~" + r.Cells[2].Value + "|";
          
            }


            Properties.Settings.Default.pdfFile = z.Substring(0, z.Length - 1 );
            Properties.Settings.Default.Save();

            if (onClose != null)
                onClose.Invoke(this, EventArgs.Empty);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pdfs_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            System.Console.Write(sender);
        }
    }
}
