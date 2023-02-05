using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HuongDoiTuong02
{
    internal class Person
    {
        string name;
        int age;
        string sdt;
        bool sex;
        public Person()
        {
        }
        public Person(string name, int age, string sdt, bool sex)
        {
            this.Name = name;
            this.Age = age;
            this.Sdt = sdt;
            this.Sex = sex;
        }
        public string Name { get => name; set => name = value; }
        public int Age { get => age; set => age = value; }
        public string Sdt { get => sdt; set => sdt = value; }
        public bool Sex { get => sex; set => sex = value; }
        public void ShowInformation()
        {
            Console.WriteLine($"\nTên: {name}");
            Console.WriteLine($"Tuổi: {age}");
            Console.WriteLine("Giới tính: " + (sex == true ? "Nam" : "Nữ"));
            Console.WriteLine($"Số điện thoại: {Sdt}");
        }
    }
}
