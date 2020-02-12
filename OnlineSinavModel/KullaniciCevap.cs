using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace OnlineSinavModel
{
    public class KullaniciCevap : Base
    {

        public int KullaniciSinavID { get; set; }
        public KullaniciSinav KullaniciSinav{ get; set; }

        public int SoruID { get; set; }
        public Soru Soru { get; set; }
    }
}
