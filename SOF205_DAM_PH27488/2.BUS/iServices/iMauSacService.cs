using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1.DAL.DomainClass;
using _2.BUS.ViewModels;

namespace _2.BUS.iServices
{
    public interface iMauSacService
    {
        string Add(MauSacView obj);
        string Update(MauSacView obj);
        string Delete(MauSacView obj);
        List<MauSacView> GetAllMs();
        List<MauSacView> GetAllMs(string input);
        MauSac GetById(Guid id);
        Guid GetIdByName(string ten);
    }
}
