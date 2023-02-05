using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PH27488_KhanhPH
{
    internal class SERVICE
    {
        List<GiaoVien> giaoviens;

        public SERVICE()
        {
        }

        public SERVICE(List<GiaoVien> giaoviens)
        {
            this.Giaoviens = giaoviens;
        }

        internal List<GiaoVien> Giaoviens { get => giaoviens; set => giaoviens = value; }
        public GiaoVien NhapTT()
        {
            Console.WriteLine("Mời nhập thông tin giáo viên: ");
            Console.WriteLine("Họ và tên: ");
            string name = Console.ReadLine();
            Console.WriteLine("Mã: ");
            int Id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Số giờ dạy: ");
            double soGioDay = Convert.ToDouble(Console.ReadLine());
            GiaoVien gv = new GiaoVien(Id, name, soGioDay);
            return gv;
        }
        public void NhapDS()
        {
            Console.WriteLine("mời nhập số lượng đối tượng: ");
            int input = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < input; i++)
            {
                GiaoVien gv = NhapTT();
                giaoviens.Add(gv);
            }
            Console.WriteLine("bạn có muốn nhập tiếp ko, chọn 1 để nhập tiếp: ");
            string nhaptiep=Console.ReadLine();
            if (nhaptiep == "1")
            {
                NhapDS();
            }
        }
        public void XuatDS()
        {
            foreach(GiaoVien gv in giaoviens)
            {
                gv.InThongTin();
            }
        }
        public void XuatDStheoGioDay()
        {

        }
        public void Remove()
        {
            Console.WriteLine("mời nhập id gv cần xóa: ");
            int xoa=Convert.ToInt32(Console.ReadLine());
            int dem = 0;
            for(int i = 0; i < giaoviens.Count; i++)
            {
                if(giaoviens[i].ID1== xoa)
                {
                    giaoviens.RemoveAt(i);
                    dem++;
                }
            }

        }
        public void KeThua()
        {
            GiaoVienPoly gv = new GiaoVienPoly("WEB", 27456, "Tân Văn Sơn", 18);
            gv.InThongTin();
        }
    }
}
