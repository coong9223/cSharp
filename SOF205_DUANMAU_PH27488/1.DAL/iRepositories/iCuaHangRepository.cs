using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1.DAL.DomainClass;

namespace _1.DAL.iRepositories
{
    public interface iCuaHangRepository
    {
        bool Add(CuaHang ch);
        bool Update(CuaHang ch);
        bool Delete(CuaHang ch);
        CuaHang GetById(Guid id);
        List<CuaHang> GetAll(); 
    }
}
