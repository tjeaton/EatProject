using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace EatonProjection
{
    public partial class Form1 : Form
    {
        //Form Links
        backgroundForm bgFrm = new backgroundForm();
        lyricsForm lyFrm = new lyricsForm();
        //Variables
        string sData;
        bool svData;
        string vtSend;


        public Form1()
        {
            InitializeComponent();
            //Show Visual Forms
            bgFrm.Show();
            lyFrm.Show();

        }

        private void btnShowBG_Click(object sender, EventArgs e)
        {
            svData = chkLoop.Checked;
            vtSend = txtVUrl.Text;
            bgFrm.initVideo(svData, vtSend);
                
        }

        private void btnStopBG_Click(object sender, EventArgs e)
        {
            bgFrm.stopVideo(true);
        }

        private void btnShowTxt_Click(object sender, EventArgs e)
        {
            sData = txtOne.Text;
            lyFrm.clrText(true);
            lyFrm.drawText(sData);
        }

        private void nxtLyric_Click(object sender, EventArgs e)
        {
            sData = txtTwo.Text;
            lyFrm.clrText(true);
            lyFrm.drawText(sData);
        }

        private void txtTwo_TextChanged(object sender, EventArgs e)
        {
            sData = txtTwo.Text;
            lyFrm.clrText(true);
            lyFrm.drawText(sData);
        }

        #region Saving and Opening of Files
        private void btnSave_Click(object sender, EventArgs e)
        {
            Stream fileStream = null;
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            saveFileDialog1.Filter = "Text Files (*.txt)|*.txt";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.RestoreDirectory = true;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((fileStream = saveFileDialog1.OpenFile()) != null)
                        using (fileStream)
                        {
                            File.WriteAllText(saveFileDialog1.FileName, txtTwo.Text);
                        }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not save file to disk. Original error: " + ex.Message);
                }
            }
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            Stream fileStream = null;
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            //openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = "Text Files (*.txt)|*.txt";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((fileStream = openFileDialog1.OpenFile()) != null)
                    {
                        using (fileStream)
                        {
                            txtTwo.Text = File.ReadAllText(openFileDialog1.FileName);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }
        }
        #endregion


    }
}
