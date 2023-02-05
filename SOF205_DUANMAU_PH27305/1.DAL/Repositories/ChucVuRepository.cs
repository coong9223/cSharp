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
    public class ChucVuRepository : IChucVuRepository
    {
        private FpolyDBContext _dbContext;
        public ChucVuRepository()
        {
            _dbContext = new FpolyDBContext();
        }
        public bool Add(ChucVu obj)
        {
            if (obj == null) return false;
            _dbContext.ChucVus.Add(obj);
            _dbContext.SaveChanges();
            return true;
        }

        public bool Delete(ChucVu obj)
        {
            if (obj == null) return false;
            var tempObj = _dbContext.ChucVus.FirstOrDefault(c => c.Id == obj.Id);
            _dbContext.Remove(tempObj);
            _dbContext.SaveChanges();
            return true;
        }

        public List<ChucVu> GetAll()
        {
            return _dbContext.ChucVus.ToList();
        }

        public ChucVu GetById(Guid id)
        {
            if (id == Guid.Empty) return null;
            return _dbContext.ChucVus.FirstOrDefault(c => c.Id == id);
        }

        public bool Update(ChucVu obj)
        {
            if (obj == null) return false;
            var tempObj = _dbContext.ChucVus.FirstOrDefault(c => c.Id == obj.Id);
            tempObj.Ten = obj.Ten;
            _dbContext.Update(tempObj);
            _dbContext.SaveChanges();
            return true;
        }
    }
}
