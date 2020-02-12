using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace OnlineSinavModel
{
   public class KursDers:Base
    {
        public int KullaniciId { get; set; }
        [ForeignKey("KullaniciId")]
        public Kullanici Kullanici { get; set; }

        public int DersId { get; set; }
        [ForeignKey("DersId")]
        public Ders Ders { get; set; }

        public DateTime KayitTarihi { get; set; }
    }
}
