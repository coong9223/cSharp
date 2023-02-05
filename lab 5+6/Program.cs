using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_5_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;            
            Hoa a= new Hoa();
            a.InThongTin();
            Console.ReadKey();
            HoaHong b=new HoaHong();
            b.ThongTin();
            HoaCuc c=new HoaCuc(); 
            c.InThongTin();
            c.PhanLoai();
            c.PhanLoai2(60);
        }
    }
}
