using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Congnt_PH27488
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

        public void inThongTin()
        {
            Console.WriteLine($"id: {ID}, tên: {Ten}, số kỳ học: {SoKyHoc}");
        }
    }
}
