namespace KutuphaneYonetimSistemi
{
    partial class FormKitaplar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormKitaplar));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.buttonKitapEkle = new System.Windows.Forms.Button();
            this.buttonKitapBilgiGuncelle = new System.Windows.Forms.Button();
            this.buttonSil = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.buttonAra = new System.Windows.Forms.Button();
            this.buttonTemizle = new System.Windows.Forms.Button();
            this.buttonTumKitaplariGoster = new System.Windows.Forms.Button();
            this.textBoxKitapTurKodu = new System.Windows.Forms.TextBox();
            this.textBoxISBN = new System.Windows.Forms.TextBox();
            this.textBoxYazarSoyad = new System.Windows.Forms.TextBox();
            this.textBoxYazarAdi = new System.Windows.Forms.TextBox();
            this.textBoxKitapAdi = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonKitapOduncVer = new System.Windows.Forms.Button();
            this.dateTimePickerOduncAlmaTarihi = new System.Windows.Forms.DateTimePicker();
            this.textBoxOduncAlan = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.buttonKitabiIadeEt = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.labelGecikmeBedeli = new System.Windows.Forms.Label();
            this.buttonGecikmeBedeliHesapla = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dataGridViewKitaplar = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKitaplar)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.groupBox6);
            this.groupBox1.Controls.Add(this.groupBox5);
            this.groupBox1.Controls.Add(this.textBoxKitapTurKodu);
            this.groupBox1.Controls.Add(this.textBoxISBN);
            this.groupBox1.Controls.Add(this.textBoxYazarSoyad);
            this.groupBox1.Controls.Add(this.textBoxYazarAdi);
            this.groupBox1.Controls.Add(this.textBoxKitapAdi);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.labelID);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(727, 386);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kitap Kayıt Güncelleme";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.buttonKitapEkle);
            this.groupBox6.Controls.Add(this.buttonKitapBilgiGuncelle);
            this.groupBox6.Controls.Add(this.buttonSil);
            this.groupBox6.Location = new System.Drawing.Point(7, 300);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(354, 80);
            this.groupBox6.TabIndex = 19;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Kayıt Düzenleme İşlemleri";
            // 
            // buttonKitapEkle
            // 
            this.buttonKitapEkle.Location = new System.Drawing.Point(129, 22);
            this.buttonKitapEkle.Name = "buttonKitapEkle";
            this.buttonKitapEkle.Size = new System.Drawing.Size(97, 41);
            this.buttonKitapEkle.TabIndex = 12;
            this.buttonKitapEkle.Text = "Yeni Kitap Ekle";
            this.buttonKitapEkle.UseVisualStyleBackColor = true;
            this.buttonKitapEkle.Click += new System.EventHandler(this.buttonKitapEkle_Click);
            // 
            // buttonKitapBilgiGuncelle
            // 
            this.buttonKitapBilgiGuncelle.Location = new System.Drawing.Point(13, 22);
            this.buttonKitapBilgiGuncelle.Name = "buttonKitapBilgiGuncelle";
            this.buttonKitapBilgiGuncelle.Size = new System.Drawing.Size(97, 41);
            this.buttonKitapBilgiGuncelle.TabIndex = 13;
            this.buttonKitapBilgiGuncelle.Text = "Kitap Bilgileri Güncelle";
            this.buttonKitapBilgiGuncelle.UseVisualStyleBackColor = true;
            this.buttonKitapBilgiGuncelle.Click += new System.EventHandler(this.buttonKitapBilgiGuncelle_Click);
            // 
            // buttonSil
            // 
            this.buttonSil.Location = new System.Drawing.Point(245, 22);
            this.buttonSil.Name = "buttonSil";
            this.buttonSil.Size = new System.Drawing.Size(97, 41);
            this.buttonSil.TabIndex = 17;
            this.buttonSil.Text = "Kitap Sil";
            this.buttonSil.UseVisualStyleBackColor = true;
            this.buttonSil.Click += new System.EventHandler(this.buttonSil_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.buttonAra);
            this.groupBox5.Controls.Add(this.buttonTemizle);
            this.groupBox5.Controls.Add(this.buttonTumKitaplariGoster);
            this.groupBox5.Location = new System.Drawing.Point(378, 300);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(343, 80);
            this.groupBox5.TabIndex = 18;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Arama";
            // 
            // buttonAra
            // 
            this.buttonAra.Location = new System.Drawing.Point(119, 22);
            this.buttonAra.Name = "buttonAra";
            this.buttonAra.Size = new System.Drawing.Size(97, 41);
            this.buttonAra.TabIndex = 15;
            this.buttonAra.Text = "Ara";
            this.buttonAra.UseVisualStyleBackColor = true;
            this.buttonAra.Click += new System.EventHandler(this.buttonAra_Click);
            // 
            // buttonTemizle
            // 
            this.buttonTemizle.Location = new System.Drawing.Point(6, 22);
            this.buttonTemizle.Name = "buttonTemizle";
            this.buttonTemizle.Size = new System.Drawing.Size(97, 41);
            this.buttonTemizle.TabIndex = 14;
            this.buttonTemizle.Text = "Temizle";
            this.buttonTemizle.UseVisualStyleBackColor = true;
            this.buttonTemizle.Click += new System.EventHandler(this.buttonTemizle_Click);
            // 
            // buttonTumKitaplariGoster
            // 
            this.buttonTumKitaplariGoster.Location = new System.Drawing.Point(233, 24);
            this.buttonTumKitaplariGoster.Name = "buttonTumKitaplariGoster";
            this.buttonTumKitaplariGoster.Size = new System.Drawing.Size(97, 41);
            this.buttonTumKitaplariGoster.TabIndex = 16;
            this.buttonTumKitaplariGoster.Text = "Tüm Kitapları Göster";
            this.buttonTumKitaplariGoster.UseVisualStyleBackColor = true;
            this.buttonTumKitaplariGoster.Click += new System.EventHandler(this.buttonTumKitaplariGoster_Click);
            // 
            // textBoxKitapTurKodu
            // 
            this.textBoxKitapTurKodu.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxKitapTurKodu.Location = new System.Drawing.Point(190, 246);
            this.textBoxKitapTurKodu.Name = "textBoxKitapTurKodu";
            this.textBoxKitapTurKodu.Size = new System.Drawing.Size(111, 30);
            this.textBoxKitapTurKodu.TabIndex = 11;
            // 
            // textBoxISBN
            // 
            this.textBoxISBN.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxISBN.Location = new System.Drawing.Point(190, 202);
            this.textBoxISBN.Name = "textBoxISBN";
            this.textBoxISBN.Size = new System.Drawing.Size(111, 30);
            this.textBoxISBN.TabIndex = 10;
            // 
            // textBoxYazarSoyad
            // 
            this.textBoxYazarSoyad.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxYazarSoyad.Location = new System.Drawing.Point(190, 160);
            this.textBoxYazarSoyad.Name = "textBoxYazarSoyad";
            this.textBoxYazarSoyad.Size = new System.Drawing.Size(293, 30);
            this.textBoxYazarSoyad.TabIndex = 9;
            // 
            // textBoxYazarAdi
            // 
            this.textBoxYazarAdi.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxYazarAdi.Location = new System.Drawing.Point(190, 116);
            this.textBoxYazarAdi.Name = "textBoxYazarAdi";
            this.textBoxYazarAdi.Size = new System.Drawing.Size(293, 30);
            this.textBoxYazarAdi.TabIndex = 8;
            // 
            // textBoxKitapAdi
            // 
            this.textBoxKitapAdi.Font = new System.Drawing.Font("Century", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxKitapAdi.Location = new System.Drawing.Point(190, 73);
            this.textBoxKitapAdi.Name = "textBoxKitapAdi";
            this.textBoxKitapAdi.Size = new System.Drawing.Size(293, 30);
            this.textBoxKitapAdi.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(19, 80);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 23);
            this.label7.TabIndex = 6;
            this.label7.Text = "Kitap Adı:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(17, 123);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 23);
            this.label6.TabIndex = 5;
            this.label6.Text = "Yazar Adı:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(17, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 23);
            this.label5.TabIndex = 4;
            this.label5.Text = "Yazar Soyadı:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(17, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "ISBN:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(17, 253);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Kitap Tür Kodu:";
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Location = new System.Drawing.Point(190, 33);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(10, 15);
            this.labelID.TabIndex = 1;
            this.labelID.Text = ".";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(17, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kitap ID:";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.buttonKitapOduncVer);
            this.groupBox2.Controls.Add(this.dateTimePickerOduncAlmaTarihi);
            this.groupBox2.Controls.Add(this.textBoxOduncAlan);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Location = new System.Drawing.Point(745, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(279, 386);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kitap Ödünç Alma";
            // 
            // buttonKitapOduncVer
            // 
            this.buttonKitapOduncVer.Location = new System.Drawing.Point(80, 149);
            this.buttonKitapOduncVer.Name = "buttonKitapOduncVer";
            this.buttonKitapOduncVer.Size = new System.Drawing.Size(111, 41);
            this.buttonKitapOduncVer.TabIndex = 17;
            this.buttonKitapOduncVer.Text = "Kitabı Ödünç Ver";
            this.buttonKitapOduncVer.UseVisualStyleBackColor = true;
            this.buttonKitapOduncVer.Click += new System.EventHandler(this.buttonKitapOduncVer_Click);
            // 
            // dateTimePickerOduncAlmaTarihi
            // 
            this.dateTimePickerOduncAlmaTarihi.Location = new System.Drawing.Point(156, 76);
            this.dateTimePickerOduncAlmaTarihi.Name = "dateTimePickerOduncAlmaTarihi";
            this.dateTimePickerOduncAlmaTarihi.Size = new System.Drawing.Size(107, 23);
            this.dateTimePickerOduncAlmaTarihi.TabIndex = 10;
            // 
            // textBoxOduncAlan
            // 
            this.textBoxOduncAlan.Font = new System.Drawing.Font("Century", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxOduncAlan.Location = new System.Drawing.Point(150, 31);
            this.textBoxOduncAlan.Name = "textBoxOduncAlan";
            this.textBoxOduncAlan.Size = new System.Drawing.Size(111, 30);
            this.textBoxOduncAlan.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(6, 76);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 23);
            this.label9.TabIndex = 8;
            this.label9.Text = "Tarih:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(6, 33);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(121, 23);
            this.label8.TabIndex = 7;
            this.label8.Text = "Ödünç Alan:";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.buttonKitabiIadeEt);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.labelGecikmeBedeli);
            this.groupBox3.Controls.Add(this.buttonGecikmeBedeliHesapla);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Location = new System.Drawing.Point(1044, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(299, 386);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Kitap İade";
            // 
            // buttonKitabiIadeEt
            // 
            this.buttonKitabiIadeEt.Location = new System.Drawing.Point(98, 191);
            this.buttonKitabiIadeEt.Name = "buttonKitabiIadeEt";
            this.buttonKitabiIadeEt.Size = new System.Drawing.Size(111, 41);
            this.buttonKitabiIadeEt.TabIndex = 16;
            this.buttonKitabiIadeEt.Text = "Kitabı İade Et";
            this.buttonKitabiIadeEt.UseVisualStyleBackColor = true;
            this.buttonKitabiIadeEt.Click += new System.EventHandler(this.buttonKitabiIadeEt_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(206, 33);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(36, 23);
            this.label11.TabIndex = 15;
            this.label11.Text = "TL";
            // 
            // labelGecikmeBedeli
            // 
            this.labelGecikmeBedeli.AutoSize = true;
            this.labelGecikmeBedeli.Font = new System.Drawing.Font("Century", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelGecikmeBedeli.Location = new System.Drawing.Point(166, 33);
            this.labelGecikmeBedeli.Name = "labelGecikmeBedeli";
            this.labelGecikmeBedeli.Size = new System.Drawing.Size(21, 23);
            this.labelGecikmeBedeli.TabIndex = 14;
            this.labelGecikmeBedeli.Text = "0";
            // 
            // buttonGecikmeBedeliHesapla
            // 
            this.buttonGecikmeBedeliHesapla.Location = new System.Drawing.Point(98, 117);
            this.buttonGecikmeBedeliHesapla.Name = "buttonGecikmeBedeliHesapla";
            this.buttonGecikmeBedeliHesapla.Size = new System.Drawing.Size(111, 41);
            this.buttonGecikmeBedeliHesapla.TabIndex = 13;
            this.buttonGecikmeBedeliHesapla.Text = "Gecikme Bedeli Hesapla";
            this.buttonGecikmeBedeliHesapla.UseVisualStyleBackColor = true;
            this.buttonGecikmeBedeliHesapla.Click += new System.EventHandler(this.buttonGecikmeBedeliHesapla_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(6, 33);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(154, 23);
            this.label10.TabIndex = 8;
            this.label10.Text = "Gecikme Bedeli:";
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Transparent;
            this.groupBox4.Controls.Add(this.dataGridViewKitaplar);
            this.groupBox4.Location = new System.Drawing.Point(12, 414);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(1334, 236);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Kitap Listesi";
            // 
            // dataGridViewKitaplar
            // 
            this.dataGridViewKitaplar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewKitaplar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewKitaplar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewKitaplar.Location = new System.Drawing.Point(3, 19);
            this.dataGridViewKitaplar.Name = "dataGridViewKitaplar";
            this.dataGridViewKitaplar.RowTemplate.Height = 25;
            this.dataGridViewKitaplar.Size = new System.Drawing.Size(1328, 214);
            this.dataGridViewKitaplar.TabIndex = 0;
            this.dataGridViewKitaplar.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewKitaplar_CellClick);
            // 
            // FormKitaplar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1358, 662);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormKitaplar";
            this.Text = "Kütüphane Yönetim Sistemi";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormKitaplar_FormClosed);
            this.Load += new System.EventHandler(this.FormKitaplar_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKitaplar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private TextBox textBoxKitapAdi;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label labelID;
        private Label label1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private TextBox textBoxKitapTurKodu;
        private TextBox textBoxISBN;
        private TextBox textBoxYazarSoyad;
        private TextBox textBoxYazarAdi;
        private Button buttonKitapBilgiGuncelle;
        private Button buttonKitapEkle;
        private DateTimePicker dateTimePickerOduncAlmaTarihi;
        private TextBox textBoxOduncAlan;
        private Label label9;
        private Label label8;
        private GroupBox groupBox4;
        private DataGridView dataGridViewKitaplar;
        private Button buttonKitapOduncVer;
        private Button buttonKitabiIadeEt;
        private Label label11;
        private Label labelGecikmeBedeli;
        private Button buttonGecikmeBedeliHesapla;
        private Label label10;
        private Button buttonAra;
        private Button buttonTemizle;
        private Button buttonTumKitaplariGoster;
        private Button buttonSil;
        private GroupBox groupBox5;
        private GroupBox groupBox6;
    }
}