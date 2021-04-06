using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZedGraph;
using BL;

namespace KutuphaneOtomasyonuWinForm
{
    public partial class Kitap_Grafik_Sfs : Form
    {
        public Kitap_Grafik_Sfs()
        {
            InitializeComponent();
        }

        private void anasayfa_Click(object sender, EventArgs e)
        {
            //anasayfaya dönüş sağlanır.
            Form1 anasyf = new Form1();
            anasyf.Show();
            this.Hide();
        }
        trafik zedgraph = new trafik();
        private void Kitap_Grafik_Sfs_Load(object sender, EventArgs e)
        {
            //zedgraph yardımıyla tüm kitaplardan verilen kitap sayısını çıkarıp tablo üzerinde "verilmeye hazır kitap sayısı" , 
            //"tüm kitap sayısı" ve "Verilen kitap sayısı"'nı grafik üzerinde gösteriyoruz.
            int ktp = zedgraph.listele();
            int verilen_ktp = zedgraph.alma();

            GraphPane myPane = zedGraphControl1.GraphPane;
            myPane.Title.Text = "Kitap Grafik";
            myPane.XAxis.Title.Text = "";
            myPane.YAxis.Title.Text = "";

            //kitap sayıları ile ilgili satırlar tanımlanır ve kitap sayıları için işlemler yapılır.
            string[] satir = { "Verilen Kitaplar", "Verilmeye Hazır Kitaplar", "Tüm Kitaplar" };
            double[] kitap_sayi = { verilen_ktp, ktp - verilen_ktp, ktp };

            //verilen kitap ve tüm kitaplar tablo üzerinde kutu yanında gösterilir.
            myPane.AddPieSlices(kitap_sayi, new[] { "Verilen Kitaplar", "Verilmeye Hazır Kitaplar", null });
            myPane.Legend.IsVisible = true;
            LineItem myLine = myPane.AddCurve(null, null, kitap_sayi, Color.Red);
            //tablo renk dönüşümü
            myLine.Line.Fill = new Fill(Color.Red, Color.White, Color.Blue);

            myPane.XAxis.Scale.TextLabels = satir;
            myPane.XAxis.Type = AxisType.Text;

            //tablo renk ve yön fonksiyonu.
            myPane.Chart.Fill = new Fill(Color.White, Color.FromArgb(255, 255, 166), 90F);
            myPane.Fill = new Fill(Color.FromArgb(250, 250, 255));
            zedGraphControl1.AxisChange();
        }

        
    }
}
