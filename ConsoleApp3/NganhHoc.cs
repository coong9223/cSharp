using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class NganhHoc
    {
        private int ID;
        private string Ten;
        private int SoKyHoc;
        public NganhHoc()
        {
        }
        public NganhHoc(int iD, string ten, int soKyHoc)
        {
            ID1 = iD;
            Ten1 = ten;
            SoKyHoc1 = soKyHoc;
        }
        public int ID1 { get => ID; set => ID = value; }
        public string Ten1 { get => Ten; set => Ten = value; }
        public int SoKyHoc1 { get => SoKyHoc; set => SoKyHoc = value; }
        public virtual void Kethua()
        {
            Console.WriteLine("it 17332");
        }
        public void InThongTin()
        {
            Console.WriteLine($"mã ngành học là: {ID}");
            Console.WriteLine($"tên ngành học là: {Ten}");
            Console.WriteLine($"số kỳ học: {SoKyHoc}");
        }
    }
}
