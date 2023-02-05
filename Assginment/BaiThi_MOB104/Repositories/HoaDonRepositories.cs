using BaiThi_MOB104.Context;
using BaiThi_MOB104.DomainModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BaiThi_MOB104.Repositories
{
   public class HoaDonRepositories
    {

        private FpolyDBContext _DbContext;

        public HoaDonRepositories()
        {
            _DbContext = new FpolyDBContext();
        }
       public List<HoaDon> GetAll()
        {
            return _DbContext.HoaDons.ToList();
        }

        public bool AddHoaDonRepositories(HoaDon obj)
        {
            if (obj == null) return false;
            _DbContext.Add(obj);
            _DbContext.SaveChanges();
            return true;
        }

        public bool UpdateHoaDonRepositories(HoaDon obj)
        {
            if (obj == null) return false;
            _DbContext.Update(obj);
            _DbContext.SaveChanges();
            return true;
        }

        public bool DeleteHoaDonRepositories(HoaDon obj)
        {
            if (obj == null) return false;
            _DbContext.Remove(obj);
            _DbContext.SaveChanges();
            return true;
        }
    }
}
