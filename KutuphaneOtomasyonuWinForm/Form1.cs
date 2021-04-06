using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KutuphaneOtomasyonuWinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btn_ogrenciİslemleri_Click(object sender, EventArgs e)
        {
            Ogrenci_İslemleri_Sfs ogrislem = new Ogrenci_İslemleri_Sfs();
            ogrislem.Show();
            this.Hide();
        }
        private void btn_kitapİslemleri_Click(object sender, EventArgs e)
        {
            Kitap_İslemleri_Sfs ktpislem = new Kitap_İslemleri_Sfs();
            ktpislem.Show();
            this.Hide();
        }
        private void btn_alımİadeİslemleri_Click(object sender, EventArgs e)
        {
            İade_ve_Alim_Sfs kai = new İade_ve_Alim_Sfs();
            kai.Show();
            this.Hide();
        }
        private void btn_ogrKitapListesi_Click(object sender, EventArgs e)
        {
            Alim_ve_İade_Gosterim_Sfs kitp_list = new Alim_ve_İade_Gosterim_Sfs();
            kitp_list.Show();
            this.Hide();
        }
        private void btn_kitapTakip_Click(object sender, EventArgs e)
        {
            Ogrenci_Alim_ve_İade_Gosterim_Sfs ogr_list = new Ogrenci_Alim_ve_İade_Gosterim_Sfs();
            ogr_list.Show();
            this.Hide();
        }
        private void btn_grafik_Click(object sender, EventArgs e)
        {
            Kitap_Grafik_Sfs ktp_grfik = new Kitap_Grafik_Sfs();
            ktp_grfik.Show();
            this.Hide();
        }
    }
}
