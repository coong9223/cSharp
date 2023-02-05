using _2.BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.IServices
{
    public interface IQLNhanVienService
    {
        string Add(QLNhanVienView obj);
        string Update(QLNhanVienView obj);
        string Delete(QLNhanVienView obj);
        List<QLNhanVienView> GetAll();
        List<string> TrangThai();
    }
}
