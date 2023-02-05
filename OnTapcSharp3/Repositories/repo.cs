using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using OnTapcSharp3.Context;
using OnTapcSharp3.DomainClass;

namespace OnTapcSharp3.Repositories
{
    public class repo
    {
        FpolyDBContext dbContext;
        public repo()
        {
            dbContext = new FpolyDBContext();
        }

        public List<SanPham> GetSp()
        {
            return dbContext.SanPhams.ToList();
        }

        public bool Add(SanPham sp)
        {
            if(sp.Id == null)return false;
            dbContext.Add(sp);
            dbContext.SaveChanges();
            return true;
        }

        public bool Update(SanPham sp)
        {
            if (sp.Id == null) return false;
            dbContext.Update(sp);
            dbContext.SaveChanges();
            return true;
        }

        public bool Delete(SanPham sp)
        {
            if (sp.Id == null) return false;
            dbContext.Remove(sp);
            dbContext.SaveChanges();
            return true;
        }
    }
}
