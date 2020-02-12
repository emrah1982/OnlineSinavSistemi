using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace OnlineSinavModel
{
   public class KullaniciRol:Base
    {
        public int KullaniciId { get; set; }
        public int RolId { get; set; }

        #region Navigation Property
        [ForeignKey("KullaniciId")]
        public Kullanici Kullanici { get; set; }
        [ForeignKey("RolId")]
        public Rol Rol { get; set; }
        #endregion

    }
}
