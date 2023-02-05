using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1.DAL.DomainClass;

namespace _2.BUS.ViewModels
{
    public class CuaHangView
    {
        public CuaHang ch { get; set; }
        public Guid id { get; set; }
        public string ma { get; set; }
        public string ten { get; set; }
        public string diaChi { get; set; }
        public string thanhPho { get; set; }
        public string quocGia { get; set; }
    }
}
