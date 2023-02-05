using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1.DAL.DomainClass;

namespace _1.DAL.iRepositories
{
    public interface iGioHangChiTietRepository
    {
        bool Add(GioHangChiTiet obj);
        bool Update(GioHangChiTiet obj);
        bool Delete(GioHangChiTiet obj);
        GioHangChiTiet GetById(Guid id);
        List<GioHangChiTiet> GetAllGioHangCt();
    }
}
