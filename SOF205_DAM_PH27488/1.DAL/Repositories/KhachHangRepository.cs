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
    public class KhachHangRepository:iKhachHangRepository
    {
        FpolyDBContext dbContext;
        public KhachHangRepository()
        {
            dbContext = new FpolyDBContext();
        }

        bool iKhachHangRepository.Add(KhachHang obj)
        {
            if (obj == null) return false;
            obj.Id=Guid.NewGuid();
            dbContext.Add(obj);
            dbContext.SaveChanges();
            return true;
        }

        bool iKhachHangRepository.Delete(KhachHang obj)
        {
            if (obj == null) return false;
            var tempobj = dbContext.KhachHangs.FirstOrDefault(c => c.Id == obj.Id);
            dbContext.Remove(tempobj);
            dbContext.SaveChanges();
            return true;
        }

        List<KhachHang> iKhachHangRepository.GetAllKh()
        {
            return dbContext.KhachHangs.ToList();
        }

        KhachHang iKhachHangRepository.GetById(Guid id)
        {
            return dbContext.KhachHangs.FirstOrDefault(c => c.Id == id);
        }

        bool iKhachHangRepository.Update(KhachHang obj)
        {
            if (obj == null) return false;
            var tempobj = dbContext.KhachHangs.FirstOrDefault(c => c.Id == obj.Id);
            tempobj.Ma = obj.Ma;
            tempobj.Ten = obj.Ten;
            tempobj.TenDem = obj.TenDem;
            tempobj.Ho = obj.Ho;
            tempobj.NgaySinh = obj.NgaySinh;
            tempobj.Sdt = obj.Sdt;
            tempobj.DiaChi = obj.DiaChi;
            tempobj.ThanhPho = obj.ThanhPho;
            tempobj.QuocGia = obj.QuocGia;
            tempobj.MatKhau = obj.MatKhau;
            dbContext.Update(tempobj);
            dbContext.SaveChanges();
            return true;
        }
    }
}
