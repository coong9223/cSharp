using BAI_1_6_CRUD_EF_DBFIRST.Context;
using BAI_1_6_CRUD_EF_DBFIRST.DomainModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BAI_1_6_CRUD_EF_DBFIRST.Repositories
{
    public class CuaHangRepository
    {
        FpolyDBContext _dbContext;
        public CuaHangRepository()
        {
            _dbContext = new FpolyDBContext();
        }
        public List<CuaHang> GetAll()
        {
            return _dbContext.CuaHangs.ToList();
        }
        public bool Add(CuaHang cuahang)
        {
            if (cuahang == null) return false;
            cuahang.Id = Guid.NewGuid();
            _dbContext.Add(cuahang);
            _dbContext.SaveChanges();
            return true;
        }
        public bool Update(CuaHang cuahang)
        {
            if (cuahang == null) return false;
            _dbContext.Update(cuahang);
            _dbContext.SaveChanges();
            return true;
        }
        public bool Delete(CuaHang cuahang)
        {
            if (cuahang == null) return false;
            _dbContext.Remove(cuahang);
            _dbContext.SaveChanges();
            return true;
        }
    }
}
