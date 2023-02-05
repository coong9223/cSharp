using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic
{
    internal class QuanLyNhanKhau <T> where T : class 
        // where để giới hạn kiểu dữ liệu
    {
       
        public QuanLyNhanKhau(List<T> tenGiCungDuoc)
        {
            TenGiCungDuoc = tenGiCungDuoc;
        }

        public QuanLyNhanKhau()
        {
            TenGiCungDuoc = new List<T>();
        }

        public List<T> TenGiCungDuoc { get; set; }
        public void In()
        {
            Console.WriteLine("Tôi là gì đó");
        }

    }
}
