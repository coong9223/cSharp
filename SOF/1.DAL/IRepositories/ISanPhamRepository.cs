using System;
using System.Collections.Generic;
using System.Text;
using _1.DAL.DomainClass;


namespace _1.DAL.IRepositories
{
    public interface ISanPhamRepository
    {
        bool Add(SanPham obj);
        bool Update(SanPham obj);
        bool Delete(SanPham obj);
        SanPham GetById(Guid id);
        List<SanPham> GetAll();
    }
}
