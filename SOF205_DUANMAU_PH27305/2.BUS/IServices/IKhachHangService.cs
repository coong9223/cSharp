using _1.DAL.DomainModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.IServices
{
    public interface IKhachHangService
    {
        string Add(KhachHang obj);
        string Update(KhachHang obj);
        string Delete(KhachHang obj);
        List<KhachHang> GetAll();
        List<KhachHang> GetAll(string input);
        KhachHang GetById(Guid id);
        Guid GetIdByName(string input);
        List<string> TrangThai();
    }
}
