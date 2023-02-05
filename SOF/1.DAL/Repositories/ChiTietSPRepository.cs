using _1.DAL.Context;
using _1.DAL.DomainClass;
using _1.DAL.IRepositories;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace _1.DAL.Repositories
{
    public class ChiTietSPRepository : IChiTietSPRepository
    {
        private FpolyDBContext _dBContext;

        public ChiTietSPRepository()
        {
            _dBContext = new FpolyDBContext();
        }
        public bool Add(ChiTietSp obj)
        {
            if (obj == null) return false;
            _dBContext.ChiTietSps.Add(obj);
            _dBContext.SaveChanges();
            return true;
        }

        public bool Delete(ChiTietSp obj)
        {
            if (obj == null) return false;
            var temp = _dBContext.ChiTietSps.FirstOrDefault(c=>c.Id == obj.Id);
            _dBContext.Remove(temp);
            _dBContext.SaveChanges();
            return true;
        }

        public List<ChiTietSp> GetAll()
        {
            return _dBContext.ChiTietSps.ToList();
        }

        public ChiTietSp GetById(Guid id)
        {
            if (id == Guid.Empty) return null;
            return _dBContext.ChiTietSps.FirstOrDefault(c => c.Id == id);
        }

        public bool Update(ChiTietSp obj)
        {
            if (obj == null) return false;
            var temp = _dBContext.ChiTietSps.FirstOrDefault(c => c.Id == obj.Id);
            temp.GiaBan = obj.GiaBan;
            temp.GiaNhap = obj.GiaNhap;
            temp.IdDongSp = obj.IdDongSp;
            temp.IdMauSac = obj.IdMauSac;
            temp.IdNsx = obj.IdNsx;
            temp.IdSp = obj.IdSp;
            temp.NamBh = obj.NamBh;
            temp.MoTa = obj.MoTa;
            _dBContext.ChiTietSps.Update(temp);
            _dBContext.SaveChanges();
            return true;
        }
    }
}
