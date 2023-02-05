using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HuongDoiTuong02
{
    internal class Student : Person
    {
        string monhoc;
        double diem;
        public Student()
        {
        }
        public Student(string monhoc, double diem, string name, int age, string sdt, bool sex) : base(name, age, sdt, sex)
        {
            this.monhoc = monhoc;
            this.diem = diem;
        }
        public void ShowInformation()
        {
            base.ShowInformation();
            Console.WriteLine($"Học môn: {monhoc}");
            Console.WriteLine($"Điểm môn: {diem}");
        }
    }
}
