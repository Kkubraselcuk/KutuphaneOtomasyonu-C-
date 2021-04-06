
namespace KutuphaneOtomasyonuWinForm
{
    partial class Ogrenci_İslemleri_Sfs
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
            this.label10 = new System.Windows.Forms.Label();
            this.btn_ogrAra = new System.Windows.Forms.Button();
            this.txtBx_ogrAra = new System.Windows.Forms.TextBox();
            this.btn_anasayfa = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtBx_email = new System.Windows.Forms.TextBox();
            this.txtBx_adres = new System.Windows.Forms.TextBox();
            this.txtBx_telefon = new System.Windows.Forms.TextBox();
            this.txtBx_adSoyad = new System.Windows.Forms.TextBox();
            this.txtBx_tc = new System.Windows.Forms.TextBox();
            this.txtBx_id = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_ekle = new System.Windows.Forms.Button();
            this.btn_guncelle = new System.Windows.Forms.Button();
            this.btn_sil = new System.Windows.Forms.Button();
            this.btn_listele = new System.Windows.Forms.Button();
            this.dtgrd_ogrenciListesi = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrd_ogrenciListesi)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.btn_ogrAra);
            this.groupBox1.Controls.Add(this.txtBx_ogrAra);
            this.groupBox1.Location = new System.Drawing.Point(13, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(218, 129);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Öğrenci Ara";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(64, 21);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 13);
            this.label10.TabIndex = 2;
            this.label10.Text = "TC Giriniz:";
            // 
            // btn_ogrAra
            // 
            this.btn_ogrAra.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_ogrAra.Location = new System.Drawing.Point(21, 63);
            this.btn_ogrAra.Name = "btn_ogrAra";
            this.btn_ogrAra.Size = new System.Drawing.Size(173, 38);
            this.btn_ogrAra.TabIndex = 1;
            this.btn_ogrAra.Text = "Öğrenci Ara";
            this.btn_ogrAra.UseVisualStyleBackColor = false;
            this.btn_ogrAra.Click += new System.EventHandler(this.btn_ogrAra_Click);
            // 
            // txtBx_ogrAra
            // 
            this.txtBx_ogrAra.Location = new System.Drawing.Point(21, 37);
            this.txtBx_ogrAra.Name = "txtBx_ogrAra";
            this.txtBx_ogrAra.Size = new System.Drawing.Size(173, 20);
            this.txtBx_ogrAra.TabIndex = 0;
            this.txtBx_ogrAra.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBx_ogrAra.Click += new System.EventHandler(this.txtBx_ogrAra_Click);
            // 
            // btn_anasayfa
            // 
            this.btn_anasayfa.BackColor = System.Drawing.Color.DarkRed;
            this.btn_anasayfa.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_anasayfa.Location = new System.Drawing.Point(13, 13);
            this.btn_anasayfa.Name = "btn_anasayfa";
            this.btn_anasayfa.Size = new System.Drawing.Size(84, 31);
            this.btn_anasayfa.TabIndex = 1;
            this.btn_anasayfa.Text = "ANASAYFA";
            this.btn_anasayfa.UseVisualStyleBackColor = false;
            this.btn_anasayfa.Click += new System.EventHandler(this.btn_anasayfa_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.txtBx_email);
            this.groupBox2.Controls.Add(this.txtBx_adres);
            this.groupBox2.Controls.Add(this.txtBx_telefon);
            this.groupBox2.Controls.Add(this.txtBx_adSoyad);
            this.groupBox2.Controls.Add(this.txtBx_tc);
            this.groupBox2.Controls.Add(this.txtBx_id);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(237, 24);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(443, 190);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Öğrenci Bilgileri";
            // 
            // txtBx_email
            // 
            this.txtBx_email.Location = new System.Drawing.Point(102, 157);
            this.txtBx_email.Name = "txtBx_email";
            this.txtBx_email.Size = new System.Drawing.Size(311, 20);
            this.txtBx_email.TabIndex = 3;
            // 
            // txtBx_adres
            // 
            this.txtBx_adres.Location = new System.Drawing.Point(102, 131);
            this.txtBx_adres.Name = "txtBx_adres";
            this.txtBx_adres.Size = new System.Drawing.Size(311, 20);
            this.txtBx_adres.TabIndex = 10;
            // 
            // txtBx_telefon
            // 
            this.txtBx_telefon.Location = new System.Drawing.Point(102, 105);
            this.txtBx_telefon.Name = "txtBx_telefon";
            this.txtBx_telefon.Size = new System.Drawing.Size(311, 20);
            this.txtBx_telefon.TabIndex = 9;
            // 
            // txtBx_adSoyad
            // 
            this.txtBx_adSoyad.Location = new System.Drawing.Point(102, 79);
            this.txtBx_adSoyad.Name = "txtBx_adSoyad";
            this.txtBx_adSoyad.Size = new System.Drawing.Size(311, 20);
            this.txtBx_adSoyad.TabIndex = 8;
            // 
            // txtBx_tc
            // 
            this.txtBx_tc.Location = new System.Drawing.Point(102, 53);
            this.txtBx_tc.Name = "txtBx_tc";
            this.txtBx_tc.Size = new System.Drawing.Size(311, 20);
            this.txtBx_tc.TabIndex = 7;
            // 
            // txtBx_id
            // 
            this.txtBx_id.Location = new System.Drawing.Point(102, 27);
            this.txtBx_id.Name = "txtBx_id";
            this.txtBx_id.Size = new System.Drawing.Size(311, 20);
            this.txtBx_id.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label6.Location = new System.Drawing.Point(6, 155);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 22);
            this.label6.TabIndex = 5;
            this.label6.Text = "Email:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label5.Location = new System.Drawing.Point(6, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 22);
            this.label5.TabIndex = 4;
            this.label5.Text = "Adres:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label4.Location = new System.Drawing.Point(6, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 22);
            this.label4.TabIndex = 3;
            this.label4.Text = "Telefon:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label3.Location = new System.Drawing.Point(6, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ad Soyad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label2.Location = new System.Drawing.Point(6, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "TC:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID:";
            // 
            // btn_ekle
            // 
            this.btn_ekle.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_ekle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_ekle.Location = new System.Drawing.Point(290, 220);
            this.btn_ekle.Name = "btn_ekle";
            this.btn_ekle.Size = new System.Drawing.Size(102, 35);
            this.btn_ekle.TabIndex = 3;
            this.btn_ekle.Text = "Ekle";
            this.btn_ekle.UseVisualStyleBackColor = false;
            this.btn_ekle.Click += new System.EventHandler(this.btn_ekle_Click);
            // 
            // btn_guncelle
            // 
            this.btn_guncelle.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_guncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_guncelle.Location = new System.Drawing.Point(398, 220);
            this.btn_guncelle.Name = "btn_guncelle";
            this.btn_guncelle.Size = new System.Drawing.Size(102, 35);
            this.btn_guncelle.TabIndex = 4;
            this.btn_guncelle.Text = "Güncelle";
            this.btn_guncelle.UseVisualStyleBackColor = false;
            this.btn_guncelle.Click += new System.EventHandler(this.btn_guncelle_Click);
            // 
            // btn_sil
            // 
            this.btn_sil.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_sil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_sil.Location = new System.Drawing.Point(506, 220);
            this.btn_sil.Name = "btn_sil";
            this.btn_sil.Size = new System.Drawing.Size(102, 35);
            this.btn_sil.TabIndex = 5;
            this.btn_sil.Text = "Sil";
            this.btn_sil.UseVisualStyleBackColor = false;
            this.btn_sil.Click += new System.EventHandler(this.btn_sil_Click);
            // 
            // btn_listele
            // 
            this.btn_listele.BackColor = System.Drawing.Color.ForestGreen;
            this.btn_listele.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_listele.Location = new System.Drawing.Point(237, 364);
            this.btn_listele.Name = "btn_listele";
            this.btn_listele.Size = new System.Drawing.Size(219, 41);
            this.btn_listele.TabIndex = 6;
            this.btn_listele.Text = "TümKayıtları Listele";
            this.btn_listele.UseVisualStyleBackColor = false;
            this.btn_listele.Click += new System.EventHandler(this.btn_listele_Click);
            // 
            // dtgrd_ogrenciListesi
            // 
            this.dtgrd_ogrenciListesi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgrd_ogrenciListesi.Location = new System.Drawing.Point(34, 424);
            this.dtgrd_ogrenciListesi.Name = "dtgrd_ogrenciListesi";
            this.dtgrd_ogrenciListesi.Size = new System.Drawing.Size(667, 198);
            this.dtgrd_ogrenciListesi.TabIndex = 7;
            this.dtgrd_ogrenciListesi.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgrd_ogrenciListesi_CellContentClick);
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.LemonChiffon;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.Firebrick;
            this.label7.Location = new System.Drawing.Point(31, 258);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(558, 19);
            this.label7.TabIndex = 23;
            this.label7.Text = "Öğrenci eklemek için sadece isim, numara ve bölüm giriniz ve Ekle butonuna basını" +
    "z.";
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.LemonChiffon;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.Color.Firebrick;
            this.label8.Location = new System.Drawing.Point(31, 277);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(558, 21);
            this.label8.TabIndex = 24;
            this.label8.Text = "Güncellenecek öğrencinin ID\'sini yazınız ve yeni bilgilerini giriniz ve Güncelle " +
    "butonuna basınız.";
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.LemonChiffon;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.ForeColor = System.Drawing.Color.Firebrick;
            this.label9.Location = new System.Drawing.Point(31, 298);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(558, 15);
            this.label9.TabIndex = 25;
            this.label9.Text = "Silmek istediğiniz öğrencinin ID\'sini giriniz ve Sil butonuna basınız.";
            // 
            // Ogrenci_İslemleri_Sfs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::KutuphaneOtomasyonuWinForm.Properties.Resources.giriş1;
            this.ClientSize = new System.Drawing.Size(925, 648);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dtgrd_ogrenciListesi);
            this.Controls.Add(this.btn_listele);
            this.Controls.Add(this.btn_sil);
            this.Controls.Add(this.btn_guncelle);
            this.Controls.Add(this.btn_ekle);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btn_anasayfa);
            this.Controls.Add(this.groupBox1);
            this.Name = "Ogrenci_İslemleri_Sfs";
            this.Text = "Öğrenci İşlemleri Sayfası";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrd_ogrenciListesi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_ogrAra;
        private System.Windows.Forms.TextBox txtBx_ogrAra;
        private System.Windows.Forms.Button btn_anasayfa;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBx_email;
        private System.Windows.Forms.TextBox txtBx_adres;
        private System.Windows.Forms.TextBox txtBx_telefon;
        private System.Windows.Forms.TextBox txtBx_adSoyad;
        private System.Windows.Forms.TextBox txtBx_tc;
        private System.Windows.Forms.TextBox txtBx_id;
        private System.Windows.Forms.Button btn_ekle;
        private System.Windows.Forms.Button btn_guncelle;
        private System.Windows.Forms.Button btn_sil;
        private System.Windows.Forms.Button btn_listele;
        private System.Windows.Forms.DataGridView dtgrd_ogrenciListesi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
    }
}