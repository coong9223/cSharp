using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1.DAL.DomainClass;
using _2.BUS.ViewModels;

namespace _2.BUS.iServices
{
    public interface iNhanVienService
    {
        string Add(NhanVienView obj);
        string Update(NhanVienView obj);
        string Delete(NhanVienView obj);
        List<NhanVienView> GetAllNv();
        List<NhanVienView> GetAllNv(string input);
        List<string> GetCh();
        List<string> GetCv();
        NhanVien GetById(Guid id);
        Guid GetIdByName(string ten);
    }
}
