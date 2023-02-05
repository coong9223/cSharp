using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c2_ThamChieu
{
    internal class TinhToan
    {
        public static int MyProperty { get;set; }// property static
        public static void TinhCong()//phương thức static
        {
            Console.WriteLine("Nhập số thứ nhất");
            int x=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhập số thứ hai");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"tổng của {x} và {y} là: {x+y}"); 
        }
        //tham chiếu: là khi thực hiện các lệnh thì chúng tác động trực tiếp lên các địa chỉ ô nhớ
        //chứa các biến hông qua đó tác động lên chúng => thay đổi.

        //Với C# có 2 từ khóa ref và out để thực hiện việc này
        //truyền tham trị chỉ thực hiện lên các giá trị truyền vào mà ko ảnh hưởng đến các biến nếu
        //chúng được gọi vào như là 1 parameter (tham số)

        public static bool TryParse(string s,out int x)
        {
            x = 0;
            try
            {
                x=Convert.ToInt32(s);
                return true;
            }
            catch (Exception)
            {
                Console.WriteLine("ko ép kiểu được vì sai format");
                return false;
            }
            
        }
    }
}
