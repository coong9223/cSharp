using System;
using System.Collections.Generic;
using System.Text;
using _1.DAL.iRepositories;
using _1.DAL.Repositories;
using _1.DAL.DomainClass;

namespace _2.BUS.iServices
{
    public interface iMauSacService
    {
        public string Add(MauSac obj);
        public string Update(MauSac obj);
        public string Delete(MauSac obj);
        List<MauSac> GetAll();
        MauSac GetById(Guid id);
        Guid GetIdFormTen(string ten);
    }
}
