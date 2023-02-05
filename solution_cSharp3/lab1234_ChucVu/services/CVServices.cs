using System;
using System.Collections.Generic;
using System.Text;
using lab1234_ChucVu.DomainClass;
using lab1234_ChucVu.repositories;
using System.Linq;

namespace lab1234_ChucVu.services
{
    public class CVServices
    {
        private List<ChucVu> _lstCV;//khởi tạo đối tượng mới
        private CVRepositories _cvRepo;
        public CVServices()
        {
            _lstCV = new List<ChucVu>();//cho phép sử dụng
            _cvRepo = new CVRepositories();
            GetALL();
        }
        private void GetALL()
        {
            _lstCV = _cvRepo.GetAll();//listcv=tất cả các thuộc tính của repo
        }
        public string Add(ChucVu obj)
        {
            if (_cvRepo.Add(obj))
            {
                GetALL();
                return "thêm thành công";
            }
            return "thêm thất bại";
        }
        public string Update(ChucVu obj)
        {
            var temp = _cvRepo.GetAll().FirstOrDefault(c => c.Id == obj.Id);
            temp.Ma=obj.Ma;
            temp.Ten=obj.Ten;
            if (_cvRepo.Update(obj))
            {
                GetALL();
                return "sửa thành công";
            }
            return "sửa thất bại";
        }
        public string Delete(ChucVu obj)
        {
            var temp = _cvRepo.GetAll().FirstOrDefault(c => c.Id == obj.Id);
            if (_cvRepo.Delete(obj))
            {
                GetALL();
                return "xóa thành công";
            }
            return "xóa thất bại";
        }
        public string Clear(ChucVu obj)
        {
            if (_cvRepo.Clear(obj))
            {
                GetALL();
                return "dọn thành công";
            }
            return "dọn thất bại";
        }

        public ChucVu GetCuaHangById(Guid id)
        {
            return _lstCV.FirstOrDefault(c => c.Id == id);
        }

        public List<ChucVu> GetAlls()//Trả về danh sách các cửa hàng
        {
            return _lstCV;
        }

        //Tìm kiếm gần đúng theo nhiều thuộc tính
        public List<ChucVu> GetAlls(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return GetAlls();
            }

            return _lstCV.Where(c => c.Ma.ToLower().StartsWith(input.ToLower()) || c.Ten.ToLower().StartsWith(input.ToLower())).ToList();
        }
    }
    
}
