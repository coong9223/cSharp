using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HuongDoiTuong01;

namespace hướng_đối_tượng
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            // string giongcho, string ten, int tuoi, string maulong, 
            Concho x; // Khai báo 1 con chó
            Concho y = new Concho(); // Tạo 1 con chó = constructor không tham số - Các thuộc tính chưa có giá trị
            Concho z = new Concho("Chihuahua", "ABC", 3, "Vàng", true); // Constructor có tham số 
            // => Các thuộc tính có giá trị luôn
            // Get -> Lấy thuộc tính
            Console.WriteLine($"Con chó vừa tạo có tên là: {z.Ten}, Màu lông là: {z.Maulong}");
            // Set -> Gán giá trị cho thuộc tính của đối tượng
            y.Ten = "XYZ"; y.Maulong = "Đỏ";
            Console.WriteLine($"Con chó vừa tạo có tên là: {y.Ten}, Màu lông là: {y.Maulong}");
            z.Sua();
            z.NamSinh();
            Console.ReadLine();
        }
    }
}
