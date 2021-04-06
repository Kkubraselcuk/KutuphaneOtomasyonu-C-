using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Entity;
using System.Data;
using System.Data.OleDb;

namespace BL
{
    public class ogrenci_islem
    {
        DAL.DAL dl1 = new DAL.DAL();
        public List<ogrenciler> ogrenci_goster()
        {
            //veritabanından ogrenciler tablosundaki değerleri çekiyoruz.
            OleDbDataReader dr = dl1.DRVeriCek("SELECT * FROM ogrenciler", CommandType.Text);
            if (dr.HasRows)
            {
                //bu değerleri bir liste ile geri döndürüyoruz.
                List<ogrenciler> ogrenciler1 = new List<ogrenciler>();
                while (dr.Read())
                {
                    ogrenciler ogrnci = new ogrenciler { ogrenciid = int.Parse(dr["ogrenciid"].ToString()), tc = dr["tc"].ToString(), adsoyad = dr["adsoyad"].ToString(), telefon = dr["telefon"].ToString(), adres = dr["adres"].ToString(), email = dr["email"].ToString() };
                    ogrenciler1.Add(ogrnci);
                }
                return ogrenciler1;
            }
            return null;
        }


        DAL.DAL dl2 = new DAL.DAL();
        public List<ogrenciler> ogrenci_goster(string tc)
        {
            //veritabanından ogrenciler tablosundaki değerleri çekiyoruz.
            OleDbDataReader dr = dl2.DRVeriCek("SELECT * FROM ogrenciler WHERE tc='" + tc + "'", CommandType.Text);
            if (dr.HasRows)
            {
                //bu değerleri bir liste ile geri döndürüyoruz.
                //bu sefer çekmek istediğimiz sütunu da sorguya gönderiyoruz. 
                List<ogrenciler> ogrenciler1 = new List<ogrenciler>();
                while (dr.Read())
                {
                    ogrenciler ogrnci = new ogrenciler { ogrenciid = int.Parse(dr["ogrenciid"].ToString()), tc = dr["tc"].ToString(), adsoyad = dr["adsoyad"].ToString(), telefon = dr["telefon"].ToString(), adres = dr["adres"].ToString(), email = dr["email"].ToString() };
                    ogrenciler1.Add(ogrnci);
                }
                return ogrenciler1;
            }
            return null;
        }


        DAL.DAL dl3 = new DAL.DAL();
        public int ogr_ekle(string tc, string adsoyad, string telefon, string adres, string email)
        {
            //öğrenci eklemek için sorgumuzu fonksiyona değerler ile birlikte gönderiyoruz.
            int sonuc = dl3.EkleSilGuncelle("INSERT into ogrenciler (tc,adsoyad,telefon,adres,email) VALUES ('" + tc + "','" + adsoyad + "','" + telefon + "','" + adres + "','" + email + "')", System.Data.CommandType.Text);
            return sonuc;
        }


        DAL.DAL dl4 = new DAL.DAL();
        public int ogr_guncelle(int ogrenciid, string tc, string adsoyad, string telefon, string adres, string email)
        {
            //öğrenci güncellemek için sorgumuzu fonksiyona değerler ile birlikte gönderiyoruz.
            int sonuc = dl4.EkleSilGuncelle("UPDATE ogrenciler SET tc='" + tc + "', adsoyad='" + adsoyad + "', telefon='" + telefon + "', adres='" + adres + "', email='" + email + "' WHERE ogrenciid=" + ogrenciid + "", System.Data.CommandType.Text);
            return sonuc;
        }


        DAL.DAL dl5 = new DAL.DAL();

        public int ogr_sil(int ogrenciid)
        {
            //öğrenciyi silmek için sorgumuzu fonksiyona değerler ile birlikte gönderiyoruz.
            int sonuc = dl5.EkleSilGuncelle("DELETE from ogrenciler where ogrenciid =" + ogrenciid + "", System.Data.CommandType.Text);
            return sonuc;
        }
    }
}
