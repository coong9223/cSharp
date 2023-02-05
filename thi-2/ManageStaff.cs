using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace thi_2
{
    internal class ManageStaff
    {
        List<NhanVien> nhanviens;

        public ManageStaff()
        {
        }

        public ManageStaff(List<NhanVien> nhanviens)
        {
            this.Nhanviens = nhanviens;
        }
        internal List<NhanVien> Nhanviens { get => nhanviens; set => nhanviens = value; }
        public NhanVien NhapDL()
        {
            Console.WriteLine("tên nhân viên: ");
            string name=Console.ReadLine();
            Console.WriteLine("mã nhân viên: ");
            string maNv=Console.ReadLine();
            Console.WriteLine("lương của nhân viên: ");
            int salary=Convert.ToInt32(Console.ReadLine());
            NhanVien nv=new NhanVien(name, maNv, salary);
            return nv;
        }
        public void Nhap()
        {
            Console.WriteLine("mời nhập số lượng nhân viên: ");
            int nhap = Convert.ToInt32(Console.ReadLine());
            for(int i = 0; i < nhap; i++)
            {
                NhanVien nv = NhapDL();
                nhanviens.Add(nv);
            }
            Console.WriteLine("bạn có muốn nhập tiếp? chọn 1 để nhập tiếp");
            string nhaptiep =Console.ReadLine();
            if(nhaptiep == "1")
            {
                Nhap();
            }
        }
        public void Xuat()
        {
            foreach(NhanVien nv in Nhanviens)
            {
                nv.InThongTin();
            }
        }
        public void Remove()
        {
            Console.WriteLine("nhân viên cần xóa có mã là: ");
            string remove=Console.ReadLine();
            for(int i = 0; i < nhanviens.Count;)
            {
                if (nhanviens[i].MaNV1 == "1")
                {
                    nhanviens.RemoveAt(i);
                }
                else i++;
            }
        }
        public void XuatTheoLuong()
        {
            for(int i=0; i < nhanviens.Count; i++)
            {
                if(nhanviens[i].Salary1 >= 15 && nhanviens[i].Salary1 <= 50)
                {
                    Xuat();
                }
            }
        }
        public void kethua()
        {
            Manager mn = new Manager(15,"Nguyễn Thành Công","Ph27488",19);
            mn.InThongTin();
        }
    }
}
