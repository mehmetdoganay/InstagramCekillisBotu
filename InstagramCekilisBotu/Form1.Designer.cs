
namespace InstagramCekilisBotu
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCekilisYap = new System.Windows.Forms.Button();
            this.CmbYedekKisiSayisi = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CmbKazanacakKisiSayisi = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtLink = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.LstKatilimci = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.LstKazananlar = new System.Windows.Forms.ListBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.LstYedekler = new System.Windows.Forms.ListBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCekilisYap);
            this.groupBox1.Controls.Add(this.CmbYedekKisiSayisi);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.CmbKazanacakKisiSayisi);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtLink);
            this.groupBox1.Location = new System.Drawing.Point(164, 71);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(762, 135);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ayarlar";
            // 
            // btnCekilisYap
            // 
            this.btnCekilisYap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.btnCekilisYap.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCekilisYap.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.btnCekilisYap.Location = new System.Drawing.Point(194, 96);
            this.btnCekilisYap.Name = "btnCekilisYap";
            this.btnCekilisYap.Size = new System.Drawing.Size(385, 33);
            this.btnCekilisYap.TabIndex = 6;
            this.btnCekilisYap.Text = "Çekilişi Başlat";
            this.btnCekilisYap.UseVisualStyleBackColor = false;
            this.btnCekilisYap.Click += new System.EventHandler(this.button1_Click);
            // 
            // CmbYedekKisiSayisi
            // 
            this.CmbYedekKisiSayisi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(208)))), ((int)(((byte)(204)))));
            this.CmbYedekKisiSayisi.FormattingEnabled = true;
            this.CmbYedekKisiSayisi.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.CmbYedekKisiSayisi.Location = new System.Drawing.Point(468, 56);
            this.CmbYedekKisiSayisi.Name = "CmbYedekKisiSayisi";
            this.CmbYedekKisiSayisi.Size = new System.Drawing.Size(121, 28);
            this.CmbYedekKisiSayisi.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label3.Location = new System.Drawing.Point(373, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Yedek Sayısı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label2.Location = new System.Drawing.Point(7, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Kazanacak Kişi Sayısı";
            // 
            // CmbKazanacakKisiSayisi
            // 
            this.CmbKazanacakKisiSayisi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(208)))), ((int)(((byte)(204)))));
            this.CmbKazanacakKisiSayisi.FormattingEnabled = true;
            this.CmbKazanacakKisiSayisi.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.CmbKazanacakKisiSayisi.Location = new System.Drawing.Point(167, 56);
            this.CmbKazanacakKisiSayisi.Name = "CmbKazanacakKisiSayisi";
            this.CmbKazanacakKisiSayisi.Size = new System.Drawing.Size(121, 28);
            this.CmbKazanacakKisiSayisi.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label1.Location = new System.Drawing.Point(29, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Gönderi Linki";
            // 
            // txtLink
            // 
            this.txtLink.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(208)))), ((int)(((byte)(204)))));
            this.txtLink.Location = new System.Drawing.Point(123, 19);
            this.txtLink.Name = "txtLink";
            this.txtLink.Size = new System.Drawing.Size(633, 27);
            this.txtLink.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.LstKatilimci);
            this.groupBox2.Location = new System.Drawing.Point(164, 238);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(272, 276);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Katılımcılar";
            // 
            // LstKatilimci
            // 
            this.LstKatilimci.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(208)))), ((int)(((byte)(204)))));
            this.LstKatilimci.FormattingEnabled = true;
            this.LstKatilimci.ItemHeight = 20;
            this.LstKatilimci.Location = new System.Drawing.Point(10, 19);
            this.LstKatilimci.Name = "LstKatilimci";
            this.LstKatilimci.Size = new System.Drawing.Size(256, 244);
            this.LstKatilimci.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.LstKazananlar);
            this.groupBox3.Location = new System.Drawing.Point(605, 238);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(321, 105);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Kazananlar";
            // 
            // LstKazananlar
            // 
            this.LstKazananlar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(208)))), ((int)(((byte)(204)))));
            this.LstKazananlar.FormattingEnabled = true;
            this.LstKazananlar.ItemHeight = 20;
            this.LstKazananlar.Location = new System.Drawing.Point(6, 17);
            this.LstKazananlar.Name = "LstKazananlar";
            this.LstKazananlar.Size = new System.Drawing.Size(315, 64);
            this.LstKazananlar.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.LstYedekler);
            this.groupBox4.Location = new System.Drawing.Point(605, 411);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(321, 118);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Yedekler";
            // 
            // LstYedekler
            // 
            this.LstYedekler.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(208)))), ((int)(((byte)(204)))));
            this.LstYedekler.FormattingEnabled = true;
            this.LstYedekler.ItemHeight = 20;
            this.LstYedekler.Location = new System.Drawing.Point(6, 23);
            this.LstYedekler.Name = "LstYedekler";
            this.LstYedekler.Size = new System.Drawing.Size(315, 64);
            this.LstYedekler.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.button2.Location = new System.Drawing.Point(164, 535);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(272, 32);
            this.button2.TabIndex = 4;
            this.button2.Text = "Dışa Aktar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.button3.Location = new System.Drawing.Point(605, 349);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(321, 33);
            this.button3.TabIndex = 5;
            this.button3.Text = "Dışa Aktar";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.button4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.button4.Location = new System.Drawing.Point(605, 535);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(321, 32);
            this.button4.TabIndex = 6;
            this.button4.Text = "Dışa Aktar";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(136)))), ((int)(((byte)(130)))));
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.label4.Location = new System.Drawing.Point(166, 9);
            this.label4.MaximumSize = new System.Drawing.Size(1000, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(777, 46);
            this.label4.TabIndex = 7;
            this.label4.Text = "IEEE BAUN INSTAGRAM ÇEKİLİŞ ARACI";
            // 
            // ımageList1
            // 
            this.ımageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.ımageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.button1.Location = new System.Drawing.Point(977, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 33);
            this.button1.TabIndex = 8;
            this.button1.Text = "Kapat";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(136)))), ((int)(((byte)(130)))));
            this.ClientSize = new System.Drawing.Size(1075, 600);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.Color.DarkOrange;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox CmbYedekKisiSayisi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CmbKazanacakKisiSayisi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLink;
        private System.Windows.Forms.Button btnCekilisYap;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox LstKatilimci;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ListBox LstKazananlar;
        private System.Windows.Forms.ListBox LstYedekler;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.Button button1;
    }
}

