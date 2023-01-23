using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace proje70
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 1)
            {
                pictureBox1.Image = Resource1.gs_banner;
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                pictureBox1.Image = Resource1.fb_banner;
            }
            else if (comboBox1.SelectedIndex == 3)
            {
                pictureBox1.Image = Resource1.bjk_banner;
            }
            else
            {
                pictureBox1.Image = Resource1.superlig_banner;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 1;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 2;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 3;
        }
    }
}
