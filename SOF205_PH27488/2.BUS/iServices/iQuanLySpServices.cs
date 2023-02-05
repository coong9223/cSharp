using System;
using System.Collections.Generic;
using System.Text;
using _2.BUS.ViewModels;

namespace _2.BUS.iServices
{
    public interface iQuanLySpServices
    {
        string Add(SanPhamView obj);
        string Update(SanPhamView obj);
        string Delete(SanPhamView obj);
        List<SanPhamView> GetAll(); 
    }
}
