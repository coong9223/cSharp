using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic
{
    internal class NguoiGia
    {
        public int Tuoi { get; set; }

        public NguoiGia()
        {
            Tuoi = 100;
        }

        public NguoiGia(int tuoi)
        {
            Tuoi = tuoi;
        }

        public void IN()
        {

            Console.WriteLine("Tôi là người già");
        }
    }
}
