using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1.DAL.DomainClass;
using _2.BUS.ViewModels;

namespace _2.BUS.iServices
{
    public interface iGioHangService
    {
        string Add(GioHangView obj);
        string Update(GioHangView obj);
        string Delete(GioHangView obj);
        List<GioHangView> GetAllGh();
        List<GioHangView> GetAllGh(string input);
        GioHang GetById(Guid id);
        Guid GetIdByName(string ten);
    }
}
