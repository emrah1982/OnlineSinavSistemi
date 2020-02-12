using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace OnlineSinavModel
{
   public class Soru:Base
    {
        public string SoruMetni { get; set; }
        public string Cevap { get; set; }
        public byte ZorlukDerecesi { get; set; }
        public int BransID { get; set; }
        public string Aciklama { get; set; }
        public int KullaniciID { get; set; }
        public bool OnaylandiMi { get; set; }


        #region navigation property
        //[ForeignKey("BransID")]
        public virtual Brans Brans { get; set; }
        //[ForeignKey("KullaniciID")]
        public virtual Kullanici Kullanici { get; set; }


        public ICollection<SinavSoru> SinavSoru { get; set; }
        #endregion

    }
}
