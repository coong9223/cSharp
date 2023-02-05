using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1.DAL.DomainClass;
using _2.BUS.ViewModels;

namespace _2.BUS.iServices
{
    public interface iDspService
    {
        string Add(DongSpView obj);
        string Update(DongSpView obj);
        string Delete(DongSpView obj);
        List<DongSpView> GetAllDsp();
        List<DongSpView> GetAllDsp(string input);
        DongSp GetById(Guid id);
        Guid GetIdByName(string ten);       
    }
}
