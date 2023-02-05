using BaiThi_MOB104.Context;
using BaiThi_MOB104.DomainModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BaiThi_MOB104.Repositories
{
    public class GioHangRepositories
    {

        private FpolyDBContext _DbContext;

        public GioHangRepositories()
        {
            _DbContext = new FpolyDBContext();
        }
        public List<GioHang> GetAll()
        {
            return _DbContext.GioHangs.ToList();
        }

        public bool AddGioHangRepositories(GioHang obj)
        {
            if (obj == null) return false;
            _DbContext.Add(obj);
            _DbContext.SaveChanges();
            return true;
        }

        public bool UpdateGioHangRepositories(GioHang obj)
        {
            if (obj == null) return false;
            _DbContext.Update(obj);
            _DbContext.SaveChanges();
            return true;
        }

        public bool DeleteGioHangRepositories(GioHang obj)
        {
            if (obj == null) return false;
            _DbContext.Remove(obj);
            _DbContext.SaveChanges();
            return true;
        }


    }
}
