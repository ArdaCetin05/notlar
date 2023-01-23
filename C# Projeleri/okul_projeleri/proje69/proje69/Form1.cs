using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace proje69
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string msj = "Adı Soyadı: " + textBoxAdSoyad.Text + "\n";

            msj += "Doğum Tarihi: " + comboBoxGun.Text + " " + comboBoxAy.Text + " " + comboBoxYil.Text + "\n";

            if (radioButtonErkek.Checked)
                msj += "Cinsiyeti: Erkek\n";
            else
                msj += "Cinsiyeti: Kadın\n";

            if (radioButtonBV_var.Checked)
                msj += "Bilgisayarı var...\n";
            else
                msj += "Bilgisayarı yok...\n";

            if (radioButtonBB_Az.Checked)
                msj += "Kullanmayı az biliyor...";
            else if (radioButtonBB_orta.Checked)
                msj += "Kullanmayı orta biliyor...";
            else
                msj += "Kullanmayı çok biliyor...";

            MessageBox.Show(msj, "Anket Sonucu", MessageBoxButtons.OK, MessageBoxIcon.Information);

            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 1; i <=31; i++)
            {
                comboBoxGun.Items.Add(i);
            }
            for (int i = 1900; i <= 2050; i++)
            {
                comboBoxYil.Items.Add(i);
            }
        }
    }
}
