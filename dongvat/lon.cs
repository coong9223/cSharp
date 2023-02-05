using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dongvat
{
    internal class lon:dongvat
    {
        string gionglon;
        public lon()
        {
        }      
        public lon(string gionglon)
        {
            this.Gionglon = gionglon;
        }
        public string Gionglon { get => gionglon; set => gionglon = value; }
        public void showthongtin()
        {
            base.showthongtin();
            Console.WriteLine("giống lợn là: " + gionglon);
        }
        public override void keu()
        {
            Console.WriteLine("con lợn kêu éc");
        }
    }
}
