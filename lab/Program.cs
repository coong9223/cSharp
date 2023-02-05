using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai_tap
{
    class Program
    {
        static void Bai1()
        {
            Console.WriteLine("Bài 1");
            Console.WriteLine("Nhập tên: ");
            string name = Console.ReadLine();
            Console.WriteLine("Nhập tuổi của bạn thân: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhập giới tính của người yêu: ");
            string gt = Console.ReadLine();
            Console.ReadLine();
        }
        static void Bai2()
        {
            Console.WriteLine("Bài 2");
            //cách 1:
            Console.WriteLine("Mời nhập số thứ 1: ");
            float x = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Mời nhập số thứ 2");
            float y = Convert.ToSingle(Console.ReadLine());
            float ketQua = x / y;
            Console.WriteLine($"Kết quả của phép tính {x} chia {y} là {ketQua}");
            //cách 2
            Console.WriteLine("mời nhập:");
            int a=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("mời nhập:");
            int b = Convert.ToInt32(Console.ReadLine());
            double ketqua = (double)a / b;
            Console.WriteLine(ketqua);
            //cách 3
            double ketqua2 = a * 1.0 / b;
            Console.WriteLine(ketqua2);
        }
        static void Bai3(int x, int y, int z)
        {
            Console.WriteLine("Bài 3");
            //cách 1
            int min = x <= y && x <= z ? x : (y <= z ? y : z);
            int max = x >= y && x >= z ? x : (y >= z ? x : z);
            if(x>min && x < max)
                { Console.WriteLine($"{x} là số cần tìm"); }
            if (y > min && y < max)
                { Console.WriteLine($"{y} là số cần tìm"); }
            if (z > min && z < max)
                { Console.WriteLine($"{z} là số cần tìm"); }
            //cách 2
            int giua = x + y + z - min - max;
            Console.WriteLine($"{giua} là số cần tìm");
            //cách 3
            int giua2 = (x - y) * (x - z) <= 0 ? x : (y - x) * (y - z) <= 0 ? y : z;
            Console.WriteLine($"{giua2} là số cần tìm");
            //cách 4
            if (x >= y && x <= z || x >= z && x <= y)
            {
                Console.WriteLine($"{x} là số cần tìm");
            }//làm tương tự với y và z
            //cách 5
            int[] arr = { x, y, z };
            Array.Sort(arr);//tự động sắp xếp mảng
            int giua3 = arr[1];
        }
        static void Bai4(string ten, string sdt, int namsinh)
        {
            //cách 1 sai
            Console.WriteLine("Bài 4");
            int dauso = sdt[1];
            int tuoi = 2022 - namsinh;
            string tenmang;
            if (dauso == 9)
            {
                tenmang = "ABC";
            }
            else if (dauso == 8)
            {
                tenmang = "XYZ";
            }
            else
            {
                tenmang = "MNP";
            }
            Console.WriteLine($"Tôi tên là:{ten}, Tôi {tuoi} tuổi, Tôi dùng mạng {tenmang}");
            //cách 2
            if (sdt.StartsWith("09") )
                {
                Console.WriteLine("nhà mạng ABC");
                }else if (sdt.StartsWith("08"))
            {
                Console.WriteLine("nhà mạng XYZ");
            }
            else
            {
                Console.WriteLine("nhà mạng MNP");
            }
        }
            //cách 3
            static void Bai5()
            {
                Console.WriteLine("mời nhập số điện thoại: ");
                int sdt2 = Convert.ToInt32(Console.ReadLine());
                if (sdt2 / 100000000 == 9)
                {
                    Console.WriteLine("mạng đang dùng là ABC");
                }
                else if (sdt2 / 100000000 == 8)
                {
                    Console.WriteLine("mạng đang dùng là XYZ");
                }
                else { Console.WriteLine("mạng đang dùng là MNP"); }
            }
             

            static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Bai1();
            Bai2();
            Bai3(6,5,7);
            Bai4("Nguyễn Thành Công", "0962968674", 2003);
            Bai5();
            Console.ReadLine();
        }
    }
}