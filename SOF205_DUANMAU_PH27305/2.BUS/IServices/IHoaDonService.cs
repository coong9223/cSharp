using _1.DAL.DomainModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.IServices
{
    public interface IHoaDonService
    {
        string Add(HoaDon obj);
        string Update(HoaDon obj);
        string Delete(HoaDon obj);
        List<HoaDon> GetAll();
        List<HoaDon> GetAll(string input);
    }
}
