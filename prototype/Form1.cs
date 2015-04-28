using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prototype
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {

        }

        private void len_increase_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void propertyGrid1_Click(object sender, EventArgs e)
        {

        }

        private void rotateLeftToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void rotateLeftToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog()==DialogResult.OK)
            {
                axWindowsMediaPlayer1.URL = openFileDialog1.FileName;

            }
        }

        private void addVideosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                axWindowsMediaPlayer1.URL = openFileDialog1.FileName;

            }
        }

        private void creditsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.BackColor = Color.White;
            this.ForeColor = Color.Black;
            this.Size = new System.Drawing.Size(155, 265);
            this.Text = "Run-time Controls";
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
