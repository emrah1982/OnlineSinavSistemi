using OnlineSinavCore.Concrete;
using OnlineSinavDAL.Abstract;
using OnlineSinavModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineSinavDAL.Concrete
{
    public  class KullaniciRolRepository:EFBaseRepository<OnlineSinavContext,KullaniciRol>, IKullaniciRolRepository
    {
        public KullaniciRolRepository(OnlineSinavContext context):base(context)
        {

        }
    }
}
