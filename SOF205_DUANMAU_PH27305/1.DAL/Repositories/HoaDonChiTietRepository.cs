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
    public class HoaDonChiTietRepository : IHoaDonChiTietRepository
    {
        private FpolyDBContext _dbContext;
        public HoaDonChiTietRepository()
        {
            _dbContext = new FpolyDBContext();
        }
        public bool Add(HoaDonChiTiet obj)
        {
            if (obj == null) return false;
            _dbContext.HoaDonChiTiets.Add(obj);
            _dbContext.SaveChanges();
            return true;
        }

        public bool Delete(HoaDonChiTiet obj)
        {
            if (obj == null) return false;
            var tempObj = _dbContext.HoaDonChiTiets.FirstOrDefault(c => c.IdHoaDon == obj.IdHoaDon);
            _dbContext.Remove(tempObj);
            _dbContext.SaveChanges();
            return true;
        }

        public List<HoaDonChiTiet> GetAll()
        {
            return _dbContext.HoaDonChiTiets.ToList();
        }

        public HoaDonChiTiet GetById(Guid id)
        {
            if (id == Guid.Empty) return null;
            return _dbContext.HoaDonChiTiets.FirstOrDefault(c => c.IdHoaDon == id);
        }

        public bool Update(HoaDonChiTiet obj)
        {
            if (obj == null) return false;
            var tempObj = _dbContext.HoaDonChiTiets.FirstOrDefault(c => c.IdHoaDon == obj.IdHoaDon);
            tempObj.IdChiTietSp = obj.IdChiTietSp;
            tempObj.SoLuong = obj.SoLuong;
            tempObj.DonGia = obj.DonGia;
            _dbContext.Update(tempObj);
            _dbContext.SaveChanges();
            return true;
        }
    }
}
