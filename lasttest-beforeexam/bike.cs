using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lasttest_beforeexam
{
    internal class bike
    {
        private int ID;
        private string Name;
        private string HSX;
        public bike()//constructor không tham số dùng để khởi tạo đối tượng với cái giá trị mặc định
        {
        }
        public bike(int iD, string name, string hSX)//constructor có tham số dùng để khởi tạo đối tượng với các giá trị có sẵn
        {
            ID1 = iD;
            Name1 = name;
            HSX1 = hSX;
        }
        public int ID1 { get => ID; set => ID = value; }//propertive: dùng để gán và lấy giá trị cho các thuộc tính
        //get: lấy giá trị
        //set: gán giá trị
        public string Name1 { get => Name; set => Name = value; }
        public string HSX1 { get => HSX; set => HSX = value; }
        public void InThongTin()
        {
            Console.WriteLine($"xe: {Name}, có mã là: {ID}, hsx: {HSX}");
        }
        public virtual void ThongTinBoSung()
        {
            Console.WriteLine("xe Honda");
        }
    }
}
