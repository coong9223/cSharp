using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lasttest_beforeexam
{
    internal class services
    {
        List<bike> bikes;//quản lý và lưu trữ 1 kiểu dữ liệu trong 1 collection
        //ArrayList: dùng để quản lý và lưu trữ nhiều kiểu dữ liệu trong 1 collection
        public services()
        {
        }
        public services(List<bike> bikes)
        {
            this.Bikes = bikes;
        }
        internal List<bike> Bikes { get => bikes; set => bikes = value; }
        public bike NhapTT()
        {
            Console.WriteLine("Mời nhập thông tin xe:");
            Console.WriteLine("tên: ");
            string name = Console.ReadLine();
            Console.WriteLine("mã: ");
            int Id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("hsx: ");
            string Hsx = Console.ReadLine();
            bike bk = new bike(Id, name, Hsx);
            return bk;
        }
        public void NhapDS()
        {
            Console.WriteLine("mời nhập số lượng phần tử: ");
            int x=Convert.ToInt32(Console.ReadLine());
            for(int i = 0; i < x; i++)
            {
                bike bk = NhapTT();
                bikes.Add(bk);
            }
            Console.WriteLine("bạn có muốn nhập tiếp hay ko, 1 để nhập tiếp!");
            string nhaptiep=Console.ReadLine();
            if (nhaptiep == "1")
            {
                NhapDS();
            }
        }
        public void XuatDS()
        {
        foreach(var bike in Bikes)
            {
                bike.InThongTin();
            }
        }
        public void HONDA()
        {
            int dem=0;
            foreach (var bike in Bikes)
            {
                if(bike.HSX1 == "Honda")
                {
                    bike.InThongTin();
                    dem++;
                }               
            }
            if (dem == 0)
            {
                Console.WriteLine("đéo có xe nào của honda");
            }
        }
        public void sapxep()
        { 
            var x=bikes.OrderByDescending(p => p.ID1).ToList();//giảm dần
            //var x=bikes.OrderByDescending(p => p.ID1).ToList(); tăng dần
            foreach (var bike in Bikes)
            {
                bike.InThongTin();
            }
        }
        public void Kethua()
        {
            bike bk=new bike(6,"ksajflkj","suzuki");
            bk.InThongTin();
        }
    }
}
