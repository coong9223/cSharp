using System;
using HamPhuongThuc_List;

namespace HamPhuongThuc_List
{
    internal class Program
    {
        void Main(string[] args)
        {
            //khởi tạo đối tượng mới
            HamPhuongThuc hp = new HamPhuongThuc();
            hp.HamKhongTraVe();
            hp.HamKhongTraVeChoTruoc(10);
            hp.HamTraVe();
            hp.HamTraVeChoTruoc(13, 18);
        }
        
    }
}
