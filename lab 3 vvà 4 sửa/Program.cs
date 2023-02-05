using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab
{
    class Program
    {
        static int[] NhapMang()
        {
            int size = Convert.ToInt32(Console.ReadLine());
            int[] mang = new int[size];
            for (int i = 0; i < size; i++)
            {
                Console.Write("nhập phần tử thứ" + (i + 1));
                mang[i] = Convert.ToInt32(Console.ReadLine());
            }
            return mang;
        }
        static void fibo()
        {
            Console.WriteLine("nhập ");
            int n = Convert.ToInt32(Console.ReadLine());
            if (n == 1 || n == 2)
            {
                Console.WriteLine($"số fibo thư{n} là 1");
            }
            else
            {
                int f1 = 1, f2 = 1, f3 = 0, count = 0;
                while (count < n)
                {
                    f3 = f1 + f2;
                    f1 = f2;
                    f2 = f3;
                }
                Console.WriteLine($"số fibo thứ {n} là {f3}");
            }
        }
        static void ngto()
        {
            Console.WriteLine("nhập ");
            int n = Convert.ToInt32(Console.ReadLine());
            bool check = true;
            if (n < 2)
            {
                Console.WriteLine("không là số nguyên tố");
                check = false;
            }

            for (int i = 0; i <= Math.Sqrt(n); i++)//Math.Sqrt để lấy căn bậc 2 của 1 số
            {
                if (n % i == 0)
                {
                    Console.WriteLine($"{n} không phải số nguyên tố");
                    check = false;//update trạng thái nó là số nguyên tố
                    break;
                }
            }
            if (check)
            {
                Console.WriteLine($"{n} là số nguyên tố");
            }
        }
        static void TongSoLe(int[] arr)
        {
            int tong = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                tong += arr[i] * (arr[i] % 2);//số lẻ=>số lẻ *1, số chẵn=> số chẵn * 0 = 0
            }
            Console.WriteLine(tong);
        }
        static void Bai4()
        {
            Console.WriteLine("mời nhập số lượng tên: ");
            int z = Convert.ToInt32(Console.ReadLine());
            string[] ten = new string[z];
            string[] hoten = new string[z];
            string[] tenvt = new string[z];
            for (int x = 0; x < ten.Length; x++)
            {
                Console.WriteLine("mời nhập họ tên: ");
                ten[x] = Console.ReadLine();
                hoten = ten[x].Split(" ");//xóa khoảng cách giữa các tên
                tenvt[x] = hoten[hoten.Length - 1];//lấy tên đầu tiên
                for (int i = 0; i < hoten.Length - 1; i++)
                {
                    tenvt[x] += hoten[i][0];
                }
            }
            for (int x = 0; x < z; x++)
            {
                int count = 0;
                for (int i = 0; i < x; i++)
                {
                    if (tenvt[i] == tenvt[x])
                    {
                        count++;
                        continue;

                    }
                    if (count == 0)
                    {
                        Console.WriteLine(tenvt[x]);
                    }
                    else
                    {
                        Console.WriteLine(tenvt[x] + count);
                    }
                }
            }
            static void Main(string[] args)
            {
                int[] arr = NhapMang();
                TongSoLe(arr);
                Bai4();
                Console.ReadKey();
            }
        }
    }
}