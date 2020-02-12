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
   public class BransRepository:EFBaseRepository<OnlineSinavContext,Brans>,IBransRepository
    {

        public BransRepository(OnlineSinavContext context):base(context)
        {

        }

       
    }
}
