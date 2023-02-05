using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TongQuanWinForm
{
    internal class Class1
    {
        public Guid id { get; set; }//mã tự sinh
        public string name { get; set; }    
        public string tloai { get; set; }

        public List<Class1> GetClass()//lấy danh sách các thuộc tính có trong đối tượng Class1
        {
            return new List<Class1>()//không hiểu 
        {
            new Class1{id=Guid.NewGuid(),name="Cong",tloai="kinh dị"},//khởi tạo từng đối tượng với các thuộc tính tương ứng
            new Class1{id=Guid.NewGuid(),name="Nguyen",tloai="hài hước"},
            new Class1{id=Guid.NewGuid(),name="Thanh",tloai="TrinhTham"},
        };
        }
    }
    

}
