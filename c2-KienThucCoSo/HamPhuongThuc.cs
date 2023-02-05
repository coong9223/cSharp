using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c2_OnTap6._0
{
    internal class HamPhuongThuc
    {
        public void PhuongThucKhongTraVe()
        {
            Console.WriteLine("không trả về");
        }
        public void PhuongThucKhongTraVe(int x)
        {
            Console.WriteLine("phương thức không trả về có tham số x = "+x);
        }
        public int TraVeMotTong()
        {
            return 10 + 20;
        }
        public int TraVeMotTong(int a, int b)
        {
            return a + b;
        }
        public static void HamTinh()
        {
            Console.WriteLine("hàm này có thể gọi được thông qua class mà ko cần tạo đối tượng");
        }
    }
}
