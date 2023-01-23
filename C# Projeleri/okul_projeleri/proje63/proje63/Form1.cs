using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace proje63
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
            if (comboBox1.SelectedIndex == 0)
            {
                label2.Text = "seçim için bekleniyor";
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                label2.Text = "bahar öztürk";
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                label2.Text = "ulaş arlı";
            }
            else if (comboBox1.SelectedIndex == 3)
            {
                label2.Text = "ebru yelkovan";
            }
            else if (comboBox1.SelectedIndex == 4)
            {
                label2.Text = "yeşim emirbaş";
            }
            else if (comboBox1.SelectedIndex == 5)
            {
                label2.Text = "setenay göçer";
            }
        }
    }
}
