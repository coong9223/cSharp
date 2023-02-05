using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Test1_cSharp2
{   
    internal class Service
    {
        List<Student> students=new List<Student>();

        internal List<Student> Students { get => students; set => students = value; }

        public Service(List<Student> students)
        {
            this.Students = students;
        }

        public Service()
        {
        }
        public Student NhapThongTin()
        {
            string id=Console.ReadLine();
            string name=Console.ReadLine();
            int ngSinh=Convert.ToInt32(Console.ReadLine());
            string nganh=Console.ReadLine();
            Student st=new Student(id,name,ngSinh,nganh);
            return st;
        }

        public void Nhap()
        {
            Console.WriteLine("mời nhập số lượng phần tử");
            int n=Convert.ToInt32(Console.ReadLine());
            int[] arr=new int[n];
            for(int i=0;i<arr.Length;i++)
            {
                Console.WriteLine("hãy nhập id: ");
                string id = NhapID();
                Console.WriteLine("nhập tên: ");
                string name = Console.ReadLine();
                Console.WriteLine("nhập ngày sinh");
                int ngSinh = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("nhập ngành ");
                string nganh=Console.ReadLine(); 
                Student student = new Student(id, name, ngSinh, nganh);
                students.Add(student);              
            }
        }

        public int NhapNamSinh()
        {
            int x;
            bool check=int.TryParse(Console.ReadLine(), out x);
            if(check)return x;//nếu nhập đúng
            else return NhapNamSinh();
        }
        public void Xuat()
        {
            foreach(var student in students)
            {
                student.InThongTin();
            }
        }
        public string NhapID()
        {
            Console.WriteLine("nhập id: ");
            string id=Console.ReadLine();
            foreach(char x in id)
            {
                if (char.IsLetter(x))
                {
                    Console.WriteLine("string id ko được chứa chữ cái");
                    return NhapID();
                }
            }
            return id;
        }

        //public List<T> LocFile<T>(string path)
        //{
        //    if (!File.Exists(path))
        //    {
        //        Console.WriteLine("file ko tồn tại");return null;
        //    }
                
        //    else
        //    {
        //        XmlSerializer xs = new XmlSerializer(typeof(List<T>));
        //        using (FileStream fs = new FileStream(path, FileMode.Open)) ;
        //    }
                
        //}

        public void Linq_layDSSV_10X()
        {
            var x = students.Where(p => p.NgSinh > 1999 && p.NgSinh < 2011);
            foreach(var items in x)
            {
                items.InThongTin();
            }
        }
        public void Linq2_SapXepTangDanTheoDS()
        {
            students = students.OrderBy(p=>p.NgSinh).ToList();
            foreach(var item in students)
            {
                item.InThongTin();  
            }
        }
    }
}
