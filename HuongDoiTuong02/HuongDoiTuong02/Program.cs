using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HuongDoiTuong02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            //Student x = new Student("Ứng dụng phần mềm", 9.0, "Nguyễn Cương", 18, "0972756511", true);
            //x.ShowInformation();
            //Dog a = new Dog();
            //a.Chay();
            //a.Keu();
            //Chicken b = new Chicken();
            //b.Keu();
            //b.Chay();
            //b.VoCanh();
            //b.VoCanh(1);
            Person ab = new Person();
            ab.ShowInformation();
            Console.ReadKey();
        }
    }
}
