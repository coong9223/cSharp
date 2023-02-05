using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace thi_2
{
    internal class Manager:NhanVien
    {
        int bonus;

        public Manager()
        {
        }

        public Manager(int bonus, string name, string maNV, int salary):base(name, maNV, salary)
        {
            this.Bonus = bonus;
        }

        public int Bonus { get => bonus; set => bonus = value; }
        
    }
}
