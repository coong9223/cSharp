using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static List<NganhHoc> list = new List<NganhHoc>();
        static Service sv = new Service(list);
        static string Menu()
        {
            
            Console.WriteLine("------menu------");
            Console.WriteLine("1.Nhập danh sách đối tượng");
            Console.WriteLine("2.Xuất danh sách đối tượng");
            Console.WriteLine("3. Xuất các ngành học có kỳ học lớn hơn 6");
            Console.WriteLine("4. Xóa kỳ học theo ID nhập vào");
            Console.WriteLine("0.Thoát");
            Console.WriteLine("mời nhập mục chọn:");
            string chon=Console.ReadLine();
            return chon;
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            do
            {
                switch (Menu())
                {
                    case "1":
                        sv.NhapDS();
                        break;
                    case "2":
                        sv.XuatDS();
                        break;
                    case "3":
                        sv.XuatDSKyHoc();
                        break;
                    case "4":
                        sv.Remove();
                        break;
                    case "0":
                        System.Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("mời nhập lại: ");
                        break;
                }
            }while (true);
            Console.ReadKey();
        }
    }
}
