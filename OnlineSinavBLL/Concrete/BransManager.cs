using OnlineSinavBLL.Abstract;
using OnlineSinavDAL.Abstract;
using OnlineSinavModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineSinavBLL.Concrete
{
    public class BransManager : IBransManager
    {
        IBransRepository bransRepository;
        public BransManager(IBransRepository _bransRepository)
        {
            bransRepository = _bransRepository;
        }

        public bool Add(Brans brans)
        {
            var result = bransRepository.Add(brans);
            return result.IsSuccess?true:false;
        }

        public ICollection<Brans> GetAll()
        {
            var result = bransRepository.GetAll();
            return result.Data;
        }

        public ICollection<Brans> GetAllByKurs(int kursId)
        {
            throw new NotImplementedException();
        }

        public Brans GetBrans(int id)
        {
            throw new NotImplementedException();
            //var result = bransRepository.GetBy();
            //return result.Data;
        }

        public bool SoftDelete(int id)
        {
            throw new NotImplementedException();
        }

        public bool Update(Brans brans)
        {
            var result = bransRepository.Update(brans);
            return result.IsSuccess ? true : false;
        }
    }
}
