using System;
using System.Collections.Generic;
using System.Text;
using _1.DAL.DomainClass;

namespace _1.DAL.iRepositories
{
    public interface iCuaHangRepositories
    {
        bool Add(CuaHang obj);
        bool Update(CuaHang obj);
        bool Delete(CuaHang obj);
        CuaHang GetById(Guid id);//phương thức tìm sản phẩm theo Id
        List<CuaHang> GetAll();
    }
}
