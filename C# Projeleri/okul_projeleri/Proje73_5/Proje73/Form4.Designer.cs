namespace Proje73
{
    partial class Form4
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelOgrenciArama = new System.Windows.Forms.Label();
            this.textBoxAra = new System.Windows.Forms.TextBox();
            this.buttonTemizle = new System.Windows.Forms.Button();
            this.dataGridViewBilgiler = new System.Windows.Forms.DataGridView();
            this.ogrenci_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adi_soyadi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.okul_no = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sinifi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cinsiyet = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.bolumu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detay = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBilgiler)).BeginInit();
            this.SuspendLayout();
            // 
            // labelOgrenciArama
            // 
            this.labelOgrenciArama.AutoSize = true;
            this.labelOgrenciArama.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelOgrenciArama.Location = new System.Drawing.Point(187, 11);
            this.labelOgrenciArama.Name = "labelOgrenciArama";
            this.labelOgrenciArama.Size = new System.Drawing.Size(98, 16);
            this.labelOgrenciArama.TabIndex = 0;
            this.labelOgrenciArama.Text = "Öğrenci Arama";
            // 
            // textBoxAra
            // 
            this.textBoxAra.Location = new System.Drawing.Point(295, 10);
            this.textBoxAra.Name = "textBoxAra";
            this.textBoxAra.Size = new System.Drawing.Size(109, 20);
            this.textBoxAra.TabIndex = 1;
            this.textBoxAra.TextChanged += new System.EventHandler(this.textBoxAra_TextChanged);
            // 
            // buttonTemizle
            // 
            this.buttonTemizle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonTemizle.Location = new System.Drawing.Point(414, 8);
            this.buttonTemizle.Name = "buttonTemizle";
            this.buttonTemizle.Size = new System.Drawing.Size(75, 23);
            this.buttonTemizle.TabIndex = 2;
            this.buttonTemizle.Text = "Temizle";
            this.buttonTemizle.UseVisualStyleBackColor = true;
            this.buttonTemizle.Click += new System.EventHandler(this.buttonTemizle_Click);
            // 
            // dataGridViewBilgiler
            // 
            this.dataGridViewBilgiler.AllowUserToAddRows = false;
            this.dataGridViewBilgiler.AllowUserToDeleteRows = false;
            this.dataGridViewBilgiler.AllowUserToOrderColumns = true;
            this.dataGridViewBilgiler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBilgiler.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ogrenci_id,
            this.adi_soyadi,
            this.okul_no,
            this.sinifi,
            this.cinsiyet,
            this.bolumu,
            this.detay});
            this.dataGridViewBilgiler.Location = new System.Drawing.Point(12, 48);
            this.dataGridViewBilgiler.MultiSelect = false;
            this.dataGridViewBilgiler.Name = "dataGridViewBilgiler";
            this.dataGridViewBilgiler.ReadOnly = true;
            this.dataGridViewBilgiler.RowTemplate.Height = 20;
            this.dataGridViewBilgiler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewBilgiler.Size = new System.Drawing.Size(652, 299);
            this.dataGridViewBilgiler.TabIndex = 3;
            this.dataGridViewBilgiler.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewBilgiler_CellContentClick);
            // 
            // ogrenci_id
            // 
            this.ogrenci_id.DataPropertyName = "ogrenci_id";
            this.ogrenci_id.HeaderText = "İd";
            this.ogrenci_id.Name = "ogrenci_id";
            this.ogrenci_id.ReadOnly = true;
            this.ogrenci_id.Width = 40;
            // 
            // adi_soyadi
            // 
            this.adi_soyadi.DataPropertyName = "adi_soyadi";
            this.adi_soyadi.HeaderText = "Ad Soyad";
            this.adi_soyadi.Name = "adi_soyadi";
            this.adi_soyadi.ReadOnly = true;
            this.adi_soyadi.Width = 110;
            // 
            // okul_no
            // 
            this.okul_no.DataPropertyName = "okul_no";
            this.okul_no.HeaderText = "Okul No";
            this.okul_no.Name = "okul_no";
            this.okul_no.ReadOnly = true;
            this.okul_no.Width = 70;
            // 
            // sinifi
            // 
            this.sinifi.DataPropertyName = "sinifi";
            this.sinifi.HeaderText = "Sınıfı";
            this.sinifi.Name = "sinifi";
            this.sinifi.ReadOnly = true;
            this.sinifi.Width = 70;
            // 
            // cinsiyet
            // 
            this.cinsiyet.DataPropertyName = "cinsiyet";
            this.cinsiyet.HeaderText = "Cinsiyet";
            this.cinsiyet.Name = "cinsiyet";
            this.cinsiyet.ReadOnly = true;
            this.cinsiyet.Width = 70;
            // 
            // bolumu
            // 
            this.bolumu.DataPropertyName = "bolumu";
            this.bolumu.HeaderText = "Bölümü";
            this.bolumu.Name = "bolumu";
            this.bolumu.ReadOnly = true;
            this.bolumu.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.bolumu.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.bolumu.Width = 148;
            // 
            // detay
            // 
            this.detay.DataPropertyName = "detay";
            this.detay.HeaderText = "Detay";
            this.detay.Name = "detay";
            this.detay.ReadOnly = true;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(676, 359);
            this.Controls.Add(this.dataGridViewBilgiler);
            this.Controls.Add(this.buttonTemizle);
            this.Controls.Add(this.textBoxAra);
            this.Controls.Add(this.labelOgrenciArama);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Öğrenci Listeleme";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBilgiler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelOgrenciArama;
        private System.Windows.Forms.TextBox textBoxAra;
        private System.Windows.Forms.Button buttonTemizle;
        private System.Windows.Forms.DataGridView dataGridViewBilgiler;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrenci_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn adi_soyadi;
        private System.Windows.Forms.DataGridViewTextBoxColumn okul_no;
        private System.Windows.Forms.DataGridViewTextBoxColumn sinifi;
        private System.Windows.Forms.DataGridViewCheckBoxColumn cinsiyet;
        private System.Windows.Forms.DataGridViewTextBoxColumn bolumu;
        private System.Windows.Forms.DataGridViewButtonColumn detay;

    }
}