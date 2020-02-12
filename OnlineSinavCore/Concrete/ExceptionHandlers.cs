using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;


namespace OnlineSinavCore.Concrete
{
   public class ExceptionHandlers: DbContext
    {
        public static void ExceptionHandler(Action action)
        {
            #region  System.Exception Üyeleri
            //İstisnai durumlar hakkında daha açıklayıcı bilgiler almak için System.Exception sınıfının üyelerini kullanırız. En çok kullanılan property’ler şunlardır;
            //HelpLink: Bu exception ile ilişkilendirilmiş web safyasının adresini tutar. Kendi tanımladığımız exceptionda bu property’i set edebiliriz.
            //InnerException : Asıl exception’dan kaynaklanan istisnayı okumak için kullanılır. Try içinde hata oluştuğu zaman catch’e atlar demiştik.Catch’de de meydana gelebilecek istisnayı öğrenmek için InnerException kullanılır.
            //Message : Hatanın nedenini açıklayan, hata kakkında bilgi veren içeriği bildirir.
            //Source: Hatanın oluştuğu class veya uygulamayı ifade eder.Eğer exception içinde Source property’si set edilmemişse geriye hatanın yazıldığı Assembly adı döner.Örneğin OverflowException hatası oluştuğunda source olarak mscorlib döner.
            //StackTrace : İşe yarar bilgilerden biri olarak stacktrace, hatanın oluştuğu dosyanın adını ve satır bilgisini açıklar.
            //TargetSite : Hataya sebep olan metodun adını döndürür.
            #endregion
            #region Hata mesajlarını kaydetme
            try
            {
                action.Invoke();
            }
            catch (System.Exception ex)
            {
                if (ex!=null)
                {

                    

                    var HataUrl = ex.HelpLink;
                    var HataMethodu = Convert.ToString(ex.TargetSite);
                    var HataSatiri = ex.StackTrace;
                    var HataYeri = ex.Source;
                    var HataMesaji = ex.Message;
                    var HataZamani = DateTime.Now;


                }

          
               
                //ExceptionHandlingProperty exceptionHandlingProperty = new ExceptionHandlingProperty();
                //var addedData = context.Entry(exceptionHandlingProperty);
                //addedData.State = EntityState.Added;
                //context.SaveChanges();



            }

            #endregion
        }
    }
}
