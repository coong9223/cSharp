using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HuongDoiTuong02
{
    internal class Chicken : Animal
    {
        public override void Keu()
        {
            Console.WriteLine("gà gáy ò ó o ");
        }
        public override void Chay()
        {
            Console.WriteLine("gà chạy 2 chân");
        }
        public void VoCanh()
        {
            Console.WriteLine("gà vỗ cánh lúc ra khỏi chuồng");
        }
        public void VoCanh(int x) // overload - nạp chồng - cùng tên, cùng kiểu, khác tập tham số truyền vào
        {
            Console.WriteLine($"gà vỗ cánh bay vù vù với tốc độ {x}");
        }
    }
}
