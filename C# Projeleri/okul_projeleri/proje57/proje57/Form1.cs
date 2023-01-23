using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace proje57
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double x, y, z, snc;
            x = double.Parse(textBox1.Text);
            y = double.Parse(textBox2.Text);
            z = double.Parse(textBox3.Text);
            snc = 3 * x + 4 * y - z - 3;
            label5.Text = snc.ToString();
        }
    }
}
