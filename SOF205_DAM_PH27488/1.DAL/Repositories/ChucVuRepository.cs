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
    public class ChucVuRepository : iChucVuRepository
    {
        FpolyDBContext dbContext;
        public ChucVuRepository()
        {
            dbContext = new FpolyDBContext();
        }
        bool iChucVuRepository.Add(ChucVu obj)
        {
            if(obj == null) return false;
            obj.Id = Guid.NewGuid();
            dbContext.Add(obj);
            dbContext.SaveChanges();
            return true;
        }

        bool iChucVuRepository.Delete(ChucVu obj)
        {
            if (obj == null) return false;
            var tempobj=dbContext.ChucVus.FirstOrDefault(c => c.Id == obj.Id);
            dbContext.Remove(tempobj);
            dbContext.SaveChanges();
            return true;
        }

        List<ChucVu> iChucVuRepository.GetAllCv()
        {
            return dbContext.ChucVus.ToList();
        }

        ChucVu iChucVuRepository.GetById(Guid id)
        {
            return dbContext.ChucVus.FirstOrDefault(c => c.Id == id);
        }

        bool iChucVuRepository.Update(ChucVu obj)
        {
            if (obj == null) return false;
            var tempobj = dbContext.ChucVus.FirstOrDefault(c => c.Id == obj.Id);
            tempobj.Ma = obj.Ma;
            tempobj.Ten = obj.Ten;
            dbContext.Update(tempobj);
            dbContext.SaveChanges();
            return true;
        }
    }
}
