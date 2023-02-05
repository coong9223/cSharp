using Project_Template_SM22_Csharp.Context;
using Project_Template_SM22_Csharp.DomainModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Project_Template_SM22_Csharp.Repositories
{
    public class XeMayRepositories
    {
        private FpolyDBContext _DbContext;
        public XeMayRepositories()
        {
            _DbContext = new FpolyDBContext();
        }
        public bool AddXeMayRepositories(XeMay obj )
        {
            if( obj == null ) return false;
            _DbContext.Add(obj);
            _DbContext.SaveChanges();
            return true;    
        }
        public bool UpdateXeMayRepositories(XeMay obj)
        {
            if (obj == null) return false;
            _DbContext.Update(obj);
            _DbContext.SaveChanges();
            return true;
        }
        public bool DeleteXeMayRepositories(XeMay obj)
        {
            if (obj == null) return false;
            _DbContext.Remove(obj);
            _DbContext.SaveChanges();
            return true;
        }
        public List<XeMay> GetAll()
        {
            return _DbContext.XeMays.ToList();
        }

    }
}
