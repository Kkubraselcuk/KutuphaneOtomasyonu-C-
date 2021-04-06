using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BL;
using Entity;

namespace KutuphaneOtomasyonuWinForm
{
    public partial class Ogrenci_İslemleri_Sfs : Form
    {
        public Ogrenci_İslemleri_Sfs()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        ogrenci_islem o_list = new ogrenci_islem();

        void ogr_gstr()
        {
            //ogrencilerrenciler listesindeki verileri ogr_goster fonkiyonu ile datagridview'e çağırır. 
            List<ogrenciler> ogrenciler1 = o_list.ogrenci_goster();
            dtgrd_ogrenciListesi.DataSource = ogrenciler1;
        }
        private void btn_anasayfa_Click(object sender, EventArgs e)
        {
            //anasayfaya dönüş butonu
            Form1 anasyf = new Form1();
            anasyf.Show();
            this.Hide();
        }
        private void btn_ogrAra_Click(object sender, EventArgs e)
        {
            // arama textbox'ındaki metin ogrenciler tablosundan bulunarak listeleniyor.
            List<ogrenciler> ogrenciler1 = o_islm.ogrenci_goster(txtBx_ogrAra.Text);
            dtgrd_ogrenciListesi.DataSource = ogrenciler1;
        }
        private void dtgrd_ogrenciListesi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //datagridview'de tıklanan satırın bilgileri textbox'a aktarılır.
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dtgrd_ogrenciListesi.Rows[e.RowIndex];
                txtBx_id.Text = row.Cells[0].Value.ToString();
                txtBx_tc.Text = row.Cells[1].Value.ToString();
                txtBx_adSoyad.Text = row.Cells[2].Value.ToString();
                txtBx_telefon.Text = row.Cells[3].Value.ToString();
                txtBx_adres.Text = row.Cells[4].Value.ToString();
                txtBx_email.Text = row.Cells[5].Value.ToString();
            }
        }
        ogrenci_islem o_islm = new ogrenci_islem();
        private void btn_ekle_Click(object sender, EventArgs e)
        {
            //BL'daki ogrenci_islem sınıfındaki ogr_ekle fonksiyonu çalıştırılarak öğrenci ekleme işlemi yapılır.
            int sonuc = o_islm.ogr_ekle(txtBx_tc.Text, txtBx_adSoyad.Text, txtBx_telefon.Text, txtBx_adres.Text, txtBx_email.Text);
            MessageBox.Show("Öğrenci Başarıyla Eklendi.");
        }

        ogrenci_islem o_sill = new ogrenci_islem();
        private void btn_sil_Click(object sender, EventArgs e)
        {
            //BL'daki ogrenci_islem sınıfındaki ogr_sil fonksiyonu çalıştırılarak öğrenci silme işlemi yapılır.
            try
            {
                o_sill.ogr_sil(int.Parse(txtBx_id.Text));
                MessageBox.Show("Öğrenci Başarıyla Silindi.");
            }
            catch (Exception)
            {
                MessageBox.Show("Lütfen girilen değerleri kontrol ediniz!");
            }
        }

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            //BL'daki ogrenci_islem sınıfındaki ogr_guncelle fonksiyonu çalıştırılarak öğrenci güncelleme işlemi yapılır.
            try
            {
                int sonuc = o_islm.ogr_guncelle(int.Parse(txtBx_id.Text), txtBx_tc.Text, txtBx_adSoyad.Text, txtBx_telefon.Text, txtBx_adres.Text, txtBx_email.Text);
                MessageBox.Show("Öğrenci Başarıyla Güncellendi.");
            }
            catch (Exception)
            {
                MessageBox.Show("Lütfen güncelleme bilgilerini doğru girdiğinizden emin olun!");
            }
        }

        private void btn_listele_Click(object sender, EventArgs e)
        {
            //ogr_gstr fonksiyonu ile öğrenci listelemesi yapılır.
            ogr_gstr();
            MessageBox.Show("Öğrenciler Başarıyla Listelendi.");
        }

        private void txtBx_ogrAra_Click(object sender, EventArgs e)
        {
            //textbox içindeki yazılar silinir.
            txtBx_ogrAra.Text = "";
        }
    }
}
