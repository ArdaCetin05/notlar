namespace Proje73
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.labelAdSoyad = new System.Windows.Forms.Label();
            this.textBoxAdSoyad = new System.Windows.Forms.TextBox();
            this.labelOkulNo = new System.Windows.Forms.Label();
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
            this.buttonKaydet = new System.Windows.Forms.Button();
            this.comboBoxBolumu = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelAdSoyadHata = new System.Windows.Forms.Label();
            this.labelOkulNoHata = new System.Windows.Forms.Label();
            this.labelTCHata = new System.Windows.Forms.Label();
            this.labelGSMHata = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelAdSoyad
            // 
            this.labelAdSoyad.AutoSize = true;
            this.labelAdSoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelAdSoyad.Location = new System.Drawing.Point(18, 25);
            this.labelAdSoyad.Name = "labelAdSoyad";
            this.labelAdSoyad.Size = new System.Drawing.Size(80, 16);
            this.labelAdSoyad.TabIndex = 0;
            this.labelAdSoyad.Text = "Ad Soyadı";
            // 
            // textBoxAdSoyad
            // 
            this.textBoxAdSoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxAdSoyad.Location = new System.Drawing.Point(104, 22);
            this.textBoxAdSoyad.MaxLength = 100;
            this.textBoxAdSoyad.Name = "textBoxAdSoyad";
            this.textBoxAdSoyad.Size = new System.Drawing.Size(175, 22);
            this.textBoxAdSoyad.TabIndex = 0;
            this.textBoxAdSoyad.TextChanged += new System.EventHandler(this.textBoxAdSoyad_TextChanged);
            // 
            // labelOkulNo
            // 
            this.labelOkulNo.AutoSize = true;
            this.labelOkulNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelOkulNo.Location = new System.Drawing.Point(35, 60);
            this.labelOkulNo.Name = "labelOkulNo";
            this.labelOkulNo.Size = new System.Drawing.Size(63, 16);
            this.labelOkulNo.TabIndex = 2;
            this.labelOkulNo.Text = "Okul No";
            // 
            // textBoxOkulNo
            // 
            this.textBoxOkulNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxOkulNo.Location = new System.Drawing.Point(104, 59);
            this.textBoxOkulNo.Name = "textBoxOkulNo";
            this.textBoxOkulNo.Size = new System.Drawing.Size(175, 22);
            this.textBoxOkulNo.TabIndex = 3;
            this.textBoxOkulNo.TextChanged += new System.EventHandler(this.textBoxOkulNo_TextChanged);
            // 
            // labelSinif
            // 
            this.labelSinif.AutoSize = true;
            this.labelSinif.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelSinif.Location = new System.Drawing.Point(56, 95);
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
            "10/AE",
            "10/AB"});
            this.comboBoxSinif.Location = new System.Drawing.Point(104, 96);
            this.comboBoxSinif.Name = "comboBoxSinif";
            this.comboBoxSinif.Size = new System.Drawing.Size(175, 21);
            this.comboBoxSinif.TabIndex = 5;
            // 
            // labelBolumu
            // 
            this.labelBolumu.AutoSize = true;
            this.labelBolumu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelBolumu.Location = new System.Drawing.Point(39, 130);
            this.labelBolumu.Name = "labelBolumu";
            this.labelBolumu.Size = new System.Drawing.Size(59, 16);
            this.labelBolumu.TabIndex = 6;
            this.labelBolumu.Text = "Bölümü";
            // 
            // labelCinsiyet
            // 
            this.labelCinsiyet.AutoSize = true;
            this.labelCinsiyet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelCinsiyet.Location = new System.Drawing.Point(39, 165);
            this.labelCinsiyet.Name = "labelCinsiyet";
            this.labelCinsiyet.Size = new System.Drawing.Size(63, 16);
            this.labelCinsiyet.TabIndex = 8;
            this.labelCinsiyet.Text = "Cinsiyet";
            // 
            // radioButtonErkek
            // 
            this.radioButtonErkek.AutoSize = true;
            this.radioButtonErkek.Checked = true;
            this.radioButtonErkek.Location = new System.Drawing.Point(119, 168);
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
            this.radioButtonKadin.Location = new System.Drawing.Point(197, 168);
            this.radioButtonKadin.Name = "radioButtonKadin";
            this.radioButtonKadin.Size = new System.Drawing.Size(52, 17);
            this.radioButtonKadin.TabIndex = 10;
            this.radioButtonKadin.Text = "Kadın";
            this.radioButtonKadin.UseVisualStyleBackColor = true;
            // 
            // textBoxTC
            // 
            this.textBoxTC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxTC.Location = new System.Drawing.Point(104, 200);
            this.textBoxTC.MaxLength = 11;
            this.textBoxTC.Name = "textBoxTC";
            this.textBoxTC.Size = new System.Drawing.Size(175, 22);
            this.textBoxTC.TabIndex = 12;
            this.textBoxTC.TextChanged += new System.EventHandler(this.textBoxTC_TextChanged);
            // 
            // labelTC
            // 
            this.labelTC.AutoSize = true;
            this.labelTC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelTC.Location = new System.Drawing.Point(25, 200);
            this.labelTC.Name = "labelTC";
            this.labelTC.Size = new System.Drawing.Size(73, 16);
            this.labelTC.TabIndex = 11;
            this.labelTC.Text = "TC Kimlik";
            // 
            // labelDT
            // 
            this.labelDT.AutoSize = true;
            this.labelDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelDT.Location = new System.Drawing.Point(1, 235);
            this.labelDT.Name = "labelDT";
            this.labelDT.Size = new System.Drawing.Size(101, 16);
            this.labelDT.TabIndex = 13;
            this.labelDT.Text = "Doğum Tarihi";
            // 
            // dateTimePickerDT
            // 
            this.dateTimePickerDT.Location = new System.Drawing.Point(104, 237);
            this.dateTimePickerDT.Name = "dateTimePickerDT";
            this.dateTimePickerDT.Size = new System.Drawing.Size(175, 20);
            this.dateTimePickerDT.TabIndex = 14;
            // 
            // maskedTextBoxGSM
            // 
            this.maskedTextBoxGSM.Location = new System.Drawing.Point(104, 272);
            this.maskedTextBoxGSM.Mask = "(999) 000-0000";
            this.maskedTextBoxGSM.Name = "maskedTextBoxGSM";
            this.maskedTextBoxGSM.Size = new System.Drawing.Size(175, 20);
            this.maskedTextBoxGSM.TabIndex = 15;
            this.maskedTextBoxGSM.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBoxGSM_MaskInputRejected);
            // 
            // labelGSM
            // 
            this.labelGSM.AutoSize = true;
            this.labelGSM.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelGSM.Location = new System.Drawing.Point(56, 270);
            this.labelGSM.Name = "labelGSM";
            this.labelGSM.Size = new System.Drawing.Size(41, 16);
            this.labelGSM.TabIndex = 16;
            this.labelGSM.Text = "GSM";
            // 
            // buttonKaydet
            // 
            this.buttonKaydet.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.buttonKaydet.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonKaydet.Location = new System.Drawing.Point(474, 200);
            this.buttonKaydet.Name = "buttonKaydet";
            this.buttonKaydet.Size = new System.Drawing.Size(75, 23);
            this.buttonKaydet.TabIndex = 18;
            this.buttonKaydet.Text = "Kaydet";
            this.buttonKaydet.UseVisualStyleBackColor = true;
            this.buttonKaydet.Click += new System.EventHandler(this.buttonKaydet_Click);
            // 
            // comboBoxBolumu
            // 
            this.comboBoxBolumu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxBolumu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBoxBolumu.FormattingEnabled = true;
            this.comboBoxBolumu.Items.AddRange(new object[] {
            "Bilişim",
            "Kimya"});
            this.comboBoxBolumu.Location = new System.Drawing.Point(104, 132);
            this.comboBoxBolumu.Name = "comboBoxBolumu";
            this.comboBoxBolumu.Size = new System.Drawing.Size(175, 21);
            this.comboBoxBolumu.TabIndex = 19;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Proje73.Resource1.logo2;
            this.pictureBox1.Location = new System.Drawing.Point(363, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(291, 164);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // labelAdSoyadHata
            // 
            this.labelAdSoyadHata.AutoSize = true;
            this.labelAdSoyadHata.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelAdSoyadHata.ForeColor = System.Drawing.Color.Red;
            this.labelAdSoyadHata.Location = new System.Drawing.Point(285, 27);
            this.labelAdSoyadHata.Name = "labelAdSoyadHata";
            this.labelAdSoyadHata.Size = new System.Drawing.Size(12, 13);
            this.labelAdSoyadHata.TabIndex = 20;
            this.labelAdSoyadHata.Text = "*";
            this.labelAdSoyadHata.Visible = false;
            // 
            // labelOkulNoHata
            // 
            this.labelOkulNoHata.AutoSize = true;
            this.labelOkulNoHata.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelOkulNoHata.ForeColor = System.Drawing.Color.Red;
            this.labelOkulNoHata.Location = new System.Drawing.Point(285, 62);
            this.labelOkulNoHata.Name = "labelOkulNoHata";
            this.labelOkulNoHata.Size = new System.Drawing.Size(12, 13);
            this.labelOkulNoHata.TabIndex = 21;
            this.labelOkulNoHata.Text = "*";
            this.labelOkulNoHata.Visible = false;
            // 
            // labelTCHata
            // 
            this.labelTCHata.AutoSize = true;
            this.labelTCHata.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelTCHata.ForeColor = System.Drawing.Color.Red;
            this.labelTCHata.Location = new System.Drawing.Point(285, 202);
            this.labelTCHata.Name = "labelTCHata";
            this.labelTCHata.Size = new System.Drawing.Size(12, 13);
            this.labelTCHata.TabIndex = 22;
            this.labelTCHata.Text = "*";
            this.labelTCHata.Visible = false;
            // 
            // labelGSMHata
            // 
            this.labelGSMHata.AutoSize = true;
            this.labelGSMHata.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelGSMHata.ForeColor = System.Drawing.Color.Red;
            this.labelGSMHata.Location = new System.Drawing.Point(285, 272);
            this.labelGSMHata.Name = "labelGSMHata";
            this.labelGSMHata.Size = new System.Drawing.Size(12, 13);
            this.labelGSMHata.TabIndex = 23;
            this.labelGSMHata.Text = "*";
            this.labelGSMHata.Visible = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "resim|*.png";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(676, 359);
            this.Controls.Add(this.labelGSMHata);
            this.Controls.Add(this.labelTCHata);
            this.Controls.Add(this.labelOkulNoHata);
            this.Controls.Add(this.labelAdSoyadHata);
            this.Controls.Add(this.comboBoxBolumu);
            this.Controls.Add(this.buttonKaydet);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelGSM);
            this.Controls.Add(this.maskedTextBoxGSM);
            this.Controls.Add(this.dateTimePickerDT);
            this.Controls.Add(this.labelDT);
            this.Controls.Add(this.textBoxTC);
            this.Controls.Add(this.labelTC);
            this.Controls.Add(this.radioButtonKadin);
            this.Controls.Add(this.radioButtonErkek);
            this.Controls.Add(this.labelCinsiyet);
            this.Controls.Add(this.labelBolumu);
            this.Controls.Add(this.comboBoxSinif);
            this.Controls.Add(this.labelSinif);
            this.Controls.Add(this.textBoxOkulNo);
            this.Controls.Add(this.labelOkulNo);
            this.Controls.Add(this.textBoxAdSoyad);
            this.Controls.Add(this.labelAdSoyad);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yeni Öğrenci Kayıt";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelAdSoyad;
        private System.Windows.Forms.TextBox textBoxAdSoyad;
        private System.Windows.Forms.Label labelOkulNo;
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
        private System.Windows.Forms.Button buttonKaydet;
        private System.Windows.Forms.ComboBox comboBoxBolumu;
        private System.Windows.Forms.Label labelAdSoyadHata;
        private System.Windows.Forms.Label labelOkulNoHata;
        private System.Windows.Forms.Label labelTCHata;
        private System.Windows.Forms.Label labelGSMHata;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}