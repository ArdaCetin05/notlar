using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proje58
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double hipotenus, taban, yukseklik, alan, cevre;
            yukseklik = double.Parse(yuk.Text);
            taban = double.Parse(tab.Text);
            hipotenus = double.Parse(hipo.Text);
            cevre = (taban + yukseklik + hipotenus);
            alan = (yukseklik * taban) / 2;
            c.Text = cevre.ToString();
            a.Text = alan.ToString();
        }
    }
}
