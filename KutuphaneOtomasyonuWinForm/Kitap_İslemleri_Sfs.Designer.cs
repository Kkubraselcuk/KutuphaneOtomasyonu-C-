
namespace KutuphaneOtomasyonuWinForm
{
    partial class Kitap_İslemleri_Sfs
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
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.anasayfa = new System.Windows.Forms.Button();
            this.kitap_listesi_d = new System.Windows.Forms.DataGridView();
            this.tum_b = new System.Windows.Forms.Button();
            this.sil_b = new System.Windows.Forms.Button();
            this.guncelle_b = new System.Windows.Forms.Button();
            this.ekle_b = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rafno_t = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.id_t = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tur_t = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.yayinevi_t = new System.Windows.Forms.TextBox();
            this.yazar_t = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ad_t = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ktp_ara_t = new System.Windows.Forms.TextBox();
            this.kategori_cmb = new System.Windows.Forms.ComboBox();
            this.ktp_ara_b = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.kitap_listesi_d)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.Firebrick;
            this.label7.Location = new System.Drawing.Point(62, 336);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(581, 17);
            this.label7.TabIndex = 38;
            this.label7.Text = "Silmek istediğiniz kitabın ID\'sini giriniz ve Sil butonuna basınız.";
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.Color.Firebrick;
            this.label8.Location = new System.Drawing.Point(62, 320);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(581, 16);
            this.label8.TabIndex = 37;
            this.label8.Text = "Güncellenecek Kitabın ID\'sini yazınız ve yeni bilgilerini giriniz ve Güncelle but" +
    "onuna basınız.";
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.ForeColor = System.Drawing.Color.Firebrick;
            this.label9.Location = new System.Drawing.Point(62, 304);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(581, 16);
            this.label9.TabIndex = 36;
            this.label9.Text = "Kitap eklemek için sadece Kitap Adı, Yazar, Yayınevi, Tür ve Rafno giriniz ve ekl" +
    "e butonuna basınız.";
            // 
            // anasayfa
            // 
            this.anasayfa.BackColor = System.Drawing.Color.DarkRed;
            this.anasayfa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.anasayfa.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.anasayfa.Location = new System.Drawing.Point(4, 11);
            this.anasayfa.Name = "anasayfa";
            this.anasayfa.Size = new System.Drawing.Size(108, 31);
            this.anasayfa.TabIndex = 35;
            this.anasayfa.Text = "ANASAYFA";
            this.anasayfa.UseVisualStyleBackColor = false;
            this.anasayfa.Click += new System.EventHandler(this.anasayfa_Click);
            // 
            // kitap_listesi_d
            // 
            this.kitap_listesi_d.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.kitap_listesi_d.Location = new System.Drawing.Point(4, 416);
            this.kitap_listesi_d.Margin = new System.Windows.Forms.Padding(2);
            this.kitap_listesi_d.Name = "kitap_listesi_d";
            this.kitap_listesi_d.RowTemplate.Height = 24;
            this.kitap_listesi_d.Size = new System.Drawing.Size(688, 276);
            this.kitap_listesi_d.TabIndex = 34;
            this.kitap_listesi_d.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.kitap_listesi_d_CellContentClick);
            // 
            // tum_b
            // 
            this.tum_b.BackColor = System.Drawing.Color.ForestGreen;
            this.tum_b.ForeColor = System.Drawing.SystemColors.Control;
            this.tum_b.Location = new System.Drawing.Point(230, 368);
            this.tum_b.Margin = new System.Windows.Forms.Padding(2);
            this.tum_b.Name = "tum_b";
            this.tum_b.Size = new System.Drawing.Size(213, 44);
            this.tum_b.TabIndex = 33;
            this.tum_b.Text = "TÜM KAYITLARI GÖSTER";
            this.tum_b.UseVisualStyleBackColor = false;
            this.tum_b.Click += new System.EventHandler(this.tum_b_Click);
            // 
            // sil_b
            // 
            this.sil_b.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sil_b.Location = new System.Drawing.Point(479, 258);
            this.sil_b.Margin = new System.Windows.Forms.Padding(2);
            this.sil_b.Name = "sil_b";
            this.sil_b.Size = new System.Drawing.Size(141, 31);
            this.sil_b.TabIndex = 32;
            this.sil_b.Text = "SİL";
            this.sil_b.UseVisualStyleBackColor = true;
            this.sil_b.Click += new System.EventHandler(this.sil_b_Click);
            // 
            // guncelle_b
            // 
            this.guncelle_b.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.guncelle_b.Location = new System.Drawing.Point(334, 258);
            this.guncelle_b.Margin = new System.Windows.Forms.Padding(2);
            this.guncelle_b.Name = "guncelle_b";
            this.guncelle_b.Size = new System.Drawing.Size(141, 31);
            this.guncelle_b.TabIndex = 31;
            this.guncelle_b.Text = "GÜNCELLE";
            this.guncelle_b.UseVisualStyleBackColor = true;
            this.guncelle_b.Click += new System.EventHandler(this.guncelle_b_Click);
            // 
            // ekle_b
            // 
            this.ekle_b.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ekle_b.Location = new System.Drawing.Point(196, 258);
            this.ekle_b.Margin = new System.Windows.Forms.Padding(2);
            this.ekle_b.Name = "ekle_b";
            this.ekle_b.Size = new System.Drawing.Size(134, 31);
            this.ekle_b.TabIndex = 30;
            this.ekle_b.Text = "EKLE";
            this.ekle_b.UseVisualStyleBackColor = true;
            this.ekle_b.Click += new System.EventHandler(this.ekle_b_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.rafno_t);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.id_t);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.tur_t);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.yayinevi_t);
            this.groupBox2.Controls.Add(this.yazar_t);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.ad_t);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.ForeColor = System.Drawing.Color.DarkRed;
            this.groupBox2.Location = new System.Drawing.Point(196, 52);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(447, 202);
            this.groupBox2.TabIndex = 29;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Öğrenci Bilgileri";
            // 
            // rafno_t
            // 
            this.rafno_t.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rafno_t.Location = new System.Drawing.Point(74, 181);
            this.rafno_t.Name = "rafno_t";
            this.rafno_t.Size = new System.Drawing.Size(350, 20);
            this.rafno_t.TabIndex = 11;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.ForeColor = System.Drawing.SystemColors.Control;
            this.label10.Location = new System.Drawing.Point(16, 184);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 13);
            this.label10.TabIndex = 10;
            this.label10.Text = "Raf No:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(16, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Kitap ID:";
            // 
            // id_t
            // 
            this.id_t.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.id_t.Location = new System.Drawing.Point(74, 29);
            this.id_t.Name = "id_t";
            this.id_t.Size = new System.Drawing.Size(350, 20);
            this.id_t.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(16, 156);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Tür:";
            // 
            // tur_t
            // 
            this.tur_t.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tur_t.Location = new System.Drawing.Point(74, 153);
            this.tur_t.Margin = new System.Windows.Forms.Padding(2);
            this.tur_t.Name = "tur_t";
            this.tur_t.Size = new System.Drawing.Size(350, 20);
            this.tur_t.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(16, 126);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Yayınevi:";
            // 
            // yayinevi_t
            // 
            this.yayinevi_t.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.yayinevi_t.Location = new System.Drawing.Point(74, 123);
            this.yayinevi_t.Margin = new System.Windows.Forms.Padding(2);
            this.yayinevi_t.Name = "yayinevi_t";
            this.yayinevi_t.Size = new System.Drawing.Size(350, 20);
            this.yayinevi_t.TabIndex = 4;
            // 
            // yazar_t
            // 
            this.yazar_t.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.yazar_t.Location = new System.Drawing.Point(74, 92);
            this.yazar_t.Margin = new System.Windows.Forms.Padding(2);
            this.yazar_t.Name = "yazar_t";
            this.yazar_t.Size = new System.Drawing.Size(350, 20);
            this.yazar_t.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(14, 94);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Yazar:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(14, 65);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kitap Adı:";
            // 
            // ad_t
            // 
            this.ad_t.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ad_t.Location = new System.Drawing.Point(74, 61);
            this.ad_t.Margin = new System.Windows.Forms.Padding(2);
            this.ad_t.Name = "ad_t";
            this.ad_t.Size = new System.Drawing.Size(350, 20);
            this.ad_t.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.ktp_ara_t);
            this.groupBox1.Controls.Add(this.kategori_cmb);
            this.groupBox1.Controls.Add(this.ktp_ara_b);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.ForeColor = System.Drawing.Color.DarkRed;
            this.groupBox1.Location = new System.Drawing.Point(17, 52);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(175, 188);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kitap Ara";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.ForeColor = System.Drawing.SystemColors.Control;
            this.label11.Location = new System.Drawing.Point(10, 83);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(73, 13);
            this.label11.TabIndex = 5;
            this.label11.Text = "Kitap Bilgisi";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(10, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(158, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Önce Arama Kriteri Seçiniz";
            // 
            // ktp_ara_t
            // 
            this.ktp_ara_t.Location = new System.Drawing.Point(9, 99);
            this.ktp_ara_t.Name = "ktp_ara_t";
            this.ktp_ara_t.Size = new System.Drawing.Size(143, 21);
            this.ktp_ara_t.TabIndex = 3;
            // 
            // kategori_cmb
            // 
            this.kategori_cmb.FormattingEnabled = true;
            this.kategori_cmb.Items.AddRange(new object[] {
            "kitapadi",
            "yazar",
            "tur"});
            this.kategori_cmb.Location = new System.Drawing.Point(9, 54);
            this.kategori_cmb.Margin = new System.Windows.Forms.Padding(2);
            this.kategori_cmb.Name = "kategori_cmb";
            this.kategori_cmb.Size = new System.Drawing.Size(144, 23);
            this.kategori_cmb.TabIndex = 2;
            this.kategori_cmb.SelectedIndexChanged += new System.EventHandler(this.kategori_cmb_SelectedIndexChanged);
            // 
            // ktp_ara_b
            // 
            this.ktp_ara_b.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ktp_ara_b.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ktp_ara_b.Location = new System.Drawing.Point(10, 124);
            this.ktp_ara_b.Margin = new System.Windows.Forms.Padding(2);
            this.ktp_ara_b.Name = "ktp_ara_b";
            this.ktp_ara_b.Size = new System.Drawing.Size(143, 31);
            this.ktp_ara_b.TabIndex = 1;
            this.ktp_ara_b.Text = "Kitap Ara";
            this.ktp_ara_b.UseVisualStyleBackColor = true;
            this.ktp_ara_b.Click += new System.EventHandler(this.ktp_ara_b_Click);
            // 
            // Kitap_İslemleri_Sfs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::KutuphaneOtomasyonuWinForm.Properties.Resources.kitapSfs;
            this.ClientSize = new System.Drawing.Size(696, 703);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.anasayfa);
            this.Controls.Add(this.kitap_listesi_d);
            this.Controls.Add(this.tum_b);
            this.Controls.Add(this.sil_b);
            this.Controls.Add(this.guncelle_b);
            this.Controls.Add(this.ekle_b);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Kitap_İslemleri_Sfs";
            this.Text = "Kitap İşlemleri Sayfası";
            ((System.ComponentModel.ISupportInitialize)(this.kitap_listesi_d)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button anasayfa;
        private System.Windows.Forms.DataGridView kitap_listesi_d;
        private System.Windows.Forms.Button tum_b;
        private System.Windows.Forms.Button sil_b;
        private System.Windows.Forms.Button guncelle_b;
        private System.Windows.Forms.Button ekle_b;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox id_t;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tur_t;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox yayinevi_t;
        private System.Windows.Forms.TextBox yazar_t;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ad_t;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox ktp_ara_t;
        private System.Windows.Forms.ComboBox kategori_cmb;
        private System.Windows.Forms.Button ktp_ara_b;
        private System.Windows.Forms.TextBox rafno_t;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
    }
}