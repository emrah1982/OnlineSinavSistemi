using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineSinavModel
{
   public class Rol:Base
    {
        public string Ad { get; set; }

        public virtual ICollection<KullaniciRol> KullaniciRoller { get; set; }
       
    }
}
