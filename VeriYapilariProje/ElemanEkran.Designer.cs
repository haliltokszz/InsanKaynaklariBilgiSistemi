namespace VeriYapilariProje
{
    partial class ElemanEkran
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
            this.tabControlEleman = new System.Windows.Forms.TabControl();
            this.tabKisiEkle = new System.Windows.Forms.TabPage();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.btnKisiAra = new System.Windows.Forms.Button();
            this.txtKisiArama = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtKisiDy = new System.Windows.Forms.TextBox();
            this.txtKisiDg = new System.Windows.Forms.DateTimePicker();
            this.txtKisiSoyad = new System.Windows.Forms.TextBox();
            this.txtKisiTC = new System.Windows.Forms.MaskedTextBox();
            this.txtKisiAdres = new System.Windows.Forms.TextBox();
            this.txtKisiYabanciDil = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtKisiTel = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.txtKisiEposta = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.txtKisiAd = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.btnKisiEkle = new System.Windows.Forms.Button();
            this.btnKisiSil = new System.Windows.Forms.Button();
            this.btnKisiGuncelle = new System.Windows.Forms.Button();
            this.tabCV = new System.Windows.Forms.TabPage();
            this.txtCVKisiArama = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnCVTemizle = new System.Windows.Forms.Button();
            this.txtCVIsyeriAd = new System.Windows.Forms.TextBox();
            this.txtCVOkulBaslangicYili = new System.Windows.Forms.MaskedTextBox();
            this.txtCVIsyeriAdres = new System.Windows.Forms.TextBox();
            this.txtCVOkulBitisYili = new System.Windows.Forms.MaskedTextBox();
            this.txtCVOkulNotOrtalama = new System.Windows.Forms.TextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.txtCVIsyeriCalismaYili = new System.Windows.Forms.MaskedTextBox();
            this.txtCVOkulBolum = new System.Windows.Forms.TextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.txtCVOkulAd = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.txtCVIsyeriPozisyon = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.btnCVekle = new System.Windows.Forms.Button();
            this.label22 = new System.Windows.Forms.Label();
            this.tabIlanBasvuru = new System.Windows.Forms.TabPage();
            this.btnListele = new System.Windows.Forms.Button();
            this.txtIlanIsyeriAd = new System.Windows.Forms.TextBox();
            this.lblIsyeriAd = new System.Windows.Forms.Label();
            this.rdbtnIsyeriAd = new System.Windows.Forms.RadioButton();
            this.rdbtnPozisyon = new System.Windows.Forms.RadioButton();
            this.txtIlanKisiArama = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnBasvur = new System.Windows.Forms.Button();
            this.lstIsIlan = new System.Windows.Forms.ListView();
            this.label9 = new System.Windows.Forms.Label();
            this.tabControlEleman.SuspendLayout();
            this.tabKisiEkle.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabCV.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabIlanBasvuru.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlEleman
            // 
            this.tabControlEleman.Controls.Add(this.tabKisiEkle);
            this.tabControlEleman.Controls.Add(this.tabCV);
            this.tabControlEleman.Controls.Add(this.tabIlanBasvuru);
            this.tabControlEleman.Location = new System.Drawing.Point(-3, 2);
            this.tabControlEleman.Name = "tabControlEleman";
            this.tabControlEleman.SelectedIndex = 0;
            this.tabControlEleman.Size = new System.Drawing.Size(487, 504);
            this.tabControlEleman.TabIndex = 66;
            // 
            // tabKisiEkle
            // 
            this.tabKisiEkle.BackColor = System.Drawing.Color.DarkTurquoise;
            this.tabKisiEkle.Controls.Add(this.btnTemizle);
            this.tabKisiEkle.Controls.Add(this.btnKisiAra);
            this.tabKisiEkle.Controls.Add(this.txtKisiArama);
            this.tabKisiEkle.Controls.Add(this.label6);
            this.tabKisiEkle.Controls.Add(this.groupBox1);
            this.tabKisiEkle.Controls.Add(this.btnKisiEkle);
            this.tabKisiEkle.Controls.Add(this.btnKisiSil);
            this.tabKisiEkle.Controls.Add(this.btnKisiGuncelle);
            this.tabKisiEkle.Location = new System.Drawing.Point(4, 25);
            this.tabKisiEkle.Name = "tabKisiEkle";
            this.tabKisiEkle.Padding = new System.Windows.Forms.Padding(3);
            this.tabKisiEkle.Size = new System.Drawing.Size(479, 475);
            this.tabKisiEkle.TabIndex = 0;
            this.tabKisiEkle.Text = "Kişi İşlemleri";
            // 
            // btnTemizle
            // 
            this.btnTemizle.BackColor = System.Drawing.Color.Salmon;
            this.btnTemizle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTemizle.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTemizle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnTemizle.Location = new System.Drawing.Point(9, 421);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(129, 50);
            this.btnTemizle.TabIndex = 68;
            this.btnTemizle.Text = "Textboxları Temizle";
            this.btnTemizle.UseVisualStyleBackColor = false;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // btnKisiAra
            // 
            this.btnKisiAra.BackColor = System.Drawing.Color.Snow;
            this.btnKisiAra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKisiAra.Location = new System.Drawing.Point(345, 37);
            this.btnKisiAra.Name = "btnKisiAra";
            this.btnKisiAra.Size = new System.Drawing.Size(116, 34);
            this.btnKisiAra.TabIndex = 67;
            this.btnKisiAra.Text = "Ara";
            this.btnKisiAra.UseVisualStyleBackColor = false;
            this.btnKisiAra.Click += new System.EventHandler(this.btnKisiAra_Click);
            // 
            // txtKisiArama
            // 
            this.txtKisiArama.Location = new System.Drawing.Point(138, 43);
            this.txtKisiArama.Name = "txtKisiArama";
            this.txtKisiArama.Size = new System.Drawing.Size(201, 22);
            this.txtKisiArama.TabIndex = 66;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 43);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 17);
            this.label6.TabIndex = 65;
            this.label6.Text = "Seçilecek Kişi TC:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtKisiDy);
            this.groupBox1.Controls.Add(this.txtKisiDg);
            this.groupBox1.Controls.Add(this.txtKisiSoyad);
            this.groupBox1.Controls.Add(this.txtKisiTC);
            this.groupBox1.Controls.Add(this.txtKisiAdres);
            this.groupBox1.Controls.Add(this.txtKisiYabanciDil);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtKisiTel);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.txtKisiEposta);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label24);
            this.groupBox1.Controls.Add(this.txtKisiAd);
            this.groupBox1.Controls.Add(this.label23);
            this.groupBox1.Location = new System.Drawing.Point(6, 77);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(455, 338);
            this.groupBox1.TabIndex = 64;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kişi Bilgileri";
            // 
            // txtKisiDy
            // 
            this.txtKisiDy.Location = new System.Drawing.Point(117, 209);
            this.txtKisiDy.Name = "txtKisiDy";
            this.txtKisiDy.Size = new System.Drawing.Size(279, 22);
            this.txtKisiDy.TabIndex = 43;
            // 
            // txtKisiDg
            // 
            this.txtKisiDg.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtKisiDg.Location = new System.Drawing.Point(117, 237);
            this.txtKisiDg.Name = "txtKisiDg";
            this.txtKisiDg.Size = new System.Drawing.Size(279, 22);
            this.txtKisiDg.TabIndex = 63;
            // 
            // txtKisiSoyad
            // 
            this.txtKisiSoyad.Location = new System.Drawing.Point(117, 71);
            this.txtKisiSoyad.Name = "txtKisiSoyad";
            this.txtKisiSoyad.Size = new System.Drawing.Size(279, 22);
            this.txtKisiSoyad.TabIndex = 51;
            // 
            // txtKisiTC
            // 
            this.txtKisiTC.Location = new System.Drawing.Point(117, 99);
            this.txtKisiTC.Mask = "00000000000";
            this.txtKisiTC.Name = "txtKisiTC";
            this.txtKisiTC.Size = new System.Drawing.Size(279, 22);
            this.txtKisiTC.TabIndex = 61;
            // 
            // txtKisiAdres
            // 
            this.txtKisiAdres.Location = new System.Drawing.Point(117, 181);
            this.txtKisiAdres.Name = "txtKisiAdres";
            this.txtKisiAdres.Size = new System.Drawing.Size(279, 22);
            this.txtKisiAdres.TabIndex = 41;
            // 
            // txtKisiYabanciDil
            // 
            this.txtKisiYabanciDil.Location = new System.Drawing.Point(117, 303);
            this.txtKisiYabanciDil.Name = "txtKisiYabanciDil";
            this.txtKisiYabanciDil.Size = new System.Drawing.Size(279, 22);
            this.txtKisiYabanciDil.TabIndex = 42;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 17);
            this.label5.TabIndex = 23;
            this.label5.Text = "E-Posta:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(11, 99);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(52, 17);
            this.label13.TabIndex = 40;
            this.label13.Text = "TC No:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift SemiBold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(11, 275);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(385, 17);
            this.label4.TabIndex = 24;
            this.label4.Text = "Birden fazla yabancı dil biliyorsanız aralarına boşluk koyun.";
            // 
            // txtKisiTel
            // 
            this.txtKisiTel.Location = new System.Drawing.Point(117, 127);
            this.txtKisiTel.Mask = "(999) 000-0000";
            this.txtKisiTel.Name = "txtKisiTel";
            this.txtKisiTel.Size = new System.Drawing.Size(279, 22);
            this.txtKisiTel.TabIndex = 55;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 17);
            this.label3.TabIndex = 25;
            this.label3.Text = "Adres:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(12, 209);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(86, 17);
            this.label16.TabIndex = 37;
            this.label16.Text = "Doğum Yeri:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 17);
            this.label2.TabIndex = 26;
            this.label2.Text = "Telefon:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(11, 237);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(97, 17);
            this.label17.TabIndex = 36;
            this.label17.Text = "Doğum Tarihi:";
            // 
            // txtKisiEposta
            // 
            this.txtKisiEposta.Location = new System.Drawing.Point(117, 155);
            this.txtKisiEposta.Name = "txtKisiEposta";
            this.txtKisiEposta.Size = new System.Drawing.Size(279, 22);
            this.txtKisiEposta.TabIndex = 31;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 17);
            this.label1.TabIndex = 27;
            this.label1.Text = "Ad:";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(7, 299);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(83, 17);
            this.label24.TabIndex = 59;
            this.label24.Text = "Yabancı Dil:";
            // 
            // txtKisiAd
            // 
            this.txtKisiAd.Location = new System.Drawing.Point(117, 39);
            this.txtKisiAd.Name = "txtKisiAd";
            this.txtKisiAd.Size = new System.Drawing.Size(279, 22);
            this.txtKisiAd.TabIndex = 28;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(11, 71);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(52, 17);
            this.label23.TabIndex = 60;
            this.label23.Text = "Soyad:";
            // 
            // btnKisiEkle
            // 
            this.btnKisiEkle.BackColor = System.Drawing.Color.Snow;
            this.btnKisiEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKisiEkle.Location = new System.Drawing.Point(272, 427);
            this.btnKisiEkle.Name = "btnKisiEkle";
            this.btnKisiEkle.Size = new System.Drawing.Size(94, 39);
            this.btnKisiEkle.TabIndex = 33;
            this.btnKisiEkle.Text = "Ekle";
            this.btnKisiEkle.UseVisualStyleBackColor = false;
            this.btnKisiEkle.Click += new System.EventHandler(this.btnKisiEkle_Click);
            // 
            // btnKisiSil
            // 
            this.btnKisiSil.BackColor = System.Drawing.Color.Snow;
            this.btnKisiSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKisiSil.Location = new System.Drawing.Point(172, 427);
            this.btnKisiSil.Name = "btnKisiSil";
            this.btnKisiSil.Size = new System.Drawing.Size(82, 39);
            this.btnKisiSil.TabIndex = 35;
            this.btnKisiSil.Text = "Sil";
            this.btnKisiSil.UseVisualStyleBackColor = false;
            this.btnKisiSil.Click += new System.EventHandler(this.btnKisiSil_Click);
            // 
            // btnKisiGuncelle
            // 
            this.btnKisiGuncelle.BackColor = System.Drawing.Color.Snow;
            this.btnKisiGuncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKisiGuncelle.Location = new System.Drawing.Point(372, 427);
            this.btnKisiGuncelle.Name = "btnKisiGuncelle";
            this.btnKisiGuncelle.Size = new System.Drawing.Size(89, 39);
            this.btnKisiGuncelle.TabIndex = 34;
            this.btnKisiGuncelle.Text = "Guncelle";
            this.btnKisiGuncelle.UseVisualStyleBackColor = false;
            this.btnKisiGuncelle.Click += new System.EventHandler(this.btnKisiGuncelle_Click);
            // 
            // tabCV
            // 
            this.tabCV.BackColor = System.Drawing.Color.DarkTurquoise;
            this.tabCV.Controls.Add(this.txtCVKisiArama);
            this.tabCV.Controls.Add(this.label7);
            this.tabCV.Controls.Add(this.groupBox2);
            this.tabCV.Location = new System.Drawing.Point(4, 25);
            this.tabCV.Name = "tabCV";
            this.tabCV.Padding = new System.Windows.Forms.Padding(3);
            this.tabCV.Size = new System.Drawing.Size(479, 475);
            this.tabCV.TabIndex = 1;
            this.tabCV.Text = "CV Ekle";
            // 
            // txtCVKisiArama
            // 
            this.txtCVKisiArama.Location = new System.Drawing.Point(161, 39);
            this.txtCVKisiArama.Name = "txtCVKisiArama";
            this.txtCVKisiArama.Size = new System.Drawing.Size(276, 22);
            this.txtCVKisiArama.TabIndex = 92;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(29, 39);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 17);
            this.label7.TabIndex = 91;
            this.label7.Text = "Seçilecek Kişi TC:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.btnCVTemizle);
            this.groupBox2.Controls.Add(this.txtCVIsyeriAd);
            this.groupBox2.Controls.Add(this.txtCVOkulBaslangicYili);
            this.groupBox2.Controls.Add(this.txtCVIsyeriAdres);
            this.groupBox2.Controls.Add(this.txtCVOkulBitisYili);
            this.groupBox2.Controls.Add(this.txtCVOkulNotOrtalama);
            this.groupBox2.Controls.Add(this.label28);
            this.groupBox2.Controls.Add(this.txtCVIsyeriCalismaYili);
            this.groupBox2.Controls.Add(this.txtCVOkulBolum);
            this.groupBox2.Controls.Add(this.label27);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label26);
            this.groupBox2.Controls.Add(this.label19);
            this.groupBox2.Controls.Add(this.txtCVOkulAd);
            this.groupBox2.Controls.Add(this.label20);
            this.groupBox2.Controls.Add(this.txtCVIsyeriPozisyon);
            this.groupBox2.Controls.Add(this.label21);
            this.groupBox2.Controls.Add(this.label25);
            this.groupBox2.Controls.Add(this.btnCVekle);
            this.groupBox2.Controls.Add(this.label22);
            this.groupBox2.Location = new System.Drawing.Point(28, 67);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(409, 401);
            this.groupBox2.TabIndex = 88;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "CV Bilgileri";
            // 
            // btnCVTemizle
            // 
            this.btnCVTemizle.BackColor = System.Drawing.Color.Salmon;
            this.btnCVTemizle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCVTemizle.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCVTemizle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCVTemizle.Location = new System.Drawing.Point(66, 292);
            this.btnCVTemizle.Name = "btnCVTemizle";
            this.btnCVTemizle.Size = new System.Drawing.Size(129, 50);
            this.btnCVTemizle.TabIndex = 88;
            this.btnCVTemizle.Text = "Textboxları Temizle";
            this.btnCVTemizle.UseVisualStyleBackColor = false;
            this.btnCVTemizle.Click += new System.EventHandler(this.btnCVTemizle_Click);
            // 
            // txtCVIsyeriAd
            // 
            this.txtCVIsyeriAd.Location = new System.Drawing.Point(169, 31);
            this.txtCVIsyeriAd.Name = "txtCVIsyeriAd";
            this.txtCVIsyeriAd.Size = new System.Drawing.Size(169, 22);
            this.txtCVIsyeriAd.TabIndex = 66;
            // 
            // txtCVOkulBaslangicYili
            // 
            this.txtCVOkulBaslangicYili.Location = new System.Drawing.Point(169, 197);
            this.txtCVOkulBaslangicYili.Mask = "00000";
            this.txtCVOkulBaslangicYili.Name = "txtCVOkulBaslangicYili";
            this.txtCVOkulBaslangicYili.Size = new System.Drawing.Size(169, 22);
            this.txtCVOkulBaslangicYili.TabIndex = 87;
            this.txtCVOkulBaslangicYili.ValidatingType = typeof(int);
            // 
            // txtCVIsyeriAdres
            // 
            this.txtCVIsyeriAdres.Location = new System.Drawing.Point(169, 59);
            this.txtCVIsyeriAdres.Name = "txtCVIsyeriAdres";
            this.txtCVIsyeriAdres.Size = new System.Drawing.Size(169, 22);
            this.txtCVIsyeriAdres.TabIndex = 79;
            // 
            // txtCVOkulBitisYili
            // 
            this.txtCVOkulBitisYili.Location = new System.Drawing.Point(169, 227);
            this.txtCVOkulBitisYili.Mask = "00000";
            this.txtCVOkulBitisYili.Name = "txtCVOkulBitisYili";
            this.txtCVOkulBitisYili.Size = new System.Drawing.Size(169, 22);
            this.txtCVOkulBitisYili.TabIndex = 86;
            this.txtCVOkulBitisYili.ValidatingType = typeof(int);
            // 
            // txtCVOkulNotOrtalama
            // 
            this.txtCVOkulNotOrtalama.Location = new System.Drawing.Point(169, 255);
            this.txtCVOkulNotOrtalama.Name = "txtCVOkulNotOrtalama";
            this.txtCVOkulNotOrtalama.Size = new System.Drawing.Size(169, 22);
            this.txtCVOkulNotOrtalama.TabIndex = 76;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(63, 87);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(106, 17);
            this.label28.TabIndex = 74;
            this.label28.Text = "İşyeri Pozisyon:";
            // 
            // txtCVIsyeriCalismaYili
            // 
            this.txtCVIsyeriCalismaYili.Location = new System.Drawing.Point(169, 115);
            this.txtCVIsyeriCalismaYili.Mask = "00";
            this.txtCVIsyeriCalismaYili.Name = "txtCVIsyeriCalismaYili";
            this.txtCVIsyeriCalismaYili.Size = new System.Drawing.Size(169, 22);
            this.txtCVIsyeriCalismaYili.TabIndex = 81;
            this.txtCVIsyeriCalismaYili.ValidatingType = typeof(int);
            // 
            // txtCVOkulBolum
            // 
            this.txtCVOkulBolum.Location = new System.Drawing.Point(169, 169);
            this.txtCVOkulBolum.Name = "txtCVOkulBolum";
            this.txtCVOkulBolum.Size = new System.Drawing.Size(169, 22);
            this.txtCVOkulBolum.TabIndex = 75;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(64, 197);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(95, 17);
            this.label27.TabIndex = 73;
            this.label27.Text = "Başlangıç Yılı:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(63, 143);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(65, 17);
            this.label14.TabIndex = 61;
            this.label14.Text = "Okul Adı:";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(63, 225);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(60, 17);
            this.label26.TabIndex = 72;
            this.label26.Text = "Bitiş Yılı:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(63, 169);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(51, 17);
            this.label19.TabIndex = 63;
            this.label19.Text = "Bölüm:";
            // 
            // txtCVOkulAd
            // 
            this.txtCVOkulAd.Location = new System.Drawing.Point(169, 143);
            this.txtCVOkulAd.Name = "txtCVOkulAd";
            this.txtCVOkulAd.Size = new System.Drawing.Size(169, 22);
            this.txtCVOkulAd.TabIndex = 68;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(42, 118);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(127, 17);
            this.label20.TabIndex = 64;
            this.label20.Text = "Çalışılan Süre (Yıl):";
            // 
            // txtCVIsyeriPozisyon
            // 
            this.txtCVIsyeriPozisyon.Location = new System.Drawing.Point(169, 87);
            this.txtCVIsyeriPozisyon.Name = "txtCVIsyeriPozisyon";
            this.txtCVIsyeriPozisyon.Size = new System.Drawing.Size(169, 22);
            this.txtCVIsyeriPozisyon.TabIndex = 67;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(63, 31);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(66, 17);
            this.label21.TabIndex = 65;
            this.label21.Text = "İşyeri Ad:";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(63, 255);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(106, 17);
            this.label25.TabIndex = 82;
            this.label25.Text = "Not Ortalaması:";
            // 
            // btnCVekle
            // 
            this.btnCVekle.BackColor = System.Drawing.Color.Snow;
            this.btnCVekle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCVekle.Location = new System.Drawing.Point(214, 292);
            this.btnCVekle.Name = "btnCVekle";
            this.btnCVekle.Size = new System.Drawing.Size(124, 50);
            this.btnCVekle.TabIndex = 69;
            this.btnCVekle.Text = "Ekle ve Güncelle";
            this.btnCVekle.UseVisualStyleBackColor = false;
            this.btnCVekle.Click += new System.EventHandler(this.btnCVekle_Click);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(63, 59);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(86, 17);
            this.label22.TabIndex = 83;
            this.label22.Text = "İşyeri Adres:";
            // 
            // tabIlanBasvuru
            // 
            this.tabIlanBasvuru.BackColor = System.Drawing.Color.DarkTurquoise;
            this.tabIlanBasvuru.Controls.Add(this.btnListele);
            this.tabIlanBasvuru.Controls.Add(this.txtIlanIsyeriAd);
            this.tabIlanBasvuru.Controls.Add(this.lblIsyeriAd);
            this.tabIlanBasvuru.Controls.Add(this.rdbtnIsyeriAd);
            this.tabIlanBasvuru.Controls.Add(this.rdbtnPozisyon);
            this.tabIlanBasvuru.Controls.Add(this.txtIlanKisiArama);
            this.tabIlanBasvuru.Controls.Add(this.label8);
            this.tabIlanBasvuru.Controls.Add(this.btnBasvur);
            this.tabIlanBasvuru.Controls.Add(this.lstIsIlan);
            this.tabIlanBasvuru.Location = new System.Drawing.Point(4, 25);
            this.tabIlanBasvuru.Name = "tabIlanBasvuru";
            this.tabIlanBasvuru.Padding = new System.Windows.Forms.Padding(3);
            this.tabIlanBasvuru.Size = new System.Drawing.Size(479, 475);
            this.tabIlanBasvuru.TabIndex = 2;
            this.tabIlanBasvuru.Text = "İlan Başvuru";
            // 
            // btnListele
            // 
            this.btnListele.BackColor = System.Drawing.Color.Snow;
            this.btnListele.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListele.Location = new System.Drawing.Point(21, 126);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(179, 34);
            this.btnListele.TabIndex = 99;
            this.btnListele.Text = "Listele";
            this.btnListele.UseVisualStyleBackColor = false;
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // txtIlanIsyeriAd
            // 
            this.txtIlanIsyeriAd.Location = new System.Drawing.Point(150, 87);
            this.txtIlanIsyeriAd.Name = "txtIlanIsyeriAd";
            this.txtIlanIsyeriAd.Size = new System.Drawing.Size(300, 22);
            this.txtIlanIsyeriAd.TabIndex = 98;
            this.txtIlanIsyeriAd.Visible = false;
            // 
            // lblIsyeriAd
            // 
            this.lblIsyeriAd.AutoSize = true;
            this.lblIsyeriAd.Location = new System.Drawing.Point(18, 92);
            this.lblIsyeriAd.Name = "lblIsyeriAd";
            this.lblIsyeriAd.Size = new System.Drawing.Size(69, 17);
            this.lblIsyeriAd.TabIndex = 97;
            this.lblIsyeriAd.Text = "İşyeri Adı:";
            this.lblIsyeriAd.Visible = false;
            // 
            // rdbtnIsyeriAd
            // 
            this.rdbtnIsyeriAd.AutoSize = true;
            this.rdbtnIsyeriAd.Location = new System.Drawing.Point(278, 51);
            this.rdbtnIsyeriAd.Name = "rdbtnIsyeriAd";
            this.rdbtnIsyeriAd.Size = new System.Drawing.Size(172, 21);
            this.rdbtnIsyeriAd.TabIndex = 96;
            this.rdbtnIsyeriAd.TabStop = true;
            this.rdbtnIsyeriAd.Text = "İşyeri Ada Göre Listele";
            this.rdbtnIsyeriAd.UseVisualStyleBackColor = true;
            this.rdbtnIsyeriAd.CheckedChanged += new System.EventHandler(this.rdbtnIsyeriAd_CheckedChanged);
            // 
            // rdbtnPozisyon
            // 
            this.rdbtnPozisyon.AutoSize = true;
            this.rdbtnPozisyon.Location = new System.Drawing.Point(21, 51);
            this.rdbtnPozisyon.Name = "rdbtnPozisyon";
            this.rdbtnPozisyon.Size = new System.Drawing.Size(175, 21);
            this.rdbtnPozisyon.TabIndex = 95;
            this.rdbtnPozisyon.TabStop = true;
            this.rdbtnPozisyon.Text = "Pozisyona Göre Listele";
            this.rdbtnPozisyon.UseVisualStyleBackColor = true;
            // 
            // txtIlanKisiArama
            // 
            this.txtIlanKisiArama.Location = new System.Drawing.Point(150, 13);
            this.txtIlanKisiArama.Name = "txtIlanKisiArama";
            this.txtIlanKisiArama.Size = new System.Drawing.Size(300, 22);
            this.txtIlanKisiArama.TabIndex = 94;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 13);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(120, 17);
            this.label8.TabIndex = 93;
            this.label8.Text = "Seçilecek Kişi TC:";
            // 
            // btnBasvur
            // 
            this.btnBasvur.BackColor = System.Drawing.Color.Snow;
            this.btnBasvur.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBasvur.Location = new System.Drawing.Point(287, 126);
            this.btnBasvur.Name = "btnBasvur";
            this.btnBasvur.Size = new System.Drawing.Size(163, 34);
            this.btnBasvur.TabIndex = 2;
            this.btnBasvur.Text = "Başvur";
            this.btnBasvur.UseVisualStyleBackColor = false;
            this.btnBasvur.Click += new System.EventHandler(this.btnBasvur_Click);
            // 
            // lstIsIlan
            // 
            this.lstIsIlan.HideSelection = false;
            this.lstIsIlan.Location = new System.Drawing.Point(6, 172);
            this.lstIsIlan.Name = "lstIsIlan";
            this.lstIsIlan.Size = new System.Drawing.Size(465, 287);
            this.lstIsIlan.TabIndex = 0;
            this.lstIsIlan.UseCompatibleStateImageBehavior = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.ForeColor = System.Drawing.Color.Maroon;
            this.label9.Location = new System.Drawing.Point(53, 358);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(323, 16);
            this.label9.TabIndex = 89;
            this.label9.Text = "Eski bilgileriniz silinmez, bağlı listede tutulur.";
            // 
            // ElemanEkran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkTurquoise;
            this.ClientSize = new System.Drawing.Size(484, 507);
            this.Controls.Add(this.tabControlEleman);
            this.Name = "ElemanEkran";
            this.Text = "Eleman -İnsan Kaynakları Bilgi Sistemi";
            this.tabControlEleman.ResumeLayout(false);
            this.tabKisiEkle.ResumeLayout(false);
            this.tabKisiEkle.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabCV.ResumeLayout(false);
            this.tabCV.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabIlanBasvuru.ResumeLayout(false);
            this.tabIlanBasvuru.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlEleman;
        private System.Windows.Forms.TabPage tabKisiEkle;
        private System.Windows.Forms.MaskedTextBox txtKisiTC;
        private System.Windows.Forms.TextBox txtKisiAdres;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnKisiSil;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnKisiGuncelle;
        private System.Windows.Forms.Button btnKisiEkle;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox txtKisiAd;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox txtKisiEposta;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.MaskedTextBox txtKisiTel;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtKisiYabanciDil;
        private System.Windows.Forms.TextBox txtKisiDy;
        private System.Windows.Forms.TextBox txtKisiSoyad;
        private System.Windows.Forms.TabPage tabCV;
        private System.Windows.Forms.MaskedTextBox txtCVOkulBaslangicYili;
        private System.Windows.Forms.MaskedTextBox txtCVOkulBitisYili;
        private System.Windows.Forms.TextBox txtCVOkulBolum;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Button btnCVekle;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox txtCVIsyeriAd;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox txtCVIsyeriPozisyon;
        private System.Windows.Forms.TextBox txtCVOkulAd;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.MaskedTextBox txtCVIsyeriCalismaYili;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.TextBox txtCVOkulNotOrtalama;
        private System.Windows.Forms.TextBox txtCVIsyeriAdres;
        private System.Windows.Forms.TabPage tabIlanBasvuru;
        private System.Windows.Forms.Button btnBasvur;
        private System.Windows.Forms.ListView lstIsIlan;
        private System.Windows.Forms.DateTimePicker txtKisiDg;
        private System.Windows.Forms.TextBox txtKisiArama;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtCVKisiArama;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnKisiAra;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.TextBox txtIlanIsyeriAd;
        private System.Windows.Forms.Label lblIsyeriAd;
        private System.Windows.Forms.RadioButton rdbtnIsyeriAd;
        private System.Windows.Forms.RadioButton rdbtnPozisyon;
        private System.Windows.Forms.TextBox txtIlanKisiArama;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnListele;
        private System.Windows.Forms.Button btnCVTemizle;
        private System.Windows.Forms.Label label9;
    }
}

