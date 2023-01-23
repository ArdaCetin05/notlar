using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace proje62
{
    public partial class Form1 : Form
    {
        string kAdı = "arda", sfre = "1234";
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (ka.Text == kAdı && sifre.Text == sfre)
            {
                Application.Exit();
            }
            else
            {
                if (ka.Text != kAdı)
                    ka.Focus();
                if (sifre.Text != sfre)
                    sifre.Focus();              
                hata.Visible = true;
            }
        }

        private void ka_TextChanged(object sender, EventArgs e)
        {
            hata.Visible = false;
            if (ka.Text != "")
            {
                kaHata.Visible = false;
            }
            else
            {
                kaHata.Visible = true;
            }
        }

        private void sifre_TextChanged(object sender, EventArgs e)
        {
            hata.Visible = false;
            if (sifre.Text != "")
            {
                sifreHata.Visible = false;
            }
            else
            {
                sifreHata.Visible = true; 
            }
        }

        
    }
}
