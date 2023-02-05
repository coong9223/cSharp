using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using All_cSharp3.DomainClass;
using All_cSharp3.Context;

namespace All_cSharp3.Repositories
{
    public class CVRepositories
    {
        private FpolyDBContext _dbContext;

        public CVRepositories()
        {
            _dbContext = new FpolyDBContext();
        }
        
        public List<ChucVu> GetAll()
        {
            return _dbContext.ChucVus.ToList();
        }

        public bool Add(ChucVu cv)
        {
            if(cv == null) return false;
            cv.Id=Guid.NewGuid();
            _dbContext.Add(cv);
            _dbContext.SaveChanges();
            return true;
        }

        public bool Update(ChucVu cv)
        {
            if (cv == null) return false;
            _dbContext.Update(cv);
            _dbContext.SaveChanges();
            return true;
        }

        public bool Delete(ChucVu cv)
        {
            if (cv == null) return false;
            _dbContext.Remove(cv);
            _dbContext.SaveChanges();
            return true;
        }


    }
}
