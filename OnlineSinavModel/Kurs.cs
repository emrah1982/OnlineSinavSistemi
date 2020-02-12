using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace OnlineSinavModel
{
   public class Kurs:Base
    {

        public DateTime BaslamaTarihi { get; set; }
        public DateTime BitisTarihi { get; set; }
        public bool BitttiMi { get; set; }
        public int SinavId { get; set; }
        public int HaftalikCalisma { get; set; }

        //Navigation Property
        //[ForeignKey("SinavId")]
        //public virtual Sinav Sinav { get; set; }
        public ICollection<KursDers> KursDers { get; set; }
        public ICollection<KullaniciKurs> KullaniciKurs { get; set; }
        [ForeignKey("SinavId")]
        public Sinav Sinav { get; set; }
        public Ders Ders { get; set; }


    }
}
