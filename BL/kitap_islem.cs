using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;
using Entity;

namespace BL
{
    public class kitap_islem
    {
        DAL.DAL dl1 = new DAL.DAL();
        public List<kitaplar> kitap_goster()
        {
            //veritabanından kitap tablosundaki değerleri çekiyoruz.
            OleDbDataReader dr = dl1.DRVeriCek("SELECT * FROM kitaplar", CommandType.Text);
            if (dr.HasRows)
            {
                //bu değerleri bir liste ile geri döndürüyoruz.
                List<kitaplar> kitaplar = new List<kitaplar>();
                while (dr.Read())
                {
                    kitaplar ktp = new kitaplar { kitapid = int.Parse(dr["kitapid"].ToString()), kitapadi = dr["kitapadi"].ToString(), yazari = dr["yazari"].ToString(), yayinevi = dr["yayinevi"].ToString(), tur = dr["tur"].ToString(), rafno = dr["rafno"].ToString() };
                    kitaplar.Add(ktp);
                }
                return kitaplar;
            }

            return null;
        }

        DAL.DAL dl2 = new DAL.DAL();
        public List<kitaplar> kitap_goster(string deger, string konum)
        {
            //veritabanından kitap tablosundaki değerleri çekiyoruz.
            OleDbDataReader dr = dl2.DRVeriCek("SELECT * FROM kitaplar WHERE " + konum + " ='" + deger + "'", CommandType.Text);
            if (dr.HasRows)
            {
                //bu değerleri bir liste ile geri döndürüyoruz.
                //bu sefer çekmek istediğimiz sütunu da sorguya gönderiyoruz. 
                List<kitaplar> kitaplar = new List<kitaplar>();
                while (dr.Read())
                {
                    kitaplar ktp = new kitaplar { kitapid = int.Parse(dr["kitapid"].ToString()), kitapadi = dr["kitapadi"].ToString(), yazari = dr["yazari"].ToString(), yayinevi = dr["yayinevi"].ToString(), tur = dr["tur"].ToString(), rafno = dr["rafno"].ToString() };
                    kitaplar.Add(ktp);
                }
                return kitaplar;
            }

            return null;
        }


        DAL.DAL dl3 = new DAL.DAL();
        public int ktp_ekle(string kitapadi, string yazari, string yayinevi, string tur, string rafno)
        {
            //kitap eklemek için sorgumuzu fonksiyona değerler ile birlikte gönderiyoruz.
            int sonuc = dl3.EkleSilGuncelle("insert into kitaplar (kitapadi,yazari,yayinevi,tur,rafno) values ('" + kitapadi + "','" + yazari + "','" + yayinevi + "','" + tur + "','" + rafno + "')", System.Data.CommandType.Text);
            return sonuc;
        }

        DAL.DAL dl4 = new DAL.DAL();
        public int ktp_guncelle(int kitapid, string kitapadi, string yazari, string yayinevi, string tur, string rafno)
        {
            //kitap güncellemek için sorgumuzu fonksiyona değerler ile birlikte gönderiyoruz.
            int sonuc = dl4.EkleSilGuncelle("update kitaplar set kitapadi='" + kitapadi + "', yazari='" + yazari + "', yayinevi='" + yayinevi + "', tur='" + tur + "', rafno='" + rafno + "' WHERE kitapid=" + kitapid + "", System.Data.CommandType.Text);
            return sonuc;
        }

        DAL.DAL dl5 = new DAL.DAL();

        public int ktp_sil(int kitapid)
        {
            //kitap silmek için sorgumuzu fonksiyona değerler ile birlikte gönderiyoruz.
            int sonuc = dl5.EkleSilGuncelle("DELETE from kitaplar where kitapid =" + kitapid + "", System.Data.CommandType.Text);
            return sonuc;
        }
    }
}
