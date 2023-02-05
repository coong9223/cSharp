using _1.DAL.DomainClass;
using System;
using System.Collections.Generic;
using System.Text;

namespace _2.BUS.ViewModels
{
    public class QLNhanVienView
    {
        public NhanVien NhanVien { get; set; }
        public ChucVu ChucVu { get; set; }
        public CuaHang CuaHang { get; set; }
    }
}
