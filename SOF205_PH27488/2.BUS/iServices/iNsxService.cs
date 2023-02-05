using System;
using System.Collections.Generic;
using System.Text;
using _2.BUS.ViewModels;
using _1.DAL.DomainClass;

namespace _2.BUS.iServices
{
    public interface iNsxService
    {
        string Add(Nsx obj);
        string Update(Nsx obj);
        string Delete(Nsx obj);
        List<Nsx> GetAll();
        Nsx GetById(Guid id);
        Guid GetIdFormTen(string ten);
    }
}
