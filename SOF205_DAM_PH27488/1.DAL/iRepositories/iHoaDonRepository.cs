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
        bool Add(HoaDon obj);
        bool Update(HoaDon obj);   
        bool Delete(HoaDon obj);  
        HoaDon GetById(Guid id);
        List<HoaDon> GetAllHoaDon();
    }
}
