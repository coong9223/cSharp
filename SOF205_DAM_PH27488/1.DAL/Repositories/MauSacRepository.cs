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
    public class MauSacRepository : iMauSacRepository
    {
        FpolyDBContext dbContext;
        public MauSacRepository()
        {
            dbContext = new FpolyDBContext();
        }

        bool iMauSacRepository.Add(MauSac obj)
        {
            if (obj == null) return false;
            obj.Id = Guid.NewGuid();
            dbContext.Add(obj);
            dbContext.SaveChanges();
            return true;
        }

        bool iMauSacRepository.Delete(MauSac obj)
        {
            if (obj == null) return false;
            var tempobj = dbContext.MauSacs.FirstOrDefault(c => c.Id == obj.Id);
            dbContext.Remove(tempobj);
            dbContext.SaveChanges();
            return true;
        }

        List<MauSac> iMauSacRepository.GetAllMs()
        {
            return dbContext.MauSacs.ToList();
        }

        MauSac iMauSacRepository.GetById(Guid id)
        {
            return dbContext.MauSacs.FirstOrDefault(c => c.Id == id);
        }

        bool iMauSacRepository.Update(MauSac obj)
        {
            if (obj == null) return false;
            var tempobj = dbContext.MauSacs.FirstOrDefault(c => c.Id == obj.Id);
            tempobj.Ma = obj.Ma;
            tempobj.Ten = obj.Ten;
            dbContext.Update(tempobj);
            dbContext.SaveChanges();
            return true;
        }
    }
}
