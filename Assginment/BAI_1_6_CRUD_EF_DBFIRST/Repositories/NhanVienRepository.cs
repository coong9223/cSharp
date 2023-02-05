using BAI_1_6_CRUD_EF_DBFIRST.Context;
using BAI_1_6_CRUD_EF_DBFIRST.DomainModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BAI_1_6_CRUD_EF_DBFIRST.Repositories
{
    public class NhanVienRepository
    {
        FpolyDBContext _dbContext;
        public NhanVienRepository()
        {
            _dbContext = new FpolyDBContext();
        }
        public List<NhanVien> GetAll()
        {
            return _dbContext.NhanViens.ToList();
        }
        public bool Add(NhanVien nhanvien)
        {
            if(nhanvien == null) return false;
            nhanvien.Id = Guid.NewGuid();
            _dbContext.Add(nhanvien);
            _dbContext.SaveChanges();
            nhanvien = new NhanVien();
            return true;
        }
        public bool Update(NhanVien nhanvien)
        {
            if (nhanvien == null) return false;
            _dbContext.Update(nhanvien);
            _dbContext.SaveChanges();
            return true;
        }
        public bool Delete(NhanVien nhanvien)
        {
            if (nhanvien == null) return false;
            _dbContext.Remove(nhanvien);
            _dbContext.SaveChanges();
            return true;
        }
    }
}
