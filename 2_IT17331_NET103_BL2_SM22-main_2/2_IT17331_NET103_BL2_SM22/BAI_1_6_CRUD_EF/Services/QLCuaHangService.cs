using BAI_1_6_CRUD_EF.DomainClass;
using BAI_1_6_CRUD_EF.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BAI_1_6_CRUD_EF.Services
{
    public class QLCuaHangService
    {
        //Chứa tất cả các chưng năng mà bài toán yêu cầu
        private List<CuaHang> _lstCuaHangs;

        private CuaHangRepository _CHrepository;

        public QLCuaHangService()
        {
            _lstCuaHangs = new List<CuaHang>();
            _CHrepository = new CuaHangRepository();
            GetDataFromDB();
        }

        private void GetDataFromDB()
        {
            _lstCuaHangs = _CHrepository.GetAll();
        }

        //Phương thức thêm mới
        public string Add(CuaHang obj)
        {
            if (_CHrepository.Add(obj))
            {
                GetDataFromDB();
                return "Thêm thành công";
            }

            return "Thêm thất bại";
        }

        //Phương thức sửa
        public string Update(CuaHang obj)
        {
            var temp = _CHrepository.GetAll().FirstOrDefault(c => c.Id == obj.Id);
            temp.DiaChi = obj.DiaChi;
            temp.Ma = obj.Ma;
            temp.QuocGia = obj.QuocGia;
            temp.Ten = obj.Ten;
            temp.ThanhPho = obj.ThanhPho;
            if (_CHrepository.Update(temp))
            {
                GetDataFromDB();
                return "Sửa thành công";
            }

            return "Sửa thất bại";
        }

        //Phương thức Xóa
        public string Delete(CuaHang obj)
        {
            var temp = _CHrepository.GetAll().FirstOrDefault(c => c.Id == obj.Id);
            if (_CHrepository.Delete(temp))
            {
                GetDataFromDB();
                return "Xóa thành công";
            }

            return "Xóa thất bại";
        }

        //Tìm đối tượng thông id
        public CuaHang GetCuaHangById(Guid id)
        {
            return _lstCuaHangs.FirstOrDefault(c => c.Id == id);
        }

        public List<CuaHang> GetAllCuaHangs()//Trả về danh sách các cửa hàng
        {
            return _lstCuaHangs;
        }

        //Tìm kiếm gần đúng theo nhiều thuộc tính
        public List<CuaHang> GetAllCuaHangs(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return GetAllCuaHangs();
            }

            return _lstCuaHangs.Where(c => c.Ma.ToLower().StartsWith(input.ToLower()) || c.Ten.ToLower().StartsWith(input.ToLower())).ToList();
        }

        //Danh sách các thành phố
        public List<string> GetAllThanhPhos()
        {
            return new List<string>() { "HN", "BN", "HP", "ST", "HT" };
        }
    }

}
