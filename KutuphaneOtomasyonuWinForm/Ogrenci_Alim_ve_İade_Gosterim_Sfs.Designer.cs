
namespace KutuphaneOtomasyonuWinForm
{
    partial class Ogrenci_Alim_ve_İade_Gosterim_Sfs
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
            ((System.ComponentModel.ISupportInitialize)(this.liste_d)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // anasayfa
            // 
            this.anasayfa.BackColor = System.Drawing.Color.DarkRed;
            this.anasayfa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.anasayfa.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.anasayfa.Location = new System.Drawing.Point(12, 12);
            this.anasayfa.Name = "anasayfa";
            this.anasayfa.Size = new System.Drawing.Size(113, 30);
            this.anasayfa.TabIndex = 14;
            this.anasayfa.Text = "ANASAYFA";
            this.anasayfa.UseVisualStyleBackColor = false;
            this.anasayfa.Click += new System.EventHandler(this.anasayfa_Click);
            // 
            // yukleme_btn
            // 
            this.yukleme_btn.BackColor = System.Drawing.Color.ForestGreen;
            this.yukleme_btn.ForeColor = System.Drawing.SystemColors.Control;
            this.yukleme_btn.Location = new System.Drawing.Point(201, 243);
            this.yukleme_btn.Name = "yukleme_btn";
            this.yukleme_btn.Size = new System.Drawing.Size(330, 47);
            this.yukleme_btn.TabIndex = 13;
            this.yukleme_btn.Text = "Tüm Kayıtları Göster";
            this.yukleme_btn.UseVisualStyleBackColor = false;
            this.yukleme_btn.Click += new System.EventHandler(this.yukleme_btn_Click);
            // 
            // liste_d
            // 
            this.liste_d.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.liste_d.Location = new System.Drawing.Point(12, 296);
            this.liste_d.Name = "liste_d";
            this.liste_d.Size = new System.Drawing.Size(649, 229);
            this.liste_d.TabIndex = 12;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.arama_btn);
            this.groupBox1.Controls.Add(this.giris_t);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(182, 83);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(332, 114);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Emanet-İade edilen kitap";
            // 
            // arama_btn
            // 
            this.arama_btn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.arama_btn.Location = new System.Drawing.Point(100, 71);
            this.arama_btn.Name = "arama_btn";
            this.arama_btn.Size = new System.Drawing.Size(156, 26);
            this.arama_btn.TabIndex = 4;
            this.arama_btn.Text = "Arama Yap";
            this.arama_btn.UseVisualStyleBackColor = false;
            this.arama_btn.Click += new System.EventHandler(this.arama_btn_Click);
            // 
            // giris_t
            // 
            this.giris_t.Location = new System.Drawing.Point(100, 33);
            this.giris_t.Name = "giris_t";
            this.giris_t.Size = new System.Drawing.Size(219, 21);
            this.giris_t.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(12, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Öğrenci TC:";
            // 
            // Ogrenci_Alim_ve_İade_Gosterim_Sfs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::KutuphaneOtomasyonuWinForm.Properties.Resources.Ogrencigosterim2;
            this.ClientSize = new System.Drawing.Size(679, 537);
            this.Controls.Add(this.anasayfa);
            this.Controls.Add(this.yukleme_btn);
            this.Controls.Add(this.liste_d);
            this.Controls.Add(this.groupBox1);
            this.Name = "Ogrenci_Alim_ve_İade_Gosterim_Sfs";
            this.Text = "Öğrenci Alım ve İade Gösterim Sayfası";
            ((System.ComponentModel.ISupportInitialize)(this.liste_d)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
    }
}