using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using All_cSharp3.DomainClass;
using All_cSharp3.Repositories;

namespace All_cSharp3.Services
{
    public class CuaHangServices
    {
        private List<CuaHang> _lstCuaHang;//Khởi tạo đối tượng
        private CuaHangRepositories _CHRepositories;
        public CuaHangServices()
        {
            _lstCuaHang = new List<CuaHang>();//cho phép sử dụng
            _CHRepositories = new CuaHangRepositories();
        }

        private void GetDataFromDB()
        {
            _lstCuaHang = _CHRepositories.GetAll();//lấy tất cả dữ liệu từ bảng repositories
        }

        public string Add(CuaHang obj)
        {
            if (_CHRepositories.Add(obj))
            {
                GetDataFromDB();//ném vào list
                return "Thêm thành công";
            }

            return "Thêm thất bại";
        }

        //Phương thức sửa
        public string Update(CuaHang obj)
        {
            var temp = _CHRepositories.GetAll().FirstOrDefault(c => c.Id == obj.Id);
            temp.DiaChi = obj.DiaChi;
            temp.Ma = obj.Ma;
            temp.QuocGia = obj.QuocGia;
            temp.Ten = obj.Ten;
            temp.ThanhPho = obj.ThanhPho;
            if (_CHRepositories.Update(temp))
            {
                GetDataFromDB();
                return "Sửa thành công";
            }

            return "Sửa thất bại";
        }

        //Phương thức Xóa
        public string Delete(CuaHang obj)
        {
            var temp = _CHRepositories.GetAll().FirstOrDefault(c => c.Id == obj.Id);
            if (_CHRepositories.Delete(temp))
            {
                GetDataFromDB();
                return "Xóa thành công";
            }

            return "Xóa thất bại";
        }

        public CuaHang GetCuaHangById(Guid id)
        {
            return _lstCuaHang.FirstOrDefault(c => c.Id == id);
        }

        public List<CuaHang> GetAllCuaHangs()//Trả về danh sách các cửa hàng
        {
            return _lstCuaHang;
        }

        //Tìm kiếm gần đúng theo nhiều thuộc tính
        public List<CuaHang> GetAllCuaHangs(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return GetAllCuaHangs();
            }

            return _lstCuaHang.Where(c => c.Ma.ToLower().StartsWith(input.ToLower()) || c.Ten.ToLower().StartsWith(input.ToLower())).ToList();
        }

        //Danh sách các thành phố
        public List<string> GetAllThanhPhos()
        {
            return new List<string>() { "HN", "BN", "HP", "ST", "HT" };//khởi tạo đối tượng mới
        }
    }   
}
