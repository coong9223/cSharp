using _1.DAL.Context;
using _1.DAL.DomainClass;
using _1.DAL.IRepositories;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;


namespace _1.DAL.Repositories
{
    public class HoaDonCTRepository : IHoaDonCTRepository
    {
        private FpolyDBContext _dbContext;
        public HoaDonCTRepository()
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
            var temp = _dbContext.HoaDonChiTiets.FirstOrDefault(x => x.IdHoaDon == obj.IdHoaDon);
            _dbContext.HoaDonChiTiets.Remove(temp);
            _dbContext.SaveChanges();
            return true;
        }

        public HoaDonChiTiet GetById(Guid id)
        {
            if (id== Guid.Empty) return null;
            return _dbContext.HoaDonChiTiets.FirstOrDefault(x => x.IdHoaDon == id); 
            
        }

        public List<HoaDonChiTiet> GetAll()
        {
            return _dbContext.HoaDonChiTiets.ToList();
        }

        public bool Update(HoaDonChiTiet obj)
        {
            if (obj == null) return false;
            var temp = _dbContext.HoaDonChiTiets.FirstOrDefault(x => x.IdHoaDon == obj.IdHoaDon);
            temp.IdChiTietSp = obj.IdChiTietSp;
            temp.SoLuong = obj.SoLuong;
            temp.DonGia = obj.DonGia;
            _dbContext.HoaDonChiTiets.Update(temp);
            _dbContext.SaveChanges();
            return true;
        }
    }
}
