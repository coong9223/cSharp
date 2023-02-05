using BAI_1_6_CRUD_EF_DBFIRST.DomainModels;
using BAI_1_6_CRUD_EF_DBFIRST.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BAI_1_6_CRUD_EF_DBFIRST.Services
{
    public class QLCuaHangService
    {
        List<CuaHang> _lstCuaHangs;
        CuaHangRepository _CHrepository;

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

        public string Add(CuaHang obj)
        {
            if (_CHrepository.Add(obj))
            {
                GetDataFromDB();
                return "thêm thành công";
            }
            return "thêm thất bại";
        }

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
                return "sửa thành công";
            }
            return "sửa thất bại";
        }

        public string Delete(CuaHang obj)
        {
            var temp = _CHrepository.GetAll().FirstOrDefault(c => c.Id == obj.Id);
            if (_CHrepository.Delete(temp))
            {
                GetDataFromDB();
                return "xóa thành công";
            }
            return "xóa thất bại";
        }

        public CuaHang GetCuaHangById(Guid id)
        {
            return _lstCuaHangs.FirstOrDefault(c => c.Id == id);
        }

        public List<CuaHang> GetAllCuaHangs()
        {
            return _lstCuaHangs;
        }

        public List<CuaHang> GetAllCuaHangs(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return GetAllCuaHangs();
            }
            return _lstCuaHangs.Where(c => c.Ma.ToLower().StartsWith(input.ToLower()) || c.Ten.ToLower().StartsWith(input.ToLower())).ToList();
        }

        public List<string> GetAllThanhPhos()
        {
            return new List<string>() { "Hà Nội", "Hải Phòng", "Hải Dương", "Hồ Chí Minh", "Đà Nẵng", "Vũng Tàu", "Quảng Ninh"};
        }
    }
}
