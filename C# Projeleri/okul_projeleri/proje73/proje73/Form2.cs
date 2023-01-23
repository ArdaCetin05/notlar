using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace proje73
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=OKULDB.accdb;Persist Security Info=True");
            string sql = "insert into ogrenciTBL(adi_soyadi,okul_no,sinifi,cinsiyet,bolumu,tc_kimlik,dogum_tarihi,telefon_no) values(@adi_soyadi,@okul_no,@sinifi,@cinsiyet,@bolumu,@tc_kimlik,@dogum_tarihi,@telefon_no)";
            OleDbCommand cmd = new OleDbCommand(sql, baglanti);
            cmd.Parameters.AddWithValue("@adi_soyadi",textBox1.Text);
            cmd.Parameters.AddWithValue("@okul_no",int.Parse(textBox2.Text));
            cmd.Parameters.AddWithValue("@sinifi",comboBox1.Text);
            if (radioButton1.Checked)
            {
                cmd.Parameters.AddWithValue("@cinsiyet",true);
            }
            else
            {
                cmd.Parameters.AddWithValue("@cinsiyet",false);
            }
            
            cmd.Parameters.AddWithValue("@bolumu",comboBox2.Text);
            cmd.Parameters.AddWithValue("@tc_kimlik",textBox3.Text);
            cmd.Parameters.AddWithValue("@dogum_tarihi",dateTimePicker1.Value.ToString());
            cmd.Parameters.AddWithValue("@telefon_no",maskedTextBox1.Text);
            baglanti.Open();
            cmd.ExecuteNonQuery();

            baglanti.Close();
            cmd.Dispose();
            baglanti.Dispose();
            MessageBox.Show("yeni öğrenci kaydı alındı", "durum", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}
