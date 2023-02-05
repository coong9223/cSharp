using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1.DAL.DomainClass;

namespace _2.BUS.ViewModels
{
    public class NhanVienView
    {
        public NhanVien nv { get; set; }
        public Guid id { get; set; }
        public string ma { get; set; }
        public string ten { get; set; }
        public string tenDem { get; set; }
        public string ho { get; set; }
        public string gioiTinh { get; set; }
        public DateTime ngSinh { get; set; }
        public string diaChi { get; set; }
        public string sdt { get; set; }
        public string matKhau { get; set; }
        public CuaHang ch { get; set; }
        public ChucVu cv { get; set; }
        public Guid idGuiBc { get; set; }
        public int status { get; set; }
    }
}
