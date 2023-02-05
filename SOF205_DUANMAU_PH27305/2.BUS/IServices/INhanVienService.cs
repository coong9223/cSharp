using _1.DAL.DomainModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.IServices
{
    public interface INhanVienService
    {
        string Add(NhanVien obj);
        string Update(NhanVien obj);
        string Delete(NhanVien obj);
        List<NhanVien> GetAll();
        List<NhanVien> GetAll(string input);
    }
}
