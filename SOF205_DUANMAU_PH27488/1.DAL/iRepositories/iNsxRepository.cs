using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1.DAL.DomainClass;

namespace _1.DAL.iRepositories
{
    public interface iNsxRepository
    {
        bool Add(Nsx nsx);
        bool Update(Nsx nsx);
        bool Delete(Nsx nsx);
        Nsx GetById(Guid id);
        List<Nsx> GetAll(); 
    }
}
