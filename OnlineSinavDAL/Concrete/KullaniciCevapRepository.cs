using OnlineSinavCore.Concrete;
using OnlineSinavCore.Messages;
using OnlineSinavDAL.Abstract;
using OnlineSinavModel;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace OnlineSinavDAL.Concrete
{
   public class KullaniciCevapRepository:EFBaseRepository<OnlineSinavContext, KullaniciCevap>,IKullaniciCevapRepository
    {
        public KullaniciCevapRepository(OnlineSinavContext context):base(context)
        {

        }

       

       
    }
}
