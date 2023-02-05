using System;
using System.Collections.Generic;
using System.Text;
using _1.DAL.DomainClass;
using _1.DAL.iRepositories;
using _1.DAL.Context;
using System.Linq;

namespace _1.DAL.Repositories
{
    public class NhanVienRepositories : iNhanVienRepositories
    {
        FpolyDBContext _dbContext;
        public NhanVienRepositories()
        {
            _dbContext = new FpolyDBContext();
        }
        bool iNhanVienRepositories.Add(NhanVien obj)
        {
            if (obj == null) return false;
            obj.Id = Guid.NewGuid();
            _dbContext.NhanViens.Add(obj);
            _dbContext.SaveChanges();
            return true;
        }

        bool iNhanVienRepositories.Delete(NhanVien obj)
        {
            if (obj == null) return false;
            var tempobj = _dbContext.NhanViens.FirstOrDefault(c => c.Id == obj.Id);
            _dbContext.NhanViens.Remove(tempobj);
            _dbContext.SaveChanges();
            return true;
        }

        List<NhanVien> iNhanVienRepositories.GetAll()
        {
            return _dbContext.NhanViens.ToList();
        }

        NhanVien iNhanVienRepositories.GetById(Guid id)
        {
            if (id == Guid.Empty) return null;
            return _dbContext.NhanViens.FirstOrDefault(c => c.Id == id);
        }

        bool iNhanVienRepositories.Update(NhanVien obj)
        {
            if (obj == null) return false;
            var tempobj = _dbContext.NhanViens.FirstOrDefault(c => c.Id == obj.Id);
            tempobj.Ma = obj.Ma;
            tempobj.Ten = obj.Ten;
            tempobj.TenDem = obj.TenDem;
            tempobj.Ho = obj.Ho;
            tempobj.NgaySinh = obj.NgaySinh;
            tempobj.Sdt = obj.Sdt;
            tempobj.DiaChi = obj.DiaChi;
            tempobj.GioiTinh = obj.GioiTinh;
            tempobj.TrangThai = obj.TrangThai;
            tempobj.MatKhau = obj.MatKhau;
            tempobj.IdCh = obj.IdCh;
            tempobj.IdCv = obj.IdCv;
            tempobj.IdGuiBc = obj.IdGuiBc;
            _dbContext.NhanViens.Add(obj);
            _dbContext.SaveChanges();
            return true;    
        }
    }
}
