using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineSinavCore.Abstract
{
   public interface IExceptionMessage
    {
        int KullaniciId { get; set; }
        string HataMesaji { get; set; }
        string HataUrl { get; set; }
        string HataMethodu { get; set; }
        string HataSatiri { get; set; }
        string HataYeri { get; set; }
        DateTime HataZamani { get; set; }
    }
}
