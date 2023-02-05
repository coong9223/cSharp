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
    public class CuaHangRepository : ICuaHangRepository
    {
        private FpolyDBContext _dbContext;
        public CuaHangRepository()
        {
            _dbContext = new FpolyDBContext();
        }
        public bool Add(CuaHang obj)
        {
            if (obj == null) return false;
            _dbContext.CuaHangs.Add(obj);
            _dbContext.SaveChanges();
            return true;
        }

        public bool Delete(CuaHang obj)
        {
            if (obj == null) return false;
            var tempObj = _dbContext.CuaHangs.FirstOrDefault(c => c.Id == obj.Id);
            _dbContext.Remove(tempObj);
            _dbContext.SaveChanges();
            return true;
        }

        public List<CuaHang> GetAll()
        {
            return _dbContext.CuaHangs.ToList();
        }

        public CuaHang GetById(Guid id)
        {
            if (id == Guid.Empty) return null;
            return _dbContext.CuaHangs.FirstOrDefault(c => c.Id == id);
        }

        public bool Update(CuaHang obj)
        {
            if (obj == null) return false;
            var tempObj = _dbContext.CuaHangs.FirstOrDefault(c => c.Id == obj.Id);
            tempObj.Ten = obj.Ten;
            tempObj.DiaChi = obj.DiaChi;
            tempObj.ThanhPho = obj.ThanhPho;
            tempObj.QuocGia = obj.QuocGia;
            _dbContext.Update(tempObj);
            _dbContext.SaveChanges();
            return true;
        }
    }
}
