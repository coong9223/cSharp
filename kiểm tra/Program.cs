using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test1
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            do
            {
                Console.WriteLine("Mời nhập số: ");
                x = Convert.ToInt32(Console.ReadLine());
                switch (x)
                {
                    case 1:
                        int a, b;
                        {
                        Console.WriteLine("Bạn đã chọn mục: nhập 2 số a và b.");
                        Console.WriteLine("Mời bạn nhập số thứ 1: ");
                        a=Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Mời bạn nhập số thứ 2: ");
                        b=Convert.ToInt32(Console.ReadLine()); 
                        Console.WriteLine($"Hai số vừa nhập là {a} và {b}");
                        }
                        
                        break;
                    case 2:
                        Console.WriteLine("Bạn đã chọn mục: tính tổng các số từ a đến b vừa nhập.");
                        int sum = 0;
                        int i = 0;
                        {
                            Console.WriteLine("Mời bạn nhập số thứ 1: ");
                            a = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Mời bạn nhập số thứ 2: ");
                            b = Convert.ToInt32(Console.ReadLine());
                            for(;i>=a && i <= b; i++)
                            {
                                sum += i;
                                break;
                            }
                            Console.WriteLine($"tổng các số từ {a} đến {b} = {sum}");
                        }                       
                        break;
                    case 3:
                        Console.WriteLine("Bạn đã chọn muc: tính a mũ b vừa nhập.");
                        {
                            Console.WriteLine("Mời bạn nhập số thứ 1: ");
                            a = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Mời bạn nhập số thứ 2: ");
                            b = Convert.ToInt32(Console.ReadLine());
                            int so = a;
                            for(;so <= b; so++)
                            {
                                
                            }
                        }
                        break;
                    case 4:
                        Console.WriteLine("Bạn đã chọn mục: tính trung bình cộng của mảng vừa nhập vào.");
                        double tb;
                        int sopt = 0;
                        {
                            Console.WriteLine("Mời bạn nhập số thứ 1: ");
                            a = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Mời bạn nhập số thứ 2: ");
                            b = Convert.ToInt32(Console.ReadLine());
                            sopt = b - a + 1;
                            tb = sum / sopt;
                            Console.WriteLine($"Trun g bình cộng mảng vừa nhập ={tb} ");
                        }
                        break;
                    default:
                        Console.WriteLine("Mời bạn nhập lại");
                        break;
                }
            } while (x != 0);
            Console.ReadKey();  
        }
    }
}


