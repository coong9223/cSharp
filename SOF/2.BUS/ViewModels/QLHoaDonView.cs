using _1.DAL.DomainClass;
using System;
using System.Collections.Generic;
using System.Text;

namespace _2.BUS.ViewModels
{
    public class QLHoaDonView
    {
        public HoaDon HoaDon { get; set; }
        public HoaDonChiTiet HoaDonChiTiet { get; set; }
        public KhachHang KhachHang { get; set; }
        public NhanVien NhanVien { get; set; }
        public QLSanPhamView QLSanPhamView { get; set; }
    }
}
