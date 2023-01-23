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
                label1.Text = veri["okul_no"].ToString();
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
            groupBoxOgrenciOkulNo.Enabled = false;
            panelİslem.Visible = false;
            panelGuncelle.Visible = true;
            guncelle();
            textBoxAdSoyad.Focus();
            
        }

        private void buttonİptal_Click(object sender, EventArgs e)
        {
            bilgi_getir(Convert.ToInt32(label1.Text));
            groupBoxOgrenciBilgileri.Enabled = false;
            groupBoxOgrenciOkulNo.Enabled = true;
            panelİslem.Visible = true;
            panelGuncelle.Visible = false;
            textBoxOkulNo.Focus();
        }
        private void guncelle() {
            OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=OKULDB.accdb;Persist Security Info=True");
            string sql = "update ogrenciTBL SET adi_soyadi = @adi_soyadi, sinifi = @sinifi, cinsiyet = @cinsiyet, bolumu=@bolumu, tc_kimlik = @tc_kimlik, dogum_tarihi = @dogum_tarihi, telefon_no = @telefon_no where okul_no = @okul_no ";
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
            cmd.Parameters.AddWithValue("@okul_no", Convert.ToInt32(label1.Text));
            baglanti.Open();
            cmd.ExecuteNonQuery();
            baglanti.Close();
            cmd.Dispose();
            baglanti.Dispose();
         
        }

        private void buttonSil_Click(object sender, EventArgs e)
        {
            DialogResult snc = MessageBox.Show("ogrenciyi silmek istediğinize emin misiniz ? ", "ogrenci sil", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (snc == DialogResult.Yes)
            {
                sil();
            }
        }
        private void sil() {
            OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=OKULDB.accdb;Persist Security Info=True");
            string sql = "delete from ogrenciTBL where okul_no = @okul_no";
            OleDbCommand cmd = new OleDbCommand(sql, baglanti);
            cmd.Parameters.AddWithValue("@okul_no", Convert.ToInt32(label1.Text));
            baglanti.Open();
            cmd.ExecuteNonQuery();
            baglanti.Close();
            cmd.Dispose();
            baglanti.Dispose();
            MessageBox.Show("ogrenci silindi", "işlem tamamlandı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
        //---------------------------------------------------------
    }
}
