using _1.DAL.DomainModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.IServices
{
    public interface IMauSacService
    {
        string Add(MauSac obj);
        string Update(MauSac obj);
        string Delete(MauSac obj);
        List<MauSac> GetAll();
        List<MauSac> GetAll(string input);
        MauSac GetById(Guid id);
        Guid GetIdFromTen(string ten);
    }
}
