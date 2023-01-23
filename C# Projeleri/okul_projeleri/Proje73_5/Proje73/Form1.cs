using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Proje73
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //---------------------------------------------------------
        private void Form1_Load(object sender, EventArgs e)
        {
            labelTarih.Text = DateTime.Now.ToLongDateString();
            labelSaat.Text = DateTime.Now.ToLongTimeString();
            //timerTarih_Tick(timerTarih, e);
        }
        //---------------------------------------------------------
        private void timerTarih_Tick(object sender, EventArgs e)
        {
            labelTarih.Text = DateTime.Now.ToLongDateString();
            labelSaat.Text = DateTime.Now.ToLongTimeString();
        }
        //---------------------------------------------------------
        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //---------------------------------------------------------
        private void yeniKayıtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.ShowDialog();
        }
        //---------------------------------------------------------
        private void ogrenciBilgiKartıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 frm3 = new Form3();
            frm3.ShowDialog();
        }
        //---------------------------------------------------------
        private void öğrenciListelemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 frm4 = new Form4();
            frm4.ShowDialog();
        }
        //---------------------------------------------------------
    }
}
