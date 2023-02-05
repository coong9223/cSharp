using BAI_1_6_CRUD_EF_DBFIRST.DomainModels;
using BAI_1_6_CRUD_EF_DBFIRST.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BAI_1_6_CRUD_EF_DBFIRST.Services
{
    public class QLNhanVienService
    {
        List<NhanVien> _lstNhanVien;
        NhanVienRepository _nvRepository;
        ChucVuRepository _cvRepository;
        CuaHangRepository _chRepository;
        public QLNhanVienService()
        {
            _lstNhanVien = new List<NhanVien>();
            _nvRepository = new NhanVienRepository();
            _cvRepository = new ChucVuRepository();
            _chRepository = new CuaHangRepository();
            GetDataFromDB();
        }
        private void GetDataFromDB()
        {
            _lstNhanVien = _nvRepository.GetAll();
        }
        public string Add(NhanVien nhanvien)
        {
            if (_nvRepository.Add(nhanvien))
            {
                GetDataFromDB();
                return "thêm thành công";
            }
            return "thêm thất bại";
        }
        public string Update(NhanVien nhanvien)
        {
            var temp = _nvRepository.GetAll().FirstOrDefault(c => c.Id == nhanvien.Id);
            temp.Ma = nhanvien.Ma;
            temp.Ten = nhanvien.Ten;
            temp.TenDem = nhanvien.TenDem;
            temp.Ho = nhanvien.Ho;
            temp.GioiTinh = nhanvien.GioiTinh;
            temp.NgaySinh = nhanvien.NgaySinh;
            temp.DiaChi = nhanvien.DiaChi;
            temp.Sdt = nhanvien.Sdt;
            temp.MatKhau = nhanvien.MatKhau;
            temp.IdCv = nhanvien.IdCv;
            temp.IdCh = nhanvien.IdCh;
            temp.IdGuiBc = nhanvien.IdGuiBc;
            temp.TrangThai = nhanvien.TrangThai;
            if (_nvRepository.Update(temp))
            {
                GetDataFromDB();
                return "sửa thành công";
            }
            return "sửa thất bại";
        }
        public string Delete(NhanVien nhanvien)
        {
            var temp = _nvRepository.GetAll().FirstOrDefault(c => c.Id == nhanvien.Id);
            if (_nvRepository.Delete(temp))
            {
                GetDataFromDB();
                return "xóa thành công";
            }
            return "xóa thất bại";
        }
        public List<NhanVien> GetAllNhanVien()
        {
            return _lstNhanVien;
        }
        public List<NhanVien> GetAllNhanVien(string input)
        {
            if (string.IsNullOrEmpty(input)) return GetAllNhanVien();
            return _lstNhanVien.Where(c => c.Ma.ToLower().StartsWith(input.ToLower()) || c.Ten.ToLower().StartsWith(input.ToLower()) || c.IdCv.ToString().Equals(input)|| c.IdCh.ToString().Equals(input)).ToList(); // || c.IdCv == TimIdChucVu(input) || c.IdCh == TimIdCuaHang(input)
            //return _lstNhanVien.Where(c => c.Ma.ToLower().StartsWith(input.ToLower()) || c.Ten.ToLower().StartsWith(input.ToLower()) || c.IdCv == GetChucVus().FirstOrDefault(c=>c.Ten.ToLower().StartsWith(input.ToLower())).Id|| c.IdCh == GetCuaHangs().FirstOrDefault(c => c.Ten.ToLower().StartsWith(input.ToLower())).Id).ToList();
        }
        public List<NhanVien> GetAllNhanVienTheoChucVu(string input)
        {
            Guid Id = GetChucVus().FirstOrDefault(c => c.Ma == input || c.Ten.ToLower().StartsWith(input)).Id;
            return _nvRepository.GetAll().Where(c => c.IdCv == Id).ToList();
        }
        public List<NhanVien> GetAllNhanVienTheoCuaHang(string input)
        {
            Guid Id = GetCuaHangs().FirstOrDefault(c => c.Ma == input || c.Ten.ToLower().StartsWith(input)).Id;
            return _nvRepository.GetAll().Where(c => c.IdCh == Id).ToList();
        }
        public List<String> TrangThai()
        {
            return new List<String>() { "Không Hoạt Động", "Hoạt Động" };
        }
        public Guid TimIdChucVu(string input)
        {
            return GetChucVus().FirstOrDefault(c => c.Ten.ToLower().StartsWith(input.ToLower())).Id;
        }
        public Guid TimIdCuaHang(string input)
        {
            return GetCuaHangs().FirstOrDefault(c => c.Ten.ToLower().StartsWith(input.ToLower())).Id;
        }
        public List<ChucVu> GetChucVus()
        {
            return _cvRepository.GetAll();
        }
        public List<CuaHang> GetCuaHangs()
        {
            return _chRepository.GetAll();
        }
    }
}
