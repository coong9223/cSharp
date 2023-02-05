using System;
using System.Collections.Generic;
using c2_ôn_tập_về_hàm;
namespace OnTapHam
{
    internal class Programe
    {   static void Bai1(string t)
        {
            Console.WriteLine($"hello {t}");
        }
        static int Bai2(int a, int b)
        {
            return a + b;
        }
        static void Main(string[] args)
        {
            test t=new test();
            t.InThongiTin();
            Bai1("Nguyễn Thành Công");
            Console.WriteLine(Bai2(5, 7));   
            KeThua kt=new KeThua();
            kt.InThongiTin();
            kt.GhiDe();
        }
    }
}
