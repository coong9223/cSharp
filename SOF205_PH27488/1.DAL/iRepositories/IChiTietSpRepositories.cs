using System;
using System.Collections.Generic;
using System.Text;
using _1.DAL.DomainClass;

namespace _1.DAL.iRepositories
{
    public interface IChiTietSpRepositories
    {
        bool Add(ChiTietSp obj);
        bool Update(ChiTietSp obj);
        bool Delete(ChiTietSp obj);
        ChiTietSp GetById(Guid id);//phương thức tìm sản phẩm theo Id
        List<ChiTietSp> GetAll();
    }
}
