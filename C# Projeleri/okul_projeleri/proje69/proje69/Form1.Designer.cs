namespace proje69
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioButtonKadın = new System.Windows.Forms.RadioButton();
            this.radioButtonErkek = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxYil = new System.Windows.Forms.ComboBox();
            this.comboBoxAy = new System.Windows.Forms.ComboBox();
            this.comboBoxGun = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxAdSoyad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.radioButtonBB_cok = new System.Windows.Forms.RadioButton();
            this.radioButtonBB_orta = new System.Windows.Forms.RadioButton();
            this.radioButtonBB_Az = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButtonBV_var = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.comboBoxYil);
            this.groupBox1.Controls.Add(this.comboBoxAy);
            this.groupBox1.Controls.Add(this.comboBoxGun);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBoxAdSoyad);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(551, 145);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "lişisel bilgileriniz";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radioButtonKadın);
            this.panel1.Controls.Add(this.radioButtonErkek);
            this.panel1.Location = new System.Drawing.Point(111, 78);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(115, 24);
            this.panel1.TabIndex = 7;
            // 
            // radioButtonKadın
            // 
            this.radioButtonKadın.AutoSize = true;
            this.radioButtonKadın.Location = new System.Drawing.Point(58, 2);
            this.radioButtonKadın.Name = "radioButtonKadın";
            this.radioButtonKadın.Size = new System.Drawing.Size(51, 17);
            this.radioButtonKadın.TabIndex = 1;
            this.radioButtonKadın.TabStop = true;
            this.radioButtonKadın.Text = "kadın";
            this.radioButtonKadın.UseVisualStyleBackColor = true;
            // 
            // radioButtonErkek
            // 
            this.radioButtonErkek.AutoSize = true;
            this.radioButtonErkek.Location = new System.Drawing.Point(0, 2);
            this.radioButtonErkek.Name = "radioButtonErkek";
            this.radioButtonErkek.Size = new System.Drawing.Size(52, 17);
            this.radioButtonErkek.TabIndex = 0;
            this.radioButtonErkek.TabStop = true;
            this.radioButtonErkek.Text = "erkek";
            this.radioButtonErkek.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "cinsiyetiniz :";
            // 
            // comboBoxYil
            // 
            this.comboBoxYil.FormattingEnabled = true;
            this.comboBoxYil.Location = new System.Drawing.Point(260, 51);
            this.comboBoxYil.Name = "comboBoxYil";
            this.comboBoxYil.Size = new System.Drawing.Size(72, 21);
            this.comboBoxYil.TabIndex = 5;
            // 
            // comboBoxAy
            // 
            this.comboBoxAy.FormattingEnabled = true;
            this.comboBoxAy.Items.AddRange(new object[] {
            "ocak",
            "şubat",
            "mart",
            "nisan",
            "mayıs",
            "haziran",
            "temmuz",
            "ağustos",
            "eylül",
            "ekim",
            "kasım",
            "aralık"});
            this.comboBoxAy.Location = new System.Drawing.Point(162, 51);
            this.comboBoxAy.Name = "comboBoxAy";
            this.comboBoxAy.Size = new System.Drawing.Size(92, 21);
            this.comboBoxAy.TabIndex = 5;
            // 
            // comboBoxGun
            // 
            this.comboBoxGun.FormattingEnabled = true;
            this.comboBoxGun.Location = new System.Drawing.Point(110, 51);
            this.comboBoxGun.Name = "comboBoxGun";
            this.comboBoxGun.Size = new System.Drawing.Size(46, 21);
            this.comboBoxGun.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "doğum tarihiniz :";
            // 
            // textBoxAdSoyad
            // 
            this.textBoxAdSoyad.Location = new System.Drawing.Point(111, 27);
            this.textBoxAdSoyad.Name = "textBoxAdSoyad";
            this.textBoxAdSoyad.Size = new System.Drawing.Size(130, 20);
            this.textBoxAdSoyad.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "adınız soyadınız :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.panel3);
            this.groupBox2.Controls.Add(this.panel2);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(12, 163);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(551, 99);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "yetenekler";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.radioButtonBB_cok);
            this.panel3.Controls.Add(this.radioButtonBB_orta);
            this.panel3.Controls.Add(this.radioButtonBB_Az);
            this.panel3.Location = new System.Drawing.Point(123, 50);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(146, 25);
            this.panel3.TabIndex = 2;
            // 
            // radioButtonBB_cok
            // 
            this.radioButtonBB_cok.AutoSize = true;
            this.radioButtonBB_cok.Location = new System.Drawing.Point(97, 4);
            this.radioButtonBB_cok.Name = "radioButtonBB_cok";
            this.radioButtonBB_cok.Size = new System.Drawing.Size(43, 17);
            this.radioButtonBB_cok.TabIndex = 3;
            this.radioButtonBB_cok.TabStop = true;
            this.radioButtonBB_cok.Text = "çok";
            this.radioButtonBB_cok.UseVisualStyleBackColor = true;
            // 
            // radioButtonBB_orta
            // 
            this.radioButtonBB_orta.AutoSize = true;
            this.radioButtonBB_orta.Location = new System.Drawing.Point(49, 4);
            this.radioButtonBB_orta.Name = "radioButtonBB_orta";
            this.radioButtonBB_orta.Size = new System.Drawing.Size(43, 17);
            this.radioButtonBB_orta.TabIndex = 3;
            this.radioButtonBB_orta.TabStop = true;
            this.radioButtonBB_orta.Text = "orta";
            this.radioButtonBB_orta.UseVisualStyleBackColor = true;
            // 
            // radioButtonBB_Az
            // 
            this.radioButtonBB_Az.AutoSize = true;
            this.radioButtonBB_Az.Location = new System.Drawing.Point(3, 4);
            this.radioButtonBB_Az.Name = "radioButtonBB_Az";
            this.radioButtonBB_Az.Size = new System.Drawing.Size(36, 17);
            this.radioButtonBB_Az.TabIndex = 0;
            this.radioButtonBB_Az.TabStop = true;
            this.radioButtonBB_Az.Text = "az";
            this.radioButtonBB_Az.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.radioButton4);
            this.panel2.Controls.Add(this.radioButtonBV_var);
            this.panel2.Location = new System.Drawing.Point(123, 19);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(94, 25);
            this.panel2.TabIndex = 2;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(49, 4);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(42, 17);
            this.radioButton4.TabIndex = 3;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "yok";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButtonBV_var
            // 
            this.radioButtonBV_var.AutoSize = true;
            this.radioButtonBV_var.Location = new System.Drawing.Point(3, 4);
            this.radioButtonBV_var.Name = "radioButtonBV_var";
            this.radioButtonBV_var.Size = new System.Drawing.Size(40, 17);
            this.radioButtonBV_var.TabIndex = 0;
            this.radioButtonBV_var.TabStop = true;
            this.radioButtonBV_var.Text = "var";
            this.radioButtonBV_var.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "bilgisayar bilginiz";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "bilgisayarınız var mı";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(250, 284);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "gönder";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 317);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "anket";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radioButtonKadın;
        private System.Windows.Forms.RadioButton radioButtonErkek;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxYil;
        private System.Windows.Forms.ComboBox comboBoxAy;
        private System.Windows.Forms.ComboBox comboBoxGun;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxAdSoyad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton radioButtonBV_var;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RadioButton radioButtonBB_cok;
        private System.Windows.Forms.RadioButton radioButtonBB_orta;
        private System.Windows.Forms.RadioButton radioButtonBB_Az;
        private System.Windows.Forms.Button button1;
    }
}

