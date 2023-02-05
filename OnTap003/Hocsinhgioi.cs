using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnTap003
{
    internal class Hocsinhgioi:HocSinh
    {
        private double diemtrungbinh;
        // số lượng thuộc tính của lớp kế thừa = số lượng của lớp cha + số lượng thêm
        public Hocsinhgioi()
        {
        }

        public Hocsinhgioi(double diemtrungbinh, string mahv, string ten, int tuoi)
            : base(mahv, ten, tuoi)
        {// base là thành phần được kế thừa từ lớp cha
            this.Diemtrungbinh = diemtrungbinh;
        }

        public double Diemtrungbinh { get => diemtrungbinh; set => diemtrungbinh = value; }
        public void ABC()
        {
            base.InThongTin();// kế thừa phương thức
        }
        public override void Lambaitap()//Lambaitap đã bị ghi đè dữ liệu
        {
            Console.WriteLine("là sinh viên giỏi, tôi dẽ cố gắng làm hết");
        }
        public void Phatbieu()
        {
            Console.WriteLine("phát biểu sôi nổi cùng cả lớp");
        }
        public void Phatbieu(string mucdo)
        {
            if(mucdo == "Easy")
            {
                Console.WriteLine("nhường các bạn khác");
            }else if (mucdo == "normal")
            {
                Console.WriteLine("phát biểu và thêm ý kiến");
            }else
            {
                Console.WriteLine("cố gắng tìm hiểu r phát biểu");
            }
        }
        // overload và override => thể hiện tính đa hình của oop
        // override: khác đối tượng, cùng hành động
        // overload: cùng đối tượng, cùng hành động nhưng khác trạng thái
        // các phương thức phải cùng kiểu trả về
    }
}
