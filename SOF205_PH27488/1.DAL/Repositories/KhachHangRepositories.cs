using System;
using System.Collections.Generic;
using System.Text;
using _1.DAL.DomainClass;
using _1.DAL.iRepositories;
using _1.DAL.Context;
using System.Linq;

namespace _1.DAL.Repositories
{
    public class KhachHangRepositories : iKhachHangRepositories
    {
        FpolyDBContext _dbContext;
        public KhachHangRepositories()
        {
            _dbContext = new FpolyDBContext();
        }
        bool iKhachHangRepositories.Add(KhachHang obj)
        {
            if (obj == null) return false;
            obj.Id = Guid.NewGuid();
            _dbContext.KhachHangs.Add(obj);
            _dbContext.SaveChanges();
            return true;
        }

        bool iKhachHangRepositories.Delete(KhachHang obj)
        {
            if (obj == null) return false;
            var tempobj = _dbContext.KhachHangs.FirstOrDefault(c => c.Id == obj.Id);
            _dbContext.KhachHangs.Remove(tempobj);
            _dbContext.SaveChanges();
            return true;
        }

        List<KhachHang> iKhachHangRepositories.GetAll()
        {
            return _dbContext.KhachHangs.ToList();
        }

        KhachHang iKhachHangRepositories.GetById(Guid id)
        {
            if (id == Guid.Empty) return null;
            return _dbContext.KhachHangs.FirstOrDefault(c => c.Id == id);
        }

        bool iKhachHangRepositories.Update(KhachHang obj)
        {
            if (obj == null) return false;
            var tempobj = _dbContext.KhachHangs.FirstOrDefault(c => c.Id == obj.Id);
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
            _dbContext.KhachHangs.Add(obj);
            _dbContext.SaveChanges();
            return true;
        }
    }
}
