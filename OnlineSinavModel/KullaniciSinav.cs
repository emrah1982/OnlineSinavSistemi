using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace OnlineSinavModel
{
   public class KullaniciSinav:Base
    {
        //[ForeignKey("KullaniciId")]
        public int KullaniciId { get; set; }
        public Kullanici Kullanici { get; set; }

        //[ForeignKey("SinavId")]
        public int SinavId { get; set; }
        public Sinav Sinav { get; set; }

        public bool SinavBittiMi { get; set; }
        public ICollection<KullaniciCevap> KullaniciCevap { get;set; }
    }
}
