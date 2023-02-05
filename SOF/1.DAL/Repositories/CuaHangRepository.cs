using _1.DAL.Context;
using _1.DAL.DomainClass;
using _1.DAL.IRepositories;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;


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
            obj.Id = Guid.NewGuid();
            _dbContext.CuaHangs.Add(obj);
            _dbContext.SaveChanges();
            return true;
        }

        public bool Delete(CuaHang obj)
        {
            if (obj == null) return false;
            var temp = _dbContext.CuaHangs.FirstOrDefault(x => x.Id == obj.Id);
            _dbContext.CuaHangs.Remove(obj);
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
            return _dbContext.CuaHangs.FirstOrDefault(x => x.Id == id);
        }

        public bool Update(CuaHang obj)
        {
            if (obj == null) return false;
            var temp = _dbContext.CuaHangs.FirstOrDefault(x=> x.Id == obj.Id);
            temp.Ma = obj.Ma;
            temp.Ten = obj.Ten;
            temp.DiaChi = obj.DiaChi;
            temp.ThanhPho = obj.ThanhPho;
            temp.QuocGia = obj.QuocGia;

            _dbContext.CuaHangs.Update(temp);
            _dbContext.SaveChanges();
            return true;

            
        }
    }
}
