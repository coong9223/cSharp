using _1.DAL.Context;
using _1.DAL.DomainClass;
using _1.DAL.IRepositories;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace _1.DAL.Repositories
{
    public class SanPhamRepository : ISanPhamRepository
    {
        private FpolyDBContext _dbContext;
        public SanPhamRepository()
        {
            _dbContext = new FpolyDBContext();
        }
        public bool Add(SanPham obj)
        {
            if (obj == null) return false;
            obj.Id = Guid.NewGuid();//tu dong generate khoa chinh
            _dbContext.SanPhams.Add(obj);
            _dbContext.SaveChanges();
            return true;
        }

        public bool Delete(SanPham obj)
        {
            if (obj == null) return false;
            var tempobj = _dbContext.SanPhams.FirstOrDefault(c => c.Id == obj.Id);
            _dbContext.SanPhams.Remove(tempobj);
            _dbContext.SaveChanges();
            return true;
        }

        public List<SanPham> GetAll()
        {
            return _dbContext.SanPhams.ToList();
        }

        public SanPham GetById(Guid id)
        {
            if (id == Guid.Empty) return null;
            return _dbContext.SanPhams.FirstOrDefault(c => c.Id == id);
        }

        public bool Update(SanPham obj)
        {
            if (obj == null) return false;
            var tempobj = _dbContext.SanPhams.FirstOrDefault(c => c.Id == obj.Id);
            tempobj.Ma = obj.Ma;
            tempobj.Ten = obj.Ten;
            _dbContext.SanPhams.Update(tempobj);
            _dbContext.SaveChanges();
            return true;
        }
    }
}
