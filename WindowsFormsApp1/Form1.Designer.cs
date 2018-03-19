namespace WindowsFormsApp1
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
            this.FiboSonuc = new System.Windows.Forms.Label();
            this.btnFibo = new System.Windows.Forms.Button();
            this.fiboText = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnDosya = new System.Windows.Forms.Button();
            this.siralama = new System.Windows.Forms.ListBox();
            this.hesaplaBtn = new System.Windows.Forms.Button();
            this.SayiGiris = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.mtrs = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.sayiListesi = new System.Windows.Forms.ListBox();
            this.btnListele = new System.Windows.Forms.Button();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.birinci_islem = new System.Windows.Forms.Button();
            this.labelSonuc = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SonucText = new System.Windows.Forms.TextBox();
            this.ucuncuSayi = new System.Windows.Forms.TextBox();
            this.ikinciSayi = new System.Windows.Forms.TextBox();
            this.birinciSayi = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.groupBox3.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // FiboSonuc
            // 
            this.FiboSonuc.AutoSize = true;
            this.FiboSonuc.Location = new System.Drawing.Point(6, 92);
            this.FiboSonuc.Name = "FiboSonuc";
            this.FiboSonuc.Size = new System.Drawing.Size(0, 17);
            this.FiboSonuc.TabIndex = 2;
            this.FiboSonuc.Visible = false;
            // 
            // btnFibo
            // 
            this.btnFibo.Location = new System.Drawing.Point(109, 21);
            this.btnFibo.Name = "btnFibo";
            this.btnFibo.Size = new System.Drawing.Size(78, 52);
            this.btnFibo.TabIndex = 1;
            this.btnFibo.Text = "Fibonacci\r\n Sonuc";
            this.btnFibo.UseVisualStyleBackColor = true;
            this.btnFibo.Click += new System.EventHandler(this.btnFibo_Click);
            // 
            // fiboText
            // 
            this.fiboText.Location = new System.Drawing.Point(9, 36);
            this.fiboText.Name = "fiboText";
            this.fiboText.Size = new System.Drawing.Size(94, 22);
            this.fiboText.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnFibo);
            this.groupBox3.Controls.Add(this.FiboSonuc);
            this.groupBox3.Controls.Add(this.fiboText);
            this.groupBox3.Location = new System.Drawing.Point(3, 230);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(201, 155);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Beşinci İşlem : Fibonacci";
            // 
            // btnDosya
            // 
            this.btnDosya.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnDosya.Location = new System.Drawing.Point(6, 21);
            this.btnDosya.Name = "btnDosya";
            this.btnDosya.Size = new System.Drawing.Size(61, 57);
            this.btnDosya.TabIndex = 0;
            this.btnDosya.Text = "Dosya \r\nSeç";
            this.btnDosya.UseVisualStyleBackColor = false;
            this.btnDosya.Click += new System.EventHandler(this.btnDosya_Click);
            // 
            // siralama
            // 
            this.siralama.FormattingEnabled = true;
            this.siralama.ItemHeight = 16;
            this.siralama.Location = new System.Drawing.Point(73, 21);
            this.siralama.Name = "siralama";
            this.siralama.Size = new System.Drawing.Size(169, 356);
            this.siralama.TabIndex = 1;
            // 
            // hesaplaBtn
            // 
            this.hesaplaBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.hesaplaBtn.Location = new System.Drawing.Point(112, 60);
            this.hesaplaBtn.Name = "hesaplaBtn";
            this.hesaplaBtn.Size = new System.Drawing.Size(75, 33);
            this.hesaplaBtn.TabIndex = 0;
            this.hesaplaBtn.Text = "Hesapla";
            this.hesaplaBtn.UseVisualStyleBackColor = false;
            this.hesaplaBtn.Click += new System.EventHandler(this.hesaplaBtn_Click);
            // 
            // SayiGiris
            // 
            this.SayiGiris.Location = new System.Drawing.Point(6, 65);
            this.SayiGiris.Name = "SayiGiris";
            this.SayiGiris.Size = new System.Drawing.Size(100, 22);
            this.SayiGiris.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(166, 17);
            this.label5.TabIndex = 2;
            this.label5.Text = "1-15 arası bir sayı giriniz.";
            // 
            // mtrs
            // 
            this.mtrs.AutoSize = true;
            this.mtrs.Location = new System.Drawing.Point(6, 111);
            this.mtrs.Name = "mtrs";
            this.mtrs.Size = new System.Drawing.Size(0, 17);
            this.mtrs.TabIndex = 2;
            this.mtrs.Visible = false;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage2.Controls.Add(this.groupBox5);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(549, 394);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "(2.-4.) İşlem";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.siralama);
            this.groupBox5.Controls.Add(this.btnDosya);
            this.groupBox5.Location = new System.Drawing.Point(283, 8);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(248, 383);
            this.groupBox5.TabIndex = 2;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Dördüncü işlem : Dosya";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.sayiListesi);
            this.groupBox2.Controls.Add(this.btnListele);
            this.groupBox2.Location = new System.Drawing.Point(17, 8);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(260, 384);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "İkinci İşlem : Listeleme";
            // 
            // sayiListesi
            // 
            this.sayiListesi.FormattingEnabled = true;
            this.sayiListesi.ItemHeight = 16;
            this.sayiListesi.Location = new System.Drawing.Point(89, 21);
            this.sayiListesi.Name = "sayiListesi";
            this.sayiListesi.Size = new System.Drawing.Size(163, 356);
            this.sayiListesi.TabIndex = 1;
            // 
            // btnListele
            // 
            this.btnListele.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnListele.Location = new System.Drawing.Point(6, 21);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(75, 38);
            this.btnListele.TabIndex = 0;
            this.btnListele.Text = "Listele";
            this.btnListele.UseVisualStyleBackColor = false;
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage1.Controls.Add(this.groupBox4);
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(549, 394);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "(1.-3.-5.) İşlem";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.mtrs);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.hesaplaBtn);
            this.groupBox4.Controls.Add(this.SayiGiris);
            this.groupBox4.Location = new System.Drawing.Point(213, 3);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(330, 382);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Üçüncü İşlem : Çarpım Tablosu";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.birinci_islem);
            this.groupBox1.Controls.Add(this.labelSonuc);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.SonucText);
            this.groupBox1.Controls.Add(this.ucuncuSayi);
            this.groupBox1.Controls.Add(this.ikinciSayi);
            this.groupBox1.Controls.Add(this.birinciSayi);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(201, 221);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bir İşlem : (a+b)*c";
            // 
            // birinci_islem
            // 
            this.birinci_islem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.birinci_islem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.birinci_islem.Location = new System.Drawing.Point(9, 114);
            this.birinci_islem.Name = "birinci_islem";
            this.birinci_islem.Size = new System.Drawing.Size(171, 31);
            this.birinci_islem.TabIndex = 2;
            this.birinci_islem.Text = "İşlemi Yap";
            this.birinci_islem.UseVisualStyleBackColor = false;
            this.birinci_islem.Click += new System.EventHandler(this.birinci_islem_Click);
            // 
            // labelSonuc
            // 
            this.labelSonuc.AutoSize = true;
            this.labelSonuc.Enabled = false;
            this.labelSonuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelSonuc.Location = new System.Drawing.Point(6, 179);
            this.labelSonuc.Name = "labelSonuc";
            this.labelSonuc.Size = new System.Drawing.Size(49, 15);
            this.labelSonuc.TabIndex = 1;
            this.labelSonuc.Text = "3. Sayı :";
            this.labelSonuc.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "Sonuç :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "3. Sayı :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "2. Sayı :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "1. Sayı :";
            // 
            // SonucText
            // 
            this.SonucText.Enabled = false;
            this.SonucText.Location = new System.Drawing.Point(80, 151);
            this.SonucText.Name = "SonucText";
            this.SonucText.ReadOnly = true;
            this.SonucText.Size = new System.Drawing.Size(100, 22);
            this.SonucText.TabIndex = 0;
            this.SonucText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ucuncuSayi_KeyPress);
            // 
            // ucuncuSayi
            // 
            this.ucuncuSayi.Location = new System.Drawing.Point(80, 86);
            this.ucuncuSayi.Name = "ucuncuSayi";
            this.ucuncuSayi.Size = new System.Drawing.Size(100, 22);
            this.ucuncuSayi.TabIndex = 0;
            this.ucuncuSayi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ucuncuSayi_KeyPress);
            // 
            // ikinciSayi
            // 
            this.ikinciSayi.Location = new System.Drawing.Point(80, 56);
            this.ikinciSayi.Name = "ikinciSayi";
            this.ikinciSayi.Size = new System.Drawing.Size(100, 22);
            this.ikinciSayi.TabIndex = 0;
            this.ikinciSayi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ikinciSayi_KeyPress);
            // 
            // birinciSayi
            // 
            this.birinciSayi.Location = new System.Drawing.Point(80, 26);
            this.birinciSayi.Name = "birinciSayi";
            this.birinciSayi.Size = new System.Drawing.Size(100, 22);
            this.birinciSayi.TabIndex = 0;
            this.birinciSayi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.birinciSayi_KeyPress);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 8);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(557, 423);
            this.tabControl1.TabIndex = 1;
            this.tabControl1.Tag = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 443);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "TeknoKaucukForm";
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label FiboSonuc;
        private System.Windows.Forms.Button btnFibo;
        private System.Windows.Forms.TextBox fiboText;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnDosya;
        private System.Windows.Forms.ListBox siralama;
        private System.Windows.Forms.Button hesaplaBtn;
        private System.Windows.Forms.TextBox SayiGiris;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label mtrs;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox sayiListesi;
        private System.Windows.Forms.Button btnListele;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button birinci_islem;
        private System.Windows.Forms.Label labelSonuc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox SonucText;
        private System.Windows.Forms.TextBox ucuncuSayi;
        private System.Windows.Forms.TextBox ikinciSayi;
        private System.Windows.Forms.TextBox birinciSayi;
        private System.Windows.Forms.TabControl tabControl1;
    }
}

