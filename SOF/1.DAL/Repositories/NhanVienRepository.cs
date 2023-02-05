using _1.DAL.Context;
using _1.DAL.DomainClass;
using _1.DAL.IRepositories;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;



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
            obj.Id = Guid.NewGuid();//tu dong generate khoa chinh
            _dbContext.NhanViens.Add(obj);
            _dbContext.SaveChanges();
            return true;
        }

        public bool Delete(NhanVien obj)
        {
            if (obj == null) return false;

            var tempobj = _dbContext.NhanViens.FirstOrDefault(c => c.Id == obj.Id);

            _dbContext.NhanViens.Remove(tempobj);
            _dbContext.SaveChanges();
            return true;
        }

        public NhanVien Get(Guid id)
        {
            if (id == Guid.Empty)
                return null;
            return _dbContext.NhanViens.FirstOrDefault(c => c.Id == id);
        }

        public List<NhanVien> GetAll()
        {
            return _dbContext.NhanViens.ToList();
        }

        public bool Update(NhanVien obj)
        {
            if (obj == null) return false;

            var tempobj = _dbContext.NhanViens.FirstOrDefault(c => c.Id == obj.Id);
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

            _dbContext.NhanViens.Update(tempobj);
            _dbContext.SaveChanges();
            return true;
        }
    }
}
