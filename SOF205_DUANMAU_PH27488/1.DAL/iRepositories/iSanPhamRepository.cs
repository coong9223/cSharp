using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1.DAL.DomainClass;

namespace _1.DAL.iRepositories
{
    public interface iSanPhamRepository
    {
        bool Add(SanPham sp);
        bool Update(SanPham sp);
        bool Delete(SanPham sp);
        SanPham GetById(Guid id);
        List<SanPham> GetAll();
    }
}
