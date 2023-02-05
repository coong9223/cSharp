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
        bool Add(GioHangChiTiet ghct);
        bool Update(GioHangChiTiet ghct);
        bool Delete(GioHangChiTiet ghct);
        GioHangChiTiet GetById(Guid id);
        List<GioHangChiTiet> GetAll();
    }
}
