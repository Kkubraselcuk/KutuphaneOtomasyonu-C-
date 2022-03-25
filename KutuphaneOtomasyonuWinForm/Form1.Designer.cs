
namespace KutuphaneOtomasyonuWinForm
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
            this.btn_ogrenciİslemleri = new System.Windows.Forms.Button();
            this.btn_kitapİslemleri = new System.Windows.Forms.Button();
            this.btn_alımİadeİslemleri = new System.Windows.Forms.Button();
            this.btn_ogrKitapListesi = new System.Windows.Forms.Button();
            this.btn_kitapTakip = new System.Windows.Forms.Button();
            this.btn_grafik = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_ogrenciİslemleri
            // 
            this.btn_ogrenciİslemleri.BackColor = System.Drawing.Color.Pink;
            this.btn_ogrenciİslemleri.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btn_ogrenciİslemleri.Location = new System.Drawing.Point(813, 301);
            this.btn_ogrenciİslemleri.Name = "btn_ogrenciİslemleri";
            this.btn_ogrenciİslemleri.Size = new System.Drawing.Size(283, 53);
            this.btn_ogrenciİslemleri.TabIndex = 0;
            this.btn_ogrenciİslemleri.Text = "Öğrenci İşlemleri";
            this.btn_ogrenciİslemleri.UseVisualStyleBackColor = false;
            this.btn_ogrenciİslemleri.Click += new System.EventHandler(this.btn_ogrenciİslemleri_Click);
            // 
            // btn_kitapİslemleri
            // 
            this.btn_kitapİslemleri.BackColor = System.Drawing.Color.Thistle;
            this.btn_kitapİslemleri.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btn_kitapİslemleri.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_kitapİslemleri.Location = new System.Drawing.Point(813, 360);
            this.btn_kitapİslemleri.Name = "btn_kitapİslemleri";
            this.btn_kitapİslemleri.Size = new System.Drawing.Size(283, 53);
            this.btn_kitapİslemleri.TabIndex = 1;
            this.btn_kitapİslemleri.Text = "Kitap İşlemleri";
            this.btn_kitapİslemleri.UseVisualStyleBackColor = false;
            this.btn_kitapİslemleri.Click += new System.EventHandler(this.btn_kitapİslemleri_Click);
            // 
            // btn_alımİadeİslemleri
            // 
            this.btn_alımİadeİslemleri.BackColor = System.Drawing.Color.MediumPurple;
            this.btn_alımİadeİslemleri.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btn_alımİadeİslemleri.Location = new System.Drawing.Point(813, 419);
            this.btn_alımİadeİslemleri.Name = "btn_alımİadeİslemleri";
            this.btn_alımİadeİslemleri.Size = new System.Drawing.Size(283, 53);
            this.btn_alımİadeİslemleri.TabIndex = 2;
            this.btn_alımİadeİslemleri.Text = "Kitap Emanet ve İade İşlemleri";
            this.btn_alımİadeİslemleri.UseVisualStyleBackColor = false;
            this.btn_alımİadeİslemleri.Click += new System.EventHandler(this.btn_alımİadeİslemleri_Click);
            // 
            // btn_ogrKitapListesi
            // 
            this.btn_ogrKitapListesi.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btn_ogrKitapListesi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btn_ogrKitapListesi.Location = new System.Drawing.Point(813, 478);
            this.btn_ogrKitapListesi.Name = "btn_ogrKitapListesi";
            this.btn_ogrKitapListesi.Size = new System.Drawing.Size(283, 53);
            this.btn_ogrKitapListesi.TabIndex = 3;
            this.btn_ogrKitapListesi.Text = "Kitap Emanet - İade Listesi";
            this.btn_ogrKitapListesi.UseVisualStyleBackColor = false;
            this.btn_ogrKitapListesi.Click += new System.EventHandler(this.btn_ogrKitapListesi_Click);
            // 
            // btn_kitapTakip
            // 
            this.btn_kitapTakip.BackColor = System.Drawing.Color.LightGreen;
            this.btn_kitapTakip.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btn_kitapTakip.Location = new System.Drawing.Point(813, 537);
            this.btn_kitapTakip.Name = "btn_kitapTakip";
            this.btn_kitapTakip.Size = new System.Drawing.Size(283, 53);
            this.btn_kitapTakip.TabIndex = 4;
            this.btn_kitapTakip.Text = "Öğrenci Emanet - İade Listesi";
            this.btn_kitapTakip.UseVisualStyleBackColor = false;
            this.btn_kitapTakip.Click += new System.EventHandler(this.btn_kitapTakip_Click);
            // 
            // btn_grafik
            // 
            this.btn_grafik.BackColor = System.Drawing.Color.LightSalmon;
            this.btn_grafik.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btn_grafik.Location = new System.Drawing.Point(813, 596);
            this.btn_grafik.Name = "btn_grafik";
            this.btn_grafik.Size = new System.Drawing.Size(283, 53);
            this.btn_grafik.TabIndex = 5;
            this.btn_grafik.Text = "Grafik";
            this.btn_grafik.UseVisualStyleBackColor = false;
            this.btn_grafik.Click += new System.EventHandler(this.btn_grafik_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tempus Sans ITC", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Purple;
            this.label1.Location = new System.Drawing.Point(110, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(911, 84);
            this.label1.TabIndex = 6;
            this.label1.Text = "KÜTÜPHANE OTOMASYONU";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::KutuphaneOtomasyonuWinForm.Properties.Resources.kitap;
            this.ClientSize = new System.Drawing.Size(1156, 737);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_grafik);
            this.Controls.Add(this.btn_kitapTakip);
            this.Controls.Add(this.btn_ogrKitapListesi);
            this.Controls.Add(this.btn_alımİadeİslemleri);
            this.Controls.Add(this.btn_kitapİslemleri);
            this.Controls.Add(this.btn_ogrenciİslemleri);
            this.Name = "Form1";
            this.Text = "ANASAYFA";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_ogrenciİslemleri;
        private System.Windows.Forms.Button btn_kitapİslemleri;
        private System.Windows.Forms.Button btn_alımİadeİslemleri;
        private System.Windows.Forms.Button btn_ogrKitapListesi;
        private System.Windows.Forms.Button btn_kitapTakip;
        private System.Windows.Forms.Button btn_grafik;
        private System.Windows.Forms.Label label1;
    }
}

