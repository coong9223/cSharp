using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HuongDoiTuong02
{
    abstract class Animal
    {
        string tiengkeu;
        public abstract void Keu();
        public virtual void Chay() // phương thức virtual
        {
            Console.WriteLine("động vật đang chạy");
        }
    }
}
