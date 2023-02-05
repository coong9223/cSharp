using System;
using System.Collections.Generic;
using System.Text;
using asm_gd1.Context;
using asm_gd1.DomainClass;
using System.Linq;

namespace asm_gd1.repositories
{
    public class AsmRepositories
    {
        private FpolyDBContext _dbContext;

        public AsmRepositories()
        {
            _dbContext = new FpolyDBContext();
        }

        public List<NhanVien> GetAll()
        {
            return _dbContext.NhanViens.ToList();
        }

        public bool Add(NhanVien obj)
        {
            if (obj == null) return false;
            obj.Id = Guid.NewGuid();
            _dbContext.Add(obj);
            _dbContext.SaveChanges();
            return true;
        }

        public bool Update(NhanVien obj)
        {
            if (obj == null) return false;
            _dbContext.Update(obj);
            _dbContext.SaveChanges();
            return true;
        }

        public bool Delete(NhanVien obj)
        {
            if (obj == null) return false;
            _dbContext.Remove(obj);
            _dbContext.SaveChanges();
            return true;
        }
    }
}
