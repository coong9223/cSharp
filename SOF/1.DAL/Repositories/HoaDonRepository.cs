using _1.DAL.Context;
using _1.DAL.DomainClass;
using _1.DAL.IRepositories;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;


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
            obj.Id = Guid.NewGuid();
            _dbContext.HoaDons.Add(obj);
            _dbContext.SaveChanges();
            return true;
            
        }

        public bool Delete(HoaDon obj)
        {
            if (obj == null) return false;
            var temp = _dbContext.HoaDons.FirstOrDefault(x => x.Id == obj.Id);
            _dbContext.HoaDons.Remove(temp);
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
            return _dbContext.HoaDons.FirstOrDefault(x => x.Id ==id);
        }

        public bool Update(HoaDon obj)
        {
            if (obj == null) return false;
            var temp = _dbContext.HoaDons.FirstOrDefault(x => x.Id == obj.Id);
            temp.IdKh = obj.IdKh;
            temp.IdNv = obj.IdNv;
            temp.Ma = obj.Ma;
            temp.NgayTao = obj.NgayTao;
            temp.NgayThanhToan = obj.NgayThanhToan;
            temp.TenNguoiNhan = obj.TenNguoiNhan;
            temp.DiaChi = obj.DiaChi;
            temp.Sdt = obj.Sdt;
            temp.TinhTrang = obj.TinhTrang;
            temp.NgayShip = obj.NgayShip;
            temp.NgayNhan = obj.NgayNhan;
            _dbContext.HoaDons.Update(temp);
            _dbContext.SaveChanges();
            return true;
        }
    }
}
