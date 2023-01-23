namespace Proje73
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.labelTarih = new System.Windows.Forms.Label();
            this.timerTarih = new System.Windows.Forms.Timer(this.components);
            this.labelSaat = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.forumToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yeniKayıtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ogrenciBilgiKartıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çıkışToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTarih
            // 
            this.labelTarih.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelTarih.Location = new System.Drawing.Point(524, 33);
            this.labelTarih.Name = "labelTarih";
            this.labelTarih.Size = new System.Drawing.Size(140, 23);
            this.labelTarih.TabIndex = 0;
            this.labelTarih.Text = "Tarih";
            this.labelTarih.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timerTarih
            // 
            this.timerTarih.Enabled = true;
            this.timerTarih.Interval = 1000;
            this.timerTarih.Tick += new System.EventHandler(this.timerTarih_Tick);
            // 
            // labelSaat
            // 
            this.labelSaat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelSaat.Location = new System.Drawing.Point(524, 71);
            this.labelSaat.Name = "labelSaat";
            this.labelSaat.Size = new System.Drawing.Size(140, 23);
            this.labelSaat.TabIndex = 1;
            this.labelSaat.Text = "Saat";
            this.labelSaat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.forumToolStripMenuItem,
            this.çıkışToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(676, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // forumToolStripMenuItem
            // 
            this.forumToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yeniKayıtToolStripMenuItem,
            this.ogrenciBilgiKartıToolStripMenuItem});
            this.forumToolStripMenuItem.Name = "forumToolStripMenuItem";
            this.forumToolStripMenuItem.Size = new System.Drawing.Size(108, 20);
            this.forumToolStripMenuItem.Text = "Öğrenci İşlemleri";
            // 
            // yeniKayıtToolStripMenuItem
            // 
            this.yeniKayıtToolStripMenuItem.Name = "yeniKayıtToolStripMenuItem";
            this.yeniKayıtToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.yeniKayıtToolStripMenuItem.Text = "Yeni Kayıt";
            this.yeniKayıtToolStripMenuItem.Click += new System.EventHandler(this.yeniKayıtToolStripMenuItem_Click);
            // 
            // ogrenciBilgiKartıToolStripMenuItem
            // 
            this.ogrenciBilgiKartıToolStripMenuItem.Name = "ogrenciBilgiKartıToolStripMenuItem";
            this.ogrenciBilgiKartıToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.ogrenciBilgiKartıToolStripMenuItem.Text = "Öğrenci Bilgi Kartı";
            this.ogrenciBilgiKartıToolStripMenuItem.Click += new System.EventHandler(this.ogrenciBilgiKartıToolStripMenuItem_Click);
            // 
            // çıkışToolStripMenuItem
            // 
            this.çıkışToolStripMenuItem.Name = "çıkışToolStripMenuItem";
            this.çıkışToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.çıkışToolStripMenuItem.Text = "Çıkış";
            this.çıkışToolStripMenuItem.Click += new System.EventHandler(this.çıkışToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 33);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(273, 213);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(676, 359);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelSaat);
            this.Controls.Add(this.labelTarih);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "H-OKUL";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTarih;
        private System.Windows.Forms.Timer timerTarih;
        private System.Windows.Forms.Label labelSaat;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem forumToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çıkışToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem yeniKayıtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ogrenciBilgiKartıToolStripMenuItem;
    }
}

