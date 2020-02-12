using OnlineSinavBLL.Abstract;
using OnlineSinavDAL.Abstract;
using OnlineSinavModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineSinavBLL.Concrete
{
    public class DersManager : IBaseManager<Ders>
    {
        IDersRepository IdersRepository;
        public DersManager(IDersRepository _IdersRepository)
        {
            IdersRepository = _IdersRepository;
        }

        public bool Add(Ders entitey)
        {
            //var result;
            //if (!string.IsNullOrEmpty(entitey.Baslik) || !string.IsNullOrEmpty(Convert.ToString( entitey.KursID))
            //{
            //     result = IdersRepository.Add(entitey);
        
            //}
            //else
            //{

            //}
            var result = IdersRepository.Add(entitey);
            return result.IsSuccess ? true : false;
        }

        public ICollection<Ders> GetAll()
        {

            throw new NotImplementedException();
        }      

        public Ders Get(int id)
        {
            throw new NotImplementedException();
        }

        public bool SoftDelete(int id)
        {
            throw new NotImplementedException();
        }

        public bool Update(Ders entitey)
        {
            throw new NotImplementedException();
        }

        public ICollection<Ders> GetAllByDers(int DersId)
        {
            throw new NotImplementedException();
        }
    }
}
