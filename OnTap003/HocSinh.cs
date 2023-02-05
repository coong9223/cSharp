using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnTap003
{
    internal class HocSinh
    {
        /*access modifier - tính đóng - bao đóng
         * internal - phạm vi truy cập trong cùng asembly
         * public - phạm vi truy cập ở mọi nơi
         * private - phạm vi truy cập chỉ trong class khai báo
         * protected - trong class khai báo và các class kế thừa
         * protected internal - trong cùng assembly và các class kế thừa
         */
        private string mahv;
        private string ten;
        private int tuoi;
        public HocSinh()// Constructor không tham số 
        {//dùng để khởi tạo đối tượng với các giá trị mặc định
        }
        public HocSinh(string mahv, string ten, int tuoi)
        {//dùng để khởi tạo đối tượng với các giá trị có sẵn
            this.Mahv = mahv;
            this.Ten = ten;
            this.Tuoi = tuoi;
        }
        // property - dùng để gán và lấy giá trị cho các thuộc tính
        // get - lấy giá trị
        // set - gán giá trị
        public string Mahv { get => mahv; set => mahv = value; }
        public string Ten { get => ten; set => ten = value; }
        public int Tuoi { get => tuoi; set => tuoi = value; }
        public void InThongTin()
        {// $ - đánh dấu, có thể gọi các biến vào trong chuỗi
            Console.WriteLine($"tôi tên là: {ten}");
            Console.WriteLine($"tôi {tuoi} tuổi");
            Console.WriteLine($"tôi có mã là {mahv}");
        }
        public void Inthongtinnamsinh()
        {
            Console.WriteLine($"tôi tên là: {ten}");
            Console.WriteLine($"tôisinh năm {DateTime.Now.Year - tuoi}");
            Console.WriteLine($"tôi có mã là {mahv}");
        }
        public virtual void Lambaitap()// để ghi đè cần thêm từ khóa virtual
        {
            Console.WriteLine("làm bài tập, khó quá thì bỏ");
        }
    }
}
