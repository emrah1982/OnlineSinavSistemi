using OnlineSinavCore.Concrete;
using OnlineSinavDAL.Abstract;
using OnlineSinavModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineSinavDAL.Concrete
{
   public class KullaniciKursRepository:EFBaseRepository<OnlineSinavContext,KullaniciKurs>,IKullaniciKursRepository
    {
        public KullaniciKursRepository(OnlineSinavContext context) : base(context)
        {

        }
    }
}
