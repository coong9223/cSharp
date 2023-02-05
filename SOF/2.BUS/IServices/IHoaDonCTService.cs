using _2.BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace _2.BUS.IServices
{
    public interface IHoaDonCTService
    {
        string Add(HoaDonChiTietView obj);
        string Update(HoaDonChiTietView obj);
        string Delete(HoaDonChiTietView obj);
        List<HoaDonChiTietView> GetAll();
        List<HoaDonChiTietView> GetAll(string hdct);
    }
}
