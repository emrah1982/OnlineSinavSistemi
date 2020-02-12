using OnlineSinavCore.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineSinavModel
{
   public class Base:IData
    {
        public int ID { get; set; }
        public bool IsDeleted { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool IsActive { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        //public DateTime InsertDate { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public DateTime? UpdateDate { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public DateTime? InsertDate { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        //veya
        //public Nullable<DateTime> UpdateDate { get; set; }


    }
}
