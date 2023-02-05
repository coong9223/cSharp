using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1.DAL.DomainClass;


namespace _2.BUS.ViewModels
{
    public class CtSpView
    {
        public ChiTietSp ctsp { get; set; }
        public SanPham sp { get; set; }
        public DongSp dsp { get; set; }
        public Nsx nsx { get; set; }
        public MauSac ms { get; set; }
        public Guid id { get; set; }
        public Guid idSp { get; set; }
        public Guid idDsp { get; set; }
        public Guid idNsx { get; set; }
        public Guid idMs { get; set; }
        public int namBh { get; set; }
        public string moTa { get; set; }
        public int slTon { get; set; }
        public Decimal giaNhap { get; set; }
        public Decimal giaBan { get; set; }
    }
}
