using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic
{
    internal class Nguoi
    {
        public string Name { get; set; }   // prop tab tab
        public string CMT { get; set; }

        public Nguoi()
        {
            Name = "abc";
            CMT = "XYZ";
        }

        public Nguoi(string name, string cMT)
        {
            Name = name;
            CMT = cMT;
        }
        public void IN()
        {

            Console.WriteLine("Tôi là người bình thường");
        }
    }
}
