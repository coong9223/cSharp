using System;
using System.Collections;//thêm
using System.Collections.Generic;//thêm
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace collection
{
    /* collection là những lớp được tạo ra để hỗ trợ chúng ta trong quá trình lưu trữ và quản lý thông tin
     * với các phương thức hỗ trợ linh hoạt
     * collections có 2 loại (non-generic, generic)
     * Arraylist: là collection cho phép quản lý và lưu trữ mọi kiểu dữ liệu trong 1 collection
     * List: là collection generic chỉ lưu trữ 1 kiểu dữ liệu trong 1 collection
     * các collection đều lưu trữ được các object
     * các collection có thể truy vấn đế các phần tử tương tự như trong mảng
     */
    //tạo 1 danh sách List static - toàn cục
   
    internal class Program
    {
        static List<chicken> chickens = new List<chicken>();
        //tạo phương thức nhập con gà và tạo đối tượng con gà
        static chicken TaoConGa()
        {
            //nhập thông tin
            Console.WriteLine("nhập tên con gà:");
            string ten=Console.ReadLine();
            Console.WriteLine("nhập màu lông con gà:");
            string maulong=Console.ReadLine();
            Console.WriteLine("nhập tuổi con gà:");
            int tuoi=Convert.ToInt32(Console.ReadLine());
            //tạo một đối tượng con gà bằng constructor có tham số
            chicken cg= new chicken(ten, maulong, tuoi);
            return cg;
        }
        static void ThemGaVaoDanhSach()
        {
            Console.WriteLine("bạn muốn nhập bao nhiêu con gà:");
            int soluong=Convert.ToInt32(Console.ReadLine());
            for(int i = 0; i < soluong; i++)
            {
                chicken s= TaoConGa();//nhập và tạo con gà mới
                chickens.Add(s);//thêm con gà vừa tạo vào list
            }
        }
        static void XuatDanhSach()
        {
            foreach(chicken /*var*/ item in chickens)
            {
                item.InThongTin();//gọi phương thức
            }
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding=System.Text.Encoding.UTF8;  
            ThemGaVaoDanhSach();
            XuatDanhSach();


            //khai báo
            ArrayList arraylist = new ArrayList();  //không cần xác nhận kiểu dữ liệu 
            List<string> lists = new List<string>();//phải xác nhận kiểu dữ liệu cho nó

            //thêm phần tử cho collection - Add
            arraylist.Add(1);
            arraylist.Add("abc123");
            arraylist.Add("abc123");
            arraylist.Add(new ArrayList());
            lists.Add("10");
            // ko thể có list.Add(10) vì ko add được kiểu dữ liệu khác string

            //truy vấn đến phần tử
            for (int i = 0; i < arraylist.Count; i++)//Count = số phần tử
            {
                Console.WriteLine(arraylist[i]);
            }

            //thêm - Insert - thêm vào 1 vị trí nào đó giá trị nào đó
            arraylist.Insert(1, "Insert ");
            //truy vấn đến phần tử
            for (int i = 0; i < arraylist.Count; i++)//Count = số phần tử
            {
                Console.WriteLine(arraylist[i]);
            }

            //sửa phần tử - truy vấn đến và sửa
            //xóa Remove và RemoveAt
            arraylist.Remove(1);//xoác đối tuonwjg trong collection
            //truy vấn đến phần tử
            for (int i = 0; i < arraylist.Count; i++)//Count = số phần tử
            {
                Console.WriteLine(arraylist[i]);
            }

            arraylist.RemoveAt(0);//xóa đối tượng collection theo vị trí
            //truy vấn đến phần tử
            for (int i = 0; i < arraylist.Count; i++)//Count = số phần tử
            {
                Console.WriteLine(arraylist[i]);
            }

            //kiểm tra
            Console.WriteLine(arraylist.Contains("xys"));//kiểm tra tồn tại trả kết quả true-false

            //kiểm tra vị trí
            Console.WriteLine(arraylist.IndexOf("Insert"));//-1 nếu không tồn tại
            Console.WriteLine(arraylist.LastIndexOf("abc123"));

            //đảo ngược
            arraylist.Reverse();
            //truy vấn đến phần tử
            for (int i = 0; i < arraylist.Count; i++)//Count = số phần tử
            {
                Console.WriteLine(arraylist[i]);
            }

            //một số phương thức xử lý đặc biệt
            //xóa tất cả
            arraylist.Clear();
            //xóa một phần
            arraylist.RemoveRange(1, 3);//xóa từ vị trí 1 và xóa 3 phần tử

            Console.ReadKey();
        }
    }
}
