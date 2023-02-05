using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1.DAL.DomainClass;

namespace _1.DAL.iRepositories
{
    public interface iChiTietSanPhamRepository
    {
        bool Add(ChiTietSp ctsp);
        bool Update(ChiTietSp ctsp);
        bool Delete(ChiTietSp ctsp);
        ChiTietSp GetById(Guid id);
        List<ChiTietSp> GetAll();
    }
}
