using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace OnlineSinavModel
{
   public class SinavSoru:Base
    {
        public int SinavID { get; set; }
        [ForeignKey("SinavID")]
        public Sinav Sinav { get; set; }

        public int SoruID { get; set; }
        [ForeignKey("SoruID")]
        public Soru Soru { get; set; }
    }
}
