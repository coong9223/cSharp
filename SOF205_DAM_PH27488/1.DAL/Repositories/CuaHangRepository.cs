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
    public class CuaHangRepository : iCuaHangRepository
    {
        FpolyDBContext dbContext;
        public CuaHangRepository()
        {
            dbContext = new FpolyDBContext();
        }
        bool iCuaHangRepository.Add(CuaHang obj)
        {
            if (obj == null) return false;
            obj.Id = Guid.NewGuid();
            dbContext.Add(obj);
            dbContext.SaveChanges();
            return true;
        }

        bool iCuaHangRepository.Delete(CuaHang obj)
        {
            if (obj == null) return false;
            var tempobj=dbContext.CuaHangs.FirstOrDefault(x => x.Id == obj.Id);
            dbContext.Remove(tempobj);
            dbContext.SaveChanges();
            return true;
        }

        List<CuaHang> iCuaHangRepository.GetAllCh()
        {
            return dbContext.CuaHangs.ToList();
        }

        CuaHang iCuaHangRepository.GetById(Guid id)
        {
            return dbContext.CuaHangs.FirstOrDefault(x => x.Id == id);
        }

        bool iCuaHangRepository.Update(CuaHang obj)
        {
            if (obj == null) return false;
            var tempobj = dbContext.CuaHangs.FirstOrDefault(x => x.Id == obj.Id);
            tempobj.Ma = obj.Ma;
            tempobj.Ten = obj.Ten;
            tempobj.DiaChi = obj.DiaChi;
            tempobj.ThanhPho = obj.ThanhPho;
            dbContext.Update(tempobj);
            dbContext.SaveChanges();
            return true;
        }
    }
}
