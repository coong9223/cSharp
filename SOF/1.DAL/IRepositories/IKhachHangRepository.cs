using System;
using System.Collections.Generic;
using System.Text;
using _1.DAL.DomainClass;


namespace _1.DAL.IRepositories
{
    public interface IKhachHangRepository
    {
        bool Add(KhachHang obj);
        bool Update(KhachHang obj);
        bool Delete(KhachHang obj);
        KhachHang Get(Guid id);
        List<KhachHang> GetAll();
    }
}
