using System;
using System.Collections.Generic;
using System.Text;
using lab1234_ChucVu.Context;
using lab1234_ChucVu.DomainClass;
using System.Linq;

namespace lab1234_ChucVu.repositories
{
    public class CVRepositories
    {
        private FpolyDBContext _dbContext;
        public CVRepositories()
        {
            _dbContext = new FpolyDBContext();
        }
        public List<ChucVu> GetAll()
        {
            return _dbContext.ChucVus.ToList();
        }
        public bool Add(ChucVu obj)
        {
            if (obj == null) return false;
            obj.Id = Guid.NewGuid();
            _dbContext.ChucVus.Add(obj);
            _dbContext.SaveChanges();
            return true;
        }
        public bool Update(ChucVu obj)
        {
            if(obj == null) return false;
            _dbContext.Update(obj);
            _dbContext.SaveChanges();
            return true;
        }
        public bool Delete(ChucVu obj)
        {
            if (obj == null) return false;
            _dbContext.Remove(obj);
            _dbContext.SaveChanges();
            return true;
        }
        public bool Clear(ChucVu obj)
        {
            if (obj == null) return false;
            _dbContext.RemoveAll(obj);
            _dbContext.SaveChanges();
            return true;
        }
    }
}
