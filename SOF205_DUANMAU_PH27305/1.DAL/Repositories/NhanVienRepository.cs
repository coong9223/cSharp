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
    public class NhanVienRepository : INhanVienRepository
    {
        private FpolyDBContext _dbContext;
        public NhanVienRepository()
        {
            _dbContext = new FpolyDBContext();
        }
        public bool Add(NhanVien obj)
        {
            if (obj == null) return false;
            _dbContext.NhanViens.Add(obj);
            _dbContext.SaveChanges();
            return true;
        }

        public bool Delete(NhanVien obj)
        {
            if (obj == null) return false;
            var tempObj = _dbContext.NhanViens.FirstOrDefault(c => c.Id == obj.Id);
            _dbContext.Remove(tempObj);
            _dbContext.SaveChanges();
            return true;
        }

        public List<NhanVien> GetAll()
        {
            return _dbContext.NhanViens.ToList();
        }

        public NhanVien GetById(Guid id)
        {
            if (id == Guid.Empty) return null;
            return _dbContext.NhanViens.FirstOrDefault(c => c.Id == id);
        }

        public bool Update(NhanVien obj)
        {
            if (obj == null) return false;
            var tempObj = _dbContext.NhanViens.FirstOrDefault(c => c.Id == obj.Id);
            tempObj.Ten = obj.Ten;
            tempObj.TenDem = obj.TenDem;
            tempObj.Ho = obj.Ho;
            tempObj.GioiTinh = obj.GioiTinh;
            tempObj.NgaySinh = obj.NgaySinh;
            tempObj.DiaChi = obj.DiaChi;
            tempObj.Sdt = obj.Sdt;
            tempObj.MatKhau = obj.MatKhau;
            tempObj.IdCh = obj.IdCh;
            tempObj.IdCv = obj.IdCv;
            tempObj.IdGuiBc = obj.IdGuiBc;
            tempObj.TrangThai = obj.TrangThai;
            _dbContext.Update(tempObj);
            _dbContext.SaveChanges();
            return true;
        }
    }
}
