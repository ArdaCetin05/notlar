using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace proje66
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                listBox1.Items.Add(textBox1.Text);
                textBox1.Clear();
                listBox1.SelectedIndex = listBox1.Items.Count - 1;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count > 0)
            {
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
                listBox1.SelectedIndex = listBox1.Items.Count - 1;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            listBox2.Items.Add(listBox1.Text);
            listBox2.SelectedIndex = listBox2.Items.Count - 1;
            listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            listBox2.SelectedIndex = listBox2.Items.Count - 1;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.Items.Count > 0)
            {
                button5.Enabled = true;
            }
            else
            {
                button5.Enabled = false;
            }
            if (listBox2.Items.Count > 0)
            {
                button4.Enabled = true;
            }
            else
            {
                button4.Enabled = false;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(listBox2.Text);
            listBox1.SelectedIndex = listBox1.Items.Count - 1;
            listBox2.Items.RemoveAt(listBox2.SelectedIndex);
            listBox1.SelectedIndex = listBox1.Items.Count - 1;
        }

     

        
    }
}
