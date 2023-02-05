using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1.DAL.DomainClass;

namespace _1.DAL.iRepositories
{
    public interface iHoaDonRepository
    {
        bool Add(HoaDon hd);
        bool Update(HoaDon hd);
        bool Delete(HoaDon hd);
        HoaDon getById(Guid id);
        List<HoaDon> GetAll();
    }
}
