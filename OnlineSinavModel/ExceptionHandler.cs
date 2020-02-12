using OnlineSinavCore.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineSinavModel
{
    public class ExceptionHandlers: IExceptionMessage
    {
        public int KullaniciId { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string HataMesaji { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string HataUrl { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string HataMethodu { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string HataSatiri { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string HataYeri { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public DateTime HataZamani { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        /// <summary>
        /// Message(Mesaj): Ortaya çıkan hatayla ilgili açıklayıcı bir mesaj saklar.
        //Source(Kaynak): İstisnai durum nesnesinin gönderildiği uygulama ya da dosyanın adıdır.
        //StackTrace(Yığınİzi): Hatanın oluştuğu metod ve program hakkında bilgi içerir.
        //HelpLink(YardımBağlantısı): Hatayla ilgili olan yardım dosyasının yol bilgisini saklar.
        //TargetSite(HedefAlanı): İstisnai durumu yaratan metod ile ilgili bilgi verir.
        //InnerException(Dahiliİstisna): "catch" bloğu içerisinden bir hata yaratılırsa "catch" bloğuna gelinmesine yol açan istisnai durumun Exception nesnesidir.
        //ToString(Dizgiye): Bu metod ilgili hataya ilişkin hata metninin tamamını dizi olarak döndürür.
        /// </summary>
        /// <param name="action"></param>
        public static void ExceptionHandler(Action action)
        {
            try
            {
                action.Invoke();
            }            
            catch (Exception ex)
            {
                if (ex.Message!=null)
                {
                    var hataMesaji = ex.Message;
                    var hataYardim = ex.HelpLink;
                    var method = ex.TargetSite;
                    var source = ex.Source;
                    var hataDosyaninAdi = ex.Source;


                }
  

            }

        }
    }

}
