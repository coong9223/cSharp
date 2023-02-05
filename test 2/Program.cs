using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_test_2
{
    public class Program
    {
        static int Menu()
        {
            Console.WriteLine("-----Menu-----");
            Console.WriteLine("1. Nhập 1 số nguyên");
            Console.WriteLine("2. In ra màn hình số nguyên vừa nhập");
            Console.WriteLine("3. Tính tổng các chữ số bạn vừa nhập");
            Console.WriteLine("4. Đảo ngược số bạn vừa nhập");
            Console.WriteLine("5. Tính trung bình cộng các số lẻ trong mảng");
            Console.WriteLine("6. Thoát");
            Console.WriteLine("Mời chọn mục: ");
            int x = Convert.ToInt32(Console.ReadLine());
            return x;
        }
       
        static int bai1()
        {
            Console.WriteLine("Mời bạn nhập số");
            int x = Convert.ToInt32(Console.ReadLine());
            return x;
        }
        static void bai3(int a)
        {
            int sum = 0; int x = a;
            while (a > 0)
            {
                sum += a % 10;//lấy chữ số cuối cùng của số
                a /= 10;//update giảm số đi 10 lần
            }
            Console.WriteLine($"tổng các chữ số của {x} là {sum}");
        }
        static void bai4(int a)
        {
            int songc = 0; int x = a;
            while (a > 0)
            {
                songc = songc * 10 + a % 10;
                a /= 10;//update giảm số đi 10 lần
            }
            Console.WriteLine($"chữ số đảo ngược của số {x} là {songc}");
        }
        static void bai5()
        {
            Console.WriteLine("hãy nhập số phần tử của mảng: ");
            int length = bai1();
            if (length <= 0)
            {
                Console.WriteLine("nhập lại");
            }
            else
            {
                int[] arr = new int[length]; double tong = 0; int dem = 0;
                Console.WriteLine("nhập các phần tử trong mảng");
                for (int i = 0; i < length; i++)
                {
                    arr[i] = bai1();
                    if (arr[i] % 2 != 0)
                    {
                        tong = tong + arr[i];
                        dem++;
                    }
                    Console.WriteLine($"trung bình cộng các số lẻ là:{tong / dem}");
                }
            }
        }
            static void Main(string[] args)
            {
                Console.OutputEncoding = Encoding.UTF8;
                int x = 0; // Tạp ở đây để lát dùng lại
                do
                {
                    switch (Menu())
                    {
                        case 1:
                            Console.WriteLine("Bạn vừa chọn nhập 1 số nguyên");
                            x = bai1();
                            break; // Break là bắt buộc
                        case 2:
                            Console.WriteLine("In số vừa nhập");
                            Console.WriteLine("Số bạn vừa nhập là " + x);
                            break;
                        case 3:
                            Console.WriteLine("Tính tổng các chữ số");
                            bai3(x);
                            break;
                        case 4:
                            Console.WriteLine("Đảo ngược số");
                            bai4(x);
                            break;
                        case 5:
                            Console.WriteLine("TBC số lẻ trong mảng");
                            bai5();
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

