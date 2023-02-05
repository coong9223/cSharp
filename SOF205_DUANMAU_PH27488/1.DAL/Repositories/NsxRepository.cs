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
    public class NsxRepository:iNsxRepository
    {
        private FpolyDBContext _dbContext;
        public NsxRepository()
        {
            _dbContext = new FpolyDBContext();
        }

        bool iNsxRepository.Add(Nsx nsx)
        {
            if (nsx == null) return false;
            nsx.Id = Guid.Empty;
            _dbContext.Add(nsx);
            _dbContext.SaveChanges();
            return true;
        }

        bool iNsxRepository.Delete(Nsx nsx)
        {
            if (nsx == null) return false;
            var temp=_dbContext.Nsxes.FirstOrDefault(c=>c.Id==nsx.Id);  
            _dbContext.Remove(nsx);
            _dbContext.SaveChanges();
            return true;
        }

        List<Nsx> iNsxRepository.GetAll()
        {
            return _dbContext.Nsxes.ToList();
        }

        Nsx iNsxRepository.GetById(Guid id)
        {
            return _dbContext.Nsxes.FirstOrDefault(c=>c.Id==id);
        }

        bool iNsxRepository.Update(Nsx nsx)
        {
            if (nsx == null) return false;
            var temp = _dbContext.Nsxes.FirstOrDefault(c => c.Id == nsx.Id);
            _dbContext.Update(nsx);
            _dbContext.SaveChanges();
            return true;
        }
    }
}
