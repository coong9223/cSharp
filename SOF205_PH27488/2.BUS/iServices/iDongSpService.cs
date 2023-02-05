using System;
using System.Collections.Generic;
using System.Text;
using _1.DAL.DomainClass;

namespace _2.BUS.iServices
{
    public interface iDongSpService
    {
        public string Add(DongSp obj);
        public string Update(DongSp obj);
        public string Delete(DongSp obj);
        List<DongSp> GetAll();
        DongSp GetById(Guid id);
        Guid GetIdFormTen(string ten);
    }
}
