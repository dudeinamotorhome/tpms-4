using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPDM
{
    public partial class TPDM : Form
    {
        String placeHolderText = "Type a Name Here ...";
        public TPDM()
        {
            InitializeComponent();
            this.updateCombo();
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void contin_Click(object sender, EventArgs e)
        {
            if (filename.Text.Equals(placeHolderText) != true)
            {
                string sName = filename.Text.IndexOf(".pdf") > -1 ? filename.Text : filename.Text + ".pdf";
                System.Console.WriteLine(sName);
                string sPDF = this.comboBox1.SelectedItem.ToString();
                System.Console.WriteLine(sPDF);
                string[] pdfForms = Properties.Settings.Default.pdfFile.Split('|');
                string targetDir = "";
                string pdffile = "";
                foreach ( string item in pdfForms)
                {
                    string [] ele = item.Split('~');
                    if (ele[0] == sPDF)
                    {
                        pdffile = ele[1];
                        targetDir = ele[2];
                        break;
                    }
                }


                String sourceFile = pdffile;
                String destFile = System.IO.Path.Combine(targetDir, sName);
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

            s.onClose += S_onClose;
            s.Show();
        }

        private void updateCombo()
        {
            this.comboBox1.Items.Clear();

            string z = Properties.Settings.Default.pdfFile;
            string[] items = z.Split('|');
            bool bselected = false;
            for (int i = 0; i < items.Length; i++)
            {
                string[] item = items[i].Split('~');
                if (item.Length == 3 && item[0].Length > 0)
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

        private void S_onClose(object sender, EventArgs e)
        {
            // refresh list
            this.updateCombo();
        }

        private void filename_ControlAdded(object sender, ControlEventArgs e)
        {
            filename.Text = placeHolderText;
        }

        private void TPDM_Activated(object sender, EventArgs e)
        {

        }
    }
}
