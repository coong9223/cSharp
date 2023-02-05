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
    public class NhanVienService : INhanVienService
    {
        INhanVienRepository _iNhanVienRepository;
        public NhanVienService()
        {
            _iNhanVienRepository = new NhanVienRepository();
        }
        public string Add(NhanVienView obj)
        {
            if (obj == null)
                return "Them that bai";
            var sp = new NhanVien()
            {
                Id = obj.Id,
                Ma = obj.Ma,
                Ten = obj.Ten,
                TenDem = obj.TenDem,
                Ho = obj.Ho,
                GioiTinh = obj.GioiTinh,
                NgaySinh = obj.NgaySinh,
                Sdt = obj.Sdt,
                DiaChi = obj.DiaChi,
                MatKhau = obj.MatKhau,

                TrangThai = obj.TrangThai,
            };
            if (_iNhanVienRepository.Add(sp))
            {
                return "Them thanh cong";
            }
            return "Them that bai";
        }

        public string Delete(NhanVienView obj)
        {
            if (obj == null) return "Xoa that bai";
            var cv = _iNhanVienRepository.GetAll().FirstOrDefault(c => c.Id == obj.Id);

            if (_iNhanVienRepository.Delete(cv))
            {
                return "Xoa thanh cong";
            }
            return "Xoa that bai";
        }

        public string Update(NhanVienView obj)
        {
            if (obj == null) return "Sua that bai";
            var ms = _iNhanVienRepository.GetAll().FirstOrDefault(c => c.Id == obj.Id);
            ms.Ma = obj.Ma;
            ms.Ten = obj.Ten;
            ms.TenDem = obj.TenDem;
            ms.Ho = obj.Ho;
            ms.GioiTinh = obj.GioiTinh;
            ms.NgaySinh = obj.NgaySinh;
            ms.Sdt = obj.Sdt;
            ms.DiaChi = obj.DiaChi;
            ms.MatKhau = obj.MatKhau;

            ms.TrangThai = obj.TrangThai;
            if (_iNhanVienRepository.Update(ms))
            {
                return "Sua thanh cong";
            }
            return "Sua that bai";
        }
        public List<NhanVienView> GetAll()
        {
            List<NhanVienView> lst = new List<NhanVienView>();
            lst =
                (
                from a in _iNhanVienRepository.GetAll()
                select new NhanVienView()
                {
                    Id = a.Id,
                    Ma = a.Ma,
                    Ten = a.Ten,
                    TenDem = a.TenDem,
                    Ho = a.Ho,
                    GioiTinh = a.GioiTinh,
                    NgaySinh = (DateTime)a.NgaySinh,
                    Sdt = a.Sdt,
                    DiaChi = a.DiaChi,
                    MatKhau = a.MatKhau,
                    TrangThai = a.TrangThai,
                }
                ).ToList();
            return lst;
        }

        public List<NhanVienView> GetAll(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return GetAll();
            }

            return GetAll().Where(c => c.Ma.ToLower().StartsWith(input.ToLower()) || c.Ten.ToLower().StartsWith(input.ToLower())).ToList();
        }


        public NhanVien GetById(Guid id)
        {
            return _iNhanVienRepository.GetAll().FirstOrDefault(c => c.Id == id);
        }

        public Guid GetIdByName(string name)
        {
            return GetAll().FirstOrDefault(c => c.Ten == name).Id;
        }

        public List<string> TrangThai()
        {
            return new List<string>() { "Hoat dong", "Khong hoat dong" };
        }
    }
}
