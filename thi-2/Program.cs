using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace thi_2
{
    internal class Program
    {
        static List<NhanVien> list = new List<NhanVien>(); 
        static ManageStaff mn = new ManageStaff(list);
        static int Menu()
        {
            Console.WriteLine("---menu---");
            Console.WriteLine("nhập danh sách đối tượng");
            Console.WriteLine("xuất danh sách đối tượng");
            Console.WriteLine("xóa nhân viên theo mã nhân viên");
            Console.WriteLine("xuất danh sách nhân viên theo khoảng lương");
            Console.WriteLine("thoát");
            Console.WriteLine("Mời chọn mục: ");
            int chon=Convert.ToInt32(Console.ReadLine());
            return chon;
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            do
            {
                switch(Menu()){
                    case 1:
                        mn.Nhap();
                        break;
                    case 2:
                        mn.Xuat();
                        break;
                    case 3:mn.Remove();
                        break;
                    case 4:
                        mn.XuatTheoLuong();
                        break;
                    case 5:mn.kethua();
                        break;
                    case 0:
                        System.Environment.Exit(0); 
                        break;
                    default:
                        Console.WriteLine("mời nhập lại: ");
                        break;
                }
            }while (true);  
        }
    }
}
