using _1.DAL.DomainModels;
using _1.DAL.IRepositories;
using _1.DAL.Repositories;
using _2.BUS.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.Services
{
    public class CuaHangService : ICuaHangService
    {
        private ICuaHangRepository _iCuaHangRepository;
        List<CuaHang> _lstCuaHang;
        public CuaHangService()
        {
            _iCuaHangRepository = new CuaHangRepository();
            _lstCuaHang = new List<CuaHang>();
            GetDataFromDb();
        }
        private void GetDataFromDb()
        {
            _lstCuaHang = _iCuaHangRepository.GetAll();
        }
        public string Add(CuaHang obj)
        {
            if (obj == null) return "thêm thất bại";
            var cuaHang = obj;
            if (_iCuaHangRepository.Add(cuaHang))
            {
                GetDataFromDb();
                return "thêm thành công";
            }
            return "thêm thất bại";
        }

        public string Delete(CuaHang obj)
        {
            if (obj == null) return "xóa thất bại";
            var cuaHang = obj;
            if (_iCuaHangRepository.Delete(cuaHang))
            {
                GetDataFromDb();
                return "xóa thành công";
            }
            return "xóa thất bại";
        }

        public List<CuaHang> GetAll()
        {
            return _lstCuaHang;
        }

        public List<CuaHang> GetAll(string input)
        {
            if (string.IsNullOrEmpty(input)) return GetAll();
            return _lstCuaHang.Where(c => c.Ma.ToLower().StartsWith(input.ToLower()) || c.Ten.ToLower().StartsWith(input.ToLower())).ToList();
        }

        public string Update(CuaHang obj)
        {
            if (obj == null) return "sửa thất bại";
            var cuaHang = obj;
            if (_iCuaHangRepository.Update(cuaHang))
            {
                GetDataFromDb();
                return "sửa thành công";
            }
            return "sửa thất bại";
        }
        public List<string> GetThanhPhos()
        {
            return new List<string>() { "Hà Nội", "Hải Phòng", "Hải Dương", "Hồ Chí Minh", "Đà Nẵng", "Vũng Tàu", "Quảng Ninh" };
        }

        public CuaHang GetById(Guid id)
        {
            return _lstCuaHang.FirstOrDefault(c => c.Id == id);
        }

        public Guid GetIdByName(string input)
        {
            return _lstCuaHang.Where(x => x.Ten == input).Select(x => x.Id).FirstOrDefault();
        }
    }
}
