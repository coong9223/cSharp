using System;
using System.Collections.Generic;
using System.Text;
using _1.DAL.DomainClass;

namespace _2.BUS.iServices
{
    public interface iSanPhamService
    {
        string Add(SanPham obj);
        string Update(SanPham obj);
        string Delete(SanPham obj);
        List<SanPham> GetAll();
        SanPham GetById(Guid id);
        Guid GetIdFormTen(string ten);
    }
}
