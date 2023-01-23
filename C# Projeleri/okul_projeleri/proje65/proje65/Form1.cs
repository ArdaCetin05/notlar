using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace proje65
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("textBox boş geçilemez", "hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(comboBox1.Items.IndexOf(textBox1.Text) == -1)
            {
                comboBox1.Items.Add(textBox1.Text);
                textBox1.Clear();
                comboBox1.SelectedIndex = comboBox1.Items.Count - 1;
                label2.Text = "eleman sayısı : " + (comboBox1.Items.Count - 1).ToString();
            }
            else
            {
                MessageBox.Show("bu eleman zaten var", "hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            if (comboBox1.Items.IndexOf(textBox1.Text) > -1)
            {
                comboBox1.SelectedIndex = comboBox1.Items.IndexOf(textBox1.Text);
            }
            else{
                MessageBox.Show("böyle bir eleman yoktur","hata",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("silmek istediğine emin misin","uyarı",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                comboBox1.Items.RemoveAt(comboBox1.SelectedIndex);
                comboBox1.SelectedIndex = 0;
                label2.Text = "eleman sayısı : " + (comboBox1.Items.Count - 1).ToString();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                button3.Enabled = false;
            }
            else
            {
                button3.Enabled = true;
            }
        }

       
    }
}
