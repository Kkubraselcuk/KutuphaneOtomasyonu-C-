using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class kitaplar
    {
        //veritabanındaki kitaplar tablosundaki sütun verilerini tanımlıyoruz.
        public int kitapid { get; set; }
        public string kitapadi { get; set; }
        public string yazari { get; set; }
        public string yayinevi { get; set; }
        public string tur { get; set; }
        public string rafno { get; set; }
    }
}
