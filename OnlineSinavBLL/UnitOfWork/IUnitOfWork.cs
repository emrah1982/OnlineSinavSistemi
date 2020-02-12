
using OnlineSinavBLL.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineSinavBLL.UnitOfWork
{
   public interface IUnitOfWork:IDisposable
    {
        //Interface oldugu için interface den cagırıyoruz
        IBransManager Brans { get; }
        IDersManager Ders { get; }
        IKullaniciCevapManager KullaniciCevap { get; }
        IKullaniciKursManager KullaniciKurs { get; }

    }
}
