using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ontap002
{
    class HocsinhCapBa : Hocsinh
    {
        string khoihoc;

        public HocsinhCapBa()
        {
        }

        public HocsinhCapBa(string khoihoc, string mahs, string tenhs, int tuoi)
            :base(mahs, tenhs, tuoi)
        { // từ khóa base => Dùng để gọi ra các thành phần thuộc lớp cha
            this.Khoihoc = khoihoc;
        }

        public string Khoihoc { get => khoihoc; set => khoihoc = value; }
        public void ThongTin()
        {
            base.InThongTin(); // => kế thừa phương thức InThongTin từ lớp cha
        }
        public void ThongTin(int x)
        {
            Console.WriteLine("Khối tôi muốn học là: "+ khoihoc);
        }
        // 2 phương thức ThongTin ở trên là Overload - Nạp chồng
        public override void ABC()
        {
            //  Phương thức ABC là Ghi đè lên phương thức ABC của lớp cha
        }
        // Tính đa hình: 
        // 1. Cùng 1 hành động nhưng với các đối tượng khác nhau thì khác nhau - Override
        // 2. 1 hành động của 1 đối tượng nhưng ở trạng thái khác nhau thì khác nhau - Overload
    }
}
