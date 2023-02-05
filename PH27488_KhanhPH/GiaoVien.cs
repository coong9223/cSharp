using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PH27488_KhanhPH
{
    internal class GiaoVien
    {
        private int ID;
        private string Name;
        private double SoGioDay;
        public GiaoVien()
        {
        }
        public GiaoVien(int iD, string name, double soGioDay)
        {
            ID1 = iD;
            Name1 = name;
            SoGioDay1 = soGioDay;
        }
        public int ID1 { get => ID; set => ID = value; }
        public string Name1 { get => Name; set => Name = value; }
        public double SoGioDay1 { get => SoGioDay; set => SoGioDay = value; }
        public void InThongTin()
        {
            Console.WriteLine($"giáo viên: {Name}, có mã là: {ID}, số giờ dạy: {SoGioDay}");
        }
    }
}
