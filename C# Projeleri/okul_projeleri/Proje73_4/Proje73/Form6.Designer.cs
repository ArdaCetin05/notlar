namespace Proje73
{
    partial class Form6
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adi_soyadi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.okulno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sinifi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cinsiyet = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.bolumu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detay = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(175, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(216, 30);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(151, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(373, 28);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(74, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.adi_soyadi,
            this.okulno,
            this.sinifi,
            this.cinsiyet,
            this.bolumu,
            this.detay});
            this.dataGridView1.Location = new System.Drawing.Point(16, 72);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(590, 291);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // id
            // 
            this.id.DataPropertyName = "ogrenci_id";
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 40;
            // 
            // adi_soyadi
            // 
            this.adi_soyadi.DataPropertyName = "adi_soyadi";
            this.adi_soyadi.HeaderText = "ad soyad";
            this.adi_soyadi.Name = "adi_soyadi";
            this.adi_soyadi.ReadOnly = true;
            // 
            // okulno
            // 
            this.okulno.DataPropertyName = "okul_no";
            this.okulno.HeaderText = "okul no";
            this.okulno.Name = "okulno";
            this.okulno.ReadOnly = true;
            this.okulno.Width = 70;
            // 
            // sinifi
            // 
            this.sinifi.DataPropertyName = "sinifi";
            this.sinifi.HeaderText = "sınıfı";
            this.sinifi.Name = "sinifi";
            this.sinifi.ReadOnly = true;
            this.sinifi.Width = 40;
            // 
            // cinsiyet
            // 
            this.cinsiyet.DataPropertyName = "cinsiyet";
            this.cinsiyet.HeaderText = "cinsiyet";
            this.cinsiyet.Name = "cinsiyet";
            this.cinsiyet.ReadOnly = true;
            this.cinsiyet.Width = 45;
            // 
            // bolumu
            // 
            this.bolumu.DataPropertyName = "bolumu";
            this.bolumu.HeaderText = "bolumu";
            this.bolumu.Name = "bolumu";
            this.bolumu.ReadOnly = true;
            this.bolumu.Width = 140;
            // 
            // detay
            // 
            this.detay.DataPropertyName = "detay";
            this.detay.HeaderText = "detay";
            this.detay.Name = "detay";
            this.detay.ReadOnly = true;
            this.detay.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.detay.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.detay.Text = "detay";
            this.detay.Width = 75;
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(623, 375);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form6";
            this.Text = "ogrenci liste";
            this.Load += new System.EventHandler(this.Form6_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn adi_soyadi;
        private System.Windows.Forms.DataGridViewTextBoxColumn okulno;
        private System.Windows.Forms.DataGridViewTextBoxColumn sinifi;
        private System.Windows.Forms.DataGridViewCheckBoxColumn cinsiyet;
        private System.Windows.Forms.DataGridViewTextBoxColumn bolumu;
        private System.Windows.Forms.DataGridViewButtonColumn detay;
    }
}