namespace proje62
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.kal = new System.Windows.Forms.Label();
            this.sifrel = new System.Windows.Forms.Label();
            this.ka = new System.Windows.Forms.TextBox();
            this.sifre = new System.Windows.Forms.TextBox();
            this.kaHata = new System.Windows.Forms.Label();
            this.sifreHata = new System.Windows.Forms.Label();
            this.hata = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // kal
            // 
            this.kal.AutoSize = true;
            this.kal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kal.Location = new System.Drawing.Point(34, 47);
            this.kal.Name = "kal";
            this.kal.Size = new System.Drawing.Size(91, 16);
            this.kal.TabIndex = 0;
            this.kal.Text = "kullanıcı adı";
            // 
            // sifrel
            // 
            this.sifrel.AutoSize = true;
            this.sifrel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sifrel.Location = new System.Drawing.Point(80, 90);
            this.sifrel.Name = "sifrel";
            this.sifrel.Size = new System.Drawing.Size(38, 16);
            this.sifrel.TabIndex = 1;
            this.sifrel.Text = "şifre";
            // 
            // ka
            // 
            this.ka.Location = new System.Drawing.Point(131, 46);
            this.ka.Name = "ka";
            this.ka.Size = new System.Drawing.Size(145, 20);
            this.ka.TabIndex = 2;
            this.ka.TextChanged += new System.EventHandler(this.ka_TextChanged);
            // 
            // sifre
            // 
            this.sifre.Location = new System.Drawing.Point(131, 90);
            this.sifre.Name = "sifre";
            this.sifre.PasswordChar = '*';
            this.sifre.Size = new System.Drawing.Size(145, 20);
            this.sifre.TabIndex = 3;
            this.sifre.TextChanged += new System.EventHandler(this.sifre_TextChanged);
            // 
            // kaHata
            // 
            this.kaHata.AutoSize = true;
            this.kaHata.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kaHata.ForeColor = System.Drawing.Color.Red;
            this.kaHata.Location = new System.Drawing.Point(282, 47);
            this.kaHata.Name = "kaHata";
            this.kaHata.Size = new System.Drawing.Size(14, 16);
            this.kaHata.TabIndex = 4;
            this.kaHata.Text = "*";
            // 
            // sifreHata
            // 
            this.sifreHata.AutoSize = true;
            this.sifreHata.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sifreHata.ForeColor = System.Drawing.Color.Red;
            this.sifreHata.Location = new System.Drawing.Point(282, 91);
            this.sifreHata.Name = "sifreHata";
            this.sifreHata.Size = new System.Drawing.Size(14, 16);
            this.sifreHata.TabIndex = 5;
            this.sifreHata.Text = "*";
            // 
            // hata
            // 
            this.hata.AutoSize = true;
            this.hata.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.hata.ForeColor = System.Drawing.Color.Red;
            this.hata.Location = new System.Drawing.Point(80, 137);
            this.hata.Name = "hata";
            this.hata.Size = new System.Drawing.Size(249, 16);
            this.hata.TabIndex = 6;
            this.hata.Text = "kullanıcı adı ve/veya şifreniz yanlış";
            this.hata.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(163, 187);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "giris";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(335, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(142, 153);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 221);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.hata);
            this.Controls.Add(this.sifreHata);
            this.Controls.Add(this.kaHata);
            this.Controls.Add(this.sifre);
            this.Controls.Add(this.ka);
            this.Controls.Add(this.sifrel);
            this.Controls.Add(this.kal);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label kal;
        private System.Windows.Forms.Label sifrel;
        private System.Windows.Forms.TextBox ka;
        private System.Windows.Forms.TextBox sifre;
        private System.Windows.Forms.Label kaHata;
        private System.Windows.Forms.Label sifreHata;
        private System.Windows.Forms.Label hata;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

