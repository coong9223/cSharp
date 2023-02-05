using System;
using System.Collections.Generic;
using System.Text;
using _1.DAL.DomainClass;
using _1.DAL.iRepositories;
using _1.DAL.Context;
using System.Linq;

namespace _1.DAL.Repositories
{
    public class MauSacRepositories : iMauSacRepositories
    {
        FpolyDBContext _dbContext;
        public MauSacRepositories()
        {
            _dbContext = new FpolyDBContext();
        }
        bool iMauSacRepositories.Add(MauSac obj)
        {
            if (obj == null) return false;
            obj.Id = Guid.NewGuid();
            _dbContext.MauSacs.Add(obj);
            _dbContext.SaveChanges();
            return true;
        }

        bool iMauSacRepositories.Delete(MauSac obj)
        {
            if (obj == null) return false;
            var tempobj = _dbContext.MauSacs.FirstOrDefault(c => c.Id == obj.Id);
            _dbContext.Remove(tempobj);
            _dbContext.SaveChanges();
            return true;
        }

        List<MauSac> iMauSacRepositories.GetAll()
        {
            return _dbContext.MauSacs.ToList();
        }

        MauSac iMauSacRepositories.GetById(Guid id)
        {
            if (id == Guid.Empty) return null;
            return _dbContext.MauSacs.FirstOrDefault(c => c.Id == id);
        }

        bool iMauSacRepositories.Update(MauSac obj)
        {
            if (obj == null) return false;
            var tempobj = _dbContext.MauSacs.FirstOrDefault(c => c.Id == obj.Id);
            tempobj.Ten = obj.Ten;
            _dbContext.Update(tempobj);
            _dbContext.SaveChanges();
            return true;
        }
    }       
}
