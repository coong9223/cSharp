using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1.DAL.DomainClass;
using _2.BUS.ViewModels;

namespace _2.BUS.iServices
{
    public interface iKhachHangService
    {
        string Add(KhachHangView obj);
        string Update(KhachHangView obj);
        string Delete(KhachHangView obj);
        List<KhachHangView> GetAllKh();
        List<KhachHangView> GetAllKh(string input);
        KhachHang GetById(Guid id);
        Guid GetIdByName(string ten);
        List<string> GetThanhPho();
        List<string> GetQuocGia();
    }
}
