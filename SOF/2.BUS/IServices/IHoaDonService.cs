using _1.DAL.DomainClass;
using _2.BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace _2.BUS.IServices
{
    public interface IHoaDonService
    {
        string Add(HoaDonView obj);
        string Update(HoaDonView obj);
        string Delete(HoaDonView obj);
        List<HoaDonView> GetAll();
        List<HoaDonView> GetAll(string hd);
        List<string> TrangThai();
        HoaDon GetById(Guid id);
        Guid GetIdByMa(string ma);
    }
}
