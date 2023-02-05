using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_5_6
{
    internal class Hoa
    {
        string name;
        string vungss;

        public string Name { get => name; set => name = value; }
        public string Vungss { get => vungss; set => vungss = value; }

        public Hoa(string name, string vungss)
        {
            this.Name = name;
            this.Vungss = vungss;
        }

        public Hoa()
        {
        }
        public void InThongTin()
        {
            Console.WriteLine("Nhập tên loài hoa: ");
            string name=Console.ReadLine();            
            Console.WriteLine("nhập thông tin vùng sinh sống của Hoa: ");
            string vungss=Console.ReadLine();
            Console.WriteLine($"tên loài hoa là: {name}");
            Console.WriteLine($"vùng sinh sống: {vungss}");
        }
    }
}
