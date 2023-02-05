using System;
using System.Collections.Generic;
using System.Text;
using _1.DAL.DomainClass;
using _1.DAL.iRepositories;
using _1.DAL.Context;
using System.Linq;

namespace _1.DAL.Repositories
{
    public class HoaDonCtRepositories : iHoaDonCtRepositories
    {
        FpolyDBContext _dbContext;
        public HoaDonCtRepositories()
        {
            _dbContext = new FpolyDBContext();
        }
        bool iHoaDonCtRepositories.Add(HoaDonChiTiet obj)
        {
            if (obj == null) return false;
            obj.Id = Guid.NewGuid();
            _dbContext.HoaDonChiTiets.Add(obj);
            _dbContext.SaveChanges();
            return true;
        }

        bool iHoaDonCtRepositories.Delete(HoaDonChiTiet obj)
        {
            if (obj == null) return false;
            var tempobj = _dbContext.HoaDonChiTiets.FirstOrDefault(c => c.Id == obj.Id);
            _dbContext.HoaDonChiTiets.Remove(tempobj);
            _dbContext.SaveChanges();
            return true;
        }

        List<HoaDonChiTiet> iHoaDonCtRepositories.GetAll()
        {
            return _dbContext.HoaDonChiTiets.ToList();
        }

        HoaDonChiTiet iHoaDonCtRepositories.GetById(Guid id)
        {
            if (id == Guid.Empty) return null;
            return _dbContext.HoaDonChiTiets.FirstOrDefault(c => c.Id == id);
        }

        bool iHoaDonCtRepositories.Update(HoaDonChiTiet obj)
        {
            if (obj == null) return false;
            var tempobj = _dbContext.HoaDonChiTiets.FirstOrDefault(c => c.Id == obj.Id);
            tempobj.SoLuong = obj.SoLuong;
            tempobj.DonGia = obj.DonGia;
            tempobj.IdHoaDon = obj.IdHoaDon;
            tempobj.IdChiTietSp = obj.IdChiTietSp;
            _dbContext.HoaDonChiTiets.Add(obj);
            _dbContext.SaveChanges();
            return true;
        }
    }
}
