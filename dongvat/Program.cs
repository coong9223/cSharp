using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dongvat
{
    internal class Program
    { 
        static dongvat taodv()
        {
            Console.WriteLine("hãy nhập thông tin cho động vật");
            Console.WriteLine("nhập tên:");
            string ten = Console.ReadLine();
            Console.WriteLine("nhập cân nặng trung bình: ");
            double tb =Convert.ToDouble(Console.ReadLine());
            dongvat dv=new dongvat(ten,tb);
            return dv;
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("nhập thông tin: ");
            dongvat dv = taodv();
            dv.showthongtin();
        }
    }
}
