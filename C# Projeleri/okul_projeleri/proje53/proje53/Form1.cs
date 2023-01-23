using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace proje53
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "kırmızı";
            label1.ForeColor = Color.Red;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = "yesil";
            label1.ForeColor = Color.Green;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Text = "mavi";
            label1.ForeColor = Color.Blue;
        }
    }
}
