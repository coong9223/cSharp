using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VongLap_Menu
{
    class Program
    {
        static int Menu()
        {
            Console.WriteLine("Chức năng 1: Nhập 2 số nguyên");
            Console.WriteLine("Chức năng 2: Tổng các số từ a đến b");
            Console.WriteLine("Chức năng 3: Tính a^b ");
            Console.WriteLine("Chức năng 4: Tính trung bình cộng một mảng");
            Console.WriteLine("Chức năng 5: Thoát");
            int x = Convert.ToInt32(Console.ReadLine());
            return x;
        }

        static int NhapSo()
        {
            Console.Write("Nhập 1 số nào đó: ");
            int x = Convert.ToInt32(Console.ReadLine());
            return x;
        }

        static void TongTuAdenB(int a, int b)
        {
            int tong = 0;
            if (a > b)
            {
                Console.WriteLine($"{a} đang lớn hơn {b}, không tính được đâu");
            }
            else
            {
                for (int i = a; i <= b; i++)
                {
                    tong += i;
                }
            }
            Console.WriteLine($"Tổng các số từ {a} đến {b} là: {tong}");
        }

        static void SoMu(int a, int b)
        {
            //Cách 1: Vòng for
            //long x = 1;
            //if (b == 0)
            //{
            //    Console.WriteLine($"{a}^{b} = 1");
            //}
            //else
            //{
            //    for (int i = 1; i <= b; i++)
            //    {
            //        x *= a;
            //    }
            //    Console.WriteLine($"{a}^{b} = {x}");
            //}
            // Cách 2: Dùng hàm Pow
            Console.WriteLine($"{a}^{b} = {Math.Pow(a, b)}");

        }
        static void TBCMang()
        {
            Console.WriteLine("Nhập kích thước mảng mà bạn mong muốn");
            int length = NhapSo();
            if (length <= 0)
            {
                Console.WriteLine("Kích thước mảng phải > 0");
            }
            else
            {
                double tong = 0;
                int[] arr = new int[length];
                for (int i = 0; i < length; i++)
                {
                    arr[i] = NhapSo(); tong += arr[i];
                }
                Console.WriteLine($"Trung bình cộng của mảng vừa nhập là {Math.Round(tong / length, 2)}");
            }
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            int x = 0, y = 0;
            do
            {
                switch (Menu())
                {
                    case 1:
                        Console.WriteLine("Bạn vừa chọn nhập 2 số nguyên");
                        x = NhapSo();
                        y = NhapSo();
                        break; // Break là bắt buộc
                    case 2:
                        Console.WriteLine("Tổng các chữ số từ a đến b");
                        TongTuAdenB(x, y);
                        break;
                    case 3:
                        Console.WriteLine("Tính a ^ b");
                        SoMu(x, y);
                        break;
                    case 4:
                        TBCMang();
                        break;
                    case 5:
                        return;
                        break;
                    default:
                        Console.WriteLine("Hãy chọn 1 hoặc 2 hoặc 3");
                        break;
                }
            } while (true);
            // Viết hàm tạo 1 menu, hãy cho phép người dùng nhập chán
            // thì thôi cho đến khi chọn chức năng 4: thoát
            Console.ReadKey();
        }
    }
}