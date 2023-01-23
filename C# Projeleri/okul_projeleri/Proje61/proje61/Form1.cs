using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace proje61
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (bocek.Left < 600-138)
            {
              bocek.Left += 10;
            x.Text = bocek.Left.ToString();  
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (bocek.Left > 0)
            {
               bocek.Left -= 10;
               x.Text = bocek.Left.ToString(); 
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (bocek.Top < 180)
            {
               bocek.Top += 10;
               y.Text = bocek.Top.ToString(); 
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (bocek.Top > 0)
            {
               bocek.Top -= 10;
               y.Text = bocek.Top.ToString(); 
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bocek.Top = 60;
            bocek.Left = 230;
            x.Text = bocek.Left.ToString();
            y.Text = bocek.Top.ToString();
        }

     
    }
}
