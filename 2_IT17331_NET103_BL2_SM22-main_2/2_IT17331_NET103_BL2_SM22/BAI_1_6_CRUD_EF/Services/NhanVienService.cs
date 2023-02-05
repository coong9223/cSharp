using BAI_1_6_CRUD_EF.DomainClass;
using BAI_1_6_CRUD_EF.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BAI_1_6_CRUD_EF.Services
{
    public class NhanVienService
    {

        private List<NhanVien> _lstNhanViens;
        private NhanVienRepository _NVrepository;
        private ChucVuRepository _CVrepository;
        private CuaHangRepository _CHrepository;


        public NhanVienService()
        {
            _lstNhanViens = new List<NhanVien>();
            _NVrepository = new NhanVienRepository();
            _CVrepository = new ChucVuRepository();
            _CHrepository = new CuaHangRepository();
            GetDataFromDB();
        }

        private void GetDataFromDB() {
            _lstNhanViens = _NVrepository.GetAll();
        }

        public string Add(NhanVien obj)
        {
            if (_NVrepository.Add(obj))
            {
                GetDataFromDB();
                return "Thêm thành công";
            }

            return "Thêm thất bại";
        }

        public string Update(NhanVien obj)
        {
            var temp = _NVrepository.GetAll().FirstOrDefault(c => c.Id == obj.Id);
            temp.Ma = obj.Ma;
            temp.Ho = obj.Ho;
            temp.TenDem = obj.TenDem;
            temp.Ten = obj.Ten;
            temp.GioiTinh = obj.GioiTinh;
            temp.NgaySinh = obj.NgaySinh;
            temp.DiaChi = obj.DiaChi;
            temp.Sdt = obj.Sdt;
            temp.MatKhau = obj.MatKhau;
            temp.IdCv = obj.IdCv;
            temp.IdCh = obj.IdCh;
            temp.IdGuiBc = obj.IdGuiBc;
            temp.TrangThai = obj.TrangThai;


            if (_NVrepository.Update(temp))
            {
                GetDataFromDB();
                return "Sửa thành công";
            }

            return "Sửa thất bại";
        }


        public string Delete(NhanVien obj)
        {
            var temp = _NVrepository.GetAll().FirstOrDefault(c => c.Id == obj.Id);
            if (_NVrepository.Delete(temp))
            {
                GetDataFromDB();
                return "Xóa thành công";
            }

            return "Xóa thất bại";
        }

        

        public NhanVien GetNhanVienById(Guid id) { return _lstNhanViens.FirstOrDefault(c => c.Id == id); }
        public List<NhanVien> GetAllNhanViens() { return _lstNhanViens; }

        public List<NhanVien> GetAllNhanViens(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return GetAllNhanViens();
            }

            return _lstNhanViens.Where(c => c.Ma.ToLower().StartsWith(input.ToLower()) || c.Ten.ToLower().StartsWith(input.ToLower()) || c.IdCv.ToString().Equals(input) || c.IdCh.ToString().Equals(input)).ToList();
        }

        public List<string> TrangThai()
        {
            return new List<string>() {"Không hoạt động", "Hoạt động" };
        }

        public List<ChucVu> GetChucVu() 
        {
            return _CVrepository.GetAll();
        }

        public List<CuaHang> GetCuaHang()
        {
            return _CHrepository.GetAll();
        }
        
        
        public string CheckMa(string ma)
        {
            int x = 1;
            foreach (var item in GetAllNhanViens())
            {
                if (item.Ma == ma)
                {
                    return ma + x;
                    x++;
                    continue;
                }
            }
            return ma;
        }

        public List<NhanVien> GetNhanVienTheoCV(string macv) 
        {
            Guid id = GetChucVu().FirstOrDefault(c => c.Ma == macv).Id;
            return _NVrepository.GetAll().Where(c => c.IdCv == id).ToList();
        }
    }
}
