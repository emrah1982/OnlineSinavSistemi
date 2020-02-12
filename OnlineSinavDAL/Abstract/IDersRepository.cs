using OnlineSinavCore.Abstract;
using OnlineSinavModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineSinavDAL.Abstract
{
    public interface IDersRepository:IRepository<Ders>
    {
        ICollection<Ders> KursDers(int kursId);
        ICollection<Ders> DersIcerik(string icerik);
    }
}
