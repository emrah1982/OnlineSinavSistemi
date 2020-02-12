using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace OnlineSinavModel
{
   public class Sikayet:Base
    {
     
        public int KullaniciId { get; set; }
        public int DersId { get; set; }
        public string Aciklama { get; set; }

        #region navigotion property
        [ForeignKey("KullaniciId")]
        public Kullanici Kullanici { get; set; }
        [ForeignKey("DersId")]
        public Ders Ders { get; set; }
        #endregion
    }
}
