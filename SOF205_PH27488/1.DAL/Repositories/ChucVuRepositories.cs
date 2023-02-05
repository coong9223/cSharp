using System;
using System.Collections.Generic;
using System.Text;
using _1.DAL.DomainClass;
using _1.DAL.iRepositories;
using _1.DAL.Context;
using System.Linq;

namespace _1.DAL.Repositories
{
    public class ChucVuRepositories : iChucVuRepositories
    {
        FpolyDBContext _dbContext;
        public ChucVuRepositories()
        {
            _dbContext = new FpolyDBContext();
        }
        bool iChucVuRepositories.Add(ChucVu obj)
        {
            if (obj == null) return false;
            obj.Id = Guid.NewGuid();
            _dbContext.ChucVus.Add(obj);
            _dbContext.SaveChanges();
            return true;

        }

        bool iChucVuRepositories.Delete(ChucVu obj)
        {
            if (obj == null) return false;
            var tempobj = _dbContext.ChucVus.FirstOrDefault(c => c.Id == obj.Id);
            _dbContext.Remove(tempobj);
            _dbContext.SaveChanges();
            return true;
        }

        List<ChucVu> iChucVuRepositories.GetAll()
        {
            return _dbContext.ChucVus.ToList();
        }

        ChucVu iChucVuRepositories.GetById(Guid id)
        {
            if (id == Guid.Empty) return null;
            return _dbContext.ChucVus.FirstOrDefault(c => c.Id == id);
        }

        bool iChucVuRepositories.Update(ChucVu obj)
        {
            if (obj == null) return false;
            var tempobj = _dbContext.ChucVus.FirstOrDefault(c => c.Id == obj.Id);
            tempobj.Ten = obj.Ten;
            _dbContext.Add(obj);
            _dbContext.SaveChanges();
            return true;
        }
    }
}
