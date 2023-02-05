using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1.DAL.DomainClass;
using _2.BUS.ViewModels;

namespace _2.BUS.iServices
{
    public interface iSanPhamService
    {
        string Add(SanPhamView obj);
        string Update(SanPhamView obj);
        string Delete(SanPhamView obj);
        List<SanPhamView> GetAllSp();
        List<SanPhamView> GetAllSp(string input);
        SanPham GetById(Guid id);
        Guid GetIdByName(string ten);
    }
}
