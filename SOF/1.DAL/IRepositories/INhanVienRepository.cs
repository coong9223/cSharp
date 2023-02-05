using System;
using System.Collections.Generic;
using System.Text;
using _1.DAL.DomainClass;


namespace _1.DAL.IRepositories
{
    public interface INhanVienRepository
    {
        bool Add(NhanVien obj);
        bool Update(NhanVien obj);
        bool Delete(NhanVien obj);
        NhanVien Get(Guid id);
        List<NhanVien> GetAll();
    }
}
