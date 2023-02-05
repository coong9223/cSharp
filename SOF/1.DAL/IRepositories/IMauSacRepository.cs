using System;
using System.Collections.Generic;
using System.Text;
using _1.DAL.DomainClass;



namespace _1.DAL.IRepositories
{
    public interface IMauSacRepository
    {
        bool Add(MauSac obj);
        bool Update(MauSac obj);
        bool Delete(MauSac obj);
        MauSac GetById(Guid id);
        List<MauSac> GetAll();
    }
}
