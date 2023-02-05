using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_last
{
    internal class sinhvienUDPM:sinhvien
    {
        double diemJava;
        double diemCs;

        public sinhvienUDPM()
        {
        }

        public sinhvienUDPM(double diemJava, double diemCs)
        {
            this.DiemJava = diemJava;
            this.DiemCs = diemCs;
        }
        public sinhvienUDPM (double diemJava, double diemCs, string Masv, string Ten, int Namsinh): base(Masv, Ten, Namsinh)
        {
            this.DiemJava = diemJava;
            this.DiemCs = diemCs;
        }

        public double DiemJava { get => diemJava; set => diemJava = value; }
        public double DiemCs { get => diemCs; set => diemCs = value; }
        public void Inthongtin()
        {
            base.Inthongtin();
        }
    }
}
