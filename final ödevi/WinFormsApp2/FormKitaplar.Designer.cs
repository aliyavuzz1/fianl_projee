namespace WinFormsApp2
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttontümkitaplar = new System.Windows.Forms.Button();
            this.buttonara = new System.Windows.Forms.Button();
            this.buttontemizle = new System.Windows.Forms.Button();
            this.buttonkitapbilgileri = new System.Windows.Forms.Button();
            this.buttonyenikitap = new System.Windows.Forms.Button();
            this.textBoxKitapTürKodu = new System.Windows.Forms.TextBox();
            this.textBoxISBN = new System.Windows.Forms.TextBox();
            this.textBoxyazarSoyad = new System.Windows.Forms.TextBox();
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
            this.buttonkitapödünçver = new System.Windows.Forms.Button();
            this.dateTimePickerödünçalmatarih = new System.Windows.Forms.DateTimePicker();
            this.textBoxödünçalan = new System.Windows.Forms.TextBox();
            this.labeltarih = new System.Windows.Forms.Label();
            this.labelödünçalan = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.buttonkitabıiadeet = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.buttongecikmebedeli = new System.Windows.Forms.Button();
            this.labelgecikmebedeli = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dataGridViewkitaplar = new System.Windows.Forms.DataGridView();
            this.buttonsil = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewkitaplar)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonsil);
            this.groupBox1.Controls.Add(this.buttontümkitaplar);
            this.groupBox1.Controls.Add(this.buttonara);
            this.groupBox1.Controls.Add(this.buttontemizle);
            this.groupBox1.Controls.Add(this.buttonkitapbilgileri);
            this.groupBox1.Controls.Add(this.buttonyenikitap);
            this.groupBox1.Controls.Add(this.textBoxKitapTürKodu);
            this.groupBox1.Controls.Add(this.textBoxISBN);
            this.groupBox1.Controls.Add(this.textBoxyazarSoyad);
            this.groupBox1.Controls.Add(this.textBoxYazarAdi);
            this.groupBox1.Controls.Add(this.textBoxKitapAdi);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.labelID);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(415, 295);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kitap Kayıt ve Güncelleme";
            // 
            // buttontümkitaplar
            // 
            this.buttontümkitaplar.Location = new System.Drawing.Point(263, 188);
            this.buttontümkitaplar.Name = "buttontümkitaplar";
            this.buttontümkitaplar.Size = new System.Drawing.Size(112, 67);
            this.buttontümkitaplar.TabIndex = 16;
            this.buttontümkitaplar.Text = "Tüm Kitapları Göster";
            this.buttontümkitaplar.UseVisualStyleBackColor = true;
            this.buttontümkitaplar.Click += new System.EventHandler(this.buttontümkitaplar_Click);
            // 
            // buttonara
            // 
            this.buttonara.Location = new System.Drawing.Point(278, 153);
            this.buttonara.Name = "buttonara";
            this.buttonara.Size = new System.Drawing.Size(75, 23);
            this.buttonara.TabIndex = 15;
            this.buttonara.Text = "Ara";
            this.buttonara.UseVisualStyleBackColor = true;
            this.buttonara.Click += new System.EventHandler(this.buttonara_Click);
            // 
            // buttontemizle
            // 
            this.buttontemizle.Location = new System.Drawing.Point(278, 111);
            this.buttontemizle.Name = "buttontemizle";
            this.buttontemizle.Size = new System.Drawing.Size(75, 23);
            this.buttontemizle.TabIndex = 14;
            this.buttontemizle.Text = "Temizle";
            this.buttontemizle.UseVisualStyleBackColor = true;
            this.buttontemizle.Click += new System.EventHandler(this.buttontemizle_Click);
            // 
            // buttonkitapbilgileri
            // 
            this.buttonkitapbilgileri.Location = new System.Drawing.Point(278, 13);
            this.buttonkitapbilgileri.Name = "buttonkitapbilgileri";
            this.buttonkitapbilgileri.Size = new System.Drawing.Size(84, 49);
            this.buttonkitapbilgileri.TabIndex = 13;
            this.buttonkitapbilgileri.Text = "Kitap Bilgileri Güncelle";
            this.buttonkitapbilgileri.UseVisualStyleBackColor = true;
            this.buttonkitapbilgileri.Click += new System.EventHandler(this.buttonkitapbilgileri_Click);
            // 
            // buttonyenikitap
            // 
            this.buttonyenikitap.Location = new System.Drawing.Point(278, 68);
            this.buttonyenikitap.Name = "buttonyenikitap";
            this.buttonyenikitap.Size = new System.Drawing.Size(97, 23);
            this.buttonyenikitap.TabIndex = 12;
            this.buttonyenikitap.Text = "Yeni Kitap Ekle";
            this.buttonyenikitap.UseVisualStyleBackColor = true;
            this.buttonyenikitap.Click += new System.EventHandler(this.buttonyenikitap_Click);
            // 
            // textBoxKitapTürKodu
            // 
            this.textBoxKitapTürKodu.Location = new System.Drawing.Point(131, 211);
            this.textBoxKitapTürKodu.Name = "textBoxKitapTürKodu";
            this.textBoxKitapTürKodu.Size = new System.Drawing.Size(100, 23);
            this.textBoxKitapTürKodu.TabIndex = 11;
            // 
            // textBoxISBN
            // 
            this.textBoxISBN.Location = new System.Drawing.Point(131, 170);
            this.textBoxISBN.Name = "textBoxISBN";
            this.textBoxISBN.Size = new System.Drawing.Size(100, 23);
            this.textBoxISBN.TabIndex = 10;
            // 
            // textBoxyazarSoyad
            // 
            this.textBoxyazarSoyad.Location = new System.Drawing.Point(131, 129);
            this.textBoxyazarSoyad.Name = "textBoxyazarSoyad";
            this.textBoxyazarSoyad.Size = new System.Drawing.Size(100, 23);
            this.textBoxyazarSoyad.TabIndex = 9;
            // 
            // textBoxYazarAdi
            // 
            this.textBoxYazarAdi.Location = new System.Drawing.Point(131, 95);
            this.textBoxYazarAdi.Name = "textBoxYazarAdi";
            this.textBoxYazarAdi.Size = new System.Drawing.Size(100, 23);
            this.textBoxYazarAdi.TabIndex = 8;
            // 
            // textBoxKitapAdi
            // 
            this.textBoxKitapAdi.Location = new System.Drawing.Point(131, 54);
            this.textBoxKitapAdi.Name = "textBoxKitapAdi";
            this.textBoxKitapAdi.Size = new System.Drawing.Size(100, 23);
            this.textBoxKitapAdi.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(6, 209);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(119, 21);
            this.label7.TabIndex = 6;
            this.label7.Text = "Kitap Tür Kodu :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(6, 168);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 21);
            this.label6.TabIndex = 5;
            this.label6.Text = "ISBN :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(6, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 21);
            this.label5.TabIndex = 4;
            this.label5.Text = "Yazar Soyadı :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(6, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "Yazar Adı :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(6, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Kitap Adı :";
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelID.Location = new System.Drawing.Point(131, 19);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(16, 21);
            this.labelID.TabIndex = 1;
            this.labelID.Text = "-";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(6, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kitap ID :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonkitapödünçver);
            this.groupBox2.Controls.Add(this.dateTimePickerödünçalmatarih);
            this.groupBox2.Controls.Add(this.textBoxödünçalan);
            this.groupBox2.Controls.Add(this.labeltarih);
            this.groupBox2.Controls.Add(this.labelödünçalan);
            this.groupBox2.Location = new System.Drawing.Point(433, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(228, 289);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kitap Ödünç Alma";
            // 
            // buttonkitapödünçver
            // 
            this.buttonkitapödünçver.Location = new System.Drawing.Point(70, 150);
            this.buttonkitapödünçver.Name = "buttonkitapödünçver";
            this.buttonkitapödünçver.Size = new System.Drawing.Size(84, 49);
            this.buttonkitapödünçver.TabIndex = 14;
            this.buttonkitapödünçver.Text = "Kitap Ödünç Ver";
            this.buttonkitapödünçver.UseVisualStyleBackColor = true;
            this.buttonkitapödünçver.Click += new System.EventHandler(this.buttonkitapödünçver_Click);
            // 
            // dateTimePickerödünçalmatarih
            // 
            this.dateTimePickerödünçalmatarih.Location = new System.Drawing.Point(103, 85);
            this.dateTimePickerödünçalmatarih.Name = "dateTimePickerödünçalmatarih";
            this.dateTimePickerödünçalmatarih.Size = new System.Drawing.Size(107, 23);
            this.dateTimePickerödünçalmatarih.TabIndex = 9;
            // 
            // textBoxödünçalan
            // 
            this.textBoxödünçalan.Location = new System.Drawing.Point(110, 33);
            this.textBoxödünçalan.Name = "textBoxödünçalan";
            this.textBoxödünçalan.Size = new System.Drawing.Size(100, 23);
            this.textBoxödünçalan.TabIndex = 8;
            // 
            // labeltarih
            // 
            this.labeltarih.AutoSize = true;
            this.labeltarih.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labeltarih.Location = new System.Drawing.Point(6, 87);
            this.labeltarih.Name = "labeltarih";
            this.labeltarih.Size = new System.Drawing.Size(50, 21);
            this.labeltarih.TabIndex = 4;
            this.labeltarih.Text = "Tarih :";
            // 
            // labelödünçalan
            // 
            this.labelödünçalan.AutoSize = true;
            this.labelödünçalan.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelödünçalan.Location = new System.Drawing.Point(6, 31);
            this.labelödünçalan.Name = "labelödünçalan";
            this.labelödünçalan.Size = new System.Drawing.Size(98, 21);
            this.labelödünçalan.TabIndex = 3;
            this.labelödünçalan.Text = "Ödünç Alan :";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.buttonkitabıiadeet);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.buttongecikmebedeli);
            this.groupBox3.Controls.Add(this.labelgecikmebedeli);
            this.groupBox3.Location = new System.Drawing.Point(687, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(257, 289);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Kitap İade";
            // 
            // buttonkitabıiadeet
            // 
            this.buttonkitabıiadeet.Location = new System.Drawing.Point(88, 203);
            this.buttonkitabıiadeet.Name = "buttonkitabıiadeet";
            this.buttonkitabıiadeet.Size = new System.Drawing.Size(84, 49);
            this.buttonkitabıiadeet.TabIndex = 16;
            this.buttonkitabıiadeet.Text = "Kitabı İade Et";
            this.buttonkitabıiadeet.UseVisualStyleBackColor = true;
            this.buttonkitabıiadeet.Click += new System.EventHandler(this.buttonkitabıiadeet_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(190, 35);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(26, 21);
            this.label9.TabIndex = 15;
            this.label9.Text = "TL";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(128, 35);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(19, 21);
            this.label8.TabIndex = 14;
            this.label8.Text = "0";
            // 
            // buttongecikmebedeli
            // 
            this.buttongecikmebedeli.Location = new System.Drawing.Point(75, 105);
            this.buttongecikmebedeli.Name = "buttongecikmebedeli";
            this.buttongecikmebedeli.Size = new System.Drawing.Size(97, 65);
            this.buttongecikmebedeli.TabIndex = 13;
            this.buttongecikmebedeli.Text = "Gecikme Bedeli Hesapla";
            this.buttongecikmebedeli.UseVisualStyleBackColor = true;
            this.buttongecikmebedeli.Click += new System.EventHandler(this.buttongecikmebedeli_Click);
            // 
            // labelgecikmebedeli
            // 
            this.labelgecikmebedeli.AutoSize = true;
            this.labelgecikmebedeli.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelgecikmebedeli.Location = new System.Drawing.Point(6, 33);
            this.labelgecikmebedeli.Name = "labelgecikmebedeli";
            this.labelgecikmebedeli.Size = new System.Drawing.Size(123, 21);
            this.labelgecikmebedeli.TabIndex = 4;
            this.labelgecikmebedeli.Text = "Gecikme Bedeli :";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dataGridViewkitaplar);
            this.groupBox4.Location = new System.Drawing.Point(18, 307);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(931, 175);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Kitap Listesi";
            // 
            // dataGridViewkitaplar
            // 
            this.dataGridViewkitaplar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewkitaplar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewkitaplar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewkitaplar.Location = new System.Drawing.Point(3, 19);
            this.dataGridViewkitaplar.Name = "dataGridViewkitaplar";
            this.dataGridViewkitaplar.RowTemplate.Height = 25;
            this.dataGridViewkitaplar.Size = new System.Drawing.Size(925, 153);
            this.dataGridViewkitaplar.TabIndex = 0;
            this.dataGridViewkitaplar.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewkitaplar_CellClick);
            // 
            // buttonsil
            // 
            this.buttonsil.Location = new System.Drawing.Point(278, 266);
            this.buttonsil.Name = "buttonsil";
            this.buttonsil.Size = new System.Drawing.Size(75, 23);
            this.buttonsil.TabIndex = 17;
            this.buttonsil.Text = "Kitap Sil";
            this.buttonsil.UseVisualStyleBackColor = true;
            this.buttonsil.Click += new System.EventHandler(this.buttonsil_Click);
            // 
            // FormKitaplar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSalmon;
            this.ClientSize = new System.Drawing.Size(956, 517);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormKitaplar";
            this.Text = "Kütüphane Yönetim Sistemi";
            this.Load += new System.EventHandler(this.FormKitaplar_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewkitaplar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private Button buttonkitapbilgileri;
        private Button buttonyenikitap;
        private TextBox textBoxKitapTürKodu;
        private TextBox textBoxISBN;
        private TextBox textBoxyazarSoyad;
        private TextBox textBoxYazarAdi;
        private TextBox textBoxKitapAdi;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label labelID;
        private Label label1;
        private GroupBox groupBox2;
        private TextBox textBoxödünçalan;
        private Label labeltarih;
        private Label labelödünçalan;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
        private DataGridView dataGridViewkitaplar;
        private DateTimePicker dateTimePickerödünçalmatarih;
        private Button buttongecikmebedeli;
        private Label labelgecikmebedeli;
        private Button buttonkitabıiadeet;
        private Label label9;
        private Label label8;
        private Button buttonkitapödünçver;
        private Button buttonara;
        private Button buttontemizle;
        private Button buttontümkitaplar;
        private Button buttonsil;
    }
}