using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace OnlineSinavModel
{
    public class Ders : Base
    {
        public int KursId { get; set; }
        public string Baslik { get; set; }
        public string Icerik { get; set; }
        public string VideoUrl { get; set; }
        public string DokumanUrl { get; set; }

        //naviagation Property
        [ForeignKey("KursId")]
        public virtual Kurs Kurs { get; set; }

        public ICollection<KursDers> KursDers { get; set; }
        public ICollection<Yorum> Yorumlar { get; set; }
        public virtual ICollection<Sikayet> Sikayetler { get; set; }
    }
}
