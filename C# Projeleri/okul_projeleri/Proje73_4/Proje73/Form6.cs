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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=OKULDB.accdb;Persist Security Info=True");
            string sql = "Select adi_soyadi,okul_no,sinifi,cinsiyet,bolumu,detay From ogrenciTBL";
            OleDbCommand cmd = new OleDbCommand(sql, baglanti);
            baglanti.Open();
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataTable datatable = new DataTable();
            da.Fill(datatable);
            dataGridView1.DataSource = datatable;
            cmd.ExecuteNonQuery();
            baglanti.Close();
            cmd.Dispose();
            baglanti.Dispose();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=OKULDB.accdb;Persist Security Info=True");
            string sql = "Select adi_soyadi,okul_no,sinifi,cinsiyet,bolumu,detay From ogrenciTBL where adi_soyadi like @filtre";
            OleDbCommand cmd = new OleDbCommand(sql, baglanti);
            baglanti.Open();
            cmd.Parameters.AddWithValue("@filtre", "%"+textBox1.Text+"%");
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataTable datatable = new DataTable();
            da.Fill(datatable);
            dataGridView1.DataSource = datatable;
            cmd.ExecuteNonQuery();
            baglanti.Close();
            cmd.Dispose();
            baglanti.Dispose();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Form3 frm3 = new Form3();
            frm3.ShowDialog();
        }
    }
}
