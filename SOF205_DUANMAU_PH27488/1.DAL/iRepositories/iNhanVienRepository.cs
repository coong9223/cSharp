using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1.DAL.DomainClass;

namespace _1.DAL.iRepositories
{
    public interface iNhanVienRepository
    {
        bool Add(NhanVien nv);
        bool Update(NhanVien nv);
        bool Delete(NhanVien nv);
        NhanVien GetById(Guid id);
        List<NhanVien> GetAll();
    }
}
