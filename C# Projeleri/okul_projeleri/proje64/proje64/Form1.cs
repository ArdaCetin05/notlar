using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace proje64
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 1; i <= 3000 ; i++)
            {
                comboBox1.Items.Add(i);
            }
            comboBox1.SelectedIndex = 0;
            for (int i = 2000; i >= 1; i--)
            {
                comboBox2.Items.Add(i);
            }
            comboBox2.SelectedIndex = 0;
            for (int i = 300; i <= 6000; i+=3)
            {
                comboBox3.Items.Add(i);
            }
            comboBox3.SelectedIndex = 0;
            for (int i = 5000; i >= 500; i--)
            {
                if (i%2 == 1)
                {
                    comboBox4.Items.Add(i);
                }
                
            }
            comboBox4.SelectedIndex = 0;
        }
    }
}
