using BaiThi_MOB104.Context;
using BaiThi_MOB104.DomainModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BaiThi_MOB104.Repositories
{
    public class TaiKhoanRepositories
    {
        private FpolyDBContext _DbContext;

        public TaiKhoanRepositories()
        {
            _DbContext = new FpolyDBContext();
        }
        public List<TaiKhoan> GetAll()
        {
            return _DbContext.TaiKhoans.ToList();
        }

        public bool AddTaiKhoanRepositories(TaiKhoan obj)
        {
            if (obj == null) return false;
            _DbContext.Add(obj);
            _DbContext.SaveChanges();
            return true;
        }

        public bool UpdateTaiKhoanRepositories(TaiKhoan obj)
        {
            if (obj == null) return false;
            _DbContext.Update(obj);
            _DbContext.SaveChanges();
            return true;
        }

        public bool DeleteTaiKhoanRepositories(TaiKhoan obj)
        {
            if (obj == null) return false;
            _DbContext.Remove(obj);
            _DbContext.SaveChanges();
            return true;
        }


    }
}
