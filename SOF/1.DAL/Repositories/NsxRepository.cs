using _1.DAL.Context;
using _1.DAL.DomainClass;
using _1.DAL.IRepositories;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System;

namespace _1.DAL.Repositories
{
    public class NsxRepository : INsxRepository
    {
        private FpolyDBContext _dBContext;
        public NsxRepository()
        {
            _dBContext = new FpolyDBContext();
        }
        public bool Add(Nsx obj)
        {
            if(obj == null) return false;
            _dBContext.Nsxes.Add(obj);
            _dBContext.SaveChanges();
            return true;
        }

        public bool Delete(Nsx obj)
        {
            if (obj == null) return false ;
            _dBContext.Nsxes.Remove(obj);
            _dBContext.SaveChanges();
            return true;
        }

        public List<Nsx> GetAll()
        {
            return _dBContext.Nsxes.ToList();
        }

        public Nsx GetById(Guid id)
        {
            if (id == Guid.Empty)
                return null;
            return _dBContext.Nsxes.FirstOrDefault(c => c.Id == id);
        }

        public bool Update(Nsx obj)
        {
            if (obj == null) return false;
            var temp = _dBContext.Nsxes.FirstOrDefault(c => c.Id == obj.Id);
            temp.Ma= obj.Ma;
            temp.Ten = obj.Ten;
            _dBContext.Nsxes.Update(temp);
            _dBContext.SaveChanges();
            return true;
        }
    }
}
