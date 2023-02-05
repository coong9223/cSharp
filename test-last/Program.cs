using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_last
{
    internal class Program
    {
        static List<sinhvien> list = new List<sinhvien>();
        static service sv = new service(list);//tạo 1 đối tượng kiểu service toàn cục
        static string Menu()
        {
            
            Console.WriteLine("-------Menu-------");
            Console.WriteLine("1. nhập danh sách đối tượng");
            Console.WriteLine("2.xuất danh sách đối tượng");
            Console.WriteLine("3.xuất danh sách các sinh vien tuổi từ 25 trở xuống");
            Console.WriteLine("4.tìm sinh viên theo tên có chữa một chuỗi được nhập từ bàn phím");
            Console.WriteLine("5.kế thừa");
            Console.WriteLine("6.xóa phần tử theo tên");
            Console.WriteLine("7.tìm theo tên sử dụng linq");
            Console.WriteLine("8.sắp xếp theo tên sử dụng linq");
            Console.WriteLine("0.thoát");
            Console.WriteLine("mời nhập: ");
            string luachon=Console.ReadLine();
            return luachon;
        }
        static void VongLapMenu()
        {
            do
            {
                switch (Menu())
                {
                    case "1":
                        sv.NhapDS();
                        break;
                    case "2":
                        if(list.Count == 0)
                        {
                            Console.WriteLine("danh sách hiện tại chưa có sinh viên nào, mời bạn nhập trước");
                            sv.NhapDS();                            
                        }else
                        sv.XuatDS();
                        break;
                    case "3":
                        if (list.Count == 0)
                        {
                            Console.WriteLine("danh sách hiện tại chưa có sinh viên nào, mời bạn nhập trước");
                            sv.NhapDS();
                        }
                        else
                            sv.XuatDSDuoi25();
                            break;
                    case "4":
                        if (list.Count == 0)
                        {
                            Console.WriteLine("danh sách hiện tại chưa có sinh viên nào, mời bạn nhập trước");
                            sv.NhapDS();
                        }
                        else
                            sv.XuatDSDuoi25();
                        break;
                    case "5":
                        sv.Kethua();
                        break;
                    case "6":
                        sv.Xoaphantu();
                        break;
                    case "7":
                        Console.WriteLine("tìm theo tên:");
                        sv.TimTheoTen();
                        break;
                    case "8":
                        Console.WriteLine("sắp xếp");
                        sv.SapXepTheoTen();
                        break;
                    case "0":
                        //System.Environment.Exit(0);
                        return;
                        break;
                    default:
                        Console.WriteLine("hãy nhập lại");
                        break;

                }
            }while (true);
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            VongLapMenu();
        }
    }
}
