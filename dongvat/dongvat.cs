using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dongvat
{
    internal class dongvat
    {
        string ten;
        double trongluongtb;

        public dongvat()
        {
        }
        public dongvat(string ten, double trongluongtb)
        {
            this.Ten = ten;
            this.Trongluongtb = trongluongtb;
        }

        public string Ten { get => ten; set => ten = value; }
        public double Trongluongtb { get => trongluongtb; set => trongluongtb = value; }
        public void showthongtin()
        {
            Console.WriteLine($"tên động vật: {ten}" );
            Console.WriteLine($"trọng lượng trung bình là: {trongluongtb} " );
        }
    }
}
