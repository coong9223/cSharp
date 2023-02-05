using System;
using System.Collections.Generic;
using System.Text;
using _1.DAL.DomainClass;


namespace _1.DAL.IRepositories
{
    public interface IHoaDonRepository
    {
        bool Add(HoaDon obj);
        bool Update(HoaDon obj);
        bool Delete(HoaDon obj);
        HoaDon GetById(Guid id);
        List<HoaDon> GetAll();
    }
}
