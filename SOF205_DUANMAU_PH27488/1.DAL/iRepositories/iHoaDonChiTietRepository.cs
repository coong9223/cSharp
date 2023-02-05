using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1.DAL.DomainClass;

namespace _1.DAL.iRepositories
{
    public interface iHoaDonChiTietRepository
    {
        bool Add(HoaDonChiTiet hdct);
        bool UPdate(HoaDonChiTiet hdct);
        bool Delete(HoaDonChiTiet hdct);
        HoaDonChiTiet GetById(Guid id);
        List<HoaDonChiTiet> GetAll();   
    }
}
