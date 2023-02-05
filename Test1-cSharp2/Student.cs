using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1_cSharp2
{
    internal class Student
    {
        private string id;
        private string name;
        private int ngSinh;
        private string Nganh;

        public string Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public int NgSinh { get => ngSinh; set => ngSinh = value; }
        public string Nganh1 { get => Nganh; set => Nganh = value; }

        public Student(string id, string name, int ngSinh, string nganh)
        {
            this.Id = id;
            this.Name = name;
            this.NgSinh = ngSinh;
            Nganh1 = nganh;
        }

        public Student()
        {
        }
        public void InThongTin()
        {
            Console.WriteLine($"id: {id},name: {name},ngSinh: {ngSinh},ngành: {Nganh}");
        }
    }
}
