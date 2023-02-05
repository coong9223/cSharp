using System;
using System.Collections.Generic;
using System.Text;
using _1.DAL.DomainClass;
namespace _1.DAL.iRepositories
{
    public interface iSanPhamRepositories
    {
        bool Add(SanPham obj);
        bool Update(SanPham obj);
        bool Delete(SanPham obj);
        SanPham GetById(Guid id);//phương thức tìm sản phẩm theo Id
        List<SanPham> GetAll();
    }
}
