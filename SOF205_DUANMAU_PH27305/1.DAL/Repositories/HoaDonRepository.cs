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
    public class HoaDonRepository : IHoaDonRepository
    {
        private FpolyDBContext _dbContext;
        public HoaDonRepository()
        {
            _dbContext = new FpolyDBContext();
        }
        public bool Add(HoaDon obj)
        {
            if (obj == null) return false;
            _dbContext.HoaDons.Add(obj);
            _dbContext.SaveChanges();
            return true;
        }

        public bool Delete(HoaDon obj)
        {
            if (obj == null) return false;
            var tempObj = _dbContext.HoaDons.FirstOrDefault(c => c.Id == obj.Id);
            _dbContext.Remove(tempObj);
            _dbContext.SaveChanges();
            return true;
        }

        public List<HoaDon> GetAll()
        {
            return _dbContext.HoaDons.ToList();
        }

        public HoaDon GetById(Guid id)
        {
            if (id == Guid.Empty) return null;
            return _dbContext.HoaDons.FirstOrDefault(c => c.Id == id);
        }

        public bool Update(HoaDon obj)
        {
            if (obj == null) return false;
            var tempObj = _dbContext.HoaDons.FirstOrDefault(c => c.Id == obj.Id);
            tempObj.IdKh = obj.IdKh;
            tempObj.IdNv = obj.IdNv;
            tempObj.NgayTao = obj.NgayTao;
            tempObj.NgayThanhToan = obj.NgayThanhToan;
            tempObj.NgayShip = obj.NgayShip;
            tempObj.NgayNhan = obj.NgayNhan;
            tempObj.TenNguoiNhan = obj.TenNguoiNhan;
            tempObj.DiaChi = obj.DiaChi;
            tempObj.Sdt = obj.Sdt;
            _dbContext.Update(tempObj);
            _dbContext.SaveChanges();
            return true;
        }
    }
}
