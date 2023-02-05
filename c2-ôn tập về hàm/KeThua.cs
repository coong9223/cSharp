using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c2_ôn_tập_về_hàm
{
    internal class KeThua:test//kế thừa tất cả thành phần của lớp cha
    {
        string content="Nguyễn Thành Công";

        public KeThua()
        {
        }

        public KeThua(string content, string name, int age): base(name, age)
        {
            //this.Name = name;
            this.Content = content;
        }

        public string Content { get => content; set => content = value; }//có 3 thuộc tính vì lấy cả thuộc tính của lớp cha
        public void ABC()
        {
            base.InThongiTin();//kế thừa phương thức
        }
        public override void GhiDe()
        {
            Console.WriteLine("Tôi đã ghi đè và có thêm nội dung"+ Content);
        }

        //overload
        public void DocBai(string a, string b, int c)
        {
            Console.WriteLine("Linh tinh");
        }
        public void DocBai(string a, int c, string b) 
        {
            Console.WriteLine(Content);
        }
    }
}
