using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Proje73
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        public Form3(int okul_No)
        {
            InitializeComponent();
            bilgi_getir(okul_No);
            groupBoxİslem.Enabled = true;
        }
        //---------------------------------------------------------
        private void buttonAra_Click(object sender, EventArgs e)
        {
            if (textBoxOkulNo.Text == "")
            {
                MessageBox.Show("Öğrenci bilgilerinin görüntülenmesi için okul numarası girilmelidir!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxOkulNo.Focus();
            }
            else
            {
                bilgi_getir(Convert.ToInt32(textBoxOkulNo.Text));
                textBoxOkulNo.Clear();
                textBoxOkulNo.Focus();
                groupBoxİslem.Enabled = true;
            }

        }
        //---------------------------------------------------------
        private void bilgi_getir(int okul_no)
        {
            OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=OKULDB.accdb;Persist Security Info=True");
            string sql = "Select * From ogrenciTBL Where okul_no = @okul_no";
            OleDbCommand cmd = new OleDbCommand(sql, baglanti);
            cmd.Parameters.AddWithValue("@okul_no", okul_no);
            baglanti.Open();
            OleDbDataReader veri = cmd.ExecuteReader();
            if (veri.Read())
            {
                labelOkulNo.Text = veri["okul_no"].ToString();
                textBoxAdSoyad.Text = veri["adi_soyadi"].ToString();
                comboBoxSinif.Text = veri["sinifi"].ToString();
                comboBoxBolumu.Text = veri["bolumu"].ToString();
                if (Convert.ToBoolean(veri["cinsiyet"]) == true)
                    radioButtonErkek.Checked = true;
                else
                    radioButtonKadin.Checked = true;
                textBoxTC.Text = veri["tc_kimlik"].ToString();
                dateTimePickerDT.Value = Convert.ToDateTime(veri["dogum_tarihi"]);
                maskedTextBoxGSM.Text = veri["telefon_no"].ToString();

                string yol = Application.StartupPath + @"\images\";
                pictureBox1.ImageLocation = yol + veri["resim"].ToString();
            }
            else
            {
                MessageBox.Show("Bu numaralı bir öğrenci bulunamamıştır!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxOkulNo.Focus();
                veri.Close();
                baglanti.Close();
                cmd.Dispose();
                baglanti.Dispose();
            }
        }
        //---------------------------------------------------------
        private void buttonGuncelle_Click(object sender, EventArgs e)
        {
            groupBoxOgrenciBilgileri.Enabled = true;
            panelİslem.Visible = false;
            panelGuncelle.Visible = true;
            textBoxAdSoyad.Focus();
            
        }

        private void buttonİptal_Click(object sender, EventArgs e)
        {
            bilgi_getir(Convert.ToInt32(labelOkulNo.Text));
            groupBoxOgrenciBilgileri.Enabled = false;
            panelİslem.Visible = true;
            panelGuncelle.Visible = false;
            textBoxOkulNo.Focus();
        }
        //---------------------------------------------------------
        private void buttonKaydet_Click(object sender, EventArgs e)
        {
            bool hata = false;

            if (maskedTextBoxGSM.MaskCompleted == false)
            {
                labelGSM.Visible = true;
                maskedTextBoxGSM.Focus();
                hata = true;
            }

            if (textBoxTC.Text.Length < 11)
            {
                labelTC.Visible = true;
                textBoxTC.Focus();
                hata = true;
            }

            if (textBoxAdSoyad.Text == "")
            {
                labelAdSoyad.Visible = true;
                textBoxAdSoyad.Focus();
                hata = true;
            }

            if (!hata)
                Güncelle();
        }
        //---------------------------------------------------------
        private void Güncelle()
        {
            OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=OKULDB.accdb;Persist Security Info=True");
            string sql = "Update ogrenciTBL Set adi_soyadi = @adi_soyadi, sinifi = @sinifi, cinsiyet = @cinsiyet, bolumu = @bolumu, tc_kimlik = @tc_kimlik, dogum_tarihi = @dogum_tarihi, telefon_no = @telefon_no Where okul_no = @okul_no";
            OleDbCommand cmd = new OleDbCommand(sql, baglanti);
            cmd.Parameters.AddWithValue("@adi_soyadi", textBoxAdSoyad.Text);
            cmd.Parameters.AddWithValue("@sinifi", comboBoxSinif.Text);
            if (radioButtonErkek.Checked)
                cmd.Parameters.AddWithValue("@cinsiyet", true);
            else
                cmd.Parameters.AddWithValue("@cinsiyet", false);
            cmd.Parameters.AddWithValue("@bolumu", comboBoxBolumu.Text);
            cmd.Parameters.AddWithValue("@tc_kimlik", textBoxTC.Text);
            cmd.Parameters.AddWithValue("@dogum_tarihi", dateTimePickerDT.Value.ToString());
            cmd.Parameters.AddWithValue("@telefon_no", maskedTextBoxGSM.Text);
            cmd.Parameters.AddWithValue("@okul_no", Convert.ToInt32(labelOkulNo.Text));
            baglanti.Open();
            cmd.ExecuteNonQuery();
            baglanti.Close();
            cmd.Dispose();
            baglanti.Dispose();
            groupBoxOgrenciBilgileri.Enabled = false;
            panelİslem.Visible = true;
            panelGuncelle.Visible = false;
            textBoxOkulNo.Focus();
        }
        //---------------------------------------------------------
        private void buttonSil_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Öğrenci kaydını silmek ister misiniz", "Öğrenci kayıt silme", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=OKULDB.accdb;Persist Security Info=True");
                string sql = "Delete From ogrenciTBL Where okul_no = @okul_no";
                OleDbCommand cmd = new OleDbCommand(sql, baglanti);
                cmd.Parameters.AddWithValue("@okul_no", Convert.ToInt32(labelOkulNo.Text));
                baglanti.Open();
                cmd.ExecuteNonQuery();
                baglanti.Close();
                cmd.Dispose();
                baglanti.Dispose();
                MessageBox.Show("öğrenci kaydı başarılıyla silinmiştir.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Question);
                this.Close();
            }
        }
        //---------------------------------------------------------
    }
}
