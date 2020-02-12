using Microsoft.EntityFrameworkCore;
using OnlineSinavCore.Concrete;
using OnlineSinavDAL.Abstract;
using OnlineSinavModel;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace OnlineSinavDAL.Concrete
{
   public class DersRepository:EFBaseRepository<OnlineSinavContext,Ders>,IDersRepository
    {
        public DersRepository(OnlineSinavContext context):base(context)
        {
           
        }

        public ICollection<Ders> DersIcerik(string icerik)
        {
            using (OnlineSinavContext context = new OnlineSinavContext())
            {

                //Lazy<Ders> ders = new Lazy<Ders>();
                return context.Ders.Where(d => d.Icerik == icerik).ToList();
                //return context.Ders.Find(d=>d.)
                // string name = "";
                //var p0 = new SqlParameter("Name", name);
                // //parameter
                //Ders ders = new Ders();
                //var sonucs = context.Database.ExecuteSqlCommand("").ToString();

                //               return;
            }

        }

        public ICollection<Ders> KursDers(int kursId)
        {
            using (OnlineSinavContext context = new OnlineSinavContext())
            {
               return context.Ders.Where(d => d.KursId == kursId).ToList();

            }
        }

       
    }
}
