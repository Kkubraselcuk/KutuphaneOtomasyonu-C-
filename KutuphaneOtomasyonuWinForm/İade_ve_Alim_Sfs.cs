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
    public partial class İade_ve_Alim_Sfs : Form
    {
        public İade_ve_Alim_Sfs()
        {
            InitializeComponent();
        }

        string konum = " ";
        string tablo = "";
        iade_alim_islemleri islem_yap = new iade_alim_islemleri();

        

        //alim baslangic

        iade_alim_islemleri alim_iade_ekle = new iade_alim_islemleri();
        private void emanet_btn_Click(object sender, EventArgs e)
        {
            //emanet_islemi fonksiyonuna gerekli parametreleri göndererek emanet verme işlemini yapıyoruz.
            try
            {
                int Sonuc = alim_iade_ekle.emanet_islemi(int.Parse(emanet_ktp_id_t.Text), int.Parse(emanet_ogr_id_t.Text), DateTime.Parse(emanet_tarih_t.Text), DateTime.Parse(emanet_tarih__son_t.Text), "alım");
                MessageBox.Show("Emanet verme işlemi başarılı!");
            }
            catch (Exception)
            {
                MessageBox.Show("Emanet işlemi için lütfen alanları doldurunuz!");
            }
        }

        ogrenci_islem ogr_islem = new ogrenci_islem();
        private void emanet_ogr_ara_btn_Click(object sender, EventArgs e)
        {
            //öğrenci tablosundan istediğimiz verileri çekip datagridview'e yüklüyoruz.
            try
            {
                List<ogrenciler> ogr = ogr_islem.ogrenci_goster(emanet_ogr_no_t.Text);
                dataGridView1.DataSource = ogr;
                tablo = "emanet_islemleri_ogrenci";
                MessageBox.Show("Arama başarılı!");
            }
            catch (Exception)
            {
                MessageBox.Show("Geçersiz girdi!");
            }
        }

        kitap_islem kitap_islemler = new kitap_islem();
        private void emanet_ktp_ara_btn_Click(object sender, EventArgs e)
        {
            //kitap tablosundan istediğimiz verileri çekip datagridview'e yüklüyoruz.
            try
            {
                List<kitaplar> ktp2 = kitap_islemler.kitap_goster(emanet_ktp_bilgi_t.Text, konum);
                dataGridView1.DataSource = ktp2;
                tablo = "emanet_islemleri_kitap";
                MessageBox.Show("Arama başrılı!");
            }
            catch (Exception)
            {
                MessageBox.Show("Alanlar boş bırakılamaz!");
            }
        }

        private void emanet_ktp_kategori_cmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            //aramanın neye göre yapılacağı bilgisini combobox'tan alıyoruz.
            konum = emanet_ktp_kategori_cmb.SelectedItem.ToString();
        }

        
        //alim bitiş

        //iade groupbox başlangıç
        private void iade_ogr_ara_btn_Click(object sender, EventArgs e)
        {
            //öğrenci tablosundan istediğimiz verileri çekip datagridview'e yüklüyoruz.
            try
            {
                List<almaverme> kayit_cek = islem_yap.kayit_listeleme1(int.Parse(iade_ogr_no_t.Text));
                dataGridView1.DataSource = kayit_cek;
                MessageBox.Show("Arama başarılı");
            }
            catch (Exception)
            {
                MessageBox.Show("Alanlar boş bırakılamaz!");
            }
        }

        private void iade_ktp_ara_btn_Click(object sender, EventArgs e)
        {
            //kitap tablosundan istediğimiz verileri çekip datagridview'e yüklüyoruz.
            try
            {
                string konum = " ";
                konum = iade_ktp_kategori_cmb.SelectedItem.ToString();
                List<almaverme> kayit_cek_2 = islem_yap.kayit_listeleme2(iade_ktp_bilgi_t.Text, konum);
                dataGridView1.DataSource = kayit_cek_2;
                MessageBox.Show("Arama başarılı!");
            }
            catch (Exception)
            {
                MessageBox.Show("Alanlar boş bırakılamaz!");
            }
        }

        private void iade_btn_Click(object sender, EventArgs e)
        {
            //tablo_iade_duzenleme fonksiyonuna gerekli parametreleri göndererek iade etme işlemini yapıyoruz.
            try
            { 
                int Sonuc = alim_iade_ekle.tablo_iade_duzenleme(int.Parse(iade_ktp_id_t.Text), 
                    int.Parse(iade_ogr_id_t.Text), "iade", iade_ktp_tarih_t.Text);
                MessageBox.Show("İade başarılı!");
            }
            catch (Exception)
            {
                MessageBox.Show("İade işlemi için lütfen alanları doldurunuz!");
            }
        }

        public void emanet_ve_iade_renk()
        {
            double ceza = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                ceza = double.Parse(dataGridView1.Rows[i].Cells[5].Value.ToString());
                dataGridView1.Rows[i].Cells[5].Value = ceza.ToString("c");
                string islem_turu = dataGridView1.Rows[i].Cells[6].Value.ToString();

                //eğer islem_turu iade'ye eşitse ilgili satırlar yeşil olur.
                if (islem_turu == "iade")
                {
                    dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.Green;
                    dataGridView1.Rows[i].DefaultCellStyle.ForeColor = Color.White;
                }

                //almaverme tablosundaki islem_turu iadeye eşit değilse tarihsel işlemler aşağıdaki gibi yapılır.
                if (islem_turu != "iade")
                {
                    string t1, t2; DateTime s1, s2;
                    t1 = DateTime.Now.ToShortDateString();
                    DateTime t3 = DateTime.Parse(dataGridView1.Rows[i].Cells[3].Value.ToString());
                    t2 = t3.ToShortDateString();
                    TimeSpan fark;
                    s1 = DateTime.Parse(t1);
                    s2 = DateTime.Parse(t2);
                    fark = s1.Subtract(s2);

                    //eğer iade tarihine 2 gün veya daha az kaldıysa o kişinin satırı sarı olarak görünür
                    if (Int32.Parse(fark.TotalDays.ToString()) > -3 && Int32.Parse(fark.TotalDays.ToString()) < 1)
                    {
                        dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.Yellow;
                        dataGridView1.Rows[i].DefaultCellStyle.ForeColor = Color.Black;
                    }
                    //eğer son iade tarihi geçmişse satırın kırmızı görünmesi sağlanır.
                    if (Int32.Parse(fark.TotalDays.ToString()) > 0)
                    {
                        dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                        dataGridView1.Rows[i].DefaultCellStyle.ForeColor = Color.Black;                        
                    }                   
                }
            }
        }

        void veri_cek()
        {
            //almaverme tablosundaki verileri datagridview'e yüklemek için bu fonksiyonu kullanıyoruz.
            List<almaverme> ktp = islem_yap.iade_alim_yukle();
            dataGridView1.DataSource = ktp;
        }
        private void sırala_btn_Click(object sender, EventArgs e)
        {
            //sırala butonuna tıklandığında veri_cek ve emanet_ve_iade_renk fonksiyonları çalıştırılır.
            veri_cek();
            emanet_ve_iade_renk();
        }

        private void anasayfa_Click(object sender, EventArgs e)
        {
            //anasayfaya dönüş yapılır.
            Form1 anasyf = new Form1();
            anasyf.Show();
            this.Hide();
        }

        private void emanet_tarih_secim_ValueChanged(object sender, EventArgs e)
        {
            //emanet alınan tarih bilgisini datetimepicker yardımıyla alıyoruz.
            emanet_tarih_t.Text = emanet_tarih_secim.Value.ToShortDateString();
            DateTime emanettarih = DateTime.Parse(emanet_tarih_t.Text);

            //emanet tarihine 30 gün ekleyerek son teslim tarihini belirliyoruz.
            emanet_tarih__son_t.Text = emanettarih.AddDays(30).ToShortDateString();
        }
    }
}
