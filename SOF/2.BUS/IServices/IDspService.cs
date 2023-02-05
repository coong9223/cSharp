using _1.DAL.DomainClass;
using _2.BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace _2.BUS.IServices
{
    public interface IDspService
    {
        string Add(DspView obj);
        string Update(DspView obj);
        string Delete(DspView obj);
        List<DspView> GetAll();
        List<DspView> GetAll(string input);
        DongSp GetById(Guid id);
        Guid GetIdByName(string name);
    }
}
