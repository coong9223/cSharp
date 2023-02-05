using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1.DAL.DomainClass;
using _2.BUS.ViewModels;

namespace _2.BUS.iServices
{
    public interface iHoaDonService
    {
        string Add(HoaDonView obj);
        string Update(HoaDonView obj);
        string Delete(HoaDonView obj);
        List<HoaDonView> GetAllHd();
        List<HoaDonView> GetAllHd(string input);
        HoaDon GetById(Guid id);
        Guid GetIdByName(string ten);
    }
}
