using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HuongDoiTuong01
{
    internal class Concho
    {
        string giongcho;
        string ten;
        int tuoi;
        string maulong;
        bool gioitinh;
        public Concho()
        {
        }
        public Concho(string giongcho, string ten, int tuoi, string maulong, bool gioitinh)
        {
            this.Giongcho = giongcho;
            this.Ten = ten;
            this.Tuoi = tuoi;
            this.Maulong = maulong;
            this.Gioitinh = gioitinh;
        }

        public string Giongcho { get => giongcho; set => giongcho = value; }
        public string Ten { get => ten; set => ten = value; }
        public int Tuoi { get => tuoi; set => tuoi = value; }
        public string Maulong { get => maulong; set => maulong = value; }
        public bool Gioitinh { get => gioitinh; set => gioitinh = value; }
        public void Sua()
        {
            Console.WriteLine("Chú chó này sủa " + Ten);
        }
        public void NamSinh()
        {
            Console.WriteLine("Năm sinh của chú chó: " + (DateTime.Now.Year - Tuoi));
        }// Datetime.Now = thời điểm hiện tại
        /*
         * Tính đóng gói - bao đóng - Encapsulation: Thể hiện khả năng truy cập đến các thành phần nằm trong class -> Thể hiện qua Access Modifier
         * public: Truy cập được ở mọi nơi
         * private: Chỉ dùng được trong class chứa nó, được sử dụng làm mặc định
         * internal: Chỉ sử dụng trong cùng Assembly 
         * protected: Sử dụng trong Class định nghĩa và các Class con
         * internal protected: Trong cùng Assembly và Class con ở ngoài Assembly
         */

    }
}
