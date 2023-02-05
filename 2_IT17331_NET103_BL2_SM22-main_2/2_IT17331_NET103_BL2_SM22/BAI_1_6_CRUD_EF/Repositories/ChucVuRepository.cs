using BAI_1_6_CRUD_EF.Context;
using BAI_1_6_CRUD_EF.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BAI_1_6_CRUD_EF.Repositories
{
    public class ChucVuRepository
    {
        private FpolyDBContext _dBContext;

        public ChucVuRepository()
        {

            _dBContext = new FpolyDBContext();
        }

        public List<ChucVu> GetAll()
        {
            return _dBContext.ChucVus.ToList();
        }

        public bool Add(ChucVu obj)
        {
            if (obj == null) return false;
            obj.Id = Guid.NewGuid();
            _dBContext.Add(obj);
            _dBContext.SaveChanges();
            return true;

        }

        public bool Update(ChucVu obj)
        {
            if (obj == null) return false;
            _dBContext.Update(obj);
            _dBContext.SaveChanges();
            return true;
        }

        public bool Delete(ChucVu obj)
        {
            if (obj == null) return false;
            _dBContext.Remove(obj);
            _dBContext.SaveChanges();
            return true;
        }
    }
}
