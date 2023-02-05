using _1.DAL.Context;
using _1.DAL.DomainClass;
using _1.DAL.IRepositories;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace _1.DAL.Repositories
{
    public class DspRepository : IDspRepository
    {
        private FpolyDBContext _dbContext;
        public DspRepository()
        {
            _dbContext = new FpolyDBContext();
        }
        public bool Add(DongSp obj)
        {
            if (obj == null) return false;
            obj.Id = Guid.NewGuid();
            _dbContext.DongSps.Add(obj);
            _dbContext.SaveChanges();
            return true;
        }

        public bool Delete(DongSp obj)
        {
            if (obj == null) return false;
            var temp = _dbContext.DongSps.FirstOrDefault(x => x.Id == obj.Id);
            _dbContext.Remove(temp);
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
            return _dbContext.DongSps.FirstOrDefault(x=>x.Id== id);
        }

        public bool Update(DongSp obj)
        {

            if (obj == null) return false;
            var temp = _dbContext.DongSps.FirstOrDefault(x => x.Id == obj.Id);
            temp.Ten = obj.Ten;
            temp.Ma = obj.Ma;
            _dbContext.DongSps.Update(temp);
            _dbContext.SaveChanges();
            return true;
        }
    }
}
