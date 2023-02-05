using BaiThi_MOB104.Context;
using BaiThi_MOB104.DomainModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BaiThi_MOB104.Repositories
{
    public class DanhMucRepositories
    {

        private FpolyDBContext _DbContext;
        public DanhMucRepositories()
        {
            _DbContext = new FpolyDBContext();
        }
        public List<DongSp> GetAll()
        {
            return _DbContext.DongSps.ToList();
        }

        public bool AddDanhMucRepositories(DongSp obj)
        {
            if (obj == null) return false;
            _DbContext.Add(obj);
            _DbContext.SaveChanges();
            return true;
        }

        public bool UpdateDanhMucRepositories(DongSp obj)
        {
            if (obj == null) return false;
            _DbContext.Update(obj);
            _DbContext.SaveChanges();
            return true;
        }

        public bool DeleteDanhMucRepositories(DongSp obj)
        {
            if (obj == null) return false;
            _DbContext.Remove(obj);
            _DbContext.SaveChanges();
            return true;
        }

    }
}
