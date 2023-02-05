using System;
using System.Collections.Generic;
using System.Text;
using _1.DAL.DomainClass;

namespace _1.DAL.iRepositories
{
    public interface iHoaDonRepositories
    {
        bool Add(HoaDon obj);
        bool Update(HoaDon obj);
        bool Delete(HoaDon obj);
        HoaDon GetById(Guid id);//phương thức tìm sản phẩm theo Id
        List<HoaDon> GetAll();
    }
}
