using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1.DAL.DomainClass;
using _2.BUS.ViewModels;

namespace _2.BUS.iServices
{
    public interface iChucVuService
    {
        string Add(ChucVuView obj);
        string Update(ChucVuView obj);
        string Delete(ChucVuView obj);
        List<ChucVuView> GetAllNv();
        List<ChucVuView> GetAllNv(string input);
        ChucVu GetById(Guid id);
        Guid GetIdByName(string ten);
    }
}
