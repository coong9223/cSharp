using BAI_1_6_CRUD_EF.Context;
using BAI_1_6_CRUD_EF.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BAI_1_6_CRUD_EF.Repositories
{
    public class NhanVienRepository
    {
        private FpolyDBContext _dBContext;

        public NhanVienRepository()
        {

            _dBContext = new FpolyDBContext();
        }

        public List<NhanVien> GetAll()
        {
            return _dBContext.NhanViens.ToList();
        }

        public bool Add(NhanVien obj)
        {
            if (obj == null) return false;
            obj.Id = Guid.NewGuid();
            _dBContext.Add(obj);
            _dBContext.SaveChanges();
            return true;

        }

        public bool Update(NhanVien obj)
        {
            if (obj == null) return false;
            _dBContext.Update(obj);
            _dBContext.SaveChanges();
            return true;
        }

        public bool Delete(NhanVien obj)
        {
            if (obj == null) return false;
            _dBContext.Remove(obj);
            _dBContext.SaveChanges();
            return true;
        }
    }
}
