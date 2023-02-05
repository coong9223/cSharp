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
    public class DongSpRepository : iDongSpRepository
    {
        private FpolyDBContext _dbContext;
        public DongSpRepository()
        {
            _dbContext = new FpolyDBContext();
        }

        bool iDongSpRepository.Add(DongSp dsp)
        {
            if (dsp == null) return false;
            dsp.Id = Guid.Empty;
            _dbContext.Add(dsp);
            _dbContext.SaveChanges();
            return true;
        }

        bool iDongSpRepository.Delete(DongSp dsp)
        {
            if (dsp == null) return false;
            var temp = _dbContext.DongSps.FirstOrDefault(c => c.Id == dsp.Id);
            _dbContext.Remove(temp);
            _dbContext.SaveChanges();
            return true;
        }

        List<DongSp> iDongSpRepository.GetAll()
        {
            return _dbContext.DongSps.ToList();
        }

        DongSp iDongSpRepository.GetById(Guid id)
        {
            return _dbContext.DongSps.FirstOrDefault(c => c.Id == id);
        }

        bool iDongSpRepository.Update(DongSp dsp)
        {
            if (dsp == null) return false;
            var temp = _dbContext.DongSps.FirstOrDefault(c => c.Id == dsp.Id);
            temp.Ma = dsp.Ma;
            temp.Ten = dsp.Ten;
            _dbContext.Update(temp);
            _dbContext.SaveChanges();
            return true;
        }
    }
}
