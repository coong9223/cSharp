using System;
using System.Collections.Generic;
using System.Text;

namespace HamPhuongThuc_List
{
    public class HamPhuongThuc
    {
         public void HamKhongTraVe()
        {
            Console.WriteLine("hàm này không trả về");
        }

        public void HamKhongTraVeChoTruoc(int x)
        {
            Console.WriteLine("hàm này trả về giá trị của x = " + x);
        }

        public int HamTraVe()
        {
            return 10 + 20;
        }

        public int HamTraVeChoTruoc(int a, int b)
        {
            return a + b;
        }
    }
}
