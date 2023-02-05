using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _2.BUS.ViewModels;
using _1.DAL.DomainClass;

namespace _2.BUS.iServices
{
    public interface iNsxService
    {
        string Add(NsxView nsx);
        string Update(NsxView nsx);
        string Delete(NsxView nsx);
        List<NsxView> GetData();
        Nsx GetById(Guid id);
    }
}
