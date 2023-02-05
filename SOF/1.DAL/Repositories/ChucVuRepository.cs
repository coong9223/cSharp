using _1.DAL.Context;
using _1.DAL.DomainClass;
using _1.DAL.IRepositories;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;


namespace _1.DAL.Repositories
{
    public class ChucVuRepository : IChucVuRepository
    {
        private FpolyDBContext _dbContext;
        public ChucVuRepository()
        {
            _dbContext = new FpolyDBContext();
        }
        public bool Add(ChucVu obj)
        {
            if (obj == null) return false;
            obj.Id = Guid.NewGuid();
            _dbContext.ChucVus.Add(obj);
            _dbContext.SaveChanges();
            return true;
        }

        public bool Delete(ChucVu obj)
        {

            if (obj == null) return false;
            var temp = _dbContext.ChucVus.FirstOrDefault(x => x.Id == obj.Id); 
            _dbContext.ChucVus.Remove(temp);
            _dbContext.SaveChanges();
            return true;
        }

        public List<ChucVu> GetAll()
        {
            return _dbContext.ChucVus.ToList();
        }

        public ChucVu GetById(Guid id)
        {
            if(id == Guid.Empty) return null;
            return _dbContext.ChucVus.FirstOrDefault(x => x.Id == id);
        }

        public bool Update(ChucVu obj)
        {

            if (obj == null) return false;
            var temp = _dbContext.ChucVus.FirstOrDefault(x => x.Id == obj.Id);
            temp.Ma = obj.Ma;
            temp.Ten = obj.Ten;
            _dbContext.ChucVus.Update(temp);
            _dbContext.SaveChanges();
            return true;

        }
    }
}
