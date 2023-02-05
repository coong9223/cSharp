using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace collection
{
    internal class chicken
    {
        string ten;
        string maulong;
        int tuoi;

        public chicken()
        {
        }

        public chicken(string ten, string maulong, int tuoi)
        {
            this.Ten = ten;
            this.Maulong = maulong;
            this.Tuoi = tuoi;
        }

        public string Ten { get => ten; set => ten = value; }
        public string Maulong { get => maulong; set => maulong = value; }
        public int Tuoi { get => tuoi; set => tuoi = value; }
        public void InThongTin()
        {
            Console.WriteLine($"tên: {ten}, màu lông: {maulong}, tuổi: {tuoi}");
        }
    }
}
