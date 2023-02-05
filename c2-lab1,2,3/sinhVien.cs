using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c2_lab1_2_3
{
    internal class sinhVien
    {
        string Mssv;
        string Name;
        int Age;

        public sinhVien()
        {
        }

        public sinhVien(string mssv, string name, int age)
        {
            Mssv1 = mssv;
            Name1 = name;
            Age1 = age;
        }

        public string Mssv1 { get => Mssv; set => Mssv = value; }
        public string Name1 { get => Name; set => Name = value; }
        public int Age1 { get => Age; set => Age = value; }
        public void InThongTin()
        {
            Console.WriteLine($" mã sv: {Mssv}, tên: {Name}, tuổi: {Age} ");
        }
    }
}
