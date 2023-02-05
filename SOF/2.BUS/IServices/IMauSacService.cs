using _1.DAL.DomainClass;
using _2.BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace _2.BUS.IServices
{
    public interface IMauSacService
    {
        string Add(MauSacView obj);
        string Update(MauSacView obj);
        string Delete(MauSacView obj);
        List<MauSacView> GetAll();
        List<MauSacView> GetAll(string input);

        MauSac GetById(Guid id);
        Guid GetIdByName(string name);
    }
}
