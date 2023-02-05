using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThaoTacVoiFile
{
    public class SinhVien
    {
        public SinhVien(string maSV, string ten, int tuoi, float diem)
        {
            this.maSV = maSV;
            Ten = ten;
            Tuoi = tuoi;
            Diem = diem;
        }

        public string maSV { get; set; }
        public string Ten { get; set; }
        public int Tuoi { get; set; }
        public float Diem { get; set; }

        public SinhVien()
        {
        }

        public void InTT()
        {
            Console.WriteLine($"Mssv: {maSV}, Tên: {Ten}, Tuổi: {Tuoi}, điểm: {Diem}");
        }

    }
}
