using OnlineSinavCore.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineSinavModel
{
    public class ExceptionMessage : Base, IExceptionMessage
    {
        public Kullanici Kullanici { get; set; }
        public int KullaniciId { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string HataMesaji { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string HataUrl { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string HataMethodu { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string HataSatiri { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string HataYeri { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public DateTime HataZamani { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
