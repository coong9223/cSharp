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
    public class ChiTietSpRepository : IChiTietSpRepository
    {
        private FpolyDBContext _dbContext;
        public ChiTietSpRepository()
        {
            _dbContext = new FpolyDBContext();
        }
        public bool Add(ChiTietSp obj)
        {
            if (obj == null) return false;
            _dbContext.ChiTietSps.Add(obj);
            _dbContext.SaveChanges();
            return true;
        }

        public bool Delete(ChiTietSp obj)
        {
            if (obj == null) return false;
            var tempObj = _dbContext.ChiTietSps.FirstOrDefault(c => c.Id == obj.Id);
            _dbContext.Remove(tempObj);
            _dbContext.SaveChanges();
            return true;
        }

        public List<ChiTietSp> GetAll()
        {
            return _dbContext.ChiTietSps.ToList();
        }

        public ChiTietSp GetById(Guid id)
        {
            if (id == Guid.Empty) return null;
            return _dbContext.ChiTietSps.FirstOrDefault(c => c.Id == id);
        }

        public bool Update(ChiTietSp obj)
        {
            if (obj == null) return false;
            var tempObj = _dbContext.ChiTietSps.FirstOrDefault(c => c.Id == obj.Id);
            tempObj.IdSp = obj.IdSp;
            tempObj.IdNsx = obj.IdNsx;
            tempObj.IdMauSac = obj.IdMauSac;
            tempObj.IdDongSp = obj.IdDongSp;
            tempObj.NamBh = obj.NamBh;
            tempObj.MoTa = obj.MoTa;
            tempObj.SoLuongTon = obj.SoLuongTon;
            tempObj.GiaBan = obj.GiaBan;
            tempObj.GiaNhap = obj.GiaNhap;
            _dbContext.Update(tempObj);
            _dbContext.SaveChanges();
            return true;
        }
    }
}
