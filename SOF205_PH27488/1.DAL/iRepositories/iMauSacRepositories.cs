using System;
using System.Collections.Generic;
using System.Text;
using _1.DAL.DomainClass;

namespace _1.DAL.iRepositories
{
    public interface iMauSacRepositories
    {
        bool Add(MauSac obj);
        bool Update(MauSac obj);
        bool Delete(MauSac obj);
        MauSac GetById(Guid id);//phương thức tìm sản phẩm theo Id
        List<MauSac> GetAll();
    }
}
