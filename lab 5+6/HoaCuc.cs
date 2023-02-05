using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_5_6
{
    internal class HoaCuc:Hoa
    {
        string mausac;
        int socanhhoa;
        public HoaCuc()
        {
        }
        public HoaCuc(string mausac, int socanhhoa)
        {
            this.Mausac = mausac;
            this.Socanhhoa = socanhhoa;
        }

        public string Mausac { get => mausac; set => mausac = value; }
        public int Socanhhoa { get => socanhhoa; set => socanhhoa = value; }
        public void InThongTin()
        {
            base.InThongTin();
        }
        public void PhanLoai()
        {
            Console.WriteLine("mời nhập mà sắc:");
            Mausac=Console.ReadLine();
            if (Mausac == "yellow")
                Console.WriteLine("cúc vàng");
            else if (Mausac == "violet")
                Console.WriteLine("cúc tía");
            else if (Mausac == "white")
                Console.WriteLine("cúc trắng");
            else Console.WriteLine("cúc lai");
        }
        public void PhanLoai2(int Socanhthat)
        {
            if (Socanhthat-Socanhhoa==5 || Socanhhoa - Socanhthat == 5)
                Console.WriteLine("hoa đột biên");
            else Console.WriteLine("hoa bình thường");
        }
    }
}
