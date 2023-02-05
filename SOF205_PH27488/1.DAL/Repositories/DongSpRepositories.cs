using System;
using System.Collections.Generic;
using System.Text;
using _1.DAL.DomainClass;
using _1.DAL.iRepositories;
using _1.DAL.Context;
using System.Linq;

namespace _1.DAL.Repositories
{
    public class DongSpRepositories : iDongSpRepositories
    {
        FpolyDBContext _dbContext;
        public DongSpRepositories()
        {
            _dbContext = new FpolyDBContext();
        }
        bool iDongSpRepositories.Add(DongSp obj)
        {
            if (obj == null) return false;
            obj.Id = Guid.NewGuid();
            _dbContext.DongSps.Add(obj);
            _dbContext.SaveChanges();
            return true;
        }

        bool iDongSpRepositories.Delete(DongSp obj)
        {
            if (obj == null) return false;
            var tempobj = _dbContext.DongSps.FirstOrDefault(c => c.Id == obj.Id);
            _dbContext.Remove(tempobj);
            _dbContext.SaveChanges();
            return true;
        }

        List<DongSp> iDongSpRepositories.GetAll()
        {
            return _dbContext.DongSps.ToList();
        }

        DongSp iDongSpRepositories.GetById(Guid id)
        {
            if (id == Guid.Empty) return null;
            return _dbContext.DongSps.FirstOrDefault(c => c.Id == id);
        }

        bool iDongSpRepositories.Update(DongSp obj)
        {
            if (obj == null) return false;
            var tempobj = _dbContext.DongSps.FirstOrDefault(c => c.Id == obj.Id);
            tempobj.Ten = obj.Ten;
            _dbContext.Update(tempobj);
            _dbContext.SaveChanges();
            return true;
        }
    }
}
