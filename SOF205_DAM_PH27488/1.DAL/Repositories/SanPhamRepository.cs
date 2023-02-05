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
    public class SanPhamRepository:iSanPhamRepository
    {
        FpolyDBContext dbContext;
        public SanPhamRepository()
        {
            dbContext = new FpolyDBContext();
        }

        bool iSanPhamRepository.Add(SanPham obj)
        {
            if (obj == null) return false;
            obj.Id= Guid.NewGuid();
            dbContext.Add(obj);
            dbContext.SaveChanges();
            return true;
        }

        bool iSanPhamRepository.Delete(SanPham obj)
        {
            if (obj == null) return false;
            var tempobj=dbContext.SanPhams.FirstOrDefault(c=>c.Id==obj.Id);
            dbContext.Remove(tempobj);
            dbContext.SaveChanges();
            return true;
        }

        List<SanPham> iSanPhamRepository.GetAllSp()
        {
            return dbContext.SanPhams.ToList();
        }

        SanPham iSanPhamRepository.GetById(Guid id)
        {
            return dbContext.SanPhams.FirstOrDefault(c=>c.Id==id);
        }

        bool iSanPhamRepository.Update(SanPham obj)
        {
            if (obj == null) return false;
            var tempobj = dbContext.SanPhams.FirstOrDefault(c => c.Id == obj.Id);
            tempobj.Ma=obj.Ma;
            tempobj.Ten=obj.Ten;
            dbContext.Update(tempobj);
            dbContext.SaveChanges();
            return true;
        }
    }
}
