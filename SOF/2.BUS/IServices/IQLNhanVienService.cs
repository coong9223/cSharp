using _2.BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace _2.BUS.IServices
{
    public interface IQLNhanVienService
    {
        string Add(QLNhanVienView obj);
        string Update(QLNhanVienView obj);
        string Delete(QLNhanVienView obj);
        List<QLNhanVienView> GetAll();
    }
}
