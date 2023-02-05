using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1.DAL.DomainClass;
using _1.DAL.iRepositories;
using _1.DAL.Context;

namespace _1.DAL.Repositories
{
    public class MauSacRepositories:iMauSacRepository
    {
        private FpolyDBContext _dbContext;
        public MauSacRepositories()
        {
            _dbContext = new FpolyDBContext();  
        }

        bool iMauSacRepository.Add(MauSac mau)
        {
            if (mau == null) return false;
            mau.Id = Guid.Empty;
            _dbContext.Add(mau);
            _dbContext.SaveChanges();
            return true;
        }

        bool iMauSacRepository.Delete(MauSac mau)
        {
            if (mau == null) return false;
            var temp = _dbContext.MauSacs.FirstOrDefault(c => c.Id == mau.Id);
            _dbContext.Remove(mau);
            _dbContext.SaveChanges();
            return true;
        }

        List<MauSac> iMauSacRepository.GetAll()
        {
            return _dbContext.MauSacs.ToList();
        }

        MauSac iMauSacRepository.GetById(Guid id)
        {
            return _dbContext.MauSacs.FirstOrDefault(c => c.Id == id);
        }

        bool iMauSacRepository.Update(MauSac mau)
        {
            if(mau == null) return false;
            var temp = _dbContext.MauSacs.FirstOrDefault(c => c.Id == mau.Id);
            _dbContext.Update(mau);
            _dbContext.SaveChanges();
            return true;
        }
    }
}
