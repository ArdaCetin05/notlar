using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace proje60
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ejderhaonoff_Click(object sender, EventArgs e)
        {
            if (ejderha.Visible == true)
            {
                ejderha.Visible = false;
                ejderhaonoff.Text = "[aç]";
            }
            else
            {
                ejderha.Visible = true;
                ejderhaonoff.Text = "[kapat]";
            }
        }

        private void koyonoff_Click(object sender, EventArgs e)
        {
            if (koy.Visible == true)
            {
                koy.Visible = false;
                koyonoff.Text = "[aç]";
            }
            else
            {
                koy.Visible = true;
                koyonoff.Text = "[kapat]";
            }
        }

        private void donanmaonoff_Click(object sender, EventArgs e)
        {
            if (donanma1.Visible == true && donanma2.Visible == true && donanma3.Visible == true)
            {
                donanma1.Visible = false;
                donanma2.Visible = false;
                donanma3.Visible = false;
                donanmaonoff.Text = "[aç]";
            }
            else
            {
                donanma1.Visible = true;
                donanma2.Visible = true;
                donanma3.Visible = true;
                donanmaonoff.Text = "[kapat]";
            }
        }

        private void kaleonoff_Click(object sender, EventArgs e)
        {
            if (kale.Visible == true)
            {
                kale.Visible = false;
                kaleonoff.Text = "[aç]";
            }
            else
            {
                kale.Visible = true;
                kaleonoff.Text = "[kapat]";
            }
        }

        private void orduonoff_Click(object sender, EventArgs e)
        {
            if (ordu.Visible == true)
            {
                ordu.Visible = false;
                orduonoff.Text = "[aç]";
            }
            else
            {
                ordu.Visible = true;
                orduonoff.Text = "[kapat]";
            }
        }

        private void heroonoff_Click(object sender, EventArgs e)
        {
            if (hero.Visible == true)
            {
                hero.Visible = false;
                heroonoff.Text = "[aç]";
            }
            else
            {
                hero.Visible = true;
                heroonoff.Text = "[kapat]";
            }
        }
    }
}
