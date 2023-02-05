using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1.DAL.Context;
using _1.DAL.DomainClass;
using _1.DAL.iRepositories;

namespace _1.DAL.Repositories
{
    public class CtSpRepository:iCtSpRepository
    {
        FpolyDBContext dbContext;
        public CtSpRepository()
        {
            dbContext = new FpolyDBContext();
        }

        bool iCtSpRepository.Add(ChiTietSp obj)
        {
            if (obj == null) return false;
            obj.Id = Guid.NewGuid();
            dbContext.Add(obj);
            dbContext.SaveChanges();
            return true;
        }

        bool iCtSpRepository.Delete(ChiTietSp obj)
        {
            if (obj == null) return false;
            var tempobj = dbContext.ChiTietSps.FirstOrDefault(c => c.Id == obj.Id);
            dbContext.Add(tempobj);
            dbContext.SaveChanges();
            return true;
        }

        List<ChiTietSp> iCtSpRepository.GetAllCtSp()
        {
            return dbContext.ChiTietSps.ToList();
        }

        ChiTietSp iCtSpRepository.GetById(Guid id)
        {
            return dbContext.ChiTietSps.FirstOrDefault(c => c.Id ==id);
        }

        bool iCtSpRepository.Update(ChiTietSp obj)
        {
            if (obj == null) return false;
            var tempobj = dbContext.ChiTietSps.FirstOrDefault(c => c.Id == obj.Id);
            tempobj.IdSp = obj.IdSp;
            tempobj.IdNsx=obj.IdNsx;
            tempobj.IdMauSac=obj.IdMauSac;
            tempobj.IdDongSp=obj.IdDongSp;
            tempobj.NamBh=obj.NamBh;
            tempobj.MoTa=obj.MoTa;
            tempobj.SoLuongTon=obj.SoLuongTon;
            tempobj.GiaNhap=obj.GiaNhap;
            tempobj.GiaBan=obj.GiaBan;
            dbContext.Add(tempobj);
            dbContext.SaveChanges();
            return true;
        }
    }
}
