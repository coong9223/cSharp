using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_5_6
{
    internal class HoaHong:Hoa
    {
        string phanloai;
        string mausac;
        public HoaHong()
        {
        }
        public HoaHong(string phanloai, string mausac, string name, string vungss):base(name,vungss)
        {
            this.Phanloai = phanloai;
            this.Mausac = mausac;
        }

        public string Phanloai { get => phanloai; set => phanloai = value; }
        public string Mausac { get => mausac; set => mausac = value; }
        public void ThongTin()
        {   base.InThongTin();
            Console.WriteLine("mời nhập mà sắc của hoa:");
            Mausac = Console.ReadLine();           
            if (Mausac == "pink")
                Phanloai = "hồng";
            else if (Mausac == "white")
                Phanloai = "hồng bạch";           
            else if (Mausac == "blue")
                Phanloai = "hồng xanh";            
            else Phanloai = "hồng lai"; 
            Console.WriteLine($"Phân loại hoa hồng: {Phanloai}");  
        }
    }
}
