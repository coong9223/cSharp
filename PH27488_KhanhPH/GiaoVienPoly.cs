using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PH27488_KhanhPH
{
    internal class GiaoVienPoly:GiaoVien
    {
        string NganhDay;

        public GiaoVienPoly()
        {
        }

        public GiaoVienPoly(string nganhDay, int iD, string name, double soGioDay)
            :base(iD, name, soGioDay)
        {
            NganhDay1 = nganhDay;
        }

        public string NganhDay1 { get => NganhDay; set => NganhDay = value; }
        public void InThongTin()
        {
            base.InThongTin();
            Console.WriteLine("nhập ngành dạy: ");
            string NganhDay=Console.ReadLine();
            Console.WriteLine("ngành dạy là: "+NganhDay);
        }
    }
}
