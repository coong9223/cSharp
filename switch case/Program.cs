using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace switch_case { 
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("mời nhập lựa chọn: ");
            int x = Convert.ToInt32(Console.ReadLine());
            string s = Console.ReadLine();
            switch (x)
            {
                case 1:
                   Console.WriteLine("bạn vừa chọn 1");
                    break;
                case 2:
                    Console.WriteLine("bạn vừa chọn 2");
                    break;
                default:
                    Console.WriteLine("bạn phải nhập 1 hoặc 2");
                    break;
            }

            switch (s)
            {
                case "abc":
                    Console.WriteLine("bạn vừa chọn 1");
                    break;
                case "xyz":
                    Console.WriteLine("bạn vừa chọn 2");
                    break;
                default:
                    Console.WriteLine("bạn phải nhập 1 hoặc 2");
                    break;
            }
            //
            //vòng lặp for
            int i = 0;//tạo trước 1 biến chạy
            for (; i < 10; i++)//for + tab tab
            {
                Console.WriteLine(i + " ");
            }//kiểm tra biến-kiểm tra điều kiện-câu lệnh-update biến
            Console.WriteLine("i=" + i);
            //
            //mảng
            //<kiểu dữ liệu> [] <tên mảng>;
            int[] arr;// khai báo mảng rỗng
            int[] brr = new int[10];//khải báo mảng có 10 phần tử
            int[] crr = { 1, 2, 3, 4, 5, 6, 7, 9, 8 };//khởi tạo mảng xác định
            for (int m = 0; m < brr.Length; m++)//Lngth == độ dài
            {
                Console.WriteLine(brr[m] + " ");
            }
            //
            for (int z = 0; z < crr.Length; z++)
            {
                if (crr[z]%2 == 0)
                {
                     Console.WriteLine(crr[z] + " ");
                }             
            }
            Console.WriteLine(String.Join(",", crr));//in cả mảng

            //vòng lặp while 
            int a = 0;
            while (x<=100)
            {
                Console.WriteLine("hãy nhập các số >100");
               x = Convert.ToInt32(Console.ReadLine());//update
            }//điều kiện -> câu lệnh

            //vòng lặp đo-while
            do
            {
                Console.WriteLine("hãy nhập các số <0");
                x = Convert.ToInt32(Console.ReadLine());//update
            } while (x >= 0);//câu lệnh->điều kiện->câu lệnh
            Console.WriteLine("x=" + x);
            //
            //vòng lặp foreach
            foreach (int item in crr)
            {
                Console.WriteLine(item);
            }

            //làm một menu cho phép người dùng nhập đến khi chọn chức năng thoát
            //cách 1
            Console.WriteLine("mời nhập số: ");
            int b;
            do
            {
                b= Convert.ToInt32(Console.ReadLine());
                switch (b)
                {
                    case 0:
                        Console.WriteLine("thoát");
                        //System.Environment.Exit(0);
                        break;
                    case 1:
                        Console.WriteLine("bạn đã chọn chức năng 1");
                        break;
                    case 2:
                        Console.WriteLine("bạn đã chọn chức năng 2");
                        break ;
                    default:
                        Console.WriteLine("mời nhập lại ");
                        break;
                }
            } while (b != 0);

            //cách 2
            do
            {
                b = Convert.ToInt32(Console.ReadLine());
                switch (b)
                {
                    case 0:                     
                        System.Environment.Exit(0);
                        break;
                    case 1:
                        Console.WriteLine("bạn đã chọn chức năng 1");
                        break;
                    case 2:
                        Console.WriteLine("bạn đã chọn chức năng 2");
                        break;
                    default:
                        Console.WriteLine("mời nhập lại ");
                        break;
                }
            } while (b != 0);
            //cách 3
            
            static void vongLap()
            {
                int c;
                int thoat = 0;
                do
                {
                    c = Convert.ToInt32(Console.ReadLine());
                    switch (c)
                    {
                        case 0:
                            thoat = 1;
                            break;
                        case 1:
                            Console.WriteLine("bạn đã chọn chức năng 1");
                            break;
                        case 2:
                            Console.WriteLine("bạn đã chọn chức năng 2");
                            break;
                        default:
                            Console.WriteLine("mời nhập lại ");
                            break;
                    }
                } while (thoat == 0);
            }
            Console.ReadKey();
        }
    }
}