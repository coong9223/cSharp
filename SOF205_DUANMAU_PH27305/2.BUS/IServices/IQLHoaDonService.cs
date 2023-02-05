using _2.BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.IServices
{
    public interface IQLHoaDonService
    {
        string Add(QLHoaDonView obj);
        string Update(QLHoaDonView obj);
        string Delete(QLHoaDonView obj);
        List<QLHoaDonView> GetAll();
    }
}
