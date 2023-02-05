using System;
using System.Collections.Generic;
using System.Text;
using bai_1._6_crud_ef.DomainClass;
using bai_1._6_crud_ef.Context;
using System.Linq;

namespace bai_1._6_crud_ef.repositories
{
    public class QLCHRepositories
    {
        private FpolyDBContext _dbContext;

        public QLCHRepositories()
        {
            _dbContext = new FpolyDBContext();
        }

        public List<CuaHang> GetAll()
        {
            return _dbContext.CuaHangs.ToList();
        }

        public bool Add(CuaHang obj)
        {
            if (obj == null) return false;
            obj.Id = Guid.NewGuid();
            _dbContext.Add(obj);
            _dbContext.SaveChanges();
            return true;
        }

        public bool Update(CuaHang obj)
        {
            if (obj == null) return false;
            _dbContext.Update(obj);
            _dbContext.SaveChanges();
            return true;
        }

        public bool Delete(CuaHang obj)
        {
            if (obj == null) return false;
            _dbContext.Remove(obj);
            _dbContext.SaveChanges();
            return true;
        }
    }
}
