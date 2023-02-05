using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1.DAL.DomainClass;

namespace _1.DAL.iRepositories
{
    public interface iGioHangRepository
    {
        bool Add(GioHang gh);
        bool UPdate(GioHang gh);
        bool Delete(GioHang gh);
        GioHang GetById(Guid id);
        List<GioHang> GetAll();
    }
}
