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
    public class NhanVienRepositoriesL : iNhanVienRepository
    {
        private FpolyDBContext _dbContext;
        public NhanVienRepositoriesL()
        {
            _dbContext = new FpolyDBContext();   
        }
        bool iNhanVienRepository.Add(NhanVien nv)
        {
            if (nv == null) return false;
            nv.Id = Guid.Empty;
            _dbContext.Add(nv);
            _dbContext.SaveChanges();
            return true;
        }

        bool iNhanVienRepository.Delete(NhanVien nv)
        {
            if(nv==null)return false;
            var temp=_dbContext.NhanViens.FirstOrDefault(c=>c.Id==nv.Id);
            _dbContext.Remove(nv);
            _dbContext.SaveChanges();
            return true;
        }

        List<NhanVien> iNhanVienRepository.GetAll()
        {
            return _dbContext.NhanViens.ToList();
        }

        NhanVien iNhanVienRepository.GetById(Guid id)
        {
            return _dbContext.NhanViens.FirstOrDefault(c=>c.Id== id);
        }

        bool iNhanVienRepository.Update(NhanVien nv)
        {
            if(nv==null)return false;
            var temp=_dbContext.NhanViens.FirstOrDefault(c=>c.Id==nv.Id);
            _dbContext.Update(nv);
            _dbContext.SaveChanges();
            return true;
        }
    }
}
