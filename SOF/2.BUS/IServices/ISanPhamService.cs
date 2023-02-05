using _1.DAL.DomainClass;
using _2.BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace _2.BUS.IServices
{
    public interface ISanPhamService
    {
        string Add(ViewSP obj);
        string Update(ViewSP obj);
        string Delete(ViewSP obj);
        List<ViewSP> GetAll();
        List<ViewSP> GetAll(string input);

        SanPham GetById(Guid id);
        Guid GetIdByName(string name);
    }
}
