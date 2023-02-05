using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_last
{
    internal class sinhvien
    {
        private string Masv;
        private string Ten;
        private int Namsinh;

        public sinhvien()
        {
        }

        public sinhvien(string masv, string ten, int namsinh)
        {
            Masv1 = masv;
            Ten1 = ten;
            Namsinh1 = namsinh;
        }

        public string Masv1 { get => Masv; set => Masv = value; }
        public string Ten1 { get => Ten; set => Ten = value; }
        public int Namsinh1 { get => Namsinh; set => Namsinh = value; }
        public void Inthongtin()
        {
            Console.WriteLine("mã số sinh viên:" + Masv);
            Console.WriteLine("tên sinh viên:" + Ten);
            Console.WriteLine("năm sinh sinh viên:" + Namsinh);
        }
    }
}
