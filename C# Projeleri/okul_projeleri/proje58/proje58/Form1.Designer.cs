
namespace proje58
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.yuk = new System.Windows.Forms.TextBox();
            this.tab = new System.Windows.Forms.TextBox();
            this.hipo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.c = new System.Windows.Forms.Label();
            this.a = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(26, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(321, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "dik üçgende çevre ve alan hesaplaması";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(92, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "yükseklik";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(92, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "taban";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(92, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "hipotenüs";
            // 
            // yuk
            // 
            this.yuk.Location = new System.Drawing.Point(175, 91);
            this.yuk.Name = "yuk";
            this.yuk.Size = new System.Drawing.Size(100, 20);
            this.yuk.TabIndex = 4;
            // 
            // tab
            // 
            this.tab.Location = new System.Drawing.Point(175, 129);
            this.tab.Name = "tab";
            this.tab.Size = new System.Drawing.Size(100, 20);
            this.tab.TabIndex = 5;
            // 
            // hipo
            // 
            this.hipo.Location = new System.Drawing.Point(175, 169);
            this.hipo.Name = "hipo";
            this.hipo.Size = new System.Drawing.Size(100, 20);
            this.hipo.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(95, 225);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "çevre :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(98, 261);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 16);
            this.label6.TabIndex = 8;
            this.label6.Text = "alan :";
            // 
            // c
            // 
            this.c.AutoSize = true;
            this.c.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.c.Location = new System.Drawing.Point(139, 228);
            this.c.Name = "c";
            this.c.Size = new System.Drawing.Size(0, 16);
            this.c.TabIndex = 9;
            // 
            // a
            // 
            this.a.AutoSize = true;
            this.a.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.a.Location = new System.Drawing.Point(139, 263);
            this.a.Name = "a";
            this.a.Size = new System.Drawing.Size(0, 16);
            this.a.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(149, 330);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "hesapla";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 378);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.a);
            this.Controls.Add(this.c);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.hipo);
            this.Controls.Add(this.tab);
            this.Controls.Add(this.yuk);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "dik üçgende çevre ve alan";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox yuk;
        private System.Windows.Forms.TextBox tab;
        private System.Windows.Forms.TextBox hipo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label c;
        private System.Windows.Forms.Label a;
        private System.Windows.Forms.Button button1;
    }
}

