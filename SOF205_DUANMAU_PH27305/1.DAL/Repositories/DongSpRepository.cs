using _1.DAL.Context;
using _1.DAL.DomainModels;
using _1.DAL.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.Repositories
{
    public class DongSpRepository : IDongSpRepository
    {
        private FpolyDBContext _dbContext;
        public DongSpRepository()
        {
            _dbContext = new FpolyDBContext();
        }
        public bool Add(DongSp obj)
        {
            if (obj == null) return false;
            _dbContext.DongSps.Add(obj);
            _dbContext.SaveChanges();
            return true;
        }

        public bool Delete(DongSp obj)
        {
            if (obj == null) return false;
            var tempObj = _dbContext.DongSps.FirstOrDefault(c => c.Id == obj.Id);
            _dbContext.Remove(tempObj);
            _dbContext.SaveChanges();
            return true;
        }

        public List<DongSp> GetAll()
        {
            return _dbContext.DongSps.ToList();
        }

        public DongSp GetById(Guid id)
        {
            if (id == Guid.Empty) return null;
            return _dbContext.DongSps.FirstOrDefault(c => c.Id == id);
        }

        public bool Update(DongSp obj)
        {
            if (obj == null) return false;
            var tempObj = _dbContext.DongSps.FirstOrDefault(c => c.Id == obj.Id);
            tempObj.Ten = obj.Ten;
            _dbContext.Update(tempObj);
            _dbContext.SaveChanges();
            return true;
        }
    }
}
