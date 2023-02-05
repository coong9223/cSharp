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
            _dbContext.SanPhams.Add(obj);
            _dbContext.SaveChanges();
            return true;
        }

        public bool Delete(SanPham obj)
        {
            if (obj == null) return false;
            var tempObj = _dbContext.SanPhams.FirstOrDefault(c => c.Id == obj.Id);
            _dbContext.Remove(tempObj);
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
            var tempObj = _dbContext.SanPhams.FirstOrDefault(c => c.Id == obj.Id);
            tempObj.Ten = obj.Ten;
            _dbContext.Update(tempObj);
            _dbContext.SaveChanges();
            return true;
        }
    }
}
