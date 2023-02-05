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
    public class GioHangRepository : IGioHangRepository
    {
        private FpolyDBContext _dbContext;
        public GioHangRepository()
        {
            _dbContext = new FpolyDBContext();
        }
        public bool Add(GioHang obj)
        {
            if (obj == null) return false;
            _dbContext.GioHangs.Add(obj);
            _dbContext.SaveChanges();
            return true;
        }

        public bool Delete(GioHang obj)
        {
            if (obj == null) return false;
            var tempObj = _dbContext.GioHangs.FirstOrDefault(c => c.Id == obj.Id);
            _dbContext.Remove(tempObj);
            _dbContext.SaveChanges();
            return true;
        }

        public List<GioHang> GetAll()
        {
            return _dbContext.GioHangs.ToList();
        }

        public GioHang GetById(Guid id)
        {
            if (id == Guid.Empty) return null;
            return _dbContext.GioHangs.FirstOrDefault(c => c.Id == id);
        }

        public bool Update(GioHang obj)
        {
            if (obj == null) return false;
            var tempObj = _dbContext.GioHangs.FirstOrDefault(c => c.Id == obj.Id);
            tempObj.IdKh = obj.IdKh;
            tempObj.IdNv = obj.IdNv;
            tempObj.NgayTao = obj.NgayTao;
            tempObj.NgayThanhToan = obj.NgayThanhToan;
            tempObj.TenNguoiNhan = obj.TenNguoiNhan;
            tempObj.DiaChi = obj.DiaChi;
            tempObj.Sdt = obj.Sdt;
            tempObj.TinhTrang = obj.TinhTrang;
            _dbContext.Update(tempObj);
            _dbContext.SaveChanges();
            return true;
        }
    }
}
