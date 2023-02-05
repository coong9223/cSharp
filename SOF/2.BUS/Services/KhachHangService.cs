using _1.DAL.DomainClass;
using _1.DAL.IRepositories;
using _1.DAL.Repositories;
using _2.BUS.IServices;
using _2.BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.Services
{
    public class KhachHangService : IKhachHangService
    {
        IKhachHangRepository _iKhachHangRepository;
        public KhachHangService()
        {
            _iKhachHangRepository = new KhachHangRepository();
        }
        public string Add(KhachHangView obj)
        {
            if (obj == null)
                return "Them that bai";
            var sp = new KhachHang()
            {
                Id = obj.Id,
                Ma = obj.Ma,
                Ten = obj.Ten,
                TenDem = obj.TenDem,
                Ho = obj.Ho,
                NgaySinh = obj.NgaySinh,
                Sdt = obj.Sdt,
                DiaChi = obj.DiaChi,
                ThanhPho = obj.ThanhPho,
                QuocGia = obj.QuocGia,
                MatKhau = obj.MatKhau,

            };
            if (_iKhachHangRepository.Add(sp))
            {
                return "Them thanh cong";
            }
            return "Them that bai";
        }

        public string Delete(KhachHangView obj)
        {
            if (obj == null) return "Xoa that bai";
            var cv = _iKhachHangRepository.GetAll().FirstOrDefault(c => c.Id == obj.Id);

            if (_iKhachHangRepository.Delete(cv))
            {
                return "Xoa thanh cong";
            }
            return "Xoa that bai";
        }

        public List<KhachHangView> GetAll()
        {
            List<KhachHangView> lst = new List<KhachHangView>();
            lst =
                (
                from a in _iKhachHangRepository.GetAll()
                select new KhachHangView()
                {
                    Id = a.Id,
                    Ma = a.Ma,
                    Ten = a.Ten,
                    TenDem = a.TenDem,
                    Ho = a.Ho,
                    NgaySinh = (DateTime)a.NgaySinh,
                    Sdt = a.Sdt,
                    DiaChi = a.DiaChi,
                    ThanhPho = a.ThanhPho,
                    QuocGia = a.QuocGia,
                    MatKhau = a.MatKhau,
                }
                ).ToList();
            return lst;
        }

        public List<KhachHangView> GetAll(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return GetAll();
            }

            return GetAll().Where(c => c.DiaChi.ToLower().StartsWith(input.ToLower()) || c.Ten.ToLower().StartsWith(input.ToLower())).ToList();
        }

        public KhachHang GetById(Guid id)
        {
            return _iKhachHangRepository.GetAll().FirstOrDefault(c => c.Id == id);

        }

        public Guid GetIdByName(string name)
        {
            return GetAll().FirstOrDefault(c => c.Ten == name).Id;

        }

        public string Update(KhachHangView obj)
        {
            if (obj == null) return "Sua that bai";
            var ms = _iKhachHangRepository.GetAll().FirstOrDefault(c => c.Id == obj.Id);
            ms.Ma = obj.Ma;
            ms.Ten = obj.Ten;
            ms.TenDem = obj.TenDem;
            ms.Ho = obj.Ho;
            ms.NgaySinh = obj.NgaySinh;
            ms.Sdt = obj.Sdt;
            ms.DiaChi = obj.DiaChi;
            ms.ThanhPho = obj.ThanhPho;
            ms.QuocGia = obj.QuocGia;
            ms.MatKhau = obj.MatKhau;

            if (_iKhachHangRepository.Update(ms))
            {
                return "Sua thanh cong";
            }
            return "Sua that bai";
        }
    }
}
