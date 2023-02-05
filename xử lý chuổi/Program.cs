using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XulyString
{
    class Program
    {
        /*
         * string - chuỗi là 1 kiểu dữ liệu phổ biến trong các ngôn ngữ lập trình
         * chứa các kí tự
         * string là Readonly - chỉ đọc được, không sửa được trực tiếp
         * có thể cộng được các string nhưng không nhân, chia hoặc trừ được
         * string có thể được tham chiếu như 1 mảng kí tự nhưng không phải mảng kí tự
         */
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            //// Khai báo chuỗi
            string s1;
            //// Khởi tạo
            string s2 = "ABCD", s3 = "EFGH" ;
            //// Xuất
            string s4 = s2 + s3;
            Console.WriteLine(s4);
            for (int i = 0; i < s4.Length; i++) // string.Length = độ dài
            {
               Console.WriteLine(s4[i]);
            }

            // Các hàm xử lý chuỗi
            string nhap = Console.ReadLine(); // Nhập chuỗi
            string chuoi = "  aflhKKkwqeAlfwBehrquiwreh     ";
            Console.WriteLine("Chuỗi ban đầu: |" + chuoi + "|");
            Console.WriteLine("Chuỗi sau đó: |" + chuoi.Trim()+"|");

            //phải có .Trim() thì mới có thể thay đổi giá trị thật của chuỗi
            chuoi = chuoi.Trim(); //Phải gán nếu muốn thay đổi giá trị thật
            // xóa các dấu cách ở đầu và cuối


            // Thay thế - Replace
            Console.WriteLine("Chuỗi sau khi thay thế e bằng A:"+ chuoi.Replace("e", "..."));


            // Cắt chuỗi - Substring
            Console.WriteLine("Chuỗi được cắt từ vị trí 10: " + chuoi.Substring(10));
            Console.WriteLine("Chuỗi được cắt từ 10 có độ dài 5: " + chuoi.Substring(10, 5));


            // Xóa một phần của chuỗi - Remove
            Console.WriteLine("Chuỗi bị xóa từ vị trí 10: " + chuoi.Remove(10));
            Console.WriteLine("Chuỗi bị xóa từ 10 có độ dài 5: " + chuoi.Remove(10, 5));


            // Các hàm kiểm tra
            // Kiểm tra chuỗi nằm trong chuỗi
            Console.WriteLine("Kiểm tra xem chuỗi có chứa y hay không? " + chuoi.Contains("y"));


            // Kiểm tra chuỗi bắt đầu hoặc kết thúc bởi chuỗi nào đó
            Console.WriteLine("Kiểm tra xem chuỗi bắt đầu bởi afl ? " + chuoi.StartsWith("afl"));


            Console.WriteLine("Kiểm tra xem chuỗi kết thúc bởi afl ? " + chuoi.EndsWith("afl"));


            // Biến chuỗi thành Hoa - thường
            Console.WriteLine("Chuỗi biến thành chữ hoa: " + chuoi.ToUpper());
            Console.WriteLine("Chuỗi biến thành chữ thường: " + chuoi.ToLower());


            // Split - cắt 1 chuỗi thành mảng chứa các chuỗi con theo 1 kí tự ngăn cách
            string s = "123:234:111";
            string[] catchuoi = s.Split(':');
            foreach (var item in catchuoi)
            {
                Console.WriteLine(item);
            }
            // 1: Nhập 1 chuỗi, Kiểm tra xem chuỗi đó có độ dài lẻ hay chẵn,
            // nếu lẻ thì xóa hết kí tự A và a
            // nếu chẵn thì thay thế kí tự a và A bởi B
            // 2: Viết hàm chuyển tên thành tên viết tắt: VD: Pham Gia Khanh => KhanhPG
            Bai2();
            Console.ReadKey();
        static void Bai2()
        {
            Console.WriteLine("Nhập tên mà bạn muốn viết tắt: ");
            string name = Console.ReadLine();
            string[] hoten = name.Split(' ');// Cắt thành mảng chứa từng từ trong tên
            string ketqua = hoten[hoten.Length - 1];// Lấy tên trước
            for (int i = 0; i < hoten.Length - 1; i++)
        {
            ketqua += hoten[i][0]; // Lấy ký tự đầu của họ hoặc tên đệm
        }
        Console.WriteLine("Tên viết tắt là: " + ketqua);
        }
        }
    }
}


