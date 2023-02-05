using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ôn_tập_oop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("mời nhập thông tin:");
            Console.WriteLine("mời nhập tên:");
            string name=Console.ReadLine();
            Console.WriteLine("mời nhập tuổi");
            int tuoi=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("mời nhập cmnd:");
            string cmnd=Console.ReadLine();
            Console.WriteLine("mời nhập số điện thoại:");
            string sdt=Console.ReadLine();
            Console.WriteLine("xác định giới tính");
            bool gt=Convert.ToBoolean(Console.ReadLine());  
            ConNguoi cn01 = new ConNguoi(name, tuoi, cmnd, sdt, gt);
            cn01.NhaMang();
            cn01.KetHon();
            Console.ReadKey();
        }
    }
}
