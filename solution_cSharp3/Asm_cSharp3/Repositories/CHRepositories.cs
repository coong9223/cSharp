using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Asm_cSharp3.DomainClass;
using Asm_cSharp3.Context;

namespace Asm_cSharp3.Repositories
{
    public class CHRepositories
    {
        public FpolyDBContext _dbContext;
        public CHRepositories()
        {
            _dbContext = new FpolyDBContext();
        }
        public List<CuaHang> GetAll()
        {
            return _dbContext.CuaHangs.ToList();
        }

        public bool Add(CuaHang ch)
        {
            if (ch == null) return false;
            ch.Id = Guid.NewGuid();
            _dbContext.Add(ch);
            _dbContext.SaveChanges();
            return true;
        }

        public bool Update(CuaHang ch)
        {
            if (ch == null) return false;
            _dbContext.Update(ch);
            _dbContext.SaveChanges();
            return true;
        }

        public bool Delete(CuaHang ch)
        {
            if(ch == null) return false;
            _dbContext.Remove(ch);
            _dbContext.SaveChanges();
            return true;
        }
    }
}
