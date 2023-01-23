
namespace Proje72
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.progressBarDurum = new System.Windows.Forms.ProgressBar();
            this.labelYuzde = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.buttonUret = new System.Windows.Forms.Button();
            this.timerUretec = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(51, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "ilerleme";
            // 
            // progressBarDurum
            // 
            this.progressBarDurum.Location = new System.Drawing.Point(92, 21);
            this.progressBarDurum.Maximum = 200;
            this.progressBarDurum.Name = "progressBarDurum";
            this.progressBarDurum.Size = new System.Drawing.Size(477, 13);
            this.progressBarDurum.Step = 1;
            this.progressBarDurum.TabIndex = 1;
            // 
            // labelYuzde
            // 
            this.labelYuzde.AutoSize = true;
            this.labelYuzde.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelYuzde.Location = new System.Drawing.Point(575, 21);
            this.labelYuzde.Name = "labelYuzde";
            this.labelYuzde.Size = new System.Drawing.Size(33, 16);
            this.labelYuzde.TabIndex = 0;
            this.labelYuzde.Text = "% 0";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 18);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(233, 381);
            this.listBox1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listBox1);
            this.groupBox1.Location = new System.Drawing.Point(54, 72);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(267, 417);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "rastgele sayı 1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listBox2);
            this.groupBox2.Location = new System.Drawing.Point(341, 72);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(267, 417);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "rastgele sayı 2";
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(12, 18);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(233, 381);
            this.listBox2.TabIndex = 0;
            // 
            // buttonUret
            // 
            this.buttonUret.Location = new System.Drawing.Point(295, 495);
            this.buttonUret.Name = "buttonUret";
            this.buttonUret.Size = new System.Drawing.Size(75, 23);
            this.buttonUret.TabIndex = 4;
            this.buttonUret.Text = "üret";
            this.buttonUret.UseVisualStyleBackColor = true;
            this.buttonUret.Click += new System.EventHandler(this.buttonUret_Click);
            // 
            // timerUretec
            // 
            this.timerUretec.Tick += new System.EventHandler(this.timerUretec_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 523);
            this.Controls.Add(this.buttonUret);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.progressBarDurum);
            this.Controls.Add(this.labelYuzde);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar progressBarDurum;
        private System.Windows.Forms.Label labelYuzde;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button buttonUret;
        private System.Windows.Forms.Timer timerUretec;
    }
}

