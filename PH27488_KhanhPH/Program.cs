using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PH27488_KhanhPH
{
    internal class Program
        
    {   static List<GiaoVien> list=new List<GiaoVien>();   
        static SERVICE sv = new SERVICE(list);
        static int Menu()
        {
            Console.WriteLine("-------------Menu-------------");
            Console.WriteLine("1.Nhập danh sách đối tượng");
            Console.WriteLine("2.Xuất danh sách đối tượng");
            Console.WriteLine("3.Xuất danh sách GV có giờ dạy ngoài khoảng do người dùng nhập");
            Console.WriteLine("4. Xóa đối tượng theo ID");
            Console.WriteLine("5. Kế thừa");
            Console.WriteLine("0.Thoát");
            Console.WriteLine("Mời chọn:");
            int chon=Convert.ToInt32(Console.ReadLine());
            return chon;
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            do
            {
                switch (Menu())
                {
                    case 1:
                        sv.NhapDS();
                        break;
                    case 2:sv.XuatDS();
                        break;
                    case 3:                       
                        break;
                    case 4:
                        sv.Remove();
                        break;
                    case 0:
                        System.Environment.Exit(0);
                        break;
                    case 5:
                        sv.KeThua();
                        break;
                    default:
                        Console.WriteLine("mời nhập lại");
                        break; 
                }
            }while(true);
        }
    }
}
