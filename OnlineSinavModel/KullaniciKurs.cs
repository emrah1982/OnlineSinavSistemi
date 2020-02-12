using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace OnlineSinavModel
{
   public class KullaniciKurs:Base
    {
        public int KursId { get; set; }
        [ForeignKey("KursId")]
        public Kurs Kurs { get; set; }

        public int KullaniciId { get; set; }
        [ForeignKey("KullaniciID")]
        public Kullanici Kullanici { get; set; }

        public bool Durum { get; set; }
    }
}
