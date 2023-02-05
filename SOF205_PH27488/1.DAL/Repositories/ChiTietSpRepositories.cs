using System;
using System.Collections.Generic;
using System.Text;
using _1.DAL.DomainClass;
using _1.DAL.iRepositories;
using _1.DAL.Context;
using System.Linq;

namespace _1.DAL.Repositories
{
    public class ChiTietSpRepositories : IChiTietSpRepositories
    {
        FpolyDBContext _dbContext;
        public ChiTietSpRepositories()
        {
            _dbContext = new FpolyDBContext();
        }
        bool IChiTietSpRepositories.Add(ChiTietSp obj)
        {
            if (obj == null) return false;
            obj.Id = Guid.NewGuid();
            _dbContext.ChiTietSps.Add(obj);
            _dbContext.SaveChanges();
            return true;
        }

        bool IChiTietSpRepositories.Delete(ChiTietSp obj)
        {
            if(obj == null) return false;
            var tempobj=_dbContext.ChiTietSps.FirstOrDefault(c=>c.Id==obj.Id);
            _dbContext.ChiTietSps.Remove(tempobj);
            _dbContext.SaveChanges();
            return true;
        }

        List<ChiTietSp> IChiTietSpRepositories.GetAll()
        {
            return _dbContext.ChiTietSps.ToList();
        }

        ChiTietSp IChiTietSpRepositories.GetById(Guid id)
        {
            if(id==Guid.Empty) return null;
            return _dbContext.ChiTietSps.FirstOrDefault(c=>c.Id==id);
        }

        bool IChiTietSpRepositories.Update(ChiTietSp obj)
        {
            if(obj == null) return false;
            var tempobj = _dbContext.ChiTietSps.FirstOrDefault(c => c.Id == obj.Id);
            tempobj.GiaBan = obj.GiaBan;
            tempobj.GiaNhap = obj.GiaNhap;
            tempobj.SoLuongTon = obj.SoLuongTon;
            tempobj.MoTa = obj.MoTa;
            tempobj.NamBh = obj.NamBh;
            tempobj.IdDongSp = obj.IdDongSp;
            tempobj.IdMauSac = obj.IdMauSac;
            tempobj.IdNsx = obj.IdNsx;
            tempobj.IdSp = obj.IdSp;
            _dbContext.ChiTietSps.Add(obj);
            _dbContext.SaveChanges();
            return true;
        }
    }
}
