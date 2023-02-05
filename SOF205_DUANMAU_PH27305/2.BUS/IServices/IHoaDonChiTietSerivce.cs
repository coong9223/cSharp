using _1.DAL.DomainModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.IServices
{
    public interface IHoaDonChiTietSerivce
    {
        string Add(HoaDonChiTiet obj);
        string Update(HoaDonChiTiet obj);
        string Delete(HoaDonChiTiet obj);
        List<HoaDonChiTiet> GetAll();
        List<HoaDonChiTiet> GetAll(string input);
    }
}
