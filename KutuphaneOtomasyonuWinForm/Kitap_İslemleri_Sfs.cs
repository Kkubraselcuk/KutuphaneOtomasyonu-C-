using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entity;
using BL;

namespace KutuphaneOtomasyonuWinForm
{
    public partial class Kitap_İslemleri_Sfs : Form
    {
        public Kitap_İslemleri_Sfs()
        {
            InitializeComponent();
        }
        string konum = " ";

        kitap_islem k_islm = new kitap_islem();
        private void ekle_b_Click(object sender, EventArgs e)
        {
            //BL'daki kitap_islem sınıfındaki ktp_ekle fonksiyonu çaılştırılarak kitap ekleme işlemi yapılır.
            int sonuc = k_islm.ktp_ekle(ad_t.Text, yazar_t.Text, yayinevi_t.Text, tur_t.Text, rafno_t.Text);
            MessageBox.Show("Kitap Başarıyla Eklendi.");
        }

        void veri_cek()
        {
            //kitaplar listesinden sütun bilgilerini çekip datagridview'e aktarır.
            List<kitaplar> ktp = ktp_islem.kitap_goster();
            kitap_listesi_d.DataSource = ktp;
        }

        kitap_islem ktp_islem = new kitap_islem();
        private void tum_b_Click(object sender, EventArgs e)
        {
            //veri_cek fonksiyonu ile tüm kitap bilgileri datagridview'e aktarılır.
            veri_cek();
            MessageBox.Show("Tüm kayıtlar listelendi");
        }

        kitap_islem ktp_guncelleme = new kitap_islem();
        private void guncelle_b_Click(object sender, EventArgs e)
        {
            //BL'daki kitap_islem sınıfındaki ktp_guncelle fonksiyonu çalıştırılarak kitap güncellleme işlemi yapılır.
            try
            {
                int Sonuc = ktp_guncelleme.ktp_guncelle(int.Parse(id_t.Text), ad_t.Text, yazar_t.Text, yayinevi_t.Text, tur_t.Text, rafno_t.Text);
                MessageBox.Show("Kitap başarıyla güncellendi");
            }
            catch (Exception)
            {
                MessageBox.Show("Lütfen güncelleme bilgilerini doğru giriniz!");
            }
        }

        kitap_islem ktp_silme = new kitap_islem();
        private void sil_b_Click(object sender, EventArgs e)
        {
            //BL'daki kitap_islem sınıfındaki ktp_sil fonksiyonu çalıştırılarak kitap silme işlemi yapılır.
            try
            {
                int Sonuc = ktp_silme.ktp_sil(int.Parse(id_t.Text));
                MessageBox.Show("Kitap başarıyla silindi");
            }
            catch (Exception)
            {
                MessageBox.Show("Lütfen alanları doldurduğunuzdan veya doğru olduğundan emin olunuz!");
            }
        }

        private void kitap_listesi_d_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //datagridview'de tıklanan satırın bilgileri textbox'a aktarılır.
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = kitap_listesi_d.Rows[e.RowIndex];
                id_t.Text = row.Cells[0].Value.ToString();
                ad_t.Text = row.Cells[1].Value.ToString();
                yazar_t.Text = row.Cells[2].Value.ToString();
                yayinevi_t.Text = row.Cells[3].Value.ToString();
                tur_t.Text = row.Cells[4].Value.ToString();
                rafno_t.Text = row.Cells[5].Value.ToString();
            }
        }
        private void kategori_cmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            //konum değeri textbox içersindeki seçilen değere eşitlenir.
            konum = kategori_cmb.SelectedItem.ToString();
        }
        private void ktp_ara_b_Click(object sender, EventArgs e)
        {
            //BL'daki kitap_islem sınıfından kitap_goster fonksiyonu çalıştırılarak kitap bilgileri
            //datagridview'e aktarılır.
            try
            {
                List<kitaplar> ktp2 = ktp_islem.kitap_goster(ktp_ara_t.Text, konum);
                kitap_listesi_d.DataSource = ktp2;
                MessageBox.Show("Arama sonuçları listelendi");
            }
            catch (Exception)
            {
                MessageBox.Show("Lütfen Alanları Doldurunuz!");
            }
        }

        private void anasayfa_Click(object sender, EventArgs e)
        {
            //anasayfaya dönüş butonu.
            Form1 anasyf = new Form1();
            anasyf.Show();
            this.Hide();
        }
    }
}
