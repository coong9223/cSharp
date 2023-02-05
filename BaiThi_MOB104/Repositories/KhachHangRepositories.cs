using BaiThi_MOB104.Context;
using BaiThi_MOB104.DomainModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BaiThi_MOB104.Repositories
{
    public class KhachHangRepositories
    {

        private FpolyDBContext _DbContext;

        public KhachHangRepositories()
        {
            _DbContext = new FpolyDBContext();
        }
        public List<KhachHang> GetAll()
        {
            return _DbContext.KhachHangs.ToList();
        }

        public bool AddKhachHangRepositories(KhachHang obj)
        {
            if (obj == null) return false;
            _DbContext.Add(obj);
            _DbContext.SaveChanges();
            return true;
        }

        public bool UpdateKhachHangRepositories(KhachHang obj)
        {
            if (obj == null) return false;
            _DbContext.Update(obj);
            _DbContext.SaveChanges();
            return true;
        }

        public bool DeleteKhachHangRepositories(KhachHang obj)
        {
            if (obj == null) return false;
            _DbContext.Remove(obj);
            _DbContext.SaveChanges();
            return true;
        }


    }
}
