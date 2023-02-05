using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c2_ôn_tập_về_hàm
{
    internal class test
    {
        //1. thuộc tính:
        private string name="abc";//set giá trị ngoài constructor
        private int age;

        //2. constructor: hàm tạo dùng để khởi tạo đối tượng
        //constructor không tham số: khởi tạo đối tượng với các giá trị mặc định
        public test()
        {//set giá trị mặc định trong constructor
            Name = "xin chào";//được ưu tiên hơn nếu có cả 2
            Age = 30;
        }
        //constructor có tham số: khởi tạo đối tượng với các giá trị được truyền vào
        public test(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }
        //3. property: 
        public string Name { get => name; set => name = value; }
        public int Age { get => age; set => age = value; }
        //get: lấy giá trị của thuộc tính
        //set: gán giá trị cho thuộc tính

        //4. phương thức:
        public void InThongiTin()
        {
            Console.WriteLine($"xin chào tôi tên là {name} và tôi {age} tuổi");
            Console.WriteLine($"xin chào tôi tên là {Name} và tôi {Age} tuổi");
        }

        //5. ghi đè: tái định nghĩa lại phương thức (viết lại)
        //abtract chỉ có thể dùng trong class abtract, có tính trừu tượng
        public virtual void GhiDe()
        {
            Console.WriteLine("abc");
        }
        
    }
}
