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
    public class NhanVienRepository : iNhanVienRepository
    {
        FpolyDBContext dbContext;
        public NhanVienRepository()
        {
            dbContext = new FpolyDBContext();
        }
        bool iNhanVienRepository.Add(NhanVien obj)
        {
            if(obj == null) return false;
            obj.Id=Guid.NewGuid();
            dbContext.Add(obj);
            dbContext.SaveChanges();
            return true;
        }
        bool iNhanVienRepository.Delete(NhanVien obj)
        {
            if (obj == null) return false;
            var tempobj = dbContext.NhanViens.FirstOrDefault(c => c.Id ==obj.Id);
            dbContext.Remove(tempobj);
            dbContext.SaveChanges();
            return true;
        }

        List<NhanVien> iNhanVienRepository.GetAllNv()
        {
            return dbContext.NhanViens.ToList();
        }

        NhanVien iNhanVienRepository.GetById(Guid id)
        {
            return dbContext.NhanViens.FirstOrDefault(c => c.Id == id);
        }

        bool iNhanVienRepository.Update(NhanVien obj)
        {
            if (obj == null) return false;
            var tempobj = dbContext.NhanViens.FirstOrDefault(c => c.Id == obj.Id);
            tempobj.Ma = obj.Ma;
            tempobj.Ten = obj.Ten;
            tempobj.TenDem = obj.TenDem;
            tempobj.Ho = obj.Ho;
            tempobj.NgaySinh = obj.NgaySinh;
            tempobj.GioiTinh = obj.GioiTinh;
            tempobj.DiaChi = obj.DiaChi;
            tempobj.Sdt = obj.Sdt;
            tempobj.MatKhau = obj.MatKhau;
            tempobj.IdCh = obj.IdCh;
            tempobj.IdCv = obj.IdCv;
            tempobj.IdGuiBc = obj.IdGuiBc;
            tempobj.TrangThai = obj.TrangThai;
            dbContext.Update(obj);
            dbContext.SaveChanges();
            return true;
        }
    }
}
