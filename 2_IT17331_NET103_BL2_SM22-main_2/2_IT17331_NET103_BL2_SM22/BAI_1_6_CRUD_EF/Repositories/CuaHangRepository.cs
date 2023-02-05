using BAI_1_6_CRUD_EF.Context;
using BAI_1_6_CRUD_EF.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BAI_1_6_CRUD_EF.Repositories
{
    public class CuaHangRepository
    {
        private FpolyDBContext _dbContext;

        public CuaHangRepository()
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
