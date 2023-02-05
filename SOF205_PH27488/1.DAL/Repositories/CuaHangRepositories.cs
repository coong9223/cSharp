using System;
using System.Collections.Generic;
using System.Text;
using _1.DAL.DomainClass;
using _1.DAL.iRepositories;
using _1.DAL.Context;
using System.Linq;

namespace _1.DAL.Repositories
{
    public class CuaHangRepositories : iCuaHangRepositories
    {
        FpolyDBContext _dbContext;
        public CuaHangRepositories()
        {
            _dbContext = new FpolyDBContext();
        }
        bool iCuaHangRepositories.Add(CuaHang obj)
        {
            if (obj == null) return false;
            obj.Id = Guid.NewGuid();
            _dbContext.CuaHangs.Add(obj);
            _dbContext.SaveChanges();
            return true;
        }

        bool iCuaHangRepositories.Delete(CuaHang obj)
        {
            if (obj == null) return false;
            var tempobj = _dbContext.CuaHangs.FirstOrDefault(c => c.Id == obj.Id);
            _dbContext.CuaHangs.Remove(tempobj);
            _dbContext.SaveChanges();
            return true;
        }

        List<CuaHang> iCuaHangRepositories.GetAll()
        {
            return _dbContext.CuaHangs.ToList();
        }

        CuaHang iCuaHangRepositories.GetById(Guid id)
        {
            if (id == Guid.Empty) return null;
            return _dbContext.CuaHangs.FirstOrDefault(c => c.Id == id);
        }

        bool iCuaHangRepositories.Update(CuaHang obj)
        {
            if (obj == null) return false;
            var tempobj = _dbContext.CuaHangs.FirstOrDefault(c => c.Id == obj.Id);
            tempobj.Ma = obj.Ma;
            tempobj.Ten = obj.Ten;
            _dbContext.CuaHangs.Add(obj);
            _dbContext.SaveChanges();
            return true;
        }
    }
}
