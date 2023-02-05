using System;
using System.Collections.Generic;
using System.Text;
using _1.DAL.DomainClass;

namespace _1.DAL.iRepositories
{
    public interface iHoaDonCtRepositories
    {
        bool Add(HoaDonChiTiet obj);
        bool Update(HoaDonChiTiet obj);
        bool Delete(HoaDonChiTiet obj);
        HoaDonChiTiet GetById(Guid id);//phương thức tìm sản phẩm theo Id
        List<HoaDonChiTiet> GetAll();
    }
}
