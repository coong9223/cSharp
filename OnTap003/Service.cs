using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnTap003
{
    internal class Service
    {
        List<HocSinh> hocsinhs;

        public Service()
        {
        }

        public Service(List<HocSinh> hocsinhs)
        {
            this.Hocsinhs = hocsinhs;
        }

        internal List<HocSinh> Hocsinhs { get => hocsinhs; set => hocsinhs = value; }
        public void NhapDS()
        {
            Console.WriteLine("bạn muốn nhập bao nhiêu học sinh");
            int soluong = Convert.ToInt32(Console.ReadLine());
            while(soluong > 0)
            {
                Console.WriteLine("nhập tên");
                string ten=Console.ReadLine();
                Console.WriteLine("nhập mã");
                string ma = Console.ReadLine();
                Console.WriteLine("nhập tuổi");
                int tuoi = Convert.ToInt32(Console.ReadLine());
                //tạo đối tượng bằng constructor có tham số
                HocSinh hs = new HocSinh(ma, ten, tuoi);
                hocsinhs.Add(hs);
                soluong--;//mỗi lần nhập 1 dinh viên thì số lần chạy giảm đi 1
            }
            Console.WriteLine("bạn muốn nhập tiếp hay không? 1 để tiếp, còn lại thì không");
            string nhaptiep = Console.ReadLine();
            if (nhaptiep == "1")
            {
                NhapDS();
            }
        }
        public void XuatDS()
        {
            foreach(var item in hocsinhs)
            {
                item.InThongTin();
            }
        }
        public void Timtheoma()
        {
            Console.WriteLine("nhập mã muốn tìm");
            string ma = Console.ReadLine();
            bool timthay = false;
            foreach(var item in hocsinhs)
            {
                if (item.Mahv == ma)
                {
                    item.InThongTin();
                    timthay = true;
                }
            }
            if (!timthay)
            {
                Console.WriteLine("không có đồng chí nào có mã là {0} cả", ma);
            }
        }
    }
}
