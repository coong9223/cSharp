using _1.DAL.DomainModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.IServices
{
    public interface IDongSpService
    {
        string Add(DongSp obj);
        string Update(DongSp obj);
        string Delete(DongSp obj);
        List<DongSp> GetAll();
        List<DongSp> GetAll(string input);
        DongSp GetById(Guid id);
        Guid GetIdFromTen(string ten);
    }
}
