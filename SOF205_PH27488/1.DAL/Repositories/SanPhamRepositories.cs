using System;
using System.Collections.Generic;
using System.Text;
using _1.DAL.DomainClass;
using _1.DAL.iRepositories;
using _1.DAL.Context;
using System.Linq;

namespace _1.DAL.Repositories
{
    public class SanPhamRepositories : iSanPhamRepositories
    {
        FpolyDBContext _dbContext;

        public SanPhamRepositories()
        {
            _dbContext = new FpolyDBContext();
        }

        bool iSanPhamRepositories.Add(SanPham obj)
        {
            if (obj == null) return false;
            obj.Id = Guid.NewGuid();
            _dbContext.SanPhams.Add(obj);
            _dbContext.SaveChanges();
            return true;
        }

        bool iSanPhamRepositories.Delete(SanPham obj)
        {
            if (obj == null) return false;
            var tempobj = _dbContext.SanPhams.FirstOrDefault(c => c.Id == obj.Id);
            _dbContext.Remove(tempobj);
            _dbContext.SaveChanges();
            return true;
        }

        List<SanPham> iSanPhamRepositories.GetAll()
        {
            return _dbContext.SanPhams.ToList();
        }

        SanPham iSanPhamRepositories.GetById(Guid id)
        {
            if (id == Guid.Empty) return null;
            return _dbContext.SanPhams.FirstOrDefault(c => c.Id == id);
        }

        bool iSanPhamRepositories.Update(SanPham obj)
        {
            if (obj == null) return false;
            var tempobj = _dbContext.SanPhams.FirstOrDefault(c => c.Id == obj.Id);
            tempobj.Ten = obj.Ten;
            _dbContext.Update(tempobj);
            _dbContext.SaveChanges();
            return true;
        }
    }
}
