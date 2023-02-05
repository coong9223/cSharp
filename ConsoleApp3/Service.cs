using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Service
    {
        List<NganhHoc> nganhhocs;
        public Service()
        {
        }
        public Service(List<NganhHoc> nganhhocs)
        {
            this.Nganhhocs = nganhhocs;
        }
        internal List<NganhHoc> Nganhhocs { get => nganhhocs; set => nganhhocs = value; }
        public NganhHoc NhapDuLieu()
        {
            Console.WriteLine("nhập tên ngành học"); 
            string ten=Console.ReadLine();
            Console.WriteLine("mã ngành học:");
            int id=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("nhập số kỳ học");
            int sokyhoc=Convert.ToInt32(Console.ReadLine());
            NganhHoc nghoc =new NganhHoc(id, ten, sokyhoc);
            return nghoc;
        }
        public void NhapDS()
        {
            Console.WriteLine("nhập số lượng sinh viên cần cho vào danh sách");
            int soluong=Convert.ToInt32(Console.ReadLine());
            for(int i=0; i<soluong; i++)
            {
                NganhHoc s = NhapDuLieu();
                nganhhocs.Add(s);   
            }
            Console.WriteLine("bạn muốn nhập tiếp ko? nhấn 1 để tiếp tục nhập, còn lại thì đéo.");
            string nhaptiep=Console.ReadLine();
            if(nhaptiep == "1")
            {
                NhapDS();
            }
        }
        public void XuatDS()
        {
            foreach(var item in nganhhocs)
            {
                item.InThongTin();
            }
        }
        public void XuatDSKyHoc()
        {
            int dem = 0;
            if(nganhhocs.Count==0)
                Console.WriteLine("đéo có ngành học nào:");
            foreach(var item in nganhhocs)
            {
                if (item.SoKyHoc1 > 6)
                {
                    item.InThongTin();
                    dem++;
                }
            }
            if (dem == 0)
            {
                Console.WriteLine("không có ngành nào có số kỳ học lớn hơn 6");
            }
        }
        public void Remove()
        {
            Console.WriteLine("nhập ID muốn xóa: ");
            int xoa = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < nganhhocs.Count;)
            {
                if (Nganhhocs[i].ID1 == xoa)
                    nganhhocs.RemoveAt(i);
                else
                    i++;
            }
            Console.WriteLine("đã xóa");
        }
        
    }
}
