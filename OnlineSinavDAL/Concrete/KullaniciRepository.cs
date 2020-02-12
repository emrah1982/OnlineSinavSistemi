using OnlineSinavCore.Concrete;
using OnlineSinavDAL.Abstract;
using OnlineSinavModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineSinavDAL.Concrete
{
    public class KullaniciRepository : EFBaseRepository<OnlineSinavContext, Kullanici>, IKullaniciRepository
    {
        public KullaniciRepository(OnlineSinavContext context) : base(context)
        {

        }
    }
}
