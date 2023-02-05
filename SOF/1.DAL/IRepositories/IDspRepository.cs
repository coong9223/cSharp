using System;
using System.Collections.Generic;
using System.Text;
using _1.DAL.DomainClass;


namespace _1.DAL.IRepositories
{
    public interface IDspRepository
    {
        bool Add(DongSp obj);
        bool Update(DongSp obj);
        bool Delete(DongSp obj);
        DongSp GetById(Guid id);
        List<DongSp> GetAll();
    }
}
