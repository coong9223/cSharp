//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace BaiTapKoLienQuan
//{
//    class Program
//    {
//        static void Bai1()
//        {
//            Console.WriteLine("mời nhập số lượng phần tử: ");
//            int n=Convert.ToInt32(Console.ReadLine());
//            int[] arr=new int[n];
//            int i;
//            if (n <= 0)
//            {
//                Console.WriteLine("không hợp lệ, mời nhập lại");
//            }
//            else
//            {
//                Console.WriteLine("mời nhập các giá trị");
//                for(i=0; i<arr.Length; i++)
//            {
//                arr[i]=Convert.ToInt32(Console.ReadLine());
//            }
//            }
//            for(i = 0; i < arr.Length-1; i++)
//            {
//                for(int j = i+1;j< arr.Length; j++)
//                {
//                    if (Math.Abs(arr[i]) > Math.Abs(arr[j]))                      
//                    {
//                        int temp = Math.Abs(arr[i]);
//                        arr[i] = Math.Abs(arr[j]);
//                        arr[j] = temp;
//                    }
//                }
//            }Console.WriteLine("xuất mảng");
//            for (i = 0; i < arr.Length; i++)
//            {
//                Console.WriteLine($"{Math.Abs(arr[i])}\t");
//            }
//        }
//        static void Main(string[] args)
//        {
//            Console.OutputEncoding = Encoding.UTF8;
//            Bai1();
//            Console.ReadKey();
//        }
//    }
//}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapKoLienQuan
{
    class Program
    {
        static void Bai1()
        {
            Console.WriteLine("mời nhập số lượng phần tử: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];
            int i;
            if (n <= 0)
            {
                Console.WriteLine("không hợp lệ, mời nhập lại");
            }
            else
            {
                Console.WriteLine("mời nhập các giá trị");
                for (i = 0; i < arr.Length; i++)
                {
                    arr[i] = Convert.ToInt32(Console.ReadLine());
                }
            }
            for (i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (Math.Abs(arr[i]) > Math.Abs(arr[j]))
                    {
                        int temp = Math.Abs(arr[i]);
                        arr[i] = Math.Abs(arr[j]);
                        arr[j] = temp;
                    }
                }
            }
            Console.WriteLine("xuất mảng");
            for (i = 0; i < arr.Length; i++)
            {
                Console.Write($"{arr[i]}\t");
            }
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Bai1();
            Console.ReadKey();
        }
    }
}