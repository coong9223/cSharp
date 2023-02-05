using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1.DAL.DomainClass;

namespace _1.DAL.iRepositories
{
    public interface iKhachHangRepository
    {
        bool Add(KhachHang kh);
        bool Update(KhachHang kh);
        bool Delete(KhachHang kh);
        List<KhachHang> GetAll();
        KhachHang GetById(Guid id);

    }
}
