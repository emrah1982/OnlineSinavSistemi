using OnlineSinavModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineSinavBLL.Abstract
{
   public interface IBransManager 
    {
        ICollection<Brans> GetAllByKurs(int kursId);
        ICollection<Brans> GetAll();

        bool Add(Brans brans);
        bool Update(Brans brans);
        bool SoftDelete(int id);
        Brans GetBrans(int id);
    }
}
