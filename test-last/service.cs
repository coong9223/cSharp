using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_last
{
    internal class service
    {
        List<sinhvien> sinhviens;        
        public service()
        {
        }

        public service(List<sinhvien> sinhviens)
        {
            this.Sinhviens = sinhviens;
        }
        internal List<sinhvien> Sinhviens { get => sinhviens; set => sinhviens = value; }

        public sinhvien NhapSinhVien()
    {
        Console.WriteLine("nhập tên sinh viên");
        string ten = Console.ReadLine();
        Console.WriteLine("nhập mã sinh viên");
        string ma = Console.ReadLine();
        Console.WriteLine("nhập năm sinh sinh viên");
        int namsinh = Convert.ToInt32(Console.ReadLine());
        sinhvien sv = new sinhvien(ma, ten, namsinh);
        return sv;
    }
    public void NhapDS()
    {
        Console.WriteLine("nhập số lượng sinh viên bạn muốn thêm vào danh sách");
        int soluong=Convert.ToInt32(Console.ReadLine());
        for(int i = 0; i < soluong; i++)
        {
            sinhvien s = NhapSinhVien();
            Sinhviens.Add(s);
        }
            Console.WriteLine("bạn nhập tiếp chứ? nhập 1 để nhập tiếp, còn lại thì không");
            string nhaptiep=Console.ReadLine();
            if(nhaptiep == "1")
            {
                NhapDS();//gọi chính nó để tiếp tục nhập
            }
    }
        public void XuatDS()
        {
            foreach(sinhvien i in sinhviens)//dùng foreach để duyệt qua từng phần tử của list
            {
                i.Inthongtin();
            }
        }
        public void XuatDSDuoi25()
        {
            foreach (sinhvien i in sinhviens)//dùng foreach để duyệt qua từng phần tử của list
            {
                if(DateTime.Now.Year - i.Namsinh1 <= 25)
                {
                    i.Inthongtin();
                }

            }
        }
        public void Timsinhvien()
        {
            Console.WriteLine("hãy nhập thông tin bạn cần tìm");
            string tim=Console.ReadLine();
            foreach (sinhvien i in sinhviens)//dùng foreach để duyệt qua từng phần tử của list
            {
                if (i.Ten1.Contains(tim))//containts = chứa thứ cần tìm
                {
                    i.Inthongtin();
                }

            }
        }

        public void TimTheoTen()
        {
            Console.WriteLine("nhập chuỗi muốn tìm:");
            string tim = Console.ReadLine();
            //tìm kiếm sử dụng linq
            var/*List<sinhvien>*/ x=sinhviens.Where(p => p.Ten1==tim).ToList();
            foreach (var item in x)
            {
                item.Inthongtin();
            }
        }
        public void SapXepTheoTen()
        {
            var x=sinhviens.OrderBy(p => p.Namsinh1).ToList();
            //sinhviens=sinhviens.OrderBy(p=>p.Namsinh1).ToList();
            //nếu đề bài yêu cầu dùng luôn list đó để sắp xếp

            //giảm dần:
            //var x=sinhviens.OrderByDescending(p => p.Namsinh1).ToList();
            foreach (var item in x)
            {
                item.Inthongtin();
            }
        }

        public void TinhTong(dynamic a,dynamic b)
        {
            Console.WriteLine(a+b);
        }
        public void Kethua()
        {
            sinhvienUDPM svud= new sinhvienUDPM(8.5, 4.5, "27488", "Nguyễn Thành Công", 2003);
            svud.Inthongtin();
        }
        public void Xoaphantu()
        {
            Console.WriteLine("nhập tên mà bạn muốn xóa");
            string xoa = Console.ReadLine();
            for(int i = 0; i < sinhviens.Count;)
            {
                if (sinhviens[i].Ten1 == xoa)
                {
                    sinhviens.RemoveAt(i);
                    //sinhviens.Remove(sinhviens[i]);
                }
                else i++;
            }
        }
    }
    
}
