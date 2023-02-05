using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dongvat
{
    internal class bo:dongvat
    {
        string giongloai;

        public bo()

        {
        }

        public bo(string giongloai, string ten, double trongluongtb):base (ten, trongluongtb)
        {
            this.Giongloai = giongloai;
        }

        public string Giongloai { get => giongloai; set => giongloai = value; }
        public void thongtin()
        {
            Console.WriteLine("con bò kê alo");
        }
        public void chay()
        {
            Console.WriteLine("con bò chạy cắm mặt");
        }
        public void chay(int x)
        {
            Console.WriteLine("con bò chạy với tốc độ" + x);
        }
    }
}
