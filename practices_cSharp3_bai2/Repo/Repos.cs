using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using practices_cSharp3_bai2.Context;
using practices_cSharp3_bai2.DomainClass;

namespace practices_cSharp3_bai2.Repo
{
    public class Repos
    {
        FpolyDBContext db;
        public Repos()
        {
            db = new FpolyDBContext();
        }
        public List<SanPham> GEtAllSp()
        {
            return db.SanPhams.ToList();
        }

        public bool Addsp(SanPham sp)
        {
            if(sp==null) return false;
            db.Add(sp);
            db.SaveChanges();
            return true;
        }

        public bool Upsp(SanPham sp)
        {
            if (sp == null) return false;
            db.Update(sp);
            db.SaveChanges();
            return true;
        }

        public bool Delsp(SanPham sp)
        {
            
            if (sp == null) return false;
            db.Remove(sp);
            db.SaveChanges();
            return true;
        }
    }
}
