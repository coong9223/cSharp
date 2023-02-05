using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HuongDoiTuong02
{
    internal class Teacher : Person
    {
        string monday;
        public Teacher()
        {
        }
        public Teacher(string monday, string name, int age, string sdt, bool sex) : base(name, age, sdt, sex)
        {
            this.Monday = monday;
        }
        public string Monday { get => monday; set => monday = value; }
        public void ShowInformation()
        {
            base.ShowInformation();
            Console.WriteLine($"Dạy môn: {monday}");
        }
    }
}
