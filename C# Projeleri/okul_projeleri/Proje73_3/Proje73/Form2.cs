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

            

            if (textBoxAdSoyad.Text == "")
            {
                labelAdSoyadHata.Visible = true;
                textBoxAdSoyad.Focus();
                hata = true;
            }

            if (!hata) 
                kaydet();
            
        }
        //--------------------------------------------------
        private void kaydet()
        {
            OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=OKULDB.accdb;Persist Security Info=True");
            string sql = "Insert into ogrenciTBL(adi_soyadi, okul_no, sinifi, cinsiyet, bolumu, tc_kimlik, dogum_tarihi, telefon_no) Values(@adi_soyadi, @okul_no, @sinifi, @cinsiyet, @bolumu, @tc_kimlik, @dogum_tarihi, @telefon_no) ";
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
            baglanti.Open();
            cmd.ExecuteNonQuery();
            baglanti.Close();
            cmd.Dispose();
            baglanti.Dispose();
            MessageBox.Show("Kayıt işlemi tamamlandı.", "Yeni Kayıt", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        //--------------------------------------------------
    }
}
