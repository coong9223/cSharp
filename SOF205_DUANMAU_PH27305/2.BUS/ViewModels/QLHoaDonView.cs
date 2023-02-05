using _1.DAL.DomainModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.ViewModels
{
    public class QLHoaDonView
    {
        public HoaDon HoaDon { get; set; }
        public HoaDonChiTiet HoaDonChiTiet { get; set; }      
        public KhachHang KhachHang { get; set; }
        public NhanVien NhanVien { get; set; }
        public ChiTietSp ChiTietSp { get; set; }
        public SanPham SanPham { get; set; }
        public QLSanPhamView QLSanPhamView { get; set; }
    }
}
