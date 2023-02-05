using Project_Template_SM22_Csharp.Context;
using Project_Template_SM22_Csharp.DomainModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Project_Template_SM22_Csharp.Repositories
{
    public class SanPhamRepositories
    {

        private FpolyDBContext _DbContext;
        public SanPhamRepositories()
        {
            _DbContext = new FpolyDBContext();
        }
      
        public bool AddSanPhamRepositories(SanPham obj )
        {
            if( obj == null )   return false;
            _DbContext.Add(obj);
            _DbContext.SaveChanges();
            return true;
        }
        public bool UpdateSanPhamRepositories(SanPham obj)
        {
            if (obj == null) return false;
            _DbContext.Update(obj);
            _DbContext.SaveChanges();
            return true;
        }
        public bool DeleteSanPhamRepositories(SanPham obj)
        {
            if (obj == null) return false;
            _DbContext.Remove(obj);
            _DbContext.SaveChanges();
            return true;
        }
        public List<SanPham> GetAll()
        {
            return _DbContext.SanPhams.ToList();
        }
    }
}
