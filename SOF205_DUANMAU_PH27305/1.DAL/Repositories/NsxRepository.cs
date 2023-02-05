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
    public class NsxRepository : INsxRepository
    {
        private FpolyDBContext _dbContext;
        public NsxRepository()
        {
            _dbContext = new FpolyDBContext();
        }
        public bool Add(Nsx obj)
        {
            if (obj == null) return false;
            _dbContext.Nsxes.Add(obj);
            _dbContext.SaveChanges();
            return true;
        }

        public bool Delete(Nsx obj)
        {
            if (obj == null) return false;
            var tempObj = _dbContext.Nsxes.FirstOrDefault(c => c.Id == obj.Id);
            _dbContext.Remove(tempObj);
            _dbContext.SaveChanges();
            return true;
        }

        public List<Nsx> GetAll()
        {
            return _dbContext.Nsxes.ToList();
        }

        public Nsx GetById(Guid id)
        {
            if (id == Guid.Empty) return null;
            return _dbContext.Nsxes.FirstOrDefault(c => c.Id == id);
        }

        public bool Update(Nsx obj)
        {
            if (obj == null) return false;
            var tempObj = _dbContext.Nsxes.FirstOrDefault(c => c.Id == obj.Id);
            tempObj.Ten = obj.Ten;
            _dbContext.Update(tempObj);
            _dbContext.SaveChanges();
            return true;
        }
    }
}
