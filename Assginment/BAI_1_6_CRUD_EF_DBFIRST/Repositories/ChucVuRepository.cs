using BAI_1_6_CRUD_EF_DBFIRST.Context;
using BAI_1_6_CRUD_EF_DBFIRST.DomainModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BAI_1_6_CRUD_EF_DBFIRST.Repositories
{
    public class ChucVuRepository
    {
        FpolyDBContext _dbContext;
        public ChucVuRepository()
        {
            _dbContext = new FpolyDBContext();
        }
        public List<ChucVu> GetAll()
        {
            return _dbContext.ChucVus.ToList();
        }
        public bool Add(ChucVu chucvu)
        {
            if (chucvu == null) return false;
            chucvu.Id = Guid.NewGuid();
            _dbContext.Add(chucvu);
            _dbContext.SaveChanges();
            return true;
        }
        public bool Update(ChucVu chucvu)
        {
            if (chucvu == null) return false;
            _dbContext.Update(chucvu);
            _dbContext.SaveChanges();
            return true;
        }
        public bool Delete(ChucVu chucvu)
        {
            if (chucvu == null) return false;
            _dbContext.Remove(chucvu);
            _dbContext.SaveChanges();
            return true;
        }
    }
}
