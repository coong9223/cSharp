using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1.DAL.Context;
using _1.DAL.DomainClass;
using _1.DAL.iRepositories;

namespace _1.DAL.Repositories
{
    public class HoaDonRepository : iHoaDonRepository
    {
        FpolyDBContext dbContext;
        public HoaDonRepository()
        {
            dbContext = new FpolyDBContext();
        }
        bool iHoaDonRepository.Add(HoaDon obj)
        {
            if(obj == null)return false;
            obj.Id = Guid.NewGuid();
            dbContext.Add(obj);
            dbContext.SaveChanges();
            return true;
        }

        bool iHoaDonRepository.Delete(HoaDon obj)
        {
            if (obj == null) return false;
            var tempobj = dbContext.HoaDons.FirstOrDefault(c => c.Id == obj.Id);
            dbContext.Remove(tempobj);
            dbContext.SaveChanges();
            return true;
        }

        List<HoaDon> iHoaDonRepository.GetAllHoaDon()
        {
            return dbContext.HoaDons.ToList();
        }

        HoaDon iHoaDonRepository.GetById(Guid id)
        {
            return dbContext.HoaDons.FirstOrDefault(c => c.Id == id);
        }

        bool iHoaDonRepository.Update(HoaDon obj)
        {
            if (obj == null) return false;
            var tempobj = dbContext.HoaDons.FirstOrDefault(c => c.Id == obj.Id);
            tempobj.IdKh = obj.IdKh;
            tempobj.IdNv = obj.IdNv;
            tempobj.Ma = obj.Ma;
            tempobj.NgayTao = obj.NgayTao;
            tempobj.NgayThanhToan = obj.NgayThanhToan;
            tempobj.NgayShip = obj.NgayShip;
            tempobj.NgayNhan = obj.NgayNhan;
            tempobj.TinhTrang = obj.TinhTrang;
            tempobj.TenNguoiNhan = obj.TenNguoiNhan;
            tempobj.DiaChi = obj.DiaChi;
            tempobj.Sdt = obj.Sdt;
            dbContext.Update(tempobj);
            dbContext.SaveChanges();
            return true;
        }
    }
}
