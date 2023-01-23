using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Proje12
{
    public partial class Form1 : Form
    {
        //---------------------------------------------------------
        public Form1()
        {
            InitializeComponent();
        }
        //---------------------------------------------------------
        private void buttonSag_Click(object sender, EventArgs e)
        {
            if (pictureBoxUgurBocegi.Left < 500)
            {
                pictureBoxUgurBocegi.Left = pictureBoxUgurBocegi.Left + 10;
                labelLeft.Text = "LEFT(X) = " + pictureBoxUgurBocegi.Left.ToString();
            }
        }
        //---------------------------------------------------------
        private void buttonSol_Click(object sender, EventArgs e)
        {
            if (pictureBoxUgurBocegi.Left > 0)
            {
                pictureBoxUgurBocegi.Left = pictureBoxUgurBocegi.Left - 10;
                labelLeft.Text = "LEFT(X) = " + pictureBoxUgurBocegi.Left.ToString();
            }
        }
        //---------------------------------------------------------
        private void buttonYukari_Click(object sender, EventArgs e)
        {
            if (pictureBoxUgurBocegi.Top > 0)
            {
                pictureBoxUgurBocegi.Top = pictureBoxUgurBocegi.Top - 10;
                labelTop.Text = "TOP(Y) = " + pictureBoxUgurBocegi.Top.ToString();
            }
        }
        //---------------------------------------------------------
        private void buttonAsagi_Click(object sender, EventArgs e)
        {
            if (pictureBoxUgurBocegi.Top < 200)
            {
                pictureBoxUgurBocegi.Top = pictureBoxUgurBocegi.Top + 10;
                labelTop.Text = "TOP(Y) = " + pictureBoxUgurBocegi.Top.ToString();
            }
        }
        //---------------------------------------------------------
        private void buttonBasaAl_Click(object sender, EventArgs e)
        {
            pictureBoxUgurBocegi.Left = 240;
            labelLeft.Text = "LEFT(X) = 240";
            pictureBoxUgurBocegi.Top = 80;
            labelTop.Text = "TOP(Y) = 80";
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W)
            {
                buttonYukari_Click(sender,e);
            }
            else if (e.KeyCode == Keys.S)
            {
                buttonAsagi_Click(sender, e);
            }
            else if (e.KeyCode == Keys.A)
            {
                buttonSol_Click(sender, e);
            }
            else if (e.KeyCode == Keys.D)
            {
                buttonSag_Click(sender, e);
            }
            else if (e.KeyCode == Keys.Space)
            {
                buttonBasaAl_Click(sender, e);
            }
            else if (e.KeyCode == Keys.Escape)
            {
                Application.Exit();
            }
        }
        //---------------------------------------------------------
    }
}
