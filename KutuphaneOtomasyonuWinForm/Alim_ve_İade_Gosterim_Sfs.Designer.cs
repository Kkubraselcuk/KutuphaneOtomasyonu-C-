
namespace KutuphaneOtomasyonuWinForm
{
    partial class Alim_ve_İade_Gosterim_Sfs
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
            this.anasayfa = new System.Windows.Forms.Button();
            this.yukleme_btn = new System.Windows.Forms.Button();
            this.liste_d = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.arama_btn = new System.Windows.Forms.Button();
            this.giris_t = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ozellik_c = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ktp_ara_t = new System.Windows.Forms.TextBox();
            this.kategori_cmb = new System.Windows.Forms.ComboBox();
            this.ktp_ara_b = new System.Windows.Forms.Button();
            this.kitap_listesi_d = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.liste_d)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kitap_listesi_d)).BeginInit();
            this.SuspendLayout();
            // 
            // anasayfa
            // 
            this.anasayfa.BackColor = System.Drawing.Color.DarkRed;
            this.anasayfa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.anasayfa.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.anasayfa.Location = new System.Drawing.Point(12, 12);
            this.anasayfa.Name = "anasayfa";
            this.anasayfa.Size = new System.Drawing.Size(113, 28);
            this.anasayfa.TabIndex = 10;
            this.anasayfa.Text = "ANASAYFA";
            this.anasayfa.UseVisualStyleBackColor = false;
            this.anasayfa.Click += new System.EventHandler(this.anasayfa_Click);
            // 
            // yukleme_btn
            // 
            this.yukleme_btn.BackColor = System.Drawing.Color.ForestGreen;
            this.yukleme_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.yukleme_btn.ForeColor = System.Drawing.SystemColors.Control;
            this.yukleme_btn.Location = new System.Drawing.Point(561, 253);
            this.yukleme_btn.Name = "yukleme_btn";
            this.yukleme_btn.Size = new System.Drawing.Size(245, 45);
            this.yukleme_btn.TabIndex = 9;
            this.yukleme_btn.Text = "Tüm Kayıtları Göster";
            this.yukleme_btn.UseVisualStyleBackColor = false;
            this.yukleme_btn.Click += new System.EventHandler(this.yukleme_btn_Click);
            // 
            // liste_d
            // 
            this.liste_d.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.liste_d.Location = new System.Drawing.Point(12, 304);
            this.liste_d.Name = "liste_d";
            this.liste_d.Size = new System.Drawing.Size(794, 241);
            this.liste_d.TabIndex = 8;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.arama_btn);
            this.groupBox1.Controls.Add(this.giris_t);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.ozellik_c);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.ForeColor = System.Drawing.Color.DarkRed;
            this.groupBox1.Location = new System.Drawing.Point(216, 67);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(443, 143);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Emanet-İade edilen kitap";
            // 
            // arama_btn
            // 
            this.arama_btn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.arama_btn.ForeColor = System.Drawing.Color.Black;
            this.arama_btn.Location = new System.Drawing.Point(200, 99);
            this.arama_btn.Name = "arama_btn";
            this.arama_btn.Size = new System.Drawing.Size(131, 25);
            this.arama_btn.TabIndex = 4;
            this.arama_btn.Text = "Arama Yap";
            this.arama_btn.UseVisualStyleBackColor = false;
            this.arama_btn.Click += new System.EventHandler(this.arama_btn_Click);
            // 
            // giris_t
            // 
            this.giris_t.Location = new System.Drawing.Point(162, 66);
            this.giris_t.Name = "giris_t";
            this.giris_t.Size = new System.Drawing.Size(228, 21);
            this.giris_t.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(27, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Kitap Bilgisi:";
            // 
            // ozellik_c
            // 
            this.ozellik_c.FormattingEnabled = true;
            this.ozellik_c.Items.AddRange(new object[] {
            "kitapadi",
            "yazar",
            "tur"});
            this.ozellik_c.Location = new System.Drawing.Point(162, 24);
            this.ozellik_c.Name = "ozellik_c";
            this.ozellik_c.Size = new System.Drawing.Size(228, 23);
            this.ozellik_c.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(27, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kitabı şuna göre ara:";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.ktp_ara_t);
            this.groupBox2.Controls.Add(this.kategori_cmb);
            this.groupBox2.Controls.Add(this.ktp_ara_b);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.ForeColor = System.Drawing.Color.DarkRed;
            this.groupBox2.Location = new System.Drawing.Point(943, 67);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(484, 143);
            this.groupBox2.TabIndex = 29;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kitap Bilgisi Ara";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label11.Location = new System.Drawing.Point(28, 66);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(84, 15);
            this.label11.TabIndex = 5;
            this.label11.Text = "Kitap Bilgisi";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(28, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(179, 15);
            this.label6.TabIndex = 4;
            this.label6.Text = "Önce Arama Kriteri Seçiniz";
            // 
            // ktp_ara_t
            // 
            this.ktp_ara_t.Location = new System.Drawing.Point(212, 66);
            this.ktp_ara_t.Name = "ktp_ara_t";
            this.ktp_ara_t.Size = new System.Drawing.Size(243, 21);
            this.ktp_ara_t.TabIndex = 3;
            // 
            // kategori_cmb
            // 
            this.kategori_cmb.FormattingEnabled = true;
            this.kategori_cmb.Items.AddRange(new object[] {
            "kitapadi",
            "yazar",
            "tur"});
            this.kategori_cmb.Location = new System.Drawing.Point(212, 28);
            this.kategori_cmb.Margin = new System.Windows.Forms.Padding(2);
            this.kategori_cmb.Name = "kategori_cmb";
            this.kategori_cmb.Size = new System.Drawing.Size(243, 23);
            this.kategori_cmb.TabIndex = 2;
            this.kategori_cmb.SelectedIndexChanged += new System.EventHandler(this.kategori_cmb_SelectedIndexChanged);
            // 
            // ktp_ara_b
            // 
            this.ktp_ara_b.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ktp_ara_b.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ktp_ara_b.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ktp_ara_b.Location = new System.Drawing.Point(257, 99);
            this.ktp_ara_b.Margin = new System.Windows.Forms.Padding(2);
            this.ktp_ara_b.Name = "ktp_ara_b";
            this.ktp_ara_b.Size = new System.Drawing.Size(143, 25);
            this.ktp_ara_b.TabIndex = 1;
            this.ktp_ara_b.Text = "Kitap Ara";
            this.ktp_ara_b.UseVisualStyleBackColor = false;
            this.ktp_ara_b.Click += new System.EventHandler(this.ktp_ara_b_Click);
            // 
            // kitap_listesi_d
            // 
            this.kitap_listesi_d.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.kitap_listesi_d.Location = new System.Drawing.Point(868, 304);
            this.kitap_listesi_d.Margin = new System.Windows.Forms.Padding(2);
            this.kitap_listesi_d.Name = "kitap_listesi_d";
            this.kitap_listesi_d.RowTemplate.Height = 24;
            this.kitap_listesi_d.Size = new System.Drawing.Size(640, 241);
            this.kitap_listesi_d.TabIndex = 35;
            // 
            // Alim_ve_İade_Gosterim_Sfs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::KutuphaneOtomasyonuWinForm.Properties.Resources.alimGosterim;
            this.ClientSize = new System.Drawing.Size(1513, 557);
            this.Controls.Add(this.kitap_listesi_d);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.anasayfa);
            this.Controls.Add(this.yukleme_btn);
            this.Controls.Add(this.liste_d);
            this.Controls.Add(this.groupBox1);
            this.Name = "Alim_ve_İade_Gosterim_Sfs";
            this.Text = "Kitap Alım ve İade Gösterim Sayfası";
            ((System.ComponentModel.ISupportInitialize)(this.liste_d)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kitap_listesi_d)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button anasayfa;
        private System.Windows.Forms.Button yukleme_btn;
        private System.Windows.Forms.DataGridView liste_d;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button arama_btn;
        private System.Windows.Forms.TextBox giris_t;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox ozellik_c;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox ktp_ara_t;
        private System.Windows.Forms.ComboBox kategori_cmb;
        private System.Windows.Forms.Button ktp_ara_b;
        private System.Windows.Forms.DataGridView kitap_listesi_d;
    }
}