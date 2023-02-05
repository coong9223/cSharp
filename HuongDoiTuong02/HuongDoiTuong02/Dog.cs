using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HuongDoiTuong02
{
    internal class Dog : Animal
    {
        public override void Keu()
        {
            Console.WriteLine("chó sủa go go");
        }
        public override void Chay()
        {
            Console.WriteLine("chó chạy 4 chân");
        }
    }
}
