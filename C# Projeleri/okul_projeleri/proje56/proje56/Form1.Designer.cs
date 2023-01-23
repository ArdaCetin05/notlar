namespace proje56
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.s1 = new System.Windows.Forms.TextBox();
            this.s2 = new System.Windows.Forms.TextBox();
            this.snc = new System.Windows.Forms.TextBox();
            this.carpma = new System.Windows.Forms.Button();
            this.bolme = new System.Windows.Forms.Button();
            this.cikarma = new System.Windows.Forms.Button();
            this.toplama = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(22, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "sayi1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(22, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "sayi2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(22, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "sonuc";
            // 
            // s1
            // 
            this.s1.Location = new System.Drawing.Point(93, 18);
            this.s1.Name = "s1";
            this.s1.Size = new System.Drawing.Size(100, 20);
            this.s1.TabIndex = 3;
            // 
            // s2
            // 
            this.s2.Location = new System.Drawing.Point(93, 45);
            this.s2.Name = "s2";
            this.s2.Size = new System.Drawing.Size(100, 20);
            this.s2.TabIndex = 4;
            // 
            // snc
            // 
            this.snc.Location = new System.Drawing.Point(93, 75);
            this.snc.Name = "snc";
            this.snc.ReadOnly = true;
            this.snc.Size = new System.Drawing.Size(100, 20);
            this.snc.TabIndex = 5;
            // 
            // carpma
            // 
            this.carpma.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.carpma.Location = new System.Drawing.Point(30, 202);
            this.carpma.Name = "carpma";
            this.carpma.Size = new System.Drawing.Size(75, 50);
            this.carpma.TabIndex = 6;
            this.carpma.Text = "*";
            this.carpma.UseVisualStyleBackColor = true;
            this.carpma.Click += new System.EventHandler(this.carpma_Click);
            // 
            // bolme
            // 
            this.bolme.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bolme.Location = new System.Drawing.Point(111, 202);
            this.bolme.Name = "bolme";
            this.bolme.Size = new System.Drawing.Size(75, 50);
            this.bolme.TabIndex = 7;
            this.bolme.Text = "/";
            this.bolme.UseVisualStyleBackColor = true;
            this.bolme.Click += new System.EventHandler(this.bolme_Click);
            // 
            // cikarma
            // 
            this.cikarma.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cikarma.Location = new System.Drawing.Point(111, 146);
            this.cikarma.Name = "cikarma";
            this.cikarma.Size = new System.Drawing.Size(75, 50);
            this.cikarma.TabIndex = 8;
            this.cikarma.Text = "-";
            this.cikarma.UseVisualStyleBackColor = true;
            this.cikarma.Click += new System.EventHandler(this.cikarma_Click);
            // 
            // toplama
            // 
            this.toplama.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.toplama.Location = new System.Drawing.Point(30, 146);
            this.toplama.Name = "toplama";
            this.toplama.Size = new System.Drawing.Size(75, 50);
            this.toplama.TabIndex = 9;
            this.toplama.Text = "+";
            this.toplama.UseVisualStyleBackColor = true;
            this.toplama.Click += new System.EventHandler(this.toplama_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(216, 280);
            this.Controls.Add(this.toplama);
            this.Controls.Add(this.cikarma);
            this.Controls.Add(this.bolme);
            this.Controls.Add(this.carpma);
            this.Controls.Add(this.snc);
            this.Controls.Add(this.s2);
            this.Controls.Add(this.s1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "hesap makinesi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox s1;
        private System.Windows.Forms.TextBox s2;
        private System.Windows.Forms.TextBox snc;
        private System.Windows.Forms.Button carpma;
        private System.Windows.Forms.Button bolme;
        private System.Windows.Forms.Button cikarma;
        private System.Windows.Forms.Button toplama;
    }
}

