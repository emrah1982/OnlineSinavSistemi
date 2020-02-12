using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace OnlineSinavModel
{
   public class Sinav:Base
    {
        public int KursMerkeziId { get; set; }
        public DateTime SinavTarihi { get; set; }
        public int SinavSaati { get; set; }
        public int Suresi { get; set; }
        public byte SoruSayisi { get; set; }
        public string Sinif { get; set; }
        public int BransId { get; set; }
      
 
        public byte Kontejan { get; set; }
        public bool OturumBittiMi { get; set; }
        //navigation Property
        [ForeignKey("KursMerkeziId")]
        public virtual KursMerkezi KursMerkezi { get; set; }
        [ForeignKey("BransId")]
        public virtual Brans Brans { get; set; }


        public int OgretmenId { get; set; }
        public virtual Kullanici Ogretmen { get; set; }


        public int KaydedenKullaniciId { get; set; }
        public virtual Kullanici KaydedenKullanici { get; set; }
     

     

        //public User Reviewer { get; set; }
        //public int ReviewerId { get; set; }

        //public User Reviewee { get; set; }
        //public int RevieweeId { get; set; }


        public Kurs Kurs { get; set; }

        public ICollection<SinavSoru> SinavSoru { get; set; }
        public ICollection<KullaniciSinav> KullaniciSinav { get; set; }
        public ICollection<KullaniciCevap> KullaniciCevap { get; set; }

       


    }
}
