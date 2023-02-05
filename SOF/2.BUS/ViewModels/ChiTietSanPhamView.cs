using System;
using System.Collections.Generic;
using System.Text;

namespace _2.BUS.ViewModels
{
    public class ChiTietSanPhamView
    {
        public Guid IdChitietSp { get; set; }
        public Guid? IdSp { get; set; }
        public string MaSp { get; set; }
        public string TenSp { get; set; }
        public string TenDongSp { get; set; }
        public string TenNsx { get; set; }
        public string TenMauSac { get; set; }
        public int? SoLuongTon { get; set; }
        public decimal? GiaNhap { get; set; }
        public decimal? GiaBan { get; set; }
        public int NamBh { get; set; }
        public string MoTa { get; set; }
    }
}
