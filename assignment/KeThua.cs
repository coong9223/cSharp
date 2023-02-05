using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment
{
    internal class KeThua:SinhVien
    {
        string n = "Công dz";

        public KeThua()
        {
        }

        public KeThua(string n, string id, string name, string sdt, string msv, string email, double mark)
            :base(id, name, sdt, msv, email, mark)
        {
            this.N = n;
        }
        public string N { get => n; set => n = value; }

        public void InThongTinThem()
        {
            base.InThongTin();
        }

        public override void GhiDe()
        {
            Console.WriteLine("đã ghi đè nội dung: "+N); 
        }
    }
    
}
