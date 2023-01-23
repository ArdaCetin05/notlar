namespace Proje73
{
    partial class Form3
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
            this.labelAdSoyad = new System.Windows.Forms.Label();
            this.textBoxAdSoyad = new System.Windows.Forms.TextBox();
            this.textBoxOkulNo = new System.Windows.Forms.TextBox();
            this.labelSinif = new System.Windows.Forms.Label();
            this.comboBoxSinif = new System.Windows.Forms.ComboBox();
            this.labelBolumu = new System.Windows.Forms.Label();
            this.labelCinsiyet = new System.Windows.Forms.Label();
            this.radioButtonErkek = new System.Windows.Forms.RadioButton();
            this.radioButtonKadin = new System.Windows.Forms.RadioButton();
            this.textBoxTC = new System.Windows.Forms.TextBox();
            this.labelTC = new System.Windows.Forms.Label();
            this.labelDT = new System.Windows.Forms.Label();
            this.dateTimePickerDT = new System.Windows.Forms.DateTimePicker();
            this.maskedTextBoxGSM = new System.Windows.Forms.MaskedTextBox();
            this.labelGSM = new System.Windows.Forms.Label();
            this.buttonAra = new System.Windows.Forms.Button();
            this.comboBoxBolumu = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBoxOgrenciOkulNo = new System.Windows.Forms.GroupBox();
            this.groupBoxOgrenciBilgileri = new System.Windows.Forms.GroupBox();
            this.labelOkulNo = new System.Windows.Forms.Label();
            this.labelOkulNoBaslik = new System.Windows.Forms.Label();
            this.groupBoxOgrenciFotograf = new System.Windows.Forms.GroupBox();
            this.groupBoxİslem = new System.Windows.Forms.GroupBox();
            this.panelGuncelle = new System.Windows.Forms.Panel();
            this.buttonİptal = new System.Windows.Forms.Button();
            this.buttonKaydet = new System.Windows.Forms.Button();
            this.panelİslem = new System.Windows.Forms.Panel();
            this.buttonSil = new System.Windows.Forms.Button();
            this.buttonGuncelle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBoxOgrenciOkulNo.SuspendLayout();
            this.groupBoxOgrenciBilgileri.SuspendLayout();
            this.groupBoxOgrenciFotograf.SuspendLayout();
            this.groupBoxİslem.SuspendLayout();
            this.panelGuncelle.SuspendLayout();
            this.panelİslem.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelAdSoyad
            // 
            this.labelAdSoyad.AutoSize = true;
            this.labelAdSoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelAdSoyad.Location = new System.Drawing.Point(52, 43);
            this.labelAdSoyad.Name = "labelAdSoyad";
            this.labelAdSoyad.Size = new System.Drawing.Size(80, 16);
            this.labelAdSoyad.TabIndex = 0;
            this.labelAdSoyad.Text = "Ad Soyadı";
            // 
            // textBoxAdSoyad
            // 
            this.textBoxAdSoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxAdSoyad.Location = new System.Drawing.Point(138, 40);
            this.textBoxAdSoyad.MaxLength = 100;
            this.textBoxAdSoyad.Name = "textBoxAdSoyad";
            this.textBoxAdSoyad.Size = new System.Drawing.Size(175, 22);
            this.textBoxAdSoyad.TabIndex = 0;
            // 
            // textBoxOkulNo
            // 
            this.textBoxOkulNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxOkulNo.Location = new System.Drawing.Point(48, 19);
            this.textBoxOkulNo.Name = "textBoxOkulNo";
            this.textBoxOkulNo.Size = new System.Drawing.Size(175, 22);
            this.textBoxOkulNo.TabIndex = 3;
            // 
            // labelSinif
            // 
            this.labelSinif.AutoSize = true;
            this.labelSinif.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelSinif.Location = new System.Drawing.Point(90, 73);
            this.labelSinif.Name = "labelSinif";
            this.labelSinif.Size = new System.Drawing.Size(42, 16);
            this.labelSinif.TabIndex = 4;
            this.labelSinif.Text = "Sınıfı";
            // 
            // comboBoxSinif
            // 
            this.comboBoxSinif.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSinif.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBoxSinif.FormattingEnabled = true;
            this.comboBoxSinif.Items.AddRange(new object[] {
            "9/A",
            "9/B",
            "9/AE",
            "9/AB",
            "10/A",
            "10/B",
            "10/F",
            "10/AE",
            "10/AB",
            "12/AB",
            "12/AE"});
            this.comboBoxSinif.Location = new System.Drawing.Point(138, 74);
            this.comboBoxSinif.Name = "comboBoxSinif";
            this.comboBoxSinif.Size = new System.Drawing.Size(175, 21);
            this.comboBoxSinif.TabIndex = 5;
            // 
            // labelBolumu
            // 
            this.labelBolumu.AutoSize = true;
            this.labelBolumu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelBolumu.Location = new System.Drawing.Point(73, 108);
            this.labelBolumu.Name = "labelBolumu";
            this.labelBolumu.Size = new System.Drawing.Size(59, 16);
            this.labelBolumu.TabIndex = 6;
            this.labelBolumu.Text = "Bölümü";
            // 
            // labelCinsiyet
            // 
            this.labelCinsiyet.AutoSize = true;
            this.labelCinsiyet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelCinsiyet.Location = new System.Drawing.Point(73, 143);
            this.labelCinsiyet.Name = "labelCinsiyet";
            this.labelCinsiyet.Size = new System.Drawing.Size(63, 16);
            this.labelCinsiyet.TabIndex = 8;
            this.labelCinsiyet.Text = "Cinsiyet";
            // 
            // radioButtonErkek
            // 
            this.radioButtonErkek.AutoSize = true;
            this.radioButtonErkek.Checked = true;
            this.radioButtonErkek.Location = new System.Drawing.Point(153, 146);
            this.radioButtonErkek.Name = "radioButtonErkek";
            this.radioButtonErkek.Size = new System.Drawing.Size(53, 17);
            this.radioButtonErkek.TabIndex = 9;
            this.radioButtonErkek.TabStop = true;
            this.radioButtonErkek.Text = "Erkek";
            this.radioButtonErkek.UseVisualStyleBackColor = true;
            // 
            // radioButtonKadin
            // 
            this.radioButtonKadin.AutoSize = true;
            this.radioButtonKadin.Location = new System.Drawing.Point(231, 146);
            this.radioButtonKadin.Name = "radioButtonKadin";
            this.radioButtonKadin.Size = new System.Drawing.Size(52, 17);
            this.radioButtonKadin.TabIndex = 10;
            this.radioButtonKadin.Text = "Kadın";
            this.radioButtonKadin.UseVisualStyleBackColor = true;
            // 
            // textBoxTC
            // 
            this.textBoxTC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxTC.Location = new System.Drawing.Point(138, 178);
            this.textBoxTC.MaxLength = 11;
            this.textBoxTC.Name = "textBoxTC";
            this.textBoxTC.Size = new System.Drawing.Size(175, 22);
            this.textBoxTC.TabIndex = 12;
            // 
            // labelTC
            // 
            this.labelTC.AutoSize = true;
            this.labelTC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelTC.Location = new System.Drawing.Point(59, 178);
            this.labelTC.Name = "labelTC";
            this.labelTC.Size = new System.Drawing.Size(73, 16);
            this.labelTC.TabIndex = 11;
            this.labelTC.Text = "TC Kimlik";
            // 
            // labelDT
            // 
            this.labelDT.AutoSize = true;
            this.labelDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelDT.Location = new System.Drawing.Point(35, 213);
            this.labelDT.Name = "labelDT";
            this.labelDT.Size = new System.Drawing.Size(101, 16);
            this.labelDT.TabIndex = 13;
            this.labelDT.Text = "Doğum Tarihi";
            // 
            // dateTimePickerDT
            // 
            this.dateTimePickerDT.Location = new System.Drawing.Point(138, 215);
            this.dateTimePickerDT.Name = "dateTimePickerDT";
            this.dateTimePickerDT.Size = new System.Drawing.Size(175, 20);
            this.dateTimePickerDT.TabIndex = 14;
            // 
            // maskedTextBoxGSM
            // 
            this.maskedTextBoxGSM.Location = new System.Drawing.Point(138, 250);
            this.maskedTextBoxGSM.Mask = "(999) 000-0000";
            this.maskedTextBoxGSM.Name = "maskedTextBoxGSM";
            this.maskedTextBoxGSM.Size = new System.Drawing.Size(175, 20);
            this.maskedTextBoxGSM.TabIndex = 15;
            // 
            // labelGSM
            // 
            this.labelGSM.AutoSize = true;
            this.labelGSM.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelGSM.Location = new System.Drawing.Point(90, 248);
            this.labelGSM.Name = "labelGSM";
            this.labelGSM.Size = new System.Drawing.Size(41, 16);
            this.labelGSM.TabIndex = 16;
            this.labelGSM.Text = "GSM";
            // 
            // buttonAra
            // 
            this.buttonAra.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.buttonAra.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAra.Location = new System.Drawing.Point(226, 19);
            this.buttonAra.Name = "buttonAra";
            this.buttonAra.Size = new System.Drawing.Size(75, 23);
            this.buttonAra.TabIndex = 18;
            this.buttonAra.Text = "Ara";
            this.buttonAra.UseVisualStyleBackColor = true;
            this.buttonAra.Click += new System.EventHandler(this.buttonAra_Click);
            // 
            // comboBoxBolumu
            // 
            this.comboBoxBolumu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxBolumu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBoxBolumu.FormattingEnabled = true;
            this.comboBoxBolumu.Items.AddRange(new object[] {
            "Bilişim Teknolojileri / Yazılım Geliştirme Dalı",
            "Bilişim Teknolojileri/Veri Tabanı Programcılığı",
            "Kimya",
            "Çift Kanatlı Hayvan Yetiştiriciliği",
            "Bilişim"});
            this.comboBoxBolumu.Location = new System.Drawing.Point(138, 110);
            this.comboBoxBolumu.Name = "comboBoxBolumu";
            this.comboBoxBolumu.Size = new System.Drawing.Size(175, 21);
            this.comboBoxBolumu.TabIndex = 19;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Proje73.Resource1.logo2;
            this.pictureBox1.Location = new System.Drawing.Point(14, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(270, 165);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // groupBoxOgrenciOkulNo
            // 
            this.groupBoxOgrenciOkulNo.Controls.Add(this.textBoxOkulNo);
            this.groupBoxOgrenciOkulNo.Controls.Add(this.buttonAra);
            this.groupBoxOgrenciOkulNo.Location = new System.Drawing.Point(12, 12);
            this.groupBoxOgrenciOkulNo.Name = "groupBoxOgrenciOkulNo";
            this.groupBoxOgrenciOkulNo.Size = new System.Drawing.Size(348, 49);
            this.groupBoxOgrenciOkulNo.TabIndex = 24;
            this.groupBoxOgrenciOkulNo.TabStop = false;
            this.groupBoxOgrenciOkulNo.Text = "Öğrenci Okul Numarası";
            // 
            // groupBoxOgrenciBilgileri
            // 
            this.groupBoxOgrenciBilgileri.Controls.Add(this.labelOkulNo);
            this.groupBoxOgrenciBilgileri.Controls.Add(this.labelOkulNoBaslik);
            this.groupBoxOgrenciBilgileri.Controls.Add(this.textBoxAdSoyad);
            this.groupBoxOgrenciBilgileri.Controls.Add(this.labelAdSoyad);
            this.groupBoxOgrenciBilgileri.Controls.Add(this.comboBoxBolumu);
            this.groupBoxOgrenciBilgileri.Controls.Add(this.labelSinif);
            this.groupBoxOgrenciBilgileri.Controls.Add(this.comboBoxSinif);
            this.groupBoxOgrenciBilgileri.Controls.Add(this.labelBolumu);
            this.groupBoxOgrenciBilgileri.Controls.Add(this.labelGSM);
            this.groupBoxOgrenciBilgileri.Controls.Add(this.labelCinsiyet);
            this.groupBoxOgrenciBilgileri.Controls.Add(this.maskedTextBoxGSM);
            this.groupBoxOgrenciBilgileri.Controls.Add(this.radioButtonErkek);
            this.groupBoxOgrenciBilgileri.Controls.Add(this.dateTimePickerDT);
            this.groupBoxOgrenciBilgileri.Controls.Add(this.radioButtonKadin);
            this.groupBoxOgrenciBilgileri.Controls.Add(this.labelDT);
            this.groupBoxOgrenciBilgileri.Controls.Add(this.labelTC);
            this.groupBoxOgrenciBilgileri.Controls.Add(this.textBoxTC);
            this.groupBoxOgrenciBilgileri.Enabled = false;
            this.groupBoxOgrenciBilgileri.Location = new System.Drawing.Point(12, 67);
            this.groupBoxOgrenciBilgileri.Name = "groupBoxOgrenciBilgileri";
            this.groupBoxOgrenciBilgileri.Size = new System.Drawing.Size(348, 280);
            this.groupBoxOgrenciBilgileri.TabIndex = 25;
            this.groupBoxOgrenciBilgileri.TabStop = false;
            this.groupBoxOgrenciBilgileri.Text = "Öğrenci Bilgileri";
            // 
            // labelOkulNo
            // 
            this.labelOkulNo.AutoSize = true;
            this.labelOkulNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelOkulNo.Location = new System.Drawing.Point(135, 12);
            this.labelOkulNo.Name = "labelOkulNo";
            this.labelOkulNo.Size = new System.Drawing.Size(0, 16);
            this.labelOkulNo.TabIndex = 21;
            // 
            // labelOkulNoBaslik
            // 
            this.labelOkulNoBaslik.AutoSize = true;
            this.labelOkulNoBaslik.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelOkulNoBaslik.Location = new System.Drawing.Point(68, 12);
            this.labelOkulNoBaslik.Name = "labelOkulNoBaslik";
            this.labelOkulNoBaslik.Size = new System.Drawing.Size(63, 16);
            this.labelOkulNoBaslik.TabIndex = 20;
            this.labelOkulNoBaslik.Text = "Okul No";
            // 
            // groupBoxOgrenciFotograf
            // 
            this.groupBoxOgrenciFotograf.Controls.Add(this.pictureBox1);
            this.groupBoxOgrenciFotograf.Location = new System.Drawing.Point(366, 12);
            this.groupBoxOgrenciFotograf.Name = "groupBoxOgrenciFotograf";
            this.groupBoxOgrenciFotograf.Size = new System.Drawing.Size(298, 195);
            this.groupBoxOgrenciFotograf.TabIndex = 26;
            this.groupBoxOgrenciFotograf.TabStop = false;
            this.groupBoxOgrenciFotograf.Text = "Öğrenci Fotoğrafı";
            // 
            // groupBoxİslem
            // 
            this.groupBoxİslem.Controls.Add(this.panelGuncelle);
            this.groupBoxİslem.Controls.Add(this.panelİslem);
            this.groupBoxİslem.Enabled = false;
            this.groupBoxİslem.Location = new System.Drawing.Point(366, 213);
            this.groupBoxİslem.Name = "groupBoxİslem";
            this.groupBoxİslem.Size = new System.Drawing.Size(298, 134);
            this.groupBoxİslem.TabIndex = 27;
            this.groupBoxİslem.TabStop = false;
            // 
            // panelGuncelle
            // 
            this.panelGuncelle.Controls.Add(this.buttonİptal);
            this.panelGuncelle.Controls.Add(this.buttonKaydet);
            this.panelGuncelle.Location = new System.Drawing.Point(14, 19);
            this.panelGuncelle.Name = "panelGuncelle";
            this.panelGuncelle.Size = new System.Drawing.Size(270, 100);
            this.panelGuncelle.TabIndex = 21;
            this.panelGuncelle.Visible = false;
            // 
            // buttonİptal
            // 
            this.buttonİptal.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.buttonİptal.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonİptal.Location = new System.Drawing.Point(151, 39);
            this.buttonİptal.Name = "buttonİptal";
            this.buttonİptal.Size = new System.Drawing.Size(75, 23);
            this.buttonİptal.TabIndex = 20;
            this.buttonİptal.Text = "İptal";
            this.buttonİptal.UseVisualStyleBackColor = true;
            this.buttonİptal.Click += new System.EventHandler(this.buttonİptal_Click);
            // 
            // buttonKaydet
            // 
            this.buttonKaydet.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.buttonKaydet.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonKaydet.Location = new System.Drawing.Point(45, 39);
            this.buttonKaydet.Name = "buttonKaydet";
            this.buttonKaydet.Size = new System.Drawing.Size(75, 23);
            this.buttonKaydet.TabIndex = 19;
            this.buttonKaydet.Text = "Kaydet";
            this.buttonKaydet.UseVisualStyleBackColor = true;
            this.buttonKaydet.Click += new System.EventHandler(this.buttonKaydet_Click);
            // 
            // panelİslem
            // 
            this.panelİslem.Controls.Add(this.buttonSil);
            this.panelİslem.Controls.Add(this.buttonGuncelle);
            this.panelİslem.Location = new System.Drawing.Point(14, 19);
            this.panelİslem.Name = "panelİslem";
            this.panelİslem.Size = new System.Drawing.Size(270, 100);
            this.panelİslem.TabIndex = 0;
            // 
            // buttonSil
            // 
            this.buttonSil.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.buttonSil.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSil.Location = new System.Drawing.Point(151, 39);
            this.buttonSil.Name = "buttonSil";
            this.buttonSil.Size = new System.Drawing.Size(75, 23);
            this.buttonSil.TabIndex = 20;
            this.buttonSil.Text = "Sil";
            this.buttonSil.UseVisualStyleBackColor = true;
            this.buttonSil.Click += new System.EventHandler(this.buttonSil_Click);
            // 
            // buttonGuncelle
            // 
            this.buttonGuncelle.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.buttonGuncelle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonGuncelle.Location = new System.Drawing.Point(45, 39);
            this.buttonGuncelle.Name = "buttonGuncelle";
            this.buttonGuncelle.Size = new System.Drawing.Size(75, 23);
            this.buttonGuncelle.TabIndex = 19;
            this.buttonGuncelle.Text = "Güncelle";
            this.buttonGuncelle.UseVisualStyleBackColor = true;
            this.buttonGuncelle.Click += new System.EventHandler(this.buttonGuncelle_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(676, 359);
            this.Controls.Add(this.groupBoxİslem);
            this.Controls.Add(this.groupBoxOgrenciFotograf);
            this.Controls.Add(this.groupBoxOgrenciBilgileri);
            this.Controls.Add(this.groupBoxOgrenciOkulNo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yeni Öğrenci Kayıt";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBoxOgrenciOkulNo.ResumeLayout(false);
            this.groupBoxOgrenciOkulNo.PerformLayout();
            this.groupBoxOgrenciBilgileri.ResumeLayout(false);
            this.groupBoxOgrenciBilgileri.PerformLayout();
            this.groupBoxOgrenciFotograf.ResumeLayout(false);
            this.groupBoxİslem.ResumeLayout(false);
            this.panelGuncelle.ResumeLayout(false);
            this.panelİslem.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelAdSoyad;
        private System.Windows.Forms.TextBox textBoxAdSoyad;
        private System.Windows.Forms.TextBox textBoxOkulNo;
        private System.Windows.Forms.Label labelSinif;
        private System.Windows.Forms.ComboBox comboBoxSinif;
        private System.Windows.Forms.Label labelBolumu;
        private System.Windows.Forms.Label labelCinsiyet;
        private System.Windows.Forms.RadioButton radioButtonErkek;
        private System.Windows.Forms.RadioButton radioButtonKadin;
        private System.Windows.Forms.TextBox textBoxTC;
        private System.Windows.Forms.Label labelTC;
        private System.Windows.Forms.Label labelDT;
        private System.Windows.Forms.DateTimePicker dateTimePickerDT;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxGSM;
        private System.Windows.Forms.Label labelGSM;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonAra;
        private System.Windows.Forms.ComboBox comboBoxBolumu;
        private System.Windows.Forms.GroupBox groupBoxOgrenciOkulNo;
        private System.Windows.Forms.GroupBox groupBoxOgrenciBilgileri;
        private System.Windows.Forms.GroupBox groupBoxOgrenciFotograf;
        private System.Windows.Forms.GroupBox groupBoxİslem;
        private System.Windows.Forms.Label labelOkulNoBaslik;
        private System.Windows.Forms.Panel panelİslem;
        private System.Windows.Forms.Button buttonSil;
        private System.Windows.Forms.Button buttonGuncelle;
        private System.Windows.Forms.Panel panelGuncelle;
        private System.Windows.Forms.Button buttonİptal;
        private System.Windows.Forms.Button buttonKaydet;
        private System.Windows.Forms.Label labelOkulNo;
    }
}