using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using System.IO;

namespace Proje73
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        //--------------------------------------------------
        private void Form2_Load(object sender, EventArgs e)
        {
            comboBoxSinif.SelectedIndex = comboBoxBolumu.SelectedIndex = 0;
        }
        //--------------------------------------------------
        private void buttonKaydet_Click(object sender, EventArgs e)
        {
            bool hata = false;

            if (maskedTextBoxGSM.MaskCompleted == false)
            {
                labelGSMHata.Visible = true;
                maskedTextBoxGSM.Focus();
                hata = true;
            }

            if (textBoxTC.Text.Length < 11)
            {
                labelTCHata.Visible = true;
                textBoxTC.Focus();
                hata = true;
            }

            if (textBoxOkulNo.Text == "")
            {
                labelOkulNoHata.Visible = true;
                textBoxOkulNo.Focus();
                hata = true;
            }

            if (textBoxAdSoyad.Text == "")
            {
                labelAdSoyadHata.Visible = true;
                textBoxAdSoyad.Focus();
                hata = true;
            }

            if (!hata)
            {
                string yol = Application.StartupPath + @"\images\";
                if (Directory.Exists(yol) == false)
                    Directory.CreateDirectory(yol);

                string resim_adi = uret(12) + ".jpg";
                while (File.Exists(yol + resim_adi) == true)
                    resim_adi = uret(12) + ".jpg";

                if (pictureBox1.ImageLocation != null)
                {
                    File.Copy(pictureBox1.ImageLocation, yol + resim_adi, true);
                }

                kaydet(resim_adi);
            }

            
        }
        //--------------------------------------------------
        private void kaydet(string resim)
        {
            OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=OKULDB.accdb;Persist Security Info=True");
            string sql = "insert into ogrenciTBL(adi_soyadi, okul_no, sinifi, cinsiyet, bolumu, tc_kimlik, dogum_tarihi, telefon_no, resim) Values(@adi_soyadi, @okul_no, @sinifi, @cinsiyet, @bolumu, @tc_kimlik, @dogum_tarihi, @telefon_no, @resim)";
            OleDbCommand cmd = new OleDbCommand(sql, baglanti);
            cmd.Parameters.AddWithValue("@adi_soyadi", textBoxAdSoyad.Text);
            cmd.Parameters.AddWithValue("@okul_no", Convert.ToInt32(textBoxOkulNo.Text));
            cmd.Parameters.AddWithValue("@sinifi", comboBoxSinif.Text);
            if (radioButtonErkek.Checked)
                cmd.Parameters.AddWithValue("@cinsiyet", true);
            else
                cmd.Parameters.AddWithValue("@cinsiyet", false);
            cmd.Parameters.AddWithValue("@bolumu", comboBoxBolumu.Text);
            cmd.Parameters.AddWithValue("@tc_kimlik", textBoxTC.Text);
            cmd.Parameters.AddWithValue("@dogum_tarihi", dateTimePickerDT.Value.ToString());
            cmd.Parameters.AddWithValue("@telefon_no", maskedTextBoxGSM.Text);
            cmd.Parameters.AddWithValue("@resim", resim);
            baglanti.Open();
            cmd.ExecuteNonQuery();
            baglanti.Close();
            cmd.Dispose();
            baglanti.Dispose();
            MessageBox.Show("Yeni öğrenci kaydı alındı...", "Durum", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
        //--------------------------------------------------
        private void textBoxAdSoyad_TextChanged(object sender, EventArgs e)
        {
            labelAdSoyadHata.Visible = false;
        }
        //--------------------------------------------------
        private void textBoxOkulNo_TextChanged(object sender, EventArgs e)
        {
            labelOkulNoHata.Visible = false;
        }
        //--------------------------------------------------
        private void textBoxTC_TextChanged(object sender, EventArgs e)
        {
            if (textBoxTC.Text.Length == 11)
                labelTCHata.Visible = false;
        }
        //--------------------------------------------------
        private void maskedTextBoxGSM_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            labelGSMHata.Visible = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.ImageLocation = openFileDialog1.FileName;
            }
        }
        private string uret(int k) {
            Random rnd = new Random();
            string str = "";
            for (int i = 1; i <= k; i++)
            {
                char c = Convert.ToChar(rnd.Next(65, 91));
                str += c.ToString();
            }
            return str;
        }
        //--------------------------------------------------
    }
}
