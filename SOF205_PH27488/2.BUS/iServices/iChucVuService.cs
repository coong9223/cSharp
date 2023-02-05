using System;
using System.Collections.Generic;
using System.Text;
using _2.BUS.ViewModels;
using _1.DAL.DomainClass;

namespace _2.BUS.iServices
{
    public interface iChucVuService
    {
        string Add(ChucVu obj);
        string Update(ChucVu obj);
        string Delete(ChucVu obj);
        List<ChucVu> GetAll();
        ChucVu GetById(Guid id);
        Guid GetIdFormTen(string ten);
    }
}
