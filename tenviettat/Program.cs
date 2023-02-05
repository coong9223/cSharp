using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tenviettat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Mời nhập tên muốn viết tắt:");
            string name=Console.ReadLine();
            string[] value = name.Split(' ');
            string tenviettat=value[value.Length-1];
            for(int i=0; i<value.Length-1; i++)
            {
                tenviettat+=value[i][0];
            }
            Console.WriteLine(tenviettat);
        }
    }
}
