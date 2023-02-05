using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using asm_gd1.DomainClass;
using asm_gd1.repositories;


namespace asm_gd1.services
{
    public class AsmServices
    {
        private List<NhanVien> _lst;

        private AsmRepositories _nvRepo;
        

        public AsmServices()
        {
            _lst = new List<NhanVien>();
            _nvRepo = new AsmRepositories();
            GetDataFromDB();
        }

        private void GetDataFromDB()
        {
            _lst = _nvRepo.GetAll();
        }

        //Phương thức thêm mới
        public string Add(NhanVien obj)
        {
            if (_nvRepo.Add(obj))
            {
                GetDataFromDB();
                return "Thêm thành công";
            }

            return "Thêm thất bại";
        }

        //Phương thức sửa
        public string Update(NhanVien obj)
        {
            var temp = _nvRepo.GetAll().FirstOrDefault(c => c.Id == obj.Id);
            temp.DiaChi = obj.DiaChi;
            temp.Ma = obj.Ma;
            temp.Ho = obj.Ho;
            temp.Ten = obj.Ten;
            temp.TenDem = obj.TenDem;
            temp.GioiTinh = obj.GioiTinh;
            temp.NgaySinh = obj.NgaySinh;
            temp.DiaChi = obj.DiaChi;
            temp.Sdt = obj.Sdt;
            temp.MatKhau = obj.MatKhau;
            temp.TrangThai=obj.TrangThai;
            if (_nvRepo.Update(temp))
            {
                GetDataFromDB();
                return "Sửa thành công";
            }
            return "Sửa thất bại";
        }

        //Phương thức Xóa
        public string Delete(NhanVien obj)
        {
            var temp = _nvRepo.GetAll().FirstOrDefault(c => c.Id == obj.Id);
            if (_nvRepo.Delete(temp))
            {
                GetDataFromDB();
                return "Xóa thành công";
            }

            return "Xóa thất bại";
        }

        //Tìm đối tượng thông id
        public NhanVien GetNhanVienById(Guid id)
        {
            return _lst.FirstOrDefault(c => c.Id == id);
        }

        public List<NhanVien> GetAlls()//Trả về danh sách các cửa hàng
        {
            return _lst;
        }

        //Tìm kiếm gần đúng theo nhiều thuộc tính
        public List<NhanVien> GetAlls(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return GetAlls();
            }

            return _lst.Where(c => c.Ma.ToLower().StartsWith(input.ToLower()) || c.Ten.ToLower().StartsWith(input.ToLower())).ToList();
        }

        //Danh sách các thành phố
        public List<string> GetAllCH()
        {
            return new List<string>() { "CH1", "CH2", "CH3", "CH4", "CH5" };
        }
        public List<string> GetAllMaCH()
        {
            return new List<string>() { "Lọc mã cửa hàng","CH01", "CH02", "CH03", "CH04", "CH05" };
        }
        
    }
}
