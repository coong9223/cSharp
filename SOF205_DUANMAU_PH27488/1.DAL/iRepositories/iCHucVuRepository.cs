using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1.DAL.DomainClass;

namespace _1.DAL.iRepositories
{
    public interface iCHucVuRepository
    {
        bool Add(ChucVu cv);
        bool Update(ChucVu cv);
        bool Delete(ChucVu cv);
        ChucVu GetById(Guid id);
        List<ChucVu> GetAll();  
    }
}
