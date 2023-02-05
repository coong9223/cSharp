using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment
{
    [Serializable]
    public class SinhVien
    {
        private string Id;
        private string Name;
        private string Sdt;
        private string Msv;
        private string Email;
        private double Mark;

        public SinhVien()
        {
        }

        public SinhVien(string id, string name, string sdt, string msv, string email, double mark)
        {
            Id1 = id;
            Name1 = name;
            Sdt1 = sdt;
            Msv1 = msv;
            Email1 = email;
            Mark1 = mark;
        }

        public string Id1 { get => Id; set => Id = value; }
        public string Name1 { get => Name; set => Name = value; }
        public string Sdt1 { get => Sdt; set => Sdt = value; }
        public string Msv1 { get => Msv; set => Msv = value; }
        public string Email1 { get => Email; set => Email = value; }
        public double Mark1 { get => Mark; set => Mark = value; }
        public void InThongTin()
        {
            Console.WriteLine($"id:{Id}, name:{Name}, sdt:{Sdt}, Msv:{Msv}, Email:{Email}, mark:{Mark}");
        }

        //ghi đè
        public virtual void GhiDe()
        {
            Console.WriteLine("abc");
        }
    }
}
