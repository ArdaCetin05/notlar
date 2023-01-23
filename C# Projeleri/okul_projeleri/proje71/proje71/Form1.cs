using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace proje71
{
    public partial class Form1 : Form
    {
        int syc;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                syc = Convert.ToInt32(textBox1.Text);
                label1.Text = syc.ToString();
                timer1.Enabled = true;//timerSayac.Start();
                panel1.Visible = false;
            }
            else
            {
                MessageBox.Show("Sayaç değeri boş bırakılamaz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox1.Focus();
            }
 
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            syc--;
            label1.Text = syc.ToString();
            if (syc == 0)
            {
                timer1.Enabled = false;//timerSayac.Stop();
                if (comboBox1.SelectedIndex == 1)
                    Application.Exit();
                else if (comboBox1.SelectedIndex == 2)
                    System.Diagnostics.Process.Start("shutdown", "-l -f");
                else if (comboBox1.SelectedIndex == 3)
                    System.Diagnostics.Process.Start("shutdown", "-f -s -t 1");
                else
                    panel1.Visible = true;
            }
        }

        
    }
}
