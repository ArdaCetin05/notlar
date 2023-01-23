using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace proje73
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToLongDateString();
            label2.Text = DateTime.Now.ToLongTimeString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToLongDateString();
            label2.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
        }

        private void toolStripLabel2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolStripComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Form frm = new Form2();
            frm.ShowDialog();
            frm.Close();
        }

        

        
    }
}
