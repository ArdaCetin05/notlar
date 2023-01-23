using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace proje59
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_MouseHover(object sender, EventArgs e)
        {
            label3.ForeColor = Color.Orange;
        }

        private void label3_MouseLeave(object sender, EventArgs e)
        {
            label3.ForeColor = Color.Yellow;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            label4.Text = textBox1.Text + "\nVS\n" + textBox2.Text;
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            textBox1.Visible = false;
            textBox2.Visible = false;

        }
    }
}
