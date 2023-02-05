using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1.DAL.Context;
using _1.DAL.DomainClass;
using _1.DAL.iRepositories;

namespace _1.DAL.Repositories
{
    public class NsxRepository:iNsxRepository
    {
        FpolyDBContext dbContext;
        public NsxRepository()
        {
            dbContext = new FpolyDBContext();
        }

        bool iNsxRepository.Add(Nsx obj)
        {
            if (obj == null) return false;
            obj.Id=Guid.NewGuid();
            dbContext.Add(obj); 
            dbContext.SaveChanges();
            return true;
        }

        bool iNsxRepository.Delete(Nsx obj)
        {
            if (obj == null) return false;
            var tempobj=dbContext.Nsxes.FirstOrDefault(c=>c.Id==obj.Id);
            dbContext.Remove(tempobj);
            dbContext.SaveChanges();
            return true;
        }

        List<Nsx> iNsxRepository.GetAllNsx()
        {
            return dbContext.Nsxes.ToList();
        }

        Nsx iNsxRepository.GetById(Guid id)
        {
            return dbContext.Nsxes.FirstOrDefault(c => c.Id == id);
        }

        bool iNsxRepository.Update(Nsx obj)
        {
            if (obj == null) return false;
            var tempobj = dbContext.Nsxes.FirstOrDefault(c => c.Id == obj.Id);
            tempobj.Ma = obj.Ma;
            tempobj.Ten = obj.Ten;
            dbContext.Update(tempobj);
            dbContext.SaveChanges();
            return true;
        }
    }
}
