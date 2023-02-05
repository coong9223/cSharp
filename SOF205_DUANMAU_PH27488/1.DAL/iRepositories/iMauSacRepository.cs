using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1.DAL.DomainClass;

namespace _1.DAL.iRepositories
{
    public interface iMauSacRepository
    {
        bool Add(MauSac mau);
        bool Update(MauSac mau);
        bool Delete(MauSac mau);
        MauSac GetById(Guid id);
        List<MauSac> GetAll();
    }
}
