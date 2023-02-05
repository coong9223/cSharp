using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class LopHoc:NganhHoc
    {
        int malop;
        public LopHoc()
        {
        }
        public LopHoc(int malop, int iD, string ten, int soKyHoc):base(iD, ten, soKyHoc)
        {
            this.Malop = malop;
        }

        public int Malop { get => malop; set => malop = value; }
        public override void Kethua()
        {
            Console.WriteLine("it 17307");
        }

    }
}
