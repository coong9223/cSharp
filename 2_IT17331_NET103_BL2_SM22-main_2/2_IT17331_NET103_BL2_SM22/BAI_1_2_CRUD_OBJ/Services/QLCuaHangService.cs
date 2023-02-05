using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BAI_1_2_CRUD_OBJ.Models;

namespace BAI_1_2_CRUD_OBJ.Services
{
    public class QLCuaHangService
    {
        //Chứa tất cả các chưng năng mà bài toán yêu cầu
        private List<CuaHang> _lstCuaHangs;

        public QLCuaHangService()
        {
            _lstCuaHangs = new List<CuaHang>();
            FakeData();
        }

        private void FakeData()//Đổ data vào list
        {
            _lstCuaHangs = new List<CuaHang>()
            {
                new CuaHang(){Id = Guid.NewGuid(),Ma = "CH01",Ten = "FPT SHOP CẦU GIẤY",DiaChi = "Số 1 tôn thất thuyết",ThanhPho = "Hà Nội",QuocGia = "VN",Status = 1},
                new CuaHang(){Id = Guid.NewGuid(),Ma = "CH02",Ten = "FPT SHOP HQV",DiaChi = "Số 2 tôn thất thuyết",ThanhPho = "Hà Nội",QuocGia = "VN",Status = 0},
                new CuaHang(){Id = Guid.NewGuid(),Ma = "CH03",Ten = "FPT SHOP TDH",DiaChi = "Số 3 tôn thất thuyết",ThanhPho = "Hà Nội",QuocGia = "VN",Status = 1},
                new CuaHang(){Id = Guid.NewGuid(),Ma = "CH04",Ten = "FPT SHOP NKT",DiaChi = "Số 4 tôn thất thuyết",ThanhPho = "Hà Nội",QuocGia = "VN",Status = 2},
            };
        }

        //Phương thức thêm mới
        public string Add(CuaHang obj)
        {
            obj.Id = Guid.NewGuid();//khởi tạo khóa chính trước khi thêm mới
            _lstCuaHangs.Add(obj);
            return "Thêm thành công";
        }

        //Phương thức sửa
        public string Update(CuaHang obj)
        {
            int index = _lstCuaHangs.FindIndex(c => c.Id == obj.Id);
            if (index == -1) return "Sửa không thành công";
            _lstCuaHangs[index] = obj;
            return "Sửa thành công";
        }

        //Phương thức Xóa
        public string Delete(CuaHang obj)
        {
            int index = _lstCuaHangs.FindIndex(c => c.Id == obj.Id);
            if (index == -1) return "Xóa không thành công";
            _lstCuaHangs.RemoveAt(index);
            return "Xóa thành công";
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