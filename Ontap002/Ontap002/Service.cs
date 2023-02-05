using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ontap002
{
    class Service
    {
        List<Hocsinh> hocsinhs;

        public Service()
        {
        }

        public Service(List<Hocsinh> hocsinhs)
        {
            this.Hocsinhs = hocsinhs;
        }

        internal List<Hocsinh> Hocsinhs { get => hocsinhs; set => hocsinhs = value; }
        public Hocsinh NhapHocSinh()
        {
            Console.WriteLine("Nhập tên: "); // Đưa ra thông báo
            string ten = Console.ReadLine(); // Nhập 
            Console.WriteLine("Nhập mã: ");
            string ma = Console.ReadLine();
            Console.WriteLine("Nhập tuổi: ");
            int tuoi = Convert.ToInt32(Console.ReadLine());
            // Tạo đối tượng bằng Constructor có tham số
            Hocsinh hs = new Hocsinh(ma, ten, tuoi);
            return hs;
        }

        public void NhapDS()
        {
            Console.WriteLine("Nhập Số lượng học sinh bạn muốn thêm: ");
            int soluong = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < soluong; i++)
            {
                Hocsinh x = NhapHocSinh();
                hocsinhs.Add(x);
            }
        }
        public void XuatDS()
        {
            foreach (var item in hocsinhs)// item là 1 Học sinh bất kì trong list
            {
                item.InThongTin();
            }
        }
        public void XuatDSNS()
        {
            //.... Tự làm
        }
        public void TimTheoMa()
        {
            Console.WriteLine("Nhập cái mã mà bạn muốn tìm");
            string ma = Console.ReadLine();
            int count = 0; // Đếm khi tìm thấy
            foreach (var item in hocsinhs)
            {
                if (item.Mahs == ma) // item.Mahs => Dùng get
                {
                    item.InThongTin(); count++;
                }
            }
            if (count == 0)
            {
                Console.WriteLine("Không tìm thấy học sinh nào như thế này cả");
            }
        }
        public void TenVietTat()
        {
            foreach (Hocsinh item in hocsinhs)
            {
                item.Tenhs = VietTat(item.Tenhs); // DÙng Set
            }
        }
        
        public String VietTat(string tencu)
        {          
            string[] tachten = tencu.Split(' '); // Dùng split tách tên theo dấu cách
            string tenvt = tachten[tachten.Length - 1];// Gán tên
            for (int i = 0; i < tachten.Length - 1 ; i++)
            {
                tenvt += tachten[i][0]; // Lấy kí tự đầu tiên của họ hoặc tên đệm
                //tenvt += tachten[i].Substring(0, 1);
            }
            return tenvt;
        }
        public void KeThua()
        {
            HocsinhCapBa hsc3 = new HocsinhCapBa();
            hsc3.Tenhs = "Học sinh cấp 3";
            hsc3.Mahs = "HSC3";
            hsc3.Tuoi = 16;
            hsc3.Khoihoc = "A";
            hsc3.ThongTin();
            hsc3.ThongTin(1); // Gọi cả 2 Overload
        }

    }
}
