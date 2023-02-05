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
    public class KhachHangRepository : IKhachHangRepository
    {
        private FpolyDBContext _dbContext;
        public KhachHangRepository()
        {
            _dbContext = new FpolyDBContext();
        }
        public bool Add(KhachHang obj)
        {
            if (obj == null) return false;
            _dbContext.KhachHangs.Add(obj);
            _dbContext.SaveChanges();
            return true;
        }

        public bool Delete(KhachHang obj)
        {
            if (obj == null) return false;
            var tempObj = _dbContext.KhachHangs.FirstOrDefault(c => c.Id == obj.Id);
            _dbContext.Remove(tempObj);
            _dbContext.SaveChanges();
            return true;
        }

        public List<KhachHang> GetAll()
        {
            return _dbContext.KhachHangs.ToList();
        }

        public KhachHang GetById(Guid id)
        {
            if (id == Guid.Empty) return null;
            return _dbContext.KhachHangs.FirstOrDefault(c => c.Id == id);
        }

        public bool Update(KhachHang obj)
        {
            if (obj == null) return false;
            var tempObj = _dbContext.KhachHangs.FirstOrDefault(c => c.Id == obj.Id);
            tempObj.Ten = obj.Ten;
            tempObj.TenDem = obj.TenDem;
            tempObj.Ho = obj.Ho;
            tempObj.NgaySinh = obj.NgaySinh;
            tempObj.Sdt = obj.Sdt;
            tempObj.DiaChi = obj.DiaChi;
            tempObj.ThanhPho = obj.ThanhPho;
            tempObj.QuocGia = obj.QuocGia;
            tempObj.MatKhau = obj.MatKhau;
            _dbContext.Update(tempObj);
            _dbContext.SaveChanges();
            return true;
        }
    }
}
