using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ôn_tập_oop
{
    internal class ConNguoi
    { 
        string ten;
        int tuoi;
        string cmnd;
        string sdt;
        bool gioitinh=true;

        public ConNguoi(string ten, int tuoi, string cmnd, string sdt, bool gioitinh)
        {
            this.ten = ten;
            this.tuoi = tuoi;
            this.cmnd = cmnd;
            this.sdt = sdt;
            this.gioitinh = gioitinh;
        }

        public void NhaMang()
        {
            if (sdt.StartsWith("097") || sdt.StartsWith("098"))
                Console.WriteLine("Sdt này thuộc nhà mạng Viettel");
            else if (sdt.StartsWith("091") || sdt.StartsWith("092"))
                Console.WriteLine("Sdt này thuộc nhà mạng Vina");
            else
                Console.WriteLine("Sdt này thuộc nhà mạng khác");
        }
        public void KetHon()
        {
            if (gioitinh == true)
                Console.WriteLine("nam");
            else Console.WriteLine("nữ");
            if ((gioitinh == true && tuoi>=20) || (gioitinh == false && tuoi >= 18))
            {
                Console.WriteLine("đã đủ tuổi kết hôn");
            }
            else
            {
                Console.WriteLine("còn lâu");
            }
        }
    }

}
