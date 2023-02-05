using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1.DAL.DomainClass;
using _2.BUS.ViewModels;

namespace _2.BUS.iServices
{
    public interface iNsxService
    {
        string Add(NsxView obj);
        string Update(NsxView obj);
        string Delete(NsxView obj);
        List<NsxView> GetAllNsx();
        List<NsxView> GetAllNsx(string input);
        Nsx GetById(Guid id);
        Guid GetIdByName(string ten);
    }
}
