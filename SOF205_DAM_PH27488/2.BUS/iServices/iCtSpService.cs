using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1.DAL.DomainClass;
using _2.BUS.ViewModels;

namespace _2.BUS.iServices
{
    public interface iCtSpService
    {
        string Add(CtSpView obj);
        string Update(CtSpView obj);
        string Delete(CtSpView obj);
        List<CtSpView> GetAllCtSp();
        List<CtSpView> GetAllCtSp(string input);
        ChiTietSp GetById(Guid id);
        Guid GetIdByName(string ten);
    }
}
