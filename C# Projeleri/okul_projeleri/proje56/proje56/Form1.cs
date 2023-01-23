using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace proje56
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void toplama_Click(object sender, EventArgs e)
        {
            double sy1, sy2, sonuc;
            sy1 = double.Parse(s1.Text);
            sy2 = double.Parse(s2.Text);
            sonuc = sy1 + sy2;
            snc.Text = sonuc.ToString();

        }

        private void cikarma_Click(object sender, EventArgs e)
        {
            double sy1, sy2, sonuc;
            sy1 = double.Parse(s1.Text);
            sy2 = double.Parse(s2.Text);
            sonuc = sy1 - sy2;
            snc.Text = sonuc.ToString();
        }

        private void carpma_Click(object sender, EventArgs e)
        {
            double sy1, sy2, sonuc;
            sy1 = double.Parse(s1.Text);
            sy2 = double.Parse(s2.Text);
            sonuc = sy1 * sy2;
            snc.Text = sonuc.ToString();
        }

        private void bolme_Click(object sender, EventArgs e)
        {
            double sy1, sy2, sonuc;
            sy1 = double.Parse(s1.Text);
            sy2 = double.Parse(s2.Text);
            sonuc = sy1 / sy2;
            snc.Text = sonuc.ToString();
        }
    }
}
