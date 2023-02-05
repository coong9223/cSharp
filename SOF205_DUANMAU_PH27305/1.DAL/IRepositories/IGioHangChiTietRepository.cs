using _1.DAL.DomainModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.IRepositories
{
    public interface IGioHangChiTietRepository
    {
        bool Add(GioHangChiTiet obj);
        bool Update(GioHangChiTiet obj);
        bool Delete(GioHangChiTiet obj);
        List<GioHangChiTiet> GetAll();
        GioHangChiTiet GetById(Guid id);
    }
}
