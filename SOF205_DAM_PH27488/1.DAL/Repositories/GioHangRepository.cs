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
    public class GioHangRepository:iGioHangRepository
    {
        FpolyDBContext dbContext;
        public GioHangRepository()
        {
            dbContext = new FpolyDBContext();
        }

        bool iGioHangRepository.Add(GioHang obj)
        {
            if (obj == null) return false;
            obj.Id= Guid.NewGuid();
            dbContext.Add(obj);
            dbContext.SaveChanges();
            return true;
        }

        bool iGioHangRepository.Delete(GioHang obj)
        {
            if (obj == null) return false;
            var tempobj=dbContext.GioHangs.FirstOrDefault(g => g.Id==obj.Id);
            dbContext.Remove(tempobj);
            dbContext.SaveChanges();
            return true;
        }

        List<GioHang> iGioHangRepository.GetAllGioHang()
        {
            return dbContext.GioHangs.ToList();
        }

        GioHang iGioHangRepository.GetById(Guid id)
        {
            return dbContext.GioHangs.FirstOrDefault(g => g.Id == id);
        }

        bool iGioHangRepository.Update(GioHang obj)
        {
            if (obj == null) return false;
            var tempobj = dbContext.GioHangs.FirstOrDefault(g => g.Id == obj.Id);
            tempobj.IdKh = obj.IdKh;
            tempobj.IdNv = obj.IdNv;
            tempobj.Ma = obj.Ma;
            tempobj.NgayTao = obj.NgayTao;
            tempobj.NgayThanhToan = obj.NgayThanhToan;
            tempobj.TenNguoiNhan = obj.TenNguoiNhan;
            tempobj.DiaChi = obj.DiaChi;
            tempobj.Sdt = obj.Sdt;
            tempobj.TinhTrang = obj.TinhTrang;
            dbContext.Update(tempobj);
            dbContext.SaveChanges();
            return true;
        }
    }
}
