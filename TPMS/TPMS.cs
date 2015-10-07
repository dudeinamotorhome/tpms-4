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
    public partial class TPMS : Form
    {
        String placeHolderText = "Type a Name Here ...";
        public TPMS()
        {
            InitializeComponent();
            string z = Properties.Settings.Default.pdfFile;
            string[] items = z.Split('|');
            bool bselected = false;
            for (int i = 0; i < items.Length; i++)
            {
                string [] item = items[i].Split('~');
                if (item.Length == 3 && item[0].Length > 0  )
                {
                    int cbi = this.comboBox1.Items.Add(item[0]);
                    if (!bselected)
                    {
                        bselected = true;
                        this.comboBox1.SelectedIndex = cbi;

                    }
                }

            }
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void contin_Click(object sender, EventArgs e)
        {
            if (filename.Text.Equals(placeHolderText) != true)
            {
                String sName = filename.Text.IndexOf(".pdf") > -1 ? filename.Text : filename.Text + ".pdf";
                System.Console.WriteLine(sName);
                String sourceFile = @Properties.Settings.Default.pdfFile;
                String destFile = System.IO.Path.Combine(Properties.Settings.Default.targetDir, sName);
                int iNbr = 0;
                while (System.IO.File.Exists(destFile))
                {
                    String sFind = "";
                    if (iNbr == 0 )
                    {
                        sFind = ".pdf";
                    } else
                    {
                        sFind = "_" + iNbr + ".pdf";
                    }
                    iNbr++;
                    String sReplace = "_" + iNbr + ".pdf";
                    destFile = destFile.Replace(sFind, sReplace);
                }
                System.IO.File.Copy(sourceFile, destFile, false);
                System.Diagnostics.Process.Start(@destFile);

                Application.Exit();
            } else
            {
                MessageBox.Show("You must type a name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void filename_KeyDown(object sender, KeyEventArgs e)
        {
            if (filename.Text.Equals(placeHolderText) == true)
            {
                filename.Text = "";
                filename.ForeColor = Color.Black;
            }
        }

        private void filename_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (filename.Text.Trim().Equals(null) == true || filename.Text.Trim().Equals("") == true)
            {
                filename.Text = placeHolderText;
                filename.ForeColor = Color.Gray;
            }
        }

        private void filename_Enter(object sender, EventArgs e)
        {
            if (filename.Text.Equals(placeHolderText) == true)
            {
                filename.Text = "";
                filename.ForeColor = Color.Black;
            }
        }

        private void filename_Leave(object sender, EventArgs e)
        {
            if (filename.Text.Trim().Equals(null) == true || filename.Text.Trim().Equals("") == true)
            {
                filename.Text = placeHolderText;
                filename.ForeColor = Color.Gray;
            }
        }

        private void pictureBox1_DoubleClick(object sender, EventArgs e)
        {
            System.Console.WriteLine("setup");
            Settings s = new Settings();
            s.Show();
        }

        private void filename_ControlAdded(object sender, ControlEventArgs e)
        {
            filename.Text = placeHolderText;
        }

        private void TPMS_Activated(object sender, EventArgs e)
        {

        }
    }
}
