using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lasttest_beforeexam
{
    internal class Program
    {
        static List<bike> lists = new List<bike>();
        static services sv = new services(lists);
        static int Menu()
        {
            Console.WriteLine("menu");
            Console.WriteLine("1.Nhập danh sách đối tượng");
            Console.WriteLine("2.Xuất danh sách đối tượng");
            Console.WriteLine("3. Xuất các xe máy của hãng HONDA");
            Console.WriteLine("4. Sắp xếp đối tượng theo ID giảm dần");
            Console.WriteLine("5.Kế thừa");
            Console.WriteLine("0.Thoát");
            Console.WriteLine("Mời chọn mục");
            int chon = Convert.ToInt32(Console.ReadLine());
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
                    case 2:
                        sv.XuatDS();
                        break;
                    case 3:
                        sv.HONDA();
                        break;
                    case 4:
                        sv.sapxep();
                        break;
                    case 0:
                        System.Environment.Exit(0);
                        break;
                    case 5:
                        sv.Kethua();
                        break;
                    default:
                        Console.WriteLine("mời nhập lại: ");
                        break;
                }
            } while (true);
        }
    }
}
