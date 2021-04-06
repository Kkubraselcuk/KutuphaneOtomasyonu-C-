using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class ogrenciler
    {
        //veritabanındaki öğrenciler tablosundaki sütunları tanımlıyoruz.
        public int ogrenciid { get; set; }
        public string tc { get; set; }
        public string adsoyad { get; set; }
        public string telefon { get; set; }
        public string adres { get; set; }
        public string email { get; set; }
    }
}
