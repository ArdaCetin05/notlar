using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace proje68
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog()==DialogResult.OK)
            {
                pictureBox1.ImageLocation = openFileDialog1.FileName;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Visible = !checkBox1.Checked;
            if (checkBox1.Checked)
            {
                checkBox1.Text = "resmi göster";
                checkBox1.Top = 40;
                this.Height = 140;

            }
            else
            {
                checkBox1.Text = "resmi gizle";
                checkBox1.Top = 349;
                this.Height = 416;
            }
        }
    }
}
