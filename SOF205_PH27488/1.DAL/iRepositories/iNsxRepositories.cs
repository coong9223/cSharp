using System;
using System.Collections.Generic;
using System.Text;
using _1.DAL.DomainClass;
namespace _1.DAL.iRepositories
{
    public interface iNsxRepositories
    {
        bool Add(Nsx obj);
        bool Update(Nsx obj);
        bool Delete(Nsx obj);
        Nsx GetById(Guid id);//phương thức tìm sản phẩm theo Id
        List<Nsx> GetAll();
    }
}
