using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineSinavCore.Abstract
{
    public interface IData
    {
        bool IsDeleted { get; set; }
        bool IsActive { get; set; }
        DateTime? InsertDate { get; set; }
        DateTime? UpdateDate { get; set; }
    }
}
