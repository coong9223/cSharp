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
    public class DspRepository:iDspRepository
    {
        FpolyDBContext dbContext;
        public DspRepository()
        {
            dbContext = new FpolyDBContext();
        }

        bool iDspRepository.Add(DongSp obj)
        {
            if (obj == null) return false;
            obj.Id = Guid.NewGuid();
            dbContext.Add(obj);
            dbContext.SaveChanges();
            return true;
        }

        bool iDspRepository.Delete(DongSp obj)
        {
            if (obj == null) return false;
            var tempobj = dbContext.DongSps.FirstOrDefault(c => c.Id == obj.Id);
            dbContext.Remove(tempobj);
            dbContext.SaveChanges();
            return true;
        }

        List<DongSp> iDspRepository.GetAllDsp()
        {
            return dbContext.DongSps.ToList();
        }

        DongSp iDspRepository.GetById(Guid id)
        {
            return dbContext.DongSps.FirstOrDefault(c => c.Id == id);
        }

        bool iDspRepository.Update(DongSp obj)
        {
            if (obj == null) return false;
            var tempobj = dbContext.DongSps.FirstOrDefault(c => c.Id == obj.Id);
            tempobj.Ma = obj.Ma;
            tempobj.Ten = obj.Ten;
            dbContext.Update(tempobj);
            dbContext.SaveChanges();
            return true;
        }
    }
}
