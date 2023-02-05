using _1.DAL.DomainModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.ViewModels
{
    public class QLNhanVienView
    {
        public NhanVien NhanVien { get; set; }
        public ChucVu ChucVu { get; set; }
        public CuaHang CuaHang { get; set; }

    }
}
