using System;
using System.Collections.Generic;
using System.Text;
using _1.DAL.DomainClass;

namespace _1.DAL.iRepositories
{
    public interface iDongSpRepositories
    {
        bool Add(DongSp obj);
        bool Update(DongSp obj);
        bool Delete(DongSp obj);
        DongSp GetById(Guid id);//phương thức tìm sản phẩm theo Id
        List<DongSp> GetAll();
    }
}
