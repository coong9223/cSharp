using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Practice_cSharp_3.Context;
using Practice_cSharp_3.DomainClass;
using Practice_cSharp_3.Views;
namespace Practice_cSharp_3.Repositories
{
    public class PracticesRepo
    {
        FpolyDBContext _dbContext;
        public PracticesRepo()
        {
            _dbContext = new FpolyDBContext();  
        }
        public List<SanPham> GelAllSP()
        {
            return _dbContext.SanPhams.ToList();
        }

        public bool AddSp(SanPham sp)
        {
            if (sp == null) return false;
            _dbContext.Add(sp);
            _dbContext.SaveChanges();
            return true;
        }

        public bool DeleteSp(SanPham sp)
        {
            if (sp == null) return false;
            _dbContext.Remove(sp);
            _dbContext.SaveChanges();
            return true;
        }
        public bool UpdateSp(SanPham sp)
        {
            if (sp == null) return false;
            _dbContext.Update(sp);
            _dbContext.SaveChanges();
            return true;
        }
    }
}
