using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace OnlineSinavModel
{
   public class KullaniciDetay:Base
    {
        public int KullaniciID { get; set; }
        public int Mezuniyet { get; set; }
        public string Adres { get; set; }
        public string Telefon { get; set; }

        //navigation property
        //public virtual KullaniciDetay KullaniciDetaylari { get; set; }
        //[ForeignKey("KullaniciID")]    
        public Kullanici Kullanici { get; set; }

    }
}
