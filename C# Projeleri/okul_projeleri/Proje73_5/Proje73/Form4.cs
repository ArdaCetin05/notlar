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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        //----------------------------------------------------
        private void Form4_Load(object sender, EventArgs e)
        {
            OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=OKULDB.accdb;Persist Security Info=True");
            string sql = "Select ogrenci_id, adi_soyadi, okul_no, sinifi, cinsiyet, bolumu, 'Detay' as detay From ogrenciTBL";
            OleDbCommand cmd = new OleDbCommand(sql, baglanti);
            baglanti.Open();
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridViewBilgiler.DataSource = dt;
            baglanti.Close();
            cmd.Dispose();
            baglanti.Dispose();
        }
        //----------------------------------------------------
        private void textBoxAra_TextChanged(object sender, EventArgs e)
        {
            OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=OKULDB.accdb;Persist Security Info=True");
            string sql = "Select ogrenci_id, adi_soyadi, okul_no, sinifi, cinsiyet, bolumu, 'Detay' as detay From ogrenciTBL Where adi_soyadi like @fitre";
            OleDbCommand cmd = new OleDbCommand(sql, baglanti);
            cmd.Parameters.AddWithValue("@fitre", "%" + textBoxAra.Text + "%");
            baglanti.Open();
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridViewBilgiler.DataSource = dt;
            baglanti.Close();
            cmd.Dispose();
            baglanti.Dispose();
        }
        //----------------------------------------------------
        private void buttonTemizle_Click(object sender, EventArgs e)
        {
            textBoxAra.Clear();
            textBoxAra.Focus();
        }
        //----------------------------------------------------
        private void dataGridViewBilgiler_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 6)
            {
                Form3 frm3 = new Form3(Convert.ToInt32(dataGridViewBilgiler.CurrentRow.Cells[2].Value));
                frm3.ShowDialog();
                this.Close();
            }
        }
        //----------------------------------------------------
    }
}
