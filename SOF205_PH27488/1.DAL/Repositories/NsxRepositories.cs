using System;
using System.Collections.Generic;
using System.Text;
using _1.DAL.DomainClass;
using _1.DAL.iRepositories;
using _1.DAL.Context;
using System.Linq;


namespace _1.DAL.Repositories
{
    public class NsxRepositories : iNsxRepositories
    {
        FpolyDBContext _dbContext;
        public NsxRepositories()
        {
            _dbContext = new FpolyDBContext();
        }
        bool iNsxRepositories.Add(Nsx obj)
        {
            if (obj == null) return false;
            obj.Id = Guid.NewGuid();
            _dbContext.Nsxes.Add(obj);
            _dbContext.SaveChanges();
            return true;
        }

        bool iNsxRepositories.Delete(Nsx obj)
        {
            if (obj == null) return false;
            var tempobj = _dbContext.Nsxes.FirstOrDefault(c => c.Id == obj.Id);
            _dbContext.Remove(tempobj);
            _dbContext.SaveChanges();
            return true;
        }

        List<Nsx> iNsxRepositories.GetAll()
        {
            return _dbContext.Nsxes.ToList();
        }

        Nsx iNsxRepositories.GetById(Guid id)
        {
            if (id == Guid.Empty) return null;
            return _dbContext.Nsxes.FirstOrDefault(c => c.Id == id);
        }

        bool iNsxRepositories.Update(Nsx obj)
        {
            if (obj == null) return false;
            var tempobj = _dbContext.Nsxes.FirstOrDefault(c => c.Id == obj.Id);
            tempobj.Ten = obj.Ten;
            _dbContext.Update(tempobj);
            _dbContext.SaveChanges();
            return true;
        }
    }
}
