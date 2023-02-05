using Project_Template_SM22_Csharp.Context;
using Project_Template_SM22_Csharp.DomainModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Project_Template_SM22_Csharp.Repositories
{
    public class NhanVienRepositories
    {
        private FpolyDBContext _DbContext;

        public NhanVienRepositories()
        {
            _DbContext = new FpolyDBContext();
        }

        public List<NhanVien> GetAll()
        {
            return _DbContext.NhanViens.ToList();
        }

        public bool AddNhanVienRepositories(NhanVien obj)
        {
            if(obj == null) return false;
            _DbContext.Add(obj);
            _DbContext.SaveChanges();
            return true;
        }
        public bool UpdateNhanVienRepositories(NhanVien obj)
        {
            if (obj == null) return false;
            _DbContext.Update(obj);
            _DbContext.SaveChanges();
            return true;
        }
        public bool DeleteNhanVienRepositories(NhanVien obj)
        {
            if (obj == null) return false;
            _DbContext.Remove(obj);
            _DbContext.SaveChanges();
            return true;
        }




    }
}
