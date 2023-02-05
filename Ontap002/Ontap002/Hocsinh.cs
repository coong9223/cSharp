using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ontap002
{
    class Hocsinh
    {
        // Public - Mọi nơi
        // Private - Chỉ trong class chứa nó - Mặc định
        // internal - trong cùng 1 assembly
        // protected - trong class cha và các class con kế thừa từ nó
        // protected internal - trong cùng assembly và các lớp con kế thừa
        private string mahs = "acasc";
        private string tenhs;
        private int tuoi;

        public Hocsinh() //Constructor - Hàm tạo - Dùng để khởi tạo đối tượng
        {
            // Không tham số - tạo đối tượng với giá trị mặc định
        }

        public Hocsinh(string mahs, string tenhs, int tuoi)
        { // Có tham số - tạo đối tượng với các giá trị có sẵn => truyền vào
            this.Mahs = mahs; // this => chính là class
            this.Tenhs = tenhs;
            this.Tuoi = tuoi;
        }
        // Property => public & có get, set để lấy giá trị và gán giá trị (thuộc tính)
        public string Mahs { get => mahs; set => mahs = value; }
        public string Tenhs { get => tenhs; set => tenhs = value; }
        public int Tuoi { get => tuoi; set => tuoi = value; }

        public void InThongTin()
        {// $ đánh dấu việc có thể gọi được trực tiếp biến vào trong string
            Console.WriteLine($"Tên tôi là {tenhs}," +
                $" mã của tôi là {mahs}, tôi {tuoi} tuổi");
        }

        public virtual void ABC() // Phải có từ khóa virtual để có thể được ghi đè
        {

        }
    }
}
