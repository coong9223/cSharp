using System;
using System.Collections.Generic;
using System.Text;
using _1.DAL.DomainClass;
using _1.DAL.iRepositories;
using _1.DAL.Context;
using System.Linq;

namespace _1.DAL.Repositories
{
    public class HoaDonRepositories : iHoaDonRepositories
    {
        FpolyDBContext _dbContext;
        public HoaDonRepositories()
        {
            _dbContext = new FpolyDBContext();  
        }
        bool iHoaDonRepositories.Add(HoaDon obj)
        {
            if (obj == null) return false;
            obj.Id = Guid.NewGuid();
            _dbContext.HoaDons.Add(obj);
            _dbContext.SaveChanges();
            return true;
        }

        bool iHoaDonRepositories.Delete(HoaDon obj)
        {
            if (obj == null) return false;
            var tempobj = _dbContext.HoaDons.FirstOrDefault(c => c.Id == obj.Id);
            _dbContext.HoaDons.Remove(tempobj);
            _dbContext.SaveChanges();
            return true;
        }

        List<HoaDon> iHoaDonRepositories.GetAll()
        {
            return _dbContext.HoaDons.ToList();
        }

        HoaDon iHoaDonRepositories.GetById(Guid id)
        {
            if (id == Guid.Empty) return null;
            return _dbContext.HoaDons.FirstOrDefault(c => c.Id == id);
        }

        bool iHoaDonRepositories.Update(HoaDon obj)
        {
            if (obj == null) return false;
            var tempobj = _dbContext.HoaDons.FirstOrDefault(c => c.Id == obj.Id);
            tempobj.Ma = obj.Ma;
            tempobj.NgayTao = obj.NgayTao;
            tempobj.NgayThanhToan = obj.NgayThanhToan;
            tempobj.NgayShip = obj.NgayShip;
            tempobj.NgayNhan = obj.NgayNhan;
            tempobj.TinhTrang = obj.TinhTrang;
            tempobj.TenNguoiNhan = obj.TenNguoiNhan;
            tempobj.DiaChi = obj.DiaChi;
            tempobj.Sdt = obj.Sdt;
            tempobj.IdKh = obj.IdKh;
            tempobj.IdNv = obj.IdNv;
            _dbContext.HoaDons.Add(obj);
            _dbContext.SaveChanges();
            return true;
        }
    }
}
