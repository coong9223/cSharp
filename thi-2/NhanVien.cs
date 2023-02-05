using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace thi_2
{
    internal class NhanVien
    {
        private string Name;
        private string MaNV;
        private int Salary;

        public NhanVien()
        {
        }

        public NhanVien(string name, string maNV, int salary)
        {
            Name1 = name;
            MaNV1 = maNV;
            Salary1 = salary;
        }

        public string Name1 { get => Name; set => Name = value; }
        public string MaNV1 { get => MaNV; set => MaNV = value; }
        public int Salary1 { get => Salary; set => Salary = value; }
        public void InThongTin()
        {
            Console.WriteLine($"tên: {Name}, mã: {MaNV}, lương: {Salary}");
        }
        public int TinhLuong()
        {
            int MonthlySalary = Salary * 22;
            return MonthlySalary;
        }
    }
}
