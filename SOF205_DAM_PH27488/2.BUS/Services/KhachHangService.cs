using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1.DAL.DomainClass;
using _1.DAL.iRepositories;
using _1.DAL.Repositories;
using _2.BUS.iServices;
using _2.BUS.ViewModels;

namespace _2.BUS.Services
{
    public class KhachHangService:iKhachHangService
    {
        private iKhachHangRepository iKhRepo;
        public KhachHangService()
        {
            iKhRepo = new KhachHangRepository();
        }

        public string Add(KhachHangView obj)
        {
            if (obj == null) return "that bai";
            var kh = new KhachHang()
            {
                Id = obj.id,
                Ma = obj.ma,
                Ten = obj.ten,
                TenDem = obj.tenDem,
                Ho = obj.ho,
                NgaySinh = obj.ngSinh,
                Sdt = obj.sdt,
                DiaChi = obj.diaChi,
                ThanhPho = obj.thanhPho,
                QuocGia = obj.quocGia,
                MatKhau = obj.matKhau,
            };
            if (iKhRepo.Add(kh)) return "thanh cong";
            return "that bai";
        }

        public string Delete(KhachHangView obj)
        {
            if (obj == null) return "that bai";
            var temp = iKhRepo.GetAllKh().FirstOrDefault(c => c.Id == obj.id);
            if (iKhRepo.Delete(temp)) return "thanh cong";
            return "that bai";
        }

        public List<KhachHangView> GetAllKh()
        {
            List<KhachHangView>lst=new List<KhachHangView> ();
            lst = (from a in iKhRepo.GetAllKh()
                   select new KhachHangView()
                   {
                       id = a.Id,
                       ma = a.Ma,
                       ten = a.Ten,
                       tenDem = a.TenDem,
                       ho = a.Ho,
                       ngSinh = a.NgaySinh.Value,
                       sdt = a.Sdt,
                       diaChi = a.DiaChi,
                       thanhPho = a.ThanhPho,
                       quocGia = a.QuocGia,
                       matKhau = a.MatKhau,
                   }).ToList();
            return lst;
        }

        public List<KhachHangView> GetAllKh(string input)
        {
            if (string.IsNullOrEmpty(input)) return GetAllKh();
            return GetAllKh().Where(c => c.ma.ToLower().StartsWith(input.ToLower()) || c.ten.StartsWith(input.ToLower())).ToList();
        }

        public KhachHang GetById(Guid id)
        {
            return iKhRepo.GetAllKh().FirstOrDefault(c => c.Id == id);
        }

        public Guid GetIdByName(string ten)
        {
            return iKhRepo.GetAllKh().FirstOrDefault(c => c.Ten == ten).Id;
        }

        public string Update(KhachHangView obj)
        {
            if (obj == null) return "that bai";
            var temp = iKhRepo.GetAllKh().FirstOrDefault(c => c.Id == obj.id);
            temp.Ma = obj.ma;
            temp.Ten = obj.ten;
            temp.TenDem = obj.tenDem;
            temp.Ho = obj.ho;
            temp.NgaySinh = obj.ngSinh;
            temp.Sdt = obj.sdt;
            temp.DiaChi = obj.diaChi;
            temp.ThanhPho = obj.thanhPho;
            temp.QuocGia = obj.quocGia;
            temp.MatKhau = obj.matKhau;
            if (iKhRepo.Update(temp)) return "thanh cong";
            return "that bai";
        }

        List<string> iKhachHangService.GetQuocGia()
        {
            return new List<string> { "Vietnam", "Singapore" };
        }

        List<string> iKhachHangService.GetThanhPho()
        {
            return new List<string> { "Hanoi", "Thanhhoa", "Thaibinh", "Hoabinh" };
        }
    }
}
