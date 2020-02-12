using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineSinavBLL.Abstract
{
   public interface IBaseManager<TEntitey>
    {
        
        //ICollection<TEntitey> GetAllByKurs(int KursId);
        ICollection<TEntitey> GetAll();
        bool Add(TEntitey entitey);
        bool Update(TEntitey entitey);
        bool SoftDelete(int id);
        TEntitey Get(int id);
    }
}
