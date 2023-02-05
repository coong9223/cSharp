using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1.DAL.DomainClass;
using _1.DAL.iRepositories;
using _1.DAL.Context ;

namespace _1.DAL.Repositories
{
    public class SanPhamRepository:iSanPhamRepository
    {
        private FpolyDBContext _dbContext;
        public SanPhamRepository()
        {
            _dbContext = new FpolyDBContext();
        }

        bool iSanPhamRepository.Add(SanPham sp)
        {
            if(sp==null)return false;
            sp.Id=Guid.NewGuid();
            _dbContext.Add(sp);
            _dbContext.SaveChanges();
            return true;
        }

        bool iSanPhamRepository.Delete(SanPham sp)
        {
            if( sp==null)return false; 
            var temp=_dbContext.SanPhams.FirstOrDefault(c=>c.Id==sp.Id);
            _dbContext.Remove(temp);
            _dbContext.SaveChanges();
            return true;
        }

        List<SanPham> iSanPhamRepository.GetAll()
        {
            return _dbContext.SanPhams.ToList();
        }

        SanPham iSanPhamRepository.GetById(Guid id)
        {
            if (id == Guid.Empty) return null;
            return _dbContext.SanPhams.FirstOrDefault(c=>c.Id==id);
        }

        bool iSanPhamRepository.Update(SanPham sp)
        {
            if (sp == null) return false;
            var temp = _dbContext.SanPhams.FirstOrDefault(c => c.Id == sp.Id);
            temp.Ma = sp.Ma;
            temp.Ten = sp.Ten;
            _dbContext.Update(temp);
            _dbContext.SaveChanges();
            return true;
        }
    }
}
