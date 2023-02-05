using _1.DAL.Context;
using _1.DAL.DomainClass;
using _1.DAL.IRepositories;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace _1.DAL.Repositories
{
    public class MauSacRepository : IMauSacRepository
    {
        private FpolyDBContext _dbContext;
        public MauSacRepository()
        {
            _dbContext = new FpolyDBContext();
        }
        public bool Add(MauSac obj)
        {
            if (obj == null) return false;
            obj.Id = Guid.NewGuid();
            _dbContext.MauSacs.Add(obj);
            _dbContext.SaveChanges();
            return true;
        }

        public bool Delete(MauSac obj)
        {
            if (obj == null) return false;
            var temp = _dbContext.MauSacs.FirstOrDefault(x => x.Id == obj.Id);
            _dbContext.MauSacs.Remove(temp);
            _dbContext.SaveChanges();
            return true;
        }

        public List<MauSac> GetAll()
        {
            return _dbContext.MauSacs.ToList();
        }

        public MauSac GetById(Guid id)
        {
            if (id == Guid.Empty) return null;
            return _dbContext.MauSacs.FirstOrDefault(x => x.Id == id);
        }

        public bool Update(MauSac obj)
        {
            if (obj == null) return false;
            var temp = _dbContext.MauSacs.FirstOrDefault(x => x.Id == obj.Id);
            temp.Ma = obj.Ma;
            temp.Ten = obj.Ten;
            _dbContext.MauSacs.Update(temp);
            _dbContext.SaveChanges();
            return true;
        }
    }
}
