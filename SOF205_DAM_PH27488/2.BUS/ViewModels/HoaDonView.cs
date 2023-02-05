using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1.DAL.DomainClass;

namespace _2.BUS.ViewModels
{
    public class HoaDonView
    {
        public HoaDon hd { get; set; }
        public KhachHang kh { get; set; }
        public NhanVien nv { get; set; }
        public Guid id { get; set; }
        public string ma { get; set; }
        public DateTime ngTao { get; set; }
        public DateTime ngThanhToan { get; set; }
        public DateTime ngShip { get; set; }
        public DateTime ngNhan { get; set; }
        public int status { get; set; }
        public string tenNgNhan { get; set; }
        public string diaChi { get; set; }
        public string sdt { get; set; }
    }
}
