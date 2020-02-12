using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace OnlineSinavModel
{
   public class Yorum:Base
    {
        public int DersId { get; set; }
        [ForeignKey("DersId")]
        public Ders Ders { get; set; }
        public int KullaniciId { get; set; }
        [ForeignKey("KullaniciId")]
        public Kullanici Kullanici { get; set; }
        public string Aciklama { get; set; }
    }
}
