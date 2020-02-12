using OnlineSinavBLL.Abstract;
using OnlineSinavDAL.Abstract;
using OnlineSinavModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineSinavBLL.Concrete
{
    public class KullaniciCevapManager : IBaseManager<KullaniciCevap>
    {
        IKullaniciCevapRepository kullaniciCevapRepository;
        public KullaniciCevapManager(IKullaniciCevapRepository _kullaniciCevapRepository)
        {
            kullaniciCevapRepository = _kullaniciCevapRepository;
        }
        public bool Add(KullaniciCevap entitey)
        {
            throw new NotImplementedException();
        }

        public KullaniciCevap Get(int id)
        {
            throw new NotImplementedException();
        }

        public ICollection<KullaniciCevap> GetAll()
        {
            throw new NotImplementedException();
        }

        public bool SoftDelete(int id)
        {
            throw new NotImplementedException();
        }

        public bool Update(KullaniciCevap entitey)
        {
            throw new NotImplementedException();
        }
    }
}
