using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab
{
    class Program
    {
        static int Nhapso()
        {
            int x = Convert.ToInt32(Console.ReadLine());
            return x;
        }
        static void Bai1()
        {
            Console.WriteLine("nhập số phần tử trong mảng: ");
            int a = Nhapso();
            int[] x = new int[a];
            Console.WriteLine("nhập giá trị cho từng phần tử trong mảng: ");
            for (int i = 0; i < a; i++)
            {
                x[i] = Nhapso();
            }
            int max = x[0];
            int max2 = int.MinValue;
            for (int i = 0; i < a; i++)
            {
                if (max < x[i])
                {
                    max = x[i];
                }
            }
            for (int j = 0; j < a; j++)
            {
                if (max2 < x[j] && max != x[j])
                {
                    max2 = x[j];
                }
            }
            Console.WriteLine("Phần tử lớn thứ 2 trong mảng là: " + max2);
            //bài 3
            int sum = x.Select(x => x * (x % 2)).Sum();
            Console.WriteLine($"tổng là: {sum}");
        }

        static void Bai2()
        {
        nhaplai:
            Console.WriteLine("mời nhập số: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int fn = 0;
            int fn1 = 1;
            int fn2 = 1;
            int dem = 0;
            if (n < 1)
            {
                Console.WriteLine($"{n} không là số nguyên tố");
                goto nhaplai;
            }
            for (int i = 1; i < n; i++)
            {
                if (n % i == 0)
                    dem++;
            }
            if (dem == 1)
                Console.WriteLine($"{n} là số nguyên tố");
            else
                Console.WriteLine($"{n} không là số nguyên tố");
            //if (n <= 1)
            //{
            //    Console.WriteLine($"{n} không phải là số nguyên tố");
            //}
            //else
            //{
            //    for (int a = 2; a < n; a++)
            //    {
            //        if (n % a != 0)
            //        {
            //            Console.WriteLine($"{n} là số nguyên tố");
            //        }
            //        else 
            //        { Console.WriteLine($"{n} ko là số nguyên tố"); }
            //    }
            //}
            if (n == 0)
            {
                Console.WriteLine($"số fibonacci thứ {n} = {n}");
            }
            else if (n == 1 || n == 2)
            {
                Console.WriteLine($"số fibonacci thứ {n} = {fn1}");
            }
            else
            {
                for (int i = 3; i <= n; i++)//số fibonacci = tổng 2 số fibonacci liền trước
                {
                    fn = fn1 + fn2;//=> fn > fn2
                    fn1 = fn2;//=> fn1 = fn2
                    fn2 = fn;//=> fn2 = fn của vòng trước để bắt đầu tính cho vòng lặp mới
                }
                Console.WriteLine($"số fibonacci thứ {n} = {fn}");

            }
        }
        //static void Bai3()
        //{
        //    Console.WriteLine("mời nhập số lượng phần tử trong mảng:");
        //    int b = Nhapso(); 
        //    int tong = 0; 
        //    int dem = 0;
        //    int[] y = new int[b];
        //    for (int i = 0; i <= y.Length; i++)
        //    {
        //        y[i] = Nhapso();              
        //    }
        //    for(int i = 0; i <= y.Length; i++)
        //    {
        //        Console.WriteLine($"{y[i]}\n");
        //        while (y[i] % 2 != 0)
        //        {
        //            tong = tong + y[i];
        //            dem++;
        //        } 
        //    }
        //    Console.WriteLine($"trung bình cộng các số lẻ trong mảng là {tong * 1.0 / dem}");
        //}
        static void Bai4()
        {
            //Console.WriteLine("mời nhập số lượng tên: ");
            //int z = Nhapso();
            //string[] ten = new string[z];
            //string[] hoten = new string[z];
            //string[] tenvt = new string[z];
            //for (int x = 0; x < ten.Length; x++)
            //{
            //    Console.WriteLine($"mời nhập họ tên thứ {x+1}: ");
            //    ten[x] = Console.ReadLine();
            //    hoten = ten[x].Split(" ");//xóa khoảng cách giữa các tên
            //    tenvt[x] = hoten[hoten.Length - 1];//lấy tên đầu tiên
            //    for (int i = 0; i < hoten.Length - 1; i++)
            //    {
            //        tenvt[x] += hoten[i][0];
            //    }
            //}
            //for (int x = 0; x < z; x++)
            //{
            //    int count = 1;
            //    for (int i = 0; i < x; i++)
            //    {
            //        if (tenvt[x] == tenvt[i])
            //        {
            //            count++;
            //            continue;
            //        }
            //    }
            //    if (count == 1)
            //        Console.WriteLine(tenvt[x]);
            //    else
            //        Console.WriteLine(tenvt[x] + count);
            //}
            Console.WriteLine("số tên bạn muốn nhập là: ");
            int size = Convert.ToInt32(Console.ReadLine());
            string[] mangten = new string[size];
            for (int i = 0; i < size; i++) // nhập tên
            {
                Console.WriteLine("nhập tên thứ {0}: ", i + 1);
                mangten[i] = Console.ReadLine();
            }
            string[] ketqua = new string[size];
            for (int i = 0; i < size; i++) // cắt tên
            {
                string[] catten = mangten[i].Split(' ');
                ketqua[i] = catten[catten.Length - 1];
                for (int j = 0; j < catten.Length - 1; j++)
                {
                    ketqua[i] += catten[j][0];
                }
            }
            Array.Sort(ketqua);
            for (int i = 0; i < ketqua.Length - 1; i++) // lọc những tên trúng nhau
            {
                int x = 1;
                for (int j = i + 1; j <= ketqua.Length - 1; j++)
                {
                    if (ketqua[j] == ketqua[i])
                    {
                        ketqua[j] += x;
                        x++;
                    }
                }
            }
            foreach (string item in ketqua) // show kết quả
            {
                Console.WriteLine(item);
            }
        }            
            static void Main(string[] args)
            {
                Console.OutputEncoding = Encoding.UTF8;
                int x = 0;
                Bai1();
                Bai2();
                //Bai3();
                Bai4();
                Console.ReadKey();
            }
        }
    }


