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
    public partial class Ogrenci_Alim_ve_İade_Gosterim_Sfs : Form
    {
        public Ogrenci_Alim_ve_İade_Gosterim_Sfs()
        {
            InitializeComponent();
        }

        iade_alim_islemleri iade_ve_alimlar = new iade_alim_islemleri();

        private void yukleme_btn_Click(object sender, EventArgs e)
        {
            //öğrencilerin daha önce yaptığı kitap alım ve iadeleri datagridview üzerinde gösterilir.
            List<almaverme> ktp1 = iade_ve_alimlar.iade_alim_yukle();
            liste_d.DataSource = ktp1;
            MessageBox.Show("Kayıt gösterme başarılı!");
        }

        private void arama_btn_Click(object sender, EventArgs e)
        {
            //BL'daki iade_alim_islemleri sınıfından ogrenci_emanet_iade_listele fanksiyonu çalıştırılıp arama textbox içindeki 
            //veri tablodan çağırılıp datagridview üzerinden gösterilir.
            List<almaverme> arama = iade_ve_alimlar.ogrenci_emanet_iade_listele(giris_t.Text);
            liste_d.DataSource = arama;
            MessageBox.Show("Arama Başarılı!");
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
