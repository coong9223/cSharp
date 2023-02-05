using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1.DAL.DomainClass;
using _2.BUS.ViewModels;

namespace _2.BUS.iServices
{
    public interface iCuaHangService
    {
        string Add(CuaHangView obj);
        string Update(CuaHangView obj);
        string Delete(CuaHangView obj);
        List<CuaHangView> GetAllCh();
        List<CuaHangView> GetAllCh(string input);
        CuaHang GetById(Guid id);
        Guid GetIdByName(string ten);
    }
}
