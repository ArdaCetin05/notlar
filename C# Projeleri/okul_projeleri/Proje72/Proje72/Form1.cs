using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proje72
{
    public partial class Form1 : Form
    {
        //-------------------------------------------------------
        public Form1()
        {
            InitializeComponent();
        }
        //-------------------------------------------------------
        private void buttonUret_Click(object sender, EventArgs e)
        {
            timerUretec.Start();
            buttonUret.Enabled = false;
        }
        //-------------------------------------------------------
        private void timerUretec_Tick(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int sayi = rnd.Next(0, 1000000);

            while (listBox1.Items.IndexOf(sayi) != -1 || listBox2.Items.IndexOf(sayi) != -1)
                sayi = rnd.Next(0, 1000000);

            if (listBox1.Items.Count != 100)
            {
                listBox1.Items.Add(sayi);
                listBox1.SelectedIndex = listBox1.Items.Count - 1;
            }
            else
            {
                listBox2.Items.Add(sayi);
                listBox2.SelectedIndex = listBox2.Items.Count - 1;
            }

            progressBarDurum.Value++;
            labelYuzde.Text = "% " + Math.Round(progressBarDurum.Value * 0.5).ToString();

            if (listBox2.Items.Count == 100)
            {
                timerUretec.Stop();
                MessageBox.Show("Rasgele sayı üretimi tamamlanmıştır...", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        //-------------------------------------------------------
    }
}