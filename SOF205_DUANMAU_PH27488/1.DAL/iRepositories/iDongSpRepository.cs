using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1.DAL.DomainClass;

namespace _1.DAL.iRepositories
{
    public interface iDongSpRepository
    {
        bool Add(DongSp dsp);
        bool Update(DongSp dsp);
        bool Delete(DongSp dsp);
        DongSp GetById(Guid id);
        List<DongSp> GetAll();
    }
}
